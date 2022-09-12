using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace JaizBank.Data.Migrations
{
    public partial class InitialMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Transactions",
                columns: table => new
                {
                    TransactionsId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MerchantId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MerchantName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Location = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TerminalId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Stan = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DateTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Amount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    DebitCardNo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ExpireDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    AuthorizationCode = table.Column<double>(type: "float", nullable: true),
                    Offline = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ResponseCode = table.Column<int>(type: "int", nullable: false),
                    AID = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RRN = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Accelerex = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PTAD = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Transactions", x => x.TransactionsId);
                });

            migrationBuilder.InsertData(
                table: "Transactions",
                columns: new[] { "TransactionsId", "AID", "Accelerex", "Amount", "AuthorizationCode", "DateTime", "DebitCardNo", "ExpireDate", "Location", "MerchantId", "MerchantName", "Offline", "PTAD", "RRN", "ResponseCode", "Stan", "TerminalId" },
                values: new object[] { 1, "A0000000041010", "2.0.0-090921-LINT", 1m, 0.0, null, "539941******3369", null, "NO, 174 NTA/MBUORA RD, PORTHARCOURT", null, "LIZPEE GLOBAL RESOURCES", "CVM", "Global Accelerex", "000210002450", 91, "003862", "23011845" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Transactions");
        }
    }
}
