using System;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using Microsoft.VisualBasic;
using Excel = Microsoft.Office.Interop.Excel;

namespace SDRS
{
    public partial class frmViewPayments : Form
    {
        public frmViewPayments()
        {
            InitializeComponent();
            con = new SqlConnection("Data Source=ENGINEERNGENO;Initial Catalog=SDRS;Integrated Security=True");
            showGrid();
        }
        // Database variables
        SqlConnection con;
        SqlCommand cmd;
        SqlDataAdapter adapter;
        DataSet ds;
        private void btnClose2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

     

       

        private void frmViewPayments_Load(object sender, EventArgs e)
        {
            var bunifuDataGrid = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.Controls.Add(bunifuDataGrid);
           
        }
        // Load data in adapter
        void showGrid()
        {
            try
            {
                adapter = new SqlDataAdapter("SELECT AdmNo,TotalAmount, Paid, Date, Balance, Prepayment,PaymentID,PayMode FROM tblPayment WHERE PayMode !='NULL' ", con);
                adapter.MissingSchemaAction = MissingSchemaAction.AddWithKey;
                ds = new DataSet();
                adapter.Fill(ds, "Payments");
                if (ds.Tables[0].Rows.Count > 0)
                {
                    // display on Grid 
                    dgvViewPayments.DataSource = ds;
                    dgvViewPayments.DataMember = "Payments";
                }
                else
                    dgvViewPayments.Rows.Add("Empty Records ");

            }
            catch (Exception ex)
            {
                return;
            }

        }

    }
}
