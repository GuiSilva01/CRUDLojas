using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CRUDLojas.Migrations
{
    public partial class inicio2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "DataCadastro",
                table: "Loja",
                nullable: true,
                oldClrType: typeof(DateTime));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "DataCadastro",
                table: "Loja",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);
        }
    }
}
