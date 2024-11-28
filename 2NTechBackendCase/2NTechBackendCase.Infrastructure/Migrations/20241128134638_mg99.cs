using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace _2NTechBackendCase.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class mg99 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<Guid>(
                name: "ReportId",
                table: "Employees",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.CreateTable(
                name: "Reports",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Reports", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Employees_ReportId",
                table: "Employees",
                column: "ReportId");

            migrationBuilder.AddForeignKey(
                name: "FK_Employees_Reports_ReportId",
                table: "Employees",
                column: "ReportId",
                principalTable: "Reports",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Employees_Reports_ReportId",
                table: "Employees");

            migrationBuilder.DropTable(
                name: "Reports");

            migrationBuilder.DropIndex(
                name: "IX_Employees_ReportId",
                table: "Employees");

            migrationBuilder.DropColumn(
                name: "ReportId",
                table: "Employees");
        }
    }
}
