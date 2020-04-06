using Microsoft.EntityFrameworkCore.Migrations;

namespace ClientEight.Migrations
{
    public partial class seedentitiestable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            try
            {
                migrationBuilder.InsertData(
                table: "entities",
                columns: new[] { "ID", "Age", "Name", "Password", "Salary", "UserID" },
                values: new object[] { 1, 23, "SidduChalwa", "@Siddu0.sid", 450000, "siddu@gmail.com" });
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
                migrationBuilder.DeleteData(
                table: "entities",
                keyColumn: "ID",
                keyValue: 1);
            }
            catch (System.Exception)
            {

                throw;
            }
        }
    }
}
