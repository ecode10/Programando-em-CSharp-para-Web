# MySQL-Front Dump 2.5
#
# Host: localhost   Database: bd_primeiraaplicacao
# --------------------------------------------------------
# Server version 4.0.16-nt


#
# Table structure for table 'tb_usuario'
#

DROP TABLE IF EXISTS `tb_usuario`;
CREATE TABLE `tb_usuario` (
  `ch_usu` int(3) unsigned NOT NULL auto_increment,
  `no_usu` varchar(255) NOT NULL default '',
  `email_usu` varchar(255) NOT NULL default '',
  PRIMARY KEY  (`ch_usu`),
  KEY `ch_usu` (`ch_usu`)
) TYPE=InnoDB;



#
# Dumping data for table 'tb_usuario'
#

INSERT INTO `tb_usuario` (`ch_usu`, `no_usu`, `email_usu`) VALUES("1", "Mauricio", "mauricio@ascompras.cm");
INSERT INTO `tb_usuario` (`ch_usu`, `no_usu`, `email_usu`) VALUES("2", "Mauricio", "mauricio@ascompras.cm");
INSERT INTO `tb_usuario` (`ch_usu`, `no_usu`, `email_usu`) VALUES("3", "Mauricio", "mauricio@ascompras.cm");
INSERT INTO `tb_usuario` (`ch_usu`, `no_usu`, `email_usu`) VALUES("4", "Mauricio", "mauricio@ascompras.cm");
