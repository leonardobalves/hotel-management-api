using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HotelManagementAPI.Migrations
{
    public partial class PopulateHotelWithRooms : Migration
    {
        protected override void Up(MigrationBuilder mb)
        {
            mb.Sql("Insert into Rooms(RoomNumber, Vacant) Values('101', '0')");
            mb.Sql("Insert into Rooms(RoomNumber, Vacant) Values('102', '0')");
            mb.Sql("Insert into Rooms(RoomNumber, Vacant) Values('103', '1')");
        }

        protected override void Down(MigrationBuilder mb)
        {
            mb.Sql("Delete from Rooms");
        }
    }
}
