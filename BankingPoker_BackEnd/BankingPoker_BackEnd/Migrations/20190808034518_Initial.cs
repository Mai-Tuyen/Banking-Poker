using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace BankingPoker_BackEnd.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Player",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Name = table.Column<string>(maxLength: 200, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Player", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "BuyInDetail",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    PlayerId = table.Column<Guid>(nullable: false),
                    NumberAdd = table.Column<int>(nullable: false),
                    TimeAdd = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BuyInDetail", x => x.Id);
                    table.ForeignKey(
                        name: "FK_BuyInDetail_Player_PlayerId",
                        column: x => x.PlayerId,
                        principalTable: "Player",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Sumary",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    PlayerId = table.Column<Guid>(nullable: false),
                    SumAdd = table.Column<int>(nullable: false),
                    SumCutOut = table.Column<int>(nullable: false),
                    Profit = table.Column<int>(nullable: false),
                    Date = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sumary", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Sumary_Player_PlayerId",
                        column: x => x.PlayerId,
                        principalTable: "Player",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_BuyInDetail_PlayerId",
                table: "BuyInDetail",
                column: "PlayerId");

            migrationBuilder.CreateIndex(
                name: "IX_Sumary_PlayerId",
                table: "Sumary",
                column: "PlayerId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BuyInDetail");

            migrationBuilder.DropTable(
                name: "Sumary");

            migrationBuilder.DropTable(
                name: "Player");
        }
    }
}
