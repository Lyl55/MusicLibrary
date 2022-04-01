using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MusicLibrary.Entities.Concrete;

namespace MusicLibrary.Business.Abstract
{
    public interface IMusicService
    {
        void Add(Music music);
        void Update(Music music);
        void Delete(Music music);
        void DeleteAll();
        Music Get(int id);
        List<Music> GetAll();
        int GetIndexId();
        List<Music> GetByGenreId(int genreId);
        List<Music> Search(string name, int genreId, int strParam);
    }
}
