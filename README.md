# 📚 Library Management System  
# 📚 Sistema de Gestión de Biblioteca

Desktop application built with **C# and .NET Framework** to manage a library with **user roles, loans, categories, authors and reports**.

Aplicación de escritorio desarrollada en **C# y .NET Framework** para gestionar una biblioteca con **roles de usuario, préstamos, categorías, autores y reportes**.

---

## 🧩 Main Features / Funcionalidades

### 🔐 Authentication / Autenticación
The system includes a login with two user roles:
- **Administrator**
- **Member (Socio)**

El sistema incluye un login con dos tipos de usuarios:
- **Administrador**
- **Socio**
## 📸 Screenshots

### 🔐 Login
![Login](Screenshots/1.Login.png)
---

### 👨‍💼 Administrator / Administrador

Administrators have full access to the system:

Administradores pueden:

- **Dashboard / Principal**
- **Loans / Préstamos**
  - Create loans for one or more books  
  - Assign books to members  
  - View loan details  
  - Return borrowed books  

  - Registrar préstamos de uno o más libros  
  - Asignar libros a socios  
  - Ver el detalle del préstamo  
  - Devolver libros  

- **Categories / Categorías**
  - Create, edit and delete categories  
  - Crear, editar y eliminar categorías  

- **Books / Libros**
  - Register books  
  - Assign author and category  
  - Edit and delete books  

  - Registrar libros  
  - Asignar autor y categoría  
  - Editar y eliminar libros  

- **Users / Usuarios**
  - Manage administrators and members  
  - Gestionar usuarios administradores y socios  

- **Authors / Autores**
  - Create, edit and delete authors  
  - Crear, editar y eliminar autores  

---

### 👤 Member (Socio)

Members can:

- View their own loans  
- See loan details  
- Print loan tickets  

Los socios pueden:
- Ver sus préstamos  
- Consultar detalles  
- Imprimir comprobantes  

---

## 🛠 Technologies / Tecnologías

- C#  
- .NET Framework  
- Windows Forms  
- SQL Server  
- Visual Studio  

---

## 🗂 Architecture / Arquitectura

The system uses a layered architecture:

El sistema utiliza una arquitectura en capas:

- Presentation Layer / Interfaz (Windows Forms)  
- Business Logic Layer / Lógica de negocio  
- Data Access Layer / Acceso a datos (SQL Server)  

---

## 🚀 How to Run / Cómo ejecutar

1. Open the solution in Visual Studio  
2. Restore the database  
3. Configure the connection string  
4. Run the project  

1. Abrir la solución en Visual Studio  
2. Restaurar la base de datos  
3. Configurar la cadena de conexión  
4. Ejecutar el proyecto  

---

## 🎯 Purpose / Objetivo

This project was developed as part of a university course to practice real-world application development using object-oriented programming and databases.

Este proyecto fue desarrollado como parte de una materia universitaria para practicar programación orientada a objetos y aplicaciones con base de datos.
