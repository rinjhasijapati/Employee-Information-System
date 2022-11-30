
Use bit3rdsem
go   
create table employee(
id int not null primary key identity(1,1),
name nvarchar(255) not null,
address nvarchar (255) not null, 
salary nvarchar (25) not null
)



insert into employee(name, address, salary) values

('ram', 'kathmandu', '45,000'),
('shyam', 'bhaktapur','55,000'),
('rita', 'lalitpur','65,000'),
('geeta', 'kavre', '55,000'),
('lila', 'dhulikhel', '75,000')









Select * from employee

