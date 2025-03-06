using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace _7071Midterm_Study.Migrations
{
    /// <inheritdoc />
    public partial class two : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "ID",
                keyValue: new Guid("178e51f1-2273-41d8-b19f-9333f2c19317"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "ID",
                keyValue: new Guid("3de752ca-b93a-455a-804e-9b4f5b3889c4"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "ID",
                keyValue: new Guid("48e08988-a033-4aaa-a630-598ee5971b61"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "ID",
                keyValue: new Guid("d1715a0f-e048-4d6b-9f59-03bd0322b91f"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "ID",
                keyValue: new Guid("ddcf9913-cc8e-4e18-b9fc-64ab9827e611"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "ID",
                keyValue: new Guid("e94caf49-16af-4f82-b8fd-c16724c19779"));

            migrationBuilder.DeleteData(
                table: "Employee",
                keyColumn: "ID",
                keyValue: new Guid("0b0924b2-21ec-4c8b-a611-ab6455444f16"));

            migrationBuilder.DeleteData(
                table: "Employee",
                keyColumn: "ID",
                keyValue: new Guid("0c7e56fb-5be8-4b25-a567-4e43342368bb"));

            migrationBuilder.DeleteData(
                table: "Employee",
                keyColumn: "ID",
                keyValue: new Guid("10025b0f-bd2e-4376-adcb-e2d31dd0ca73"));

            migrationBuilder.DeleteData(
                table: "Employee",
                keyColumn: "ID",
                keyValue: new Guid("18243a9b-3678-4649-b6ce-3205d4345bef"));

            migrationBuilder.DeleteData(
                table: "Employee",
                keyColumn: "ID",
                keyValue: new Guid("452690f9-4e13-46d4-b6d0-874f98df5b6b"));

            migrationBuilder.DeleteData(
                table: "Employee",
                keyColumn: "ID",
                keyValue: new Guid("7fb64648-5346-41e9-82a2-7de2e62df15c"));

            migrationBuilder.DeleteData(
                table: "Employee",
                keyColumn: "ID",
                keyValue: new Guid("86d34287-1fdb-4606-8eda-b341539f0eee"));

            migrationBuilder.DeleteData(
                table: "Employee",
                keyColumn: "ID",
                keyValue: new Guid("d689cc86-281c-45fc-9299-7fc49394fe29"));

            migrationBuilder.DeleteData(
                table: "Services",
                keyColumn: "ID",
                keyValue: new Guid("0b3a058c-d4c6-44dd-b722-842f8f8439ab"));

            migrationBuilder.DeleteData(
                table: "Services",
                keyColumn: "ID",
                keyValue: new Guid("5e60b2cc-029b-458d-9448-9fa26cbf069d"));

            migrationBuilder.DeleteData(
                table: "Services",
                keyColumn: "ID",
                keyValue: new Guid("5e8d269a-4a16-4027-8f17-85338c758031"));

            migrationBuilder.DeleteData(
                table: "Services",
                keyColumn: "ID",
                keyValue: new Guid("63c17569-4c5c-4d22-98dc-bfc73a689b89"));

            migrationBuilder.DeleteData(
                table: "Services",
                keyColumn: "ID",
                keyValue: new Guid("7bd97ebd-c34e-430b-aa73-136515eb4e70"));

            migrationBuilder.DeleteData(
                table: "Services",
                keyColumn: "ID",
                keyValue: new Guid("7d5418c0-a1cd-4431-8484-9402e7feb502"));

            migrationBuilder.DeleteData(
                table: "Services",
                keyColumn: "ID",
                keyValue: new Guid("7de064c5-8ad5-473f-a661-ffb2e4af7803"));

            migrationBuilder.DeleteData(
                table: "Services",
                keyColumn: "ID",
                keyValue: new Guid("896f3871-5c39-40f5-ae43-bda82f3686ae"));

            migrationBuilder.DeleteData(
                table: "Services",
                keyColumn: "ID",
                keyValue: new Guid("93e3a199-88c7-4975-9490-278a57d49261"));

            migrationBuilder.DeleteData(
                table: "Services",
                keyColumn: "ID",
                keyValue: new Guid("bad4fa44-0e43-460b-9932-1e9df4c68e4e"));

            migrationBuilder.DeleteData(
                table: "Services",
                keyColumn: "ID",
                keyValue: new Guid("d9d14e4c-5e23-47c5-ae66-b6583cd018a1"));

            migrationBuilder.DeleteData(
                table: "Services",
                keyColumn: "ID",
                keyValue: new Guid("e4676c20-de2e-42db-a0a8-478386f8107c"));

            migrationBuilder.DeleteData(
                table: "Services",
                keyColumn: "ID",
                keyValue: new Guid("e5099435-c9ac-40cd-9d9b-d58056b60680"));

            migrationBuilder.DeleteData(
                table: "Services",
                keyColumn: "ID",
                keyValue: new Guid("e8599604-016a-4cc5-9ccc-5612602d0e4e"));

            migrationBuilder.DeleteData(
                table: "Services",
                keyColumn: "ID",
                keyValue: new Guid("fa36a902-71f6-4ea4-b06d-bfa539a0cfa2"));

            migrationBuilder.DeleteData(
                table: "People",
                keyColumn: "ID",
                keyValue: new Guid("0b0924b2-21ec-4c8b-a611-ab6455444f16"));

            migrationBuilder.DeleteData(
                table: "People",
                keyColumn: "ID",
                keyValue: new Guid("0c7e56fb-5be8-4b25-a567-4e43342368bb"));

            migrationBuilder.DeleteData(
                table: "People",
                keyColumn: "ID",
                keyValue: new Guid("10025b0f-bd2e-4376-adcb-e2d31dd0ca73"));

            migrationBuilder.DeleteData(
                table: "People",
                keyColumn: "ID",
                keyValue: new Guid("178e51f1-2273-41d8-b19f-9333f2c19317"));

            migrationBuilder.DeleteData(
                table: "People",
                keyColumn: "ID",
                keyValue: new Guid("18243a9b-3678-4649-b6ce-3205d4345bef"));

            migrationBuilder.DeleteData(
                table: "People",
                keyColumn: "ID",
                keyValue: new Guid("3de752ca-b93a-455a-804e-9b4f5b3889c4"));

            migrationBuilder.DeleteData(
                table: "People",
                keyColumn: "ID",
                keyValue: new Guid("452690f9-4e13-46d4-b6d0-874f98df5b6b"));

            migrationBuilder.DeleteData(
                table: "People",
                keyColumn: "ID",
                keyValue: new Guid("48e08988-a033-4aaa-a630-598ee5971b61"));

            migrationBuilder.DeleteData(
                table: "People",
                keyColumn: "ID",
                keyValue: new Guid("7fb64648-5346-41e9-82a2-7de2e62df15c"));

            migrationBuilder.DeleteData(
                table: "People",
                keyColumn: "ID",
                keyValue: new Guid("86d34287-1fdb-4606-8eda-b341539f0eee"));

            migrationBuilder.DeleteData(
                table: "People",
                keyColumn: "ID",
                keyValue: new Guid("d1715a0f-e048-4d6b-9f59-03bd0322b91f"));

            migrationBuilder.DeleteData(
                table: "People",
                keyColumn: "ID",
                keyValue: new Guid("d689cc86-281c-45fc-9299-7fc49394fe29"));

            migrationBuilder.DeleteData(
                table: "People",
                keyColumn: "ID",
                keyValue: new Guid("ddcf9913-cc8e-4e18-b9fc-64ab9827e611"));

            migrationBuilder.DeleteData(
                table: "People",
                keyColumn: "ID",
                keyValue: new Guid("e94caf49-16af-4f82-b8fd-c16724c19779"));

            migrationBuilder.InsertData(
                table: "People",
                columns: new[] { "ID", "DateOfBirth", "FullAdressId", "FullNameId" },
                values: new object[,]
                {
                    { new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(1990, 5, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 1 },
                    { new Guid("00000000-0000-0000-0000-000000000002"), new DateTime(1985, 8, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, 2 },
                    { new Guid("00000000-0000-0000-0000-000000000003"), new DateTime(1980, 2, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, 3 },
                    { new Guid("00000000-0000-0000-0000-000000000004"), new DateTime(1992, 11, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, 4 },
                    { new Guid("00000000-0000-0000-0000-000000000005"), new DateTime(1988, 4, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 5, 5 },
                    { new Guid("00000000-0000-0000-0000-000000000006"), new DateTime(1996, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 6, 6 },
                    { new Guid("00000000-0000-0000-0000-000000000007"), new DateTime(1988, 3, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, 2 },
                    { new Guid("00000000-0000-0000-0000-000000000008"), new DateTime(1992, 7, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, 3 },
                    { new Guid("00000000-0000-0000-0000-000000000009"), new DateTime(1988, 3, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, 4 },
                    { new Guid("00000000-0000-0000-0000-00000000000a"), new DateTime(1984, 3, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 5, 5 },
                    { new Guid("00000000-0000-0000-0000-00000000000b"), new DateTime(1995, 7, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 6, 6 },
                    { new Guid("00000000-0000-0000-0000-00000000000c"), new DateTime(1984, 3, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 7, 7 },
                    { new Guid("00000000-0000-0000-0000-00000000000d"), new DateTime(1991, 7, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 8, 8 },
                    { new Guid("00000000-0000-0000-0000-00000000000e"), new DateTime(1990, 7, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 9, 9 }
                });

            migrationBuilder.InsertData(
                table: "Services",
                columns: new[] { "ID", "Name" },
                values: new object[,]
                {
                    { new Guid("11111111-1111-1111-1111-111111111111"), "Consulting" },
                    { new Guid("22222222-2222-2222-2222-222222222222"), "Development" },
                    { new Guid("33333333-3333-3333-3333-333333333333"), "Marketing" },
                    { new Guid("44444444-4444-4444-4444-444444444444"), "Marketing" },
                    { new Guid("55555555-5555-5555-5555-555555555555"), "Shoplifting" },
                    { new Guid("66666666-6666-6666-6666-666666666666"), "shoort" },
                    { new Guid("77777777-7777-7777-7777-777777777777"), "Icecream" },
                    { new Guid("88888888-8888-8888-8888-888888888888"), "Love" },
                    { new Guid("99999999-9999-9999-9999-999999999999"), "Milking" },
                    { new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaaaa"), "walking dogs" },
                    { new Guid("bbbbbbbb-bbbb-bbbb-bbbb-bbbbbbbbbbbb"), "Development" },
                    { new Guid("cccccccc-cccc-cccc-cccc-cccccccccccc"), "Marketing" },
                    { new Guid("dddddddd-dddd-dddd-dddd-dddddddddddd"), "Consulting" },
                    { new Guid("eeeeeeee-eeee-eeee-eeee-eeeeeeeeeeee"), "Development" },
                    { new Guid("ffffffff-ffff-ffff-ffff-ffffffffffff"), "Marketing" }
                });

            migrationBuilder.InsertData(
                table: "Clients",
                columns: new[] { "ID", "Income" },
                values: new object[,]
                {
                    { new Guid("00000000-0000-0000-0000-000000000001"), 50000 },
                    { new Guid("00000000-0000-0000-0000-000000000002"), 60000 },
                    { new Guid("00000000-0000-0000-0000-000000000003"), 75000 },
                    { new Guid("00000000-0000-0000-0000-000000000004"), 54000 },
                    { new Guid("00000000-0000-0000-0000-000000000005"), 66000 },
                    { new Guid("00000000-0000-0000-0000-000000000006"), 77400 }
                });

            migrationBuilder.InsertData(
                table: "Employee",
                columns: new[] { "ID", "ManagerID", "Salary", "Title" },
                values: new object[,]
                {
                    { new Guid("00000000-0000-0000-0000-000000000007"), null, 70000, "Developer" },
                    { new Guid("00000000-0000-0000-0000-000000000008"), null, 80000, "Designer" },
                    { new Guid("00000000-0000-0000-0000-000000000009"), null, 70000, "Developer" },
                    { new Guid("00000000-0000-0000-0000-00000000000a"), null, 70000, "Developer" },
                    { new Guid("00000000-0000-0000-0000-00000000000b"), null, 80000, "Designer" },
                    { new Guid("00000000-0000-0000-0000-00000000000c"), null, 70000, "Developer" },
                    { new Guid("00000000-0000-0000-0000-00000000000d"), null, 80000, "Designer" },
                    { new Guid("00000000-0000-0000-0000-00000000000e"), null, 80000, "Designer" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "ID",
                keyValue: new Guid("00000000-0000-0000-0000-000000000001"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "ID",
                keyValue: new Guid("00000000-0000-0000-0000-000000000002"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "ID",
                keyValue: new Guid("00000000-0000-0000-0000-000000000003"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "ID",
                keyValue: new Guid("00000000-0000-0000-0000-000000000004"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "ID",
                keyValue: new Guid("00000000-0000-0000-0000-000000000005"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "ID",
                keyValue: new Guid("00000000-0000-0000-0000-000000000006"));

            migrationBuilder.DeleteData(
                table: "Employee",
                keyColumn: "ID",
                keyValue: new Guid("00000000-0000-0000-0000-000000000007"));

            migrationBuilder.DeleteData(
                table: "Employee",
                keyColumn: "ID",
                keyValue: new Guid("00000000-0000-0000-0000-000000000008"));

            migrationBuilder.DeleteData(
                table: "Employee",
                keyColumn: "ID",
                keyValue: new Guid("00000000-0000-0000-0000-000000000009"));

            migrationBuilder.DeleteData(
                table: "Employee",
                keyColumn: "ID",
                keyValue: new Guid("00000000-0000-0000-0000-00000000000a"));

            migrationBuilder.DeleteData(
                table: "Employee",
                keyColumn: "ID",
                keyValue: new Guid("00000000-0000-0000-0000-00000000000b"));

            migrationBuilder.DeleteData(
                table: "Employee",
                keyColumn: "ID",
                keyValue: new Guid("00000000-0000-0000-0000-00000000000c"));

            migrationBuilder.DeleteData(
                table: "Employee",
                keyColumn: "ID",
                keyValue: new Guid("00000000-0000-0000-0000-00000000000d"));

            migrationBuilder.DeleteData(
                table: "Employee",
                keyColumn: "ID",
                keyValue: new Guid("00000000-0000-0000-0000-00000000000e"));

            migrationBuilder.DeleteData(
                table: "Services",
                keyColumn: "ID",
                keyValue: new Guid("11111111-1111-1111-1111-111111111111"));

            migrationBuilder.DeleteData(
                table: "Services",
                keyColumn: "ID",
                keyValue: new Guid("22222222-2222-2222-2222-222222222222"));

            migrationBuilder.DeleteData(
                table: "Services",
                keyColumn: "ID",
                keyValue: new Guid("33333333-3333-3333-3333-333333333333"));

            migrationBuilder.DeleteData(
                table: "Services",
                keyColumn: "ID",
                keyValue: new Guid("44444444-4444-4444-4444-444444444444"));

            migrationBuilder.DeleteData(
                table: "Services",
                keyColumn: "ID",
                keyValue: new Guid("55555555-5555-5555-5555-555555555555"));

            migrationBuilder.DeleteData(
                table: "Services",
                keyColumn: "ID",
                keyValue: new Guid("66666666-6666-6666-6666-666666666666"));

            migrationBuilder.DeleteData(
                table: "Services",
                keyColumn: "ID",
                keyValue: new Guid("77777777-7777-7777-7777-777777777777"));

            migrationBuilder.DeleteData(
                table: "Services",
                keyColumn: "ID",
                keyValue: new Guid("88888888-8888-8888-8888-888888888888"));

            migrationBuilder.DeleteData(
                table: "Services",
                keyColumn: "ID",
                keyValue: new Guid("99999999-9999-9999-9999-999999999999"));

            migrationBuilder.DeleteData(
                table: "Services",
                keyColumn: "ID",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaaaa"));

            migrationBuilder.DeleteData(
                table: "Services",
                keyColumn: "ID",
                keyValue: new Guid("bbbbbbbb-bbbb-bbbb-bbbb-bbbbbbbbbbbb"));

            migrationBuilder.DeleteData(
                table: "Services",
                keyColumn: "ID",
                keyValue: new Guid("cccccccc-cccc-cccc-cccc-cccccccccccc"));

            migrationBuilder.DeleteData(
                table: "Services",
                keyColumn: "ID",
                keyValue: new Guid("dddddddd-dddd-dddd-dddd-dddddddddddd"));

            migrationBuilder.DeleteData(
                table: "Services",
                keyColumn: "ID",
                keyValue: new Guid("eeeeeeee-eeee-eeee-eeee-eeeeeeeeeeee"));

            migrationBuilder.DeleteData(
                table: "Services",
                keyColumn: "ID",
                keyValue: new Guid("ffffffff-ffff-ffff-ffff-ffffffffffff"));

            migrationBuilder.DeleteData(
                table: "People",
                keyColumn: "ID",
                keyValue: new Guid("00000000-0000-0000-0000-000000000001"));

            migrationBuilder.DeleteData(
                table: "People",
                keyColumn: "ID",
                keyValue: new Guid("00000000-0000-0000-0000-000000000002"));

            migrationBuilder.DeleteData(
                table: "People",
                keyColumn: "ID",
                keyValue: new Guid("00000000-0000-0000-0000-000000000003"));

            migrationBuilder.DeleteData(
                table: "People",
                keyColumn: "ID",
                keyValue: new Guid("00000000-0000-0000-0000-000000000004"));

            migrationBuilder.DeleteData(
                table: "People",
                keyColumn: "ID",
                keyValue: new Guid("00000000-0000-0000-0000-000000000005"));

            migrationBuilder.DeleteData(
                table: "People",
                keyColumn: "ID",
                keyValue: new Guid("00000000-0000-0000-0000-000000000006"));

            migrationBuilder.DeleteData(
                table: "People",
                keyColumn: "ID",
                keyValue: new Guid("00000000-0000-0000-0000-000000000007"));

            migrationBuilder.DeleteData(
                table: "People",
                keyColumn: "ID",
                keyValue: new Guid("00000000-0000-0000-0000-000000000008"));

            migrationBuilder.DeleteData(
                table: "People",
                keyColumn: "ID",
                keyValue: new Guid("00000000-0000-0000-0000-000000000009"));

            migrationBuilder.DeleteData(
                table: "People",
                keyColumn: "ID",
                keyValue: new Guid("00000000-0000-0000-0000-00000000000a"));

            migrationBuilder.DeleteData(
                table: "People",
                keyColumn: "ID",
                keyValue: new Guid("00000000-0000-0000-0000-00000000000b"));

            migrationBuilder.DeleteData(
                table: "People",
                keyColumn: "ID",
                keyValue: new Guid("00000000-0000-0000-0000-00000000000c"));

            migrationBuilder.DeleteData(
                table: "People",
                keyColumn: "ID",
                keyValue: new Guid("00000000-0000-0000-0000-00000000000d"));

            migrationBuilder.DeleteData(
                table: "People",
                keyColumn: "ID",
                keyValue: new Guid("00000000-0000-0000-0000-00000000000e"));

            migrationBuilder.InsertData(
                table: "People",
                columns: new[] { "ID", "DateOfBirth", "FullAdressId", "FullNameId" },
                values: new object[,]
                {
                    { new Guid("0b0924b2-21ec-4c8b-a611-ab6455444f16"), new DateTime(1990, 7, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 9, 9 },
                    { new Guid("0c7e56fb-5be8-4b25-a567-4e43342368bb"), new DateTime(1988, 3, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, 4 },
                    { new Guid("10025b0f-bd2e-4376-adcb-e2d31dd0ca73"), new DateTime(1984, 3, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 7, 7 },
                    { new Guid("178e51f1-2273-41d8-b19f-9333f2c19317"), new DateTime(1990, 5, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 1 },
                    { new Guid("18243a9b-3678-4649-b6ce-3205d4345bef"), new DateTime(1991, 7, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 8, 8 },
                    { new Guid("3de752ca-b93a-455a-804e-9b4f5b3889c4"), new DateTime(1992, 11, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, 4 },
                    { new Guid("452690f9-4e13-46d4-b6d0-874f98df5b6b"), new DateTime(1988, 3, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, 2 },
                    { new Guid("48e08988-a033-4aaa-a630-598ee5971b61"), new DateTime(1996, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 6, 6 },
                    { new Guid("7fb64648-5346-41e9-82a2-7de2e62df15c"), new DateTime(1995, 7, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 6, 6 },
                    { new Guid("86d34287-1fdb-4606-8eda-b341539f0eee"), new DateTime(1992, 7, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, 3 },
                    { new Guid("d1715a0f-e048-4d6b-9f59-03bd0322b91f"), new DateTime(1985, 8, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, 2 },
                    { new Guid("d689cc86-281c-45fc-9299-7fc49394fe29"), new DateTime(1984, 3, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 5, 5 },
                    { new Guid("ddcf9913-cc8e-4e18-b9fc-64ab9827e611"), new DateTime(1988, 4, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 5, 5 },
                    { new Guid("e94caf49-16af-4f82-b8fd-c16724c19779"), new DateTime(1980, 2, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, 3 }
                });

            migrationBuilder.InsertData(
                table: "Services",
                columns: new[] { "ID", "Name" },
                values: new object[,]
                {
                    { new Guid("0b3a058c-d4c6-44dd-b722-842f8f8439ab"), "Icecream" },
                    { new Guid("5e60b2cc-029b-458d-9448-9fa26cbf069d"), "Consulting" },
                    { new Guid("5e8d269a-4a16-4027-8f17-85338c758031"), "Shoplifting" },
                    { new Guid("63c17569-4c5c-4d22-98dc-bfc73a689b89"), "Development" },
                    { new Guid("7bd97ebd-c34e-430b-aa73-136515eb4e70"), "Love" },
                    { new Guid("7d5418c0-a1cd-4431-8484-9402e7feb502"), "walking dogs" },
                    { new Guid("7de064c5-8ad5-473f-a661-ffb2e4af7803"), "Development" },
                    { new Guid("896f3871-5c39-40f5-ae43-bda82f3686ae"), "Marketing" },
                    { new Guid("93e3a199-88c7-4975-9490-278a57d49261"), "Development" },
                    { new Guid("bad4fa44-0e43-460b-9932-1e9df4c68e4e"), "Milking" },
                    { new Guid("d9d14e4c-5e23-47c5-ae66-b6583cd018a1"), "Marketing" },
                    { new Guid("e4676c20-de2e-42db-a0a8-478386f8107c"), "Consulting" },
                    { new Guid("e5099435-c9ac-40cd-9d9b-d58056b60680"), "shoort" },
                    { new Guid("e8599604-016a-4cc5-9ccc-5612602d0e4e"), "Marketing" },
                    { new Guid("fa36a902-71f6-4ea4-b06d-bfa539a0cfa2"), "Marketing" }
                });

            migrationBuilder.InsertData(
                table: "Clients",
                columns: new[] { "ID", "Income" },
                values: new object[,]
                {
                    { new Guid("178e51f1-2273-41d8-b19f-9333f2c19317"), 50000 },
                    { new Guid("3de752ca-b93a-455a-804e-9b4f5b3889c4"), 54000 },
                    { new Guid("48e08988-a033-4aaa-a630-598ee5971b61"), 77400 },
                    { new Guid("d1715a0f-e048-4d6b-9f59-03bd0322b91f"), 60000 },
                    { new Guid("ddcf9913-cc8e-4e18-b9fc-64ab9827e611"), 66000 },
                    { new Guid("e94caf49-16af-4f82-b8fd-c16724c19779"), 75000 }
                });

            migrationBuilder.InsertData(
                table: "Employee",
                columns: new[] { "ID", "ManagerID", "Salary", "Title" },
                values: new object[,]
                {
                    { new Guid("0b0924b2-21ec-4c8b-a611-ab6455444f16"), null, 80000, "Designer" },
                    { new Guid("0c7e56fb-5be8-4b25-a567-4e43342368bb"), null, 70000, "Developer" },
                    { new Guid("10025b0f-bd2e-4376-adcb-e2d31dd0ca73"), null, 70000, "Developer" },
                    { new Guid("18243a9b-3678-4649-b6ce-3205d4345bef"), null, 80000, "Designer" },
                    { new Guid("452690f9-4e13-46d4-b6d0-874f98df5b6b"), null, 70000, "Developer" },
                    { new Guid("7fb64648-5346-41e9-82a2-7de2e62df15c"), null, 80000, "Designer" },
                    { new Guid("86d34287-1fdb-4606-8eda-b341539f0eee"), null, 80000, "Designer" },
                    { new Guid("d689cc86-281c-45fc-9299-7fc49394fe29"), null, 70000, "Developer" }
                });
        }
    }
}
