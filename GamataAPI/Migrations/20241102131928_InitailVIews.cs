using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GamataAPI.Migrations
{
    /// <inheritdoc />
    public partial class InitailVIews : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            SqlViews.SQlViewsClass sQlViews = new SqlViews.SQlViewsClass();
            sQlViews.DeleteViewQuery(migrationBuilder);
            sQlViews.InsertViewQuery(migrationBuilder);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
