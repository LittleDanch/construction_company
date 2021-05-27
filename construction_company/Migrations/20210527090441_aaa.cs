using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace construction_company.Migrations
{
    public partial class aaa : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Orders",
                columns: table => new
                {
                    ID = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StartData = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EndData = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CompletionMark = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AboutPayment = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Price = table.Column<int>(type: "int", nullable: false),
                    CustomersID = table.Column<long>(type: "bigint", nullable: true),
                    TypesOfWorkID = table.Column<long>(type: "bigint", nullable: true),
                    BrigadesID = table.Column<long>(type: "bigint", nullable: true),
                    StaffID = table.Column<long>(type: "bigint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Orders", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Brigades",
                columns: table => new
                {
                    ID = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Staff1ID = table.Column<long>(type: "bigint", nullable: true),
                    Staff2ID = table.Column<long>(type: "bigint", nullable: true),
                    Staff3ID = table.Column<long>(type: "bigint", nullable: true),
                    OrdersID = table.Column<long>(type: "bigint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Brigades", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Brigades_Orders_OrdersID",
                        column: x => x.OrdersID,
                        principalTable: "Orders",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Customers",
                columns: table => new
                {
                    ID = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FullName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Age = table.Column<int>(type: "int", nullable: false),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Phone = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PassportData = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OrdersID = table.Column<long>(type: "bigint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customers", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Customers_Orders_OrdersID",
                        column: x => x.OrdersID,
                        principalTable: "Orders",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "TypesOfWork",
                columns: table => new
                {
                    ID = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Price = table.Column<int>(type: "int", nullable: false),
                    Material1ID = table.Column<long>(type: "bigint", nullable: true),
                    Material2ID = table.Column<long>(type: "bigint", nullable: true),
                    Material3ID = table.Column<long>(type: "bigint", nullable: true),
                    OrdersID = table.Column<long>(type: "bigint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TypesOfWork", x => x.ID);
                    table.ForeignKey(
                        name: "FK_TypesOfWork_Orders_OrdersID",
                        column: x => x.OrdersID,
                        principalTable: "Orders",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Staff",
                columns: table => new
                {
                    ID = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FullName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Age = table.Column<int>(type: "int", nullable: false),
                    Gender = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Phone = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PassportData = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    positionID = table.Column<long>(type: "bigint", nullable: true),
                    BrigadesID = table.Column<long>(type: "bigint", nullable: true),
                    BrigadesID1 = table.Column<long>(type: "bigint", nullable: true),
                    BrigadesID2 = table.Column<long>(type: "bigint", nullable: true),
                    OrdersID = table.Column<long>(type: "bigint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Staff", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Staff_Brigades_BrigadesID",
                        column: x => x.BrigadesID,
                        principalTable: "Brigades",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Staff_Brigades_BrigadesID1",
                        column: x => x.BrigadesID1,
                        principalTable: "Brigades",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Staff_Brigades_BrigadesID2",
                        column: x => x.BrigadesID2,
                        principalTable: "Brigades",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Staff_Orders_OrdersID",
                        column: x => x.OrdersID,
                        principalTable: "Orders",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Material",
                columns: table => new
                {
                    ID = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Packaging = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Price = table.Column<int>(type: "int", nullable: false),
                    TypesOfWorkID = table.Column<long>(type: "bigint", nullable: true),
                    TypesOfWorkID1 = table.Column<long>(type: "bigint", nullable: true),
                    TypesOfWorkID2 = table.Column<long>(type: "bigint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Material", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Material_TypesOfWork_TypesOfWorkID",
                        column: x => x.TypesOfWorkID,
                        principalTable: "TypesOfWork",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Material_TypesOfWork_TypesOfWorkID1",
                        column: x => x.TypesOfWorkID1,
                        principalTable: "TypesOfWork",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Material_TypesOfWork_TypesOfWorkID2",
                        column: x => x.TypesOfWorkID2,
                        principalTable: "TypesOfWork",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "position",
                columns: table => new
                {
                    ID = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name_Position = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Salary = table.Column<int>(type: "int", nullable: false),
                    Responsibilities = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Requirements = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    StaffID = table.Column<long>(type: "bigint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_position", x => x.ID);
                    table.ForeignKey(
                        name: "FK_position_Staff_StaffID",
                        column: x => x.StaffID,
                        principalTable: "Staff",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Brigades_OrdersID",
                table: "Brigades",
                column: "OrdersID");

            migrationBuilder.CreateIndex(
                name: "IX_Customers_OrdersID",
                table: "Customers",
                column: "OrdersID");

            migrationBuilder.CreateIndex(
                name: "IX_Material_TypesOfWorkID",
                table: "Material",
                column: "TypesOfWorkID");

            migrationBuilder.CreateIndex(
                name: "IX_Material_TypesOfWorkID1",
                table: "Material",
                column: "TypesOfWorkID1");

            migrationBuilder.CreateIndex(
                name: "IX_Material_TypesOfWorkID2",
                table: "Material",
                column: "TypesOfWorkID2");

            migrationBuilder.CreateIndex(
                name: "IX_position_StaffID",
                table: "position",
                column: "StaffID");

            migrationBuilder.CreateIndex(
                name: "IX_Staff_BrigadesID",
                table: "Staff",
                column: "BrigadesID");

            migrationBuilder.CreateIndex(
                name: "IX_Staff_BrigadesID1",
                table: "Staff",
                column: "BrigadesID1");

            migrationBuilder.CreateIndex(
                name: "IX_Staff_BrigadesID2",
                table: "Staff",
                column: "BrigadesID2");

            migrationBuilder.CreateIndex(
                name: "IX_Staff_OrdersID",
                table: "Staff",
                column: "OrdersID");

            migrationBuilder.CreateIndex(
                name: "IX_TypesOfWork_OrdersID",
                table: "TypesOfWork",
                column: "OrdersID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Customers");

            migrationBuilder.DropTable(
                name: "Material");

            migrationBuilder.DropTable(
                name: "position");

            migrationBuilder.DropTable(
                name: "TypesOfWork");

            migrationBuilder.DropTable(
                name: "Staff");

            migrationBuilder.DropTable(
                name: "Brigades");

            migrationBuilder.DropTable(
                name: "Orders");
        }
    }
}
