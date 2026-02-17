using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ProEventos.API.Data.Migrations
{
    public partial class DataTest : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Eventos",
                columns: new[] { "EventoId", "DataEvento", "ImagemURL", "Local", "Lote", "QtdPessoas", "Tema" },
                values: new object[] { 1, new DateTime(2026, 2, 19, 18, 46, 23, 868, DateTimeKind.Local).AddTicks(2178), "foto1.png", "Rio de Janeiro", "1o Lote", 250, "Angular 11 e .NET 5" });

            migrationBuilder.InsertData(
                table: "Eventos",
                columns: new[] { "EventoId", "DataEvento", "ImagemURL", "Local", "Lote", "QtdPessoas", "Tema" },
                values: new object[] { 2, new DateTime(2026, 2, 20, 18, 46, 23, 869, DateTimeKind.Local).AddTicks(7087), "foto2.png", "São Paulo", "2o Lote", 250, "Angular 11 e .NET 5" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Eventos",
                keyColumn: "EventoId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Eventos",
                keyColumn: "EventoId",
                keyValue: 2);
        }
    }
}
