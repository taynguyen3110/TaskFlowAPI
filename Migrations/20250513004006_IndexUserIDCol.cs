﻿using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace daytask.Migrations
{
    /// <inheritdoc />
    public partial class IndexUserIDCol : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_Tasks_UserId",
                table: "Tasks",
                column: "UserId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Tasks_UserId",
                table: "Tasks");
        }
    }
}
