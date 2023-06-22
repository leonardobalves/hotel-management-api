# HotelManagementAPI

Hotel booking API to manage hotel rooms and clients.

# Goal

The goal was to further increase my knowledge in ASP.NET Core Web API, Entity Framework, setting up a connection to a database and develop a CRUD to manipulate data.

# Learnings

* API Development
* HTTP requests
* EF Core Migrations
* Data Annotations
* Serialization and Deserialization

# API Routes

Booking list
- **@GET** 'https://localhost:7173/bookings'

Search booking by ID
- **@GET** 'https://localhost:7173/bookings/{id}'

Booking list with clients
- **@GET** 'https://localhost:7173/bookings/clients'

Add booking
- **@POST** 'https://localhost:7173/bookings' raw JSON: { "roomNumber": "100", "vacant": true, "clients": [] }

Modify booking
- **@PUT** 'https://localhost:7173/bookings/{id}' raw JSON: { "roomId": 5, "roomNumber": 500, "vacant": true, "clients": [] }

Delete booking
- **@DELETE** 'https://localhost:7173/bookings/{id}'

Clients list
- **@GET** 'https://localhost:7173/clients'

Search clients by ID
- **@GET** 'https://localhost:7173/clients/{id}'

Add clients
- **@POST** 'https://localhost:7173/clients' raw JSON: { "name": "Leonardo", "phoneNumber": "11111111" }

Modify client
- **@PUT** 'https://localhost:7173/clients/{id}' raw JSON: { "clientId": 3, "name": "Leonardo", "phoneNumber": "33333333", "roomId": 3 }

Delete booking
- **@DELETE** 'https://localhost:7173/clients/{id}'


# How to run the project

Clone the repository with `git clone https://github.com/leonardobuckalves/hotel-management-api.git`

Open the project in Visual Studio 2022.

Set up the connection string to connect to your local MySQL database.

Inside inside command prompt (cmd/PowerShell), navigate to the project folder, run dotnet ef database update.

In Visual Studio press F5, or press Ctrl+F5 to start without debugging.

# Author

[Leonardo Buck Alves](https://www.linkedin.com/in/leonardobuckalves/)
