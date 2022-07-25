create table Annoucmement (
Id int primary key identity,
LocalId int not null unique,
SessionInDomainId int not null 
	foreign key references [dbo].[Session_in_Domain]([id])
	on delete cascade on update cascade,
Price money not null,
Telephone nvarchar(16) null,
Advertiser nvarchar(30) null,
AddDate datetime not null)