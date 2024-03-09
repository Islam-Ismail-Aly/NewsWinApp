using Microsoft.IdentityModel.Tokens;
using NewsApp.Core.Data;
using System.Data;

namespace NewsApp.PresentationLayer.Forms
{
    public partial class ForgetPasswordfrm : Form
    {
        private readonly ApplicationDBContext _db;
        public ForgetPasswordfrm()
        {
            InitializeComponent();
            _db = new ApplicationDBContext();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void btn_GetPassword_Click(object sender, EventArgs e)
        {
            if (!txt_yourEmail.Text.IsNullOrEmpty())
            {
                var email = _db.Authors.Where(a => a.Email.Equals(txt_yourEmail.Text)).FirstOrDefault();
                if (email is not null)
                    txt_getEmail.Text = email.Password;
            }
            else
            {
                MessageBox.Show("Not found, Please check your email!", "Not found", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
