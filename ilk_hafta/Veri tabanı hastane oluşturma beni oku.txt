veri tabaný ismi hastaneproje.

tablo Branslar
Bransid tinyint,
BransAd varchar(50)

tablo Doktorlar
Doktorid tinyint,
DoktorAd varchar(15),
DoktorSoyad varchar(15),
DoktorBrans varchar(50),
DoktorTC char(11),
DoktorSifre varchar(10)

tablo Duyurular
Duyuruid smallint,
Duyuru varchar(200)

tablo Hastalar 
Hastaid smallint,
HastaAd varchar(30),
HastaSoyad varchar(20),
HastaTC char(11),
HastaTelefon varchar(15),
HastaSifre varchar(10),
HastaCinsiyet varchar(5)

tablo Randevular
Randevuid int,
RandevuTarih varchar(10),
RandevuSaat varchar(5),
RandevuBrans varchar(50),
RandevuDoktor varchar(40),
RandevuDurum bit,
HastaTC char(11),
Sikayet varchar(250)

tablo Sekreter
Sekreterid tinyint,
SekreterAdSoyad varchar(40),
SekreterTC char(11),
SekreterSifre varchar(10)

veritabanýný ve Tablolarý elle oluþturdum. Veri tabaný kodlarý yazmadým. 