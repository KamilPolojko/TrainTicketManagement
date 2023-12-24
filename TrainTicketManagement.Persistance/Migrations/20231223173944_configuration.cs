using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TrainTicketManagement.Persistance.Migrations
{
    /// <inheritdoc />
    public partial class configuration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "PersonName_LastName",
                table: "Users",
                newName: "LastName");

            migrationBuilder.RenameColumn(
                name: "PersonName_FirstName",
                table: "Users",
                newName: "FirstName");

            migrationBuilder.RenameColumn(
                name: "Email_UserName",
                table: "Users",
                newName: "MailName");

            migrationBuilder.RenameColumn(
                name: "Email_DomainName",
                table: "Users",
                newName: "MailDomain");

            migrationBuilder.RenameColumn(
                name: "Name_SerialNumberOfTrain",
                table: "Trains",
                newName: "SerialNumberOfTrain");

            migrationBuilder.RenameColumn(
                name: "Name_FirstPartOfName",
                table: "Trains",
                newName: "FirstPartOfTheName");

            migrationBuilder.AlterColumn<string>(
                name: "PeselNumber",
                table: "Users",
                type: "nvarchar(11)",
                maxLength: 11,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.UpdateData(
                table: "Trains",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: new DateTime(2023, 12, 23, 18, 39, 43, 609, DateTimeKind.Local).AddTicks(2152));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: new DateTime(2023, 12, 23, 18, 39, 43, 609, DateTimeKind.Local).AddTicks(1648));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "MailName",
                table: "Users",
                newName: "Email_UserName");

            migrationBuilder.RenameColumn(
                name: "MailDomain",
                table: "Users",
                newName: "Email_DomainName");

            migrationBuilder.RenameColumn(
                name: "LastName",
                table: "Users",
                newName: "PersonName_LastName");

            migrationBuilder.RenameColumn(
                name: "FirstName",
                table: "Users",
                newName: "PersonName_FirstName");

            migrationBuilder.RenameColumn(
                name: "SerialNumberOfTrain",
                table: "Trains",
                newName: "Name_SerialNumberOfTrain");

            migrationBuilder.RenameColumn(
                name: "FirstPartOfTheName",
                table: "Trains",
                newName: "Name_FirstPartOfName");

            migrationBuilder.AlterColumn<string>(
                name: "PeselNumber",
                table: "Users",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(11)",
                oldMaxLength: 11);

            migrationBuilder.UpdateData(
                table: "Trains",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: new DateTime(2023, 12, 22, 19, 39, 1, 916, DateTimeKind.Local).AddTicks(1731));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: new DateTime(2023, 12, 22, 19, 39, 1, 916, DateTimeKind.Local).AddTicks(1118));
        }
    }
}
