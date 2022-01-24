using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace AppSenaJmoc.Migrations
{
    public partial class Migration01 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Clientes",
                columns: table => new
                {
                    Id_Cliente = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre_Cliente = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Apellidos_Cliente = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    Telefono_Cliente = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email_Cliente = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Ciudad_Cliente = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Clientes", x => x.Id_Cliente);
                });

            migrationBuilder.CreateTable(
                name: "Proveedores",
                columns: table => new
                {
                    Id_Proveedor = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre_Provedor = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Direccion_Proveedor = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Telefono_Proveedor = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Email_Proveedor = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Ciudad_Proveedor = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Proveedores", x => x.Id_Proveedor);
                });

            migrationBuilder.CreateTable(
                name: "Tecnicos",
                columns: table => new
                {
                    Id_Tecnico = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre_Tecnico = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Apellidos_Tecnico = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Telefono_Tecnico = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Email_Tecnico = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Ciudad_Tecnico = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tecnicos", x => x.Id_Tecnico);
                });

            migrationBuilder.CreateTable(
                name: "Equipos",
                columns: table => new
                {
                    Id_Equipo = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Marca_Equipo = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Tipo_Cliente = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Serie_Equipo = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Id_Cliente = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Equipos", x => x.Id_Equipo);
                    table.ForeignKey(
                        name: "FK_Equipos_Clientes_Id_Cliente",
                        column: x => x.Id_Cliente,
                        principalTable: "Clientes",
                        principalColumn: "Id_Cliente",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Materiales1",
                columns: table => new
                {
                    Id_Materiales = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre_Materiales = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Descripcion_materiales = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Precio_Materiales = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Existencias_Materiales = table.Column<int>(type: "int", maxLength: 100, nullable: false),
                    Id_Proveedor = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Materiales1", x => x.Id_Materiales);
                    table.ForeignKey(
                        name: "FK_Materiales1_Proveedores_Id_Proveedor",
                        column: x => x.Id_Proveedor,
                        principalTable: "Proveedores",
                        principalColumn: "Id_Proveedor",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "detalle_Facturas",
                columns: table => new
                {
                    Id_Detalle_factura = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Cantidad_Detalle = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Id_Materiales = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_detalle_Facturas", x => x.Id_Detalle_factura);
                    table.ForeignKey(
                        name: "FK_detalle_Facturas_Materiales1_Id_Materiales",
                        column: x => x.Id_Materiales,
                        principalTable: "Materiales1",
                        principalColumn: "Id_Materiales",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "detalle_Presupuestos",
                columns: table => new
                {
                    Id_detalle_Presupuesto = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Cantidad_detalle_Presupuesto = table.Column<int>(type: "int", nullable: false),
                    Id_Materiales = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_detalle_Presupuestos", x => x.Id_detalle_Presupuesto);
                    table.ForeignKey(
                        name: "FK_detalle_Presupuestos_Materiales1_Id_Materiales",
                        column: x => x.Id_Materiales,
                        principalTable: "Materiales1",
                        principalColumn: "Id_Materiales",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Facturas",
                columns: table => new
                {
                    Id_factura = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Total_pagar_factura = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Id_Equipo = table.Column<int>(type: "int", nullable: false),
                    Id_Tecnico = table.Column<int>(type: "int", nullable: false),
                    Id_Detalle_factura = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Facturas", x => x.Id_factura);
                    table.ForeignKey(
                        name: "FK_Facturas_detalle_Facturas_Id_Detalle_factura",
                        column: x => x.Id_Detalle_factura,
                        principalTable: "detalle_Facturas",
                        principalColumn: "Id_Detalle_factura",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Facturas_Equipos_Id_Equipo",
                        column: x => x.Id_Equipo,
                        principalTable: "Equipos",
                        principalColumn: "Id_Equipo",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Facturas_Tecnicos_Id_Tecnico",
                        column: x => x.Id_Tecnico,
                        principalTable: "Tecnicos",
                        principalColumn: "Id_Tecnico",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Presupuestos",
                columns: table => new
                {
                    Id_Presupuesto = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Total_Pagar_Presupuesto = table.Column<int>(type: "int", maxLength: 100, nullable: false),
                    Hora_Presupuesto = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Fecha_presupuesto = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Id_Equipo = table.Column<int>(type: "int", nullable: false),
                    Id_Tecnico = table.Column<int>(type: "int", nullable: false),
                    Id_detalle_Presupuesto = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Presupuestos", x => x.Id_Presupuesto);
                    table.ForeignKey(
                        name: "FK_Presupuestos_detalle_Presupuestos_Id_detalle_Presupuesto",
                        column: x => x.Id_detalle_Presupuesto,
                        principalTable: "detalle_Presupuestos",
                        principalColumn: "Id_detalle_Presupuesto",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Presupuestos_Equipos_Id_Equipo",
                        column: x => x.Id_Equipo,
                        principalTable: "Equipos",
                        principalColumn: "Id_Equipo",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Presupuestos_Tecnicos_Id_Tecnico",
                        column: x => x.Id_Tecnico,
                        principalTable: "Tecnicos",
                        principalColumn: "Id_Tecnico",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_detalle_Facturas_Id_Materiales",
                table: "detalle_Facturas",
                column: "Id_Materiales");

            migrationBuilder.CreateIndex(
                name: "IX_detalle_Presupuestos_Id_Materiales",
                table: "detalle_Presupuestos",
                column: "Id_Materiales");

            migrationBuilder.CreateIndex(
                name: "IX_Equipos_Id_Cliente",
                table: "Equipos",
                column: "Id_Cliente");

            migrationBuilder.CreateIndex(
                name: "IX_Facturas_Id_Detalle_factura",
                table: "Facturas",
                column: "Id_Detalle_factura");

            migrationBuilder.CreateIndex(
                name: "IX_Facturas_Id_Equipo",
                table: "Facturas",
                column: "Id_Equipo");

            migrationBuilder.CreateIndex(
                name: "IX_Facturas_Id_Tecnico",
                table: "Facturas",
                column: "Id_Tecnico");

            migrationBuilder.CreateIndex(
                name: "IX_Materiales1_Id_Proveedor",
                table: "Materiales1",
                column: "Id_Proveedor");

            migrationBuilder.CreateIndex(
                name: "IX_Presupuestos_Id_detalle_Presupuesto",
                table: "Presupuestos",
                column: "Id_detalle_Presupuesto");

            migrationBuilder.CreateIndex(
                name: "IX_Presupuestos_Id_Equipo",
                table: "Presupuestos",
                column: "Id_Equipo");

            migrationBuilder.CreateIndex(
                name: "IX_Presupuestos_Id_Tecnico",
                table: "Presupuestos",
                column: "Id_Tecnico");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Facturas");

            migrationBuilder.DropTable(
                name: "Presupuestos");

            migrationBuilder.DropTable(
                name: "detalle_Facturas");

            migrationBuilder.DropTable(
                name: "detalle_Presupuestos");

            migrationBuilder.DropTable(
                name: "Equipos");

            migrationBuilder.DropTable(
                name: "Tecnicos");

            migrationBuilder.DropTable(
                name: "Materiales1");

            migrationBuilder.DropTable(
                name: "Clientes");

            migrationBuilder.DropTable(
                name: "Proveedores");
        }
    }
}
