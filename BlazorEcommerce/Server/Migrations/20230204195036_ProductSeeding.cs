using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace BlazorEcommerce.Server.Migrations
{
    /// <inheritdoc />
    public partial class ProductSeeding : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Description", "ImageUrl", "Price", "Title" },
                values: new object[,]
                {
                    { 1, "The Hitchhiker's Guide to the Galaxy has become an international multi-media phenomenon; the novels are the most widely distributed, having been translated into more than 30 languages by 2005.[4][5] The first novel, The Hitchhiker's Guide to the Galaxy (1979), has been ranked fourth on the BBC’s The Big Read poll.[6] The sixth novel, And Another Thing, was written by Eoin Colfer with additional unpublished material by Douglas Adams. In 2017, BBC Radio 4 announced a 40th-anniversary celebration with Dirk Maggs, one of the original producers, in charge.[7] The first of six new episodes was broadcast on 8 March 2018.[8]", "https://upload.wikimedia.org/wikipedia/en/b/bd/H2G2_UK_front_cover.jpg", 9.99m, "The Hitchhiker's Guide to the Galaxy" },
                    { 2, "In the 2040s,[9] the world has been gripped by an energy crisis from the depletion of fossil fuels and the consequences of pollution, global warming and overpopulation, causing widespread social problems, poverty, and economic stagnation. To escape the decline their world is facing, people turn to the OASIS,[a] a virtual reality simulator accessible by players using visors and haptic technology such as gloves. It functions both as an MMORPG and as a virtual world, with its currency being the most stable in the real world. It was created by James Donovan Halliday, founder of Gregarious Simulation Systems (formerly Gregarious Games), who made a posthumous video of his will stating to the public that he had left an Easter egg inside the OASIS, and the first person to find it would inherit his entire fortune, ownership of his corporation as well as complete control of the OASIS itself, which is worth trillions. The story follows the adventures of Wade Watts, starting about five years after the announcement, when he discovers one of the three keys which unlock three successive gates leading to the treasure.", "https://upload.wikimedia.org/wikipedia/en/thumb/a/a4/Ready_Player_One_cover.jpg/220px-Ready_Player_One_cover.jpg", 7.99m, "Ready Player One" },
                    { 3, "A dystopian social science fiction novel and cautionary tale written by George Orwell.", "https://upload.wikimedia.org/wikipedia/commons/thumb/c/c3/1984first.jpg/220px-1984first.jpg", 6.99m, "Nineteen Eighty-Four" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3);
        }
    }
}
