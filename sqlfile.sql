-- MySQL dump 10.13  Distrib 8.0.12, for Win64 (x86_64)
--
-- Host: localhost    Database: ktv
-- ------------------------------------------------------
-- Server version	8.0.12

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
 SET NAMES utf8 ;
/*!40103 SET @OLD_TIME_ZONE=@@TIME_ZONE */;
/*!40103 SET TIME_ZONE='+00:00' */;
/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;

--
-- Table structure for table `singer`
--

DROP TABLE IF EXISTS `singer`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
 SET character_set_client = utf8mb4 ;
CREATE TABLE `singer` (
  `singerid` int(11) NOT NULL AUTO_INCREMENT,
  `singername` varchar(45) CHARACTER SET utf8 COLLATE utf8_unicode_ci DEFAULT NULL,
  `photopath` varchar(600) CHARACTER SET utf8 COLLATE utf8_unicode_ci DEFAULT NULL,
  `singercategory` varchar(45) CHARACTER SET utf8 COLLATE utf8_unicode_ci DEFAULT NULL,
  PRIMARY KEY (`singerid`),
  UNIQUE KEY `singerid_UNIQUE` (`singerid`)
) ENGINE=InnoDB AUTO_INCREMENT=38 DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `singer`
--

LOCK TABLES `singer` WRITE;
/*!40000 ALTER TABLE `singer` DISABLE KEYS */;
INSERT INTO `singer` VALUES (1,'华晨宇','..\\..\\..\\media\\singer\\华晨宇.jpg','男歌手'),(2,'林俊杰','..\\..\\..\\media\\singer\\林俊杰.jpg','男歌手'),(3,'beyond','..\\..\\..\\media\\singer\\beyond.jpg','组合'),(4,'五月天','..\\..\\..\\media\\singer\\五月天.jpg','组合'),(7,'苏打绿','..\\..\\..\\media\\singer\\苏打绿.jpg','组合'),(8,'王菲','..\\..\\..\\media\\singer\\王菲.jpg','女歌手'),(9,'陈奕迅','..\\..\\..\\media\\singer\\陈奕迅.jpg','男歌手'),(10,'Tino Coury','..\\..\\..\\media\\singer\\Tino Coury.jpg','男歌手'),(11,'陈悦','..\\..\\..\\media\\singer\\陈悦.jpg','女歌手'),(12,'郑智化','..\\..\\..\\media\\singer\\郑智化.jpg','男歌手'),(13,'银临','..\\..\\..\\media\\singer\\银临.jpg','男歌手'),(14,'林志炫','..\\..\\..\\media\\singer\\林志炫.jpg','男歌手'),(15,'排骨教主','..\\..\\..\\media\\singer\\排骨教主.jpg','男歌手'),(16,'小虎队','..\\..\\..\\media\\singer\\小虎队.jpg','组合'),(17,'许冠杰','..\\..\\..\\media\\singer\\许冠杰.jpg','男歌手'),(18,'张雨生','..\\..\\..\\media\\singer\\张雨生.jpg','男歌手'),(19,'刘德华','..\\..\\..\\media\\singer\\刘德华.jpg','男歌手'),(21,'余少群','..\\..\\..\\media\\singer\\余少群.jpg','男歌手'),(22,'张国荣','..\\..\\..\\media\\singer\\张国荣.jpg','男歌手'),(23,'郭兰英','..\\..\\..\\media\\singer\\郭兰英.jpg','女歌手'),(24,'叶丽仪','..\\..\\..\\media\\singer\\叶丽仪.jpg','女歌手'),(25,'孙燕姿','..\\..\\..\\media\\singer\\孙燕姿.jpg','女歌手'),(26,'玖月奇迹','..\\..\\..\\media\\singer\\玖月奇迹.jpg','组合'),(27,'Taylor Swift','..\\..\\..\\media\\singer\\Taylor Swift.jpg','女歌手'),(28,'Lady GaGa','..\\..\\..\\media\\singer\\Lady GaGa.jpg','女歌手'),(29,'米津玄师','..\\..\\..\\media\\singer\\米津玄师.jpg','男歌手'),(30,'Fool\'s Garden','..\\..\\..\\media\\singer\\Fool\'s Garden.jpg','组合'),(31,'萧敬腾','..\\..\\..\\media\\singer\\萧敬腾.jpg','男歌手'),(32,'杨宗纬','..\\..\\..\\media\\singer\\杨宗纬.jpg','男歌手'),(33,'赵雷','..\\..\\..\\media\\singer\\赵雷.jpg','男歌手'),(34,'周杰伦','..\\..\\..\\media\\singer\\周杰伦.jpg','男歌手'),(35,'张学友','..\\..\\..\\media\\singer\\张学友.jpg','男歌手'),(36,'孙燕姿','..\\..\\..\\media\\singer\\孙燕姿.jpg','女歌手'),(37,'花泽香菜','..\\..\\..\\media\\singer\\花泽香菜.jpg','女歌手');
/*!40000 ALTER TABLE `singer` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `song`
--

DROP TABLE IF EXISTS `song`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
 SET character_set_client = utf8mb4 ;
CREATE TABLE `song` (
  `songid` int(11) NOT NULL AUTO_INCREMENT,
  `songname` varchar(45) CHARACTER SET utf8 COLLATE utf8_unicode_ci NOT NULL,
  `songtype` varchar(45) CHARACTER SET utf8 COLLATE utf8_unicode_ci DEFAULT NULL,
  `songtopic` varchar(45) CHARACTER SET utf8 COLLATE utf8_unicode_ci DEFAULT NULL,
  `songgenre` varchar(45) CHARACTER SET utf8 COLLATE utf8_unicode_ci DEFAULT NULL,
  `songpinyin` varchar(45) CHARACTER SET utf8 COLLATE utf8_unicode_ci DEFAULT NULL,
  `language` varchar(45) CHARACTER SET utf8 COLLATE utf8_unicode_ci DEFAULT NULL,
  `path` varchar(600) CHARACTER SET utf8 COLLATE utf8_unicode_ci DEFAULT NULL,
  `singerid` int(11) DEFAULT NULL,
  PRIMARY KEY (`songid`),
  UNIQUE KEY `songid_UNIQUE` (`songid`),
  KEY `singerid_idx` (`singerid`),
  CONSTRAINT `singerid` FOREIGN KEY (`singerid`) REFERENCES `singer` (`singerid`)
) ENGINE=InnoDB AUTO_INCREMENT=62 DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `song`
--

LOCK TABLES `song` WRITE;
/*!40000 ALTER TABLE `song` DISABLE KEYS */;
INSERT INTO `song` VALUES (1,'我管你','励志','经典','摇滚','WGN','华语','http://120.192.82.54/hd.yinyuetai.com/uploads/videos/common/2FDD015ACFE6AAF75A2712880F9E2CF2.mp4',1),(2,'齐天','兴奋','经典','流行','QT','华语','http://120.192.82.54/hd.yinyuetai.com/uploads/videos/common/2409015C75F181E022A8594EF9F15D4D.mp4',1),(3,'蜉蝣','励志','经典','流行','ALSDGN','华语','http://120.192.82.54/hd.yinyuetai.com/uploads/videos/common/81A70151229E1D20BEEB729C565831D7.flv',1),(5,'轨迹','伤感','经典','流行','GJ','华语','http://120.192.82.54/hd.yinyuetai.com/uploads/videos/common/958501662996C0C511C571E10C6B2353.mp4',34),(6,'凉凉','伤感','经典','古典','LL','华语','http://120.192.82.54/hd.yinyuetai.com/uploads/videos/common/CB940159833EA69014A884FE522695BC.mp4',32),(7,'成都','伤感','经典','民谣','CD','华语','http://120.192.82.54/hd.yinyuetai.com/uploads/videos/common/BC7301662EE8054965F3CD0CC647EDEC.mp4',33),(8,'我醒着做梦','伤感','经典','流行','WXZZM','华语','http://211.136.65.147/cache/hc.yinyuetai.com/uploads/videos/common/33F9016624976D891D0A2717D983C727.mp4?ich_args2=115-10191209028152_d9ddc896b55f354e00465583330dcbe4_10307403_9c89602bd6c2f9d69539518939a83798_710d93d1269c96826edc71a35fa26d03',35),(9,'寒鸦少年','兴奋','经典','摇滚','HYSN','华语','http://120.192.82.54/hd.yinyuetai.com/uploads/videos/common/48FC01658925E2362240B6F1E2009883.mp4',1),(12,'王妃','兴奋','经典','摇滚','WF','华语','http://120.192.82.54/hd.yinyuetai.com/uploads/videos/common/69080163DFD96E6393CE7381F78605D6.mp4',31),(13,'因为爱情','甜蜜','经典','流行','YWAQ','华语','http://120.192.82.54/hd.yinyuetai.com/uploads/videos/common/308E0144F7B2E40A1D5BA61CF4ACB805.flv',9),(14,'倔强','励志','经典','摇滚','JJ','华语','http://120.192.82.54/hd.yinyuetai.com/uploads/videos/common/60C8013F5F08CE7A8550A0E6A3BA64AB.flv',4),(15,'伤心的人别听慢歌','兴奋','经典','摇滚','SXDRBTMG','华语','http://120.192.82.54/hd.yinyuetai.com/uploads/videos/common/70C7013F28EBF65C5CED89C24322137C.flv',4),(16,'后来的我们','伤感','经典','流行','HLDWM','华语','http://120.192.82.54/hd.yinyuetai.com/uploads/videos/common/B11C01560DE2E62B4F498A1E9EB64659.flv',4),(17,'故事','伤感','经典','流行','GS','华语','http://120.192.82.54/hd.yinyuetai.com/uploads/videos/common/49E00142E421A7AA73FECB2410E7D9CC.flv',7),(18,'我好想你','伤感','经典','流行','WHXN','华语','http://120.192.82.54/hd.yinyuetai.com/uploads/videos/common/C2DE013F4FAC9E1324D6C93DC4C48164.flv',7),(19,'无与伦比的美丽','甜蜜','轻音乐','流行','WYLBDML','华语','http://120.192.82.54/hc.yinyuetai.com/uploads/videos/common/9E060133435B0130822DF724FC957BBD.flv',7),(20,'小情歌','甜蜜','经典','流行','XQG','华语','http://120.192.82.54/hd.yinyuetai.com/uploads/videos/common/1962013EE5957F4DE3EABE1C18F18A08.flv',7),(21,'阿里山的姑娘','甜蜜','经典','民谣','ALSDGN','华语','http://120.192.82.54/hd.yinyuetai.com/uploads/videos/common/C0DA014822E37C55EC516EC13AD0B456.flv',26),(32,'绿光','甜蜜','经典','流行','LG','华语','http://120.192.82.54/hd.yinyuetai.com/uploads/videos/common/7E10014434C8D8C28A086A22FD587BC2.flv',25),(33,'上海滩','伤感','经典','流行','SHT','华语','http://120.192.82.54/hc.yinyuetai.com/uploads/videos/common/18CE012B96B01079AF007CF2A200ADFE.flv',24),(34,'南泥湾','兴奋','经典','民谣','NNW','华语','http://120.192.82.54/hd.yinyuetai.com/uploads/videos/common/F7C901634D2C3301C30E929B8C2793CC.mp4',23),(35,'胭脂扣','伤感','经典','流行','YZK','华语','http://120.192.82.54/hc.yinyuetai.com/uploads/videos/common/F4D001387B924AC4C80F7E56629572A2.flv',22),(36,'枉凝眉','伤感','经典','古典','WNM','华语','http://120.192.82.54/hc.yinyuetai.com/uploads/videos/common/E5CF0166057E39A0B0D647F8EED7610C.mp4',21),(37,'光辉岁月','励志','经典','流行','GHSY','粤语','http://120.192.82.54/hd.yinyuetai.com/uploads/videos/common/F76401666718E21201C3ED04C0F2695D.mp4',3),(38,'十年','伤感','经典','流行','SN','粤语','http://120.192.82.54/hc.yinyuetai.com/uploads/videos/common/0DFD015D53DC09AC1A7946700D830153.mp4',9),(40,'江南','甜蜜','经典','流行','JN','华语','http://120.192.82.54/hd.yinyuetai.com/uploads/videos/common/B8D1015E08D89C29223A478BBE768930.mp4',2),(41,'海阔天空','励志','经典','流行','HKTK','粤语','http://120.192.82.54/hd.yinyuetai.com/uploads/videos/common/B7B20167E4333CDCAA76F72E588E8583.mp4',3),(42,'小酒窝','甜蜜','经典','流行','XJW','华语','http://120.192.82.54/hc.yinyuetai.com/uploads/videos/common/B41CF3A302D284F937542A685B9FB459.flv',2),(43,'红豆','伤感','经典','流行','HD','华语','http://120.192.82.54/hd.yinyuetai.com/uploads/videos/common/021C013B65DAE154E28B527723B32276.flv ',8),(44,'忘情水','伤感','经典','流行','WQS','华语','http://120.192.82.54/hc.yinyuetai.com/uploads/videos/common/C3C001361938F58B8A9697B10E2D9808.flv',19),(45,'我的未来不是梦','励志','经典','流行','WDWLBSM','华语','http://223.82.247.121/hd.yinyuetai.com/uploads/videos/common/812E0163400C5DD2744A9A494F5B2345.mp4',18),(46,'沧海一声笑','励志','经典','流行','CHYSX','华语','http://120.192.82.54/hc.yinyuetai.com/uploads/videos/common/150A0161E1DA4B51F519F58BB1103042.mp4',16),(47,'再见','伤感','经典','流行','ZJ','华语','http://120.192.82.54/hc.yinyuetai.com/uploads/videos/common/B878EA06488B021327FB47D6BD3EE2DD.flv',17),(48,'浮夸','伤感','经典','流行','FK','华语','http://120.192.82.54/hd.yinyuetai.com/uploads/videos/common/63420164A90EA6F96DA0DBC3D3C93FC3.mp4',9),(49,'牵丝戏','伤感','翻唱','古风','QSX','华语','http://120.192.82.54/hd.yinyuetai.com/uploads/videos/common/DE48015702E3CC0C10093E5EE2A8D9BE.flv',15),(50,'单身情歌','伤感','经典','流行','DSQG','华语','http://hd.yinyuetai.com/uploads/videos/common/5055014D933EE3A360A6B71FC1534ACD.flv',14),(51,'腐草为萤','伤感','翻唱','流行','FCWY','华语','http://120.192.82.54/hd.yinyuetai.com/uploads/videos/common/48E80140AA7DB63BB6184C0227B78916.flv',13),(52,'水手','励志','经典','流行','SS','华语','http://120.192.82.54/hc.yinyuetai.com/uploads/videos/common/4C0101655DA0BE29DC83A0DB9C942D13.mp4',12),(53,'绿野仙踪','兴奋','轻音乐','流行','LYXZ','华语','http://120.192.82.54/hd.yinyuetai.com/uploads/videos/common/2834014509AD3FB600D84F54A4027993.flv',11),(54,'I Know You Were Trouble','兴奋','经典','流行','IKYWT','欧美','http://120.192.82.54/hd.yinyuetai.com/uploads/videos/common/4A91013BFDDB8592636EED245675C9E4.flv',27),(55,'Delicate','伤感','经典','流行','D','欧美','http://120.192.82.54/hd.yinyuetai.com/uploads/videos/common/E1BD01621802467663CD8D93EF2998BB.mp4',27),(56,'Always Remember Us This Way','伤感','经典','流行','ARUTW','欧美','http://120.192.82.54/hd.yinyuetai.com/uploads/videos/common/15C30166FB5EE0AE4B46506443A710E3.mp4',28),(57,'Bad Romance','兴奋','经典','流行','BR','欧美','http://120.192.82.54/hd.yinyuetai.com/uploads/videos/common/71D3015EAD9F0574C569DC10827C12CD.mp4',28),(58,'恋爱循环','甜蜜','轻音乐','流行','LAXH','日语','http://120.192.82.54/hc.yinyuetai.com/uploads/videos/common/04470167BB62C92B42C9F03AEF998D33.mp4',37),(59,'lemon','励志','经典','流行','L','日语','http://120.192.82.54/hc.yinyuetai.com/uploads/videos/common/29790167CF0169CC7A0B853624D7F52F.mp4',29),(60,'lemon','甜蜜','轻音乐','流行','L','欧美','http://120.192.82.54/hd.yinyuetai.com/uploads/videos/common/C1EC015B74ED5D2542E952B165558D57.mp4',30),(61,'Back To Life','兴奋','经典','流行','BTL','欧美','http://120.192.82.54/hc.yinyuetai.com/uploads/videos/common/CFDC01385B628824AA625DFD4873862E.flv',10);
/*!40000 ALTER TABLE `song` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2019-05-06 17:30:40
