using Microsoft.EntityFrameworkCore.Migrations;

namespace Product.DAO.Migrations
{
    public partial class productmodifiedwithbrandname : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Brand",
                table: "ProductMaster",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Brand",
                table: "ProductMaster");
        }
    }
}
