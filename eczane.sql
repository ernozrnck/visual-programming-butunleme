-- phpMyAdmin SQL Dump
-- version 5.1.3
-- https://www.phpmyadmin.net/
--
-- Anamakine: 127.0.0.1
-- Üretim Zamanı: 17 Oca 2023, 15:16:25
-- Sunucu sürümü: 8.0.28
-- PHP Sürümü: 8.1.2

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Veritabanı: `eczane`
--

-- --------------------------------------------------------

--
-- Tablo için tablo yapısı `ilaclar`
--

CREATE TABLE `ilaclar` (
  `id` int NOT NULL,
  `isim` varchar(300) COLLATE utf8mb4_unicode_ci NOT NULL,
  `ureticisi` varchar(300) COLLATE utf8mb4_unicode_ci NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

--
-- Tablo döküm verisi `ilaclar`
--

INSERT INTO `ilaclar` (`id`, `isim`, `ureticisi`) VALUES
(1, 'Apranax PLUS', 'abdi ibrahim'),
(2, 'xanax', 'Phizer');

-- --------------------------------------------------------

--
-- Tablo için tablo yapısı `kullanici`
--

CREATE TABLE `kullanici` (
  `TC` int NOT NULL,
  `TamAd` varchar(350) COLLATE utf8mb4_unicode_ci NOT NULL,
  `sifre` varchar(350) COLLATE utf8mb4_unicode_ci NOT NULL,
  `turkmu` tinyint NOT NULL DEFAULT '0'
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

--
-- Tablo döküm verisi `kullanici`
--

INSERT INTO `kullanici` (`TC`, `TamAd`, `sifre`, `turkmu`) VALUES
(1, 'ggg', 'C4CA4238A0B923820DCC509A6F75849B', 1);

-- --------------------------------------------------------

--
-- Tablo için tablo yapısı `personel`
--

CREATE TABLE `personel` (
  `TC` int NOT NULL,
  `ad` varchar(300) COLLATE utf8mb4_unicode_ci NOT NULL,
  `soyad` varchar(300) COLLATE utf8mb4_unicode_ci NOT NULL,
  `sifre` varchar(400) COLLATE utf8mb4_unicode_ci NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

--
-- Tablo döküm verisi `personel`
--

INSERT INTO `personel` (`TC`, `ad`, `soyad`, `sifre`) VALUES
(1, 'Eren', 'Özörencik', 'C4CA4238A0B923820DCC509A6F75849B');

--
-- Dökümü yapılmış tablolar için indeksler
--

--
-- Tablo için indeksler `ilaclar`
--
ALTER TABLE `ilaclar`
  ADD PRIMARY KEY (`id`);

--
-- Tablo için indeksler `kullanici`
--
ALTER TABLE `kullanici`
  ADD PRIMARY KEY (`TC`);

--
-- Tablo için indeksler `personel`
--
ALTER TABLE `personel`
  ADD PRIMARY KEY (`TC`);

--
-- Dökümü yapılmış tablolar için AUTO_INCREMENT değeri
--

--
-- Tablo için AUTO_INCREMENT değeri `ilaclar`
--
ALTER TABLE `ilaclar`
  MODIFY `id` int NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=7;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
