# Chocolate Production
Accounting of material and financial resources of a private enterprise for the production of chocolate products.

The project was developed as part of the academic year on the subject of DBMS in the third year of the 2nd semester of the first `module`.

This graphical application was developed on `Windows Forms` in the `C# programming language`

After implementing this work, I used various technologies, such as the `C# programming language`, `raw SQL queries`, `Microsoft SQL Server`. 

In the database, I used objects such as `tables`, `triggers`, `stored procedures`. 

## Setup

1. Clone the repository:

```sh
$ git clone https://github.com/Nurlis03/Chocolate-Production.git
```

2. Configuring the database:

- Open the `database_files` folder, import the `PPO3-2-version.bak`, or `PPO3-2-version.bacpac` one of them in Microsoft SQL Server Management Studio.
- Open  SQL Server Configuration Manager and follow these steps:
    - Enable TCP/IP protocol.
    - Set the port for TCP/IP protocol (port 1433 is usually used).
- configure connection string to your database:
    - Find Settings.Designer.cs which is located at `Chocolate-Production\Chocolate_production_version 2\Properties\Settings.Designer.cs`
    - Set value of connection string `[global::System.Configuration.DefaultSettingValueAttribute("Data Source=YourHost;Initial Catalog=YourDatabase;Integrated Security=True")]`
    - Find App.config which is located at `Chocolate-Production\Chocolate_production_version2\App.config`
    - Set value of connection string 
    ```C#
    <connectionStrings>
    <add name="Chocolate_production_version2.Properties.Settings.PPO3_2_versionConnectionString" connectionString="Data Source=YourHost;Initial          Catalog=YourDatabase;Integrated Security=True" providerName="System.Data.SqlClient" />
    <add name="Entities"  connectionString="metadata=res://*/employee_model.csdl|res://*/employee_model.ssdl|res://*/employee_model.msl;provider=System.Data.SqlClient;provider connection string=&quot;data source=YourHost;initial catalog=YourDatabase;integrated security=True;MultipleActiveResultSets=True;App=EntityFramework&quot;" providerName="System.Data.EntityClient" />
  </connectionStrings>
    ```

## Functionality
1. CRUD operations of 7 tables(Budget, Employee, Finished_products, Ingredients, Positions, Raw_material, Units)
2. Purchase of raw materials
3. Produce products
4. Sale of products
5. Showing the ingredients of the selected product
6. Issuing salaries to employees

## Design of database
![image](https://github.com/Nurlis03/Chocolate-Production/assets/99631295/c3b93d15-f2b5-408a-aa5e-974d2b46e69b)
## Author 

**------------------------------Kimbiletov Nurlis Muratovich*-----------------------------*
