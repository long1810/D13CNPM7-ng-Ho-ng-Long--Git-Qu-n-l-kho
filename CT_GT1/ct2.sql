create database ct2

create table nhaCC
(maNCC varchar(10)not null primary key ,
tenNCC varchar(100),
dienthoai varchar(14),
diachi varchar(100)
)

create table phieunhap
(maPN varchar(10)NOT NULL primary key ,
ngaynhap date,
maNCC varchar(10),
tienNhap int
)

create table ChiTietPN
( maPN varchar(10),
 maHang varchar(10),
ngaynhap date,
soluong int,
giaNhap int,
thanhtien int,
primary key (maPN,maHang)
)

create table kh
(makh varchar(10) not null primary key,
tenkh varchar(30),
dc varchar(30),
dt int
)
insert into kh values 

create table hoadon
(mahd varchar(10) not null primary key,
ngayban date  default getdate(),
tienban int,
MaKH VARCHAR(10),
giamgia int default 100,
thanhtoan int
)
insert into hoadon(mahd,MaKH) values ('hd1','makh1')

insert into chitietHD values 
								('hd1','hang01',10,100000,0),
								('hd1','hang02',10,200000,0),
								('hd2','hang03',10,300000,0),
								('hd2','hang04',10,400000,0),
								('hd2','hang02',10,200000,0),
								('hd3','hang01',10,100000,0),
								('hd3','hang02',10,200000,0),
								('hd4','hang01',10,100000,0),
								('hd5','hang01',10,100000,0),
								('hd6','hang01',10,100000,0);





create table chitietHD
(mahd varchar(10) not null,
 maHang varchar(10) not null,
soluong int,
gianhap int,
thanhtien int,
primary key (mahd,maHang)
)

create table hang
(
maHang varchar(10) not null primary key,
tenhg varchar(40),
soluong int,
maLH varchar(100),
maNSX varchar(10),
tinhtrang nvarchar(30),
gia int
)
create table loaihang
(
maLH varchar(100),
tenLH nvarchar(100),
primary key (maLh),
)

CREATE TABLE nhaNSX
(
maNSX VARCHAR(50)NOT NULL,
tenNSX varchar(100),
dc varchar(500),
dt varchar(30),
PRIMARY KEY (maNSX)
)
insert into nhaNSX values ('nsx1',' gunci ','ha noi ','01010010'),
							('nsx2',' bitit ','ha noi ','01010010'),
							('nsx3',' cha neo ','ha noi ','01010010');
							
insert into nhaNSX values ('nsx1',' gunci ','ha noi ','01010010'),
							('nsx2',' bitit ','ha noi ','01010010'),
							('nsx3',' cha neo ','ha noi ','01010010');

-- lllllllllllllllllllllllllllllllllllll
maPN varchar(10)NOT NULL primary key ,
ngaynhap date,
maNCC varchar(10),
tienNhap int


create trigger 	thanhtien on ChiTietPN
for insert ,update, delete
as
update phieunhap
set tiennhap = (select sum(thanhtien) from phieunhap,ChiTietPN where phieunhap.maPN = CHiTietPN.maPN)


create trigger 	thanhtien2 on ChiTietPN
for insert 
as
update ChiTietPN
set thanhtien = soluong*gianhap
insert into phieunhap(maPN,ngaynhap,maNCC) values ('pn2','1/30/2020','ncc2'),
								('pn3','1/30/2020','ncc1' ),
								('pn4','2/30/2020','ncc3'),
								('pn5','3/30/2020','ncc4'),
								('pn7','4/30/2020','ncc3'),
								('pn8','5/30/2020','ncc4'),
								('pn9','6/30/2020','ncc2'),
								('pn1','7/30/2020','ncc1'),
								('pn6','8/30/2020','ncc3' );

insert into ChiTietPN (maPN,maHang,ngaynhap,giaNhap,soluong)
					values ('pn1','hang01',1000,100, 0),
							('pn1','hang02',1000,200,0),
							('pn1','hang03',1000,300,0),
							('pn2','hang01',1000,400,0),
							('pn2','hang02',1000,500,0),
							('pn2','hang03',1000,600,0),
							('pn2','hang04',1000,700,0),
							('pn3','hang01',1000,800,0),
							('pn3','hang02',1000,100,0),
							('pn3','hang03',1000,100,0),
							('pn4','hang01',1000,1200,0),
							('pn5','hang02',1000,1100,0),
							('pn6','hang06',1000,1200,0),
							('pn7','hang07',1000,1100,0);
create table taikhoan
(tk varchar(100) not null,
mk varchar(100),
primary key (tk),
)							
insert into taikhoan values ('tk1','1'),
							('hoan','1'),
							('tuan','1'),
							('hung','1'),
							('c',''),
							('tui ne ','1');
							
						
insert into kh values ('makh1','long ',' ha noi ',0972550684),
						('makh2','tu ',' ha noi ',0972550684),
						('makh3','hoan ',' ha noi ',0972550684),
						('makh4','hung ',' ha noi ',0972550684),
						('makh5','tuan ',' ha noi ',0972550684);
						

insert into nhaCC values ('ncc1','grap','0123456789 ','ha noi'),
						('ncc2','shop ppee','0123456789 ','ha noi'),
						('ncc3','tiki','0123456789 ','ha noi'),
						('ncc4','intel ','0123456789 ','ha noi');

insert into hang values ('hang06',N'giay','20','lh1','nsx2',N' t?t ',10000),
						('hang07',N'dep','30','lh1','nsx2',N' t?t ',20000),
						('hang08',N'quan bo ','40','lh3','nsx3',N' t?t ',30000),
						('hang09',N'loa','50','lh2','nsx3',N' t?t ',40000),
						('hang015',N'may tinh','60','lh2','nsx3',N' t?t ',50000);


insert into loaihang values ('lh1',N' th?i trang '),
							('lh2',N' công ngh? '),
							('lh3',N' tinh th?n '),
							('lh4',N' cao c?p ');



--llllllllllllllll--llllllllllllllll
create proc tt
as
update ChiTietPN
set thanhtien = giaNhap*soluong

exec tt

--llllllllllllllll--llllllllllllllll
create trigger tinhtien on ChiTietPN
for insert
as
update ChiTietPN
set thanhtien = giaNhap*soluong

--llllllllllllllll--llllllllllllllll
alter proc ncchang1 @m varchar(100)
as
select NCC.maNCC, hang.maHG,inventory.mak,  inventory.soluong
from NCC,CTphieunhap,phieunhap,hang,inventory
where NCC.maNCC = phieunhap.maNCC and phieunhap.maPN = CTphieunhap.maPN and  CTphieunhap.maHG= hang.maHG 
		and NCC.maNCC = 'ncc1'
		
exec ncchang1 ncc2			

--llllllllllllllll--llllllllllllllll
create trigger capnhat_tien on chitietHD
for
insert
as
update chitietHD
set thanhtien = soluong*gianhap

--llllllllllllllll
select * from nhaNSX,hang where hang.maNSX = nhaNSX.maNSX and nhaNSX.maNSX ='nsx1'   


		

		

select * from loaihang
select * from hang where maHang = '1'
select * from nhaNSX
select * from nha


update hang
set tenhg ='', soluong = , maNSX = '', tinhtrang ='' where maHang =''
delete 
from hang
where maHang ='1'
select * from hang where tenhg like '%o%'
select COUNT(*) from taikhoan where tk = 'c' and mk = ''
select SUM(thanhtien)

select *
from ChiTietPN
where maPN = 'pn1' 

select month(ngaynhap)
from phieunhap

select *, convert(varchar(10),ngaynhap,103)
from ChiTietPN
where ngayNhap ='30/2020'

select *, convert(varchar(10),ngaynhap,103)
from ChiTietPN
where month(ngaynhap)= '1'

select *, convert(varchar(10),ngaynhap,103)
from ChiTietPN
where year(ngaynhap)= '2020'

select SUM(soluong)
from ChiTietPN
where ngayNhap ='1/30/2020'						