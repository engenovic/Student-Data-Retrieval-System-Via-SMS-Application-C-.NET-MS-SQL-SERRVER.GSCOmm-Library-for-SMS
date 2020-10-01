using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace SDRS
{
    public partial class frmFeeBill : Form
    {
        public frmFeeBill()
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
        int rno = 0;
       
        // Alert function
        public void Alert(string msg, Alert.alertTypeEnum type)
        {
            Alert f = new Alert();
            f.setAlert(msg, type);
        }
        private void btnClose2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmFeeBill_Load(object sender, EventArgs e)
        {
            // Forms
            cbxForm.Items.Add("1");
            cbxForm.Items.Add("2");
            cbxForm.Items.Add("3");
            cbxForm.Items.Add("4");
            // Current Term
            cbxTerm.Items.Add("1");
            cbxTerm.Items.Add("2");
            cbxTerm.Items.Add("3");
            // Billing Groups 
            cbxBillGroup.Items.Add("Boarding");
            cbxBillGroup.Items.Add("Day");
            var bunifuDataGrid = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.Controls.Add(bunifuDataGrid);
            
        }
       

        private void btnSave11_Click(object sender, EventArgs e)
        {
            try
            {
                cmd = new SqlCommand("INSERT into tblBilling(FormID,VoteHead,Amount,BillGroup,TermID) values(" + cbxForm.Text + ",'" + txtVote.Text + "'," + txtKES.Text + ",'" + cbxBillGroup.Text + "', " + cbxTerm.Text + ")", con);
                con.Open();
                int n = cmd.ExecuteNonQuery();
                con.Close();
                if (n > 0)
                {
                    this.Alert("Billing Saved Successfully", SDRS.Alert.alertTypeEnum.Success);
                    
                    
                }
                else
                    this.Alert("Could not Save that Billing!", SDRS.Alert.alertTypeEnum.Warning);
            }
            catch (Exception ex)
            {
             this.Alert("Unable to perform Insertion Operation!!", SDRS.Alert.alertTypeEnum.Error);
                MessageBox.Show(ex.Message);
                con.Close();
            }
        }
        // Load data in adapter
        void showGrid()
        {
            try
            {
                adapter = new SqlDataAdapter("select TOP 10 * from tblBilling", con);
                adapter.MissingSchemaAction = MissingSchemaAction.AddWithKey;
                ds = new DataSet();
                adapter.Fill(ds, "Bills");
                if (ds.Tables[0].Rows.Count > 0)
                {
                    // display on Grid 
                    dgvFeesBilling.DataSource = ds;
                    dgvFeesBilling.DataMember = "Bills";
                }
                else
                    dgvFeesBilling.Rows.Add("No Existing Records Found");

            }
            catch (Exception ex)
            {
                this.Alert("Could Perform query Operation" + ex.Message, SDRS.Alert.alertTypeEnum.Warning);
            }

        }
        private void gunaButton1_Click(object sender, EventArgs e)
        {
            
        }
    }
}
