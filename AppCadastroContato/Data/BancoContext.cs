using AppCadastroContato.Models;
using Microsoft.EntityFrameworkCore;
using System;

namespace AppCadastroContato.Data
{
    public class BancoContext : DbContext
    {
        public BancoContext(DbContextOptions<BancoContext> options) : base(options)
        { }

        public DbSet<ContatoModel> Contatos { get; set; }

        public DbSet<UsuarioModel> Usuarios { get; set; }

    }
}
