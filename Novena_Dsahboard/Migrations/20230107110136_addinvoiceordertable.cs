using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Novena_Dsahboard.Migrations
{
    public partial class addinvoiceordertable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Invoice",
                columns: table => new
                {
                    in_id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    in_date = table.Column<DateTime>(nullable: true),
                    in_totalbill = table.Column<double>(nullable: true),
                    in_fk_user = table.Column<int>(nullable: true),
                    UserId = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Invoice", x => x.in_id);
                    table.ForeignKey(
                        name: "FK_Invoice_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Order",
                columns: table => new
                {
                    o_id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    o_date = table.Column<DateTime>(nullable: true),
                    o_qty = table.Column<int>(nullable: true),
                    o_bill = table.Column<double>(nullable: true),
                    o_unitprice = table.Column<int>(nullable: true),
                    o_fk_pro = table.Column<int>(nullable: true),
                    ProductId = table.Column<int>(nullable: true),
                    o_fk_invoice = table.Column<int>(nullable: true),
                    Invoicein_id = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Order", x => x.o_id);
                    table.ForeignKey(
                        name: "FK_Order_Invoice_Invoicein_id",
                        column: x => x.Invoicein_id,
                        principalTable: "Invoice",
                        principalColumn: "in_id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Order_Product_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Product",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Invoice_UserId",
                table: "Invoice",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Order_Invoicein_id",
                table: "Order",
                column: "Invoicein_id");

            migrationBuilder.CreateIndex(
                name: "IX_Order_ProductId",
                table: "Order",
                column: "ProductId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Order");

            migrationBuilder.DropTable(
                name: "Invoice");
        }
    }
}
