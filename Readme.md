# Venta-Entradas

Aplicación de escritorio (Windows Forms) para la compra y gestión de entradas de eventos, con soporte para usuarios normales y administradores.

---

## Tecnologías

- .NET 8 (Windows Forms)
- Entity Framework (DbContext en `DAL\Models\AppDbContext.cs`)
- SQL Server (por ejemplo, SQL Express)
- Patrón por capas: UI / BLL / DAL

---

## Requisitos

- Windows con **.NET 8 Runtime** instalado.
- Instancia de **SQL Server** accesible (local o remota).
- (Opcional) **Visual Studio 2022** para ejecutar, depurar y modificar el proyecto.

---

## Configuración de la base de datos

1. Crear una base de datos en SQL Server (por ejemplo: `VentaEntradasDb`).
2. Revisar la cadena de conexión en `Venta-Entradas\App.config`:
   - Sección: `connectionStrings`
   - Clave: `ConnectionString`
   - Actualizar al menos:
     - `Data Source=` (servidor/instancia)
     - `Initial Catalog=` (nombre de la BD creada)
   - Ejemplo (adaptar a tu entorno):

     ```xml
     <connectionStrings>
       <add name="ConnectionString"
            connectionString="Data Source=.\SQLEXPRESS;Initial Catalog=VentaEntradasDb;Integrated Security=True" />
     </connectionStrings>
     ```

3. Asegurarse de que la base de datos tenga las tablas esperadas:
   - Si el proyecto incluye migraciones de Entity Framework:
     - Ejecutar las migraciones contra la BD configurada.
   - Si no hay migraciones:
     - Crear la estructura de tablas manualmente según los modelos en `DAL\Models\`.

---

## Instalación y ejecución (Visual Studio)

1. Abrir la solución en **Visual Studio 2022**.
2. Revisar y actualizar la cadena de conexión en `Venta-Entradas\App.config` según tu servidor SQL.
3. Confirmar que la BD (`Initial Catalog`) existe y es accesible.
4. Compilar la solución:
   - Menú: **Build > Build Solution**.
5. Ejecutar la aplicación:
   - **F5** (con depuración) o
   - **Ctrl+F5** (sin depuración).

---

## Flujo de uso (usuario final)

### 1. Registro

- Abrir la pantalla de registro desde la interfaz principal.
- Completar los campos:
  - Nombre
  - Apellido
  - DNI
  - Usuario
  - Contraseña
- Cada campo debe cumplir las validaciones mínimas definidas en la lógica de negocio.

### 2. Inicio de sesión

- Ingresar **Usuario** y **Contraseña**.
- Si las credenciales son válidas:
  - Se inicia sesión y se almacena el estado en `Utils\SesionManageUtil.cs`.

### 3. Navegar eventos

- Abrir el módulo de eventos: `UcRecitales`.
- Consultar la lista de eventos disponibles.
- Añadir entradas al carrito.

### 4. Carrito y pago

- El carrito se mantiene en `SesionManageUtil.Carrito`.
- Al confirmar la compra:
  - Se crea una **factura temporal**.
  - Se generan los **tickets** correspondientes.
  - La lógica está en:
    - `BLL\FacturaBusiness.cs`
    - `BLL\TicketBusiness.cs`
  - El método de pago seleccionado se guarda en la factura.

### 5. Mis entradas

- Abrir `UcMisEntradas`.
- Consultar:
  - Tickets propios.
  - Facturas asociadas.
- Desde aquí se puede:
  - Enviar un ticket a otro usuario (validaciones en `BLL\TicketBusiness.cs`).

### 6. Cierre de sesión

- Seleccionar la opción de cerrar sesión.
- Se utiliza `SesionManageUtil.CerrarSesion()` para limpiar la sesión.

---

## Rol administrador

- El acceso al módulo administrador (`UcAdmin`) se habilita cuando:
  - `SesionManageUtil.EsAdmin()` devuelve `true`.
- Funcionalidades:
  - Gestión de eventos:
    - Crear, editar, eliminar eventos.
  - Visualización de ventas y facturación.
- Lógica principal:
  - `BLL\EventoBusiness.cs`
  - `BLL\FacturaBusiness.cs`

---

## Estructura principal del proyecto

- `Venta-Entradas\Form1.cs`, `Form2.cs`  
  Formularios principales de la aplicación.

- `Venta-Entradas\UcRecitales.cs`  
  Listado de eventos y agregado al carrito.

- `Venta-Entradas\UcMisEntradas.cs`  
  Consulta de tickets y facturas, envío de tickets a otros usuarios.

- `Venta-Entradas\UcAdmin.cs`  
  Módulo de administración (eventos, ventas).

- `BLL\UsuarioBusiness.cs`  
  Lógica de negocio para usuarios.

- `BLL\EventoBusiness.cs`  
  Lógica de negocio para eventos.

- `BLL\TicketBusiness.cs`  
  Lógica de negocio para tickets (generación, envío, validaciones).

- `BLL\FacturaBusiness.cs`  
  Lógica de negocio para facturas.

- `DAL\UsuarioData.cs`, `DAL\TicketData.cs`, `DAL\FacturaData.cs`, etc.  
  Acceso a datos hacia SQL Server.

- `DAL\Models\AppDbContext.cs`  
  Configuración de Entity Framework (DbContext y modelos).

- `Utils\SesionManageUtil.cs`  
  Manejo de sesión, roles, carrito.

- `Utils\NavbarUtil.cs`  
  Utilidades de navegación dentro de la UI.

- `Venta-Entradas\App.config`  
  Cadena de conexión y configuración de la aplicación.

---

## Errores comunes y solución

- **Error de conexión a la BD**
  - Verificar:
    - Cadena de conexión en `App.config`.
    - Que el servidor SQL esté levantado.
    - Credenciales y permisos de acceso.

- **Usuario no encontrado / contraseña inválida**
  - Confirmar que el usuario esté registrado.
  - Verificar que la contraseña no haya sido cambiada.

- **No hay entradas disponibles**
  - El sistema valida el stock.
  - Se lanza una excepción cuando `Cantidad < 1`.
  - Revisar la configuración de stock del evento.

- **Excepciones en operaciones transaccionales**
  - Revisar:
    - Ventana **Output** de Visual Studio.
    - Ventana de **Error List**.
  - Analizar trace y mensajes arrojados por la capa BLL/DAL.

---

## Pruebas recomendadas

- Crear usuarios de prueba:
  - Uno con rol **admin**.
  - Uno o más con rol **usuario normal**.
- Probar casos límite:
  - Compra cuando el stock del evento es 1.
  - Envío de tickets entre usuarios.
  - Intentar realizar acciones de administración con un usuario sin permisos.
- Utilizar la salida de Visual Studio:
  - Ventana **Output** para revisar excepciones y mensajes de depuración.

---

## Cómo reportar problemas

Al reportar un problema sobre la aplicación, incluir:

1. Pasos exactos para reproducir el error.
2. Mensaje de error completo (texto) tal como aparece en pantalla o en el log.
3. Información de entorno:
   - Versión de .NET instalada.
   - Tipo de base de datos:
     - Local (ej. `.\SQLEXPRESS`)
     - Remota (servidor en red).
4. (Opcional) Fragmento de la cadena de conexión usada (sin credenciales sensibles si aplica).

---
