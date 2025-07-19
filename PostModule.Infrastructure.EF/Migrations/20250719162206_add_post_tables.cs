using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PostModule.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class add_post_tables : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Posts",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    Status = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    LocationType = table.Column<int>(type: "int", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Posts", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PostPrices",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PostId = table.Column<int>(type: "int", nullable: false),
                    WeightStart = table.Column<int>(type: "int", nullable: false),
                    WeightEnd = table.Column<int>(type: "int", nullable: false),
                    Price_Tehran = table.Column<int>(type: "int", nullable: false),
                    Price_StateCenter = table.Column<int>(type: "int", nullable: false),
                    Price_City = table.Column<int>(type: "int", nullable: false),
                    Price_InsideState = table.Column<int>(type: "int", nullable: false),
                    Price_StateClose = table.Column<int>(type: "int", nullable: false),
                    Price_StateNonClose = table.Column<int>(type: "int", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PostPrices", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PostPrices_Posts_PostId",
                        column: x => x.PostId,
                        principalTable: "Posts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_PostPrices_PostId",
                table: "PostPrices",
                column: "PostId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PostPrices");

            migrationBuilder.DropTable(
                name: "Posts");
        }
    }
}
