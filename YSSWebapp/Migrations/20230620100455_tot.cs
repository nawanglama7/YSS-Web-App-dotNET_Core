using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace YSSWebapp.Migrations
{
    /// <inheritdoc />
    public partial class tot : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Members",
                columns: table => new
                {
                    StateID = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    BAIID = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MemberType = table.Column<int>(type: "int", nullable: false),
                    pic = table.Column<byte[]>(type: "varbinary(max)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Gender = table.Column<bool>(type: "bit", nullable: false),
                    DoB = table.Column<DateTime>(type: "datetime2", nullable: false),
                    PhoneNo = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Members", x => x.StateID);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Members");
        }
    }
}
