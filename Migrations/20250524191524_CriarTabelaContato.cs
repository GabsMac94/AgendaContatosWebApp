﻿using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace AgendaContatos.Migrations
{
    /// <inheritdoc />
    public partial class CriarTabelaContato : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Contatos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Nome = table.Column<string>(type: "text", nullable: false),
                    Apelido = table.Column<string>(type: "text", nullable: false),
                    CPF = table.Column<string>(type: "text", nullable: false),
                    Telefone = table.Column<string>(type: "text", nullable: false),
                    Email = table.Column<string>(type: "text", nullable: false),
                    DataCadastro = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    DataUltimaAlteracao = table.Column<DateTime>(type: "timestamp with time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Contatos", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Contatos");
        }
    }
}
