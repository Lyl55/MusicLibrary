using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MusicLibrary.DataAccess.Abstract;
using MusicLibrary.Entities.Concrete;

namespace MusicLibrary.DataAccess.Concrete.EntityFramework
{
    public class EfGenreDal:EfEntityRepositoryBase<Genre,MusicLibContext>,IGenreDal
    {
    }
}
