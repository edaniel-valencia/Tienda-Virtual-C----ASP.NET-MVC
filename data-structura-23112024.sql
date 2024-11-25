

select * from user;
insert into user(Uname, Ulastname, Uemail, Uphone, Upassword, Rid) values ('Edaniel', 'Valencia', 'edaniel@tse', '593965411589', '652d5107fc06198559263d94de19a3c666ca5c67bb50b0cb6019b54245134b49', '1');

select * from role;
insert into role(Rdescription) values ('Administrador');

select *from CATEGORY;
insert into CATEGORY (CAdescription) VALUES
	('ELECTRONICOS'),
    ('MUEBLES'),
    ('TECNOLOGIA'),
    ('COSMETICO'),
    ('FARMACOS');
    
select *from BRAND;
insert into BRAND (Bdescription) VALUES
	('ELECTRONICOS'),
    ('MUEBLES'),
    ('TECNOLOGIA'),
    ('COSMETICO'),
    ('FARMACOS');

    
select *from province;
insert into province (PROid, PROdescription) VALUES
	('01','COTOPAXI'),
    ('02','PICHINCHA'),
    ('03','LOS RIOS'),
    ('04','GUAYAS'),
    ('05','MANABI'),
    ('06','CUENTA'),
    ('07','PUYO'),
    ('08','SUCUMBIOS');
    
select *from department;
insert into department (DEPid, DEPdescription, PROVid) VALUES
	('0101','LA MANA', '01'),
    ('0101','PUJILI', '01'),
    ('0101','SIGCHOS', '01'),
    ('0101','LATACUNGA', '01'),
    ('0102','QUITO', '02'),
    ('0102','PUERTO QUITO', '02'),
    ('0102','SANGOLQUI', '02'),
    ('0103','QUEVEDO', '04'),
    ('0103','VALENCIA', '04'),
    ('0104','GUAYAQUIL', '04'),
    ('0104','DURAN', '05'),
    ('0105','BABAHOYO', '05'),
    ('0106','CASA BLANCA', '06'),
    ('0107','TENA', '07'),
    ('0108','SUCUMBIOS', '08');
    
    
    select *from sector;
insert into sector (SECid, SECdescription, PROVid, DEPid) VALUES
	('10101','LA MANA', 		'0101', '01'),
    ('10101','PUJILI', 		'0101', '01'),
    ('10101','SIGCHOS', 		'0101', '01'),
    ('10101','LATACUNGA', 		'0101', '01'),
    ('20102','QUITO', 			'0102', '02'),
    ('20102','PUERTO QUITO', 	'0102', '02'),
    ('20102','SANGOLQUI', 		'0102', '02'),
    ('40103','QUEVEDO', 		'0104', '04'),
    ('40103','VALENCIA', 		'0104', '04'),
    ('40104','GUAYAQUIL', 		'0104', '04'),
    ('50104','DURAN', 			'0105', '05'),
    ('50105','BABAHOYO', 		'0105', '05'),
    ('60106','CASA BLANCA', 	'0106', '06'),
    ('70107','TENA', 			'0107', '07'),
    ('80108','SUCUMBIOS', 		'0108', '07');