using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FoodSite.Migrations
{
    public partial class CategoriesPopulation : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("INSERT INTO Categories(CategoryName, CategoryDescription)" +
                                 "VALUES ('Normal', 'Normal ingredients food')");


            migrationBuilder.Sql("INSERT INTO Categories(CategoryName, CategoryDescription)" +
                                 "VALUES ('Natrual', 'Natural ingredients food')");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("DELETE FROM Categories");
        }
    }
}
