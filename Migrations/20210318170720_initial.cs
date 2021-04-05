using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SHT_WIMS02.Migrations
{
    public partial class initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CatalogItems",
                columns: table => new
                {
                    ItemId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Category = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UoM = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CatalogItems", x => x.ItemId);
                });

            migrationBuilder.CreateTable(
                name: "CountHdrs",
                columns: table => new
                {
                    CountHdrId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LocationId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CountDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CountBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Comment = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CountHdrs", x => x.CountHdrId);
                });

            migrationBuilder.CreateTable(
                name: "Counties",
                columns: table => new
                {
                    CntyFIPS = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    CntyName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Territory = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Seat = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SeatLat = table.Column<double>(type: "float", nullable: false),
                    SeatLon = table.Column<double>(type: "float", nullable: false),
                    Area = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Counties", x => x.CntyFIPS);
                });

            migrationBuilder.CreateTable(
                name: "Locations",
                columns: table => new
                {
                    LocationId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    LocationName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LocationCounty = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Type = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Affiliation = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneMain = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Address1 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Address2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    City = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    State = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PostalCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Climate = table.Column<bool>(type: "bit", nullable: false),
                    Secure = table.Column<bool>(type: "bit", nullable: false),
                    Agreement = table.Column<bool>(type: "bit", nullable: false),
                    Area = table.Column<int>(type: "int", nullable: false),
                    Lat = table.Column<double>(type: "float", nullable: false),
                    Lon = table.Column<double>(type: "float", nullable: false),
                    Elev = table.Column<int>(type: "int", nullable: false),
                    Comment = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Locations", x => x.LocationId);
                });

            migrationBuilder.CreateTable(
                name: "PullHdrs",
                columns: table => new
                {
                    PullHdrId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Status = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LocationId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PullDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Destination = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Requester = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ReqPhone = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ReqEmail = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Comment = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PullHdrs", x => x.PullHdrId);
                });

            migrationBuilder.CreateTable(
                name: "ReceiveHdrs",
                columns: table => new
                {
                    ReceiveHdrId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LocationId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ReceiveDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Origin = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Receiver = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Comment = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ReceiveHdrs", x => x.ReceiveHdrId);
                });

            migrationBuilder.CreateTable(
                name: "CountItems",
                columns: table => new
                {
                    CountItemId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CountHdrId = table.Column<int>(type: "int", nullable: false),
                    ItemId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UoM = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Qty = table.Column<int>(type: "int", nullable: false),
                    Comment = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CountItems", x => x.CountItemId);
                    table.ForeignKey(
                        name: "FK_CountItems_CountHdrs_CountHdrId",
                        column: x => x.CountHdrId,
                        principalTable: "CountHdrs",
                        principalColumn: "CountHdrId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CartLines",
                columns: table => new
                {
                    CartLineId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PullHdrId = table.Column<int>(type: "int", nullable: false),
                    ItemId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UoM = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Qty = table.Column<int>(type: "int", nullable: false),
                    DateNeeded = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Comment = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CartLines", x => x.CartLineId);
                    table.ForeignKey(
                        name: "FK_CartLines_PullHdrs_PullHdrId",
                        column: x => x.PullHdrId,
                        principalTable: "PullHdrs",
                        principalColumn: "PullHdrId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PullItems",
                columns: table => new
                {
                    PullItemId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PullHdrId = table.Column<int>(type: "int", nullable: false),
                    QtyRequested = table.Column<int>(type: "int", nullable: false),
                    QtyShipped = table.Column<int>(type: "int", nullable: false),
                    DateNeeded = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ItemId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UoM = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Qty = table.Column<int>(type: "int", nullable: false),
                    Comment = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PullItems", x => x.PullItemId);
                    table.ForeignKey(
                        name: "FK_PullItems_PullHdrs_PullHdrId",
                        column: x => x.PullHdrId,
                        principalTable: "PullHdrs",
                        principalColumn: "PullHdrId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ReceiveItems",
                columns: table => new
                {
                    ReceiveItemId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ReceiveHdrId = table.Column<int>(type: "int", nullable: false),
                    ItemId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UoM = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Qty = table.Column<int>(type: "int", nullable: false),
                    Comment = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ReceiveItems", x => x.ReceiveItemId);
                    table.ForeignKey(
                        name: "FK_ReceiveItems_ReceiveHdrs_ReceiveHdrId",
                        column: x => x.ReceiveHdrId,
                        principalTable: "ReceiveHdrs",
                        principalColumn: "ReceiveHdrId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_CartLines_PullHdrId",
                table: "CartLines",
                column: "PullHdrId");

            migrationBuilder.CreateIndex(
                name: "IX_CountItems_CountHdrId",
                table: "CountItems",
                column: "CountHdrId");

            migrationBuilder.CreateIndex(
                name: "IX_PullItems_PullHdrId",
                table: "PullItems",
                column: "PullHdrId");

            migrationBuilder.CreateIndex(
                name: "IX_ReceiveItems_ReceiveHdrId",
                table: "ReceiveItems",
                column: "ReceiveHdrId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CartLines");

            migrationBuilder.DropTable(
                name: "CatalogItems");

            migrationBuilder.DropTable(
                name: "Counties");

            migrationBuilder.DropTable(
                name: "CountItems");

            migrationBuilder.DropTable(
                name: "Locations");

            migrationBuilder.DropTable(
                name: "PullItems");

            migrationBuilder.DropTable(
                name: "ReceiveItems");

            migrationBuilder.DropTable(
                name: "CountHdrs");

            migrationBuilder.DropTable(
                name: "PullHdrs");

            migrationBuilder.DropTable(
                name: "ReceiveHdrs");
        }
    }
}
