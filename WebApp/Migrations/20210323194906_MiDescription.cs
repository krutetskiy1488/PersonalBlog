using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace WebApp.Migrations
{
    public partial class MiDescription : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Description",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Title = table.Column<string>(nullable: true),
                    Subtitle = table.Column<string>(nullable: true),
                    TitleImagePath = table.Column<string>(nullable: true),
                    MetaTitle = table.Column<string>(nullable: true),
                    MetaDescription = table.Column<string>(nullable: true),
                    MetaKeywords = table.Column<string>(nullable: true),
                    DateAdded = table.Column<DateTime>(nullable: false),
                    Text = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Description", x => x.Id);
                });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3fdef149-fd52-48e1-b5ce-a099a7cac941",
                column: "ConcurrencyStamp",
                value: "e9eab7ff-8486-45f0-8c68-b27f5104d7c1");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8559a0b0-a171-4724-8431-982e2c8a5ed4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "56656d23-0b2d-4f0b-87a9-956657b1e0f9", "AQAAAAEAACcQAAAAEDbIQo3ejwylS9WxGdM+LBMMNoiyn2bBKHVJTh5nctRrNBUOV032WkUBm03pUzOVwA==" });

            migrationBuilder.InsertData(
                table: "Description",
                columns: new[] { "Id", "DateAdded", "MetaDescription", "MetaKeywords", "MetaTitle", "Subtitle", "Text", "Title", "TitleImagePath" },
                values: new object[] { new Guid("58e519d6-5f87-48aa-b4f2-743db9772fc5"), new DateTime(2021, 3, 23, 19, 49, 5, 966, DateTimeKind.Utc).AddTicks(8491), null, null, null, null, "Я Семен", null, null });

            migrationBuilder.UpdateData(
                table: "TextFields",
                keyColumn: "Id",
                keyValue: new Guid("30afafcc-42e4-4e1e-9247-57b886c5f715"),
                column: "DateAdded",
                value: new DateTime(2021, 3, 23, 19, 49, 5, 967, DateTimeKind.Utc).AddTicks(2198));

            migrationBuilder.UpdateData(
                table: "TextFields",
                keyColumn: "Id",
                keyValue: new Guid("368eb6c7-cd57-407d-ab0e-3ce51d616fc2"),
                column: "DateAdded",
                value: new DateTime(2021, 3, 23, 19, 49, 5, 967, DateTimeKind.Utc).AddTicks(2151));

            migrationBuilder.UpdateData(
                table: "TextFields",
                keyColumn: "Id",
                keyValue: new Guid("ed87c8f8-82bb-471b-aa44-80bd6ffb9a9a"),
                column: "DateAdded",
                value: new DateTime(2021, 3, 23, 19, 49, 5, 967, DateTimeKind.Utc).AddTicks(1059));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Description");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3fdef149-fd52-48e1-b5ce-a099a7cac941",
                column: "ConcurrencyStamp",
                value: "7f64f7ff-9481-42f2-8e35-7a21ca977119");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8559a0b0-a171-4724-8431-982e2c8a5ed4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "0fbc0830-10e7-4ea7-b3e2-ea3cab6b50b3", "AQAAAAEAACcQAAAAEIcRLiaPrOUvGq3V7Eor8QkDd1Yx4Cya+To6xq7YnuYyKS6FABqUMY8smLjAAqmqcg==" });

            migrationBuilder.UpdateData(
                table: "TextFields",
                keyColumn: "Id",
                keyValue: new Guid("30afafcc-42e4-4e1e-9247-57b886c5f715"),
                column: "DateAdded",
                value: new DateTime(2021, 3, 13, 6, 33, 59, 833, DateTimeKind.Utc).AddTicks(6337));

            migrationBuilder.UpdateData(
                table: "TextFields",
                keyColumn: "Id",
                keyValue: new Guid("368eb6c7-cd57-407d-ab0e-3ce51d616fc2"),
                column: "DateAdded",
                value: new DateTime(2021, 3, 13, 6, 33, 59, 833, DateTimeKind.Utc).AddTicks(6217));

            migrationBuilder.UpdateData(
                table: "TextFields",
                keyColumn: "Id",
                keyValue: new Guid("ed87c8f8-82bb-471b-aa44-80bd6ffb9a9a"),
                column: "DateAdded",
                value: new DateTime(2021, 3, 13, 6, 33, 59, 832, DateTimeKind.Utc).AddTicks(2456));
        }
    }
}
