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
                var builtConfig = config.Build();    
                
                if (context.HostingEnvironment.IsProduction())
                {

                    string keyvault = builtConfig["keyvault"];
                    string RunAs = builtConfig["RunAs"];
                    string AppId = builtConfig["AppId"];
                    string TenantId = builtConfig["TenantId"];
                    string AppKey = builtConfig["AppKey"];

                    var azureServiceTokenProvider = new AzureServiceTokenProvider(
                        $"RunAs={RunAs};AppId={AppId};TenantId={TenantId};AppKey={AppKey}"
                    );
                    var keyVaultClient = new KeyVaultClient(
                        new KeyVaultClient.AuthenticationCallback(
                            azureServiceTokenProvider.KeyVaultTokenCallback));

                    config.AddAzureKeyVault(
                        $"https://{keyvault}.vault.azure.net/",
                        keyVaultClient,
                        new DefaultKeyVaultSecretManager());
                }
            })
                .UseStartup<Startup>();
    }
}
