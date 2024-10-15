using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DogWalkApp.Infrastructure.Migrations
{
    public partial class changed_DogWalker_and_DogOwner_entitynames : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Dogs_DogOwners_OwnerId",
                table: "Dogs");

            migrationBuilder.DropForeignKey(
                name: "FK_WeightRanges_DogWalkers_DogWalkerId",
                table: "WeightRanges");

            migrationBuilder.DropTable(
                name: "DogOwners");

            migrationBuilder.DropTable(
                name: "DogWalkers");

            migrationBuilder.RenameColumn(
                name: "DogWalkerId",
                table: "WeightRanges",
                newName: "WalkerId");

            migrationBuilder.RenameIndex(
                name: "IX_WeightRanges_DogWalkerId",
                table: "WeightRanges",
                newName: "IX_WeightRanges_WalkerId");

            migrationBuilder.CreateTable(
                name: "Owners",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false, comment: "Primary identifier of the dog owner")
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false, comment: "Primary identifier of the user")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Owners", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Owners_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Walkers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false, comment: "Primary identifier of the dog walker")
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false, comment: "Primary identifier of the user"),
                    MaxNumberOfDogs = table.Column<int>(type: "int", nullable: false, comment: "Maximum number of dogs that the walker can handle")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Walkers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Walkers_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Owners_UserId",
                table: "Owners",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Walkers_UserId",
                table: "Walkers",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Dogs_Owners_OwnerId",
                table: "Dogs",
                column: "OwnerId",
                principalTable: "Owners",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_WeightRanges_Walkers_WalkerId",
                table: "WeightRanges",
                column: "WalkerId",
                principalTable: "Walkers",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Dogs_Owners_OwnerId",
                table: "Dogs");

            migrationBuilder.DropForeignKey(
                name: "FK_WeightRanges_Walkers_WalkerId",
                table: "WeightRanges");

            migrationBuilder.DropTable(
                name: "Owners");

            migrationBuilder.DropTable(
                name: "Walkers");

            migrationBuilder.RenameColumn(
                name: "WalkerId",
                table: "WeightRanges",
                newName: "DogWalkerId");

            migrationBuilder.RenameIndex(
                name: "IX_WeightRanges_WalkerId",
                table: "WeightRanges",
                newName: "IX_WeightRanges_DogWalkerId");

            migrationBuilder.CreateTable(
                name: "DogOwners",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false, comment: "Primary identifier of the dog owner")
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false, comment: "Primary identifier of the user")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DogOwners", x => x.Id);
                    table.ForeignKey(
                        name: "FK_DogOwners_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "DogWalkers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false, comment: "Primary identifier of the dog walker")
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false, comment: "Primary identifier of the user"),
                    MaxNumberOfDogs = table.Column<int>(type: "int", nullable: false, comment: "Maximum number of dogs that the walker can handle")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DogWalkers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_DogWalkers_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_DogOwners_UserId",
                table: "DogOwners",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_DogWalkers_UserId",
                table: "DogWalkers",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Dogs_DogOwners_OwnerId",
                table: "Dogs",
                column: "OwnerId",
                principalTable: "DogOwners",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_WeightRanges_DogWalkers_DogWalkerId",
                table: "WeightRanges",
                column: "DogWalkerId",
                principalTable: "DogWalkers",
                principalColumn: "Id");
        }
    }
}
