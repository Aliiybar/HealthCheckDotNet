using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SignApi.Migrations
{
    public partial class initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {

            migrationBuilder.InsertData(
                table: "Signs", 
                columns: new[] { "Id", "SignName", "Location" }, 
                values: new object[] { Guid.NewGuid(), "TST001", "TEST" });

            //migrationBuilder.Sql($"INSERT INTO Signs (Id, SignName, Location) VALUES ('{Guid.NewGuid()}', 'TST001', 'TEST' ) ");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
        }
    }
}
