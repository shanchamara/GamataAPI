using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GamataAPI.Migrations
{
    /// <inheritdoc />
    public partial class InitailTables : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                table: "AspNetRoleClaims");

            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                table: "AspNetUserClaims");

            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                table: "AspNetUserLogins");

            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                table: "AspNetUserRoles");

            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                table: "AspNetUserRoles");

            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                table: "AspNetUserTokens");

            migrationBuilder.DropForeignKey(
                name: "FK_RefreshToken_AspNetUsers_AppUserId",
                table: "RefreshToken");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AspNetUserTokens",
                table: "AspNetUserTokens");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AspNetUsers",
                table: "AspNetUsers");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AspNetUserRoles",
                table: "AspNetUserRoles");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AspNetUserLogins",
                table: "AspNetUserLogins");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AspNetUserClaims",
                table: "AspNetUserClaims");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AspNetRoles",
                table: "AspNetRoles");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AspNetRoleClaims",
                table: "AspNetRoleClaims");

            migrationBuilder.RenameTable(
                name: "AspNetUserTokens",
                newName: "Tbl_User_Token");

            migrationBuilder.RenameTable(
                name: "AspNetUsers",
                newName: "t_user");

            migrationBuilder.RenameTable(
                name: "AspNetUserRoles",
                newName: "Tbl_User_Role");

            migrationBuilder.RenameTable(
                name: "AspNetUserLogins",
                newName: "Tbl_User_Login");

            migrationBuilder.RenameTable(
                name: "AspNetUserClaims",
                newName: "Tbl_User_Claims");

            migrationBuilder.RenameTable(
                name: "AspNetRoles",
                newName: "Tbl_Role");

            migrationBuilder.RenameTable(
                name: "AspNetRoleClaims",
                newName: "Tbl_Role_Claims");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "t_user",
                newName: "RnUserID");

            migrationBuilder.RenameIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "Tbl_User_Role",
                newName: "IX_Tbl_User_Role_RoleId");

            migrationBuilder.RenameIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "Tbl_User_Login",
                newName: "IX_Tbl_User_Login_UserId");

            migrationBuilder.RenameIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "Tbl_User_Claims",
                newName: "IX_Tbl_User_Claims_UserId");

            migrationBuilder.RenameIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "Tbl_Role_Claims",
                newName: "IX_Tbl_Role_Claims_RoleId");

            migrationBuilder.AlterColumn<string>(
                name: "Address",
                table: "t_user",
                type: "mediumtext",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "longtext",
                oldNullable: true)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<string>(
                name: "Country",
                table: "t_user",
                type: "varchar(45)",
                maxLength: 45,
                nullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<string>(
                name: "District",
                table: "t_user",
                type: "varchar(45)",
                maxLength: 45,
                nullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<string>(
                name: "Division",
                table: "t_user",
                type: "varchar(45)",
                maxLength: 45,
                nullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<string>(
                name: "GramasewaDivision",
                table: "t_user",
                type: "varchar(45)",
                maxLength: 45,
                nullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<string>(
                name: "IdentificationID",
                table: "t_user",
                type: "varchar(45)",
                maxLength: 45,
                nullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<string>(
                name: "IdentificationType",
                table: "t_user",
                type: "varchar(45)",
                maxLength: 45,
                nullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<string>(
                name: "Incorporation",
                table: "t_user",
                type: "varchar(100)",
                maxLength: 100,
                nullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<string>(
                name: "IncorporationNo",
                table: "t_user",
                type: "varchar(50)",
                maxLength: 50,
                nullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<DateTime>(
                name: "InsertedOn",
                table: "t_user",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<bool>(
                name: "IsActive",
                table: "t_user",
                type: "tinyint(1)",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<int>(
                name: "LastModifiedBy",
                table: "t_user",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<DateTime>(
                name: "LastModifiedOn",
                table: "t_user",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "t_user",
                type: "varchar(300)",
                maxLength: 300,
                nullable: false,
                defaultValue: "")
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<string>(
                name: "PostalCode",
                table: "t_user",
                type: "varchar(45)",
                maxLength: 45,
                nullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<string>(
                name: "ProfileImage",
                table: "t_user",
                type: "varchar(80)",
                maxLength: 80,
                nullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<string>(
                name: "Province",
                table: "t_user",
                type: "varchar(45)",
                maxLength: 45,
                nullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<string>(
                name: "Remark",
                table: "t_user",
                type: "mediumtext",
                nullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<string>(
                name: "StoreName",
                table: "t_user",
                type: "varchar(100)",
                maxLength: 100,
                nullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Tbl_User_Token",
                table: "Tbl_User_Token",
                columns: new[] { "UserId", "LoginProvider", "Name" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_t_user",
                table: "t_user",
                column: "RnUserID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Tbl_User_Role",
                table: "Tbl_User_Role",
                columns: new[] { "UserId", "RoleId" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_Tbl_User_Login",
                table: "Tbl_User_Login",
                columns: new[] { "LoginProvider", "ProviderKey" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_Tbl_User_Claims",
                table: "Tbl_User_Claims",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Tbl_Role",
                table: "Tbl_Role",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Tbl_Role_Claims",
                table: "Tbl_Role_Claims",
                column: "Id");

            migrationBuilder.CreateTable(
                name: "m_activity",
                columns: table => new
                {
                    Code = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Name_Sinhala = table.Column<string>(type: "varchar(500)", maxLength: 500, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Name_English = table.Column<string>(type: "varchar(500)", maxLength: 500, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Name_Tamil = table.Column<string>(type: "varchar(500)", maxLength: 500, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Type = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Icon = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_m_activity", x => x.Code);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "m_country",
                columns: table => new
                {
                    Code = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Name_Sinhala = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Name_English = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Name_Tamil = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_m_country", x => x.Code);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "m_library_has_group",
                columns: table => new
                {
                    Code = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Name_English = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Name_Sinhala = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Name_Tamil = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Image = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_m_library_has_group", x => x.Code);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "m_product",
                columns: table => new
                {
                    Code = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Parent = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Name_Sinhala = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Name_English = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Name_Tamil = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Image = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Product_Description = table.Column<string>(type: "mediumtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    UOMGroups = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    IsSeed = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    Type = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Is_SLGAP_Certified = table.Column<bool>(type: "tinyint(1)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_m_product", x => x.Code);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "m_supplier",
                columns: table => new
                {
                    Code = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Name_Sinhala = table.Column<string>(type: "varchar(500)", maxLength: 500, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Name_English = table.Column<string>(type: "varchar(500)", maxLength: 500, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Name_Tamil = table.Column<string>(type: "varchar(500)", maxLength: 500, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Address = table.Column<string>(type: "varchar(5000)", maxLength: 5000, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Contact_No1 = table.Column<string>(type: "varchar(10)", maxLength: 10, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Contact_No2 = table.Column<string>(type: "varchar(10)", maxLength: 10, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Email = table.Column<string>(type: "varchar(200)", maxLength: 200, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    InsertedOn = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    LastModifiedOn = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    LastModifiedBy = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_m_supplier", x => x.Code);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "t_apptoken",
                columns: table => new
                {
                    Code = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    FK_UserID = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Token = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Mobile_OS = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    InsertedOn = table.Column<DateTime>(type: "datetime(6)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_t_apptoken", x => x.Code);
                    table.ForeignKey(
                        name: "FK_t_apptoken_t_user_FK_UserID",
                        column: x => x.FK_UserID,
                        principalTable: "t_user",
                        principalColumn: "RnUserID",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "t_blog",
                columns: table => new
                {
                    Code = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Category = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Short_Text = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Subject = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Body_English = table.Column<string>(type: "LONGTEXT", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Lan = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    FK_UserID = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    IsApproved = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    FK_User_ApprovedID = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    PublishedOn = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    Image = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    IsDeleted = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    InsertedOn = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    LastModifiedOn = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    LastModifiedBy = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_t_blog", x => x.Code);
                    table.ForeignKey(
                        name: "FK_t_blog_t_user_FK_UserID",
                        column: x => x.FK_UserID,
                        principalTable: "t_user",
                        principalColumn: "RnUserID",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "t_notification",
                columns: table => new
                {
                    Code = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Message = table.Column<string>(type: "mediumtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Message_Sinhala = table.Column<string>(type: "mediumtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Message_Tamil = table.Column<string>(type: "mediumtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    FK_UserID = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    InsertedOn = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    IsView = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    Type = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    TypeCode = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    FK_To_UserID = table.Column<int>(type: "int", nullable: false),
                    LastModifiedOn = table.Column<DateTime>(type: "datetime(6)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_t_notification", x => x.Code);
                    table.ForeignKey(
                        name: "FK_t_notification_t_user_FK_UserID",
                        column: x => x.FK_UserID,
                        principalTable: "t_user",
                        principalColumn: "RnUserID",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "t_order_header",
                columns: table => new
                {
                    Code = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    FK_Buyer_UserID = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    FK_Seller_UserID = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Shipping_Address = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Shipping_Contact = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Shipping_Name = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Order_Placed_DateTime = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    Order_Confirmed_DateTime = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    Order_Rejected_DateTime = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    Order_Shipped_DateTime = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    Order_Delivered_DateTime = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    Order_Completed_DateTime = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    Order_Canceled_DateTime = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    Order_Received_DateTime = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    Buyer_Rate = table.Column<int>(type: "int", nullable: false),
                    Comment = table.Column<string>(type: "LONGTEXT", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Buyer_RateOn = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    Status = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Cancel_Reason = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    InsertedOn = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    LastModifiedOn = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    LastModifiedBy = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_t_order_header", x => x.Code);
                    table.ForeignKey(
                        name: "FK_t_order_header_t_user_FK_Buyer_UserID",
                        column: x => x.FK_Buyer_UserID,
                        principalTable: "t_user",
                        principalColumn: "RnUserID",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "t_post",
                columns: table => new
                {
                    Code = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Post_English = table.Column<string>(type: "LONGTEXT", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Post_Sinhala = table.Column<string>(type: "LONGTEXT", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Post_Tamil = table.Column<string>(type: "LONGTEXT", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Cover_Image = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Image1 = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Image2 = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    FK_UserID = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Publish_DateTime = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    Type = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    IsDeleted = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    InsertedOn = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    LastModifiedOn = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    LastModifiedBy = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_t_post", x => x.Code);
                    table.ForeignKey(
                        name: "FK_t_post_t_user_FK_UserID",
                        column: x => x.FK_UserID,
                        principalTable: "t_user",
                        principalColumn: "RnUserID",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "t_subscribe",
                columns: table => new
                {
                    Code = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Email = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    InsertedOn = table.Column<DateTime>(type: "datetime(6)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_t_subscribe", x => x.Code);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "m_country_detail",
                columns: table => new
                {
                    Code = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Type = table.Column<string>(type: "varchar(3)", maxLength: 3, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Parent = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Name_Sinhala = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Name_English = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Name_Tamil = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    FK_Country_Code = table.Column<string>(type: "varchar(100)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_m_country_detail", x => new { x.Code, x.Type, x.Parent });
                    table.ForeignKey(
                        name: "FK_m_country_detail_m_country_FK_Country_Code",
                        column: x => x.FK_Country_Code,
                        principalTable: "m_country",
                        principalColumn: "Code");
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "m_library_has_post",
                columns: table => new
                {
                    Code = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    FK_Library_Group = table.Column<int>(type: "int", nullable: false),
                    Subject = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Content = table.Column<string>(type: "LONGTEXT", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Lan = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    FK_UserID = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    IsApproved = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    FK_User_ApprovedID = table.Column<int>(type: "int", nullable: false),
                    PublishedOn = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    Image = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    IsDeleted = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    InsertedOn = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    LastModifiedOn = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    LastModifiedBy = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_m_library_has_post", x => x.Code);
                    table.ForeignKey(
                        name: "FK_m_library_has_post_m_library_has_group_FK_Library_Group",
                        column: x => x.FK_Library_Group,
                        principalTable: "m_library_has_group",
                        principalColumn: "Code",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_m_library_has_post_t_user_FK_UserID",
                        column: x => x.FK_UserID,
                        principalTable: "t_user",
                        principalColumn: "RnUserID",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "m_advisory",
                columns: table => new
                {
                    FK_Product_Code = table.Column<string>(type: "varchar(100)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    FK_Activity_Code = table.Column<string>(type: "varchar(100)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Start_Duration = table.Column<int>(type: "int", nullable: false),
                    End_Duration = table.Column<int>(type: "int", nullable: false),
                    Zone = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Description_English = table.Column<string>(type: "LONGTEXT", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Description_Sinhala = table.Column<string>(type: "LONGTEXT", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Description_Tamil = table.Column<string>(type: "LONGTEXT", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Order = table.Column<int>(type: "int", nullable: false),
                    InsertedOn = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    LastModifiedOn = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    LastModifiedBy = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_m_advisory", x => new { x.FK_Product_Code, x.FK_Activity_Code });
                    table.ForeignKey(
                        name: "FK_m_advisory_m_activity_FK_Activity_Code",
                        column: x => x.FK_Activity_Code,
                        principalTable: "m_activity",
                        principalColumn: "Code",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_m_advisory_m_product_FK_Product_Code",
                        column: x => x.FK_Product_Code,
                        principalTable: "m_product",
                        principalColumn: "Code",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "m_harvest_calendar",
                columns: table => new
                {
                    FK_Product_Code = table.Column<string>(type: "varchar(100)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    January = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    February = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    March = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    April = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    May = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    June = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    July = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    August = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    September = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    October = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    November = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    December = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    InsertedOn = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    LastModifiedOn = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    LastModifiedBy = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_m_harvest_calendar", x => x.FK_Product_Code);
                    table.ForeignKey(
                        name: "FK_m_harvest_calendar_m_product_FK_Product_Code",
                        column: x => x.FK_Product_Code,
                        principalTable: "m_product",
                        principalColumn: "Code",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "m_product_instructions",
                columns: table => new
                {
                    FK_Product_Code = table.Column<string>(type: "varchar(100)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    FK_Activity_Code = table.Column<string>(type: "varchar(100)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Description_English = table.Column<string>(type: "LONGTEXT", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Description_Sinhala = table.Column<string>(type: "LONGTEXT", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Description_Tamil = table.Column<string>(type: "LONGTEXT", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    InsertedOn = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    LastModifiedOn = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    LastModifiedBy = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_m_product_instructions", x => new { x.FK_Product_Code, x.FK_Activity_Code });
                    table.ForeignKey(
                        name: "FK_m_product_instructions_m_activity_FK_Activity_Code",
                        column: x => x.FK_Activity_Code,
                        principalTable: "m_activity",
                        principalColumn: "Code",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_m_product_instructions_m_product_FK_Product_Code",
                        column: x => x.FK_Product_Code,
                        principalTable: "m_product",
                        principalColumn: "Code",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "t_crop_record_book",
                columns: table => new
                {
                    Code = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    FK_UserID = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    FK_Product_Code = table.Column<string>(type: "varchar(100)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Farming_Location_Area = table.Column<decimal>(type: "decimal(65,30)", nullable: false),
                    Trained_Staff_Count = table.Column<int>(type: "int", nullable: false),
                    Trainee_Staff_Count = table.Column<int>(type: "int", nullable: false),
                    Traget_Market = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    IsDeleted = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    InsertedOn = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    LastModifiedOn = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    LastModifiedBy = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_t_crop_record_book", x => x.Code);
                    table.ForeignKey(
                        name: "FK_t_crop_record_book_m_product_FK_Product_Code",
                        column: x => x.FK_Product_Code,
                        principalTable: "m_product",
                        principalColumn: "Code",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_t_crop_record_book_t_user_FK_UserID",
                        column: x => x.FK_UserID,
                        principalTable: "t_user",
                        principalColumn: "RnUserID",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "t_farming_product",
                columns: table => new
                {
                    FK_UserID = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    FK_Product_Code = table.Column<string>(type: "varchar(100)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    IsDeleted = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    InsertedOn = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    LastModifiedOn = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    LastModifiedBy = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_t_farming_product", x => new { x.FK_UserID, x.FK_Product_Code });
                    table.ForeignKey(
                        name: "FK_t_farming_product_m_product_FK_Product_Code",
                        column: x => x.FK_Product_Code,
                        principalTable: "m_product",
                        principalColumn: "Code",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_t_farming_product_t_user_FK_UserID",
                        column: x => x.FK_UserID,
                        principalTable: "t_user",
                        principalColumn: "RnUserID",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "m_supplier_item",
                columns: table => new
                {
                    Code = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    FK_Supplier_Code = table.Column<int>(type: "int", nullable: false),
                    FK_Product_Code = table.Column<string>(type: "varchar(100)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Type = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Name_Sinhala = table.Column<string>(type: "varchar(1000)", maxLength: 1000, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Name_English = table.Column<string>(type: "varchar(1000)", maxLength: 1000, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Name_Tamil = table.Column<string>(type: "varchar(1000)", maxLength: 1000, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Description = table.Column<string>(type: "mediumtext", maxLength: 5000, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    InsertedOn = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    LastModifiedOn = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    LastModifiedBy = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_m_supplier_item", x => x.Code);
                    table.ForeignKey(
                        name: "FK_m_supplier_item_m_product_FK_Product_Code",
                        column: x => x.FK_Product_Code,
                        principalTable: "m_product",
                        principalColumn: "Code");
                    table.ForeignKey(
                        name: "FK_m_supplier_item_m_supplier_FK_Supplier_Code",
                        column: x => x.FK_Supplier_Code,
                        principalTable: "m_supplier",
                        principalColumn: "Code",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "t_post_comment",
                columns: table => new
                {
                    Code = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    FK_Post_Code = table.Column<int>(type: "int", nullable: false),
                    FK_UserID = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Comment = table.Column<string>(type: "LONGTEXT", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Commented_DateTime = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    IsDeleted = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    InsertedOn = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    LastModifiedOn = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    LastModifiedBy = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_t_post_comment", x => x.Code);
                    table.ForeignKey(
                        name: "FK_t_post_comment_t_post_FK_Post_Code",
                        column: x => x.FK_Post_Code,
                        principalTable: "t_post",
                        principalColumn: "Code",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_t_post_comment_t_user_FK_UserID",
                        column: x => x.FK_UserID,
                        principalTable: "t_user",
                        principalColumn: "RnUserID",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "t_post_like",
                columns: table => new
                {
                    Code = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    FK_Post_Code = table.Column<int>(type: "int", nullable: false),
                    FK_UserID = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Liked_DateTime = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    InsertedOn = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    LastModifiedOn = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    LastModifiedBy = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_t_post_like", x => x.Code);
                    table.ForeignKey(
                        name: "FK_t_post_like_t_post_FK_Post_Code",
                        column: x => x.FK_Post_Code,
                        principalTable: "t_post",
                        principalColumn: "Code",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_t_post_like_t_user_FK_UserID",
                        column: x => x.FK_UserID,
                        principalTable: "t_user",
                        principalColumn: "RnUserID",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "t_farming_location",
                columns: table => new
                {
                    Code = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    FK_UserID = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    FK_Country_Code = table.Column<string>(type: "varchar(100)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    FK_Country_Type = table.Column<string>(type: "varchar(3)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    FK_Country_Parent = table.Column<string>(type: "varchar(100)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    IsDeleted = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    Area = table.Column<decimal>(type: "decimal(65,30)", nullable: false),
                    Area_Unit = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    InsertedOn = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    LastModifiedOn = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    LastModifiedBy = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_t_farming_location", x => x.Code);
                    table.ForeignKey(
                        name: "FK_t_farming_location_m_country_detail_FK_Country_Code_FK_Count~",
                        columns: x => new { x.FK_Country_Code, x.FK_Country_Type, x.FK_Country_Parent },
                        principalTable: "m_country_detail",
                        principalColumns: new[] { "Code", "Type", "Parent" },
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_t_farming_location_t_user_FK_UserID",
                        column: x => x.FK_UserID,
                        principalTable: "t_user",
                        principalColumn: "RnUserID",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "t_listing",
                columns: table => new
                {
                    Code = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Image = table.Column<string>(type: "varchar(200)", maxLength: 200, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    FK_Country_Code = table.Column<string>(type: "varchar(100)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    FK_Country_Type = table.Column<string>(type: "varchar(3)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    FK_Country_Parent = table.Column<string>(type: "varchar(100)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Name_Sinhala = table.Column<string>(type: "mediumtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Name_English = table.Column<string>(type: "mediumtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Name_Tamil = table.Column<string>(type: "mediumtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Group_of_Company = table.Column<string>(type: "varchar(500)", maxLength: 500, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    IsOutlet = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    Product_Category = table.Column<string>(type: "mediumtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Telephone = table.Column<string>(type: "varchar(10)", maxLength: 10, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Whatsup = table.Column<string>(type: "varchar(10)", maxLength: 10, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Address = table.Column<string>(type: "mediumtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Products_Sinhala = table.Column<string>(type: "mediumtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Products_English = table.Column<string>(type: "mediumtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Products_Tamil = table.Column<string>(type: "mediumtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Location = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    InsertedOn = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    LastModifiedOn = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    LastModifiedBy = table.Column<int>(type: "int", nullable: false),
                    InsertedBy = table.Column<int>(type: "int", nullable: false),
                    Status = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_t_listing", x => x.Code);
                    table.ForeignKey(
                        name: "FK_t_listing_m_country_detail_FK_Country_Code_FK_Country_Type_F~",
                        columns: x => new { x.FK_Country_Code, x.FK_Country_Type, x.FK_Country_Parent },
                        principalTable: "m_country_detail",
                        principalColumns: new[] { "Code", "Type", "Parent" },
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "t_plan",
                columns: table => new
                {
                    Code = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Area = table.Column<decimal>(type: "decimal(65,30)", nullable: false),
                    UOM = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Start_DateTime = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    End_DateTime = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    FK_Product_Code = table.Column<string>(type: "varchar(100)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    FK_UserID = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Inserted_DateTime = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    Last_Updated_DateTime = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    IsActive = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    FK_Country_Code = table.Column<string>(type: "varchar(100)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    FK_Country_Type = table.Column<string>(type: "varchar(3)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    FK_Country_Parent = table.Column<string>(type: "varchar(100)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Seed_Code = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    FK_Seed_Supplier_Code = table.Column<int>(type: "int", nullable: true),
                    InsertedOn = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    LastModifiedOn = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    LastModifiedBy = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_t_plan", x => x.Code);
                    table.ForeignKey(
                        name: "FK_t_plan_m_country_detail_FK_Country_Code_FK_Country_Type_FK_C~",
                        columns: x => new { x.FK_Country_Code, x.FK_Country_Type, x.FK_Country_Parent },
                        principalTable: "m_country_detail",
                        principalColumns: new[] { "Code", "Type", "Parent" });
                    table.ForeignKey(
                        name: "FK_t_plan_m_product_FK_Product_Code",
                        column: x => x.FK_Product_Code,
                        principalTable: "m_product",
                        principalColumn: "Code",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_t_plan_m_supplier_FK_Seed_Supplier_Code",
                        column: x => x.FK_Seed_Supplier_Code,
                        principalTable: "m_supplier",
                        principalColumn: "Code");
                    table.ForeignKey(
                        name: "FK_t_plan_t_user_FK_UserID",
                        column: x => x.FK_UserID,
                        principalTable: "t_user",
                        principalColumn: "RnUserID",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "t_sell",
                columns: table => new
                {
                    Code = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Quantity = table.Column<decimal>(type: "decimal(65,30)", nullable: false),
                    Unit_Price = table.Column<decimal>(type: "decimal(65,30)", nullable: false),
                    UOM = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Available_DateTime = table.Column<DateTime>(type: "datetime(6)", nullable: true),
                    Expired_DateTime = table.Column<DateTime>(type: "datetime(6)", nullable: true),
                    FK_Product_Code = table.Column<string>(type: "varchar(100)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    FK_UserID = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    IsActive = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    FK_Country_Code = table.Column<string>(type: "varchar(100)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    FK_Country_Type = table.Column<string>(type: "varchar(3)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    FK_Country_Parent = table.Column<string>(type: "varchar(100)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Remark = table.Column<string>(type: "mediumtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Image01 = table.Column<string>(type: "varchar(200)", maxLength: 200, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Image02 = table.Column<string>(type: "varchar(200)", maxLength: 200, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Image03 = table.Column<string>(type: "varchar(200)", maxLength: 200, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Image04 = table.Column<string>(type: "varchar(200)", maxLength: 200, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Ref_PlantID = table.Column<int>(type: "int", nullable: false),
                    Inserted_DateTime = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    Last_Updated_DateTime = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    InsertedOn = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    LastModifiedOn = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    LastModifiedBy = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_t_sell", x => x.Code);
                    table.ForeignKey(
                        name: "FK_t_sell_m_country_detail_FK_Country_Code_FK_Country_Type_FK_C~",
                        columns: x => new { x.FK_Country_Code, x.FK_Country_Type, x.FK_Country_Parent },
                        principalTable: "m_country_detail",
                        principalColumns: new[] { "Code", "Type", "Parent" },
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_t_sell_m_product_FK_Product_Code",
                        column: x => x.FK_Product_Code,
                        principalTable: "m_product",
                        principalColumn: "Code",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_t_sell_t_user_FK_UserID",
                        column: x => x.FK_UserID,
                        principalTable: "t_user",
                        principalColumn: "RnUserID",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "t_crb_diseases_control_method",
                columns: table => new
                {
                    Code = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    FK_CRB_Code = table.Column<int>(type: "int", nullable: false),
                    Crop_Area = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Category = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Pest_Name = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Liquid_Name = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Is_Registered_Pesticide = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    Recommended_Company_Name = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Applied_Quantity = table.Column<decimal>(type: "decimal(65,30)", nullable: false),
                    Applied_Date = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    Applied_Method = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Batch_Code = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Applied_Person_Name = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Purchase_Method = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    IsDeleted = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    InsertedOn = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    LastModifiedOn = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    LastModifiedBy = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_t_crb_diseases_control_method", x => x.Code);
                    table.ForeignKey(
                        name: "FK_t_crb_diseases_control_method_t_crop_record_book_FK_CRB_Code",
                        column: x => x.FK_CRB_Code,
                        principalTable: "t_crop_record_book",
                        principalColumn: "Code",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "t_crb_employee_training_report",
                columns: table => new
                {
                    Code = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    FK_CRB_Code = table.Column<int>(type: "int", nullable: false),
                    Training_Name = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Time_Frame = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Trainee_Name = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Train_Company = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Is_Paid = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    IsDeleted = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    InsertedOn = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    LastModifiedOn = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    LastModifiedBy = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_t_crb_employee_training_report", x => x.Code);
                    table.ForeignKey(
                        name: "FK_t_crb_employee_training_report_t_crop_record_book_FK_CRB_Code",
                        column: x => x.FK_CRB_Code,
                        principalTable: "t_crop_record_book",
                        principalColumn: "Code",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "t_crb_harvest_activity_detail",
                columns: table => new
                {
                    Code = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    FK_CRB_Code = table.Column<int>(type: "int", nullable: false),
                    Harvest_Date = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    Product_Name = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Batch_Code = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Harvest_Quantity = table.Column<decimal>(type: "decimal(65,30)", nullable: false),
                    Harvest_After_Production_Quantity = table.Column<decimal>(type: "decimal(65,30)", nullable: false),
                    Export_Quantity = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Local_Market_Quantity = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Other_Applies = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    IsDeleted = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    InsertedOn = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    LastModifiedOn = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    LastModifiedBy = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_t_crb_harvest_activity_detail", x => x.Code);
                    table.ForeignKey(
                        name: "FK_t_crb_harvest_activity_detail_t_crop_record_book_FK_CRB_Code",
                        column: x => x.FK_CRB_Code,
                        principalTable: "t_crop_record_book",
                        principalColumn: "Code",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "t_crb_has_additional_fertilizer_detail",
                columns: table => new
                {
                    Code = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    FK_CRB_Code = table.Column<int>(type: "int", nullable: false),
                    Is_Organic_Fertilizer = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    Applied_Date = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    Organic_Type = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Applied_Product = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Voulme = table.Column<decimal>(type: "decimal(65,30)", nullable: false),
                    Applied_Method = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Batch_No = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Applied_Person_Name = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Recommended_Company = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    IsDeleted = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    InsertedOn = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    LastModifiedOn = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    LastModifiedBy = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_t_crb_has_additional_fertilizer_detail", x => x.Code);
                    table.ForeignKey(
                        name: "FK_t_crb_has_additional_fertilizer_detail_t_crop_record_book_FK~",
                        column: x => x.FK_CRB_Code,
                        principalTable: "t_crop_record_book",
                        principalColumn: "Code",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "t_crb_has_chemical_detail",
                columns: table => new
                {
                    Code = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    FK_CRB_Code = table.Column<int>(type: "int", nullable: false),
                    Control_Type = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Veed_Name = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Chemical_Name = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Applied_Date = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    Volume = table.Column<decimal>(type: "decimal(65,30)", nullable: false),
                    Applied_Method = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Recommended_Company = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Applied_Person_Name = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Batch_No = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Is_Registed_Herbicide = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    IsDeleted = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    InsertedOn = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    LastModifiedOn = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    LastModifiedBy = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_t_crb_has_chemical_detail", x => x.Code);
                    table.ForeignKey(
                        name: "FK_t_crb_has_chemical_detail_t_crop_record_book_FK_CRB_Code",
                        column: x => x.FK_CRB_Code,
                        principalTable: "t_crop_record_book",
                        principalColumn: "Code",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "t_crb_has_combined_pest_control_detail",
                columns: table => new
                {
                    Code = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    FK_CRB_Code = table.Column<int>(type: "int", nullable: false),
                    Is_Infection_Resistors = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    Is_Area_Specific_Seed = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    Is_Disease_Free_Seeds = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    Is_Recommended_Land_Prep = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    Is_Recommended_Distance = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    Is_Recommended_Fertilizer = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    Is_Recommended_Plantation = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    Is_Fence = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    Is_Successful_Veed_Removal = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    Is_Remove_Infected_Plants = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    Is_Ontime_Crop_Harvesting = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    IsDeleted = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    InsertedOn = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    LastModifiedOn = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    LastModifiedBy = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_t_crb_has_combined_pest_control_detail", x => x.Code);
                    table.ForeignKey(
                        name: "FK_t_crb_has_combined_pest_control_detail_t_crop_record_book_FK~",
                        column: x => x.FK_CRB_Code,
                        principalTable: "t_crop_record_book",
                        principalColumn: "Code",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "t_crb_has_fertilizer_detail",
                columns: table => new
                {
                    Code = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    FK_CRB_Code = table.Column<int>(type: "int", nullable: false),
                    Purchased_Date = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    Fertilizer_Type = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Volume = table.Column<decimal>(type: "decimal(65,30)", nullable: false),
                    Purcahsed_Location = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Manufacturer = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Batch_No = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    IsDeleted = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    InsertedOn = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    LastModifiedOn = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    LastModifiedBy = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_t_crb_has_fertilizer_detail", x => x.Code);
                    table.ForeignKey(
                        name: "FK_t_crb_has_fertilizer_detail_t_crop_record_book_FK_CRB_Code",
                        column: x => x.FK_CRB_Code,
                        principalTable: "t_crop_record_book",
                        principalColumn: "Code",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "t_crb_has_material_purchase",
                columns: table => new
                {
                    Code = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    FK_CRB_Code = table.Column<int>(type: "int", nullable: false),
                    Purchase_Date = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    Material_Type = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Volume = table.Column<decimal>(type: "decimal(65,30)", nullable: false),
                    Purchased_Location = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Batch_No = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Manufacture_Date = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    Expired_Date = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Manufacturer = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    IsDeleted = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    InsertedOn = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    LastModifiedOn = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    LastModifiedBy = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_t_crb_has_material_purchase", x => x.Code);
                    table.ForeignKey(
                        name: "FK_t_crb_has_material_purchase_t_crop_record_book_FK_CRB_Code",
                        column: x => x.FK_CRB_Code,
                        principalTable: "t_crop_record_book",
                        principalColumn: "Code",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "t_crb_has_planting_material",
                columns: table => new
                {
                    Code = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    FK_CRB_Code = table.Column<int>(type: "int", nullable: false),
                    Planted_Date = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    Product_Name = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Is_Pataka_Ropanaya = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    Area = table.Column<decimal>(type: "decimal(65,30)", nullable: false),
                    Ropana_Treatment = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Ropana_Purchase_Supplier = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Ropana_Certification_and_Body = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    IsDeleted = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    InsertedOn = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    LastModifiedOn = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    LastModifiedBy = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_t_crb_has_planting_material", x => x.Code);
                    table.ForeignKey(
                        name: "FK_t_crb_has_planting_material_t_crop_record_book_FK_CRB_Code",
                        column: x => x.FK_CRB_Code,
                        principalTable: "t_crop_record_book",
                        principalColumn: "Code",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "t_crb_has_seed_report",
                columns: table => new
                {
                    Code = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    FK_CRB_Code = table.Column<int>(type: "int", nullable: false),
                    Plantation_Date = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    Seed_Name = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Is_Seed_Hybrid = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    Area = table.Column<decimal>(type: "decimal(65,30)", nullable: false),
                    Seed_Cert_Detail = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Seed_Treatment_Detail = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    IsDeleted = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    InsertedOn = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    LastModifiedOn = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    LastModifiedBy = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_t_crb_has_seed_report", x => x.Code);
                    table.ForeignKey(
                        name: "FK_t_crb_has_seed_report_t_crop_record_book_FK_CRB_Code",
                        column: x => x.FK_CRB_Code,
                        principalTable: "t_crop_record_book",
                        principalColumn: "Code",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "t_crb_irrigation_detail",
                columns: table => new
                {
                    Code = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    FK_CRB_Code = table.Column<int>(type: "int", nullable: false),
                    Is_Water_Flow_Through_Valid_Places = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    Is_Valid_Water_Sources = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    Is_Chemical_Risky = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    Is_Chemical_Research_Done = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    IsDeleted = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    InsertedOn = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    LastModifiedOn = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    LastModifiedBy = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_t_crb_irrigation_detail", x => x.Code);
                    table.ForeignKey(
                        name: "FK_t_crb_irrigation_detail_t_crop_record_book_FK_CRB_Code",
                        column: x => x.FK_CRB_Code,
                        principalTable: "t_crop_record_book",
                        principalColumn: "Code",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "t_crb_irrigation_report",
                columns: table => new
                {
                    Code = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    FK_CRB_Code = table.Column<int>(type: "int", nullable: false),
                    Applied_Date = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    Crop_Area = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Irrigation_Method = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Water_Applied_Method = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Batch_Code = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Applied_Person_Name = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    IsDeleted = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    InsertedOn = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    LastModifiedOn = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    LastModifiedBy = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_t_crb_irrigation_report", x => x.Code);
                    table.ForeignKey(
                        name: "FK_t_crb_irrigation_report_t_crop_record_book_FK_CRB_Code",
                        column: x => x.FK_CRB_Code,
                        principalTable: "t_crop_record_book",
                        principalColumn: "Code",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "t_crb_location_detail",
                columns: table => new
                {
                    FK_CRB_Code = table.Column<int>(type: "int", nullable: false),
                    Land_Ownership = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Land_Ownership_Other_Text = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Is_Plantation_History_Ok = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    Is_Cultivatability_Ok = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    Is_Cultivatability_Applied = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    Is_Previously_Cultivated = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    Is_Soil_Tested = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    Previously_Cultivated_Product = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Previously_Used_Chemical = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    IsDeleted = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    InsertedOn = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    LastModifiedOn = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    LastModifiedBy = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_t_crb_location_detail", x => x.FK_CRB_Code);
                    table.ForeignKey(
                        name: "FK_t_crb_location_detail_t_crop_record_book_FK_CRB_Code",
                        column: x => x.FK_CRB_Code,
                        principalTable: "t_crop_record_book",
                        principalColumn: "Code",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "t_crb_wast_harvest_record",
                columns: table => new
                {
                    Code = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    FK_CRB_Code = table.Column<int>(type: "int", nullable: false),
                    Record_Date = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    Product_Name = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Wast_Quantity = table.Column<decimal>(type: "decimal(65,30)", nullable: false),
                    Reason = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    IsDeleted = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    InsertedOn = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    LastModifiedOn = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    LastModifiedBy = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_t_crb_wast_harvest_record", x => x.Code);
                    table.ForeignKey(
                        name: "FK_t_crb_wast_harvest_record_t_crop_record_book_FK_CRB_Code",
                        column: x => x.FK_CRB_Code,
                        principalTable: "t_crop_record_book",
                        principalColumn: "Code",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "t_plan_detail",
                columns: table => new
                {
                    Code = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    FK_PlanID = table.Column<int>(type: "int", nullable: false),
                    FK_Activity = table.Column<string>(type: "varchar(100)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Start_Duration = table.Column<int>(type: "int", nullable: false),
                    End_Duration = table.Column<int>(type: "int", nullable: false),
                    IsActive = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    InsertedOn = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    LastModifiedOn = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    LastModifiedBy = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_t_plan_detail", x => x.Code);
                    table.ForeignKey(
                        name: "FK_t_plan_detail_m_activity_FK_Activity",
                        column: x => x.FK_Activity,
                        principalTable: "m_activity",
                        principalColumn: "Code",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_t_plan_detail_t_plan_FK_PlanID",
                        column: x => x.FK_PlanID,
                        principalTable: "t_plan",
                        principalColumn: "Code",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "t_inquiry",
                columns: table => new
                {
                    Code = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    FK_Sell_Code = table.Column<int>(type: "int", nullable: false),
                    Quantity = table.Column<decimal>(type: "decimal(65,30)", nullable: false),
                    FK_UserID = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    InquiryInDetail = table.Column<string>(type: "mediumtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    IsDeleted = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    IsAccept = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    InsertedOn = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    LastModifiedOn = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    LastModifiedBy = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_t_inquiry", x => x.Code);
                    table.ForeignKey(
                        name: "FK_t_inquiry_t_sell_FK_Sell_Code",
                        column: x => x.FK_Sell_Code,
                        principalTable: "t_sell",
                        principalColumn: "Code",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_t_inquiry_t_user_FK_UserID",
                        column: x => x.FK_UserID,
                        principalTable: "t_user",
                        principalColumn: "RnUserID",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "t_order_detail",
                columns: table => new
                {
                    Code = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    FK_HeaderID = table.Column<int>(type: "int", nullable: false),
                    FK_Sell_Code = table.Column<int>(type: "int", nullable: false),
                    Quantity = table.Column<decimal>(type: "decimal(65,30)", nullable: false),
                    UOM = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Unit_Price = table.Column<decimal>(type: "decimal(65,30)", nullable: false),
                    InsertedOn = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    LastModifiedOn = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    LastModifiedBy = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_t_order_detail", x => x.Code);
                    table.ForeignKey(
                        name: "FK_t_order_detail_t_order_header_FK_HeaderID",
                        column: x => x.FK_HeaderID,
                        principalTable: "t_order_header",
                        principalColumn: "Code",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_t_order_detail_t_sell_FK_Sell_Code",
                        column: x => x.FK_Sell_Code,
                        principalTable: "t_sell",
                        principalColumn: "Code",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "t_sell_rate",
                columns: table => new
                {
                    Code = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    FK_Sell_Code = table.Column<int>(type: "int", nullable: false),
                    FK_UserID = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Rate = table.Column<int>(type: "int", nullable: false),
                    Comment = table.Column<string>(type: "LONGTEXT", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    InsertedOn = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    LastModifiedOn = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    LastModifiedBy = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_t_sell_rate", x => x.Code);
                    table.ForeignKey(
                        name: "FK_t_sell_rate_t_sell_FK_Sell_Code",
                        column: x => x.FK_Sell_Code,
                        principalTable: "t_sell",
                        principalColumn: "Code",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_t_sell_rate_t_user_FK_UserID",
                        column: x => x.FK_UserID,
                        principalTable: "t_user",
                        principalColumn: "RnUserID",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "t_temp_shopping_cart",
                columns: table => new
                {
                    Code = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Quantity = table.Column<decimal>(type: "decimal(65,30)", nullable: false),
                    FK_BuyerID = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    FK_Sell_Code = table.Column<int>(type: "int", nullable: false),
                    InsertedOn = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    LastModifiedOn = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    LastModifiedBy = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_t_temp_shopping_cart", x => x.Code);
                    table.ForeignKey(
                        name: "FK_t_temp_shopping_cart_t_sell_FK_Sell_Code",
                        column: x => x.FK_Sell_Code,
                        principalTable: "t_sell",
                        principalColumn: "Code",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_t_temp_shopping_cart_t_user_FK_BuyerID",
                        column: x => x.FK_BuyerID,
                        principalTable: "t_user",
                        principalColumn: "RnUserID",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "t_wishList",
                columns: table => new
                {
                    FK_Sell_Code = table.Column<int>(type: "int", nullable: false),
                    FK_UserID = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    InsertedOn = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    LastModifiedOn = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    LastModifiedBy = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_t_wishList", x => new { x.FK_Sell_Code, x.FK_UserID });
                    table.ForeignKey(
                        name: "FK_t_wishList_t_sell_FK_Sell_Code",
                        column: x => x.FK_Sell_Code,
                        principalTable: "t_sell",
                        principalColumn: "Code",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_t_wishList_t_user_FK_UserID",
                        column: x => x.FK_UserID,
                        principalTable: "t_user",
                        principalColumn: "RnUserID",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "t_inquiry_has_message",
                columns: table => new
                {
                    Code = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    FK_Inquiry = table.Column<int>(type: "int", nullable: false),
                    FK_UserID = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Message = table.Column<string>(type: "mediumtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    IsDeleted = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    InsertedOn = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    LastModifiedOn = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    LastModifiedBy = table.Column<int>(type: "int", nullable: false),
                    IsView = table.Column<bool>(type: "tinyint(1)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_t_inquiry_has_message", x => x.Code);
                    table.ForeignKey(
                        name: "FK_t_inquiry_has_message_t_inquiry_FK_Inquiry",
                        column: x => x.FK_Inquiry,
                        principalTable: "t_inquiry",
                        principalColumn: "Code",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_t_inquiry_has_message_t_user_FK_UserID",
                        column: x => x.FK_UserID,
                        principalTable: "t_user",
                        principalColumn: "RnUserID",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateIndex(
                name: "IX_m_advisory_FK_Activity_Code",
                table: "m_advisory",
                column: "FK_Activity_Code");

            migrationBuilder.CreateIndex(
                name: "IX_m_advisory_FK_Product_Code",
                table: "m_advisory",
                column: "FK_Product_Code");

            migrationBuilder.CreateIndex(
                name: "IX_m_advisory_Start_Duration",
                table: "m_advisory",
                column: "Start_Duration");

            migrationBuilder.CreateIndex(
                name: "IX_m_country_detail_FK_Country_Code",
                table: "m_country_detail",
                column: "FK_Country_Code");

            migrationBuilder.CreateIndex(
                name: "IX_m_library_has_post_FK_Library_Group",
                table: "m_library_has_post",
                column: "FK_Library_Group");

            migrationBuilder.CreateIndex(
                name: "IX_m_library_has_post_FK_UserID",
                table: "m_library_has_post",
                column: "FK_UserID");

            migrationBuilder.CreateIndex(
                name: "IX_m_product_instructions_FK_Activity_Code",
                table: "m_product_instructions",
                column: "FK_Activity_Code");

            migrationBuilder.CreateIndex(
                name: "IX_m_supplier_item_FK_Product_Code",
                table: "m_supplier_item",
                column: "FK_Product_Code");

            migrationBuilder.CreateIndex(
                name: "IX_m_supplier_item_FK_Supplier_Code",
                table: "m_supplier_item",
                column: "FK_Supplier_Code");

            migrationBuilder.CreateIndex(
                name: "IX_t_apptoken_FK_UserID",
                table: "t_apptoken",
                column: "FK_UserID");

            migrationBuilder.CreateIndex(
                name: "IX_t_blog_FK_UserID",
                table: "t_blog",
                column: "FK_UserID");

            migrationBuilder.CreateIndex(
                name: "IX_t_crb_diseases_control_method_FK_CRB_Code",
                table: "t_crb_diseases_control_method",
                column: "FK_CRB_Code");

            migrationBuilder.CreateIndex(
                name: "IX_t_crb_employee_training_report_FK_CRB_Code",
                table: "t_crb_employee_training_report",
                column: "FK_CRB_Code");

            migrationBuilder.CreateIndex(
                name: "IX_t_crb_harvest_activity_detail_FK_CRB_Code",
                table: "t_crb_harvest_activity_detail",
                column: "FK_CRB_Code");

            migrationBuilder.CreateIndex(
                name: "IX_t_crb_has_additional_fertilizer_detail_FK_CRB_Code",
                table: "t_crb_has_additional_fertilizer_detail",
                column: "FK_CRB_Code");

            migrationBuilder.CreateIndex(
                name: "IX_t_crb_has_chemical_detail_FK_CRB_Code",
                table: "t_crb_has_chemical_detail",
                column: "FK_CRB_Code");

            migrationBuilder.CreateIndex(
                name: "IX_t_crb_has_combined_pest_control_detail_FK_CRB_Code",
                table: "t_crb_has_combined_pest_control_detail",
                column: "FK_CRB_Code");

            migrationBuilder.CreateIndex(
                name: "IX_t_crb_has_fertilizer_detail_FK_CRB_Code",
                table: "t_crb_has_fertilizer_detail",
                column: "FK_CRB_Code");

            migrationBuilder.CreateIndex(
                name: "IX_t_crb_has_material_purchase_FK_CRB_Code",
                table: "t_crb_has_material_purchase",
                column: "FK_CRB_Code");

            migrationBuilder.CreateIndex(
                name: "IX_t_crb_has_planting_material_FK_CRB_Code",
                table: "t_crb_has_planting_material",
                column: "FK_CRB_Code");

            migrationBuilder.CreateIndex(
                name: "IX_t_crb_has_seed_report_FK_CRB_Code",
                table: "t_crb_has_seed_report",
                column: "FK_CRB_Code");

            migrationBuilder.CreateIndex(
                name: "IX_t_crb_irrigation_detail_FK_CRB_Code",
                table: "t_crb_irrigation_detail",
                column: "FK_CRB_Code");

            migrationBuilder.CreateIndex(
                name: "IX_t_crb_irrigation_report_FK_CRB_Code",
                table: "t_crb_irrigation_report",
                column: "FK_CRB_Code");

            migrationBuilder.CreateIndex(
                name: "IX_t_crb_wast_harvest_record_FK_CRB_Code",
                table: "t_crb_wast_harvest_record",
                column: "FK_CRB_Code");

            migrationBuilder.CreateIndex(
                name: "IX_t_crop_record_book_FK_Product_Code",
                table: "t_crop_record_book",
                column: "FK_Product_Code");

            migrationBuilder.CreateIndex(
                name: "IX_t_crop_record_book_FK_UserID",
                table: "t_crop_record_book",
                column: "FK_UserID");

            migrationBuilder.CreateIndex(
                name: "IX_t_farming_location_FK_Country_Code_FK_Country_Type_FK_Countr~",
                table: "t_farming_location",
                columns: new[] { "FK_Country_Code", "FK_Country_Type", "FK_Country_Parent" });

            migrationBuilder.CreateIndex(
                name: "IX_t_farming_location_FK_UserID",
                table: "t_farming_location",
                column: "FK_UserID");

            migrationBuilder.CreateIndex(
                name: "IX_t_farming_product_FK_Product_Code",
                table: "t_farming_product",
                column: "FK_Product_Code");

            migrationBuilder.CreateIndex(
                name: "IX_t_inquiry_FK_Sell_Code",
                table: "t_inquiry",
                column: "FK_Sell_Code");

            migrationBuilder.CreateIndex(
                name: "IX_t_inquiry_FK_UserID",
                table: "t_inquiry",
                column: "FK_UserID");

            migrationBuilder.CreateIndex(
                name: "IX_t_inquiry_has_message_FK_Inquiry",
                table: "t_inquiry_has_message",
                column: "FK_Inquiry");

            migrationBuilder.CreateIndex(
                name: "IX_t_inquiry_has_message_FK_UserID",
                table: "t_inquiry_has_message",
                column: "FK_UserID");

            migrationBuilder.CreateIndex(
                name: "IX_t_listing_FK_Country_Code_FK_Country_Type_FK_Country_Parent",
                table: "t_listing",
                columns: new[] { "FK_Country_Code", "FK_Country_Type", "FK_Country_Parent" });

            migrationBuilder.CreateIndex(
                name: "IX_t_notification_FK_UserID",
                table: "t_notification",
                column: "FK_UserID");

            migrationBuilder.CreateIndex(
                name: "IX_t_order_detail_FK_HeaderID",
                table: "t_order_detail",
                column: "FK_HeaderID");

            migrationBuilder.CreateIndex(
                name: "IX_t_order_detail_FK_Sell_Code",
                table: "t_order_detail",
                column: "FK_Sell_Code");

            migrationBuilder.CreateIndex(
                name: "IX_t_order_header_FK_Buyer_UserID",
                table: "t_order_header",
                column: "FK_Buyer_UserID");

            migrationBuilder.CreateIndex(
                name: "IX_t_plan_FK_Country_Code_FK_Country_Type_FK_Country_Parent",
                table: "t_plan",
                columns: new[] { "FK_Country_Code", "FK_Country_Type", "FK_Country_Parent" });

            migrationBuilder.CreateIndex(
                name: "IX_t_plan_FK_Product_Code",
                table: "t_plan",
                column: "FK_Product_Code");

            migrationBuilder.CreateIndex(
                name: "IX_t_plan_FK_Seed_Supplier_Code",
                table: "t_plan",
                column: "FK_Seed_Supplier_Code");

            migrationBuilder.CreateIndex(
                name: "IX_t_plan_FK_UserID",
                table: "t_plan",
                column: "FK_UserID");

            migrationBuilder.CreateIndex(
                name: "IX_t_plan_detail_FK_Activity",
                table: "t_plan_detail",
                column: "FK_Activity");

            migrationBuilder.CreateIndex(
                name: "IX_t_plan_detail_FK_PlanID",
                table: "t_plan_detail",
                column: "FK_PlanID");

            migrationBuilder.CreateIndex(
                name: "IX_t_post_FK_UserID",
                table: "t_post",
                column: "FK_UserID");

            migrationBuilder.CreateIndex(
                name: "IX_t_post_comment_FK_Post_Code",
                table: "t_post_comment",
                column: "FK_Post_Code");

            migrationBuilder.CreateIndex(
                name: "IX_t_post_comment_FK_UserID",
                table: "t_post_comment",
                column: "FK_UserID");

            migrationBuilder.CreateIndex(
                name: "IX_t_post_like_FK_Post_Code",
                table: "t_post_like",
                column: "FK_Post_Code");

            migrationBuilder.CreateIndex(
                name: "IX_t_post_like_FK_UserID",
                table: "t_post_like",
                column: "FK_UserID");

            migrationBuilder.CreateIndex(
                name: "IX_t_sell_FK_Country_Code_FK_Country_Type_FK_Country_Parent",
                table: "t_sell",
                columns: new[] { "FK_Country_Code", "FK_Country_Type", "FK_Country_Parent" });

            migrationBuilder.CreateIndex(
                name: "IX_t_sell_FK_Product_Code",
                table: "t_sell",
                column: "FK_Product_Code");

            migrationBuilder.CreateIndex(
                name: "IX_t_sell_FK_UserID",
                table: "t_sell",
                column: "FK_UserID");

            migrationBuilder.CreateIndex(
                name: "IX_t_sell_rate_FK_Sell_Code",
                table: "t_sell_rate",
                column: "FK_Sell_Code");

            migrationBuilder.CreateIndex(
                name: "IX_t_sell_rate_FK_UserID",
                table: "t_sell_rate",
                column: "FK_UserID");

            migrationBuilder.CreateIndex(
                name: "IX_t_temp_shopping_cart_FK_BuyerID",
                table: "t_temp_shopping_cart",
                column: "FK_BuyerID");

            migrationBuilder.CreateIndex(
                name: "IX_t_temp_shopping_cart_FK_Sell_Code",
                table: "t_temp_shopping_cart",
                column: "FK_Sell_Code");

            migrationBuilder.CreateIndex(
                name: "IX_t_wishList_FK_UserID",
                table: "t_wishList",
                column: "FK_UserID");

            migrationBuilder.AddForeignKey(
                name: "FK_RefreshToken_t_user_AppUserId",
                table: "RefreshToken",
                column: "AppUserId",
                principalTable: "t_user",
                principalColumn: "RnUserID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Tbl_Role_Claims_Tbl_Role_RoleId",
                table: "Tbl_Role_Claims",
                column: "RoleId",
                principalTable: "Tbl_Role",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Tbl_User_Claims_t_user_UserId",
                table: "Tbl_User_Claims",
                column: "UserId",
                principalTable: "t_user",
                principalColumn: "RnUserID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Tbl_User_Login_t_user_UserId",
                table: "Tbl_User_Login",
                column: "UserId",
                principalTable: "t_user",
                principalColumn: "RnUserID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Tbl_User_Role_Tbl_Role_RoleId",
                table: "Tbl_User_Role",
                column: "RoleId",
                principalTable: "Tbl_Role",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Tbl_User_Role_t_user_UserId",
                table: "Tbl_User_Role",
                column: "UserId",
                principalTable: "t_user",
                principalColumn: "RnUserID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Tbl_User_Token_t_user_UserId",
                table: "Tbl_User_Token",
                column: "UserId",
                principalTable: "t_user",
                principalColumn: "RnUserID",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_RefreshToken_t_user_AppUserId",
                table: "RefreshToken");

            migrationBuilder.DropForeignKey(
                name: "FK_Tbl_Role_Claims_Tbl_Role_RoleId",
                table: "Tbl_Role_Claims");

            migrationBuilder.DropForeignKey(
                name: "FK_Tbl_User_Claims_t_user_UserId",
                table: "Tbl_User_Claims");

            migrationBuilder.DropForeignKey(
                name: "FK_Tbl_User_Login_t_user_UserId",
                table: "Tbl_User_Login");

            migrationBuilder.DropForeignKey(
                name: "FK_Tbl_User_Role_Tbl_Role_RoleId",
                table: "Tbl_User_Role");

            migrationBuilder.DropForeignKey(
                name: "FK_Tbl_User_Role_t_user_UserId",
                table: "Tbl_User_Role");

            migrationBuilder.DropForeignKey(
                name: "FK_Tbl_User_Token_t_user_UserId",
                table: "Tbl_User_Token");

            migrationBuilder.DropTable(
                name: "m_advisory");

            migrationBuilder.DropTable(
                name: "m_harvest_calendar");

            migrationBuilder.DropTable(
                name: "m_library_has_post");

            migrationBuilder.DropTable(
                name: "m_product_instructions");

            migrationBuilder.DropTable(
                name: "m_supplier_item");

            migrationBuilder.DropTable(
                name: "t_apptoken");

            migrationBuilder.DropTable(
                name: "t_blog");

            migrationBuilder.DropTable(
                name: "t_crb_diseases_control_method");

            migrationBuilder.DropTable(
                name: "t_crb_employee_training_report");

            migrationBuilder.DropTable(
                name: "t_crb_harvest_activity_detail");

            migrationBuilder.DropTable(
                name: "t_crb_has_additional_fertilizer_detail");

            migrationBuilder.DropTable(
                name: "t_crb_has_chemical_detail");

            migrationBuilder.DropTable(
                name: "t_crb_has_combined_pest_control_detail");

            migrationBuilder.DropTable(
                name: "t_crb_has_fertilizer_detail");

            migrationBuilder.DropTable(
                name: "t_crb_has_material_purchase");

            migrationBuilder.DropTable(
                name: "t_crb_has_planting_material");

            migrationBuilder.DropTable(
                name: "t_crb_has_seed_report");

            migrationBuilder.DropTable(
                name: "t_crb_irrigation_detail");

            migrationBuilder.DropTable(
                name: "t_crb_irrigation_report");

            migrationBuilder.DropTable(
                name: "t_crb_location_detail");

            migrationBuilder.DropTable(
                name: "t_crb_wast_harvest_record");

            migrationBuilder.DropTable(
                name: "t_farming_location");

            migrationBuilder.DropTable(
                name: "t_farming_product");

            migrationBuilder.DropTable(
                name: "t_inquiry_has_message");

            migrationBuilder.DropTable(
                name: "t_listing");

            migrationBuilder.DropTable(
                name: "t_notification");

            migrationBuilder.DropTable(
                name: "t_order_detail");

            migrationBuilder.DropTable(
                name: "t_plan_detail");

            migrationBuilder.DropTable(
                name: "t_post_comment");

            migrationBuilder.DropTable(
                name: "t_post_like");

            migrationBuilder.DropTable(
                name: "t_sell_rate");

            migrationBuilder.DropTable(
                name: "t_subscribe");

            migrationBuilder.DropTable(
                name: "t_temp_shopping_cart");

            migrationBuilder.DropTable(
                name: "t_wishList");

            migrationBuilder.DropTable(
                name: "m_library_has_group");

            migrationBuilder.DropTable(
                name: "t_crop_record_book");

            migrationBuilder.DropTable(
                name: "t_inquiry");

            migrationBuilder.DropTable(
                name: "t_order_header");

            migrationBuilder.DropTable(
                name: "m_activity");

            migrationBuilder.DropTable(
                name: "t_plan");

            migrationBuilder.DropTable(
                name: "t_post");

            migrationBuilder.DropTable(
                name: "t_sell");

            migrationBuilder.DropTable(
                name: "m_supplier");

            migrationBuilder.DropTable(
                name: "m_country_detail");

            migrationBuilder.DropTable(
                name: "m_product");

            migrationBuilder.DropTable(
                name: "m_country");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Tbl_User_Token",
                table: "Tbl_User_Token");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Tbl_User_Role",
                table: "Tbl_User_Role");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Tbl_User_Login",
                table: "Tbl_User_Login");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Tbl_User_Claims",
                table: "Tbl_User_Claims");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Tbl_Role_Claims",
                table: "Tbl_Role_Claims");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Tbl_Role",
                table: "Tbl_Role");

            migrationBuilder.DropPrimaryKey(
                name: "PK_t_user",
                table: "t_user");

            migrationBuilder.DropColumn(
                name: "Country",
                table: "t_user");

            migrationBuilder.DropColumn(
                name: "District",
                table: "t_user");

            migrationBuilder.DropColumn(
                name: "Division",
                table: "t_user");

            migrationBuilder.DropColumn(
                name: "GramasewaDivision",
                table: "t_user");

            migrationBuilder.DropColumn(
                name: "IdentificationID",
                table: "t_user");

            migrationBuilder.DropColumn(
                name: "IdentificationType",
                table: "t_user");

            migrationBuilder.DropColumn(
                name: "Incorporation",
                table: "t_user");

            migrationBuilder.DropColumn(
                name: "IncorporationNo",
                table: "t_user");

            migrationBuilder.DropColumn(
                name: "InsertedOn",
                table: "t_user");

            migrationBuilder.DropColumn(
                name: "IsActive",
                table: "t_user");

            migrationBuilder.DropColumn(
                name: "LastModifiedBy",
                table: "t_user");

            migrationBuilder.DropColumn(
                name: "LastModifiedOn",
                table: "t_user");

            migrationBuilder.DropColumn(
                name: "Name",
                table: "t_user");

            migrationBuilder.DropColumn(
                name: "PostalCode",
                table: "t_user");

            migrationBuilder.DropColumn(
                name: "ProfileImage",
                table: "t_user");

            migrationBuilder.DropColumn(
                name: "Province",
                table: "t_user");

            migrationBuilder.DropColumn(
                name: "Remark",
                table: "t_user");

            migrationBuilder.DropColumn(
                name: "StoreName",
                table: "t_user");

            migrationBuilder.RenameTable(
                name: "Tbl_User_Token",
                newName: "AspNetUserTokens");

            migrationBuilder.RenameTable(
                name: "Tbl_User_Role",
                newName: "AspNetUserRoles");

            migrationBuilder.RenameTable(
                name: "Tbl_User_Login",
                newName: "AspNetUserLogins");

            migrationBuilder.RenameTable(
                name: "Tbl_User_Claims",
                newName: "AspNetUserClaims");

            migrationBuilder.RenameTable(
                name: "Tbl_Role_Claims",
                newName: "AspNetRoleClaims");

            migrationBuilder.RenameTable(
                name: "Tbl_Role",
                newName: "AspNetRoles");

            migrationBuilder.RenameTable(
                name: "t_user",
                newName: "AspNetUsers");

            migrationBuilder.RenameIndex(
                name: "IX_Tbl_User_Role_RoleId",
                table: "AspNetUserRoles",
                newName: "IX_AspNetUserRoles_RoleId");

            migrationBuilder.RenameIndex(
                name: "IX_Tbl_User_Login_UserId",
                table: "AspNetUserLogins",
                newName: "IX_AspNetUserLogins_UserId");

            migrationBuilder.RenameIndex(
                name: "IX_Tbl_User_Claims_UserId",
                table: "AspNetUserClaims",
                newName: "IX_AspNetUserClaims_UserId");

            migrationBuilder.RenameIndex(
                name: "IX_Tbl_Role_Claims_RoleId",
                table: "AspNetRoleClaims",
                newName: "IX_AspNetRoleClaims_RoleId");

            migrationBuilder.RenameColumn(
                name: "RnUserID",
                table: "AspNetUsers",
                newName: "Id");

            migrationBuilder.AlterColumn<string>(
                name: "Address",
                table: "AspNetUsers",
                type: "longtext",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "mediumtext",
                oldNullable: true)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddPrimaryKey(
                name: "PK_AspNetUserTokens",
                table: "AspNetUserTokens",
                columns: new[] { "UserId", "LoginProvider", "Name" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_AspNetUserRoles",
                table: "AspNetUserRoles",
                columns: new[] { "UserId", "RoleId" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_AspNetUserLogins",
                table: "AspNetUserLogins",
                columns: new[] { "LoginProvider", "ProviderKey" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_AspNetUserClaims",
                table: "AspNetUserClaims",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_AspNetRoleClaims",
                table: "AspNetRoleClaims",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_AspNetRoles",
                table: "AspNetRoles",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_AspNetUsers",
                table: "AspNetUsers",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId",
                principalTable: "AspNetRoles",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                table: "AspNetUserClaims",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                table: "AspNetUserLogins",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId",
                principalTable: "AspNetRoles",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                table: "AspNetUserRoles",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                table: "AspNetUserTokens",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_RefreshToken_AspNetUsers_AppUserId",
                table: "RefreshToken",
                column: "AppUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
