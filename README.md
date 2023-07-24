
# testeo backend incidencias campuslands

en este testeo se uso la version de de net 7.0.0 con el entity framework


## Dependencias Entity Framework



```
 dotnet add package Pomelo.EntityFrameworkCore.MySql --version 7.0.0
 ```
 ```
  dotnet add package Microsoft.EntityFrameworkCore --version 8.0.0-preview.6.23329.4
 ```
```
  dotnet add package AutoMapper --version 12.0.1
```

| categoria  | Type     | Description                |
| :-------- | :-------  | :------------------------- |
| `database`|`extension`| **Requerido**. para conectar con base de datos |
|`AutoMapper`|`extension`| **Requerido**. para mapear consultar a la web api |
|`EntityFrameworkCore`|`extension`| **Requerido**. para generar esquema de entidades y estructura del testeo  |




#### el proyecto requiere ejecucion de 2 comandos para visualizar en base de datos.



## inicializar testeo


Creacion de migraciones dentro de la carpeta /Data/

```
dotnet ef migrations add InitialCreate --project ./Infrastructure --startup-project ./API --output-dir ./DataMigrations
```

Actualizacion y migracion a base de datos. asegurarse de que el servidor y credenciales sean acordes

```
dotnet ef database update --project ./Infrastructure --startup-project ./API
```



## Support

For support, email angelgabrielorteg@gmail.com or join to campus lands channel on discord.


## Autor

- [@Angel-ISO](https://www.github.com/octokatherine)


