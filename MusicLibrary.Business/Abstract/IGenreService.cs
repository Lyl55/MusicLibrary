using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MusicLibrary.Entities.Concrete;

namespace MusicLibrary.Business.Abstract
{
    public interface IGenreService
    {
        void Add(Genre genre);
        void Update(Genre genre);
        void Delete(Genre genre);
        void DeleteAll();
        Genre Get(int id);
        List<Genre> GetAll();
        int GetIndexId();
    }
}
