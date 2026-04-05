namespace Image
{
    partial class Frm_PrintOptions
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
            label1 = new Label();
            printPreviewControl1 = new PrintPreviewControl();
            printDocument1 = new System.Drawing.Printing.PrintDocument();
            printDialog1 = new PrintDialog();
            nud_Width = new NumericUpDown();
            nud_Heigth = new NumericUpDown();
            lb_Width = new Label();
            lb_Height = new Label();
            button1 = new Button();
            comboBox2 = new ComboBox();
            label3 = new Label();
            flp_Perview = new FlowLayoutPanel();
            radioButton2 = new RadioButton();
            groupBox1 = new GroupBox();
            radioButton1 = new RadioButton();
            gb_PageLayout = new GroupBox();
            label4 = new Label();
            nud_columns = new NumericUpDown();
            radioButton4 = new RadioButton();
            radioButton3 = new RadioButton();
            pictureBox2 = new PictureBox();
            button2 = new Button();
            ((System.ComponentModel.ISupportInitialize)nud_Width).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nud_Heigth).BeginInit();
            groupBox1.SuspendLayout();
            gb_PageLayout.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nud_columns).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Symbol", 22.2F, FontStyle.Bold | FontStyle.Underline | FontStyle.Strikeout, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.MediumBlue;
            label1.Location = new Point(575, 6);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(214, 50);
            label1.TabIndex = 0;
            label1.Text = "معاينه الورقه";
            // 
            // printPreviewControl1
            // 
            printPreviewControl1.AutoZoom = false;
            printPreviewControl1.Document = printDocument1;
            printPreviewControl1.Location = new Point(14, 65);
            printPreviewControl1.Margin = new Padding(4, 3, 4, 3);
            printPreviewControl1.Name = "printPreviewControl1";
            printPreviewControl1.Size = new Size(517, 588);
            printPreviewControl1.TabIndex = 0;
            printPreviewControl1.UseAntiAlias = true;
            printPreviewControl1.Zoom = 0.5D;
            // 
            // printDocument1
            // 
            printDocument1.PrintPage += printDocument1_PrintPage;
            // 
            // printDialog1
            // 
            printDialog1.UseEXDialog = true;
            // 
            // nud_Width
            // 
            nud_Width.Cursor = Cursors.AppStarting;
            nud_Width.DecimalPlaces = 2;
            nud_Width.ForeColor = Color.Blue;
            nud_Width.Increment = new decimal(new int[] { 1, 0, 0, 65536 });
            nud_Width.Location = new Point(1210, 109);
            nud_Width.Margin = new Padding(4, 3, 4, 3);
            nud_Width.Name = "nud_Width";
            nud_Width.Size = new Size(169, 27);
            nud_Width.TabIndex = 2;
            nud_Width.ValueChanged += nud_Width_ValueChanged;
            // 
            // nud_Heigth
            // 
            nud_Heigth.Cursor = Cursors.AppStarting;
            nud_Heigth.DecimalPlaces = 2;
            nud_Heigth.ForeColor = Color.Blue;
            nud_Heigth.Increment = new decimal(new int[] { 1, 0, 0, 65536 });
            nud_Heigth.Location = new Point(1210, 152);
            nud_Heigth.Margin = new Padding(4, 3, 4, 3);
            nud_Heigth.Name = "nud_Heigth";
            nud_Heigth.Size = new Size(169, 27);
            nud_Heigth.TabIndex = 3;
            nud_Heigth.ValueChanged += nud_Heigth_ValueChanged;
            // 
            // lb_Width
            // 
            lb_Width.AutoSize = true;
            lb_Width.BackColor = Color.Azure;
            lb_Width.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lb_Width.ForeColor = Color.DodgerBlue;
            lb_Width.Location = new Point(1463, 116);
            lb_Width.Margin = new Padding(4, 0, 4, 0);
            lb_Width.Name = "lb_Width";
            lb_Width.Size = new Size(54, 23);
            lb_Width.TabIndex = 7;
            lb_Width.Text = "الطول";
            // 
            // lb_Height
            // 
            lb_Height.AutoSize = true;
            lb_Height.BackColor = Color.Azure;
            lb_Height.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lb_Height.ForeColor = Color.DodgerBlue;
            lb_Height.Location = new Point(1463, 159);
            lb_Height.Margin = new Padding(4, 0, 4, 0);
            lb_Height.Name = "lb_Height";
            lb_Height.Size = new Size(59, 23);
            lb_Height.TabIndex = 8;
            lb_Height.Text = "العرض";
            // 
            // button1
            // 
            button1.BackColor = Color.MidnightBlue;
            button1.Cursor = Cursors.Hand;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 22.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.White;
            button1.Location = new Point(1390, 560);
            button1.Margin = new Padding(4, 3, 4, 3);
            button1.Name = "button1";
            button1.Size = new Size(171, 59);
            button1.TabIndex = 6;
            button1.Text = "طباعه";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // comboBox2
            // 
            comboBox2.BackColor = Color.Snow;
            comboBox2.Cursor = Cursors.WaitCursor;
            comboBox2.FlatStyle = FlatStyle.Popup;
            comboBox2.FormattingEnabled = true;
            comboBox2.Items.AddRange(new object[] { "صور معاملات (3*4سم)", "صوره للهويه/جواز السفر(4.5*3.5سم)", "حجم الهويه(9.5*6.20)" });
            comboBox2.Location = new Point(1210, 36);
            comboBox2.Margin = new Padding(4, 3, 4, 3);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(170, 28);
            comboBox2.TabIndex = 1;
            comboBox2.SelectedIndexChanged += comboBox2_SelectedIndexChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Symbol", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.DodgerBlue;
            label3.Location = new Point(1463, 36);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(95, 23);
            label3.TabIndex = 11;
            label3.Text = "قياس الصوره";
            // 
            // flp_Perview
            // 
            flp_Perview.AllowDrop = true;
            flp_Perview.AutoScroll = true;
            flp_Perview.BackColor = SystemColors.ActiveBorder;
            flp_Perview.Location = new Point(559, 61);
            flp_Perview.Margin = new Padding(4, 3, 4, 3);
            flp_Perview.Name = "flp_Perview";
            flp_Perview.Size = new Size(634, 558);
            flp_Perview.TabIndex = 12;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Cursor = Cursors.AppStarting;
            radioButton2.FlatStyle = FlatStyle.Flat;
            radioButton2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            radioButton2.ForeColor = Color.DodgerBlue;
            radioButton2.Location = new Point(4, 35);
            radioButton2.Margin = new Padding(4, 3, 4, 3);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(180, 24);
            radioButton2.TabIndex = 0;
            radioButton2.Text = "طباعه في اوراق متعدده\r\n";
            radioButton2.UseVisualStyleBackColor = true;
            radioButton2.CheckedChanged += radioButton2_CheckedChanged;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.Azure;
            groupBox1.Controls.Add(radioButton1);
            groupBox1.Controls.Add(radioButton2);
            groupBox1.Cursor = Cursors.SizeAll;
            groupBox1.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Strikeout, GraphicsUnit.Point, 0);
            groupBox1.ForeColor = Color.RoyalBlue;
            groupBox1.Location = new Point(1210, 206);
            groupBox1.Margin = new Padding(4, 3, 4, 3);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(4, 3, 4, 3);
            groupBox1.Size = new Size(220, 113);
            groupBox1.TabIndex = 4;
            groupBox1.TabStop = false;
            groupBox1.Text = "خيارات الطباعه";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Cursor = Cursors.AppStarting;
            radioButton1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            radioButton1.ForeColor = Color.DodgerBlue;
            radioButton1.Location = new Point(4, 83);
            radioButton1.Margin = new Padding(4, 3, 4, 3);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(171, 24);
            radioButton1.TabIndex = 1;
            radioButton1.Text = "طباعه في نفس الورقه";
            radioButton1.UseVisualStyleBackColor = true;
            radioButton1.CheckedChanged += radioButton1_CheckedChanged_1;
            // 
            // gb_PageLayout
            // 
            gb_PageLayout.BackColor = Color.Lavender;
            gb_PageLayout.Controls.Add(label4);
            gb_PageLayout.Controls.Add(nud_columns);
            gb_PageLayout.Controls.Add(radioButton4);
            gb_PageLayout.Controls.Add(radioButton3);
            gb_PageLayout.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Strikeout, GraphicsUnit.Point, 0);
            gb_PageLayout.ForeColor = Color.RoyalBlue;
            gb_PageLayout.Location = new Point(1381, 325);
            gb_PageLayout.Margin = new Padding(4, 3, 4, 3);
            gb_PageLayout.Name = "gb_PageLayout";
            gb_PageLayout.Padding = new Padding(4, 3, 4, 3);
            gb_PageLayout.Size = new Size(224, 152);
            gb_PageLayout.TabIndex = 5;
            gb_PageLayout.TabStop = false;
            gb_PageLayout.Text = "تنسيق الورقه";
            gb_PageLayout.Visible = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.DodgerBlue;
            label4.Location = new Point(4, 102);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(85, 20);
            label4.TabIndex = 2;
            label4.Text = "عدد الاعمده";
            // 
            // nud_columns
            // 
            nud_columns.Cursor = Cursors.AppStarting;
            nud_columns.Location = new Point(87, 100);
            nud_columns.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            nud_columns.Name = "nud_columns";
            nud_columns.Size = new Size(102, 34);
            nud_columns.TabIndex = 2;
            nud_columns.Value = new decimal(new int[] { 2, 0, 0, 0 });
            nud_columns.ValueChanged += nud_columns_ValueChanged;
            // 
            // radioButton4
            // 
            radioButton4.AutoSize = true;
            radioButton4.Cursor = Cursors.AppStarting;
            radioButton4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            radioButton4.ForeColor = Color.DodgerBlue;
            radioButton4.Location = new Point(7, 70);
            radioButton4.Margin = new Padding(4, 3, 4, 3);
            radioButton4.Name = "radioButton4";
            radioButton4.Size = new Size(116, 24);
            radioButton4.TabIndex = 1;
            radioButton4.TabStop = true;
            radioButton4.Text = "تنسيق  شبكي";
            radioButton4.UseVisualStyleBackColor = true;
            radioButton4.CheckedChanged += radioButton4_CheckedChanged;
            // 
            // radioButton3
            // 
            radioButton3.AutoSize = true;
            radioButton3.Cursor = Cursors.AppStarting;
            radioButton3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            radioButton3.ForeColor = Color.DodgerBlue;
            radioButton3.Location = new Point(9, 40);
            radioButton3.Margin = new Padding(4, 3, 4, 3);
            radioButton3.Name = "radioButton3";
            radioButton3.Size = new Size(118, 24);
            radioButton3.TabIndex = 0;
            radioButton3.TabStop = true;
            radioButton3.Text = "تنسيق عمودي";
            radioButton3.UseVisualStyleBackColor = true;
            radioButton3.CheckedChanged += radioButton3_CheckedChanged;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.AliceBlue;
            pictureBox2.BorderStyle = BorderStyle.FixedSingle;
            pictureBox2.Image = ImageTool.Properties.Resources.photo_٢٠٢٦_٠٣_١٤_٢٣_٥٤_٣٠;
            pictureBox2.Location = new Point(1307, 560);
            pictureBox2.Margin = new Padding(4, 3, 4, 3);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(58, 59);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 13;
            pictureBox2.TabStop = false;
            // 
            // button2
            // 
            button2.BackColor = Color.MidnightBlue;
            button2.FlatStyle = FlatStyle.Flat;
            button2.ForeColor = Color.AliceBlue;
            button2.Location = new Point(1034, 625);
            button2.Name = "button2";
            button2.Size = new Size(159, 46);
            button2.TabIndex = 14;
            button2.Text = "تحديث";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // Frm_PrintOptions
            // 
            AllowDrop = true;
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.AliceBlue;
            ClientSize = new Size(1618, 683);
            Controls.Add(button2);
            Controls.Add(pictureBox2);
            Controls.Add(gb_PageLayout);
            Controls.Add(groupBox1);
            Controls.Add(flp_Perview);
            Controls.Add(label3);
            Controls.Add(comboBox2);
            Controls.Add(button1);
            Controls.Add(lb_Height);
            Controls.Add(lb_Width);
            Controls.Add(nud_Heigth);
            Controls.Add(nud_Width);
            Controls.Add(printPreviewControl1);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ForeColor = Color.Navy;
            Margin = new Padding(4, 3, 4, 3);
            Name = "Frm_PrintOptions";
            Text = "المعاينه";
            FormClosing += Frm_PrintOptions_FormClosing;
            FormClosed += Frm_PrintOptions_FormClosed;
            Load += Frm_PrintOptions_Load;
            ((System.ComponentModel.ISupportInitialize)nud_Width).EndInit();
            ((System.ComponentModel.ISupportInitialize)nud_Heigth).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            gb_PageLayout.ResumeLayout(false);
            gb_PageLayout.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nud_columns).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private PrintPreviewControl printPreviewControl1;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private PrintDialog printDialog1;
        private NumericUpDown nud_Width;
        private NumericUpDown nud_Heigth;
        private Label lb_Width;
        private Label lb_Height;
        private Button button1;
        private ComboBox comboBox2;
        private Label label3;
        private RadioButton radioButton2;
        private GroupBox groupBox1;
        private RadioButton radioButton1;
        private GroupBox gb_PageLayout;
        private RadioButton radioButton4;
        private RadioButton radioButton3;
        private Label label4;
        private NumericUpDown nud_columns;
        private PictureBox pictureBox2;
        public FlowLayoutPanel flp_Perview;
        private Button button2;
    }
}