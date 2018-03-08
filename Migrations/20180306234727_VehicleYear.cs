using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace autoTrader.Migrations
{
    public partial class VehicleYear : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "year",
                table: "Vehicle",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "year",
                table: "Vehicle");
        }
    }
}
