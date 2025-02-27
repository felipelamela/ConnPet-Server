using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Api.Migrations
{
    /// <inheritdoc />
    public partial class init : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Address",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Number = table.Column<string>(type: "NVARCHAR(30)", maxLength: 30, nullable: false),
                    Complement = table.Column<string>(type: "NVARCHAR(255)", maxLength: 255, nullable: true),
                    Neighborhood = table.Column<string>(type: "NVARCHAR(180)", maxLength: 180, nullable: true),
                    Street = table.Column<string>(type: "NVARCHAR(255)", maxLength: 255, nullable: false),
                    City = table.Column<string>(type: "NVARCHAR(180)", maxLength: 180, nullable: false),
                    State = table.Column<string>(type: "NVARCHAR(50)", maxLength: 50, nullable: false),
                    PostalCode = table.Column<string>(type: "NVARCHAR(8)", maxLength: 8, nullable: false),
                    Country = table.Column<string>(type: "NVARCHAR(30)", maxLength: 30, nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "DATETIME", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "DATETIME", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Address", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "LoginAuth",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Login = table.Column<string>(type: "NVARCHAR(300)", nullable: false),
                    Password = table.Column<string>(type: "NVARCHAR(300)", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "DATETIME", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "DATETIME", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LoginAuth", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Tutor",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "NVARCHAR(255)", nullable: false),
                    Login = table.Column<string>(type: "NVARCHAR(300)", nullable: false),
                    Password = table.Column<string>(type: "NVARCHAR(300)", nullable: false),
                    Document = table.Column<string>(type: "NVARCHAR(14)", nullable: false),
                    AddressId = table.Column<long>(type: "bigint", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "DATETIME", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "DATETIME", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tutor", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Tutor_Address_AddressId",
                        column: x => x.AddressId,
                        principalTable: "Address",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Pet",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "NVARCHAR(8)", nullable: false),
                    BirthDate = table.Column<DateTime>(type: "DATETIME", nullable: false),
                    Species = table.Column<string>(type: "NVARCHAR(20)", nullable: false),
                    Breed = table.Column<string>(type: "NVARCHAR(30)", nullable: false),
                    Sex = table.Column<string>(type: "CHAR(1)", nullable: false),
                    TutorId = table.Column<long>(type: "BIGINT", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "DATETIME", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "DATETIME", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pet", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Pet_Tutor_TutorId",
                        column: x => x.TutorId,
                        principalTable: "Tutor",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Clinic",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CorporateName = table.Column<string>(type: "NVARCHAR(255)", nullable: false),
                    TradingName = table.Column<string>(type: "NVARCHAR(255)", nullable: false),
                    CNPJ = table.Column<string>(type: "NVARCHAR(14)", nullable: false),
                    StateRegistration = table.Column<string>(type: "NVARCHAR(50)", nullable: false),
                    MunicipalRegistration = table.Column<string>(type: "NVARCHAR(50)", nullable: false),
                    Contact = table.Column<string>(type: "NVARCHAR(100)", nullable: false),
                    Email = table.Column<string>(type: "NVARCHAR(255)", nullable: false),
                    DigitalCertification = table.Column<string>(type: "NVARCHAR(255)", nullable: false),
                    Document = table.Column<string>(type: "NVARCHAR(50)", nullable: false),
                    UserAdminId = table.Column<long>(type: "BIGINT", nullable: false),
                    AddressId = table.Column<long>(type: "BIGINT", nullable: false),
                    AddressId1 = table.Column<long>(type: "bigint", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Clinic", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Clinic_Address_AddressId",
                        column: x => x.AddressId,
                        principalTable: "Address",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Clinic_Address_AddressId1",
                        column: x => x.AddressId1,
                        principalTable: "Address",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "User",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "NVARCHAR(255)", nullable: false),
                    Document = table.Column<string>(type: "NVARCHAR(14)", nullable: false),
                    CRMV = table.Column<string>(type: "NVARCHAR(50)", nullable: true),
                    StatusWorker = table.Column<string>(type: "CHAR(1)", nullable: false),
                    Type = table.Column<string>(type: "CHAR(1)", nullable: false),
                    LoginAuthId = table.Column<long>(type: "BIGINT", nullable: false),
                    AddressId = table.Column<long>(type: "BIGINT", nullable: false),
                    ClinicId = table.Column<long>(type: "BIGINT", nullable: false),
                    AddressId1 = table.Column<long>(type: "bigint", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "DATETIME", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "DATETIME", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_User", x => x.Id);
                    table.ForeignKey(
                        name: "FK_User_Address_AddressId",
                        column: x => x.AddressId,
                        principalTable: "Address",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_User_Address_AddressId1",
                        column: x => x.AddressId1,
                        principalTable: "Address",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_User_Clinic_ClinicId",
                        column: x => x.ClinicId,
                        principalTable: "Clinic",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_User_LoginAuth_LoginAuthId",
                        column: x => x.LoginAuthId,
                        principalTable: "LoginAuth",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Consultation",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Reason = table.Column<string>(type: "NVARCHAR(500)", nullable: false),
                    Status = table.Column<string>(type: "NVARCHAR(20)", nullable: false),
                    Diagnosis = table.Column<string>(type: "NVARCHAR(500)", nullable: false),
                    Observation = table.Column<string>(type: "NVARCHAR(1000)", nullable: false),
                    DateSchedule = table.Column<DateTime>(type: "DATETIME", nullable: false),
                    ClinicId = table.Column<long>(type: "bigint", nullable: false),
                    VetId = table.Column<long>(type: "bigint", nullable: false),
                    PetId = table.Column<long>(type: "bigint", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Consultation", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Consultation_Clinic_ClinicId",
                        column: x => x.ClinicId,
                        principalTable: "Clinic",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Consultation_Pet_PetId",
                        column: x => x.PetId,
                        principalTable: "Pet",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Consultation_User_VetId",
                        column: x => x.VetId,
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Clinic_AddressId",
                table: "Clinic",
                column: "AddressId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Clinic_AddressId1",
                table: "Clinic",
                column: "AddressId1");

            migrationBuilder.CreateIndex(
                name: "IX_Clinic_UserAdminId",
                table: "Clinic",
                column: "UserAdminId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Consultation_ClinicId",
                table: "Consultation",
                column: "ClinicId");

            migrationBuilder.CreateIndex(
                name: "IX_Consultation_PetId",
                table: "Consultation",
                column: "PetId");

            migrationBuilder.CreateIndex(
                name: "IX_Consultation_VetId",
                table: "Consultation",
                column: "VetId");

            migrationBuilder.CreateIndex(
                name: "IX_Pet_TutorId",
                table: "Pet",
                column: "TutorId");

            migrationBuilder.CreateIndex(
                name: "IX_Tutor_AddressId",
                table: "Tutor",
                column: "AddressId");

            migrationBuilder.CreateIndex(
                name: "IX_User_AddressId",
                table: "User",
                column: "AddressId");

            migrationBuilder.CreateIndex(
                name: "IX_User_AddressId1",
                table: "User",
                column: "AddressId1");

            migrationBuilder.CreateIndex(
                name: "IX_User_ClinicId",
                table: "User",
                column: "ClinicId");

            migrationBuilder.CreateIndex(
                name: "IX_User_LoginAuthId",
                table: "User",
                column: "LoginAuthId");

            migrationBuilder.AddForeignKey(
                name: "FK_Clinic_User_UserAdminId",
                table: "Clinic",
                column: "UserAdminId",
                principalTable: "User",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Clinic_Address_AddressId",
                table: "Clinic");

            migrationBuilder.DropForeignKey(
                name: "FK_Clinic_Address_AddressId1",
                table: "Clinic");

            migrationBuilder.DropForeignKey(
                name: "FK_User_Address_AddressId",
                table: "User");

            migrationBuilder.DropForeignKey(
                name: "FK_User_Address_AddressId1",
                table: "User");

            migrationBuilder.DropForeignKey(
                name: "FK_Clinic_User_UserAdminId",
                table: "Clinic");

            migrationBuilder.DropTable(
                name: "Consultation");

            migrationBuilder.DropTable(
                name: "Pet");

            migrationBuilder.DropTable(
                name: "Tutor");

            migrationBuilder.DropTable(
                name: "Address");

            migrationBuilder.DropTable(
                name: "User");

            migrationBuilder.DropTable(
                name: "Clinic");

            migrationBuilder.DropTable(
                name: "LoginAuth");
        }
    }
}
