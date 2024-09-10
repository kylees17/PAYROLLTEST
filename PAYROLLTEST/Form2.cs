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


namespace PAYROLLTEST
{
    public partial class Form2 : Form
    {


        public Form2()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Connection string should be stored securely and not hard-coded in production
            string connectionString = "Data Source=DESKTOP-GEO9JUP\\SQLEXPRESS;Initial Catalog=Login;Integrated Security=True;";

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();
                using (SqlCommand cmd = new SqlCommand("INSERT INTO Employee_new (ID, FirstName, MiddleName, LastName, Address, Contact, Status, BirthPlace, Sex, Birthday, Age, Emergency, DailyRate, Position, DateHired, PaymentMethod, WorkStatus, Department) VALUES (@ID, @FirstName, @MiddleName, @LastName, @Address, @Contact, @Status, @BirthPlace, @Sex, @Birthday, @Age, @Emergency, @DailyRate, @Position, @DateHired, @PaymentMethod, @WorkStatus, @Department)", con))
                {
                    cmd.Parameters.AddWithValue("@ID", int.Parse(txtcode.Text));
                    cmd.Parameters.AddWithValue("@FirstName", txtfname.Text);
                    cmd.Parameters.AddWithValue("@MiddleName", txtmname.Text);
                    cmd.Parameters.AddWithValue("@LastName", txtlname.Text);
                    cmd.Parameters.AddWithValue("@Address", txtaddress.Text);
                    cmd.Parameters.AddWithValue("@Contact", txtcontact.Text);
                    cmd.Parameters.AddWithValue("@Status", txtstatus.Text);
                    cmd.Parameters.AddWithValue("@BirthPlace", txtbplace.Text);
                    cmd.Parameters.AddWithValue("@Sex", txtsex.Text);
                    cmd.Parameters.AddWithValue("@Birthday", dtpdbirth.Value); // DateTime parameter
                    cmd.Parameters.AddWithValue("@Age", txtage.Text);
                    cmd.Parameters.AddWithValue("@Emergency", txtemerg.Text);
                    cmd.Parameters.AddWithValue("@DailyRate", txtdrate.Text); // Assuming DailyRate is decimal
                    cmd.Parameters.AddWithValue("@Position", txtposition.Text);
                    cmd.Parameters.AddWithValue("@DateHired", dtpdhired.Value); // DateTime parameter
                    cmd.Parameters.AddWithValue("@PaymentMethod", txtpmethod.Text);
                    cmd.Parameters.AddWithValue("@WorkStatus", txtworkstatus.Text);
                    cmd.Parameters.AddWithValue("@Department", txtdpt.Text);

                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Successfully Created");
                }
            }
          


            txtcode.Text = "";
            txtfname.Text = "";
            txtmname.Text = "";
            txtlname.Text = "";
            txtaddress.Text = "";
            txtcontact.Text = "";
            txtstatus.Text = "";
            txtbplace.Text = "";
            txtsex.Text = "";
            dtpdbirth.Text = "";
            txtage.Text = "";
            txtemerg.Text = "";
            txtdrate.Text = "";
            txtposition.Text = "";
            dtpdhired.Text = "";
            txtpmethod.Text = "";
            txtworkstatus.Text = "";
            txtdpt.Text = "";

           
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            txtcode.Text = "";
            txtfname.Text = "";
            txtmname.Text = "";
            txtlname.Text = "";
            txtaddress.Text = "";
            txtcontact.Text = "";
            txtstatus.Text = "";
            txtbplace.Text = "";
            txtsex.Text = "";
            dtpdbirth.Text = "";
            txtage.Text = "";
            txtemerg.Text = "";
            txtdrate.Text = "";
            txtposition.Text = "";
            dtpdhired.Text = "";
            txtpmethod.Text = "";
            txtworkstatus.Text = "";
            txtdpt.Text = "";
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            Menu menu = new Menu();
            menu.Show();
            this.Hide();
        }


        private void Form2_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-GEO9JUP\\SQLEXPRESS;Initial Catalog=Login;Integrated Security=True;");
            con.Open();
            SqlCommand cmd = new SqlCommand("SELECT * FROM Employee_new", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {

            SqlConnection con = new SqlConnection("Data Source=DESKTOP-GEO9JUP\\SQLEXPRESS;Initial Catalog=Login;Integrated Security=True;");
            con.Open();
            SqlCommand cmd = new SqlCommand("UPDATE Employee_new SET FirstName=@FirstName, MiddleName=@MiddleName, LastName=@LastName, Address=@Address, Contact=@Contact, Status=@Status, BirthPlace=@BirthPlace, Sex=@Sex, Birthday=@Birthday, Age=@Age, Emergency=@Emergency, DailyRate=@DailyRate, Position=@Position, DateHired=@DateHired, PaymentMethod=@PaymentMethod, WorkStatus=@WorkStatus, Department=@Department WHERE ID=@ID", con);
            cmd.Parameters.AddWithValue("ID", int.Parse(txtcode.Text));
            cmd.Parameters.AddWithValue("@FirstName", txtfname.Text);
            cmd.Parameters.AddWithValue("@MiddleName", txtmname.Text);
            cmd.Parameters.AddWithValue("@LastName", txtlname.Text);
            cmd.Parameters.AddWithValue("@Address", txtaddress.Text);
            cmd.Parameters.AddWithValue("@Contact", txtcontact.Text);
            cmd.Parameters.AddWithValue("@Status", txtstatus.Text);
            cmd.Parameters.AddWithValue("@BirthPlace", txtbplace.Text);
            cmd.Parameters.AddWithValue("@Sex", txtsex.Text);
            cmd.Parameters.AddWithValue("Birthday", dtpdbirth.Value);
            cmd.Parameters.AddWithValue("@Age", txtage.Text);
            cmd.Parameters.AddWithValue("@Emergency", txtemerg.Text);
            cmd.Parameters.AddWithValue("@DailyRate", txtdrate.Text);
            cmd.Parameters.AddWithValue("@Position", txtposition.Text);
            cmd.Parameters.AddWithValue("@DateHired", dtpdhired.Value);
            cmd.Parameters.AddWithValue("@PaymentMethod", txtpmethod.Text);
            cmd.Parameters.AddWithValue("@WorkStatus", txtworkstatus.Text);
            cmd.Parameters.AddWithValue("@Department", txtdpt.Text);
            cmd.ExecuteNonQuery();
        
            con.Close();
            MessageBox.Show("Successfully Updated");
        }
            private void btnDelete_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-GEO9JUP\\SQLEXPRESS;Initial Catalog=Login;Integrated Security=True;");
            con.Open();
            SqlCommand cmd = new SqlCommand("delete Employee_new where ID=@ID", con);
            cmd.Parameters.AddWithValue("ID", int.Parse(txtcode.Text));

            cmd.ExecuteNonQuery();

            con.Close();
            MessageBox.Show("Successfully Deleted");
        }

        private void textBox12_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtcode_TextChanged(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-GEO9JUP\\SQLEXPRESS;Initial Catalog=Login;Integrated Security=True;");
            con.Open();
            if (txtcode.Text != "") 
            {
                SqlCommand cmd = new SqlCommand("Select FirstName,MiddleName,LastName,Address,Contact,Status,BirthPlace,Sex,Birthday,Age,Emergency,DailyRate,Position,DateHired,PaymentMethod,WorkStatus,Department FROM Employee_new WHERE ID=@ID", con);
                cmd.Parameters.AddWithValue("ID", int.Parse(txtcode.Text));
                SqlDataReader da = cmd.ExecuteReader();
                while (da.Read())
                {
                    txtfname.Text = da.GetValue(0).ToString();
                    txtmname.Text = da.GetValue(1).ToString();
                    txtlname.Text = da.GetValue(2).ToString();
                    txtaddress.Text = da.GetValue(3).ToString();
                    txtcontact.Text = da.GetValue(4).ToString();
                    txtstatus.Text = da.GetValue(5).ToString();
                    txtbplace.Text = da.GetValue(6).ToString();
                    txtsex.Text = da.GetValue(7).ToString();
                    dtpdbirth.Text = da.GetValue(8).ToString();
                    txtage.Text = da.GetValue(9).ToString();
                    txtemerg.Text = da.GetValue(10).ToString();
                    txtdrate.Text = da.GetValue(11).ToString();
                    txtposition.Text = da.GetValue(12).ToString();
                    dtpdhired.Text = da.GetValue(13).ToString();
                    txtpmethod.Text = da.GetValue(14).ToString();
                    txtworkstatus.Text = da.GetValue(15).ToString();
                    txtdpt.Text = da.GetValue(16).ToString();
                }
                con.Close();
            }
        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
            this.Hide();
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void label20_Click(object sender, EventArgs e)
        {

        }
    }
}
