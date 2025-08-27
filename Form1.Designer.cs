namespace To_Do_List
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.checkedListBox = new System.Windows.Forms.CheckedListBox();
            this.txtbxAddItem = new System.Windows.Forms.TextBox();
            this.btnShowSelectedItems = new System.Windows.Forms.Button();
            this.btnRemoveCheckedTask = new System.Windows.Forms.Button();
            this.btnCheckAllTask = new System.Windows.Forms.Button();
            this.btnUncheckAllTask = new System.Windows.Forms.Button();
            this.btnAddTask = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // checkedListBox
            // 
            this.checkedListBox.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.checkedListBox.FormattingEnabled = true;
            this.checkedListBox.Location = new System.Drawing.Point(75, 120);
            this.checkedListBox.Name = "checkedListBox";
            this.checkedListBox.Size = new System.Drawing.Size(530, 194);
            this.checkedListBox.TabIndex = 0;
            // 
            // txtbxAddItem
            // 
            this.txtbxAddItem.Location = new System.Drawing.Point(248, 361);
            this.txtbxAddItem.Name = "txtbxAddItem";
            this.txtbxAddItem.Size = new System.Drawing.Size(195, 24);
            this.txtbxAddItem.TabIndex = 1;
            this.txtbxAddItem.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtbxAddItem_KeyDown);
            // 
            // btnShowSelectedItems
            // 
            this.btnShowSelectedItems.Location = new System.Drawing.Point(75, 344);
            this.btnShowSelectedItems.Name = "btnShowSelectedItems";
            this.btnShowSelectedItems.Size = new System.Drawing.Size(115, 56);
            this.btnShowSelectedItems.TabIndex = 2;
            this.btnShowSelectedItems.Text = " Show Selected Items";
            this.btnShowSelectedItems.UseVisualStyleBackColor = true;
            this.btnShowSelectedItems.Click += new System.EventHandler(this.btnShowSelectedItems_Click);
            // 
            // btnRemoveCheckedTask
            // 
            this.btnRemoveCheckedTask.Location = new System.Drawing.Point(75, 442);
            this.btnRemoveCheckedTask.Name = "btnRemoveCheckedTask";
            this.btnRemoveCheckedTask.Size = new System.Drawing.Size(115, 56);
            this.btnRemoveCheckedTask.TabIndex = 3;
            this.btnRemoveCheckedTask.Text = "Remove Checked Task";
            this.btnRemoveCheckedTask.UseVisualStyleBackColor = true;
            this.btnRemoveCheckedTask.Click += new System.EventHandler(this.btnRemoveCheckedTask_Click);
            // 
            // btnCheckAllTask
            // 
            this.btnCheckAllTask.Location = new System.Drawing.Point(490, 344);
            this.btnCheckAllTask.Name = "btnCheckAllTask";
            this.btnCheckAllTask.Size = new System.Drawing.Size(115, 56);
            this.btnCheckAllTask.TabIndex = 4;
            this.btnCheckAllTask.Text = "Check All Task";
            this.btnCheckAllTask.UseVisualStyleBackColor = true;
            this.btnCheckAllTask.Click += new System.EventHandler(this.btnCheckAllTask_Click);
            // 
            // btnUncheckAllTask
            // 
            this.btnUncheckAllTask.Location = new System.Drawing.Point(490, 442);
            this.btnUncheckAllTask.Name = "btnUncheckAllTask";
            this.btnUncheckAllTask.Size = new System.Drawing.Size(115, 56);
            this.btnUncheckAllTask.TabIndex = 5;
            this.btnUncheckAllTask.Text = "Uncheck All Task";
            this.btnUncheckAllTask.UseVisualStyleBackColor = true;
            this.btnUncheckAllTask.Click += new System.EventHandler(this.btnUncheckAllTask_Click);
            // 
            // btnAddTask
            // 
            this.btnAddTask.Location = new System.Drawing.Point(281, 420);
            this.btnAddTask.Name = "btnAddTask";
            this.btnAddTask.Size = new System.Drawing.Size(115, 56);
            this.btnAddTask.TabIndex = 6;
            this.btnAddTask.Text = "AddTask";
            this.btnAddTask.UseVisualStyleBackColor = true;
            this.btnAddTask.Click += new System.EventHandler(this.btnAddTask_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Vladimir Script", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(250, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(216, 57);
            this.label1.TabIndex = 7;
            this.label1.Text = "To Do List";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(675, 556);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.checkedListBox);
            this.Controls.Add(this.txtbxAddItem);
            this.Controls.Add(this.btnCheckAllTask);
            this.Controls.Add(this.btnAddTask);
            this.Controls.Add(this.btnRemoveCheckedTask);
            this.Controls.Add(this.btnShowSelectedItems);
            this.Controls.Add(this.btnUncheckAllTask);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = " To Do List";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckedListBox checkedListBox;
        private System.Windows.Forms.TextBox txtbxAddItem;
        private System.Windows.Forms.Button btnShowSelectedItems;
        private System.Windows.Forms.Button btnRemoveCheckedTask;
        private System.Windows.Forms.Button btnCheckAllTask;
        private System.Windows.Forms.Button btnUncheckAllTask;
        private System.Windows.Forms.Button btnAddTask;
        private System.Windows.Forms.Label label1;
    }
}

