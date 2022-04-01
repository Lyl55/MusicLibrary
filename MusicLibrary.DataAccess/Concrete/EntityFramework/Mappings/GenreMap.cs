using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Mapping;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MusicLibrary.Entities.Concrete;
using System.ComponentModel.DataAnnotations.Schema;

namespace MusicLibrary.DataAccess.Concrete.EntityFramework.Mappings
{
    public class GenreMap:EntityTypeConfiguration<Genre>
    {
        public GenreMap()
        {
            ToTable("Genres");
            HasKey(g => g.Id);
            Property(g => g.Name).HasColumnName("Name");
            Property(g => g.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
        }
    }
}
