-- phpMyAdmin SQL Dump
-- version 5.1.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Erstellungszeit: 09. Jan 2022 um 18:56
-- Server-Version: 10.4.22-MariaDB
-- PHP-Version: 8.1.1

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Datenbank: `hotel_willeke`
--
CREATE DATABASE IF NOT EXISTS `hotel_willeke` DEFAULT CHARACTER SET utf8mb4 COLLATE utf8mb4_general_ci;
USE `hotel_willeke`;

-- --------------------------------------------------------

--
-- Tabellenstruktur für Tabelle `adresse`
--

CREATE TABLE `adresse` (
  `AdressID` int(6) NOT NULL,
  `Hausnummer` varchar(6) COLLATE latin1_german2_ci DEFAULT NULL,
  `Straße` varchar(35) COLLATE latin1_german2_ci DEFAULT NULL,
  `PLZ` int(5) DEFAULT NULL
) ENGINE=MyISAM DEFAULT CHARSET=latin1 COLLATE=latin1_german2_ci;

--
-- Daten für Tabelle `adresse`
--

INSERT INTO `adresse` (`AdressID`, `Hausnummer`, `Straße`, `PLZ`) VALUES
(3, '28', 'Schulstraße', 80331),
(2, '26', 'Dorfstraße', 80331),
(1, '24', 'Gartenstraße', 80331),
(4, '2', 'Meisenweg', 48291),
(7, '39a', 'Sendener Weg', 13507),
(6, '5', 'Lagustelweg', 20095),
(5, '16', 'Amselweg', 48361),
(8, '19', 'Mispelweg', 22179),
(9, '13', 'Brachetweg', 22179);

-- --------------------------------------------------------

--
-- Tabellenstruktur für Tabelle `buchung`
--

CREATE TABLE `buchung` (
  `GruppenID` int(6) NOT NULL,
  `ZimmerID` int(6) NOT NULL,
  `Babybett` tinyint(1) DEFAULT NULL,
  `PayTV` tinyint(1) DEFAULT NULL,
  `Frühstück` tinyint(1) DEFAULT NULL,
  `Datum` date NOT NULL DEFAULT '0000-00-00'
) ENGINE=MyISAM DEFAULT CHARSET=latin1 COLLATE=latin1_german2_ci;

--
-- Daten für Tabelle `buchung`
--

INSERT INTO `buchung` (`GruppenID`, `ZimmerID`, `Babybett`, `PayTV`, `Frühstück`, `Datum`) VALUES
(4, 10, 0, 0, 1, '2022-01-04'),
(4, 10, 0, 0, 1, '2022-01-03'),
(5, 11, 0, 0, 1, '2022-01-08'),
(5, 11, 0, 0, 1, '2022-01-07'),
(5, 11, 0, 0, 1, '2022-01-06'),
(4, 10, 0, 0, 1, '2022-01-02'),
(2, 21, 1, 1, 0, '2022-01-09'),
(3, 23, 1, 0, 1, '2022-01-06'),
(3, 23, 1, 0, 1, '2022-01-07'),
(3, 23, 1, 0, 1, '2022-01-08'),
(3, 23, 1, 0, 1, '2022-01-09'),
(2, 21, 1, 1, 0, '2022-01-10'),
(1, 13, 0, 1, 1, '2022-01-09');

-- --------------------------------------------------------

--
-- Tabellenstruktur für Tabelle `gast`
--

CREATE TABLE `gast` (
  `GastID` int(6) NOT NULL,
  `Name` varchar(255) COLLATE latin1_german2_ci DEFAULT NULL,
  `Nachname` varchar(255) COLLATE latin1_german2_ci DEFAULT NULL,
  `Email` varchar(50) COLLATE latin1_german2_ci DEFAULT NULL,
  `AdressID` int(6) DEFAULT NULL
) ENGINE=MyISAM DEFAULT CHARSET=latin1 COLLATE=latin1_german2_ci;

--
-- Daten für Tabelle `gast`
--

INSERT INTO `gast` (`GastID`, `Name`, `Nachname`, `Email`, `AdressID`) VALUES
(1, 'Ben', 'Zelleröhr', 'b.zelleroehr@gmail.com', 5),
(2, 'Sven', 'Gersmeier', 'sven@gmail.com', 4),
(6, 'Ranajey', 'Müllersmann', 'heinzfsh@gmail.com', 6),
(3, 'Heinz Joseph', 'Müllersmann', 'heinzfsh@gmail.com', 6),
(4, 'Barbera Maria', 'Müllersmann', 'barbera@freenet.com', 6),
(5, 'Tristan Heinz', 'Müllersmann', 'tristangaming@gmail.com', 6),
(7, 'Peter', 'Niehaus', 'piethaus@t-online.de', 7),
(8, 'Finn', 'Ackermann', 'ackermann@web.de', 8),
(9, 'Clara', 'Keilhammer', 'c.keilhammer@gmx.de', 9);

-- --------------------------------------------------------

--
-- Tabellenstruktur für Tabelle `gebäude`
--

CREATE TABLE `gebäude` (
  `GebäudeID` int(6) NOT NULL,
  `AdressID` int(6) DEFAULT NULL
) ENGINE=MyISAM DEFAULT CHARSET=latin1 COLLATE=latin1_german2_ci;

--
-- Daten für Tabelle `gebäude`
--

INSERT INTO `gebäude` (`GebäudeID`, `AdressID`) VALUES
(1, 1),
(2, 2),
(3, 3);

-- --------------------------------------------------------

--
-- Tabellenstruktur für Tabelle `gruppe`
--

CREATE TABLE `gruppe` (
  `GruppenID` int(6) NOT NULL
) ENGINE=MyISAM DEFAULT CHARSET=latin1 COLLATE=latin1_german2_ci;

--
-- Daten für Tabelle `gruppe`
--

INSERT INTO `gruppe` (`GruppenID`) VALUES
(1),
(2),
(3),
(4),
(5);

-- --------------------------------------------------------

--
-- Tabellenstruktur für Tabelle `gruppegast`
--

CREATE TABLE `gruppegast` (
  `GruppenID` int(6) NOT NULL,
  `GastID` int(6) NOT NULL,
  `Bezahlt` tinyint(1) DEFAULT NULL
) ENGINE=MyISAM DEFAULT CHARSET=latin1 COLLATE=latin1_german2_ci;

--
-- Daten für Tabelle `gruppegast`
--

INSERT INTO `gruppegast` (`GruppenID`, `GastID`, `Bezahlt`) VALUES
(5, 9, 0),
(5, 8, 1),
(4, 7, 1),
(3, 6, 0),
(3, 5, 0),
(3, 4, 0),
(3, 3, 1),
(2, 2, 1),
(1, 1, 1);

-- --------------------------------------------------------

--
-- Tabellenstruktur für Tabelle `plz`
--

CREATE TABLE `plz` (
  `PLZ` int(5) NOT NULL,
  `Ort` varchar(255) COLLATE latin1_german2_ci DEFAULT NULL
) ENGINE=MyISAM DEFAULT CHARSET=latin1 COLLATE=latin1_german2_ci;

--
-- Daten für Tabelle `plz`
--

INSERT INTO `plz` (`PLZ`, `Ort`) VALUES
(48361, 'Beelen'),
(48291, 'Telgte'),
(80331, 'München'),
(20095, 'Hamburg'),
(13507, 'Berlin'),
(22179, 'Hamburg');

-- --------------------------------------------------------

--
-- Tabellenstruktur für Tabelle `preis`
--

CREATE TABLE `preis` (
  `Dienstleistung` varchar(20) COLLATE latin1_german2_ci NOT NULL,
  `Preis` double DEFAULT NULL
) ENGINE=MyISAM DEFAULT CHARSET=latin1 COLLATE=latin1_german2_ci;

-- --------------------------------------------------------

--
-- Tabellenstruktur für Tabelle `terassebalkon`
--

CREATE TABLE `terassebalkon` (
  `TerasseBalkon` varchar(50) COLLATE latin1_german2_ci NOT NULL
) ENGINE=MyISAM DEFAULT CHARSET=latin1 COLLATE=latin1_german2_ci;

--
-- Daten für Tabelle `terassebalkon`
--

INSERT INTO `terassebalkon` (`TerasseBalkon`) VALUES
('Groß'),
('Klein'),
('Nein'),
('Terasse');

-- --------------------------------------------------------

--
-- Tabellenstruktur für Tabelle `zimmer`
--

CREATE TABLE `zimmer` (
  `ZimmerID` int(6) NOT NULL,
  `Fernseher` tinyint(1) DEFAULT NULL,
  `Kühlschrank` tinyint(1) DEFAULT NULL,
  `Hauptstraße` tinyint(1) DEFAULT NULL,
  `Zimmernummer` varchar(255) COLLATE latin1_german2_ci DEFAULT NULL,
  `GebäudeID` int(6) DEFAULT NULL,
  `ZimmerTyp` varchar(20) COLLATE latin1_german2_ci DEFAULT NULL,
  `TerasseBalkon` varchar(20) COLLATE latin1_german2_ci DEFAULT NULL
) ENGINE=MyISAM DEFAULT CHARSET=latin1 COLLATE=latin1_german2_ci;

--
-- Daten für Tabelle `zimmer`
--

INSERT INTO `zimmer` (`ZimmerID`, `Fernseher`, `Kühlschrank`, `Hauptstraße`, `Zimmernummer`, `GebäudeID`, `ZimmerTyp`, `TerasseBalkon`) VALUES
(1, 1, 1, 1, '101', 1, 'EZ', 'Terasse'),
(2, 1, 1, 1, '102', 1, 'EZ', 'Nein'),
(3, 1, 1, 0, '103', 1, 'EZ', 'Nein'),
(4, 1, 1, 0, '201', 1, 'DZ', 'Nein'),
(5, 1, 1, 1, '202', 1, 'DZ', 'Klein'),
(6, 1, 1, 1, '203', 1, 'EZ', 'Klein'),
(7, 1, 1, 0, '301', 1, 'EZ', 'Klein'),
(8, 1, 1, 0, '302', 1, 'EZ', 'Klein'),
(9, 0, 0, 0, '303', 1, 'EZ', 'Klein'),
(10, 0, 0, 0, '304', 1, 'EZ', 'Nein'),
(11, 0, 1, 1, '101', 2, 'DZ', 'Terasse'),
(12, 0, 1, 1, '102', 2, 'DZ', 'Terasse'),
(13, 0, 1, 0, '103', 2, 'EZ', 'Nein'),
(14, 1, 1, 0, '201', 2, 'EZ', 'Nein'),
(15, 1, 1, 0, '202', 2, 'DZ', 'Klein'),
(16, 1, 1, 0, '203', 2, 'DZ', 'Klein'),
(17, 1, 1, 0, '301', 2, 'EZ', 'Klein'),
(18, 1, 1, 0, '302', 2, 'EZ', 'Nein'),
(19, 1, 1, 0, '101', 3, 'DZ', 'Nein'),
(20, 1, 1, 0, '102', 3, 'DZ', 'Nein'),
(21, 1, 1, 0, '201', 3, 'EZ', 'Nein'),
(22, 1, 1, 0, '202', 3, 'Suite', 'Groß'),
(23, 1, 1, 0, '301', 3, 'Suite', 'Groß'),
(24, 1, 1, 0, '302', 3, 'EZ', 'Klein');

-- --------------------------------------------------------

--
-- Tabellenstruktur für Tabelle `zimmertyp`
--

CREATE TABLE `zimmertyp` (
  `ZimmerTyp` varchar(50) COLLATE latin1_german2_ci NOT NULL
) ENGINE=MyISAM DEFAULT CHARSET=latin1 COLLATE=latin1_german2_ci;

--
-- Daten für Tabelle `zimmertyp`
--

INSERT INTO `zimmertyp` (`ZimmerTyp`) VALUES
('DZ'),
('EZ'),
('Suite');

--
-- Indizes der exportierten Tabellen
--

--
-- Indizes für die Tabelle `adresse`
--
ALTER TABLE `adresse`
  ADD PRIMARY KEY (`AdressID`),
  ADD KEY `PLZ` (`PLZ`);

--
-- Indizes für die Tabelle `buchung`
--
ALTER TABLE `buchung`
  ADD PRIMARY KEY (`ZimmerID`,`Datum`);

--
-- Indizes für die Tabelle `gast`
--
ALTER TABLE `gast`
  ADD PRIMARY KEY (`GastID`),
  ADD KEY `AdressID` (`AdressID`);

--
-- Indizes für die Tabelle `gebäude`
--
ALTER TABLE `gebäude`
  ADD PRIMARY KEY (`GebäudeID`),
  ADD KEY `AdressID` (`AdressID`);

--
-- Indizes für die Tabelle `gruppe`
--
ALTER TABLE `gruppe`
  ADD PRIMARY KEY (`GruppenID`);

--
-- Indizes für die Tabelle `gruppegast`
--
ALTER TABLE `gruppegast`
  ADD PRIMARY KEY (`GruppenID`,`GastID`),
  ADD KEY `GastID` (`GastID`);

--
-- Indizes für die Tabelle `plz`
--
ALTER TABLE `plz`
  ADD PRIMARY KEY (`PLZ`);

--
-- Indizes für die Tabelle `preis`
--
ALTER TABLE `preis`
  ADD PRIMARY KEY (`Dienstleistung`);

--
-- Indizes für die Tabelle `terassebalkon`
--
ALTER TABLE `terassebalkon`
  ADD PRIMARY KEY (`TerasseBalkon`);

--
-- Indizes für die Tabelle `zimmer`
--
ALTER TABLE `zimmer`
  ADD PRIMARY KEY (`ZimmerID`),
  ADD KEY `GebäudeID` (`GebäudeID`),
  ADD KEY `ZimmerTyp` (`ZimmerTyp`),
  ADD KEY `TerasseBalkon` (`TerasseBalkon`);

--
-- Indizes für die Tabelle `zimmertyp`
--
ALTER TABLE `zimmertyp`
  ADD PRIMARY KEY (`ZimmerTyp`);

--
-- AUTO_INCREMENT für exportierte Tabellen
--

--
-- AUTO_INCREMENT für Tabelle `adresse`
--
ALTER TABLE `adresse`
  MODIFY `AdressID` int(6) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=11;

--
-- AUTO_INCREMENT für Tabelle `gast`
--
ALTER TABLE `gast`
  MODIFY `GastID` int(6) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=11;

--
-- AUTO_INCREMENT für Tabelle `gebäude`
--
ALTER TABLE `gebäude`
  MODIFY `GebäudeID` int(6) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=29;

--
-- AUTO_INCREMENT für Tabelle `gruppe`
--
ALTER TABLE `gruppe`
  MODIFY `GruppenID` int(6) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=14;

--
-- AUTO_INCREMENT für Tabelle `gruppegast`
--
ALTER TABLE `gruppegast`
  MODIFY `GruppenID` int(6) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=14;

--
-- AUTO_INCREMENT für Tabelle `zimmer`
--
ALTER TABLE `zimmer`
  MODIFY `ZimmerID` int(6) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=25;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
