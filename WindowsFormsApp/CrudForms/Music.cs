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
using Core.Extensions;
using MusicLibrary.Business.Abstract;
using MusicLibrary.Business.DependencyResolvers.Ninject;
using MusicLibrary.Entities.Concrete;

namespace WindowsFormsApp.CrudForms
{
    public partial class MusicForm : Form
    {
        private readonly IGenreService _genreService;
        private readonly IMusicService _musicService;
        public MusicForm()
        {
             InitializeComponent();
            _genreService = InstanceFactory.GetInstance<IGenreService>(new BusinessModule());
            _musicService = InstanceFactory.GetInstance<IMusicService>(new BusinessModule());

        }

        private void dgwGenres_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            tbxName.Text = dgwMusics.CurrentRow?.Cells["Name"].Value.ToString();
        }
        

        private void btnAdd_Click(object sender, EventArgs e)
        {
            _musicService.Add(new Music
            {
                Name = tbxName.Text,
                GenreId=(int)cmbGenre.SelectedValue
            });

            LoadMusics();
            LoadGenres();
            LoadGenresToCmb();

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            _musicService.Update(new Music
            {
                Id = (int)dgwMusics.CurrentRow?.Cells["Id"].Value,
                Name = tbxName.Text,
                GenreId = (int)cmbGenre.SelectedValue
            });
            LoadMusics();
            LoadGenres();
            LoadGenresToCmb();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            _musicService.Delete(new Music
            {
                Id = (int)dgwMusics.CurrentRow?.Cells["Id"].Value
            });
            LoadMusics();
            LoadGenres();
            LoadGenresToCmb();
        }

        private void btnGenreAdd_Click(object sender, EventArgs e)
        {
            _genreService.Add(new Genre
            {
                Name = tbxGenreName.Text
            });
            LoadMusics();
            LoadGenres();
            LoadGenresToCmb();
        }

        private void btnGenreUpdate_Click(object sender, EventArgs e)
        {
            _genreService.Update(new Genre
            {
                Id = (int)dgwGenres.CurrentRow?.Cells["Id"].Value,
                Name = tbxGenreName.Text
            });
            LoadMusics();
            LoadGenres();
            LoadGenresToCmb();
        }

        private void btnGenreDelete_Click(object sender, EventArgs e)
        {
            _genreService.Delete(new Genre
            {
                Id = (int)dgwGenres.CurrentRow?.Cells["Id"].Value
            });
            LoadMusics();
            LoadGenres();
            LoadGenresToCmb();
        }

        private void dgwMusics_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            tbxName.Text = dgwMusics.CurrentRow.Cells["Name"].Value.ToString();
            cmbGenre.SelectedValue = dgwMusics.CurrentRow.Cells["GenreId"].Value;
        }

        private void MusicForm_Load(object sender, EventArgs e)
        {
            LoadGenres();
            LoadMusics();
            LoadGenresToCmb();
        }

        private void LoadGenres()
        {
            dgwGenres.DataSource = _genreService.GetAll();
        }

        private void LoadMusics()
        {
            dgwMusics.DataSource = _musicService.GetAll();
        }

        private void LoadGenresToCmb()
        {
            cmbGenre.DataSource = _genreService.GetAll();
            cmbGenre.DisplayMember = "Name";
            cmbGenre.ValueMember = "Id";
        }

        private void dgwMusics_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void gbxCrud_Enter(object sender, EventArgs e)
        {

        }

        private void btnsearchmusic_Click(object sender, EventArgs e)
        {
            string name = this.tbxMusicSearch.Text;
            int genreId = this.cmbGenreId.SelectedValue.ToInt();
            int strParam = this.cmbmusicsearch.SelectedIndex;
            dgwMusics.DataSource = _musicService.Search(name, genreId, strParam);
        }
    }
}
