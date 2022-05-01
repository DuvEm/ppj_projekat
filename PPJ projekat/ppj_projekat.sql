/*
Navicat MySQL Data Transfer

Source Server         : mysql
Source Server Version : 80028
Source Host           : localhost:3306
Source Database       : ppj_projekat

Target Server Type    : MYSQL
Target Server Version : 80028
File Encoding         : 65001

Date: 2022-05-01 12:59:04
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
) ENGINE=InnoDB AUTO_INCREMENT=5 DEFAULT CHARSET=utf8mb3 COLLATE=utf8_unicode_ci;

-- ----------------------------
-- Records of artikal
-- ----------------------------
INSERT INTO `artikal` VALUES ('1', 'Fudbalska lopta', 'Lopta', '150');
INSERT INTO `artikal` VALUES ('2', 'Kosarkaska lopta', 'Lopta', '120');
INSERT INTO `artikal` VALUES ('3', 'Teniska lopta', 'Lopta', '15');
INSERT INTO `artikal` VALUES ('4', 'Odbojkaska lopta', 'Lopta', '45');

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
INSERT INTO `kupac` VALUES ('5', 'Nedim', 'Ligata', 'Sarajevo', 'Briješće', '06236547', 'Liga', 'liga123');

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
) ENGINE=InnoDB AUTO_INCREMENT=20 DEFAULT CHARSET=utf8mb3 COLLATE=utf8_unicode_ci;

-- ----------------------------
-- Records of narudzbenica
-- ----------------------------
INSERT INTO `narudzbenica` VALUES ('3', '3', '2022-04-18');
INSERT INTO `narudzbenica` VALUES ('4', '3', '2022-04-18');
INSERT INTO `narudzbenica` VALUES ('5', '4', '2022-04-18');
INSERT INTO `narudzbenica` VALUES ('6', '4', '2022-05-01');
INSERT INTO `narudzbenica` VALUES ('7', '4', '2022-05-01');
INSERT INTO `narudzbenica` VALUES ('8', '4', '2022-05-01');
INSERT INTO `narudzbenica` VALUES ('9', '4', '2022-05-01');
INSERT INTO `narudzbenica` VALUES ('10', '5', '2022-05-01');
INSERT INTO `narudzbenica` VALUES ('11', '3', '2022-05-01');
INSERT INTO `narudzbenica` VALUES ('12', '3', '2022-05-01');
INSERT INTO `narudzbenica` VALUES ('13', '3', '2022-05-01');
INSERT INTO `narudzbenica` VALUES ('14', '3', '2022-05-01');
INSERT INTO `narudzbenica` VALUES ('16', '3', '2022-05-01');
INSERT INTO `narudzbenica` VALUES ('17', '3', '2022-05-01');
INSERT INTO `narudzbenica` VALUES ('18', '3', '2022-05-01');
INSERT INTO `narudzbenica` VALUES ('19', '3', '2022-05-01');

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
) ENGINE=InnoDB AUTO_INCREMENT=5 DEFAULT CHARSET=utf8mb3 COLLATE=utf8_unicode_ci;

-- ----------------------------
-- Records of skladiste
-- ----------------------------
INSERT INTO `skladiste` VALUES ('1', '1', '4');
INSERT INTO `skladiste` VALUES ('2', '2', '9');
INSERT INTO `skladiste` VALUES ('3', '3', '40');
INSERT INTO `skladiste` VALUES ('4', '4', '10');

-- ----------------------------
-- Table structure for `stavka_narudzbenice`
-- ----------------------------
DROP TABLE IF EXISTS `stavka_narudzbenice`;
CREATE TABLE `stavka_narudzbenice` (
  `stavka_id` int NOT NULL AUTO_INCREMENT,
  `narudzbenica_id` int NOT NULL,
  `artikal_id` int NOT NULL,
  `kolicina` int DEFAULT NULL,
  `ukupno_novca` int DEFAULT NULL,
  PRIMARY KEY (`stavka_id`),
  KEY `narudzbenica_id` (`narudzbenica_id`),
  KEY `artikal_id` (`artikal_id`),
  CONSTRAINT `artikal_id` FOREIGN KEY (`artikal_id`) REFERENCES `artikal` (`artikal_id`),
  CONSTRAINT `narudzbenica_id` FOREIGN KEY (`narudzbenica_id`) REFERENCES `narudzbenica` (`narudzbenica_id`)
) ENGINE=InnoDB AUTO_INCREMENT=31 DEFAULT CHARSET=utf8mb3 COLLATE=utf8_unicode_ci;

-- ----------------------------
-- Records of stavka_narudzbenice
-- ----------------------------
INSERT INTO `stavka_narudzbenice` VALUES ('3', '3', '1', '2', '300');
INSERT INTO `stavka_narudzbenice` VALUES ('4', '4', '4', '4', '180');
INSERT INTO `stavka_narudzbenice` VALUES ('5', '5', '1', '1', '150');
INSERT INTO `stavka_narudzbenice` VALUES ('6', '6', '1', '1', '150');
INSERT INTO `stavka_narudzbenice` VALUES ('11', '8', '1', '1', '150');
INSERT INTO `stavka_narudzbenice` VALUES ('12', '8', '2', '2', '240');
INSERT INTO `stavka_narudzbenice` VALUES ('13', '9', '1', '1', '150');
INSERT INTO `stavka_narudzbenice` VALUES ('14', '10', '1', '1', '150');
INSERT INTO `stavka_narudzbenice` VALUES ('15', '11', '2', '1', '120');
INSERT INTO `stavka_narudzbenice` VALUES ('25', '17', '1', '1', '150');
INSERT INTO `stavka_narudzbenice` VALUES ('26', '17', '2', '1', '120');
