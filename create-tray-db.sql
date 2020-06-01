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

CREATE TABLE `tblProduction` (
  `ProductionId` int(11) NOT NULL AUTO_INCREMENT,
  `name` varchar(12) NOT NULL,
  `city` varchar(11) NOT NULL,
  `department` varchar(11) NOT NULL,
   TrayTypeId INT( 11 ) NOT NULL ,
  `SowingDate` date NOT NULL,
  PRIMARY KEY (ProductionId),
  FOREIGN KEY (TrayTypeId) REFERENCES tblTrayType(TrayTypeId)
) ENGINE=InnoDB AUTO_INCREMENT=11 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;
INSERT INTO `tblProduction` VALUES (1,'nigo','marseille','loiret',1,'2019-01-30');
