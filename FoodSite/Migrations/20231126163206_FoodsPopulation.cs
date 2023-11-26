using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FoodSite.Migrations
{
    public partial class FoodsPopulation : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("INSERT INTO Foods(FoodName, FoodShortDescription, FoodDetailedDescription, FoodPrice, FoodImageUrl, FoodThumbUrl, IsFavoriteFood, InStock, CategoryId)" +
                                            "VALUES('All-in Burguer', 'Bread, Hamburguer, Egg, Ham and Cheese', 'Delicious bread with eggs, ham, cheese and good quality meat', 12.50, 'http://www.macoratti.net/Imagens/lanches/cheesesalada1.jpg', 'http://www.macoratti.net/Imagens/lanches/cheesesalada1.jpg', 0, 1, 1)");

            migrationBuilder.Sql("INSERT INTO Foods(FoodName, FoodShortDescription, FoodDetailedDescription, FoodPrice, FoodImageUrl, FoodThumbUrl, IsFavoriteFood, InStock, CategoryId)" +
                                            "VALUES('Simple Sandwich', 'Bread, Ham, Cheese and tomatoes', 'Delicious simple sandwich for a quick break', 8.00, 'http://www.macoratti.net/Imagens/lanches/mistoquente4.jpg', 'http://www.macoratti.net/Imagens/lanches/mistoquente4.jpg', 0, 1, 1)");

            migrationBuilder.Sql("INSERT INTO Foods(FoodName, FoodShortDescription, FoodDetailedDescription, FoodPrice, FoodImageUrl, FoodThumbUrl, IsFavoriteFood, InStock, CategoryId)" +
                                            "VALUES('Simple Burguer', 'Bread, Hamburguer, Ham, Cheese', 'Delicious medium burger for you that is not that hungry', 11.00, 'http://www.macoratti.net/Imagens/lanches/cheeseburguer1.jpg', 'http://www.macoratti.net/Imagens/lanches/cheeseburguer1.jpg', 0, 1, 1)");

            migrationBuilder.Sql("INSERT INTO Foods(FoodName, FoodShortDescription, FoodDetailedDescription, FoodPrice, FoodImageUrl, FoodThumbUrl, IsFavoriteFood, InStock, CategoryId)" +
                                            "VALUES('Salad Sandwich', 'Fit Bread, Carrots, Turkey, White Cheese', 'Delicious natural sandwich for you that is taking a fit lifestyle', 15.00, 'http://www.macoratti.net/Imagens/lanches/lanchenatural.jpg', 'http://www.macoratti.net/Imagens/lanches/lanchenatural.jpg', 1, 1, 2)");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("DELETE FROM Foods");
        }
    }
}
