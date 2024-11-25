CREATE DATABASE ASPNET;

USE ASPNET;

DROP TABLE IF EXISTS CATEGORY;
CREATE TABLE CATEGORY(
	CAid int primary key auto_increment,
    CAdescription varchar (100),
    CAstatus bit default 1,
    CAdataCreated datetime default current_timestamp
);

DROP TABLE IF EXISTS BRAND;
CREATE TABLE BRAND(
	Bid int primary key auto_increment,
    Bdescription varchar (100),
    Bstatus bit default 1,
    BdataCreated datetime default current_timestamp
);

DROP TABLE IF EXISTS PRODUCT;
CREATE TABLE PRODUCT(
	Pid int primary key auto_increment,
    Pname varchar (20),
    Pdescription varchar (100),
    Pprice decimal(10,2) default 0,
    Pstock int,
    ProuteImage varchar(200),
    PnameImage varchar(200),  
    Bid int,
    CAid int,
    Pstatus bit default 1,
    PdataCreated datetime default current_timestamp,
    FOREIGN KEY (Bid) REFERENCES BRAND(Bid) ON DELETE CASCADE ON UPDATE CASCADE,
    FOREIGN KEY (CAid) REFERENCES CATEGORY(CAid) ON DELETE CASCADE ON UPDATE CASCADE
);
   
DROP TABLE IF EXISTS CLIENT;
CREATE TABLE CLIENT(
	Cid int primary key auto_increment,
    Cname varchar (50),
    Clastname varchar (50),
    Cemail varchar (50),
    Cphone varchar (50),  
    Cpassword varchar (50),  
    Creset bit default 0,
    Cstatus bit default 1,
    CdataCreated datetime default current_timestamp
);
    
DROP TABLE IF EXISTS SHOPPING_CART;
CREATE TABLE SHOPPING_CART(
	SCid int primary key auto_increment,
    Cid int,
    Pid int,
    SCamount int,
    SCdataCreated datetime default current_timestamp,
    FOREIGN KEY (Cid) REFERENCES CLIENT(Cid) ON DELETE CASCADE ON UPDATE CASCADE,
    FOREIGN KEY (Pid) REFERENCES PRODUCT(Pid) ON DELETE CASCADE ON UPDATE CASCADE
);
    
DROP TABLE IF EXISTS SALES;
CREATE TABLE SALES(
	Sid int primary key auto_increment,
    Cid int,
    StotalProduct int,
    StotalValue decimal(10,2),
    Scontact varchar(20),
    Ssector varchar(50),
    Sphone varchar(20),
    Sdirection varchar(50),
    StransactionCode varchar(100),
	SdataCreated datetime default current_timestamp,
    FOREIGN KEY (Cid) REFERENCES CLIENT(Cid) ON DELETE CASCADE ON UPDATE CASCADE
);
    
DROP TABLE IF EXISTS SALES_DETAIL;
CREATE TABLE SALES_DETAIL(
	SDid int primary key auto_increment,
    Sid int,
    Pid int,
    SDamount int,
    SDtotalValue decimal (10,2),
    FOREIGN KEY (Sid) REFERENCES SALES(Sid) ON DELETE CASCADE ON UPDATE CASCADE,
	FOREIGN KEY (Pid) REFERENCES PRODUCT(Pid) ON DELETE CASCADE ON UPDATE CASCADE
);


DROP TABLE IF EXISTS ROLE;
CREATE TABLE ROLE(
	Rid int primary key auto_increment,
    Rdescription varchar (50),    
	Rstatus int default 1,
    RdataCreated datetime default current_timestamp
);

DROP TABLE IF EXISTS USER;
CREATE TABLE USER(
	Uid int primary key auto_increment,
    Uname varchar (50),
    Ulastname varchar (50),
    Uemail varchar (50),
    Uphone varchar (50),  
    Upassword varchar (100),  
    Ureset int default 0,
    Rid int,
    Ustatus int default 1,
    UdataCreated datetime default current_timestamp,
    FOREIGN KEY (Rid) REFERENCES ROLE(Rid) ON DELETE CASCADE ON UPDATE CASCADE
);

    
    
DROP TABLE IF EXISTS DEPARTMENT;
CREATE TABLE DEPARTMENT(
	DEPid varchar (5),
    DEPdescription varchar (50),
	DEPstatus bit default 1,
    DEPdataCreated datetime default current_timestamp
);


DROP TABLE IF EXISTS PROVINCE;
CREATE TABLE PROVINCE(
	PROid varchar (5),
    PROdescription varchar (50),
	PROstatus bit default 1,
    PROdataCreated datetime default current_timestamp
);
    


DROP TABLE IF EXISTS SECTOR;
CREATE TABLE SECTOR(
	SECid varchar (5),
    SECdescription varchar (50),
	SECstatus bit default 1,
    SECdataCreated datetime default current_timestamp
);
    







    
    