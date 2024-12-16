-- phpMyAdmin SQL Dump
-- version 5.2.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Erstellungszeit: 24. Jun 2024 um 13:14
-- Server-Version: 10.4.32-MariaDB
-- PHP-Version: 8.2.12

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Datenbank: `quiz`
--

-- --------------------------------------------------------

--
-- Tabellenstruktur für Tabelle `highscore`
--

CREATE TABLE `highscore` (
  `HS_nr` int(11) NOT NULL,
  `HS_spnr` int(11) NOT NULL,
  `HS_punkte` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- --------------------------------------------------------

--
-- Tabellenstruktur für Tabelle `kontinent`
--

CREATE TABLE `kontinent` (
  `k_nr` int(11) NOT NULL,
  `k_name` varchar(20) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- --------------------------------------------------------

--
-- Tabellenstruktur für Tabelle `lender`
--

CREATE TABLE `lender` (
  `L_nr` int(20) NOT NULL,
  `L_name` varchar(20) NOT NULL,
  `L_hauptsadt` varchar(20) NOT NULL,
  `L_kontinent` int(20) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- --------------------------------------------------------

--
-- Tabellenstruktur für Tabelle `spieler`
--

CREATE TABLE `spieler` (
  `S_nr` int(11) NOT NULL,
  `S_name` varchar(20) NOT NULL,
  `S_pw` varchar(20) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Indizes der exportierten Tabellen
--

--
-- Indizes für die Tabelle `highscore`
--
ALTER TABLE `highscore`
  ADD KEY `HS_spnr` (`HS_spnr`);

--
-- Indizes für die Tabelle `kontinent`
--
ALTER TABLE `kontinent`
  ADD PRIMARY KEY (`k_nr`);

--
-- Indizes für die Tabelle `lender`
--
ALTER TABLE `lender`
  ADD KEY `L_kontinent` (`L_kontinent`);

--
-- Indizes für die Tabelle `spieler`
--
ALTER TABLE `spieler`
  ADD PRIMARY KEY (`S_nr`);

--
-- Constraints der exportierten Tabellen
--

--
-- Constraints der Tabelle `highscore`
--
ALTER TABLE `highscore`
  ADD CONSTRAINT `highscore_ibfk_1` FOREIGN KEY (`HS_spnr`) REFERENCES `spieler` (`S_nr`);

--
-- Constraints der Tabelle `lender`
--
ALTER TABLE `lender`
  ADD CONSTRAINT `lender_ibfk_1` FOREIGN KEY (`L_kontinent`) REFERENCES `kontinent` (`k_nr`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
