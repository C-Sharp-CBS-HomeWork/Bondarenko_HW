using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Task_1.Migrations
{
    public partial class init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "FirstEntities",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FirstEntities", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "SecondEntities",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SecondEntities", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "ThirdEntities",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ThirdEntities", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "FirstEntitySecondEntity",
                columns: table => new
                {
                    FirstsID = table.Column<int>(type: "int", nullable: false),
                    SecondsID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FirstEntitySecondEntity", x => new { x.FirstsID, x.SecondsID });
                    table.ForeignKey(
                        name: "FK_FirstEntitySecondEntity_FirstEntities_FirstsID",
                        column: x => x.FirstsID,
                        principalTable: "FirstEntities",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_FirstEntitySecondEntity_SecondEntities_SecondsID",
                        column: x => x.SecondsID,
                        principalTable: "SecondEntities",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "FirstEntityThirdEntity",
                columns: table => new
                {
                    FirstsID = table.Column<int>(type: "int", nullable: false),
                    ThirdsID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FirstEntityThirdEntity", x => new { x.FirstsID, x.ThirdsID });
                    table.ForeignKey(
                        name: "FK_FirstEntityThirdEntity_FirstEntities_FirstsID",
                        column: x => x.FirstsID,
                        principalTable: "FirstEntities",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_FirstEntityThirdEntity_ThirdEntities_ThirdsID",
                        column: x => x.ThirdsID,
                        principalTable: "ThirdEntities",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "SecondEntityThirdEntity",
                columns: table => new
                {
                    SecondsID = table.Column<int>(type: "int", nullable: false),
                    ThirdsID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SecondEntityThirdEntity", x => new { x.SecondsID, x.ThirdsID });
                    table.ForeignKey(
                        name: "FK_SecondEntityThirdEntity_SecondEntities_SecondsID",
                        column: x => x.SecondsID,
                        principalTable: "SecondEntities",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SecondEntityThirdEntity_ThirdEntities_ThirdsID",
                        column: x => x.ThirdsID,
                        principalTable: "ThirdEntities",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_FirstEntitySecondEntity_SecondsID",
                table: "FirstEntitySecondEntity",
                column: "SecondsID");

            migrationBuilder.CreateIndex(
                name: "IX_FirstEntityThirdEntity_ThirdsID",
                table: "FirstEntityThirdEntity",
                column: "ThirdsID");

            migrationBuilder.CreateIndex(
                name: "IX_SecondEntityThirdEntity_ThirdsID",
                table: "SecondEntityThirdEntity",
                column: "ThirdsID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "FirstEntitySecondEntity");

            migrationBuilder.DropTable(
                name: "FirstEntityThirdEntity");

            migrationBuilder.DropTable(
                name: "SecondEntityThirdEntity");

            migrationBuilder.DropTable(
                name: "FirstEntities");

            migrationBuilder.DropTable(
                name: "SecondEntities");

            migrationBuilder.DropTable(
                name: "ThirdEntities");
        }
    }
}
