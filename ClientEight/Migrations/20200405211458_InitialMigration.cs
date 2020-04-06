using Microsoft.EntityFrameworkCore.Migrations;

namespace ClientEight.Migrations
{
    public partial class InitialMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            try
            {
                migrationBuilder.CreateTable(
                name: "entities",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserID = table.Column<string>(nullable: true),
                    Password = table.Column<string>(nullable: true),
                    Name = table.Column<string>(nullable: true),
                    Age = table.Column<int>(nullable: false),
                    Salary = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_entities", x => x.ID);
                });
            }
            catch (System.Exception)
            {

                throw;
            }
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            try
            {
                migrationBuilder.DropTable(
                name: "entities");
            }
            catch (System.Exception)
            {

                throw;
            }
        }
    }
}
