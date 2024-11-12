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
            // Clear existing columns
            listView1.Columns.Clear();

            // Set the ListView to Details view
            listView1.View = View.Details;

            try
            {
                con.Open();

                // Fetch data from the database
                string query = @"SELECT ID, NameOfEmployee, Email, EmployeeID, Department, Position, 
                     TypeOfRate, MonthlyRate, MonthlyRateBasisDays, DailyRate, 
                     DailyRateAmountfromMonthlyRate,
                     SSSno, PHICno, HDMFno, TINno, 
                     DaysOfWork, HoursOfWork, HourlyRate, MinuteRate, BasicPay, 
                     OvertimeMins, OvertimeHrs, OvertimeAmount, RestDaysHrs, RestDaysDays, 
                     RestDayAmount, RestDayOThrs, RestDayOTAmount, TotalEmployeeRestDayHrs, 
                     TotalEmployeeRestDayDays, TotalEmployeeRestDayAmount, SpecialHolidayHrs, 
                     SpecialHolidayDays, SpecialHolidayAmount, SpecialHolidayOTHrs, 
                     SpecialHolidayOTAmount, SpecialHolidayAndRestDayHrs, 
                     SpecialHolidayAndRestDayOTHrs, SpecialHolidayAndRestDayOTAmount, 
                     LegalHolidayHrs, LegalHolidayDays, LegalHolidayAmount, LegalHolidayOTHrs, 
                     LegalOTAmount, LegalHolidayAndRestDayHrs, LegalHolidayAndRestDayDays, 
                     LegalHolidayAndRestDayAmount, LegalHolidayAndRestDayOTHrs, 
                     LegalHolidayAndRestDayOTAmount, TotalEmployeeHolidayHrs, 
                     TotalEmployeeHolidayDays, TotalEmployeeHolidayAmount, 
                     NDonworkingdayHrs, NDonworkingdayAmount, NDOTonworkingdayHrs, 
                     NDOTonworkingdayAmount, NDonLegalHolidayHrs, NDonLegalHolidayAmount, 
                     NDOTonLegalHolidayHrs, NDOTonLegalHolidayAmount, 
                     NDonRestDayLegalHolidayHrs, NDonLegalHolidayRestdayAmount, 
                     NDOTonRestDayLegalHolidayHrs, NDOTonLegalHolidayRestdayAmount, 
                     NDonSpecialHolidayorRestDayHrs, NDonSpecialHolidayorRestDayAmount, 
                     NDOTonSpecialHolidayorRestDayHrs, NDOTonSpecialHolidayorRestDayAmount, 
                     NDSpecialHolidayandRestDayHrs, NDSpecialHolidayandRestDayAmount, 
                     NDOTSpecialHolidayandRestDayHrs, NDOTSpecialHolidayandRestDayAmount, 
                     TotalNDHrs, TotalNDAmount, SalaryAdjustment, LeaveWithPaySickDays, 
                     LeaveWithPayVacationDays, LeaveWithPaySickAmount, LeaveWithPayVacationAmount, 
                     COLA, Incentives, HazzardPay, Commission, CalamityLeave, OtherTaxable2, 
                     TotalTaxableAmount, DeMinimis, IncentiveProgram, Bonus, Column3, 
                     LaundryAllowance, MealAllowance, CompanyLoan, T13MonthPay, 
                     TotalNonTaxable, TotalGrossPay, LateMin, LateMinAmount, LateHour, 
                     LateAmount, AbsentOrWithoutLWPDays, AbsentOrWithoutLWPAmount, 
                     TotalTardiness, SSSCUSTOMBASED, PHICCUSTOMBASED,  SSSBasicPayBased, 
                     SSSGrossBased, SSSstatus, SSS, PHICBasicPayBased, 
                     PHIC, PHICstatus, TotalSocialCost, SSSsalaryloan, SSSCalamityLoan, 
                     HDMFSalaryLoan, HDMFCalamityLoan, TotalGovernmentLoans, CompanyLoans, 
                     OtherLoan1, OtherLoan2, OtherLoan3, TotalOtherLoans, AdjustmentOrRefunds, 
                     SalaryDeduction, Deductions, ManualTeraphyTechniques, UniformDeduction, 
                     MedicalExpensesDeduction, TotalDeductions, AmountDue, TaxableIncome, 
                     WithholdingTax, NetPay, T13thmonthbased, T13thMonthforthisCutoff, 
                     SalaryType, ATM, CASH, ATM#, Remarks
                     FROM Employee_new";

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

                // Clear existing items in the ListView
                listView1.Items.Clear();

                // Add columns dynamically based on the DataTable column names
                foreach (DataColumn column in dt.Columns)
                {
                    // Default all columns to Left alignment, but numeric columns (int) to Right alignment
                    HorizontalAlignment alignment = HorizontalAlignment.Left;

                    // If the column contains numeric types (int, long, etc.), set the alignment to Right
                    if (column.DataType == typeof(int) || column.DataType == typeof(long) ||
                        column.DataType == typeof(decimal) || column.DataType == typeof(float) ||
                        column.DataType == typeof(double))
                    {
                        alignment = HorizontalAlignment.Right;
                    }

                    // Add the column with the correct alignment
                    listView1.Columns.Add(column.ColumnName, 150, alignment); // Adjust width as needed
                }

                // Iterate through each row in the DataTable and add as ListView items
                foreach (DataRow row in dt.Rows)
                {
                    // Create a new ListViewItem using the first column's value (ID in this case)
                    ListViewItem item = new ListViewItem(row["ID"].ToString());

                    // Add remaining columns as subitems dynamically
                    for (int i = 1; i < dt.Columns.Count; i++) // Start from 1 to avoid the first column (ID)
                    {
                        // Just add the value as is without formatting decimals
                        string value = row[dt.Columns[i].ColumnName].ToString();
                        item.SubItems.Add(value);
                    }

                    // Add the full ListViewItem to the ListView control
                    listView1.Items.Add(item);
                }
            }

        }

        private void Form5_Load(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Menu menu = new Menu();
            menu.Show();
          
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            form3.Show();
           
        }
    }
}
