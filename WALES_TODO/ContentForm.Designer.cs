namespace WALES_TODO
{
    partial class ContentForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.sqlCommand1 = new Microsoft.Data.SqlClient.SqlCommand();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.RefreshBtn = new System.Windows.Forms.Button();
            this.EditBtn = new System.Windows.Forms.Button();
            this.DelBtn = new System.Windows.Forms.Button();
            this.DataSpace = new System.Windows.Forms.DataGridView();
            this.SearchBtn = new System.Windows.Forms.Label();
            this.TextToSearch = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.statusbox = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dateTime = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.AddBtn = new System.Windows.Forms.Button();
            this.TaskText = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataSpace)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // sqlCommand1
            // 
            this.sqlCommand1.CommandTimeout = 30;
            this.sqlCommand1.EnableOptimizedParameterBinding = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.RefreshBtn);
            this.groupBox1.Controls.Add(this.EditBtn);
            this.groupBox1.Controls.Add(this.DelBtn);
            this.groupBox1.Controls.Add(this.DataSpace);
            this.groupBox1.Controls.Add(this.SearchBtn);
            this.groupBox1.Controls.Add(this.TextToSearch);
            this.groupBox1.Location = new System.Drawing.Point(653, 199);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(985, 548);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // RefreshBtn
            // 
            this.RefreshBtn.Location = new System.Drawing.Point(451, 473);
            this.RefreshBtn.Name = "RefreshBtn";
            this.RefreshBtn.Size = new System.Drawing.Size(144, 43);
            this.RefreshBtn.TabIndex = 5;
            this.RefreshBtn.Text = "Refresh";
            this.RefreshBtn.UseVisualStyleBackColor = true;
            this.RefreshBtn.Click += new System.EventHandler(this.RefreshBtn_Click);
            // 
            // EditBtn
            // 
            this.EditBtn.Location = new System.Drawing.Point(645, 473);
            this.EditBtn.Name = "EditBtn";
            this.EditBtn.Size = new System.Drawing.Size(138, 43);
            this.EditBtn.TabIndex = 4;
            this.EditBtn.Text = "Edit";
            this.EditBtn.UseVisualStyleBackColor = true;
            this.EditBtn.Click += new System.EventHandler(this.EditBtn_Click);
            // 
            // DelBtn
            // 
            this.DelBtn.Location = new System.Drawing.Point(829, 473);
            this.DelBtn.Name = "DelBtn";
            this.DelBtn.Size = new System.Drawing.Size(135, 43);
            this.DelBtn.TabIndex = 3;
            this.DelBtn.Text = "Delete";
            this.DelBtn.UseVisualStyleBackColor = true;
            this.DelBtn.Click += new System.EventHandler(this.DelBtn_Click);
            // 
            // DataSpace
            // 
            this.DataSpace.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DataSpace.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.DataSpace.BackgroundColor = System.Drawing.SystemColors.Control;
            this.DataSpace.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataSpace.Location = new System.Drawing.Point(15, 82);
            this.DataSpace.Name = "DataSpace";
            this.DataSpace.RowHeadersWidth = 51;
            this.DataSpace.RowTemplate.Height = 29;
            this.DataSpace.Size = new System.Drawing.Size(963, 352);
            this.DataSpace.TabIndex = 2;
            // 
            // SearchBtn
            // 
            this.SearchBtn.AutoSize = true;
            this.SearchBtn.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.SearchBtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.SearchBtn.Location = new System.Drawing.Point(108, 24);
            this.SearchBtn.Name = "SearchBtn";
            this.SearchBtn.Size = new System.Drawing.Size(76, 30);
            this.SearchBtn.TabIndex = 1;
            this.SearchBtn.Text = "Search:";
            this.SearchBtn.Click += new System.EventHandler(this.SearchBtn_Click);
            // 
            // TextToSearch
            // 
            this.TextToSearch.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TextToSearch.Location = new System.Drawing.Point(191, 23);
            this.TextToSearch.Multiline = true;
            this.TextToSearch.Name = "TextToSearch";
            this.TextToSearch.Size = new System.Drawing.Size(773, 37);
            this.TextToSearch.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.statusbox);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.dateTime);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.AddBtn);
            this.groupBox2.Controls.Add(this.TaskText);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(26, 199);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(621, 548);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            // 
            // statusbox
            // 
            this.statusbox.AutoSize = true;
            this.statusbox.Location = new System.Drawing.Point(583, 49);
            this.statusbox.Name = "statusbox";
            this.statusbox.Size = new System.Drawing.Size(18, 17);
            this.statusbox.TabIndex = 6;
            this.statusbox.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(532, 44);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Status";
            // 
            // dateTime
            // 
            this.dateTime.Location = new System.Drawing.Point(147, 249);
            this.dateTime.Name = "dateTime";
            this.dateTime.Size = new System.Drawing.Size(250, 27);
            this.dateTime.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(73, 249);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "DueDate";
            // 
            // AddBtn
            // 
            this.AddBtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.AddBtn.Location = new System.Drawing.Point(73, 122);
            this.AddBtn.Name = "AddBtn";
            this.AddBtn.Size = new System.Drawing.Size(453, 50);
            this.AddBtn.TabIndex = 2;
            this.AddBtn.Text = "AddTask";
            this.AddBtn.UseVisualStyleBackColor = true;
            this.AddBtn.Click += new System.EventHandler(this.AddBtn_Click);
            // 
            // TaskText
            // 
            this.TaskText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TaskText.Location = new System.Drawing.Point(73, 44);
            this.TaskText.Multiline = true;
            this.TaskText.Name = "TaskText";
            this.TaskText.Size = new System.Drawing.Size(453, 44);
            this.TaskText.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(6, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "TASK:";
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.richTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox1.Font = new System.Drawing.Font("Segoe UI", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.richTextBox1.Location = new System.Drawing.Point(549, 21);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(484, 110);
            this.richTextBox1.TabIndex = 2;
            this.richTextBox1.Text = "WALES TO_DO";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1664, 759);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataSpace)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Data.SqlClient.SqlCommand sqlCommand1;
        private GroupBox groupBox1;
        private Button RefreshBtn;
        private Button EditBtn;
        private Button DelBtn;
        private DataGridView DataSpace;
        private Label SearchBtn;
        private TextBox TextToSearch;
        private GroupBox groupBox2;
        private DateTimePicker dateTime;
        private Label label2;
        private Button AddBtn;
        private TextBox TaskText;
        private Label label1;
        private RichTextBox richTextBox1;
        private CheckBox statusbox;
        private Label label3;
    }
}