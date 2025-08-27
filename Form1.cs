using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Dynamic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace To_Do_List
{
    public partial class Form1 : Form
    {
        //بدايه كود توسيط العناصر في الشاشه
        private Dictionary<Control, CtrlInfo> DefaultControlSizes = new Dictionary<Control, CtrlInfo>();
        private Size FormDefaultClientSize;
        public Form1()
        {
            InitializeComponent();
            this.Resize += Form1_Resize;
            this.WindowState = FormWindowState.Normal;
            this.MinimumSize = this.Size;
            FormDefaultClientSize = this.ClientSize;

            Control ctrl = this.GetNextControl(this, true);
            while (ctrl != null)
            {
                if (ctrl is ListBox listBox)
                    listBox.IntegralHeight = false;

                DefaultControlSizes.Add(ctrl, new CtrlInfo(ctrl.Bounds, ctrl.Font.Size));
                ctrl = this.GetNextControl(ctrl, true);
            }
        }

        private void ScaleControls()
        {
            if (this.WindowState != FormWindowState.Minimized)
            {
                foreach (var kvp in DefaultControlSizes)
                {
                    Control ctrl = kvp.Key;

                    double Xscl = (double)this.ClientSize.Width / FormDefaultClientSize.Width;
                    double Yscl = (double)this.ClientSize.Height / FormDefaultClientSize.Height;

                    // لو مش عايز تغير حجم الخط علّق السطرين دول
                    float fntscl = (float)(kvp.Value.cFontSize * Yscl);
                    ctrl.Font = new Font(ctrl.Font.FontFamily, fntscl, ctrl.Font.Style, ctrl.Font.Unit);

                    ctrl.Width = (int)(kvp.Value.cBounds.Width * Xscl);
                    ctrl.Height = (int)(kvp.Value.cBounds.Height * Yscl);
                    ctrl.Left = (int)(kvp.Value.cBounds.X * Xscl);
                    ctrl.Top = (int)(kvp.Value.cBounds.Y * Yscl);
                }
            }
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            ScaleControls();
        }

        public class CtrlInfo
        {
            public Rectangle cBounds;
            public float cFontSize;

            public CtrlInfo(Rectangle bounds, float fontSize)
            {
                cBounds = bounds;
                cFontSize = fontSize;
            }
        }
        // نهايه كود توسيط العناصر في الشاشه
        string filePath = Path.Combine(Application.StartupPath, "data.txt");

        void LoadDataFromFile()
        {
            
            if (File.Exists(filePath))
            {
              checkedListBox.Items.AddRange(File.ReadAllLines(filePath));
            }
        }
        void SaveDataToFile()
        {
            string[] Tasks = new string[checkedListBox.Items.Count];
            for (int i = 0; i < checkedListBox.Items.Count; i++)
            {
                Tasks[i]= checkedListBox.Items[i].ToString();
            }
            File.WriteAllLines(filePath, Tasks);
        }
        void ShowTasks()
        {
            if(checkedListBox.CheckedItems.Count == 0)
            {
                MessageBox.Show("No tasks selected.", "Info", MessageBoxButtons.OK);
                return;
            }
            string Selected = "";
            for (int i = 0; i < checkedListBox.CheckedItems.Count; i++)
            {
                Selected += (i + 1) + "-" + checkedListBox.CheckedItems[i] + "\n";
            }
            MessageBox.Show(Selected, "Selected Items", MessageBoxButtons.OK);
        }
        void DeleteTask()
        {
            var confirm = MessageBox.Show("Are you sure you want to delete selected tasks?", "Confirm Delete", MessageBoxButtons.YesNo);
            if (confirm == DialogResult.Yes)
            {
                for (int i = checkedListBox.CheckedIndices.Count - 1; i >= 0; i--)
                {
                    checkedListBox.Items.RemoveAt(checkedListBox.CheckedIndices[i]);
                }
                SaveDataToFile();
            }
            
        } 
        void AddTask()
        {
            if (txtbxAddItem.Text.ToString() == "")
            {
                MessageBox.Show("Please Enter A Task", "Nothing To Add", MessageBoxButtons.OK);
                return;
            }
            for (int i = 0; i < checkedListBox.Items.Count; i++)
            {
                if (txtbxAddItem.Text.ToLower() == checkedListBox.Items[i].ToString().ToLower())
                {
                    MessageBox.Show("Task Already Exist", "Nothing To Add", MessageBoxButtons.OK);
                    return;
                }
            }
            checkedListBox.Items.Add(txtbxAddItem.Text.ToString());
            txtbxAddItem.Clear();
            SaveDataToFile();
        }

        private void btnShowSelectedItems_Click(object sender, EventArgs e)
        {
            ShowTasks();
        }

        private void btnAddTask_Click(object sender, EventArgs e)
        {
            AddTask();
        }

        private void btnRemoveCheckedTask_Click(object sender, EventArgs e)
        {
            if (checkedListBox.CheckedItems.Count > 0)
            {
                DeleteTask();
                return;
            }
            MessageBox.Show("No tasks selected.", "Info", MessageBoxButtons.OK);
        }

        private void btnCheckAllTask_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < checkedListBox.Items.Count; i++)
            {
                checkedListBox.SetItemChecked(i, true);
            }
        }

        private void btnUncheckAllTask_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < checkedListBox.Items.Count; i++)
            {
                checkedListBox.SetItemChecked(i, false);
            }
        }

        private void txtbxAddItem_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnAddTask.PerformClick();
                e.SuppressKeyPress = true;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (!File.Exists(filePath))
            {
                File.WriteAllText(filePath, ""); 
            }
            LoadDataFromFile();
        }
    }

}

       
    

