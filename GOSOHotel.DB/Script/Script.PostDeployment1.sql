/*
Post-Deployment Script Template							
--------------------------------------------------------------------------------------
 This file contains SQL statements that will be appended to the build script.		
 Use SQLCMD syntax to include a file in the post-deployment script.			
 Example:      :r .\myfile.sql								
 Use SQLCMD syntax to reference a variable in the post-deployment script.		
 Example:      :setvar TableName MyTable							
               SELECT * FROM [$(TableName)]					
--------------------------------------------------------------------------------------
*/

INSERT INTO [dbo].[Admin]
(
[Id],
[Username],
[Password])
VALUES('2345','admin','gosohotel')

INSERT INTO [dbo].[Front Desk]
(
[Id],
[Username],
[Password])
VALUES('6789','front desk','frontdesk')
