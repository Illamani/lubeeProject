# Projecto Lubee

## Project setup

## FRONTEND

--Para iniciar con el setup del front lo primero que vamos a necesitar es la instalacion de vue.js
Considerando que se tiene ya previamente instalado npm, de ser asi utilizar el siguiente comando
--npm install vue--
Luego de instalar dirijiendose a la carpeta donde esta situado el projecto del front ejecutar el siguiente comando:
--npm run serve--

## BACKEND

--Para iniciar el backend se debe tener instalado la version 7 de .NET junto con Visual Studio

Luego en el archivo appsettings.json se debe modificar el connectionString, mas precisamente la password para poder utilizar el servidor de mySql

Tambien se debe utilizar el entorno de desarrollo "lubeeProject" y no otro como el IIS Express, ya que las peticiones con axios en el front estan 
hardcodeadas a ese entorno ("Localhost:9090")

Para hacer eso en la parte superior de visual studio abajo de "Tools" y "Extensiones" se encuentra un menu emergente, setearlo como "lubeeProject"

## SQL

Se debe instalar MySql

En otro archivo estaran los scripts necesarios para correr una prueba del proyecto, tambien se encuentran metodos de INSERT dentro del backend para poder 
crear otras pruebas

El script de creacion se encuentra en la carpeta Sql como ScriptCreacionSql.sql

Luego los archivos para ingresar registros se encuentran en la misma carpeta sql dentro de otra carpeta llamada SqlImport, aqui una vez creada
las tablas de producto, contrato y curso se podra utilizar el importador de MySql en formato tanto Json como Csv