using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Persistence.Migrations
{
    /// <inheritdoc />
    public partial class newDb : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Models_Brands_BrandId1",
                table: "Models");

            migrationBuilder.DropForeignKey(
                name: "FK_Models_Fuels_FuelId1",
                table: "Models");

            migrationBuilder.DropForeignKey(
                name: "FK_Models_Transmissions_TransmissionId1",
                table: "Models");

            migrationBuilder.DropIndex(
                name: "IX_Models_BrandId1",
                table: "Models");

            migrationBuilder.DropIndex(
                name: "IX_Models_FuelId1",
                table: "Models");

            migrationBuilder.DropIndex(
                name: "IX_Models_TransmissionId1",
                table: "Models");

            migrationBuilder.DeleteData(
                table: "UserOperationClaims",
                keyColumn: "Id",
                keyValue: new Guid("25f17c80-4ab9-4f0d-8968-f329b0926fd4"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("721b2e51-85ec-43ef-ac6c-14ca39af31b0"));

            migrationBuilder.DropColumn(
                name: "BrandId1",
                table: "Models");

            migrationBuilder.DropColumn(
                name: "FuelId1",
                table: "Models");

            migrationBuilder.DropColumn(
                name: "TransmissionId1",
                table: "Models");

            migrationBuilder.AlterColumn<Guid>(
                name: "TransmissionId",
                table: "Models",
                type: "uniqueidentifier",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<Guid>(
                name: "FuelId",
                table: "Models",
                type: "uniqueidentifier",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<Guid>(
                name: "BrandId",
                table: "Models",
                type: "uniqueidentifier",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "AuthenticatorType", "CreatedDate", "DeletedDate", "Email", "PasswordHash", "PasswordSalt", "UpdatedDate" },
                values: new object[] { new Guid("15240a82-d6fb-400c-983f-6a819bdb75be"), 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "narch@kodlama.io", new byte[] { 209, 105, 180, 151, 120, 40, 226, 76, 126, 201, 139, 83, 145, 178, 129, 125, 206, 212, 46, 213, 166, 141, 208, 220, 76, 164, 21, 29, 144, 222, 25, 135, 152, 17, 233, 231, 78, 219, 19, 251, 177, 123, 21, 152, 34, 100, 126, 5, 53, 113, 103, 39, 227, 35, 65, 42, 102, 233, 35, 1, 120, 186, 255, 154 }, new byte[] { 251, 73, 112, 182, 255, 47, 187, 125, 114, 154, 239, 227, 161, 62, 56, 83, 110, 159, 196, 5, 32, 201, 4, 142, 95, 65, 197, 209, 144, 130, 248, 139, 58, 139, 215, 225, 208, 104, 242, 255, 112, 125, 61, 102, 194, 129, 221, 127, 127, 242, 0, 146, 173, 253, 182, 165, 0, 233, 254, 218, 101, 196, 197, 218, 245, 184, 245, 30, 71, 213, 20, 37, 126, 223, 164, 120, 228, 62, 25, 138, 249, 211, 190, 137, 254, 118, 195, 10, 151, 207, 72, 167, 33, 131, 244, 127, 226, 15, 60, 189, 237, 145, 233, 100, 129, 8, 2, 162, 83, 205, 231, 44, 246, 37, 76, 241, 73, 49, 165, 104, 191, 208, 15, 229, 93, 28, 84, 142 }, null });

            migrationBuilder.InsertData(
                table: "UserOperationClaims",
                columns: new[] { "Id", "CreatedDate", "DeletedDate", "OperationClaimId", "UpdatedDate", "UserId" },
                values: new object[] { new Guid("0804fdbc-009b-4ba4-99f9-c3ce256d4943"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 1, null, new Guid("15240a82-d6fb-400c-983f-6a819bdb75be") });

            migrationBuilder.CreateIndex(
                name: "IX_Models_BrandId",
                table: "Models",
                column: "BrandId");

            migrationBuilder.CreateIndex(
                name: "IX_Models_FuelId",
                table: "Models",
                column: "FuelId");

            migrationBuilder.CreateIndex(
                name: "IX_Models_TransmissionId",
                table: "Models",
                column: "TransmissionId");

            migrationBuilder.AddForeignKey(
                name: "FK_Models_Brands_BrandId",
                table: "Models",
                column: "BrandId",
                principalTable: "Brands",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Models_Fuels_FuelId",
                table: "Models",
                column: "FuelId",
                principalTable: "Fuels",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Models_Transmissions_TransmissionId",
                table: "Models",
                column: "TransmissionId",
                principalTable: "Transmissions",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Models_Brands_BrandId",
                table: "Models");

            migrationBuilder.DropForeignKey(
                name: "FK_Models_Fuels_FuelId",
                table: "Models");

            migrationBuilder.DropForeignKey(
                name: "FK_Models_Transmissions_TransmissionId",
                table: "Models");

            migrationBuilder.DropIndex(
                name: "IX_Models_BrandId",
                table: "Models");

            migrationBuilder.DropIndex(
                name: "IX_Models_FuelId",
                table: "Models");

            migrationBuilder.DropIndex(
                name: "IX_Models_TransmissionId",
                table: "Models");

            migrationBuilder.DeleteData(
                table: "UserOperationClaims",
                keyColumn: "Id",
                keyValue: new Guid("0804fdbc-009b-4ba4-99f9-c3ce256d4943"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("15240a82-d6fb-400c-983f-6a819bdb75be"));

            migrationBuilder.AlterColumn<int>(
                name: "TransmissionId",
                table: "Models",
                type: "int",
                nullable: false,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier");

            migrationBuilder.AlterColumn<int>(
                name: "FuelId",
                table: "Models",
                type: "int",
                nullable: false,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier");

            migrationBuilder.AlterColumn<int>(
                name: "BrandId",
                table: "Models",
                type: "int",
                nullable: false,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier");

            migrationBuilder.AddColumn<Guid>(
                name: "BrandId1",
                table: "Models",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "FuelId1",
                table: "Models",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "TransmissionId1",
                table: "Models",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "AuthenticatorType", "CreatedDate", "DeletedDate", "Email", "PasswordHash", "PasswordSalt", "UpdatedDate" },
                values: new object[] { new Guid("721b2e51-85ec-43ef-ac6c-14ca39af31b0"), 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "narch@kodlama.io", new byte[] { 82, 89, 88, 191, 59, 216, 59, 200, 47, 82, 241, 163, 155, 174, 0, 19, 4, 45, 152, 38, 55, 253, 31, 103, 47, 204, 90, 104, 102, 54, 144, 191, 124, 229, 23, 142, 18, 21, 155, 23, 64, 219, 107, 111, 93, 176, 178, 90, 110, 162, 179, 51, 213, 63, 44, 1, 50, 163, 144, 193, 104, 172, 93, 108 }, new byte[] { 165, 21, 97, 84, 75, 68, 194, 115, 161, 41, 67, 189, 176, 200, 38, 28, 214, 186, 130, 85, 222, 188, 111, 132, 245, 56, 56, 49, 129, 5, 190, 141, 159, 244, 253, 5, 138, 151, 190, 167, 160, 247, 46, 165, 8, 181, 175, 186, 121, 104, 32, 190, 240, 220, 74, 129, 117, 5, 157, 118, 7, 82, 9, 204, 201, 218, 216, 15, 162, 8, 200, 90, 8, 201, 193, 198, 187, 246, 224, 87, 116, 134, 201, 74, 92, 153, 205, 248, 53, 51, 139, 73, 32, 125, 252, 124, 34, 64, 177, 46, 196, 134, 98, 222, 26, 154, 51, 212, 28, 128, 212, 103, 255, 226, 222, 179, 113, 34, 49, 204, 245, 30, 253, 139, 108, 181, 8, 157 }, null });

            migrationBuilder.InsertData(
                table: "UserOperationClaims",
                columns: new[] { "Id", "CreatedDate", "DeletedDate", "OperationClaimId", "UpdatedDate", "UserId" },
                values: new object[] { new Guid("25f17c80-4ab9-4f0d-8968-f329b0926fd4"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 1, null, new Guid("721b2e51-85ec-43ef-ac6c-14ca39af31b0") });

            migrationBuilder.CreateIndex(
                name: "IX_Models_BrandId1",
                table: "Models",
                column: "BrandId1");

            migrationBuilder.CreateIndex(
                name: "IX_Models_FuelId1",
                table: "Models",
                column: "FuelId1");

            migrationBuilder.CreateIndex(
                name: "IX_Models_TransmissionId1",
                table: "Models",
                column: "TransmissionId1");

            migrationBuilder.AddForeignKey(
                name: "FK_Models_Brands_BrandId1",
                table: "Models",
                column: "BrandId1",
                principalTable: "Brands",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Models_Fuels_FuelId1",
                table: "Models",
                column: "FuelId1",
                principalTable: "Fuels",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Models_Transmissions_TransmissionId1",
                table: "Models",
                column: "TransmissionId1",
                principalTable: "Transmissions",
                principalColumn: "Id");
        }
    }
}
