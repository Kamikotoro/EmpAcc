using EmpAcc.EmpAccDBDataSetTableAdapters;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using static EmpAcc.EmpAccDBDataSet;

namespace EmpAcc
{
    public partial class MainForm : Form
    {
        bool _menuOpened = true;
        int _tabIndex = 0;

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr one, int two, int three, int four);


        public MainForm()
        {
            InitializeComponent();
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void MenuButton_Click(object sender, EventArgs e)
        {
            MenuTimer.Start();

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (_menuOpened)
            {
                MenuPanel.Width -= 10;
                if (MenuPanel.Width <= MenuPanel.MinimumSize.Width)
                {
                    _menuOpened = false;
                    MenuTimer.Stop();
                }
            }
            else
            {
                MenuPanel.Width += 10;
                if (MenuPanel.Width >= MenuPanel.MaximumSize.Width)
                {
                    _menuOpened = true;
                    MenuTimer.Stop();
                }
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void MaxButton_Click(object sender, EventArgs e)
        {
            if (WindowState is FormWindowState.Maximized) WindowState = FormWindowState.Normal;
            else WindowState = FormWindowState.Maximized;
        }

        private void MinButton_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void MainPanelDrag(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(Handle, 0x112, 0xf012, 0);
        }

        private void SearchBox_TextChanged(object sender, EventArgs e)
        {

        }



        private void EmpTab_SelectedIndexChanged(object sender, EventArgs e)
        {
            _tabIndex = ((TabControl)sender).SelectedIndex;
            switch (_tabIndex)
            {
                case 0:
                    button2.Visible = true;
                    DeleteButton.Visible = true;
                    button3.Visible = true;
                    break;
                case 1:
                    button2.Visible = true;
                    DeleteButton.Visible = true;
                    button3.Visible = false;
                    break;
                case 2:
                    button2.Visible = false;
                    DeleteButton.Visible = false;
                    button3.Visible = false;
                    break;
                default:
                    break;
            }
        }




        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "empAccDBDataSet.ChartView". При необходимости она может быть перемещена или удалена.
            this.chartViewTableAdapter.Fill(this.empAccDBDataSet.ChartView);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "empAccDBDataSet.Division". При необходимости она может быть перемещена или удалена.
            this.divisionTableAdapter.Fill(this.empAccDBDataSet.Division);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "empAccDBDataSet.Employees". При необходимости она может быть перемещена или удалена.
            this.employeesTableAdapter.Fill(this.empAccDBDataSet.Employees);

        }



        private void ChartSelected(object sender, TabControlCancelEventArgs e)
        {
            UpdateChart();
        }


        private void UpdateChart()
        {
            EmpChart.Series[0].XValueMember = "Title";
            EmpChart.Series[0].YValueMembers = "Count";

            EmpChart.DataSource = empAccDBDataSet.ChartView.DefaultView;
            EmpChart.DataBind();
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            switch (_tabIndex)
            {
                case 0:
                    empAccDBDataSet.Employees.AddEmployeesRow("", 0, "", null, "", "", null, null);
                    break;
                case 1:
                    empAccDBDataSet.Division.AddDivisionRow("", null);
                    break;
                default:
                    break;
            }
        }


        private void DeleteButton_Click(object sender, EventArgs e)
        {
            switch (_tabIndex)
            {
                case 0:
                    empAccDBDataSet.Employees.RemoveEmployeesRow((EmployeesRow)((DataRowView)EmpDataGrid.SelectedRows[0].DataBoundItem).Row);
                    break;
                case 1:
                    empAccDBDataSet.Division.RemoveDivisionRow((DivisionRow)((DataRowView)DivDataGrid.SelectedRows[0].DataBoundItem).Row);
                    break;
                default:
                    break;
            }

        }
        
        private void EmpDataGrid_EditEnd(object sender, DataGridViewCellEventArgs e)
        {
            this.Validate();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ((EmployeesRow)((DataRowView)EmpDataGrid.SelectedRows[0].DataBoundItem).Row).DateDis = DateTime.Now;
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                this.tableAdapterManager.UpdateAll(empAccDBDataSet);

            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }

        }
    }
}
