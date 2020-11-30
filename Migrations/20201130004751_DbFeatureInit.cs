using Microsoft.EntityFrameworkCore.Migrations;

namespace CRCompras.Migrations
{
    public partial class DbFeatureInit : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("INSERT INTO Features (Name) VALUES ('Polarizado');");
            migrationBuilder.Sql("INSERT INTO Features (Name) VALUES ('Sonido');");
            migrationBuilder.Sql("INSERT INTO Features (Name) VALUES ('4x4');");
            migrationBuilder.Sql("INSERT INTO Features (Name) VALUES ('Bajo');");
            migrationBuilder.Sql("INSERT INTO Features (Name) VALUES ('Hatchback');");
            migrationBuilder.Sql("INSERT INTO Features (Name) VALUES ('Sedan');");
            migrationBuilder.Sql("INSERT INTO Features (Name) VALUES ('Deportivo');");
            migrationBuilder.Sql("INSERT INTO Features (Name) VALUES ('Utilitario');");
            migrationBuilder.Sql("INSERT INTO Features (Name) VALUES ('Alto');");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("DELETE FROM Features WHERE Name IN ('Polarizado', 'Sonido', '4x4', 'Bajo', 'Hatchback', 'Sedan', 'Deportivo', 'Utilitario', 'Alto')");
        }

   }
}
