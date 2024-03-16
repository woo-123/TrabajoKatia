﻿using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace GrupoPrueba2.Migrations
{
    public partial class context : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "DataPago",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    PaymentDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    NombreTarjeta = table.Column<string>(type: "text", nullable: true),
                    NumeroTarjeta = table.Column<string>(type: "text", nullable: true),
                    MontoTotal = table.Column<decimal>(type: "numeric", nullable: false),
                    UserID = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DataPago", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "t_order",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    UserID = table.Column<string>(type: "text", nullable: true),
                    Total = table.Column<decimal>(type: "numeric", nullable: false),
                    pagoId = table.Column<int>(type: "integer", nullable: true),
                    Status = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_t_order", x => x.id);
                    table.ForeignKey(
                        name: "FK_t_order_DataPago_pagoId",
                        column: x => x.pagoId,
                        principalTable: "DataPago",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "t_order_detail",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    ProductoId = table.Column<int>(type: "integer", nullable: true),
                    Quantity = table.Column<int>(type: "integer", nullable: false),
                    Price = table.Column<decimal>(type: "numeric", nullable: false),
                    pedidoID = table.Column<int>(type: "integer", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_t_order_detail", x => x.id);
                    table.ForeignKey(
                        name: "FK_t_order_detail_t_order_pedidoID",
                        column: x => x.pedidoID,
                        principalTable: "t_order",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_t_order_detail_t_product_ProductoId",
                        column: x => x.ProductoId,
                        principalTable: "t_product",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_t_order_pagoId",
                table: "t_order",
                column: "pagoId");

            migrationBuilder.CreateIndex(
                name: "IX_t_order_detail_pedidoID",
                table: "t_order_detail",
                column: "pedidoID");

            migrationBuilder.CreateIndex(
                name: "IX_t_order_detail_ProductoId",
                table: "t_order_detail",
                column: "ProductoId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "t_order_detail");

            migrationBuilder.DropTable(
                name: "t_order");

            migrationBuilder.DropTable(
                name: "DataPago");
        }
    }
}
