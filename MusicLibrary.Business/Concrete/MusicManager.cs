﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using MusicLibrary.Business.Abstract;
using MusicLibrary.DataAccess.Abstract;
using MusicLibrary.Entities.Concrete;

namespace MusicLibrary.Business.Concrete
{
    public class MusicManager : IMusicService
    {
        private readonly IMusicDal _musicDal;

        public MusicManager(IMusicDal musicDal)
        {
            this._musicDal = musicDal;
        }

        public void Add(Music music)
        {
            this._musicDal.Add(music);
        }

        public void Update(Music music)
        {
            this._musicDal.Update(music);
        }

        public void Delete(Music music)
        {
            this._musicDal.Delete(music);
        }

        public void DeleteAll()
        {
            _musicDal.DeleteAll();
        }

        public Music Get(int id)
        {
            return this._musicDal.Get(x => x.Id == id);
        }

        public List<Music> GetAll()
        {
            return this._musicDal.GetAll();
        }

        public int GetIndexId()
        {
            return this._musicDal.GetNextId();
        }

        public List<Music> GetByGenreId(int genreId)
        {
            return this._musicDal.GetAll(x => x.GenreId == genreId);
        }

        public List<Music> Search(string name, int genreId, int strParam)
        {
            var result = new List<Music>();
            switch (GetSearchOption(name, genreId))
            {
                case 0:
                    result = _musicDal.GetAll();
                    break;
                case 1:
                    SearchCase(name,strParam);
                    break;
                case 2:
                    result = _musicDal.GetAll(m => m.GenreId == genreId);
                    break;
                case 3:
                    SearchCase(name, genreId, strParam);
                    break;

            }

            return result;
        }


        public List<Music> SearchCase(string name,int strParam)
        {
            var result = new List<Music>();

            switch (strParam)
            {
                case 0:
                    result = _musicDal.GetAll(m => m.Name.Contains((name)));
                    break;
                case 1:
                    result = _musicDal.GetAll(m => m.Name.StartsWith(name));
                    break;
                case 2:
                    result = _musicDal.GetAll(m => m.Name.EndsWith(name));
                    break;
            }
            return result;
        }

        public List<Music> SearchCase(string name, int genreId, int strParam)
        {
            var result = new List<Music>();

            switch (strParam)
            {
                case 0:
                    result = _musicDal.GetAll(m => m.Name.Contains(name) & m.GenreId == genreId);
                    break;
                case 1:
                    result = _musicDal.GetAll(m => m.Name.StartsWith(name) & m.GenreId == genreId);
                    break;
                case 2:
                    result = _musicDal.GetAll(m => m.Name.EndsWith(name) & m.GenreId == genreId);
                    break;
            }

            return result;
        }



        /// <summary>
        /// 0->no param
        /// 1->name
        /// 2->genre
        /// 3->name+genre
        /// </summary>
        /// <param name="name"></param>
        /// <param name="genreId"></param>
        /// <returns></returns>
        private int GetSearchOption(string name, int genreId)
        {
            var result = 0;
            if (name.Trim() == "" & genreId != 0)
            {
                result = 3;
            }
            else if (name.Trim() == "")
            {
                result = 1;
            }
            else if (genreId != 0)
            {
                result = 2;
            }

            return result;
        }

    }
}
