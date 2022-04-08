using Microsoft.EntityFrameworkCore.Migrations;

namespace CoreWebAppExample.Migrations
{
    public partial class third : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_appointment_docID",
                table: "appointment",
                column: "docID");

            migrationBuilder.CreateIndex(
                name: "IX_appointment_ptID",
                table: "appointment",
                column: "ptID");

            migrationBuilder.AddForeignKey(
                name: "FK_appointment_doctor_docID",
                table: "appointment",
                column: "docID",
                principalTable: "doctor",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_appointment_patient_ptID",
                table: "appointment",
                column: "ptID",
                principalTable: "patient",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_appointment_doctor_docID",
                table: "appointment");

            migrationBuilder.DropForeignKey(
                name: "FK_appointment_patient_ptID",
                table: "appointment");

            migrationBuilder.DropIndex(
                name: "IX_appointment_docID",
                table: "appointment");

            migrationBuilder.DropIndex(
                name: "IX_appointment_ptID",
                table: "appointment");
        }
    }
}
