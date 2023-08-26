using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Traversal.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class mig_add_blogpostdate_destination : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "BlogPostDate",
                table: "Destinations",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "BlogPostDate",
                table: "Destinations");
        }
    }
}
