-- MySQL Administrator dump 1.4
--
-- ------------------------------------------------------
-- Server version	6.0.4-alpha-community-log


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8 */;

/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;


--
-- Create schema odonto
--

CREATE DATABASE IF NOT EXISTS odonto;
USE odonto;

--
-- Definition of table `doctores`
--

DROP TABLE IF EXISTS `doctores`;
CREATE TABLE `doctores` (
  `id_doctor` int(11) NOT NULL AUTO_INCREMENT,
  `nombre_doctor` varchar(60) DEFAULT NULL,
  `cedula_doctor` int(11) DEFAULT NULL,
  `fechanac_doctor` date DEFAULT NULL,
  `edad_doctor` int(11) DEFAULT NULL,
  `direccion_doctor` text,
  `telefono_doctor` varchar(15) DEFAULT NULL,
  `fecharegistro_doctor` date DEFAULT NULL,
  PRIMARY KEY (`id_doctor`)
) ENGINE=MyISAM AUTO_INCREMENT=3 DEFAULT CHARSET=utf8;

--
-- Dumping data for table `doctores`
--

/*!40000 ALTER TABLE `doctores` DISABLE KEYS */;
INSERT INTO `doctores` (`id_doctor`,`nombre_doctor`,`cedula_doctor`,`fechanac_doctor`,`edad_doctor`,`direccion_doctor`,`telefono_doctor`,`fecharegistro_doctor`) VALUES 
 (1,'Diego Gonzalez',17111050,'1984-11-13',26,'calle principal la rinconada de paraguachi cerca de la escuela','04121953625','2010-06-23');
/*!40000 ALTER TABLE `doctores` ENABLE KEYS */;


--
-- Definition of table `odontograma`
--

DROP TABLE IF EXISTS `odontograma`;
CREATE TABLE `odontograma` (
  `id_odonto` int(11) NOT NULL AUTO_INCREMENT,
  `cedula_persona` int(11) DEFAULT NULL,
  `pieza11_1` char(10) DEFAULT NULL,
  `pieza11_2` char(10) DEFAULT NULL,
  `pieza11_3` char(10) DEFAULT NULL,
  `pieza11_4` char(10) DEFAULT NULL,
  `pieza11_5` char(10) DEFAULT NULL,
  `pieza12_1` char(10) DEFAULT NULL,
  `pieza12_2` char(10) DEFAULT NULL,
  `pieza12_3` char(10) DEFAULT NULL,
  `pieza12_4` char(10) DEFAULT NULL,
  `pieza12_5` char(10) DEFAULT NULL,
  `pieza13_1` char(10) DEFAULT NULL,
  `pieza13_2` char(10) DEFAULT NULL,
  `pieza13_3` char(10) DEFAULT NULL,
  `pieza13_4` char(10) DEFAULT NULL,
  `pieza13_5` char(10) DEFAULT NULL,
  `pieza14_1` char(10) DEFAULT NULL,
  `pieza14_2` char(10) DEFAULT NULL,
  `pieza14_3` char(10) DEFAULT NULL,
  `pieza14_4` char(10) DEFAULT NULL,
  `pieza14_5` char(10) DEFAULT NULL,
  `pieza15_1` char(10) DEFAULT NULL,
  `pieza15_2` char(10) DEFAULT NULL,
  `pieza15_3` char(10) DEFAULT NULL,
  `pieza15_4` char(10) DEFAULT NULL,
  `pieza15_5` char(10) DEFAULT NULL,
  `pieza16_1` char(10) DEFAULT NULL,
  `pieza16_2` char(10) DEFAULT NULL,
  `pieza16_3` char(10) DEFAULT NULL,
  `pieza16_4` char(10) DEFAULT NULL,
  `pieza16_5` char(10) DEFAULT NULL,
  `pieza17_1` char(10) DEFAULT NULL,
  `pieza17_2` char(10) DEFAULT NULL,
  `pieza17_3` char(10) DEFAULT NULL,
  `pieza17_4` char(10) DEFAULT NULL,
  `pieza17_5` char(10) DEFAULT NULL,
  `pieza18_1` char(10) DEFAULT NULL,
  `pieza18_2` char(10) DEFAULT NULL,
  `pieza18_3` char(10) DEFAULT NULL,
  `pieza18_4` char(10) DEFAULT NULL,
  `pieza18_5` char(10) DEFAULT NULL,
  `pieza21_1` char(10) DEFAULT NULL,
  `pieza21_2` char(10) DEFAULT NULL,
  `pieza21_3` char(10) DEFAULT NULL,
  `pieza21_4` char(10) DEFAULT NULL,
  `pieza21_5` char(10) DEFAULT NULL,
  `pieza22_1` char(10) DEFAULT NULL,
  `pieza22_2` char(10) DEFAULT NULL,
  `pieza22_3` char(10) DEFAULT NULL,
  `pieza22_4` char(10) DEFAULT NULL,
  `pieza22_5` char(10) DEFAULT NULL,
  `pieza23_1` char(10) DEFAULT NULL,
  `pieza23_2` char(10) DEFAULT NULL,
  `pieza23_3` char(10) DEFAULT NULL,
  `pieza23_4` char(10) DEFAULT NULL,
  `pieza23_5` char(10) DEFAULT NULL,
  `pieza24_1` char(10) DEFAULT NULL,
  `pieza24_2` char(10) DEFAULT NULL,
  `pieza24_3` char(10) DEFAULT NULL,
  `pieza24_4` char(10) DEFAULT NULL,
  `pieza24_5` char(10) DEFAULT NULL,
  `pieza25_1` char(10) DEFAULT NULL,
  `pieza25_2` char(10) DEFAULT NULL,
  `pieza25_3` char(10) DEFAULT NULL,
  `pieza25_4` char(10) DEFAULT NULL,
  `pieza25_5` char(10) DEFAULT NULL,
  `pieza26_1` char(10) DEFAULT NULL,
  `pieza26_2` char(10) DEFAULT NULL,
  `pieza26_3` char(10) DEFAULT NULL,
  `pieza26_4` char(10) DEFAULT NULL,
  `pieza26_5` char(10) DEFAULT NULL,
  `pieza27_1` char(10) DEFAULT NULL,
  `pieza27_2` char(10) DEFAULT NULL,
  `pieza27_3` char(10) DEFAULT NULL,
  `pieza27_4` char(10) DEFAULT NULL,
  `pieza27_5` char(10) DEFAULT NULL,
  `pieza28_1` char(10) DEFAULT NULL,
  `pieza28_2` char(10) DEFAULT NULL,
  `pieza28_3` char(10) DEFAULT NULL,
  `pieza28_4` char(10) DEFAULT NULL,
  `pieza28_5` char(10) DEFAULT NULL,
  `pieza31_1` char(10) DEFAULT NULL,
  `pieza31_2` char(10) DEFAULT NULL,
  `pieza31_3` char(10) DEFAULT NULL,
  `pieza31_4` char(10) DEFAULT NULL,
  `pieza31_5` char(10) DEFAULT NULL,
  `pieza32_1` char(10) DEFAULT NULL,
  `pieza32_2` char(10) DEFAULT NULL,
  `pieza32_3` char(10) DEFAULT NULL,
  `pieza32_4` char(10) DEFAULT NULL,
  `pieza32_5` char(10) DEFAULT NULL,
  `pieza33_1` char(10) DEFAULT NULL,
  `pieza33_2` char(10) DEFAULT NULL,
  `pieza33_3` char(10) DEFAULT NULL,
  `pieza33_4` char(10) DEFAULT NULL,
  `pieza33_5` char(10) DEFAULT NULL,
  `pieza34_1` char(10) DEFAULT NULL,
  `pieza34_2` char(10) DEFAULT NULL,
  `pieza34_3` char(10) DEFAULT NULL,
  `pieza34_4` char(10) DEFAULT NULL,
  `pieza34_5` char(10) DEFAULT NULL,
  `pieza35_1` char(10) DEFAULT NULL,
  `pieza35_2` char(10) DEFAULT NULL,
  `pieza35_3` char(10) DEFAULT NULL,
  `pieza35_4` char(10) DEFAULT NULL,
  `pieza35_5` char(10) DEFAULT NULL,
  `pieza36_1` char(10) DEFAULT NULL,
  `pieza36_2` char(10) DEFAULT NULL,
  `pieza36_3` char(10) DEFAULT NULL,
  `pieza36_4` char(10) DEFAULT NULL,
  `pieza36_5` char(10) DEFAULT NULL,
  `pieza37_1` char(10) DEFAULT NULL,
  `pieza37_2` char(10) DEFAULT NULL,
  `pieza37_3` char(10) DEFAULT NULL,
  `pieza37_4` char(10) DEFAULT NULL,
  `pieza37_5` char(10) DEFAULT NULL,
  `pieza38_1` char(10) DEFAULT NULL,
  `pieza38_2` char(10) DEFAULT NULL,
  `pieza38_3` char(10) DEFAULT NULL,
  `pieza38_4` char(10) DEFAULT NULL,
  `pieza38_5` char(10) DEFAULT NULL,
  `pieza41_1` char(10) DEFAULT NULL,
  `pieza41_2` char(10) DEFAULT NULL,
  `pieza41_3` char(10) DEFAULT NULL,
  `pieza41_4` char(10) DEFAULT NULL,
  `pieza41_5` char(10) DEFAULT NULL,
  `pieza42_1` char(10) DEFAULT NULL,
  `pieza42_2` char(10) DEFAULT NULL,
  `pieza42_3` char(10) DEFAULT NULL,
  `pieza42_4` char(10) DEFAULT NULL,
  `pieza42_5` char(10) DEFAULT NULL,
  `pieza43_1` char(10) DEFAULT NULL,
  `pieza43_2` char(10) DEFAULT NULL,
  `pieza43_3` char(10) DEFAULT NULL,
  `pieza43_4` char(10) DEFAULT NULL,
  `pieza43_5` char(10) DEFAULT NULL,
  `pieza44_1` char(10) DEFAULT NULL,
  `pieza44_2` char(10) DEFAULT NULL,
  `pieza44_3` char(10) DEFAULT NULL,
  `pieza44_4` char(10) DEFAULT NULL,
  `pieza44_5` char(10) DEFAULT NULL,
  `pieza45_1` char(10) DEFAULT NULL,
  `pieza45_2` char(10) DEFAULT NULL,
  `pieza45_3` char(10) DEFAULT NULL,
  `pieza45_4` char(10) DEFAULT NULL,
  `pieza45_5` char(10) DEFAULT NULL,
  `pieza46_1` char(10) DEFAULT NULL,
  `pieza46_2` char(10) DEFAULT NULL,
  `pieza46_3` char(10) DEFAULT NULL,
  `pieza46_4` char(10) DEFAULT NULL,
  `pieza46_5` char(10) DEFAULT NULL,
  `pieza47_1` char(10) DEFAULT NULL,
  `pieza47_2` char(10) DEFAULT NULL,
  `pieza47_3` char(10) DEFAULT NULL,
  `pieza47_4` char(10) DEFAULT NULL,
  `pieza47_5` char(10) DEFAULT NULL,
  `pieza48_1` char(10) DEFAULT NULL,
  `pieza48_2` char(10) DEFAULT NULL,
  `pieza48_3` char(10) DEFAULT NULL,
  `pieza48_4` char(10) DEFAULT NULL,
  `pieza48_5` char(10) DEFAULT NULL,
  `pieza51_1` char(10) DEFAULT NULL,
  `pieza51_2` char(10) DEFAULT NULL,
  `pieza51_3` char(10) DEFAULT NULL,
  `pieza51_4` char(10) DEFAULT NULL,
  `pieza51_5` char(10) DEFAULT NULL,
  `pieza52_1` char(10) DEFAULT NULL,
  `pieza52_2` char(10) DEFAULT NULL,
  `pieza52_3` char(10) DEFAULT NULL,
  `pieza52_4` char(10) DEFAULT NULL,
  `pieza52_5` char(10) DEFAULT NULL,
  `pieza53_1` char(10) DEFAULT NULL,
  `pieza53_2` char(10) DEFAULT NULL,
  `pieza53_3` char(10) DEFAULT NULL,
  `pieza53_4` char(10) DEFAULT NULL,
  `pieza53_5` char(10) DEFAULT NULL,
  `pieza54_1` char(10) DEFAULT NULL,
  `pieza54_2` char(10) DEFAULT NULL,
  `pieza54_3` char(10) DEFAULT NULL,
  `pieza54_4` char(10) DEFAULT NULL,
  `pieza54_5` char(10) DEFAULT NULL,
  `pieza55_1` char(10) DEFAULT NULL,
  `pieza55_2` char(10) DEFAULT NULL,
  `pieza55_3` char(10) DEFAULT NULL,
  `pieza55_4` char(10) DEFAULT NULL,
  `pieza55_5` char(10) DEFAULT NULL,
  `pieza61_1` char(10) DEFAULT NULL,
  `pieza61_2` char(10) DEFAULT NULL,
  `pieza61_3` char(10) DEFAULT NULL,
  `pieza61_4` char(10) DEFAULT NULL,
  `pieza61_5` char(10) DEFAULT NULL,
  `pieza62_1` char(10) DEFAULT NULL,
  `pieza62_2` char(10) DEFAULT NULL,
  `pieza62_3` char(10) DEFAULT NULL,
  `pieza62_4` char(10) DEFAULT NULL,
  `pieza62_5` char(10) DEFAULT NULL,
  `pieza63_1` char(10) DEFAULT NULL,
  `pieza63_2` char(10) DEFAULT NULL,
  `pieza63_3` char(10) DEFAULT NULL,
  `pieza63_4` char(10) DEFAULT NULL,
  `pieza63_5` char(10) DEFAULT NULL,
  `pieza64_1` char(10) DEFAULT NULL,
  `pieza64_2` char(10) DEFAULT NULL,
  `pieza64_3` char(10) DEFAULT NULL,
  `pieza64_4` char(10) DEFAULT NULL,
  `pieza64_5` char(10) DEFAULT NULL,
  `pieza65_1` char(10) DEFAULT NULL,
  `pieza65_2` char(10) DEFAULT NULL,
  `pieza65_3` char(10) DEFAULT NULL,
  `pieza65_4` char(10) DEFAULT NULL,
  `pieza65_5` char(10) DEFAULT NULL,
  `pieza71_1` char(10) DEFAULT NULL,
  `pieza71_2` char(10) DEFAULT NULL,
  `pieza71_3` char(10) DEFAULT NULL,
  `pieza71_4` char(10) DEFAULT NULL,
  `pieza71_5` char(10) DEFAULT NULL,
  `pieza72_1` char(10) DEFAULT NULL,
  `pieza72_2` char(10) DEFAULT NULL,
  `pieza72_3` char(10) DEFAULT NULL,
  `pieza72_4` char(10) DEFAULT NULL,
  `pieza72_5` char(10) DEFAULT NULL,
  `pieza73_1` char(10) DEFAULT NULL,
  `pieza73_2` char(10) DEFAULT NULL,
  `pieza73_3` char(10) DEFAULT NULL,
  `pieza73_4` char(10) DEFAULT NULL,
  `pieza73_5` char(10) DEFAULT NULL,
  `pieza74_1` char(10) DEFAULT NULL,
  `pieza74_2` char(10) DEFAULT NULL,
  `pieza74_3` char(10) DEFAULT NULL,
  `pieza74_4` char(10) DEFAULT NULL,
  `pieza74_5` char(10) DEFAULT NULL,
  `pieza75_1` char(10) DEFAULT NULL,
  `pieza75_2` char(10) DEFAULT NULL,
  `pieza75_3` char(10) DEFAULT NULL,
  `pieza75_4` char(10) DEFAULT NULL,
  `pieza75_5` char(10) DEFAULT NULL,
  `pieza81_1` char(10) DEFAULT NULL,
  `pieza81_2` char(10) DEFAULT NULL,
  `pieza81_3` char(10) DEFAULT NULL,
  `pieza81_4` char(10) DEFAULT NULL,
  `pieza81_5` char(10) DEFAULT NULL,
  `pieza82_1` char(10) DEFAULT NULL,
  `pieza82_2` char(10) DEFAULT NULL,
  `pieza82_3` char(10) DEFAULT NULL,
  `pieza82_4` char(10) DEFAULT NULL,
  `pieza82_5` char(10) DEFAULT NULL,
  `pieza83_1` char(10) DEFAULT NULL,
  `pieza83_2` char(10) DEFAULT NULL,
  `pieza83_3` char(10) DEFAULT NULL,
  `pieza83_4` char(10) DEFAULT NULL,
  `pieza83_5` char(10) DEFAULT NULL,
  `pieza84_1` char(10) DEFAULT NULL,
  `pieza84_2` char(10) DEFAULT NULL,
  `pieza84_3` char(10) DEFAULT NULL,
  `pieza84_4` char(10) DEFAULT NULL,
  `pieza84_5` char(10) DEFAULT NULL,
  `pieza85_1` char(10) DEFAULT NULL,
  `pieza85_2` char(10) DEFAULT NULL,
  `pieza85_3` char(10) DEFAULT NULL,
  `pieza85_4` char(10) DEFAULT NULL,
  `pieza85_5` char(10) DEFAULT NULL,
  PRIMARY KEY (`id_odonto`)
) ENGINE=MyISAM AUTO_INCREMENT=14 DEFAULT CHARSET=utf8;

--
-- Dumping data for table `odontograma`
--

/*!40000 ALTER TABLE `odontograma` DISABLE KEYS */;
INSERT INTO `odontograma` (`id_odonto`,`cedula_persona`,`pieza11_1`,`pieza11_2`,`pieza11_3`,`pieza11_4`,`pieza11_5`,`pieza12_1`,`pieza12_2`,`pieza12_3`,`pieza12_4`,`pieza12_5`,`pieza13_1`,`pieza13_2`,`pieza13_3`,`pieza13_4`,`pieza13_5`,`pieza14_1`,`pieza14_2`,`pieza14_3`,`pieza14_4`,`pieza14_5`,`pieza15_1`,`pieza15_2`,`pieza15_3`,`pieza15_4`,`pieza15_5`,`pieza16_1`,`pieza16_2`,`pieza16_3`,`pieza16_4`,`pieza16_5`,`pieza17_1`,`pieza17_2`,`pieza17_3`,`pieza17_4`,`pieza17_5`,`pieza18_1`,`pieza18_2`,`pieza18_3`,`pieza18_4`,`pieza18_5`,`pieza21_1`,`pieza21_2`,`pieza21_3`,`pieza21_4`,`pieza21_5`,`pieza22_1`,`pieza22_2`,`pieza22_3`,`pieza22_4`,`pieza22_5`,`pieza23_1`,`pieza23_2`,`pieza23_3`,`pieza23_4`,`pieza23_5`,`pieza24_1`,`pieza24_2`,`pieza24_3`,`pieza24_4`,`pieza24_5`,`pieza25_1`,`pieza25_2`,`pieza25_3`,`pieza25_4`,`pieza25_5`,`pieza26_1`,`pieza26_2`,`pieza26_3`,`pieza26_4`,`pieza26_5`,`pieza27_1`,`pieza27_2`,`pieza27_3`,`pieza27_4`,`pieza27_5`,`pieza28_1`,`pieza28_2`,`pieza28_3`,`pieza28_4`,`pieza28_5`,`pieza31_1`,`pieza31_2`,`pieza31_3`,`pieza31_4`,`pieza31_5`,`pieza32_1`,`pieza32_2`,`pieza32_3`,`pieza32_4`,`pieza32_5`,`pieza33_1`,`pieza33_2`,`pieza33_3`,`pieza33_4`,`pieza33_5`,`pieza34_1`,`pieza34_2`,`pieza34_3`,`pieza34_4`,`pieza34_5`,`pieza35_1`,`pieza35_2`,`pieza35_3`,`pieza35_4`,`pieza35_5`,`pieza36_1`,`pieza36_2`,`pieza36_3`,`pieza36_4`,`pieza36_5`,`pieza37_1`,`pieza37_2`,`pieza37_3`,`pieza37_4`,`pieza37_5`,`pieza38_1`,`pieza38_2`,`pieza38_3`,`pieza38_4`,`pieza38_5`,`pieza41_1`,`pieza41_2`,`pieza41_3`,`pieza41_4`,`pieza41_5`,`pieza42_1`,`pieza42_2`,`pieza42_3`,`pieza42_4`,`pieza42_5`,`pieza43_1`,`pieza43_2`,`pieza43_3`,`pieza43_4`,`pieza43_5`,`pieza44_1`,`pieza44_2`,`pieza44_3`,`pieza44_4`,`pieza44_5`,`pieza45_1`,`pieza45_2`,`pieza45_3`,`pieza45_4`,`pieza45_5`,`pieza46_1`,`pieza46_2`,`pieza46_3`,`pieza46_4`,`pieza46_5`,`pieza47_1`,`pieza47_2`,`pieza47_3`,`pieza47_4`,`pieza47_5`,`pieza48_1`,`pieza48_2`,`pieza48_3`,`pieza48_4`,`pieza48_5`,`pieza51_1`,`pieza51_2`,`pieza51_3`,`pieza51_4`,`pieza51_5`,`pieza52_1`,`pieza52_2`,`pieza52_3`,`pieza52_4`,`pieza52_5`,`pieza53_1`,`pieza53_2`,`pieza53_3`,`pieza53_4`,`pieza53_5`,`pieza54_1`,`pieza54_2`,`pieza54_3`,`pieza54_4`,`pieza54_5`,`pieza55_1`,`pieza55_2`,`pieza55_3`,`pieza55_4`,`pieza55_5`,`pieza61_1`,`pieza61_2`,`pieza61_3`,`pieza61_4`,`pieza61_5`,`pieza62_1`,`pieza62_2`,`pieza62_3`,`pieza62_4`,`pieza62_5`,`pieza63_1`,`pieza63_2`,`pieza63_3`,`pieza63_4`,`pieza63_5`,`pieza64_1`,`pieza64_2`,`pieza64_3`,`pieza64_4`,`pieza64_5`,`pieza65_1`,`pieza65_2`,`pieza65_3`,`pieza65_4`,`pieza65_5`,`pieza71_1`,`pieza71_2`,`pieza71_3`,`pieza71_4`,`pieza71_5`,`pieza72_1`,`pieza72_2`,`pieza72_3`,`pieza72_4`,`pieza72_5`,`pieza73_1`,`pieza73_2`,`pieza73_3`,`pieza73_4`,`pieza73_5`,`pieza74_1`,`pieza74_2`,`pieza74_3`,`pieza74_4`,`pieza74_5`,`pieza75_1`,`pieza75_2`,`pieza75_3`,`pieza75_4`,`pieza75_5`,`pieza81_1`,`pieza81_2`,`pieza81_3`,`pieza81_4`,`pieza81_5`,`pieza82_1`,`pieza82_2`,`pieza82_3`,`pieza82_4`,`pieza82_5`,`pieza83_1`,`pieza83_2`,`pieza83_3`,`pieza83_4`,`pieza83_5`,`pieza84_1`,`pieza84_2`,`pieza84_3`,`pieza84_4`,`pieza84_5`,`pieza85_1`,`pieza85_2`,`pieza85_3`,`pieza85_4`,`pieza85_5`) VALUES 
 (13,17111050,'','','','Label39-R','','Label31-R','Label32-C','Label33-C','Label34-C','Label35-R','','','','','','','','','','','','','','Label19-C','','','','','Label14-C','','','','','','','','','','','','','','','Label44-R','','','','','','','','','','Label54-C','','','','','Label59-R','','','','','Label64-R','','','','','','','','','','','','','','','','','','','','Label219-C','','','','','','','','','','','','','','','','','','','','','','','','','','','','','','','','Label181-C','Label182-C','Label183-R','Label184-R','Label185-R','','','','Label224-C','','','','','Label229-C','','','','','','','','','','','','','','','','','','','','','','','','','','','','','','','','','','','','','','','','Label99-R','','','','','','','','','','Label89-C','','','','','','','','','','','','','','','Label114-C','','','','','Label119-R','','','','','','','','','','','','','','','','','','','','Label174-C','','','','','','','','','','','','','','','','','','','','Label134-C','','','','','','','','','','Label144-C','','','','','','','','','','',''),
 (12,17417958,'','','','','','','','','','','','','','','','','','','','','','','','Label19-C','','','','','Label14-C','','','','','','','','','','','','','','','Label44-R','','','','','','','','','','Label54-C','','','','','Label59-R','','','','','Label64-R','','','','','','','','','','','','','','','','','','','','Label219-C','','','','','','','','','','','','','','','','','','','','','','','','','','','','','','','','Label181-C','Label182-C','Label183-R','Label184-R','Label185-R','','','','Label224-C','','','','','Label229-C','','','','','','','','','','','','','','','','','','','','','','','','','','','','','','','','','','','','','','','','Label99-R','','','','','','','','','','Label89-C','','','','','','','','','','','','','','','Label114-C','','','','','Label119-R','','','','','','','','','','','','','','','','','','','','Label174-C','','','','','','','','','','','','','','','','','','','','Label134-C','','','','','Label139-R','','','','','Label144-C','','','','','','','','','','','');
/*!40000 ALTER TABLE `odontograma` ENABLE KEYS */;


--
-- Definition of table `personas`
--

DROP TABLE IF EXISTS `personas`;
CREATE TABLE `personas` (
  `id_persona` int(11) NOT NULL AUTO_INCREMENT,
  `nombre_persona` varchar(100) DEFAULT NULL,
  `cedula_persona` int(11) DEFAULT NULL,
  `fechanac_persona` date DEFAULT NULL,
  `edad_persona` int(11) DEFAULT NULL,
  `fecha_persona` date DEFAULT NULL,
  `representante_persona` varchar(100) DEFAULT NULL,
  `telefono_persona` varchar(15) DEFAULT NULL,
  `direccion_persona` text,
  `alergico_persona` text,
  `hismedica_persona` text,
  `histodonto_persona` text,
  PRIMARY KEY (`id_persona`),
  UNIQUE KEY `id_persona` (`id_persona`)
) ENGINE=MyISAM AUTO_INCREMENT=6 DEFAULT CHARSET=utf8;

--
-- Dumping data for table `personas`
--

/*!40000 ALTER TABLE `personas` DISABLE KEYS */;
INSERT INTO `personas` (`id_persona`,`nombre_persona`,`cedula_persona`,`fechanac_persona`,`edad_persona`,`fecha_persona`,`representante_persona`,`telefono_persona`,`direccion_persona`,`alergico_persona`,`hismedica_persona`,`histodonto_persona`) VALUES 
 (1,'diego jose gonzalez rosas',17111050,'1983-11-11',26,'2010-06-14','diego gonzalez','134123123','modificado otra vez','otra modificacion','nuevo dato','dfsdf'),
 (2,'sdfsd',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),
 (4,'jose',17111053,'2010-06-15',0,'2010-06-15','gonzalez','123123','emdfnsjdnfjsdnf','sdfnsjdfnsd','dfsdf','sdfsdfsdf'),
 (5,'maria fermin',17417958,'1984-10-29',26,'2010-06-21','diego gonzalez','041223423423','calle principal  la rinconada de paraguachi','mentiolate','sdcsd','estos datos fue modificados');
/*!40000 ALTER TABLE `personas` ENABLE KEYS */;


--
-- Definition of table `usuarios`
--

DROP TABLE IF EXISTS `usuarios`;
CREATE TABLE `usuarios` (
  `id_usuarios` int(10) unsigned NOT NULL AUTO_INCREMENT,
  `nombre_usuario` varchar(45) NOT NULL,
  `apellido_usuario` varchar(45) NOT NULL,
  `cedula_usuario` int(11) NOT NULL,
  `telefono_usuario` varchar(45) NOT NULL,
  `user_usuario` varchar(45) NOT NULL,
  `pass_usuario` varchar(45) NOT NULL,
  `Nivel_usuario` varchar(45) NOT NULL,
  `direccion_usuario` varchar(45) NOT NULL,
  PRIMARY KEY (`id_usuarios`)
) ENGINE=InnoDB AUTO_INCREMENT=3 DEFAULT CHARSET=utf8;

--
-- Dumping data for table `usuarios`
--

/*!40000 ALTER TABLE `usuarios` DISABLE KEYS */;
INSERT INTO `usuarios` (`id_usuarios`,`nombre_usuario`,`apellido_usuario`,`cedula_usuario`,`telefono_usuario`,`user_usuario`,`pass_usuario`,`Nivel_usuario`,`direccion_usuario`) VALUES 
 (1,'','',0,'','admin','1234','',''),
 (2,'diego','gonzalez',17111050,'04121953625','diego','d17111050','Administrador','la rincoanda de paraguachi');
/*!40000 ALTER TABLE `usuarios` ENABLE KEYS */;




/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
