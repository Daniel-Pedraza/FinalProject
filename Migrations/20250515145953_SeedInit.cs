using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FinalProject.Migrations
{
    /// <inheritdoc />
    public partial class SeedInit : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Photo",
                table: "Members",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "MemberID",
                table: "Contacts",
                type: "INTEGER",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PhoneNumber",
                table: "Contacts",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "PricingID",
                table: "Contacts",
                type: "INTEGER",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Pricings",
                columns: table => new
                {
                    PricingID = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Description = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pricings", x => x.PricingID);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Contacts_MemberID",
                table: "Contacts",
                column: "MemberID");

            migrationBuilder.CreateIndex(
                name: "IX_Contacts_PricingID",
                table: "Contacts",
                column: "PricingID");

            migrationBuilder.AddForeignKey(
                name: "FK_Contacts_Members_MemberID",
                table: "Contacts",
                column: "MemberID",
                principalTable: "Members",
                principalColumn: "MemberID");

            migrationBuilder.AddForeignKey(
                name: "FK_Contacts_Pricings_PricingID",
                table: "Contacts",
                column: "PricingID",
                principalTable: "Pricings",
                principalColumn: "PricingID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Contacts_Members_MemberID",
                table: "Contacts");

            migrationBuilder.DropForeignKey(
                name: "FK_Contacts_Pricings_PricingID",
                table: "Contacts");

            migrationBuilder.DropTable(
                name: "Pricings");

            migrationBuilder.DropIndex(
                name: "IX_Contacts_MemberID",
                table: "Contacts");

            migrationBuilder.DropIndex(
                name: "IX_Contacts_PricingID",
                table: "Contacts");

            migrationBuilder.DropColumn(
                name: "Photo",
                table: "Members");

            migrationBuilder.DropColumn(
                name: "MemberID",
                table: "Contacts");

            migrationBuilder.DropColumn(
                name: "PhoneNumber",
                table: "Contacts");

            migrationBuilder.DropColumn(
                name: "PricingID",
                table: "Contacts");
        }
    }
}
