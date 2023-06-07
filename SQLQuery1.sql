Create trigger trigtienluong on TTluong
after insert,update 
as
	update TTluong set tongtien=(c.luongcoban/26)*c.hesoluong*c.songaylam from inserted i,TTluong c where c.maluong=i.maluong

	Insert into TTluong Values('ML1','1','2022-12-01','2022-12-31',1.9,2000000,1,200000)
	Select * from TTluong
	Select *from TTnhanvien

Select msnv,tongtien from TTluong where tongtien = (SELECT MAX(tongtien) FROM TTluong ) 