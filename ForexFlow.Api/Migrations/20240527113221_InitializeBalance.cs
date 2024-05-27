using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ForexFlow.Api.Migrations
{
    /// <inheritdoc />
    public partial class InitializeBalance : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Balances",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    USD = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    UZS = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    RUB = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Balances", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Balances");
        }
    }
}
