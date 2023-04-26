-- --------------------------------------------------------
-- Host:                         127.0.0.1
-- Server version:               10.11.2-MariaDB - mariadb.org binary distribution
-- Server OS:                    Win64
-- HeidiSQL Version:             11.3.0.6295
-- --------------------------------------------------------

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET NAMES utf8 */;
/*!50503 SET NAMES utf8mb4 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;


-- Dumping database structure for studentmanagementsystem
CREATE DATABASE IF NOT EXISTS `studentmanagementsystem` /*!40100 DEFAULT CHARACTER SET armscii8 COLLATE armscii8_bin */;
USE `studentmanagementsystem`;

-- Dumping structure for table studentmanagementsystem.courses
CREATE TABLE IF NOT EXISTS `courses` (
  `courseId` int(6) NOT NULL AUTO_INCREMENT,
  `courseName` varchar(30) DEFAULT NULL,
  `instructor` varchar(40) DEFAULT NULL,
  `startDate` datetime DEFAULT NULL,
  `endDate` datetime DEFAULT NULL,
  `program` varchar(30) DEFAULT NULL,
  PRIMARY KEY (`courseId`) USING BTREE
) ENGINE=InnoDB AUTO_INCREMENT=100006 DEFAULT CHARSET=armscii8 COLLATE=armscii8_bin;

-- Dumping data for table studentmanagementsystem.courses: ~80 rows (approximately)
DELETE FROM `courses`;
/*!40000 ALTER TABLE `courses` DISABLE KEYS */;
INSERT INTO `courses` (`courseId`, `courseName`, `instructor`, `startDate`, `endDate`, `program`) VALUES
	(1, 'Games', 'Eilert', '2023-09-10 16:15:55', '2023-12-12 07:17:13', 'Services'),
	(2, 'Industrial', 'Dismore', '2023-09-10 12:14:40', '2023-12-13 07:43:34', 'Research and Development'),
	(3, 'Movies', 'Arnaudon', '2023-09-05 12:12:21', '2023-12-09 21:37:10', 'Accounting'),
	(4, 'Books', 'Cockcroft', '2023-09-12 04:25:28', '2023-12-12 10:02:37', 'Legal'),
	(5, 'Clothing', 'Sleightholm', '2023-09-12 12:40:29', '2023-12-14 19:02:37', 'Marketing'),
	(6, 'Health', 'Simonian', '2023-09-13 20:41:10', '2023-12-13 18:00:19', 'Services'),
	(7, 'Home', 'Aubrey', '2023-09-05 04:38:27', '2023-12-11 05:15:52', 'Business Development'),
	(8, 'Music', 'Magrannell', '2023-09-12 18:12:31', '2023-12-12 23:45:24', 'Human Resources'),
	(9, 'Outdoors', 'Puddicombe', '2023-09-14 11:01:50', '2023-12-12 00:53:05', 'Sales'),
	(10, 'Garden', 'Pevreal', '2023-09-04 13:04:44', '2023-12-10 05:11:43', 'Research and Development'),
	(11, 'Industrial', 'Babington', '2023-09-07 17:54:24', '2023-12-10 18:32:44', 'Legal'),
	(12, 'Kids', 'Norvill', '2023-09-10 09:04:20', '2023-12-09 09:18:46', 'Support'),
	(13, 'Electronics', 'Chelam', '2023-09-04 05:53:00', '2023-12-10 19:59:08', 'Engineering'),
	(14, 'Grocery', 'Cranidge', '2023-09-08 03:10:28', '2023-12-10 13:26:57', 'Services'),
	(15, 'Kids', 'Perrone', '2023-09-04 04:33:00', '2023-12-14 06:29:59', 'Product Management'),
	(16, 'Grocery', 'Lazer', '2023-09-07 09:37:16', '2023-12-13 06:25:58', 'Services'),
	(17, 'Automotive', 'Habbema', '2023-09-10 21:27:25', '2023-12-10 22:21:04', 'Accounting'),
	(18, 'Home', 'Sansom', '2023-09-07 22:49:36', '2023-12-12 01:39:23', 'Product Management'),
	(19, 'Movies', 'Ainge', '2023-09-11 13:20:23', '2023-12-08 04:49:24', 'Engineering'),
	(20, 'Computers', 'Greetland', '2023-09-04 16:37:28', '2023-12-12 10:08:58', 'Engineering'),
	(21, 'Kids', 'Huddle', '2023-09-06 17:17:57', '2023-12-12 15:47:34', 'Business Development'),
	(22, 'Computers', 'Brassington', '2023-09-13 07:25:44', '2023-12-14 05:32:35', 'Business Development'),
	(23, 'Clothing', 'Sneller', '2023-09-04 18:16:20', '2023-12-13 09:58:25', 'Business Development'),
	(24, 'Baby', 'McGahern', '2023-09-09 19:16:53', '2023-12-12 14:01:10', 'Human Resources'),
	(25, 'Health', 'Stanyan', '2023-09-14 11:24:51', '2023-12-09 20:17:59', 'Research and Development'),
	(26, 'Garden', 'Dutton', '2023-09-10 16:00:01', '2023-12-13 00:12:07', 'Sales'),
	(27, 'Automotive', 'Basley', '2023-09-06 13:19:58', '2023-12-13 21:49:46', 'Training'),
	(28, 'Books', 'Karlicek', '2023-09-08 22:59:05', '2023-12-08 17:46:17', 'Human Resources'),
	(29, 'Computers', 'De Carlo', '2023-09-08 02:56:37', '2023-12-08 00:51:44', 'Business Development'),
	(30, 'Games', 'McCrostie', '2023-09-08 11:21:43', '2023-12-14 01:16:27', 'Sales'),
	(31, 'Games', 'Epdell', '2023-09-09 23:22:02', '2023-12-14 19:49:02', 'Legal'),
	(32, 'Industrial', 'Chark', '2023-09-14 12:57:01', '2023-12-11 00:00:35', 'Services'),
	(33, 'Books', 'Reuter', '2023-09-07 13:07:33', '2023-12-13 11:18:34', 'Legal'),
	(34, 'Movies', 'Collings', '2023-09-09 17:17:12', '2023-12-11 22:33:01', 'Marketing'),
	(35, 'Health', 'Hierro', '2023-09-06 12:07:52', '2023-12-12 04:12:38', 'Human Resources'),
	(36, 'Tools', 'Hunnisett', '2023-09-06 22:58:33', '2023-12-14 00:40:44', 'Legal'),
	(37, 'Home', 'Eccleshare', '2023-09-13 13:54:55', '2023-12-12 14:51:31', 'Sales'),
	(38, 'Automotive', 'Woller', '2023-09-05 12:38:15', '2023-12-08 18:43:52', 'Product Management'),
	(39, 'Health', 'Keel', '2023-09-06 12:21:12', '2023-12-12 00:38:21', 'Sales'),
	(40, 'Music', 'List', '2023-09-09 09:26:28', '2023-12-09 08:02:40', 'Research and Development'),
	(41, 'Baby', 'Aylmer', '2023-09-14 20:48:00', '2023-12-13 10:21:14', 'Accounting'),
	(42, 'Health', 'Grishenkov', '2023-09-13 14:42:37', '2023-12-09 23:03:47', 'Engineering'),
	(43, 'Tools', 'Flello', '2023-09-07 10:54:40', '2023-12-14 08:27:43', 'Engineering'),
	(44, 'Sports', 'Trayhorn', '2023-09-11 23:54:03', '2023-12-12 11:04:59', 'Support'),
	(45, 'Garden', 'Vlasenkov', '2023-09-06 23:01:32', '2023-12-14 05:41:44', 'Sales'),
	(46, 'Games', 'Oyley', '2023-09-08 08:36:54', '2023-12-12 05:35:55', 'Research and Development'),
	(47, 'Music', 'Goodyer', '2023-09-06 21:41:54', '2023-12-12 08:39:16', 'Services'),
	(48, 'Industrial', 'Easman', '2023-09-06 06:10:29', '2023-12-11 06:55:37', 'Research and Development'),
	(49, 'Movies', 'Johananoff', '2023-09-07 21:08:52', '2023-12-12 17:38:26', 'Product Management'),
	(50, 'Toys', 'Ierland', '2023-09-12 08:14:30', '2023-12-08 00:05:46', 'Engineering'),
	(51, 'Shoes', 'Brend', '2023-09-13 21:24:32', '2023-12-08 23:54:24', 'Human Resources'),
	(52, 'Beauty', 'Docket', '2023-09-04 15:48:24', '2023-12-10 20:59:37', 'Engineering'),
	(53, 'Computers', 'Waterfield', '2023-09-11 01:19:35', '2023-12-09 01:38:46', 'Business Development'),
	(54, 'Electronics', 'Tasch', '2023-09-04 02:03:15', '2023-12-14 11:41:50', 'Business Development'),
	(55, 'Music', 'Ruggiero', '2023-09-04 13:43:36', '2023-12-08 15:46:47', 'Legal'),
	(56, 'Grocery', 'Gianetti', '2023-09-13 08:35:11', '2023-12-09 11:52:51', 'Support'),
	(57, 'Clothing', 'Sonschein', '2023-09-12 17:24:32', '2023-12-09 22:49:13', 'Business Development'),
	(58, 'Baby', 'Thorneywork', '2023-09-07 13:17:37', '2023-12-08 02:16:11', 'Business Development'),
	(59, 'Tools', 'Flintoffe', '2023-09-10 10:26:47', '2023-12-10 19:15:50', 'Marketing'),
	(60, 'Baby', 'Colbron', '2023-09-13 15:14:40', '2023-12-09 17:27:54', 'Sales'),
	(61, 'Clothing', 'Jacobsz', '2023-09-07 00:30:31', '2023-12-14 05:32:23', 'Marketing'),
	(62, 'Computers', 'Pead', '2023-09-09 20:58:24', '2023-12-11 07:18:45', 'Accounting'),
	(63, 'Music', 'Harness', '2023-09-10 01:48:25', '2023-12-13 23:49:47', 'Product Management'),
	(64, 'Garden', 'Backs', '2023-09-08 05:02:20', '2023-12-12 18:12:47', 'Marketing'),
	(65, 'Kids', 'Clack', '2023-09-08 20:11:58', '2023-12-13 06:03:41', 'Sales'),
	(66, 'Shoes', 'Dufall', '2023-09-06 09:08:19', '2023-12-09 11:05:58', 'Business Development'),
	(67, 'Games', 'Meconi', '2023-09-05 21:28:34', '2023-12-08 21:24:21', 'Engineering'),
	(68, 'Clothing', 'Gatland', '2023-09-08 00:50:03', '2023-12-12 08:53:47', 'Product Management'),
	(69, 'Computers', 'Gowthrop', '2023-09-04 15:21:42', '2023-12-12 20:52:30', 'Marketing'),
	(70, 'Tools', 'Broek', '2023-09-14 23:12:28', '2023-12-14 20:29:14', 'Legal'),
	(71, 'Kids', 'Dickman', '2023-09-12 15:37:31', '2023-12-13 17:53:42', 'Engineering'),
	(72, 'Beauty', 'Meeron', '2023-09-04 23:59:10', '2023-12-10 09:13:19', 'Training'),
	(73, 'Music', 'Lumm', '2023-09-09 08:34:31', '2023-12-10 01:44:15', 'Business Development'),
	(74, 'Automotive', 'Midlane', '2023-09-07 07:30:37', '2023-12-08 09:58:23', 'Sales'),
	(75, 'Health', 'Crowcombe', '2023-09-04 05:35:28', '2023-12-14 12:32:47', 'Legal'),
	(76, 'Garden', 'Joliffe', '2023-09-05 20:57:51', '2023-12-14 00:06:32', 'Accounting'),
	(77, 'Sports', 'Busby', '2023-09-05 06:12:50', '2023-12-12 21:04:09', 'Legal'),
	(78, 'Grocery', 'Schleicher', '2023-09-06 21:39:25', '2023-12-14 21:09:40', 'Marketing'),
	(79, 'Electronics', 'Studdert', '2023-09-07 03:49:41', '2023-12-12 19:22:16', 'Product Management'),
	(80, 'Sports', 'Kobisch', '2023-09-08 15:31:45', '2023-12-13 07:44:42', 'Support');
/*!40000 ALTER TABLE `courses` ENABLE KEYS */;

-- Dumping structure for table studentmanagementsystem.students
CREATE TABLE IF NOT EXISTS `students` (
  `studentId` int(6) NOT NULL AUTO_INCREMENT,
  `firstName` varchar(25) NOT NULL,
  `lastName` varchar(25) NOT NULL,
  `program` varchar(30) DEFAULT NULL,
  `phone` varchar(12) DEFAULT NULL,
  `email` varchar(30) DEFAULT NULL,
  PRIMARY KEY (`studentId`) USING BTREE
) ENGINE=InnoDB AUTO_INCREMENT=81 DEFAULT CHARSET=armscii8 COLLATE=armscii8_bin;

-- Dumping data for table studentmanagementsystem.students: ~80 rows (approximately)
DELETE FROM `students`;
/*!40000 ALTER TABLE `students` DISABLE KEYS */;
INSERT INTO `students` (`studentId`, `firstName`, `lastName`, `program`, `phone`, `email`) VALUES
	(1, 'Griz', 'Baiden', 'Business Development', '9805720000', 'gbaiden0@ocn.ne.jp'),
	(2, 'Kris', 'Lanegran', 'Accounting', '4963030000', 'klanegran1@salon.com'),
	(3, 'Ethelin', 'Matresse', 'Business Development', '4943150000', 'ematresse2@sourceforge.net'),
	(4, 'Sampson', 'Straneo', 'Business Development', '3061430000', 'sstraneo3@wordpress.org'),
	(5, 'Camey', 'Brandolini', 'Legal', '8039670000', 'cbrandolini4@weibo.com'),
	(6, 'Mitchael', 'Forty', 'Services', '3751090000', 'mforty5@oakley.com'),
	(7, 'Dinah', 'Lonie', 'Human Resources', '2296960000', 'dlonie6@smugmug.com'),
	(8, 'Ruben', 'Caskie', 'Human Resources', '8546340000', 'rcaskie7@bloglines.com'),
	(9, 'Marylinda', 'Smeuin', 'Marketing', '2755450000', 'msmeuin8@tinyurl.com'),
	(10, 'Clementine', 'Brecon', 'Training', '3578500000', 'cbrecon9@netvibes.com'),
	(11, 'Rockey', 'Peres', 'Accounting', '7448760000', 'rperesa@geocities.com'),
	(12, 'Leora', 'Gordon-Giles', 'Human Resources', '1701510000', 'lgordongilesb@fc2.com'),
	(13, 'Sutherland', 'Goade', 'Product Management', '8313590000', 'sgoadec@yellowbook.com'),
	(14, 'Orson', 'Simond', 'Engineering', '7639650000', 'osimondd@php.net'),
	(15, 'Obidiah', 'Noury', 'Training', '3757710000', 'onourye@va.gov'),
	(16, 'Alain', 'Ortmann', 'Engineering', '6325050000', 'aortmannf@forbes.com'),
	(17, 'Yolane', 'Beardsell', 'Sales', '9805320000', 'ybeardsellg@hao123.com'),
	(18, 'Mable', 'Tabourel', 'Product Management', '5607580000', 'mtabourelh@accuweather.com'),
	(19, 'Edouard', 'Keaveny', 'Training', '3951100000', 'ekeavenyi@discovery.com'),
	(20, 'Winslow', 'Errington', 'Legal', '5488630000', 'werringtonj@digg.com'),
	(21, 'Drew', 'Thyer', 'Sales', '9612350000', 'dthyerk@4shared.com'),
	(22, 'Symon', 'Phipps', 'Research and Development', '3021940000', 'sphippsl@vistaprint.com'),
	(23, 'Curr', 'Waistall', 'Human Resources', '3353870000', 'cwaistallm@ifeng.com'),
	(24, 'Lula', 'Cupitt', 'Accounting', '2732040000', 'lcupittn@privacy.gov.au'),
	(25, 'Clemmie', 'Palphreyman', 'Accounting', '1562920000', 'cpalphreymano@soup.io'),
	(26, 'Kyrstin', 'Cordey', 'Marketing', '8599400000', 'kcordeyp@jimdo.com'),
	(27, 'Ebony', 'Meany', 'Research and Development', '5317140000', 'emeanyq@goodreads.com'),
	(28, 'Kim', 'Wilmington', 'Research and Development', '8656770000', 'kwilmingtonr@wunderground.com'),
	(29, 'Nickie', 'Butterwick', 'Accounting', '1729520000', 'nbutterwicks@ebay.co.uk'),
	(30, 'Pollyanna', 'Clethro', 'Support', '6528040000', 'pclethrot@usda.gov'),
	(31, 'Lanita', 'Aberkirdo', 'Training', '6172730000', 'laberkirdou@bing.com'),
	(32, 'Ashlee', 'Breache', 'Support', '8371020000', 'abreachev@google.ru'),
	(33, 'Gianna', 'Wooler', 'Product Management', '1221290000', 'gwoolerw@smugmug.com'),
	(34, 'Marji', 'Devereu', 'Sales', '8399520000', 'mdevereux@vinaora.com'),
	(35, 'Adriano', 'Drillingcourt', 'Research and Development', '7424960000', 'adrillingcourty@homestead.com'),
	(36, 'Bernie', 'Standering', 'Engineering', '7425050000', 'bstanderingz@mozilla.org'),
	(37, 'Betsy', 'McPartling', 'Sales', '6727070000', 'bmcpartling10@newyorker.com'),
	(38, 'Waverly', 'Worswick', 'Marketing', '9206940000', 'wworswick11@guardian.co.uk'),
	(39, 'Crawford', 'Skilton', 'Human Resources', '8103670000', 'cskilton12@qq.com'),
	(40, 'Shurwood', 'Treves', 'Engineering', '8088890000', 'streves13@is.gd'),
	(41, 'Yovonnda', 'Fiddy', 'Accounting', '4719360000', 'yfiddy14@businesswire.com'),
	(42, 'Freedman', 'Bernasek', 'Business Development', '2936970000', 'fbernasek15@fda.gov'),
	(43, 'Joanne', 'Maudsley', 'Marketing', '2529730000', 'jmaudsley16@storify.com'),
	(44, 'Frannie', 'Bassam', 'Sales', '7212900000', 'fbassam17@shareasale.com'),
	(45, 'Avram', 'Stivani', 'Sales', '7729840000', 'astivani18@uiuc.edu'),
	(46, 'Marcela', 'Smyth', 'Engineering', '6442520000', 'msmyth19@toplist.cz'),
	(47, 'Jasper', 'McElvine', 'Legal', '1685380000', 'jmcelvine1a@nytimes.com'),
	(48, 'Dara', 'Trimby', 'Legal', '4831820000', 'dtrimby1b@google.nl'),
	(49, 'Barnett', 'Brunskill', 'Support', '8833680000', 'bbrunskill1c@oracle.com'),
	(50, 'Jerrie', 'Barribal', 'Human Resources', '2874460000', 'jbarribal1d@walmart.com'),
	(51, 'Samuele', 'Noye', 'Business Development', '5476870000', 'snoye1e@earthlink.net'),
	(52, 'Flor', 'Rosenbloom', 'Engineering', '7243540000', 'frosenbloom1f@sun.com'),
	(53, 'Terencio', 'Senter', 'Engineering', '4817630000', 'tsenter1g@flickr.com'),
	(54, 'Martino', 'Kreber', 'Human Resources', '2763240000', 'mkreber1h@blinklist.com'),
	(55, 'Carmel', 'Mountstephen', 'Sales', '9402620000', 'cmountstephen1i@sfgate.com'),
	(56, 'Shalna', 'Lilburne', 'Human Resources', '8045170000', 'slilburne1j@wp.com'),
	(57, 'Nickey', 'Raynor', 'Training', '2474240000', 'nraynor1k@sakura.ne.jp'),
	(58, 'Heinrik', 'Tewkesbury', 'Legal', '3669370000', 'htewkesbury1l@netscape.com'),
	(59, 'Halimeda', 'Rebeiro', 'Training', '6598180000', 'hrebeiro1m@spotify.com'),
	(60, 'Jerrold', 'Treharne', 'Support', '8454890000', 'jtreharne1n@gizmodo.com'),
	(61, 'Malvina', 'Archell', 'Human Resources', '1878760000', 'marchell1o@chronoengine.com'),
	(62, 'Rik', 'Lough', 'Human Resources', '1415820000', 'rlough1p@icq.com'),
	(63, 'Collette', 'Yardy', 'Legal', '4313980000', 'cyardy1q@walmart.com'),
	(64, 'Goldy', 'Cumesky', 'Product Management', '4034490000', 'gcumesky1r@gizmodo.com'),
	(65, 'Suki', 'Vellacott', 'Training', '5174350000', 'svellacott1s@timesonline.co.uk'),
	(66, 'Oriana', 'Yosevitz', 'Services', '9048590000', 'oyosevitz1t@jalbum.net'),
	(67, 'Jessamyn', 'Abrahmson', 'Legal', '2529800000', 'jabrahmson1u@mediafire.com'),
	(68, 'Mable', 'Heselwood', 'Sales', '7129420000', 'mheselwood1v@forbes.com'),
	(69, 'Panchito', 'Brugmann', 'Accounting', '5252530000', 'pbrugmann1w@gizmodo.com'),
	(70, 'Matteo', 'Challenor', 'Sales', '3841040000', 'mchallenor1x@trellian.com'),
	(71, 'Joelynn', 'Tallach', 'Accounting', '6792660000', 'jtallach1y@chron.com'),
	(72, 'Marcy', 'Bracco', 'Legal', '6035150000', 'mbracco1z@cnet.com'),
	(73, 'Jojo', 'Godin', 'Support', '9507780000', 'jgodin20@wunderground.com'),
	(74, 'Orlando', 'Camerati', 'Marketing', '3321720000', 'ocamerati21@sun.com'),
	(75, 'Carling', 'Ricks', 'Support', '9812330000', 'cricks22@globo.com'),
	(76, 'Chlo', 'McCafferty', 'Accounting', '2108290000', 'cmccafferty23@ucla.edu'),
	(77, 'Kassandra', 'Lavery', 'Services', '4375130000', 'klavery24@cnet.com'),
	(78, 'Daisie', 'Piscot', 'Sales', '3676310000', 'dpiscot25@tiny.cc'),
	(79, 'Lynnet', 'Gawler', 'Training', '3783680000', 'lgawler26@theglobeandmail.com'),
	(80, 'Willie', 'Dymott', 'Services', '8577610000', 'wdymott27@furl.net');
/*!40000 ALTER TABLE `students` ENABLE KEYS */;

/*!40101 SET SQL_MODE=IFNULL(@OLD_SQL_MODE, '') */;
/*!40014 SET FOREIGN_KEY_CHECKS=IFNULL(@OLD_FOREIGN_KEY_CHECKS, 1) */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40111 SET SQL_NOTES=IFNULL(@OLD_SQL_NOTES, 1) */;
