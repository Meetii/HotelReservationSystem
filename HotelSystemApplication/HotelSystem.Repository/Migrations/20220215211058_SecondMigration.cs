using Microsoft.EntityFrameworkCore.Migrations;

namespace HotelSystem.Repository.Migrations
{
    public partial class SecondMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_HotelInReservationCarts",
                table: "HotelInReservationCarts");

            migrationBuilder.DropPrimaryKey(
                name: "PK_HotelInOrders",
                table: "HotelInOrders");

            migrationBuilder.AddPrimaryKey(
                name: "PK_HotelInReservationCarts",
                table: "HotelInReservationCarts",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_HotelInOrders",
                table: "HotelInOrders",
                column: "Id");

            migrationBuilder.CreateIndex(
                name: "IX_HotelInReservationCarts_HotelId",
                table: "HotelInReservationCarts",
                column: "HotelId");

            migrationBuilder.CreateIndex(
                name: "IX_HotelInOrders_HotelId",
                table: "HotelInOrders",
                column: "HotelId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_HotelInReservationCarts",
                table: "HotelInReservationCarts");

            migrationBuilder.DropIndex(
                name: "IX_HotelInReservationCarts_HotelId",
                table: "HotelInReservationCarts");

            migrationBuilder.DropPrimaryKey(
                name: "PK_HotelInOrders",
                table: "HotelInOrders");

            migrationBuilder.DropIndex(
                name: "IX_HotelInOrders_HotelId",
                table: "HotelInOrders");

            migrationBuilder.AddPrimaryKey(
                name: "PK_HotelInReservationCarts",
                table: "HotelInReservationCarts",
                columns: new[] { "HotelId", "ReservationCartId" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_HotelInOrders",
                table: "HotelInOrders",
                columns: new[] { "HotelId", "OrderId" });
        }
    }
}
