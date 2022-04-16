/*
Navicat MySQL Data Transfer

Source Server         : mysql
Source Server Version : 80028
Source Host           : localhost:3306
Source Database       : ppj_projekatt

Target Server Type    : MYSQL
Target Server Version : 80028
File Encoding         : 65001

Date: 2022-04-16 13:54:23
*/

SET FOREIGN_KEY_CHECKS=0;
-- ----------------------------
-- Table structure for `artikal`
-- ----------------------------
DROP TABLE IF EXISTS `artikal`;
CREATE TABLE `artikal` (
  `artikal_id` int NOT NULL AUTO_INCREMENT,
  `naziv_artikla` varchar(255) CHARACTER SET utf8 COLLATE utf8_unicode_ci NOT NULL,
  `vrsta_artikla` varchar(255) CHARACTER SET utf8 COLLATE utf8_unicode_ci NOT NULL,
  `cijena` double NOT NULL,
  PRIMARY KEY (`artikal_id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb3 COLLATE=utf8_unicode_ci;

-- ----------------------------
-- Records of artikal
-- ----------------------------

-- ----------------------------
-- Table structure for `kupac`
-- ----------------------------
DROP TABLE IF EXISTS `kupac`;
CREATE TABLE `kupac` (
  `kupac_id` int NOT NULL AUTO_INCREMENT,
  `ime` varchar(255) CHARACTER SET utf8 COLLATE utf8_unicode_ci NOT NULL,
  `prezime` varchar(255) CHARACTER SET utf8 COLLATE utf8_unicode_ci NOT NULL,
  `grad` varchar(255) CHARACTER SET utf8 COLLATE utf8_unicode_ci NOT NULL,
  `adresa` varchar(255) CHARACTER SET utf8 COLLATE utf8_unicode_ci NOT NULL,
  `telefon` varchar(255) CHARACTER SET utf8 COLLATE utf8_unicode_ci NOT NULL,
  `user` varchar(255) CHARACTER SET utf8 COLLATE utf8_unicode_ci NOT NULL,
  `pass` varchar(255) CHARACTER SET utf8 COLLATE utf8_unicode_ci NOT NULL,
  PRIMARY KEY (`kupac_id`)
) ENGINE=InnoDB AUTO_INCREMENT=6 DEFAULT CHARSET=utf8mb3 COLLATE=utf8_unicode_ci;

-- ----------------------------
-- Records of kupac
-- ----------------------------
INSERT INTO `kupac` VALUES ('1', 'Emir', 'Duvnjak', 'Sarajevo', 'Sarajevo', '054545', 'admin', 'admin');
INSERT INTO `kupac` VALUES ('2', 'Huso', 'Husic', 'Tuzla', 'Tuzla', '055448', 'Huso', 'huso123');
INSERT INTO `kupac` VALUES ('3', 'Edhem', 'Rogo', 'Sarajevo', 'Buća Potok', '062356897', 'Edo', 'edo123');
INSERT INTO `kupac` VALUES ('4', 'Salih', 'Rogo', 'Sarajevo', 'Buća Potok', '062569874', 'Sale', 'sale123');
INSERT INTO `kupac` VALUES ('5', 'Nedim', 'Ligata', 'Sarajevo', 'Briješće', '062365478', 'Liga', 'liga123');

-- ----------------------------
-- Table structure for `narudzbenica`
-- ----------------------------
DROP TABLE IF EXISTS `narudzbenica`;
CREATE TABLE `narudzbenica` (
  `narudzbenica_id` int NOT NULL AUTO_INCREMENT,
  `kupac_id` int NOT NULL,
  `datum_narudzbe` date NOT NULL,
  PRIMARY KEY (`narudzbenica_id`),
  KEY `kupac_id` (`kupac_id`),
  CONSTRAINT `kupac_id` FOREIGN KEY (`kupac_id`) REFERENCES `kupac` (`kupac_id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb3 COLLATE=utf8_unicode_ci;

-- ----------------------------
-- Records of narudzbenica
-- ----------------------------

-- ----------------------------
-- Table structure for `skladiste`
-- ----------------------------
DROP TABLE IF EXISTS `skladiste`;
CREATE TABLE `skladiste` (
  `id` int NOT NULL AUTO_INCREMENT,
  `artikal_id` int NOT NULL,
  `kolicina_stanje` int DEFAULT NULL,
  PRIMARY KEY (`id`),
  KEY `artikal1_id` (`artikal_id`),
  CONSTRAINT `artikal1_id` FOREIGN KEY (`artikal_id`) REFERENCES `artikal` (`artikal_id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb3 COLLATE=utf8_unicode_ci;

-- ----------------------------
-- Records of skladiste
-- ----------------------------

-- ----------------------------
-- Table structure for `stavka_narudzbenice`
-- ----------------------------
DROP TABLE IF EXISTS `stavka_narudzbenice`;
CREATE TABLE `stavka_narudzbenice` (
  `stavka_id` int NOT NULL AUTO_INCREMENT,
  `narudzbenica_id` int NOT NULL,
  `artikal_id` int NOT NULL,
  `kolicina` int DEFAULT NULL,
  PRIMARY KEY (`stavka_id`),
  KEY `narudzbenica_id` (`narudzbenica_id`),
  KEY `artikal_id` (`artikal_id`),
  CONSTRAINT `artikal_id` FOREIGN KEY (`artikal_id`) REFERENCES `artikal` (`artikal_id`),
  CONSTRAINT `narudzbenica_id` FOREIGN KEY (`narudzbenica_id`) REFERENCES `narudzbenica` (`narudzbenica_id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb3 COLLATE=utf8_unicode_ci;

-- ----------------------------
-- Records of stavka_narudzbenice
-- ----------------------------
