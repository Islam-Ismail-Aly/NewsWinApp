using NewsApp.Core.Data;
using NewsApp.Core.Models;
using NewsApp.PresentationLayer.Helpers;

namespace NewsApp.PresentationLayer
{
    public partial class Mainfrm : Form
    {
        private readonly ApplicationDBContext _db;
        private int _id;
        public Mainfrm()
        {
            InitializeComponent();
            _db = new ApplicationDBContext();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void LoadData()
        {
            MessageBox.Show("Welcome to News Application!", "Welcome", MessageBoxButtons.OK, MessageBoxIcon.Information);

            dataGrid.DataSource = _db.News.Select(s => new { Id = s.Id, Title = s.Title, Brief = s.Brief, Description = s.Description, CreationDate = s.CreationDate, Author = s.Author.UserName, Catalog = s.Catalog.Name }).ToList();

            cb_Author.DataSource = _db.Authors.Select(d => new { d.Id, d.UserName }).ToList();
            cb_Author.DisplayMember = "UserName";
            cb_Author.ValueMember = "Id";

            cb_Catalog.DataSource = _db.Catalogs.Select(s => new { s.Name, s.Id }).ToList();
            cb_Catalog.DisplayMember = "Name";
            cb_Catalog.ValueMember = "Id";

            cb_Author.SelectedIndex = -1;
            cb_Catalog.SelectedIndex = -1;

            dataGrid.Columns["Id"].Visible = false;
        }

        private void Mainfrm_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btn_Profile_Click(object sender, EventArgs e)
        {
            Profilefrm profilefrm = new Profilefrm();
            // Close this form when the mainfrm is closed
            //profilefrm.FormClosed += (s, args) => this.Close();
            profilefrm.ShowDialog();
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            News news = new News
            {
                Title = txt_Title.Text,
                Brief = txt_Breif.Text,
                CreationDate = dateTime.Value,
                Description = txt_Description.Text,
                AuthorId = (int)cb_Author.SelectedValue,
                CatalogId = (int)cb_Catalog.SelectedValue
            };

            _db.News.Add(news);
            _db.SaveChanges();

            LoadData();

            ControlHelperManager.ClearControl(this.Controls);
            MessageBox.Show("The Item has been saved successfully!", "Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btn_Update_Click(object sender, EventArgs e)
        {
            if (dataGrid.SelectedRows.Count > 0)
            {
                int selectedId = (int)dataGrid.SelectedRows[0].Cells["Id"].Value;

                News news = _db.News.Find(selectedId);

                news.Title = txt_Title.Text;
                news.Brief = txt_Breif.Text;
                news.CreationDate = dateTime.Value;
                news.Description = txt_Description.Text;
                news.AuthorId = (int)cb_Author.SelectedValue;
                news.CatalogId = (int)cb_Catalog.SelectedValue;

                _db.SaveChanges();

                LoadData();
                ControlHelperManager.ClearControl(this.Controls);
                MessageBox.Show("The Item has been updated successfully!", "Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            if (dataGrid.SelectedRows.Count > 0)
            {
                int selectedId = (int)dataGrid.SelectedRows[0].Cells["Id"].Value;

                News news = _db.News.Find(selectedId);

                _db.News.Remove(news);
                _db.SaveChanges();

                LoadData();
                ControlHelperManager.ClearControl(this.Controls);
                MessageBox.Show("The Item has been deleted successfully!", "Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void dataGrid_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            DataGridViewRow selectedRow = dataGrid.Rows[e.RowIndex];

            News news = _db.News.FirstOrDefault(s => s.Id == Convert.ToInt32(selectedRow.Cells["Id"].Value));

            txt_Title.Text = news.Title;
            txt_Breif.Text = news.Brief;
            txt_Description.Text = news.Description;
            dateTime.Value = news.CreationDate;

            cb_Author.SelectedValue = news.AuthorId != null ? cb_Author.SelectedValue = news.AuthorId : cb_Author.SelectedIndex = -1;
            cb_Catalog.SelectedValue = news.CatalogId != null ? cb_Catalog.SelectedValue = news.CatalogId : cb_Catalog.SelectedIndex = -1;

            btn_Delete.Visible = true;
            btn_Update.Visible = true;
            btn_Save.Visible = false;
        }
    }
}
