create database [thevckit]
use thevckit

create table comboBoxSourse(
	
	id int identity (0,1),
	[filename]	nchar(40)	not null,
	[image]		image		not null
)
go

insert [comboBoxSourse] ([filename], [image]) values ('vckit.png', convert(varchar(max), 'C:\Users\thevc\Pictures\Wallpapers\wallpaper\vckit.png'))
insert [comboBoxSourse]([filename], [image]) values ('hello.jpg', convert(varchar(max), 'C:\Users\thevc\Pictures\Saved Pictures\hello.jpg'))