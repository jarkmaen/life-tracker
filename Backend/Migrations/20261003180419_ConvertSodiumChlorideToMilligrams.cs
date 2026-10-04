using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Backend.Migrations
{
    /// <inheritdoc />
    public partial class ConvertSodiumChlorideToMilligrams : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("UPDATE Minerals SET Chloride = Chloride * 1000, Sodium = Sodium * 1000");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("UPDATE Minerals SET Chloride = Chloride / 1000, Sodium = Sodium / 1000");
        }
    }
}
