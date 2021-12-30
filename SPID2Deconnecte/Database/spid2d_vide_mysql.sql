-- phpMyAdmin SQL Dump
-- version 4.9.2
-- https://www.phpmyadmin.net/
--
-- Hôte : 127.0.0.1:3306
-- Généré le :  sam. 25 déc. 2021 à 12:17
-- Version du serveur :  10.4.10-MariaDB
-- Version de PHP :  5.6.40

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET AUTOCOMMIT = 0;
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Base de données :  `spid2d`
--

-- --------------------------------------------------------

--
-- Structure de la table `bareme`
--

DROP TABLE IF EXISTS `bareme`;
CREATE TABLE IF NOT EXISTS `bareme` (
  `BAR_CD` varchar(5) NOT NULL,
  `BAR_LB` varchar(32) NOT NULL,
  `BAR_LB_COURT` varchar(5) DEFAULT NULL,
  `BAR_ID` bigint(20) NOT NULL,
  `ORGA_ID` bigint(20) NOT NULL,
  `BAR_NB_JOUEUR` int(11) DEFAULT NULL,
  `BL_MAJ` tinyint(1) DEFAULT 0,
  PRIMARY KEY (`BAR_ID`),
  KEY `ORGA_ID` (`ORGA_ID`)
) ENGINE=MyISAM DEFAULT CHARSET=utf16;

--
-- Déchargement des données de la table `bareme`
--

INSERT INTO `bareme` (`BAR_CD`, `BAR_LB`, `BAR_LB_COURT`, `BAR_ID`, `ORGA_ID`, `BAR_NB_JOUEUR`, `BL_MAJ`) VALUES
('11J', 'BAREME 11 JOUEURS', '', 3055, 100001, 11, 1),
('12J', 'BAREME 12 JOUEURS', '', 3056, 100001, 12, 1),
('16J', 'BAREME 16 JOUEURS', '', 3057, 100001, 16, 1),
('18', 'BAREME 18 JOUEURS', '', 3058, 100001, 18, 1),
('C', 'N2SENIORS', '', 1028, 100001, 24, 1),
('A1', 'N3SENIORS', '', 1029, 100001, 48, 1),
('E2', 'N1JUNIORS', '', 1030, 100001, 16, 1),
('B2', 'N2JUNIORS', '', 1031, 100001, 32, 1),
('C1', 'N4SENIORS gr 1-2-3-6', '', 1032, 100001, 24, 1),
('E3', 'N1SENIORS', '', 1027, 100001, 16, 1),
('C4', 'N4SENIORS gr 4', '', 1033, 100001, 24, 1),
('C5', 'N4SENIORS gr 5', '', 1034, 100001, 24, 1),
('24J', 'BAREME 24 JOUEURS', '', 3060, 100001, 24, 1),
('20J', 'BAREME 20 JOUEURS', '', 3059, 100001, 20, 1),
('32J', 'BAREME 32 JOUEURS', '', 3061, 100001, 32, 1),
('48J', 'BAREME 48 JOUEURS', '', 3062, 100001, 48, 1),
('6J', 'BAREME 6 JOUEURS', '', 3039, 100001, 6, 1),
('7J', 'BAREME 7 JOUEURS', '', 3051, 100001, 7, 1),
('8J', 'BAREME 8 JOUEURS', '', 3052, 100001, 8, 1),
('9J', 'BAREME 9 JOUEURS', '', 3053, 100001, 9, 1),
('10J', 'BAREME 10 JOUEURS', '', 3054, 100001, 10, 1);

-- --------------------------------------------------------

--
-- Structure de la table `bareme_detail`
--

DROP TABLE IF EXISTS `bareme_detail`;
CREATE TABLE IF NOT EXISTS `bareme_detail` (
  `DBAR_ID_DETAILS` bigint(20) NOT NULL,
  `DBAR_NB_PLACE` int(11) NOT NULL,
  `DBAR_NB_POINT` int(11) NOT NULL,
  `BAR_ID` bigint(20) NOT NULL,
  `BL_MAJ` tinyint(1) NOT NULL DEFAULT 0,
  PRIMARY KEY (`DBAR_ID_DETAILS`),
  KEY `BAR_ID` (`BAR_ID`)
) ENGINE=MyISAM DEFAULT CHARSET=utf16;

--
-- Déchargement des données de la table `bareme_detail`
--

INSERT INTO `bareme_detail` (`DBAR_ID_DETAILS`, `DBAR_NB_PLACE`, `DBAR_NB_POINT`, `BAR_ID`, `BL_MAJ`) VALUES
(1401, 4, 70, 1029, 1),
(1400, 43, 2, 1029, 1),
(1399, 33, 10, 1029, 1),
(1398, 23, 26, 1029, 1),
(1397, 13, 38, 1029, 1),
(1396, 3, 70, 1029, 1),
(1395, 42, 2, 1029, 1),
(1394, 32, 11, 1029, 1),
(1393, 22, 26, 1029, 1),
(1392, 12, 38, 1029, 1),
(1391, 2, 85, 1029, 1),
(1390, 41, 2, 1029, 1),
(1389, 31, 12, 1029, 1),
(1388, 21, 26, 1029, 1),
(1387, 11, 38, 1029, 1),
(1386, 1, 100, 1029, 1),
(1385, 20, 6, 1028, 1),
(1384, 10, 23, 1028, 1),
(1383, 19, 7, 1028, 1),
(1382, 9, 23, 1028, 1),
(1381, 18, 8, 1028, 1),
(1380, 8, 32, 1028, 1),
(1379, 17, 9, 1028, 1),
(1378, 7, 32, 1028, 1),
(1377, 16, 11, 1028, 1),
(1376, 6, 32, 1028, 1),
(1375, 15, 13, 1028, 1),
(1374, 5, 32, 1028, 1),
(1373, 24, 3, 1028, 1),
(1372, 14, 15, 1028, 1),
(1371, 4, 52, 1028, 1),
(1370, 23, 3, 1028, 1),
(1369, 13, 17, 1028, 1),
(1368, 3, 52, 1028, 1),
(1367, 22, 3, 1028, 1),
(1366, 12, 23, 1028, 1),
(1365, 2, 80, 1028, 1),
(1364, 21, 3, 1028, 1),
(1363, 11, 23, 1028, 1),
(1362, 1, 100, 1028, 1),
(1402, 14, 38, 1029, 1),
(1403, 24, 26, 1029, 1),
(1404, 34, 9, 1029, 1),
(1405, 44, 2, 1029, 1),
(1406, 5, 54, 1029, 1),
(1407, 15, 38, 1029, 1),
(1408, 25, 18, 1029, 1),
(1409, 35, 8, 1029, 1),
(1410, 45, 2, 1029, 1),
(1411, 6, 54, 1029, 1),
(1412, 16, 38, 1029, 1),
(1413, 26, 17, 1029, 1),
(1414, 36, 7, 1029, 1),
(1415, 46, 2, 1029, 1),
(1416, 7, 54, 1029, 1),
(1417, 17, 26, 1029, 1),
(1418, 27, 16, 1029, 1),
(1419, 37, 6, 1029, 1),
(1420, 47, 2, 1029, 1),
(1421, 8, 54, 1029, 1),
(1422, 18, 26, 1029, 1),
(1423, 28, 15, 1029, 1),
(1424, 38, 5, 1029, 1),
(1425, 48, 2, 1029, 1),
(1426, 9, 38, 1029, 1),
(1427, 19, 26, 1029, 1),
(1428, 29, 14, 1029, 1),
(1429, 39, 4, 1029, 1),
(1430, 10, 38, 1029, 1),
(1431, 20, 26, 1029, 1),
(1432, 30, 13, 1029, 1),
(1433, 40, 3, 1029, 1),
(1434, 1, 100, 1030, 1),
(1435, 11, 10, 1030, 1),
(1436, 2, 80, 1030, 1),
(1437, 12, 7, 1030, 1),
(1438, 3, 65, 1030, 1),
(1439, 13, 5, 1030, 1),
(1440, 4, 50, 1030, 1),
(1441, 14, 4, 1030, 1),
(1442, 5, 40, 1030, 1),
(1443, 15, 3, 1030, 1),
(1444, 6, 35, 1030, 1),
(1445, 16, 2, 1030, 1),
(1446, 7, 30, 1030, 1),
(1447, 8, 25, 1030, 1),
(1448, 9, 20, 1030, 1),
(1449, 10, 15, 1030, 1),
(1450, 1, 100, 1031, 1),
(1451, 11, 31, 1031, 1),
(1452, 21, 13, 1031, 1),
(1453, 31, 3, 1031, 1),
(1454, 2, 80, 1031, 1),
(1455, 12, 30, 1031, 1),
(1456, 22, 12, 1031, 1),
(1457, 32, 2, 1031, 1),
(1458, 3, 65, 1031, 1),
(1459, 13, 29, 1031, 1),
(1460, 23, 11, 1031, 1),
(1461, 4, 55, 1031, 1),
(1462, 14, 28, 1031, 1),
(1463, 24, 10, 1031, 1),
(1464, 5, 45, 1031, 1),
(1465, 15, 27, 1031, 1),
(1466, 25, 9, 1031, 1),
(1467, 6, 40, 1031, 1),
(1468, 16, 26, 1031, 1),
(1469, 26, 8, 1031, 1),
(1470, 7, 37, 1031, 1),
(1471, 17, 23, 1031, 1),
(1472, 27, 7, 1031, 1),
(1473, 8, 35, 1031, 1),
(1474, 18, 20, 1031, 1),
(1475, 28, 6, 1031, 1),
(1476, 9, 33, 1031, 1),
(1477, 19, 17, 1031, 1),
(1478, 29, 5, 1031, 1),
(1479, 10, 32, 1031, 1),
(1480, 20, 15, 1031, 1),
(1481, 30, 4, 1031, 1),
(1482, 1, 100, 1032, 1),
(1483, 11, 23, 1032, 1),
(1484, 21, 3, 1032, 1),
(1485, 2, 80, 1032, 1),
(1486, 12, 22, 1032, 1),
(1487, 22, 3, 1032, 1),
(1488, 3, 65, 1032, 1),
(1489, 13, 17, 1032, 1),
(1490, 23, 3, 1032, 1),
(1491, 4, 52, 1032, 1),
(1492, 14, 15, 1032, 1),
(1493, 24, 3, 1032, 1),
(1494, 5, 42, 1032, 1),
(1495, 15, 13, 1032, 1),
(1496, 6, 37, 1032, 1),
(1497, 16, 11, 1032, 1),
(1498, 7, 32, 1032, 1),
(1499, 17, 9, 1032, 1),
(1500, 8, 28, 1032, 1),
(1501, 18, 8, 1032, 1),
(1502, 9, 25, 1032, 1),
(1503, 19, 7, 1032, 1),
(1504, 10, 24, 1032, 1),
(1505, 20, 6, 1032, 1),
(1347, 11, 10, 1027, 1),
(1348, 2, 80, 1027, 1),
(1349, 12, 10, 1027, 1),
(1350, 3, 50, 1027, 1),
(1351, 13, 5, 1027, 1),
(1352, 4, 50, 1027, 1),
(1353, 14, 4, 1027, 1),
(1354, 5, 30, 1027, 1),
(1355, 15, 2, 1027, 1),
(1356, 6, 30, 1027, 1),
(1357, 16, 2, 1027, 1),
(1358, 7, 30, 1027, 1),
(1359, 8, 30, 1027, 1),
(1360, 9, 10, 1027, 1),
(1361, 10, 10, 1027, 1),
(1346, 1, 100, 1027, 1),
(1506, 1, 100, 1033, 1),
(1507, 11, 23, 1033, 1),
(1508, 21, 5, 1033, 1),
(1509, 2, 80, 1033, 1),
(1510, 12, 22, 1033, 1),
(1511, 22, 4, 1033, 1),
(1512, 3, 65, 1033, 1),
(1513, 13, 17, 1033, 1),
(1514, 23, 3, 1033, 1),
(1515, 4, 52, 1033, 1),
(1516, 14, 15, 1033, 1),
(1517, 24, 2, 1033, 1),
(1518, 5, 42, 1033, 1),
(1519, 15, 13, 1033, 1),
(1520, 6, 37, 1033, 1),
(1521, 16, 11, 1033, 1),
(1522, 7, 32, 1033, 1),
(1523, 17, 9, 1033, 1),
(1524, 8, 28, 1033, 1),
(1525, 18, 8, 1033, 1),
(1526, 9, 25, 1033, 1),
(1527, 19, 7, 1033, 1),
(1528, 10, 24, 1033, 1),
(1529, 20, 6, 1033, 1),
(1530, 1, 100, 1034, 1),
(1531, 11, 23, 1034, 1),
(1532, 21, 3, 1034, 1),
(1533, 2, 80, 1034, 1),
(1534, 12, 22, 1034, 1),
(1535, 22, 3, 1034, 1),
(1536, 3, 65, 1034, 1),
(1537, 13, 17, 1034, 1),
(1538, 23, 3, 1034, 1),
(1539, 4, 52, 1034, 1),
(1540, 14, 15, 1034, 1),
(1541, 24, 3, 1034, 1),
(1542, 5, 32, 1034, 1),
(1543, 15, 13, 1034, 1),
(1544, 6, 32, 1034, 1),
(1545, 16, 11, 1034, 1),
(1546, 7, 32, 1034, 1),
(1547, 17, 9, 1034, 1),
(1548, 8, 32, 1034, 1),
(1549, 18, 8, 1034, 1),
(1550, 9, 25, 1034, 1),
(1551, 19, 7, 1034, 1),
(1552, 10, 24, 1034, 1),
(1553, 20, 6, 1034, 1),
(3881, 1, 100, 3060, 1),
(3882, 11, 23, 3060, 1),
(3883, 21, 5, 3060, 1),
(3884, 2, 80, 3060, 1),
(3885, 12, 22, 3060, 1),
(3886, 22, 4, 3060, 1),
(3887, 3, 65, 3060, 1),
(3888, 13, 17, 3060, 1),
(3889, 23, 3, 3060, 1),
(3890, 4, 52, 3060, 1),
(3891, 14, 15, 3060, 1),
(3892, 24, 2, 3060, 1),
(3893, 5, 42, 3060, 1),
(3894, 15, 13, 3060, 1),
(3895, 6, 37, 3060, 1),
(3896, 16, 11, 3060, 1),
(3897, 7, 32, 3060, 1),
(3898, 17, 9, 3060, 1),
(3899, 8, 28, 3060, 1),
(3900, 18, 8, 3060, 1),
(3901, 9, 25, 3060, 1),
(3902, 19, 7, 3060, 1),
(3903, 10, 24, 3060, 1),
(3904, 20, 6, 3060, 1),
(3861, 1, 100, 3059, 1),
(3862, 11, 17, 3059, 1),
(3863, 2, 80, 3059, 1),
(3864, 12, 15, 3059, 1),
(3865, 3, 65, 3059, 1),
(3866, 13, 13, 3059, 1),
(3867, 4, 50, 3059, 1),
(3868, 14, 11, 3059, 1),
(3869, 5, 40, 3059, 1),
(3870, 15, 9, 3059, 1),
(3871, 6, 35, 3059, 1),
(3872, 16, 7, 3059, 1),
(3873, 7, 30, 3059, 1),
(3874, 17, 5, 3059, 1),
(3875, 8, 25, 3059, 1),
(3876, 18, 4, 3059, 1),
(3877, 9, 22, 3059, 1),
(3878, 19, 3, 3059, 1),
(3879, 10, 19, 3059, 1),
(3880, 20, 2, 3059, 1),
(3905, 1, 100, 3061, 1),
(3906, 11, 31, 3061, 1),
(3907, 21, 13, 3061, 1),
(3908, 31, 3, 3061, 1),
(3909, 2, 80, 3061, 1),
(3910, 12, 30, 3061, 1),
(3911, 22, 12, 3061, 1),
(3912, 32, 2, 3061, 1),
(3913, 3, 65, 3061, 1),
(3914, 13, 29, 3061, 1),
(3915, 23, 11, 3061, 1),
(3916, 4, 55, 3061, 1),
(3917, 14, 28, 3061, 1),
(3918, 24, 10, 3061, 1),
(3919, 5, 45, 3061, 1),
(3920, 15, 27, 3061, 1),
(3921, 25, 9, 3061, 1),
(3922, 6, 40, 3061, 1),
(3923, 16, 26, 3061, 1),
(3924, 26, 8, 3061, 1),
(3925, 7, 37, 3061, 1),
(3926, 17, 23, 3061, 1),
(3927, 27, 7, 3061, 1),
(3928, 8, 35, 3061, 1),
(3929, 18, 20, 3061, 1),
(3930, 28, 6, 3061, 1),
(3931, 9, 33, 3061, 1),
(3932, 19, 17, 3061, 1),
(3933, 29, 5, 3061, 1),
(3934, 10, 32, 3061, 1),
(3935, 20, 15, 3061, 1),
(3936, 30, 4, 3061, 1),
(3937, 1, 100, 3062, 1),
(3938, 11, 36, 3062, 1),
(3939, 21, 26, 3062, 1),
(3940, 31, 12, 3062, 1),
(3941, 41, 2, 3062, 1),
(3942, 2, 85, 3062, 1),
(3943, 12, 35, 3062, 1),
(3944, 22, 25, 3062, 1),
(3945, 32, 11, 3062, 1),
(3946, 42, 2, 3062, 1),
(3947, 3, 70, 3062, 1),
(3948, 13, 34, 3062, 1),
(3949, 23, 24, 3062, 1),
(3950, 33, 10, 3062, 1),
(3951, 43, 2, 3062, 1),
(3952, 4, 60, 3062, 1),
(3953, 14, 33, 3062, 1),
(3954, 24, 23, 3062, 1),
(3955, 34, 9, 3062, 1),
(3956, 44, 2, 3062, 1),
(3957, 5, 54, 3062, 1),
(3958, 15, 32, 3062, 1),
(3959, 25, 18, 3062, 1),
(3960, 35, 8, 3062, 1),
(3961, 45, 2, 3062, 1),
(3962, 6, 52, 3062, 1),
(3963, 16, 31, 3062, 1),
(3964, 26, 17, 3062, 1),
(3965, 36, 7, 3062, 1),
(3966, 46, 2, 3062, 1),
(3967, 7, 50, 3062, 1),
(3968, 17, 30, 3062, 1),
(3969, 27, 16, 3062, 1),
(3970, 37, 6, 3062, 1),
(3971, 47, 2, 3062, 1),
(3972, 8, 48, 3062, 1),
(3973, 18, 29, 3062, 1),
(3974, 28, 15, 3062, 1),
(3975, 38, 5, 3062, 1),
(3976, 48, 2, 3062, 1),
(3977, 9, 38, 3062, 1),
(3978, 19, 28, 3062, 1),
(3979, 29, 14, 3062, 1),
(3980, 39, 4, 3062, 1),
(3981, 10, 37, 3062, 1),
(3982, 20, 27, 3062, 1),
(3983, 30, 13, 3062, 1),
(3984, 40, 3, 3062, 1),
(3610, 1, 100, 3039, 1),
(3611, 2, 75, 3039, 1),
(3612, 3, 50, 3039, 1),
(3613, 4, 30, 3039, 1),
(3614, 5, 15, 3039, 1),
(3615, 6, 2, 3039, 1),
(3770, 1, 100, 3051, 1),
(3771, 2, 75, 3051, 1),
(3772, 3, 50, 3051, 1),
(3773, 4, 35, 3051, 1),
(3774, 5, 20, 3051, 1),
(3775, 6, 10, 3051, 1),
(3776, 7, 2, 3051, 1),
(3777, 1, 100, 3052, 1),
(3778, 2, 80, 3052, 1),
(3779, 3, 60, 3052, 1),
(3780, 4, 45, 3052, 1),
(3781, 5, 33, 3052, 1),
(3782, 6, 21, 3052, 1),
(3783, 7, 10, 3052, 1),
(3784, 8, 2, 3052, 1),
(3785, 1, 100, 3053, 1),
(3786, 2, 80, 3053, 1),
(3787, 3, 60, 3053, 1),
(3788, 4, 45, 3053, 1),
(3789, 5, 33, 3053, 1),
(3790, 6, 21, 3053, 1),
(3791, 7, 12, 3053, 1),
(3792, 8, 5, 3053, 1),
(3793, 9, 2, 3053, 1),
(3794, 1, 100, 3054, 1),
(3795, 2, 80, 3054, 1),
(3796, 3, 65, 3054, 1),
(3797, 4, 50, 3054, 1),
(3798, 5, 40, 3054, 1),
(3799, 6, 30, 3054, 1),
(3800, 7, 20, 3054, 1),
(3801, 8, 10, 3054, 1),
(3802, 9, 5, 3054, 1),
(3803, 10, 2, 3054, 1),
(3804, 1, 100, 3055, 1),
(3805, 11, 2, 3055, 1),
(3806, 2, 80, 3055, 1),
(3807, 3, 65, 3055, 1),
(3808, 4, 50, 3055, 1),
(3809, 5, 40, 3055, 1),
(3810, 6, 30, 3055, 1),
(3811, 7, 20, 3055, 1),
(3812, 8, 15, 3055, 1),
(3813, 9, 10, 3055, 1),
(3814, 10, 5, 3055, 1),
(3815, 1, 100, 3056, 1),
(3816, 11, 5, 3056, 1),
(3817, 2, 80, 3056, 1),
(3818, 12, 2, 3056, 1),
(3819, 3, 65, 3056, 1),
(3820, 4, 50, 3056, 1),
(3821, 5, 40, 3056, 1),
(3822, 6, 30, 3056, 1),
(3823, 7, 25, 3056, 1),
(3824, 8, 20, 3056, 1),
(3825, 9, 15, 3056, 1),
(3826, 10, 10, 3056, 1),
(3827, 1, 100, 3057, 1),
(3828, 11, 10, 3057, 1),
(3829, 2, 80, 3057, 1),
(3830, 12, 7, 3057, 1),
(3831, 3, 65, 3057, 1),
(3832, 13, 5, 3057, 1),
(3833, 4, 50, 3057, 1),
(3834, 14, 4, 3057, 1),
(3835, 5, 40, 3057, 1),
(3836, 15, 3, 3057, 1),
(3837, 6, 35, 3057, 1),
(3838, 16, 2, 3057, 1),
(3839, 7, 30, 3057, 1),
(3840, 8, 25, 3057, 1),
(3841, 9, 20, 3057, 1),
(3842, 10, 15, 3057, 1),
(3843, 1, 100, 3058, 1),
(3844, 11, 16, 3058, 1),
(3845, 2, 80, 3058, 1),
(3846, 12, 13, 3058, 1),
(3847, 3, 65, 3058, 1),
(3848, 13, 11, 3058, 1),
(3849, 4, 50, 3058, 1),
(3850, 14, 9, 3058, 1),
(3851, 5, 40, 3058, 1),
(3852, 15, 7, 3058, 1),
(3853, 6, 35, 3058, 1),
(3854, 16, 5, 3058, 1),
(3855, 7, 30, 3058, 1),
(3856, 17, 3, 3058, 1),
(3857, 8, 25, 3058, 1),
(3858, 18, 2, 3058, 1),
(3859, 9, 22, 3058, 1),
(3860, 10, 19, 3058, 1);

-- --------------------------------------------------------

--
-- Structure de la table `cat`
--

DROP TABLE IF EXISTS `cat`;
CREATE TABLE IF NOT EXISTS `cat` (
  `CAT_ID` bigint(20) NOT NULL,
  `GCAT_CD` varchar(5) NOT NULL,
  `CAT_LB` varchar(32) NOT NULL,
  `CAT_CD` varchar(5) NOT NULL,
  `CAT_DT_DEB` date NOT NULL,
  `CAT_DT_FIN` date NOT NULL,
  `CAT_FG` enum('M','F','X','') NOT NULL DEFAULT 'X',
  `DEM_ID` bigint(20) DEFAULT 0,
  `BL_MAJ` tinyint(4) DEFAULT 0,
  PRIMARY KEY (`CAT_ID`),
  KEY `GCAT_CD` (`GCAT_CD`)
) ENGINE=MyISAM DEFAULT CHARSET=utf16;

--
-- Déchargement des données de la table `cat`
--

INSERT INTO `cat` (`CAT_ID`, `GCAT_CD`, `CAT_LB`, `CAT_CD`, `CAT_DT_DEB`, `CAT_DT_FIN`, `CAT_FG`, `DEM_ID`, `BL_MAJ`) VALUES
(16, 'VET  ', 'Veterans 4', 'V4', '1800-12-31', '1934-06-30', 'M', 0, 1),
(15, 'VET  ', 'Veterans 3 Messieurs', 'V3', '1934-07-01', '1944-06-30', 'M', 0, 1),
(14, 'VET  ', 'Veterans 3 Dames', 'V3D', '1800-12-31', '1944-06-30', 'F', 0, 1),
(13, 'VET  ', 'Veterans 2', 'V2', '1944-07-01', '1954-06-30', 'X', 0, 1),
(12, 'VET  ', 'Veterans 1', 'V1', '1954-07-01', '1964-06-30', 'X', 0, 1),
(11, 'SEN  ', 'Seniors', 'S', '1964-07-01', '1987-06-30', 'X', 0, 1),
(10, 'JUN  ', 'Juniors 3', 'J3', '1987-07-01', '1988-06-30', 'X', 0, 1),
(9, 'JUN  ', 'Juniors 2', 'J2', '1988-07-01', '1989-06-30', 'X', 0, 1),
(8, 'JUN  ', 'Juniors 1', 'J1', '1989-07-01', '1990-06-30', 'X', 0, 1),
(7, 'CAD  ', 'Cadets 2', 'C2', '1990-07-01', '1991-06-30', 'X', 0, 1),
(6, 'CAD  ', 'Cadets 1', 'C1', '1991-07-01', '1992-06-30', 'X', 0, 1),
(5, 'MIN  ', 'Minimes 2', 'M2', '1992-07-01', '1993-06-30', 'X', 0, 1),
(4, 'MIN  ', 'Minimes 1', 'M1', '1993-07-01', '1994-06-30', 'X', 0, 1),
(3, 'BEN  ', 'Benjamins 2', 'B2', '1994-07-01', '1995-06-30', 'X', 0, 1),
(2, 'BEN  ', 'Benjamins 1', 'B1', '1995-07-01', '1996-06-30', 'X', 0, 1),
(1, 'POU  ', 'Poussin', 'P', '1996-07-01', '2099-12-31', 'X', 0, 1),
(-101, '', 'Inconnue', 'I', '1990-01-01', '1990-01-01', 'X', NULL, 1);

-- --------------------------------------------------------

--
-- Structure de la table `categorie_epreuve`
--

DROP TABLE IF EXISTS `categorie_epreuve`;
CREATE TABLE IF NOT EXISTS `categorie_epreuve` (
  `DIV_ID` bigint(20) NOT NULL,
  `CAT_ID` bigint(20) NOT NULL,
  `CAT_EPR_BL_PRINCIPAL` tinyint(4) NOT NULL,
  PRIMARY KEY (`DIV_ID`,`CAT_ID`),
  KEY `DIV_ID` (`DIV_ID`),
  KEY `CAT_ID` (`CAT_ID`)
) ENGINE=MyISAM DEFAULT CHARSET=utf16;

-- --------------------------------------------------------

--
-- Structure de la table `cat_age_group`
--

DROP TABLE IF EXISTS `cat_age_group`;
CREATE TABLE IF NOT EXISTS `cat_age_group` (
  `GCAT_CD` char(5) NOT NULL,
  `GCAT_LB_COURT` varchar(5) NOT NULL,
  `GCAT_LB` varchar(32) NOT NULL,
  `BL_MAJ` tinyint(1) NOT NULL DEFAULT 0,
  PRIMARY KEY (`GCAT_CD`)
) ENGINE=MyISAM DEFAULT CHARSET=utf16;

--
-- Déchargement des données de la table `cat_age_group`
--

INSERT INTO `cat_age_group` (`GCAT_CD`, `GCAT_LB_COURT`, `GCAT_LB`, `BL_MAJ`) VALUES
('INC', 'INC', 'Inconnu', 0),
('POU', 'POU', 'Poussins', 1),
('BEN', 'BEN', 'Benjamins', 1),
('MIN', 'MIN', 'Minimes', 1),
('CAD', 'CAD', 'Cadets', 1),
('JUN', 'JUN', 'Juniors', 1),
('SEN', 'SEN', 'Seniors', 1),
('VET', 'VET', 'Veterans', 1);

-- --------------------------------------------------------

--
-- Structure de la table `cellule_pot`
--

DROP TABLE IF EXISTS `cellule_pot`;
CREATE TABLE IF NOT EXISTS `cellule_pot` (
  `CELLULE_ID` bigint(20) NOT NULL,
  `LIGNE_POT_ID` bigint(20) NOT NULL,
  `TABPART_ID_TABLEAU` bigint(20) DEFAULT NULL,
  `CELL_NM_TABLE` int(11) DEFAULT NULL,
  `CELL_LB_PARTIE` varchar(64) DEFAULT NULL,
  `CELL_CODE_ROUGE` int(11) DEFAULT NULL,
  `CELL_CODE_VERT` int(11) DEFAULT NULL,
  `CELL_CODE_BLEU` int(11) DEFAULT NULL,
  PRIMARY KEY (`CELLULE_ID`),
  KEY `LIGNE_POT_ID` (`LIGNE_POT_ID`),
  KEY `TABPART_ID_TABLEAU` (`TABPART_ID_TABLEAU`)
) ENGINE=MyISAM DEFAULT CHARSET=utf16;

-- --------------------------------------------------------

--
-- Structure de la table `classement`
--

DROP TABLE IF EXISTS `classement`;
CREATE TABLE IF NOT EXISTS `classement` (
  `CLST_ID` bigint(20) NOT NULL,
  `POUL_ID` bigint(20) DEFAULT NULL,
  `CLST_NB_RANG` int(11) DEFAULT NULL,
  `CLST_NB_POINTS` int(11) DEFAULT NULL,
  `CLST_NB_VICTOIRE` int(11) DEFAULT NULL,
  `CLST_NB_DEFAITE` int(11) DEFAULT NULL,
  `CLST_NB_EGALITE` int(11) DEFAULT NULL,
  `CLST_NB_FORFAITS` int(11) DEFAULT NULL,
  `CLST_NB_PENALITE` int(11) DEFAULT NULL,
  `CLST_NB_GAGNE` int(11) DEFAULT NULL,
  `CLST_NB_PERDUES` int(11) DEFAULT NULL,
  `EQUIP_ID` bigint(20) DEFAULT NULL,
  `LIC_ID` bigint(20) DEFAULT NULL,
  `TAB_ID` bigint(20) DEFAULT NULL,
  `CLST_CD_LETTRE` char(2) DEFAULT NULL,
  `NIV_ID` bigint(20) DEFAULT NULL,
  `CLST_RANG_FORFAIT` char(2) DEFAULT NULL,
  PRIMARY KEY (`CLST_ID`),
  KEY `POUL_ID` (`POUL_ID`),
  KEY `NIV_ID` (`NIV_ID`),
  KEY `TAB_ID` (`TAB_ID`),
  KEY `LIC_ID` (`LIC_ID`)
) ENGINE=MyISAM DEFAULT CHARSET=utf16;

--
-- Déchargement des données de la table `classement`
--

INSERT INTO `classement` (`CLST_ID`, `POUL_ID`, `CLST_NB_RANG`, `CLST_NB_POINTS`, `CLST_NB_VICTOIRE`, `CLST_NB_DEFAITE`, `CLST_NB_EGALITE`, `CLST_NB_FORFAITS`, `CLST_NB_PENALITE`, `CLST_NB_GAGNE`, `CLST_NB_PERDUES`, `EQUIP_ID`, `LIC_ID`, `TAB_ID`, `CLST_CD_LETTRE`, `NIV_ID`, `CLST_RANG_FORFAIT`) VALUES
(-101, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL);

-- --------------------------------------------------------

--
-- Structure de la table `club`
--

DROP TABLE IF EXISTS `club`;
CREATE TABLE IF NOT EXISTS `club` (
  `CLUB_ID` bigint(20) NOT NULL,
  `ORGA_ID` bigint(20) DEFAULT NULL,
  `CLUB_NM` varchar(8) NOT NULL,
  `CLUB_LB_LONG` varchar(32) NOT NULL,
  `CLUB_LB_COURT` varchar(15) NOT NULL,
  `CLUB_FG` char(1) NOT NULL,
  PRIMARY KEY (`CLUB_ID`),
  KEY `ORGA_ID` (`ORGA_ID`)
) ENGINE=MyISAM DEFAULT CHARSET=utf16;

--
-- Déchargement des données de la table `club`
--

INSERT INTO `club` (`CLUB_ID`, `ORGA_ID`, `CLUB_NM`, `CLUB_LB_LONG`, `CLUB_LB_COURT`, `CLUB_FG`) VALUES
(-101, -101, '0', 'Inconnu', 'Inc', 'M');

-- --------------------------------------------------------

--
-- Structure de la table `division`
--

DROP TABLE IF EXISTS `division`;
CREATE TABLE IF NOT EXISTS `division` (
  `DIV_ID` bigint(20) NOT NULL,
  `ORGA_ID` bigint(20) NOT NULL,
  `EPRV_ID` bigint(20) NOT NULL,
  `DIV_CD` varchar(5) NOT NULL,
  `DIV_LB` varchar(32) NOT NULL,
  `DIV_NB_POULE` int(11) NOT NULL,
  `DIV_FG_SEXE` char(1) NOT NULL,
  `DIV_FG_TYPE_LICENCE` char(1) NOT NULL,
  `DIV_BL_CORPO` tinyint(1) NOT NULL,
  `DIV_NB_TOUR` tinyint(1) DEFAULT NULL,
  `DIV_CD_LETTRE` varchar(2) NOT NULL,
  `DIV_CM` text DEFAULT NULL,
  `DIV_LB_USER_MODIF` varchar(15) NOT NULL,
  `BAR_ID` bigint(20) DEFAULT NULL,
  `GCAT_CD` char(5) DEFAULT NULL,
  `DIV_DIV_ID` bigint(20) DEFAULT NULL,
  `DIV_BL_DOUBLE` tinyint(4) DEFAULT NULL,
  `DIV_NB_POINT_MANCHE` int(11) DEFAULT 11,
  `DIV_NB_MANCHE_POULE` int(11) DEFAULT 0,
  `DIV_NB_MANCHE_TAB` int(11) DEFAULT 0,
  `DIV_NB_POINT_MIN` int(11) DEFAULT 0,
  `DIV_NB_POINT_MAX` int(11) DEFAULT 9999,
  `DIV_DT_TOUR` date DEFAULT NULL,
  PRIMARY KEY (`DIV_ID`),
  KEY `ORGA_ID` (`ORGA_ID`),
  KEY `EPRV_ID` (`EPRV_ID`),
  KEY `BAR_ID` (`BAR_ID`),
  KEY `GCAT_CD` (`GCAT_CD`)
) ENGINE=MyISAM DEFAULT CHARSET=utf16;

--
-- Déchargement des données de la table `division`
--

INSERT INTO `division` (`DIV_ID`, `ORGA_ID`, `EPRV_ID`, `DIV_CD`, `DIV_LB`, `DIV_NB_POULE`, `DIV_FG_SEXE`, `DIV_FG_TYPE_LICENCE`, `DIV_BL_CORPO`, `DIV_NB_TOUR`, `DIV_CD_LETTRE`, `DIV_CM`, `DIV_LB_USER_MODIF`, `BAR_ID`, `GCAT_CD`, `DIV_DIV_ID`, `DIV_BL_DOUBLE`, `DIV_NB_POINT_MANCHE`, `DIV_NB_MANCHE_POULE`, `DIV_NB_MANCHE_TAB`, `DIV_NB_POINT_MIN`, `DIV_NB_POINT_MAX`, `DIV_DT_TOUR`) VALUES
(-101, -101, 2302, 'INC', 'Inconnue', 0, 'D', 'T', 0, 0, 'L', NULL, 'SPIDD', NULL, NULL, NULL, 0, 0, 0, 0, 0, 0, '2003-12-05');

-- --------------------------------------------------------

--
-- Structure de la table `epreuve`
--

DROP TABLE IF EXISTS `epreuve`;
CREATE TABLE IF NOT EXISTS `epreuve` (
  `EPRV_ID` bigint(20) NOT NULL,
  `ORGA_ID` bigint(20) NOT NULL,
  `EPR_EPRV_ID` bigint(20) DEFAULT NULL,
  `EPRV_CD` char(2) NOT NULL,
  `EPRV_LB_COURT` varchar(5) NOT NULL,
  `EPRV_LB` varchar(32) NOT NULL,
  `EPRV_FG` char(1) NOT NULL,
  `EPRV_CM` text DEFAULT NULL,
  `EPRV_LB_USER_MODIF` varchar(15) NOT NULL,
  PRIMARY KEY (`EPRV_ID`),
  KEY `ORGA_ID` (`ORGA_ID`)
) ENGINE=MyISAM DEFAULT CHARSET=utf16;

--
-- Déchargement des données de la table `epreuve`
--

INSERT INTO `epreuve` (`EPRV_ID`, `ORGA_ID`, `EPR_EPRV_ID`, `EPRV_CD`, `EPRV_LB_COURT`, `EPRV_LB`, `EPRV_FG`, `EPRV_CM`, `EPRV_LB_USER_MODIF`) VALUES
(-101, -101, NULL, 'IN', 'Inc', 'Iconnu', 'I', '', 'SPIDD');

-- --------------------------------------------------------

--
-- Structure de la table `grille_detail`
--

DROP TABLE IF EXISTS `grille_detail`;
CREATE TABLE IF NOT EXISTS `grille_detail` (
  `DGRIL_ID_DETAIL` int(11) NOT NULL,
  `DGRIL_NB_JOURNEE` int(11) NOT NULL,
  `DGRIL_NB_EQUIPE1` int(11) NOT NULL,
  `DGRIL_NB_EQUIPE2` int(11) NOT NULL,
  `GRIL_ID_RENC` int(11) NOT NULL,
  `BL_MAJ` int(11) DEFAULT 0,
  PRIMARY KEY (`DGRIL_ID_DETAIL`),
  KEY `GRIL_ID_RENC` (`GRIL_ID_RENC`)
) ENGINE=MyISAM DEFAULT CHARSET=utf16;

--
-- Déchargement des données de la table `grille_detail`
--

INSERT INTO `grille_detail` (`DGRIL_ID_DETAIL`, `DGRIL_NB_JOURNEE`, `DGRIL_NB_EQUIPE1`, `DGRIL_NB_EQUIPE2`, `GRIL_ID_RENC`, `BL_MAJ`) VALUES
(1531, 1, 1, 4, 1037, 1),
(1532, 1, 2, 3, 1037, 1),
(1533, 2, 1, 3, 1037, 1),
(1534, 2, 2, 4, 1037, 1),
(1535, 3, 1, 2, 1037, 1),
(1536, 3, 3, 4, 1037, 1),
(1537, 1, 1, 6, 1038, 1),
(1538, 1, 2, 5, 1038, 1),
(1539, 1, 3, 4, 1038, 1),
(1540, 2, 1, 5, 1038, 1),
(1541, 2, 4, 6, 1038, 1),
(1542, 2, 2, 3, 1038, 1),
(1543, 3, 1, 4, 1038, 1),
(1544, 3, 3, 5, 1038, 1),
(1545, 3, 2, 6, 1038, 1),
(1546, 4, 1, 3, 1038, 1),
(1547, 4, 2, 4, 1038, 1),
(1548, 4, 5, 6, 1038, 1),
(1549, 5, 1, 2, 1038, 1),
(1550, 5, 3, 6, 1038, 1),
(1551, 5, 4, 5, 1038, 1),
(4112, 1, 1, 3, 3049, 1),
(4113, 1, -1, -1, 3049, 1),
(4114, 2, 2, 3, 3049, 1),
(4115, 2, -1, -1, 3049, 1),
(4116, 3, 1, 2, 3049, 1),
(4117, 3, -1, -1, 3049, 1),
(4118, 1, 2, 5, 3050, 1),
(4119, 1, 3, 4, 3050, 1),
(4120, 1, -1, -1, 3050, 1),
(4121, 2, 1, 5, 3050, 1),
(4122, 2, 2, 3, 3050, 1),
(4123, 2, -1, -1, 3050, 1),
(4124, 3, 1, 4, 3050, 1),
(4125, 3, 3, 5, 3050, 1),
(4126, 3, -1, -1, 3050, 1),
(4127, 4, 1, 3, 3050, 1),
(4128, 4, 2, 4, 3050, 1),
(4129, 4, -1, -1, 3050, 1),
(4130, 5, 1, 2, 3050, 1),
(4131, 5, 4, 5, 3050, 1),
(4132, 5, -1, -1, 3050, 1),
(5274, 1, 2, 7, 3105, 1),
(5275, 1, 3, 6, 3105, 1),
(5276, 1, 4, 5, 3105, 1),
(5277, 2, 1, 7, 3105, 1),
(5278, 2, 2, 5, 3105, 1),
(5279, 2, 3, 4, 3105, 1),
(5280, 2, 6, -1, 3105, 1),
(5281, 3, 1, 6, 3105, 1),
(5282, 3, 5, 7, 3105, 1),
(5283, 3, 2, 3, 3105, 1),
(5284, 3, 4, -1, 3105, 1),
(5285, 4, 1, 5, 3105, 1),
(5286, 4, 4, 6, 3105, 1),
(5287, 4, 3, 7, 3105, 1),
(5288, 4, 2, -1, 3105, 1),
(5273, 1, 1, -1, 3105, 1),
(5289, 5, 1, 4, 3105, 1),
(5290, 5, 3, 5, 3105, 1),
(5291, 5, 2, 6, 3105, 1),
(5292, 5, 7, -1, 3105, 1),
(5293, 6, 1, 3, 3105, 1),
(5294, 6, 2, 4, 3105, 1),
(5295, 6, 6, 7, 3105, 1),
(5296, 6, 5, -1, 3105, 1),
(5297, 7, 1, 2, 3105, 1),
(5298, 7, 4, 7, 3105, 1),
(5299, 7, 5, 6, 3105, 1),
(5300, 7, 3, -1, 3105, 1),
(13822, 1, 1, 8, 3517, 1),
(13823, 1, 2, 7, 3517, 1),
(13824, 1, 3, 6, 3517, 1),
(13825, 1, 4, 5, 3517, 1),
(13826, 2, 1, 7, 3517, 1),
(13827, 2, 6, 8, 3517, 1),
(13828, 2, 2, 5, 3517, 1),
(13829, 2, 3, 4, 3517, 1),
(13830, 3, 1, 6, 3517, 1),
(13831, 3, 5, 7, 3517, 1),
(13832, 3, 4, 8, 3517, 1),
(13833, 3, 2, 3, 3517, 1),
(13834, 4, 1, 5, 3517, 1),
(13835, 4, 4, 6, 3517, 1),
(13836, 4, 3, 7, 3517, 1),
(13837, 4, 2, 8, 3517, 1),
(13838, 5, 1, 4, 3517, 1),
(13839, 5, 3, 5, 3517, 1),
(13840, 5, 2, 6, 3517, 1),
(13841, 5, 7, 8, 3517, 1),
(13842, 6, 1, 3, 3517, 1),
(13843, 6, 2, 4, 3517, 1),
(13844, 6, 5, 8, 3517, 1),
(13845, 6, 6, 7, 3517, 1),
(13846, 7, 1, 2, 3517, 1),
(13847, 7, 3, 8, 3517, 1),
(13848, 7, 4, 7, 3517, 1),
(13849, 7, 5, 6, 3517, 1),
(13879, 1, 2, 7, 3520, 1),
(13880, 1, 3, 6, 3520, 1),
(13881, 1, 4, 5, 3520, 1),
(13882, 1, -1, -1, 3520, 1),
(13883, 2, 1, 7, 3520, 1),
(13884, 2, 2, 5, 3520, 1),
(13885, 2, 3, 4, 3520, 1),
(13886, 2, -1, -1, 3520, 1),
(13887, 3, 1, 6, 3520, 1),
(13888, 3, 5, 7, 3520, 1),
(13889, 3, 2, 3, 3520, 1),
(13890, 3, -1, -1, 3520, 1),
(13891, 4, 1, 5, 3520, 1),
(13892, 4, 4, 6, 3520, 1),
(13893, 4, 3, 7, 3520, 1),
(13894, 4, -1, -1, 3520, 1),
(13895, 5, 1, 4, 3520, 1),
(13896, 5, 3, 5, 3520, 1),
(13897, 5, 2, 6, 3520, 1),
(13898, 5, -1, -1, 3520, 1),
(13899, 6, 1, 3, 3520, 1),
(13900, 6, 2, 4, 3520, 1),
(13901, 6, 6, 7, 3520, 1),
(13902, 6, -1, -1, 3520, 1),
(13903, 7, 1, 2, 3520, 1),
(13904, 7, 4, 7, 3520, 1),
(13905, 7, 5, 6, 3520, 1),
(13906, 7, -1, -1, 3520, 1);

-- --------------------------------------------------------

--
-- Structure de la table `grille_rencontre`
--

DROP TABLE IF EXISTS `grille_rencontre`;
CREATE TABLE IF NOT EXISTS `grille_rencontre` (
  `GRIL_ID_RENC` bigint(20) NOT NULL,
  `ORGA_ID` bigint(20) NOT NULL,
  `GRIL_CD_RENC` varchar(5) NOT NULL,
  `GRIL_LB_RENC` varchar(32) NOT NULL,
  `GRIL_NB_EQUIPE` int(11) NOT NULL,
  `GRIL_FG` char(2) NOT NULL,
  `GRIL_LB_USER_MODIF` varchar(20) DEFAULT 'Default',
  `GRIL_DT_CREATION` date DEFAULT '2021-07-01',
  `BL_MAJ` tinyint(4) DEFAULT 0,
  PRIMARY KEY (`GRIL_ID_RENC`),
  KEY `ORGA_ID` (`ORGA_ID`)
) ENGINE=MyISAM DEFAULT CHARSET=utf16;

--
-- Déchargement des données de la table `grille_rencontre`
--

INSERT INTO `grille_rencontre` (`GRIL_ID_RENC`, `ORGA_ID`, `GRIL_CD_RENC`, `GRIL_LB_RENC`, `GRIL_NB_EQUIPE`, `GRIL_FG`, `GRIL_LB_USER_MODIF`, `GRIL_DT_CREATION`, `BL_MAJ`) VALUES
(1037, 100001, 'P4', 'POULES 4 JOUEURS', 4, 'I', 'Default', '1900-01-01', 1),
(1038, 100001, 'p6', 'POULES 6 JOUEURS', 6, 'I', 'Default', '1900-01-01', 1),
(3049, 100001, 'P3', 'POULES 3 JOUEURS', 3, 'I', 'Default', '1900-01-01', 1),
(3050, 100001, 'P5', 'POULES 5 JOUEURS', 5, 'I', 'Default', '1900-01-01', 1),
(3105, 100001, 'P7', 'POULES 7 JOUEURS', 7, 'I', 'Default', '1900-01-01', 1),
(3517, 100001, 'P8', 'POULES 8 JOUEURS', 8, 'I', 'Default', '1900-01-01', 1),
(3520, 100001, 'P7B', 'Poule 7 joueurs', 7, 'I', 'Default', '1900-01-01', 1);

-- --------------------------------------------------------

--
-- Structure de la table `inscription`
--

DROP TABLE IF EXISTS `inscription`;
CREATE TABLE IF NOT EXISTS `inscription` (
  `INSC_ID` bigint(20) NOT NULL,
  `JOUE_ID` bigint(20) NOT NULL,
  `TOUR_ID` bigint(20) NOT NULL,
  `INSC_NB_DOSSARD` int(11) NOT NULL,
  `INSC_NB_RANG_POULE` int(11) NOT NULL,
  `INSC_NB_POINT_TOUR` int(11) DEFAULT NULL,
  `INSC_BL_ABSENT` tinyint(4) NOT NULL,
  `POUL_ID` bigint(20) DEFAULT NULL,
  `TOUR_ID_PREC` bigint(20) DEFAULT NULL,
  `INSC_NB_RANG_TOUR` int(11) DEFAULT NULL,
  `INSC_NM_RANG_TABLEAU` int(11) DEFAULT NULL,
  `INSC_CD_LETTRE` char(1) DEFAULT NULL,
  `TAB_ID` bigint(20) DEFAULT NULL,
  `INSC_BL_TETE_SERIE` tinyint(4) DEFAULT NULL,
  `INSC_NM_CLASSEMENT` int(11) DEFAULT NULL,
  `INSC_TIRAGE_POS_TAB` int(11) DEFAULT NULL,
  `INSC_BL_TIRAGE_TETE_SERIE` tinyint(4) DEFAULT NULL,
  PRIMARY KEY (`INSC_ID`),
  KEY `JOUE_ID` (`JOUE_ID`),
  KEY `TOUR_ID` (`TOUR_ID`),
  KEY `POUL_ID` (`POUL_ID`),
  KEY `TOUR_ID_PREC` (`TOUR_ID_PREC`),
  KEY `TAB_ID` (`TAB_ID`)
) ENGINE=MyISAM DEFAULT CHARSET=utf16;

--
-- Déchargement des données de la table `inscription`
--

INSERT INTO `inscription` (`INSC_ID`, `JOUE_ID`, `TOUR_ID`, `INSC_NB_DOSSARD`, `INSC_NB_RANG_POULE`, `INSC_NB_POINT_TOUR`, `INSC_BL_ABSENT`, `POUL_ID`, `TOUR_ID_PREC`, `INSC_NB_RANG_TOUR`, `INSC_NM_RANG_TABLEAU`, `INSC_CD_LETTRE`, `TAB_ID`, `INSC_BL_TETE_SERIE`, `INSC_NM_CLASSEMENT`, `INSC_TIRAGE_POS_TAB`, `INSC_BL_TIRAGE_TETE_SERIE`) VALUES
(-101, -101, -101, 0, 0, NULL, 0, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL);

-- --------------------------------------------------------

--
-- Structure de la table `joueur`
--

DROP TABLE IF EXISTS `joueur`;
CREATE TABLE IF NOT EXISTS `joueur` (
  `JOUE_ID` bigint(20) NOT NULL,
  `EPRV_ID` bigint(20) NOT NULL,
  `LIC_ID` bigint(20) NOT NULL,
  `JOUE_NB_POINT_TOTAL` varchar(64) DEFAULT NULL,
  `JOUE_BL_FORFAIT_GENE` int(11) NOT NULL,
  `JOUE_LB_TRI_POINT` varchar(64) DEFAULT NULL,
  `PRESENT` tinyint(1) NOT NULL DEFAULT 0,
  PRIMARY KEY (`JOUE_ID`),
  KEY `EPRV_ID` (`EPRV_ID`),
  KEY `LIC_ID` (`LIC_ID`)
) ENGINE=MyISAM DEFAULT CHARSET=utf16;

--
-- Déchargement des données de la table `joueur`
--

INSERT INTO `joueur` (`JOUE_ID`, `EPRV_ID`, `LIC_ID`, `JOUE_NB_POINT_TOTAL`, `JOUE_BL_FORFAIT_GENE`, `JOUE_LB_TRI_POINT`, `PRESENT`) VALUES
(-101, -101, -101, NULL, 0, NULL, 0);

-- --------------------------------------------------------

--
-- Structure de la table `licencie`
--

DROP TABLE IF EXISTS `licencie`;
CREATE TABLE IF NOT EXISTS `licencie` (
  `LIC_ID` bigint(20) NOT NULL,
  `CAT_ID` bigint(20) DEFAULT NULL,
  `CLUB_ID` bigint(20) DEFAULT NULL,
  `CLU_CLUB_ID` bigint(20) DEFAULT NULL,
  `TCLST_ID` bigint(20) DEFAULT NULL,
  `PERS_LB_NOM` varchar(64) DEFAULT NULL,
  `PERS_LB_PRENOM` varchar(15) DEFAULT NULL,
  `PERS_FG_SEXE` char(2) DEFAULT 'M',
  `PERS_DT_NAISSANCE` date DEFAULT NULL,
  `LIC_NB_LICENCE` varchar(8) DEFAULT NULL,
  `LIC_FG_NATIONALITE` char(2) DEFAULT NULL,
  `LIC_FG` char(2) DEFAULT NULL,
  `LIC_FG_MODULE` char(2) DEFAULT NULL,
  `LIC_FG_CERTIFICAT` char(2) DEFAULT NULL,
  `LIC_DT_CERTIFICAT` date DEFAULT NULL,
  `LIC_DT_VALIDATION` date DEFAULT NULL,
  `LIC_NB_PLACE` int(11) DEFAULT NULL,
  `LIC_NB_POINT` int(11) DEFAULT NULL,
  `LIC_FG_ECHELON` char(2) DEFAULT NULL,
  `LIC_NB_POINT_CF_PREC` varchar(64) DEFAULT NULL,
  `LIC_NB_POINT_TOTAL_CF` varchar(64) DEFAULT NULL,
  `LIC_NB_TRI_POINT_CF` varchar(64) DEFAULT NULL,
  `LIC_BL_LOCAL` tinyint(4) DEFAULT NULL,
  `LIC_BL_DOUBLE` tinyint(4) DEFAULT NULL,
  `LIC_NB_TOTAL_POINT_DOUBLE` int(11) DEFAULT NULL,
  `LIC_NB_POINT_TOUR_PREC_CF` varchar(64) DEFAULT NULL,
  `EPRV_ID` bigint(20) DEFAULT NULL,
  `DOUBLE_CLUB_ID` bigint(20) DEFAULT NULL,
  `DOUBLE_CLU_CLUB_ID` bigint(20) DEFAULT NULL,
  PRIMARY KEY (`LIC_ID`),
  KEY `CAT_ID` (`CAT_ID`),
  KEY `CLUB_ID` (`CLUB_ID`),
  KEY `EPRV_ID` (`EPRV_ID`),
  KEY `TCLST_ID` (`TCLST_ID`),
  KEY `EPRV_ID_2` (`EPRV_ID`)
) ENGINE=MyISAM DEFAULT CHARSET=utf16;

--
-- Déchargement des données de la table `licencie`
--

INSERT INTO `licencie` (`LIC_ID`, `CAT_ID`, `CLUB_ID`, `CLU_CLUB_ID`, `TCLST_ID`, `PERS_LB_NOM`, `PERS_LB_PRENOM`, `PERS_FG_SEXE`, `PERS_DT_NAISSANCE`, `LIC_NB_LICENCE`, `LIC_FG_NATIONALITE`, `LIC_FG`, `LIC_FG_MODULE`, `LIC_FG_CERTIFICAT`, `LIC_DT_CERTIFICAT`, `LIC_DT_VALIDATION`, `LIC_NB_PLACE`, `LIC_NB_POINT`, `LIC_FG_ECHELON`, `LIC_NB_POINT_CF_PREC`, `LIC_NB_POINT_TOTAL_CF`, `LIC_NB_TRI_POINT_CF`, `LIC_BL_LOCAL`, `LIC_BL_DOUBLE`, `LIC_NB_TOTAL_POINT_DOUBLE`, `LIC_NB_POINT_TOUR_PREC_CF`, `EPRV_ID`, `DOUBLE_CLUB_ID`, `DOUBLE_CLU_CLUB_ID`) VALUES
(-101, -101, -101, NULL, -101, 'Absent', NULL, 'M', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, 0, NULL, NULL, NULL, NULL, 1, NULL, NULL, NULL, NULL, NULL, NULL);

-- --------------------------------------------------------

--
-- Structure de la table `ligne_pot`
--

DROP TABLE IF EXISTS `ligne_pot`;
CREATE TABLE IF NOT EXISTS `ligne_pot` (
  `LIGNE_POT_ID` bigint(20) NOT NULL,
  `POT_ID` bigint(20) NOT NULL,
  `LIGNE_POT_NM_ORDRE` int(11) NOT NULL,
  `LIGNE_POT_LB` varchar(22) DEFAULT NULL,
  `LIGNE_POT_NB_TABLE` int(11) DEFAULT NULL,
  PRIMARY KEY (`LIGNE_POT_ID`),
  KEY `POT_ID` (`POT_ID`)
) ENGINE=MyISAM DEFAULT CHARSET=utf16;

-- --------------------------------------------------------

--
-- Structure de la table `manche`
--

DROP TABLE IF EXISTS `manche`;
CREATE TABLE IF NOT EXISTS `manche` (
  `MANCH_ID` bigint(20) NOT NULL,
  `TABPART_ID_TABLEAU` bigint(20) NOT NULL,
  `MANCH_NB_SCORE1` int(11) DEFAULT NULL,
  `MANCH_NB_SCORE2` int(11) DEFAULT NULL,
  `MANCH_NB_RANG` int(11) NOT NULL,
  PRIMARY KEY (`MANCH_ID`),
  KEY `TABPART_ID_TABLEAU` (`TABPART_ID_TABLEAU`)
) ENGINE=MyISAM DEFAULT CHARSET=utf16;

-- --------------------------------------------------------

--
-- Structure de la table `memo`
--

DROP TABLE IF EXISTS `memo`;
CREATE TABLE IF NOT EXISTS `memo` (
  `MEMO` text DEFAULT NULL
) ENGINE=MyISAM DEFAULT CHARSET=utf16;

--
-- Déchargement des données de la table `memo`
--

INSERT INTO `memo` (`MEMO`) VALUES
('䕳獡植ੳ畲ഊ砍੬楧湥猍ਮഊ⬫ഊⴭⴭⴭⴭ');

-- --------------------------------------------------------

--
-- Structure de la table `niveau`
--

DROP TABLE IF EXISTS `niveau`;
CREATE TABLE IF NOT EXISTS `niveau` (
  `NIV_ID` bigint(20) NOT NULL,
  `TAB_ID` bigint(20) NOT NULL,
  `NIVREF_ID` bigint(20) NOT NULL,
  `NIV_DT_HEURE` date NOT NULL,
  `NIV_LB_LIEU` varchar(32) DEFAULT NULL,
  `NIV_CM` varchar(5) DEFAULT NULL,
  PRIMARY KEY (`NIV_ID`),
  KEY `TAB_ID` (`TAB_ID`),
  KEY `NIVREF_ID` (`NIVREF_ID`)
) ENGINE=MyISAM DEFAULT CHARSET=utf16;

-- --------------------------------------------------------

--
-- Structure de la table `niveau_ref`
--

DROP TABLE IF EXISTS `niveau_ref`;
CREATE TABLE IF NOT EXISTS `niveau_ref` (
  `NIVREF_ID` bigint(20) NOT NULL,
  `TABREF_ID` bigint(20) NOT NULL,
  `NIVREF_CD` char(5) NOT NULL,
  `NIVREF_LB` varchar(32) NOT NULL,
  `NIVREF_NB` int(11) NOT NULL,
  `NIVREF_BL_DEPART` tinyint(4) DEFAULT NULL,
  `NIVREF_NIVREF_ID` bigint(20) DEFAULT NULL,
  `BL_MAJ` tinyint(1) DEFAULT 0,
  PRIMARY KEY (`NIVREF_ID`),
  KEY `TABREF_ID` (`TABREF_ID`)
) ENGINE=MyISAM DEFAULT CHARSET=utf16;

-- --------------------------------------------------------

--
-- Structure de la table `organisme`
--

DROP TABLE IF EXISTS `organisme`;
CREATE TABLE IF NOT EXISTS `organisme` (
  `ORGA_ID` bigint(20) NOT NULL,
  `ORG_ORGA_ID` bigint(20) DEFAULT NULL,
  `ORGA_LB` varchar(32) NOT NULL,
  `ORGA_CD` varchar(5) NOT NULL,
  `ORGA_FG` char(2) NOT NULL,
  `ORGA_BL_MODULE` tinyint(4) NOT NULL DEFAULT 0,
  `BL_MAJ` tinyint(1) NOT NULL DEFAULT 0,
  PRIMARY KEY (`ORGA_ID`),
  KEY `ORG_ORGA_ID` (`ORG_ORGA_ID`)
) ENGINE=MyISAM DEFAULT CHARSET=utf16;

--
-- Déchargement des données de la table `organisme`
--

INSERT INTO `organisme` (`ORGA_ID`, `ORG_ORGA_ID`, `ORGA_LB`, `ORGA_CD`, `ORGA_FG`, `ORGA_BL_MODULE`, `BL_MAJ`) VALUES
(-101, -101, 'Inconnu', 'Inc', 'D', 0, 0),
(1, 1019, 'AIN', 'D01', 'D', 0, 1),
(2, 1005, 'AISNE', 'D02', 'D', 0, 1),
(3, 1021, 'ALLIER', 'D03', 'D', 0, 1),
(4, 1021, 'ALPES HTE PROVENCE', 'D04', 'D', 0, 1),
(5, 1009, 'HAUTES ALPES', 'D05', 'D', 0, 1),
(6, 1001, 'ALPES MARITIMES', 'D06', 'D', 0, 1),
(7, 1008, 'ARDECHE', 'D07', 'D', 0, 1),
(8, 1022, 'ARDENNES', 'D08', 'D', 1, 1),
(9, 1008, 'ARIEGE', 'D09', 'D', 1, 1),
(10, 1013, 'AUBE', 'D10', 'D', 1, 1),
(11, 1022, 'AUDE', 'D11', 'D', 0, 1),
(12, 1021, 'AVEYRON', 'D12', 'D', 1, 1),
(13, 1017, 'BOUCHES DU RHONE', 'D13', 'D', 0, 1),
(14, 1005, 'CALVADOS', 'D14', 'D', 0, 1),
(15, 1020, 'CANTAL', 'D15', 'D', 0, 1),
(16, 1020, 'CHARENTE', 'D16', 'D', 1, 1),
(17, 1023, 'CHARENTE MARITIME', 'D17', 'D', 1, 1),
(18, 1014, 'CHER', 'D18', 'D', 0, 1),
(19, 1006, 'CORREZE', 'D19', 'D', 0, 1),
(21, 1007, 'COTE D OR', 'D21', 'D', 0, 1),
(22, 1014, 'COTES D ARMOR', 'D22', 'D', 0, 1),
(23, 1003, 'CREUSE', 'D23', 'D', 0, 1),
(24, 1011, 'DORDOGNE', 'D24', 'D', 0, 1),
(25, 1001, 'DOUBS', 'D25', 'D', 0, 1),
(26, 1018, 'DROME', 'D26', 'D', 0, 1),
(27, 1023, 'EURE', 'D27', 'D', 0, 1),
(28, 1007, 'EURE ET LOIR', 'D28', 'D', 0, 1),
(29, 1013, 'FINISTERE', 'D29', 'D', 0, 1),
(30, 1022, 'GARD', 'D30', 'D', 0, 1),
(31, 1022, 'HAUTE GARONNE', 'D31', 'D', 1, 1),
(32, 1003, 'GERS', 'D32', 'D', 1, 1),
(33, 1013, 'GIRONDE', 'D33', 'D', 0, 1),
(34, 1007, 'HERAULT', 'D34', 'D', 0, 1),
(35, 1023, 'ILLE ET VILAINE', 'D35', 'D', 0, 1),
(36, 1023, 'INDRE', 'D36', 'D', 0, 1),
(37, 1001, 'INDRE ET LOIRE', 'D37', 'D', 0, 1),
(38, 1011, 'ISERE', 'D38', 'D', 0, 1),
(39, 1003, 'JURA', 'D39', 'D', 0, 1),
(40, 1023, 'LANDES', 'D40', 'D', 0, 1),
(41, 1001, 'LOIR ET CHER', 'D41', 'D', 0, 1),
(42, 1005, 'LOIRE', 'D42', 'D', 0, 1),
(43, 1004, 'HAUTE LOIRE', 'D43', 'D', 0, 1),
(44, 1023, 'LOIRE ATLANTIQUE', 'D44', 'D', 0, 1),
(45, 1022, 'LOIRET', 'D45', 'D', 0, 1),
(46, 1003, 'LOT', 'D46', 'D', 1, 1),
(47, 1013, 'LOT ET GARONNE', 'D47', 'D', 0, 1),
(48, 1004, 'LOZERE', 'D48', 'D', 0, 1),
(49, 1017, 'MAINE ET LOIRE', 'D49', 'D', 0, 1),
(50, 1008, 'MANCHE', 'D50', 'D', 0, 1),
(51, 1008, 'MARNE', 'D51', 'D', 1, 1),
(52, 1004, 'HAUTE-MARNE', 'D52', 'D', 1, 1),
(53, 1015, 'MAYENNE', 'D53', 'D', 0, 1),
(54, 1015, 'MEURTHE ET MOSELLE', 'D54', 'D', 0, 1),
(55, 1007, 'MEUSE', 'D55', 'D', 0, 1),
(56, 1015, 'MORBIHAN', 'D56', 'D', 0, 1),
(57, 1006, 'MOSELLE', 'D57', 'D', 0, 1),
(58, 1010, 'NIEVRE', 'D58', 'D', 0, 1),
(59, 1019, 'NORD', 'D59', 'D', 0, 1),
(60, 1017, 'OISE', 'D60', 'D', 0, 1),
(61, 1010, 'ORNE', 'D61', 'D', 0, 1),
(62, 1005, 'PAS DE CALAIS', 'D62', 'D', 0, 1),
(63, 1003, 'PUY DE DOME', 'D63', 'D', 0, 1),
(64, 1022, 'PYRENEES ATLANTIQUE', 'D64', 'D', 0, 1),
(65, 1013, 'HAUTES PYRENEES', 'D65', 'D', 1, 1),
(66, 1002, 'PYRENEES ORIENTALES', 'D66', 'D', 0, 1),
(67, 1002, 'BAS RHIN', 'D67', 'D', 1, 1),
(68, 1001, 'HAUT RHIN', 'D68', 'D', 1, 1),
(69, 1011, 'RHONE', 'D69', 'D', 0, 1),
(70, 1006, 'HAUTE SAONE', 'D70', 'D', 0, 1),
(71, 1004, 'SAONE ET LOIRE', 'D71', 'D', 0, 1),
(72, 1001, 'SARTHE', 'D72', 'D', 0, 1),
(73, 1001, 'SAVOIE', 'D73', 'D', 0, 1),
(74, 1012, 'HAUTE SAVOIE', 'D74', 'D', 0, 1),
(75, 1018, 'PARIS', 'D75', 'D', 0, 1),
(76, 1012, 'SEINE MARITIME', 'D76', 'D', 0, 1),
(77, 1012, 'SEINE ET MARNE', 'D77', 'D', 0, 1),
(78, 1020, 'YVELINES', 'D78', 'D', 0, 1),
(79, 1019, 'DEUX SEVRES', 'D79', 'D', 1, 1),
(80, 1022, 'SOMME', 'D80', 'D', 0, 1),
(81, 1022, 'TARN', 'D81', 'D', 1, 1),
(82, 1009, 'TARN ET GARONNE', 'D82', 'D', 1, 1),
(83, 1021, 'VAR', 'D83', 'D', 0, 1),
(84, 1004, 'VAUCLUSE', 'D84', 'D', 0, 1),
(85, 1020, 'VENDEE', 'D85', 'D', 0, 1),
(86, 1014, 'VIENNE', 'D86', 'D', 1, 1),
(87, 1015, 'HAUTE VIENNE', 'D87', 'D', 0, 1),
(88, 1006, 'VOSGES', 'D88', 'D', 0, 1),
(89, 1011, 'YONNE', 'D89', 'D', 0, 1),
(90, 1012, 'BELFORT', 'D90', 'D', 1, 1),
(91, 1012, 'ESSONNE', 'D91', 'D', 0, 1),
(92, 1012, 'HAUTS DE SEINE', 'D92', 'D', 0, 1),
(93, 1012, 'SEINE ST DENIS', 'D93', 'D', 0, 1),
(94, 1012, 'VAL DE MARNE', 'D94', 'D', 0, 1),
(95, 1024, 'VAL D OISE', 'D95', 'D', 0, 1),
(98, 1024, 'HAUTE CORSE', 'D98', 'D', 0, 1),
(99, 1033, 'CORSE DU SUD', 'D99', 'D', 0, 1),
(100, 1034, 'GUADELOUPE', 'D9A', 'D', 0, 1),
(101, 1030, 'MARTINIQUE', 'D9B', 'D', 0, 1),
(102, 1031, 'GUYANE', 'D9C', 'D', 0, 1),
(103, 1032, 'REUNION', 'D9D', 'D', 0, 1),
(104, 1032, 'NOUVELLE CALEDONIE NORD', 'D9E', 'D', 0, 1),
(105, 1036, 'NOUVELLE CALEDONIE SUD', 'D9F', 'D', 0, 1),
(106, 1037, 'MAYOTTE', 'D9G', 'D', 0, 1),
(107, 10004, 'TAHITI', 'D9H', 'D', 0, 1),
(1001, 10005, 'RHONE ALPES', 'L01', 'L', 0, 1),
(1002, 10003, 'ALSACE', 'L02', 'L', 1, 1),
(1003, 10002, 'AQUITAINE', 'L03', 'L', 0, 1),
(1004, 10004, 'PAYS DE LA LOIRE', 'L04', 'L', 0, 1),
(1005, 10005, 'AUVERGNE', 'L05', 'L', 0, 1),
(1006, 10002, 'BOURGOGNE', 'L06', 'L', 0, 1),
(1007, 10005, 'BRETAGNE', 'L07', 'L', 0, 1),
(1008, 10004, 'CHAMPAGNE - ARDENNE', 'L08', 'L', 1, 1),
(1009, 10006, 'COTE D AZUR', 'L09', 'L', 0, 1),
(1010, 10005, 'NORD/PAS-DE-CALAIS', 'L10', 'L', 0, 1),
(1011, 10001, 'FRANCHE COMTE', 'L11', 'L', 0, 1),
(1012, 10004, 'ILE DE FRANCE', 'L12', 'L', 0, 1),
(1013, 10003, 'LANGUEDOC ROUSSILLON', 'L13', 'L', 0, 1),
(1014, 10005, 'LIMOUSIN', 'L14', 'L', 0, 1),
(1015, 10006, 'LORRAINE', 'L15', 'L', 0, 1),
(1017, 10006, 'BASSE NORMANDIE', 'L17', 'L', 0, 1),
(1018, 10006, 'HAUTE NORMANDIE', 'L18', 'L', 0, 1),
(1019, 10003, 'PICARDIE', 'L19', 'L', 0, 1),
(1020, 10004, 'POITOU CHARENTES', 'L20', 'L', 1, 1),
(1021, 10003, 'PROVENCE', 'L21', 'L', 0, 1),
(1022, 10001, 'MIDI-PYRENEES', 'L22', 'L', 1, 1),
(1023, 10004, 'CENTRE', 'L23', 'L', 0, 1),
(1024, 10007, 'CORSE', 'L24', 'L', 0, 1),
(1030, 10007, 'GUYANE.L', 'L30', 'L', 0, 1),
(1031, 10007, 'REUNION.L', 'L31', 'L', 1, 1),
(1032, 10007, 'NOUVELLE CALEDONIE', 'L32', 'L', 0, 1),
(1033, 10007, 'GUADELOUPE.L', 'L33', 'L', 0, 1),
(1034, 10007, 'MARTINIQUE.L', 'L34', 'L', 1, 1),
(1036, 10007, 'MAYOTTE.L', 'L36', 'L', 0, 1),
(1037, 100001, 'TAHITI.L', 'L37', 'L', 0, 1),
(10001, 100001, 'ZONE 1', 'Z01', 'Z', 0, 1),
(10002, 100001, 'ZONE 2', 'Z02', 'Z', 0, 1),
(10003, 100001, 'ZONE 3', 'Z03', 'Z', 1, 1),
(10004, 100001, 'ZONE 4', 'Z04', 'Z', 0, 1),
(10005, 100001, 'ZONE 5', 'Z05', 'Z', 0, 1),
(10006, 100001, 'ZONE 6', 'Z06', 'Z', 0, 1),
(10007, 100001, 'ZONE 7', 'Z07', 'Z', 0, 1),
(100001, NULL, 'FFTT', 'FEDE', 'F', 0, 1);

-- --------------------------------------------------------

--
-- Structure de la table `package`
--

DROP TABLE IF EXISTS `package`;
CREATE TABLE IF NOT EXISTS `package` (
  `PKG_ID` bigint(20) NOT NULL,
  `UTIL_LB_LOGIN` varchar(15) NOT NULL,
  `PKG_LB` varchar(32) DEFAULT NULL,
  `PKG_ETAT` char(2) DEFAULT NULL,
  `PKG_LB_USER_MODIF` varchar(15) DEFAULT NULL,
  `PKG_DT_MODIFICATION` date DEFAULT NULL,
  `PKG_DT_CREATION` date DEFAULT NULL,
  `PKG_TEXT_DESC` date DEFAULT NULL,
  `PKG_TEXT_MONTE` date DEFAULT NULL,
  PRIMARY KEY (`PKG_ID`)
) ENGINE=MyISAM DEFAULT CHARSET=utf16;

--
-- Déchargement des données de la table `package`
--

INSERT INTO `package` (`PKG_ID`, `UTIL_LB_LOGIN`, `PKG_LB`, `PKG_ETAT`, `PKG_LB_USER_MODIF`, `PKG_DT_MODIFICATION`, `PKG_DT_CREATION`, `PKG_TEXT_DESC`, `PKG_TEXT_MONTE`) VALUES
(1923, 'patrick.chautar', 'Criterium - Tour 2 - R1 - Femini', '69', 'patrick.chautar', '2021-11-17', '2021-11-17', NULL, NULL);

-- --------------------------------------------------------

--
-- Structure de la table `package_tableau`
--

DROP TABLE IF EXISTS `package_tableau`;
CREATE TABLE IF NOT EXISTS `package_tableau` (
  `PKG_ID` bigint(20) NOT NULL,
  `TAB_ID` bigint(20) NOT NULL,
  PRIMARY KEY (`PKG_ID`,`TAB_ID`)
) ENGINE=MyISAM DEFAULT CHARSET=utf16;

--
-- Déchargement des données de la table `package_tableau`
--

INSERT INTO `package_tableau` (`PKG_ID`, `TAB_ID`) VALUES
(1923, 39997);

-- --------------------------------------------------------

--
-- Structure de la table `parametre`
--

DROP TABLE IF EXISTS `parametre`;
CREATE TABLE IF NOT EXISTS `parametre` (
  `PARM_CD` char(5) NOT NULL,
  `PARM_LB` varchar(32) NOT NULL,
  `PARM_DT_CREA` timestamp NOT NULL DEFAULT current_timestamp() ON UPDATE current_timestamp(),
  PRIMARY KEY (`PARM_CD`)
) ENGINE=MyISAM DEFAULT CHARSET=utf16;

--
-- Déchargement des données de la table `parametre`
--

INSERT INTO `parametre` (`PARM_CD`, `PARM_LB`, `PARM_DT_CREA`) VALUES
('BASE', '1.8', '2004-09-08 22:00:00'),
('REFER', 'Date de création du référentiel', '2004-09-09 05:25:24');

-- --------------------------------------------------------

--
-- Structure de la table `partie`
--

DROP TABLE IF EXISTS `partie`;
CREATE TABLE IF NOT EXISTS `partie` (
  `PARTI_ID` bigint(20) NOT NULL,
  `LIC_ID` bigint(20) NOT NULL,
  `LIC_LIC_ID` bigint(20) NOT NULL,
  `RENC_ID` bigint(20) DEFAULT NULL,
  `PARTI_NB_ORDRE` int(11) NOT NULL,
  `PARTI_BL_GAGNE1` tinyint(4) NOT NULL,
  `PARTI_BL_GAGNE2` tinyint(4) NOT NULL,
  `PARTI_BL_FORFAIT` tinyint(4) NOT NULL,
  `EPRV_ID` bigint(20) DEFAULT NULL,
  `PARTI_BL_SUPPRIMEE` tinyint(4) DEFAULT NULL,
  `PARTI_DT` date NOT NULL,
  `PARTI_NM_TOUR` int(11) DEFAULT NULL,
  `PARTI_BL_DOUBLE` tinyint(4) DEFAULT NULL,
  `TAB_ID` bigint(20) DEFAULT NULL,
  `PARTI_NB_POINT1` int(11) DEFAULT NULL,
  `PARTI_NB_POINT2` int(11) DEFAULT NULL,
  `PARTI_BL_CLST` tinyint(4) DEFAULT NULL,
  `PARTI_BL_NONJOUEE` tinyint(4) DEFAULT NULL,
  PRIMARY KEY (`PARTI_ID`),
  KEY `LIC_ID` (`LIC_ID`),
  KEY `LIC_LIC_ID` (`LIC_LIC_ID`),
  KEY `EPRV_ID` (`EPRV_ID`),
  KEY `TAB_ID` (`TAB_ID`)
) ENGINE=MyISAM DEFAULT CHARSET=utf16;

-- --------------------------------------------------------

--
-- Structure de la table `partie_ref`
--

DROP TABLE IF EXISTS `partie_ref`;
CREATE TABLE IF NOT EXISTS `partie_ref` (
  `RPARTI_ID_PARTIE_REF` bigint(20) NOT NULL,
  `NIVREF_ID` bigint(20) NOT NULL,
  `PAR_RPARTI_ID_PARTIE_REF` bigint(20) DEFAULT NULL,
  `PAR2_RPARTI_ID_PARTIE_REF` bigint(20) DEFAULT NULL,
  `RPARTI_NM_RANG1` int(11) DEFAULT NULL,
  `RPARTI_NM_RANG2` int(11) DEFAULT NULL,
  `RPARTI_NM_ORDRE_REF` int(11) DEFAULT NULL,
  `RPARTI_NM_PARTIE_REF` int(11) DEFAULT NULL,
  `RPARTI_FG_PARTIE_1` char(1) DEFAULT NULL,
  `RPARTI_NM_CLST_VAINQUEUR` int(11) DEFAULT NULL,
  `RPARTI_NM_POULE1` int(11) DEFAULT NULL,
  `RPARTI_NM_CLASSEMENT1` int(11) DEFAULT NULL,
  `RPARTI_NM_POULE2` int(11) DEFAULT NULL,
  `RPARTI_NM_CLASSEMENT2` int(11) DEFAULT NULL,
  `RPARTI_NM_POSITION1` int(11) DEFAULT NULL,
  `RPARTI_NM_POSITION2` int(11) DEFAULT NULL,
  `RPARTI_FG_PARTIE_2` varchar(1) DEFAULT NULL,
  `RPARTI_NM_CLST_PERDANT` int(11) DEFAULT NULL,
  `RPARTI_FG_PARTIE_REF` char(1) DEFAULT NULL,
  `RPARTI_NM_CLST_REF` char(1) DEFAULT NULL,
  `BL_MAJ` tinyint(1) DEFAULT 0,
  `RPARTI_BL_CLST_NONJOUEE` tinyint(1) NOT NULL DEFAULT 0,
  PRIMARY KEY (`RPARTI_ID_PARTIE_REF`),
  KEY `NIVREF_ID` (`NIVREF_ID`)
) ENGINE=MyISAM DEFAULT CHARSET=utf16;

-- --------------------------------------------------------

--
-- Structure de la table `pbcatcol`
--

DROP TABLE IF EXISTS `pbcatcol`;
CREATE TABLE IF NOT EXISTS `pbcatcol` (
  `PBC_TNAM` char(32) NOT NULL,
  `PBC_TID` int(11) DEFAULT NULL,
  `PBC_OWNR` char(32) NOT NULL,
  `PBC_CNAM` char(32) NOT NULL,
  `PBC_CID` smallint(6) DEFAULT NULL,
  `PBC_LABL` text DEFAULT NULL,
  `PBC_LPOS` smallint(11) DEFAULT NULL,
  `PBC_HDR` text DEFAULT NULL,
  `PBC_HPOS` smallint(6) DEFAULT NULL,
  `PBC_JTFY` smallint(6) DEFAULT NULL,
  `PBC_MASK` varchar(31) DEFAULT NULL,
  `PBC_CASE` smallint(6) DEFAULT NULL,
  `PBC_HGHT` smallint(6) DEFAULT NULL,
  `PBC_WDTH` smallint(6) DEFAULT NULL,
  `PBC_PTRN` varchar(31) DEFAULT NULL,
  `PBC_BMAP` char(1) DEFAULT NULL,
  `PBC_INIT` text DEFAULT NULL,
  `PBC_CMNT` text DEFAULT NULL,
  `PBC_EDIT` varchar(31) DEFAULT NULL,
  `PBC_TAG` text DEFAULT NULL
) ENGINE=MyISAM DEFAULT CHARSET=utf16;

-- --------------------------------------------------------

--
-- Structure de la table `pbcatedt`
--

DROP TABLE IF EXISTS `pbcatedt`;
CREATE TABLE IF NOT EXISTS `pbcatedt` (
  `PBE_NAME` varchar(30) NOT NULL,
  `PBE_EDIT` text DEFAULT NULL,
  `PBE_TYPE` smallint(6) DEFAULT NULL,
  `PBE_CNTR` int(11) DEFAULT NULL,
  `PBE_SEQN` smallint(6) NOT NULL,
  `PBE_FLAG` int(11) DEFAULT NULL,
  `PBE_WORK` char(32) DEFAULT NULL
) ENGINE=MyISAM DEFAULT CHARSET=utf16;

-- --------------------------------------------------------

--
-- Structure de la table `pbcatfmt`
--

DROP TABLE IF EXISTS `pbcatfmt`;
CREATE TABLE IF NOT EXISTS `pbcatfmt` (
  `PBF_NAME` varchar(30) NOT NULL,
  `PBF_FRMT` text DEFAULT NULL,
  `PBF_TYPE` smallint(6) DEFAULT NULL,
  `PBF_CNTR` int(11) DEFAULT NULL
) ENGINE=MyISAM DEFAULT CHARSET=utf16;

-- --------------------------------------------------------

--
-- Structure de la table `pbcattbl`
--

DROP TABLE IF EXISTS `pbcattbl`;
CREATE TABLE IF NOT EXISTS `pbcattbl` (
  `PBT_TNAM` char(32) NOT NULL,
  `PBT_TID` int(11) DEFAULT NULL,
  `PBT_OWNR` char(32) NOT NULL,
  `PBD_FHGT` smallint(6) DEFAULT NULL,
  `PBD_FWGT` smallint(6) DEFAULT NULL,
  `PBD_FITL` char(1) DEFAULT NULL,
  `PBD_FUNL` char(1) DEFAULT NULL,
  `PBD_FCHR` smallint(6) DEFAULT NULL,
  `PBD_FPTC` smallint(6) DEFAULT NULL,
  `PBD_FFCE` char(18) DEFAULT NULL,
  `PBH_FHGT` smallint(6) DEFAULT NULL,
  `PBH_FWGT` smallint(6) DEFAULT NULL,
  `PBH_FITL` char(1) DEFAULT NULL,
  `PBH_FUNL` char(1) DEFAULT NULL,
  `PBH_FCHR` smallint(6) DEFAULT NULL,
  `PBH_FPTC` smallint(6) DEFAULT NULL,
  `PBH_FFCE` char(18) DEFAULT NULL,
  `PBL_FHGT` smallint(6) DEFAULT NULL,
  `PBL_FWGT` smallint(6) DEFAULT NULL,
  `PBL_FITL` char(1) DEFAULT NULL,
  `PBL_FUNL` char(1) DEFAULT NULL,
  `PBL_FCHR` smallint(6) DEFAULT NULL,
  `PBL_FPTC` smallint(6) DEFAULT NULL,
  `PBL_FFCE` char(18) DEFAULT NULL,
  `PBT_CMNT` text DEFAULT NULL
) ENGINE=MyISAM DEFAULT CHARSET=utf16;

-- --------------------------------------------------------

--
-- Structure de la table `pbcatvld`
--

DROP TABLE IF EXISTS `pbcatvld`;
CREATE TABLE IF NOT EXISTS `pbcatvld` (
  `PBV_NAME` varchar(30) NOT NULL,
  `PBV_VALD` text DEFAULT NULL,
  `PBV_TYPE` smallint(6) DEFAULT NULL,
  `PBV_CNTR` int(11) DEFAULT NULL,
  `PBV_MSG` text DEFAULT NULL
) ENGINE=MyISAM DEFAULT CHARSET=utf16;

-- --------------------------------------------------------

--
-- Structure de la table `pot`
--

DROP TABLE IF EXISTS `pot`;
CREATE TABLE IF NOT EXISTS `pot` (
  `POT_ID` bigint(20) NOT NULL,
  `POT_LB` varchar(32) NOT NULL,
  `POT_DT` date NOT NULL,
  `POT_NB_TABLE` int(11) DEFAULT NULL,
  `POT_NB_TRANCHE` int(11) DEFAULT NULL,
  `POT_HEURE` int(11) DEFAULT NULL,
  `POT_MINUTE` int(11) DEFAULT NULL,
  `POT_NB_INTERVALLE` int(11) DEFAULT NULL,
  `POT_NB_TABLE_MAX` int(11) DEFAULT NULL,
  `POT_POT_ID` bigint(20) DEFAULT NULL,
  PRIMARY KEY (`POT_ID`),
  KEY `POT_POT_ID` (`POT_POT_ID`)
) ENGINE=MyISAM DEFAULT CHARSET=utf16;

-- --------------------------------------------------------

--
-- Structure de la table `pot_tableau`
--

DROP TABLE IF EXISTS `pot_tableau`;
CREATE TABLE IF NOT EXISTS `pot_tableau` (
  `POT_ID` bigint(20) NOT NULL,
  `TAB_ID` bigint(20) NOT NULL,
  `POTTAB_CODE_ROUGE` int(11) DEFAULT NULL,
  `POTTAB_CODE_VERT` int(11) DEFAULT NULL,
  `POTTAB_CODE_BLEU` int(11) DEFAULT NULL,
  KEY `TAB_ID` (`TAB_ID`),
  KEY `POT_ID` (`POT_ID`)
) ENGINE=MyISAM DEFAULT CHARSET=utf16;

-- --------------------------------------------------------

--
-- Structure de la table `poule`
--

DROP TABLE IF EXISTS `poule`;
CREATE TABLE IF NOT EXISTS `poule` (
  `POUL_ID` bigint(20) NOT NULL,
  `GRIL_ID_RENC` bigint(20) NOT NULL,
  `CALEN_ID_SPORTIF` bigint(20) DEFAULT NULL,
  `FEUIL_ID_RENC` bigint(20) DEFAULT NULL,
  `DIV_ID` bigint(20) NOT NULL,
  `POUL_CD` varchar(5) NOT NULL,
  `POUL_LB` varchar(32) NOT NULL,
  `POUL_NM_GROUPE` smallint(6) DEFAULT NULL,
  `POUL_BL_VIRTUEL` tinyint(4) NOT NULL,
  `POUL_DT` date DEFAULT NULL,
  `POUL_DT_VALIDATION` date DEFAULT NULL,
  `POUL_LB_COMPETIT` varchar(32) DEFAULT NULL,
  `POUL_LB_USER_MODIF` varchar(15) NOT NULL,
  `POUL_DT_MODIFICATION` date DEFAULT NULL,
  `POUL_DT_CREATION` date NOT NULL,
  `TAB_ID` bigint(20) DEFAULT NULL,
  `POUL_NM_TABLEAU` int(11) DEFAULT NULL,
  PRIMARY KEY (`POUL_ID`),
  KEY `GRIL_ID_RENC` (`GRIL_ID_RENC`),
  KEY `DIV_ID` (`DIV_ID`),
  KEY `TAB_ID` (`TAB_ID`)
) ENGINE=MyISAM DEFAULT CHARSET=utf16;

-- --------------------------------------------------------

--
-- Structure de la table `securite`
--

DROP TABLE IF EXISTS `securite`;
CREATE TABLE IF NOT EXISTS `securite` (
  `PROFIL_CD` char(5) NOT NULL,
  `PROFIL_LB` varchar(32) NOT NULL,
  `PROFIL_PWD` varchar(32) NOT NULL,
  PRIMARY KEY (`PROFIL_CD`)
) ENGINE=MyISAM DEFAULT CHARSET=utf16;

--
-- Déchargement des données de la table `securite`
--

INSERT INTO `securite` (`PROFIL_CD`, `PROFIL_LB`, `PROFIL_PWD`) VALUES
('C', 'Consultation', 'consult'),
('M', 'Modification', 'modif'),
('A', 'Administration', '');

-- --------------------------------------------------------

--
-- Structure de la table `tableau`
--

DROP TABLE IF EXISTS `tableau`;
CREATE TABLE IF NOT EXISTS `tableau` (
  `TAB_ID` bigint(20) NOT NULL,
  `TABREF_ID` bigint(20) DEFAULT NULL,
  `TOUR_ID` bigint(20) NOT NULL,
  `TAB_NB_GROUPE` int(11) NOT NULL,
  `TAB_CD_TABLEAU` varchar(5) DEFAULT NULL,
  `TAB_LB` varchar(32) NOT NULL,
  `TAB_DT_HEURE` date NOT NULL,
  `TAB_LB_LIEU` varchar(32) DEFAULT NULL,
  `TAB_CM_TABLEAU` text DEFAULT NULL,
  `TAB_CM_TABLE_JUGE` text DEFAULT NULL,
  `TAB_LB_RAPPORT` text DEFAULT NULL,
  `TAB_LB_USER_MODIF` varchar(15) NOT NULL,
  `TAB_DT_MODIFICATION` date DEFAULT NULL,
  `TAB_DT_CREATION` date NOT NULL,
  PRIMARY KEY (`TAB_ID`),
  KEY `TABREF_ID` (`TABREF_ID`),
  KEY `TOUR_ID` (`TOUR_ID`)
) ENGINE=MyISAM DEFAULT CHARSET=utf16;

--
-- Déchargement des données de la table `tableau`
--

INSERT INTO `tableau` (`TAB_ID`, `TABREF_ID`, `TOUR_ID`, `TAB_NB_GROUPE`, `TAB_CD_TABLEAU`, `TAB_LB`, `TAB_DT_HEURE`, `TAB_LB_LIEU`, `TAB_CM_TABLEAU`, `TAB_CM_TABLE_JUGE`, `TAB_LB_RAPPORT`, `TAB_LB_USER_MODIF`, `TAB_DT_MODIFICATION`, `TAB_DT_CREATION`) VALUES
(39997, NULL, 39879, 0, '', 'Groupe 1', '2021-11-21', '', '', '', '', 'sportive.ligue@', '2021-09-28', '2021-07-07');

-- --------------------------------------------------------

--
-- Structure de la table `tableau_partie`
--

DROP TABLE IF EXISTS `tableau_partie`;
CREATE TABLE IF NOT EXISTS `tableau_partie` (
  `TABPART_ID_TABLEAU` bigint(20) NOT NULL,
  `POUL_ID` bigint(20) DEFAULT NULL,
  `NIV_ID` bigint(20) DEFAULT NULL,
  `INSC_ID` bigint(20) DEFAULT NULL,
  `INS_INSC_ID` bigint(20) DEFAULT NULL,
  `PARTI_ID` bigint(20) DEFAULT NULL,
  `TABPART_NM_ORDRE_NIVEAU` int(11) DEFAULT NULL,
  `TABPART_NM_TABLEAU` int(11) DEFAULT NULL,
  `TABPART_NM_VAINQUEUR` int(11) DEFAULT NULL,
  `TABPART_DT_HEURE` date NOT NULL,
  `TABPART_NB_TABLE` char(5) DEFAULT NULL,
  `RPARTI_ID_PARTIE_REF` bigint(20) DEFAULT NULL,
  `TABPART_TYPE_PARTIE` tinyint(4) DEFAULT NULL,
  `TABPART_NM_PERDANT` int(11) DEFAULT NULL,
  `TABPART_LB_PARTIE` varchar(10) DEFAULT NULL,
  `TABPART_BL_CLST` tinyint(4) DEFAULT 0,
  PRIMARY KEY (`TABPART_ID_TABLEAU`),
  KEY `POUL_ID` (`POUL_ID`),
  KEY `NIV_ID` (`NIV_ID`),
  KEY `INSC_ID` (`INSC_ID`),
  KEY `INS_INSC_ID` (`INS_INSC_ID`),
  KEY `PARTI_ID` (`PARTI_ID`),
  KEY `RPARTI_ID_PARTIE_REF` (`RPARTI_ID_PARTIE_REF`)
) ENGINE=MyISAM DEFAULT CHARSET=utf16;

-- --------------------------------------------------------

--
-- Structure de la table `tableau_ref`
--

DROP TABLE IF EXISTS `tableau_ref`;
CREATE TABLE IF NOT EXISTS `tableau_ref` (
  `TABREF_ID` bigint(20) NOT NULL,
  `TABREF_CD` varchar(5) NOT NULL,
  `TABREF_LB` varchar(32) NOT NULL,
  `TABREF_FG` char(2) NOT NULL,
  `TABREF_NB_JOUEURS_REF` int(11) NOT NULL,
  `TABREF_CM` text DEFAULT NULL,
  `TABREF_LB_USER_MODIF` varchar(15) NOT NULL,
  `TABREF_DT_MODIFICATION` date DEFAULT NULL,
  `TABREF_DT_CREATION` date NOT NULL,
  `TABREF_SAISIE_TYPE` char(2) DEFAULT NULL,
  `BL_MAJ` tinyint(11) DEFAULT 0,
  PRIMARY KEY (`TABREF_ID`)
) ENGINE=MyISAM DEFAULT CHARSET=utf16;

-- --------------------------------------------------------

--
-- Structure de la table `tirage`
--

DROP TABLE IF EXISTS `tirage`;
CREATE TABLE IF NOT EXISTS `tirage` (
  `TIRAGE_ID` bigint(20) NOT NULL,
  `TAB_ID` bigint(20) NOT NULL,
  `TIRAGE_NUM_LIGNE` int(11) NOT NULL,
  `TIRAGE_NUM_COLONNE` int(11) NOT NULL,
  `TIRAGE_VALEUR` int(11) DEFAULT NULL,
  `TIRAGE_BL_QUALIFIE` smallint(6) DEFAULT NULL,
  PRIMARY KEY (`TIRAGE_ID`)
) ENGINE=MyISAM DEFAULT CHARSET=utf16;

-- --------------------------------------------------------

--
-- Structure de la table `tour`
--

DROP TABLE IF EXISTS `tour`;
CREATE TABLE IF NOT EXISTS `tour` (
  `TOUR_ID` bigint(20) NOT NULL,
  `DIV_ID` bigint(20) NOT NULL,
  `TOUR_LB` varchar(32) DEFAULT NULL,
  `TOUR_NB_GROUPE` int(11) DEFAULT NULL,
  `TOUR_NB_POULE` int(11) DEFAULT NULL,
  `TOUR_NB_JOUEUR` int(11) DEFAULT NULL,
  `TOUR_NB_JOUEUR_DESC` int(11) DEFAULT NULL,
  `TOUR_NB_JOUEUR_MONT` int(11) DEFAULT NULL,
  `TOUR_DT` date DEFAULT NULL,
  `TOUR_LB_USER_MODIF` varchar(15) DEFAULT NULL,
  `TOUR_DT_MODIFICATION` date DEFAULT NULL,
  `TOUR_DT_CREATION` date DEFAULT NULL,
  `GRIL_ID_RENC` bigint(20) DEFAULT NULL,
  `TOUR_BL_CLOTURE` tinyint(4) DEFAULT NULL,
  `TOUR_NM` int(11) DEFAULT NULL,
  `DIV_DIV_LB` varchar(32) DEFAULT NULL,
  `DIV2_DIV_LB` varchar(32) DEFAULT NULL,
  PRIMARY KEY (`TOUR_ID`),
  KEY `DIV_ID` (`DIV_ID`),
  KEY `GRIL_ID_RENC` (`GRIL_ID_RENC`)
) ENGINE=MyISAM DEFAULT CHARSET=utf16;

--
-- Déchargement des données de la table `tour`
--

INSERT INTO `tour` (`TOUR_ID`, `DIV_ID`, `TOUR_LB`, `TOUR_NB_GROUPE`, `TOUR_NB_POULE`, `TOUR_NB_JOUEUR`, `TOUR_NB_JOUEUR_DESC`, `TOUR_NB_JOUEUR_MONT`, `TOUR_DT`, `TOUR_LB_USER_MODIF`, `TOUR_DT_MODIFICATION`, `TOUR_DT_CREATION`, `GRIL_ID_RENC`, `TOUR_BL_CLOTURE`, `TOUR_NM`, `DIV_DIV_LB`, `DIV2_DIV_LB`) VALUES
(-101, -101, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL);

-- --------------------------------------------------------

--
-- Structure de la table `type_classement`
--

DROP TABLE IF EXISTS `type_classement`;
CREATE TABLE IF NOT EXISTS `type_classement` (
  `TCLST_ID` bigint(20) NOT NULL,
  `TCLST_LB` varchar(32) NOT NULL,
  `TCLST_CD` char(2) DEFAULT NULL,
  `TCLST_NB_POINT_MIN` int(11) NOT NULL,
  `BL_MAJ` tinyint(4) DEFAULT 0,
  PRIMARY KEY (`TCLST_ID`)
) ENGINE=MyISAM DEFAULT CHARSET=utf16;

--
-- Déchargement des données de la table `type_classement`
--

INSERT INTO `type_classement` (`TCLST_ID`, `TCLST_LB`, `TCLST_CD`, `TCLST_NB_POINT_MIN`, `BL_MAJ`) VALUES
(15, '25', '25', 1800, 1),
(14, '30', '30', 1700, 1),
(13, '35', '35', 1600, 1),
(12, '40', '40', 1500, 1),
(11, '45', '45', 1400, 1),
(10, '50', '50', 1300, 1),
(9, '55', '55', 1200, 1),
(8, '60', '60', 1100, 1),
(7, '65', '65', 1000, 1),
(6, '70', '70', 900, 1),
(5, '75', '75', 800, 1),
(4, '80', '80', 700, 1),
(3, '85', '85', 680, 1),
(2, '90', '90', 660, 1),
(1, 'NC', 'NC', 0, 1),
(100, 'Numerote', 'NN', 2600, 1),
(-101, 'Inconnu', NULL, 0, 0);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
