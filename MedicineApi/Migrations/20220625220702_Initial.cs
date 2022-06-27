using Microsoft.EntityFrameworkCore.Migrations;

namespace MedicineApi.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Medicines",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(80)", maxLength: 80, nullable: false),
                    Category = table.Column<string>(type: "nvarchar(80)", maxLength: 80, nullable: true),
                    Quantity = table.Column<int>(type: "int", nullable: false),
                    Price = table.Column<decimal>(type: "decimal(10,2)", precision: 10, scale: 2, nullable: false),
                    ExpDate = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Medicines", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Medicines",
                columns: new[] { "Id", "Category", "ExpDate", "Name", "Price", "Quantity" },
                values: new object[] { 1, "Analgesic", "02/02/2023", "Aspirin", 10.25m, 30 });

            migrationBuilder.InsertData(
                table: "Medicines",
                columns: new[] { "Id", "Category", "ExpDate", "Name", "Price", "Quantity" },
                values: new object[] { 2, "Antibiotic", "12/08/2022", "Penicillin", 25.45m, 5 });

            migrationBuilder.InsertData(
                table: "Medicines",
                columns: new[] { "Id", "Category", "ExpDate", "Name", "Price", "Quantity" },
                values: new object[] { 3, "Analgesic", "21/07/2022", "Paracetamol", 7.95m, 10 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Medicines");
        }
    }
}
