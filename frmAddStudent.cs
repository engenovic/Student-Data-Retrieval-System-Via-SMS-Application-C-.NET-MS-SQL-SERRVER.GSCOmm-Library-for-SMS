using System;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using Microsoft.VisualBasic;

namespace SDRS
{
    public partial class frmAddStudent : Form
    {
        public frmAddStudent()
        {
            InitializeComponent();
            con = new SqlConnection("Data Source=ENGINEERNGENO;Initial Catalog=SDRS;Integrated Security=True");
            loaddata();
            showdata();
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

        private void frmAddStudent_Load(object sender, EventArgs e)
        {
            // Billing Groups 
            cbxBillGroup.Items.Add("Boarding");
            cbxBillGroup.Items.Add("Day");
            //cbxBillGroup.DropDownStyle = ToolStripDropDownItem;
            // Forms
            cbxForm.Items.Add("1");
            cbxForm.Items.Add("2");
            cbxForm.Items.Add("3");
            cbxForm.Items.Add("4");
            //Stream
            cbxStream.Items.Add("N");
            cbxStream.Items.Add("C");
            cbxStream.Items.Add("S");
            // Gender
           cbxGender.Items.Add("Male");
           cbxGender.Items.Add("Female");
            // Relation
            cbxRelation.Items.Add("Father");
            cbxRelation.Items.Add("Mother");
            cbxRelation.Items.Add("Guardian");
        }
        // Load data in adapter
        void loaddata()
        {
            try{
                adapter = new SqlDataAdapter("select AdmNo,Name,Form,Stream,DOB,Gender,BillGroup,Photo,ParentName,PhoneNo,Address,Relation,CurrentTerm from tblStudents", con);
                adapter.MissingSchemaAction = MissingSchemaAction.AddWithKey;
                ds = new DataSet(); 
                adapter.Fill(ds, "tblStudents");
            }
            catch(Exception ex)
            {
         this.Alert("Could Perform query Operation"+ ex.Message, SDRS.Alert.alertTypeEnum.Warning);
                btnNew11.Visible = false;
            }
            
        }
        // Display loaded data in input form controls 
        void showdata()
        {
            try
            {
                if (ds.Tables[0].Rows.Count > 0)
                {
                    // display on input controls 
                    var displayDate = Convert.ToString(ds.Tables[0].Rows[rno][4]);
                    DateTime dateFormatted;
                    if (DateTime.TryParse(displayDate, out dateFormatted))
                    {
                        dpDOB.Value = dateFormatted;
                    }
                    else
                    {
                        dpDOB.Value = DateTime.Now;
                    }
                    txtAdmNo.Text = ds.Tables[0].Rows[rno][0].ToString();
                    txtStdName.Text = ds.Tables[0].Rows[rno][1].ToString();
                    cbxForm.Text = ds.Tables[0].Rows[rno][2].ToString();
                    cbxStream.Text = ds.Tables[0].Rows[rno][3].ToString();
                    cbxGender.Text = ds.Tables[0].Rows[rno][5].ToString();
                    cbxBillGroup.Text = ds.Tables[0].Rows[rno][6].ToString();
                    txtPrtName.Text = ds.Tables[0].Rows[rno][8].ToString();
                    txtPhone.Text = ds.Tables[0].Rows[rno][9].ToString();
                    txtAddress.Text = ds.Tables[0].Rows[rno][10].ToString();
                    cbxRelation.Text = ds.Tables[0].Rows[rno][11].ToString();
                   // cbxTerm.Text = ds.Tables[0].Rows[rno][12].ToString();
                    pBoxStd.Image = null;
                    if (ds.Tables[0].Rows[rno][7] != System.DBNull.Value)
                    {
                        photo_aray = (byte[])ds.Tables[0].Rows[rno][7];
                        MemoryStream ms = new MemoryStream(photo_aray);
                        pBoxStd.Image = Image.FromStream(ms);
                    }
                }
                else
                    this.Alert("There are no existing records!", SDRS.Alert.alertTypeEnum.Warning);
            }
            catch(Exception ex)
            {
                this.Alert("Unable to query databse!!", SDRS.Alert.alertTypeEnum.Warning);
            }
           
        }

        private void pBoxStd_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "jpeg|*.jpg|bmp|*.bmp|all files|*.*";
            DialogResult res = openFileDialog1.ShowDialog();
            if (res == DialogResult.OK)
            {
                pBoxStd.Image = Image.FromFile(openFileDialog1.FileName);
            }
        }
        // Determine Student's Billing 
        void getBilling()
        {
            try
            {
                adapter = new SqlDataAdapter("SELECT SUM (Amount) FROM tblBilling WHERE FormID=" + cbxForm.Text + " AND BillGroup='" + cbxBillGroup.Text + "' AND TermID=1", con);
                ds = new DataSet();
                adapter.Fill(ds, "tblStudents");
                TotalBilled = Convert.ToInt32(ds.Tables[0].Rows[rno][0]); 
            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.Message);
                this.Alert("Could Perform query Operation" + ex.Message, SDRS.Alert.alertTypeEnum.Warning);

            }
        }
        // Initialize Student Payment in the payment table
       void  setInitialPay()
        {
            getBilling();
            //DateTime date = "2020-04-18";
            string ranDate = "Friday, April 17, 2020";
            DateTime rdate=  DateTime.Parse(ranDate);
             try
            {
                cmd = new SqlCommand("INSERT into tblPayment(AdmNo,TotalAmount,Paid,Date,Balance,Prepayment) values(" + txtAdmNo.Text + "," + TotalBilled + ",0,'"+rdate+"'," + TotalBilled+ ",0)", con);
                con.Open();
                int n = cmd.ExecuteNonQuery();
                con.Close();
            }
                catch (Exception ex)
            {
         this.Alert("Unable to Bill Current Student!!", SDRS.Alert.alertTypeEnum.Error);
                con.Close();
            }
        }
        // Determine all the subjects the student is taking based on stream
        void getSubjects()
        {
            
            try
            {
                adapter = new SqlDataAdapter("SELECT SubInitial FROM tblSubjects WHERE SGroup='ALL' OR SGroup='" + cbxStream.Text + "'", con);
               ds = new DataSet();
               adapter.Fill(ds, "Subjects");
                adapter.Fill(dt);
               
            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.Message);
                this.Alert("Could Perform query Operation" + ex.Message, SDRS.Alert.alertTypeEnum.Warning);

            }
        }
        // Initialize Marks in the Marks table
        void setInitialMark()
        {
            getSubjects();
            try
            {
                // Just open connection once to avoid closing and opening which may buffer
                con.Open();
                foreach (DataRow row in dt.Rows)
                {

                    string subname = row["SubInitial"].ToString();

                    //MessageBox.Show(subname);
                    try
                    {
                        cmd = new SqlCommand("INSERT into tblMark(AdmNo,Subject,ExamID,Mark,Grade,Comment) values(" + txtAdmNo.Text + ",'" + subname + "',(SELECT ExamID FROM tblExam WHERE Status= 'Active'),0,'N', 'NULL')", con);

                        int n = cmd.ExecuteNonQuery();
                        
                    }
                    catch (Exception ex)
                    {
                        // MessageBox.Show(ex.Message);
                        this.Alert("Could not Perform Insertion Operation!", SDRS.Alert.alertTypeEnum.Error);
                        con.Close();
                    }
                }
                this.Alert("All Student Subjects have been initialized", SDRS.Alert.alertTypeEnum.Info);
                con.Close();
            }
            catch (Exception ex)
            {
                this.Alert("Could not Initialize Subjects for Students!", SDRS.Alert.alertTypeEnum.Warning);
            }

        }
        private void btnSave11_Click(object sender, EventArgs e)
        {// Format entered phone number to international format
            string phone = txtPhone.Text;
            string first_xter = phone.Substring(0, 1);
            if (first_xter == "0")
            {
                phone = "+254" + phone.Remove(0, 1);

            }
            // Check to see  if the student already exist or duplicate phone number // Put this later #" OR PhoneNo= '" + phone + "'#
            try
            {
                adapter = new SqlDataAdapter("select * from tblStudents WHERE AdmNo= " + txtAdmNo.Text + "", con);
                ds = new DataSet(); adapter.Fill(ds, "tblStudents");
                if (ds.Tables[0].Rows.Count > 0)
                {
                    this.Alert("A student with this Admission and/ or Phone Number already Exists!!", SDRS.Alert.alertTypeEnum.Error);
                   
                }
                // If the student is not registered/ phone number not used then proceed to register
                else
                {
                    try
                    {
                        cmd = new SqlCommand("INSERT into tblStudents(AdmNo,Name,Form,Stream,DOB,Gender,BillGroup,Photo,ParentName,PhoneNo,Address,Relation,CurrentTerm) values(" + txtAdmNo.Text + ",'" + txtStdName.Text + "'," + cbxForm.Text + ",'" + cbxStream.Text + "','" + DateTime.Parse(dpDOB.Text) + "'," +
                                        "'" + cbxGender.Text + "','" + cbxBillGroup.Text + "',@photo, '" + txtPrtName.Text + "','" + phone + "','" + txtAddress.Text + "','" + cbxRelation.Text + "',1)", con);
                        conv_photo();
                        con.Open();
                        int n = cmd.ExecuteNonQuery();
                        con.Close();
                        if (n > 0)
                        {
                            this.Alert("Student Registered Successfully!", SDRS.Alert.alertTypeEnum.Success);
                            loaddata();
                            setInitialMark();
                            setInitialPay();
                            // Send SMS to Parent informing of successful student admission
                            
                            frmDashb smpf = new frmDashb();
                            smpf.AutoSMS("Dear "+ txtPrtName.Text+", "+ txtStdName.Text+" has been successfully admitted to Form "+ cbxForm.Text+ ""+cbxStream.Text+". You will be required to provide Admission Number " +txtAdmNo.Text+" everytime you want to access Student data. We are glad to have you at Singoronik Secondary School. ^BN", txtPhone.Text);
                        }
                        else
                            this.Alert("Unable to register Student!", SDRS.Alert.alertTypeEnum.Warning);
                    }
                    catch (Exception ex)
                    {
                        this.Alert("Unable to perform Insertion Operation!!", SDRS.Alert.alertTypeEnum.Error);
                        // MessageBox.Show(ex.Message);
                        con.Close();
                    }
                }
            }
            catch(Exception ex)
            {
                this.Alert("Unable to perform Query Operation!!", SDRS.Alert.alertTypeEnum.Error);
            }
            
           
            
        }
        void conv_photo()
        {
            //converting photo to binary data  
            if (pBoxStd.Image != null)
            {
                //using MemoryStream 
                ms = new MemoryStream();
                pBoxStd.Image.Save(ms, ImageFormat.Jpeg);
                byte[] photo_aray = new byte[ms.Length];
                ms.Position = 0;
                ms.Read(photo_aray, 0, photo_aray.Length);
                cmd.Parameters.AddWithValue("@photo", photo_aray);
            }
        }

        private void btnNew11_Click(object sender, EventArgs e)
        {

            try
            {
                cmd = new SqlCommand("select max(AdmNo)+5 from tblStudents", con);
                con.Open();
                txtAdmNo.Text = cmd.ExecuteScalar().ToString();
                con.Close();
                 
                txtAddress.Text = txtPhone.Text = txtStdName.Text = txtPrtName.Text = "";
                dpDOB.Text= DateTime.Now.ToString();
                cbxBillGroup.Text = "Select Billing Group";
                cbxForm.Text = "Choose Form";
                cbxStream.Text = "Specify Form";
                cbxGender.Text = "Choose Gender";
             //   cbxTerm.Text = "Choose Term";
                cbxRelation.Text = "Select Relation";
                pBoxStd.Image = SDRS.Properties.Resources.student1;
            }
            catch(Exception ex)
            {
   this.Alert("Could Perform Query Operation" , SDRS.Alert.alertTypeEnum.Error);
                con.Close();
            }
            
        }

        private void gunaButton1_Click(object sender, EventArgs e)
        {
            try
            {
                int n = Convert.ToInt32(Interaction.InputBox("Enter Admission Number:", "Search", "8704", 100, 100));
                DataRow drow;
                drow = ds.Tables[0].Rows.Find(n);
                if (drow != null)
                {
                    rno = ds.Tables[0].Rows.IndexOf(drow);
                    // Display found results on input controls
                    showdata();
                    
                }
                else
      this.Alert("No records for the specified student found!", SDRS.Alert.alertTypeEnum.Warning);
            }
            catch
            {
          this.Alert("Could Perform Query Operation", SDRS.Alert.alertTypeEnum.Error);
            }
        }

        private void btnUpdate11_Click(object sender, EventArgs e)
        {
            // Format entered phone number to international format
            string phone = txtPhone.Text;
            string first_xter = phone.Substring(0, 1);
            if (first_xter == "0")
            {
                phone = "+254" + phone.Remove(0, 1);

            }

            try
            {
                cmd = new SqlCommand ("UPDATE tblStudents SET Name='" + txtStdName.Text + "' ,Form=" + cbxForm.Text + " ,Stream='" + cbxStream.Text + "',DOB='" + DateTime.Parse(dpDOB.Text) + "',Gender='" + cbxGender.Text + "',BillGroup='" + cbxBillGroup.Text + "',Photo=@photo,ParentName='" + txtPrtName.Text + "',PhoneNo='" + phone + "',Address='" + txtAddress.Text + "',Relation='" + cbxRelation.Text + "', CurrentTerm=1  WHERE AdmNo=" + txtAdmNo.Text + "", con);
                conv_photo();
                con.Open();
                int n = cmd.ExecuteNonQuery();
                con.Close();
                if (n > 0)
                {
              this.Alert(" Records updated !", SDRS.Alert.alertTypeEnum.Info);
                    loaddata();
                }
                else
                this.Alert(" Failed to update records", SDRS.Alert.alertTypeEnum.Warning);
            }
            catch (Exception ex)
            {
               // MessageBox.Show(ex.Message);
       this.Alert("Could Perform Updation Operation!!", SDRS.Alert.alertTypeEnum.Error);
                con.Close();
            }
           
        }

        private void btnDelete11_Click(object sender, EventArgs e)
        {
            
           DialogResult dlg=  MessageBox.Show(" Sure to remove all records relating to the specified student? ", "Confirm Student Deletion", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (dlg == DialogResult.OK)
            {
                try
                {
                    cmd = new SqlCommand("delete from tblStudents where AdmNo=" + txtAdmNo.Text + ";delete from tblPayment where AdmNo=" + txtAdmNo.Text + "", con) ;
                    con.Open();
                    int n = cmd.ExecuteNonQuery();
                    con.Close();
                    if (n > 0)
                    {
                        this.Alert("All Student Records were deleted !!", SDRS.Alert.alertTypeEnum.Info);
                        loaddata();
                        rno = 0;
                        showdata();
                    }
                    else
                        this.Alert("Failed to delete Student Records!", SDRS.Alert.alertTypeEnum.Warning);
                }
                catch (Exception ex)
                {
                    this.Alert("Could Perform Deletion Operation!!", SDRS.Alert.alertTypeEnum.Error);
                    con.Close();
                }

            }


        }

        private void gunaButton3_Click(object sender, EventArgs e)
        {
            rno = 0;
            showdata();
        }

        private void gunaButton2_Click(object sender, EventArgs e)
        {
            if (rno > 0)
            {
                rno--;
                showdata();
            }
            else
     this.Alert("You have reached the beginning of Student data navigation", SDRS.Alert.alertTypeEnum.Info);
        }

        private void gunaButton4_Click(object sender, EventArgs e)
        {
            if (rno < ds.Tables[0].Rows.Count - 1)
            {
                rno++; showdata();
            }
            else
           this.Alert("End of Student data navigation", SDRS.Alert.alertTypeEnum.Info);
        }

        private void gunaButton5_Click(object sender, EventArgs e)
        {
            rno = ds.Tables[0].Rows.Count - 1;
            showdata();
        }
    }
}
