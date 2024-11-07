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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;


namespace PAYROLLTEST
{
    public partial class Form2 : Form
    {
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-GEO9JUP\\SQLEXPRESS;Initial Catalog=Login;Integrated Security=True;");
        SqlCommand cmd;
        DataTable dt;
        SqlDataAdapter da;
        DataSet ds;



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
            try
            {
                // Hard-coded connection string (not recommended for production)
                string connectionString = "Data Source=DESKTOP-GEO9JUP\\SQLEXPRESS;Initial Catalog=Login;Integrated Security=True;";

                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();

                    // Insert query
                    string query = @"INSERT INTO Employee_new 
        (ID, NameOfEmployee, Email, EmployeeID, Department, Position, TypeOfRate, MonthlyRate, MonthlyRateBasisDays, DailyRate, DailyRateAmountfromMonthlyRate, SSSCUSTOMBASED, PHICCUSTOMBASED, SSSno, PHICno, HDMFno, TINno) 
        VALUES 
        (@ID, @NameOfEmployee, @Email, @EmployeeID, @Department, @Position, @TypeOfRate, @MonthlyRate, @MonthlyRateBasisDays, @DailyRate, @DailyRateAmountfromMonthlyRate, @SSSCUSTOMBASED, @PHICCUSTOMBASED, @SSSno, @PHICno, @HDMFno, @TINno)";

                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        // Add parameters with TryParse logic directly
                        cmd.Parameters.AddWithValue("@ID", int.TryParse(txtcode.Text, out int id) ? id : (object)DBNull.Value);
                        cmd.Parameters.AddWithValue("@NameOfEmployee", txtfname.Text);
                        cmd.Parameters.AddWithValue("@Email", txtemail.Text);
                        cmd.Parameters.AddWithValue("@EmployeeID", txtEmpID.Text);
                        cmd.Parameters.AddWithValue("@Department", txtdpt.Text);
                        cmd.Parameters.AddWithValue("@Position", txtposition.Text);
                        cmd.Parameters.AddWithValue("@TypeOfRate", txtTypeRate.Text);
                        cmd.Parameters.AddWithValue("@MonthlyRate", decimal.TryParse(txtMonthlyRate.Text, out decimal monthlyRate) ? monthlyRate : (object)DBNull.Value);
                        cmd.Parameters.AddWithValue("@MonthlyRateBasisDays", int.TryParse(txtMonthlyRateBasisDays.Text, out int monthlyRateBasisDays) ? monthlyRateBasisDays : (object)DBNull.Value);
                        cmd.Parameters.AddWithValue("@DailyRate", decimal.TryParse(txtdrate.Text, out decimal dailyRate) ? dailyRate : (object)DBNull.Value);
                        cmd.Parameters.AddWithValue("@DailyRateAmountfromMonthlyRate", decimal.TryParse(txtDailyRateAmtFrmMonthlyRate.Text, out decimal dailyRateAmtFromMonthlyRate) ? dailyRateAmtFromMonthlyRate : (object)DBNull.Value);
                        cmd.Parameters.AddWithValue("@SSSCUSTOMBASED", int.TryParse(txtSSSCustomBased.Text, out int SSSCustomBased) ? (object)SSSCustomBased : DBNull.Value);
                        cmd.Parameters.AddWithValue("@PHICCUSTOMBASED", int.TryParse(txtPhicCustom.Text, out int PhicCustom) ? (object)PhicCustom : DBNull.Value);
                        cmd.Parameters.AddWithValue("@SSSno", txtSSSnumber.Text);
                        cmd.Parameters.AddWithValue("@PHICno", txtPhicNo.Text);
                        cmd.Parameters.AddWithValue("@HDMFno", txtHdmfNo.Text);
                        cmd.Parameters.AddWithValue("@TINno", txtTinNo.Text);

                        // Check if any numeric fields were invalid
                        if (cmd.Parameters["@ID"].Value is DBNull )

                        {
                            MessageBox.Show("Please ensure all numeric fields are entered correctly.");
                            return;
                        }

                        // Execute the query
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Record successfully created!");

                        // Clear text fields after successful operation
                        ClearTextFields();
                    }
                }
            }
            catch (Exception ex)
            {
                // Display the error message in case of any exception
                MessageBox.Show("Error: " + ex.Message);
            }

            void ClearTextFields()
            {
                txtcode.Text = "";
                txtfname.Text = "";
                txtemail.Text = "";
                txtEmpID.Text = "";
                txtdpt.Text = "";
                txtposition.Text = "";
                txtTypeRate.Text = "";
                txtMonthlyRate.Text = "";
                txtMonthlyRateBasisDays.Text = "";
                txtdrate.Text = "";
                txtDailyRateAmtFrmMonthlyRate.Text = "";
                txtSSSCustomBased.Text = "";
                txtPhicCustom.Text = "";
                txtSSSnumber.Text = "";
                txtPhicNo.Text = "";
                txtHdmfNo.Text = "";
                txtTinNo.Text = "";
            }


        }

        private void btnNew_Click(object sender, EventArgs e)
        {

            txtcode.Text = "";
            txtfname.Text = "";
            txtemail.Text = "";
            txtEmpID.Text = "";
            txtdpt.Text = "";
            txtposition.Text = "";
            txtTypeRate.Text = "";
            txtMonthlyRate.Text = "";
            txtMonthlyRateBasisDays.Text = "";
            txtdrate.Text = "";
            txtDailyRateAmtFrmMonthlyRate.Text = "";
            txtSSSCustomBased.Text = "";
            txtPhicCustom.Text = "";
            txtSSSnumber.Text = "";
            txtPhicNo.Text = "";
            txtHdmfNo.Text = "";
            txtTinNo.Text = "";
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
          
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {

            try
            {
                // Create a connection to the SQL Server database
                using (SqlConnection con = new SqlConnection("Data Source=DESKTOP-GEO9JUP\\SQLEXPRESS;Initial Catalog=Login;Integrated Security=True;"))
                {
                    // Open the database connection
                    con.Open();

                    // SQL update query for the Employee_new table
                    SqlCommand cmd = new SqlCommand(@"UPDATE Employee_new 
            SET NameOfEmployee=@NameOfEmployee, Email=@Email, EmployeeID=@EmployeeID, 
                Department=@Department, Position=@Position, TypeOfRate=@TypeOfRate, 
                MonthlyRate=@MonthlyRate, MonthlyRateBasisDays=@MonthlyRateBasisDays, 
                DailyRate=@DailyRate, DailyRateAmountfromMonthlyRate=@DailyRateAmountfromMonthlyRate, 
                SSSCUSTOMBASED=@SSSCUSTOMBASED, PHICCUSTOMBASED=@PHICCUSTOMBASED, 
                SSSno=@SSSno, PHICno=@PHICno, HDMFno=@HDMFno, TINno=@TINno 
            WHERE ID=@ID", con);

                    // Adding parameters
                    cmd.Parameters.AddWithValue("@ID", int.Parse(txtcode.Text));
                    cmd.Parameters.AddWithValue("@NameOfEmployee", txtfname.Text);
                    cmd.Parameters.AddWithValue("@Email", txtemail.Text);
                    cmd.Parameters.AddWithValue("@EmployeeID", txtEmpID.Text);
                    cmd.Parameters.AddWithValue("@Department", txtdpt.Text);
                    cmd.Parameters.AddWithValue("@Position", txtposition.Text);
                    cmd.Parameters.AddWithValue("@TypeOfRate", txtTypeRate.Text);
                    cmd.Parameters.AddWithValue("@MonthlyRate", int.TryParse(txtMonthlyRate.Text, out int monthlyRate) ? (object)monthlyRate : DBNull.Value);
                    cmd.Parameters.AddWithValue("@MonthlyRateBasisDays", int.TryParse(txtMonthlyRateBasisDays.Text, out int monthlyRateBasisDays) ? (object)monthlyRateBasisDays : DBNull.Value);
                    cmd.Parameters.AddWithValue("@DailyRate", int.TryParse(txtdrate.Text, out int dailyRate) ? (object)dailyRate : DBNull.Value);
                    cmd.Parameters.AddWithValue("@DailyRateAmountfromMonthlyRate", int.TryParse(txtDailyRateAmtFrmMonthlyRate.Text, out int dailyRateAmtFromMonthlyRate) ? (object)dailyRateAmtFromMonthlyRate : DBNull.Value);
                    cmd.Parameters.AddWithValue("@SSSCUSTOMBASED", int.TryParse(txtSSSCustomBased.Text, out int SSSCustomBased) ? (object)SSSCustomBased :DBNull.Value);
                    cmd.Parameters.AddWithValue("@PHICCUSTOMBASED", int.TryParse(txtPhicCustom.Text, out int PhicCustom) ? (object)PhicCustom : DBNull.Value);
                    cmd.Parameters.AddWithValue("@SSSno", txtSSSnumber.Text);
                    cmd.Parameters.AddWithValue("@PHICno", txtPhicNo.Text);
                    cmd.Parameters.AddWithValue("@HDMFno", txtHdmfNo.Text);
                    cmd.Parameters.AddWithValue("@TINno", txtTinNo.Text);

                    // Execute the update command
                    cmd.ExecuteNonQuery();

                    // Close the connection
                    con.Close();

                    // Notify the user of a successful update
                    MessageBox.Show("Successfully Updated");
                }
            }
            catch (Exception ex)
            {
                // Display an error message if an exception occurs
                MessageBox.Show("Error: " + ex.Message);
            }

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
                SqlCommand cmd = new SqlCommand("Select NameOfEmployee, Email, EmployeeID, Department, Position, TypeOfRate, MonthlyRate, MonthlyRateBasisDays, DailyRate, DailyRateAmountfromMonthlyRate, SSSCUSTOMBASED, PHICCUSTOMBASED, SSSno, PHICno, HDMFno, TINno FROM Employee_new WHERE ID=@ID", con);
                cmd.Parameters.AddWithValue("ID", int.Parse(txtcode.Text));
                SqlDataReader da = cmd.ExecuteReader();
                while (da.Read())
                {
                    // Map the retrieved values to the corresponding text fields
                    txtfname.Text = da["NameOfEmployee"].ToString();
                    txtemail.Text = da["Email"].ToString();
                    txtEmpID.Text = da["EmployeeID"].ToString();
                    txtdpt.Text = da["Department"].ToString();
                    txtposition.Text = da["Position"].ToString();
                    txtTypeRate.Text = da["TypeOfRate"].ToString();
                    txtMonthlyRate.Text = da["MonthlyRate"].ToString();
                    txtMonthlyRateBasisDays.Text = da["MonthlyRateBasisDays"].ToString();
                    txtdrate.Text = da["DailyRate"].ToString();
                    txtDailyRateAmtFrmMonthlyRate.Text = da["DailyRateAmountfromMonthlyRate"].ToString();
                    txtSSSCustomBased.Text = da["SSSCUSTOMBASED"].ToString();
                    txtPhicCustom.Text = da["PHICCUSTOMBASED"].ToString();
                    txtSSSnumber.Text = da["SSSno"].ToString();
                    txtPhicNo.Text = da["PHICno"].ToString();
                    txtHdmfNo.Text = da["HDMFno"].ToString();
                    txtTinNo.Text = da["TINno"].ToString();

                }
                con.Close();
            }
        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
          
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

        private void btnLoad_Click(object sender, EventArgs e)
        {

            listView1.Columns.Clear(); // Clear existing columns

            // Add columns to the ListView, adjusting width where necessary
            listView1.Columns.Add("ID", 50, HorizontalAlignment.Left);
            listView1.Columns.Add("Name Of Employee", 150, HorizontalAlignment.Left);
            listView1.Columns.Add("Email", 150, HorizontalAlignment.Left);
            listView1.Columns.Add("Employee ID", 100, HorizontalAlignment.Left);
            listView1.Columns.Add("Department", 100, HorizontalAlignment.Left);
            listView1.Columns.Add("Position", 100, HorizontalAlignment.Left);
            listView1.Columns.Add("Type Of Rate", 100, HorizontalAlignment.Left);
            listView1.Columns.Add("Monthly Rate", 100, HorizontalAlignment.Right);
            listView1.Columns.Add("Monthly Rate Basis Days", 150, HorizontalAlignment.Right);
            listView1.Columns.Add("Daily Rate", 100, HorizontalAlignment.Right);
            listView1.Columns.Add("Daily Rate Amount from Monthly Rate", 150, HorizontalAlignment.Right);
            listView1.Columns.Add("SSS CUSTOM BASED", 150, HorizontalAlignment.Right);
            listView1.Columns.Add("PHIC CUSTOM BASED", 150, HorizontalAlignment.Right);
            listView1.Columns.Add("SSSno", 120, HorizontalAlignment.Left);
            listView1.Columns.Add("PHICno", 120, HorizontalAlignment.Left);
            listView1.Columns.Add("HDMFno", 120, HorizontalAlignment.Left);
            listView1.Columns.Add("TINno", 120, HorizontalAlignment.Left);

            // Ensure the ListView uses details view
            listView1.View = View.Details;

            try
            {
                con.Open();

                // Fetch data from the database
                string query = "SELECT ID, NameOfEmployee, Email, EmployeeID, Department, Position, " +
                               "TypeOfRate, MonthlyRate, MonthlyRateBasisDays, DailyRate, " +
                               "DailyRateAmountfromMonthlyRate, SSSCUSTOMBASED, PHICCUSTOMBASED, " +
                               "SSSno, PHICno, HDMFno, TINno FROM Employee_new";

                cmd = new SqlCommand(query, con);
                da = new SqlDataAdapter(cmd);
                ds = new DataSet();
                da.Fill(ds, "EmployeeData");
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while loading data: " + ex.Message);
                return; // Exit the method if there's an error
            }
            finally
            {
                if (con.State == ConnectionState.Open)
                    con.Close();
            }

            // Check if the dataset contains any data
            if (ds.Tables["EmployeeData"].Rows.Count > 0)
            {
                DataTable dt = ds.Tables["EmployeeData"];
                listView1.Items.Clear(); // Clear existing items

                // Iterate through each row
                foreach (DataRow row in dt.Rows)
                {
                    // Create a new ListViewItem, starting with the first column (ID)
                    ListViewItem item = new ListViewItem(row["ID"].ToString());

                    // Add remaining columns as subitems in the correct order
                    item.SubItems.Add(row["NameOfEmployee"].ToString());
                    item.SubItems.Add(row["Email"].ToString());
                    item.SubItems.Add(row["EmployeeID"].ToString());
                    item.SubItems.Add(row["Department"].ToString());
                    item.SubItems.Add(row["Position"].ToString());
                    item.SubItems.Add(row["TypeOfRate"].ToString());
                    item.SubItems.Add(row["MonthlyRate"].ToString());
                    item.SubItems.Add(row["MonthlyRateBasisDays"].ToString());
                    item.SubItems.Add(row["DailyRate"].ToString());
                    item.SubItems.Add(row["DailyRateAmountfromMonthlyRate"].ToString());
                    item.SubItems.Add(row["SSSCUSTOMBASED"].ToString());
                    item.SubItems.Add(row["PHICCUSTOMBASED"].ToString());
                    item.SubItems.Add(row["SSSno"].ToString());
                    item.SubItems.Add(row["PHICno"].ToString());
                    item.SubItems.Add(row["HDMFno"].ToString());
                    item.SubItems.Add(row["TINno"].ToString());

                    // Add the full ListViewItem to the ListView control
                    listView1.Items.Add(item);
                }
            }
            else
            {
                MessageBox.Show("No data found in the Employee_new table.");
            }
        }

        private void btn_edit_Click_1(object sender, EventArgs e)
        {
           
        }

        private void btnDelete_Click_1(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-GEO9JUP\\SQLEXPRESS;Initial Catalog=Login;Integrated Security=True;");
            con.Open();
            SqlCommand cmd = new SqlCommand("delete Employee_new where ID=@ID", con);
            cmd.Parameters.AddWithValue("ID", int.Parse(txtcode.Text));

            cmd.ExecuteNonQuery();

            con.Close();
            MessageBox.Show("Successfully Deleted");
        }

        private void btn_edit_Click_2(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
            this.Hide();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtDailyRateAmtFrmMonthlyRate_TextChanged(object sender, EventArgs e)
        {
           

        }

        private void txtMonthlyRate_TextChanged(object sender, EventArgs e)
        {
            // Check if MonthlyRate text box is empty or contains only whitespace
            if (string.IsNullOrWhiteSpace(txtMonthlyRate.Text))
            {
                // Clear the Daily Rate Amount field and exit the method
                txtDailyRateAmtFrmMonthlyRate.Text = "";
                return;
            }

            // Declare variables to hold parsed values
            double MonthlyRate;
            double MonthlyDays;

            // Try to parse the MonthlyRate from the text box
            if (!double.TryParse(txtMonthlyRate.Text, out MonthlyRate) || MonthlyRate <= 0)
            {
                // If parsing fails or MonthlyRate is not positive, clear the Daily Rate Amount field
                txtDailyRateAmtFrmMonthlyRate.Text = "";
                return;
            }

            // Try to parse the MonthlyRateBasisDays from the text box
            if (double.TryParse(txtMonthlyRateBasisDays.Text, out MonthlyDays) && MonthlyDays > 0)
            {
                // Calculate DailyRateAmtFrmMonthlyRate only if MonthlyDays is greater than zero
                double DailyRateAmtFrmMonthlyRate = MonthlyRate / MonthlyDays;

                // Set the result in the Daily Rate Amount field with two decimal places
                txtDailyRateAmtFrmMonthlyRate.Text = DailyRateAmtFrmMonthlyRate.ToString("F2");
            }
            else
            {
                // If MonthlyDays is invalid or zero, set the Daily Rate Amount field to "Invalid"
                txtDailyRateAmtFrmMonthlyRate.Text = "Invalid";
            }


            if (txtMonthlyRate.Text != "")
            {
                double value;
                if (double.TryParse(txtMonthlyRate.Text, out value))
                {
                    double dividedValue = value ; // Replace 20 with the divisor

                    // Set the result in both TextBoxes
                    txtSSSCustomBased.Text = dividedValue.ToString("F2");
                    txtPhicCustom.Text = dividedValue.ToString("F2"); // Output in new TextBox
                }
                else
                {
                    // Handle invalid input
                    txtSSSCustomBased.Text = "Invalid input";
                    txtPhicCustom.Text = "Invalid input"; // Update new TextBox for consistency
                }
            }
            else
            {
                // Clear both TextBoxes if the input is empty
                txtSSSCustomBased.Text = "";
                txtPhicCustom.Text = "";
            }

        }

        private void txtTypeRate_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtdrate_TextChanged(object sender, EventArgs e)
        {
            if (txtdrate.Text != "")
            {
                double value;
                if (double.TryParse(txtdrate.Text, out value))
                {
                    double dividedValue = value * 20; // Replace 20 with the divisor

                    // Set the result in both TextBoxes
                    txtSSSCustomBased.Text = dividedValue.ToString("");
                    txtPhicCustom.Text = dividedValue.ToString(""); // Output in new TextBox
                }
                else
                {
                    // Handle invalid input
                    txtSSSCustomBased.Text = "Invalid input";
                    txtPhicCustom.Text = "Invalid input"; // Update new TextBox for consistency
                }
            }
            else
            {
                // Clear both TextBoxes if the input is empty
                txtSSSCustomBased.Text = "";
                txtPhicCustom.Text = "";
            }

        }
    }
}
