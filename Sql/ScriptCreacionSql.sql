CREATE SCHEMA `lubee_project` ;

CREATE TABLE `contrato` (
  `Id` int NOT NULL,
  `ContractId` int NOT NULL,
  `ItemId` int NOT NULL,
  `CreatedDate` datetime NOT NULL,
  `UpdateDate` datetime DEFAULT NULL,
  `Enabled` BOOLEAN  NOT NULL,
  `Deleted` BOOLEAN  NOT NULL,
  `CreatedBy` varchar(45) DEFAULT NULL,
  PRIMARY KEY (`Id`)
);

CREATE TABLE `curso` (
  `Id` int NOT NULL,
  `CourseCode` varchar(45) NOT NULL,
  `FechaAlta` datetime NOT NULL,
  `Estado` int NOT NULL,
  `CantidadEgresado` int NOT NULL,
  `FechaEntrega` datetime NOT NULL,
  `MediaEntrega` int DEFAULT NULL,
  `Vendedor` int DEFAULT NULL,
  `ColegioNivel` varchar(45) NOT NULL,
  `ColegioNombre` varchar(45) NOT NULL,
  `ColegioCurso` varchar(45) NOT NULL,
  `ColegioLocalidad` varchar(45) NOT NULL,
  `Comision` int NOT NULL,
  `Total` decimal(6,0) DEFAULT NULL,
  PRIMARY KEY (`Id`)
);

CREATE TABLE `producto` (
  `Id` int NOT NULL,
  `Nombre` varchar(45) NOT NULL,
  `Precio` decimal(15,2) DEFAULT NULL,
  PRIMARY KEY (`Id`)
);