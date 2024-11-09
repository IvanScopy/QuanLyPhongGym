using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GymManagement
{
    public partial class NewMember : Form
    {
        public NewMember()
        {
            InitializeComponent();
        }
        Classes.DataBaseProcess dtbase = new Classes.DataBaseProcess();

        private void btnLuu_Click(object sender, EventArgs e)
        {
            string name = txtHoTen.Text;
            string gender = rdbNam.Checked ? rdbNam.Text : rdbNu.Text;
            string dob = dtpNgaySinh.Value.ToString("yyyy-MM-dd"); // Format date for SQL
            Int64 mobile = Int64.Parse(txtSDT.Text);
            string email = txtEmail.Text;
            string joindate = dtpNgayDangKi.Value.ToString("yyyy-MM-dd"); // Format date for SQL
            string membershipTime = cbbThoiGianTap.Text;
            string address = rtbDiaChi.Text;

            // Prepare SQL query with parameters
            string sql = "INSERT INTO NewMember (Name, Gender, Dob, Mobile, Email, JoinDate, MembershipTime, Maddress) " +
                         "VALUES (@Name, @Gender, @Dob, @Mobile, @Email, @JoinDate, @MembershipTime, @Maddress)";

            // Set parameters for the query
            Dictionary<string, object> parameters = new Dictionary<string, object>
            {
                { "@Name", name },
                { "@Gender", gender },
                { "@Dob", dob },
                { "@Mobile", mobile },
                { "@Email", email },
                { "@JoinDate", joindate },
                { "@MembershipTime", membershipTime },
                { "@Maddress", address }  // Match with SQL column name "Maddress"
            };

            try
            {
                dtbase.DataChange(sql, parameters);
                MessageBox.Show("Member information saved successfully.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error saving member information: " + ex.Message);
            }
        }



        private void btnLamLai_Click(object sender, EventArgs e)
        {
            txtHoTen.Clear();

            rdbNam.Checked = false;
            rdbNu.Checked = false;

            txtSDT.Clear();
            txtEmail.Clear();

            cbbThoiGianTap.ResetText();
            rtbDiaChi.Clear();

            dtpNgaySinh.Value = DateTime.Now;
            dtpNgayDangKi.Value = DateTime.Now;
        }
    }
}
