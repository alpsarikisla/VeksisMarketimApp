CREATE DATABASE Veksis_Market_DB
GO
USE Veksis_Market_DB
GO
CREATE TABLE Kategoriler
(
	ID int IDENTITY(1,1),
	UstKategori_ID int,
	Isim nvarchar(75) NOT NULL,
	Durum bit,
	Silinmis bit,
	CONSTRAINT pk_Kategori PRIMARY KEY(ID),
	CONSTRAINT fk_kategoriUstKategori FOREIGN KEY(UstKategori_ID) REFERENCES Kategoriler(ID)
)
GO
CREATE TABLE Kullanicilar
(
	ID int IDENTITY(1,1),
	Isim nvarchar(50),
	Soyisim nvarchar(50),
	KullaniciAdi nvarchar(20),
	Sifre nvarchar(12),
	Durum bit,
	Silinmis bit,
	CONSTRAINT pk_Kullanici PRIMARY KEY(ID)
)
GO
CREATE TABLE Sehirler
(
	ID int IDENTITY(1,1),
	Isim nvarchar(50),
	CONSTRAINT pk_sehir PRIMARY KEY(ID)
)
GO
CREATE TABLE Ilceler
(
	ID int IDENTITY(1,1),
	SehirID int,
	Isim nvarchar(500),
	CONSTRAINT pk_ilce PRIMARY KEY(ID),
	CONSTRAINT fk_ilce_Sehir FOREIGN KEY(SehirID) REFERENCES Sehirler(ID)
)
GO
CREATE TABLE Tedarikciler
(
	ID int IDENTITY(1,1),
	FirmaAdi nvarchar(500),
	Yetkili nvarchar(150),
	FirmaTelefon nvarchar(11),
	Email nvarchar(75),
	Sehir_ID int,
	Ilce_ID int,
	Adres nvarchar(500),
	Durum bit,
	Silinmis bit,
	CONSTRAINT pk_Tedarikci PRIMARY KEY(ID),
	CONSTRAINT fk_TedarikciSehir FOREIGN KEY(Sehir_ID) REFERENCES Sehirler(ID),
	CONSTRAINT fk_TedarikciIlce FOREIGN KEY(Ilce_ID) REFERENCES Ilceler(ID)
)
GO
CREATE TABLE Markalar
(
	ID int IDENTITY(1,1),
	Isim nvarchar(75),
	Durum bit,
	Silinmis bit,
	CONSTRAINT pk_Marka PRIMARY KEY(ID)
)
GO
CREATE TABLE Birimler
(
	ID int IDENTITY(1,1),
	Isim nvarchar(75),
	Durum bit,
	Silinmis bit,
	CONSTRAINT pk_Birim PRIMARY KEY(ID)
)
GO
CREATE TABLE Urunler
(
	ID int IDENTITY(1,1),
	BarkodNo nvarchar(50) NOT NULL,
	Kategori_ID int,
	Marka_ID int,
	Birim_ID int,
	KDVOrani int,
	Isim nvarchar(50) NOT NULL,
	Stok decimal(18,2),
	Aciklama ntext,
	BirimFiyat decimal(18,2),
	Durum bit,
	Silinmis bit,
	CONSTRAINT pk_urun PRIMARY KEY(ID),
	CONSTRAINT fk_UrunKategori FOREIGN KEY(Kategori_ID) REFERENCES Kategoriler(ID),
	CONSTRAINT fk_UrunMarka FOREIGN KEY(Marka_ID) REFERENCES Markalar(ID),
	CONSTRAINT fk_UrunBirim FOREIGN KEY(Birim_ID) REFERENCES Birimler(ID)
)
GO
CREATE TABLE Alimlar
(
	ID int IDENTITY(1,1),
	Urun_ID int,
	Tedarikci_ID int,
	BirimAdet decimal(18,2),
	AlisFiyat decimal(18,2),
	AlisTarihi date,
	CONSTRAINT pk_Alim PRIMARY KEY(ID),
	CONSTRAINT fk_alimUrun FOREIGN KEY(Urun_ID) REFERENCES Urunler(ID),
	CONSTRAINT fk_alimTedarikci FOREIGN KEY(Tedarikci_ID) REFERENCES Tedarikciler(ID)
)
GO
CREATE TABLE Satislar
(
	ID int IDENTITY(1,1),
	Kullanici_ID int,
	AraToplam decimal(18,2),
	Toplam decimal(18,2),
	KDV decimal(18,2),
	SatisTarihi datetime,
	CONSTRAINT pk_satis PRIMARY KEY(ID),
	CONSTRAINT fk_satisKullanici FOREIGN KEY(Kullanici_ID) REFERENCES Kullanicilar(ID)
)
GO
CREATE TABLE SatisDetaylar
(
	ID nvarchar(50),
	Satis_ID int,
	Urun_ID int,
	Adet decimal(18,2),
	BirimFiyat decimal(18,2),
	AraToplam decimal(18,2),
	Toplam decimal(18,2),
	KDV decimal(18,2),
	CONSTRAINT pk_SatisDetay PRIMARY KEY(ID),
	CONSTRAINT fk_satisDetaySatis FOREIGN KEY(Satis_ID) REFERENCES Satislar(ID),
	CONSTRAINT fk_satisDetayUrun FOREIGN KEY(Urun_ID) REFERENCES Urunler(ID)
)
