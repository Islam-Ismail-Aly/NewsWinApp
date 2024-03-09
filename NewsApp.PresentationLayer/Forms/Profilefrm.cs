using NewsApp.Core.Data;
using NewsApp.Core.Models;
using NewsApp.PresentationLayer.Forms;
using NewsApp.PresentationLayer.Helpers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NewsApp.PresentationLayer
{
    public partial class Profilefrm : Form
    {
        private Author _author;

        public Profilefrm()
        {
            InitializeComponent();
            _author = null; // Initialize _author to null
        }

        public Profilefrm(Author author) : this()
        {
            _author = author; // Initialize _author with the provided author object
            LoadAuthorData();
        }

        private void LoadAuthorData()
        {
            var userImage = ImageHelperManager.ByteArrayToImage(_author.Image);

            if (userImage == null )
            {
                MessageBox.Show("Not found image for this Author", "Not Found", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

            if (_author != null)
            {
                txt_AuthorName.Text = _author.UserName ?? "";
                txt_AuthorEmail.Text = _author.Email ?? "";
                txt_AuthorAddress.Text = _author.Address ?? "";
                pic_profileImage.Image = userImage ?? null;
            }
            else
            {
                // Handle the case when _author is null
                MessageBox.Show("Author information is not available.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Profilefrm_Load(object sender, EventArgs e)
        {
            LoadAuthorData();
            txt_AuthorAddress.Enabled = false;
            txt_AuthorName.Enabled = false;
            txt_AuthorEmail.Enabled = false;
        }

        private void btn_Main_Click(object sender, EventArgs e)
        {
            Mainfrm mainfrm = new Mainfrm();
            mainfrm.ShowDialog();
        }

        private void lbl_forgetPassword_Click(object sender, EventArgs e)
        {
            ForgetPasswordfrm forgetfrm = new ForgetPasswordfrm();
            forgetfrm.ShowDialog();
        }

        private void lbl_changePassword_Click(object sender, EventArgs e)
        {
            ChangePasswordfrm changefrm = new ChangePasswordfrm(_author);
            changefrm.ShowDialog();
        }

        private void btn_authorfrm_Click(object sender, EventArgs e)
        {
            Authorfrm authorfrm = new Authorfrm();
            authorfrm.ShowDialog();
        }
    }
}
