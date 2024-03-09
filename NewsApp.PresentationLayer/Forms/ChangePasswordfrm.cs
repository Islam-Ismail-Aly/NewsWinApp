using Microsoft.IdentityModel.Tokens;
using NewsApp.Core.Data;
using NewsApp.Core.Models;
using System.Data;

namespace NewsApp.PresentationLayer.Forms
{
    public partial class ChangePasswordfrm : Form
    {
        private readonly ApplicationDBContext _db;
        private Author _author;
        private string _oldPassword;
        public ChangePasswordfrm()
        {
            InitializeComponent();
            _author = null;
            _db = new ApplicationDBContext();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        public ChangePasswordfrm(Author author) : this()
        {
            _oldPassword = author.Password;
            _author = author;
        }

        private void CheckPassword()
        {
            if (txt_OldPass.Text.IsNullOrEmpty())
            {
                MessageBox.Show(text: "please check old password!", "Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                return;
            }
            if (txt_newPass.Text.IsNullOrEmpty())
            {
                MessageBox.Show(text: "please check new password!", "Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                return;
            }
            if (txt_confirmPass.Text.IsNullOrEmpty())
            {
                MessageBox.Show(text: "please check confirm password!", "Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                return;
            }
        }

        private void btn_changePass_Click(object sender, EventArgs e)
        {
            CheckPassword();

            var author = _db.Authors.Where(a => a.Id == _author.Id).FirstOrDefault();

            if (txt_newPass.Text == txt_confirmPass.Text && txt_OldPass.Text == _oldPassword)
            {
                if (author != null)
                {
                    author.Password = txt_confirmPass.Text;
                    _db.SaveChanges();
                    MessageBox.Show(text: "Your password has been change successfully !", "Success", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                    this.Close();
                }
            }
            else
            {
                MessageBox.Show(text: "please check the password!", "Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
        }
    }
}
