using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace JaizBank.Data.Migrations
{
    public partial class Added : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<double>(
                name: "Amount",
                table: "Transactions",
                type: "float",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "TransactionsId",
                keyValue: 1,
                columns: new[] { "Amount", "DateTime", "ExpireDate" },
                values: new object[] { 0.01, new DateTime(2022, 8, 30, 13, 45, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 11, 24, 0, 0, 0, 0, DateTimeKind.Unspecified) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<decimal>(
                name: "Amount",
                table: "Transactions",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(double),
                oldType: "float");

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "TransactionsId",
                keyValue: 1,
                columns: new[] { "Amount", "DateTime", "ExpireDate" },
                values: new object[] { 1m, null, null });
        }
    }
}
