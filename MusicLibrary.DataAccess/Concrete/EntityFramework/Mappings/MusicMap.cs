using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MusicLibrary.Entities.Concrete;
using System.ComponentModel.DataAnnotations.Schema;

namespace MusicLibrary.DataAccess.Concrete.EntityFramework.Mappings
{
    public class MusicMap:EntityTypeConfiguration<Music>
    {
        public MusicMap()
        {
            ToTable("Musics");
            HasKey(m => m.Id);
            Property(g => g.Name).HasColumnName("Name");
            Property(g => g.GenreId).HasColumnName("GenreId");
            Property(g => g.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
        }
        
    }
}
