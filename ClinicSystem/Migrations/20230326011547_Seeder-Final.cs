using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ClinicSystem.Migrations
{
    public partial class SeederFinal : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Appointments",
                columns: new[] { "Id", "BirthDate", "Date", "DoctorId", "EndTime", "PatientName", "StartTime" },
                values: new object[,]
                {
                    { 1, new DateTime(1998, 6, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 3, 27, 3, 15, 47, 80, DateTimeKind.Local).AddTicks(1680), 1, new TimeSpan(0, 11, 30, 0, 0), "Omar", new TimeSpan(0, 11, 0, 0, 0) },
                    { 2, new DateTime(1995, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 3, 28, 3, 15, 47, 80, DateTimeKind.Local).AddTicks(1698), 1, new TimeSpan(0, 10, 30, 0, 0), "Mohamed", new TimeSpan(0, 10, 0, 0, 0) },
                    { 3, new DateTime(2000, 2, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 3, 27, 3, 15, 47, 80, DateTimeKind.Local).AddTicks(1703), 2, new TimeSpan(0, 16, 30, 0, 0), "Hosam", new TimeSpan(0, 16, 0, 0, 0) }
                });

            migrationBuilder.InsertData(
                table: "DoctorSchedules",
                columns: new[] { "Id", "Date", "DoctorId", "EndTime", "StartTime" },
                values: new object[,]
                {
                    { 1, 6, 1, new TimeSpan(0, 12, 0, 0, 0), new TimeSpan(0, 10, 0, 0, 0) },
                    { 2, 0, 1, new TimeSpan(0, 12, 0, 0, 0), new TimeSpan(0, 10, 0, 0, 0) },
                    { 3, 1, 1, new TimeSpan(0, 12, 0, 0, 0), new TimeSpan(0, 10, 0, 0, 0) },
                    { 4, 2, 1, new TimeSpan(0, 12, 0, 0, 0), new TimeSpan(0, 10, 0, 0, 0) },
                    { 5, 3, 1, new TimeSpan(0, 12, 0, 0, 0), new TimeSpan(0, 10, 0, 0, 0) },
                    { 6, 6, 2, new TimeSpan(0, 17, 0, 0, 0), new TimeSpan(0, 15, 0, 0, 0) },
                    { 7, 0, 2, new TimeSpan(0, 17, 0, 0, 0), new TimeSpan(0, 15, 0, 0, 0) },
                    { 8, 1, 2, new TimeSpan(0, 17, 0, 0, 0), new TimeSpan(0, 15, 0, 0, 0) },
                    { 9, 2, 2, new TimeSpan(0, 17, 0, 0, 0), new TimeSpan(0, 15, 0, 0, 0) },
                    { 10, 3, 2, new TimeSpan(0, 17, 0, 0, 0), new TimeSpan(0, 15, 0, 0, 0) }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "DoctorSchedules",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "DoctorSchedules",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "DoctorSchedules",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "DoctorSchedules",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "DoctorSchedules",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "DoctorSchedules",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "DoctorSchedules",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "DoctorSchedules",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "DoctorSchedules",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "DoctorSchedules",
                keyColumn: "Id",
                keyValue: 10);
        }
    }
}
