# Karen Axon Portfolio
This business lookup API lists businesses in the United States. It has CRUD and Cors functionality and successfully returns API calls.

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

## About Cors

 With CORS, a server can specify who can access the assets of an API and which HTTP request methods are allowed from external resources.

![-----------------------------------------------------](https://raw.githubusercontent.com/andreasbm/readme/master/assets/lines/aqua.png)

## About Cors



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
