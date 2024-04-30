using System;
using System.Windows.Forms;

namespace Calculator2024 {

    public partial class frmRate : Form {

        private void btnSend_Click(object sender, EventArgs e) {

            if (!string.IsNullOrWhiteSpace(txtMessage.Text)) {

                MessageBox.Show("Thanks for helping us improving our App!", "Thank you!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.IsMdiContainer = false;
                this.Hide();
                frmCalculator frm = new frmCalculator();
                frm.MdiParent = frmRate.ActiveForm;
                frm.Show();
            }
            else {

                MessageBox.Show("Say something!", "Leave a comment!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnComeback_Click(object sender, EventArgs e) {
            
            this.IsMdiContainer = false;
            this.Hide();
            frmCalculator frm = new frmCalculator();
            frm.MdiParent = frmRate.ActiveForm;
            frm.Show();
        }

        public frmRate() => InitializeComponent();
        private void btnExit_Click(object sender, EventArgs e) => Application.Exit();
    }
}