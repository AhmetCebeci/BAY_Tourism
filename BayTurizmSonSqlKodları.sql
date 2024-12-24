CREATE TABLE "Kisi"(
"id" INT,
"ad" VARCHAR (20),
"soyad" VARCHAR (30),
"tc" VARCHAR (11),
"telefonNo" VARCHAR (14),
"kullaniciMi" BOOLEAN ,
"yolcuMu" BOOLEAN,
CONSTRAINT "KisiPK" PRIMARY KEY("id"),
CONSTRAINT "KisilerUniqueTC" UNIQUE("tc"),
CONSTRAINT "KisilerUniqueTelefon" UNIQUE("telefonNo")
);

CREATE TABLE "Kullanici"(
    "id" INT,
    "eMail" VARCHAR(50) NOT NULL,
    "sifre" VARCHAR(12) NOT NULL,
    CONSTRAINT "KullaniciPK" PRIMARY KEY ("id"),
    FOREIGN KEY ("id") REFERENCES "Kisi" ("id")
);

CREATE TABLE "Yolcu"(
    "id" INT,
    "kullanici" INT ,
    CONSTRAINT "YolcuPK" PRIMARY KEY ("id"),
    FOREIGN KEY ("id") REFERENCES "Kisi"("id")
);

CREATE TABLE "Firma"(
    "id" INT ,
    "firmaAd" VARCHAR(50),
    CONSTRAINT "FirmaPK" PRIMARY KEY("id") 
);

CREATE TABLE "Otobus"(
    "id" INT ,
    "plaka" VARCHAR(12),
    "firmaId" INT,
    "marka" VARCHAR(15),
    CONSTRAINT "OtobusPK" PRIMARY KEY ("id"),
    CONSTRAINT "OtobusUnique" UNIQUE ("plaka"),
    FOREIGN KEY ("firmaId") REFERENCES "Firma" ("id")
)

CREATE TABLE "Sehir"(
    "sehirPlaka" INT ,
    "ad" VARCHAR (17),
    CONSTRAINT "SehirPK" PRIMARY KEY ("sehirPlaka"),
    CONSTRAINT "sehirUnique" UNIQUE ("ad")
)

CREATE TABLE "Yorum"(
    "id" INT,
    "icerik" VARCHAR (100),
    "kullanici" INT,
    CONSTRAINT "YorumPK" PRIMARY KEY ("id"),
    FOREIGN KEY ("kullanici") REFERENCES "Kullanici" ("id")
);

CREATE TABLE "Terminal"(
    "id" INT ,
    "ad" VARCHAR (20),
    "sehir" INT,
    CONSTRAINT "TerminalPK" PRIMARY KEY ("id"),
    FOREIGN KEY ("sehir") REFERENCES "Sehir" ("sehirPlaka")
)

CREATE TABLE "Koltuk" (
    "koltukNo" INT,  
    "otobus" INT,
    CONSTRAINT "KoltukPK" PRIMARY KEY ("koltukNo", "otobus"), 
    FOREIGN KEY ("otobus") REFERENCES "Otobus" ("id")
);

CREATE TABLE "Sefer"(
    "seferId" INT,
    "saat" TIME,
    "tarih" DATE,
    "kalkisTerminal" INT,
    "varisTerminal" INT,
    "otobus" INT,
    "firma"INT,
    "ucret" INT,
    CONSTRAINT "SeferPK" PRIMARY KEY ("seferId"),
    FOREIGN KEY ("kalkisTerminal") REFERENCES "Terminal" ("id"),
    FOREIGN KEY ("varisTerminal") REFERENCES "Terminal" ("id"),
    FOREIGN KEY ("otobus") REFERENCES "Otobus" ("id"),
    FOREIGN KEY ("firma") REFERENCES "Firma" ("id"),
    CONSTRAINT "SeferUnique" UNIQUE ("otobus","saat","tarih")
)


CREATE TABLE "Kampanya"(
    "kampanyaKodu" INT,
    "indirimMiktari" INT,
    CONSTRAINT "KampanyaPK" PRIMARY KEY ("kampanyaKodu")
)

CREATE TABLE "Bagaj"(
    "bagajId" INT,
    "parcaSayisi" INT,
    "yolcu" INT,
    CONSTRAINT "BagajPK" PRIMARY KEY ("bagajId"),
    FOREIGN KEY ("yolcu") REFERENCES "Yolcu" ("id")
)

CREATE TABLE "Admin"(
    "adminNo" INT ,
    "kullaniciAd" VARCHAR(20) NOT NULL,
    "sifre" VARCHAR(15) NOT NULL,
    CONSTRAINT "AdminPK" PRIMARY KEY ("adminNo"),
    CONSTRAINT "AdminUnique" UNIQUE ("kullaniciAd")
)

CREATE TABLE "Fatura" (
    "faturaId" INT,
    "kampanyaKodu" INT,
    "sonFiyat" INT,
    "toplamFiyat" INT,
    "tarih" DATE,
    CONSTRAINT "FaturaPK" PRIMARY KEY ("faturaId"),
    FOREIGN KEY ("kampanyaKodu") REFERENCES "Kampanya" ("kampanyaKodu")
)

CREATE TABLE "Bilet" (
    "biletId" INT,
    "fatura" INT,
    "koltuk" INT,
    "sefer" INT,
    "kullanici" INT,
    "yolcu" INT,
    "kesimTarihi" DATE,
    CONSTRAINT "BiletPK" PRIMARY KEY ("biletId"),
    FOREIGN KEY ("fatura") REFERENCES "Fatura" ("faturaId"),
    FOREIGN KEY ("koltuk") REFERENCES "Koltuk" ("koltukNo"),
    FOREIGN KEY ("sefer") REFERENCES "Sefer" ("seferId"),
    FOREIGN KEY ("yolcu") REFERENCES "Yolcu" ("id")
   
)

CREATE TABLE "KisiSayaci" (
    "id" SERIAL PRIMARY KEY,
    "toplam_kisi_sayisi" INT DEFAULT 0
);



--fonksiyon1 indirimi uygulayan fonksiyondur 
CREATE OR REPLACE FUNCTION IndirimUygula(faturaID INT, indirimMiktari INT)
RETURNS INT AS $$
DECLARE
    yeniFiyat INT;
BEGIN
    -- Mevcut fiyatı al
    SELECT "toplamFiyat"
    INTO yeniFiyat
    FROM "Fatura"
    WHERE "faturaId" = faturaID;

    -- Fiyatı indirimle güncelle
    yeniFiyat := yeniFiyat - indirimMiktari;

    -- Negatif fiyatı önle
    IF yeniFiyat < 0 THEN
        yeniFiyat := 0;
    END IF;

    -- Fiyatı güncelle
    UPDATE "Fatura"
    SET "sonFiyat" = yeniFiyat
    WHERE "faturaId" = faturaID;

    -- Yeni fiyatı döndür
    RETURN yeniFiyat;
END;
$$ LANGUAGE plpgsql;


--fonksiyon2 kampanya tablosundan indirim miktarını alır ve indirim uygulanan fonksiyonu kendi içerisinde çağırarak indirim miktarını bu fonksiyona parametre olarak verir.
CREATE OR REPLACE FUNCTION indirim_trigger()
RETURNS TRIGGER AS $$
DECLARE
    indirimMiktari INT;  -- kamampanyadan gelen indirim miktarı
BEGIN
    -- kampanya tablosundan indirim miktarını al
    SELECT "indirimMiktari"
    INTO indirimMiktari
    FROM "Kampanya"
    WHERE "kampanyaKodu" = NEW."kampanyaKodu";

    -- eger kampanya bulunamazsa hata ver
    IF NOT FOUND THEN
        RAISE EXCEPTION 'Geçersiz kampanya kodu: %', NEW."kampanyaKodu";
    END IF;

    -- ındirim uygulama fonksiyonunu çağır
    PERFORM IndirimUygula(NEW."faturaId", indirimMiktari);

    RETURN NEW;
END;
$$ LANGUAGE plpgsql;


--Trigger1 Fatura tablosuna veri eklendikten sonra indirim_trigger() fonksiyonunu çalıştıran trigger. bu trigger indirim uygulanmış fiyatı tabloya ekler.
CREATE TRIGGER indirimMiktariDondurVeUygula
AFTER INSERT ON "Fatura"
FOR EACH ROW
EXECUTE FUNCTION indirim_trigger();



--fonksiyon3 Gelen string değeri büyük harflere çeviren
CREATE OR REPLACE FUNCTION buyukharf(gelen_deger VARCHAR)
RETURNS VARCHAR AS $$
BEGIN
    RETURN UPPER(gelen_deger);
END;
$$ LANGUAGE plpgsql;



--fonksiyon4 tetikleyiciyi çağıran fonksiyon
CREATE OR REPLACE FUNCTION buyukHarfUygulaFonksiyonu()
RETURNS TRIGGER AS $$
BEGIN
    -- "ad" ve "soyad" alanlarını büyük harfe çevir
    NEW."ad" := UPPER(NEW."ad");
    NEW."soyad" := UPPER(NEW."soyad");
    RETURN NEW;
END;
$$ LANGUAGE plpgsql;


--trigger2 buyukHarfe cevir
CREATE TRIGGER buyukHarfUygula
BEFORE INSERT ON "Kisi"
FOR EACH ROW
EXECUTE FUNCTION buyukHarfUygulaFonksiyonu();


--fonksiyon5 kisi tablosuna kayıt eklendiğinde sayacı bir arttırarak toplam kişi sayısını bulan fonksiyon
CREATE OR REPLACE FUNCTION kisi_sayaci_guncelle()
RETURNS TRIGGER AS $$
BEGIN
    UPDATE "KisiSayaci"
    SET "toplam_kisi_sayisi" = "toplam_kisi_sayisi" + 1
    WHERE "id" = 1; -- Her zaman ilk satırı güncelliyoruz
    RETURN NEW;
END;
$$ LANGUAGE plpgsql;

--trigger 3 kisiSayacıGuncelle fonksiyonunu cağıran trigger
CREATE TRIGGER kisi_ekleme_sayaci
AFTER INSERT ON "Kisi"
FOR EACH ROW
EXECUTE FUNCTION kisi_sayaci_guncelle();





--fonksiyon6 Gelen string değeri küçük harflere çeviren
CREATE OR REPLACE FUNCTION kucukharf(gelen_deger VARCHAR)
RETURNS VARCHAR AS $$
BEGIN
    RETURN LOWER(gelen_deger);
END;
$$ LANGUAGE plpgsql;



--fonksiyon7 tetikleyiciyi çağıran fonksiyon
CREATE OR REPLACE FUNCTION kucukHarfUygulaFonksiyonu()
RETURNS TRIGGER AS $$
BEGIN
    -- "ad" alanlarını küçük harfe çevir
     NEW."ad" := Lower(NEW."ad");
    RETURN NEW;
END;
$$ LANGUAGE plpgsql;


--trigger4 kuyukHarfe cevir
CREATE TRIGGER kucukHarfUygula
BEFORE INSERT ON "Sehir"
FOR EACH ROW
EXECUTE FUNCTION kucukHarfUygulaFonksiyonu();











ALTER SEQUENCE "Sehir_sehirPlaka_seq" RESTART WITH 1;



INSERT INTO "Sehir" (Ad)
VALUES
    ('Adana'),
    ('Adıyaman'),
    ('Afyonkarahisar'),
    ('Ağrı'),
    ('Amasya'),
    ('Ankara'),
    ('Antalya'),
    ('Artvin'),
    ('Aydın'),
    ('Balıkesir'),
    ('Bilecik'),
    ('Bingöl'),
    ('Bitlis'),
    ('Bolu'),
    ('Burdur'),
    ('Bursa'),
    ('Çanakkale'),
    ('Çankırı'),
    ('Çorum'),
    ('Denizli'),
    ('Diyarbakır'),
    ('Edirne'),
    ('Elazığ'),
    ('Erzincan'),
    ('Erzurum'),
    ('Eskişehir'),
    ('Gaziantep'),
    ('Giresun'),
    ('Gümüşhane'),
    ('Hakkari'),
    ('Hatay'),
    ('Isparta'),
    ('Mersin'),
    ('İstanbul'),
    ('İzmir'),
    ('Kars'),
    ('Kastamonu'),
    ('Kayseri'),
    ('Kırklareli'),
    ('Kırşehir'),
    ('Kocaeli'),
    ('Konya'),
    ('Kütahya'),
    ('Malatya'),
    ('Manisa'),
    ('Kahramanmaraş'),
    ('Mardin'),
    ('Muğla'),
    ('Muş'),
    ('Nevşehir'),
    ('Niğde'),
    ('Ordu'),
    ('Rize'),
    ('Sakarya'),
    ('Samsun'),
    ('Siirt'),
    ('Sinop'),
    ('Sivas'),
    ('Tekirdağ'),
    ('Tokat'),
    ('Trabzon'),
    ('Tunceli'),
    ('Şanlıurfa'),
    ('Uşak'),
    ('Van'),
    ('Yozgat'),
    ('Zonguldak'),
    ('Aksaray'),
    ('Bayburt'),
    ('Karaman'),
    ('Kırıkkale'),
    ('Batman'),
    ('Şırnak'),
    ('Bartın'),
    ('Ardahan'),
    ('Iğdır'),
    ('Yalova'),
    ('Karabük'),
    ('Kilis'),
    ('Osmaniye'),
    ('Düzce');
    
    
    ALTER SEQUENCE "Terminal_id_seq" RESTART WITH 1;
    
   INSERT INTO "Terminal" (Ad, Sehir)
SELECT 
    Ad AS Ad,
    "sehirPlaka" AS Sehir
FROM "Sehir";



--kullanıcının yaptığı yorum sayısını getiren fonksiyon
CREATE OR REPLACE FUNCTION KullaniciYorumSayisi(kullaniciID INT)
RETURNS INT AS $$
DECLARE
    yorumSayisi INT;
BEGIN
    SELECT COUNT(*) INTO yorumSayisi
    FROM "Yorum"
    WHERE "kullanici" = kullaniciID;

    RETURN yorumSayisi;
END;
$$ LANGUAGE plpgsql;


--sehrin plaka değerine göre o şehirde bulunan terminalleri getiren fonksiyon
CREATE OR REPLACE FUNCTION SehirTerminalleri(sehirPlaka INT)
RETURNS TABLE(terminalAd VARCHAR) AS $$
BEGIN
    RETURN QUERY
    SELECT "ad"
    FROM "Terminal"
    WHERE "sehir" = sehirPlaka;
END;
$$ LANGUAGE plpgsql;

--kullanıcının almış olduğu biletlerin sayısını döndüren fonksiyon
CREATE OR REPLACE FUNCTION KullaniciBiletSayisi(kullaniciID INT)
RETURNS INT AS $$
DECLARE
    bilet_sayisi INT;
BEGIN
    -- Kullanıcının bilet sayısını hesapla
    SELECT COUNT(*) INTO bilet_sayisi
    FROM "Bilet"
    WHERE "kullanici" = kullaniciID;

    -- Sonucu döndür
    RETURN bilet_sayisi;
END;
$$ LANGUAGE plpgsql;

--son kesilen faturanın adresini döndüren fonksiyon
CREATE OR REPLACE FUNCTION SonKesilenFaturaID()
RETURNS INT AS $$
DECLARE
    son_fatura_id INT;
BEGIN
    -- Son kesilen faturayı al (en yüksek fatura tarihi ile)
    SELECT "faturaId" INTO son_fatura_id
    FROM "Fatura"
    ORDER BY "tarih" DESC
    LIMIT 1;

    -- Sonucu döndür
    RETURN son_fatura_id;
END;
$$ LANGUAGE plpgsql;


