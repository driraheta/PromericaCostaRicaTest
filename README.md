# PromericaCostaRicaTest
Repositorio para almacenar la prueba técnica para el banco promerica (TI) en Costa Rica. 

## Comenzando 🚀

_Estas instrucciones te permitirán obtener una copia del proyecto en funcionamiento en tu máquina local para propósitos de desarrollo y pruebas._

### Pre-requisitos 📋
```
_Net Core 3.1_
```
```
_SQL Server_
```

### Instalación/Ejecución 🔧

_Pasos basicos:_
```
1- _Ejecutar el script que esta en la carpeta database, fuera de la solucion del proyecto_
```
```
2- Abrir la solución en Visual Studio 2019 preferentemente
```
```
3- Editar y configurar la cadena de conexión que esta en el archivo startup del proyecto API
```
```
4- Ejecutar el proyecto API
```
```
5- Probar que funcionan los metodos en swagger
```
```
6- Ejecutar el proyecto WebApp de la solución (con el proyecto API en ejecución)
```
```
7- Realizar las pruebas y validaciones que indican en el PDF
```

### Analice las pruebas end-to-end 🔩

* 1- Debe contar con un botón que al presionarlo consulte la información de la tabla maestro y la muestra como una lista en la página
* 2- Debe contar con un botón que al presionarlo llame a la página de consulta del detalle
* 3- Debe contar con un botón que llame a la página de modificación del maestro (para un registro específico)
* 4- Debe permitir modificar solo la información mínima necesaria del registro específico seleccionado
en la consulta maestro.
* 5- Debe contar con un botón que al presionarlo realice la actualización del registro.
* 6- Debe permitir regresar a la consulta del maestro.
* 7- Debe permitir la consulta de la información del registro específico seleccionado en la consulta maestro.
* 8- Debe contar con un botón que al presionarlo realice el borrado (se debe implementar un javascript
que muestre una alerta antes de modificar para confirmar si se desea eliminar o no el registro).
* 9- Debe permitir regresar a la consulta del maestro.

## Construido con 🛠️

* [Visual Studio 2019](https://visualstudio.microsoft.com/es/vs/) - IDE mas usado para desarrollo .NET. Community Edition
* [Azure Data Studio](https://docs.microsoft.com/en-us/sql/azure-data-studio/download-azure-data-studio?view=sql-server-ver15) - Para la administracion de la base de datos de forma grafíca.
* [Bootstrap](https://getbootstrap.com/docs/4.6/getting-started/introduction/) - Popular framework de css
* [FluentValidation](https://docs.fluentvalidation.net/en/latest/aspnet.html) - Nuget para realizar las validaciones de campos en el API.
* [Sweet Alert 2](https://sweetalert2.github.io/) - Para mostrar alertas, ventanas de confirmacion.

## Comentarios 📌
* Las validaciones de campos estan hechas en el API, del lado de frontend no agregue validacion de campos, esto para hacerlo unicamente en backend usando la libreria de fluent validation

## Expresiones de Gratitud 🎁

* Gracias por la oportunidad, desde el tiempo de la entrevista 📢
* Mis mejores deseos 🍺, ☕ al equipo.
* Quedo a sus ordenes para esta ocasion y futuras 🤓.

---
⌨️ por [DIRAHETA](https://github.com/driraheta) (uno que uso en ocasiones) 😊
