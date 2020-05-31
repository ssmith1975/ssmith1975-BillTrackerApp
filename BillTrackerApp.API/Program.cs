#define Managed

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using Microsoft.Azure.KeyVault;
using Microsoft.Azure.Services.AppAuthentication;
using Microsoft.Extensions.Configuration.AzureKeyVault;
using Microsoft.Extensions.Hosting;
using System.Configuration;

namespace BillTrackerApp.API
{
    public class Program
    {

        public static void Main(string[] args)
        {

            CreateWebHostBuilder(args).Build().Run();
        }

        public static IWebHostBuilder CreateWebHostBuilder(string[] args) =>
            WebHost.CreateDefaultBuilder(args)
            .ConfigureAppConfiguration((context, config) =>
            {

                var loggerFactory = LoggerFactory.Create(builder =>
                {
                    builder
                        .AddConsole();
                });

                ILogger logger = loggerFactory.CreateLogger<Program>();
                logger.LogInformation("Setting up app configurations...");

                var builtConfig = config.Build();

                try
                {
                    AzureServiceTokenProvider azureServiceTokenProvider;
                    string keyvaultConnectionString = null;
                    string KeyVault = builtConfig["KeyVault"];
                    bool useKey;

                    if (String.IsNullOrEmpty(KeyVault))
                    {
                        throw new ConfigurationErrorsException("'KeyVault' property is missing from configuration");
                    }

                    Boolean.TryParse(builtConfig["UseKey"], out useKey);

                    if (useKey)
                    {
                        List<string> keys = new List<string> { "RunAs", "AppId", "TenantId", "AppKey" };

                        keys.ForEach(key =>
                        {

                            if (String.IsNullOrEmpty(builtConfig[key]))
                            {
                                throw new ConfigurationErrorsException($"'{key}' property is missing from configuration");
                            }

                            keyvaultConnectionString += $"{key}={builtConfig[key]};";
                        }); // end forEach

                    } // end if

                    azureServiceTokenProvider = new AzureServiceTokenProvider(keyvaultConnectionString);

                    var keyVaultClient = new KeyVaultClient(
                        new KeyVaultClient.AuthenticationCallback(
                            azureServiceTokenProvider.KeyVaultTokenCallback));

                    config.AddAzureKeyVault(
                        $"https://{KeyVault}.vault.azure.net/",
                        keyVaultClient,
                        new DefaultKeyVaultSecretManager());

                    logger.LogInformation("Configurations completed successfully...");
                }
                catch (Exception ex)
                {

                    logger.LogError($"Error while retrieving content from key vault:\n\t{ex.Message}\n");
                    logger.LogError(ex.StackTrace);

                    throw ex;
                } // end try/catch

            })
                .UseStartup<Startup>();
    }
}
