# BillTrackerApp

An application for tracking personal finances monthly.

### Technology

#### Back-end 
* The back-end is a web service implemented in Web API 2 built on ASP.NET Core 3.1 application. 

* Data is stored in MySQL and utilizes Entity Framework Core 3.1 ORM. 

* Builds a Docker image to run on Linux

* Deployed to Azure cloud as an App Service docker Linux container via CI/CD pipeline. 

* Secrets are stored in an Azure Key Vault.

#### Front-end

* Plan on creating a single-page application (SPA) using React 16, coded in TypeScript.

## Installation

Clone this app from GitHub.

In Azure, make sure you create an system principal identity for the app web service and grant it permission to access the vault. Create a connection string as



*Name* | *Value*
---- | -----
ConnectionStrings--BillTrackerDBConnection | Server={your database server name}.mysql.database.azure.com; Port=3306; Database={your_database}; Uid={your username}; Pwd={your password}; SslMode=Preferred;
 
*Note the double dashes in the key*

Add Manage User Secrets to store Azure secrets. Include the following in your secrets.json file: 

### Local Environment 
The purpose of placing these keys in the local development environment is to allow the application (especially in Docker) to access the Key Vault that includes the connection string.

```json
{
  "KeyVault": "<your key vault name>",
  "UseKey": "true", // true|false
  "RunAs": "App",
  "TenantId": "<your tenant id>",
  "AppKey": "<your client secret>",
  "AppId": "<your application id>"
}
```

### Azure App Service Configuration

Publish to Azure App Service

#### Configuration
The keys may not necessarily be needed when running in Azure. The minimum requirements are listed below:
```json
{
  "KeyVault": "<your key vault name>",
  "UseKey": "false",
}
```

## Usage



## Contributing
Pull requests are welcome. For major changes, please open an issue first to discuss what you would like to change.

Please make sure to update tests as appropriate.

## License
[MIT](https://choosealicense.com/licenses/mit/)