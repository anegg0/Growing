
DROP DATABASE IF EXISTS `growing`;
CREATE DATABASE `growing`;
USE `growing`;

CREATE TABLE `tblTray` (
  `TrayId` int(11) NOT NULL AUTO_INCREMENT,
  `name` varchar(12) NOT NULL,
  `city` varchar(11) NOT NULL,
  `department` varchar(11) NOT NULL,
  `Gender` varchar(11) NOT NULL,
  `SowingDate` date NOT NULL,
  PRIMARY KEY (`TrayId`)
) ENGINE=InnoDB AUTO_INCREMENT=11 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;
INSERT INTO `tblTray` VALUES (1,'nigo','marseille','loiret','fluid','2019-01-30');
