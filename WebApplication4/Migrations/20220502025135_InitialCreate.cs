using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebApplication4.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ADMIN_T",
                columns: table => new
                {
                    AdminID = table.Column<int>(type: "int", nullable: false),
                    AdminFirstName = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    AdminLastName = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    AdminAddress = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    AdminCity = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    AdminZipCode = table.Column<int>(type: "int", nullable: true),
                    AdminState = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    AdminPhone = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    AdminDOB = table.Column<DateTime>(type: "date", nullable: true),
                    AdminEmail = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    AdminPassword = table.Column<string>(type: "char(66)", unicode: false, fixedLength: true, maxLength: 66, nullable: false),
                    AdminSalary = table.Column<decimal>(type: "decimal(10,2)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__ADMIN_T__719FE4E84E8B61D9", x => x.AdminID);
                });

            migrationBuilder.CreateTable(
                name: "LIBRARIAN_T",
                columns: table => new
                {
                    LibrarianID = table.Column<int>(type: "int", nullable: false),
                    LibrarianFirstName = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    LibrarianLastName = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    LibrarianAddress = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    LibrarianCity = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    LibrarianZipCode = table.Column<int>(type: "int", nullable: true),
                    LibrarianState = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    LibrarianPhone = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    LibrarianDOB = table.Column<DateTime>(type: "date", nullable: true),
                    LibrarianEmail = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    LibrarianPassword = table.Column<string>(type: "char(66)", unicode: false, fixedLength: true, maxLength: 66, nullable: false),
                    LibrarianSalary = table.Column<decimal>(type: "decimal(10,2)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__LIBRARIA__E4D86D9DA77FF6A5", x => x.LibrarianID);
                });

            migrationBuilder.CreateTable(
                name: "User",
                columns: table => new
                {
                    UserID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    firstName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    lastName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    address = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    city = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    state = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    phoneNumber = table.Column<int>(type: "int", nullable: false),
                    DOB = table.Column<DateTime>(type: "datetime2", nullable: false),
                    email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    zipcode = table.Column<int>(type: "int", nullable: true),
                    password = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_User", x => x.UserID);
                });

            migrationBuilder.CreateTable(
                name: "USER_T",
                columns: table => new
                {
                    UserID = table.Column<int>(type: "int", nullable: false),
                    UserFirstName = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    UserLastName = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    UserAddress = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    UserCity = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    UserState = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    UserZipCode = table.Column<int>(type: "int", nullable: true),
                    UserPhone = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    UserDOB = table.Column<DateTime>(type: "date", nullable: true),
                    UserEmail = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    UserPassword = table.Column<string>(type: "char(66)", unicode: false, fixedLength: true, maxLength: 66, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__USER_T__1788CCAC92BB7317", x => x.UserID);
                });

            migrationBuilder.CreateTable(
                name: "LIBRARIAN_CARD",
                columns: table => new
                {
                    CardNumber = table.Column<int>(type: "int", nullable: true),
                    IssueDate = table.Column<DateTime>(type: "date", nullable: true),
                    AccountStatus = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.ForeignKey(
                        name: "FK__LIBRARIAN__CardN__5070F446",
                        column: x => x.CardNumber,
                        principalTable: "LIBRARIAN_T",
                        principalColumn: "LibrarianID");
                });

            migrationBuilder.CreateTable(
                name: "CREDITCARD_T",
                columns: table => new
                {
                    UserID = table.Column<int>(type: "int", nullable: true),
                    CardHolderName = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    CardNumber = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    CardExpDate = table.Column<DateTime>(type: "date", nullable: true),
                    CardCVV = table.Column<int>(type: "int", nullable: true),
                    CardAddress = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    CardCity = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    CardZipCode = table.Column<int>(type: "int", nullable: true),
                    CardState = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.ForeignKey(
                        name: "FK__CREDITCAR__UserI__47DBAE45",
                        column: x => x.UserID,
                        principalTable: "USER_T",
                        principalColumn: "UserID");
                });

            migrationBuilder.CreateTable(
                name: "AUTHOR_T",
                columns: table => new
                {
                    AuthorID = table.Column<int>(type: "int", nullable: false),
                    AuthorFirstName = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    AuthorLastName = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    ItemID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AUTHOR_T", x => x.AuthorID);
                });

            migrationBuilder.CreateTable(
                name: "ITEM_T",
                columns: table => new
                {
                    ItemID = table.Column<int>(type: "int", nullable: false),
                    Title = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Author = table.Column<int>(type: "int", nullable: true),
                    Publisher = table.Column<int>(type: "int", nullable: true),
                    DatePublished = table.Column<DateTime>(type: "date", nullable: true),
                    PurchasePrice = table.Column<decimal>(type: "decimal(10,2)", nullable: true),
                    RentalPrice = table.Column<decimal>(type: "decimal(10,2)", nullable: true),
                    ItemType = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Genre = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Duration = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    password = table.Column<int>(type: "int", nullable: true),
                    zipcode = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__ITEM_T__727E83EB6C1B5D75", x => x.ItemID);
                    table.ForeignKey(
                        name: "FK__ITEM_T__Author__3F466844",
                        column: x => x.Author,
                        principalTable: "AUTHOR_T",
                        principalColumn: "AuthorID");
                });

            migrationBuilder.CreateTable(
                name: "ITEMHOLD_T",
                columns: table => new
                {
                    UserID = table.Column<int>(type: "int", nullable: true),
                    ItemHold1 = table.Column<int>(type: "int", nullable: true),
                    ItemHold2 = table.Column<int>(type: "int", nullable: true),
                    ItemHold3 = table.Column<int>(type: "int", nullable: true),
                    ItemHold4 = table.Column<int>(type: "int", nullable: true),
                    ItemHold5 = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.ForeignKey(
                        name: "FK__ITEMHOLD___ItemH__4AB81AF0",
                        column: x => x.ItemHold1,
                        principalTable: "ITEM_T",
                        principalColumn: "ItemID");
                    table.ForeignKey(
                        name: "FK__ITEMHOLD___ItemH__4BAC3F29",
                        column: x => x.ItemHold2,
                        principalTable: "ITEM_T",
                        principalColumn: "ItemID");
                    table.ForeignKey(
                        name: "FK__ITEMHOLD___ItemH__4CA06362",
                        column: x => x.ItemHold3,
                        principalTable: "ITEM_T",
                        principalColumn: "ItemID");
                    table.ForeignKey(
                        name: "FK__ITEMHOLD___ItemH__4D94879B",
                        column: x => x.ItemHold4,
                        principalTable: "ITEM_T",
                        principalColumn: "ItemID");
                    table.ForeignKey(
                        name: "FK__ITEMHOLD___ItemH__4E88ABD4",
                        column: x => x.ItemHold5,
                        principalTable: "ITEM_T",
                        principalColumn: "ItemID");
                });

            migrationBuilder.CreateTable(
                name: "ITEMSTOCK_T",
                columns: table => new
                {
                    ItemNumber = table.Column<int>(type: "int", nullable: false),
                    Quantity = table.Column<int>(type: "int", nullable: true),
                    Description = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ITEMSTOCK_T", x => x.ItemNumber);
                    table.ForeignKey(
                        name: "FK__ITEMSTOCK__ItemN__4222D4EF",
                        column: x => x.ItemNumber,
                        principalTable: "ITEM_T",
                        principalColumn: "ItemID");
                });

            migrationBuilder.CreateTable(
                name: "PUBLISHER_T",
                columns: table => new
                {
                    PublisherID = table.Column<int>(type: "int", nullable: false),
                    PublisherName = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    ItemID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PUBLISHER_T", x => x.PublisherID);
                    table.ForeignKey(
                        name: "FK__PUBLISHER__ItemI__440B1D61",
                        column: x => x.ItemID,
                        principalTable: "ITEM_T",
                        principalColumn: "ItemID");
                });

            migrationBuilder.CreateIndex(
                name: "IX_AUTHOR_T_ItemID",
                table: "AUTHOR_T",
                column: "ItemID");

            migrationBuilder.CreateIndex(
                name: "UQ__AUTHOR_T__70DAFC159F24DC93",
                table: "AUTHOR_T",
                column: "AuthorID",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_CREDITCARD_T_UserID",
                table: "CREDITCARD_T",
                column: "UserID");

            migrationBuilder.CreateIndex(
                name: "IX_ITEM_T_Author",
                table: "ITEM_T",
                column: "Author");

            migrationBuilder.CreateIndex(
                name: "IX_ITEM_T_Publisher",
                table: "ITEM_T",
                column: "Publisher");

            migrationBuilder.CreateIndex(
                name: "IX_ITEMHOLD_T_ItemHold1",
                table: "ITEMHOLD_T",
                column: "ItemHold1");

            migrationBuilder.CreateIndex(
                name: "IX_ITEMHOLD_T_ItemHold2",
                table: "ITEMHOLD_T",
                column: "ItemHold2");

            migrationBuilder.CreateIndex(
                name: "IX_ITEMHOLD_T_ItemHold3",
                table: "ITEMHOLD_T",
                column: "ItemHold3");

            migrationBuilder.CreateIndex(
                name: "IX_ITEMHOLD_T_ItemHold4",
                table: "ITEMHOLD_T",
                column: "ItemHold4");

            migrationBuilder.CreateIndex(
                name: "IX_ITEMHOLD_T_ItemHold5",
                table: "ITEMHOLD_T",
                column: "ItemHold5");

            migrationBuilder.CreateIndex(
                name: "IX_LIBRARIAN_CARD_CardNumber",
                table: "LIBRARIAN_CARD",
                column: "CardNumber");

            migrationBuilder.CreateIndex(
                name: "IX_PUBLISHER_T_ItemID",
                table: "PUBLISHER_T",
                column: "ItemID");

            migrationBuilder.CreateIndex(
                name: "UQ__PUBLISHE__4C657E4A548DE844",
                table: "PUBLISHER_T",
                column: "PublisherID",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK__AUTHOR_T__ItemID__4316F928",
                table: "AUTHOR_T",
                column: "ItemID",
                principalTable: "ITEM_T",
                principalColumn: "ItemID");

            migrationBuilder.AddForeignKey(
                name: "FK__ITEM_T__Publishe__403A8C7D",
                table: "ITEM_T",
                column: "Publisher",
                principalTable: "PUBLISHER_T",
                principalColumn: "PublisherID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK__AUTHOR_T__ItemID__4316F928",
                table: "AUTHOR_T");

            migrationBuilder.DropForeignKey(
                name: "FK__PUBLISHER__ItemI__440B1D61",
                table: "PUBLISHER_T");

            migrationBuilder.DropTable(
                name: "ADMIN_T");

            migrationBuilder.DropTable(
                name: "CREDITCARD_T");

            migrationBuilder.DropTable(
                name: "ITEMHOLD_T");

            migrationBuilder.DropTable(
                name: "ITEMSTOCK_T");

            migrationBuilder.DropTable(
                name: "LIBRARIAN_CARD");

            migrationBuilder.DropTable(
                name: "User");

            migrationBuilder.DropTable(
                name: "USER_T");

            migrationBuilder.DropTable(
                name: "LIBRARIAN_T");

            migrationBuilder.DropTable(
                name: "ITEM_T");

            migrationBuilder.DropTable(
                name: "AUTHOR_T");

            migrationBuilder.DropTable(
                name: "PUBLISHER_T");
        }
    }
}
