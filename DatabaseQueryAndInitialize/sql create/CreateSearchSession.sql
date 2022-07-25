DROP TABLE [dbo].[SearchSession]
Go
CREATE TABLE SearchSession (
Id int NOT NULL PRIMARY KEY CLUSTERED identity(1,1),
SessionDate datetime NOT NULL,
userName nvarchar(30) NOT NULL,
)
ALTER TABLE [dbo].[SearchSession] ADD CONSTRAINT df_session_date DEFAULT GETDATE() FOR [SessionDate]
ALTER TABLE [dbo].[SearchSession] ADD CONSTRAINT df_username DEFAULT 'master' FOR [userName]