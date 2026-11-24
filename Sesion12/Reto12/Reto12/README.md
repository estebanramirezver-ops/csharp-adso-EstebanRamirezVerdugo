# Inventario — Sesión 10 (Reto 10)

Aplicación de escritorio (Windows Forms, .NET 10) para gestionar un inventario de productos. El código está organizado en capas: modelos, datos, servicios e interfaz.

## Estructura

```
Reto10/
├── Reto10.slnx
├── Inventario.Modelos/      Producto, StockInsuficienteException
├── Inventario.Datos/        IRepositorioProductos, RepositorioJson
├── Inventario.Servicio/     ServicioInventario (reglas de negocio)
└── Inventario.Escritorio/   Windows Forms: Form1, FormProducto, FormReportes
```

Cada capa solo conoce a las de abajo:

```
Escritorio → Servicio → Datos → Modelos
```

## Requisitos

- Windows
- [.NET 10 SDK](https://dotnet.microsoft.com/download)
- Visual Studio con la carga de trabajo **Desarrollo de escritorio con .NET**

## Ejecución

1. Abre `Reto10.slnx` en Visual Studio.
2. Establece `Inventario.Escritorio` como proyecto de inicio.
3. Presiona **F5**.

Desde la terminal:

```bash
dotnet run --project Inventario.Escritorio
```

## Persistencia

Los productos se guardan en `inventario.json`, que se crea en el directorio de trabajo del programa (con F5, la carpeta `bin/.../net10.0-windows`) al agregar el primer producto. Si el archivo está dañado, se copia a `inventario.json.danado` y se inicia con una lista vacía.

## Funcionalidades

**Ventana principal (`Form1`)**

- Tabla de productos con búsqueda por nombre o código.
- Agregar producto mediante un formulario validado (`FormProducto`).
- Editar con doble clic sobre la fila (el código no se puede cambiar).
- Vender y agregar stock.
- Eliminar con confirmación.

**Reportes (`FormReportes`)**

- Productos más valiosos (precio × stock), con filtro por código/nombre y por precio.
- Productos con stock bajo (menos de 5 unidades).
- Producto más caro del inventario.

## Reglas de negocio

- Código y nombre obligatorios; el código se guarda en mayúsculas y no puede repetirse.
- El precio debe ser mayor que 0 y el stock no puede ser negativo.
- No se puede vender más unidades de las que hay en stock (`StockInsuficienteException`).
