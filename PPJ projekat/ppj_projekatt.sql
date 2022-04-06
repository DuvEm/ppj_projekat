/*
Navicat MySQL Data Transfer

Source Server         : MySql
Source Server Version : 50018
Source Host           : localhost:3306
Source Database       : ppj_projekat

Target Server Type    : MYSQL
Target Server Version : 50018
File Encoding         : 65001

Date: 2022-04-06 08:48:56
*/

SET FOREIGN_KEY_CHECKS=0;
-- ----------------------------
-- Table structure for `artikal`
-- ----------------------------
DROP TABLE IF EXISTS `artikal`;
CREATE TABLE `artikal` (
  `artikal_id` int(11) NOT NULL auto_increment,
  `naziv_artikla` varchar(255) collate utf8_unicode_ci NOT NULL,
  `vrsta_artikla` varchar(255) collate utf8_unicode_ci NOT NULL,
  `cijena` double NOT NULL,
  PRIMARY KEY  (`artikal_id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;

-- ----------------------------
-- Records of artikal
-- ----------------------------

-- ----------------------------
-- Table structure for `kupac`
-- ----------------------------
DROP TABLE IF EXISTS `kupac`;
CREATE TABLE `kupac` (
  `kupac_id` int(11) NOT NULL auto_increment,
  `ime` varchar(255) collate utf8_unicode_ci NOT NULL,
  `prezime` varchar(255) collate utf8_unicode_ci NOT NULL,
  `grad` varchar(255) collate utf8_unicode_ci NOT NULL,
  `adresa` varchar(255) collate utf8_unicode_ci NOT NULL,
  `telefon` varchar(255) collate utf8_unicode_ci NOT NULL,
  `user` varchar(255) collate utf8_unicode_ci NOT NULL,
  `pass` varchar(255) collate utf8_unicode_ci NOT NULL,
  PRIMARY KEY  (`kupac_id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;

-- ----------------------------
-- Records of kupac
-- ----------------------------

-- ----------------------------
-- Table structure for `narudzbenica`
-- ----------------------------
DROP TABLE IF EXISTS `narudzbenica`;
CREATE TABLE `narudzbenica` (
  `narudzbenica_id` int(11) NOT NULL auto_increment,
  `kupac_id` int(11) NOT NULL,
  `datum_narudzbe` date NOT NULL,
  PRIMARY KEY  (`narudzbenica_id`),
  KEY `kupac_id` (`kupac_id`),
  CONSTRAINT `kupac_id` FOREIGN KEY (`kupac_id`) REFERENCES `kupac` (`kupac_id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;

-- ----------------------------
-- Records of narudzbenica
-- ----------------------------

-- ----------------------------
-- Table structure for `skladiste`
-- ----------------------------
DROP TABLE IF EXISTS `skladiste`;
CREATE TABLE `skladiste` (
  `id` int(11) NOT NULL auto_increment,
  `artikal_id` int(11) NOT NULL,
  `kolicina_stanje` int(11) default NULL,
  PRIMARY KEY  (`id`),
  KEY `artikal1_id` (`artikal_id`),
  CONSTRAINT `artikal1_id` FOREIGN KEY (`artikal_id`) REFERENCES `artikal` (`artikal_id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;

-- ----------------------------
-- Records of skladiste
-- ----------------------------

-- ----------------------------
-- Table structure for `stavka_narudzbenice`
-- ----------------------------
DROP TABLE IF EXISTS `stavka_narudzbenice`;
CREATE TABLE `stavka_narudzbenice` (
  `stavka_id` int(11) NOT NULL auto_increment,
  `narudzbenica_id` int(11) NOT NULL,
  `artikal_id` int(11) NOT NULL,
  `kolicina` int(11) default NULL,
  PRIMARY KEY  (`stavka_id`),
  KEY `narudzbenica_id` (`narudzbenica_id`),
  KEY `artikal_id` (`artikal_id`),
  CONSTRAINT `narudzbenica_id` FOREIGN KEY (`narudzbenica_id`) REFERENCES `narudzbenica` (`narudzbenica_id`),
  CONSTRAINT `artikal_id` FOREIGN KEY (`artikal_id`) REFERENCES `artikal` (`artikal_id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;

-- ----------------------------
-- Records of stavka_narudzbenice
-- ----------------------------
