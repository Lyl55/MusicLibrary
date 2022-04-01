using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Core.DependencyResolvers.Ninject;
using MusicLibrary.Business.Abstract;
using MusicLibrary.Business.Concrete;
using MusicLibrary.Business.DependencyResolvers.Ninject;

namespace WindowsFormsApp
{
    public partial class Form1 : Form
    {
        private readonly IMusicService _musicService;
        private readonly IGenreService _genreService;
        public Form1()
        {
            InitializeComponent();
            _musicService = InstanceFactory.GetInstance<IMusicService>(new BusinessModule());
            _genreService = InstanceFactory.GetInstance<IGenreService>(new BusinessModule());
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.dataGridView1.DataSource = this._musicService.GetAll();
            this.dataGridView1.DataSource = this._genreService.GetAll();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
