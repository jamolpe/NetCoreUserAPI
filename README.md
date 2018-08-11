# Users API
--------

## Tecnologías

Para el desarrollo de esta api se han utilizado las siguientes tecnologías y herramientas:

* Postman
* Visual Studio code / Visual Studio mac / Visual Studio 2017
* ASP.NET Core and C# for cross-platform server-side code
* JWT token generator

## Configuración
--------
En este proyecto se pueden configurar diferentes elementos de la API:
* Tiempo en horas de expiración del token
* Secret para generación de tokens
* String de conexión de bases de datos

```json
{
  "AppSettings": {
    "TokenExpirationHours": 2, 
    "Secret": "ThetokenSecrethavetobebiggerthan128bits",
    "DataBaseConnection": "Server=localhost;Database=Users;UserID=test;Password=test"
  }
}
```
Estos elementos se encuentran en el archivo appsettings.json

<sub>Proyecto desarrollado por Javier Molpeceres Gómez, la explotación y utilización de este proyecto sin el consentimiento del desarrollador queda totalmente prohibida.