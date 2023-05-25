using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MusicaUTN.Modelos;

    public class DataContext : DbContext
    {
        public DataContext (DbContextOptions<DataContext> options)
            : base(options)
        {
        }

        public DbSet<MusicaUTN.Modelos.Autor> Autores { get; set; } = default!;

        public DbSet<MusicaUTN.Modelos.Pista>? Pistas { get; set; }
    }
