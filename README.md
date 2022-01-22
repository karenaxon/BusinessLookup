# Business Lookup API
This is a business lookup API. It has Create, Read, Update, and Delete (CRUD) and Cross-Origin Requests (CORS) functionality. It successfully returns API calls.

#### By Karen Axon

![-----------------------------------------------------](https://raw.githubusercontent.com/andreasbm/readme/master/assets/lines/aqua.png)

## Technologies Used
* API
* C#
* Asp.Net Core MVC
* Razor
* .Net 5
* dotnet script, REPL
* MySQL
* HTML
* CSS
* Bootstrap

![-----------------------------------------------------](https://raw.githubusercontent.com/andreasbm/readme/master/assets/lines/aqua.png)

## About CORS

 Browser security prevents a web page from making requests to a different domain. CORS, allows a server to relax the same-origin policy and to specify which HTTP request methods are allowed from external resources. This API uses a named policy to enable CORS. The allowed URLs can be changed in the ConfigureServices method of the Startup.cs file. 

![-----------------------------------------------------](https://raw.githubusercontent.com/andreasbm/readme/master/assets/lines/aqua.png)

## API Endpoints
* Example URL: http://localhost:5000/api/Businesses
* To get a list of all the businesses use: <br>_api/Businesses_
* To look up a business with a specific id number use: <br>_api/Businesses/id_
* To get a set of results based on a given parameter use a key-value pair: <br> _api/Businesses/?name=businessName_
* To get a set of results based on two parameters use the & symbol between each key-value pair: <br>_api/Businesses/?name=businessName&city=cityName_

The parameters available are:
- businessId
- name
- type
- streetAddress
- city
- state
- zipCode

![-----------------------------------------------------](https://raw.githubusercontent.com/andreasbm/readme/master/assets/lines/aqua.png)

## Setup/Installation 

* Install .NET 5.0 [here](https://dotnet.microsoft.com/en-us/download/dotnet/5.0)
* Click on the [repository's](https://github.com/karenaxon/BusinessLookup.git) link.
* Click on the green "Code" button and copy the repository URL.
* Open your terminal and navigate to the location where you would like to clone the application.
* Use the command _git clone https://github.com/karenaxon/BusinessLookup.git_ to clone the repository.
* From the root directory of the application, the BusinessLookup folder, run the following commands:
  - _dotnet restore_
  - _dotnet add package Microsoft.EntityFrameworkCore -v 5.0.0_ 
  - _dotnet add package Pomelo.EntityFrameworkCore.MySql -v 5.0.0-alpha.2_	
  - _dotnet add package Microsoft.EntityFrameworkCore.Design -v 5.0.0_
  -  _dotnet build_		
* Open the application in your favorite text editor to make changes.
* Once you can successfully run _dotnet build_, set up the database.


![-----------------------------------------------------](https://raw.githubusercontent.com/andreasbm/readme/master/assets/lines/aqua.png)


## Setting up the database

After following the Setup/Installation steps above:
* Start a local instance 3306 in MySQL Workbench.
* In the terminal, navigate to the root directory of the application and create an _appsettings.json_ file with the following code (making sure to delete the [ ] and replace the name of the database and the corresponding password):
```
{
  "ConnectionStrings": {
    "DefaultConnection": "Server=localhost;Port=3306;database=[data_base_name];uid=root;pwd=[password];"
  }
}
```
* Run these commands in the root directory:
  - dotnet ef migrations add Initial
  - dotnet ef database update

![-----------------------------------------------------](https://raw.githubusercontent.com/andreasbm/readme/master/assets/lines/aqua.png)


## Using the Application
After following the Setup/Installation steps above and setting up the database: 
  * Navigate to the root directory.
  * Start the application in a server with the command _dotnet run_.	

![-----------------------------------------------------](https://raw.githubusercontent.com/andreasbm/readme/master/assets/lines/aqua.png)

## Known Bugs
* None

![-----------------------------------------------------](https://raw.githubusercontent.com/andreasbm/readme/master/assets/lines/aqua.png)

## License

[MIT](https://choosealicense.com/licenses/mit/)

Copyright (c) January 2022 - Karen Axon

![-----------------------------------------------------](https://raw.githubusercontent.com/andreasbm/readme/master/assets/lines/aqua.png)


## Contact Information:

<h3>Karen Axon</h3>

[![GitHub Badge](https://img.shields.io/badge/GitHub-100000?style=for-the-badge&logo=github&logoColor=white)](https://github.com/karenaxon)
[![LinkedIn Badge](https://img.shields.io/badge/LinkedIn-0077B5?style=for-the-badge&logo=linkedin&logoColor=white)](https://www.linkedin.com/in/kaxon)
