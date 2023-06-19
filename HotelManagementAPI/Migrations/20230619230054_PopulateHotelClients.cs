using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HotelManagementAPI.Migrations
{
    public partial class PopulateHotelClients : Migration
    {
        protected override void Up(MigrationBuilder mb)
        {
            mb.Sql("Insert into Clients(Name, PhoneNumber, RoomId) Values('Teobaldo', '999999', '3')");
        }

        protected override void Down(MigrationBuilder mb)
        {
            mb.Sql("Delete from Clients");
        }
    }
}
