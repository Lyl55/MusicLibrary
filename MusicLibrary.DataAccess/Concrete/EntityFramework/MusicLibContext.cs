using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MusicLibrary.DataAccess.Concrete.EntityFramework.Mappings;
using MusicLibrary.Entities.Concrete;

namespace MusicLibrary.DataAccess.Concrete.EntityFramework
{
    public class MusicLibContext:DbContext
    {
        public DbSet<Genre> Genres { get; set; }
        public DbSet<Music> Musics { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new GenreMap());
            modelBuilder.Configurations.Add(new MusicMap());

        }
    }
}
