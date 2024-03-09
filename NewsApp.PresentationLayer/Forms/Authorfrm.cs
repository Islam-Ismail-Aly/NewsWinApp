using NewsApp.Core.Data;
using NewsApp.Core.Models;
using NewsApp.PresentationLayer.Helpers;
using System.Data;

namespace NewsApp.PresentationLayer.Forms
{
    public partial class Authorfrm : Form
    {
        private readonly ApplicationDBContext _db;
        private int _id;
        public Authorfrm()
        {
            InitializeComponent();
            _db = new ApplicationDBContext();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void LoadData()
        {
            dataGrid.DataSource = _db.Authors.Select(a => new { Id = a.Id, Username = a.UserName, Email = a.Email, Address = a.Address, pic = a.Image }).ToList();
            dataGrid.Columns["Id"].Visible = false;
            dataGrid.Columns["pic"].Visible = false;
        }

        private void Authorfrm_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void dataGrid_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            DataGridViewRow selectedRow = dataGrid.Rows[e.RowIndex];

            Author author = _db.Authors.FirstOrDefault(s => s.Id == Convert.ToInt32(selectedRow.Cells["Id"].Value));

            var userImage = ImageHelperManager.ByteArrayToImage(author.Image);

            if (userImage == null)
            {
                MessageBox.Show("Not found image for this Author", "Not Found", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

            if (selectedRow != null)
            {
                txt_userName.Text = author.UserName ?? "";
                txt_email.Text = author.Email ?? "";
                txt_Address.Text = author.Address ?? "";
                pic_profileImage.Image = userImage ?? null;
            }

            btn_Save.Visible = false;
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            var openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image Files(*.jpg; *.jpeg; *.png;)|*.jpg; *.jpeg; *.png;";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    var image = Image.FromFile(openFileDialog.FileName);
                    var author = new Author
                    {
                        UserName = txt_userName.Text,
                        Email = txt_email.Text,
                        Address = txt_Address.Text,
                        Image = ImageHelperManager.ImageToByteArray(image)
                    };

                    _db.Authors.Add(author);
                    _db.SaveChanges();
                    LoadData();
                    MessageBox.Show("Author saved successfully!", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error: {ex.Message}");
                }
            }
            else
            {
                MessageBox.Show("you canceld the operation", "Cancel", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
    }
}
