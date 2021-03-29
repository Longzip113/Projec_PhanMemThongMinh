CREATE database QL_MAYBAY

use QL_MAYBAY

CREATE TABLE CHUCVU(
	id bigint NOT NULL PRIMARY KEY auto_increment,
    code char(20) null,
	tenchucvu nvarchar(50) NULL,
    tinhtrang bit NULL
);

CREATE TABLE KHACHHANG(
	id bigint NOT NULL PRIMARY KEY auto_increment,
	hoten nvarchar(50) NULL,
	cmnd char(50) NULL,
	dienthoai char(20) NULL,
    
    taikhoan char(20) NULL,
	matkhau char(20) NULL,
    tinhtrang bit NULL
);

CREATE TABLE NHANVIEN(
	id bigint NOT NULL PRIMARY KEY auto_increment,
	id_chucvu bigint NOT NULL,
	hoten nvarchar(50) NULL,
	cmnd char(20) NULL,
    dienthoai char(20) NULL,
    
    taikhoan char(20) NULL,
	matkhau char(20) NULL,
    tinhtrang bit NULL
);

CREATE TABLE SANBAY(
	id bigint NOT NULL PRIMARY KEY auto_increment,
	tensanbay nvarchar(50) NULL,
	tenthanhpho nvarchar(50) NULL,
    tinhtrang bit NULL
);

CREATE TABLE TUYENBAY(
	id bigint NOT NULL PRIMARY KEY auto_increment,
	id_sanbaydi bigint NOT NULL,
	id_sanbayden bigint NOT NULL,
    tinhtrang bit NULL
);

CREATE TABLE MAYBAY(
	id bigint NOT NULL PRIMARY KEY auto_increment,
    tenmaybay nvarchar(50) NULL,
	sogheloai1 int NULL,
	sogheloai2 int NULL,
	tinhtrang bit NULL
);

CREATE TABLE CHUYENBAY(
	id bigint NOT NULL PRIMARY KEY auto_increment,
	id_tuyenbay bigint NOT NULL,
    id_maybay bigint NOT NULL,
	thoigianbay float NULL,
	ngaygio datetime NULL,
	tinhtrang bit NULL
);

CREATE TABLE VECHUYENBAY(
	id bigint NOT NULL PRIMARY KEY auto_increment,
	id_chuyenbay bigint NOT NULL,
	id_hangve bigint NOT NULL,
	dongia float NULL,
	tinhtrang bit NULL
);

CREATE TABLE HANGVE(
	id bigint NOT NULL PRIMARY KEY auto_increment,
	TenHangVe nvarchar(50) NULL,
    tinhtrang bit NULL
);

CREATE TABLE PHIEUDATVE(
	id bigint NOT NULL PRIMARY KEY auto_increment,
	id_ve bigint NOT NULL,
	id_khachhang bigint NOT NULL,
	id_nhanvien bigint NOT NULL,
	ghichu nvarchar(20) NULL,
	maghe char(20) NULL,
	ngaydat datetime NULL,
	thanhtien float NULL,
    tinhtrang bit NULL
);


ALTER TABLE NHANVIEN ADD CONSTRAINT fk_NHANVIEN_CHUCVU FOREIGN KEY (id_chucvu) REFERENCES CHUCVU(id);

ALTER TABLE TUYENBAY ADD CONSTRAINT fk_TUYENBAY_SANBAY_DI FOREIGN KEY (id_sanbaydi) REFERENCES SANBAY(id);
ALTER TABLE TUYENBAY ADD CONSTRAINT fk_TUYENBAY_SANBAY_DEN FOREIGN KEY (id_sanbayden) REFERENCES SANBAY(id);

ALTER TABLE CHUYENBAY ADD CONSTRAINT fk_CHUYENBAY_TUYENBAY FOREIGN KEY (id_tuyenbay) REFERENCES TUYENBAY(id);
ALTER TABLE CHUYENBAY ADD CONSTRAINT fk_CHUYENBAY_MAYBAY FOREIGN KEY (id_maybay) REFERENCES MAYBAY(id);

ALTER TABLE VECHUYENBAY ADD CONSTRAINT fk_VECHUYENBAY_CHUYENBAY FOREIGN KEY (id_chuyenbay) REFERENCES CHUYENBAY(id);
ALTER TABLE VECHUYENBAY ADD CONSTRAINT fk_VECHUYENBAY_HANGVE FOREIGN KEY (id_hangve) REFERENCES HANGVE(id);

ALTER TABLE PHIEUDATVE ADD CONSTRAINT fk_PHIEUDATVE_VECHUYENBAY FOREIGN KEY (id_ve) REFERENCES VECHUYENBAY(id);
ALTER TABLE PHIEUDATVE ADD CONSTRAINT fk_PHIEUDATVE_KHANHHANG FOREIGN KEY (id_khachhang) REFERENCES KHACHHANG(id);
ALTER TABLE PHIEUDATVE ADD CONSTRAINT fk_PHIEUDATVE_NHANVIEN FOREIGN KEY (id_nhanvien) REFERENCES NHANVIEN(id);













