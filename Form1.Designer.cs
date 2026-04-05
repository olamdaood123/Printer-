namespace Image
{
    partial class Form1
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
            pictureBox1 = new PictureBox();
            btn_Print = new Button();
            openFileDialog1 = new OpenFileDialog();
            printDocument1 = new System.Drawing.Printing.PrintDocument();
            printDialog1 = new PrintDialog();
            nud_Copies = new NumericUpDown();
            label1 = new Label();
            bt_Blutooth = new Button();
            bt_WhatsApp = new Button();
            label2 = new Label();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            pictureBox4 = new PictureBox();
            btnTestConnection = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nud_Copies).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = SystemColors.ButtonHighlight;
            pictureBox1.Cursor = Cursors.AppStarting;
            pictureBox1.Location = new Point(12, 22);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(588, 405);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // btn_Print
            // 
            btn_Print.AutoSize = true;
            btn_Print.BackColor = Color.MidnightBlue;
            btn_Print.Cursor = Cursors.Hand;
            btn_Print.FlatStyle = FlatStyle.Flat;
            btn_Print.Font = new Font("Sitka Text", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_Print.ForeColor = Color.White;
            btn_Print.Location = new Point(833, 335);
            btn_Print.Name = "btn_Print";
            btn_Print.Size = new Size(116, 41);
            btn_Print.TabIndex = 1;
            btn_Print.Text = "معاينه";
            btn_Print.UseVisualStyleBackColor = false;
            btn_Print.Click += btn_Print_Click;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // printDialog1
            // 
            printDialog1.UseEXDialog = true;
            // 
            // nud_Copies
            // 
            nud_Copies.Cursor = Cursors.AppStarting;
            nud_Copies.Location = new Point(811, 80);
            nud_Copies.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            nud_Copies.Name = "nud_Copies";
            nud_Copies.Size = new Size(150, 27);
            nud_Copies.TabIndex = 2;
            nud_Copies.Value = new decimal(new int[] { 1, 0, 0, 0 });
            nud_Copies.ValueChanged += nud_Copies_ValueChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.FlatStyle = FlatStyle.Flat;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.DodgerBlue;
            label1.Location = new Point(875, 37);
            label1.Name = "label1";
            label1.Size = new Size(74, 20);
            label1.TabIndex = 3;
            label1.Text = "عدد النسخ";
            // 
            // bt_Blutooth
            // 
            bt_Blutooth.BackColor = Color.RoyalBlue;
            bt_Blutooth.Cursor = Cursors.Hand;
            bt_Blutooth.FlatStyle = FlatStyle.Flat;
            bt_Blutooth.ForeColor = Color.White;
            bt_Blutooth.Location = new Point(867, 245);
            bt_Blutooth.Name = "bt_Blutooth";
            bt_Blutooth.Size = new Size(94, 29);
            bt_Blutooth.TabIndex = 4;
            bt_Blutooth.Text = "Bluetooth";
            bt_Blutooth.UseVisualStyleBackColor = false;
            bt_Blutooth.Click += bt_Blutooth_Click;
            // 
            // bt_WhatsApp
            // 
            bt_WhatsApp.BackColor = Color.RoyalBlue;
            bt_WhatsApp.Cursor = Cursors.Hand;
            bt_WhatsApp.FlatStyle = FlatStyle.Flat;
            bt_WhatsApp.ForeColor = Color.White;
            bt_WhatsApp.Location = new Point(867, 198);
            bt_WhatsApp.Name = "bt_WhatsApp";
            bt_WhatsApp.Size = new Size(94, 29);
            bt_WhatsApp.TabIndex = 5;
            bt_WhatsApp.Text = "whatsapp";
            bt_WhatsApp.UseVisualStyleBackColor = false;
            bt_WhatsApp.Click += bt_WhatsApp_Click_1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.FlatStyle = FlatStyle.Flat;
            label2.ForeColor = Color.DodgerBlue;
            label2.Location = new Point(859, 148);
            label2.Name = "label2";
            label2.Size = new Size(102, 20);
            label2.TabIndex = 6;
            label2.Text = "استلام الملفات";
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.White;
            pictureBox2.BorderStyle = BorderStyle.Fixed3D;
            pictureBox2.Image = ImageTool.Properties.Resources.photo_٢٠٢٦_٠٣_١٤_٢٣_٥٤_٢٩;
            pictureBox2.Location = new Point(827, 198);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(34, 29);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 7;
            pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.BackColor = Color.White;
            pictureBox3.BorderStyle = BorderStyle.Fixed3D;
            pictureBox3.Image = ImageTool.Properties.Resources.photo_٢٠٢٦_٠٣_١٤_٢٣_٥٤_٣١;
            pictureBox3.Location = new Point(827, 245);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(34, 29);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 8;
            pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            pictureBox4.BackColor = Color.White;
            pictureBox4.BorderStyle = BorderStyle.Fixed3D;
            pictureBox4.Image = ImageTool.Properties.Resources.eye;
            pictureBox4.Location = new Point(782, 347);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(34, 29);
            pictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox4.TabIndex = 9;
            pictureBox4.TabStop = false;
            // 
            // btnTestConnection
            // 
            btnTestConnection.Location = new Point(627, 212);
            btnTestConnection.Name = "btnTestConnection";
            btnTestConnection.Size = new Size(94, 29);
            btnTestConnection.TabIndex = 10;
            btnTestConnection.Text = "test";
            btnTestConnection.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AllowDrop = true;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.AliceBlue;
            ClientSize = new Size(1073, 494);
            Controls.Add(btnTestConnection);
            Controls.Add(pictureBox4);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox2);
            Controls.Add(label2);
            Controls.Add(bt_WhatsApp);
            Controls.Add(bt_Blutooth);
            Controls.Add(label1);
            Controls.Add(nud_Copies);
            Controls.Add(btn_Print);
            Controls.Add(pictureBox1);
            Name = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)nud_Copies).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Button btn_Print;
        private OpenFileDialog openFileDialog1;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private PrintDialog printDialog1;
        private NumericUpDown nud_Copies;
        private Label label1;
        private Button bt_Blutooth;
        private Button bt_WhatsApp;
        private Label label2;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private PictureBox pictureBox4;
        private Button btnTestConnection;
    }
}
