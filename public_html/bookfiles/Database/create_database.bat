@ECHO off

:: batch file for
:: Murach's C# 2010
:: company: Mike Murach & Associates, Inc.
:: date:    September 2, 2010
:: 
:: Uses SQLCMD utility to run a SQL script that creates
:: the MMABooks database.

ECHO Attempting to create the MMABooks database . . . 
sqlcmd -S localhost\SQLExpress -E /i create_database.sql
ECHO.
ECHO If no error message is shown, then the database was created successfully.
ECHO.
PAUSE