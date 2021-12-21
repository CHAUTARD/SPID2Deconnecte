--
-- Fichier généré par SQLiteStudio v3.3.3 sur mar. déc. 14 07:51:00 2021
--
-- Encodage texte utilisé : System
--
PRAGMA foreign_keys = off;
BEGIN TRANSACTION;

-- Table : BAREME
DROP TABLE IF EXISTS BAREME;

CREATE TABLE BAREME (
    BAR_CD,
    BAR_LB,
    BAR_LB_COURT,
    BAR_ID,
    ORGA_ID,
    BAR_NB_JOUEUR,
    BL_MAJ
);

INSERT INTO BAREME (
                       BAR_CD,
                       BAR_LB,
                       BAR_LB_COURT,
                       BAR_ID,
                       ORGA_ID,
                       BAR_NB_JOUEUR,
                       BL_MAJ
                   )
                   VALUES (
                       'Inc',
                       'Inconnu',
                       'Inc',
                       '-101',
                       '-101',
                       '',
                       '0'
                   );

INSERT INTO BAREME (
                       BAR_CD,
                       BAR_LB,
                       BAR_LB_COURT,
                       BAR_ID,
                       ORGA_ID,
                       BAR_NB_JOUEUR,
                       BL_MAJ
                   )
                   VALUES (
                       'C',
                       'N2SENIORS',
                       '',
                       '1028',
                       '100001',
                       '24',
                       '1'
                   );

INSERT INTO BAREME (
                       BAR_CD,
                       BAR_LB,
                       BAR_LB_COURT,
                       BAR_ID,
                       ORGA_ID,
                       BAR_NB_JOUEUR,
                       BL_MAJ
                   )
                   VALUES (
                       'A1',
                       'N3SENIORS',
                       '',
                       '1029',
                       '100001',
                       '48',
                       '1'
                   );

INSERT INTO BAREME (
                       BAR_CD,
                       BAR_LB,
                       BAR_LB_COURT,
                       BAR_ID,
                       ORGA_ID,
                       BAR_NB_JOUEUR,
                       BL_MAJ
                   )
                   VALUES (
                       'E2',
                       'N1JUNIORS',
                       '',
                       '1030',
                       '100001',
                       '16',
                       '1'
                   );

INSERT INTO BAREME (
                       BAR_CD,
                       BAR_LB,
                       BAR_LB_COURT,
                       BAR_ID,
                       ORGA_ID,
                       BAR_NB_JOUEUR,
                       BL_MAJ
                   )
                   VALUES (
                       'B2',
                       'N2JUNIORS',
                       '',
                       '1031',
                       '100001',
                       '32',
                       '1'
                   );

INSERT INTO BAREME (
                       BAR_CD,
                       BAR_LB,
                       BAR_LB_COURT,
                       BAR_ID,
                       ORGA_ID,
                       BAR_NB_JOUEUR,
                       BL_MAJ
                   )
                   VALUES (
                       'C1',
                       'N4SENIORS gr 1-2-3-6',
                       '',
                       '1032',
                       '100001',
                       '24',
                       '1'
                   );

INSERT INTO BAREME (
                       BAR_CD,
                       BAR_LB,
                       BAR_LB_COURT,
                       BAR_ID,
                       ORGA_ID,
                       BAR_NB_JOUEUR,
                       BL_MAJ
                   )
                   VALUES (
                       'E3',
                       'N1SENIORS',
                       '',
                       '1027',
                       '100001',
                       '16',
                       '1'
                   );

INSERT INTO BAREME (
                       BAR_CD,
                       BAR_LB,
                       BAR_LB_COURT,
                       BAR_ID,
                       ORGA_ID,
                       BAR_NB_JOUEUR,
                       BL_MAJ
                   )
                   VALUES (
                       'C4',
                       'N4SENIORS gr 4',
                       '',
                       '1033',
                       '100001',
                       '24',
                       '1'
                   );

INSERT INTO BAREME (
                       BAR_CD,
                       BAR_LB,
                       BAR_LB_COURT,
                       BAR_ID,
                       ORGA_ID,
                       BAR_NB_JOUEUR,
                       BL_MAJ
                   )
                   VALUES (
                       'C5',
                       'N4SENIORS gr 5',
                       '',
                       '1034',
                       '100001',
                       '24',
                       '1'
                   );

INSERT INTO BAREME (
                       BAR_CD,
                       BAR_LB,
                       BAR_LB_COURT,
                       BAR_ID,
                       ORGA_ID,
                       BAR_NB_JOUEUR,
                       BL_MAJ
                   )
                   VALUES (
                       '24J',
                       'BAREME 24 JOUEURS',
                       '',
                       '3060',
                       '100001',
                       '24',
                       '1'
                   );

INSERT INTO BAREME (
                       BAR_CD,
                       BAR_LB,
                       BAR_LB_COURT,
                       BAR_ID,
                       ORGA_ID,
                       BAR_NB_JOUEUR,
                       BL_MAJ
                   )
                   VALUES (
                       '20J',
                       'BAREME 20 JOUEURS',
                       '',
                       '3059',
                       '100001',
                       '20',
                       '1'
                   );

INSERT INTO BAREME (
                       BAR_CD,
                       BAR_LB,
                       BAR_LB_COURT,
                       BAR_ID,
                       ORGA_ID,
                       BAR_NB_JOUEUR,
                       BL_MAJ
                   )
                   VALUES (
                       '32J',
                       'BAREME 32 JOUEURS',
                       '',
                       '3061',
                       '100001',
                       '32',
                       '1'
                   );

INSERT INTO BAREME (
                       BAR_CD,
                       BAR_LB,
                       BAR_LB_COURT,
                       BAR_ID,
                       ORGA_ID,
                       BAR_NB_JOUEUR,
                       BL_MAJ
                   )
                   VALUES (
                       '48J',
                       'BAREME 48 JOUEURS',
                       '',
                       '3062',
                       '100001',
                       '48',
                       '1'
                   );

INSERT INTO BAREME (
                       BAR_CD,
                       BAR_LB,
                       BAR_LB_COURT,
                       BAR_ID,
                       ORGA_ID,
                       BAR_NB_JOUEUR,
                       BL_MAJ
                   )
                   VALUES (
                       '6J',
                       'BAREME 6 JOUEURS',
                       '',
                       '3039',
                       '100001',
                       '6',
                       '1'
                   );

INSERT INTO BAREME (
                       BAR_CD,
                       BAR_LB,
                       BAR_LB_COURT,
                       BAR_ID,
                       ORGA_ID,
                       BAR_NB_JOUEUR,
                       BL_MAJ
                   )
                   VALUES (
                       '7J',
                       'BAREME 7 JOUEURS',
                       '',
                       '3051',
                       '100001',
                       '7',
                       '1'
                   );

INSERT INTO BAREME (
                       BAR_CD,
                       BAR_LB,
                       BAR_LB_COURT,
                       BAR_ID,
                       ORGA_ID,
                       BAR_NB_JOUEUR,
                       BL_MAJ
                   )
                   VALUES (
                       '8J',
                       'BAREME 8 JOUEURS',
                       '',
                       '3052',
                       '100001',
                       '8',
                       '1'
                   );

INSERT INTO BAREME (
                       BAR_CD,
                       BAR_LB,
                       BAR_LB_COURT,
                       BAR_ID,
                       ORGA_ID,
                       BAR_NB_JOUEUR,
                       BL_MAJ
                   )
                   VALUES (
                       '9J',
                       'BAREME 9 JOUEURS',
                       '',
                       '3053',
                       '100001',
                       '9',
                       '1'
                   );

INSERT INTO BAREME (
                       BAR_CD,
                       BAR_LB,
                       BAR_LB_COURT,
                       BAR_ID,
                       ORGA_ID,
                       BAR_NB_JOUEUR,
                       BL_MAJ
                   )
                   VALUES (
                       '10J',
                       'BAREME 10 JOUEURS',
                       '',
                       '3054',
                       '100001',
                       '10',
                       '1'
                   );

INSERT INTO BAREME (
                       BAR_CD,
                       BAR_LB,
                       BAR_LB_COURT,
                       BAR_ID,
                       ORGA_ID,
                       BAR_NB_JOUEUR,
                       BL_MAJ
                   )
                   VALUES (
                       '11J',
                       'BAREME 11 JOUEURS',
                       '',
                       '3055',
                       '100001',
                       '11',
                       '1'
                   );

INSERT INTO BAREME (
                       BAR_CD,
                       BAR_LB,
                       BAR_LB_COURT,
                       BAR_ID,
                       ORGA_ID,
                       BAR_NB_JOUEUR,
                       BL_MAJ
                   )
                   VALUES (
                       '12J',
                       'BAREME 12 JOUEURS',
                       '',
                       '3056',
                       '100001',
                       '12',
                       '1'
                   );

INSERT INTO BAREME (
                       BAR_CD,
                       BAR_LB,
                       BAR_LB_COURT,
                       BAR_ID,
                       ORGA_ID,
                       BAR_NB_JOUEUR,
                       BL_MAJ
                   )
                   VALUES (
                       '16J',
                       'BAREME 16 JOUEURS',
                       '',
                       '3057',
                       '100001',
                       '16',
                       '1'
                   );

INSERT INTO BAREME (
                       BAR_CD,
                       BAR_LB,
                       BAR_LB_COURT,
                       BAR_ID,
                       ORGA_ID,
                       BAR_NB_JOUEUR,
                       BL_MAJ
                   )
                   VALUES (
                       '18',
                       'BAREME 18 JOUEURS',
                       '',
                       '3058',
                       '100001',
                       '18',
                       '1'
                   );


-- Table : BAREME_DETAIL
DROP TABLE IF EXISTS BAREME_DETAIL;

CREATE TABLE BAREME_DETAIL (
    DBAR_ID_DETAILS,
    DBAR_NB_PLACE,
    DBAR_NB_POINT,
    BAR_ID,
    BL_MAJ
);

INSERT INTO BAREME_DETAIL (
                              DBAR_ID_DETAILS,
                              DBAR_NB_PLACE,
                              DBAR_NB_POINT,
                              BAR_ID,
                              BL_MAJ
                          )
                          VALUES (
                              '1362',
                              '1',
                              '100',
                              '1028',
                              '1'
                          );

INSERT INTO BAREME_DETAIL (
                              DBAR_ID_DETAILS,
                              DBAR_NB_PLACE,
                              DBAR_NB_POINT,
                              BAR_ID,
                              BL_MAJ
                          )
                          VALUES (
                              '1363',
                              '11',
                              '23',
                              '1028',
                              '1'
                          );

INSERT INTO BAREME_DETAIL (
                              DBAR_ID_DETAILS,
                              DBAR_NB_PLACE,
                              DBAR_NB_POINT,
                              BAR_ID,
                              BL_MAJ
                          )
                          VALUES (
                              '1364',
                              '21',
                              '3',
                              '1028',
                              '1'
                          );

INSERT INTO BAREME_DETAIL (
                              DBAR_ID_DETAILS,
                              DBAR_NB_PLACE,
                              DBAR_NB_POINT,
                              BAR_ID,
                              BL_MAJ
                          )
                          VALUES (
                              '1365',
                              '2',
                              '80',
                              '1028',
                              '1'
                          );

INSERT INTO BAREME_DETAIL (
                              DBAR_ID_DETAILS,
                              DBAR_NB_PLACE,
                              DBAR_NB_POINT,
                              BAR_ID,
                              BL_MAJ
                          )
                          VALUES (
                              '1366',
                              '12',
                              '23',
                              '1028',
                              '1'
                          );

INSERT INTO BAREME_DETAIL (
                              DBAR_ID_DETAILS,
                              DBAR_NB_PLACE,
                              DBAR_NB_POINT,
                              BAR_ID,
                              BL_MAJ
                          )
                          VALUES (
                              '1367',
                              '22',
                              '3',
                              '1028',
                              '1'
                          );

INSERT INTO BAREME_DETAIL (
                              DBAR_ID_DETAILS,
                              DBAR_NB_PLACE,
                              DBAR_NB_POINT,
                              BAR_ID,
                              BL_MAJ
                          )
                          VALUES (
                              '1368',
                              '3',
                              '52',
                              '1028',
                              '1'
                          );

INSERT INTO BAREME_DETAIL (
                              DBAR_ID_DETAILS,
                              DBAR_NB_PLACE,
                              DBAR_NB_POINT,
                              BAR_ID,
                              BL_MAJ
                          )
                          VALUES (
                              '1369',
                              '13',
                              '17',
                              '1028',
                              '1'
                          );

INSERT INTO BAREME_DETAIL (
                              DBAR_ID_DETAILS,
                              DBAR_NB_PLACE,
                              DBAR_NB_POINT,
                              BAR_ID,
                              BL_MAJ
                          )
                          VALUES (
                              '1370',
                              '23',
                              '3',
                              '1028',
                              '1'
                          );

INSERT INTO BAREME_DETAIL (
                              DBAR_ID_DETAILS,
                              DBAR_NB_PLACE,
                              DBAR_NB_POINT,
                              BAR_ID,
                              BL_MAJ
                          )
                          VALUES (
                              '1371',
                              '4',
                              '52',
                              '1028',
                              '1'
                          );

INSERT INTO BAREME_DETAIL (
                              DBAR_ID_DETAILS,
                              DBAR_NB_PLACE,
                              DBAR_NB_POINT,
                              BAR_ID,
                              BL_MAJ
                          )
                          VALUES (
                              '1372',
                              '14',
                              '15',
                              '1028',
                              '1'
                          );

INSERT INTO BAREME_DETAIL (
                              DBAR_ID_DETAILS,
                              DBAR_NB_PLACE,
                              DBAR_NB_POINT,
                              BAR_ID,
                              BL_MAJ
                          )
                          VALUES (
                              '1373',
                              '24',
                              '3',
                              '1028',
                              '1'
                          );

INSERT INTO BAREME_DETAIL (
                              DBAR_ID_DETAILS,
                              DBAR_NB_PLACE,
                              DBAR_NB_POINT,
                              BAR_ID,
                              BL_MAJ
                          )
                          VALUES (
                              '1374',
                              '5',
                              '32',
                              '1028',
                              '1'
                          );

INSERT INTO BAREME_DETAIL (
                              DBAR_ID_DETAILS,
                              DBAR_NB_PLACE,
                              DBAR_NB_POINT,
                              BAR_ID,
                              BL_MAJ
                          )
                          VALUES (
                              '1375',
                              '15',
                              '13',
                              '1028',
                              '1'
                          );

INSERT INTO BAREME_DETAIL (
                              DBAR_ID_DETAILS,
                              DBAR_NB_PLACE,
                              DBAR_NB_POINT,
                              BAR_ID,
                              BL_MAJ
                          )
                          VALUES (
                              '1376',
                              '6',
                              '32',
                              '1028',
                              '1'
                          );

INSERT INTO BAREME_DETAIL (
                              DBAR_ID_DETAILS,
                              DBAR_NB_PLACE,
                              DBAR_NB_POINT,
                              BAR_ID,
                              BL_MAJ
                          )
                          VALUES (
                              '1377',
                              '16',
                              '11',
                              '1028',
                              '1'
                          );

INSERT INTO BAREME_DETAIL (
                              DBAR_ID_DETAILS,
                              DBAR_NB_PLACE,
                              DBAR_NB_POINT,
                              BAR_ID,
                              BL_MAJ
                          )
                          VALUES (
                              '1378',
                              '7',
                              '32',
                              '1028',
                              '1'
                          );

INSERT INTO BAREME_DETAIL (
                              DBAR_ID_DETAILS,
                              DBAR_NB_PLACE,
                              DBAR_NB_POINT,
                              BAR_ID,
                              BL_MAJ
                          )
                          VALUES (
                              '1379',
                              '17',
                              '9',
                              '1028',
                              '1'
                          );

INSERT INTO BAREME_DETAIL (
                              DBAR_ID_DETAILS,
                              DBAR_NB_PLACE,
                              DBAR_NB_POINT,
                              BAR_ID,
                              BL_MAJ
                          )
                          VALUES (
                              '1380',
                              '8',
                              '32',
                              '1028',
                              '1'
                          );

INSERT INTO BAREME_DETAIL (
                              DBAR_ID_DETAILS,
                              DBAR_NB_PLACE,
                              DBAR_NB_POINT,
                              BAR_ID,
                              BL_MAJ
                          )
                          VALUES (
                              '1381',
                              '18',
                              '8',
                              '1028',
                              '1'
                          );

INSERT INTO BAREME_DETAIL (
                              DBAR_ID_DETAILS,
                              DBAR_NB_PLACE,
                              DBAR_NB_POINT,
                              BAR_ID,
                              BL_MAJ
                          )
                          VALUES (
                              '1382',
                              '9',
                              '23',
                              '1028',
                              '1'
                          );

INSERT INTO BAREME_DETAIL (
                              DBAR_ID_DETAILS,
                              DBAR_NB_PLACE,
                              DBAR_NB_POINT,
                              BAR_ID,
                              BL_MAJ
                          )
                          VALUES (
                              '1383',
                              '19',
                              '7',
                              '1028',
                              '1'
                          );

INSERT INTO BAREME_DETAIL (
                              DBAR_ID_DETAILS,
                              DBAR_NB_PLACE,
                              DBAR_NB_POINT,
                              BAR_ID,
                              BL_MAJ
                          )
                          VALUES (
                              '1384',
                              '10',
                              '23',
                              '1028',
                              '1'
                          );

INSERT INTO BAREME_DETAIL (
                              DBAR_ID_DETAILS,
                              DBAR_NB_PLACE,
                              DBAR_NB_POINT,
                              BAR_ID,
                              BL_MAJ
                          )
                          VALUES (
                              '1385',
                              '20',
                              '6',
                              '1028',
                              '1'
                          );

INSERT INTO BAREME_DETAIL (
                              DBAR_ID_DETAILS,
                              DBAR_NB_PLACE,
                              DBAR_NB_POINT,
                              BAR_ID,
                              BL_MAJ
                          )
                          VALUES (
                              '1386',
                              '1',
                              '100',
                              '1029',
                              '1'
                          );

INSERT INTO BAREME_DETAIL (
                              DBAR_ID_DETAILS,
                              DBAR_NB_PLACE,
                              DBAR_NB_POINT,
                              BAR_ID,
                              BL_MAJ
                          )
                          VALUES (
                              '1387',
                              '11',
                              '38',
                              '1029',
                              '1'
                          );

INSERT INTO BAREME_DETAIL (
                              DBAR_ID_DETAILS,
                              DBAR_NB_PLACE,
                              DBAR_NB_POINT,
                              BAR_ID,
                              BL_MAJ
                          )
                          VALUES (
                              '1388',
                              '21',
                              '26',
                              '1029',
                              '1'
                          );

INSERT INTO BAREME_DETAIL (
                              DBAR_ID_DETAILS,
                              DBAR_NB_PLACE,
                              DBAR_NB_POINT,
                              BAR_ID,
                              BL_MAJ
                          )
                          VALUES (
                              '1389',
                              '31',
                              '12',
                              '1029',
                              '1'
                          );

INSERT INTO BAREME_DETAIL (
                              DBAR_ID_DETAILS,
                              DBAR_NB_PLACE,
                              DBAR_NB_POINT,
                              BAR_ID,
                              BL_MAJ
                          )
                          VALUES (
                              '1390',
                              '41',
                              '2',
                              '1029',
                              '1'
                          );

INSERT INTO BAREME_DETAIL (
                              DBAR_ID_DETAILS,
                              DBAR_NB_PLACE,
                              DBAR_NB_POINT,
                              BAR_ID,
                              BL_MAJ
                          )
                          VALUES (
                              '1391',
                              '2',
                              '85',
                              '1029',
                              '1'
                          );

INSERT INTO BAREME_DETAIL (
                              DBAR_ID_DETAILS,
                              DBAR_NB_PLACE,
                              DBAR_NB_POINT,
                              BAR_ID,
                              BL_MAJ
                          )
                          VALUES (
                              '1392',
                              '12',
                              '38',
                              '1029',
                              '1'
                          );

INSERT INTO BAREME_DETAIL (
                              DBAR_ID_DETAILS,
                              DBAR_NB_PLACE,
                              DBAR_NB_POINT,
                              BAR_ID,
                              BL_MAJ
                          )
                          VALUES (
                              '1393',
                              '22',
                              '26',
                              '1029',
                              '1'
                          );

INSERT INTO BAREME_DETAIL (
                              DBAR_ID_DETAILS,
                              DBAR_NB_PLACE,
                              DBAR_NB_POINT,
                              BAR_ID,
                              BL_MAJ
                          )
                          VALUES (
                              '1394',
                              '32',
                              '11',
                              '1029',
                              '1'
                          );

INSERT INTO BAREME_DETAIL (
                              DBAR_ID_DETAILS,
                              DBAR_NB_PLACE,
                              DBAR_NB_POINT,
                              BAR_ID,
                              BL_MAJ
                          )
                          VALUES (
                              '1395',
                              '42',
                              '2',
                              '1029',
                              '1'
                          );

INSERT INTO BAREME_DETAIL (
                              DBAR_ID_DETAILS,
                              DBAR_NB_PLACE,
                              DBAR_NB_POINT,
                              BAR_ID,
                              BL_MAJ
                          )
                          VALUES (
                              '1396',
                              '3',
                              '70',
                              '1029',
                              '1'
                          );

INSERT INTO BAREME_DETAIL (
                              DBAR_ID_DETAILS,
                              DBAR_NB_PLACE,
                              DBAR_NB_POINT,
                              BAR_ID,
                              BL_MAJ
                          )
                          VALUES (
                              '1397',
                              '13',
                              '38',
                              '1029',
                              '1'
                          );

INSERT INTO BAREME_DETAIL (
                              DBAR_ID_DETAILS,
                              DBAR_NB_PLACE,
                              DBAR_NB_POINT,
                              BAR_ID,
                              BL_MAJ
                          )
                          VALUES (
                              '1398',
                              '23',
                              '26',
                              '1029',
                              '1'
                          );

INSERT INTO BAREME_DETAIL (
                              DBAR_ID_DETAILS,
                              DBAR_NB_PLACE,
                              DBAR_NB_POINT,
                              BAR_ID,
                              BL_MAJ
                          )
                          VALUES (
                              '1399',
                              '33',
                              '10',
                              '1029',
                              '1'
                          );

INSERT INTO BAREME_DETAIL (
                              DBAR_ID_DETAILS,
                              DBAR_NB_PLACE,
                              DBAR_NB_POINT,
                              BAR_ID,
                              BL_MAJ
                          )
                          VALUES (
                              '1400',
                              '43',
                              '2',
                              '1029',
                              '1'
                          );

INSERT INTO BAREME_DETAIL (
                              DBAR_ID_DETAILS,
                              DBAR_NB_PLACE,
                              DBAR_NB_POINT,
                              BAR_ID,
                              BL_MAJ
                          )
                          VALUES (
                              '1401',
                              '4',
                              '70',
                              '1029',
                              '1'
                          );

INSERT INTO BAREME_DETAIL (
                              DBAR_ID_DETAILS,
                              DBAR_NB_PLACE,
                              DBAR_NB_POINT,
                              BAR_ID,
                              BL_MAJ
                          )
                          VALUES (
                              '1402',
                              '14',
                              '38',
                              '1029',
                              '1'
                          );

INSERT INTO BAREME_DETAIL (
                              DBAR_ID_DETAILS,
                              DBAR_NB_PLACE,
                              DBAR_NB_POINT,
                              BAR_ID,
                              BL_MAJ
                          )
                          VALUES (
                              '1403',
                              '24',
                              '26',
                              '1029',
                              '1'
                          );

INSERT INTO BAREME_DETAIL (
                              DBAR_ID_DETAILS,
                              DBAR_NB_PLACE,
                              DBAR_NB_POINT,
                              BAR_ID,
                              BL_MAJ
                          )
                          VALUES (
                              '1404',
                              '34',
                              '9',
                              '1029',
                              '1'
                          );

INSERT INTO BAREME_DETAIL (
                              DBAR_ID_DETAILS,
                              DBAR_NB_PLACE,
                              DBAR_NB_POINT,
                              BAR_ID,
                              BL_MAJ
                          )
                          VALUES (
                              '1405',
                              '44',
                              '2',
                              '1029',
                              '1'
                          );

INSERT INTO BAREME_DETAIL (
                              DBAR_ID_DETAILS,
                              DBAR_NB_PLACE,
                              DBAR_NB_POINT,
                              BAR_ID,
                              BL_MAJ
                          )
                          VALUES (
                              '1406',
                              '5',
                              '54',
                              '1029',
                              '1'
                          );

INSERT INTO BAREME_DETAIL (
                              DBAR_ID_DETAILS,
                              DBAR_NB_PLACE,
                              DBAR_NB_POINT,
                              BAR_ID,
                              BL_MAJ
                          )
                          VALUES (
                              '1407',
                              '15',
                              '38',
                              '1029',
                              '1'
                          );

INSERT INTO BAREME_DETAIL (
                              DBAR_ID_DETAILS,
                              DBAR_NB_PLACE,
                              DBAR_NB_POINT,
                              BAR_ID,
                              BL_MAJ
                          )
                          VALUES (
                              '1408',
                              '25',
                              '18',
                              '1029',
                              '1'
                          );

INSERT INTO BAREME_DETAIL (
                              DBAR_ID_DETAILS,
                              DBAR_NB_PLACE,
                              DBAR_NB_POINT,
                              BAR_ID,
                              BL_MAJ
                          )
                          VALUES (
                              '1409',
                              '35',
                              '8',
                              '1029',
                              '1'
                          );

INSERT INTO BAREME_DETAIL (
                              DBAR_ID_DETAILS,
                              DBAR_NB_PLACE,
                              DBAR_NB_POINT,
                              BAR_ID,
                              BL_MAJ
                          )
                          VALUES (
                              '1410',
                              '45',
                              '2',
                              '1029',
                              '1'
                          );

INSERT INTO BAREME_DETAIL (
                              DBAR_ID_DETAILS,
                              DBAR_NB_PLACE,
                              DBAR_NB_POINT,
                              BAR_ID,
                              BL_MAJ
                          )
                          VALUES (
                              '1411',
                              '6',
                              '54',
                              '1029',
                              '1'
                          );

INSERT INTO BAREME_DETAIL (
                              DBAR_ID_DETAILS,
                              DBAR_NB_PLACE,
                              DBAR_NB_POINT,
                              BAR_ID,
                              BL_MAJ
                          )
                          VALUES (
                              '1412',
                              '16',
                              '38',
                              '1029',
                              '1'
                          );

INSERT INTO BAREME_DETAIL (
                              DBAR_ID_DETAILS,
                              DBAR_NB_PLACE,
                              DBAR_NB_POINT,
                              BAR_ID,
                              BL_MAJ
                          )
                          VALUES (
                              '1413',
                              '26',
                              '17',
                              '1029',
                              '1'
                          );

INSERT INTO BAREME_DETAIL (
                              DBAR_ID_DETAILS,
                              DBAR_NB_PLACE,
                              DBAR_NB_POINT,
                              BAR_ID,
                              BL_MAJ
                          )
                          VALUES (
                              '1414',
                              '36',
                              '7',
                              '1029',
                              '1'
                          );

INSERT INTO BAREME_DETAIL (
                              DBAR_ID_DETAILS,
                              DBAR_NB_PLACE,
                              DBAR_NB_POINT,
                              BAR_ID,
                              BL_MAJ
                          )
                          VALUES (
                              '1415',
                              '46',
                              '2',
                              '1029',
                              '1'
                          );

INSERT INTO BAREME_DETAIL (
                              DBAR_ID_DETAILS,
                              DBAR_NB_PLACE,
                              DBAR_NB_POINT,
                              BAR_ID,
                              BL_MAJ
                          )
                          VALUES (
                              '1416',
                              '7',
                              '54',
                              '1029',
                              '1'
                          );

INSERT INTO BAREME_DETAIL (
                              DBAR_ID_DETAILS,
                              DBAR_NB_PLACE,
                              DBAR_NB_POINT,
                              BAR_ID,
                              BL_MAJ
                          )
                          VALUES (
                              '1417',
                              '17',
                              '26',
                              '1029',
                              '1'
                          );

INSERT INTO BAREME_DETAIL (
                              DBAR_ID_DETAILS,
                              DBAR_NB_PLACE,
                              DBAR_NB_POINT,
                              BAR_ID,
                              BL_MAJ
                          )
                          VALUES (
                              '1418',
                              '27',
                              '16',
                              '1029',
                              '1'
                          );

INSERT INTO BAREME_DETAIL (
                              DBAR_ID_DETAILS,
                              DBAR_NB_PLACE,
                              DBAR_NB_POINT,
                              BAR_ID,
                              BL_MAJ
                          )
                          VALUES (
                              '1419',
                              '37',
                              '6',
                              '1029',
                              '1'
                          );

INSERT INTO BAREME_DETAIL (
                              DBAR_ID_DETAILS,
                              DBAR_NB_PLACE,
                              DBAR_NB_POINT,
                              BAR_ID,
                              BL_MAJ
                          )
                          VALUES (
                              '1420',
                              '47',
                              '2',
                              '1029',
                              '1'
                          );

INSERT INTO BAREME_DETAIL (
                              DBAR_ID_DETAILS,
                              DBAR_NB_PLACE,
                              DBAR_NB_POINT,
                              BAR_ID,
                              BL_MAJ
                          )
                          VALUES (
                              '1421',
                              '8',
                              '54',
                              '1029',
                              '1'
                          );

INSERT INTO BAREME_DETAIL (
                              DBAR_ID_DETAILS,
                              DBAR_NB_PLACE,
                              DBAR_NB_POINT,
                              BAR_ID,
                              BL_MAJ
                          )
                          VALUES (
                              '1422',
                              '18',
                              '26',
                              '1029',
                              '1'
                          );

INSERT INTO BAREME_DETAIL (
                              DBAR_ID_DETAILS,
                              DBAR_NB_PLACE,
                              DBAR_NB_POINT,
                              BAR_ID,
                              BL_MAJ
                          )
                          VALUES (
                              '1423',
                              '28',
                              '15',
                              '1029',
                              '1'
                          );

INSERT INTO BAREME_DETAIL (
                              DBAR_ID_DETAILS,
                              DBAR_NB_PLACE,
                              DBAR_NB_POINT,
                              BAR_ID,
                              BL_MAJ
                          )
                          VALUES (
                              '1424',
                              '38',
                              '5',
                              '1029',
                              '1'
                          );

INSERT INTO BAREME_DETAIL (
                              DBAR_ID_DETAILS,
                              DBAR_NB_PLACE,
                              DBAR_NB_POINT,
                              BAR_ID,
                              BL_MAJ
                          )
                          VALUES (
                              '1425',
                              '48',
                              '2',
                              '1029',
                              '1'
                          );

INSERT INTO BAREME_DETAIL (
                              DBAR_ID_DETAILS,
                              DBAR_NB_PLACE,
                              DBAR_NB_POINT,
                              BAR_ID,
                              BL_MAJ
                          )
                          VALUES (
                              '1426',
                              '9',
                              '38',
                              '1029',
                              '1'
                          );

INSERT INTO BAREME_DETAIL (
                              DBAR_ID_DETAILS,
                              DBAR_NB_PLACE,
                              DBAR_NB_POINT,
                              BAR_ID,
                              BL_MAJ
                          )
                          VALUES (
                              '1427',
                              '19',
                              '26',
                              '1029',
                              '1'
                          );

INSERT INTO BAREME_DETAIL (
                              DBAR_ID_DETAILS,
                              DBAR_NB_PLACE,
                              DBAR_NB_POINT,
                              BAR_ID,
                              BL_MAJ
                          )
                          VALUES (
                              '1428',
                              '29',
                              '14',
                              '1029',
                              '1'
                          );

INSERT INTO BAREME_DETAIL (
                              DBAR_ID_DETAILS,
                              DBAR_NB_PLACE,
                              DBAR_NB_POINT,
                              BAR_ID,
                              BL_MAJ
                          )
                          VALUES (
                              '1429',
                              '39',
                              '4',
                              '1029',
                              '1'
                          );

INSERT INTO BAREME_DETAIL (
                              DBAR_ID_DETAILS,
                              DBAR_NB_PLACE,
                              DBAR_NB_POINT,
                              BAR_ID,
                              BL_MAJ
                          )
                          VALUES (
                              '1430',
                              '10',
                              '38',
                              '1029',
                              '1'
                          );

INSERT INTO BAREME_DETAIL (
                              DBAR_ID_DETAILS,
                              DBAR_NB_PLACE,
                              DBAR_NB_POINT,
                              BAR_ID,
                              BL_MAJ
                          )
                          VALUES (
                              '1431',
                              '20',
                              '26',
                              '1029',
                              '1'
                          );

INSERT INTO BAREME_DETAIL (
                              DBAR_ID_DETAILS,
                              DBAR_NB_PLACE,
                              DBAR_NB_POINT,
                              BAR_ID,
                              BL_MAJ
                          )
                          VALUES (
                              '1432',
                              '30',
                              '13',
                              '1029',
                              '1'
                          );

INSERT INTO BAREME_DETAIL (
                              DBAR_ID_DETAILS,
                              DBAR_NB_PLACE,
                              DBAR_NB_POINT,
                              BAR_ID,
                              BL_MAJ
                          )
                          VALUES (
                              '1433',
                              '40',
                              '3',
                              '1029',
                              '1'
                          );

INSERT INTO BAREME_DETAIL (
                              DBAR_ID_DETAILS,
                              DBAR_NB_PLACE,
                              DBAR_NB_POINT,
                              BAR_ID,
                              BL_MAJ
                          )
                          VALUES (
                              '1434',
                              '1',
                              '100',
                              '1030',
                              '1'
                          );

INSERT INTO BAREME_DETAIL (
                              DBAR_ID_DETAILS,
                              DBAR_NB_PLACE,
                              DBAR_NB_POINT,
                              BAR_ID,
                              BL_MAJ
                          )
                          VALUES (
                              '1435',
                              '11',
                              '10',
                              '1030',
                              '1'
                          );

INSERT INTO BAREME_DETAIL (
                              DBAR_ID_DETAILS,
                              DBAR_NB_PLACE,
                              DBAR_NB_POINT,
                              BAR_ID,
                              BL_MAJ
                          )
                          VALUES (
                              '1436',
                              '2',
                              '80',
                              '1030',
                              '1'
                          );

INSERT INTO BAREME_DETAIL (
                              DBAR_ID_DETAILS,
                              DBAR_NB_PLACE,
                              DBAR_NB_POINT,
                              BAR_ID,
                              BL_MAJ
                          )
                          VALUES (
                              '1437',
                              '12',
                              '7',
                              '1030',
                              '1'
                          );

INSERT INTO BAREME_DETAIL (
                              DBAR_ID_DETAILS,
                              DBAR_NB_PLACE,
                              DBAR_NB_POINT,
                              BAR_ID,
                              BL_MAJ
                          )
                          VALUES (
                              '1438',
                              '3',
                              '65',
                              '1030',
                              '1'
                          );

INSERT INTO BAREME_DETAIL (
                              DBAR_ID_DETAILS,
                              DBAR_NB_PLACE,
                              DBAR_NB_POINT,
                              BAR_ID,
                              BL_MAJ
                          )
                          VALUES (
                              '1439',
                              '13',
                              '5',
                              '1030',
                              '1'
                          );

INSERT INTO BAREME_DETAIL (
                              DBAR_ID_DETAILS,
                              DBAR_NB_PLACE,
                              DBAR_NB_POINT,
                              BAR_ID,
                              BL_MAJ
                          )
                          VALUES (
                              '1440',
                              '4',
                              '50',
                              '1030',
                              '1'
                          );

INSERT INTO BAREME_DETAIL (
                              DBAR_ID_DETAILS,
                              DBAR_NB_PLACE,
                              DBAR_NB_POINT,
                              BAR_ID,
                              BL_MAJ
                          )
                          VALUES (
                              '1441',
                              '14',
                              '4',
                              '1030',
                              '1'
                          );

INSERT INTO BAREME_DETAIL (
                              DBAR_ID_DETAILS,
                              DBAR_NB_PLACE,
                              DBAR_NB_POINT,
                              BAR_ID,
                              BL_MAJ
                          )
                          VALUES (
                              '1442',
                              '5',
                              '40',
                              '1030',
                              '1'
                          );

INSERT INTO BAREME_DETAIL (
                              DBAR_ID_DETAILS,
                              DBAR_NB_PLACE,
                              DBAR_NB_POINT,
                              BAR_ID,
                              BL_MAJ
                          )
                          VALUES (
                              '1443',
                              '15',
                              '3',
                              '1030',
                              '1'
                          );

INSERT INTO BAREME_DETAIL (
                              DBAR_ID_DETAILS,
                              DBAR_NB_PLACE,
                              DBAR_NB_POINT,
                              BAR_ID,
                              BL_MAJ
                          )
                          VALUES (
                              '1444',
                              '6',
                              '35',
                              '1030',
                              '1'
                          );

INSERT INTO BAREME_DETAIL (
                              DBAR_ID_DETAILS,
                              DBAR_NB_PLACE,
                              DBAR_NB_POINT,
                              BAR_ID,
                              BL_MAJ
                          )
                          VALUES (
                              '1445',
                              '16',
                              '2',
                              '1030',
                              '1'
                          );

INSERT INTO BAREME_DETAIL (
                              DBAR_ID_DETAILS,
                              DBAR_NB_PLACE,
                              DBAR_NB_POINT,
                              BAR_ID,
                              BL_MAJ
                          )
                          VALUES (
                              '1446',
                              '7',
                              '30',
                              '1030',
                              '1'
                          );

INSERT INTO BAREME_DETAIL (
                              DBAR_ID_DETAILS,
                              DBAR_NB_PLACE,
                              DBAR_NB_POINT,
                              BAR_ID,
                              BL_MAJ
                          )
                          VALUES (
                              '1447',
                              '8',
                              '25',
                              '1030',
                              '1'
                          );

INSERT INTO BAREME_DETAIL (
                              DBAR_ID_DETAILS,
                              DBAR_NB_PLACE,
                              DBAR_NB_POINT,
                              BAR_ID,
                              BL_MAJ
                          )
                          VALUES (
                              '1448',
                              '9',
                              '20',
                              '1030',
                              '1'
                          );

INSERT INTO BAREME_DETAIL (
                              DBAR_ID_DETAILS,
                              DBAR_NB_PLACE,
                              DBAR_NB_POINT,
                              BAR_ID,
                              BL_MAJ
                          )
                          VALUES (
                              '1449',
                              '10',
                              '15',
                              '1030',
                              '1'
                          );

INSERT INTO BAREME_DETAIL (
                              DBAR_ID_DETAILS,
                              DBAR_NB_PLACE,
                              DBAR_NB_POINT,
                              BAR_ID,
                              BL_MAJ
                          )
                          VALUES (
                              '1450',
                              '1',
                              '100',
                              '1031',
                              '1'
                          );

INSERT INTO BAREME_DETAIL (
                              DBAR_ID_DETAILS,
                              DBAR_NB_PLACE,
                              DBAR_NB_POINT,
                              BAR_ID,
                              BL_MAJ
                          )
                          VALUES (
                              '1451',
                              '11',
                              '31',
                              '1031',
                              '1'
                          );

INSERT INTO BAREME_DETAIL (
                              DBAR_ID_DETAILS,
                              DBAR_NB_PLACE,
                              DBAR_NB_POINT,
                              BAR_ID,
                              BL_MAJ
                          )
                          VALUES (
                              '1452',
                              '21',
                              '13',
                              '1031',
                              '1'
                          );

INSERT INTO BAREME_DETAIL (
                              DBAR_ID_DETAILS,
                              DBAR_NB_PLACE,
                              DBAR_NB_POINT,
                              BAR_ID,
                              BL_MAJ
                          )
                          VALUES (
                              '1453',
                              '31',
                              '3',
                              '1031',
                              '1'
                          );

INSERT INTO BAREME_DETAIL (
                              DBAR_ID_DETAILS,
                              DBAR_NB_PLACE,
                              DBAR_NB_POINT,
                              BAR_ID,
                              BL_MAJ
                          )
                          VALUES (
                              '1454',
                              '2',
                              '80',
                              '1031',
                              '1'
                          );

INSERT INTO BAREME_DETAIL (
                              DBAR_ID_DETAILS,
                              DBAR_NB_PLACE,
                              DBAR_NB_POINT,
                              BAR_ID,
                              BL_MAJ
                          )
                          VALUES (
                              '1455',
                              '12',
                              '30',
                              '1031',
                              '1'
                          );

INSERT INTO BAREME_DETAIL (
                              DBAR_ID_DETAILS,
                              DBAR_NB_PLACE,
                              DBAR_NB_POINT,
                              BAR_ID,
                              BL_MAJ
                          )
                          VALUES (
                              '1456',
                              '22',
                              '12',
                              '1031',
                              '1'
                          );

INSERT INTO BAREME_DETAIL (
                              DBAR_ID_DETAILS,
                              DBAR_NB_PLACE,
                              DBAR_NB_POINT,
                              BAR_ID,
                              BL_MAJ
                          )
                          VALUES (
                              '1457',
                              '32',
                              '2',
                              '1031',
                              '1'
                          );

INSERT INTO BAREME_DETAIL (
                              DBAR_ID_DETAILS,
                              DBAR_NB_PLACE,
                              DBAR_NB_POINT,
                              BAR_ID,
                              BL_MAJ
                          )
                          VALUES (
                              '1458',
                              '3',
                              '65',
                              '1031',
                              '1'
                          );

INSERT INTO BAREME_DETAIL (
                              DBAR_ID_DETAILS,
                              DBAR_NB_PLACE,
                              DBAR_NB_POINT,
                              BAR_ID,
                              BL_MAJ
                          )
                          VALUES (
                              '1459',
                              '13',
                              '29',
                              '1031',
                              '1'
                          );

INSERT INTO BAREME_DETAIL (
                              DBAR_ID_DETAILS,
                              DBAR_NB_PLACE,
                              DBAR_NB_POINT,
                              BAR_ID,
                              BL_MAJ
                          )
                          VALUES (
                              '1460',
                              '23',
                              '11',
                              '1031',
                              '1'
                          );

INSERT INTO BAREME_DETAIL (
                              DBAR_ID_DETAILS,
                              DBAR_NB_PLACE,
                              DBAR_NB_POINT,
                              BAR_ID,
                              BL_MAJ
                          )
                          VALUES (
                              '1461',
                              '4',
                              '55',
                              '1031',
                              '1'
                          );

INSERT INTO BAREME_DETAIL (
                              DBAR_ID_DETAILS,
                              DBAR_NB_PLACE,
                              DBAR_NB_POINT,
                              BAR_ID,
                              BL_MAJ
                          )
                          VALUES (
                              '1462',
                              '14',
                              '28',
                              '1031',
                              '1'
                          );

INSERT INTO BAREME_DETAIL (
                              DBAR_ID_DETAILS,
                              DBAR_NB_PLACE,
                              DBAR_NB_POINT,
                              BAR_ID,
                              BL_MAJ
                          )
                          VALUES (
                              '1463',
                              '24',
                              '10',
                              '1031',
                              '1'
                          );

INSERT INTO BAREME_DETAIL (
                              DBAR_ID_DETAILS,
                              DBAR_NB_PLACE,
                              DBAR_NB_POINT,
                              BAR_ID,
                              BL_MAJ
                          )
                          VALUES (
                              '1464',
                              '5',
                              '45',
                              '1031',
                              '1'
                          );

INSERT INTO BAREME_DETAIL (
                              DBAR_ID_DETAILS,
                              DBAR_NB_PLACE,
                              DBAR_NB_POINT,
                              BAR_ID,
                              BL_MAJ
                          )
                          VALUES (
                              '1465',
                              '15',
                              '27',
                              '1031',
                              '1'
                          );

INSERT INTO BAREME_DETAIL (
                              DBAR_ID_DETAILS,
                              DBAR_NB_PLACE,
                              DBAR_NB_POINT,
                              BAR_ID,
                              BL_MAJ
                          )
                          VALUES (
                              '1466',
                              '25',
                              '9',
                              '1031',
                              '1'
                          );

INSERT INTO BAREME_DETAIL (
                              DBAR_ID_DETAILS,
                              DBAR_NB_PLACE,
                              DBAR_NB_POINT,
                              BAR_ID,
                              BL_MAJ
                          )
                          VALUES (
                              '1467',
                              '6',
                              '40',
                              '1031',
                              '1'
                          );

INSERT INTO BAREME_DETAIL (
                              DBAR_ID_DETAILS,
                              DBAR_NB_PLACE,
                              DBAR_NB_POINT,
                              BAR_ID,
                              BL_MAJ
                          )
                          VALUES (
                              '1468',
                              '16',
                              '26',
                              '1031',
                              '1'
                          );

INSERT INTO BAREME_DETAIL (
                              DBAR_ID_DETAILS,
                              DBAR_NB_PLACE,
                              DBAR_NB_POINT,
                              BAR_ID,
                              BL_MAJ
                          )
                          VALUES (
                              '1469',
                              '26',
                              '8',
                              '1031',
                              '1'
                          );

INSERT INTO BAREME_DETAIL (
                              DBAR_ID_DETAILS,
                              DBAR_NB_PLACE,
                              DBAR_NB_POINT,
                              BAR_ID,
                              BL_MAJ
                          )
                          VALUES (
                              '1470',
                              '7',
                              '37',
                              '1031',
                              '1'
                          );

INSERT INTO BAREME_DETAIL (
                              DBAR_ID_DETAILS,
                              DBAR_NB_PLACE,
                              DBAR_NB_POINT,
                              BAR_ID,
                              BL_MAJ
                          )
                          VALUES (
                              '1471',
                              '17',
                              '23',
                              '1031',
                              '1'
                          );

INSERT INTO BAREME_DETAIL (
                              DBAR_ID_DETAILS,
                              DBAR_NB_PLACE,
                              DBAR_NB_POINT,
                              BAR_ID,
                              BL_MAJ
                          )
                          VALUES (
                              '1472',
                              '27',
                              '7',
                              '1031',
                              '1'
                          );

INSERT INTO BAREME_DETAIL (
                              DBAR_ID_DETAILS,
                              DBAR_NB_PLACE,
                              DBAR_NB_POINT,
                              BAR_ID,
                              BL_MAJ
                          )
                          VALUES (
                              '1473',
                              '8',
                              '35',
                              '1031',
                              '1'
                          );

INSERT INTO BAREME_DETAIL (
                              DBAR_ID_DETAILS,
                              DBAR_NB_PLACE,
                              DBAR_NB_POINT,
                              BAR_ID,
                              BL_MAJ
                          )
                          VALUES (
                              '1474',
                              '18',
                              '20',
                              '1031',
                              '1'
                          );

INSERT INTO BAREME_DETAIL (
                              DBAR_ID_DETAILS,
                              DBAR_NB_PLACE,
                              DBAR_NB_POINT,
                              BAR_ID,
                              BL_MAJ
                          )
                          VALUES (
                              '1475',
                              '28',
                              '6',
                              '1031',
                              '1'
                          );

INSERT INTO BAREME_DETAIL (
                              DBAR_ID_DETAILS,
                              DBAR_NB_PLACE,
                              DBAR_NB_POINT,
                              BAR_ID,
                              BL_MAJ
                          )
                          VALUES (
                              '1476',
                              '9',
                              '33',
                              '1031',
                              '1'
                          );

INSERT INTO BAREME_DETAIL (
                              DBAR_ID_DETAILS,
                              DBAR_NB_PLACE,
                              DBAR_NB_POINT,
                              BAR_ID,
                              BL_MAJ
                          )
                          VALUES (
                              '1477',
                              '19',
                              '17',
                              '1031',
                              '1'
                          );

INSERT INTO BAREME_DETAIL (
                              DBAR_ID_DETAILS,
                              DBAR_NB_PLACE,
                              DBAR_NB_POINT,
                              BAR_ID,
                              BL_MAJ
                          )
                          VALUES (
                              '1478',
                              '29',
                              '5',
                              '1031',
                              '1'
                          );

INSERT INTO BAREME_DETAIL (
                              DBAR_ID_DETAILS,
                              DBAR_NB_PLACE,
                              DBAR_NB_POINT,
                              BAR_ID,
                              BL_MAJ
                          )
                          VALUES (
                              '1479',
                              '10',
                              '32',
                              '1031',
                              '1'
                          );

INSERT INTO BAREME_DETAIL (
                              DBAR_ID_DETAILS,
                              DBAR_NB_PLACE,
                              DBAR_NB_POINT,
                              BAR_ID,
                              BL_MAJ
                          )
                          VALUES (
                              '1480',
                              '20',
                              '15',
                              '1031',
                              '1'
                          );

INSERT INTO BAREME_DETAIL (
                              DBAR_ID_DETAILS,
                              DBAR_NB_PLACE,
                              DBAR_NB_POINT,
                              BAR_ID,
                              BL_MAJ
                          )
                          VALUES (
                              '1481',
                              '30',
                              '4',
                              '1031',
                              '1'
                          );

INSERT INTO BAREME_DETAIL (
                              DBAR_ID_DETAILS,
                              DBAR_NB_PLACE,
                              DBAR_NB_POINT,
                              BAR_ID,
                              BL_MAJ
                          )
                          VALUES (
                              '1482',
                              '1',
                              '100',
                              '1032',
                              '1'
                          );

INSERT INTO BAREME_DETAIL (
                              DBAR_ID_DETAILS,
                              DBAR_NB_PLACE,
                              DBAR_NB_POINT,
                              BAR_ID,
                              BL_MAJ
                          )
                          VALUES (
                              '1483',
                              '11',
                              '23',
                              '1032',
                              '1'
                          );

INSERT INTO BAREME_DETAIL (
                              DBAR_ID_DETAILS,
                              DBAR_NB_PLACE,
                              DBAR_NB_POINT,
                              BAR_ID,
                              BL_MAJ
                          )
                          VALUES (
                              '1484',
                              '21',
                              '3',
                              '1032',
                              '1'
                          );

INSERT INTO BAREME_DETAIL (
                              DBAR_ID_DETAILS,
                              DBAR_NB_PLACE,
                              DBAR_NB_POINT,
                              BAR_ID,
                              BL_MAJ
                          )
                          VALUES (
                              '1485',
                              '2',
                              '80',
                              '1032',
                              '1'
                          );

INSERT INTO BAREME_DETAIL (
                              DBAR_ID_DETAILS,
                              DBAR_NB_PLACE,
                              DBAR_NB_POINT,
                              BAR_ID,
                              BL_MAJ
                          )
                          VALUES (
                              '1486',
                              '12',
                              '22',
                              '1032',
                              '1'
                          );

INSERT INTO BAREME_DETAIL (
                              DBAR_ID_DETAILS,
                              DBAR_NB_PLACE,
                              DBAR_NB_POINT,
                              BAR_ID,
                              BL_MAJ
                          )
                          VALUES (
                              '1487',
                              '22',
                              '3',
                              '1032',
                              '1'
                          );

INSERT INTO BAREME_DETAIL (
                              DBAR_ID_DETAILS,
                              DBAR_NB_PLACE,
                              DBAR_NB_POINT,
                              BAR_ID,
                              BL_MAJ
                          )
                          VALUES (
                              '1488',
                              '3',
                              '65',
                              '1032',
                              '1'
                          );

INSERT INTO BAREME_DETAIL (
                              DBAR_ID_DETAILS,
                              DBAR_NB_PLACE,
                              DBAR_NB_POINT,
                              BAR_ID,
                              BL_MAJ
                          )
                          VALUES (
                              '1489',
                              '13',
                              '17',
                              '1032',
                              '1'
                          );

INSERT INTO BAREME_DETAIL (
                              DBAR_ID_DETAILS,
                              DBAR_NB_PLACE,
                              DBAR_NB_POINT,
                              BAR_ID,
                              BL_MAJ
                          )
                          VALUES (
                              '1490',
                              '23',
                              '3',
                              '1032',
                              '1'
                          );

INSERT INTO BAREME_DETAIL (
                              DBAR_ID_DETAILS,
                              DBAR_NB_PLACE,
                              DBAR_NB_POINT,
                              BAR_ID,
                              BL_MAJ
                          )
                          VALUES (
                              '1491',
                              '4',
                              '52',
                              '1032',
                              '1'
                          );

INSERT INTO BAREME_DETAIL (
                              DBAR_ID_DETAILS,
                              DBAR_NB_PLACE,
                              DBAR_NB_POINT,
                              BAR_ID,
                              BL_MAJ
                          )
                          VALUES (
                              '1492',
                              '14',
                              '15',
                              '1032',
                              '1'
                          );

INSERT INTO BAREME_DETAIL (
                              DBAR_ID_DETAILS,
                              DBAR_NB_PLACE,
                              DBAR_NB_POINT,
                              BAR_ID,
                              BL_MAJ
                          )
                          VALUES (
                              '1493',
                              '24',
                              '3',
                              '1032',
                              '1'
                          );

INSERT INTO BAREME_DETAIL (
                              DBAR_ID_DETAILS,
                              DBAR_NB_PLACE,
                              DBAR_NB_POINT,
                              BAR_ID,
                              BL_MAJ
                          )
                          VALUES (
                              '1494',
                              '5',
                              '42',
                              '1032',
                              '1'
                          );

INSERT INTO BAREME_DETAIL (
                              DBAR_ID_DETAILS,
                              DBAR_NB_PLACE,
                              DBAR_NB_POINT,
                              BAR_ID,
                              BL_MAJ
                          )
                          VALUES (
                              '1495',
                              '15',
                              '13',
                              '1032',
                              '1'
                          );

INSERT INTO BAREME_DETAIL (
                              DBAR_ID_DETAILS,
                              DBAR_NB_PLACE,
                              DBAR_NB_POINT,
                              BAR_ID,
                              BL_MAJ
                          )
                          VALUES (
                              '1496',
                              '6',
                              '37',
                              '1032',
                              '1'
                          );

INSERT INTO BAREME_DETAIL (
                              DBAR_ID_DETAILS,
                              DBAR_NB_PLACE,
                              DBAR_NB_POINT,
                              BAR_ID,
                              BL_MAJ
                          )
                          VALUES (
                              '1497',
                              '16',
                              '11',
                              '1032',
                              '1'
                          );

INSERT INTO BAREME_DETAIL (
                              DBAR_ID_DETAILS,
                              DBAR_NB_PLACE,
                              DBAR_NB_POINT,
                              BAR_ID,
                              BL_MAJ
                          )
                          VALUES (
                              '1498',
                              '7',
                              '32',
                              '1032',
                              '1'
                          );

INSERT INTO BAREME_DETAIL (
                              DBAR_ID_DETAILS,
                              DBAR_NB_PLACE,
                              DBAR_NB_POINT,
                              BAR_ID,
                              BL_MAJ
                          )
                          VALUES (
                              '1499',
                              '17',
                              '9',
                              '1032',
                              '1'
                          );

INSERT INTO BAREME_DETAIL (
                              DBAR_ID_DETAILS,
                              DBAR_NB_PLACE,
                              DBAR_NB_POINT,
                              BAR_ID,
                              BL_MAJ
                          )
                          VALUES (
                              '1500',
                              '8',
                              '28',
                              '1032',
                              '1'
                          );

INSERT INTO BAREME_DETAIL (
                              DBAR_ID_DETAILS,
                              DBAR_NB_PLACE,
                              DBAR_NB_POINT,
                              BAR_ID,
                              BL_MAJ
                          )
                          VALUES (
                              '1501',
                              '18',
                              '8',
                              '1032',
                              '1'
                          );

INSERT INTO BAREME_DETAIL (
                              DBAR_ID_DETAILS,
                              DBAR_NB_PLACE,
                              DBAR_NB_POINT,
                              BAR_ID,
                              BL_MAJ
                          )
                          VALUES (
                              '1502',
                              '9',
                              '25',
                              '1032',
                              '1'
                          );

INSERT INTO BAREME_DETAIL (
                              DBAR_ID_DETAILS,
                              DBAR_NB_PLACE,
                              DBAR_NB_POINT,
                              BAR_ID,
                              BL_MAJ
                          )
                          VALUES (
                              '1503',
                              '19',
                              '7',
                              '1032',
                              '1'
                          );

INSERT INTO BAREME_DETAIL (
                              DBAR_ID_DETAILS,
                              DBAR_NB_PLACE,
                              DBAR_NB_POINT,
                              BAR_ID,
                              BL_MAJ
                          )
                          VALUES (
                              '1504',
                              '10',
                              '24',
                              '1032',
                              '1'
                          );

INSERT INTO BAREME_DETAIL (
                              DBAR_ID_DETAILS,
                              DBAR_NB_PLACE,
                              DBAR_NB_POINT,
                              BAR_ID,
                              BL_MAJ
                          )
                          VALUES (
                              '1505',
                              '20',
                              '6',
                              '1032',
                              '1'
                          );

INSERT INTO BAREME_DETAIL (
                              DBAR_ID_DETAILS,
                              DBAR_NB_PLACE,
                              DBAR_NB_POINT,
                              BAR_ID,
                              BL_MAJ
                          )
                          VALUES (
                              '1347',
                              '11',
                              '10',
                              '1027',
                              '1'
                          );

INSERT INTO BAREME_DETAIL (
                              DBAR_ID_DETAILS,
                              DBAR_NB_PLACE,
                              DBAR_NB_POINT,
                              BAR_ID,
                              BL_MAJ
                          )
                          VALUES (
                              '1348',
                              '2',
                              '80',
                              '1027',
                              '1'
                          );

INSERT INTO BAREME_DETAIL (
                              DBAR_ID_DETAILS,
                              DBAR_NB_PLACE,
                              DBAR_NB_POINT,
                              BAR_ID,
                              BL_MAJ
                          )
                          VALUES (
                              '1349',
                              '12',
                              '10',
                              '1027',
                              '1'
                          );

INSERT INTO BAREME_DETAIL (
                              DBAR_ID_DETAILS,
                              DBAR_NB_PLACE,
                              DBAR_NB_POINT,
                              BAR_ID,
                              BL_MAJ
                          )
                          VALUES (
                              '1350',
                              '3',
                              '50',
                              '1027',
                              '1'
                          );

INSERT INTO BAREME_DETAIL (
                              DBAR_ID_DETAILS,
                              DBAR_NB_PLACE,
                              DBAR_NB_POINT,
                              BAR_ID,
                              BL_MAJ
                          )
                          VALUES (
                              '1351',
                              '13',
                              '5',
                              '1027',
                              '1'
                          );

INSERT INTO BAREME_DETAIL (
                              DBAR_ID_DETAILS,
                              DBAR_NB_PLACE,
                              DBAR_NB_POINT,
                              BAR_ID,
                              BL_MAJ
                          )
                          VALUES (
                              '1352',
                              '4',
                              '50',
                              '1027',
                              '1'
                          );

INSERT INTO BAREME_DETAIL (
                              DBAR_ID_DETAILS,
                              DBAR_NB_PLACE,
                              DBAR_NB_POINT,
                              BAR_ID,
                              BL_MAJ
                          )
                          VALUES (
                              '1353',
                              '14',
                              '4',
                              '1027',
                              '1'
                          );

INSERT INTO BAREME_DETAIL (
                              DBAR_ID_DETAILS,
                              DBAR_NB_PLACE,
                              DBAR_NB_POINT,
                              BAR_ID,
                              BL_MAJ
                          )
                          VALUES (
                              '1354',
                              '5',
                              '30',
                              '1027',
                              '1'
                          );

INSERT INTO BAREME_DETAIL (
                              DBAR_ID_DETAILS,
                              DBAR_NB_PLACE,
                              DBAR_NB_POINT,
                              BAR_ID,
                              BL_MAJ
                          )
                          VALUES (
                              '1355',
                              '15',
                              '2',
                              '1027',
                              '1'
                          );

INSERT INTO BAREME_DETAIL (
                              DBAR_ID_DETAILS,
                              DBAR_NB_PLACE,
                              DBAR_NB_POINT,
                              BAR_ID,
                              BL_MAJ
                          )
                          VALUES (
                              '1356',
                              '6',
                              '30',
                              '1027',
                              '1'
                          );

INSERT INTO BAREME_DETAIL (
                              DBAR_ID_DETAILS,
                              DBAR_NB_PLACE,
                              DBAR_NB_POINT,
                              BAR_ID,
                              BL_MAJ
                          )
                          VALUES (
                              '1357',
                              '16',
                              '2',
                              '1027',
                              '1'
                          );

INSERT INTO BAREME_DETAIL (
                              DBAR_ID_DETAILS,
                              DBAR_NB_PLACE,
                              DBAR_NB_POINT,
                              BAR_ID,
                              BL_MAJ
                          )
                          VALUES (
                              '1358',
                              '7',
                              '30',
                              '1027',
                              '1'
                          );

INSERT INTO BAREME_DETAIL (
                              DBAR_ID_DETAILS,
                              DBAR_NB_PLACE,
                              DBAR_NB_POINT,
                              BAR_ID,
                              BL_MAJ
                          )
                          VALUES (
                              '1359',
                              '8',
                              '30',
                              '1027',
                              '1'
                          );

INSERT INTO BAREME_DETAIL (
                              DBAR_ID_DETAILS,
                              DBAR_NB_PLACE,
                              DBAR_NB_POINT,
                              BAR_ID,
                              BL_MAJ
                          )
                          VALUES (
                              '1360',
                              '9',
                              '10',
                              '1027',
                              '1'
                          );

INSERT INTO BAREME_DETAIL (
                              DBAR_ID_DETAILS,
                              DBAR_NB_PLACE,
                              DBAR_NB_POINT,
                              BAR_ID,
                              BL_MAJ
                          )
                          VALUES (
                              '1361',
                              '10',
                              '10',
                              '1027',
                              '1'
                          );

INSERT INTO BAREME_DETAIL (
                              DBAR_ID_DETAILS,
                              DBAR_NB_PLACE,
                              DBAR_NB_POINT,
                              BAR_ID,
                              BL_MAJ
                          )
                          VALUES (
                              '1346',
                              '1',
                              '100',
                              '1027',
                              '1'
                          );

INSERT INTO BAREME_DETAIL (
                              DBAR_ID_DETAILS,
                              DBAR_NB_PLACE,
                              DBAR_NB_POINT,
                              BAR_ID,
                              BL_MAJ
                          )
                          VALUES (
                              '1506',
                              '1',
                              '100',
                              '1033',
                              '1'
                          );

INSERT INTO BAREME_DETAIL (
                              DBAR_ID_DETAILS,
                              DBAR_NB_PLACE,
                              DBAR_NB_POINT,
                              BAR_ID,
                              BL_MAJ
                          )
                          VALUES (
                              '1507',
                              '11',
                              '23',
                              '1033',
                              '1'
                          );

INSERT INTO BAREME_DETAIL (
                              DBAR_ID_DETAILS,
                              DBAR_NB_PLACE,
                              DBAR_NB_POINT,
                              BAR_ID,
                              BL_MAJ
                          )
                          VALUES (
                              '1508',
                              '21',
                              '5',
                              '1033',
                              '1'
                          );

INSERT INTO BAREME_DETAIL (
                              DBAR_ID_DETAILS,
                              DBAR_NB_PLACE,
                              DBAR_NB_POINT,
                              BAR_ID,
                              BL_MAJ
                          )
                          VALUES (
                              '1509',
                              '2',
                              '80',
                              '1033',
                              '1'
                          );

INSERT INTO BAREME_DETAIL (
                              DBAR_ID_DETAILS,
                              DBAR_NB_PLACE,
                              DBAR_NB_POINT,
                              BAR_ID,
                              BL_MAJ
                          )
                          VALUES (
                              '1510',
                              '12',
                              '22',
                              '1033',
                              '1'
                          );

INSERT INTO BAREME_DETAIL (
                              DBAR_ID_DETAILS,
                              DBAR_NB_PLACE,
                              DBAR_NB_POINT,
                              BAR_ID,
                              BL_MAJ
                          )
                          VALUES (
                              '1511',
                              '22',
                              '4',
                              '1033',
                              '1'
                          );

INSERT INTO BAREME_DETAIL (
                              DBAR_ID_DETAILS,
                              DBAR_NB_PLACE,
                              DBAR_NB_POINT,
                              BAR_ID,
                              BL_MAJ
                          )
                          VALUES (
                              '1512',
                              '3',
                              '65',
                              '1033',
                              '1'
                          );

INSERT INTO BAREME_DETAIL (
                              DBAR_ID_DETAILS,
                              DBAR_NB_PLACE,
                              DBAR_NB_POINT,
                              BAR_ID,
                              BL_MAJ
                          )
                          VALUES (
                              '1513',
                              '13',
                              '17',
                              '1033',
                              '1'
                          );

INSERT INTO BAREME_DETAIL (
                              DBAR_ID_DETAILS,
                              DBAR_NB_PLACE,
                              DBAR_NB_POINT,
                              BAR_ID,
                              BL_MAJ
                          )
                          VALUES (
                              '1514',
                              '23',
                              '3',
                              '1033',
                              '1'
                          );

INSERT INTO BAREME_DETAIL (
                              DBAR_ID_DETAILS,
                              DBAR_NB_PLACE,
                              DBAR_NB_POINT,
                              BAR_ID,
                              BL_MAJ
                          )
                          VALUES (
                              '1515',
                              '4',
                              '52',
                              '1033',
                              '1'
                          );

INSERT INTO BAREME_DETAIL (
                              DBAR_ID_DETAILS,
                              DBAR_NB_PLACE,
                              DBAR_NB_POINT,
                              BAR_ID,
                              BL_MAJ
                          )
                          VALUES (
                              '1516',
                              '14',
                              '15',
                              '1033',
                              '1'
                          );

INSERT INTO BAREME_DETAIL (
                              DBAR_ID_DETAILS,
                              DBAR_NB_PLACE,
                              DBAR_NB_POINT,
                              BAR_ID,
                              BL_MAJ
                          )
                          VALUES (
                              '1517',
                              '24',
                              '2',
                              '1033',
                              '1'
                          );

INSERT INTO BAREME_DETAIL (
                              DBAR_ID_DETAILS,
                              DBAR_NB_PLACE,
                              DBAR_NB_POINT,
                              BAR_ID,
                              BL_MAJ
                          )
                          VALUES (
                              '1518',
                              '5',
                              '42',
                              '1033',
                              '1'
                          );

INSERT INTO BAREME_DETAIL (
                              DBAR_ID_DETAILS,
                              DBAR_NB_PLACE,
                              DBAR_NB_POINT,
                              BAR_ID,
                              BL_MAJ
                          )
                          VALUES (
                              '1519',
                              '15',
                              '13',
                              '1033',
                              '1'
                          );

INSERT INTO BAREME_DETAIL (
                              DBAR_ID_DETAILS,
                              DBAR_NB_PLACE,
                              DBAR_NB_POINT,
                              BAR_ID,
                              BL_MAJ
                          )
                          VALUES (
                              '1520',
                              '6',
                              '37',
                              '1033',
                              '1'
                          );

INSERT INTO BAREME_DETAIL (
                              DBAR_ID_DETAILS,
                              DBAR_NB_PLACE,
                              DBAR_NB_POINT,
                              BAR_ID,
                              BL_MAJ
                          )
                          VALUES (
                              '1521',
                              '16',
                              '11',
                              '1033',
                              '1'
                          );

INSERT INTO BAREME_DETAIL (
                              DBAR_ID_DETAILS,
                              DBAR_NB_PLACE,
                              DBAR_NB_POINT,
                              BAR_ID,
                              BL_MAJ
                          )
                          VALUES (
                              '1522',
                              '7',
                              '32',
                              '1033',
                              '1'
                          );

INSERT INTO BAREME_DETAIL (
                              DBAR_ID_DETAILS,
                              DBAR_NB_PLACE,
                              DBAR_NB_POINT,
                              BAR_ID,
                              BL_MAJ
                          )
                          VALUES (
                              '1523',
                              '17',
                              '9',
                              '1033',
                              '1'
                          );

INSERT INTO BAREME_DETAIL (
                              DBAR_ID_DETAILS,
                              DBAR_NB_PLACE,
                              DBAR_NB_POINT,
                              BAR_ID,
                              BL_MAJ
                          )
                          VALUES (
                              '1524',
                              '8',
                              '28',
                              '1033',
                              '1'
                          );

INSERT INTO BAREME_DETAIL (
                              DBAR_ID_DETAILS,
                              DBAR_NB_PLACE,
                              DBAR_NB_POINT,
                              BAR_ID,
                              BL_MAJ
                          )
                          VALUES (
                              '1525',
                              '18',
                              '8',
                              '1033',
                              '1'
                          );

INSERT INTO BAREME_DETAIL (
                              DBAR_ID_DETAILS,
                              DBAR_NB_PLACE,
                              DBAR_NB_POINT,
                              BAR_ID,
                              BL_MAJ
                          )
                          VALUES (
                              '1526',
                              '9',
                              '25',
                              '1033',
                              '1'
                          );

INSERT INTO BAREME_DETAIL (
                              DBAR_ID_DETAILS,
                              DBAR_NB_PLACE,
                              DBAR_NB_POINT,
                              BAR_ID,
                              BL_MAJ
                          )
                          VALUES (
                              '1527',
                              '19',
                              '7',
                              '1033',
                              '1'
                          );

INSERT INTO BAREME_DETAIL (
                              DBAR_ID_DETAILS,
                              DBAR_NB_PLACE,
                              DBAR_NB_POINT,
                              BAR_ID,
                              BL_MAJ
                          )
                          VALUES (
                              '1528',
                              '10',
                              '24',
                              '1033',
                              '1'
                          );

INSERT INTO BAREME_DETAIL (
                              DBAR_ID_DETAILS,
                              DBAR_NB_PLACE,
                              DBAR_NB_POINT,
                              BAR_ID,
                              BL_MAJ
                          )
                          VALUES (
                              '1529',
                              '20',
                              '6',
                              '1033',
                              '1'
                          );

INSERT INTO BAREME_DETAIL (
                              DBAR_ID_DETAILS,
                              DBAR_NB_PLACE,
                              DBAR_NB_POINT,
                              BAR_ID,
                              BL_MAJ
                          )
                          VALUES (
                              '1530',
                              '1',
                              '100',
                              '1034',
                              '1'
                          );

INSERT INTO BAREME_DETAIL (
                              DBAR_ID_DETAILS,
                              DBAR_NB_PLACE,
                              DBAR_NB_POINT,
                              BAR_ID,
                              BL_MAJ
                          )
                          VALUES (
                              '1531',
                              '11',
                              '23',
                              '1034',
                              '1'
                          );

INSERT INTO BAREME_DETAIL (
                              DBAR_ID_DETAILS,
                              DBAR_NB_PLACE,
                              DBAR_NB_POINT,
                              BAR_ID,
                              BL_MAJ
                          )
                          VALUES (
                              '1532',
                              '21',
                              '3',
                              '1034',
                              '1'
                          );

INSERT INTO BAREME_DETAIL (
                              DBAR_ID_DETAILS,
                              DBAR_NB_PLACE,
                              DBAR_NB_POINT,
                              BAR_ID,
                              BL_MAJ
                          )
                          VALUES (
                              '1533',
                              '2',
                              '80',
                              '1034',
                              '1'
                          );

INSERT INTO BAREME_DETAIL (
                              DBAR_ID_DETAILS,
                              DBAR_NB_PLACE,
                              DBAR_NB_POINT,
                              BAR_ID,
                              BL_MAJ
                          )
                          VALUES (
                              '1534',
                              '12',
                              '22',
                              '1034',
                              '1'
                          );

INSERT INTO BAREME_DETAIL (
                              DBAR_ID_DETAILS,
                              DBAR_NB_PLACE,
                              DBAR_NB_POINT,
                              BAR_ID,
                              BL_MAJ
                          )
                          VALUES (
                              '1535',
                              '22',
                              '3',
                              '1034',
                              '1'
                          );

INSERT INTO BAREME_DETAIL (
                              DBAR_ID_DETAILS,
                              DBAR_NB_PLACE,
                              DBAR_NB_POINT,
                              BAR_ID,
                              BL_MAJ
                          )
                          VALUES (
                              '1536',
                              '3',
                              '65',
                              '1034',
                              '1'
                          );

INSERT INTO BAREME_DETAIL (
                              DBAR_ID_DETAILS,
                              DBAR_NB_PLACE,
                              DBAR_NB_POINT,
                              BAR_ID,
                              BL_MAJ
                          )
                          VALUES (
                              '1537',
                              '13',
                              '17',
                              '1034',
                              '1'
                          );

INSERT INTO BAREME_DETAIL (
                              DBAR_ID_DETAILS,
                              DBAR_NB_PLACE,
                              DBAR_NB_POINT,
                              BAR_ID,
                              BL_MAJ
                          )
                          VALUES (
                              '1538',
                              '23',
                              '3',
                              '1034',
                              '1'
                          );

INSERT INTO BAREME_DETAIL (
                              DBAR_ID_DETAILS,
                              DBAR_NB_PLACE,
                              DBAR_NB_POINT,
                              BAR_ID,
                              BL_MAJ
                          )
                          VALUES (
                              '1539',
                              '4',
                              '52',
                              '1034',
                              '1'
                          );

INSERT INTO BAREME_DETAIL (
                              DBAR_ID_DETAILS,
                              DBAR_NB_PLACE,
                              DBAR_NB_POINT,
                              BAR_ID,
                              BL_MAJ
                          )
                          VALUES (
                              '1540',
                              '14',
                              '15',
                              '1034',
                              '1'
                          );

INSERT INTO BAREME_DETAIL (
                              DBAR_ID_DETAILS,
                              DBAR_NB_PLACE,
                              DBAR_NB_POINT,
                              BAR_ID,
                              BL_MAJ
                          )
                          VALUES (
                              '1541',
                              '24',
                              '3',
                              '1034',
                              '1'
                          );

INSERT INTO BAREME_DETAIL (
                              DBAR_ID_DETAILS,
                              DBAR_NB_PLACE,
                              DBAR_NB_POINT,
                              BAR_ID,
                              BL_MAJ
                          )
                          VALUES (
                              '1542',
                              '5',
                              '32',
                              '1034',
                              '1'
                          );

INSERT INTO BAREME_DETAIL (
                              DBAR_ID_DETAILS,
                              DBAR_NB_PLACE,
                              DBAR_NB_POINT,
                              BAR_ID,
                              BL_MAJ
                          )
                          VALUES (
                              '1543',
                              '15',
                              '13',
                              '1034',
                              '1'
                          );

INSERT INTO BAREME_DETAIL (
                              DBAR_ID_DETAILS,
                              DBAR_NB_PLACE,
                              DBAR_NB_POINT,
                              BAR_ID,
                              BL_MAJ
                          )
                          VALUES (
                              '1544',
                              '6',
                              '32',
                              '1034',
                              '1'
                          );

INSERT INTO BAREME_DETAIL (
                              DBAR_ID_DETAILS,
                              DBAR_NB_PLACE,
                              DBAR_NB_POINT,
                              BAR_ID,
                              BL_MAJ
                          )
                          VALUES (
                              '1545',
                              '16',
                              '11',
                              '1034',
                              '1'
                          );

INSERT INTO BAREME_DETAIL (
                              DBAR_ID_DETAILS,
                              DBAR_NB_PLACE,
                              DBAR_NB_POINT,
                              BAR_ID,
                              BL_MAJ
                          )
                          VALUES (
                              '1546',
                              '7',
                              '32',
                              '1034',
                              '1'
                          );

INSERT INTO BAREME_DETAIL (
                              DBAR_ID_DETAILS,
                              DBAR_NB_PLACE,
                              DBAR_NB_POINT,
                              BAR_ID,
                              BL_MAJ
                          )
                          VALUES (
                              '1547',
                              '17',
                              '9',
                              '1034',
                              '1'
                          );

INSERT INTO BAREME_DETAIL (
                              DBAR_ID_DETAILS,
                              DBAR_NB_PLACE,
                              DBAR_NB_POINT,
                              BAR_ID,
                              BL_MAJ
                          )
                          VALUES (
                              '1548',
                              '8',
                              '32',
                              '1034',
                              '1'
                          );

INSERT INTO BAREME_DETAIL (
                              DBAR_ID_DETAILS,
                              DBAR_NB_PLACE,
                              DBAR_NB_POINT,
                              BAR_ID,
                              BL_MAJ
                          )
                          VALUES (
                              '1549',
                              '18',
                              '8',
                              '1034',
                              '1'
                          );

INSERT INTO BAREME_DETAIL (
                              DBAR_ID_DETAILS,
                              DBAR_NB_PLACE,
                              DBAR_NB_POINT,
                              BAR_ID,
                              BL_MAJ
                          )
                          VALUES (
                              '1550',
                              '9',
                              '25',
                              '1034',
                              '1'
                          );

INSERT INTO BAREME_DETAIL (
                              DBAR_ID_DETAILS,
                              DBAR_NB_PLACE,
                              DBAR_NB_POINT,
                              BAR_ID,
                              BL_MAJ
                          )
                          VALUES (
                              '1551',
                              '19',
                              '7',
                              '1034',
                              '1'
                          );

INSERT INTO BAREME_DETAIL (
                              DBAR_ID_DETAILS,
                              DBAR_NB_PLACE,
                              DBAR_NB_POINT,
                              BAR_ID,
                              BL_MAJ
                          )
                          VALUES (
                              '1552',
                              '10',
                              '24',
                              '1034',
                              '1'
                          );

INSERT INTO BAREME_DETAIL (
                              DBAR_ID_DETAILS,
                              DBAR_NB_PLACE,
                              DBAR_NB_POINT,
                              BAR_ID,
                              BL_MAJ
                          )
                          VALUES (
                              '1553',
                              '20',
                              '6',
                              '1034',
                              '1'
                          );

INSERT INTO BAREME_DETAIL (
                              DBAR_ID_DETAILS,
                              DBAR_NB_PLACE,
                              DBAR_NB_POINT,
                              BAR_ID,
                              BL_MAJ
                          )
                          VALUES (
                              '3881',
                              '1',
                              '100',
                              '3060',
                              '1'
                          );

INSERT INTO BAREME_DETAIL (
                              DBAR_ID_DETAILS,
                              DBAR_NB_PLACE,
                              DBAR_NB_POINT,
                              BAR_ID,
                              BL_MAJ
                          )
                          VALUES (
                              '3882',
                              '11',
                              '23',
                              '3060',
                              '1'
                          );

INSERT INTO BAREME_DETAIL (
                              DBAR_ID_DETAILS,
                              DBAR_NB_PLACE,
                              DBAR_NB_POINT,
                              BAR_ID,
                              BL_MAJ
                          )
                          VALUES (
                              '3883',
                              '21',
                              '5',
                              '3060',
                              '1'
                          );

INSERT INTO BAREME_DETAIL (
                              DBAR_ID_DETAILS,
                              DBAR_NB_PLACE,
                              DBAR_NB_POINT,
                              BAR_ID,
                              BL_MAJ
                          )
                          VALUES (
                              '3884',
                              '2',
                              '80',
                              '3060',
                              '1'
                          );

INSERT INTO BAREME_DETAIL (
                              DBAR_ID_DETAILS,
                              DBAR_NB_PLACE,
                              DBAR_NB_POINT,
                              BAR_ID,
                              BL_MAJ
                          )
                          VALUES (
                              '3885',
                              '12',
                              '22',
                              '3060',
                              '1'
                          );

INSERT INTO BAREME_DETAIL (
                              DBAR_ID_DETAILS,
                              DBAR_NB_PLACE,
                              DBAR_NB_POINT,
                              BAR_ID,
                              BL_MAJ
                          )
                          VALUES (
                              '3886',
                              '22',
                              '4',
                              '3060',
                              '1'
                          );

INSERT INTO BAREME_DETAIL (
                              DBAR_ID_DETAILS,
                              DBAR_NB_PLACE,
                              DBAR_NB_POINT,
                              BAR_ID,
                              BL_MAJ
                          )
                          VALUES (
                              '3887',
                              '3',
                              '65',
                              '3060',
                              '1'
                          );

INSERT INTO BAREME_DETAIL (
                              DBAR_ID_DETAILS,
                              DBAR_NB_PLACE,
                              DBAR_NB_POINT,
                              BAR_ID,
                              BL_MAJ
                          )
                          VALUES (
                              '3888',
                              '13',
                              '17',
                              '3060',
                              '1'
                          );

INSERT INTO BAREME_DETAIL (
                              DBAR_ID_DETAILS,
                              DBAR_NB_PLACE,
                              DBAR_NB_POINT,
                              BAR_ID,
                              BL_MAJ
                          )
                          VALUES (
                              '3889',
                              '23',
                              '3',
                              '3060',
                              '1'
                          );

INSERT INTO BAREME_DETAIL (
                              DBAR_ID_DETAILS,
                              DBAR_NB_PLACE,
                              DBAR_NB_POINT,
                              BAR_ID,
                              BL_MAJ
                          )
                          VALUES (
                              '3890',
                              '4',
                              '52',
                              '3060',
                              '1'
                          );

INSERT INTO BAREME_DETAIL (
                              DBAR_ID_DETAILS,
                              DBAR_NB_PLACE,
                              DBAR_NB_POINT,
                              BAR_ID,
                              BL_MAJ
                          )
                          VALUES (
                              '3891',
                              '14',
                              '15',
                              '3060',
                              '1'
                          );

INSERT INTO BAREME_DETAIL (
                              DBAR_ID_DETAILS,
                              DBAR_NB_PLACE,
                              DBAR_NB_POINT,
                              BAR_ID,
                              BL_MAJ
                          )
                          VALUES (
                              '3892',
                              '24',
                              '2',
                              '3060',
                              '1'
                          );

INSERT INTO BAREME_DETAIL (
                              DBAR_ID_DETAILS,
                              DBAR_NB_PLACE,
                              DBAR_NB_POINT,
                              BAR_ID,
                              BL_MAJ
                          )
                          VALUES (
                              '3893',
                              '5',
                              '42',
                              '3060',
                              '1'
                          );

INSERT INTO BAREME_DETAIL (
                              DBAR_ID_DETAILS,
                              DBAR_NB_PLACE,
                              DBAR_NB_POINT,
                              BAR_ID,
                              BL_MAJ
                          )
                          VALUES (
                              '3894',
                              '15',
                              '13',
                              '3060',
                              '1'
                          );

INSERT INTO BAREME_DETAIL (
                              DBAR_ID_DETAILS,
                              DBAR_NB_PLACE,
                              DBAR_NB_POINT,
                              BAR_ID,
                              BL_MAJ
                          )
                          VALUES (
                              '3895',
                              '6',
                              '37',
                              '3060',
                              '1'
                          );

INSERT INTO BAREME_DETAIL (
                              DBAR_ID_DETAILS,
                              DBAR_NB_PLACE,
                              DBAR_NB_POINT,
                              BAR_ID,
                              BL_MAJ
                          )
                          VALUES (
                              '3896',
                              '16',
                              '11',
                              '3060',
                              '1'
                          );

INSERT INTO BAREME_DETAIL (
                              DBAR_ID_DETAILS,
                              DBAR_NB_PLACE,
                              DBAR_NB_POINT,
                              BAR_ID,
                              BL_MAJ
                          )
                          VALUES (
                              '3897',
                              '7',
                              '32',
                              '3060',
                              '1'
                          );

INSERT INTO BAREME_DETAIL (
                              DBAR_ID_DETAILS,
                              DBAR_NB_PLACE,
                              DBAR_NB_POINT,
                              BAR_ID,
                              BL_MAJ
                          )
                          VALUES (
                              '3898',
                              '17',
                              '9',
                              '3060',
                              '1'
                          );

INSERT INTO BAREME_DETAIL (
                              DBAR_ID_DETAILS,
                              DBAR_NB_PLACE,
                              DBAR_NB_POINT,
                              BAR_ID,
                              BL_MAJ
                          )
                          VALUES (
                              '3899',
                              '8',
                              '28',
                              '3060',
                              '1'
                          );

INSERT INTO BAREME_DETAIL (
                              DBAR_ID_DETAILS,
                              DBAR_NB_PLACE,
                              DBAR_NB_POINT,
                              BAR_ID,
                              BL_MAJ
                          )
                          VALUES (
                              '3900',
                              '18',
                              '8',
                              '3060',
                              '1'
                          );

INSERT INTO BAREME_DETAIL (
                              DBAR_ID_DETAILS,
                              DBAR_NB_PLACE,
                              DBAR_NB_POINT,
                              BAR_ID,
                              BL_MAJ
                          )
                          VALUES (
                              '3901',
                              '9',
                              '25',
                              '3060',
                              '1'
                          );

INSERT INTO BAREME_DETAIL (
                              DBAR_ID_DETAILS,
                              DBAR_NB_PLACE,
                              DBAR_NB_POINT,
                              BAR_ID,
                              BL_MAJ
                          )
                          VALUES (
                              '3902',
                              '19',
                              '7',
                              '3060',
                              '1'
                          );

INSERT INTO BAREME_DETAIL (
                              DBAR_ID_DETAILS,
                              DBAR_NB_PLACE,
                              DBAR_NB_POINT,
                              BAR_ID,
                              BL_MAJ
                          )
                          VALUES (
                              '3903',
                              '10',
                              '24',
                              '3060',
                              '1'
                          );

INSERT INTO BAREME_DETAIL (
                              DBAR_ID_DETAILS,
                              DBAR_NB_PLACE,
                              DBAR_NB_POINT,
                              BAR_ID,
                              BL_MAJ
                          )
                          VALUES (
                              '3904',
                              '20',
                              '6',
                              '3060',
                              '1'
                          );

INSERT INTO BAREME_DETAIL (
                              DBAR_ID_DETAILS,
                              DBAR_NB_PLACE,
                              DBAR_NB_POINT,
                              BAR_ID,
                              BL_MAJ
                          )
                          VALUES (
                              '3861',
                              '1',
                              '100',
                              '3059',
                              '1'
                          );

INSERT INTO BAREME_DETAIL (
                              DBAR_ID_DETAILS,
                              DBAR_NB_PLACE,
                              DBAR_NB_POINT,
                              BAR_ID,
                              BL_MAJ
                          )
                          VALUES (
                              '3862',
                              '11',
                              '17',
                              '3059',
                              '1'
                          );

INSERT INTO BAREME_DETAIL (
                              DBAR_ID_DETAILS,
                              DBAR_NB_PLACE,
                              DBAR_NB_POINT,
                              BAR_ID,
                              BL_MAJ
                          )
                          VALUES (
                              '3863',
                              '2',
                              '80',
                              '3059',
                              '1'
                          );

INSERT INTO BAREME_DETAIL (
                              DBAR_ID_DETAILS,
                              DBAR_NB_PLACE,
                              DBAR_NB_POINT,
                              BAR_ID,
                              BL_MAJ
                          )
                          VALUES (
                              '3864',
                              '12',
                              '15',
                              '3059',
                              '1'
                          );

INSERT INTO BAREME_DETAIL (
                              DBAR_ID_DETAILS,
                              DBAR_NB_PLACE,
                              DBAR_NB_POINT,
                              BAR_ID,
                              BL_MAJ
                          )
                          VALUES (
                              '3865',
                              '3',
                              '65',
                              '3059',
                              '1'
                          );

INSERT INTO BAREME_DETAIL (
                              DBAR_ID_DETAILS,
                              DBAR_NB_PLACE,
                              DBAR_NB_POINT,
                              BAR_ID,
                              BL_MAJ
                          )
                          VALUES (
                              '3866',
                              '13',
                              '13',
                              '3059',
                              '1'
                          );

INSERT INTO BAREME_DETAIL (
                              DBAR_ID_DETAILS,
                              DBAR_NB_PLACE,
                              DBAR_NB_POINT,
                              BAR_ID,
                              BL_MAJ
                          )
                          VALUES (
                              '3867',
                              '4',
                              '50',
                              '3059',
                              '1'
                          );

INSERT INTO BAREME_DETAIL (
                              DBAR_ID_DETAILS,
                              DBAR_NB_PLACE,
                              DBAR_NB_POINT,
                              BAR_ID,
                              BL_MAJ
                          )
                          VALUES (
                              '3868',
                              '14',
                              '11',
                              '3059',
                              '1'
                          );

INSERT INTO BAREME_DETAIL (
                              DBAR_ID_DETAILS,
                              DBAR_NB_PLACE,
                              DBAR_NB_POINT,
                              BAR_ID,
                              BL_MAJ
                          )
                          VALUES (
                              '3869',
                              '5',
                              '40',
                              '3059',
                              '1'
                          );

INSERT INTO BAREME_DETAIL (
                              DBAR_ID_DETAILS,
                              DBAR_NB_PLACE,
                              DBAR_NB_POINT,
                              BAR_ID,
                              BL_MAJ
                          )
                          VALUES (
                              '3870',
                              '15',
                              '9',
                              '3059',
                              '1'
                          );

INSERT INTO BAREME_DETAIL (
                              DBAR_ID_DETAILS,
                              DBAR_NB_PLACE,
                              DBAR_NB_POINT,
                              BAR_ID,
                              BL_MAJ
                          )
                          VALUES (
                              '3871',
                              '6',
                              '35',
                              '3059',
                              '1'
                          );

INSERT INTO BAREME_DETAIL (
                              DBAR_ID_DETAILS,
                              DBAR_NB_PLACE,
                              DBAR_NB_POINT,
                              BAR_ID,
                              BL_MAJ
                          )
                          VALUES (
                              '3872',
                              '16',
                              '7',
                              '3059',
                              '1'
                          );

INSERT INTO BAREME_DETAIL (
                              DBAR_ID_DETAILS,
                              DBAR_NB_PLACE,
                              DBAR_NB_POINT,
                              BAR_ID,
                              BL_MAJ
                          )
                          VALUES (
                              '3873',
                              '7',
                              '30',
                              '3059',
                              '1'
                          );

INSERT INTO BAREME_DETAIL (
                              DBAR_ID_DETAILS,
                              DBAR_NB_PLACE,
                              DBAR_NB_POINT,
                              BAR_ID,
                              BL_MAJ
                          )
                          VALUES (
                              '3874',
                              '17',
                              '5',
                              '3059',
                              '1'
                          );

INSERT INTO BAREME_DETAIL (
                              DBAR_ID_DETAILS,
                              DBAR_NB_PLACE,
                              DBAR_NB_POINT,
                              BAR_ID,
                              BL_MAJ
                          )
                          VALUES (
                              '3875',
                              '8',
                              '25',
                              '3059',
                              '1'
                          );

INSERT INTO BAREME_DETAIL (
                              DBAR_ID_DETAILS,
                              DBAR_NB_PLACE,
                              DBAR_NB_POINT,
                              BAR_ID,
                              BL_MAJ
                          )
                          VALUES (
                              '3876',
                              '18',
                              '4',
                              '3059',
                              '1'
                          );

INSERT INTO BAREME_DETAIL (
                              DBAR_ID_DETAILS,
                              DBAR_NB_PLACE,
                              DBAR_NB_POINT,
                              BAR_ID,
                              BL_MAJ
                          )
                          VALUES (
                              '3877',
                              '9',
                              '22',
                              '3059',
                              '1'
                          );

INSERT INTO BAREME_DETAIL (
                              DBAR_ID_DETAILS,
                              DBAR_NB_PLACE,
                              DBAR_NB_POINT,
                              BAR_ID,
                              BL_MAJ
                          )
                          VALUES (
                              '3878',
                              '19',
                              '3',
                              '3059',
                              '1'
                          );

INSERT INTO BAREME_DETAIL (
                              DBAR_ID_DETAILS,
                              DBAR_NB_PLACE,
                              DBAR_NB_POINT,
                              BAR_ID,
                              BL_MAJ
                          )
                          VALUES (
                              '3879',
                              '10',
                              '19',
                              '3059',
                              '1'
                          );

INSERT INTO BAREME_DETAIL (
                              DBAR_ID_DETAILS,
                              DBAR_NB_PLACE,
                              DBAR_NB_POINT,
                              BAR_ID,
                              BL_MAJ
                          )
                          VALUES (
                              '3880',
                              '20',
                              '2',
                              '3059',
                              '1'
                          );

INSERT INTO BAREME_DETAIL (
                              DBAR_ID_DETAILS,
                              DBAR_NB_PLACE,
                              DBAR_NB_POINT,
                              BAR_ID,
                              BL_MAJ
                          )
                          VALUES (
                              '3905',
                              '1',
                              '100',
                              '3061',
                              '1'
                          );

INSERT INTO BAREME_DETAIL (
                              DBAR_ID_DETAILS,
                              DBAR_NB_PLACE,
                              DBAR_NB_POINT,
                              BAR_ID,
                              BL_MAJ
                          )
                          VALUES (
                              '3906',
                              '11',
                              '31',
                              '3061',
                              '1'
                          );

INSERT INTO BAREME_DETAIL (
                              DBAR_ID_DETAILS,
                              DBAR_NB_PLACE,
                              DBAR_NB_POINT,
                              BAR_ID,
                              BL_MAJ
                          )
                          VALUES (
                              '3907',
                              '21',
                              '13',
                              '3061',
                              '1'
                          );

INSERT INTO BAREME_DETAIL (
                              DBAR_ID_DETAILS,
                              DBAR_NB_PLACE,
                              DBAR_NB_POINT,
                              BAR_ID,
                              BL_MAJ
                          )
                          VALUES (
                              '3908',
                              '31',
                              '3',
                              '3061',
                              '1'
                          );

INSERT INTO BAREME_DETAIL (
                              DBAR_ID_DETAILS,
                              DBAR_NB_PLACE,
                              DBAR_NB_POINT,
                              BAR_ID,
                              BL_MAJ
                          )
                          VALUES (
                              '3909',
                              '2',
                              '80',
                              '3061',
                              '1'
                          );

INSERT INTO BAREME_DETAIL (
                              DBAR_ID_DETAILS,
                              DBAR_NB_PLACE,
                              DBAR_NB_POINT,
                              BAR_ID,
                              BL_MAJ
                          )
                          VALUES (
                              '3910',
                              '12',
                              '30',
                              '3061',
                              '1'
                          );

INSERT INTO BAREME_DETAIL (
                              DBAR_ID_DETAILS,
                              DBAR_NB_PLACE,
                              DBAR_NB_POINT,
                              BAR_ID,
                              BL_MAJ
                          )
                          VALUES (
                              '3911',
                              '22',
                              '12',
                              '3061',
                              '1'
                          );

INSERT INTO BAREME_DETAIL (
                              DBAR_ID_DETAILS,
                              DBAR_NB_PLACE,
                              DBAR_NB_POINT,
                              BAR_ID,
                              BL_MAJ
                          )
                          VALUES (
                              '3912',
                              '32',
                              '2',
                              '3061',
                              '1'
                          );

INSERT INTO BAREME_DETAIL (
                              DBAR_ID_DETAILS,
                              DBAR_NB_PLACE,
                              DBAR_NB_POINT,
                              BAR_ID,
                              BL_MAJ
                          )
                          VALUES (
                              '3913',
                              '3',
                              '65',
                              '3061',
                              '1'
                          );

INSERT INTO BAREME_DETAIL (
                              DBAR_ID_DETAILS,
                              DBAR_NB_PLACE,
                              DBAR_NB_POINT,
                              BAR_ID,
                              BL_MAJ
                          )
                          VALUES (
                              '3914',
                              '13',
                              '29',
                              '3061',
                              '1'
                          );

INSERT INTO BAREME_DETAIL (
                              DBAR_ID_DETAILS,
                              DBAR_NB_PLACE,
                              DBAR_NB_POINT,
                              BAR_ID,
                              BL_MAJ
                          )
                          VALUES (
                              '3915',
                              '23',
                              '11',
                              '3061',
                              '1'
                          );

INSERT INTO BAREME_DETAIL (
                              DBAR_ID_DETAILS,
                              DBAR_NB_PLACE,
                              DBAR_NB_POINT,
                              BAR_ID,
                              BL_MAJ
                          )
                          VALUES (
                              '3916',
                              '4',
                              '55',
                              '3061',
                              '1'
                          );

INSERT INTO BAREME_DETAIL (
                              DBAR_ID_DETAILS,
                              DBAR_NB_PLACE,
                              DBAR_NB_POINT,
                              BAR_ID,
                              BL_MAJ
                          )
                          VALUES (
                              '3917',
                              '14',
                              '28',
                              '3061',
                              '1'
                          );

INSERT INTO BAREME_DETAIL (
                              DBAR_ID_DETAILS,
                              DBAR_NB_PLACE,
                              DBAR_NB_POINT,
                              BAR_ID,
                              BL_MAJ
                          )
                          VALUES (
                              '3918',
                              '24',
                              '10',
                              '3061',
                              '1'
                          );

INSERT INTO BAREME_DETAIL (
                              DBAR_ID_DETAILS,
                              DBAR_NB_PLACE,
                              DBAR_NB_POINT,
                              BAR_ID,
                              BL_MAJ
                          )
                          VALUES (
                              '3919',
                              '5',
                              '45',
                              '3061',
                              '1'
                          );

INSERT INTO BAREME_DETAIL (
                              DBAR_ID_DETAILS,
                              DBAR_NB_PLACE,
                              DBAR_NB_POINT,
                              BAR_ID,
                              BL_MAJ
                          )
                          VALUES (
                              '3920',
                              '15',
                              '27',
                              '3061',
                              '1'
                          );

INSERT INTO BAREME_DETAIL (
                              DBAR_ID_DETAILS,
                              DBAR_NB_PLACE,
                              DBAR_NB_POINT,
                              BAR_ID,
                              BL_MAJ
                          )
                          VALUES (
                              '3921',
                              '25',
                              '9',
                              '3061',
                              '1'
                          );

INSERT INTO BAREME_DETAIL (
                              DBAR_ID_DETAILS,
                              DBAR_NB_PLACE,
                              DBAR_NB_POINT,
                              BAR_ID,
                              BL_MAJ
                          )
                          VALUES (
                              '3922',
                              '6',
                              '40',
                              '3061',
                              '1'
                          );

INSERT INTO BAREME_DETAIL (
                              DBAR_ID_DETAILS,
                              DBAR_NB_PLACE,
                              DBAR_NB_POINT,
                              BAR_ID,
                              BL_MAJ
                          )
                          VALUES (
                              '3923',
                              '16',
                              '26',
                              '3061',
                              '1'
                          );

INSERT INTO BAREME_DETAIL (
                              DBAR_ID_DETAILS,
                              DBAR_NB_PLACE,
                              DBAR_NB_POINT,
                              BAR_ID,
                              BL_MAJ
                          )
                          VALUES (
                              '3924',
                              '26',
                              '8',
                              '3061',
                              '1'
                          );

INSERT INTO BAREME_DETAIL (
                              DBAR_ID_DETAILS,
                              DBAR_NB_PLACE,
                              DBAR_NB_POINT,
                              BAR_ID,
                              BL_MAJ
                          )
                          VALUES (
                              '3925',
                              '7',
                              '37',
                              '3061',
                              '1'
                          );

INSERT INTO BAREME_DETAIL (
                              DBAR_ID_DETAILS,
                              DBAR_NB_PLACE,
                              DBAR_NB_POINT,
                              BAR_ID,
                              BL_MAJ
                          )
                          VALUES (
                              '3926',
                              '17',
                              '23',
                              '3061',
                              '1'
                          );

INSERT INTO BAREME_DETAIL (
                              DBAR_ID_DETAILS,
                              DBAR_NB_PLACE,
                              DBAR_NB_POINT,
                              BAR_ID,
                              BL_MAJ
                          )
                          VALUES (
                              '3927',
                              '27',
                              '7',
                              '3061',
                              '1'
                          );

INSERT INTO BAREME_DETAIL (
                              DBAR_ID_DETAILS,
                              DBAR_NB_PLACE,
                              DBAR_NB_POINT,
                              BAR_ID,
                              BL_MAJ
                          )
                          VALUES (
                              '3928',
                              '8',
                              '35',
                              '3061',
                              '1'
                          );

INSERT INTO BAREME_DETAIL (
                              DBAR_ID_DETAILS,
                              DBAR_NB_PLACE,
                              DBAR_NB_POINT,
                              BAR_ID,
                              BL_MAJ
                          )
                          VALUES (
                              '3929',
                              '18',
                              '20',
                              '3061',
                              '1'
                          );

INSERT INTO BAREME_DETAIL (
                              DBAR_ID_DETAILS,
                              DBAR_NB_PLACE,
                              DBAR_NB_POINT,
                              BAR_ID,
                              BL_MAJ
                          )
                          VALUES (
                              '3930',
                              '28',
                              '6',
                              '3061',
                              '1'
                          );

INSERT INTO BAREME_DETAIL (
                              DBAR_ID_DETAILS,
                              DBAR_NB_PLACE,
                              DBAR_NB_POINT,
                              BAR_ID,
                              BL_MAJ
                          )
                          VALUES (
                              '3931',
                              '9',
                              '33',
                              '3061',
                              '1'
                          );

INSERT INTO BAREME_DETAIL (
                              DBAR_ID_DETAILS,
                              DBAR_NB_PLACE,
                              DBAR_NB_POINT,
                              BAR_ID,
                              BL_MAJ
                          )
                          VALUES (
                              '3932',
                              '19',
                              '17',
                              '3061',
                              '1'
                          );

INSERT INTO BAREME_DETAIL (
                              DBAR_ID_DETAILS,
                              DBAR_NB_PLACE,
                              DBAR_NB_POINT,
                              BAR_ID,
                              BL_MAJ
                          )
                          VALUES (
                              '3933',
                              '29',
                              '5',
                              '3061',
                              '1'
                          );

INSERT INTO BAREME_DETAIL (
                              DBAR_ID_DETAILS,
                              DBAR_NB_PLACE,
                              DBAR_NB_POINT,
                              BAR_ID,
                              BL_MAJ
                          )
                          VALUES (
                              '3934',
                              '10',
                              '32',
                              '3061',
                              '1'
                          );

INSERT INTO BAREME_DETAIL (
                              DBAR_ID_DETAILS,
                              DBAR_NB_PLACE,
                              DBAR_NB_POINT,
                              BAR_ID,
                              BL_MAJ
                          )
                          VALUES (
                              '3935',
                              '20',
                              '15',
                              '3061',
                              '1'
                          );

INSERT INTO BAREME_DETAIL (
                              DBAR_ID_DETAILS,
                              DBAR_NB_PLACE,
                              DBAR_NB_POINT,
                              BAR_ID,
                              BL_MAJ
                          )
                          VALUES (
                              '3936',
                              '30',
                              '4',
                              '3061',
                              '1'
                          );

INSERT INTO BAREME_DETAIL (
                              DBAR_ID_DETAILS,
                              DBAR_NB_PLACE,
                              DBAR_NB_POINT,
                              BAR_ID,
                              BL_MAJ
                          )
                          VALUES (
                              '3937',
                              '1',
                              '100',
                              '3062',
                              '1'
                          );

INSERT INTO BAREME_DETAIL (
                              DBAR_ID_DETAILS,
                              DBAR_NB_PLACE,
                              DBAR_NB_POINT,
                              BAR_ID,
                              BL_MAJ
                          )
                          VALUES (
                              '3938',
                              '11',
                              '36',
                              '3062',
                              '1'
                          );

INSERT INTO BAREME_DETAIL (
                              DBAR_ID_DETAILS,
                              DBAR_NB_PLACE,
                              DBAR_NB_POINT,
                              BAR_ID,
                              BL_MAJ
                          )
                          VALUES (
                              '3939',
                              '21',
                              '26',
                              '3062',
                              '1'
                          );

INSERT INTO BAREME_DETAIL (
                              DBAR_ID_DETAILS,
                              DBAR_NB_PLACE,
                              DBAR_NB_POINT,
                              BAR_ID,
                              BL_MAJ
                          )
                          VALUES (
                              '3940',
                              '31',
                              '12',
                              '3062',
                              '1'
                          );

INSERT INTO BAREME_DETAIL (
                              DBAR_ID_DETAILS,
                              DBAR_NB_PLACE,
                              DBAR_NB_POINT,
                              BAR_ID,
                              BL_MAJ
                          )
                          VALUES (
                              '3941',
                              '41',
                              '2',
                              '3062',
                              '1'
                          );

INSERT INTO BAREME_DETAIL (
                              DBAR_ID_DETAILS,
                              DBAR_NB_PLACE,
                              DBAR_NB_POINT,
                              BAR_ID,
                              BL_MAJ
                          )
                          VALUES (
                              '3942',
                              '2',
                              '85',
                              '3062',
                              '1'
                          );

INSERT INTO BAREME_DETAIL (
                              DBAR_ID_DETAILS,
                              DBAR_NB_PLACE,
                              DBAR_NB_POINT,
                              BAR_ID,
                              BL_MAJ
                          )
                          VALUES (
                              '3943',
                              '12',
                              '35',
                              '3062',
                              '1'
                          );

INSERT INTO BAREME_DETAIL (
                              DBAR_ID_DETAILS,
                              DBAR_NB_PLACE,
                              DBAR_NB_POINT,
                              BAR_ID,
                              BL_MAJ
                          )
                          VALUES (
                              '3944',
                              '22',
                              '25',
                              '3062',
                              '1'
                          );

INSERT INTO BAREME_DETAIL (
                              DBAR_ID_DETAILS,
                              DBAR_NB_PLACE,
                              DBAR_NB_POINT,
                              BAR_ID,
                              BL_MAJ
                          )
                          VALUES (
                              '3945',
                              '32',
                              '11',
                              '3062',
                              '1'
                          );

INSERT INTO BAREME_DETAIL (
                              DBAR_ID_DETAILS,
                              DBAR_NB_PLACE,
                              DBAR_NB_POINT,
                              BAR_ID,
                              BL_MAJ
                          )
                          VALUES (
                              '3946',
                              '42',
                              '2',
                              '3062',
                              '1'
                          );

INSERT INTO BAREME_DETAIL (
                              DBAR_ID_DETAILS,
                              DBAR_NB_PLACE,
                              DBAR_NB_POINT,
                              BAR_ID,
                              BL_MAJ
                          )
                          VALUES (
                              '3947',
                              '3',
                              '70',
                              '3062',
                              '1'
                          );

INSERT INTO BAREME_DETAIL (
                              DBAR_ID_DETAILS,
                              DBAR_NB_PLACE,
                              DBAR_NB_POINT,
                              BAR_ID,
                              BL_MAJ
                          )
                          VALUES (
                              '3948',
                              '13',
                              '34',
                              '3062',
                              '1'
                          );

INSERT INTO BAREME_DETAIL (
                              DBAR_ID_DETAILS,
                              DBAR_NB_PLACE,
                              DBAR_NB_POINT,
                              BAR_ID,
                              BL_MAJ
                          )
                          VALUES (
                              '3949',
                              '23',
                              '24',
                              '3062',
                              '1'
                          );

INSERT INTO BAREME_DETAIL (
                              DBAR_ID_DETAILS,
                              DBAR_NB_PLACE,
                              DBAR_NB_POINT,
                              BAR_ID,
                              BL_MAJ
                          )
                          VALUES (
                              '3950',
                              '33',
                              '10',
                              '3062',
                              '1'
                          );

INSERT INTO BAREME_DETAIL (
                              DBAR_ID_DETAILS,
                              DBAR_NB_PLACE,
                              DBAR_NB_POINT,
                              BAR_ID,
                              BL_MAJ
                          )
                          VALUES (
                              '3951',
                              '43',
                              '2',
                              '3062',
                              '1'
                          );

INSERT INTO BAREME_DETAIL (
                              DBAR_ID_DETAILS,
                              DBAR_NB_PLACE,
                              DBAR_NB_POINT,
                              BAR_ID,
                              BL_MAJ
                          )
                          VALUES (
                              '3952',
                              '4',
                              '60',
                              '3062',
                              '1'
                          );

INSERT INTO BAREME_DETAIL (
                              DBAR_ID_DETAILS,
                              DBAR_NB_PLACE,
                              DBAR_NB_POINT,
                              BAR_ID,
                              BL_MAJ
                          )
                          VALUES (
                              '3953',
                              '14',
                              '33',
                              '3062',
                              '1'
                          );

INSERT INTO BAREME_DETAIL (
                              DBAR_ID_DETAILS,
                              DBAR_NB_PLACE,
                              DBAR_NB_POINT,
                              BAR_ID,
                              BL_MAJ
                          )
                          VALUES (
                              '3954',
                              '24',
                              '23',
                              '3062',
                              '1'
                          );

INSERT INTO BAREME_DETAIL (
                              DBAR_ID_DETAILS,
                              DBAR_NB_PLACE,
                              DBAR_NB_POINT,
                              BAR_ID,
                              BL_MAJ
                          )
                          VALUES (
                              '3955',
                              '34',
                              '9',
                              '3062',
                              '1'
                          );

INSERT INTO BAREME_DETAIL (
                              DBAR_ID_DETAILS,
                              DBAR_NB_PLACE,
                              DBAR_NB_POINT,
                              BAR_ID,
                              BL_MAJ
                          )
                          VALUES (
                              '3956',
                              '44',
                              '2',
                              '3062',
                              '1'
                          );

INSERT INTO BAREME_DETAIL (
                              DBAR_ID_DETAILS,
                              DBAR_NB_PLACE,
                              DBAR_NB_POINT,
                              BAR_ID,
                              BL_MAJ
                          )
                          VALUES (
                              '3957',
                              '5',
                              '54',
                              '3062',
                              '1'
                          );

INSERT INTO BAREME_DETAIL (
                              DBAR_ID_DETAILS,
                              DBAR_NB_PLACE,
                              DBAR_NB_POINT,
                              BAR_ID,
                              BL_MAJ
                          )
                          VALUES (
                              '3958',
                              '15',
                              '32',
                              '3062',
                              '1'
                          );

INSERT INTO BAREME_DETAIL (
                              DBAR_ID_DETAILS,
                              DBAR_NB_PLACE,
                              DBAR_NB_POINT,
                              BAR_ID,
                              BL_MAJ
                          )
                          VALUES (
                              '3959',
                              '25',
                              '18',
                              '3062',
                              '1'
                          );

INSERT INTO BAREME_DETAIL (
                              DBAR_ID_DETAILS,
                              DBAR_NB_PLACE,
                              DBAR_NB_POINT,
                              BAR_ID,
                              BL_MAJ
                          )
                          VALUES (
                              '3960',
                              '35',
                              '8',
                              '3062',
                              '1'
                          );

INSERT INTO BAREME_DETAIL (
                              DBAR_ID_DETAILS,
                              DBAR_NB_PLACE,
                              DBAR_NB_POINT,
                              BAR_ID,
                              BL_MAJ
                          )
                          VALUES (
                              '3961',
                              '45',
                              '2',
                              '3062',
                              '1'
                          );

INSERT INTO BAREME_DETAIL (
                              DBAR_ID_DETAILS,
                              DBAR_NB_PLACE,
                              DBAR_NB_POINT,
                              BAR_ID,
                              BL_MAJ
                          )
                          VALUES (
                              '3962',
                              '6',
                              '52',
                              '3062',
                              '1'
                          );

INSERT INTO BAREME_DETAIL (
                              DBAR_ID_DETAILS,
                              DBAR_NB_PLACE,
                              DBAR_NB_POINT,
                              BAR_ID,
                              BL_MAJ
                          )
                          VALUES (
                              '3963',
                              '16',
                              '31',
                              '3062',
                              '1'
                          );

INSERT INTO BAREME_DETAIL (
                              DBAR_ID_DETAILS,
                              DBAR_NB_PLACE,
                              DBAR_NB_POINT,
                              BAR_ID,
                              BL_MAJ
                          )
                          VALUES (
                              '3964',
                              '26',
                              '17',
                              '3062',
                              '1'
                          );

INSERT INTO BAREME_DETAIL (
                              DBAR_ID_DETAILS,
                              DBAR_NB_PLACE,
                              DBAR_NB_POINT,
                              BAR_ID,
                              BL_MAJ
                          )
                          VALUES (
                              '3965',
                              '36',
                              '7',
                              '3062',
                              '1'
                          );

INSERT INTO BAREME_DETAIL (
                              DBAR_ID_DETAILS,
                              DBAR_NB_PLACE,
                              DBAR_NB_POINT,
                              BAR_ID,
                              BL_MAJ
                          )
                          VALUES (
                              '3966',
                              '46',
                              '2',
                              '3062',
                              '1'
                          );

INSERT INTO BAREME_DETAIL (
                              DBAR_ID_DETAILS,
                              DBAR_NB_PLACE,
                              DBAR_NB_POINT,
                              BAR_ID,
                              BL_MAJ
                          )
                          VALUES (
                              '3967',
                              '7',
                              '50',
                              '3062',
                              '1'
                          );

INSERT INTO BAREME_DETAIL (
                              DBAR_ID_DETAILS,
                              DBAR_NB_PLACE,
                              DBAR_NB_POINT,
                              BAR_ID,
                              BL_MAJ
                          )
                          VALUES (
                              '3968',
                              '17',
                              '30',
                              '3062',
                              '1'
                          );

INSERT INTO BAREME_DETAIL (
                              DBAR_ID_DETAILS,
                              DBAR_NB_PLACE,
                              DBAR_NB_POINT,
                              BAR_ID,
                              BL_MAJ
                          )
                          VALUES (
                              '3969',
                              '27',
                              '16',
                              '3062',
                              '1'
                          );

INSERT INTO BAREME_DETAIL (
                              DBAR_ID_DETAILS,
                              DBAR_NB_PLACE,
                              DBAR_NB_POINT,
                              BAR_ID,
                              BL_MAJ
                          )
                          VALUES (
                              '3970',
                              '37',
                              '6',
                              '3062',
                              '1'
                          );

INSERT INTO BAREME_DETAIL (
                              DBAR_ID_DETAILS,
                              DBAR_NB_PLACE,
                              DBAR_NB_POINT,
                              BAR_ID,
                              BL_MAJ
                          )
                          VALUES (
                              '3971',
                              '47',
                              '2',
                              '3062',
                              '1'
                          );

INSERT INTO BAREME_DETAIL (
                              DBAR_ID_DETAILS,
                              DBAR_NB_PLACE,
                              DBAR_NB_POINT,
                              BAR_ID,
                              BL_MAJ
                          )
                          VALUES (
                              '3972',
                              '8',
                              '48',
                              '3062',
                              '1'
                          );

INSERT INTO BAREME_DETAIL (
                              DBAR_ID_DETAILS,
                              DBAR_NB_PLACE,
                              DBAR_NB_POINT,
                              BAR_ID,
                              BL_MAJ
                          )
                          VALUES (
                              '3973',
                              '18',
                              '29',
                              '3062',
                              '1'
                          );

INSERT INTO BAREME_DETAIL (
                              DBAR_ID_DETAILS,
                              DBAR_NB_PLACE,
                              DBAR_NB_POINT,
                              BAR_ID,
                              BL_MAJ
                          )
                          VALUES (
                              '3974',
                              '28',
                              '15',
                              '3062',
                              '1'
                          );

INSERT INTO BAREME_DETAIL (
                              DBAR_ID_DETAILS,
                              DBAR_NB_PLACE,
                              DBAR_NB_POINT,
                              BAR_ID,
                              BL_MAJ
                          )
                          VALUES (
                              '3975',
                              '38',
                              '5',
                              '3062',
                              '1'
                          );

INSERT INTO BAREME_DETAIL (
                              DBAR_ID_DETAILS,
                              DBAR_NB_PLACE,
                              DBAR_NB_POINT,
                              BAR_ID,
                              BL_MAJ
                          )
                          VALUES (
                              '3976',
                              '48',
                              '2',
                              '3062',
                              '1'
                          );

INSERT INTO BAREME_DETAIL (
                              DBAR_ID_DETAILS,
                              DBAR_NB_PLACE,
                              DBAR_NB_POINT,
                              BAR_ID,
                              BL_MAJ
                          )
                          VALUES (
                              '3977',
                              '9',
                              '38',
                              '3062',
                              '1'
                          );

INSERT INTO BAREME_DETAIL (
                              DBAR_ID_DETAILS,
                              DBAR_NB_PLACE,
                              DBAR_NB_POINT,
                              BAR_ID,
                              BL_MAJ
                          )
                          VALUES (
                              '3978',
                              '19',
                              '28',
                              '3062',
                              '1'
                          );

INSERT INTO BAREME_DETAIL (
                              DBAR_ID_DETAILS,
                              DBAR_NB_PLACE,
                              DBAR_NB_POINT,
                              BAR_ID,
                              BL_MAJ
                          )
                          VALUES (
                              '3979',
                              '29',
                              '14',
                              '3062',
                              '1'
                          );

INSERT INTO BAREME_DETAIL (
                              DBAR_ID_DETAILS,
                              DBAR_NB_PLACE,
                              DBAR_NB_POINT,
                              BAR_ID,
                              BL_MAJ
                          )
                          VALUES (
                              '3980',
                              '39',
                              '4',
                              '3062',
                              '1'
                          );

INSERT INTO BAREME_DETAIL (
                              DBAR_ID_DETAILS,
                              DBAR_NB_PLACE,
                              DBAR_NB_POINT,
                              BAR_ID,
                              BL_MAJ
                          )
                          VALUES (
                              '3981',
                              '10',
                              '37',
                              '3062',
                              '1'
                          );

INSERT INTO BAREME_DETAIL (
                              DBAR_ID_DETAILS,
                              DBAR_NB_PLACE,
                              DBAR_NB_POINT,
                              BAR_ID,
                              BL_MAJ
                          )
                          VALUES (
                              '3982',
                              '20',
                              '27',
                              '3062',
                              '1'
                          );

INSERT INTO BAREME_DETAIL (
                              DBAR_ID_DETAILS,
                              DBAR_NB_PLACE,
                              DBAR_NB_POINT,
                              BAR_ID,
                              BL_MAJ
                          )
                          VALUES (
                              '3983',
                              '30',
                              '13',
                              '3062',
                              '1'
                          );

INSERT INTO BAREME_DETAIL (
                              DBAR_ID_DETAILS,
                              DBAR_NB_PLACE,
                              DBAR_NB_POINT,
                              BAR_ID,
                              BL_MAJ
                          )
                          VALUES (
                              '3984',
                              '40',
                              '3',
                              '3062',
                              '1'
                          );

INSERT INTO BAREME_DETAIL (
                              DBAR_ID_DETAILS,
                              DBAR_NB_PLACE,
                              DBAR_NB_POINT,
                              BAR_ID,
                              BL_MAJ
                          )
                          VALUES (
                              '3610',
                              '1',
                              '100',
                              '3039',
                              '1'
                          );

INSERT INTO BAREME_DETAIL (
                              DBAR_ID_DETAILS,
                              DBAR_NB_PLACE,
                              DBAR_NB_POINT,
                              BAR_ID,
                              BL_MAJ
                          )
                          VALUES (
                              '3611',
                              '2',
                              '75',
                              '3039',
                              '1'
                          );

INSERT INTO BAREME_DETAIL (
                              DBAR_ID_DETAILS,
                              DBAR_NB_PLACE,
                              DBAR_NB_POINT,
                              BAR_ID,
                              BL_MAJ
                          )
                          VALUES (
                              '3612',
                              '3',
                              '50',
                              '3039',
                              '1'
                          );

INSERT INTO BAREME_DETAIL (
                              DBAR_ID_DETAILS,
                              DBAR_NB_PLACE,
                              DBAR_NB_POINT,
                              BAR_ID,
                              BL_MAJ
                          )
                          VALUES (
                              '3613',
                              '4',
                              '30',
                              '3039',
                              '1'
                          );

INSERT INTO BAREME_DETAIL (
                              DBAR_ID_DETAILS,
                              DBAR_NB_PLACE,
                              DBAR_NB_POINT,
                              BAR_ID,
                              BL_MAJ
                          )
                          VALUES (
                              '3614',
                              '5',
                              '15',
                              '3039',
                              '1'
                          );

INSERT INTO BAREME_DETAIL (
                              DBAR_ID_DETAILS,
                              DBAR_NB_PLACE,
                              DBAR_NB_POINT,
                              BAR_ID,
                              BL_MAJ
                          )
                          VALUES (
                              '3615',
                              '6',
                              '2',
                              '3039',
                              '1'
                          );

INSERT INTO BAREME_DETAIL (
                              DBAR_ID_DETAILS,
                              DBAR_NB_PLACE,
                              DBAR_NB_POINT,
                              BAR_ID,
                              BL_MAJ
                          )
                          VALUES (
                              '3770',
                              '1',
                              '100',
                              '3051',
                              '1'
                          );

INSERT INTO BAREME_DETAIL (
                              DBAR_ID_DETAILS,
                              DBAR_NB_PLACE,
                              DBAR_NB_POINT,
                              BAR_ID,
                              BL_MAJ
                          )
                          VALUES (
                              '3771',
                              '2',
                              '75',
                              '3051',
                              '1'
                          );

INSERT INTO BAREME_DETAIL (
                              DBAR_ID_DETAILS,
                              DBAR_NB_PLACE,
                              DBAR_NB_POINT,
                              BAR_ID,
                              BL_MAJ
                          )
                          VALUES (
                              '3772',
                              '3',
                              '50',
                              '3051',
                              '1'
                          );

INSERT INTO BAREME_DETAIL (
                              DBAR_ID_DETAILS,
                              DBAR_NB_PLACE,
                              DBAR_NB_POINT,
                              BAR_ID,
                              BL_MAJ
                          )
                          VALUES (
                              '3773',
                              '4',
                              '35',
                              '3051',
                              '1'
                          );

INSERT INTO BAREME_DETAIL (
                              DBAR_ID_DETAILS,
                              DBAR_NB_PLACE,
                              DBAR_NB_POINT,
                              BAR_ID,
                              BL_MAJ
                          )
                          VALUES (
                              '3774',
                              '5',
                              '20',
                              '3051',
                              '1'
                          );

INSERT INTO BAREME_DETAIL (
                              DBAR_ID_DETAILS,
                              DBAR_NB_PLACE,
                              DBAR_NB_POINT,
                              BAR_ID,
                              BL_MAJ
                          )
                          VALUES (
                              '3775',
                              '6',
                              '10',
                              '3051',
                              '1'
                          );

INSERT INTO BAREME_DETAIL (
                              DBAR_ID_DETAILS,
                              DBAR_NB_PLACE,
                              DBAR_NB_POINT,
                              BAR_ID,
                              BL_MAJ
                          )
                          VALUES (
                              '3776',
                              '7',
                              '2',
                              '3051',
                              '1'
                          );

INSERT INTO BAREME_DETAIL (
                              DBAR_ID_DETAILS,
                              DBAR_NB_PLACE,
                              DBAR_NB_POINT,
                              BAR_ID,
                              BL_MAJ
                          )
                          VALUES (
                              '3777',
                              '1',
                              '100',
                              '3052',
                              '1'
                          );

INSERT INTO BAREME_DETAIL (
                              DBAR_ID_DETAILS,
                              DBAR_NB_PLACE,
                              DBAR_NB_POINT,
                              BAR_ID,
                              BL_MAJ
                          )
                          VALUES (
                              '3778',
                              '2',
                              '80',
                              '3052',
                              '1'
                          );

INSERT INTO BAREME_DETAIL (
                              DBAR_ID_DETAILS,
                              DBAR_NB_PLACE,
                              DBAR_NB_POINT,
                              BAR_ID,
                              BL_MAJ
                          )
                          VALUES (
                              '3779',
                              '3',
                              '60',
                              '3052',
                              '1'
                          );

INSERT INTO BAREME_DETAIL (
                              DBAR_ID_DETAILS,
                              DBAR_NB_PLACE,
                              DBAR_NB_POINT,
                              BAR_ID,
                              BL_MAJ
                          )
                          VALUES (
                              '3780',
                              '4',
                              '45',
                              '3052',
                              '1'
                          );

INSERT INTO BAREME_DETAIL (
                              DBAR_ID_DETAILS,
                              DBAR_NB_PLACE,
                              DBAR_NB_POINT,
                              BAR_ID,
                              BL_MAJ
                          )
                          VALUES (
                              '3781',
                              '5',
                              '33',
                              '3052',
                              '1'
                          );

INSERT INTO BAREME_DETAIL (
                              DBAR_ID_DETAILS,
                              DBAR_NB_PLACE,
                              DBAR_NB_POINT,
                              BAR_ID,
                              BL_MAJ
                          )
                          VALUES (
                              '3782',
                              '6',
                              '21',
                              '3052',
                              '1'
                          );

INSERT INTO BAREME_DETAIL (
                              DBAR_ID_DETAILS,
                              DBAR_NB_PLACE,
                              DBAR_NB_POINT,
                              BAR_ID,
                              BL_MAJ
                          )
                          VALUES (
                              '3783',
                              '7',
                              '10',
                              '3052',
                              '1'
                          );

INSERT INTO BAREME_DETAIL (
                              DBAR_ID_DETAILS,
                              DBAR_NB_PLACE,
                              DBAR_NB_POINT,
                              BAR_ID,
                              BL_MAJ
                          )
                          VALUES (
                              '3784',
                              '8',
                              '2',
                              '3052',
                              '1'
                          );

INSERT INTO BAREME_DETAIL (
                              DBAR_ID_DETAILS,
                              DBAR_NB_PLACE,
                              DBAR_NB_POINT,
                              BAR_ID,
                              BL_MAJ
                          )
                          VALUES (
                              '3785',
                              '1',
                              '100',
                              '3053',
                              '1'
                          );

INSERT INTO BAREME_DETAIL (
                              DBAR_ID_DETAILS,
                              DBAR_NB_PLACE,
                              DBAR_NB_POINT,
                              BAR_ID,
                              BL_MAJ
                          )
                          VALUES (
                              '3786',
                              '2',
                              '80',
                              '3053',
                              '1'
                          );

INSERT INTO BAREME_DETAIL (
                              DBAR_ID_DETAILS,
                              DBAR_NB_PLACE,
                              DBAR_NB_POINT,
                              BAR_ID,
                              BL_MAJ
                          )
                          VALUES (
                              '3787',
                              '3',
                              '60',
                              '3053',
                              '1'
                          );

INSERT INTO BAREME_DETAIL (
                              DBAR_ID_DETAILS,
                              DBAR_NB_PLACE,
                              DBAR_NB_POINT,
                              BAR_ID,
                              BL_MAJ
                          )
                          VALUES (
                              '3788',
                              '4',
                              '45',
                              '3053',
                              '1'
                          );

INSERT INTO BAREME_DETAIL (
                              DBAR_ID_DETAILS,
                              DBAR_NB_PLACE,
                              DBAR_NB_POINT,
                              BAR_ID,
                              BL_MAJ
                          )
                          VALUES (
                              '3789',
                              '5',
                              '33',
                              '3053',
                              '1'
                          );

INSERT INTO BAREME_DETAIL (
                              DBAR_ID_DETAILS,
                              DBAR_NB_PLACE,
                              DBAR_NB_POINT,
                              BAR_ID,
                              BL_MAJ
                          )
                          VALUES (
                              '3790',
                              '6',
                              '21',
                              '3053',
                              '1'
                          );

INSERT INTO BAREME_DETAIL (
                              DBAR_ID_DETAILS,
                              DBAR_NB_PLACE,
                              DBAR_NB_POINT,
                              BAR_ID,
                              BL_MAJ
                          )
                          VALUES (
                              '3791',
                              '7',
                              '12',
                              '3053',
                              '1'
                          );

INSERT INTO BAREME_DETAIL (
                              DBAR_ID_DETAILS,
                              DBAR_NB_PLACE,
                              DBAR_NB_POINT,
                              BAR_ID,
                              BL_MAJ
                          )
                          VALUES (
                              '3792',
                              '8',
                              '5',
                              '3053',
                              '1'
                          );

INSERT INTO BAREME_DETAIL (
                              DBAR_ID_DETAILS,
                              DBAR_NB_PLACE,
                              DBAR_NB_POINT,
                              BAR_ID,
                              BL_MAJ
                          )
                          VALUES (
                              '3793',
                              '9',
                              '2',
                              '3053',
                              '1'
                          );

INSERT INTO BAREME_DETAIL (
                              DBAR_ID_DETAILS,
                              DBAR_NB_PLACE,
                              DBAR_NB_POINT,
                              BAR_ID,
                              BL_MAJ
                          )
                          VALUES (
                              '3794',
                              '1',
                              '100',
                              '3054',
                              '1'
                          );

INSERT INTO BAREME_DETAIL (
                              DBAR_ID_DETAILS,
                              DBAR_NB_PLACE,
                              DBAR_NB_POINT,
                              BAR_ID,
                              BL_MAJ
                          )
                          VALUES (
                              '3795',
                              '2',
                              '80',
                              '3054',
                              '1'
                          );

INSERT INTO BAREME_DETAIL (
                              DBAR_ID_DETAILS,
                              DBAR_NB_PLACE,
                              DBAR_NB_POINT,
                              BAR_ID,
                              BL_MAJ
                          )
                          VALUES (
                              '3796',
                              '3',
                              '65',
                              '3054',
                              '1'
                          );

INSERT INTO BAREME_DETAIL (
                              DBAR_ID_DETAILS,
                              DBAR_NB_PLACE,
                              DBAR_NB_POINT,
                              BAR_ID,
                              BL_MAJ
                          )
                          VALUES (
                              '3797',
                              '4',
                              '50',
                              '3054',
                              '1'
                          );

INSERT INTO BAREME_DETAIL (
                              DBAR_ID_DETAILS,
                              DBAR_NB_PLACE,
                              DBAR_NB_POINT,
                              BAR_ID,
                              BL_MAJ
                          )
                          VALUES (
                              '3798',
                              '5',
                              '40',
                              '3054',
                              '1'
                          );

INSERT INTO BAREME_DETAIL (
                              DBAR_ID_DETAILS,
                              DBAR_NB_PLACE,
                              DBAR_NB_POINT,
                              BAR_ID,
                              BL_MAJ
                          )
                          VALUES (
                              '3799',
                              '6',
                              '30',
                              '3054',
                              '1'
                          );

INSERT INTO BAREME_DETAIL (
                              DBAR_ID_DETAILS,
                              DBAR_NB_PLACE,
                              DBAR_NB_POINT,
                              BAR_ID,
                              BL_MAJ
                          )
                          VALUES (
                              '3800',
                              '7',
                              '20',
                              '3054',
                              '1'
                          );

INSERT INTO BAREME_DETAIL (
                              DBAR_ID_DETAILS,
                              DBAR_NB_PLACE,
                              DBAR_NB_POINT,
                              BAR_ID,
                              BL_MAJ
                          )
                          VALUES (
                              '3801',
                              '8',
                              '10',
                              '3054',
                              '1'
                          );

INSERT INTO BAREME_DETAIL (
                              DBAR_ID_DETAILS,
                              DBAR_NB_PLACE,
                              DBAR_NB_POINT,
                              BAR_ID,
                              BL_MAJ
                          )
                          VALUES (
                              '3802',
                              '9',
                              '5',
                              '3054',
                              '1'
                          );

INSERT INTO BAREME_DETAIL (
                              DBAR_ID_DETAILS,
                              DBAR_NB_PLACE,
                              DBAR_NB_POINT,
                              BAR_ID,
                              BL_MAJ
                          )
                          VALUES (
                              '3803',
                              '10',
                              '2',
                              '3054',
                              '1'
                          );

INSERT INTO BAREME_DETAIL (
                              DBAR_ID_DETAILS,
                              DBAR_NB_PLACE,
                              DBAR_NB_POINT,
                              BAR_ID,
                              BL_MAJ
                          )
                          VALUES (
                              '3804',
                              '1',
                              '100',
                              '3055',
                              '1'
                          );

INSERT INTO BAREME_DETAIL (
                              DBAR_ID_DETAILS,
                              DBAR_NB_PLACE,
                              DBAR_NB_POINT,
                              BAR_ID,
                              BL_MAJ
                          )
                          VALUES (
                              '3805',
                              '11',
                              '2',
                              '3055',
                              '1'
                          );

INSERT INTO BAREME_DETAIL (
                              DBAR_ID_DETAILS,
                              DBAR_NB_PLACE,
                              DBAR_NB_POINT,
                              BAR_ID,
                              BL_MAJ
                          )
                          VALUES (
                              '3806',
                              '2',
                              '80',
                              '3055',
                              '1'
                          );

INSERT INTO BAREME_DETAIL (
                              DBAR_ID_DETAILS,
                              DBAR_NB_PLACE,
                              DBAR_NB_POINT,
                              BAR_ID,
                              BL_MAJ
                          )
                          VALUES (
                              '3807',
                              '3',
                              '65',
                              '3055',
                              '1'
                          );

INSERT INTO BAREME_DETAIL (
                              DBAR_ID_DETAILS,
                              DBAR_NB_PLACE,
                              DBAR_NB_POINT,
                              BAR_ID,
                              BL_MAJ
                          )
                          VALUES (
                              '3808',
                              '4',
                              '50',
                              '3055',
                              '1'
                          );

INSERT INTO BAREME_DETAIL (
                              DBAR_ID_DETAILS,
                              DBAR_NB_PLACE,
                              DBAR_NB_POINT,
                              BAR_ID,
                              BL_MAJ
                          )
                          VALUES (
                              '3809',
                              '5',
                              '40',
                              '3055',
                              '1'
                          );

INSERT INTO BAREME_DETAIL (
                              DBAR_ID_DETAILS,
                              DBAR_NB_PLACE,
                              DBAR_NB_POINT,
                              BAR_ID,
                              BL_MAJ
                          )
                          VALUES (
                              '3810',
                              '6',
                              '30',
                              '3055',
                              '1'
                          );

INSERT INTO BAREME_DETAIL (
                              DBAR_ID_DETAILS,
                              DBAR_NB_PLACE,
                              DBAR_NB_POINT,
                              BAR_ID,
                              BL_MAJ
                          )
                          VALUES (
                              '3811',
                              '7',
                              '20',
                              '3055',
                              '1'
                          );

INSERT INTO BAREME_DETAIL (
                              DBAR_ID_DETAILS,
                              DBAR_NB_PLACE,
                              DBAR_NB_POINT,
                              BAR_ID,
                              BL_MAJ
                          )
                          VALUES (
                              '3812',
                              '8',
                              '15',
                              '3055',
                              '1'
                          );

INSERT INTO BAREME_DETAIL (
                              DBAR_ID_DETAILS,
                              DBAR_NB_PLACE,
                              DBAR_NB_POINT,
                              BAR_ID,
                              BL_MAJ
                          )
                          VALUES (
                              '3813',
                              '9',
                              '10',
                              '3055',
                              '1'
                          );

INSERT INTO BAREME_DETAIL (
                              DBAR_ID_DETAILS,
                              DBAR_NB_PLACE,
                              DBAR_NB_POINT,
                              BAR_ID,
                              BL_MAJ
                          )
                          VALUES (
                              '3814',
                              '10',
                              '5',
                              '3055',
                              '1'
                          );

INSERT INTO BAREME_DETAIL (
                              DBAR_ID_DETAILS,
                              DBAR_NB_PLACE,
                              DBAR_NB_POINT,
                              BAR_ID,
                              BL_MAJ
                          )
                          VALUES (
                              '3815',
                              '1',
                              '100',
                              '3056',
                              '1'
                          );

INSERT INTO BAREME_DETAIL (
                              DBAR_ID_DETAILS,
                              DBAR_NB_PLACE,
                              DBAR_NB_POINT,
                              BAR_ID,
                              BL_MAJ
                          )
                          VALUES (
                              '3816',
                              '11',
                              '5',
                              '3056',
                              '1'
                          );

INSERT INTO BAREME_DETAIL (
                              DBAR_ID_DETAILS,
                              DBAR_NB_PLACE,
                              DBAR_NB_POINT,
                              BAR_ID,
                              BL_MAJ
                          )
                          VALUES (
                              '3817',
                              '2',
                              '80',
                              '3056',
                              '1'
                          );

INSERT INTO BAREME_DETAIL (
                              DBAR_ID_DETAILS,
                              DBAR_NB_PLACE,
                              DBAR_NB_POINT,
                              BAR_ID,
                              BL_MAJ
                          )
                          VALUES (
                              '3818',
                              '12',
                              '2',
                              '3056',
                              '1'
                          );

INSERT INTO BAREME_DETAIL (
                              DBAR_ID_DETAILS,
                              DBAR_NB_PLACE,
                              DBAR_NB_POINT,
                              BAR_ID,
                              BL_MAJ
                          )
                          VALUES (
                              '3819',
                              '3',
                              '65',
                              '3056',
                              '1'
                          );

INSERT INTO BAREME_DETAIL (
                              DBAR_ID_DETAILS,
                              DBAR_NB_PLACE,
                              DBAR_NB_POINT,
                              BAR_ID,
                              BL_MAJ
                          )
                          VALUES (
                              '3820',
                              '4',
                              '50',
                              '3056',
                              '1'
                          );

INSERT INTO BAREME_DETAIL (
                              DBAR_ID_DETAILS,
                              DBAR_NB_PLACE,
                              DBAR_NB_POINT,
                              BAR_ID,
                              BL_MAJ
                          )
                          VALUES (
                              '3821',
                              '5',
                              '40',
                              '3056',
                              '1'
                          );

INSERT INTO BAREME_DETAIL (
                              DBAR_ID_DETAILS,
                              DBAR_NB_PLACE,
                              DBAR_NB_POINT,
                              BAR_ID,
                              BL_MAJ
                          )
                          VALUES (
                              '3822',
                              '6',
                              '30',
                              '3056',
                              '1'
                          );

INSERT INTO BAREME_DETAIL (
                              DBAR_ID_DETAILS,
                              DBAR_NB_PLACE,
                              DBAR_NB_POINT,
                              BAR_ID,
                              BL_MAJ
                          )
                          VALUES (
                              '3823',
                              '7',
                              '25',
                              '3056',
                              '1'
                          );

INSERT INTO BAREME_DETAIL (
                              DBAR_ID_DETAILS,
                              DBAR_NB_PLACE,
                              DBAR_NB_POINT,
                              BAR_ID,
                              BL_MAJ
                          )
                          VALUES (
                              '3824',
                              '8',
                              '20',
                              '3056',
                              '1'
                          );

INSERT INTO BAREME_DETAIL (
                              DBAR_ID_DETAILS,
                              DBAR_NB_PLACE,
                              DBAR_NB_POINT,
                              BAR_ID,
                              BL_MAJ
                          )
                          VALUES (
                              '3825',
                              '9',
                              '15',
                              '3056',
                              '1'
                          );

INSERT INTO BAREME_DETAIL (
                              DBAR_ID_DETAILS,
                              DBAR_NB_PLACE,
                              DBAR_NB_POINT,
                              BAR_ID,
                              BL_MAJ
                          )
                          VALUES (
                              '3826',
                              '10',
                              '10',
                              '3056',
                              '1'
                          );

INSERT INTO BAREME_DETAIL (
                              DBAR_ID_DETAILS,
                              DBAR_NB_PLACE,
                              DBAR_NB_POINT,
                              BAR_ID,
                              BL_MAJ
                          )
                          VALUES (
                              '3827',
                              '1',
                              '100',
                              '3057',
                              '1'
                          );

INSERT INTO BAREME_DETAIL (
                              DBAR_ID_DETAILS,
                              DBAR_NB_PLACE,
                              DBAR_NB_POINT,
                              BAR_ID,
                              BL_MAJ
                          )
                          VALUES (
                              '3828',
                              '11',
                              '10',
                              '3057',
                              '1'
                          );

INSERT INTO BAREME_DETAIL (
                              DBAR_ID_DETAILS,
                              DBAR_NB_PLACE,
                              DBAR_NB_POINT,
                              BAR_ID,
                              BL_MAJ
                          )
                          VALUES (
                              '3829',
                              '2',
                              '80',
                              '3057',
                              '1'
                          );

INSERT INTO BAREME_DETAIL (
                              DBAR_ID_DETAILS,
                              DBAR_NB_PLACE,
                              DBAR_NB_POINT,
                              BAR_ID,
                              BL_MAJ
                          )
                          VALUES (
                              '3830',
                              '12',
                              '7',
                              '3057',
                              '1'
                          );

INSERT INTO BAREME_DETAIL (
                              DBAR_ID_DETAILS,
                              DBAR_NB_PLACE,
                              DBAR_NB_POINT,
                              BAR_ID,
                              BL_MAJ
                          )
                          VALUES (
                              '3831',
                              '3',
                              '65',
                              '3057',
                              '1'
                          );

INSERT INTO BAREME_DETAIL (
                              DBAR_ID_DETAILS,
                              DBAR_NB_PLACE,
                              DBAR_NB_POINT,
                              BAR_ID,
                              BL_MAJ
                          )
                          VALUES (
                              '3832',
                              '13',
                              '5',
                              '3057',
                              '1'
                          );

INSERT INTO BAREME_DETAIL (
                              DBAR_ID_DETAILS,
                              DBAR_NB_PLACE,
                              DBAR_NB_POINT,
                              BAR_ID,
                              BL_MAJ
                          )
                          VALUES (
                              '3833',
                              '4',
                              '50',
                              '3057',
                              '1'
                          );

INSERT INTO BAREME_DETAIL (
                              DBAR_ID_DETAILS,
                              DBAR_NB_PLACE,
                              DBAR_NB_POINT,
                              BAR_ID,
                              BL_MAJ
                          )
                          VALUES (
                              '3834',
                              '14',
                              '4',
                              '3057',
                              '1'
                          );

INSERT INTO BAREME_DETAIL (
                              DBAR_ID_DETAILS,
                              DBAR_NB_PLACE,
                              DBAR_NB_POINT,
                              BAR_ID,
                              BL_MAJ
                          )
                          VALUES (
                              '3835',
                              '5',
                              '40',
                              '3057',
                              '1'
                          );

INSERT INTO BAREME_DETAIL (
                              DBAR_ID_DETAILS,
                              DBAR_NB_PLACE,
                              DBAR_NB_POINT,
                              BAR_ID,
                              BL_MAJ
                          )
                          VALUES (
                              '3836',
                              '15',
                              '3',
                              '3057',
                              '1'
                          );

INSERT INTO BAREME_DETAIL (
                              DBAR_ID_DETAILS,
                              DBAR_NB_PLACE,
                              DBAR_NB_POINT,
                              BAR_ID,
                              BL_MAJ
                          )
                          VALUES (
                              '3837',
                              '6',
                              '35',
                              '3057',
                              '1'
                          );

INSERT INTO BAREME_DETAIL (
                              DBAR_ID_DETAILS,
                              DBAR_NB_PLACE,
                              DBAR_NB_POINT,
                              BAR_ID,
                              BL_MAJ
                          )
                          VALUES (
                              '3838',
                              '16',
                              '2',
                              '3057',
                              '1'
                          );

INSERT INTO BAREME_DETAIL (
                              DBAR_ID_DETAILS,
                              DBAR_NB_PLACE,
                              DBAR_NB_POINT,
                              BAR_ID,
                              BL_MAJ
                          )
                          VALUES (
                              '3839',
                              '7',
                              '30',
                              '3057',
                              '1'
                          );

INSERT INTO BAREME_DETAIL (
                              DBAR_ID_DETAILS,
                              DBAR_NB_PLACE,
                              DBAR_NB_POINT,
                              BAR_ID,
                              BL_MAJ
                          )
                          VALUES (
                              '3840',
                              '8',
                              '25',
                              '3057',
                              '1'
                          );

INSERT INTO BAREME_DETAIL (
                              DBAR_ID_DETAILS,
                              DBAR_NB_PLACE,
                              DBAR_NB_POINT,
                              BAR_ID,
                              BL_MAJ
                          )
                          VALUES (
                              '3841',
                              '9',
                              '20',
                              '3057',
                              '1'
                          );

INSERT INTO BAREME_DETAIL (
                              DBAR_ID_DETAILS,
                              DBAR_NB_PLACE,
                              DBAR_NB_POINT,
                              BAR_ID,
                              BL_MAJ
                          )
                          VALUES (
                              '3842',
                              '10',
                              '15',
                              '3057',
                              '1'
                          );

INSERT INTO BAREME_DETAIL (
                              DBAR_ID_DETAILS,
                              DBAR_NB_PLACE,
                              DBAR_NB_POINT,
                              BAR_ID,
                              BL_MAJ
                          )
                          VALUES (
                              '3843',
                              '1',
                              '100',
                              '3058',
                              '1'
                          );

INSERT INTO BAREME_DETAIL (
                              DBAR_ID_DETAILS,
                              DBAR_NB_PLACE,
                              DBAR_NB_POINT,
                              BAR_ID,
                              BL_MAJ
                          )
                          VALUES (
                              '3844',
                              '11',
                              '16',
                              '3058',
                              '1'
                          );

INSERT INTO BAREME_DETAIL (
                              DBAR_ID_DETAILS,
                              DBAR_NB_PLACE,
                              DBAR_NB_POINT,
                              BAR_ID,
                              BL_MAJ
                          )
                          VALUES (
                              '3845',
                              '2',
                              '80',
                              '3058',
                              '1'
                          );

INSERT INTO BAREME_DETAIL (
                              DBAR_ID_DETAILS,
                              DBAR_NB_PLACE,
                              DBAR_NB_POINT,
                              BAR_ID,
                              BL_MAJ
                          )
                          VALUES (
                              '3846',
                              '12',
                              '13',
                              '3058',
                              '1'
                          );

INSERT INTO BAREME_DETAIL (
                              DBAR_ID_DETAILS,
                              DBAR_NB_PLACE,
                              DBAR_NB_POINT,
                              BAR_ID,
                              BL_MAJ
                          )
                          VALUES (
                              '3847',
                              '3',
                              '65',
                              '3058',
                              '1'
                          );

INSERT INTO BAREME_DETAIL (
                              DBAR_ID_DETAILS,
                              DBAR_NB_PLACE,
                              DBAR_NB_POINT,
                              BAR_ID,
                              BL_MAJ
                          )
                          VALUES (
                              '3848',
                              '13',
                              '11',
                              '3058',
                              '1'
                          );

INSERT INTO BAREME_DETAIL (
                              DBAR_ID_DETAILS,
                              DBAR_NB_PLACE,
                              DBAR_NB_POINT,
                              BAR_ID,
                              BL_MAJ
                          )
                          VALUES (
                              '3849',
                              '4',
                              '50',
                              '3058',
                              '1'
                          );

INSERT INTO BAREME_DETAIL (
                              DBAR_ID_DETAILS,
                              DBAR_NB_PLACE,
                              DBAR_NB_POINT,
                              BAR_ID,
                              BL_MAJ
                          )
                          VALUES (
                              '3850',
                              '14',
                              '9',
                              '3058',
                              '1'
                          );

INSERT INTO BAREME_DETAIL (
                              DBAR_ID_DETAILS,
                              DBAR_NB_PLACE,
                              DBAR_NB_POINT,
                              BAR_ID,
                              BL_MAJ
                          )
                          VALUES (
                              '3851',
                              '5',
                              '40',
                              '3058',
                              '1'
                          );

INSERT INTO BAREME_DETAIL (
                              DBAR_ID_DETAILS,
                              DBAR_NB_PLACE,
                              DBAR_NB_POINT,
                              BAR_ID,
                              BL_MAJ
                          )
                          VALUES (
                              '3852',
                              '15',
                              '7',
                              '3058',
                              '1'
                          );

INSERT INTO BAREME_DETAIL (
                              DBAR_ID_DETAILS,
                              DBAR_NB_PLACE,
                              DBAR_NB_POINT,
                              BAR_ID,
                              BL_MAJ
                          )
                          VALUES (
                              '3853',
                              '6',
                              '35',
                              '3058',
                              '1'
                          );

INSERT INTO BAREME_DETAIL (
                              DBAR_ID_DETAILS,
                              DBAR_NB_PLACE,
                              DBAR_NB_POINT,
                              BAR_ID,
                              BL_MAJ
                          )
                          VALUES (
                              '3854',
                              '16',
                              '5',
                              '3058',
                              '1'
                          );

INSERT INTO BAREME_DETAIL (
                              DBAR_ID_DETAILS,
                              DBAR_NB_PLACE,
                              DBAR_NB_POINT,
                              BAR_ID,
                              BL_MAJ
                          )
                          VALUES (
                              '3855',
                              '7',
                              '30',
                              '3058',
                              '1'
                          );

INSERT INTO BAREME_DETAIL (
                              DBAR_ID_DETAILS,
                              DBAR_NB_PLACE,
                              DBAR_NB_POINT,
                              BAR_ID,
                              BL_MAJ
                          )
                          VALUES (
                              '3856',
                              '17',
                              '3',
                              '3058',
                              '1'
                          );

INSERT INTO BAREME_DETAIL (
                              DBAR_ID_DETAILS,
                              DBAR_NB_PLACE,
                              DBAR_NB_POINT,
                              BAR_ID,
                              BL_MAJ
                          )
                          VALUES (
                              '3857',
                              '8',
                              '25',
                              '3058',
                              '1'
                          );

INSERT INTO BAREME_DETAIL (
                              DBAR_ID_DETAILS,
                              DBAR_NB_PLACE,
                              DBAR_NB_POINT,
                              BAR_ID,
                              BL_MAJ
                          )
                          VALUES (
                              '3858',
                              '18',
                              '2',
                              '3058',
                              '1'
                          );

INSERT INTO BAREME_DETAIL (
                              DBAR_ID_DETAILS,
                              DBAR_NB_PLACE,
                              DBAR_NB_POINT,
                              BAR_ID,
                              BL_MAJ
                          )
                          VALUES (
                              '3859',
                              '9',
                              '22',
                              '3058',
                              '1'
                          );

INSERT INTO BAREME_DETAIL (
                              DBAR_ID_DETAILS,
                              DBAR_NB_PLACE,
                              DBAR_NB_POINT,
                              BAR_ID,
                              BL_MAJ
                          )
                          VALUES (
                              '3860',
                              '10',
                              '19',
                              '3058',
                              '1'
                          );


-- Table : CAT
DROP TABLE IF EXISTS CAT;

CREATE TABLE CAT (
    CAT_ID,
    GCAT_CD,
    CAT_LB,
    CAT_CD,
    CAT_DT_DEB,
    CAT_DT_FIN,
    CAT_FG,
    DEM_ID,
    BL_MAJ
);

INSERT INTO CAT (
                    CAT_ID,
                    GCAT_CD,
                    CAT_LB,
                    CAT_CD,
                    CAT_DT_DEB,
                    CAT_DT_FIN,
                    CAT_FG,
                    DEM_ID,
                    BL_MAJ
                )
                VALUES (
                    '-101',
                    'INC  ',
                    'Inconnue',
                    'I',
                    '01/01/1900 00:00:00',
                    '01/01/1900 00:00:00',
                    'X',
                    '',
                    '0'
                );

INSERT INTO CAT (
                    CAT_ID,
                    GCAT_CD,
                    CAT_LB,
                    CAT_CD,
                    CAT_DT_DEB,
                    CAT_DT_FIN,
                    CAT_FG,
                    DEM_ID,
                    BL_MAJ
                )
                VALUES (
                    '1',
                    'POU  ',
                    'Poussin',
                    'P',
                    '01/07/1996 00:00:00',
                    '31/12/2099 00:00:00',
                    'X',
                    '',
                    '1'
                );

INSERT INTO CAT (
                    CAT_ID,
                    GCAT_CD,
                    CAT_LB,
                    CAT_CD,
                    CAT_DT_DEB,
                    CAT_DT_FIN,
                    CAT_FG,
                    DEM_ID,
                    BL_MAJ
                )
                VALUES (
                    '2',
                    'BEN  ',
                    'Benjamins 1',
                    'B1',
                    '01/07/1995 00:00:00',
                    '30/06/1996 00:00:00',
                    'X',
                    '',
                    '1'
                );

INSERT INTO CAT (
                    CAT_ID,
                    GCAT_CD,
                    CAT_LB,
                    CAT_CD,
                    CAT_DT_DEB,
                    CAT_DT_FIN,
                    CAT_FG,
                    DEM_ID,
                    BL_MAJ
                )
                VALUES (
                    '3',
                    'BEN  ',
                    'Benjamins 2',
                    'B2',
                    '01/07/1994 00:00:00',
                    '30/06/1995 00:00:00',
                    'X',
                    '',
                    '1'
                );

INSERT INTO CAT (
                    CAT_ID,
                    GCAT_CD,
                    CAT_LB,
                    CAT_CD,
                    CAT_DT_DEB,
                    CAT_DT_FIN,
                    CAT_FG,
                    DEM_ID,
                    BL_MAJ
                )
                VALUES (
                    '4',
                    'MIN  ',
                    'Minimes 1',
                    'M1',
                    '01/07/1993 00:00:00',
                    '30/06/1994 00:00:00',
                    'X',
                    '',
                    '1'
                );

INSERT INTO CAT (
                    CAT_ID,
                    GCAT_CD,
                    CAT_LB,
                    CAT_CD,
                    CAT_DT_DEB,
                    CAT_DT_FIN,
                    CAT_FG,
                    DEM_ID,
                    BL_MAJ
                )
                VALUES (
                    '5',
                    'MIN  ',
                    'Minimes 2',
                    'M2',
                    '01/07/1992 00:00:00',
                    '30/06/1993 00:00:00',
                    'X',
                    '',
                    '1'
                );

INSERT INTO CAT (
                    CAT_ID,
                    GCAT_CD,
                    CAT_LB,
                    CAT_CD,
                    CAT_DT_DEB,
                    CAT_DT_FIN,
                    CAT_FG,
                    DEM_ID,
                    BL_MAJ
                )
                VALUES (
                    '6',
                    'CAD  ',
                    'Cadets 1',
                    'C1',
                    '01/07/1991 00:00:00',
                    '30/06/1992 00:00:00',
                    'X',
                    '',
                    '1'
                );

INSERT INTO CAT (
                    CAT_ID,
                    GCAT_CD,
                    CAT_LB,
                    CAT_CD,
                    CAT_DT_DEB,
                    CAT_DT_FIN,
                    CAT_FG,
                    DEM_ID,
                    BL_MAJ
                )
                VALUES (
                    '7',
                    'CAD  ',
                    'Cadets 2',
                    'C2',
                    '01/07/1990 00:00:00',
                    '30/06/1991 00:00:00',
                    'X',
                    '',
                    '1'
                );

INSERT INTO CAT (
                    CAT_ID,
                    GCAT_CD,
                    CAT_LB,
                    CAT_CD,
                    CAT_DT_DEB,
                    CAT_DT_FIN,
                    CAT_FG,
                    DEM_ID,
                    BL_MAJ
                )
                VALUES (
                    '8',
                    'JUN  ',
                    'Juniors 1',
                    'J1',
                    '01/07/1989 00:00:00',
                    '30/06/1990 00:00:00',
                    'X',
                    '',
                    '1'
                );

INSERT INTO CAT (
                    CAT_ID,
                    GCAT_CD,
                    CAT_LB,
                    CAT_CD,
                    CAT_DT_DEB,
                    CAT_DT_FIN,
                    CAT_FG,
                    DEM_ID,
                    BL_MAJ
                )
                VALUES (
                    '9',
                    'JUN  ',
                    'Juniors 2',
                    'J2',
                    '01/07/1988 00:00:00',
                    '30/06/1989 00:00:00',
                    'X',
                    '',
                    '1'
                );

INSERT INTO CAT (
                    CAT_ID,
                    GCAT_CD,
                    CAT_LB,
                    CAT_CD,
                    CAT_DT_DEB,
                    CAT_DT_FIN,
                    CAT_FG,
                    DEM_ID,
                    BL_MAJ
                )
                VALUES (
                    '10',
                    'JUN  ',
                    'Juniors 3',
                    'J3',
                    '01/07/1987 00:00:00',
                    '30/06/1988 00:00:00',
                    'X',
                    '',
                    '1'
                );

INSERT INTO CAT (
                    CAT_ID,
                    GCAT_CD,
                    CAT_LB,
                    CAT_CD,
                    CAT_DT_DEB,
                    CAT_DT_FIN,
                    CAT_FG,
                    DEM_ID,
                    BL_MAJ
                )
                VALUES (
                    '11',
                    'SEN  ',
                    'Seniors',
                    'S',
                    '01/07/1964 00:00:00',
                    '30/06/1987 00:00:00',
                    'X',
                    '',
                    '1'
                );

INSERT INTO CAT (
                    CAT_ID,
                    GCAT_CD,
                    CAT_LB,
                    CAT_CD,
                    CAT_DT_DEB,
                    CAT_DT_FIN,
                    CAT_FG,
                    DEM_ID,
                    BL_MAJ
                )
                VALUES (
                    '12',
                    'VET  ',
                    'Veterans 1',
                    'V1',
                    '01/07/1954 00:00:00',
                    '30/06/1964 00:00:00',
                    'X',
                    '',
                    '1'
                );

INSERT INTO CAT (
                    CAT_ID,
                    GCAT_CD,
                    CAT_LB,
                    CAT_CD,
                    CAT_DT_DEB,
                    CAT_DT_FIN,
                    CAT_FG,
                    DEM_ID,
                    BL_MAJ
                )
                VALUES (
                    '13',
                    'VET  ',
                    'Veterans 2',
                    'V2',
                    '01/07/1944 00:00:00',
                    '30/06/1954 00:00:00',
                    'X',
                    '',
                    '1'
                );

INSERT INTO CAT (
                    CAT_ID,
                    GCAT_CD,
                    CAT_LB,
                    CAT_CD,
                    CAT_DT_DEB,
                    CAT_DT_FIN,
                    CAT_FG,
                    DEM_ID,
                    BL_MAJ
                )
                VALUES (
                    '14',
                    'VET  ',
                    'Veterans 3 Dames',
                    'V3D',
                    '31/12/1800 00:00:00',
                    '30/06/1944 00:00:00',
                    'F',
                    '',
                    '1'
                );

INSERT INTO CAT (
                    CAT_ID,
                    GCAT_CD,
                    CAT_LB,
                    CAT_CD,
                    CAT_DT_DEB,
                    CAT_DT_FIN,
                    CAT_FG,
                    DEM_ID,
                    BL_MAJ
                )
                VALUES (
                    '15',
                    'VET  ',
                    'Veterans 3 Messieurs',
                    'V3',
                    '01/07/1934 00:00:00',
                    '30/06/1944 00:00:00',
                    'M',
                    '',
                    '1'
                );

INSERT INTO CAT (
                    CAT_ID,
                    GCAT_CD,
                    CAT_LB,
                    CAT_CD,
                    CAT_DT_DEB,
                    CAT_DT_FIN,
                    CAT_FG,
                    DEM_ID,
                    BL_MAJ
                )
                VALUES (
                    '16',
                    'VET  ',
                    'Veterans 4',
                    'V4',
                    '31/12/1800 00:00:00',
                    '30/06/1934 00:00:00',
                    'M',
                    '',
                    '1'
                );


-- Table : CAT_AGE_GROUP
DROP TABLE IF EXISTS CAT_AGE_GROUP;

CREATE TABLE CAT_AGE_GROUP (
    GCAT_CD,
    GCAT_LB_COURT,
    GCAT_LB,
    BL_MAJ
);

INSERT INTO CAT_AGE_GROUP (
                              GCAT_CD,
                              GCAT_LB_COURT,
                              GCAT_LB,
                              BL_MAJ
                          )
                          VALUES (
                              'INC  ',
                              'INC',
                              'Inconnu',
                              '0'
                          );

INSERT INTO CAT_AGE_GROUP (
                              GCAT_CD,
                              GCAT_LB_COURT,
                              GCAT_LB,
                              BL_MAJ
                          )
                          VALUES (
                              'POU  ',
                              'POU',
                              'Poussins',
                              '1'
                          );

INSERT INTO CAT_AGE_GROUP (
                              GCAT_CD,
                              GCAT_LB_COURT,
                              GCAT_LB,
                              BL_MAJ
                          )
                          VALUES (
                              'BEN  ',
                              'BEN',
                              'Benjamins',
                              '1'
                          );

INSERT INTO CAT_AGE_GROUP (
                              GCAT_CD,
                              GCAT_LB_COURT,
                              GCAT_LB,
                              BL_MAJ
                          )
                          VALUES (
                              'MIN  ',
                              'MIN',
                              'Minimes',
                              '1'
                          );

INSERT INTO CAT_AGE_GROUP (
                              GCAT_CD,
                              GCAT_LB_COURT,
                              GCAT_LB,
                              BL_MAJ
                          )
                          VALUES (
                              'CAD  ',
                              'CAD',
                              'Cadets',
                              '1'
                          );

INSERT INTO CAT_AGE_GROUP (
                              GCAT_CD,
                              GCAT_LB_COURT,
                              GCAT_LB,
                              BL_MAJ
                          )
                          VALUES (
                              'JUN  ',
                              'JUN',
                              'Juniors',
                              '1'
                          );

INSERT INTO CAT_AGE_GROUP (
                              GCAT_CD,
                              GCAT_LB_COURT,
                              GCAT_LB,
                              BL_MAJ
                          )
                          VALUES (
                              'SEN  ',
                              'SEN',
                              'Seniors',
                              '1'
                          );

INSERT INTO CAT_AGE_GROUP (
                              GCAT_CD,
                              GCAT_LB_COURT,
                              GCAT_LB,
                              BL_MAJ
                          )
                          VALUES (
                              'VET  ',
                              'VET',
                              'Veterans',
                              '1'
                          );


-- Table : CATEGORIE_EPREUVE
DROP TABLE IF EXISTS CATEGORIE_EPREUVE;

CREATE TABLE CATEGORIE_EPREUVE (
    DIV_ID,
    CAT_ID,
    CAT_EPR_BL_PRINCIPAL
);


-- Table : CELLULE_POT
DROP TABLE IF EXISTS CELLULE_POT;

CREATE TABLE CELLULE_POT (
    CELLULE_ID,
    LIGNE_POT_ID,
    TABPART_ID_TABLEAU,
    CELL_NM_TABLE,
    CELL_LB_PARTIE,
    CELL_CODE_ROUGE,
    CELL_CODE_VERT,
    CELL_CODE_BLEU
);


-- Table : CLASSEMENT
DROP TABLE IF EXISTS CLASSEMENT;

CREATE TABLE CLASSEMENT (
    CLST_ID,
    POUL_ID,
    CLST_NB_RANG,
    CLST_NB_POINTS,
    CLST_NB_VICTOIRE,
    CLST_NB_DEFAITE,
    CLST_NB_EGALITE,
    CLST_NB_FORFAITS,
    CLST_NB_PENALITE,
    CLST_NB_GAGNE,
    CLST_NB_PERDUES,
    EQUIP_ID,
    LIC_ID,
    TAB_ID,
    CLST_CD_LETTRE,
    NIV_ID,
    CLST_RANG_FORFAIT
);


-- Table : CLUB
DROP TABLE IF EXISTS CLUB;

CREATE TABLE CLUB (
    CLUB_ID,
    ORGA_ID,
    CLUB_NM,
    CLUB_LB_LONG,
    CLUB_LB_COURT,
    CLUB_FG
);

INSERT INTO CLUB (
                     CLUB_ID,
                     ORGA_ID,
                     CLUB_NM,
                     CLUB_LB_LONG,
                     CLUB_LB_COURT,
                     CLUB_FG
                 )
                 VALUES (
                     '-101',
                     '-101',
                     '0',
                     'Inconnu',
                     'Inc',
                     'M'
                 );


-- Table : DIVISION
DROP TABLE IF EXISTS DIVISION;

CREATE TABLE DIVISION (
    DIV_ID,
    ORGA_ID,
    EPRV_ID,
    DIV_CD,
    DIV_LB,
    DIV_NB_POULE,
    DIV_FG_SEXE,
    DIV_FG_TYPE_LICENCE,
    DIV_BL_CORPO,
    DIV_NB_TOUR,
    DIV_CD_LETTRE,
    DIV_CM,
    DIV_LB_USER_MODIF,
    BAR_ID,
    GCAT_CD,
    DIV_DIV_ID,
    DIV_BL_DOUBLE,
    DIV_NB_POINT_MANCHE,
    DIV_NB_MANCHE_POULE,
    DIV_NB_MANCHE_TAB,
    DIV_NB_POINT_MIN,
    DIV_NB_POINT_MAX,
    DIV_DT_TOUR
);

INSERT INTO DIVISION (
                         DIV_ID,
                         ORGA_ID,
                         EPRV_ID,
                         DIV_CD,
                         DIV_LB,
                         DIV_NB_POULE,
                         DIV_FG_SEXE,
                         DIV_FG_TYPE_LICENCE,
                         DIV_BL_CORPO,
                         DIV_NB_TOUR,
                         DIV_CD_LETTRE,
                         DIV_CM,
                         DIV_LB_USER_MODIF,
                         BAR_ID,
                         GCAT_CD,
                         DIV_DIV_ID,
                         DIV_BL_DOUBLE,
                         DIV_NB_POINT_MANCHE,
                         DIV_NB_MANCHE_POULE,
                         DIV_NB_MANCHE_TAB,
                         DIV_NB_POINT_MIN,
                         DIV_NB_POINT_MAX,
                         DIV_DT_TOUR
                     )
                     VALUES (
                         '-101',
                         '-101',
                         '-101',
                         'INC',
                         'Inconnue',
                         '0',
                         'D',
                         'T',
                         '0',
                         '0',
                         'L',
                         '',
                         'SPIDD',
                         '',
                         '',
                         '',
                         '0',
                         '0',
                         '0',
                         '0',
                         '0',
                         '0',
                         '12/05/2003 00:00:00'
                     );


-- Table : EPREUVE
DROP TABLE IF EXISTS EPREUVE;

CREATE TABLE EPREUVE (
    EPRV_ID,
    ORGA_ID,
    EPR_EPRV_ID,
    EPRV_CD,
    EPRV_LB_COURT,
    EPRV_LB,
    EPRV_FG,
    EPRV_CM,
    EPRV_LB_USER_MODIF
);

INSERT INTO EPREUVE (
                        EPRV_ID,
                        ORGA_ID,
                        EPR_EPRV_ID,
                        EPRV_CD,
                        EPRV_LB_COURT,
                        EPRV_LB,
                        EPRV_FG,
                        EPRV_CM,
                        EPRV_LB_USER_MODIF
                    )
                    VALUES (
                        '-101',
                        '-101',
                        '',
                        'IN',
                        'Inc',
                        'Inconnu',
                        'I',
                        '',
                        'SPIDD'
                    );


-- Table : GRILLE_DETAIL
DROP TABLE IF EXISTS GRILLE_DETAIL;

CREATE TABLE GRILLE_DETAIL (
    DGRIL_ID_DETAIL,
    DGRIL_NB_JOURNEE,
    DGRIL_NB_EQUIPE1,
    DGRIL_NB_EQUIPE2,
    GRIL_ID_RENC,
    BL_MAJ
);

INSERT INTO GRILLE_DETAIL (
                              DGRIL_ID_DETAIL,
                              DGRIL_NB_JOURNEE,
                              DGRIL_NB_EQUIPE1,
                              DGRIL_NB_EQUIPE2,
                              GRIL_ID_RENC,
                              BL_MAJ
                          )
                          VALUES (
                              '1531',
                              '1',
                              '1',
                              '4',
                              '1037',
                              '1'
                          );

INSERT INTO GRILLE_DETAIL (
                              DGRIL_ID_DETAIL,
                              DGRIL_NB_JOURNEE,
                              DGRIL_NB_EQUIPE1,
                              DGRIL_NB_EQUIPE2,
                              GRIL_ID_RENC,
                              BL_MAJ
                          )
                          VALUES (
                              '1532',
                              '1',
                              '2',
                              '3',
                              '1037',
                              '1'
                          );

INSERT INTO GRILLE_DETAIL (
                              DGRIL_ID_DETAIL,
                              DGRIL_NB_JOURNEE,
                              DGRIL_NB_EQUIPE1,
                              DGRIL_NB_EQUIPE2,
                              GRIL_ID_RENC,
                              BL_MAJ
                          )
                          VALUES (
                              '1533',
                              '2',
                              '1',
                              '3',
                              '1037',
                              '1'
                          );

INSERT INTO GRILLE_DETAIL (
                              DGRIL_ID_DETAIL,
                              DGRIL_NB_JOURNEE,
                              DGRIL_NB_EQUIPE1,
                              DGRIL_NB_EQUIPE2,
                              GRIL_ID_RENC,
                              BL_MAJ
                          )
                          VALUES (
                              '1534',
                              '2',
                              '2',
                              '4',
                              '1037',
                              '1'
                          );

INSERT INTO GRILLE_DETAIL (
                              DGRIL_ID_DETAIL,
                              DGRIL_NB_JOURNEE,
                              DGRIL_NB_EQUIPE1,
                              DGRIL_NB_EQUIPE2,
                              GRIL_ID_RENC,
                              BL_MAJ
                          )
                          VALUES (
                              '1535',
                              '3',
                              '1',
                              '2',
                              '1037',
                              '1'
                          );

INSERT INTO GRILLE_DETAIL (
                              DGRIL_ID_DETAIL,
                              DGRIL_NB_JOURNEE,
                              DGRIL_NB_EQUIPE1,
                              DGRIL_NB_EQUIPE2,
                              GRIL_ID_RENC,
                              BL_MAJ
                          )
                          VALUES (
                              '1536',
                              '3',
                              '3',
                              '4',
                              '1037',
                              '1'
                          );

INSERT INTO GRILLE_DETAIL (
                              DGRIL_ID_DETAIL,
                              DGRIL_NB_JOURNEE,
                              DGRIL_NB_EQUIPE1,
                              DGRIL_NB_EQUIPE2,
                              GRIL_ID_RENC,
                              BL_MAJ
                          )
                          VALUES (
                              '1537',
                              '1',
                              '1',
                              '6',
                              '1038',
                              '1'
                          );

INSERT INTO GRILLE_DETAIL (
                              DGRIL_ID_DETAIL,
                              DGRIL_NB_JOURNEE,
                              DGRIL_NB_EQUIPE1,
                              DGRIL_NB_EQUIPE2,
                              GRIL_ID_RENC,
                              BL_MAJ
                          )
                          VALUES (
                              '1538',
                              '1',
                              '2',
                              '5',
                              '1038',
                              '1'
                          );

INSERT INTO GRILLE_DETAIL (
                              DGRIL_ID_DETAIL,
                              DGRIL_NB_JOURNEE,
                              DGRIL_NB_EQUIPE1,
                              DGRIL_NB_EQUIPE2,
                              GRIL_ID_RENC,
                              BL_MAJ
                          )
                          VALUES (
                              '1539',
                              '1',
                              '3',
                              '4',
                              '1038',
                              '1'
                          );

INSERT INTO GRILLE_DETAIL (
                              DGRIL_ID_DETAIL,
                              DGRIL_NB_JOURNEE,
                              DGRIL_NB_EQUIPE1,
                              DGRIL_NB_EQUIPE2,
                              GRIL_ID_RENC,
                              BL_MAJ
                          )
                          VALUES (
                              '1540',
                              '2',
                              '1',
                              '5',
                              '1038',
                              '1'
                          );

INSERT INTO GRILLE_DETAIL (
                              DGRIL_ID_DETAIL,
                              DGRIL_NB_JOURNEE,
                              DGRIL_NB_EQUIPE1,
                              DGRIL_NB_EQUIPE2,
                              GRIL_ID_RENC,
                              BL_MAJ
                          )
                          VALUES (
                              '1541',
                              '2',
                              '4',
                              '6',
                              '1038',
                              '1'
                          );

INSERT INTO GRILLE_DETAIL (
                              DGRIL_ID_DETAIL,
                              DGRIL_NB_JOURNEE,
                              DGRIL_NB_EQUIPE1,
                              DGRIL_NB_EQUIPE2,
                              GRIL_ID_RENC,
                              BL_MAJ
                          )
                          VALUES (
                              '1542',
                              '2',
                              '2',
                              '3',
                              '1038',
                              '1'
                          );

INSERT INTO GRILLE_DETAIL (
                              DGRIL_ID_DETAIL,
                              DGRIL_NB_JOURNEE,
                              DGRIL_NB_EQUIPE1,
                              DGRIL_NB_EQUIPE2,
                              GRIL_ID_RENC,
                              BL_MAJ
                          )
                          VALUES (
                              '1543',
                              '3',
                              '1',
                              '4',
                              '1038',
                              '1'
                          );

INSERT INTO GRILLE_DETAIL (
                              DGRIL_ID_DETAIL,
                              DGRIL_NB_JOURNEE,
                              DGRIL_NB_EQUIPE1,
                              DGRIL_NB_EQUIPE2,
                              GRIL_ID_RENC,
                              BL_MAJ
                          )
                          VALUES (
                              '1544',
                              '3',
                              '3',
                              '5',
                              '1038',
                              '1'
                          );

INSERT INTO GRILLE_DETAIL (
                              DGRIL_ID_DETAIL,
                              DGRIL_NB_JOURNEE,
                              DGRIL_NB_EQUIPE1,
                              DGRIL_NB_EQUIPE2,
                              GRIL_ID_RENC,
                              BL_MAJ
                          )
                          VALUES (
                              '1545',
                              '3',
                              '2',
                              '6',
                              '1038',
                              '1'
                          );

INSERT INTO GRILLE_DETAIL (
                              DGRIL_ID_DETAIL,
                              DGRIL_NB_JOURNEE,
                              DGRIL_NB_EQUIPE1,
                              DGRIL_NB_EQUIPE2,
                              GRIL_ID_RENC,
                              BL_MAJ
                          )
                          VALUES (
                              '1546',
                              '4',
                              '1',
                              '3',
                              '1038',
                              '1'
                          );

INSERT INTO GRILLE_DETAIL (
                              DGRIL_ID_DETAIL,
                              DGRIL_NB_JOURNEE,
                              DGRIL_NB_EQUIPE1,
                              DGRIL_NB_EQUIPE2,
                              GRIL_ID_RENC,
                              BL_MAJ
                          )
                          VALUES (
                              '1547',
                              '4',
                              '2',
                              '4',
                              '1038',
                              '1'
                          );

INSERT INTO GRILLE_DETAIL (
                              DGRIL_ID_DETAIL,
                              DGRIL_NB_JOURNEE,
                              DGRIL_NB_EQUIPE1,
                              DGRIL_NB_EQUIPE2,
                              GRIL_ID_RENC,
                              BL_MAJ
                          )
                          VALUES (
                              '1548',
                              '4',
                              '5',
                              '6',
                              '1038',
                              '1'
                          );

INSERT INTO GRILLE_DETAIL (
                              DGRIL_ID_DETAIL,
                              DGRIL_NB_JOURNEE,
                              DGRIL_NB_EQUIPE1,
                              DGRIL_NB_EQUIPE2,
                              GRIL_ID_RENC,
                              BL_MAJ
                          )
                          VALUES (
                              '1549',
                              '5',
                              '1',
                              '2',
                              '1038',
                              '1'
                          );

INSERT INTO GRILLE_DETAIL (
                              DGRIL_ID_DETAIL,
                              DGRIL_NB_JOURNEE,
                              DGRIL_NB_EQUIPE1,
                              DGRIL_NB_EQUIPE2,
                              GRIL_ID_RENC,
                              BL_MAJ
                          )
                          VALUES (
                              '1550',
                              '5',
                              '3',
                              '6',
                              '1038',
                              '1'
                          );

INSERT INTO GRILLE_DETAIL (
                              DGRIL_ID_DETAIL,
                              DGRIL_NB_JOURNEE,
                              DGRIL_NB_EQUIPE1,
                              DGRIL_NB_EQUIPE2,
                              GRIL_ID_RENC,
                              BL_MAJ
                          )
                          VALUES (
                              '1551',
                              '5',
                              '4',
                              '5',
                              '1038',
                              '1'
                          );

INSERT INTO GRILLE_DETAIL (
                              DGRIL_ID_DETAIL,
                              DGRIL_NB_JOURNEE,
                              DGRIL_NB_EQUIPE1,
                              DGRIL_NB_EQUIPE2,
                              GRIL_ID_RENC,
                              BL_MAJ
                          )
                          VALUES (
                              '4112',
                              '1',
                              '1',
                              '3',
                              '3049',
                              '1'
                          );

INSERT INTO GRILLE_DETAIL (
                              DGRIL_ID_DETAIL,
                              DGRIL_NB_JOURNEE,
                              DGRIL_NB_EQUIPE1,
                              DGRIL_NB_EQUIPE2,
                              GRIL_ID_RENC,
                              BL_MAJ
                          )
                          VALUES (
                              '4113',
                              '1',
                              '-1',
                              '-1',
                              '3049',
                              '1'
                          );

INSERT INTO GRILLE_DETAIL (
                              DGRIL_ID_DETAIL,
                              DGRIL_NB_JOURNEE,
                              DGRIL_NB_EQUIPE1,
                              DGRIL_NB_EQUIPE2,
                              GRIL_ID_RENC,
                              BL_MAJ
                          )
                          VALUES (
                              '4114',
                              '2',
                              '2',
                              '3',
                              '3049',
                              '1'
                          );

INSERT INTO GRILLE_DETAIL (
                              DGRIL_ID_DETAIL,
                              DGRIL_NB_JOURNEE,
                              DGRIL_NB_EQUIPE1,
                              DGRIL_NB_EQUIPE2,
                              GRIL_ID_RENC,
                              BL_MAJ
                          )
                          VALUES (
                              '4115',
                              '2',
                              '-1',
                              '-1',
                              '3049',
                              '1'
                          );

INSERT INTO GRILLE_DETAIL (
                              DGRIL_ID_DETAIL,
                              DGRIL_NB_JOURNEE,
                              DGRIL_NB_EQUIPE1,
                              DGRIL_NB_EQUIPE2,
                              GRIL_ID_RENC,
                              BL_MAJ
                          )
                          VALUES (
                              '4116',
                              '3',
                              '1',
                              '2',
                              '3049',
                              '1'
                          );

INSERT INTO GRILLE_DETAIL (
                              DGRIL_ID_DETAIL,
                              DGRIL_NB_JOURNEE,
                              DGRIL_NB_EQUIPE1,
                              DGRIL_NB_EQUIPE2,
                              GRIL_ID_RENC,
                              BL_MAJ
                          )
                          VALUES (
                              '4117',
                              '3',
                              '-1',
                              '-1',
                              '3049',
                              '1'
                          );

INSERT INTO GRILLE_DETAIL (
                              DGRIL_ID_DETAIL,
                              DGRIL_NB_JOURNEE,
                              DGRIL_NB_EQUIPE1,
                              DGRIL_NB_EQUIPE2,
                              GRIL_ID_RENC,
                              BL_MAJ
                          )
                          VALUES (
                              '4118',
                              '1',
                              '2',
                              '5',
                              '3050',
                              '1'
                          );

INSERT INTO GRILLE_DETAIL (
                              DGRIL_ID_DETAIL,
                              DGRIL_NB_JOURNEE,
                              DGRIL_NB_EQUIPE1,
                              DGRIL_NB_EQUIPE2,
                              GRIL_ID_RENC,
                              BL_MAJ
                          )
                          VALUES (
                              '4119',
                              '1',
                              '3',
                              '4',
                              '3050',
                              '1'
                          );

INSERT INTO GRILLE_DETAIL (
                              DGRIL_ID_DETAIL,
                              DGRIL_NB_JOURNEE,
                              DGRIL_NB_EQUIPE1,
                              DGRIL_NB_EQUIPE2,
                              GRIL_ID_RENC,
                              BL_MAJ
                          )
                          VALUES (
                              '4120',
                              '1',
                              '-1',
                              '-1',
                              '3050',
                              '1'
                          );

INSERT INTO GRILLE_DETAIL (
                              DGRIL_ID_DETAIL,
                              DGRIL_NB_JOURNEE,
                              DGRIL_NB_EQUIPE1,
                              DGRIL_NB_EQUIPE2,
                              GRIL_ID_RENC,
                              BL_MAJ
                          )
                          VALUES (
                              '4121',
                              '2',
                              '1',
                              '5',
                              '3050',
                              '1'
                          );

INSERT INTO GRILLE_DETAIL (
                              DGRIL_ID_DETAIL,
                              DGRIL_NB_JOURNEE,
                              DGRIL_NB_EQUIPE1,
                              DGRIL_NB_EQUIPE2,
                              GRIL_ID_RENC,
                              BL_MAJ
                          )
                          VALUES (
                              '4122',
                              '2',
                              '2',
                              '3',
                              '3050',
                              '1'
                          );

INSERT INTO GRILLE_DETAIL (
                              DGRIL_ID_DETAIL,
                              DGRIL_NB_JOURNEE,
                              DGRIL_NB_EQUIPE1,
                              DGRIL_NB_EQUIPE2,
                              GRIL_ID_RENC,
                              BL_MAJ
                          )
                          VALUES (
                              '4123',
                              '2',
                              '-1',
                              '-1',
                              '3050',
                              '1'
                          );

INSERT INTO GRILLE_DETAIL (
                              DGRIL_ID_DETAIL,
                              DGRIL_NB_JOURNEE,
                              DGRIL_NB_EQUIPE1,
                              DGRIL_NB_EQUIPE2,
                              GRIL_ID_RENC,
                              BL_MAJ
                          )
                          VALUES (
                              '4124',
                              '3',
                              '1',
                              '4',
                              '3050',
                              '1'
                          );

INSERT INTO GRILLE_DETAIL (
                              DGRIL_ID_DETAIL,
                              DGRIL_NB_JOURNEE,
                              DGRIL_NB_EQUIPE1,
                              DGRIL_NB_EQUIPE2,
                              GRIL_ID_RENC,
                              BL_MAJ
                          )
                          VALUES (
                              '4125',
                              '3',
                              '3',
                              '5',
                              '3050',
                              '1'
                          );

INSERT INTO GRILLE_DETAIL (
                              DGRIL_ID_DETAIL,
                              DGRIL_NB_JOURNEE,
                              DGRIL_NB_EQUIPE1,
                              DGRIL_NB_EQUIPE2,
                              GRIL_ID_RENC,
                              BL_MAJ
                          )
                          VALUES (
                              '4126',
                              '3',
                              '-1',
                              '-1',
                              '3050',
                              '1'
                          );

INSERT INTO GRILLE_DETAIL (
                              DGRIL_ID_DETAIL,
                              DGRIL_NB_JOURNEE,
                              DGRIL_NB_EQUIPE1,
                              DGRIL_NB_EQUIPE2,
                              GRIL_ID_RENC,
                              BL_MAJ
                          )
                          VALUES (
                              '4127',
                              '4',
                              '1',
                              '3',
                              '3050',
                              '1'
                          );

INSERT INTO GRILLE_DETAIL (
                              DGRIL_ID_DETAIL,
                              DGRIL_NB_JOURNEE,
                              DGRIL_NB_EQUIPE1,
                              DGRIL_NB_EQUIPE2,
                              GRIL_ID_RENC,
                              BL_MAJ
                          )
                          VALUES (
                              '4128',
                              '4',
                              '2',
                              '4',
                              '3050',
                              '1'
                          );

INSERT INTO GRILLE_DETAIL (
                              DGRIL_ID_DETAIL,
                              DGRIL_NB_JOURNEE,
                              DGRIL_NB_EQUIPE1,
                              DGRIL_NB_EQUIPE2,
                              GRIL_ID_RENC,
                              BL_MAJ
                          )
                          VALUES (
                              '4129',
                              '4',
                              '-1',
                              '-1',
                              '3050',
                              '1'
                          );

INSERT INTO GRILLE_DETAIL (
                              DGRIL_ID_DETAIL,
                              DGRIL_NB_JOURNEE,
                              DGRIL_NB_EQUIPE1,
                              DGRIL_NB_EQUIPE2,
                              GRIL_ID_RENC,
                              BL_MAJ
                          )
                          VALUES (
                              '4130',
                              '5',
                              '1',
                              '2',
                              '3050',
                              '1'
                          );

INSERT INTO GRILLE_DETAIL (
                              DGRIL_ID_DETAIL,
                              DGRIL_NB_JOURNEE,
                              DGRIL_NB_EQUIPE1,
                              DGRIL_NB_EQUIPE2,
                              GRIL_ID_RENC,
                              BL_MAJ
                          )
                          VALUES (
                              '4131',
                              '5',
                              '4',
                              '5',
                              '3050',
                              '1'
                          );

INSERT INTO GRILLE_DETAIL (
                              DGRIL_ID_DETAIL,
                              DGRIL_NB_JOURNEE,
                              DGRIL_NB_EQUIPE1,
                              DGRIL_NB_EQUIPE2,
                              GRIL_ID_RENC,
                              BL_MAJ
                          )
                          VALUES (
                              '4132',
                              '5',
                              '-1',
                              '-1',
                              '3050',
                              '1'
                          );

INSERT INTO GRILLE_DETAIL (
                              DGRIL_ID_DETAIL,
                              DGRIL_NB_JOURNEE,
                              DGRIL_NB_EQUIPE1,
                              DGRIL_NB_EQUIPE2,
                              GRIL_ID_RENC,
                              BL_MAJ
                          )
                          VALUES (
                              '5274',
                              '1',
                              '2',
                              '7',
                              '3105',
                              '1'
                          );

INSERT INTO GRILLE_DETAIL (
                              DGRIL_ID_DETAIL,
                              DGRIL_NB_JOURNEE,
                              DGRIL_NB_EQUIPE1,
                              DGRIL_NB_EQUIPE2,
                              GRIL_ID_RENC,
                              BL_MAJ
                          )
                          VALUES (
                              '5275',
                              '1',
                              '3',
                              '6',
                              '3105',
                              '1'
                          );

INSERT INTO GRILLE_DETAIL (
                              DGRIL_ID_DETAIL,
                              DGRIL_NB_JOURNEE,
                              DGRIL_NB_EQUIPE1,
                              DGRIL_NB_EQUIPE2,
                              GRIL_ID_RENC,
                              BL_MAJ
                          )
                          VALUES (
                              '5276',
                              '1',
                              '4',
                              '5',
                              '3105',
                              '1'
                          );

INSERT INTO GRILLE_DETAIL (
                              DGRIL_ID_DETAIL,
                              DGRIL_NB_JOURNEE,
                              DGRIL_NB_EQUIPE1,
                              DGRIL_NB_EQUIPE2,
                              GRIL_ID_RENC,
                              BL_MAJ
                          )
                          VALUES (
                              '5277',
                              '2',
                              '1',
                              '7',
                              '3105',
                              '1'
                          );

INSERT INTO GRILLE_DETAIL (
                              DGRIL_ID_DETAIL,
                              DGRIL_NB_JOURNEE,
                              DGRIL_NB_EQUIPE1,
                              DGRIL_NB_EQUIPE2,
                              GRIL_ID_RENC,
                              BL_MAJ
                          )
                          VALUES (
                              '5278',
                              '2',
                              '2',
                              '5',
                              '3105',
                              '1'
                          );

INSERT INTO GRILLE_DETAIL (
                              DGRIL_ID_DETAIL,
                              DGRIL_NB_JOURNEE,
                              DGRIL_NB_EQUIPE1,
                              DGRIL_NB_EQUIPE2,
                              GRIL_ID_RENC,
                              BL_MAJ
                          )
                          VALUES (
                              '5279',
                              '2',
                              '3',
                              '4',
                              '3105',
                              '1'
                          );

INSERT INTO GRILLE_DETAIL (
                              DGRIL_ID_DETAIL,
                              DGRIL_NB_JOURNEE,
                              DGRIL_NB_EQUIPE1,
                              DGRIL_NB_EQUIPE2,
                              GRIL_ID_RENC,
                              BL_MAJ
                          )
                          VALUES (
                              '5280',
                              '2',
                              '6',
                              '-1',
                              '3105',
                              '1'
                          );

INSERT INTO GRILLE_DETAIL (
                              DGRIL_ID_DETAIL,
                              DGRIL_NB_JOURNEE,
                              DGRIL_NB_EQUIPE1,
                              DGRIL_NB_EQUIPE2,
                              GRIL_ID_RENC,
                              BL_MAJ
                          )
                          VALUES (
                              '5281',
                              '3',
                              '1',
                              '6',
                              '3105',
                              '1'
                          );

INSERT INTO GRILLE_DETAIL (
                              DGRIL_ID_DETAIL,
                              DGRIL_NB_JOURNEE,
                              DGRIL_NB_EQUIPE1,
                              DGRIL_NB_EQUIPE2,
                              GRIL_ID_RENC,
                              BL_MAJ
                          )
                          VALUES (
                              '5282',
                              '3',
                              '5',
                              '7',
                              '3105',
                              '1'
                          );

INSERT INTO GRILLE_DETAIL (
                              DGRIL_ID_DETAIL,
                              DGRIL_NB_JOURNEE,
                              DGRIL_NB_EQUIPE1,
                              DGRIL_NB_EQUIPE2,
                              GRIL_ID_RENC,
                              BL_MAJ
                          )
                          VALUES (
                              '5283',
                              '3',
                              '2',
                              '3',
                              '3105',
                              '1'
                          );

INSERT INTO GRILLE_DETAIL (
                              DGRIL_ID_DETAIL,
                              DGRIL_NB_JOURNEE,
                              DGRIL_NB_EQUIPE1,
                              DGRIL_NB_EQUIPE2,
                              GRIL_ID_RENC,
                              BL_MAJ
                          )
                          VALUES (
                              '5284',
                              '3',
                              '4',
                              '-1',
                              '3105',
                              '1'
                          );

INSERT INTO GRILLE_DETAIL (
                              DGRIL_ID_DETAIL,
                              DGRIL_NB_JOURNEE,
                              DGRIL_NB_EQUIPE1,
                              DGRIL_NB_EQUIPE2,
                              GRIL_ID_RENC,
                              BL_MAJ
                          )
                          VALUES (
                              '5285',
                              '4',
                              '1',
                              '5',
                              '3105',
                              '1'
                          );

INSERT INTO GRILLE_DETAIL (
                              DGRIL_ID_DETAIL,
                              DGRIL_NB_JOURNEE,
                              DGRIL_NB_EQUIPE1,
                              DGRIL_NB_EQUIPE2,
                              GRIL_ID_RENC,
                              BL_MAJ
                          )
                          VALUES (
                              '5286',
                              '4',
                              '4',
                              '6',
                              '3105',
                              '1'
                          );

INSERT INTO GRILLE_DETAIL (
                              DGRIL_ID_DETAIL,
                              DGRIL_NB_JOURNEE,
                              DGRIL_NB_EQUIPE1,
                              DGRIL_NB_EQUIPE2,
                              GRIL_ID_RENC,
                              BL_MAJ
                          )
                          VALUES (
                              '5287',
                              '4',
                              '3',
                              '7',
                              '3105',
                              '1'
                          );

INSERT INTO GRILLE_DETAIL (
                              DGRIL_ID_DETAIL,
                              DGRIL_NB_JOURNEE,
                              DGRIL_NB_EQUIPE1,
                              DGRIL_NB_EQUIPE2,
                              GRIL_ID_RENC,
                              BL_MAJ
                          )
                          VALUES (
                              '5288',
                              '4',
                              '2',
                              '-1',
                              '3105',
                              '1'
                          );

INSERT INTO GRILLE_DETAIL (
                              DGRIL_ID_DETAIL,
                              DGRIL_NB_JOURNEE,
                              DGRIL_NB_EQUIPE1,
                              DGRIL_NB_EQUIPE2,
                              GRIL_ID_RENC,
                              BL_MAJ
                          )
                          VALUES (
                              '5273',
                              '1',
                              '1',
                              '-1',
                              '3105',
                              '1'
                          );

INSERT INTO GRILLE_DETAIL (
                              DGRIL_ID_DETAIL,
                              DGRIL_NB_JOURNEE,
                              DGRIL_NB_EQUIPE1,
                              DGRIL_NB_EQUIPE2,
                              GRIL_ID_RENC,
                              BL_MAJ
                          )
                          VALUES (
                              '5289',
                              '5',
                              '1',
                              '4',
                              '3105',
                              '1'
                          );

INSERT INTO GRILLE_DETAIL (
                              DGRIL_ID_DETAIL,
                              DGRIL_NB_JOURNEE,
                              DGRIL_NB_EQUIPE1,
                              DGRIL_NB_EQUIPE2,
                              GRIL_ID_RENC,
                              BL_MAJ
                          )
                          VALUES (
                              '5290',
                              '5',
                              '3',
                              '5',
                              '3105',
                              '1'
                          );

INSERT INTO GRILLE_DETAIL (
                              DGRIL_ID_DETAIL,
                              DGRIL_NB_JOURNEE,
                              DGRIL_NB_EQUIPE1,
                              DGRIL_NB_EQUIPE2,
                              GRIL_ID_RENC,
                              BL_MAJ
                          )
                          VALUES (
                              '5291',
                              '5',
                              '2',
                              '6',
                              '3105',
                              '1'
                          );

INSERT INTO GRILLE_DETAIL (
                              DGRIL_ID_DETAIL,
                              DGRIL_NB_JOURNEE,
                              DGRIL_NB_EQUIPE1,
                              DGRIL_NB_EQUIPE2,
                              GRIL_ID_RENC,
                              BL_MAJ
                          )
                          VALUES (
                              '5292',
                              '5',
                              '7',
                              '-1',
                              '3105',
                              '1'
                          );

INSERT INTO GRILLE_DETAIL (
                              DGRIL_ID_DETAIL,
                              DGRIL_NB_JOURNEE,
                              DGRIL_NB_EQUIPE1,
                              DGRIL_NB_EQUIPE2,
                              GRIL_ID_RENC,
                              BL_MAJ
                          )
                          VALUES (
                              '5293',
                              '6',
                              '1',
                              '3',
                              '3105',
                              '1'
                          );

INSERT INTO GRILLE_DETAIL (
                              DGRIL_ID_DETAIL,
                              DGRIL_NB_JOURNEE,
                              DGRIL_NB_EQUIPE1,
                              DGRIL_NB_EQUIPE2,
                              GRIL_ID_RENC,
                              BL_MAJ
                          )
                          VALUES (
                              '5294',
                              '6',
                              '2',
                              '4',
                              '3105',
                              '1'
                          );

INSERT INTO GRILLE_DETAIL (
                              DGRIL_ID_DETAIL,
                              DGRIL_NB_JOURNEE,
                              DGRIL_NB_EQUIPE1,
                              DGRIL_NB_EQUIPE2,
                              GRIL_ID_RENC,
                              BL_MAJ
                          )
                          VALUES (
                              '5295',
                              '6',
                              '6',
                              '7',
                              '3105',
                              '1'
                          );

INSERT INTO GRILLE_DETAIL (
                              DGRIL_ID_DETAIL,
                              DGRIL_NB_JOURNEE,
                              DGRIL_NB_EQUIPE1,
                              DGRIL_NB_EQUIPE2,
                              GRIL_ID_RENC,
                              BL_MAJ
                          )
                          VALUES (
                              '5296',
                              '6',
                              '5',
                              '-1',
                              '3105',
                              '1'
                          );

INSERT INTO GRILLE_DETAIL (
                              DGRIL_ID_DETAIL,
                              DGRIL_NB_JOURNEE,
                              DGRIL_NB_EQUIPE1,
                              DGRIL_NB_EQUIPE2,
                              GRIL_ID_RENC,
                              BL_MAJ
                          )
                          VALUES (
                              '5297',
                              '7',
                              '1',
                              '2',
                              '3105',
                              '1'
                          );

INSERT INTO GRILLE_DETAIL (
                              DGRIL_ID_DETAIL,
                              DGRIL_NB_JOURNEE,
                              DGRIL_NB_EQUIPE1,
                              DGRIL_NB_EQUIPE2,
                              GRIL_ID_RENC,
                              BL_MAJ
                          )
                          VALUES (
                              '5298',
                              '7',
                              '4',
                              '7',
                              '3105',
                              '1'
                          );

INSERT INTO GRILLE_DETAIL (
                              DGRIL_ID_DETAIL,
                              DGRIL_NB_JOURNEE,
                              DGRIL_NB_EQUIPE1,
                              DGRIL_NB_EQUIPE2,
                              GRIL_ID_RENC,
                              BL_MAJ
                          )
                          VALUES (
                              '5299',
                              '7',
                              '5',
                              '6',
                              '3105',
                              '1'
                          );

INSERT INTO GRILLE_DETAIL (
                              DGRIL_ID_DETAIL,
                              DGRIL_NB_JOURNEE,
                              DGRIL_NB_EQUIPE1,
                              DGRIL_NB_EQUIPE2,
                              GRIL_ID_RENC,
                              BL_MAJ
                          )
                          VALUES (
                              '5300',
                              '7',
                              '3',
                              '-1',
                              '3105',
                              '1'
                          );

INSERT INTO GRILLE_DETAIL (
                              DGRIL_ID_DETAIL,
                              DGRIL_NB_JOURNEE,
                              DGRIL_NB_EQUIPE1,
                              DGRIL_NB_EQUIPE2,
                              GRIL_ID_RENC,
                              BL_MAJ
                          )
                          VALUES (
                              '13822',
                              '1',
                              '1',
                              '8',
                              '3517',
                              '1'
                          );

INSERT INTO GRILLE_DETAIL (
                              DGRIL_ID_DETAIL,
                              DGRIL_NB_JOURNEE,
                              DGRIL_NB_EQUIPE1,
                              DGRIL_NB_EQUIPE2,
                              GRIL_ID_RENC,
                              BL_MAJ
                          )
                          VALUES (
                              '13823',
                              '1',
                              '2',
                              '7',
                              '3517',
                              '1'
                          );

INSERT INTO GRILLE_DETAIL (
                              DGRIL_ID_DETAIL,
                              DGRIL_NB_JOURNEE,
                              DGRIL_NB_EQUIPE1,
                              DGRIL_NB_EQUIPE2,
                              GRIL_ID_RENC,
                              BL_MAJ
                          )
                          VALUES (
                              '13824',
                              '1',
                              '3',
                              '6',
                              '3517',
                              '1'
                          );

INSERT INTO GRILLE_DETAIL (
                              DGRIL_ID_DETAIL,
                              DGRIL_NB_JOURNEE,
                              DGRIL_NB_EQUIPE1,
                              DGRIL_NB_EQUIPE2,
                              GRIL_ID_RENC,
                              BL_MAJ
                          )
                          VALUES (
                              '13825',
                              '1',
                              '4',
                              '5',
                              '3517',
                              '1'
                          );

INSERT INTO GRILLE_DETAIL (
                              DGRIL_ID_DETAIL,
                              DGRIL_NB_JOURNEE,
                              DGRIL_NB_EQUIPE1,
                              DGRIL_NB_EQUIPE2,
                              GRIL_ID_RENC,
                              BL_MAJ
                          )
                          VALUES (
                              '13826',
                              '2',
                              '1',
                              '7',
                              '3517',
                              '1'
                          );

INSERT INTO GRILLE_DETAIL (
                              DGRIL_ID_DETAIL,
                              DGRIL_NB_JOURNEE,
                              DGRIL_NB_EQUIPE1,
                              DGRIL_NB_EQUIPE2,
                              GRIL_ID_RENC,
                              BL_MAJ
                          )
                          VALUES (
                              '13827',
                              '2',
                              '6',
                              '8',
                              '3517',
                              '1'
                          );

INSERT INTO GRILLE_DETAIL (
                              DGRIL_ID_DETAIL,
                              DGRIL_NB_JOURNEE,
                              DGRIL_NB_EQUIPE1,
                              DGRIL_NB_EQUIPE2,
                              GRIL_ID_RENC,
                              BL_MAJ
                          )
                          VALUES (
                              '13828',
                              '2',
                              '2',
                              '5',
                              '3517',
                              '1'
                          );

INSERT INTO GRILLE_DETAIL (
                              DGRIL_ID_DETAIL,
                              DGRIL_NB_JOURNEE,
                              DGRIL_NB_EQUIPE1,
                              DGRIL_NB_EQUIPE2,
                              GRIL_ID_RENC,
                              BL_MAJ
                          )
                          VALUES (
                              '13829',
                              '2',
                              '3',
                              '4',
                              '3517',
                              '1'
                          );

INSERT INTO GRILLE_DETAIL (
                              DGRIL_ID_DETAIL,
                              DGRIL_NB_JOURNEE,
                              DGRIL_NB_EQUIPE1,
                              DGRIL_NB_EQUIPE2,
                              GRIL_ID_RENC,
                              BL_MAJ
                          )
                          VALUES (
                              '13830',
                              '3',
                              '1',
                              '6',
                              '3517',
                              '1'
                          );

INSERT INTO GRILLE_DETAIL (
                              DGRIL_ID_DETAIL,
                              DGRIL_NB_JOURNEE,
                              DGRIL_NB_EQUIPE1,
                              DGRIL_NB_EQUIPE2,
                              GRIL_ID_RENC,
                              BL_MAJ
                          )
                          VALUES (
                              '13831',
                              '3',
                              '5',
                              '7',
                              '3517',
                              '1'
                          );

INSERT INTO GRILLE_DETAIL (
                              DGRIL_ID_DETAIL,
                              DGRIL_NB_JOURNEE,
                              DGRIL_NB_EQUIPE1,
                              DGRIL_NB_EQUIPE2,
                              GRIL_ID_RENC,
                              BL_MAJ
                          )
                          VALUES (
                              '13832',
                              '3',
                              '4',
                              '8',
                              '3517',
                              '1'
                          );

INSERT INTO GRILLE_DETAIL (
                              DGRIL_ID_DETAIL,
                              DGRIL_NB_JOURNEE,
                              DGRIL_NB_EQUIPE1,
                              DGRIL_NB_EQUIPE2,
                              GRIL_ID_RENC,
                              BL_MAJ
                          )
                          VALUES (
                              '13833',
                              '3',
                              '2',
                              '3',
                              '3517',
                              '1'
                          );

INSERT INTO GRILLE_DETAIL (
                              DGRIL_ID_DETAIL,
                              DGRIL_NB_JOURNEE,
                              DGRIL_NB_EQUIPE1,
                              DGRIL_NB_EQUIPE2,
                              GRIL_ID_RENC,
                              BL_MAJ
                          )
                          VALUES (
                              '13834',
                              '4',
                              '1',
                              '5',
                              '3517',
                              '1'
                          );

INSERT INTO GRILLE_DETAIL (
                              DGRIL_ID_DETAIL,
                              DGRIL_NB_JOURNEE,
                              DGRIL_NB_EQUIPE1,
                              DGRIL_NB_EQUIPE2,
                              GRIL_ID_RENC,
                              BL_MAJ
                          )
                          VALUES (
                              '13835',
                              '4',
                              '4',
                              '6',
                              '3517',
                              '1'
                          );

INSERT INTO GRILLE_DETAIL (
                              DGRIL_ID_DETAIL,
                              DGRIL_NB_JOURNEE,
                              DGRIL_NB_EQUIPE1,
                              DGRIL_NB_EQUIPE2,
                              GRIL_ID_RENC,
                              BL_MAJ
                          )
                          VALUES (
                              '13836',
                              '4',
                              '3',
                              '7',
                              '3517',
                              '1'
                          );

INSERT INTO GRILLE_DETAIL (
                              DGRIL_ID_DETAIL,
                              DGRIL_NB_JOURNEE,
                              DGRIL_NB_EQUIPE1,
                              DGRIL_NB_EQUIPE2,
                              GRIL_ID_RENC,
                              BL_MAJ
                          )
                          VALUES (
                              '13837',
                              '4',
                              '2',
                              '8',
                              '3517',
                              '1'
                          );

INSERT INTO GRILLE_DETAIL (
                              DGRIL_ID_DETAIL,
                              DGRIL_NB_JOURNEE,
                              DGRIL_NB_EQUIPE1,
                              DGRIL_NB_EQUIPE2,
                              GRIL_ID_RENC,
                              BL_MAJ
                          )
                          VALUES (
                              '13838',
                              '5',
                              '1',
                              '4',
                              '3517',
                              '1'
                          );

INSERT INTO GRILLE_DETAIL (
                              DGRIL_ID_DETAIL,
                              DGRIL_NB_JOURNEE,
                              DGRIL_NB_EQUIPE1,
                              DGRIL_NB_EQUIPE2,
                              GRIL_ID_RENC,
                              BL_MAJ
                          )
                          VALUES (
                              '13839',
                              '5',
                              '3',
                              '5',
                              '3517',
                              '1'
                          );

INSERT INTO GRILLE_DETAIL (
                              DGRIL_ID_DETAIL,
                              DGRIL_NB_JOURNEE,
                              DGRIL_NB_EQUIPE1,
                              DGRIL_NB_EQUIPE2,
                              GRIL_ID_RENC,
                              BL_MAJ
                          )
                          VALUES (
                              '13840',
                              '5',
                              '2',
                              '6',
                              '3517',
                              '1'
                          );

INSERT INTO GRILLE_DETAIL (
                              DGRIL_ID_DETAIL,
                              DGRIL_NB_JOURNEE,
                              DGRIL_NB_EQUIPE1,
                              DGRIL_NB_EQUIPE2,
                              GRIL_ID_RENC,
                              BL_MAJ
                          )
                          VALUES (
                              '13841',
                              '5',
                              '7',
                              '8',
                              '3517',
                              '1'
                          );

INSERT INTO GRILLE_DETAIL (
                              DGRIL_ID_DETAIL,
                              DGRIL_NB_JOURNEE,
                              DGRIL_NB_EQUIPE1,
                              DGRIL_NB_EQUIPE2,
                              GRIL_ID_RENC,
                              BL_MAJ
                          )
                          VALUES (
                              '13842',
                              '6',
                              '1',
                              '3',
                              '3517',
                              '1'
                          );

INSERT INTO GRILLE_DETAIL (
                              DGRIL_ID_DETAIL,
                              DGRIL_NB_JOURNEE,
                              DGRIL_NB_EQUIPE1,
                              DGRIL_NB_EQUIPE2,
                              GRIL_ID_RENC,
                              BL_MAJ
                          )
                          VALUES (
                              '13843',
                              '6',
                              '2',
                              '4',
                              '3517',
                              '1'
                          );

INSERT INTO GRILLE_DETAIL (
                              DGRIL_ID_DETAIL,
                              DGRIL_NB_JOURNEE,
                              DGRIL_NB_EQUIPE1,
                              DGRIL_NB_EQUIPE2,
                              GRIL_ID_RENC,
                              BL_MAJ
                          )
                          VALUES (
                              '13844',
                              '6',
                              '5',
                              '8',
                              '3517',
                              '1'
                          );

INSERT INTO GRILLE_DETAIL (
                              DGRIL_ID_DETAIL,
                              DGRIL_NB_JOURNEE,
                              DGRIL_NB_EQUIPE1,
                              DGRIL_NB_EQUIPE2,
                              GRIL_ID_RENC,
                              BL_MAJ
                          )
                          VALUES (
                              '13845',
                              '6',
                              '6',
                              '7',
                              '3517',
                              '1'
                          );

INSERT INTO GRILLE_DETAIL (
                              DGRIL_ID_DETAIL,
                              DGRIL_NB_JOURNEE,
                              DGRIL_NB_EQUIPE1,
                              DGRIL_NB_EQUIPE2,
                              GRIL_ID_RENC,
                              BL_MAJ
                          )
                          VALUES (
                              '13846',
                              '7',
                              '1',
                              '2',
                              '3517',
                              '1'
                          );

INSERT INTO GRILLE_DETAIL (
                              DGRIL_ID_DETAIL,
                              DGRIL_NB_JOURNEE,
                              DGRIL_NB_EQUIPE1,
                              DGRIL_NB_EQUIPE2,
                              GRIL_ID_RENC,
                              BL_MAJ
                          )
                          VALUES (
                              '13847',
                              '7',
                              '3',
                              '8',
                              '3517',
                              '1'
                          );

INSERT INTO GRILLE_DETAIL (
                              DGRIL_ID_DETAIL,
                              DGRIL_NB_JOURNEE,
                              DGRIL_NB_EQUIPE1,
                              DGRIL_NB_EQUIPE2,
                              GRIL_ID_RENC,
                              BL_MAJ
                          )
                          VALUES (
                              '13848',
                              '7',
                              '4',
                              '7',
                              '3517',
                              '1'
                          );

INSERT INTO GRILLE_DETAIL (
                              DGRIL_ID_DETAIL,
                              DGRIL_NB_JOURNEE,
                              DGRIL_NB_EQUIPE1,
                              DGRIL_NB_EQUIPE2,
                              GRIL_ID_RENC,
                              BL_MAJ
                          )
                          VALUES (
                              '13849',
                              '7',
                              '5',
                              '6',
                              '3517',
                              '1'
                          );

INSERT INTO GRILLE_DETAIL (
                              DGRIL_ID_DETAIL,
                              DGRIL_NB_JOURNEE,
                              DGRIL_NB_EQUIPE1,
                              DGRIL_NB_EQUIPE2,
                              GRIL_ID_RENC,
                              BL_MAJ
                          )
                          VALUES (
                              '13879',
                              '1',
                              '2',
                              '7',
                              '3520',
                              '1'
                          );

INSERT INTO GRILLE_DETAIL (
                              DGRIL_ID_DETAIL,
                              DGRIL_NB_JOURNEE,
                              DGRIL_NB_EQUIPE1,
                              DGRIL_NB_EQUIPE2,
                              GRIL_ID_RENC,
                              BL_MAJ
                          )
                          VALUES (
                              '13880',
                              '1',
                              '3',
                              '6',
                              '3520',
                              '1'
                          );

INSERT INTO GRILLE_DETAIL (
                              DGRIL_ID_DETAIL,
                              DGRIL_NB_JOURNEE,
                              DGRIL_NB_EQUIPE1,
                              DGRIL_NB_EQUIPE2,
                              GRIL_ID_RENC,
                              BL_MAJ
                          )
                          VALUES (
                              '13881',
                              '1',
                              '4',
                              '5',
                              '3520',
                              '1'
                          );

INSERT INTO GRILLE_DETAIL (
                              DGRIL_ID_DETAIL,
                              DGRIL_NB_JOURNEE,
                              DGRIL_NB_EQUIPE1,
                              DGRIL_NB_EQUIPE2,
                              GRIL_ID_RENC,
                              BL_MAJ
                          )
                          VALUES (
                              '13882',
                              '1',
                              '-1',
                              '-1',
                              '3520',
                              '1'
                          );

INSERT INTO GRILLE_DETAIL (
                              DGRIL_ID_DETAIL,
                              DGRIL_NB_JOURNEE,
                              DGRIL_NB_EQUIPE1,
                              DGRIL_NB_EQUIPE2,
                              GRIL_ID_RENC,
                              BL_MAJ
                          )
                          VALUES (
                              '13883',
                              '2',
                              '1',
                              '7',
                              '3520',
                              '1'
                          );

INSERT INTO GRILLE_DETAIL (
                              DGRIL_ID_DETAIL,
                              DGRIL_NB_JOURNEE,
                              DGRIL_NB_EQUIPE1,
                              DGRIL_NB_EQUIPE2,
                              GRIL_ID_RENC,
                              BL_MAJ
                          )
                          VALUES (
                              '13884',
                              '2',
                              '2',
                              '5',
                              '3520',
                              '1'
                          );

INSERT INTO GRILLE_DETAIL (
                              DGRIL_ID_DETAIL,
                              DGRIL_NB_JOURNEE,
                              DGRIL_NB_EQUIPE1,
                              DGRIL_NB_EQUIPE2,
                              GRIL_ID_RENC,
                              BL_MAJ
                          )
                          VALUES (
                              '13885',
                              '2',
                              '3',
                              '4',
                              '3520',
                              '1'
                          );

INSERT INTO GRILLE_DETAIL (
                              DGRIL_ID_DETAIL,
                              DGRIL_NB_JOURNEE,
                              DGRIL_NB_EQUIPE1,
                              DGRIL_NB_EQUIPE2,
                              GRIL_ID_RENC,
                              BL_MAJ
                          )
                          VALUES (
                              '13886',
                              '2',
                              '-1',
                              '-1',
                              '3520',
                              '1'
                          );

INSERT INTO GRILLE_DETAIL (
                              DGRIL_ID_DETAIL,
                              DGRIL_NB_JOURNEE,
                              DGRIL_NB_EQUIPE1,
                              DGRIL_NB_EQUIPE2,
                              GRIL_ID_RENC,
                              BL_MAJ
                          )
                          VALUES (
                              '13887',
                              '3',
                              '1',
                              '6',
                              '3520',
                              '1'
                          );

INSERT INTO GRILLE_DETAIL (
                              DGRIL_ID_DETAIL,
                              DGRIL_NB_JOURNEE,
                              DGRIL_NB_EQUIPE1,
                              DGRIL_NB_EQUIPE2,
                              GRIL_ID_RENC,
                              BL_MAJ
                          )
                          VALUES (
                              '13888',
                              '3',
                              '5',
                              '7',
                              '3520',
                              '1'
                          );

INSERT INTO GRILLE_DETAIL (
                              DGRIL_ID_DETAIL,
                              DGRIL_NB_JOURNEE,
                              DGRIL_NB_EQUIPE1,
                              DGRIL_NB_EQUIPE2,
                              GRIL_ID_RENC,
                              BL_MAJ
                          )
                          VALUES (
                              '13889',
                              '3',
                              '2',
                              '3',
                              '3520',
                              '1'
                          );

INSERT INTO GRILLE_DETAIL (
                              DGRIL_ID_DETAIL,
                              DGRIL_NB_JOURNEE,
                              DGRIL_NB_EQUIPE1,
                              DGRIL_NB_EQUIPE2,
                              GRIL_ID_RENC,
                              BL_MAJ
                          )
                          VALUES (
                              '13890',
                              '3',
                              '-1',
                              '-1',
                              '3520',
                              '1'
                          );

INSERT INTO GRILLE_DETAIL (
                              DGRIL_ID_DETAIL,
                              DGRIL_NB_JOURNEE,
                              DGRIL_NB_EQUIPE1,
                              DGRIL_NB_EQUIPE2,
                              GRIL_ID_RENC,
                              BL_MAJ
                          )
                          VALUES (
                              '13891',
                              '4',
                              '1',
                              '5',
                              '3520',
                              '1'
                          );

INSERT INTO GRILLE_DETAIL (
                              DGRIL_ID_DETAIL,
                              DGRIL_NB_JOURNEE,
                              DGRIL_NB_EQUIPE1,
                              DGRIL_NB_EQUIPE2,
                              GRIL_ID_RENC,
                              BL_MAJ
                          )
                          VALUES (
                              '13892',
                              '4',
                              '4',
                              '6',
                              '3520',
                              '1'
                          );

INSERT INTO GRILLE_DETAIL (
                              DGRIL_ID_DETAIL,
                              DGRIL_NB_JOURNEE,
                              DGRIL_NB_EQUIPE1,
                              DGRIL_NB_EQUIPE2,
                              GRIL_ID_RENC,
                              BL_MAJ
                          )
                          VALUES (
                              '13893',
                              '4',
                              '3',
                              '7',
                              '3520',
                              '1'
                          );

INSERT INTO GRILLE_DETAIL (
                              DGRIL_ID_DETAIL,
                              DGRIL_NB_JOURNEE,
                              DGRIL_NB_EQUIPE1,
                              DGRIL_NB_EQUIPE2,
                              GRIL_ID_RENC,
                              BL_MAJ
                          )
                          VALUES (
                              '13894',
                              '4',
                              '-1',
                              '-1',
                              '3520',
                              '1'
                          );

INSERT INTO GRILLE_DETAIL (
                              DGRIL_ID_DETAIL,
                              DGRIL_NB_JOURNEE,
                              DGRIL_NB_EQUIPE1,
                              DGRIL_NB_EQUIPE2,
                              GRIL_ID_RENC,
                              BL_MAJ
                          )
                          VALUES (
                              '13895',
                              '5',
                              '1',
                              '4',
                              '3520',
                              '1'
                          );

INSERT INTO GRILLE_DETAIL (
                              DGRIL_ID_DETAIL,
                              DGRIL_NB_JOURNEE,
                              DGRIL_NB_EQUIPE1,
                              DGRIL_NB_EQUIPE2,
                              GRIL_ID_RENC,
                              BL_MAJ
                          )
                          VALUES (
                              '13896',
                              '5',
                              '3',
                              '5',
                              '3520',
                              '1'
                          );

INSERT INTO GRILLE_DETAIL (
                              DGRIL_ID_DETAIL,
                              DGRIL_NB_JOURNEE,
                              DGRIL_NB_EQUIPE1,
                              DGRIL_NB_EQUIPE2,
                              GRIL_ID_RENC,
                              BL_MAJ
                          )
                          VALUES (
                              '13897',
                              '5',
                              '2',
                              '6',
                              '3520',
                              '1'
                          );

INSERT INTO GRILLE_DETAIL (
                              DGRIL_ID_DETAIL,
                              DGRIL_NB_JOURNEE,
                              DGRIL_NB_EQUIPE1,
                              DGRIL_NB_EQUIPE2,
                              GRIL_ID_RENC,
                              BL_MAJ
                          )
                          VALUES (
                              '13898',
                              '5',
                              '-1',
                              '-1',
                              '3520',
                              '1'
                          );

INSERT INTO GRILLE_DETAIL (
                              DGRIL_ID_DETAIL,
                              DGRIL_NB_JOURNEE,
                              DGRIL_NB_EQUIPE1,
                              DGRIL_NB_EQUIPE2,
                              GRIL_ID_RENC,
                              BL_MAJ
                          )
                          VALUES (
                              '13899',
                              '6',
                              '1',
                              '3',
                              '3520',
                              '1'
                          );

INSERT INTO GRILLE_DETAIL (
                              DGRIL_ID_DETAIL,
                              DGRIL_NB_JOURNEE,
                              DGRIL_NB_EQUIPE1,
                              DGRIL_NB_EQUIPE2,
                              GRIL_ID_RENC,
                              BL_MAJ
                          )
                          VALUES (
                              '13900',
                              '6',
                              '2',
                              '4',
                              '3520',
                              '1'
                          );

INSERT INTO GRILLE_DETAIL (
                              DGRIL_ID_DETAIL,
                              DGRIL_NB_JOURNEE,
                              DGRIL_NB_EQUIPE1,
                              DGRIL_NB_EQUIPE2,
                              GRIL_ID_RENC,
                              BL_MAJ
                          )
                          VALUES (
                              '13901',
                              '6',
                              '6',
                              '7',
                              '3520',
                              '1'
                          );

INSERT INTO GRILLE_DETAIL (
                              DGRIL_ID_DETAIL,
                              DGRIL_NB_JOURNEE,
                              DGRIL_NB_EQUIPE1,
                              DGRIL_NB_EQUIPE2,
                              GRIL_ID_RENC,
                              BL_MAJ
                          )
                          VALUES (
                              '13902',
                              '6',
                              '-1',
                              '-1',
                              '3520',
                              '1'
                          );

INSERT INTO GRILLE_DETAIL (
                              DGRIL_ID_DETAIL,
                              DGRIL_NB_JOURNEE,
                              DGRIL_NB_EQUIPE1,
                              DGRIL_NB_EQUIPE2,
                              GRIL_ID_RENC,
                              BL_MAJ
                          )
                          VALUES (
                              '13903',
                              '7',
                              '1',
                              '2',
                              '3520',
                              '1'
                          );

INSERT INTO GRILLE_DETAIL (
                              DGRIL_ID_DETAIL,
                              DGRIL_NB_JOURNEE,
                              DGRIL_NB_EQUIPE1,
                              DGRIL_NB_EQUIPE2,
                              GRIL_ID_RENC,
                              BL_MAJ
                          )
                          VALUES (
                              '13904',
                              '7',
                              '4',
                              '7',
                              '3520',
                              '1'
                          );

INSERT INTO GRILLE_DETAIL (
                              DGRIL_ID_DETAIL,
                              DGRIL_NB_JOURNEE,
                              DGRIL_NB_EQUIPE1,
                              DGRIL_NB_EQUIPE2,
                              GRIL_ID_RENC,
                              BL_MAJ
                          )
                          VALUES (
                              '13905',
                              '7',
                              '5',
                              '6',
                              '3520',
                              '1'
                          );

INSERT INTO GRILLE_DETAIL (
                              DGRIL_ID_DETAIL,
                              DGRIL_NB_JOURNEE,
                              DGRIL_NB_EQUIPE1,
                              DGRIL_NB_EQUIPE2,
                              GRIL_ID_RENC,
                              BL_MAJ
                          )
                          VALUES (
                              '13906',
                              '7',
                              '-1',
                              '-1',
                              '3520',
                              '1'
                          );


-- Table : GRILLE_RENCONTRE
DROP TABLE IF EXISTS GRILLE_RENCONTRE;

CREATE TABLE GRILLE_RENCONTRE (
    GRIL_ID_RENC,
    ORGA_ID,
    GRIL_CD_RENC,
    GRIL_LB_RENC,
    GRIL_NB_EQUIPE,
    GRIL_FG,
    GRIL_LB_USER_MODIF,
    GRIL_DT_CREATION,
    BL_MAJ
);

INSERT INTO GRILLE_RENCONTRE (
                                 GRIL_ID_RENC,
                                 ORGA_ID,
                                 GRIL_CD_RENC,
                                 GRIL_LB_RENC,
                                 GRIL_NB_EQUIPE,
                                 GRIL_FG,
                                 GRIL_LB_USER_MODIF,
                                 GRIL_DT_CREATION,
                                 BL_MAJ
                             )
                             VALUES (
                                 '1037',
                                 '100001',
                                 'P4',
                                 'POULES 4 JOUEURS',
                                 '4',
                                 'I',
                                 'Default',
                                 '01/01/1900 00:00:00',
                                 '1'
                             );

INSERT INTO GRILLE_RENCONTRE (
                                 GRIL_ID_RENC,
                                 ORGA_ID,
                                 GRIL_CD_RENC,
                                 GRIL_LB_RENC,
                                 GRIL_NB_EQUIPE,
                                 GRIL_FG,
                                 GRIL_LB_USER_MODIF,
                                 GRIL_DT_CREATION,
                                 BL_MAJ
                             )
                             VALUES (
                                 '1038',
                                 '100001',
                                 'p6',
                                 'POULES 6 JOUEURS',
                                 '6',
                                 'I',
                                 'Default',
                                 '01/01/1900 00:00:00',
                                 '1'
                             );

INSERT INTO GRILLE_RENCONTRE (
                                 GRIL_ID_RENC,
                                 ORGA_ID,
                                 GRIL_CD_RENC,
                                 GRIL_LB_RENC,
                                 GRIL_NB_EQUIPE,
                                 GRIL_FG,
                                 GRIL_LB_USER_MODIF,
                                 GRIL_DT_CREATION,
                                 BL_MAJ
                             )
                             VALUES (
                                 '3049',
                                 '100001',
                                 'P3',
                                 'POULES 3 JOUEURS',
                                 '3',
                                 'I',
                                 'Default',
                                 '01/01/1900 00:00:00',
                                 '1'
                             );

INSERT INTO GRILLE_RENCONTRE (
                                 GRIL_ID_RENC,
                                 ORGA_ID,
                                 GRIL_CD_RENC,
                                 GRIL_LB_RENC,
                                 GRIL_NB_EQUIPE,
                                 GRIL_FG,
                                 GRIL_LB_USER_MODIF,
                                 GRIL_DT_CREATION,
                                 BL_MAJ
                             )
                             VALUES (
                                 '3050',
                                 '100001',
                                 'P5',
                                 'POULES 5 JOUEURS',
                                 '5',
                                 'I',
                                 'Default',
                                 '01/01/1900 00:00:00',
                                 '1'
                             );

INSERT INTO GRILLE_RENCONTRE (
                                 GRIL_ID_RENC,
                                 ORGA_ID,
                                 GRIL_CD_RENC,
                                 GRIL_LB_RENC,
                                 GRIL_NB_EQUIPE,
                                 GRIL_FG,
                                 GRIL_LB_USER_MODIF,
                                 GRIL_DT_CREATION,
                                 BL_MAJ
                             )
                             VALUES (
                                 '3105',
                                 '100001',
                                 'P7',
                                 'POULES 7 JOUEURS',
                                 '7',
                                 'I',
                                 'Default',
                                 '01/01/1900 00:00:00',
                                 '1'
                             );

INSERT INTO GRILLE_RENCONTRE (
                                 GRIL_ID_RENC,
                                 ORGA_ID,
                                 GRIL_CD_RENC,
                                 GRIL_LB_RENC,
                                 GRIL_NB_EQUIPE,
                                 GRIL_FG,
                                 GRIL_LB_USER_MODIF,
                                 GRIL_DT_CREATION,
                                 BL_MAJ
                             )
                             VALUES (
                                 '3517',
                                 '100001',
                                 'P8',
                                 'POULES 8 JOUEURS',
                                 '8',
                                 'I',
                                 'Default',
                                 '01/01/1900 00:00:00',
                                 '1'
                             );

INSERT INTO GRILLE_RENCONTRE (
                                 GRIL_ID_RENC,
                                 ORGA_ID,
                                 GRIL_CD_RENC,
                                 GRIL_LB_RENC,
                                 GRIL_NB_EQUIPE,
                                 GRIL_FG,
                                 GRIL_LB_USER_MODIF,
                                 GRIL_DT_CREATION,
                                 BL_MAJ
                             )
                             VALUES (
                                 '3520',
                                 '100001',
                                 'P7B',
                                 'Poule 7 joueurs',
                                 '7',
                                 'I',
                                 'Default',
                                 '01/01/1900 00:00:00',
                                 '1'
                             );


-- Table : INSCRIPTION
DROP TABLE IF EXISTS INSCRIPTION;

CREATE TABLE INSCRIPTION (
    INSC_ID,
    JOUE_ID,
    TOUR_ID,
    INSC_NB_DOSSARD,
    INSC_NB_RANG_POULE,
    INSC_NB_POINT_TOUR,
    INSC_BL_ABSENT,
    POUL_ID,
    TOUR_ID_PREC,
    INSC_NB_RANG_TOUR,
    INSC_NM_RANG_TABLEAU,
    INSC_CD_LETTRE,
    TAB_ID,
    INSC_BL_TETE_SERIE,
    INSC_NM_CLASSEMENT,
    INSC_TIRAGE_POS_TAB,
    INSC_BL_TIRAGE_TETE_SERIE
);

INSERT INTO INSCRIPTION (
                            INSC_ID,
                            JOUE_ID,
                            TOUR_ID,
                            INSC_NB_DOSSARD,
                            INSC_NB_RANG_POULE,
                            INSC_NB_POINT_TOUR,
                            INSC_BL_ABSENT,
                            POUL_ID,
                            TOUR_ID_PREC,
                            INSC_NB_RANG_TOUR,
                            INSC_NM_RANG_TABLEAU,
                            INSC_CD_LETTRE,
                            TAB_ID,
                            INSC_BL_TETE_SERIE,
                            INSC_NM_CLASSEMENT,
                            INSC_TIRAGE_POS_TAB,
                            INSC_BL_TIRAGE_TETE_SERIE
                        )
                        VALUES (
                            '-101',
                            '-101',
                            '-101',
                            '0',
                            '0',
                            '0',
                            '0',
                            '',
                            '',
                            '',
                            '',
                            '',
                            '',
                            '',
                            '',
                            '',
                            ''
                        );


-- Table : JOUEUR
DROP TABLE IF EXISTS JOUEUR;

CREATE TABLE JOUEUR (
    JOUE_ID,
    EPRV_ID,
    LIC_ID,
    JOUE_NB_POINT_TOTAL,
    JOUE_BL_FORFAIT_GENE,
    JOUE_LB_TRI_POINT
);

INSERT INTO JOUEUR (
                       JOUE_ID,
                       EPRV_ID,
                       LIC_ID,
                       JOUE_NB_POINT_TOTAL,
                       JOUE_BL_FORFAIT_GENE,
                       JOUE_LB_TRI_POINT
                   )
                   VALUES (
                       '-101',
                       '-101',
                       '-101',
                       '',
                       '0',
                       ''
                   );


-- Table : LICENCIE
DROP TABLE IF EXISTS LICENCIE;

CREATE TABLE LICENCIE (
    LIC_ID,
    CAT_ID,
    CLUB_ID,
    CLU_CLUB_ID,
    TCLST_ID,
    PERS_LB_NOM,
    PERS_LB_PRENOM,
    PERS_FG_SEXE,
    PERS_DT_NAISSANCE,
    LIC_NB_LICENCE,
    LIC_FG_NATIONALITE,
    LIC_FG,
    LIC_FG_MODULE,
    LIC_FG_CERTIFICAT,
    LIC_DT_CERTIFICAT,
    LIC_DT_VALIDATION,
    LIC_NB_PLACE,
    LIC_NB_POINT,
    LIC_FG_ECHELON,
    LIC_NB_POINT_CF_PREC,
    LIC_NB_POINT_TOTAL_CF,
    LIC_NB_TRI_POINT_CF,
    LIC_BL_LOCAL,
    LIC_BL_DOUBLE,
    LIC_NB_TOTAL_POINT_DOUBLE,
    LIC_NB_POINT_TOUR_PREC_CF,
    EPRV_ID,
    DOUBLE_CLUB_ID,
    DOUBLE_CLU_CLUB_ID
);

INSERT INTO LICENCIE (
                         LIC_ID,
                         CAT_ID,
                         CLUB_ID,
                         CLU_CLUB_ID,
                         TCLST_ID,
                         PERS_LB_NOM,
                         PERS_LB_PRENOM,
                         PERS_FG_SEXE,
                         PERS_DT_NAISSANCE,
                         LIC_NB_LICENCE,
                         LIC_FG_NATIONALITE,
                         LIC_FG,
                         LIC_FG_MODULE,
                         LIC_FG_CERTIFICAT,
                         LIC_DT_CERTIFICAT,
                         LIC_DT_VALIDATION,
                         LIC_NB_PLACE,
                         LIC_NB_POINT,
                         LIC_FG_ECHELON,
                         LIC_NB_POINT_CF_PREC,
                         LIC_NB_POINT_TOTAL_CF,
                         LIC_NB_TRI_POINT_CF,
                         LIC_BL_LOCAL,
                         LIC_BL_DOUBLE,
                         LIC_NB_TOTAL_POINT_DOUBLE,
                         LIC_NB_POINT_TOUR_PREC_CF,
                         EPRV_ID,
                         DOUBLE_CLUB_ID,
                         DOUBLE_CLU_CLUB_ID
                     )
                     VALUES (
                         '-101',
                         '-101',
                         '-101',
                         '',
                         '-101',
                         'Absent',
                         '',
                         '',
                         '',
                         '',
                         '',
                         '',
                         '',
                         '',
                         '',
                         '',
                         '',
                         '0',
                         '',
                         '',
                         '',
                         '',
                         '1',
                         '',
                         '',
                         '',
                         '',
                         '',
                         ''
                     );


-- Table : LIGNE_POT
DROP TABLE IF EXISTS LIGNE_POT;

CREATE TABLE LIGNE_POT (
    LIGNE_POT_ID,
    POT_ID,
    LIGNE_POT_NM_ORDRE,
    LIGNE_POT_LB,
    LIGNE_POT_NB_TABLE
);


-- Table : MANCHE
DROP TABLE IF EXISTS MANCHE;

CREATE TABLE MANCHE (
    MANCH_ID,
    TABPART_ID_TABLEAU,
    MANCH_NB_SCORE1,
    MANCH_NB_SCORE2,
    MANCH_NB_RANG
);


-- Table : MEMO
DROP TABLE IF EXISTS MEMO;

CREATE TABLE MEMO (
    MEMO
);


-- Table : NIVEAU
DROP TABLE IF EXISTS NIVEAU;

CREATE TABLE NIVEAU (
    NIV_ID,
    TAB_ID,
    NIVREF_ID,
    NIV_DT_HEURE,
    NIV_LB_LIEU,
    NIV_CM
);


-- Table : NIVEAU_REF
DROP TABLE IF EXISTS NIVEAU_REF;

CREATE TABLE NIVEAU_REF (
    NIVREF_ID,
    TABREF_ID,
    NIVREF_CD,
    NIVREF_LB,
    NIVREF_NB,
    NIVREF_BL_DEPART,
    NIVREF_NIVREF_ID,
    BL_MAJ
);


-- Table : ORGANISME
DROP TABLE IF EXISTS ORGANISME;

CREATE TABLE ORGANISME (
    ORGA_ID,
    ORG_ORGA_ID,
    ORGA_LB,
    ORGA_CD,
    ORGA_FG,
    ORGA_BL_MODULE,
    BL_MAJ
);

INSERT INTO ORGANISME (
                          ORGA_ID,
                          ORG_ORGA_ID,
                          ORGA_LB,
                          ORGA_CD,
                          ORGA_FG,
                          ORGA_BL_MODULE,
                          BL_MAJ
                      )
                      VALUES (
                          '-101',
                          '1001',
                          'Inconnu',
                          'Inc',
                          'D',
                          '0',
                          '0'
                      );

INSERT INTO ORGANISME (
                          ORGA_ID,
                          ORG_ORGA_ID,
                          ORGA_LB,
                          ORGA_CD,
                          ORGA_FG,
                          ORGA_BL_MODULE,
                          BL_MAJ
                      )
                      VALUES (
                          '1',
                          '1019',
                          'AIN',
                          'D01',
                          'D',
                          '0',
                          '1'
                      );

INSERT INTO ORGANISME (
                          ORGA_ID,
                          ORG_ORGA_ID,
                          ORGA_LB,
                          ORGA_CD,
                          ORGA_FG,
                          ORGA_BL_MODULE,
                          BL_MAJ
                      )
                      VALUES (
                          '2',
                          '1005',
                          'AISNE',
                          'D02',
                          'D',
                          '0',
                          '1'
                      );

INSERT INTO ORGANISME (
                          ORGA_ID,
                          ORG_ORGA_ID,
                          ORGA_LB,
                          ORGA_CD,
                          ORGA_FG,
                          ORGA_BL_MODULE,
                          BL_MAJ
                      )
                      VALUES (
                          '3',
                          '1021',
                          'ALLIER',
                          'D03',
                          'D',
                          '0',
                          '1'
                      );

INSERT INTO ORGANISME (
                          ORGA_ID,
                          ORG_ORGA_ID,
                          ORGA_LB,
                          ORGA_CD,
                          ORGA_FG,
                          ORGA_BL_MODULE,
                          BL_MAJ
                      )
                      VALUES (
                          '4',
                          '1021',
                          'ALPES HTE PROVENCE',
                          'D04',
                          'D',
                          '0',
                          '1'
                      );

INSERT INTO ORGANISME (
                          ORGA_ID,
                          ORG_ORGA_ID,
                          ORGA_LB,
                          ORGA_CD,
                          ORGA_FG,
                          ORGA_BL_MODULE,
                          BL_MAJ
                      )
                      VALUES (
                          '5',
                          '1009',
                          'HAUTES ALPES',
                          'D05',
                          'D',
                          '0',
                          '1'
                      );

INSERT INTO ORGANISME (
                          ORGA_ID,
                          ORG_ORGA_ID,
                          ORGA_LB,
                          ORGA_CD,
                          ORGA_FG,
                          ORGA_BL_MODULE,
                          BL_MAJ
                      )
                      VALUES (
                          '6',
                          '1001',
                          'ALPES MARITIMES',
                          'D06',
                          'D',
                          '0',
                          '1'
                      );

INSERT INTO ORGANISME (
                          ORGA_ID,
                          ORG_ORGA_ID,
                          ORGA_LB,
                          ORGA_CD,
                          ORGA_FG,
                          ORGA_BL_MODULE,
                          BL_MAJ
                      )
                      VALUES (
                          '7',
                          '1008',
                          'ARDECHE',
                          'D07',
                          'D',
                          '0',
                          '1'
                      );

INSERT INTO ORGANISME (
                          ORGA_ID,
                          ORG_ORGA_ID,
                          ORGA_LB,
                          ORGA_CD,
                          ORGA_FG,
                          ORGA_BL_MODULE,
                          BL_MAJ
                      )
                      VALUES (
                          '8',
                          '1022',
                          'ARDENNES',
                          'D08',
                          'D',
                          '1',
                          '1'
                      );

INSERT INTO ORGANISME (
                          ORGA_ID,
                          ORG_ORGA_ID,
                          ORGA_LB,
                          ORGA_CD,
                          ORGA_FG,
                          ORGA_BL_MODULE,
                          BL_MAJ
                      )
                      VALUES (
                          '9',
                          '1008',
                          'ARIEGE',
                          'D09',
                          'D',
                          '1',
                          '1'
                      );

INSERT INTO ORGANISME (
                          ORGA_ID,
                          ORG_ORGA_ID,
                          ORGA_LB,
                          ORGA_CD,
                          ORGA_FG,
                          ORGA_BL_MODULE,
                          BL_MAJ
                      )
                      VALUES (
                          '10',
                          '1013',
                          'AUBE',
                          'D10',
                          'D',
                          '1',
                          '1'
                      );

INSERT INTO ORGANISME (
                          ORGA_ID,
                          ORG_ORGA_ID,
                          ORGA_LB,
                          ORGA_CD,
                          ORGA_FG,
                          ORGA_BL_MODULE,
                          BL_MAJ
                      )
                      VALUES (
                          '11',
                          '1022',
                          'AUDE',
                          'D11',
                          'D',
                          '0',
                          '1'
                      );

INSERT INTO ORGANISME (
                          ORGA_ID,
                          ORG_ORGA_ID,
                          ORGA_LB,
                          ORGA_CD,
                          ORGA_FG,
                          ORGA_BL_MODULE,
                          BL_MAJ
                      )
                      VALUES (
                          '12',
                          '1021',
                          'AVEYRON',
                          'D12',
                          'D',
                          '1',
                          '1'
                      );

INSERT INTO ORGANISME (
                          ORGA_ID,
                          ORG_ORGA_ID,
                          ORGA_LB,
                          ORGA_CD,
                          ORGA_FG,
                          ORGA_BL_MODULE,
                          BL_MAJ
                      )
                      VALUES (
                          '13',
                          '1017',
                          'BOUCHES DU RHONE',
                          'D13',
                          'D',
                          '0',
                          '1'
                      );

INSERT INTO ORGANISME (
                          ORGA_ID,
                          ORG_ORGA_ID,
                          ORGA_LB,
                          ORGA_CD,
                          ORGA_FG,
                          ORGA_BL_MODULE,
                          BL_MAJ
                      )
                      VALUES (
                          '14',
                          '1005',
                          'CALVADOS',
                          'D14',
                          'D',
                          '0',
                          '1'
                      );

INSERT INTO ORGANISME (
                          ORGA_ID,
                          ORG_ORGA_ID,
                          ORGA_LB,
                          ORGA_CD,
                          ORGA_FG,
                          ORGA_BL_MODULE,
                          BL_MAJ
                      )
                      VALUES (
                          '15',
                          '1020',
                          'CANTAL',
                          'D15',
                          'D',
                          '0',
                          '1'
                      );

INSERT INTO ORGANISME (
                          ORGA_ID,
                          ORG_ORGA_ID,
                          ORGA_LB,
                          ORGA_CD,
                          ORGA_FG,
                          ORGA_BL_MODULE,
                          BL_MAJ
                      )
                      VALUES (
                          '16',
                          '1020',
                          'CHARENTE',
                          'D16',
                          'D',
                          '1',
                          '1'
                      );

INSERT INTO ORGANISME (
                          ORGA_ID,
                          ORG_ORGA_ID,
                          ORGA_LB,
                          ORGA_CD,
                          ORGA_FG,
                          ORGA_BL_MODULE,
                          BL_MAJ
                      )
                      VALUES (
                          '17',
                          '1023',
                          'CHARENTE MARITIME',
                          'D17',
                          'D',
                          '1',
                          '1'
                      );

INSERT INTO ORGANISME (
                          ORGA_ID,
                          ORG_ORGA_ID,
                          ORGA_LB,
                          ORGA_CD,
                          ORGA_FG,
                          ORGA_BL_MODULE,
                          BL_MAJ
                      )
                      VALUES (
                          '18',
                          '1014',
                          'CHER',
                          'D18',
                          'D',
                          '0',
                          '1'
                      );

INSERT INTO ORGANISME (
                          ORGA_ID,
                          ORG_ORGA_ID,
                          ORGA_LB,
                          ORGA_CD,
                          ORGA_FG,
                          ORGA_BL_MODULE,
                          BL_MAJ
                      )
                      VALUES (
                          '19',
                          '1006',
                          'CORREZE',
                          'D19',
                          'D',
                          '0',
                          '1'
                      );

INSERT INTO ORGANISME (
                          ORGA_ID,
                          ORG_ORGA_ID,
                          ORGA_LB,
                          ORGA_CD,
                          ORGA_FG,
                          ORGA_BL_MODULE,
                          BL_MAJ
                      )
                      VALUES (
                          '21',
                          '1007',
                          'COTE D OR',
                          'D21',
                          'D',
                          '0',
                          '1'
                      );

INSERT INTO ORGANISME (
                          ORGA_ID,
                          ORG_ORGA_ID,
                          ORGA_LB,
                          ORGA_CD,
                          ORGA_FG,
                          ORGA_BL_MODULE,
                          BL_MAJ
                      )
                      VALUES (
                          '22',
                          '1014',
                          'COTES D ARMOR',
                          'D22',
                          'D',
                          '0',
                          '1'
                      );

INSERT INTO ORGANISME (
                          ORGA_ID,
                          ORG_ORGA_ID,
                          ORGA_LB,
                          ORGA_CD,
                          ORGA_FG,
                          ORGA_BL_MODULE,
                          BL_MAJ
                      )
                      VALUES (
                          '23',
                          '1003',
                          'CREUSE',
                          'D23',
                          'D',
                          '0',
                          '1'
                      );

INSERT INTO ORGANISME (
                          ORGA_ID,
                          ORG_ORGA_ID,
                          ORGA_LB,
                          ORGA_CD,
                          ORGA_FG,
                          ORGA_BL_MODULE,
                          BL_MAJ
                      )
                      VALUES (
                          '24',
                          '1011',
                          'DORDOGNE',
                          'D24',
                          'D',
                          '0',
                          '1'
                      );

INSERT INTO ORGANISME (
                          ORGA_ID,
                          ORG_ORGA_ID,
                          ORGA_LB,
                          ORGA_CD,
                          ORGA_FG,
                          ORGA_BL_MODULE,
                          BL_MAJ
                      )
                      VALUES (
                          '25',
                          '1001',
                          'DOUBS',
                          'D25',
                          'D',
                          '0',
                          '1'
                      );

INSERT INTO ORGANISME (
                          ORGA_ID,
                          ORG_ORGA_ID,
                          ORGA_LB,
                          ORGA_CD,
                          ORGA_FG,
                          ORGA_BL_MODULE,
                          BL_MAJ
                      )
                      VALUES (
                          '26',
                          '1018',
                          'DROME',
                          'D26',
                          'D',
                          '0',
                          '1'
                      );

INSERT INTO ORGANISME (
                          ORGA_ID,
                          ORG_ORGA_ID,
                          ORGA_LB,
                          ORGA_CD,
                          ORGA_FG,
                          ORGA_BL_MODULE,
                          BL_MAJ
                      )
                      VALUES (
                          '27',
                          '1023',
                          'EURE',
                          'D27',
                          'D',
                          '0',
                          '1'
                      );

INSERT INTO ORGANISME (
                          ORGA_ID,
                          ORG_ORGA_ID,
                          ORGA_LB,
                          ORGA_CD,
                          ORGA_FG,
                          ORGA_BL_MODULE,
                          BL_MAJ
                      )
                      VALUES (
                          '28',
                          '1007',
                          'EURE ET LOIR',
                          'D28',
                          'D',
                          '0',
                          '1'
                      );

INSERT INTO ORGANISME (
                          ORGA_ID,
                          ORG_ORGA_ID,
                          ORGA_LB,
                          ORGA_CD,
                          ORGA_FG,
                          ORGA_BL_MODULE,
                          BL_MAJ
                      )
                      VALUES (
                          '29',
                          '1013',
                          'FINISTERE',
                          'D29',
                          'D',
                          '0',
                          '1'
                      );

INSERT INTO ORGANISME (
                          ORGA_ID,
                          ORG_ORGA_ID,
                          ORGA_LB,
                          ORGA_CD,
                          ORGA_FG,
                          ORGA_BL_MODULE,
                          BL_MAJ
                      )
                      VALUES (
                          '30',
                          '1022',
                          'GARD',
                          'D30',
                          'D',
                          '0',
                          '1'
                      );

INSERT INTO ORGANISME (
                          ORGA_ID,
                          ORG_ORGA_ID,
                          ORGA_LB,
                          ORGA_CD,
                          ORGA_FG,
                          ORGA_BL_MODULE,
                          BL_MAJ
                      )
                      VALUES (
                          '31',
                          '1022',
                          'HAUTE GARONNE',
                          'D31',
                          'D',
                          '1',
                          '1'
                      );

INSERT INTO ORGANISME (
                          ORGA_ID,
                          ORG_ORGA_ID,
                          ORGA_LB,
                          ORGA_CD,
                          ORGA_FG,
                          ORGA_BL_MODULE,
                          BL_MAJ
                      )
                      VALUES (
                          '32',
                          '1003',
                          'GERS',
                          'D32',
                          'D',
                          '1',
                          '1'
                      );

INSERT INTO ORGANISME (
                          ORGA_ID,
                          ORG_ORGA_ID,
                          ORGA_LB,
                          ORGA_CD,
                          ORGA_FG,
                          ORGA_BL_MODULE,
                          BL_MAJ
                      )
                      VALUES (
                          '33',
                          '1013',
                          'GIRONDE',
                          'D33',
                          'D',
                          '0',
                          '1'
                      );

INSERT INTO ORGANISME (
                          ORGA_ID,
                          ORG_ORGA_ID,
                          ORGA_LB,
                          ORGA_CD,
                          ORGA_FG,
                          ORGA_BL_MODULE,
                          BL_MAJ
                      )
                      VALUES (
                          '34',
                          '1007',
                          'HERAULT',
                          'D34',
                          'D',
                          '0',
                          '1'
                      );

INSERT INTO ORGANISME (
                          ORGA_ID,
                          ORG_ORGA_ID,
                          ORGA_LB,
                          ORGA_CD,
                          ORGA_FG,
                          ORGA_BL_MODULE,
                          BL_MAJ
                      )
                      VALUES (
                          '35',
                          '1023',
                          'ILLE ET VILAINE',
                          'D35',
                          'D',
                          '0',
                          '1'
                      );

INSERT INTO ORGANISME (
                          ORGA_ID,
                          ORG_ORGA_ID,
                          ORGA_LB,
                          ORGA_CD,
                          ORGA_FG,
                          ORGA_BL_MODULE,
                          BL_MAJ
                      )
                      VALUES (
                          '36',
                          '1023',
                          'INDRE',
                          'D36',
                          'D',
                          '0',
                          '1'
                      );

INSERT INTO ORGANISME (
                          ORGA_ID,
                          ORG_ORGA_ID,
                          ORGA_LB,
                          ORGA_CD,
                          ORGA_FG,
                          ORGA_BL_MODULE,
                          BL_MAJ
                      )
                      VALUES (
                          '37',
                          '1001',
                          'INDRE ET LOIRE',
                          'D37',
                          'D',
                          '0',
                          '1'
                      );

INSERT INTO ORGANISME (
                          ORGA_ID,
                          ORG_ORGA_ID,
                          ORGA_LB,
                          ORGA_CD,
                          ORGA_FG,
                          ORGA_BL_MODULE,
                          BL_MAJ
                      )
                      VALUES (
                          '38',
                          '1011',
                          'ISERE',
                          'D38',
                          'D',
                          '0',
                          '1'
                      );

INSERT INTO ORGANISME (
                          ORGA_ID,
                          ORG_ORGA_ID,
                          ORGA_LB,
                          ORGA_CD,
                          ORGA_FG,
                          ORGA_BL_MODULE,
                          BL_MAJ
                      )
                      VALUES (
                          '39',
                          '1003',
                          'JURA',
                          'D39',
                          'D',
                          '0',
                          '1'
                      );

INSERT INTO ORGANISME (
                          ORGA_ID,
                          ORG_ORGA_ID,
                          ORGA_LB,
                          ORGA_CD,
                          ORGA_FG,
                          ORGA_BL_MODULE,
                          BL_MAJ
                      )
                      VALUES (
                          '40',
                          '1023',
                          'LANDES',
                          'D40',
                          'D',
                          '0',
                          '1'
                      );

INSERT INTO ORGANISME (
                          ORGA_ID,
                          ORG_ORGA_ID,
                          ORGA_LB,
                          ORGA_CD,
                          ORGA_FG,
                          ORGA_BL_MODULE,
                          BL_MAJ
                      )
                      VALUES (
                          '41',
                          '1001',
                          'LOIR ET CHER',
                          'D41',
                          'D',
                          '0',
                          '1'
                      );

INSERT INTO ORGANISME (
                          ORGA_ID,
                          ORG_ORGA_ID,
                          ORGA_LB,
                          ORGA_CD,
                          ORGA_FG,
                          ORGA_BL_MODULE,
                          BL_MAJ
                      )
                      VALUES (
                          '42',
                          '1005',
                          'LOIRE',
                          'D42',
                          'D',
                          '0',
                          '1'
                      );

INSERT INTO ORGANISME (
                          ORGA_ID,
                          ORG_ORGA_ID,
                          ORGA_LB,
                          ORGA_CD,
                          ORGA_FG,
                          ORGA_BL_MODULE,
                          BL_MAJ
                      )
                      VALUES (
                          '43',
                          '1004',
                          'HAUTE LOIRE',
                          'D43',
                          'D',
                          '0',
                          '1'
                      );

INSERT INTO ORGANISME (
                          ORGA_ID,
                          ORG_ORGA_ID,
                          ORGA_LB,
                          ORGA_CD,
                          ORGA_FG,
                          ORGA_BL_MODULE,
                          BL_MAJ
                      )
                      VALUES (
                          '44',
                          '1023',
                          'LOIRE ATLANTIQUE',
                          'D44',
                          'D',
                          '0',
                          '1'
                      );

INSERT INTO ORGANISME (
                          ORGA_ID,
                          ORG_ORGA_ID,
                          ORGA_LB,
                          ORGA_CD,
                          ORGA_FG,
                          ORGA_BL_MODULE,
                          BL_MAJ
                      )
                      VALUES (
                          '45',
                          '1022',
                          'LOIRET',
                          'D45',
                          'D',
                          '0',
                          '1'
                      );

INSERT INTO ORGANISME (
                          ORGA_ID,
                          ORG_ORGA_ID,
                          ORGA_LB,
                          ORGA_CD,
                          ORGA_FG,
                          ORGA_BL_MODULE,
                          BL_MAJ
                      )
                      VALUES (
                          '46',
                          '1003',
                          'LOT',
                          'D46',
                          'D',
                          '1',
                          '1'
                      );

INSERT INTO ORGANISME (
                          ORGA_ID,
                          ORG_ORGA_ID,
                          ORGA_LB,
                          ORGA_CD,
                          ORGA_FG,
                          ORGA_BL_MODULE,
                          BL_MAJ
                      )
                      VALUES (
                          '47',
                          '1013',
                          'LOT ET GARONNE',
                          'D47',
                          'D',
                          '0',
                          '1'
                      );

INSERT INTO ORGANISME (
                          ORGA_ID,
                          ORG_ORGA_ID,
                          ORGA_LB,
                          ORGA_CD,
                          ORGA_FG,
                          ORGA_BL_MODULE,
                          BL_MAJ
                      )
                      VALUES (
                          '48',
                          '1004',
                          'LOZERE',
                          'D48',
                          'D',
                          '0',
                          '1'
                      );

INSERT INTO ORGANISME (
                          ORGA_ID,
                          ORG_ORGA_ID,
                          ORGA_LB,
                          ORGA_CD,
                          ORGA_FG,
                          ORGA_BL_MODULE,
                          BL_MAJ
                      )
                      VALUES (
                          '49',
                          '1017',
                          'MAINE ET LOIRE',
                          'D49',
                          'D',
                          '0',
                          '1'
                      );

INSERT INTO ORGANISME (
                          ORGA_ID,
                          ORG_ORGA_ID,
                          ORGA_LB,
                          ORGA_CD,
                          ORGA_FG,
                          ORGA_BL_MODULE,
                          BL_MAJ
                      )
                      VALUES (
                          '50',
                          '1008',
                          'MANCHE',
                          'D50',
                          'D',
                          '0',
                          '1'
                      );

INSERT INTO ORGANISME (
                          ORGA_ID,
                          ORG_ORGA_ID,
                          ORGA_LB,
                          ORGA_CD,
                          ORGA_FG,
                          ORGA_BL_MODULE,
                          BL_MAJ
                      )
                      VALUES (
                          '51',
                          '1008',
                          'MARNE',
                          'D51',
                          'D',
                          '1',
                          '1'
                      );

INSERT INTO ORGANISME (
                          ORGA_ID,
                          ORG_ORGA_ID,
                          ORGA_LB,
                          ORGA_CD,
                          ORGA_FG,
                          ORGA_BL_MODULE,
                          BL_MAJ
                      )
                      VALUES (
                          '52',
                          '1004',
                          'HAUTE-MARNE',
                          'D52',
                          'D',
                          '1',
                          '1'
                      );

INSERT INTO ORGANISME (
                          ORGA_ID,
                          ORG_ORGA_ID,
                          ORGA_LB,
                          ORGA_CD,
                          ORGA_FG,
                          ORGA_BL_MODULE,
                          BL_MAJ
                      )
                      VALUES (
                          '53',
                          '1015',
                          'MAYENNE',
                          'D53',
                          'D',
                          '0',
                          '1'
                      );

INSERT INTO ORGANISME (
                          ORGA_ID,
                          ORG_ORGA_ID,
                          ORGA_LB,
                          ORGA_CD,
                          ORGA_FG,
                          ORGA_BL_MODULE,
                          BL_MAJ
                      )
                      VALUES (
                          '54',
                          '1015',
                          'MEURTHE ET MOSELLE',
                          'D54',
                          'D',
                          '0',
                          '1'
                      );

INSERT INTO ORGANISME (
                          ORGA_ID,
                          ORG_ORGA_ID,
                          ORGA_LB,
                          ORGA_CD,
                          ORGA_FG,
                          ORGA_BL_MODULE,
                          BL_MAJ
                      )
                      VALUES (
                          '55',
                          '1007',
                          'MEUSE',
                          'D55',
                          'D',
                          '0',
                          '1'
                      );

INSERT INTO ORGANISME (
                          ORGA_ID,
                          ORG_ORGA_ID,
                          ORGA_LB,
                          ORGA_CD,
                          ORGA_FG,
                          ORGA_BL_MODULE,
                          BL_MAJ
                      )
                      VALUES (
                          '56',
                          '1015',
                          'MORBIHAN',
                          'D56',
                          'D',
                          '0',
                          '1'
                      );

INSERT INTO ORGANISME (
                          ORGA_ID,
                          ORG_ORGA_ID,
                          ORGA_LB,
                          ORGA_CD,
                          ORGA_FG,
                          ORGA_BL_MODULE,
                          BL_MAJ
                      )
                      VALUES (
                          '57',
                          '1006',
                          'MOSELLE',
                          'D57',
                          'D',
                          '0',
                          '1'
                      );

INSERT INTO ORGANISME (
                          ORGA_ID,
                          ORG_ORGA_ID,
                          ORGA_LB,
                          ORGA_CD,
                          ORGA_FG,
                          ORGA_BL_MODULE,
                          BL_MAJ
                      )
                      VALUES (
                          '58',
                          '1010',
                          'NIEVRE',
                          'D58',
                          'D',
                          '0',
                          '1'
                      );

INSERT INTO ORGANISME (
                          ORGA_ID,
                          ORG_ORGA_ID,
                          ORGA_LB,
                          ORGA_CD,
                          ORGA_FG,
                          ORGA_BL_MODULE,
                          BL_MAJ
                      )
                      VALUES (
                          '59',
                          '1019',
                          'NORD',
                          'D59',
                          'D',
                          '0',
                          '1'
                      );

INSERT INTO ORGANISME (
                          ORGA_ID,
                          ORG_ORGA_ID,
                          ORGA_LB,
                          ORGA_CD,
                          ORGA_FG,
                          ORGA_BL_MODULE,
                          BL_MAJ
                      )
                      VALUES (
                          '60',
                          '1017',
                          'OISE',
                          'D60',
                          'D',
                          '0',
                          '1'
                      );

INSERT INTO ORGANISME (
                          ORGA_ID,
                          ORG_ORGA_ID,
                          ORGA_LB,
                          ORGA_CD,
                          ORGA_FG,
                          ORGA_BL_MODULE,
                          BL_MAJ
                      )
                      VALUES (
                          '61',
                          '1010',
                          'ORNE',
                          'D61',
                          'D',
                          '0',
                          '1'
                      );

INSERT INTO ORGANISME (
                          ORGA_ID,
                          ORG_ORGA_ID,
                          ORGA_LB,
                          ORGA_CD,
                          ORGA_FG,
                          ORGA_BL_MODULE,
                          BL_MAJ
                      )
                      VALUES (
                          '62',
                          '1005',
                          'PAS DE CALAIS',
                          'D62',
                          'D',
                          '0',
                          '1'
                      );

INSERT INTO ORGANISME (
                          ORGA_ID,
                          ORG_ORGA_ID,
                          ORGA_LB,
                          ORGA_CD,
                          ORGA_FG,
                          ORGA_BL_MODULE,
                          BL_MAJ
                      )
                      VALUES (
                          '63',
                          '1003',
                          'PUY DE DOME',
                          'D63',
                          'D',
                          '0',
                          '1'
                      );

INSERT INTO ORGANISME (
                          ORGA_ID,
                          ORG_ORGA_ID,
                          ORGA_LB,
                          ORGA_CD,
                          ORGA_FG,
                          ORGA_BL_MODULE,
                          BL_MAJ
                      )
                      VALUES (
                          '64',
                          '1022',
                          'PYRENEES ATLANTIQUE',
                          'D64',
                          'D',
                          '0',
                          '1'
                      );

INSERT INTO ORGANISME (
                          ORGA_ID,
                          ORG_ORGA_ID,
                          ORGA_LB,
                          ORGA_CD,
                          ORGA_FG,
                          ORGA_BL_MODULE,
                          BL_MAJ
                      )
                      VALUES (
                          '65',
                          '1013',
                          'HAUTES PYRENEES',
                          'D65',
                          'D',
                          '1',
                          '1'
                      );

INSERT INTO ORGANISME (
                          ORGA_ID,
                          ORG_ORGA_ID,
                          ORGA_LB,
                          ORGA_CD,
                          ORGA_FG,
                          ORGA_BL_MODULE,
                          BL_MAJ
                      )
                      VALUES (
                          '66',
                          '1002',
                          'PYRENEES ORIENTALES',
                          'D66',
                          'D',
                          '0',
                          '1'
                      );

INSERT INTO ORGANISME (
                          ORGA_ID,
                          ORG_ORGA_ID,
                          ORGA_LB,
                          ORGA_CD,
                          ORGA_FG,
                          ORGA_BL_MODULE,
                          BL_MAJ
                      )
                      VALUES (
                          '67',
                          '1002',
                          'BAS RHIN',
                          'D67',
                          'D',
                          '1',
                          '1'
                      );

INSERT INTO ORGANISME (
                          ORGA_ID,
                          ORG_ORGA_ID,
                          ORGA_LB,
                          ORGA_CD,
                          ORGA_FG,
                          ORGA_BL_MODULE,
                          BL_MAJ
                      )
                      VALUES (
                          '68',
                          '1001',
                          'HAUT RHIN',
                          'D68',
                          'D',
                          '1',
                          '1'
                      );

INSERT INTO ORGANISME (
                          ORGA_ID,
                          ORG_ORGA_ID,
                          ORGA_LB,
                          ORGA_CD,
                          ORGA_FG,
                          ORGA_BL_MODULE,
                          BL_MAJ
                      )
                      VALUES (
                          '69',
                          '1011',
                          'RHONE',
                          'D69',
                          'D',
                          '0',
                          '1'
                      );

INSERT INTO ORGANISME (
                          ORGA_ID,
                          ORG_ORGA_ID,
                          ORGA_LB,
                          ORGA_CD,
                          ORGA_FG,
                          ORGA_BL_MODULE,
                          BL_MAJ
                      )
                      VALUES (
                          '70',
                          '1006',
                          'HAUTE SAONE',
                          'D70',
                          'D',
                          '0',
                          '1'
                      );

INSERT INTO ORGANISME (
                          ORGA_ID,
                          ORG_ORGA_ID,
                          ORGA_LB,
                          ORGA_CD,
                          ORGA_FG,
                          ORGA_BL_MODULE,
                          BL_MAJ
                      )
                      VALUES (
                          '71',
                          '1004',
                          'SAONE ET LOIRE',
                          'D71',
                          'D',
                          '0',
                          '1'
                      );

INSERT INTO ORGANISME (
                          ORGA_ID,
                          ORG_ORGA_ID,
                          ORGA_LB,
                          ORGA_CD,
                          ORGA_FG,
                          ORGA_BL_MODULE,
                          BL_MAJ
                      )
                      VALUES (
                          '72',
                          '1001',
                          'SARTHE',
                          'D72',
                          'D',
                          '0',
                          '1'
                      );

INSERT INTO ORGANISME (
                          ORGA_ID,
                          ORG_ORGA_ID,
                          ORGA_LB,
                          ORGA_CD,
                          ORGA_FG,
                          ORGA_BL_MODULE,
                          BL_MAJ
                      )
                      VALUES (
                          '73',
                          '1001',
                          'SAVOIE',
                          'D73',
                          'D',
                          '0',
                          '1'
                      );

INSERT INTO ORGANISME (
                          ORGA_ID,
                          ORG_ORGA_ID,
                          ORGA_LB,
                          ORGA_CD,
                          ORGA_FG,
                          ORGA_BL_MODULE,
                          BL_MAJ
                      )
                      VALUES (
                          '74',
                          '1012',
                          'HAUTE SAVOIE',
                          'D74',
                          'D',
                          '0',
                          '1'
                      );

INSERT INTO ORGANISME (
                          ORGA_ID,
                          ORG_ORGA_ID,
                          ORGA_LB,
                          ORGA_CD,
                          ORGA_FG,
                          ORGA_BL_MODULE,
                          BL_MAJ
                      )
                      VALUES (
                          '75',
                          '1018',
                          'PARIS',
                          'D75',
                          'D',
                          '0',
                          '1'
                      );

INSERT INTO ORGANISME (
                          ORGA_ID,
                          ORG_ORGA_ID,
                          ORGA_LB,
                          ORGA_CD,
                          ORGA_FG,
                          ORGA_BL_MODULE,
                          BL_MAJ
                      )
                      VALUES (
                          '76',
                          '1012',
                          'SEINE MARITIME',
                          'D76',
                          'D',
                          '0',
                          '1'
                      );

INSERT INTO ORGANISME (
                          ORGA_ID,
                          ORG_ORGA_ID,
                          ORGA_LB,
                          ORGA_CD,
                          ORGA_FG,
                          ORGA_BL_MODULE,
                          BL_MAJ
                      )
                      VALUES (
                          '77',
                          '1012',
                          'SEINE ET MARNE',
                          'D77',
                          'D',
                          '0',
                          '1'
                      );

INSERT INTO ORGANISME (
                          ORGA_ID,
                          ORG_ORGA_ID,
                          ORGA_LB,
                          ORGA_CD,
                          ORGA_FG,
                          ORGA_BL_MODULE,
                          BL_MAJ
                      )
                      VALUES (
                          '78',
                          '1020',
                          'YVELINES',
                          'D78',
                          'D',
                          '0',
                          '1'
                      );

INSERT INTO ORGANISME (
                          ORGA_ID,
                          ORG_ORGA_ID,
                          ORGA_LB,
                          ORGA_CD,
                          ORGA_FG,
                          ORGA_BL_MODULE,
                          BL_MAJ
                      )
                      VALUES (
                          '79',
                          '1019',
                          'DEUX SEVRES',
                          'D79',
                          'D',
                          '1',
                          '1'
                      );

INSERT INTO ORGANISME (
                          ORGA_ID,
                          ORG_ORGA_ID,
                          ORGA_LB,
                          ORGA_CD,
                          ORGA_FG,
                          ORGA_BL_MODULE,
                          BL_MAJ
                      )
                      VALUES (
                          '80',
                          '1022',
                          'SOMME',
                          'D80',
                          'D',
                          '0',
                          '1'
                      );

INSERT INTO ORGANISME (
                          ORGA_ID,
                          ORG_ORGA_ID,
                          ORGA_LB,
                          ORGA_CD,
                          ORGA_FG,
                          ORGA_BL_MODULE,
                          BL_MAJ
                      )
                      VALUES (
                          '81',
                          '1022',
                          'TARN',
                          'D81',
                          'D',
                          '1',
                          '1'
                      );

INSERT INTO ORGANISME (
                          ORGA_ID,
                          ORG_ORGA_ID,
                          ORGA_LB,
                          ORGA_CD,
                          ORGA_FG,
                          ORGA_BL_MODULE,
                          BL_MAJ
                      )
                      VALUES (
                          '82',
                          '1009',
                          'TARN ET GARONNE',
                          'D82',
                          'D',
                          '1',
                          '1'
                      );

INSERT INTO ORGANISME (
                          ORGA_ID,
                          ORG_ORGA_ID,
                          ORGA_LB,
                          ORGA_CD,
                          ORGA_FG,
                          ORGA_BL_MODULE,
                          BL_MAJ
                      )
                      VALUES (
                          '83',
                          '1021',
                          'VAR',
                          'D83',
                          'D',
                          '0',
                          '1'
                      );

INSERT INTO ORGANISME (
                          ORGA_ID,
                          ORG_ORGA_ID,
                          ORGA_LB,
                          ORGA_CD,
                          ORGA_FG,
                          ORGA_BL_MODULE,
                          BL_MAJ
                      )
                      VALUES (
                          '84',
                          '1004',
                          'VAUCLUSE',
                          'D84',
                          'D',
                          '0',
                          '1'
                      );

INSERT INTO ORGANISME (
                          ORGA_ID,
                          ORG_ORGA_ID,
                          ORGA_LB,
                          ORGA_CD,
                          ORGA_FG,
                          ORGA_BL_MODULE,
                          BL_MAJ
                      )
                      VALUES (
                          '85',
                          '1020',
                          'VENDEE',
                          'D85',
                          'D',
                          '0',
                          '1'
                      );

INSERT INTO ORGANISME (
                          ORGA_ID,
                          ORG_ORGA_ID,
                          ORGA_LB,
                          ORGA_CD,
                          ORGA_FG,
                          ORGA_BL_MODULE,
                          BL_MAJ
                      )
                      VALUES (
                          '86',
                          '1014',
                          'VIENNE',
                          'D86',
                          'D',
                          '1',
                          '1'
                      );

INSERT INTO ORGANISME (
                          ORGA_ID,
                          ORG_ORGA_ID,
                          ORGA_LB,
                          ORGA_CD,
                          ORGA_FG,
                          ORGA_BL_MODULE,
                          BL_MAJ
                      )
                      VALUES (
                          '87',
                          '1015',
                          'HAUTE VIENNE',
                          'D87',
                          'D',
                          '0',
                          '1'
                      );

INSERT INTO ORGANISME (
                          ORGA_ID,
                          ORG_ORGA_ID,
                          ORGA_LB,
                          ORGA_CD,
                          ORGA_FG,
                          ORGA_BL_MODULE,
                          BL_MAJ
                      )
                      VALUES (
                          '88',
                          '1006',
                          'VOSGES',
                          'D88',
                          'D',
                          '0',
                          '1'
                      );

INSERT INTO ORGANISME (
                          ORGA_ID,
                          ORG_ORGA_ID,
                          ORGA_LB,
                          ORGA_CD,
                          ORGA_FG,
                          ORGA_BL_MODULE,
                          BL_MAJ
                      )
                      VALUES (
                          '89',
                          '1011',
                          'YONNE',
                          'D89',
                          'D',
                          '0',
                          '1'
                      );

INSERT INTO ORGANISME (
                          ORGA_ID,
                          ORG_ORGA_ID,
                          ORGA_LB,
                          ORGA_CD,
                          ORGA_FG,
                          ORGA_BL_MODULE,
                          BL_MAJ
                      )
                      VALUES (
                          '90',
                          '1012',
                          'BELFORT',
                          'D90',
                          'D',
                          '1',
                          '1'
                      );

INSERT INTO ORGANISME (
                          ORGA_ID,
                          ORG_ORGA_ID,
                          ORGA_LB,
                          ORGA_CD,
                          ORGA_FG,
                          ORGA_BL_MODULE,
                          BL_MAJ
                      )
                      VALUES (
                          '91',
                          '1012',
                          'ESSONNE',
                          'D91',
                          'D',
                          '0',
                          '1'
                      );

INSERT INTO ORGANISME (
                          ORGA_ID,
                          ORG_ORGA_ID,
                          ORGA_LB,
                          ORGA_CD,
                          ORGA_FG,
                          ORGA_BL_MODULE,
                          BL_MAJ
                      )
                      VALUES (
                          '92',
                          '1012',
                          'HAUTS DE SEINE',
                          'D92',
                          'D',
                          '0',
                          '1'
                      );

INSERT INTO ORGANISME (
                          ORGA_ID,
                          ORG_ORGA_ID,
                          ORGA_LB,
                          ORGA_CD,
                          ORGA_FG,
                          ORGA_BL_MODULE,
                          BL_MAJ
                      )
                      VALUES (
                          '93',
                          '1012',
                          'SEINE ST DENIS',
                          'D93',
                          'D',
                          '0',
                          '1'
                      );

INSERT INTO ORGANISME (
                          ORGA_ID,
                          ORG_ORGA_ID,
                          ORGA_LB,
                          ORGA_CD,
                          ORGA_FG,
                          ORGA_BL_MODULE,
                          BL_MAJ
                      )
                      VALUES (
                          '94',
                          '1012',
                          'VAL DE MARNE',
                          'D94',
                          'D',
                          '0',
                          '1'
                      );

INSERT INTO ORGANISME (
                          ORGA_ID,
                          ORG_ORGA_ID,
                          ORGA_LB,
                          ORGA_CD,
                          ORGA_FG,
                          ORGA_BL_MODULE,
                          BL_MAJ
                      )
                      VALUES (
                          '95',
                          '1024',
                          'VAL D OISE',
                          'D95',
                          'D',
                          '0',
                          '1'
                      );

INSERT INTO ORGANISME (
                          ORGA_ID,
                          ORG_ORGA_ID,
                          ORGA_LB,
                          ORGA_CD,
                          ORGA_FG,
                          ORGA_BL_MODULE,
                          BL_MAJ
                      )
                      VALUES (
                          '98',
                          '1024',
                          'HAUTE CORSE',
                          'D98',
                          'D',
                          '0',
                          '1'
                      );

INSERT INTO ORGANISME (
                          ORGA_ID,
                          ORG_ORGA_ID,
                          ORGA_LB,
                          ORGA_CD,
                          ORGA_FG,
                          ORGA_BL_MODULE,
                          BL_MAJ
                      )
                      VALUES (
                          '99',
                          '1033',
                          'CORSE DU SUD',
                          'D99',
                          'D',
                          '0',
                          '1'
                      );

INSERT INTO ORGANISME (
                          ORGA_ID,
                          ORG_ORGA_ID,
                          ORGA_LB,
                          ORGA_CD,
                          ORGA_FG,
                          ORGA_BL_MODULE,
                          BL_MAJ
                      )
                      VALUES (
                          '100',
                          '1034',
                          'GUADELOUPE',
                          'D9A',
                          'D',
                          '0',
                          '1'
                      );

INSERT INTO ORGANISME (
                          ORGA_ID,
                          ORG_ORGA_ID,
                          ORGA_LB,
                          ORGA_CD,
                          ORGA_FG,
                          ORGA_BL_MODULE,
                          BL_MAJ
                      )
                      VALUES (
                          '101',
                          '1030',
                          'MARTINIQUE',
                          'D9B',
                          'D',
                          '0',
                          '1'
                      );

INSERT INTO ORGANISME (
                          ORGA_ID,
                          ORG_ORGA_ID,
                          ORGA_LB,
                          ORGA_CD,
                          ORGA_FG,
                          ORGA_BL_MODULE,
                          BL_MAJ
                      )
                      VALUES (
                          '102',
                          '1031',
                          'GUYANE',
                          'D9C',
                          'D',
                          '0',
                          '1'
                      );

INSERT INTO ORGANISME (
                          ORGA_ID,
                          ORG_ORGA_ID,
                          ORGA_LB,
                          ORGA_CD,
                          ORGA_FG,
                          ORGA_BL_MODULE,
                          BL_MAJ
                      )
                      VALUES (
                          '103',
                          '1032',
                          'REUNION',
                          'D9D',
                          'D',
                          '0',
                          '1'
                      );

INSERT INTO ORGANISME (
                          ORGA_ID,
                          ORG_ORGA_ID,
                          ORGA_LB,
                          ORGA_CD,
                          ORGA_FG,
                          ORGA_BL_MODULE,
                          BL_MAJ
                      )
                      VALUES (
                          '104',
                          '1032',
                          'NOUVELLE CALEDONIE NORD',
                          'D9E',
                          'D',
                          '0',
                          '1'
                      );

INSERT INTO ORGANISME (
                          ORGA_ID,
                          ORG_ORGA_ID,
                          ORGA_LB,
                          ORGA_CD,
                          ORGA_FG,
                          ORGA_BL_MODULE,
                          BL_MAJ
                      )
                      VALUES (
                          '105',
                          '1036',
                          'NOUVELLE CALEDONIE SUD',
                          'D9F',
                          'D',
                          '0',
                          '1'
                      );

INSERT INTO ORGANISME (
                          ORGA_ID,
                          ORG_ORGA_ID,
                          ORGA_LB,
                          ORGA_CD,
                          ORGA_FG,
                          ORGA_BL_MODULE,
                          BL_MAJ
                      )
                      VALUES (
                          '106',
                          '1037',
                          'MAYOTTE',
                          'D9G',
                          'D',
                          '0',
                          '1'
                      );

INSERT INTO ORGANISME (
                          ORGA_ID,
                          ORG_ORGA_ID,
                          ORGA_LB,
                          ORGA_CD,
                          ORGA_FG,
                          ORGA_BL_MODULE,
                          BL_MAJ
                      )
                      VALUES (
                          '107',
                          '10004',
                          'TAHITI',
                          'D9H',
                          'D',
                          '0',
                          '1'
                      );

INSERT INTO ORGANISME (
                          ORGA_ID,
                          ORG_ORGA_ID,
                          ORGA_LB,
                          ORGA_CD,
                          ORGA_FG,
                          ORGA_BL_MODULE,
                          BL_MAJ
                      )
                      VALUES (
                          '1001',
                          '10005',
                          'RHONE ALPES',
                          'L01',
                          'L',
                          '0',
                          '1'
                      );

INSERT INTO ORGANISME (
                          ORGA_ID,
                          ORG_ORGA_ID,
                          ORGA_LB,
                          ORGA_CD,
                          ORGA_FG,
                          ORGA_BL_MODULE,
                          BL_MAJ
                      )
                      VALUES (
                          '1002',
                          '10003',
                          'ALSACE',
                          'L02',
                          'L',
                          '1',
                          '1'
                      );

INSERT INTO ORGANISME (
                          ORGA_ID,
                          ORG_ORGA_ID,
                          ORGA_LB,
                          ORGA_CD,
                          ORGA_FG,
                          ORGA_BL_MODULE,
                          BL_MAJ
                      )
                      VALUES (
                          '1003',
                          '10002',
                          'AQUITAINE',
                          'L03',
                          'L',
                          '0',
                          '1'
                      );

INSERT INTO ORGANISME (
                          ORGA_ID,
                          ORG_ORGA_ID,
                          ORGA_LB,
                          ORGA_CD,
                          ORGA_FG,
                          ORGA_BL_MODULE,
                          BL_MAJ
                      )
                      VALUES (
                          '1004',
                          '10004',
                          'PAYS DE LA LOIRE',
                          'L04',
                          'L',
                          '0',
                          '1'
                      );

INSERT INTO ORGANISME (
                          ORGA_ID,
                          ORG_ORGA_ID,
                          ORGA_LB,
                          ORGA_CD,
                          ORGA_FG,
                          ORGA_BL_MODULE,
                          BL_MAJ
                      )
                      VALUES (
                          '1005',
                          '10005',
                          'AUVERGNE',
                          'L05',
                          'L',
                          '0',
                          '1'
                      );

INSERT INTO ORGANISME (
                          ORGA_ID,
                          ORG_ORGA_ID,
                          ORGA_LB,
                          ORGA_CD,
                          ORGA_FG,
                          ORGA_BL_MODULE,
                          BL_MAJ
                      )
                      VALUES (
                          '1006',
                          '10002',
                          'BOURGOGNE',
                          'L06',
                          'L',
                          '0',
                          '1'
                      );

INSERT INTO ORGANISME (
                          ORGA_ID,
                          ORG_ORGA_ID,
                          ORGA_LB,
                          ORGA_CD,
                          ORGA_FG,
                          ORGA_BL_MODULE,
                          BL_MAJ
                      )
                      VALUES (
                          '1007',
                          '10005',
                          'BRETAGNE',
                          'L07',
                          'L',
                          '0',
                          '1'
                      );

INSERT INTO ORGANISME (
                          ORGA_ID,
                          ORG_ORGA_ID,
                          ORGA_LB,
                          ORGA_CD,
                          ORGA_FG,
                          ORGA_BL_MODULE,
                          BL_MAJ
                      )
                      VALUES (
                          '1008',
                          '10004',
                          'CHAMPAGNE - ARDENNE',
                          'L08',
                          'L',
                          '1',
                          '1'
                      );

INSERT INTO ORGANISME (
                          ORGA_ID,
                          ORG_ORGA_ID,
                          ORGA_LB,
                          ORGA_CD,
                          ORGA_FG,
                          ORGA_BL_MODULE,
                          BL_MAJ
                      )
                      VALUES (
                          '1009',
                          '10006',
                          'COTE D AZUR',
                          'L09',
                          'L',
                          '0',
                          '1'
                      );

INSERT INTO ORGANISME (
                          ORGA_ID,
                          ORG_ORGA_ID,
                          ORGA_LB,
                          ORGA_CD,
                          ORGA_FG,
                          ORGA_BL_MODULE,
                          BL_MAJ
                      )
                      VALUES (
                          '1010',
                          '10005',
                          'NORD/PAS-DE-CALAIS',
                          'L10',
                          'L',
                          '0',
                          '1'
                      );

INSERT INTO ORGANISME (
                          ORGA_ID,
                          ORG_ORGA_ID,
                          ORGA_LB,
                          ORGA_CD,
                          ORGA_FG,
                          ORGA_BL_MODULE,
                          BL_MAJ
                      )
                      VALUES (
                          '1011',
                          '10001',
                          'FRANCHE COMTE',
                          'L11',
                          'L',
                          '0',
                          '1'
                      );

INSERT INTO ORGANISME (
                          ORGA_ID,
                          ORG_ORGA_ID,
                          ORGA_LB,
                          ORGA_CD,
                          ORGA_FG,
                          ORGA_BL_MODULE,
                          BL_MAJ
                      )
                      VALUES (
                          '1012',
                          '10004',
                          'ILE DE FRANCE',
                          'L12',
                          'L',
                          '0',
                          '1'
                      );

INSERT INTO ORGANISME (
                          ORGA_ID,
                          ORG_ORGA_ID,
                          ORGA_LB,
                          ORGA_CD,
                          ORGA_FG,
                          ORGA_BL_MODULE,
                          BL_MAJ
                      )
                      VALUES (
                          '1013',
                          '10003',
                          'LANGUEDOC ROUSSILLON',
                          'L13',
                          'L',
                          '0',
                          '1'
                      );

INSERT INTO ORGANISME (
                          ORGA_ID,
                          ORG_ORGA_ID,
                          ORGA_LB,
                          ORGA_CD,
                          ORGA_FG,
                          ORGA_BL_MODULE,
                          BL_MAJ
                      )
                      VALUES (
                          '1014',
                          '10005',
                          'LIMOUSIN',
                          'L14',
                          'L',
                          '0',
                          '1'
                      );

INSERT INTO ORGANISME (
                          ORGA_ID,
                          ORG_ORGA_ID,
                          ORGA_LB,
                          ORGA_CD,
                          ORGA_FG,
                          ORGA_BL_MODULE,
                          BL_MAJ
                      )
                      VALUES (
                          '1015',
                          '10006',
                          'LORRAINE',
                          'L15',
                          'L',
                          '0',
                          '1'
                      );

INSERT INTO ORGANISME (
                          ORGA_ID,
                          ORG_ORGA_ID,
                          ORGA_LB,
                          ORGA_CD,
                          ORGA_FG,
                          ORGA_BL_MODULE,
                          BL_MAJ
                      )
                      VALUES (
                          '1017',
                          '10006',
                          'BASSE NORMANDIE',
                          'L17',
                          'L',
                          '0',
                          '1'
                      );

INSERT INTO ORGANISME (
                          ORGA_ID,
                          ORG_ORGA_ID,
                          ORGA_LB,
                          ORGA_CD,
                          ORGA_FG,
                          ORGA_BL_MODULE,
                          BL_MAJ
                      )
                      VALUES (
                          '1018',
                          '10006',
                          'HAUTE NORMANDIE',
                          'L18',
                          'L',
                          '0',
                          '1'
                      );

INSERT INTO ORGANISME (
                          ORGA_ID,
                          ORG_ORGA_ID,
                          ORGA_LB,
                          ORGA_CD,
                          ORGA_FG,
                          ORGA_BL_MODULE,
                          BL_MAJ
                      )
                      VALUES (
                          '1019',
                          '10003',
                          'PICARDIE',
                          'L19',
                          'L',
                          '0',
                          '1'
                      );

INSERT INTO ORGANISME (
                          ORGA_ID,
                          ORG_ORGA_ID,
                          ORGA_LB,
                          ORGA_CD,
                          ORGA_FG,
                          ORGA_BL_MODULE,
                          BL_MAJ
                      )
                      VALUES (
                          '1020',
                          '10004',
                          'POITOU CHARENTES',
                          'L20',
                          'L',
                          '1',
                          '1'
                      );

INSERT INTO ORGANISME (
                          ORGA_ID,
                          ORG_ORGA_ID,
                          ORGA_LB,
                          ORGA_CD,
                          ORGA_FG,
                          ORGA_BL_MODULE,
                          BL_MAJ
                      )
                      VALUES (
                          '1021',
                          '10003',
                          'PROVENCE',
                          'L21',
                          'L',
                          '0',
                          '1'
                      );

INSERT INTO ORGANISME (
                          ORGA_ID,
                          ORG_ORGA_ID,
                          ORGA_LB,
                          ORGA_CD,
                          ORGA_FG,
                          ORGA_BL_MODULE,
                          BL_MAJ
                      )
                      VALUES (
                          '1022',
                          '10001',
                          'MIDI-PYRENEES',
                          'L22',
                          'L',
                          '1',
                          '1'
                      );

INSERT INTO ORGANISME (
                          ORGA_ID,
                          ORG_ORGA_ID,
                          ORGA_LB,
                          ORGA_CD,
                          ORGA_FG,
                          ORGA_BL_MODULE,
                          BL_MAJ
                      )
                      VALUES (
                          '1023',
                          '10004',
                          'CENTRE',
                          'L23',
                          'L',
                          '0',
                          '1'
                      );

INSERT INTO ORGANISME (
                          ORGA_ID,
                          ORG_ORGA_ID,
                          ORGA_LB,
                          ORGA_CD,
                          ORGA_FG,
                          ORGA_BL_MODULE,
                          BL_MAJ
                      )
                      VALUES (
                          '1024',
                          '10007',
                          'CORSE',
                          'L24',
                          'L',
                          '0',
                          '1'
                      );

INSERT INTO ORGANISME (
                          ORGA_ID,
                          ORG_ORGA_ID,
                          ORGA_LB,
                          ORGA_CD,
                          ORGA_FG,
                          ORGA_BL_MODULE,
                          BL_MAJ
                      )
                      VALUES (
                          '1030',
                          '10007',
                          'GUYANE.L',
                          'L30',
                          'L',
                          '0',
                          '1'
                      );

INSERT INTO ORGANISME (
                          ORGA_ID,
                          ORG_ORGA_ID,
                          ORGA_LB,
                          ORGA_CD,
                          ORGA_FG,
                          ORGA_BL_MODULE,
                          BL_MAJ
                      )
                      VALUES (
                          '1031',
                          '10007',
                          'REUNION.L',
                          'L31',
                          'L',
                          '1',
                          '1'
                      );

INSERT INTO ORGANISME (
                          ORGA_ID,
                          ORG_ORGA_ID,
                          ORGA_LB,
                          ORGA_CD,
                          ORGA_FG,
                          ORGA_BL_MODULE,
                          BL_MAJ
                      )
                      VALUES (
                          '1032',
                          '10007',
                          'NOUVELLE CALEDONIE',
                          'L32',
                          'L',
                          '0',
                          '1'
                      );

INSERT INTO ORGANISME (
                          ORGA_ID,
                          ORG_ORGA_ID,
                          ORGA_LB,
                          ORGA_CD,
                          ORGA_FG,
                          ORGA_BL_MODULE,
                          BL_MAJ
                      )
                      VALUES (
                          '1033',
                          '10007',
                          'GUADELOUPE.L',
                          'L33',
                          'L',
                          '0',
                          '1'
                      );

INSERT INTO ORGANISME (
                          ORGA_ID,
                          ORG_ORGA_ID,
                          ORGA_LB,
                          ORGA_CD,
                          ORGA_FG,
                          ORGA_BL_MODULE,
                          BL_MAJ
                      )
                      VALUES (
                          '1034',
                          '10007',
                          'MARTINIQUE.L',
                          'L34',
                          'L',
                          '1',
                          '1'
                      );

INSERT INTO ORGANISME (
                          ORGA_ID,
                          ORG_ORGA_ID,
                          ORGA_LB,
                          ORGA_CD,
                          ORGA_FG,
                          ORGA_BL_MODULE,
                          BL_MAJ
                      )
                      VALUES (
                          '1036',
                          '10007',
                          'MAYOTTE.L',
                          'L36',
                          'L',
                          '0',
                          '1'
                      );

INSERT INTO ORGANISME (
                          ORGA_ID,
                          ORG_ORGA_ID,
                          ORGA_LB,
                          ORGA_CD,
                          ORGA_FG,
                          ORGA_BL_MODULE,
                          BL_MAJ
                      )
                      VALUES (
                          '1037',
                          '100001',
                          'TAHITI.L',
                          'L37',
                          'L',
                          '0',
                          '1'
                      );

INSERT INTO ORGANISME (
                          ORGA_ID,
                          ORG_ORGA_ID,
                          ORGA_LB,
                          ORGA_CD,
                          ORGA_FG,
                          ORGA_BL_MODULE,
                          BL_MAJ
                      )
                      VALUES (
                          '10001',
                          '100001',
                          'ZONE 1',
                          'Z01',
                          'Z',
                          '0',
                          '1'
                      );

INSERT INTO ORGANISME (
                          ORGA_ID,
                          ORG_ORGA_ID,
                          ORGA_LB,
                          ORGA_CD,
                          ORGA_FG,
                          ORGA_BL_MODULE,
                          BL_MAJ
                      )
                      VALUES (
                          '10002',
                          '100001',
                          'ZONE 2',
                          'Z02',
                          'Z',
                          '0',
                          '1'
                      );

INSERT INTO ORGANISME (
                          ORGA_ID,
                          ORG_ORGA_ID,
                          ORGA_LB,
                          ORGA_CD,
                          ORGA_FG,
                          ORGA_BL_MODULE,
                          BL_MAJ
                      )
                      VALUES (
                          '10003',
                          '100001',
                          'ZONE 3',
                          'Z03',
                          'Z',
                          '1',
                          '1'
                      );

INSERT INTO ORGANISME (
                          ORGA_ID,
                          ORG_ORGA_ID,
                          ORGA_LB,
                          ORGA_CD,
                          ORGA_FG,
                          ORGA_BL_MODULE,
                          BL_MAJ
                      )
                      VALUES (
                          '10004',
                          '100001',
                          'ZONE 4',
                          'Z04',
                          'Z',
                          '0',
                          '1'
                      );

INSERT INTO ORGANISME (
                          ORGA_ID,
                          ORG_ORGA_ID,
                          ORGA_LB,
                          ORGA_CD,
                          ORGA_FG,
                          ORGA_BL_MODULE,
                          BL_MAJ
                      )
                      VALUES (
                          '10005',
                          '100001',
                          'ZONE 5',
                          'Z05',
                          'Z',
                          '0',
                          '1'
                      );

INSERT INTO ORGANISME (
                          ORGA_ID,
                          ORG_ORGA_ID,
                          ORGA_LB,
                          ORGA_CD,
                          ORGA_FG,
                          ORGA_BL_MODULE,
                          BL_MAJ
                      )
                      VALUES (
                          '10006',
                          '100001',
                          'ZONE 6',
                          'Z06',
                          'Z',
                          '0',
                          '1'
                      );

INSERT INTO ORGANISME (
                          ORGA_ID,
                          ORG_ORGA_ID,
                          ORGA_LB,
                          ORGA_CD,
                          ORGA_FG,
                          ORGA_BL_MODULE,
                          BL_MAJ
                      )
                      VALUES (
                          '10007',
                          '',
                          'ZONE 7',
                          'Z07',
                          'Z',
                          '0',
                          '1'
                      );

INSERT INTO ORGANISME (
                          ORGA_ID,
                          ORG_ORGA_ID,
                          ORGA_LB,
                          ORGA_CD,
                          ORGA_FG,
                          ORGA_BL_MODULE,
                          BL_MAJ
                      )
                      VALUES (
                          '100001',
                          '',
                          'FFTT',
                          'FEDE',
                          'F',
                          '0',
                          '1'
                      );


-- Table : PACKAGE
DROP TABLE IF EXISTS PACKAGE;

CREATE TABLE PACKAGE (
    PKG_ID,
    UTIL_LB_LOGIN,
    PKG_LB,
    PKG_ETAT,
    PKG_LB_USER_MODIF,
    PKG_DT_MODIFICATION,
    PKG_DT_CREATION,
    PKG_DATE_DESC,
    PKG_DATE_MONTE
);


-- Table : PACKAGE_TABLEAU
DROP TABLE IF EXISTS PACKAGE_TABLEAU;

CREATE TABLE PACKAGE_TABLEAU (
    PKG_ID,
    TAB_ID
);


-- Table : PARAMETRE
DROP TABLE IF EXISTS PARAMETRE;

CREATE TABLE PARAMETRE (
    PARM_CD,
    PARM_LB,
    PARM_DT_CREA
);

INSERT INTO PARAMETRE (
                          PARM_CD,
                          PARM_LB,
                          PARM_DT_CREA
                      )
                      VALUES (
                          'BASE ',
                          '1.8',
                          '09/09/2004 00:00:00'
                      );

INSERT INTO PARAMETRE (
                          PARM_CD,
                          PARM_LB,
                          PARM_DT_CREA
                      )
                      VALUES (
                          'REFER',
                          'Date de création du référentiel',
                          '09/09/2004 07:25:24'
                      );


-- Table : PARTIE
DROP TABLE IF EXISTS PARTIE;

CREATE TABLE PARTIE (
    PARTI_ID,
    LIC_ID,
    LIC_LIC_ID,
    RENC_ID,
    PARTI_NB_ORDRE,
    PARTI_BL_GAGNE1,
    PARTI_BL_GAGNE2,
    PARTI_BL_FORFAIT,
    EPRV_ID,
    PARTI_BL_SUPPRIMEE,
    PARTI_DT,
    PARTI_NM_TOUR,
    PARTI_BL_DOUBLE,
    TAB_ID,
    PARTI_NB_POINT1,
    PARTI_NB_POINT2,
    PARTI_BL_CLST,
    PARTI_BL_NONJOUEE
);


-- Table : PARTIE_REF
DROP TABLE IF EXISTS PARTIE_REF;

CREATE TABLE PARTIE_REF (
    RPARTI_ID_PARTIE_REF,
    NIVREF_ID,
    PAR_RPARTI_ID_PARTIE_REF,
    PAR2_RPARTI_ID_PARTIE_REF,
    RPARTI_NM_RANG1,
    RPARTI_NM_RANG2,
    RPARTI_NM_ORDRE_REF,
    RPARTI_NM_PARTIE_REF,
    RPARTI_FG_PARTIE_1,
    RPARTI_NM_CLST_VAINQUEUR,
    RPARTI_NM_POULE1,
    RPARTI_NM_CLASSEMENT1,
    RPARTI_NM_POULE2,
    RPARTI_NM_CLASSEMENT2,
    RPARTI_NM_POSITION1,
    RPARTI_NM_POSITION2,
    RPARTI_FG_PARTIE_2,
    RPARTI_NM_CLST_PERDANT,
    RPARTI_FG_PARTIE_REF,
    RPARTI_NM_CLST_REF,
    BL_MAJ,
    RPARTI_BL_CLST_NONJOUEE
);


-- Table : PBCATCOL
DROP TABLE IF EXISTS PBCATCOL;

CREATE TABLE PBCATCOL (
    PBC_TNAM,
    PBC_TID,
    PBC_OWNR,
    PBC_CNAM,
    PBC_CID,
    PBC_LABL,
    PBC_LPOS,
    PBC_HDR,
    PBC_HPOS,
    PBC_JTFY,
    PBC_MASK,
    PBC_CASE,
    PBC_HGHT,
    PBC_WDTH,
    PBC_PTRN,
    PBC_BMAP,
    PBC_INIT,
    PBC_CMNT,
    PBC_EDIT,
    PBC_TAG
);


-- Table : PBCATEDT
DROP TABLE IF EXISTS PBCATEDT;

CREATE TABLE PBCATEDT (
    PBE_NAME,
    PBE_EDIT,
    PBE_TYPE,
    PBE_CNTR,
    PBE_SEQN,
    PBE_FLAG,
    PBE_WORK
);


-- Table : PBCATFMT
DROP TABLE IF EXISTS PBCATFMT;

CREATE TABLE PBCATFMT (
    PBF_NAME,
    PBF_FRMT,
    PBF_TYPE,
    PBF_CNTR
);


-- Table : PBCATTBL
DROP TABLE IF EXISTS PBCATTBL;

CREATE TABLE PBCATTBL (
    PBT_TNAM,
    PBT_TID,
    PBT_OWNR,
    PBD_FHGT,
    PBD_FWGT,
    PBD_FITL,
    PBD_FUNL,
    PBD_FCHR,
    PBD_FPTC,
    PBD_FFCE,
    PBH_FHGT,
    PBH_FWGT,
    PBH_FITL,
    PBH_FUNL,
    PBH_FCHR,
    PBH_FPTC,
    PBH_FFCE,
    PBL_FHGT,
    PBL_FWGT,
    PBL_FITL,
    PBL_FUNL,
    PBL_FCHR,
    PBL_FPTC,
    PBL_FFCE,
    PBT_CMNT
);


-- Table : PBCATVLD
DROP TABLE IF EXISTS PBCATVLD;

CREATE TABLE PBCATVLD (
    PBV_NAME,
    PBV_VALD,
    PBV_TYPE,
    PBV_CNTR,
    PBV_MSG
);


-- Table : POT
DROP TABLE IF EXISTS POT;

CREATE TABLE POT (
    POT_ID,
    POT_LB,
    POT_DT,
    POT_NB_TABLE,
    POT_NB_TRANCHE,
    POT_HEURE,
    POT_MINUTE,
    POT_NB_INTERVALLE,
    POT_NB_TABLE_MAX,
    POT_POT_ID
);


-- Table : POT_TABLEAU
DROP TABLE IF EXISTS POT_TABLEAU;

CREATE TABLE POT_TABLEAU (
    POT_ID,
    TAB_ID,
    POTTAB_CODE_ROUGE,
    POTTAB_CODE_VERT,
    POTTAB_CODE_BLEU
);


-- Table : POULE
DROP TABLE IF EXISTS POULE;

CREATE TABLE POULE (
    POUL_ID,
    GRIL_ID_RENC,
    CALEN_ID_SPORTIF,
    FEUIL_ID_RENC,
    DIV_ID,
    POUL_CD,
    POUL_LB,
    POUL_NM_GROUPE,
    POUL_BL_VIRTUEL,
    POUL_DT,
    POUL_DT_VALIDATION,
    POUL_LB_COMPETIT,
    POUL_LB_USER_MODIF,
    POUL_DT_MODIFICATION,
    POUL_DT_CREATION,
    TAB_ID,
    POUL_NM_TABLEAU
);


-- Table : SECURITE
DROP TABLE IF EXISTS SECURITE;

CREATE TABLE SECURITE (
    PROFIL_CD,
    PROFIL_LB,
    PROFIL_PWD
);

INSERT INTO SECURITE (
                         PROFIL_CD,
                         PROFIL_LB,
                         PROFIL_PWD
                     )
                     VALUES (
                         'C    ',
                         'Consultation',
                         'consult'
                     );

INSERT INTO SECURITE (
                         PROFIL_CD,
                         PROFIL_LB,
                         PROFIL_PWD
                     )
                     VALUES (
                         'M    ',
                         'Modification',
                         'modif'
                     );

INSERT INTO SECURITE (
                         PROFIL_CD,
                         PROFIL_LB,
                         PROFIL_PWD
                     )
                     VALUES (
                         'A    ',
                         'Administration',
                         ''
                     );


-- Table : TABLEAU
DROP TABLE IF EXISTS TABLEAU;

CREATE TABLE TABLEAU (
    TAB_ID,
    TABREF_ID,
    TOUR_ID,
    TAB_NB_GROUPE,
    TAB_CD_TABLEAU,
    TAB_LB,
    TAB_DT_HEURE,
    TAB_LB_LIEU,
    TAB_CM_TABLEAU,
    TAB_CM_TABLE_JUGE,
    TAB_LB_RAPPORT,
    TAB_LB_USER_MODIF,
    TAB_DT_MODIFICATION,
    TAB_DT_CREATION
);


-- Table : TABLEAU_PARTIE
DROP TABLE IF EXISTS TABLEAU_PARTIE;

CREATE TABLE TABLEAU_PARTIE (
    TABPART_ID_TABLEAU,
    POUL_ID,
    NIV_ID,
    INSC_ID,
    INS_INSC_ID,
    PARTI_ID,
    TABPART_NM_ORDRE_NIVEAU,
    TABPART_NM_TABLEAU,
    TABPART_NM_VAINQUEUR,
    TABPART_DT_HEURE,
    TABPART_NB_TABLE,
    RPARTI_ID_PARTIE_REF,
    TABPART_TYPE_PARTIE,
    TABPART_NM_PERDANT,
    TABPART_LB_PARTIE,
    TABPART_BL_CLST
);


-- Table : TABLEAU_REF
DROP TABLE IF EXISTS TABLEAU_REF;

CREATE TABLE TABLEAU_REF (
    TABREF_ID,
    TABREF_CD,
    TABREF_LB,
    TABREF_FG,
    TABREF_NB_JOUEURS_REF,
    TABREF_CM,
    TABREF_LB_USER_MODIF,
    TABREF_DT_MODIFICATION,
    TABREF_DT_CREATION,
    TABREF_SAISIE_TYPE,
    BL_MAJ
);


-- Table : TIRAGE
DROP TABLE IF EXISTS TIRAGE;

CREATE TABLE TIRAGE (
    TIRAGE_ID,
    TAB_ID,
    TIRAGE_NUM_LIGNE,
    TIRAGE_NUM_COLONNE,
    TIRAGE_VALEUR,
    TIRAGE_BL_QUALIFIE
);


-- Table : TOUR
DROP TABLE IF EXISTS TOUR;

CREATE TABLE TOUR (
    TOUR_ID,
    DIV_ID,
    TOUR_LB,
    TOUR_NB_GROUPE,
    TOUR_NB_POULE,
    TOUR_NB_JOUEUR,
    TOUR_NB_JOUEUR_DESC,
    TOUR_NB_JOUEUR_MONT,
    TOUR_DT,
    TOUR_LB_USER_MODIF,
    TOUR_DT_MODIFICATION,
    TOUR_DT_CREATION,
    GRIL_ID_RENC,
    TOUR_BL_CLOTURE,
    TOUR_NM,
    DIV_DIV_LB,
    DIV2_DIV_LB
);

INSERT INTO TOUR (
                     TOUR_ID,
                     DIV_ID,
                     TOUR_LB,
                     TOUR_NB_GROUPE,
                     TOUR_NB_POULE,
                     TOUR_NB_JOUEUR,
                     TOUR_NB_JOUEUR_DESC,
                     TOUR_NB_JOUEUR_MONT,
                     TOUR_DT,
                     TOUR_LB_USER_MODIF,
                     TOUR_DT_MODIFICATION,
                     TOUR_DT_CREATION,
                     GRIL_ID_RENC,
                     TOUR_BL_CLOTURE,
                     TOUR_NM,
                     DIV_DIV_LB,
                     DIV2_DIV_LB
                 )
                 VALUES (
                     '-101',
                     '-101',
                     'Inconnu',
                     '0',
                     '0',
                     '0',
                     '',
                     '',
                     '',
                     'SPIDD',
                     '',
                     '01/01/1900 00:00:00',
                     '',
                     '',
                     '0',
                     '',
                     ''
                 );


-- Table : TYPE_CLASSEMENT
DROP TABLE IF EXISTS TYPE_CLASSEMENT;

CREATE TABLE TYPE_CLASSEMENT (
    TCLST_ID,
    TCLST_LB,
    TCLST_CD,
    TCLST_NB_POINT_MIN,
    BL_MAJ
);

INSERT INTO TYPE_CLASSEMENT (
                                TCLST_ID,
                                TCLST_LB,
                                TCLST_CD,
                                TCLST_NB_POINT_MIN,
                                BL_MAJ
                            )
                            VALUES (
                                '-101',
                                'Inconnu',
                                '',
                                '0',
                                '0'
                            );

INSERT INTO TYPE_CLASSEMENT (
                                TCLST_ID,
                                TCLST_LB,
                                TCLST_CD,
                                TCLST_NB_POINT_MIN,
                                BL_MAJ
                            )
                            VALUES (
                                '100',
                                'Numerote',
                                'NN',
                                '2600',
                                '1'
                            );

INSERT INTO TYPE_CLASSEMENT (
                                TCLST_ID,
                                TCLST_LB,
                                TCLST_CD,
                                TCLST_NB_POINT_MIN,
                                BL_MAJ
                            )
                            VALUES (
                                '1',
                                'NC',
                                'NC',
                                '0',
                                '1'
                            );

INSERT INTO TYPE_CLASSEMENT (
                                TCLST_ID,
                                TCLST_LB,
                                TCLST_CD,
                                TCLST_NB_POINT_MIN,
                                BL_MAJ
                            )
                            VALUES (
                                '2',
                                '90',
                                '90',
                                '660',
                                '1'
                            );

INSERT INTO TYPE_CLASSEMENT (
                                TCLST_ID,
                                TCLST_LB,
                                TCLST_CD,
                                TCLST_NB_POINT_MIN,
                                BL_MAJ
                            )
                            VALUES (
                                '3',
                                '85',
                                '85',
                                '680',
                                '1'
                            );

INSERT INTO TYPE_CLASSEMENT (
                                TCLST_ID,
                                TCLST_LB,
                                TCLST_CD,
                                TCLST_NB_POINT_MIN,
                                BL_MAJ
                            )
                            VALUES (
                                '4',
                                '80',
                                '80',
                                '700',
                                '1'
                            );

INSERT INTO TYPE_CLASSEMENT (
                                TCLST_ID,
                                TCLST_LB,
                                TCLST_CD,
                                TCLST_NB_POINT_MIN,
                                BL_MAJ
                            )
                            VALUES (
                                '5',
                                '75',
                                '75',
                                '800',
                                '1'
                            );

INSERT INTO TYPE_CLASSEMENT (
                                TCLST_ID,
                                TCLST_LB,
                                TCLST_CD,
                                TCLST_NB_POINT_MIN,
                                BL_MAJ
                            )
                            VALUES (
                                '6',
                                '70',
                                '70',
                                '900',
                                '1'
                            );

INSERT INTO TYPE_CLASSEMENT (
                                TCLST_ID,
                                TCLST_LB,
                                TCLST_CD,
                                TCLST_NB_POINT_MIN,
                                BL_MAJ
                            )
                            VALUES (
                                '7',
                                '65',
                                '65',
                                '1000',
                                '1'
                            );

INSERT INTO TYPE_CLASSEMENT (
                                TCLST_ID,
                                TCLST_LB,
                                TCLST_CD,
                                TCLST_NB_POINT_MIN,
                                BL_MAJ
                            )
                            VALUES (
                                '8',
                                '60',
                                '60',
                                '1100',
                                '1'
                            );

INSERT INTO TYPE_CLASSEMENT (
                                TCLST_ID,
                                TCLST_LB,
                                TCLST_CD,
                                TCLST_NB_POINT_MIN,
                                BL_MAJ
                            )
                            VALUES (
                                '9',
                                '55',
                                '55',
                                '1200',
                                '1'
                            );

INSERT INTO TYPE_CLASSEMENT (
                                TCLST_ID,
                                TCLST_LB,
                                TCLST_CD,
                                TCLST_NB_POINT_MIN,
                                BL_MAJ
                            )
                            VALUES (
                                '10',
                                '50',
                                '50',
                                '1300',
                                '1'
                            );

INSERT INTO TYPE_CLASSEMENT (
                                TCLST_ID,
                                TCLST_LB,
                                TCLST_CD,
                                TCLST_NB_POINT_MIN,
                                BL_MAJ
                            )
                            VALUES (
                                '11',
                                '45',
                                '45',
                                '1400',
                                '1'
                            );

INSERT INTO TYPE_CLASSEMENT (
                                TCLST_ID,
                                TCLST_LB,
                                TCLST_CD,
                                TCLST_NB_POINT_MIN,
                                BL_MAJ
                            )
                            VALUES (
                                '12',
                                '40',
                                '40',
                                '1500',
                                '1'
                            );

INSERT INTO TYPE_CLASSEMENT (
                                TCLST_ID,
                                TCLST_LB,
                                TCLST_CD,
                                TCLST_NB_POINT_MIN,
                                BL_MAJ
                            )
                            VALUES (
                                '13',
                                '35',
                                '35',
                                '1600',
                                '1'
                            );

INSERT INTO TYPE_CLASSEMENT (
                                TCLST_ID,
                                TCLST_LB,
                                TCLST_CD,
                                TCLST_NB_POINT_MIN,
                                BL_MAJ
                            )
                            VALUES (
                                '14',
                                '30',
                                '30',
                                '1700',
                                '1'
                            );

INSERT INTO TYPE_CLASSEMENT (
                                TCLST_ID,
                                TCLST_LB,
                                TCLST_CD,
                                TCLST_NB_POINT_MIN,
                                BL_MAJ
                            )
                            VALUES (
                                '15',
                                '25',
                                '25',
                                '1800',
                                '1'
                            );


COMMIT TRANSACTION;
PRAGMA foreign_keys = on;
