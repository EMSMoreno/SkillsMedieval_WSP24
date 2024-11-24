using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WSN24_EduardoMoreno_M3
{
    public partial class FormBlockedUser : Form
    {
        public FormBlockedUser()
        {
            InitializeComponent();
        }

        private void btnAccountRecover_Click(object sender, EventArgs e)
        {
            FormRecoverAccount recoverAccountForm = new FormRecoverAccount();
            recoverAccountForm.ShowDialog();
        }
    }
}
