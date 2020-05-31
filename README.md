# BillTrackerApp

An application for tracking personal finances monthly.

The back-end is a web service implemented in Web API 2 built on ASP.NET Core 3.1 application. Data is stored in MySQL and utilizes Entity Framework Core 3.1 ORM. Deployed to Azure cloud as an App Service docker Linux container via CI/CD pipeline. Secrets are stored in an Azure Key Vault.

## Installation

Clone this app from GitHub.

In Azure, make sure you create an system principal identity for the app web service and grant it permission to access the vault. Create a connection string as

Create a new secret for the connection string:
Name|Value
------------ | -------------
ConnectionStrings--BillTrackerDBConnection|Server={your database server name}.mysql.database.azure.com; Port=3306; Database={your_database}; Uid={your username}; Pwd={your password}; SslMode=Preferred;
 
*Note the double dashes in the key*

Add Manage User Secrets to store Azure secrets. Include the following in your secrets.json file: 

### Local Environment 
```
{
  "KeyVault": "<your key vault name>",
  "UseKey": "true|false",
  "RunAs": "App",
  "TenantId": "<your tenant id>",
  "AppKey": "<your client secret>",
  "AppId": "<your application id>"
}

```
### Azure App Service Configuration
{
  "KeyVault": "<your key vault name>",
  "UseKey": "false",
}


## Usage



## Contributing
Pull requests are welcome. For major changes, please open an issue first to discuss what you would like to change.

Please make sure to update tests as appropriate.

## License
[MIT](https://choosealicense.com/licenses/mit/)