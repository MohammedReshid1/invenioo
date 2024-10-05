﻿using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace invenio.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddUserProfImage : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ImagePath",
                table: "Users",
                type: "text",
                nullable: false,
                defaultValue: "");
        }
        
        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ImagePath",
                table: "Users");
        }
    }
}
