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
    public partial class frmViewStudents : Form
    {
        public frmViewStudents()
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
        DataTable dt = new DataTable();
        // Global Variables
        int TotalBilled;
        int rno = 0;
        // For dealing with the image
        MemoryStream ms;
        byte[] photo_aray;
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

        private void frmViewStudents_Load(object sender, EventArgs e)
        {
            var bunifuDataGrid = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.Controls.Add(bunifuDataGrid);
            cbxForm12.Items.Add("1");
            cbxForm12.Items.Add("2");
            cbxForm12.Items.Add("3");
            cbxForm12.Items.Add("4");
            cbxGender12.Items.Add("Male");
            cbxGender12.Items.Add("Female");

        }


        // Load data in adapter
        void showGrid()
        {
            try
            {
                adapter = new SqlDataAdapter("select AdmNo,Name,Form, Gender,ParentName,PhoneNo from tblStudents", con);
                adapter.MissingSchemaAction = MissingSchemaAction.AddWithKey;
                ds = new DataSet();
                adapter.Fill(ds, "tblStudents");
                if (ds.Tables[0].Rows.Count > 0)
                {
                    // display on Grid 
                    dgvViewStudents.DataSource = ds;
                    dgvViewStudents.DataMember = "tblStudents";
                }
                else
                    dgvViewStudents.Rows.Add("No Existing Records Found");

            }
            catch (Exception ex)
            {
                this.Alert("Could Perform query Operation" + ex.Message, SDRS.Alert.alertTypeEnum.Warning);
            }

        }

       

        private void btnImport12_Click(object sender, EventArgs e)
        {
            try
            {

                string name = Interaction.InputBox("Enter File Name to Import:", "Search", " ", 100, 100) + ".xlsx";
                System.Data.OleDb.OleDbConnection MyConnection;
                System.Data.DataSet DtSet;
                System.Data.OleDb.OleDbDataAdapter MyCommand;
                MyConnection = new System.Data.OleDb.OleDbConnection(@"provider=Microsoft.ACE.OLEDB.12.0;Data Source='C:\\Users\\NGENO VICTOR\\Desktop\\FINAL YEAR PROJECT\\SDRS\\IMPLEMENTATION\files\\" + name + "';Extended Properties=Excel 8.0;");
                MyCommand = new System.Data.OleDb.OleDbDataAdapter("select * from [Sheet1$]", MyConnection);
                MyCommand.TableMappings.Add("Table", "Net-informations.com");
                DtSet = new System.Data.DataSet();
                MyCommand.Fill(DtSet);
                dgvViewStudents.DataSource = DtSet.Tables[0];
                MyConnection.Close();
                this.Alert(name + "date imported", SDRS.Alert.alertTypeEnum.Success);
                DialogResult dlg = MessageBox.Show(" Empty data shall be skipped", "Import from Excel", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                if (dlg == DialogResult.OK)
                {
                    //this.Alert("Records Updated", SDRS.Alert.alertTypeEnum.Success);
                    insertDB();
                }
            }
            catch (Exception ex)
            {
               // MessageBox.Show(ex.Message);
                this.Alert("Sorry! We could not import that one" + ex.Message, SDRS.Alert.alertTypeEnum.Error);
            }
            
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Bitmap bm = new Bitmap(this.dgvViewStudents.Width, this.dgvViewStudents.Height);
            dgvViewStudents.DrawToBitmap(bm, new Rectangle(0, 0, this.dgvViewStudents.Width, this.dgvViewStudents.Height));
            e.Graphics.DrawImage(bm, 0, 0);
        }

        private void btnPrint12_Click(object sender, EventArgs e)
        {
            printDocument1.Print();
        }

        private void btnExport12_Click(object sender, EventArgs e)
        {      
            try
            {
                string name = Interaction.InputBox("Enter File Name to Export:", "Search", "XXXX", 100, 100) + ".xls";
                Excel.Application xlApp;
                Excel.Workbook xlWorkBook;
                Excel.Worksheet xlWorkSheet;
                object misValue = System.Reflection.Missing.Value;

                xlApp = new Excel.Application();
                xlWorkBook = xlApp.Workbooks.Add(misValue);
                xlWorkSheet = (Excel.Worksheet)xlWorkBook.Worksheets.get_Item(1);
                int i = 0;
                int j = 0;

                for (i = 0; i <= dgvViewStudents.RowCount - 1; i++)
                {
                    for (j = 0; j <= dgvViewStudents.ColumnCount - 1; j++)
                    {
                        DataGridViewCell cell = dgvViewStudents[j, i];
                        xlWorkSheet.Cells[i + 1, j + 1] = cell.Value;
                    }
                }

                xlWorkBook.SaveAs("C:\\Users\\NGENO VICTOR\\Desktop\\FINAL YEAR PROJECT\\SDRS\\IMPLEMENTATION\\files\\" + name + "", Excel.XlFileFormat.xlWorkbookNormal, misValue, misValue, misValue, misValue, Excel.XlSaveAsAccessMode.xlExclusive, misValue, misValue, misValue, misValue, misValue);
                xlWorkBook.Close(true, misValue, misValue);
                xlApp.Quit();

                releaseObject(xlWorkSheet);
                releaseObject(xlWorkBook);
                releaseObject(xlApp);

                this.Alert(name+ "File Created" , SDRS.Alert.alertTypeEnum.Success);
            }
            catch(Exception ex)
            {
                this.Alert("Sorry! We could not Export that one" + ex.Message, SDRS.Alert.alertTypeEnum.Error);
            }

            
        }

        private void releaseObject(object obj)
        {
            try
            {
                System.Runtime.InteropServices.Marshal.ReleaseComObject(obj);
                obj = null;
            }
            catch (Exception ex)
            {
                obj = null;
                MessageBox.Show("Exception Occured while releasing object " + ex.ToString());
            }
            finally
            {
                GC.Collect();
            }
        }

        void insertDB()
        {
            
            SqlConnection conn = new SqlConnection("Data Source=ENGINEERNGENO;Initial Catalog=SDRS;Integrated Security=True");
            SqlCommand comm;
            for (int i = 0; i < dgvViewStudents.Rows.Count; i++)
            {
                int admno = Convert.ToInt32(dgvViewStudents.Rows[i].Cells["AdmNo"].Value);
                int Form = Convert.ToInt32(dgvViewStudents.Rows[i].Cells["Form"].Value);
                int CTerm = Convert.ToInt32(dgvViewStudents.Rows[i].Cells["CurrentTerm"].Value);
                string name = dgvViewStudents.Rows[i].Cells["Name"].Value.ToString();
                string Stream = dgvViewStudents.Rows[i].Cells["Stream"].Value.ToString();
                string DOB = dgvViewStudents.Rows[i].Cells["DOB"].Value.ToString();
                string Gender = dgvViewStudents.Rows[i].Cells["Gender"].Value.ToString();
                string BillGroup = dgvViewStudents.Rows[i].Cells["BillGroup"].Value.ToString();
                string ParentName = dgvViewStudents.Rows[i].Cells["ParentName"].Value.ToString();
                string PhoneNo = "+254"+dgvViewStudents.Rows[i].Cells["PhoneNo"].Value.ToString();
                string Address = dgvViewStudents.Rows[i].Cells["Address"].Value.ToString();
                string Relation = dgvViewStudents.Rows[i].Cells["Relation"].Value.ToString();
                string StrQuery = @"INSERT INTO tblStudents(AdmNo,Name,Form,Stream,DOB,Gender,BillGroup,ParentName,PhoneNo,Address,Relation,CurrentTerm) VALUES ("+admno+", '" + name + "'," + Form+ "," +"'" + Stream + "','"+ DOB + "', '" + Gender + "','" + BillGroup + "','" + ParentName + "','" + PhoneNo+ "','" + Address + "','" + Relation + "'," + CTerm + ");";

                try
                {
                    using (conn)
                    {
                        using (comm = new SqlCommand(StrQuery, conn))
                        {
                            conn.Open();
                            comm.ExecuteNonQuery();
                            frmDashb sm = new frmDashb();
                            sm.AutoSMS("Dear " + ParentName + ", " + name + " has been successfully admitted to Form " + Form+ "" + Stream + ". You will be required to provide Admission Number " + admno + " everytime you want to access Student data. We are glad to have you at Singoronik Secondary School. ^BN", PhoneNo);

                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    //this.Alert("Fatal Error occurred" + ex.Message, SDRS.Alert.alertTypeEnum.Error);
                }
            }
            conn.Close();
            this.Alert("Mass Data Insertion Completed" , SDRS.Alert.alertTypeEnum.Success);
        }

        private void gunaGradientButton1_Click(object sender, EventArgs e)
        {
            //MessageBox.Show(dgvViewStudents.Rows[1].Cells.ToString());

        }

        private void cbxForm12_SelectedIndexChanged(object sender, EventArgs e)
        {

           
            try
            {
                adapter = new SqlDataAdapter("select AdmNo,Name,Form, Gender,ParentName,PhoneNo from tblStudents", con);
                adapter.Fill(dt);
                dgvViewStudents.DataSource = dt.Select("Form= " + cbxForm12.SelectedItem + "").CopyToDataTable();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No Data Found");
            }
            
        }

        private void cbxGender12_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            try
            {
                adapter = new SqlDataAdapter("select AdmNo,Name,Form, Gender,ParentName,PhoneNo from tblStudents", con);
                adapter.Fill(dt);
                dgvViewStudents.DataSource = dt.Select("Gender= '" + cbxGender12.SelectedItem + "'").CopyToDataTable();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No Data Found");
            }
            
        }
    }
}