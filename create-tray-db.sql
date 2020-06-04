DROP DATABASE IF EXISTS `growing`;
CREATE DATABASE `growing`;
USE `growing`;

CREATE TABLE `tblTrayType` (
  `TrayTypeId` int(11) NOT NULL AUTO_INCREMENT,
  `name` varchar(12) NOT NULL,
  `handle` varchar(11) NOT NULL,
  `length` varchar(11) NOT NULL,
  `width` varchar(11) NOT NULL,
  `height` varchar(11) NOT NULL,
  `notes` varchar(150) NOT NULL,
  PRIMARY KEY (TrayTypeId)
) ENGINE=InnoDB AUTO_INCREMENT=11 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;
INSERT INTO `tblTrayType` VALUES (1,'Long Wook','LW','23.5','11.5','4.5','crapachafouech, forkenach');
INSERT INTO `tblTrayType` VALUES (2,'Short Wook','SW','23.5','11.5','4.5','crapachafouech, forkenach');
INSERT INTO `tblTrayType` VALUES (3,'Medium Wook','MW','23.5','11.5','4.5','crapachafouech, forkenach');
INSERT INTO `tblTrayType` VALUES (4,'Huge Wook','HW','23.5','11.5','4.5','crapachafouech, forkenach');

CREATE TABLE `tblProduction` (
  `ProductionId` int(11) NOT NULL AUTO_INCREMENT,
  `name` varchar(12) NOT NULL,
  `city` varchar(11) NOT NULL,
  `department` varchar(11) NOT NULL,
   TrayTypeId INT( 11 ) NOT NULL ,
  `SowingDate` date NOT NULL,
  PRIMARY KEY (ProductionId),
  FOREIGN KEY (TrayTypeId) REFERENCES tblTrayType(TrayTypeId)
) ENGINE=InnoDB AUTO_INCREMENT=1 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;
INSERT INTO `tblProduction` VALUES (1,'nigo','marseille','loiret',1,'2019-01-30');
INSERT INTO `tblProduction` VALUES (2,'buc','marseille','loiret',1,'2019-01-30');

CREATE TABLE `tblSeason` (
  `SeasonId` int(11) NOT NULL AUTO_INCREMENT,
  `name` varchar(12) NOT NULL,
  PRIMARY KEY (SeasonId)
) ENGINE=InnoDB AUTO_INCREMENT=11 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;
INSERT INTO `tblSeason` VALUES (1,'winter');
INSERT INTO `tblSeason` VALUES (2,'spring');

CREATE TABLE `tblSeed` (
  `SeedId` int(11) NOT NULL AUTO_INCREMENT,
  `name` varchar(12) NOT NULL,
  `handle` varchar(11) NOT NULL,
  `SeedLifetime` varchar(11) NOT NULL,
  `SeedingRate` varchar(11) NOT NULL,
    `SeasonId` INT(11) NOT NULL,
  `CurrentDTM` varchar(11) NOT NULL,
  `DTM1` varchar(11) NOT NULL,
  `DTM2` varchar(11) NOT NULL,
  `DTM3` varchar(11) NOT NULL,
  `DTM4` varchar(11) NOT NULL,
  PRIMARY KEY (SeedId),
  FOREIGN KEY (SeasonId) REFERENCES tblSeason(SeasonId)
) ENGINE=InnoDB AUTO_INCREMENT=1 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;
INSERT INTO `tblSeed` VALUES (1,'amaranth','AH','30','1',1,'29','19','49','29','3');
INSERT INTO `tblSeed` VALUES (2,'radish','RH','30','1',1,'29','19','49','29','3');
INSERT INTO `tblSeed` VALUES (3,'spinach','RH','30','1',1,'29','19','49','29','3');
