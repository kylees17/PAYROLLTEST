using iText.StyledXmlParser.Jsoup.Nodes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;
using static System.Runtime.CompilerServices.RuntimeHelpers;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace PAYROLLTEST
{
    public partial class Form3 : Form
    {
        // Declare the DataTable
        DataTable sssTable;
        DataTable phicTable;
        DataTable taxTable;

        public Form3()
        {
            InitializeComponent();
            InitializeSSSTable();
            InitializePHICTable();
            InitializeDateTimePickers();


            // Attach the TextChanged event to the txtSalary TextBox
            txtSSSBasicPayBased.TextChanged += txtSSSBasicPayBased_TextChanged;
            txtPHICBasedPay.TextChanged += txtPHICBasedPay_TextChanged;

            // Set default selected index
            comboBox1.SelectedIndex = 0;  // Default selection to "Custom"
            comboBox2.SelectedIndex = 0;
            comboBox3.SelectedIndex = 0;
            // Attach event handler for Button click event
            button7.Click += button7_Click;
        }

        private void InitializeSSSTable()
        {
            // Create the DataTable and define columns
            sssTable = new DataTable();
            sssTable.Columns.Add("MinSalary", typeof(decimal)); // Minimum salary range
            sssTable.Columns.Add("MaxSalary", typeof(decimal)); // Maximum salary range
            sssTable.Columns.Add("EEContribution", typeof(decimal)); // EE Contribution

            // Add rows to the DataTable (min salary, max salary, EE contribution)
            sssTable.Rows.Add(1m, 4250.99m, 180.50m);
            sssTable.Rows.Add(4250m, 4499.99m, 202.50m);
            sssTable.Rows.Add(4500m, 4749.99m, 225.00m);
            sssTable.Rows.Add(4750m, 5249.99m, 247.50m);
            sssTable.Rows.Add(5250m, 5749.99m, 270.00m);
            sssTable.Rows.Add(5750m, 6249.99m, 292.50m);
            sssTable.Rows.Add(6250m, 6749.99m, 315.00m);
            sssTable.Rows.Add(6750m, 7249.99m, 337.50m);
            sssTable.Rows.Add(7250m, 7749.99m, 360.00m);
            sssTable.Rows.Add(7750m, 8249.99m, 382.50m);
            sssTable.Rows.Add(8250m, 8749.99m, 405.00m);
            sssTable.Rows.Add(8750m, 9249.99m, 427.50m);
            sssTable.Rows.Add(9250m, 9749.99m, 450.00m);
            sssTable.Rows.Add(9750m, 10249.99m, 472.50m);
            sssTable.Rows.Add(10250m, 10749.99m, 495.00m);
            sssTable.Rows.Add(10750m, 11249.99m, 517.50m);
            sssTable.Rows.Add(11250m, 11749.99m, 540.00m);
            sssTable.Rows.Add(11750m, 12249.99m, 562.50m);
            sssTable.Rows.Add(12250m, 12749.99m, 585.00m);
            sssTable.Rows.Add(12750m, 13249.99m, 607.50m);
            sssTable.Rows.Add(13250m, 13749.99m, 630.00m);
            sssTable.Rows.Add(13750m, 14249.99m, 652.50m);
            sssTable.Rows.Add(14250m, 14749.99m, 675.00m);
            sssTable.Rows.Add(14750m, 15249.99m, 697.50m);
            sssTable.Rows.Add(15250m, 15749.99m, 720.00m);
            sssTable.Rows.Add(15750m, 16249.99m, 742.50m);
            sssTable.Rows.Add(16250m, 16749.99m, 765.00m);
            sssTable.Rows.Add(16750m, 17249.99m, 787.50m);
            sssTable.Rows.Add(17250m, 17749.99m, 810.00m);
            sssTable.Rows.Add(17750m, 18249.99m, 832.50m);
            sssTable.Rows.Add(18250m, 18749.99m, 855.00m);
            sssTable.Rows.Add(18750m, 19249.99m, 877.50m);
            sssTable.Rows.Add(19250m, 19749.99m, 900.00m);
            sssTable.Rows.Add(19750m, 20249.99m, 900.00m);
            sssTable.Rows.Add(20250m, 20749.99m, 900.00m);
            sssTable.Rows.Add(20750m, 21249.99m, 900.00m);
            sssTable.Rows.Add(21250m, 21749.99m, 900.00m);
            sssTable.Rows.Add(21750m, 22249.99m, 900.00m);
            sssTable.Rows.Add(22250m, 22749.99m, 900.00m);
            sssTable.Rows.Add(22750m, 23249.99m, 900.00m);
            sssTable.Rows.Add(23250m, 23749.99m, 900.00m);
            sssTable.Rows.Add(23750m, 24249.99m, 900.00m);
            sssTable.Rows.Add(24250m, 24749.99m, 900.00m);
            sssTable.Rows.Add(24750m, 25249.99m, 900.00m);
            sssTable.Rows.Add(25250m, 25749.99m, 900.00m);
            sssTable.Rows.Add(25750m, 26249.99m, 900.00m);
            sssTable.Rows.Add(26250m, 26749.99m, 900.00m);
            sssTable.Rows.Add(26750m, 27249.99m, 900.00m);
            sssTable.Rows.Add(27250m, 27749.99m, 900.00m);
            sssTable.Rows.Add(27750m, 28249.99m, 900.00m);
            sssTable.Rows.Add(28250m, 28749.99m, 900.00m);
            sssTable.Rows.Add(28750m, 29249.99m, 900.00m);
            sssTable.Rows.Add(29250m, 29749.99m, 900.00m);
            sssTable.Rows.Add(29750m, 100000m, 900.00m);
        }

        private void InitializePHICTable()
        {

            phicTable = new DataTable();
            phicTable.Columns.Add("MinSalary", typeof(decimal));
            phicTable.Columns.Add("MaxSalary", typeof(decimal)); // Maximum salary range
            phicTable.Columns.Add("PhicContribution", typeof(decimal));


            phicTable.Rows.Add(1m, 10000.99m, 250m);
            phicTable.Rows.Add(10000m, 99999.99m, 0.05m);
            phicTable.Rows.Add(4500m, 4749.99m, 2500m);
        }

        private void InitializeTaxTable()
        {
            taxTable = new DataTable();
            taxTable.Columns.Add("MinSalary", typeof(decimal));
            taxTable.Columns.Add("MaxSalary", typeof(decimal)); // Maximum salary range
            taxTable.Columns.Add("Witholdingtax", typeof(decimal));


            taxTable.Rows.Add(1m, 10417m, 0m);
            taxTable.Rows.Add(10417m, 16666m, 0m);
            taxTable.Rows.Add(16666m, 33332m, 937.50m);
            taxTable.Rows.Add(33333m, 83332m, 4270.50m);
            taxTable.Rows.Add(83333m, 333332m, 16770.70m);
            taxTable.Rows.Add(333333m, 1000000, 91770.70m);
        }
        private void InitializeDateTimePickers()
        {
            // Set the format for the DateTimePickers
            StartDatePicker.Format = DateTimePickerFormat.Short;
            EndDatePicker.Format = DateTimePickerFormat.Short;

            // Set a minimum date, if needed
            StartDatePicker.MinDate = new DateTime(2020, 1, 1);
            EndDatePicker.MinDate = new DateTime(2020, 1, 1);

            // Set initial dates
            StartDatePicker.Value = DateTime.Now;
            EndDatePicker.Value = DateTime.Now;

            // Optional: You can add event listeners
            StartDatePicker.ValueChanged += dateTimePicker1_ValueChanged;
            EndDatePicker.ValueChanged += EndDatePicker_ValueChanged;
        }

        private void CalculateSHolidayAmount()
        {
            if (string.IsNullOrWhiteSpace(txtSHolidayhrs.Text) && string.IsNullOrWhiteSpace(txtSHolidaydays.Text))
            {
                txtSHolidayAmount.Text = "";
                return;
            }


            double hourRate;
            double sHolidayhrs;
            double dailyRate;
            double sHolidaydays;

            // Ensure txtPDailyrate contains valid numeric input
            if (!double.TryParse(txtPNoHours.Text, out hourRate) || hourRate <= 0)
            {
                txtSHolidayAmount.Text = "Invalid ";
                return;
            }

            if (!double.TryParse(txtPDailyrate.Text, out dailyRate) || dailyRate <= 0)
            {
                txtSHolidayAmount.Text = "Invalid ";
                return;
            }

            double sHolAmount = 0; // Initialize total amount

            // Try to parse work hours
            if (double.TryParse(txtSHolidayhrs.Text, out sHolidayhrs) && sHolidayhrs >= 0)
            {
                double sHolhrsAmount = sHolidayhrs * (hourRate * 1.30);
                sHolAmount += sHolhrsAmount; // Add to total amount
            }

            // Try to parse Holiday work DAYS
            if (double.TryParse(txtSHolidaydays.Text, out sHolidaydays) && sHolidaydays >= 0)
            {
                double sHoldaysAmount = sHolidaydays * (dailyRate * 1.30);
                sHolAmount += sHoldaysAmount; // Add to total amount
            }

            else

            {
                txtSHolidayAmount.Text = "Invalid Input";
            }
            // Display the total amount
            txtSHolidayAmount.Text = sHolAmount.ToString("F2");


        }



        private void CalculateTotalEmpRestdayAmt()
        {
            double RDAmount;
            double totalOTrdAmount = 0; // Initialize totalOTrdAmount to 0

            // Check if Rest Day Amount is empty
            if (string.IsNullOrWhiteSpace(txtRestDayAmount.Text))
            {
                txtTotalRDamount.Text = ""; // Clear the total amount if no input
                return; // Exit early
            }

            // Try to parse the Rest Day Amount
            if (!double.TryParse(txtRestDayAmount.Text, out RDAmount))
            {
                txtTotalRDamount.Text = "Invalid input"; // Invalid Rest Day Amount
                return;
            }

            // Try to parse the overtime amount, but allow it to remain 0 if invalid or empty
            if (!string.IsNullOrWhiteSpace(txtRDayOtAmt.Text) && !double.TryParse(txtRDayOtAmt.Text, out totalOTrdAmount))
            {
                txtTotalRDamount.Text = "Invalid Overtime Amount"; // Invalid Overtime Amount
                return;
            }

            // Calculate total amount
            double totalRDamt = RDAmount + totalOTrdAmount;
            txtTotalRDamount.Text = totalRDamt.ToString("F2"); // Format to 2 decimal places
        }


        private void TotalRDamount()
        {
            {
                if (string.IsNullOrWhiteSpace(txtRestDayHrs.Text) && string.IsNullOrWhiteSpace(txtRDdays.Text))
                {
                    txtRestDayAmount.Text = "";
                    txtTotalRDhrs.Text = "";
                }
                else
                {
                    double hourRate;
                    double dailyRate;
                    double restDayHrs;
                    double restDayDays;


                    // Ensure txtPDailyrate contains valid numeric input
                    if (!double.TryParse(txtPNoHours.Text, out hourRate) || hourRate <= 0)
                    {
                        txtRestDayAmount.Text = "Invalid ";
                        return;
                    }

                    if (!double.TryParse(txtPDailyrate.Text, out dailyRate) || dailyRate <= 0)
                    {
                        txtRestDayAmount.Text = "Invalid ";
                        return;
                    }

                    double totalRDAmount = 0; // Initialize total amount

                    // Try to parse work hours
                    if (double.TryParse(txtRestDayHrs.Text, out restDayHrs) && restDayHrs >= 0)
                    {
                        double RDHrsAmount = restDayHrs * (hourRate * 1.30);
                        totalRDAmount += RDHrsAmount; // Add to total amount
                    }

                    // Try to parse work OT minutes
                    if (double.TryParse(txtRDdays.Text, out restDayDays) && restDayDays >= 0)
                    {
                        double RDdaysAmount = restDayDays * (dailyRate * 1.30);
                        totalRDAmount += RDdaysAmount; // Add to total amount
                    }
                    else
                    {
                        txtRestDayAmount.Text = "Invalid Input";
                    }
                    // Display the total amount
                    txtRestDayAmount.Text = totalRDAmount.ToString("F2");
                }
            }
        }



        //Calculates the total RD HRS
        private void RDotAmount()

        {
            if (string.IsNullOrWhiteSpace(txtOtRestDayHrs.Text))
            {
                txtRDayOtAmt.Text = "";
            }
            else
            {
                double hourRate;
                double restDayOtHrs;

                // Ensure txtPDailyrate contains valid numeric input
                if (!double.TryParse(txtPNoHours.Text, out hourRate) || hourRate <= 0)
                {
                    txtRDayOtAmt.Text = "Invalid daily rate";
                    return;
                }

                // Try to parse work hours
                if (double.TryParse(txtOtRestDayHrs.Text, out restDayOtHrs) && restDayOtHrs >= 0)
                {
                    double restDayOtAmount = restDayOtHrs * (hourRate * 1.69); // calculate restday ot Amount
                    txtRDayOtAmt.Text = restDayOtAmount.ToString("F2"); // Format to 2 decimal places

                }
                else
                {
                    txtRDayOtAmt.Text = "Invalid input for Rest Day Amount";
                }

            }

        }

        private void TotalHrsAndDays()
        {
            double restDayOtHrs = 0;
            double restDayHrs = 0;
            double restDaydays = 0;

            // Check for Rest Day Hours input
            if (!double.TryParse(txtRestDayHrs.Text, out restDayHrs) || restDayHrs < 0)
            {
                txtTotalRDhrs.Text = "";
                return;
            }

            // Check for Overtime Rest Day Hours input (if not provided, default to 0)
            if (!string.IsNullOrWhiteSpace(txtOtRestDayHrs.Text))
            {
                if (!double.TryParse(txtOtRestDayHrs.Text, out restDayOtHrs) || restDayOtHrs < 0)
                {
                    txtTotalRDhrs.Text = "Invalid";
                    return;
                }
            }

            // Calculate total hours
            double totalRDhrs = restDayHrs + restDayOtHrs;
            txtTotalRDhrs.Text = totalRDhrs.ToString();

            // Check for Rest Day Days input
            if (double.TryParse(txtRDdays.Text, out restDaydays) && restDaydays >= 0)
            {
                txtTotalRDdays.Text = restDaydays.ToString();
            }
            else
            {
                txtTotalRDdays.Text = "";
            }
        }


        private void OvertimeAmount()
        {

            {
                if (string.IsNullOrWhiteSpace(txtOvertimeHrs.Text) && string.IsNullOrWhiteSpace(txtOvertimeMin.Text))
                {
                    txtOvertimeAmount.Text = "";
                    return; // Exit if both inputs are empty
                }

                double hourRate;
                double otHours;
                double minRate;
                double otMin;

                // Ensure txtPNoHours contains valid numeric input
                if (!double.TryParse(txtPNoHours.Text, out hourRate) || hourRate <= 0)
                {
                    txtOvertimeAmount.Text = "Invalid OT rate";
                    return;
                }
                // Ensure txtPMinRate contains valid numeric input
                if (!double.TryParse(txtPMinRate.Text, out minRate) || minRate <= 0)
                {
                    txtOvertimeAmount.Text = "Invalid minute rate";
                    return;
                }

                double totalAmount = 0; // Initialize total amount

                // Try to parse work OT hours
                if (double.TryParse(txtOvertimeHrs.Text, out otHours) && otHours >= 0)
                {
                    double otHrsAmount = otHours * (hourRate * 1.25);
                    totalAmount += otHrsAmount; // Add to total amount
                }

                // Try to parse work OT minutes
                if (double.TryParse(txtOvertimeMin.Text, out otMin) && otMin >= 0)
                {
                    double otMinAmount = otMin * (minRate * 1.25);
                    totalAmount += otMinAmount; // Add to total amount
                }
                else
                {
                    txtOvertimeAmount.Text = "Invalid Input";
                }

                // Display the total amount
                txtOvertimeAmount.Text = totalAmount.ToString("F2"); // Format to 2 decimal places
            }

        }

        private void SpecialHolOTamt()

        {
            if (string.IsNullOrWhiteSpace(txtSpecHolOThrs.Text))
            {
                txtSpecHolOTAmt.Text = "";
            }
            else
            {
                double hourRate;
                double specialHolOtHrs;

                // Ensure txtPDailyrate contains valid numeric input
                if (!double.TryParse(txtPNoHours.Text, out hourRate) || hourRate <= 0)
                {
                    txtSpecHolOTAmt.Text = "Invalid daily rate";
                    return;
                }

                // Try to parse Special Hol OT work hours
                if (double.TryParse(txtSpecHolOThrs.Text, out specialHolOtHrs) && specialHolOtHrs >= 0)
                {
                    double specialHolOtAmount = specialHolOtHrs * (hourRate * 1.69); // calculate restday ot Amount
                    txtSpecHolOTAmt.Text = specialHolOtAmount.ToString("F2"); // Format to 2 decimal places

                }
                else
                {
                    txtSpecHolOTAmt.Text = "Invalid input";
                }

            }
        }

        private void SHandRDamount()

        {
            if (string.IsNullOrWhiteSpace(txtSHandRDhrs.Text) && string.IsNullOrWhiteSpace(txtSHandRDdays.Text))
            {
                txtSHandRDamount.Text = "";

            }
            else
            {
                double hourRate;
                double dailyRate;
                double SHandRDhrs;
                double HandRDdays;


                // Ensure txtPDailyrate contains valid numeric input
                if (!double.TryParse(txtPNoHours.Text, out hourRate) || hourRate <= 0)
                {
                    txtRestDayAmount.Text = "Invalid ";
                    return;
                }

                if (!double.TryParse(txtPDailyrate.Text, out dailyRate) || dailyRate <= 0)
                {
                    txtRestDayAmount.Text = "Invalid ";
                    return;
                }

                double SHandRDamount = 0; // Initialize total amount

                // Try to parse work hours
                if (double.TryParse(txtSHandRDhrs.Text, out SHandRDhrs) && SHandRDhrs >= 0)
                {
                    double SHandRDhrsAmount = SHandRDhrs * (hourRate * 1.50);
                    SHandRDamount += SHandRDhrsAmount; // Add to total amount
                }

                // Try to parse 
                if (double.TryParse(txtSHandRDdays.Text, out HandRDdays) && HandRDdays >= 0)
                {
                    double HandRDdaysAmount = HandRDdays * (dailyRate * 1.50);
                    SHandRDamount += HandRDdaysAmount; // Add to total amount
                }
                else
                {
                    txtSHandRDamount.Text = "Invalid Input";
                }
                // Display the total amount
                txtSHandRDamount.Text = SHandRDamount.ToString("F2");
            }
        }

        private void SHandRDOTamount()
        {
            if (string.IsNullOrWhiteSpace(txtSHandRDOThrs.Text))
            {
                txtSHandRDOTamt.Text = "";
            }
            else
            {
                double hourRate;
                double sHandRDOtHrs;

                // Ensure txtPDailyrate contains valid numeric input
                if (!double.TryParse(txtPNoHours.Text, out hourRate) || hourRate <= 0)
                {
                    txtSpecHolOTAmt.Text = "Invalid rate";
                    return;
                }

                // Try to parse Special Hol OT work hours
                if (double.TryParse(txtSHandRDOThrs.Text, out sHandRDOtHrs) && sHandRDOtHrs >= 0)
                {
                    double SHandRDOTamt = sHandRDOtHrs * (hourRate * 1.95); // calculate restday ot Amount
                    txtSHandRDOTamt.Text = SHandRDOTamt.ToString("F2"); // Format to 2 decimal places

                }
                else
                {
                    txtSHandRDOThrs.Text = "Invalid input";
                }

            }

        }

        private void LegalHolidayOTAmount()
        {

            if (string.IsNullOrWhiteSpace(txtLHolidayOThrs.Text))
            {
                txtLHolidayOTAmount.Text = "";
            }
            else
            {
                double hourRate;
                double LHolidayOThrs;

                // Ensure txtPDailyrate contains valid numeric input
                if (!double.TryParse(txtPNoHours.Text, out hourRate) || hourRate <= 0)
                {
                    txtSpecHolOTAmt.Text = "Invalid rate";
                    return;
                }

                // Try to parse Special Hol OT work hours
                if (double.TryParse(txtLHolidayHrs.Text, out LHolidayOThrs) && LHolidayOThrs >= 0)
                {
                    double LHolidayAmount = LHolidayOThrs * (hourRate * 1.95); // calculate restday ot Amount
                    txtLHolidayOTAmount.Text = LHolidayAmount.ToString("F2"); // Format to 2 decimal places

                }
                else
                {
                    txtLHolidayOTAmount.Text = "Invalid input";
                }

            }
        }

        private void LegalHolidayAmt()
        {

            {
                if (string.IsNullOrWhiteSpace(txtLHolidayHrs.Text) && string.IsNullOrWhiteSpace(txtLholidaydays.Text))
                {
                    txtLHolidayAmount.Text = "";

                }
                else
                {
                    double hourRate;
                    double dailyRate;
                    double lHolidayHrs;
                    double lHolidayDays;


                    // Ensure txtPDailyrate contains valid numeric input
                    if (!double.TryParse(txtPNoHours.Text, out hourRate) || hourRate <= 0)
                    {
                        txtRestDayAmount.Text = "Invalid ";
                        return;
                    }

                    if (!double.TryParse(txtPDailyrate.Text, out dailyRate) || dailyRate <= 0)
                    {
                        txtRestDayAmount.Text = "Invalid ";
                        return;
                    }

                    double LHolidayamount = 0; // Initialize total amount

                    // Try to parse work hours
                    if (double.TryParse(txtLHolidayHrs.Text, out lHolidayHrs) && lHolidayHrs >= 0)
                    {
                        double LHolidayhrsAmount = lHolidayHrs * (hourRate * 2.60);
                        LHolidayamount += LHolidayhrsAmount; // Add to total amount
                    }

                    // Try to parse 
                    if (double.TryParse(txtLholidaydays.Text, out lHolidayDays) && lHolidayDays >= 0)
                    {
                        double LHolidaydaysAmount = lHolidayDays * (dailyRate * 2.60);
                        LHolidayamount += LHolidaydaysAmount; // Add to total amount
                    }
                    else
                    {
                        txtLHolidayAmount.Text = "Invalid Input";
                    }
                    // Display the total amount
                    txtLHolidayAmount.Text = LHolidayamount.ToString("F2");
                }
            }
        }

        private void LHolidayandRDAmount()
        {

            {
                if (string.IsNullOrWhiteSpace(txtLHandRDhrs.Text) && string.IsNullOrWhiteSpace(txtLHandRDdays.Text))
                {
                    txtLHandRDAmount.Text = "";

                }
                else
                {
                    double hourRate;
                    double dailyRate;
                    double lHandRDhrs;
                    double lHandRDdays;


                    // Ensure txtPDailyrate contains valid numeric input
                    if (!double.TryParse(txtPNoHours.Text, out hourRate) || hourRate <= 0)
                    {
                        txtLHandRDAmount.Text = "Invalid ";
                        return;
                    }

                    if (!double.TryParse(txtPDailyrate.Text, out dailyRate) || dailyRate <= 0)
                    {
                        txtLHandRDAmount.Text = "Invalid ";
                        return;
                    }

                    double LHandRDAmount = 0; // Initialize total amount

                    // Try to parse work hours
                    if (double.TryParse(txtLHandRDhrs.Text, out lHandRDhrs) && lHandRDhrs >= 0)
                    {
                        double LHandRDhrsAmount = lHandRDhrs * (hourRate * 2.60);
                        LHandRDAmount += LHandRDhrsAmount; // Add to total amount
                    }

                    // Try to parse 
                    if (double.TryParse(txtLHandRDdays.Text, out lHandRDdays) && lHandRDdays >= 0)
                    {
                        double LHandRDdaysAmount = lHandRDdays * (dailyRate * 2.60);
                        LHandRDAmount += LHandRDdaysAmount; // Add to total amount
                    }
                    else
                    {
                        txtLHandRDAmount.Text = "Invalid Input";
                    }
                    // Display the total amount
                    txtLHandRDAmount.Text = LHandRDAmount.ToString("F2");
                }
            }

        }
        // calculate the total hours for holiday
        private void LegalHolidayandRestdayOTAmt()
        {

            if (string.IsNullOrWhiteSpace(txtLHandRDOThrs.Text))
            {
                txtLHandRDOTamount.Text = "";

            }
            else
            {
                double hourRate;
                double LHandRDOThrs;

                // Ensure txtPDailyrate contains valid numeric input
                if (!double.TryParse(txtPNoHours.Text, out hourRate) || hourRate <= 0)
                {
                    txtLHandRDAmount.Text = " Invalid rate";
                    return;
                }


                // Try to parse Special Hol OT work hours
                if (double.TryParse(txtLHandRDOThrs.Text, out LHandRDOThrs) && LHandRDOThrs >= 0)
                {
                    double LHandRDOTAmount = LHandRDOThrs * (hourRate * 3.38); // calculate restday ot Amount
                    txtLHandRDOTamount.Text = LHandRDOTAmount.ToString("F2"); // Format to 2 decimal places                                 
                }

                else
                {
                    txtLHandRDOTamount.Text = "Invalid input";
                }

            }

        }

        private void TotalEmpHolidayHrs()
        {
            double LHandRDOThrs = 0;
            double SHolidayhrs = 0;
            double SpecHolOThrs = 0;
            double SHandRDhrs = 0;
            double SHandRDOThrs = 0;
            double LHolidayHrs = 0;
            double LHolidayOThrs = 0;
            double LHandRDhrs = 0;


            // Function to safely parse the input and return 0 if empty or invalid
            double TryParseInput(string input)
            {
                double result;
                return double.TryParse(input, out result) && result >= 0 ? result : 0;
            }

            // Parse optional fields
            SHolidayhrs = TryParseInput(txtSHolidayhrs.Text);
            SpecHolOThrs = TryParseInput(txtSpecHolOThrs.Text);
            SHandRDhrs = TryParseInput(txtSHandRDhrs.Text);
            SHandRDOThrs = TryParseInput(txtSHandRDOThrs.Text);
            LHolidayHrs = TryParseInput(txtLHolidayHrs.Text);
            LHolidayOThrs = TryParseInput(txtLHolidayOThrs.Text);
            LHandRDhrs = TryParseInput(txtLHandRDhrs.Text);
            LHandRDOThrs = TryParseInput(txtLHandRDOThrs.Text);

            // Calculate total hours
            double TotalEmpHolidayHrs = SHolidayhrs + SpecHolOThrs + SHandRDOThrs + SHandRDhrs + LHolidayHrs + LHolidayOThrs + LHandRDhrs + LHandRDOThrs;
            txtTotalEmpHolidayHrs.Text = TotalEmpHolidayHrs.ToString();
        }



        private void TotalEmpHolidayDays()
        {

            double sHolidaydays = 0;
            double specHolandRDdays = 0;
            double legalHolidayDays = 0;
            double LHandRDdays = 0;

            // Safely parse optional fields, defaulting to 0 if empty or invalid
            sHolidaydays = TryParseInput(txtSHolidaydays.Text);
            specHolandRDdays = TryParseInput(txtSHandRDdays.Text);
            legalHolidayDays = TryParseInput(txtLholidaydays.Text);
            LHandRDdays = TryParseInput(txtLHandRDdays.Text);

            // Calculate total holiday days
            double TotalEmpHolidayDays = sHolidaydays + specHolandRDdays + legalHolidayDays + LHandRDdays;
            txtTotalEmpHolidayDays.Text = TotalEmpHolidayDays.ToString();
        }

        // Helper method to safely parse the input and return 0 if empty or invalid
        private double TryParseInput(string input)
        {
            double result;
            return double.TryParse(input, out result) && result >= 0 ? result : 0;
        }

        private void TotalEmpHolidayAmount()
        {

            double specialHolidayAmt = 0;
            double specialOTHolidayAmt = 0;
            double SHandRDamount = 0;
            double SHandRDOTamount = 0;
            double LHolidayAmount = 0;
            double LHolidayOTAmount = 0;
            double LHandRDAmount = 0;
            double LHandRDOTamount = 0;

            specialHolidayAmt = TryParseInput(txtSHolidayAmount.Text);
            specialOTHolidayAmt = TryParseInput(txtSpecHolOTAmt.Text);
            SHandRDamount = TryParseInput(txtSHandRDamount.Text);
            SHandRDOTamount = TryParseInput(txtSHandRDOTamt.Text);
            LHolidayAmount = TryParseInput(txtLHolidayAmount.Text);
            LHolidayOTAmount = TryParseInput(txtLHolidayOTAmount.Text);
            LHandRDAmount = TryParseInput(txtLHandRDAmount.Text);
            LHandRDOTamount = TryParseInput(txtLHandRDOTamount.Text);

            double TotalEmpHolidayAmount = specialHolidayAmt + specialOTHolidayAmt + SHandRDamount + SHandRDOTamount + LHolidayAmount + LHolidayOTAmount + LHandRDAmount + LHandRDOTamount;
            txtTotalEmpHolidayAmt.Text = TotalEmpHolidayAmount.ToString();
        }

        private void CalculateNDworkingdayAmt()
        {
            if (string.IsNullOrWhiteSpace(txtNDworkingDayhrs.Text))
            {
                txtNDworkingDayAmount.Text = "";
                return;
            }

            double hourRate;
            double NDworkingDayhrs;

            if (!double.TryParse(txtPNoHours.Text, out hourRate) || hourRate <= 0)
            {
                txtNDworkingDayAmount.Text = "";
                return;
            }

            if (double.TryParse(txtNDworkingDayhrs.Text, out NDworkingDayhrs) && NDworkingDayhrs >= 0)
            {
                double NDworkingDayAmount = NDworkingDayhrs * (hourRate * 0.15);
                txtNDworkingDayAmount.Text = NDworkingDayAmount.ToString("F2");

            }
            else
            {
                txtNDworkingDayAmount.Text = "Invalid";
            }
        }

        private void CalculateOTNDworkingdayAmt()
        {
            if (string.IsNullOrWhiteSpace(txtNDOTworkingDayhrs.Text))
            {
                txtNDOTworkingDayAmount.Text = "";
                return;
            }

            double hourRate;
            double NDOTworkingDayhrs;

            if (!double.TryParse(txtPNoHours.Text, out hourRate) || hourRate <= 0)
            {
                txtNDworkingDayAmount.Text = "";
                return;
            }

            if (double.TryParse(txtNDOTworkingDayhrs.Text, out NDOTworkingDayhrs) && NDOTworkingDayhrs >= 0)
            {
                double NDOTworkingDayAmount = NDOTworkingDayhrs * (hourRate * 0.13);
                txtNDOTworkingDayAmount.Text = NDOTworkingDayAmount.ToString("F2");

            }
            else
            {
                txtNDOTworkingDayAmount.Text = "Invalid";
            }
        }

        private void CalculateNDlegalHolidayAmt()
        {
            if (string.IsNullOrWhiteSpace(txtNDLegalHolidayHrs.Text))
            {
                txtNDLegalHolidayAmt.Text = "";
                return;
            }

            double hourRate;
            double NDLegalHolidayHrs;

            if (!double.TryParse(txtPNoHours.Text, out hourRate) || hourRate <= 0)
            {
                txtNDLegalHolidayAmt.Text = "";
                return;
            }
            if (double.TryParse(txtNDLegalHolidayHrs.Text, out NDLegalHolidayHrs) && NDLegalHolidayHrs >= 0)
            {
                double NDLegalHolidayAmt = NDLegalHolidayHrs * (hourRate * 0.10);
                txtNDLegalHolidayAmt.Text = NDLegalHolidayAmt.ToString("F2");

            }
            else
            {
                txtNDLegalHolidayAmt.Text = "Invalid";
            }
        }

        private void CalculateNDOTlegalHolidayAmt()
        {
            if (string.IsNullOrWhiteSpace(txtNDOTLegalHolidayHrs.Text))
            {
                txtNDOTLegalHolidayAmt.Text = "";
                return;
            }

            double hourRate;
            double NDOTLegalHolidayHrs;

            if (!double.TryParse(txtPNoHours.Text, out hourRate) || hourRate <= 0)
            {
                txtNDOTLegalHolidayAmt.Text = "";
                return;
            }
            if (double.TryParse(txtNDOTLegalHolidayHrs.Text, out NDOTLegalHolidayHrs) && NDOTLegalHolidayHrs >= 0)
            {
                double NDOTLegalHolidayAmt = NDOTLegalHolidayHrs * (hourRate * 0.26);
                txtNDOTLegalHolidayAmt.Text = NDOTLegalHolidayAmt.ToString("F2");

            }
            else
            {
                txtNDOTLegalHolidayAmt.Text = "Invalid";
            }
        }

        private void CalculateNDonRestdayandLegalHolidayAmt()
        {
            if (string.IsNullOrWhiteSpace(txtNDRHandLHhrs.Text))
            {
                txtNDRHandLHamount.Text = "";
                return;
            }

            double hourRate;
            double NDRHandLHhrs;

            if (!double.TryParse(txtPNoHours.Text, out hourRate) || hourRate <= 0)
            {
                txtNDOTLegalHolidayAmt.Text = "";
                return;
            }
            if (double.TryParse(txtNDRHandLHhrs.Text, out NDRHandLHhrs) && NDRHandLHhrs >= 0)
            {
                double NDRHandLHamount = NDRHandLHhrs * (hourRate * 0.26);
                txtNDRHandLHamount.Text = NDRHandLHamount.ToString("F2");

            }
            else
            {
                txtNDRHandLHamount.Text = "Invalid";
            }
        }

        private void CalculateNDOTonRestdayandLegalHolidayAmt()
        {
            if (string.IsNullOrWhiteSpace(txtNDotRHandLHhrs.Text))
            {
                txtNDotRHandLHamount.Text = "";
                return;
            }

            double hourRate;
            double NDotRHandLHhrs;

            if (!double.TryParse(txtPNoHours.Text, out hourRate) || hourRate <= 0)
            {
                txtNDOTLegalHolidayAmt.Text = "";
                return;
            }
            if (double.TryParse(txtNDotRHandLHhrs.Text, out NDotRHandLHhrs) && NDotRHandLHhrs >= 0)
            {
                double NDotRHandLHamount = NDotRHandLHhrs * (hourRate * 0.338);
                txtNDotRHandLHamount.Text = NDotRHandLHamount.ToString("F2");

            }
            else
            {
                txtNDotRHandLHamount.Text = "Invalid";
            }
        }

        private void CalculateNDSpecHolidayorRestDayAmt()
        {
            if (string.IsNullOrWhiteSpace(txtNDonSHorRDhrs.Text))
            {
                txtNDonSHorRDAmount.Text = "";
                return;
            }

            double hourRate;
            double NDonSHorRDhrs;

            if (!double.TryParse(txtPNoHours.Text, out hourRate) || hourRate <= 0)
            {
                txtNDOTLegalHolidayAmt.Text = "";
                return;
            }
            if (double.TryParse(txtNDonSHorRDhrs.Text, out NDonSHorRDhrs) && NDonSHorRDhrs >= 0)
            {
                double NDonSHorRDAmount = NDonSHorRDhrs * (hourRate * 0.13);
                txtNDonSHorRDAmount.Text = NDonSHorRDAmount.ToString("F2");

            }
            else
            {
                txtNDonSHorRDAmount.Text = "Invalid";
            }

        }

        private void CalculateNDSpecHolidayorRestDayOTAmt()
        {

            if (string.IsNullOrWhiteSpace(txtNDOTonSHorRDhrs.Text))
            {
                txtNDOTonSHorRDAmt.Text = "";
                return;
            }

            double hourRate;
            double NDOTonSHorRDhrs;

            if (!double.TryParse(txtPNoHours.Text, out hourRate) || hourRate <= 0)
            {
                txtNDOTLegalHolidayAmt.Text = "";
                return;
            }
            if (double.TryParse(txtNDOTonSHorRDhrs.Text, out NDOTonSHorRDhrs) && NDOTonSHorRDhrs >= 0)
            {
                double NDOTonSHorRDAmt = NDOTonSHorRDhrs * (hourRate * 0.169);
                txtNDOTonSHorRDAmt.Text = NDOTonSHorRDAmt.ToString("F2");

            }
            else
            {
                txtNDOTonSHorRDAmt.Text = "Invalid";
            }


        }

        private void CalculateNDSpecHolidayANDRestDayAmt()
        {

            if (string.IsNullOrWhiteSpace(txtNDSpecHolAndRestdayHrs.Text))
            {
                txtNDSpecHolAndRestdayAmt.Text = "";
                return;
            }

            double hourRate;
            double NDSpecHolAndRestdayHrs;

            if (!double.TryParse(txtPNoHours.Text, out hourRate) || hourRate <= 0)
            {
                txtNDOTLegalHolidayAmt.Text = "";
                return;
            }
            if (double.TryParse(txtNDSpecHolAndRestdayHrs.Text, out NDSpecHolAndRestdayHrs) && NDSpecHolAndRestdayHrs >= 0)
            {
                double NDSpecHolAndRestdayAmt = NDSpecHolAndRestdayHrs * (hourRate * 0.15);
                txtNDSpecHolAndRestdayAmt.Text = NDSpecHolAndRestdayAmt.ToString("F2");

            }
            else
            {
                txtNDSpecHolAndRestdayAmt.Text = "Invalid";
            }
        }


        private void CalculateNDOTSpecHolidayANDRestDayAmt()
        {

            if (string.IsNullOrWhiteSpace(txtNDOTSpecHolAndRestdayHrs.Text))
            {
                txtNDOTSpecHolAndRestdayAmt.Text = "";
                return;
            }

            double hourRate;
            double NDOTSpecHolAndRestdayHrs;

            if (!double.TryParse(txtPNoHours.Text, out hourRate) || hourRate <= 0)
            {
                txtNDOTLegalHolidayAmt.Text = "";
                return;
            }
            if (double.TryParse(txtNDOTSpecHolAndRestdayHrs.Text, out NDOTSpecHolAndRestdayHrs) && NDOTSpecHolAndRestdayHrs >= 0)
            {
                double NDOTSpecHolAndRestdayAmt = NDOTSpecHolAndRestdayHrs * (hourRate * 0.195);
                txtNDOTSpecHolAndRestdayAmt.Text = NDOTSpecHolAndRestdayAmt.ToString("F2");

            }
            else
            {
                txtNDOTSpecHolAndRestdayAmt.Text = "Invalid";
            }
        }

        private void TotalNightDifferentialHrs()
        {
            double NDworkingDayHrs = 0;
            double NDOTworkingDayHrs = 0;
            double NDLegalHolidayHrs = 0;
            double NDOTLegalHolidayHrs = 0;
            double NDRHandLHhrs = 0;
            double NDOTRHandRHhrs = 0;
            double NDonSHorRDhrs = 0;
            double NDOTonSHorRDhrs = 0;
            double NDSpecHolAndRestdayHrs = 0;
            double NDOTSpecHolAndRestdayHrs = 0;

            double TryParseInput(string input)
            {
                double result;
                return double.TryParse(input, out result) && result >= 0 ? result : 0;
            }

            NDworkingDayHrs = TryParseInput(txtNDworkingDayhrs.Text);
            NDOTworkingDayHrs = TryParseInput(txtNDOTworkingDayhrs.Text);
            NDLegalHolidayHrs = TryParseInput(txtNDLegalHolidayHrs.Text);
            NDOTLegalHolidayHrs = TryParseInput(txtNDOTLegalHolidayHrs.Text);
            NDRHandLHhrs = TryParseInput(txtNDRHandLHhrs.Text);
            NDOTRHandRHhrs = TryParseInput(txtNDotRHandLHhrs.Text);
            NDonSHorRDhrs = TryParseInput(txtNDonSHorRDhrs.Text);
            NDOTonSHorRDhrs = TryParseInput(txtNDOTonSHorRDhrs.Text);
            NDSpecHolAndRestdayHrs = TryParseInput(txtNDSpecHolAndRestdayHrs.Text);
            NDOTSpecHolAndRestdayHrs = TryParseInput(txtNDOTSpecHolAndRestdayHrs.Text);

            double TotalNightDifferentialHrs = NDworkingDayHrs + NDOTworkingDayHrs + NDLegalHolidayHrs + NDOTLegalHolidayHrs + NDRHandLHhrs + NDOTRHandRHhrs + NDonSHorRDhrs + NDOTonSHorRDhrs + NDSpecHolAndRestdayHrs + NDOTSpecHolAndRestdayHrs;
            txtTotalNDhrs.Text = TotalNightDifferentialHrs.ToString();
        }

        private void TotalNightDifferentialAmt()
        {
            double NDworkingDayAmt = 0;
            double NDOTworkingDayAmt = 0;
            double NDLegalHolidayAmt = 0;
            double NDOTLegalHolidayAmt = 0;
            double NDRHandLHAmt = 0;
            double NDOTRHandRHAmt = 0;
            double NDonSHorRDAmt = 0;
            double NDOTonSHorRDAmt = 0;
            double NDSpecHolAndRestdayAmt = 0;
            double NDOTSpecHolAndRestdayAmt = 0;

            double TryParseInput(string input)
            {
                double result;
                return double.TryParse(input, out result) && result >= 0 ? result : 0;
            }

            NDworkingDayAmt = TryParseInput(txtNDworkingDayAmount.Text);
            NDOTworkingDayAmt = TryParseInput(txtNDOTworkingDayAmount.Text);
            NDLegalHolidayAmt = TryParseInput(txtNDLegalHolidayAmt.Text);
            NDOTLegalHolidayAmt = TryParseInput(txtNDOTLegalHolidayAmt.Text);
            NDRHandLHAmt = TryParseInput(txtNDRHandLHamount.Text);
            NDOTRHandRHAmt = TryParseInput(txtNDotRHandLHamount.Text);
            NDonSHorRDAmt = TryParseInput(txtNDonSHorRDAmount.Text);
            NDOTonSHorRDAmt = TryParseInput(txtNDOTonSHorRDAmt.Text);
            NDSpecHolAndRestdayAmt = TryParseInput(txtNDSpecHolAndRestdayAmt.Text);
            NDOTSpecHolAndRestdayAmt = TryParseInput(txtNDOTSpecHolAndRestdayAmt.Text);

            double TotalNightDifferentialAmt = NDworkingDayAmt + NDOTworkingDayAmt + NDLegalHolidayAmt + NDOTLegalHolidayAmt + NDRHandLHAmt + NDOTRHandRHAmt + NDonSHorRDAmt + NDOTonSHorRDAmt + NDSpecHolAndRestdayAmt + NDOTSpecHolAndRestdayAmt;
            txtTotalNDAmt.Text = TotalNightDifferentialAmt.ToString();
        }

        private void LeavewithPaySickAmt()
        {

            if (string.IsNullOrWhiteSpace(txtLeavewithPaySickDays.Text))
            {
                txtleavewithPaySickAmount.Text = "";
                return;
            }

            double dailyRate;
            double LeavewithPaySickDays;

            if (!double.TryParse(txtPDailyrate.Text, out dailyRate) || dailyRate <= 0)
            {
                txtleavewithPaySickAmount.Text = "";
                return;
            }
            if (double.TryParse(txtLeavewithPaySickDays.Text, out LeavewithPaySickDays) && LeavewithPaySickDays >= 0)
            {
                double leavewithPaySickAmount = LeavewithPaySickDays * dailyRate;
                txtleavewithPaySickAmount.Text = leavewithPaySickAmount.ToString("F2");

            }
            else
            {
                txtleavewithPaySickAmount.Text = "Invalid";
            }
        }

        private void LeavewithPayVacationAmt()
        {
            if (string.IsNullOrWhiteSpace(txtLeavewithPayVacationDays.Text))
            {
                txtLeavewithPayVacationAmount.Text = "";
                return;
            }

            double dailyRate;
            double LeavewithPayVacationDays;

            if (!double.TryParse(txtPDailyrate.Text, out dailyRate) || dailyRate <= 0)
            {
                txtLeavewithPayVacationAmount.Text = "";
                return;
            }
            if (double.TryParse(txtLeavewithPayVacationDays.Text, out LeavewithPayVacationDays) && LeavewithPayVacationDays >= 0)
            {
                double LeavewithPayVacationAmount = LeavewithPayVacationDays * dailyRate;
                txtLeavewithPayVacationAmount.Text = LeavewithPayVacationAmount.ToString("F2");

            }
            else
            {
                txtLeavewithPayVacationAmount.Text = "Invalid";
            }

        }

        private void TotalTaxableAmt()
        {
            double hazzardpay = 0;
            double coLa = 0;
            double incentive = 0;
            double commission = 0;
            double calamityLeave = 0;
            double otherTaxableTwo = 0;

            double TryParseInput(string input)
            {
                double result;
                return double.TryParse(input, out result) && result >= 0 ? result : 0;
            }

            hazzardpay = TryParseInput(txtHazzardPay.Text);
            coLa = TryParseInput(txtCOLA.Text);
            commission = TryParseInput(txtCommission.Text);
            incentive = TryParseInput(txtIncentives.Text);
            calamityLeave = TryParseInput(txtCalamityLeave.Text);
            otherTaxableTwo = TryParseInput(txtOtherTaxableTwo.Text);

            double TotalTaxableAmt = hazzardpay + coLa + incentive + commission + calamityLeave + otherTaxableTwo;
            txtTotaltaxableAmount.Text = TotalTaxableAmt.ToString();
        }

        private void TotalNonTaxableAmt()

        {
            double deMinimis = 0;
            double IncentiveProgram = 0;
            double Bonus = 0;
            double Column3 = 0;
            double LaundryAllowance = 0;
            double MealAllowance = 0;
            double CompanyLoan = 0;
            double ThirtheenMonthPay = 0;

            double TryParseInput(string input)
            {
                double result;
                return double.TryParse(input, out result) && result >= 0 ? result : 0;
            }

            deMinimis = TryParseInput(txtDeminimis.Text);
            IncentiveProgram = TryParseInput(txtIncentiveProgram.Text);
            Bonus = TryParseInput(txtBonus.Text);
            Column3 = TryParseInput(txtColumn3.Text);
            LaundryAllowance = TryParseInput(txtLaundryAllowance.Text);
            MealAllowance = TryParseInput(txtMealAllowance.Text);
            CompanyLoan = TryParseInput(txtCompanyLoan.Text);
            ThirtheenMonthPay = TryParseInput(txt13monthPay.Text);

            double TotalNonTaxableAmount = deMinimis + IncentiveProgram + Bonus + Column3 + LaundryAllowance + MealAllowance + CompanyLoan + ThirtheenMonthPay;
            txtTotalNonTaxableAmt.Text = TotalNonTaxableAmount.ToString();

        }

        private void TotalGrossPay()
        {
            double BasicPay = 0;
            double OvertimeAmount = 0;
            double TotalRestDayAmount = 0;
            double TotalHolidayAmount = 0;
            double TotalNightDifferential = 0;
            double LeavewithPaySick = 0;
            double LeavewithPayVacation = 0;
            double TotalTaxableAmount = 0;
            double TotalNonTaxableAmount = 0;

            double TryParseInput(string input)
            {
                double result;
                return double.TryParse(input, out result) && result >= 0 ? result : 0;
            }

            BasicPay = TryParseInput(txtBasicPay.Text);
            OvertimeAmount = TryParseInput(txtOvertimeAmount.Text);
            TotalRestDayAmount = TryParseInput(txtTotalRDamount.Text);
            TotalHolidayAmount = TryParseInput(txtTotalEmpHolidayAmt.Text);
            TotalNightDifferential = TryParseInput(txtTotalNDAmt.Text);
            LeavewithPaySick = TryParseInput(txtleavewithPaySickAmount.Text);
            LeavewithPayVacation = TryParseInput(txtLeavewithPayVacationAmount.Text);
            TotalTaxableAmount = TryParseInput(txtTotaltaxableAmount.Text);
            TotalNonTaxableAmount = TryParseInput(txtTotalNonTaxableAmt.Text);

            double TotalGrossPay = BasicPay + OvertimeAmount + TotalRestDayAmount + TotalHolidayAmount + LeavewithPaySick + LeavewithPayVacation + TotalNightDifferential + TotalTaxableAmount + TotalNonTaxableAmount;
            txtTotalGrossPay.Text = TotalGrossPay.ToString();

        }

      

        private void LateMinAmount()
        {
            if (string.IsNullOrWhiteSpace(txtLateMin.Text))
            {
                txtLateMinAmount.Text = "";
            }
            else
            {
                double minuteRate;
                double LateMinutes;

                // Ensure txtPDailyrate contains valid numeric input
                if (!double.TryParse(txtPMinRate.Text, out minuteRate) || minuteRate <= 0)
                {
                    txtLateMinAmount.Text = "Invalid rate";
                    return;
                }

                // Try to parse Special Hol OT work hours
                if (double.TryParse(txtLateMin.Text, out LateMinutes) && LateMinutes >= 0)
                {
                    double LateMinAmt = LateMinutes * minuteRate; // calculate restday ot Amount
                    txtLateMinAmount.Text = LateMinAmt.ToString("F2"); // Format to 2 decimal places

                }
                else
                {
                    txtLateMinAmount.Text = "Invalid input";
                }

            }

        }

        private void LateHoursAmount()
        {

            if (string.IsNullOrWhiteSpace(txtLateHours.Text))
            {
                txtLateHourAmount.Text = "";
                return;
            }

            double hourRate;
            double LateHours;

            if (!double.TryParse(txtPNoHours.Text, out hourRate) || hourRate <= 0)
            {
                txtLateHourAmount.Text = "";
                return;
            }
            if (double.TryParse(txtLateHours.Text, out LateHours) && LateHours >= 0)
            {
                double LateHourAmount = LateHours * hourRate;
                txtLateHourAmount.Text = LateHourAmount.ToString("F2");

            }
            else
            {
                txtLateHourAmount.Text = "Invalid";
            }
        }

        private void AbsentAmount()
        {
            if (string.IsNullOrWhiteSpace(txtAbsentDays.Text))
            {
                txtAbsentAmt.Text = "";
                return;
            }

            double dailyRate;
            double AbsentDays;

            if (!double.TryParse(txtPDailyrate.Text, out dailyRate) || dailyRate <= 0)
            {
                txtAbsentAmt.Text = "";
                return;
            }
            if (double.TryParse(txtAbsentDays.Text, out AbsentDays) && AbsentDays >= 0)
            {
                double AbsentAmount = AbsentDays * dailyRate;
                txtAbsentAmt.Text = AbsentAmount.ToString("F2");

            }
            else
            {
                txtAbsentAmt.Text = "Invalid";
            }

        }

        private void TotalTardiness()
        {

            double LateMinAmt = 0;
            double LateHourAmt = 0;
            double AbsentAmount = 0;


            double TryParseInput(string input)
            {
                double result;
                return double.TryParse(input, out result) && result >= 0 ? result : 0;
            }

            LateMinAmt = TryParseInput(txtLateMinAmount.Text);
            LateHourAmt = TryParseInput(txtLateHourAmount.Text);
            AbsentAmount = TryParseInput(txtAbsentAmt.Text);


            double TotalTard = LateMinAmt + LateHourAmt + AbsentAmount;
            txtTotalTardiness.Text = TotalTard.ToString();
        }

        private void SSSbasicPayBased()
        {
            if (string.IsNullOrWhiteSpace(txtBasicPay.Text))
            {
                txtSSSBasicPayBased.Text = "";
                return;
            }

            double BasicPay;
            double TotalTardiness;

            if (!double.TryParse(txtBasicPay.Text, out BasicPay) || BasicPay <= 0)
            {
                txtSSSBasicPayBased.Text = "";
                return;
            }
            if (double.TryParse(txtTotalTardiness.Text, out TotalTardiness) && TotalTardiness >= 0)
            {
                double SSSBasicPayBased = BasicPay - TotalTardiness;
                txtSSSBasicPayBased.Text = SSSBasicPayBased.ToString("F2");

            }
            else
            {
                txtSSSBasicPayBased.Text = "Invalid";
            }

        }

        private void SSSGrossPayBased()
        {
            if (string.IsNullOrWhiteSpace(txtTotalGrossPay.Text))
            {
                txtSSSGrossBase.Text = "";
                return;
            }

            double TotalGrossPay;
            double TotalTardiness;

            if (!double.TryParse(txtTotalGrossPay.Text, out TotalGrossPay) || TotalGrossPay <= 0)
            {
                txtSSSGrossBase.Text = "";
                return;
            }
            if (double.TryParse(txtTotalTardiness.Text, out TotalTardiness) && TotalTardiness >= 0)
            {
                double SSSGrossBase = TotalGrossPay - TotalTardiness;
                txtSSSGrossBase.Text = SSSGrossBase.ToString("F2");

            }
            else
            {
                txtSSSGrossBase.Text = "Invalid";
            }

        }

        private void PhicBasicBasedpay()

        {

            if (string.IsNullOrWhiteSpace(txtBasicPay.Text))
            {
                txtPHICBasedPay.Text = "";
                return;
            }

            double BasicPay;
            double TotalTardiness;

            if (!double.TryParse(txtBasicPay.Text, out BasicPay) || BasicPay <= 0)
            {
                txtPHICBasedPay.Text = "";
                return;
            }
            if (double.TryParse(txtTotalTardiness.Text, out TotalTardiness) && TotalTardiness >= 0)
            {
                double PHICBasedPay = BasicPay - TotalTardiness;
                txtPHICBasedPay.Text = PHICBasedPay.ToString("F2");

            }
            else
            {
                txtPHICBasedPay.Text = "Invalid";
            }
        }

        private void TotalSocialCost()
        {

            double SSS = 0;
            double PHIC = 0;
            double HDMF = 0;


            double TryParseInput(string input)
            {
                double result;
                return double.TryParse(input, out result) && result >= 0 ? result : 0;
            }

            SSS = TryParseInput(txtEEContribution.Text);
            PHIC = TryParseInput(txtPHIC.Text);
            HDMF = TryParseInput(txtHDMf.Text);


            double TotalSocialCost = SSS + PHIC + HDMF;
            txtTotalSocialCost.Text = TotalSocialCost.ToString();
        }

        private void TotalGovernmentLoans()
        {

            double SSSsalaryLoan = 0;
            double SSSCalamityLoan = 0;
            double HDMFSalaryLoan = 0;
            double HDMFCalamityLoan = 0;

            double TryParseInput(string input)
            {
                double result;
                return double.TryParse(input, out result) && result >= 0 ? result : 0;
            }

            SSSsalaryLoan = TryParseInput(txtSSSSalaryLoan.Text);
            SSSCalamityLoan = TryParseInput(txtSSSCalamityLoan.Text);
            HDMFSalaryLoan = TryParseInput(txtHdmfSalaryLoan.Text);
            HDMFCalamityLoan = TryParseInput(txtHdmfCalamityLoan.Text);


            double TotalGovernmentLoan = SSSsalaryLoan + SSSCalamityLoan + HDMFSalaryLoan + HDMFCalamityLoan;
            txtTotalGovernmentLoans.Text = TotalGovernmentLoan.ToString();

        }

        private void TotalOtherLoans()
        {
            double CompanyLoan = 0;
            double OtherLoan1 = 0;
            double OtherLoan2 = 0;
            double OtherLoan3 = 0;

            double TryParseInput(string input)
            {
                double result;
                return double.TryParse(input, out result) && result >= 0 ? result : 0;
            }

            CompanyLoan = TryParseInput(txtCompanyLoans.Text);
            OtherLoan1 = TryParseInput(txtOtherLoan1.Text);
            OtherLoan2 = TryParseInput(txtOtherLoan2.Text);
            OtherLoan3 = TryParseInput(txtotherLoan3.Text);


            double TotalOtherLoan = CompanyLoan + OtherLoan1 + OtherLoan2 + OtherLoan3;
            txtTotalOtherLoans.Text = TotalOtherLoan.ToString();

        }

        private void TotalDeductions()
        {
            double TotalTardiness = 0;
            double TotalSocialCost = 0;
            double TotalGovernmentLoan = 0;
            double TotalOtherLoan = 0;
            double AdjustmentOrRefund = 0;
            double SalaryDeduction = 0;
            double Deductions = 0;
            double LateManualTeraphytechniques = 0;
            double UniformDeduction = 0;
            double MedicalDeduction = 0;

            double TryParseInput(string input)
            {
                double result;
                return double.TryParse(input, out result) && result >= 0 ? result : 0;
            }

            TotalTardiness = TryParseInput(txtTotalTardiness.Text);
            TotalSocialCost = TryParseInput(txtTotalSocialCost.Text);
            TotalGovernmentLoan = TryParseInput(txtTotalGovernmentLoans.Text);
            TotalOtherLoan = TryParseInput(txtTotalOtherLoans.Text);
            AdjustmentOrRefund = TryParseInput(txtAdjustmentOrRefund.Text);
            SalaryDeduction = TryParseInput(txtSalaryDeductions.Text);
            Deductions = TryParseInput(txtDeduction.Text);
            LateManualTeraphytechniques = TryParseInput(txtManualTeraphyTechniques.Text);
            UniformDeduction = TryParseInput(txtuniformdeductions.Text);
            MedicalDeduction = TryParseInput(txtMedicalExpense.Text);

            double TotalDeductions = TotalTardiness + TotalSocialCost + TotalGovernmentLoan + TotalOtherLoan + AdjustmentOrRefund + SalaryDeduction + Deductions + LateManualTeraphytechniques + UniformDeduction + MedicalDeduction;
            txtTotalDeductions.Text = TotalDeductions.ToString();


        }

        private void TotalAmountDue()
        {

            if (string.IsNullOrWhiteSpace(txtTotalGrossPay.Text))
            {
                txtAmountDue.Text = "";
                return;
            }

            double TotalGrossPay;
            double TotalDeductions;

            if (!double.TryParse(txtTotalGrossPay.Text, out TotalGrossPay) || TotalGrossPay <= 0)
            {
                txtPHICBasedPay.Text = "";
                return;
            }
            if (double.TryParse(txtTotalDeductions.Text, out TotalDeductions) && TotalDeductions >= 0)
            {
                double TotalAmountDue = TotalGrossPay - TotalDeductions;
                txtAmountDue.Text = TotalAmountDue.ToString("F2");

            }
            else
            {
                txtAmountDue.Text = "Invalid";
            }
        }

        private void TaxableIncome()
        {

            if (string.IsNullOrWhiteSpace(txtTotalGrossPay.Text))
            {
                txtTaxableIncome.Text = "";
                return;
            }

            double TotalGrossPay;
            double NonTaxable;

            if (!double.TryParse(txtTotalGrossPay.Text, out TotalGrossPay) || TotalGrossPay <= 0)
            {
                txtTaxableIncome.Text = "";
                return;
            }
            if (double.TryParse(txtTotalNonTaxableAmt.Text, out NonTaxable) && NonTaxable >= 0)
            {
                double TaxableIncome = TotalGrossPay - NonTaxable;
                txtTaxableIncome.Text = TaxableIncome.ToString("F2");

            }
            else
            {
                txtTaxableIncome.Text = "Invalid";
            }

        }

        private void NetPay()
        {

            double AmountDue = 0;
            double withHoldingTax = 0;

            double TryParseInput(string input)
            {
                double result;
                return double.TryParse(input, out result) && result >= 0 ? result : 0;
            }

            AmountDue = TryParseInput(txtAmountDue.Text);
            withHoldingTax = TryParseInput(txtWithholdingTax.Text);
        

            double Netpay = AmountDue - withHoldingTax;
            txtNetPay.Text = Netpay.ToString();

        }
        
        private void ThirtheenthM()
        {
            if (txtBasicPay.Text != "")
            {
                double BasicPay;
                if (double.TryParse(txtBasicPay.Text, out BasicPay))
                {
                    double thirtheenth = BasicPay ; // Replace 2 with the divisor
                    txt13thMonthBased.Text = thirtheenth.ToString("");
                }
                else
                {
                    txt13thMonthBased.Text = "Invalid input";
                }
            }
            else
            {
                txt13thMonthBased.Text = "";
            }

        }

        private void ThirtheenMCutOff()
        {
            if (txt13thMonthBased.Text != "")
            {
                double Thirtheenth;
                if (double.TryParse(txt13thMonthBased.Text, out Thirtheenth))
                {
                    double Third = Thirtheenth / 12; // Replace 2 with the divisor
                    txt13thmonthforthisCutoff.Text = Third.ToString("F2");
                }
                else
                {
                    txt13thmonthforthisCutoff.Text = "Invalid input";
                }
            }
            else
            {
                txt13thmonthforthisCutoff.Text = "";
            }

        }

        private void ATM()
        {
            if (txtNetPay.Text != "")
            {
                double Net;
                if (double.TryParse(txtNetPay.Text, out Net))
                {
                    double ATM = Net; // Replace 2 with the divisor
                    txtAtm.Text = ATM.ToString("");
                }
                else
                {
                    txtAtm.Text = "Invalid input";
                }
            }
            else
            {
                txtAtm.Text = "";
            }

        }

        private void Cash()
        {
            if (txtNetPay.Text != "")
            {
                double Net;
                if (double.TryParse(txtNetPay.Text, out Net))
                {
                    double CASH = Net; // Replace 2 with the divisor
                    txtCash.Text = CASH.ToString("");
                }
                else
                {
                    txtCash.Text = "Invalid input";
                }
            }
            else
            {
                txtCash.Text = "";
            }

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label18_Click(object sender, EventArgs e)
        {

        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }



        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label39_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            {
                if (textBox4.Text != "")
                {
                    double value;
                    if (double.TryParse(textBox4.Text, out value))
                    {
                        double dividedValue = value / 2; // Replace 2 with the divisor
                        textBox8.Text = dividedValue.ToString("F2");
                    }
                    else
                    {
                        textBox8.Text = "Invalid input";
                    }
                }
                else
                {
                    textBox8.Text = "";
                }
            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox4_Enter(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void label40_Click(object sender, EventArgs e)
        {

        }

        private void groupBox8_Enter(object sender, EventArgs e)
        {

        }

        private void textBox70_TextChanged(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            Menu menu = new Menu();
            menu.Show();
            this.Hide();
        }

        private void txtPDailyrate_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void txtWorkhours_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox19_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtOvertimeMin_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtOvertimeAmount_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox20_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtRestDayHrs_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtRestDayAmount_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtRDdays_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox18_TextChanged(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            CalculateSHolidayAmount();

            CalculateTotalEmpRestdayAmt();

            TotalRDamount();

            RDotAmount();

            OvertimeAmount();

            SpecialHolOTamt();

            SHandRDamount();

            SHandRDOTamount();

            LegalHolidayAmt();

            LegalHolidayOTAmount();

            LHolidayandRDAmount();

            LegalHolidayandRestdayOTAmt();

            TotalEmpHolidayDays();

            TotalHrsAndDays();

            TotalEmpHolidayHrs();

            TotalEmpHolidayAmount();

            CalculateNDworkingdayAmt();

            CalculateOTNDworkingdayAmt();

            CalculateNDlegalHolidayAmt();

            CalculateNDOTlegalHolidayAmt();

            CalculateNDonRestdayandLegalHolidayAmt();

            CalculateNDOTonRestdayandLegalHolidayAmt();

            CalculateNDSpecHolidayorRestDayAmt();

            CalculateNDSpecHolidayorRestDayOTAmt();

            CalculateNDSpecHolidayANDRestDayAmt();

            CalculateNDOTSpecHolidayANDRestDayAmt();

            TotalNightDifferentialHrs();

            TotalNightDifferentialAmt();

            LeavewithPaySickAmt();

            LeavewithPayVacationAmt();

            TotalTaxableAmt();

            TotalNonTaxableAmt();

            TotalGrossPay();

            LateMinAmount();

            LateHoursAmount();

            AbsentAmount();

            TotalTardiness();

            SSSbasicPayBased();

            SSSGrossPayBased();

            PhicBasicBasedpay();

            TotalSocialCost();

            TotalGovernmentLoans();

            TotalOtherLoans();

            TotalDeductions();

            TotalAmountDue();

            TaxableIncome();

            NetPay();

            ThirtheenthM();

            ThirtheenMCutOff();

            ATM();

            Cash();


            //
            // Try to parse the input from textBox1
            if (double.TryParse(txtEEContribution.Text, out double inputValue))
            {
                double result = 0;  // Variable to store the result

                // Check the selected ComboBox item
                if (comboBox1.SelectedItem.ToString() == "Custom Based")
                {
                    // If "Custom" is selected, multiply by 1 (no change)
                    result = inputValue;
                }
                else if (comboBox1.SelectedItem.ToString() == "Custom Based Half")
                {
                    // If "Half Custom" is selected, divide by 2
                    result = inputValue / 2;
                }

                // Update the TextBox with the result
                txtEEContribution.Text = result.ToString();
            }
            else
            {
                // Show an error message if the input is not a valid number
                txtEEContribution.Text = "Invalid";
            }
            //

            if (string.IsNullOrWhiteSpace(textBox3.Text))
            {
                txtBasicPay.Text = "";
            }
            else
            {
                double dailyRate;
                int daysOfWork;

                // Ensure txtPNoHours and txtPDailyrate contain valid numeric input
                if (!double.TryParse(txtPDailyrate.Text, out dailyRate))
                {
                    txtBasicPay.Text = "Invalid hourly rate or daily rate";
                    return;
                }

                // Try to parse the days of work
                if (int.TryParse(textBox3.Text, out daysOfWork))
                {
                    double basicPay = daysOfWork * dailyRate;
                    txtBasicPay.Text = basicPay.ToString("F2"); // Format to 2 decimal places

                    // Calculate minute rate pay
                    double minuteRate = dailyRate / (8 * 60); // Assuming an 8-hour workday with 60 minutes per hour
                    txtPMinRate.Text = minuteRate.ToString("F2");

                }
                else
                {
                    txtBasicPay.Text = "Invalid input for days of work";
                }
                double hourRate = dailyRate / 8; // Assuming an 8-hour workday
                txtPNoHours.Text = hourRate.ToString("F2");
            }

            {
                // Clear previous output if work hours input is empty
                if (string.IsNullOrWhiteSpace(txtWorkhours.Text) && string.IsNullOrWhiteSpace(textBox3.Text))
                {
                    txtBasicPay.Text = "";
                    txtPMinRate.Text = "";
                    txtPNoHours.Text = "";
                    return;
                }

                double dailyRate;

                // Ensure txtPDailyrate contains valid numeric input
                if (!double.TryParse(txtPDailyrate.Text, out dailyRate) || dailyRate <= 0)
                {
                    txtBasicPay.Text = "Invalid daily rate";
                    txtPMinRate.Text = "";
                    txtPNoHours.Text = "";
                    return;
                }

                // Check if work hours were provided
                if (!string.IsNullOrWhiteSpace(txtWorkhours.Text))
                {
                    double workHours;

                    // Try to parse work hours
                    if (double.TryParse(txtWorkhours.Text, out workHours) && workHours >= 0)
                    {
                        // Calculate basic pay
                        double basicPay = workHours * (dailyRate / 8);
                        txtBasicPay.Text = basicPay.ToString("F2"); // Format to 2 decimal places

                        // Calculate minute rate pay
                        double minuteRate = dailyRate / (8 * 60); // Assuming an 8-hour workday with 60 minutes per hour
                        txtPMinRate.Text = minuteRate.ToString("F2");

                        // Calculate hourly rate
                        double hourRate = dailyRate / 8; // Assuming an 8-hour workday
                        txtPNoHours.Text = hourRate.ToString("F2");
                    }
                    else
                    {
                        txtBasicPay.Text = "Invalid input for work hours";
                        txtPMinRate.Text = "";
                        txtPNoHours.Text = "";
                    }
                }
                // Check if days of work were provided
                else if (!string.IsNullOrWhiteSpace(textBox3.Text))
                {
                    int daysOfWork;

                    // Try to parse the days of work
                    if (int.TryParse(textBox3.Text, out daysOfWork) && daysOfWork >= 0)
                    {
                        double basicPay = daysOfWork * dailyRate;
                        txtBasicPay.Text = basicPay.ToString("F2"); // Format to 2 decimal places

                        // Calculate minute rate pay
                        double minuteRate = dailyRate / (8 * 60); // Assuming an 8-hour workday with 60 minutes per hour
                        txtPMinRate.Text = minuteRate.ToString("F2");

                        // Calculate hourly rate
                        double hourRate = dailyRate / 8; // Assuming an 8-hour workday
                        txtPNoHours.Text = hourRate.ToString("F2");
                    }
                    else
                    {
                        txtBasicPay.Text = "Invalid input for days of work";
                        txtPMinRate.Text = "";
                        txtPNoHours.Text = "";
                    }
                }
            }


        }

        private void txtTotalRDdays_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtTotalRDamount_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtRDayOtAmt_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox35_TextChanged(object sender, EventArgs e)
        {


        }

        private void txtBasicPay_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtSpecHolOThrs_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox39_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox40_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtTotalEmpHolidayDays_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtLHandRDdays_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox75_TextChanged(object sender, EventArgs e)
        {



        }

        private void txtNo_TextChanged(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-GEO9JUP\\SQLEXPRESS;Initial Catalog=Login;Integrated Security=True;");
            con.Open();
            if (txtNo.Text != "")
            {
                SqlCommand cmd = new SqlCommand("Select NameOfEmployee, Email, EmployeeID, Department, Position, TypeOfRate, MonthlyRate, MonthlyRateBasisDays, DailyRate, DailyRateAmountfromMonthlyRate, SSSCUSTOMBASED, PHICCUSTOMBASED FROM Employee_new WHERE ID=@ID", con);
                cmd.Parameters.AddWithValue("ID", int.Parse(txtNo.Text));
                SqlDataReader da = cmd.ExecuteReader();
                while (da.Read())
                {
                    // Map the retrieved values to the corresponding text fields
                    txtNameOfEmployee.Text = da["NameOfEmployee"].ToString();

                    txtEMPID.Text = da["EmployeeID"].ToString();
                    txtDpt.Text = da["Department"].ToString();
                    txtPosition.Text = da["Position"].ToString();
                    txtTypeRate.Text = da["TypeOfRate"].ToString();
                    textBox4.Text = da["MonthlyRate"].ToString();
                    txtPDailyrate.Text = da["DailyRate"].ToString();
                    txtSSSCUSTOMBASED.Text = da["SSSCUSTOMBASED"].ToString();
                    txtPHICcustom.Text = da["PHICCUSTOMBASED"].ToString();


                }
                con.Close();
            }
        }

        private void txtSSSBasicPayBased_TextChanged(object sender, EventArgs e)
        {
            try
            {
                // Get the input salary from the TextBox
                decimal salary = Convert.ToDecimal(txtSSSBasicPayBased.Text);

                // Search the DataTable for the matching salary range
                DataRow matchingRow = null;
                foreach (DataRow row in sssTable.Rows)
                {
                    decimal minSalary = (decimal)row["MinSalary"];
                    decimal maxSalary = (decimal)row["MaxSalary"];

                    if (salary >= minSalary && salary <= maxSalary)
                    {
                        matchingRow = row;
                        break;
                    }
                }

                // Display the result if a matching row is found
                if (matchingRow != null)
                {
                    decimal eeContribution = (decimal)matchingRow["EEContribution"];
                    txtEEContribution.Text = $" {eeContribution}";
                }
                else
                {
                    txtEEContribution.Text = "Invalid";
                }
            }
            catch (FormatException)
            {
                txtEEContribution.Text = "Please enter a valid salary.";
            }
        }
        // Event handler for ComboBox selection change
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Try to parse the input from textBox1
            if (double.TryParse(txtEEContribution.Text, out double inputValue))
            {

                double result = 0;  // Variable to store the result

                // Check the selected ComboBox item
                if (comboBox1.SelectedItem.ToString() == "Custom Based")
                {
                    // If "Custom" is selected, multiply by 1 (no change)
                    result = inputValue;
                }
                else if (comboBox1.SelectedItem.ToString() == "Custom Based Half")
                {
                    // If "Half Custom" is selected, divide by 2
                    result = inputValue / 2;
                }

                // Update the TextBox with the result
                txtEEContribution.Text = result.ToString();
            }
            else
            {
                // Show an error message if the input is not a valid number
                txtEEContribution.Text = "Invalid";
            }
        }




        private void txtEEContribution_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox113_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPHICBasedPay_TextChanged(object sender, EventArgs e)
        {
            try
            {
                // Get the input salary from the TextBox and ensure it is a valid number
                if (string.IsNullOrWhiteSpace(txtPHICBasedPay.Text) || !decimal.TryParse(txtPHICBasedPay.Text, out decimal salary))
                {
                    txtPHIC.Text = "Please enter a valid salary.";
                    return; // Exit early if salary is not valid
                }

                // Check if the phicTable is null or empty
                if (phicTable == null || phicTable.Rows.Count == 0)
                {
                    txtPHIC.Text = "PHIC table data is not available.";
                    return;
                }

                // Search the DataTable for the matching salary range
                DataRow matchingRow = null;
                foreach (DataRow row in phicTable.Rows)
                {
                    decimal minSalary = Convert.ToDecimal(row["MinSalary"]);
                    decimal maxSalary = Convert.ToDecimal(row["MaxSalary"]);

                    // Check if the salary falls within the current row's range
                    if (salary >= minSalary && salary <= maxSalary)
                    {
                        matchingRow = row;
                        break; // Exit loop if a match is found
                    }
                }

                // Display the result if a matching row is found
                if (matchingRow != null)
                {
                    decimal phicContribution;

                    // Check for the special case where the salary range is 10,000 to 99,999.99 and the contribution is 5%
                    decimal minRange = Convert.ToDecimal(matchingRow["MinSalary"]);
                    decimal maxRange = Convert.ToDecimal(matchingRow["MaxSalary"]);

                    if (minRange == 10000m && maxRange == 99999.99m)
                    {
                        phicContribution = salary * 0.05m; // Calculate 5% of the salary
                    }
                    else
                    {
                        // Use the fixed contribution amount from the table
                        if (decimal.TryParse(matchingRow["PhicContribution"].ToString(), out decimal fixedContribution))
                        {
                            phicContribution = fixedContribution;
                        }
                        else
                        {
                            txtPHIC.Text = "Error retrieving fixed PHIC contribution.";
                            return;
                        }
                    }

                    // Display the calculated PHIC contribution with two decimal places
                    txtPHIC.Text = $"{phicContribution:F2}";
                }
                else
                {
                    txtPHIC.Text = "Invalid salary range.";
                }
            }
            catch (Exception ex)
            {
                // Catch all exceptions for debugging
                txtPHIC.Text = $"An error occurred: {ex.Message}";
            }

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Try to parse the input from txtPHIC
            if (double.TryParse(txtPHIC.Text, out double inputValue))
            {
                double result = 0;  // Variable to store the result

                // Ensure the ComboBox selection is valid
                string selectedItem = comboBox2.SelectedItem?.ToString(); // Safely get the selected item
                if (selectedItem == "Custom Based")
                {
                    // If "Custom" is selected, multiply by 1 (no change)
                    result = inputValue;
                }
                else if (selectedItem == "Custom Based Half")
                {
                    // If "Half Custom" is selected, divide by 2
                    result = inputValue / 2;
                }
                else
                {
                    // Handle invalid ComboBox selection
                    txtPHIC.Text = "Invalid selection.";
                    return;
                }

                // Update the TextBox with the result
                txtPHIC.Text = result.ToString("F2"); // Ensure two decimal places for display
            }
            else
            {
                // Show an error message if the input is not a valid number
                txtPHIC.Text = "Invalid input.";
            }
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtHDMf.Text = comboBox3.SelectedItem?.ToString();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            ValidateDateRange();
        }

        private void EndDatePicker_ValueChanged(object sender, EventArgs e)
        {
            ValidateDateRange();
        }

        private void ValidateDateRange()
        {
            // Ensure that the end date is not before the start date
            if (EndDatePicker.Value < StartDatePicker.Value)
            {
                MessageBox.Show("End date cannot be before start date.");
                EndDatePicker.Value = StartDatePicker.Value; // Reset to start date
            }
        }

        private void txt13thMonthBased_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
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
        (ID, NameOfEmployee, EmployeeID, Department, Position, TypeOfRate, MonthlyRate, SemiMonthlySalary,
                    DailyRate, DaysOfWork, SSSCUSTOMBASED, PHICCUSTOMBASED, HoursOfWork, HourlyRate, MinuteRate, BasicPay,OvertimeMins,OvertimeHrs,OvertimeAmount,
                     RestDaysHrs, RestDaysDays, RestDayAmount, RestDayOThrs, RestDayOTAmount, TotalEmployeeRestDayHrs, TotalEmployeeRestDayDays, TotalEmployeeRestDayAmount,
                     SpecialHolidayHrs, SpecialHolidayDays, SpecialHolidayAmount, SpecialHolidayOTHrs, SpecialHolidayOTAmount, SpecialHolidayAndRestDayHrs, SpecialHolidayAndRestDayOTHrs,
                       SpecialHolidayAndRestDayOTAmount, LegalHolidayHrs, LegalHolidayDays, LegalHolidayAmount, LegalHolidayOTHrs, LegalOTAmount, LegalHolidayAndRestDayHrs,
                        LegalHolidayAndRestDaydays, LegalHolidayAndRestDayAmount, LegalHolidayAndRestDayOTHrs, LegalHolidayAndRestDayOTAmount, TotalEmployeeHolidayHrs,  
                        TotalEmployeeHolidayDays,TotalEmployeeHolidayAmount, NDonworkingdayHrs, NDonworkingdayAmount, NDOTonworkingdayHrs, NDOTonworkingdayAmount, NDonLegalHolidayHrs,
                         NDonLegalHolidayAmount, NDOTonLegalHolidayHrs, NDOTonLegalHolidayAmount, NDonRestDayLegalHolidayHrs, NDonLegalHolidayRestdayAmount, NDOTonRestDayLegalHolidayHrs,  
                         NDOTonLegalHolidayRestdayAmount, NDonSpecialHolidayorRestDayHrs, NDonSpecialHolidayorRestDayAmount, NDOTonSpecialHolidayorRestDayHrs, NDOTonSpecialHolidayorRestDayAmount,  
                          NDSpecialHolidayandRestDayHrs, NDSpecialHolidayandRestDayAmount, NDOTSpecialHolidayandRestDayHrs, NDOTSpecialHolidayandRestDayAmount, TotalNDHrs, TotalNDAmount,        
                       SalaryAdjustment, LeaveWithPaySickDays, LeaveWithPayVacationDays, LeaveWithPaySickAmount, LeaveWithPayVacationAmount, COLA, Incentives, HazzardPay, Commission,
                       CalamityLeave, OtherTaxable2, TotalTaxableAmount, DeMinimis, IncentiveProgram, Bonus, Column3, LaundryAllowance, MealAllowance, CompanyLoan, T13MonthPay, TotalNonTaxable,
                        TotalGrossPay, [Late(MinuteBased)Min], [Late(MinuteBased)Amount], [Late(HourBased)Hour], [Late(HourBased)Amount], AbsentOrWithoutLWPDays, AbsentOrWithoutLWPAmount,
                        TotalTardiness, SSSBasicPayBased, SSSGrossBased, SSS, PHICBasicPayBased, PHICstatus, TotalSocialCost, SSSsalaryloan, SSSCalamityLoan, HDMFSalaryLoan, HDMFCalamityLoan,
                        TotalGovernmentLoans, CompanyLoans, OtherLoan1, OtherLoan2, OtherLoan3, TotalOtherLoans, AdjustmentOrRefunds, SalaryDeduction, Deductions, ManualTeraphyTechniques,
                      UniformDeduction, MedicalExpensesDeduction, TotalDeductions,  AmountDue, TaxableIncome, WithholdingTax, NetPay, [13thmonthbased], [13thMonthforthisCutoff], SalaryType,
                        ATM, CASH, ATM#
                            ) 
        VALUES 
        (@ID, @NameOfEmployee, @EmployeeID, @Department, @Position, @TypeOfRate, @MonthlyRate, @SemiMonthlySalary,
                    @DailyRate, @DaysOfWork, @SSSCUSTOMBASED, @PHICCUSTOMBASED, @HoursOfWork, @HourlyRate, @MinuteRate, @BasicPay,@OvertimeMins, @OvertimeHrs,@OvertimeAmount,
                    @RestDaysHrs,@RestDaysDays, @RestDayAmount, @RestDayOThrs, @RestDayOTAmount, @TotalEmployeeRestDayHrs, @TotalEmployeeRestDayDays, @TotalEmployeeRestDayAmount,
                     @SpecialHolidayHrs, @SpecialHolidayDays, @SpecialHolidayAmount, @SpecialHolidayOTHrs, @SpecialHolidayOTAmount, @SpecialHolidayAndRestDayHrs, @SpecialHolidayAndRestDayOTHrs,
                       @SpecialHolidayAndRestDayOTAmount, @LegalHolidayHrs, @LegalHolidayDays, @LegalHolidayAmount, @LegalHolidayOTHrs, @LegalOTAmount, @LegalHolidayAndRestDayHrs,
                        @LegalHolidayAndRestDaydays, @LegalHolidayAndRestDayAmount, @LegalHolidayAndRestDayOTHrs, @LegalHolidayAndRestDayOTAmount, @TotalEmployeeHolidayHrs, 
                        @TotalEmployeeHolidayDays, @TotalEmployeeHolidayAmount, @NDonworkingdayHrs, @NDonworkingdayAmount, @NDOTonworkingdayHrs, @NDOTonworkingdayAmount, @NDonLegalHolidayHrs,
                         @NDonLegalHolidayAmount, @NDOTonLegalHolidayHrs, @NDOTonLegalHolidayAmount, @NDonRestDayLegalHolidayHrs, @NDonLegalHolidayRestdayAmount,@NDOTonRestDayLegalHolidayHrs,
                          @NDOTonLegalHolidayRestdayAmount, @NDonSpecialHolidayorRestDayHrs, @NDonSpecialHolidayorRestDayAmount, @NDOTonSpecialHolidayorRestDayHrs, @NDOTonSpecialHolidayorRestDayAmount,
                        @NDSpecialHolidayandRestDayHrs, @NDSpecialHolidayandRestDayAmount, @NDOTSpecialHolidayandRestDayHrs, @NDOTSpecialHolidayandRestDayAmount, @TotalNDHrs, @TotalNDAmount,
                         @SalaryAdjustment, @LeaveWithPaySickDays, @LeaveWithPayVacationDays, @LeaveWithPaySickAmount, @LeaveWithPayVacationAmount, @COLA, @Incentives, @HazzardPay, @Commission,
                         @CalamityLeave, @OtherTaxable2, @TotalTaxableAmount, @DeMinimis, @IncentiveProgram, @Bonus, @Column3, @LaundryAllowance, @MealAllowance, @CompanyLoan, @T13MonthPay, 
                         @TotalNonTaxable, @TotalGrossPay, @[Late(MinuteBased)Min], @[Late(MinuteBased)Amount], @[Late(HourBased)Hour], @[Late(HourBased)Amount], @AbsentOrWithoutLWPDays, @AbsentOrWithoutLWPAmount,
                          @TotalTardiness, @SSSBasicPayBased, @SSSGrossBased, @SSS, @PHICBasicPayBased, @PHICstatus, @TotalSocialCost, @SSSsalaryloan, @SSSCalamityLoan, @HDMFSalaryLoan, @HDMFCalamityLoan, 
                        @TotalGovernmentLoans, @CompanyLoans, @OtherLoan1, @OtherLoan2, @OtherLoan3, @TotalOtherLoans, @AdjustmentOrRefunds, @SalaryDeduction, @Deductions, @ManualTeraphyTechniques,
                        @UniformDeduction, @MedicalExpensesDeduction, @TotalDeductions, @AmountDue, @TaxableIncome, @WithholdingTax, @NetPay, @[13thmonthbased], @[13thMonthforthisCutoff], @SalaryType, 
                        @ATM, @CASH, @ATM#
                            )";

                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        // Add parameters with TryParse logic directly
                        cmd.Parameters.AddWithValue("@ID", int.TryParse(txtNo.Text, out int id) ? id : (object)DBNull.Value);
                        cmd.Parameters.AddWithValue("@NameOfEmployee", txtNameOfEmployee.Text);                      
                        cmd.Parameters.AddWithValue("@EmployeeID", txtEMPID.Text);
                        cmd.Parameters.AddWithValue("@Department", txtDpt.Text);
                        cmd.Parameters.AddWithValue("@Position", txtPosition.Text);
                        cmd.Parameters.AddWithValue("@TypeOfRate", txtTypeRate.Text);
                        cmd.Parameters.AddWithValue("@MonthlyRate", int.TryParse(textBox4.Text, out int monthlyRate) ? monthlyRate : (object)DBNull.Value);
                        cmd.Parameters.AddWithValue("@SemiMonthlySalary", int.TryParse(textBox8.Text, out int semimonthlyrate) ? semimonthlyrate : (object)DBNull.Value);
                        cmd.Parameters.AddWithValue("@DailyRate", int.TryParse(txtPDailyrate.Text, out int dailyRate) ? dailyRate : (object)DBNull.Value);
                        cmd.Parameters.AddWithValue("@DaysOfWork", int.TryParse(textBox3.Text, out int DaysOfWork) ? DaysOfWork : (object)DBNull.Value);
                        cmd.Parameters.AddWithValue("@SSSCUSTOMBASED", int.TryParse(txtSSSCUSTOMBASED.Text, out int SSSCustomBased) ? (object)SSSCustomBased : DBNull.Value);
                        cmd.Parameters.AddWithValue("@PHICCUSTOMBASED", int.TryParse(txtPHICcustom.Text, out int PhicCustom) ? (object)PhicCustom : DBNull.Value);
                        cmd.Parameters.AddWithValue("@HoursOfWork", int.TryParse(txtWorkhours.Text, out int HoursOfWork) ? (object)HoursOfWork : DBNull.Value);
                        cmd.Parameters.AddWithValue("@HourlyRate", int.TryParse(txtPNoHours.Text, out int HourlyRate) ? (object)HourlyRate : DBNull.Value);
                        cmd.Parameters.AddWithValue("@MinuteRate", int.TryParse(txtPMinRate.Text, out int MinuteRate) ? (object)MinuteRate : DBNull.Value);
                        cmd.Parameters.AddWithValue("@BasicPay", int.TryParse(txtBasicPay.Text, out int BasicPay) ? (object)BasicPay : DBNull.Value);
                        cmd.Parameters.AddWithValue("@OvertimeMins", int.TryParse(txtOvertimeMin.Text, out int OvertimeMins) ? (object)OvertimeMins : DBNull.Value);
                        cmd.Parameters.AddWithValue("@OvertimeHrs", int.TryParse(txtOvertimeHrs.Text, out int OvertimeHrs) ? (object)OvertimeHrs : DBNull.Value);
                        cmd.Parameters.AddWithValue("@OvertimeAmount", int.TryParse(txtOvertimeAmount.Text, out int OvertimeAmount) ? (object)OvertimeAmount : DBNull.Value);
                        cmd.Parameters.AddWithValue("@RestDaysHrs", int.TryParse(txtRestDayHrs.Text, out int RestDaysHrs) ? (object)RestDaysHrs : DBNull.Value);
                        cmd.Parameters.AddWithValue("@RestDaysDays", int.TryParse(txtRDdays.Text, out int RestDaysDays) ? (object)RestDaysDays : DBNull.Value);
                        cmd.Parameters.AddWithValue("@RestDayAmount", int.TryParse(txtRestDayAmount.Text, out int RestDayAmount) ? (object)RestDayAmount : DBNull.Value);
                        cmd.Parameters.AddWithValue("@RestDayOThrs", int.TryParse(txtOtRestDayHrs.Text, out int RestDayOThrs) ? (object)RestDayOThrs : DBNull.Value);
                        cmd.Parameters.AddWithValue("@RestDayOTAmount", int.TryParse(txtRDayOtAmt.Text, out int RestDayOTAmount) ? (object)RestDayOTAmount : DBNull.Value);
                        cmd.Parameters.AddWithValue("@TotalEmployeeRestDayHrs", int.TryParse(txtTotalRDhrs.Text, out int TotalEmployeeRestDayHrs) ? (object)TotalEmployeeRestDayHrs : DBNull.Value);
                        cmd.Parameters.AddWithValue("@TotalEmployeeRestDayDays", int.TryParse(txtTotalRDdays.Text, out int TotalEmployeeRestDayDays) ? (object)TotalEmployeeRestDayDays : DBNull.Value);
                        cmd.Parameters.AddWithValue("@TotalEmployeeRestDayAmount", int.TryParse(txtTotalRDamount.Text, out int TotalEmployeeRestDayAmount) ? (object)TotalEmployeeRestDayAmount : DBNull.Value);
                        cmd.Parameters.AddWithValue("@SpecialHolidayHrs", int.TryParse(txtSHolidayhrs.Text, out int SpecialHolidayHrs) ? (object)SpecialHolidayHrs : DBNull.Value);
                        cmd.Parameters.AddWithValue("@SpecialHolidayDays", int.TryParse(txtSHolidaydays.Text, out int SpecialHolidayDays) ? (object)SpecialHolidayDays : DBNull.Value);
                        cmd.Parameters.AddWithValue("@SpecialHolidayAmount", int.TryParse(txtSHolidayAmount.Text, out int SpecialHolidayAmount) ? (object)SpecialHolidayAmount : DBNull.Value);
                        cmd.Parameters.AddWithValue("@SpecialHolidayOTHrs", int.TryParse(txtSpecHolOThrs.Text, out int SpecialHolidayOTHrs) ? (object)SpecialHolidayOTHrs : DBNull.Value);
                        cmd.Parameters.AddWithValue("@SpecialHolidayOTAmount", int.TryParse(txtSpecHolOTAmt.Text, out int SpecialHolidayOTAmount) ? (object)SpecialHolidayOTAmount : DBNull.Value);
                        cmd.Parameters.AddWithValue("@SpecialHolidayAndRestDayHrs", int.TryParse(txtSHandRDhrs.Text, out int SpecialHolidayAndRestDayHrs) ? (object)SpecialHolidayAndRestDayHrs : DBNull.Value);
                        cmd.Parameters.AddWithValue("@SpecialHolidayAndRestDayOTHrs", int.TryParse(txtSHandRDOThrs.Text, out int SpecialHolidayAndRestDayOTHrs) ? (object)SpecialHolidayAndRestDayOTHrs : DBNull.Value);
                        cmd.Parameters.AddWithValue("@SpecialHolidayAndRestDayOTAmount", int.TryParse(txtSHandRDOTamt.Text, out int SpecialHolidayAndRestDayOTAmount) ? (object)SpecialHolidayAndRestDayOTAmount : DBNull.Value);
                        cmd.Parameters.AddWithValue("@LegalHolidayHrs", int.TryParse(txtLHolidayHrs.Text, out int LegalHolidayHrs) ? (object)LegalHolidayHrs : DBNull.Value);
                        cmd.Parameters.AddWithValue("@LegalHolidayDays", int.TryParse(txtLholidaydays.Text, out int LegalHolidayDays) ? (object)LegalHolidayDays : DBNull.Value);
                        cmd.Parameters.AddWithValue("@LegalHolidayAmount", int.TryParse(txtLHolidayAmount.Text, out int LegalHolidayAmount) ? (object)LegalHolidayAmount : DBNull.Value);
                        cmd.Parameters.AddWithValue("@LegalHolidayOTHrs", int.TryParse(txtLHolidayOThrs.Text, out int LegalHolidayOTHrs) ? (object)LegalHolidayOTHrs : DBNull.Value);
                        cmd.Parameters.AddWithValue("@LegalOTAmount", int.TryParse(txtLHolidayOTAmount.Text, out int LegalOTAmount) ? (object)LegalOTAmount : DBNull.Value);
                        cmd.Parameters.AddWithValue("@LegalHolidayAndRestDayHrs", int.TryParse(txtLHandRDhrs.Text, out int LegalHolidayAndRestDayHrs) ? (object)LegalHolidayAndRestDayHrs : DBNull.Value);
                        cmd.Parameters.AddWithValue("@LegalHolidayAndRestDaydays", int.TryParse(txtLHandRDdays.Text, out int LegalHolidayAndRestDaydays) ? (object)LegalHolidayAndRestDaydays : DBNull.Value);
                        cmd.Parameters.AddWithValue("@LegalHolidayAndRestDayAmount", int.TryParse(txtLHandRDAmount.Text, out int LegalHolidayAndRestDayAmount) ? (object)LegalHolidayAndRestDayAmount : DBNull.Value);
                        cmd.Parameters.AddWithValue("@LegalHolidayAndRestDayOTHrs", int.TryParse(txtLHandRDOThrs.Text, out int LegalHolidayAndRestDayOTHrs) ? (object)LegalHolidayAndRestDayOTHrs : DBNull.Value);
                        cmd.Parameters.AddWithValue("@LegalHolidayAndRestDayOTAmount", int.TryParse(txtPHICcustom.Text, out int LegalHolidayAndRestDayOTAmount) ? (object)LegalHolidayAndRestDayOTAmount : DBNull.Value);
                        cmd.Parameters.AddWithValue("@TotalEmployeeHolidayHrs", int.TryParse(txtTotalEmpHolidayHrs.Text, out int TotalEmployeeHolidayHrs) ? (object)TotalEmployeeHolidayHrs : DBNull.Value);
                        cmd.Parameters.AddWithValue("@TotalEmployeeHolidayDays", int.TryParse(txtTotalEmpHolidayDays.Text, out int TotalEmployeeHolidayDays) ? (object)TotalEmployeeHolidayDays : DBNull.Value);
                        cmd.Parameters.AddWithValue("@TotalEmployeeHolidayAmount", int.TryParse(txtTotalEmpHolidayAmt.Text, out int TotalEmployeeHolidayAmount) ? (object)TotalEmployeeHolidayAmount : DBNull.Value);
                        cmd.Parameters.AddWithValue("@NDonworkingdayHrs", int.TryParse(txtNDworkingDayhrs.Text, out int NDonworkingdayHrs) ? (object)NDonworkingdayHrs : DBNull.Value);
                        cmd.Parameters.AddWithValue("@NDonworkingdayAmount", int.TryParse(txtNDworkingDayAmount.Text, out int NDonworkingdayAmount) ? (object)NDonworkingdayAmount : DBNull.Value);
                        cmd.Parameters.AddWithValue("@NDOTonworkingdayHrs", int.TryParse(txtNDOTworkingDayhrs.Text, out int NDOTonworkingdayHrs) ? (object)NDOTonworkingdayHrs : DBNull.Value);
                        cmd.Parameters.AddWithValue("@NDOTonworkingdayAmount", int.TryParse(txtPHICcustom.Text, out int NDOTonworkingdayAmount) ? (object)NDOTonworkingdayAmount : DBNull.Value);
                        cmd.Parameters.AddWithValue("@NDonLegalHolidayHrs", int.TryParse(txtNDLegalHolidayHrs.Text, out int NDonLegalHolidayHrs) ? (object)NDonLegalHolidayHrs : DBNull.Value);
                        cmd.Parameters.AddWithValue("@NDonLegalHolidayAmount", int.TryParse(txtNDLegalHolidayAmt.Text, out int NDonLegalHolidayAmount) ? (object)NDonLegalHolidayAmount : DBNull.Value);
                        cmd.Parameters.AddWithValue("@NDOTonLegalHolidayHrs", int.TryParse(txtNDOTLegalHolidayHrs.Text, out int NDOTonLegalHolidayHrs) ? (object)NDOTonLegalHolidayHrs : DBNull.Value);
                        cmd.Parameters.AddWithValue("@NDOTonLegalHolidayAmount", int.TryParse(txtNDOTLegalHolidayAmt.Text, out int NDOTonLegalHolidayAmount) ? (object)NDOTonLegalHolidayAmount : DBNull.Value);
                        cmd.Parameters.AddWithValue("@NDonRestDayLegalHolidayHrs", int.TryParse(txtNDRHandLHhrs.Text, out int NDonRestDayLegalHolidayHrs) ? (object)NDonRestDayLegalHolidayHrs : DBNull.Value);
                        cmd.Parameters.AddWithValue("@NDonLegalHolidayRestdayAmount", int.TryParse(txtNDRHandLHamount.Text, out int NDonLegalHolidayRestdayAmount) ? (object)NDonLegalHolidayRestdayAmount : DBNull.Value);
                        cmd.Parameters.AddWithValue("@NDOTonRestDayLegalHolidayHrs", int.TryParse(txtNDotRHandLHhrs.Text, out int NDOTonRestDayLegalHolidayHrs) ? (object)NDOTonRestDayLegalHolidayHrs : DBNull.Value);
                        cmd.Parameters.AddWithValue("@NDOTonLegalHolidayRestdayAmount", int.TryParse(txtNDotRHandLHamount.Text, out int NDOTonLegalHolidayRestdayAmount) ? (object)NDOTonLegalHolidayRestdayAmount : DBNull.Value);
                        cmd.Parameters.AddWithValue("@NDonSpecialHolidayorRestDayHrs", int.TryParse(txtNDonSHorRDhrs.Text, out int NDonSpecialHolidayorRestDayHrs) ? (object)NDonSpecialHolidayorRestDayHrs : DBNull.Value);
                        cmd.Parameters.AddWithValue("@NDonSpecialHolidayorRestDayAmount", int.TryParse(txtNDonSHorRDAmount.Text, out int NDonSpecialHolidayorRestDayAmount) ? (object)NDonSpecialHolidayorRestDayAmount : DBNull.Value);
                        cmd.Parameters.AddWithValue("@NDOTonSpecialHolidayorRestDayHrs", int.TryParse(txtNDOTonSHorRDhrs.Text, out int NDOTonSpecialHolidayorRestDayHrs) ? (object)NDOTonSpecialHolidayorRestDayHrs : DBNull.Value);
                        cmd.Parameters.AddWithValue("@NDOTonSpecialHolidayorRestDayAmount", int.TryParse(txtNDOTonSHorRDAmt.Text, out int NDOTonSpecialHolidayorRestDayAmount) ? (object)NDOTonSpecialHolidayorRestDayAmount : DBNull.Value);
                        cmd.Parameters.AddWithValue("@NDSpecialHolidayandRestDayHrs", int.TryParse(txtNDSpecHolAndRestdayHrs.Text, out int NDSpecialHolidayandRestDayHrs) ? (object)NDSpecialHolidayandRestDayHrs : DBNull.Value);
                        cmd.Parameters.AddWithValue("@NDSpecialHolidayandRestDayAmount", int.TryParse(txtNDSpecHolAndRestdayAmt.Text, out int NDSpecialHolidayandRestDayAmount) ? (object)NDSpecialHolidayandRestDayAmount : DBNull.Value);
                        cmd.Parameters.AddWithValue("@NDOTSpecialHolidayandRestDayHrs", int.TryParse(txtNDOTSpecHolAndRestdayHrs.Text, out int NDOTSpecialHolidayandRestDayHrs) ? (object)NDOTSpecialHolidayandRestDayHrs : DBNull.Value);
                        cmd.Parameters.AddWithValue("@NDOTSpecialHolidayandRestDayAmount", int.TryParse(txtNDOTSpecHolAndRestdayAmt.Text, out int NDOTSpecialHolidayandRestDayAmount) ? (object)NDOTSpecialHolidayandRestDayAmount : DBNull.Value);
                        cmd.Parameters.AddWithValue("@TotalNDHrs", int.TryParse(txtTotalNDhrs.Text, out int TotalNDHrs) ? (object)TotalNDHrs : DBNull.Value);
                        cmd.Parameters.AddWithValue("@TotalNDAmount", int.TryParse(txtTotalNDAmt.Text, out int TotalNDAmount) ? (object)TotalNDAmount : DBNull.Value);
                        cmd.Parameters.AddWithValue("@SalaryAdjustment", int.TryParse(txtSalaryAdjust.Text, out int SalaryAdjustment) ? (object)SalaryAdjustment : DBNull.Value);
                        cmd.Parameters.AddWithValue("@LeaveWithPaySickDays", int.TryParse(txtLeavewithPaySickDays.Text, out int LeaveWithPaySickDays) ? (object)LeaveWithPaySickDays : DBNull.Value);
                        cmd.Parameters.AddWithValue("@LeaveWithPayVacationDays", int.TryParse(txtLeavewithPayVacationAmount.Text, out int LeaveWithPayVacationDays) ? (object)LeaveWithPayVacationDays : DBNull.Value);
                        cmd.Parameters.AddWithValue("@LeaveWithPaySickAmount", int.TryParse(txtleavewithPaySickAmount.Text, out int LeaveWithPaySickAmount) ? (object)LeaveWithPaySickAmount : DBNull.Value);
                        cmd.Parameters.AddWithValue("@LeaveWithPayVacationAmount", int.TryParse(txtLeavewithPayVacationAmount.Text, out int LeaveWithPayVacationAmount) ? (object)LeaveWithPayVacationAmount : DBNull.Value);
                        cmd.Parameters.AddWithValue("@COLA", int.TryParse(txtCOLA.Text, out int COLA) ? (object)COLA : DBNull.Value);
                        cmd.Parameters.AddWithValue("@Incentives", int.TryParse(txtIncentives.Text, out int Incentives) ? (object)Incentives : DBNull.Value);
                        cmd.Parameters.AddWithValue("@HazzardPay", int.TryParse(txtHazzardPay.Text, out int HazzardPay) ? (object)HazzardPay : DBNull.Value);
                        cmd.Parameters.AddWithValue("@Commission", int.TryParse(txtCommission.Text, out int Commission) ? (object)Commission : DBNull.Value);
                        cmd.Parameters.AddWithValue("@CalamityLeave", int.TryParse(txtCalamityLeave.Text, out int CalamityLeave) ? (object)CalamityLeave : DBNull.Value);
                        cmd.Parameters.AddWithValue("@OtherTaxable2", int.TryParse(txtOtherTaxableTwo.Text, out int OtherTaxable2) ? (object)OtherTaxable2 : DBNull.Value);
                        cmd.Parameters.AddWithValue("@TotalTaxableAmount", int.TryParse(txtTotaltaxableAmount.Text, out int TotalTaxableAmount) ? (object)TotalTaxableAmount : DBNull.Value);
                        cmd.Parameters.AddWithValue("@DeMinimis", int.TryParse(txtDeminimis.Text, out int DeMinimis) ? (object)DeMinimis : DBNull.Value);
                        cmd.Parameters.AddWithValue("@IncentiveProgram", int.TryParse(txtIncentiveProgram.Text, out int IncentiveProgram) ? (object)IncentiveProgram : DBNull.Value);
                        cmd.Parameters.AddWithValue("@Bonus", int.TryParse(txtBonus.Text, out int Bonus) ? (object)Bonus : DBNull.Value);
                        cmd.Parameters.AddWithValue("@Column3", int.TryParse(txtColumn3.Text, out int Column3) ? (object)Column3 : DBNull.Value);
                        cmd.Parameters.AddWithValue("@LaundryAllowance", int.TryParse(txtLaundryAllowance.Text, out int LaundryAllowance) ? (object)LaundryAllowance : DBNull.Value);
                        cmd.Parameters.AddWithValue("@MealAllowance", int.TryParse(txtMealAllowance.Text, out int MealAllowance) ? (object)MealAllowance : DBNull.Value);
                        cmd.Parameters.AddWithValue("@CompanyLoan", int.TryParse(txtCompanyLoan.Text, out int CompanyLoan) ? (object)CompanyLoan : DBNull.Value);
                        cmd.Parameters.AddWithValue("@T13MonthPay", int.TryParse(txt13monthPay.Text, out int T13MonthPay) ? (object)T13MonthPay : DBNull.Value);
                        cmd.Parameters.AddWithValue("@TotalNonTaxable", int.TryParse(txtTotalNonTaxableAmt.Text, out int TotalNonTaxable) ? (object)TotalNonTaxable : DBNull.Value);
                        cmd.Parameters.AddWithValue("@TotalGrossPay", int.TryParse(txtTotalGrossPay.Text, out int TotalGrossPay) ? (object)TotalGrossPay : DBNull.Value);

                        cmd.Parameters.AddWithValue("@[Late(MinuteBased)Min]", int.TryParse(txtLateMin.Text, out int LateMin) ? (object)LateMin : DBNull.Value);
                        cmd.Parameters.AddWithValue("@[Late(MinuteBased)Amount]", int.TryParse(txtLateMinAmount.Text, out int LateMinAmount) ? (object)LateMinAmount : DBNull.Value);
                        cmd.Parameters.AddWithValue("@[Late(HourBased)Hour]", int.TryParse(txtLateHours.Text, out int LateHours) ? (object)LateHours : DBNull.Value);
                        cmd.Parameters.AddWithValue("@[Late(HourBased)Amount]", int.TryParse(txtLateHourAmount.Text, out int LateHourAmount) ? (object)LateHourAmount : DBNull.Value);
                        cmd.Parameters.AddWithValue("@AbsentOrWithoutLWPDays", int.TryParse(txtAbsentDays.Text, out int AbsentOrWithoutLWPDays) ? (object)AbsentOrWithoutLWPDays : DBNull.Value);
                        cmd.Parameters.AddWithValue("@AbsentOrWithoutLWPAmount", int.TryParse(txtAbsentAmt.Text, out int AbsentOrWithoutLWPAmount) ? (object)AbsentOrWithoutLWPAmount : DBNull.Value);
                        cmd.Parameters.AddWithValue("@TotalTardiness", int.TryParse(txtTotalTardiness.Text, out int TotalTardiness) ? (object)TotalTardiness : DBNull.Value);
                        cmd.Parameters.AddWithValue("@SSSBasicPayBased", int.TryParse(txtSSSBasicPayBased.Text, out int SSSBasicPayBased) ? (object)SSSBasicPayBased : DBNull.Value);
                        cmd.Parameters.AddWithValue("@SSSGrossBased", int.TryParse(txtSSSGrossBase.Text, out int SSSGrossBased) ? (object)SSSGrossBased : DBNull.Value);
                        cmd.Parameters.AddWithValue("@SSSstatus", int.TryParse(comboBox1.Text, out int SSSstatus) ? (object)SSSstatus : DBNull.Value);
                        cmd.Parameters.AddWithValue("@SSS", int.TryParse(txtEEContribution.Text, out int SSS) ? (object)SSS : DBNull.Value);
                        cmd.Parameters.AddWithValue("@PHICBasicPayBased", int.TryParse(txtPHICBasedPay.Text, out int PHICBasicPayBased) ? (object)PHICBasicPayBased : DBNull.Value);
                        cmd.Parameters.AddWithValue("@PHICstatus", int.TryParse(txtPHICBasedPay.Text, out int PHICstatus) ? (object)PHICstatus : DBNull.Value);
                        cmd.Parameters.AddWithValue("@HDMFSTATUS", int.TryParse(comboBox2.Text, out int HDMFSTATUS) ? (object)HDMFSTATUS : DBNull.Value);
                        cmd.Parameters.AddWithValue("@HDMF", int.TryParse(txtHDMf.Text, out int HDMF) ? (object)HDMF : DBNull.Value);
                        cmd.Parameters.AddWithValue("@TotalSocialCost", int.TryParse(txtTotalSocialCost.Text, out int TotalSocialCost) ? (object)TotalSocialCost : DBNull.Value);
                        cmd.Parameters.AddWithValue("@SSSsalaryloan", int.TryParse(txtSSSSalaryLoan.Text, out int SSSsalaryloan) ? (object)SSSsalaryloan : DBNull.Value);
                        cmd.Parameters.AddWithValue("@SSSCalamityLoan", int.TryParse(txtSSSCalamityLoan.Text, out int SSSCalamityLoan) ? (object)SSSCalamityLoan : DBNull.Value);
                        cmd.Parameters.AddWithValue("@HDMFSalaryLoan", int.TryParse(txtHdmfSalaryLoan.Text, out int HDMFSalaryLoan) ? (object)HDMFSalaryLoan : DBNull.Value);
                        cmd.Parameters.AddWithValue("@HDMFCalamityLoan", int.TryParse(txtHdmfCalamityLoan.Text, out int HDMFCalamityLoan) ? (object)HDMFCalamityLoan : DBNull.Value);
                        cmd.Parameters.AddWithValue("@TotalGovernmentLoans", int.TryParse(txtTotalGovernmentLoans.Text, out int TotalGovernmentLoans) ? (object)TotalGovernmentLoans : DBNull.Value);
                        cmd.Parameters.AddWithValue("@CompanyLoans", int.TryParse(txtCompanyLoans.Text, out int CompanyLoans) ? (object)CompanyLoans : DBNull.Value);
                        cmd.Parameters.AddWithValue("@OtherLoan1", int.TryParse(txtOtherLoan1.Text, out int OtherLoan1) ? (object)OtherLoan1 : DBNull.Value);
                        cmd.Parameters.AddWithValue("@OtherLoan2", int.TryParse(txtOtherLoan2.Text, out int OtherLoan2) ? (object)OtherLoan2 : DBNull.Value);
                        cmd.Parameters.AddWithValue("@OtherLoan3", int.TryParse(txtotherLoan3.Text, out int OtherLoan3) ? (object)OtherLoan3 : DBNull.Value);
                        cmd.Parameters.AddWithValue("@TotalOtherLoans", int.TryParse(txtTotalOtherLoans.Text, out int TotalOtherLoans) ? (object)TotalOtherLoans : DBNull.Value);
                        cmd.Parameters.AddWithValue("@AdjustmentOrRefunds", int.TryParse(txtAdjustmentOrRefund.Text, out int AdjustmentOrRefunds) ? (object)AdjustmentOrRefunds : DBNull.Value);
                        cmd.Parameters.AddWithValue("@SalaryDeduction", int.TryParse(txtSalaryDeductions.Text, out int SalaryDeduction) ? (object)SalaryDeduction : DBNull.Value);
                        cmd.Parameters.AddWithValue("@Deductions", int.TryParse(txtDeduction.Text, out int Deductions) ? (object)Deductions : DBNull.Value);
                        cmd.Parameters.AddWithValue("@ManualTeraphyTechniques", int.TryParse(txtManualTeraphyTechniques.Text, out int ManualTeraphyTechniques) ? (object)ManualTeraphyTechniques : DBNull.Value);
                        cmd.Parameters.AddWithValue("@UniformDeduction", int.TryParse(txtuniformdeductions.Text, out int UniformDeduction) ? (object)UniformDeduction : DBNull.Value);
                        cmd.Parameters.AddWithValue("@MedicalExpensesDeduction", int.TryParse(txtMedicalExpense.Text, out int MedicalExpensesDeduction) ? (object)MedicalExpensesDeduction : DBNull.Value);
                        cmd.Parameters.AddWithValue("@TotalDeductions", int.TryParse(txtTotalDeductions.Text, out int TotalDeductions) ? (object)TotalDeductions : DBNull.Value);
                        cmd.Parameters.AddWithValue("@AmountDue", int.TryParse(txtAmountDue.Text, out int AmountDue) ? (object)AmountDue : DBNull.Value);
                        cmd.Parameters.AddWithValue("@TaxableIncome", int.TryParse(txtTaxableIncome.Text, out int TaxableIncome) ? (object)TaxableIncome : DBNull.Value);
                        cmd.Parameters.AddWithValue("@WithholdingTax", int.TryParse(txtWithholdingTax.Text, out int WithholdingTax) ? (object)WithholdingTax : DBNull.Value);
                        cmd.Parameters.AddWithValue("@NetPay", int.TryParse(txtNetPay.Text, out int NetPay) ? (object)NetPay : DBNull.Value);
                        cmd.Parameters.AddWithValue("@[13thmonthbased]", int.TryParse(txt13thMonthBased.Text, out int T13thmonthbased) ? (object)T13thmonthbased : DBNull.Value);
                        cmd.Parameters.AddWithValue("@[13thMonthforthisCutoff]", int.TryParse(txt13thmonthforthisCutoff.Text, out int T13thMonthforthisCutoff) ? (object)T13thMonthforthisCutoff : DBNull.Value);
                        cmd.Parameters.AddWithValue("@SalaryType", int.TryParse(txtSalaryType.Text, out int SalaryType) ? (object)SalaryType : DBNull.Value);
                        cmd.Parameters.AddWithValue("@ATM", int.TryParse(txtAtm.Text, out int ATM) ? (object)ATM : DBNull.Value);
                        cmd.Parameters.AddWithValue("@CASH", int.TryParse(txtCash.Text, out int CASH) ? (object)CASH : DBNull.Value);
                        cmd.Parameters.AddWithValue("@ATM#", int.TryParse(txtCash.Text, out int ATMs) ? (object)ATMs : DBNull.Value);








                        // Check if any numeric fields were invalid
                        if (cmd.Parameters["@ID"].Value is DBNull)

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
               
            }
        }
    }
}
    



