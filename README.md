# Dreamovie Movie Rental System
A full-stack desktop application based on C# Windows Forms and Oracle, which manages rental transactions, members and movie inventory, as part of a Sofware Engineering Project during Year 2 of the Computing with Software Development course at Munster Technological University (MTU) in 2021. It has been tested on Visual Studio 2019 and Oracle Database 19c.

## Requirements
- Windows 10 or later
- Visual Studio 2019 or later
- Oracle Database 19c or later installed either locally or remotely via another machine or the cloud
- Oracle SQL Developer

## How to run
This Windows Forms-based application can be run from the Visual Studio IDE user interface. Although it has been tested on Visual Studio 2019 on Windows 10, the application may run on later versions of Microsoft Windows and Visual Studio such as Windows 11 and VS 2022. An Oracle database hosted locally on a Windows PC or any remote machine within a LAN network or on the cloud, from version 19c onwards, is also required to ensure this application can run without any errors as it connects to Oracle to perform Create, Read, Update and Delete (CRUD) operations.

1. Download this repository and extract all contents to a new folder on the computer.
2. Open the ***MovieSYS*** folder from the extracted folder, and then open the ***MovieSYS.sln*** file. It will then open the Visual Studio IDE.
3. Open Oracle SQL Developer, and create or open an Oracle database connection using your configured username, password, hostname/IP address, port number and service name of your Oracle server.
4. Once connected to an Oracle server from SQL Developer, a blank worksheet template will open. Open the ***RentalSYS.sql*** file on a text editor and copy the contents into the blank SQL Developer worksheet to create the schema on your Oracle database. Then run the script by clicking on the second button below the current worksheet tab, with an icon of a sheet and a tiny green icon inside the sheet. You may also press the *F5* key to run the script.
5. Run the second SQL file called ***RentalSYS_DATA.sql***, which adds data into your database, by either clearing the current worksheet using the backspace or delete keys or creating a new worksheet using the green person icon with a yellow indicator and a small "SQL" text below the worksheet tabs inside SQL Developer. Then copy the contents of the ***RentalSYS_DATA.sql*** file into the worksheet and run the script by clicking the second button below the tabs or pressing *F5*.
6. Before running the application from Visual Studio, please ensure you have the correct credentials and server details to connect the C# application to Oracle by opening a class file called ***DBConnect.cs*** inside the Solution Explorer section and editing the username, password and data source fields (including the hostname/IP address and Service Name of your Oracle server).
7. Once you have the correct credentials and server details in the DBConnect.cs file, click the Start button with the green arrow icon to run the application from the Visual Studio IDE. You can now navigate around the application.