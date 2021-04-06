-- MySQL dump 10.13  Distrib 8.0.19, for Win64 (x86_64)
--
-- Host: 127.0.0.1    Database: demo_exam
-- ------------------------------------------------------
-- Server version	8.0.19

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!50503 SET NAMES utf8 */;
/*!40103 SET @OLD_TIME_ZONE=@@TIME_ZONE */;
/*!40103 SET TIME_ZONE='+00:00' */;
/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;

--
-- Table structure for table `course`
--

DROP TABLE IF EXISTS `course`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `course` (
  `course_id` varchar(8) NOT NULL,
  `course` varchar(30) CHARACTER SET utf8 COLLATE utf8_general_ci DEFAULT NULL,
  `credit` int DEFAULT NULL,
  `classroom` varchar(100) DEFAULT NULL,
  `schedule` varchar(30) CHARACTER SET utf8 COLLATE utf8_general_ci DEFAULT NULL,
  `enrollment` int DEFAULT NULL,
  `faculty_id` varchar(6) DEFAULT NULL,
  PRIMARY KEY (`course_id`),
  KEY `fk_course_faculty_idx` (`faculty_id`),
  CONSTRAINT `fk_course_faculty` FOREIGN KEY (`faculty_id`) REFERENCES `faculty` (`faculty_id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `course`
--

LOCK TABLES `course` WRITE;
/*!40000 ALTER TABLE `course` DISABLE KEYS */;
INSERT INTO `course` VALUES ('CSC-131A','Computers in Society',3,'TC-109','M-W-F: 9:00-9:55 AM',28,'A52990'),('CSC-131B','Computers in Society',3,'TC-114','M-W-F: 9:00-9:55 AM',20,'B66750'),('CSC-131C','Computers in Society',3,'TC-109','T-H: 11:00-12:25 PM',25,'A52990'),('CSC-131D','Computers in Society',3,'TC-109','M-W-F: 9:00-9:55 AM',30,'B86590'),('CSC-131E','Computers in Society',3,'TC-301','M-W-F: 1:00-1:55 PM',25,'B66750'),('CSC-131I','Computers in Society',3,'TC-109','T-H: 1:00-2:25 PM',32,'A52990'),('CSC-132A','Introduction to Programming',3,'TC-303','M-W-F: 9:00-9:55 AM',21,'J33486'),('CSC-132B','Introduction to Programming',3,'TC-302','T-H: 1:00-2:25 PM',21,'B78880'),('CSC-230','Algorithms & Structures',3,'TC-301','M-W-F: 1:00-1:55 PM',20,'A77587'),('CSC-232A','Programming I',3,'TC-305','T-H: 11:00-12:25 PM',28,'B66750'),('CSC-232B','Programming I',3,'TC-303','T-H: 11:00-12:25 PM',17,'A77587'),('CSC-233A','Introduction to Algorithms',3,'TC-302','M-W-F: 9:00-9:55 AM',18,'H99118'),('CSC-233B','Introduction to Algorithms',3,'TC-302','M-W-F: 11:00-11:55 AM',19,'K69880'),('CSC-234A','Data Structure & Algorithms',3,'TC-302','M-W-F: 9:00-9:55 AM',25,'B78880'),('CSC-234B','Data Structure & Algorithms',3,'TC-114','T-H: 11:00-12:25 PM',15,'J33486'),('CSC-242','Programming II',3,'TC-303','T-H: 1:00-2:25 PM',18,'A52990'),('CSC-320','Object Oriented Programming',3,'TC-301','T-H: 1:00-2:25 PM',22,'B66750'),('CSC-331','Applications Programming',3,'TC-109','T-H: 11:00-12:25 PM',28,'H99118'),('CSC-333A','Computer Arch & Algorithms',3,'TC-301','M-W-F: 10:00-10:55 AM',22,'A77587'),('CSC-333B','Computer Arch & Algorithms',3,'TC-302','T-H: 11:00-12:25 PM',15,'A77587'),('CSC-335','Internet Programming',3,'TC-303','M-W-F: 1:00-1:55 PM',25,'B66750'),('CSC-432','Discrete Algorithms',3,'TC-206','T-H: 11:00-12:25 PM',20,'B86590'),('CSC-439','Database Systems',3,'TC-206','M-W-F: 1:00-1:55 PM',18,'B86590'),('CSE-138A','Introduction to CSE',3,'TC-301','T-H: 1:00-2:25 PM',15,'A52990'),('CSE-138B','Introduction to CSE',3,'TC-109','T-H: 1:00-2:25 PM',35,'J33486'),('CSE-330','Digital Logic Circuits',3,'TC-305','M-W-F: 9:00-9:55 AM',26,'K69880'),('CSE-332','Foundations of Semiconductors',3,'TC-305','T-H: 1:00-2:25 PM',24,'K69880'),('CSE-334','Elec. Measurement & Design',3,'TC-212','T-H: 11:00-12:25 PM',25,'H99118'),('CSE-430','Bioinformatics in Computer',3,'TC-206','Thu: 9:30-11:00 AM',16,'B86590'),('CSE-432','Analog Circuits Design',3,'TC-309','M-W-F: 2:00-2:55 PM',18,'K69880'),('CSE-433','Digital Signal Processing',3,'TC-206','T-H: 2:00-3:25 PM',18,'H99118'),('CSE-434','Advanced Electronics Systems',3,'TC-213','M-W-F: 1:00-1:55 PM',26,'B78880'),('CSE-436','Automatic Control and Design',3,'TC-305','M-W-F: 10:00-10:55 AM',29,'J33486'),('CSE-437','Operating Systems',3,'TC-303','T-H: 1:00-2:25 PM',17,'A77587'),('CSE-438','Advd Logic & Microprocessor',3,'TC-213','M-W-F: 11:00-11:55 AM',35,'B78880'),('CSE-439','Special Topics in CSE',3,'TC-206','M-W-F: 10:00-10:55 AM',22,'J33486'),('CSE-526','Embedded Microcontrollers',3,'TC-308','M-W-F: 9:00-9:55 AM',32,'B78880'),('CSE-535','Dynamic Modeling Systems',3,'TC-325','T-H: 11:00-12:25 PM',25,'B78880'),('CSE-556','Advanced Fuzzy Systems',3,'TC-315','M-W-F: 1:00-1:55 PM',28,'B78880'),('CSE-665','Neural Network Systems',3,'TC-315','T-H: 1:00-2:25 PM',26,'B78880');
/*!40000 ALTER TABLE `course` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `faculty`
--

DROP TABLE IF EXISTS `faculty`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `faculty` (
  `faculty_id` varchar(6) NOT NULL,
  `faculty_name` varchar(30) CHARACTER SET utf8 COLLATE utf8_general_ci DEFAULT NULL,
  `office` varchar(30) CHARACTER SET utf8 COLLATE utf8_general_ci DEFAULT NULL,
  `phone` varchar(30) CHARACTER SET utf8 COLLATE utf8_general_ci DEFAULT NULL,
  `college` varchar(30) CHARACTER SET utf8 COLLATE utf8_general_ci DEFAULT NULL,
  `title` varchar(30) CHARACTER SET utf8 COLLATE utf8_general_ci DEFAULT NULL,
  `email` varchar(30) CHARACTER SET utf8 COLLATE utf8_general_ci DEFAULT NULL,
  PRIMARY KEY (`faculty_id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `faculty`
--

LOCK TABLES `faculty` WRITE;
/*!40000 ALTER TABLE `faculty` DISABLE KEYS */;
INSERT INTO `faculty` VALUES ('A52990','Black Anderson','MTC-218','750-378-9987','Virginia Tech','Professor','banderson@college.edu'),('A77587','Debby Angles','MTC-320','750-330-2276','University of Chicago','Associate Professor','dangles@college.edu'),('B66750','Alice Brown','MTC-257','750-330-6650','University of Florida','Assistant Professor','abrown@college.edu'),('B78880','Ying Bai','MTC-211','750-378-1148','Florida Atlantic University','Associate Professor','ybai@college.edu'),('B86590','Satish Bhalla','MTC-214','750-378-1061','University of Notre Dame','Associate Professor','sbhalla@college.edu'),('H99118','Jeff Henry','MTC-336','750-330-8650','Ohio State University','Associate Professor','jhenry@college.edu'),('J33486','Steve Johnson','MTC-118','750-330-1116','Harvard University','Distinguished Professor','sjohnson@college.edu'),('K69880','Jenney King','MTC-324','750-378-1230','East Florida University','Professor','jking@college.edu'),('M56789','Ali Mhamed','MTC-353','750-378-3355','University of Main','Professor','amhamed@college.edu');
/*!40000 ALTER TABLE `faculty` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Temporary view structure for view `information_about_course`
--

DROP TABLE IF EXISTS `information_about_course`;
/*!50001 DROP VIEW IF EXISTS `information_about_course`*/;
SET @saved_cs_client     = @@character_set_client;
/*!50503 SET character_set_client = utf8mb4 */;
/*!50001 CREATE VIEW `information_about_course` AS SELECT 
 1 AS `course`,
 1 AS `faculty_id`,
 1 AS `classroom`,
 1 AS `schedule`,
 1 AS `faculty_name`*/;
SET character_set_client = @saved_cs_client;

--
-- Temporary view structure for view `information_about_student`
--

DROP TABLE IF EXISTS `information_about_student`;
/*!50001 DROP VIEW IF EXISTS `information_about_student`*/;
SET @saved_cs_client     = @@character_set_client;
/*!50503 SET character_set_client = utf8mb4 */;
/*!50001 CREATE VIEW `information_about_student` AS SELECT 
 1 AS `student_name`,
 1 AS `gpa`,
 1 AS `major`,
 1 AS `schoolYear`,
 1 AS `course`,
 1 AS `major_course`*/;
SET character_set_client = @saved_cs_client;

--
-- Temporary view structure for view `information_about_student_and_cource`
--

DROP TABLE IF EXISTS `information_about_student_and_cource`;
/*!50001 DROP VIEW IF EXISTS `information_about_student_and_cource`*/;
SET @saved_cs_client     = @@character_set_client;
/*!50503 SET character_set_client = utf8mb4 */;
/*!50001 CREATE VIEW `information_about_student_and_cource` AS SELECT 
 1 AS `student_name`,
 1 AS `course`,
 1 AS `major`,
 1 AS `enrollment`*/;
SET character_set_client = @saved_cs_client;

--
-- Table structure for table `login`
--

DROP TABLE IF EXISTS `login`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `login` (
  `user_name` varchar(20) NOT NULL,
  `pass_word` varchar(30) CHARACTER SET utf8 COLLATE utf8_general_ci DEFAULT NULL,
  `faculty_id` varchar(6) DEFAULT NULL,
  `student_id` varchar(6) DEFAULT NULL,
  PRIMARY KEY (`user_name`),
  KEY `fk_login_student_idx` (`student_id`),
  KEY `fk_login_faculty_idx` (`faculty_id`),
  CONSTRAINT `fk_login_faculty` FOREIGN KEY (`faculty_id`) REFERENCES `faculty` (`faculty_id`),
  CONSTRAINT `fk_login_student` FOREIGN KEY (`student_id`) REFERENCES `student` (`student_id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `login`
--

LOCK TABLES `login` WRITE;
/*!40000 ALTER TABLE `login` DISABLE KEYS */;
INSERT INTO `login` VALUES ('abrown','america','B66750',''),('ajade','tryagain','','A97850'),('awoods','smart','','A78835'),('banderson','birthday','A52990',''),('bvalley','see','','B92996'),('dangles','tomorrow','A77587',''),('hsmith','try','','H10210'),('jerica','excellent','','J77896'),('jhenry','test','H99118',''),('jking','goodman','K69880',''),('sbhalla','india','B86590',''),('sjohnson','jermany','J33486',''),('ybai','reback','B78880','');
/*!40000 ALTER TABLE `login` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `student`
--

DROP TABLE IF EXISTS `student`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `student` (
  `student_id` varchar(6) NOT NULL,
  `student_name` varchar(50) CHARACTER SET utf8 COLLATE utf8_general_ci DEFAULT NULL,
  `gpa` double DEFAULT NULL,
  `credits` int DEFAULT NULL,
  `major` varchar(30) CHARACTER SET utf8 COLLATE utf8_general_ci DEFAULT NULL,
  `schoolYear` varchar(30) CHARACTER SET utf8 COLLATE utf8_general_ci DEFAULT NULL,
  `email` varchar(30) CHARACTER SET utf8 COLLATE utf8_general_ci DEFAULT NULL,
  PRIMARY KEY (`student_id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `student`
--

LOCK TABLES `student` WRITE;
/*!40000 ALTER TABLE `student` DISABLE KEYS */;
INSERT INTO `student` VALUES ('A78835','Andrew Woods',3.26,108,'Computer Science','Senior','awoods@college.edu'),('A97850','Ashly Jade',3.57,116,'Information System Engineering','Junior','ajade@college.edu'),('B92996','Blue Valley',3.52,102,'Computer Science','Senior','bvalley@college.edu'),('H10210','Holes Smith',3.87,78,'Computer Engineering','Sophomore','hsmith@college.edu'),('J77896','Erica Johnson',3.95,127,'Computer Science','Senior','ejohnson@college.edu');
/*!40000 ALTER TABLE `student` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `studentcourse`
--

DROP TABLE IF EXISTS `studentcourse`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `studentcourse` (
  `s_course_id` int NOT NULL,
  `student_id` varchar(6) DEFAULT NULL,
  `course_id` varchar(8) DEFAULT NULL,
  `credit` int DEFAULT NULL,
  `major` varchar(5) CHARACTER SET utf8 COLLATE utf8_general_ci DEFAULT NULL,
  PRIMARY KEY (`s_course_id`),
  KEY `fk_student_studentcourse_idx` (`student_id`),
  KEY `fk_course_studentcourse_idx` (`course_id`),
  CONSTRAINT `fk_course_studentcourse` FOREIGN KEY (`course_id`) REFERENCES `course` (`course_id`),
  CONSTRAINT `fk_student_studentcourse` FOREIGN KEY (`student_id`) REFERENCES `student` (`student_id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `studentcourse`
--

LOCK TABLES `studentcourse` WRITE;
/*!40000 ALTER TABLE `studentcourse` DISABLE KEYS */;
INSERT INTO `studentcourse` VALUES (1000,'H10210','CSC-131D',3,'CE'),(1001,'B92996','CSC-132A',3,'CS/IS'),(1002,'J77896','CSC-335',3,'CS/IS'),(1003,'A78835','CSC-331',3,'CE'),(1004,'H10210','CSC-234B',3,'CE'),(1005,'J77896','CSC-234A',3,'CS/IS'),(1006,'B92996','CSC-233A',3,'CS/IS'),(1007,'A78835','CSC-132A',3,'CE'),(1008,'A78835','CSE-432',3,'CE'),(1009,'A78835','CSE-434',3,'CE'),(1010,'J77896','CSC-439',3,'CS/IS'),(1011,'H10210','CSC-132A',3,'CE'),(1012,'H10210','CSC-331',2,'CE'),(1013,'A78835','CSC-335',3,'CE'),(1014,'A78835','CSE-438',3,'CE'),(1015,'J77896','CSC-432',3,'CS/IS'),(1016,'A97850','CSC-132B',3,'ISE'),(1017,'A97850','CSC-234A',3,'ISE'),(1018,'A97850','CSC-331',3,'ISE'),(1019,'A97850','CSC-335',3,'ISE'),(1020,'J77896','CSE-439',3,'CS/IS'),(1021,'B92996','CSC-230',3,'CS/IS'),(1022,'A78835','CSE-332',3,'CE'),(1023,'B92996','CSE-430',3,'CE'),(1024,'J77896','CSC-333A',3,'CS/IS'),(1025,'H10210','CSE-433',3,'CE'),(1026,'H10210','CSE-334',3,'CE'),(1027,'B92996','CSC-131C',3,'CS/IS'),(1028,'B92996','CSC-439',3,'CS/IS');
/*!40000 ALTER TABLE `studentcourse` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Final view structure for view `information_about_course`
--

/*!50001 DROP VIEW IF EXISTS `information_about_course`*/;
/*!50001 SET @saved_cs_client          = @@character_set_client */;
/*!50001 SET @saved_cs_results         = @@character_set_results */;
/*!50001 SET @saved_col_connection     = @@collation_connection */;
/*!50001 SET character_set_client      = utf8mb4 */;
/*!50001 SET character_set_results     = utf8mb4 */;
/*!50001 SET collation_connection      = utf8mb4_0900_ai_ci */;
/*!50001 CREATE ALGORITHM=UNDEFINED */
/*!50013 DEFINER=`root`@`localhost` SQL SECURITY DEFINER */
/*!50001 VIEW `information_about_course` AS select `course`.`course` AS `course`,`faculty`.`faculty_id` AS `faculty_id`,`course`.`classroom` AS `classroom`,`course`.`schedule` AS `schedule`,`faculty`.`faculty_name` AS `faculty_name` from (`faculty` left join `course` on((`course`.`faculty_id` = `faculty`.`faculty_id`))) */;
/*!50001 SET character_set_client      = @saved_cs_client */;
/*!50001 SET character_set_results     = @saved_cs_results */;
/*!50001 SET collation_connection      = @saved_col_connection */;

--
-- Final view structure for view `information_about_student`
--

/*!50001 DROP VIEW IF EXISTS `information_about_student`*/;
/*!50001 SET @saved_cs_client          = @@character_set_client */;
/*!50001 SET @saved_cs_results         = @@character_set_results */;
/*!50001 SET @saved_col_connection     = @@collation_connection */;
/*!50001 SET character_set_client      = utf8mb4 */;
/*!50001 SET character_set_results     = utf8mb4 */;
/*!50001 SET collation_connection      = utf8mb4_0900_ai_ci */;
/*!50001 CREATE ALGORITHM=UNDEFINED */
/*!50013 DEFINER=`root`@`localhost` SQL SECURITY DEFINER */
/*!50001 VIEW `information_about_student` AS select `student`.`student_name` AS `student_name`,`student`.`gpa` AS `gpa`,`student`.`major` AS `major`,`student`.`schoolYear` AS `schoolYear`,`course`.`course` AS `course`,`studentcourse`.`major` AS `major_course` from ((`studentcourse` left join `student` on((`studentcourse`.`student_id` = `student`.`student_id`))) join `course` on((`course`.`course_id` = `studentcourse`.`course_id`))) */;
/*!50001 SET character_set_client      = @saved_cs_client */;
/*!50001 SET character_set_results     = @saved_cs_results */;
/*!50001 SET collation_connection      = @saved_col_connection */;

--
-- Final view structure for view `information_about_student_and_cource`
--

/*!50001 DROP VIEW IF EXISTS `information_about_student_and_cource`*/;
/*!50001 SET @saved_cs_client          = @@character_set_client */;
/*!50001 SET @saved_cs_results         = @@character_set_results */;
/*!50001 SET @saved_col_connection     = @@collation_connection */;
/*!50001 SET character_set_client      = utf8mb4 */;
/*!50001 SET character_set_results     = utf8mb4 */;
/*!50001 SET collation_connection      = utf8mb4_0900_ai_ci */;
/*!50001 CREATE ALGORITHM=UNDEFINED */
/*!50013 DEFINER=`root`@`localhost` SQL SECURITY DEFINER */
/*!50001 VIEW `information_about_student_and_cource` AS select `student`.`student_name` AS `student_name`,`course`.`course` AS `course`,`student`.`major` AS `major`,`course`.`enrollment` AS `enrollment` from ((`studentcourse` join `student` on((`student`.`student_id` = `studentcourse`.`student_id`))) join `course` on((`course`.`course_id` = `studentcourse`.`course_id`))) */;
/*!50001 SET character_set_client      = @saved_cs_client */;
/*!50001 SET character_set_results     = @saved_cs_results */;
/*!50001 SET collation_connection      = @saved_col_connection */;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2021-04-06 16:39:37
