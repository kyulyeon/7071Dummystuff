﻿using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace _7071Midterm_Study.Migrations
{
    /// <inheritdoc />
    public partial class one : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "FullAddresses",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Street = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    City = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Province = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PostalCode = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FullAddresses", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "FullName",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FullName", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Services",
                columns: table => new
                {
                    ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Services", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "People",
                columns: table => new
                {
                    ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    FullNameId = table.Column<int>(type: "int", nullable: false),
                    FullAdressId = table.Column<int>(type: "int", nullable: false),
                    DateOfBirth = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_People", x => x.ID);
                    table.ForeignKey(
                        name: "FK_People_FullAddresses_FullAdressId",
                        column: x => x.FullAdressId,
                        principalTable: "FullAddresses",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_People_FullName_FullNameId",
                        column: x => x.FullNameId,
                        principalTable: "FullName",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Clients",
                columns: table => new
                {
                    ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Income = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Clients", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Clients_People_ID",
                        column: x => x.ID,
                        principalTable: "People",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ClientService",
                columns: table => new
                {
                    ClientsID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ServicesID = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ClientService", x => new { x.ClientsID, x.ServicesID });
                    table.ForeignKey(
                        name: "FK_ClientService_Clients_ClientsID",
                        column: x => x.ClientsID,
                        principalTable: "Clients",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ClientService_Services_ServicesID",
                        column: x => x.ServicesID,
                        principalTable: "Services",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Contact",
                columns: table => new
                {
                    ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ClientID = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    EmployeeID = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Contact", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Contact_Clients_ClientID",
                        column: x => x.ClientID,
                        principalTable: "Clients",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_Contact_People_ID",
                        column: x => x.ID,
                        principalTable: "People",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Employee",
                columns: table => new
                {
                    ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Salary = table.Column<int>(type: "int", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ManagerID = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employee", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Employee_People_ID",
                        column: x => x.ID,
                        principalTable: "People",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "EmployeeService",
                columns: table => new
                {
                    EmployeesID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ServicesID = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EmployeeService", x => new { x.EmployeesID, x.ServicesID });
                    table.ForeignKey(
                        name: "FK_EmployeeService_Employee_EmployeesID",
                        column: x => x.EmployeesID,
                        principalTable: "Employee",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_EmployeeService_Services_ServicesID",
                        column: x => x.ServicesID,
                        principalTable: "Services",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Manager",
                columns: table => new
                {
                    ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Manager", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Manager_Employee_ID",
                        column: x => x.ID,
                        principalTable: "Employee",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "FullAddresses",
                columns: new[] { "ID", "City", "PostalCode", "Province", "Street" },
                values: new object[,]
                {
                    { 1, "Springfield", "62704", "IL", "123 Main St" },
                    { 2, "Shelbyville", "62705", "IL", "456 Oak Ave" },
                    { 3, "Soccer", "532344", "IL", "123 Rav St" },
                    { 4, "Basketball", "112484", "IL", "123 Abbe St" },
                    { 5, "goodluck", "125404", "IL", "123 Eric St" },
                    { 6, "Bye", "22304", "IL", "123 Claire St" },
                    { 7, "Hi", "85704", "IL", "123 Lex St" },
                    { 8, "Goodbye", "45404", "IL", "123 Ryan St" },
                    { 9, "BCIT", "35204", "IL", "123 Noah St" },
                    { 10, "OS", "75404", "IL", "123 Nolan St" },
                    { 11, "Practice", "20504", "IL", "123 Rahim St" },
                    { 12, "LOL", "02204", "IL", "123 Graves St" },
                    { 133, "Capital City", "62706", "IL", "789 Pine Rd" }
                });

            migrationBuilder.InsertData(
                table: "FullName",
                columns: new[] { "Id", "FirstName", "LastName" },
                values: new object[,]
                {
                    { 1, "John", "Doe" },
                    { 2, "Jane", "Smith" },
                    { 3, "Alice", "Johnson" },
                    { 4, "whatever", "yor" },
                    { 5, "you", "ABC" },
                    { 6, "say", "DEF" },
                    { 7, "Iam", "HIJ" },
                    { 8, "better", "morning" },
                    { 9, "than", "night" },
                    { 10, "you", "dawn" },
                    { 11, "sooo", "Twilight" },
                    { 12, "man", "dummy" },
                    { 13, "up", "data" }
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

            migrationBuilder.CreateIndex(
                name: "IX_ClientService_ServicesID",
                table: "ClientService",
                column: "ServicesID");

            migrationBuilder.CreateIndex(
                name: "IX_Contact_ClientID",
                table: "Contact",
                column: "ClientID");

            migrationBuilder.CreateIndex(
                name: "IX_Contact_EmployeeID",
                table: "Contact",
                column: "EmployeeID");

            migrationBuilder.CreateIndex(
                name: "IX_Employee_ManagerID",
                table: "Employee",
                column: "ManagerID");

            migrationBuilder.CreateIndex(
                name: "IX_EmployeeService_ServicesID",
                table: "EmployeeService",
                column: "ServicesID");

            migrationBuilder.CreateIndex(
                name: "IX_People_FullAdressId",
                table: "People",
                column: "FullAdressId");

            migrationBuilder.CreateIndex(
                name: "IX_People_FullNameId",
                table: "People",
                column: "FullNameId");

            migrationBuilder.AddForeignKey(
                name: "FK_Contact_Employee_EmployeeID",
                table: "Contact",
                column: "EmployeeID",
                principalTable: "Employee",
                principalColumn: "ID");

            migrationBuilder.AddForeignKey(
                name: "FK_Employee_Manager_ManagerID",
                table: "Employee",
                column: "ManagerID",
                principalTable: "Manager",
                principalColumn: "ID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Employee_People_ID",
                table: "Employee");

            migrationBuilder.DropForeignKey(
                name: "FK_Manager_Employee_ID",
                table: "Manager");

            migrationBuilder.DropTable(
                name: "ClientService");

            migrationBuilder.DropTable(
                name: "Contact");

            migrationBuilder.DropTable(
                name: "EmployeeService");

            migrationBuilder.DropTable(
                name: "Clients");

            migrationBuilder.DropTable(
                name: "Services");

            migrationBuilder.DropTable(
                name: "People");

            migrationBuilder.DropTable(
                name: "FullAddresses");

            migrationBuilder.DropTable(
                name: "FullName");

            migrationBuilder.DropTable(
                name: "Employee");

            migrationBuilder.DropTable(
                name: "Manager");
        }
    }
}
