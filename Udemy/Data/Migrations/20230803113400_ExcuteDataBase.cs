using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Udemy.Data.Migrations
{
    public partial class ExcuteDataBase : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "CreatedById",
                table: "Topics",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LastUpdatedById",
                table: "Topics",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CreatedById",
                table: "Courses",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LastUpdatedById",
                table: "Courses",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CreatedById",
                table: "Categories",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LastUpdatedById",
                table: "Categories",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CreatedById",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedOn",
                table: "AspNetUsers",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Discriminator",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "FullName",
                table: "AspNetUsers",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "AspNetUsers",
                type: "bit",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LastUpdatedById",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "LastUpdatedOn",
                table: "AspNetUsers",
                type: "datetime2",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Topics_CreatedById",
                table: "Topics",
                column: "CreatedById");

            migrationBuilder.CreateIndex(
                name: "IX_Topics_LastUpdatedById",
                table: "Topics",
                column: "LastUpdatedById");

            migrationBuilder.CreateIndex(
                name: "IX_Courses_CreatedById",
                table: "Courses",
                column: "CreatedById");

            migrationBuilder.CreateIndex(
                name: "IX_Courses_LastUpdatedById",
                table: "Courses",
                column: "LastUpdatedById");

            migrationBuilder.CreateIndex(
                name: "IX_Categories_CreatedById",
                table: "Categories",
                column: "CreatedById");

            migrationBuilder.CreateIndex(
                name: "IX_Categories_LastUpdatedById",
                table: "Categories",
                column: "LastUpdatedById");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUsers_Email",
                table: "AspNetUsers",
                column: "Email",
                unique: true,
                filter: "[Email] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUsers_UserName",
                table: "AspNetUsers",
                column: "UserName",
                unique: true,
                filter: "[UserName] IS NOT NULL");

            migrationBuilder.AddForeignKey(
                name: "FK_Categories_AspNetUsers_CreatedById",
                table: "Categories",
                column: "CreatedById",
                principalTable: "AspNetUsers",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Categories_AspNetUsers_LastUpdatedById",
                table: "Categories",
                column: "LastUpdatedById",
                principalTable: "AspNetUsers",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Courses_AspNetUsers_CreatedById",
                table: "Courses",
                column: "CreatedById",
                principalTable: "AspNetUsers",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Courses_AspNetUsers_LastUpdatedById",
                table: "Courses",
                column: "LastUpdatedById",
                principalTable: "AspNetUsers",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Topics_AspNetUsers_CreatedById",
                table: "Topics",
                column: "CreatedById",
                principalTable: "AspNetUsers",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Topics_AspNetUsers_LastUpdatedById",
                table: "Topics",
                column: "LastUpdatedById",
                principalTable: "AspNetUsers",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Categories_AspNetUsers_CreatedById",
                table: "Categories");

            migrationBuilder.DropForeignKey(
                name: "FK_Categories_AspNetUsers_LastUpdatedById",
                table: "Categories");

            migrationBuilder.DropForeignKey(
                name: "FK_Courses_AspNetUsers_CreatedById",
                table: "Courses");

            migrationBuilder.DropForeignKey(
                name: "FK_Courses_AspNetUsers_LastUpdatedById",
                table: "Courses");

            migrationBuilder.DropForeignKey(
                name: "FK_Topics_AspNetUsers_CreatedById",
                table: "Topics");

            migrationBuilder.DropForeignKey(
                name: "FK_Topics_AspNetUsers_LastUpdatedById",
                table: "Topics");

            migrationBuilder.DropIndex(
                name: "IX_Topics_CreatedById",
                table: "Topics");

            migrationBuilder.DropIndex(
                name: "IX_Topics_LastUpdatedById",
                table: "Topics");

            migrationBuilder.DropIndex(
                name: "IX_Courses_CreatedById",
                table: "Courses");

            migrationBuilder.DropIndex(
                name: "IX_Courses_LastUpdatedById",
                table: "Courses");

            migrationBuilder.DropIndex(
                name: "IX_Categories_CreatedById",
                table: "Categories");

            migrationBuilder.DropIndex(
                name: "IX_Categories_LastUpdatedById",
                table: "Categories");

            migrationBuilder.DropIndex(
                name: "IX_AspNetUsers_Email",
                table: "AspNetUsers");

            migrationBuilder.DropIndex(
                name: "IX_AspNetUsers_UserName",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "CreatedById",
                table: "Topics");

            migrationBuilder.DropColumn(
                name: "LastUpdatedById",
                table: "Topics");

            migrationBuilder.DropColumn(
                name: "CreatedById",
                table: "Courses");

            migrationBuilder.DropColumn(
                name: "LastUpdatedById",
                table: "Courses");

            migrationBuilder.DropColumn(
                name: "CreatedById",
                table: "Categories");

            migrationBuilder.DropColumn(
                name: "LastUpdatedById",
                table: "Categories");

            migrationBuilder.DropColumn(
                name: "CreatedById",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "CreatedOn",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "Discriminator",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "FullName",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "LastUpdatedById",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "LastUpdatedOn",
                table: "AspNetUsers");
        }
    }
}
