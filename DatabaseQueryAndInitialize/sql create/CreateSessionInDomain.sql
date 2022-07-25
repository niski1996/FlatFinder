DROP TABLE [Session_in_Domain]

CREATE TABLE [Session_in_Domain] (
id int NOT NULL PRIMARY KEY CLUSTERED IDENTITY(1,1),
sessionId int NOT NULL FOREIGN KEY REFERENCES [dbo].[SearchSession]([Id]) ON DELETE CASCADE  ON UPDATE CASCADE,
domainName nvarchar(200) NOT NULL FOREIGN KEY REFERENCES [dbo].[Domain]([Nazwa]) ON DELETE CASCADE  ON UPDATE CASCADE ,
accepted int NOT NULL,
rejected int NOT NULL,
unknown int NOT NULL,
repated int NOT NULL
)

ALTER TABLE [dbo].[Session_in_Domain] ADD CONSTRAINT df_acc DEFAULT 0 FOR [accepted]
ALTER TABLE [dbo].[Session_in_Domain] ADD CONSTRAINT df_rej DEFAULT 0 FOR [rejected]
ALTER TABLE [dbo].[Session_in_Domain] ADD CONSTRAINT df_unk DEFAULT 0 FOR [unknown]
ALTER TABLE [dbo].[Session_in_Domain] ADD CONSTRAINT df_rep DEFAULT 0 FOR [repated]
ALTER TABLE [dbo].[Session_in_Domain] ADD CONSTRAINT chck_acc CHECK ([accepted]>=0)
ALTER TABLE [dbo].[Session_in_Domain] ADD CONSTRAINT chck_rej CHECK ([rejected]>=0)
ALTER TABLE [dbo].[Session_in_Domain] ADD CONSTRAINT chck_unk CHECK ([unknown]>=0)
ALTER TABLE [dbo].[Session_in_Domain] ADD CONSTRAINT chck_rep CHECK ([repated]>=0)