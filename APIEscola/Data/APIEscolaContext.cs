﻿using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace APIEscola.Data
{
    public class APIEscolaContext : IdentityDbContext
    {
        public APIEscolaContext(DbContextOptions<APIEscolaContext> options) : base(options)
        {
        }

        //Propriedade DbSet para cada tabela

        //Sobrecarga do método OnModelCreating para configurar o modelo a partir do IdentityDbContext
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //Chama o método OnModelCreating da classe base para a criação das tabelas padrão 
            base.OnModelCreating(modelBuilder);

            //Configurar a criação de tabelas adicionais aqui

        }
    }
}


// =========================================================================================
