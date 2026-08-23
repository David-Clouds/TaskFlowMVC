#  TaskFlow MVC

Aplicación web para la gestión de tareas desarrollada con **C#**, **ASP.NET Core MVC** y **.NET 10**.

Este proyecto fue desarrollado como una práctica integral de desarrollo web y control de versiones, incluyendo **Git, GitHub, creación de ramas, integración de cambios mediante Pull Request, OpenCode como agente de desarrollo, Docker y publicación en Render**.

---

##  Aplicación publicada

**Render:**
https://taskflowmvc.onrender.com/

> La url de render 

---

## 📌 Descripción del proyecto

**TaskFlow MVC** es una aplicación web que permite organizar y administrar tareas personales desde una interfaz moderna y responsive.

La aplicación permite:

* Crear tareas.
* Visualizar tareas.
* Definir prioridades.
* Filtrar tareas por prioridad.
* Marcar tareas como completadas.
* Reabrir tareas completadas.
* Eliminar tareas.
* Visualizar estadísticas básicas.
* Ejecutarse localmente con .NET.
* Desplegarse mediante Docker en Render.

---

## 🛠️ Tecnologías utilizadas

* C#
* .NET 
* ASP.NET Core MVC
* Razor
* HTML5
* CSS3
* JavaScript
* Git
* GitHub
* OpenCode
* Docker
* Render

---

#  Arquitectura MVC

El proyecto utiliza el patrón de arquitectura **Model-View-Controller (MVC)**.

### Model

Los modelos representan la información utilizada por la aplicación.

Archivo principal:

```text
Models/TaskItem.cs
```

El modelo `TaskItem` contiene información como:

* Id
* Título
* Descripción
* Prioridad
* Estado de la tarea
* Fecha de creación

---

### View

Las vistas están ubicadas en:

```text
Views/
```

Principales vistas:

```text
Views/Home/Index.cshtml
Views/Tasks/Index.cshtml
Views/Tasks/Create.cshtml
Views/Shared/_Layout.cshtml
```

Estas vistas se encargan de mostrar la interfaz gráfica de la aplicación.

---

### Controller

El controlador principal de tareas es:

```text
Controllers/TasksController.cs
```

Se encarga de:

* Mostrar tareas.
* Crear tareas.
* Completar tareas.
* Reabrir tareas.
* Eliminar tareas.
* Filtrar tareas por prioridad.

---

# 📁 Estructura del proyecto

```text
TaskFlowMVC/
│
├── Controllers/
│   ├── HomeController.cs
│   └── TasksController.cs
│
├── Models/
│   ├── ErrorViewModel.cs
│   └── TaskItem.cs
│
├── Views/
│   ├── Home/
│   │   └── Index.cshtml
│   │
│   ├── Tasks/
│   │   ├── Index.cshtml
│   │   └── Create.cshtml
│   │
│   ├── Shared/
│   │   ├── _Layout.cshtml
│   │   ├── _ValidationScriptsPartial.cshtml
│   │   └── Error.cshtml
│   │
│   ├── _ViewImports.cshtml
│   └── _ViewStart.cshtml
│
├── wwwroot/
│   ├── css/
│   │   └── site.css
│   │
│   └── js/
│       └── site.js
│
├── Properties/
│   └── launchSettings.json
│
├── .dockerignore
├── .gitignore
├── AGENTS.md
├── Dockerfile
├── Program.cs
├── TaskFlowMVC.csproj
├── README.md
├── appsettings.json
└── appsettings.Development.json
```

---

# 💻 Instalación y ejecución local

## Requisitos

Se necesita tener instalado:

* .NET SDK 10
* Git

Para comprobar la versión de .NET:

```bash
dotnet --version
```

Ejemplo:

```text
10.0.103
```

---

## Clonar el repositorio

```bash
git clone https://github.com/David-Clouds/TaskFlowMVC.git
```

Entrar al proyecto:

```bash
cd TaskFlowMVC
```

---

## Restaurar dependencias

```bash
dotnet restore
```

---

## Compilar

```bash
dotnet build
```

---

## Ejecutar

```bash
dotnet run
```

Después abrir la dirección que indique ASP.NET Core, por ejemplo:

```text
https://localhost:xxxx
```

---

# 🔀 Uso de Git

El proyecto utiliza Git para controlar las diferentes versiones del código.

## Inicializar Git

```bash
git init
```

## Revisar el estado

```bash
git status
```

## Agregar archivos

```bash
git add .
```

## Crear un commit

```bash
git commit -m "feat: crear proyecto TaskFlow MVC con .NET 10"
```

## Consultar el historial

```bash
git log --oneline
```

---

# ☁️ Uso de GitHub

El proyecto fue publicado en GitHub:
**Repositorio:**

https://github.com/David-Clouds/TaskFlowMVC

Para conectar el repositorio local:

```bash
git remote add origin https://github.com/David-Clouds/TaskFlowMVC.git
```

Comprobar el repositorio remoto:

```bash
git remote -v
```

Cambiar la rama principal a `main`:

```bash
git branch -M main
```

Subir los cambios:

```bash
git push -u origin main
```

---

# 🌿 Creación de una rama

Para desarrollar una nueva funcionalidad se creó la rama:

```bash
git checkout -b feature/task-management
```

La rama fue utilizada para desarrollar nuevas funcionalidades sin modificar inicialmente la rama principal.

Comprobar las ramas existentes:

```bash
git branch
```

Publicar la rama:

```bash
git push -u origin feature/task-management
```

---

# 🤖 Uso de OpenCode

Se utilizó **OpenCode como agente de desarrollo** para implementar una nueva funcionalidad dentro del proyecto existente.

La funcionalidad desarrollada con ayuda del agente fue:

### Filtro de tareas por prioridad

El usuario puede seleccionar:

* Todas
* Alta
* Media
* Baja

El agente analizó la arquitectura MVC existente y realizó los cambios necesarios manteniendo la estructura del proyecto.

También se generó el archivo:

```text
AGENTS.md
```

para proporcionar contexto e instrucciones al agente sobre el proyecto.

Después de realizar los cambios se verificó el proyecto mediante:

```bash
dotnet build
```

---

# 🔀 Pull Request y Merge

Una vez terminada la funcionalidad en:

```text
feature/task-management
```

se publicó la rama en GitHub.

Después se creó un **Pull Request** desde:

```text
feature/task-management
```

hacia:

```text
main
```

El Pull Request permitió revisar los cambios antes de integrarlos en la rama principal.

Finalmente se realizó:

```text
feature/task-management
          ↓
     Pull Request
          ↓
         main
```

Y posteriormente se actualizó la rama local:

```bash
git checkout main
```

```bash
git pull origin main
```

---

# 🐳 Docker

El proyecto contiene un archivo:

```text
Dockerfile
```

Este archivo permite construir la aplicación utilizando imágenes oficiales de .NET 10.

El Dockerfile utiliza:

```text
.NET SDK 10
```

para compilar el proyecto y:

```text
ASP.NET Core Runtime 10
```

para ejecutar la aplicación.

La aplicación escucha en:

```text
0.0.0.0:10000
```

También se incluye:

```text
.dockerignore
```

para evitar copiar archivos innecesarios al contexto de Docker.

---

# 🚀 Publicación en Render

La aplicación fue desplegada utilizando **Render**.

Proceso utilizado:

```text
GitHub
   ↓
Repositorio TaskFlowMVC
   ↓
Render Web Service
   ↓
Docker
   ↓
Dockerfile
   ↓
.NET 10
   ↓
Aplicación publicada
```

Render utiliza el `Dockerfile` ubicado en la raíz del repositorio para construir la aplicación.

### Plataforma

**Render**

### Tipo de servicio

**Web Service**

### Entorno

**Docker**

### Rama desplegada

```text
main
```

### URL

https://TU-URL-DE-RENDER.onrender.com

> Reemplazar por la URL real proporcionada por Render.

---

# 🎨 Diseño

La interfaz fue personalizada completamente para evitar utilizar únicamente el diseño predeterminado de ASP.NET Core MVC.

El diseño incluye:

* Tema oscuro.
* Gradientes.
* Tarjetas modernas.
* Panel de estadísticas.
* Animaciones.
* Diseño responsive.
* Sistema visual para prioridades.
* Interfaz adaptada para dispositivos móviles.

---

# ✅ Requisitos de la actividad

| Requisito                         | Estado       |
| --------------------------------- | ------------ |
| Uso de Git                        | ✅ Completado |
| Uso de GitHub                     | ✅ Completado |
| Creación de una rama              | ✅ Completado |
| Unión de rama contra main         | ✅ Completado |
| Primer código con agente OpenCode | ✅ Completado |
| Uso de Docker                     | ✅ Completado |
| Publicación en Render             | ✅ Completado |

---

# 👨‍💻 Autor

**David-Clouds**

Proyecto académico desarrollado con:

```text
C#
ASP.NET Core MVC
.NET 10
Git
GitHub
OpenCode
Docker
Render
```

---

# 📄 Licencia

Proyecto desarrollado con fines académicos y educativos.
