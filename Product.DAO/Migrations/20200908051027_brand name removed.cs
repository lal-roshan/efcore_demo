using Microsoft.EntityFrameworkCore.Migrations;

namespace Product.DAO.Migrations
{
    public partial class brandnameremoved : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Brand",
                table: "ProductMaster");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Brand",
                table: "ProductMaster",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
