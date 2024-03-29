﻿IF OBJECT_ID('DOCUMENTO', 'U') IS NOT NULL
DROP TABLE DOCUMENTO;

IF OBJECT_ID('PUBLICACION', 'U') IS NOT NULL
DROP TABLE DOCUMENTO;

IF OBJECT_ID('HISTORICO', 'U') IS NOT NULL
DROP TABLE DOCUMENTO;

CREATE TABLE DOCUMENTO (
COD VARCHAR(20) PRIMARY KEY,
NOMBRE VARCHAR(100) NOT NULL,
ALCANCE VARCHAR(5000) NOT NULL,
ENCARGADO VARCHAR(100) NOT NULL,
CREADO DATE NOT NULL
);

CREATE TABLE PUBLICACION (
COD VARCHAR(20) NOT NULL REFERENCES DOCUMENTO(COD),
VERS VARCHAR(20) NOT NULL,
DETALLE VARCHAR(1000),
ARCHIVO VARBINARY(MAX) NOT NULL,
FECHAR DATE NOT NULL,
PUBLICADO_POR VARCHAR(100) NOT NULL,
SECCION VARCHAR(30) NOT NULL,
AMBITO VARCHAR(30) NOT NULL,
SIS_GESTION VARCHAR(30) NOT NULL,
PROCEDENCIA VARCHAR(30) NOT NULL,
TIPO_ALCANCE VARCHAR(30) NOT NULL,
PRIMARY KEY(COD,VERS)
);

CREATE TABLE HISTORICO(
ID INT PRIMARY KEY IDENTITY(1,1),
USUARIO VARCHAR(100) NOT NULL,
ACCION VARCHAR(200) NOT NULL,
FECHA DATE NOT NULL
);

--CREATE TABLE SECCION(
--ID INT PRIMARY KEY IDENTITY(1,1),
--SECCION VARCHAR(30)
--)


