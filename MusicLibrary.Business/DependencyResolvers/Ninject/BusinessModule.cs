using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MusicLibrary.Business.Abstract;
using MusicLibrary.Business.Concrete;
using MusicLibrary.DataAccess.Abstract;
using MusicLibrary.DataAccess.Concrete.EntityFramework;
using MusicLibrary.DataAccess.Concrete.EntityFramework.Mappings;
using Ninject.Modules;

namespace MusicLibrary.Business.DependencyResolvers.Ninject
{
    public class BusinessModule:NinjectModule // public etmemisiz :(
    {
        public override void Load()
        {
            Bind<IGenreDal>().To<EfGenreDal>().InSingletonScope();
            Bind<IGenreService>().To<GenreManager>().InSingletonScope();
            Bind<IMusicDal>().To<EfMusicDal>().InSingletonScope();
            Bind<IMusicService>().To<MusicManager>().InSingletonScope();

        }
    }
}
