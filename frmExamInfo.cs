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
    public partial class frmExamInfo : Form
    {
        public frmExamInfo()
        {
            InitializeComponent();
            con = new SqlConnection("Data Source=ENGINEERNGENO;Initial Catalog=SDRS;Integrated Security=True");
        }
        // Database variables
        SqlConnection con;
        SqlCommand cmd;
        SqlDataAdapter adapter;
        DataSet ds;
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

        private void btnSave11_Click(object sender, EventArgs e)
        {
            // Check to see  if the Subject already exist 
            try
            {
                adapter = new SqlDataAdapter("select * from tblSubjects WHERE SubCode= " + txtSubCode.Text + "", con);
                ds = new DataSet();
                adapter.Fill(ds, "Subjects");
                if (ds.Tables[0].Rows.Count > 0)
                {
                    this.Alert(" This Subject Exists!!", SDRS.Alert.alertTypeEnum.Error);
                }
                //If user not exist proceed to register
                else
                {
                    try
                    {
                        cmd = new SqlCommand("INSERT into tblSubjects(SubCode,SubName,SubInitial) values(" + txtSubCode.Text + ", '" + txtSubName.Text + "', '" + txtSubInit.Text + "')", con);
                        con.Open();
                        int n = cmd.ExecuteNonQuery();
                        con.Close();
                        if (n > 0)
                        {
                            this.Alert(" Subject Added!", SDRS.Alert.alertTypeEnum.Info);
                        }
                        else
                            this.Alert("Unable to Add Subject!", SDRS.Alert.alertTypeEnum.Warning);
                    }
                    catch (Exception ex)
                    {
                        this.Alert("Unable to perform Insertion Operation!!", SDRS.Alert.alertTypeEnum.Error);
                        MessageBox.Show(ex.Message);
                        con.Close();
                    }
                }
            }
            catch(Exception ex)
            {
                this.Alert("Unable to perform Insertion Operation!!", SDRS.Alert.alertTypeEnum.Error);
                MessageBox.Show(ex.Message);
                con.Close();
            }
    }

        private void gunaButton2_Click(object sender, EventArgs e)
        {
           
            // Check to see  if the Exam already exist 
            try
            {
                adapter = new SqlDataAdapter("select * from tblExam WHERE  Status='Active'", con);
                ds = new DataSet();
                adapter.Fill(ds, "Exams");
                if (ds.Tables[0].Rows.Count > 0)
                {
                    this.Alert(" There is an Active exam for this term!", SDRS.Alert.alertTypeEnum.Error);
                }
                //If user not exist proceed to register
                else
                {
                    try
                    {
                        cmd = new SqlCommand("INSERT into tblExam(Name,TermID,Status) values('" + txtExamName.Text + "', " + cbxTerm.Text + ",'Active')", con);
                        con.Open();
                        int n = cmd.ExecuteNonQuery();
                        con.Close();
                        if (n > 0)
                        {
                            this.Alert(" Exam was  Created!", SDRS.Alert.alertTypeEnum.Info);
                        }
                        else
                            this.Alert("Unable to Create Exam!", SDRS.Alert.alertTypeEnum.Warning);
                    }
                    catch (Exception ex)
                    {
                        this.Alert("Unable to perform Insertion Operation!!", SDRS.Alert.alertTypeEnum.Error);
                        MessageBox.Show(ex.Message);
                        con.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                this.Alert("Unable to perform Insertion Operation!!", SDRS.Alert.alertTypeEnum.Error);
                MessageBox.Show(ex.Message);
                con.Close();
            }
        }

        private void frmExamInfo_Load(object sender, EventArgs e)
        {
            // Initialize Term
            cbxTerm.Items.Add("1");
            cbxTerm.Items.Add("2");
            cbxTerm.Items.Add("3");

            // Initialize Subjects
            cbxSub.Items.Add("000");
            cbxSub.Items.Add("121");
            cbxSub.Items.Add("102");
            // Initialize Subject Groups
            CbxGroup.Items.Add("ALL");
            CbxGroup.Items.Add("N");
            CbxGroup.Items.Add("C");
            CbxGroup.Items.Add("S");
        }

        private void gunaButton1_Click(object sender, EventArgs e)
        {
            // Check to see  if the Grading already exist 
            try
            {
                adapter = new SqlDataAdapter("select * from tblGrades WHERE SubCode =" + cbxSub.Text + " AND Grade= '"+txtGrade.Text+"'", con);
                ds = new DataSet();
                adapter.Fill(ds, "Grades");
                if (ds.Tables[0].Rows.Count > 0)
                {
                    this.Alert(" This Grading Exists!!", SDRS.Alert.alertTypeEnum.Error);
                }
                //If user not exist proceed to register
                else
                {
                    try
                    {
                        cmd = new SqlCommand("INSERT into tblGrades(SubCode,Grade,Min,Max,Comment) values(" + cbxSub.Text + ", '" + txtGrade.Text + "'," + txtMin.Text + "," + txtMax.Text + ",'" + txtComment.Text + "')", con);
                        con.Open();
                        int n = cmd.ExecuteNonQuery();
                        con.Close();
                        if (n > 0)
                        {
                            this.Alert(" Grading was  Created!", SDRS.Alert.alertTypeEnum.Info);
                        }
                        else
                            this.Alert("Unable to Create Grading!", SDRS.Alert.alertTypeEnum.Warning);
                    }
                    catch (Exception ex)
                    {
                        this.Alert("Unable to perform Insertion Operation!!", SDRS.Alert.alertTypeEnum.Error);
                        MessageBox.Show(ex.Message);
                        con.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                this.Alert("Unable to perform Insertion Operation!!", SDRS.Alert.alertTypeEnum.Error);
                MessageBox.Show(ex.Message);
                con.Close();
            }
        }

        private void btnDelete11_Click(object sender, EventArgs e)
        {
            DialogResult dlg = MessageBox.Show(" Sure to Delete Subject? ", "Confirm Subject Deletion", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (dlg == DialogResult.OK)
            {
                try
                {
                    cmd = new SqlCommand("delete from tblSubjects where SubCode='" + txtSubCode.Text + "'", con);
                    con.Open();
                    int n = cmd.ExecuteNonQuery();
                    con.Close();
                    if (n > 0)
                    {
                        this.Alert("Subject Removed!!", SDRS.Alert.alertTypeEnum.Info);
                    }
                    else
                        this.Alert("Failed to Remove Subject!", SDRS.Alert.alertTypeEnum.Warning);
                }
                catch (Exception ex)
                {
                    this.Alert("Could Perform Deletion Operation!!", SDRS.Alert.alertTypeEnum.Error);
                    con.Close();
                }
            }
        }

        private void gunaButton4_Click(object sender, EventArgs e)
        {
            DialogResult dlg = MessageBox.Show(" Sure to remove this Exam? ", "Confirm Exam Deletion", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (dlg == DialogResult.OK)
            {
                try
                {
                    cmd = new SqlCommand("delete from tblExam where Name='" + txtExamName.Text + "' AND TermID = '" + cbxTerm.Text + "'", con);
                    con.Open();
                    int n = cmd.ExecuteNonQuery();
                    con.Close();
                    if (n > 0)
                    {
                        this.Alert("Exam Removed!!", SDRS.Alert.alertTypeEnum.Info);
                    }
                    else
                        this.Alert("Failed to Remove Exam!", SDRS.Alert.alertTypeEnum.Warning);
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
            DialogResult dlg = MessageBox.Show(" Sure to remove this Grading? ", "Confirm Grading Deletion", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (dlg == DialogResult.OK)
            {
                try
                {
                    cmd = new SqlCommand("delete from tblGrades where SubCode='" + cbxSub.Text + "' AND Grade= '" + txtGrade.Text + "'", con);
                    con.Open();
                    int n = cmd.ExecuteNonQuery();
                    con.Close();
                    if (n > 0)
                    {
                        this.Alert("Grading Removed!!", SDRS.Alert.alertTypeEnum.Info);
                    }
                    else
                        this.Alert("Failed to Remove Grading!", SDRS.Alert.alertTypeEnum.Warning);
                }
                catch (Exception ex)
                {
                    this.Alert("Could Perform Deletion Operation!!", SDRS.Alert.alertTypeEnum.Error);
                    con.Close();
                }
            }
        }
    }
}
