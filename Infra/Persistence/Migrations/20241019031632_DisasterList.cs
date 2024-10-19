using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Infra.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class DisasterList : Migration
    {
        /// <inheritdoc />
    protected override void Up(MigrationBuilder migrationBuilder)
{
    migrationBuilder.Sql(
        @"ALTER TABLE ""Regions"" 
          ALTER COLUMN ""DisasterType"" 
          TYPE integer[] 
          USING ARRAY[""DisasterType""];");
}



        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "DisasterType",
                table: "Regions",
                type: "integer",
                nullable: false,
                oldClrType: typeof(int[]),
                oldType: "integer[]");
        }
    }
}
