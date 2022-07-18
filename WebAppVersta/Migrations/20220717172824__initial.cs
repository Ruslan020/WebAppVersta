using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace WebAppVersta.Migrations
{
    public partial class _initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Orders",
                columns: table => new
                {
                    id = table.Column<Guid>(nullable: false),
                    senderTown = table.Column<string>(nullable: true),
                    senderAddress = table.Column<string>(nullable: true),
                    recieverTown = table.Column<string>(nullable: true),
                    recieverAddress = table.Column<string>(nullable: true),
                    weight = table.Column<string>(nullable: true),
                    date = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Orders", x => x.id);
                });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "id", "date", "recieverAddress", "recieverTown", "senderAddress", "senderTown", "weight" },
                values: new object[] { new Guid("63dc8fa6-07ae-4391-8916-e057f71239ce"), new DateTime(2022, 7, 17, 20, 28, 23, 697, DateTimeKind.Local).AddTicks(9743), "Новоизмайл", "Санкт-Петербург", "Тельман", "Абакан", "75" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Orders");
        }
    }
}
