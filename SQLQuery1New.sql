Create database parkingvehicle;
use parkingvehicle;

Create Table vehicle(vehicle_id int identity primary key,vehicle_num varchar (20),start_time varchar (15),end_time varchar(15));
insert into vehicle
values('');
select* from vehicle;

Create Table slots(sid varchar(8) primary key,status varchar(15));
select* from slots
insert into slots
values('A01','Available'),('A02','Available'),('A03', 'Available'),('A04','Available'),
('A05','Available'),('A06','Available'),('A07','Available'),('A08','Available'),
('A09','Available'),('A10','Available'),('A11','Available'),('A12','Available'),
('A13','Available'),('A14','Available'),('A15','Available'),('A16','Available'),
('A17','Available'),('A18','Available'),('A19','Available'),('A20','Available'),
('A21','Available'),('A22','Available'),('A23','Available'),('A24','Available'),
('A25','Available'),('A26','Available'),('A27','Available'),('A28','Available'),
('A29','Available'),('A30','Available'),('A31','Available'),('A32','Available'),
('A33','Available'),('A34','Available'),('A35','Available'),('A36','Available'),
('A37','Available'),('A38','Available'),('A39','Available'),('A40','Available'),
('A41','Available'),('A42','Available'),('A43','Available'),('A44','Available'),
('A45','Available'),('A46','Available'),('A47','Available'),('A48','Available'),
('A49','Available'),('A50','Available'),('A51','Available'),('A52','Available'),
('A53','Available'),('A54','Available'),('A55','Available'),('A56','Available'),
('A57','Available'),('A58','Available'),('A59','Available'),('A60','Available'),
('A61','Available'),('A62','Available'),('A63','Available'),('A64','Available'),
('A65','Available'),('A66','Available'),('A67','Available'),('A68','Available'),
('A69','Available'),('A70','Available'),('A71','Available'),('A72','Available'),
('A73','Available'),('A74','Available'),('A75','Available'),('A76','Available'),
('A77','Available'),('A78','Available'),('A79','Available'),('A80','Available'),
('A81','Available'),('A82','Available'),('A83','Available'),('A84','Available'),
('A85','Available'),('A86','Available'),('A87','Available'),('A88','Available'),
('A89','Available'),('A90','Available'),('A91','Available'),('A92','Available'),
('A93','Available'),('A94','Available'),('A95','Available'),('A96','Available'),
('A97','Available'),('A98','Available'),('A99','Available'),('A100','Available'),
('A101','Available'),('A102','Available'),('A103','Available'),('A104','Available'),
('A105','Available'),('A106','Available'),('A107','Available'),('A108','Available'),
('A109','Available'),('A110','Available'),('A111','Available'),('A112','Available'),
('A113','Available'),('A114','Available'),('A115','Available'),('A116','Available'),
('A117','Available'),('A118','Available'),('A119','Available'),('A120','Available'),
('B01','Available'),('B02','Available'),('B03','Available'),('B04','Available'),
('B05','Available'),('B06','Available'),('B07','Available'),('B08','Available'),
('B09','Available'),('B10','Available'),('B11','Available'),('B12','Available'),
('B13','Available'),('B14','Available'),('B15','Available'),('B16','Available'),
('B17','Available'),('B18','Available'),('B19','Available'),('B20','Available'),
('B21','Available'),('B22','Available'),('B23','Available'),('B24','Available'),
('B25','Available'),('B26','Available'),('B27','Available'),('B28','Available'),
('B29','Available'),('B30','Available'),('B31','Available'),('B32','Available'),
('B33','Available'),('B34','Available'),('B35','Available'),('B36','Available'),
('B37','Available'),('B38','Available'),('B39','Available'),('B40','Available'),
('B41','Available'),('B42','Available'),('B43','Available'),('B44','Available'),
('B45','Available'),('B46','Available'),('B47','Available'),('B48','Available'),
('B49','Available'),('B50','Available'),('B51','Available'),('B52','Available'),
('B53','Available'),('B54','Available'),('B55','Available'),('B56','Available'),
('B57','Available'),('B58','Available'),('B59','Available'),('B60','Available'),
('B61','Available'),('B62','Available'),('B63','Available'),('B64','Available'),
('B65','Available'),('B66','Available'),('B67','Available'),('B68','Available'),
('B69','Available'),('B70','Available'),('B71','Available'),('B72','Available'),
('B73','Available'),('B74','Available'),('B75','Available'),('B76','Available'),
('B77','Available'),('B78','Available'),('B79','Available'),('B80','Available'),
('B81','Available'),('B82','Available'),('B83','Available'),('B84','Available'),
('B85','Available'),('B86','Available'),('B87','Available'),('B88','Available'),
('B89','Available'),('B90','Available'),('B91','Available'),('B92','Available'),
('B93','Available'),('B94','Available'),('B95','Available'),('B96','Available'),
('B97','Available'),('B98','Available'),('B99','Available'),('B100','Available'),
('B101','Available'),('B102','Available'),('B103','Available'),('B104','Available'),
('B105','Available'),('B106','Available'),('B107','Available'),('B108','Available'),
('B109','Available'),('B110','Available'),('B111','Available'),('B112','Available'),
('B113','Available'),('B114','Available'),('B115','Available'),('B116','Available'),
('B117','Available'),('B118','Available'),('B119','Available'),('B120','Available'),
('C01','Available'),('C02','Available'),('C03','Available'),('C04','Available'),
('C05','Available'),('C06','Available'),('C07','Available'),('C08','Available'),
('C09','Available'),('C10','Available'),('C11','Available'),('C12','Available'),
('C13','Available'),('C14','Available'),('C15','Available'),('C16','Available'),
('C17','Available'),('C18','Available'),('C19','Available'),('C20','Available'),
('C21','Available'),('C22','Available'),('C23','Available'),('C24','Available'),
('C25','Available'),('C26','Available'),('C27','Available'),('C28','Available'),
('C29','Available'),('C30','Available'),('D01','Available'),('D02','Available'),
('D03','Available'),('D04','Available'),('D05','Available'),('D06','Available'),
('D07','Available'),('D08','Available'),('D09','Available'),('D10','Available'),
('D11','Available'),('D12','Available'),('D13','Available'),('D14','Available'),
('D15','Available'),('D16','Available'),('D17','Available'),('D18','Available'),
('D19','Available'),('D20','Available'),('D21','Available'),('D22','Available'),
('D23','Available'),('D24','Available'),('D25','Available'),('D26','Available'),
('D27','Available'),('D28','Available'),('D29','Available'),('D30','Available'),
('E01','Available'),('E02','Available'),('E03','Available'),('E04','Available'),
('E05','Available'),('E06','Available'),('E07','Available'),('E08','Available'),
('E09','Available'),('E10','Available'),('E11','Available'),('E12','Available'),
('E13','Available'),('E14','Available'),('E15','Available'),('E16','Available'),
('E17','Available'),('E18','Available'),('E19','Available'),('E20','Available'),
('E21','Available'),('E22','Available'),('E23','Available'),('E24','Available'),
('E25','Available'),('E26','Available'),('E27','Available'),('E28','Available'),
('E29','Available'),('E30','Available'),('E31','Available'),('E32','Available'),
('E33','Available'),('E34','Available'),('E35','Available'),('E36','Available'),
('E37','Available'),('E38','Available'),('E39','Available'),('E40','Available');



Create Table worker(user_name varchar (15)primary key,password varchar(15));
select*from worker
insert into worker
values('');


Create Table Payment(pid varchar (10),vid int,uid varchar (15),type varchar (20),veh_type decimal(7,2),time varchar (20),
primary key(pid,vid),foreign key(vid) references vehicle(vehicle_id),foreign key(uid) references worker(user_name));
insert into Payment
values('');
select * from Payment;

Create Table vehicle_slots(vid int primary key,sno varchar (8),foreign key(vid) references vehicle(vehicle_id),
foreign key(sno) references slots(sid));
insert into vehicle_slots
values('');
Select * from vehicle_slots;

