using Microsoft.EntityFrameworkCore.Migrations;

namespace CRCompras.Migrations
{
    public partial class DbInit : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            // Makes
            migrationBuilder.Sql("INSERT INTO Makes (Name) VALUES ('Toyota');");
            migrationBuilder.Sql("INSERT INTO Makes (Name) VALUES ('Nissan');");
            migrationBuilder.Sql("INSERT INTO Makes (Name) VALUES ('Mazda');");

            // Models
            migrationBuilder.Sql("INSERT INTO Models (Name, MakeId) VALUES ('Echo', 1);");
            migrationBuilder.Sql("INSERT INTO Models (Name, MakeId) VALUES ('Corolla', 1);");
            migrationBuilder.Sql("INSERT INTO Models (Name, MakeId) VALUES ('Hylux', 1);");

            migrationBuilder.Sql("INSERT INTO Models (Name, MakeId) VALUES ('Qashqai', 2);");
            migrationBuilder.Sql("INSERT INTO Models (Name, MakeId) VALUES ('Navara', 2);");
            migrationBuilder.Sql("INSERT INTO Models (Name, MakeId) VALUES ('B13', 2);");

            migrationBuilder.Sql("INSERT INTO Models (Name, MakeId) VALUES ('RX8', 3);");
            migrationBuilder.Sql("INSERT INTO Models (Name, MakeId) VALUES ('RX7', 3);");
            migrationBuilder.Sql("INSERT INTO Models (Name, MakeId) VALUES ('Tuanis', 3);");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("DELETE FROM Makes WHERE Name IN ('Toyota', 'Nissan', 'Mazda');");
        }
    }
}
