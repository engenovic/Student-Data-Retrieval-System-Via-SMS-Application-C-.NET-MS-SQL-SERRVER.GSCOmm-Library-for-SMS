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
    public partial class frmExamMark : Form
    {
        public frmExamMark()
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
        Dataset ds1;
        DataTable dt = new DataTable();
        DataRow dr;
        // Global Variables
        int TotalBilled;
        int rno = 0;
        string Grade;
        string Comment;
        // For dealing with the image
        MemoryStream ms;
        byte[] photo_aray;
        // Exam Processing Variables 
        int ADMNO;
        int TOT;
        string NAME;
        int FORM;
        int AVG;
        int RANK;
        string Term;
        string EXNAME;
        string PHONE;
        string MGrade;
        // Subjects 
        String sub1, sub2, sub3, sub4, sub5, sub6,sub7;
        // Sending Results 
        int AdmNo;
        string Subject;
        int Mark;
        string sGrade;
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

        private void frmExamMark_Load(object sender, EventArgs e)
        {
          
            var bunifuDataGrid = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.Controls.Add(bunifuDataGrid);
           // rand();
           
            
        }



        
        // Get various gradings for subjects based on entered mark
        // If you have grading system for different subjects then include # AND SubCode=" + subcode + "
        void getGrade()
        {
            int score = Convert.ToInt32(txtScore.Text);
            //int subcode = Convert.ToInt32(cbxSub.Text); // # Include this if you have 
            // different gradings for different subjects
            try
            {
                adapter = new SqlDataAdapter("SELECT Grade,Comment FROM tblGrades WHERE ("+ score + "> min OR " + score + "= min)  AND (" + score + " < Max OR " + score + " = Max)", con);
                ds = new DataSet(); adapter.Fill(ds, "Grades");
                if (ds.Tables[0].Rows.Count > 0)
                {
                    // display on input controls 
                    Grade = ds.Tables[0].Rows[rno][0].ToString();
                    Comment = ds.Tables[0].Rows[rno][1].ToString();
                }
                else
                {
                    this.Alert("Assigned Default Grading for this Subject", SDRS.Alert.alertTypeEnum.Warning);
                    Grade = "Y";
                    Comment = "Pending";
                }
            }
            catch (Exception ex)
            {
                this.Alert("Could not Perform Query Operation!", SDRS.Alert.alertTypeEnum.Error);
            }
            
        }
        void rand()
        {
            Random random = new Random();
            int randomNumber = random.Next(35, 100);
            txtScore.Text = randomNumber.ToString();
        }
        private void btnSave11_Click(object sender, EventArgs e)
        {
            // Check to see  if the student exist 
            try
            {
                adapter = new SqlDataAdapter("select * from tblStudents WHERE AdmNo= " + txtAdmNo.Text + "", con);
                ds = new DataSet(); adapter.Fill(ds, "tblStudents");
                if (ds.Tables[0].Rows.Count > 0)
                {
                    // Check if the Student has already been awarded for a certain subject and and ExamID
                    try
                    {
                        adapter = new SqlDataAdapter("select * from tblMark WHERE AdmNo= " + txtAdmNo.Text + " AND Subject= '" + cbxSub.Text + "' AND ExamID= (SELECT ExamID FROM tblExam WHERE Status= 'Active') AND Grade='N'", con);
                        ds = new DataSet(); adapter.Fill(ds, "marks");
                        if (ds.Tables[0].Rows.Count > 0)
                        {
                           
                            getGrade();
                            //cmd = new SqlCommand("INSERT into tblMark(AdmNo,Subject,ExamID,Mark,Grade,Comment) values(" + txtAdmNo.Text + "," + cbxSub.Text + "," + txtScore.Text + ",'" + Grade + "', '" + Comment + "')", con);
                          
                            cmd = new SqlCommand("UPDATE tblMark SET Mark=" + txtScore.Text + " ,Grade='" + Grade + "', Comment='" + Comment + "' WHERE AdmNo=" + txtAdmNo.Text + " AND Subject='" + cbxSub.Text + "'", con);
                            con.Open();
                            int n = cmd.ExecuteNonQuery();
                            con.Close();
                            if (n > 0)
                            {
                                this.Alert("Marks were awarded to !" + txtAdmNo.Text, SDRS.Alert.alertTypeEnum.Info);
                                getSubjects();
                                rand();
                            }
                            else
                                this.Alert("Unable to Grade the Student!", SDRS.Alert.alertTypeEnum.Warning);
                        }
                        else
                        {
                            this.Alert("Marks already awarded for this subject !", SDRS.Alert.alertTypeEnum.Error);
                        }
                    }
                    catch (Exception ex)
                    {
                        this.Alert("Unable to perform Insertion Operation!!", SDRS.Alert.alertTypeEnum.Error);
                        MessageBox.Show(ex.Message);
                        con.Close();
                    }


                    }

                else
                    {
                        this.Alert("A student with this Admission does not Exists!!", SDRS.Alert.alertTypeEnum.Error);
                    }     
            }
            catch (Exception ex)
            {
                this.Alert("Could Perform Insertion Operation!!", SDRS.Alert.alertTypeEnum.Error);
                //MessageBox.Show(ex.Message);
                con.Close();
            }
        }
        // A function to load subjects on the combobox as per specified Student dynamically
        // After every award, the data is refreshed until there are no empty subjects and the user is notified or next student is loaded
        public void getSubjects()
        {


            try
            {
                adapter = new SqlDataAdapter("SELECT Subject FROM tblMark WHERE AdmNo="+txtAdmNo.Text+ " AND ExamID=(SELECT ExamID FROM tblExam WHERE Status= 'Active') AND Grade='N' ", con);
                ds = new DataSet();
                adapter.Fill(ds, "Subjects");
                if (ds.Tables[0].Rows.Count > 0)
                {
                cbxSub.DisplayMember = "Subject";
                cbxSub.ValueMember = "Subject";
                cbxSub.DataSource = ds.Tables[0];
                cbxSub.BindingContext = this.BindingContext;
              

                }
                // Exam Not found
                else
    this.Alert("There is no Other Active  Exam left for this Student!!", SDRS.Alert.alertTypeEnum.Error);

                con.Close();
            }
           catch (Exception ex)
           {
                MessageBox.Show(ex.Message);
                con.Close();
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
                dgvMarks.DataSource = DtSet.Tables[0];
                MyConnection.Close();
                this.Alert(name + "date imported", SDRS.Alert.alertTypeEnum.Success);
                DialogResult dlg = MessageBox.Show(" Empty data shall be skipped", "Import from Excel", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                if (dlg == DialogResult.OK)
                {
                    this.Alert("Records Updated" , SDRS.Alert.alertTypeEnum.Success);
                    //insertDB();
                }
            }
            catch (Exception ex)
            {
                this.Alert("Sorry! We could not import that one" + ex.Message, SDRS.Alert.alertTypeEnum.Error);
            }
        }

        private void gunaButton2_Click(object sender, EventArgs e)
        {
            //Rank();
            PushExam();
           // PullExam("+254707142565",1672);
        }

        // Rank Student and update the POS column
        public void PushExam()
        {
            
            try
            {

                adapter = new SqlDataAdapter("SELECT* FROM tblResult", con);
                ds = new DataSet();
                adapter.Fill(ds, "Results");
                adapter.Fill(dt);
                if (ds.Tables[0].Rows.Count > 0)
                {
                    // Open Connection and perform the insert until the end of the rows
                   // con.Open();
                    foreach (DataRow row in dt.Rows)
                    {
                        int pos = Convert.ToInt32(row["POS"]);
                       int admno = Convert.ToInt32(row["AdmNo"]);   
                        string nme = row["Name"].ToString();
                        string tm = row["Term"].ToString();
                        string Exm = row["Exam"].ToString();
                        int Form = Convert.ToInt32(row["Form"]);
                        int mrk = Convert.ToInt32(row["Score"]);
                        string phone = row["PhoneNo"].ToString();
                        string mg = row["MeanGrade"].ToString();
                        string score = setResult(admno);
                        string s = Exm + ", " + tm + " NAME: " + nme + " "+ "ADMNO: " + admno + " " + "Form: " + Form.ToString() + " " + score + "MEAN GRADE: " + mg + " " + "MEAN MARK: " + mrk.ToString() + "%" + " " + "POS:" + pos.ToString();
                        // string score = setResult(admno);
                        frmDashb smex = new frmDashb();
                        smex.AutoSMS(s,phone);
                    //MessageBox.Show( s);
                        Thread.Sleep(1000);
                    }
                    con.Close();


                }
            }
            catch (Exception ex)
            {
                this.Alert("Unable to perform Insertion Operation!!", SDRS.Alert.alertTypeEnum.Error);
                MessageBox.Show(ex.Message);
                
            }
        }
        public void PullExam(string phone, int adm)
        {

            // Search student to pay Fees
            try
            {

                adapter = new SqlDataAdapter("SELECT* FROM tblResult,(SELECT PhoneNO FROM tblStudents WHERE AdmNo="+adm+") AS number, (SELECT Stream FROM tblStudents WHERE AdmNo= "+adm+") AS Stream WHERE AdmNo= "+adm+"", con);
                ds = new DataSet(); 
                adapter.Fill(ds, "Results");
                if (ds.Tables[0].Rows.Count > 0)
                {
                    string name = ds.Tables[0].Rows[rno][2].ToString();
                    string exam = ds.Tables[0].Rows[rno][3].ToString();
                    string term = ds.Tables[0].Rows[rno][5].ToString();
                    string stream = ds.Tables[0].Rows[rno][11].ToString();
                    string pno = ds.Tables[0].Rows[rno][10].ToString();
                    string grade = ds.Tables[0].Rows[rno][8].ToString();
                    int pos = Convert.ToInt32(ds.Tables[0].Rows[rno][9]);
                    int form = Convert.ToInt32(ds.Tables[0].Rows[rno][4]);
                    int mark = Convert.ToInt32(ds.Tables[0].Rows[rno][6]);
                    
                    if (pno == phone)
                    {
                        string score = setResult(adm);
                        string s = exam + ", " + term + " NAME: " + name + " " + "ADMNO: " + adm + " " + "Form: " + form.ToString() + stream + " " + score + "MEAN GRADE: " + grade + " " + "MEAN MARK: " + mark.ToString() + "%" + " " + "POS:" + pos.ToString();
                        frmDashb smspe = new frmDashb();
                        smspe.AutoSMS(s, phone);
                        //Thread.Sleep(3000);
                    }
                    else
                    {
                        frmDashb dsm = new frmDashb();
                        dsm.AutoSMS("Failed. The details you provided does not match  our records. Please ensure you provide the correct Admission number", phone);

                    }
                    //MessageBox.Show(s);
                }
                // If the student is not found
                else
                {
                    frmDashb ds= new frmDashb();
                    ds.AutoSMS("Failed. We could not process that request! Please try again later or contact 0707142565 for assistance", phone);
                }
                    
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message+ "Pull Exam");
                this.Alert("Could Perform query Operation" + ex.Message, SDRS.Alert.alertTypeEnum.Warning);
            }
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

                for (i = 0; i <= dgvMarks.RowCount - 1; i++)
                {
                    for (j = 0; j <= dgvMarks.ColumnCount - 1; j++)
                    {
                        DataGridViewCell cell = dgvMarks[j, i];
                        xlWorkSheet.Cells[i + 1, j + 1] = cell.Value;
                    }
                }

                xlWorkBook.SaveAs("C:\\Users\\NGENO VICTOR\\Desktop\\FINAL YEAR PROJECT\\SDRS\\IMPLEMENTATION\\files\\" + name + "", Excel.XlFileFormat.xlWorkbookNormal, misValue, misValue, misValue, misValue, Excel.XlSaveAsAccessMode.xlExclusive, misValue, misValue, misValue, misValue, misValue);
                xlWorkBook.Close(true, misValue, misValue);
                xlApp.Quit();

                releaseObject(xlWorkSheet);
                releaseObject(xlWorkBook);
                releaseObject(xlApp);

                this.Alert(name + "File Created", SDRS.Alert.alertTypeEnum.Success);
            }
            catch (Exception ex)
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
            for (int i = 0; i < dgvMarks.Rows.Count; i++)
            {
                string StrQuery = @"INSERT INTO std VALUES (" + dgvMarks.Rows[i].Cells["ENG"].Value + ", " + dgvMarks.Rows[i].Cells["KISW"].Value + "," + dgvMarks.Rows[i].Cells["MATH"].Value + "," + dgvMarks.Rows[i].Cells["BIO"].Value + ");";

                try
                {
                    using (SqlConnection conn = new SqlConnection("Data Source=ENGINEERNGENO;Initial Catalog=SDRS;Integrated Security=True"))
                    {
                        using (SqlCommand comm = new SqlCommand(StrQuery, conn))
                        {
                            conn.Open();
                            comm.ExecuteNonQuery();
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }

        }

        private void gunaButton1_Click(object sender, EventArgs e)
        {
            getSubjects();
        }

        private void gunaGradientButton2_Click(object sender, EventArgs e)
        {
            Rank();
        }

        // This function gets all the marks for students and 
        // related info 
        void ProcessExam()
        {
            try
            {
                 // Getting Marks from Marks table 
                adapter = new SqlDataAdapter("SELECT  AdmNo, sum(Mark) as Total, avg(Mark) as AVG from tblMark group by AdmNo ORDER BY Total DESC  ", con);
                ds = new DataSet();
                adapter.Fill(ds, "Marks");
                adapter.Fill(dt);

                int mks = ds.Tables[0].Rows.Count;

                if (mks > 0)
                {
                     // From the distinct marks obtained get other student related information
                     // 1. insert the marks to the result table 2. Rank the students according to their forms 
                    //3. Send the processed results to the parent's phone
                    foreach (DataRow row in dt.Rows)
                    {
                         ADMNO = Convert.ToInt32(row["AdmNo"]);
                         TOT= Convert.ToInt32(row["Total"]);
                        AVG= Convert.ToInt32(row["AVG"]);
                        adapter = new SqlDataAdapter("SELECT  Name, Form,(select Name from tblTerm WHERE  status = 'Current'), (select Year from tblTerm as Term WHERE  status = 'Current'), (SELECT Name FROM tblExam WHERE Status= 'Active'), PhoneNo, (SELECT Grade FROM tblGrades WHERE( "+AVG+ " > min OR " + AVG + " = min)  AND(" + AVG + "< Max OR " + AVG + " = Max)) FROM tblStudents WHERE AdmNo=" + ADMNO+" ", con);
                        ds = new DataSet();
                        adapter.Fill(ds, "StudentData");
                       
                         NAME = ds.Tables[0].Rows[rno][0].ToString();
                        FORM= Convert.ToInt32(ds.Tables[0].Rows[rno][1]);
                         Term = "Term "+ ds.Tables[0].Rows[rno][2].ToString() + " "+ ds.Tables[0].Rows[rno][3].ToString();
                        EXNAME = ds.Tables[0].Rows[rno][4].ToString();
                        PHONE = ds.Tables[0].Rows[rno][5].ToString();
                        MGrade = ds.Tables[0].Rows[rno][6].ToString();
                           InsertExam();
                    }
                    
                    this.Alert("All the Student's Results were processed Successfully!", SDRS.Alert.alertTypeEnum.Success);



                }
                else

                    this.Alert("Failed to Process Marks!!", SDRS.Alert.alertTypeEnum.Warning);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                this.Alert("Could Perform query Operation" , SDRS.Alert.alertTypeEnum.Error);
            }
        }
        void InsertExam()
        {
            try
            {
                cmd = new SqlCommand("INSERT into tblResult(AdmNo,Name,Exam,Form,Term,Score,PhoneNo,MeanGrade) values(" + ADMNO + ", '"+ NAME+ "','" + EXNAME + "'," + FORM+ ",'" + Term + "', " + AVG+ ",'" + PHONE + "','" + MGrade+ "'  )", con);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception ex)
            {
                this.Alert("Unable to perform Insertion Operation!!", SDRS.Alert.alertTypeEnum.Error);
                MessageBox.Show(ex.Message);
                con.Close();
                Rank();
            }
        }

        public void Rank()
        {

            try
            {

                adapter = new SqlDataAdapter("SELECT *, RANK ()  OVER(PARTITION BY Form ORDER BY Score DESC) AS Rank FROM tblResult", con);
                ds = new DataSet();
                adapter.Fill(ds, "Marks");
                adapter.Fill(dt);
                if (ds.Tables[0].Rows.Count > 0)
                {

                    foreach (DataRow row in dt.Rows)
                    {
                        int ADMNO = Convert.ToInt32(row["AdmNo"]);
                        int rnk = Convert.ToInt32(row["Rank"]);
                        // AVG = Convert.ToInt32(row["AVG"]);
                        cmd = new SqlCommand("UPDATE tblResult SET POS = " + rnk + " WHERE AdmNo= " + ADMNO + "", con);
                        con.Open();
                        int n = cmd.ExecuteNonQuery();
                        con.Close();
                        
                    }

                    MessageBox.Show("Ranked all Students!!");
                   

                }
               // else
                   // return "Failed to Process Exams";
            }
            catch (Exception ex)
            {
                
                //return (ex.Message);

            }
        }
       string   setResult(int adm)
        {
           
            adapter = new SqlDataAdapter("SELECT  CONCAT(Subject,Mark, Grade) AS Score FROM tblMark  WHERE AdmNo= " + adm + "", con);
            ds = new DataSet();
            adapter.Fill(ds, "Scores");
            var dt = new DataTable();
            adapter.Fill(dt);
            string s = string.Join(", ", dt.Rows.OfType<DataRow>().Select(r => r[0].ToString()));
             return s;
            
        }
        // Load data in adapter
        void showGrid()
        {
            try
            {
                adapter = new SqlDataAdapter("select * from tblMark", con);
                adapter.MissingSchemaAction = MissingSchemaAction.AddWithKey;
                ds = new DataSet();
                adapter.Fill(ds, "Marks");
                if (ds.Tables[0].Rows.Count > 0)
                {
                    // display on Grid 
                    dgvMarks.DataSource = ds;
                    dgvMarks.DataMember = "Marks";
                }
                else
                    dgvMarks.Rows.Add("No Existing Records Found");

            }
            catch (Exception ex)
            {
                this.Alert("Could Perform query Operation" + ex.Message, SDRS.Alert.alertTypeEnum.Warning);
            }

        }

        private void gunaGradientButton1_Click(object sender, EventArgs e)
        {
            ProcessExam();
            
            
        }

    }
}
