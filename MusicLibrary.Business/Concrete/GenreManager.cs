using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using MusicLibrary.Business.Abstract;
using MusicLibrary.DataAccess.Abstract;
using MusicLibrary.Entities.Concrete;

namespace MusicLibrary.Business.Concrete
{
    class GenreManager:IGenreService
    {
        private readonly IGenreDal _genreDal;

        public GenreManager(IGenreDal genreDal)
        {
            _genreDal = genreDal;
        }


        public void Add(Genre genre)
        {
            _genreDal.Add(genre);
        }

        public void Update(Genre genre)
        {
            _genreDal.Update(genre);
        }

        public void Delete(Genre genre)
        {
            _genreDal.Delete(genre);
        }

        public void DeleteAll()
        {
            _genreDal.DeleteAll();
        }

        public Genre Get(int id)
        {
            return _genreDal.Get(x => x.Id == id);
        }

        public List<Genre> GetAll()
        {
            return _genreDal.GetAll();
        }

        public int GetIndexId()
        {
            return _genreDal.GetNextId();
        }
    }
}
