# VehicleLease

**Version**: 1.0.0  
**Release Date**: 2025-07-14

## Overview

This is the initial release of the Vehicle Leasing System, developed using ASP.NET MVC 5 (.NET Framework 4.7.2) and Entity Framework Code First. The system allows a vehicle leasing company to manage which vehicles are leased, who the clients are, and how vehicles are distributed across branches.

## Features

### Branch Management
- Add, edit, delete, and view branch locations
- Includes optional region filter

### Client Management
- Manage client companies leasing vehicles

### Supplier Management
- Manage vehicle supplier records

### Driver Management
- Track drivers assigned to leased vehicles

### Vehicle Management
- Add new vehicles and assign them to branches, suppliers, clients, and drivers
- Live search and status filtering (Available or Leased)
- Visual leasing status with color-coded badges

### Dashboard Reporting
- Summary of vehicle allocations by branch, supplier, and client

## Technologies Used

- ASP.NET MVC 5 (.NET Framework 4.7.2)
- Entity Framework 6
- SQL Server Express
- Bootstrap and Font Awesome
- jQuery and JavaScript

## Database

- Code First Migrations used to create and seed the database
- Seed data includes:
  - 10 sample branches (across all major provinces)
  - Multiple suppliers, clients, and drivers
  - Sample vehicles linked to all entities
- Safe re-seeding via `AddOrUpdate()` to avoid duplication

## Installation Instructions

1. Ensure SQL Server Express or LocalDB is installed and running
2. Clone this repository to your local machine
3. Open the solution in Visual Studio
4. Update the connection string in `Web.config` if needed
5. Run `Update-Database` in Package Manager Console
6. Build and run the application

## Project Structure

- `/Models/Domain/` – Entity classes
- `/Models/DbContext/` – EF `ApplicationDbContext`
- `/Controllers/` – MVC Controllers
- `/Views/` – Razor views
- `/Migrations/` – EF Migrations and Seed method
- `README.md` – Project overview and release notes

## Author

Developed by Kwanele Duma as part of the Rosond Developer Test.

