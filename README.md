# PromericaCostaRicaTest
Repositorio para almacenar la prueba t茅cnica para el banco promerica (TI) en Costa Rica. 

## Comenzando 馃殌

_Estas instrucciones te permitir谩n obtener una copia del proyecto en funcionamiento en tu m谩quina local para prop贸sitos de desarrollo y pruebas._

### Pre-requisitos 馃搵
```
_Net Core 3.1_
```
```
_SQL Server_
```

### Instalaci贸n/Ejecuci贸n 馃敡

_Pasos basicos:_
```
1- _Ejecutar el script que esta en la carpeta database, fuera de la solucion del proyecto_
```
```
2- Abrir la soluci贸n en Visual Studio 2019 preferentemente
```
```
3- Editar y configurar la cadena de conexi贸n que esta en el archivo startup del proyecto API
```
```
4- Ejecutar el proyecto API
```
```
5- Probar que funcionan los metodos en swagger
```
```
6- Ejecutar el proyecto WebApp de la soluci贸n (con el proyecto API en ejecuci贸n)
```
```
7- Realizar las pruebas y validaciones que indican en el PDF
```

### Analice las pruebas end-to-end 馃敥

* 1- Debe contar con un bot贸n que al presionarlo consulte la informaci贸n de la tabla maestro y la muestra como una lista en la p谩gina
* 2- Debe contar con un bot贸n que al presionarlo llame a la p谩gina de consulta del detalle
* 3- Debe contar con un bot贸n que llame a la p谩gina de modificaci贸n del maestro (para un registro espec铆fico)
* 4- Debe permitir modificar solo la informaci贸n m铆nima necesaria del registro espec铆fico seleccionado
en la consulta maestro.
* 5- Debe contar con un bot贸n que al presionarlo realice la actualizaci贸n del registro.
* 6- Debe permitir regresar a la consulta del maestro.
* 7- Debe permitir la consulta de la informaci贸n del registro espec铆fico seleccionado en la consulta maestro.
* 8- Debe contar con un bot贸n que al presionarlo realice el borrado (se debe implementar un javascript
que muestre una alerta antes de modificar para confirmar si se desea eliminar o no el registro).
* 9- Debe permitir regresar a la consulta del maestro.

## Construido con 馃洜锔?

* [Visual Studio 2019](https://visualstudio.microsoft.com/es/vs/) - IDE mas usado para desarrollo .NET. Community Edition
* [Azure Data Studio](https://docs.microsoft.com/en-us/sql/azure-data-studio/download-azure-data-studio?view=sql-server-ver15) - Para la administracion de la base de datos de forma graf铆ca.
* [Bootstrap](https://getbootstrap.com/docs/4.6/getting-started/introduction/) - Popular framework de css
* [FluentValidation](https://docs.fluentvalidation.net/en/latest/aspnet.html) - Nuget para realizar las validaciones de campos en el API.
* [Sweet Alert 2](https://sweetalert2.github.io/) - Para mostrar alertas, ventanas de confirmacion.

## Comentarios 馃搶
* Las validaciones de campos estan hechas en el API, del lado de frontend no agregue validacion de campos, esto para hacerlo unicamente en backend usando la libreria de fluent validation

## Expresiones de Gratitud 馃巵

* Gracias por la oportunidad, desde el tiempo de la entrevista 馃摙
* Mis mejores deseos 馃嵑, 鈽? al equipo.
* Quedo a sus ordenes para esta ocasion y futuras 馃.

---
鈱笍 por [DIRAHETA](https://github.com/driraheta) (uno que uso en ocasiones) 馃槉
