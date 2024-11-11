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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace PAYROLLTEST
{
    public partial class Form5 : Form
    {
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-GEO9JUP\\SQLEXPRESS;Initial Catalog=Login;Integrated Security=True;");
        SqlCommand cmd;
        DataTable dt;
        SqlDataAdapter da;
        DataSet ds;


        public Form5()
        {
            InitializeComponent();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
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

        private void Form5_Load(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
