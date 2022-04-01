
namespace WindowsFormsApp.CrudForms
{
    partial class MusicForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.dgwMusics = new System.Windows.Forms.DataGridView();
            this.dgwGenres = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.gbxCrud = new System.Windows.Forms.GroupBox();
            this.cmbmusicsearch = new System.Windows.Forms.ComboBox();
            this.gbxSearchMusic = new System.Windows.Forms.GroupBox();
            this.btnsearchmusic = new System.Windows.Forms.Button();
            this.cmbGenreId = new System.Windows.Forms.ComboBox();
            this.tbxMusicSearch = new System.Windows.Forms.TextBox();
            this.lblGenreSearch = new System.Windows.Forms.Label();
            this.lblMusicNameSearch = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.cmbGenre = new System.Windows.Forms.ComboBox();
            this.tbxName = new System.Windows.Forms.TextBox();
            this.lblGenre = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.gbxCrudGenre = new System.Windows.Forms.GroupBox();
            this.btngenresearch = new System.Windows.Forms.Button();
            this.cmbgenresearch = new System.Windows.Forms.ComboBox();
            this.gbxSearchGenre = new System.Windows.Forms.GroupBox();
            this.tbxGenreSerach = new System.Windows.Forms.TextBox();
            this.lblGenreNameSearch = new System.Windows.Forms.Label();
            this.btnGenreDelete = new System.Windows.Forms.Button();
            this.btnGenreUpdate = new System.Windows.Forms.Button();
            this.btnGenreAdd = new System.Windows.Forms.Button();
            this.tbxGenreName = new System.Windows.Forms.TextBox();
            this.lblGenreName = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwMusics)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgwGenres)).BeginInit();
            this.panel1.SuspendLayout();
            this.gbxCrud.SuspendLayout();
            this.gbxSearchMusic.SuspendLayout();
            this.panel2.SuspendLayout();
            this.gbxCrudGenre.SuspendLayout();
            this.gbxSearchGenre.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.78261F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 49.21739F));
            this.tableLayoutPanel1.Controls.Add(this.dgwMusics, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.dgwGenres, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.panel2, 1, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1150, 684);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // dgwMusics
            // 
            this.dgwMusics.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgwMusics.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwMusics.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgwMusics.Location = new System.Drawing.Point(3, 3);
            this.dgwMusics.Name = "dgwMusics";
            this.dgwMusics.RowHeadersWidth = 51;
            this.dgwMusics.RowTemplate.Height = 24;
            this.dgwMusics.Size = new System.Drawing.Size(578, 336);
            this.dgwMusics.TabIndex = 1;
            this.dgwMusics.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgwMusics_CellClick);
            this.dgwMusics.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgwMusics_CellContentClick);
            // 
            // dgwGenres
            // 
            this.dgwGenres.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgwGenres.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwGenres.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgwGenres.Location = new System.Drawing.Point(587, 3);
            this.dgwGenres.Name = "dgwGenres";
            this.dgwGenres.RowHeadersWidth = 51;
            this.dgwGenres.RowTemplate.Height = 24;
            this.dgwGenres.Size = new System.Drawing.Size(560, 336);
            this.dgwGenres.TabIndex = 2;
            this.dgwGenres.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgwGenres_CellClick);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.gbxCrud);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 345);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(578, 336);
            this.panel1.TabIndex = 3;
            // 
            // gbxCrud
            // 
            this.gbxCrud.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.gbxCrud.Controls.Add(this.cmbmusicsearch);
            this.gbxCrud.Controls.Add(this.gbxSearchMusic);
            this.gbxCrud.Controls.Add(this.btnDelete);
            this.gbxCrud.Controls.Add(this.btnUpdate);
            this.gbxCrud.Controls.Add(this.btnAdd);
            this.gbxCrud.Controls.Add(this.cmbGenre);
            this.gbxCrud.Controls.Add(this.tbxName);
            this.gbxCrud.Controls.Add(this.lblGenre);
            this.gbxCrud.Controls.Add(this.lblName);
            this.gbxCrud.Location = new System.Drawing.Point(0, 0);
            this.gbxCrud.Name = "gbxCrud";
            this.gbxCrud.Size = new System.Drawing.Size(577, 336);
            this.gbxCrud.TabIndex = 1;
            this.gbxCrud.TabStop = false;
            this.gbxCrud.Text = "CRUD Operations";
            this.gbxCrud.Enter += new System.EventHandler(this.gbxCrud_Enter);
            // 
            // cmbmusicsearch
            // 
            this.cmbmusicsearch.FormattingEnabled = true;
            this.cmbmusicsearch.Items.AddRange(new object[] {
            "contains",
            "startwith",
            "endswith"});
            this.cmbmusicsearch.Location = new System.Drawing.Point(450, 256);
            this.cmbmusicsearch.Name = "cmbmusicsearch";
            this.cmbmusicsearch.Size = new System.Drawing.Size(121, 24);
            this.cmbmusicsearch.TabIndex = 8;
            // 
            // gbxSearchMusic
            // 
            this.gbxSearchMusic.Controls.Add(this.btnsearchmusic);
            this.gbxSearchMusic.Controls.Add(this.cmbGenreId);
            this.gbxSearchMusic.Controls.Add(this.tbxMusicSearch);
            this.gbxSearchMusic.Controls.Add(this.lblGenreSearch);
            this.gbxSearchMusic.Controls.Add(this.lblMusicNameSearch);
            this.gbxSearchMusic.Location = new System.Drawing.Point(31, 215);
            this.gbxSearchMusic.Name = "gbxSearchMusic";
            this.gbxSearchMusic.Size = new System.Drawing.Size(540, 118);
            this.gbxSearchMusic.TabIndex = 7;
            this.gbxSearchMusic.TabStop = false;
            this.gbxSearchMusic.Text = "Search";
            // 
            // btnsearchmusic
            // 
            this.btnsearchmusic.Location = new System.Drawing.Point(436, 89);
            this.btnsearchmusic.Name = "btnsearchmusic";
            this.btnsearchmusic.Size = new System.Drawing.Size(75, 23);
            this.btnsearchmusic.TabIndex = 5;
            this.btnsearchmusic.Text = "Search";
            this.btnsearchmusic.UseVisualStyleBackColor = true;
            this.btnsearchmusic.Click += new System.EventHandler(this.btnsearchmusic_Click);
            // 
            // cmbGenreId
            // 
            this.cmbGenreId.FormattingEnabled = true;
            this.cmbGenreId.Location = new System.Drawing.Point(120, 78);
            this.cmbGenreId.Name = "cmbGenreId";
            this.cmbGenreId.Size = new System.Drawing.Size(214, 24);
            this.cmbGenreId.TabIndex = 4;
            // 
            // tbxMusicSearch
            // 
            this.tbxMusicSearch.Location = new System.Drawing.Point(120, 39);
            this.tbxMusicSearch.Name = "tbxMusicSearch";
            this.tbxMusicSearch.Size = new System.Drawing.Size(214, 22);
            this.tbxMusicSearch.TabIndex = 3;
            // 
            // lblGenreSearch
            // 
            this.lblGenreSearch.AutoSize = true;
            this.lblGenreSearch.Location = new System.Drawing.Point(15, 78);
            this.lblGenreSearch.Name = "lblGenreSearch";
            this.lblGenreSearch.Size = new System.Drawing.Size(48, 17);
            this.lblGenreSearch.TabIndex = 2;
            this.lblGenreSearch.Text = "Genre";
            // 
            // lblMusicNameSearch
            // 
            this.lblMusicNameSearch.AutoSize = true;
            this.lblMusicNameSearch.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.lblMusicNameSearch.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.lblMusicNameSearch.Location = new System.Drawing.Point(15, 44);
            this.lblMusicNameSearch.Name = "lblMusicNameSearch";
            this.lblMusicNameSearch.Size = new System.Drawing.Size(45, 17);
            this.lblMusicNameSearch.TabIndex = 1;
            this.lblMusicNameSearch.Text = "Name";
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(368, 167);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(100, 42);
            this.btnDelete.TabIndex = 6;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(203, 167);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(101, 42);
            this.btnUpdate.TabIndex = 5;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(31, 167);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(101, 42);
            this.btnAdd.TabIndex = 4;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // cmbGenre
            // 
            this.cmbGenre.FormattingEnabled = true;
            this.cmbGenre.Location = new System.Drawing.Point(151, 97);
            this.cmbGenre.Name = "cmbGenre";
            this.cmbGenre.Size = new System.Drawing.Size(214, 24);
            this.cmbGenre.TabIndex = 3;
            // 
            // tbxName
            // 
            this.tbxName.Location = new System.Drawing.Point(151, 45);
            this.tbxName.Name = "tbxName";
            this.tbxName.Size = new System.Drawing.Size(214, 22);
            this.tbxName.TabIndex = 2;
            // 
            // lblGenre
            // 
            this.lblGenre.AutoSize = true;
            this.lblGenre.Location = new System.Drawing.Point(28, 100);
            this.lblGenre.Name = "lblGenre";
            this.lblGenre.Size = new System.Drawing.Size(48, 17);
            this.lblGenre.TabIndex = 1;
            this.lblGenre.Text = "Genre";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.lblName.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.lblName.Location = new System.Drawing.Point(28, 51);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(45, 17);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Name";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.gbxCrudGenre);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(587, 345);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(560, 336);
            this.panel2.TabIndex = 4;
            // 
            // gbxCrudGenre
            // 
            this.gbxCrudGenre.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.gbxCrudGenre.Controls.Add(this.gbxSearchGenre);
            this.gbxCrudGenre.Controls.Add(this.btnGenreDelete);
            this.gbxCrudGenre.Controls.Add(this.btnGenreUpdate);
            this.gbxCrudGenre.Controls.Add(this.btnGenreAdd);
            this.gbxCrudGenre.Controls.Add(this.tbxGenreName);
            this.gbxCrudGenre.Controls.Add(this.lblGenreName);
            this.gbxCrudGenre.Location = new System.Drawing.Point(-7, 0);
            this.gbxCrudGenre.Name = "gbxCrudGenre";
            this.gbxCrudGenre.Size = new System.Drawing.Size(581, 339);
            this.gbxCrudGenre.TabIndex = 2;
            this.gbxCrudGenre.TabStop = false;
            this.gbxCrudGenre.Text = "CRUD Operations";
            // 
            // btngenresearch
            // 
            this.btngenresearch.Location = new System.Drawing.Point(396, 74);
            this.btngenresearch.Name = "btngenresearch";
            this.btngenresearch.Size = new System.Drawing.Size(75, 23);
            this.btngenresearch.TabIndex = 10;
            this.btngenresearch.Text = "Search";
            this.btngenresearch.UseVisualStyleBackColor = true;
            // 
            // cmbgenresearch
            // 
            this.cmbgenresearch.FormattingEnabled = true;
            this.cmbgenresearch.Items.AddRange(new object[] {
            "contains",
            "startwith",
            "endswith"});
            this.cmbgenresearch.Location = new System.Drawing.Point(374, 32);
            this.cmbgenresearch.Name = "cmbgenresearch";
            this.cmbgenresearch.Size = new System.Drawing.Size(121, 24);
            this.cmbgenresearch.TabIndex = 9;
            // 
            // gbxSearchGenre
            // 
            this.gbxSearchGenre.Controls.Add(this.btngenresearch);
            this.gbxSearchGenre.Controls.Add(this.tbxGenreSerach);
            this.gbxSearchGenre.Controls.Add(this.cmbgenresearch);
            this.gbxSearchGenre.Controls.Add(this.lblGenreNameSearch);
            this.gbxSearchGenre.Location = new System.Drawing.Point(48, 230);
            this.gbxSearchGenre.Name = "gbxSearchGenre";
            this.gbxSearchGenre.Size = new System.Drawing.Size(510, 109);
            this.gbxSearchGenre.TabIndex = 5;
            this.gbxSearchGenre.TabStop = false;
            this.gbxSearchGenre.Text = "Search";
            // 
            // tbxGenreSerach
            // 
            this.tbxGenreSerach.Location = new System.Drawing.Point(119, 35);
            this.tbxGenreSerach.Name = "tbxGenreSerach";
            this.tbxGenreSerach.Size = new System.Drawing.Size(209, 22);
            this.tbxGenreSerach.TabIndex = 2;
            // 
            // lblGenreNameSearch
            // 
            this.lblGenreNameSearch.AutoSize = true;
            this.lblGenreNameSearch.Location = new System.Drawing.Point(17, 35);
            this.lblGenreNameSearch.Name = "lblGenreNameSearch";
            this.lblGenreNameSearch.Size = new System.Drawing.Size(45, 17);
            this.lblGenreNameSearch.TabIndex = 1;
            this.lblGenreNameSearch.Text = "Name";
            // 
            // btnGenreDelete
            // 
            this.btnGenreDelete.Location = new System.Drawing.Point(419, 155);
            this.btnGenreDelete.Name = "btnGenreDelete";
            this.btnGenreDelete.Size = new System.Drawing.Size(100, 42);
            this.btnGenreDelete.TabIndex = 4;
            this.btnGenreDelete.Text = "Delete";
            this.btnGenreDelete.UseVisualStyleBackColor = true;
            this.btnGenreDelete.Click += new System.EventHandler(this.btnGenreDelete_Click);
            // 
            // btnGenreUpdate
            // 
            this.btnGenreUpdate.Location = new System.Drawing.Point(233, 155);
            this.btnGenreUpdate.Name = "btnGenreUpdate";
            this.btnGenreUpdate.Size = new System.Drawing.Size(99, 42);
            this.btnGenreUpdate.TabIndex = 3;
            this.btnGenreUpdate.Text = "Update";
            this.btnGenreUpdate.UseVisualStyleBackColor = true;
            this.btnGenreUpdate.Click += new System.EventHandler(this.btnGenreUpdate_Click);
            // 
            // btnGenreAdd
            // 
            this.btnGenreAdd.Location = new System.Drawing.Point(48, 155);
            this.btnGenreAdd.Name = "btnGenreAdd";
            this.btnGenreAdd.Size = new System.Drawing.Size(98, 42);
            this.btnGenreAdd.TabIndex = 2;
            this.btnGenreAdd.Text = "Add";
            this.btnGenreAdd.UseVisualStyleBackColor = true;
            this.btnGenreAdd.Click += new System.EventHandler(this.btnGenreAdd_Click);
            // 
            // tbxGenreName
            // 
            this.tbxGenreName.Location = new System.Drawing.Point(167, 36);
            this.tbxGenreName.Name = "tbxGenreName";
            this.tbxGenreName.Size = new System.Drawing.Size(209, 22);
            this.tbxGenreName.TabIndex = 1;
            // 
            // lblGenreName
            // 
            this.lblGenreName.AutoSize = true;
            this.lblGenreName.Location = new System.Drawing.Point(30, 39);
            this.lblGenreName.Name = "lblGenreName";
            this.lblGenreName.Size = new System.Drawing.Size(45, 17);
            this.lblGenreName.TabIndex = 0;
            this.lblGenreName.Text = "Name";
            // 
            // MusicForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1150, 684);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "MusicForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.MusicForm_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgwMusics)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgwGenres)).EndInit();
            this.panel1.ResumeLayout(false);
            this.gbxCrud.ResumeLayout(false);
            this.gbxCrud.PerformLayout();
            this.gbxSearchMusic.ResumeLayout(false);
            this.gbxSearchMusic.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.gbxCrudGenre.ResumeLayout(false);
            this.gbxCrudGenre.PerformLayout();
            this.gbxSearchGenre.ResumeLayout(false);
            this.gbxSearchGenre.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.DataGridView dgwMusics;
        private System.Windows.Forms.DataGridView dgwGenres;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.GroupBox gbxCrud;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.ComboBox cmbGenre;
        private System.Windows.Forms.TextBox tbxName;
        private System.Windows.Forms.Label lblGenre;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.GroupBox gbxCrudGenre;
        private System.Windows.Forms.Button btnGenreDelete;
        private System.Windows.Forms.Button btnGenreUpdate;
        private System.Windows.Forms.Button btnGenreAdd;
        private System.Windows.Forms.TextBox tbxGenreName;
        private System.Windows.Forms.Label lblGenreName;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.ComboBox cmbmusicsearch;
        private System.Windows.Forms.GroupBox gbxSearchMusic;
        private System.Windows.Forms.Button btnsearchmusic;
        private System.Windows.Forms.ComboBox cmbGenreId;
        private System.Windows.Forms.TextBox tbxMusicSearch;
        private System.Windows.Forms.Label lblGenreSearch;
        private System.Windows.Forms.Label lblMusicNameSearch;
        private System.Windows.Forms.Button btngenresearch;
        private System.Windows.Forms.ComboBox cmbgenresearch;
        private System.Windows.Forms.GroupBox gbxSearchGenre;
        private System.Windows.Forms.TextBox tbxGenreSerach;
        private System.Windows.Forms.Label lblGenreNameSearch;
    }
}