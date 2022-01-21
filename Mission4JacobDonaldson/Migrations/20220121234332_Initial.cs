using Microsoft.EntityFrameworkCore.Migrations;

namespace Mission4JacobDonaldson.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Responses",
                columns: table => new
                {
                    MovieId = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Category = table.Column<string>(nullable: false),
                    Title = table.Column<string>(nullable: false),
                    Year = table.Column<int>(nullable: false),
                    DirectorFirstName = table.Column<string>(nullable: false),
                    DirectorLastName = table.Column<string>(nullable: false),
                    Rating = table.Column<string>(nullable: false),
                    Edited = table.Column<bool>(nullable: false),
                    LentTo = table.Column<string>(nullable: true),
                    Notes = table.Column<string>(maxLength: 25, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Responses", x => x.MovieId);
                });

            migrationBuilder.InsertData(
                table: "Responses",
                columns: new[] { "MovieId", "Category", "DirectorFirstName", "DirectorLastName", "Edited", "LentTo", "Notes", "Rating", "Title", "Year" },
                values: new object[] { 1, "Action", "Christopher", "Nolan", false, "", "Ches this is the best!", "PG-13", "The Dark Night", 2008 });

            migrationBuilder.InsertData(
                table: "Responses",
                columns: new[] { "MovieId", "Category", "DirectorFirstName", "DirectorLastName", "Edited", "LentTo", "Notes", "Rating", "Title", "Year" },
                values: new object[] { 2, "SciFi", "George", "Lucas", false, "", "#r/prequelmemes for life", "PG-13", "Star Wars Episode III: Revenge of the Sith", 2005 });

            migrationBuilder.InsertData(
                table: "Responses",
                columns: new[] { "MovieId", "Category", "DirectorFirstName", "DirectorLastName", "Edited", "LentTo", "Notes", "Rating", "Title", "Year" },
                values: new object[] { 3, "Drama/History", "Bryan", "Singer", false, "", "WWII Conspiracy Plot", "PG-13", "Valkyrie", 2008 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Responses");
        }
    }
}
