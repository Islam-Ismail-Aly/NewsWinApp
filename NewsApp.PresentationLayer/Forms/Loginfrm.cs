using NewsApp.Core.Data;
using NewsApp.Core.Models;
using NewsApp.PresentationLayer.Forms;

namespace NewsApp.PresentationLayer
{
    public partial class Loginfrm : Form
    {
        private readonly ApplicationDBContext _db;
        
        public Loginfrm()
        {
            InitializeComponent();
            _db = new ApplicationDBContext();
        }

        private void Loginfrm_Load(object sender, EventArgs e)
        {

        }

        private void btn_Login_Click(object sender, EventArgs e)
        {
            Author author = _db.Authors.Where(a => a.UserName.Equals(txt_Username.Text) && a.Password.Equals(txt_Password.Text)).FirstOrDefault();

            if (author != null)
            {

                Profilefrm profilefrm = new Profilefrm(author);

                this.Hide();

                // Close this form when the mainfrm is closed

                profilefrm.FormClosed += (s, args) => this.Close();

                profilefrm.Show();

            }
            else
            {
                MessageBox.Show("Please check the username and password", "Faild login", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void lbl_forgetPassword_Click(object sender, EventArgs e)
        {
            ForgetPasswordfrm forgetfrm = new ForgetPasswordfrm();
            forgetfrm.ShowDialog();
        }
    }
}
