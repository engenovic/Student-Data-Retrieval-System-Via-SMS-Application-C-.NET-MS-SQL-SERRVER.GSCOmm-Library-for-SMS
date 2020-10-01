using System;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using Microsoft.VisualBasic;
using System.Linq;
using System.Threading;
using Excel = Microsoft.Office.Interop.Excel;

namespace SDRS
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
            con = new SqlConnection("Data Source=ENGINEERNGENO;Initial Catalog=SDRS;Integrated Security=True");
            
        }
        // Database variables
        SqlConnection con;
        SqlCommand cmd;
        SqlDataAdapter adapter;
        DataSet ds;
        Dataset ds1;
        DataTable dt = new DataTable();
        DataRow dr;
        int rno = 0;
        private void frmLogin_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            frmDashb db = new frmDashb();
            db.Show();
            this.Close();
            db.labelUser = "Engineer";
            db.labelRole = "Admin";
            // getUsers();
        }

        
        void getUsers()
        {
            string user = txtUser.Text;
            string pass = txtPass.Text;
            

            try
            {
                adapter = new SqlDataAdapter("SELECT Username, Role from tblUsers WHERE Username= '"+user+"' AND Password= '"+pass+"' AND Status= 'Access'", con);
                ds = new DataSet(); adapter.Fill(ds, "Users");
                if (ds.Tables[0].Rows.Count > 0)
                {
                    // display on input controls 
                    string uname = ds.Tables[0].Rows[rno][0].ToString();
                    string role  = ds.Tables[0].Rows[rno][1].ToString();
                    if (role=="Admin")
                    {

                       
                         frmDashb db = new frmDashb();
                         db.Show();
                        this.Close();
                         db.labelUser = uname;
                         db.labelRole = role; 


                    }
                    else if (role == "Exams")
                    {
                        frmDashb db = new frmDashb();
                        db.Show();
                        this.Close();
                        db.labelUser = uname;
                        db.labelRole = role;
                        db.UpdateExam(true);
                    }
                    else if (role == "Fees")
                    {
                        frmDashb db = new frmDashb();
                        db.Show();
                        this.Close();
                        db.labelUser = uname;
                        db.labelRole = role;
                        db.UpdateFees(true);
                    }
                }
                else
                {
                    MessageBox.Show("Incorrect Login Credentials or Access Denied!", "User Login", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Login Failed!","User Login", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void label4_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmSignup sngup = new frmSignup();
            sngup.Show();
        }

      
    }
}
