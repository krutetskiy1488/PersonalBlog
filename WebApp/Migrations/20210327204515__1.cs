using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace WebApp.Migrations
{
    public partial class _1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "TextFields",
                keyColumn: "Id",
                keyValue: new Guid("30afafcc-42e4-4e1e-9247-57b886c5f715"));

            migrationBuilder.DeleteData(
                table: "TextFields",
                keyColumn: "Id",
                keyValue: new Guid("368eb6c7-cd57-407d-ab0e-3ce51d616fc2"));

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3fdef149-fd52-48e1-b5ce-a099a7cac941",
                column: "ConcurrencyStamp",
                value: "2289b78d-e66c-49ee-a4e4-138470af149f");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8559a0b0-a171-4724-8431-982e2c8a5ed4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "b6c273a4-01bb-4e58-bbd2-8fce6e1a8190", "AQAAAAEAACcQAAAAEPv86xhr/RFSb/mWpQtRHtOY7z82GcpRJpJsdOjRmYPBqCirTJkyXK/rV1QxBT2k1g==" });

            migrationBuilder.UpdateData(
                table: "Description",
                keyColumn: "Id",
                keyValue: new Guid("58e519d6-5f87-48aa-b4f2-743db9772fc5"),
                column: "DateAdded",
                value: new DateTime(2021, 3, 27, 20, 45, 15, 403, DateTimeKind.Utc).AddTicks(5691));

            migrationBuilder.UpdateData(
                table: "TextFields",
                keyColumn: "Id",
                keyValue: new Guid("ed87c8f8-82bb-471b-aa44-80bd6ffb9a9a"),
                column: "DateAdded",
                value: new DateTime(2021, 3, 27, 20, 45, 15, 403, DateTimeKind.Utc).AddTicks(8486));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.UpdateData(
                table: "Description",
                keyColumn: "Id",
                keyValue: new Guid("58e519d6-5f87-48aa-b4f2-743db9772fc5"),
                column: "DateAdded",
                value: new DateTime(2021, 3, 23, 19, 49, 5, 966, DateTimeKind.Utc).AddTicks(8491));

            migrationBuilder.UpdateData(
                table: "TextFields",
                keyColumn: "Id",
                keyValue: new Guid("ed87c8f8-82bb-471b-aa44-80bd6ffb9a9a"),
                column: "DateAdded",
                value: new DateTime(2021, 3, 23, 19, 49, 5, 967, DateTimeKind.Utc).AddTicks(1059));

            migrationBuilder.InsertData(
                table: "TextFields",
                columns: new[] { "Id", "CodeWord", "DateAdded", "MetaDescription", "MetaKeywords", "MetaTitle", "Subtitle", "Text", "Title", "TitleImagePath" },
                values: new object[,]
                {
                    { new Guid("368eb6c7-cd57-407d-ab0e-3ce51d616fc2"), "PageServices", new DateTime(2021, 3, 23, 19, 49, 5, 967, DateTimeKind.Utc).AddTicks(2151), null, null, null, null, "Содержание заполняется админом", "Наши услуги", null },
                    { new Guid("30afafcc-42e4-4e1e-9247-57b886c5f715"), "PageContacts", new DateTime(2021, 3, 23, 19, 49, 5, 967, DateTimeKind.Utc).AddTicks(2198), null, null, null, null, "Содержание заполняется админом", "Контакты", null }
                });
        }
    }
}
