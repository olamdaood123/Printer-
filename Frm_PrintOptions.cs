using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using System.Drawing.Printing;
using System.Reflection.Emit;
using static Image.Form1;

namespace Image
{
    public partial class Frm_PrintOptions : Form
    {
        public static Frm_PrintOptions instance;
        public List<ImageOrder> ReceivedOrders { get; set; } = [];
        int currentImageIndex = 0;
        int Posy = 100;
        float TargetWidth = 8.5f;
        float TargetHeight = 5.5f;
        public Frm_PrintOptions()
        {
            InitializeComponent();
            instance = this;

        }
        private void Frm_PrintOptions_Load(object sender, EventArgs e)
        {
            flp_Perview.Controls.Clear();
            flp_Perview.AllowDrop = true; // تفعيل السحب للوحة الأم

            foreach (var order in ReceivedOrders)
            {
                // 1. إنشاء الحاوية (Panel)
                Panel pnl = new Panel();
                pnl.Size = new Size(130, 160);
                pnl.BorderStyle = BorderStyle.FixedSingle;
                pnl.AllowDrop = true;

                // 2. إنشاء الصورة
                PictureBox pic = new PictureBox();
                pic.Image = order.Photo;
                pic.SizeMode = PictureBoxSizeMode.Zoom;
                pic.Dock = DockStyle.Top;
                pic.Height = 110;

                // --- هاد هو الجزء الجديد (السر في التبديل) ---
                pic.MouseDown += (s, ev) =>
                {
                    if (ev.Button == MouseButtons.Left) pnl.DoDragDrop(pnl, DragDropEffects.Move);
                };

                pnl.DragEnter += (s, ev) => { ev.Effect = DragDropEffects.Move; };
                pnl.DragDrop += (s, ev) =>
                {
                    Panel source = (Panel)ev.Data.GetData(typeof(Panel));
                    if (source != null && source != pnl)
                    {
                        int targetIndex = flp_Perview.Controls.GetChildIndex(pnl);
                        flp_Perview.Controls.SetChildIndex(source, targetIndex);
                    }
                };
                // --------------------------------------------

                System.Windows.Forms.Label lbl = new System.Windows.Forms.Label();
                lbl.Text = "عدد النسخ : " + order.Copies.ToString();
                lbl.Dock = DockStyle.Bottom;
                lbl.TextAlign = ContentAlignment.MiddleCenter;

                pnl.Controls.Add(lbl);
                pnl.Controls.Add(pic);
                flp_Perview.Controls.Add(pnl);
            }
            printPreviewControl1.Document = printDocument1;
        }
        int imageIndex = 0;
        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            // تحسين جودة الطباعة
            e.Graphics.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;
            e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;

            // القيم الأساسية من مربعات النص (الطول والعرض)
            int val1 = (int)((float)nud_Heigth.Value * 39.37f) + 5;
            int val2 = (int)((float)nud_Width.Value * 39.37f) + 5;
            int spaceBetween = 30;

            // الحالة الأولى: الطباعة في نفس الورقة (عمودي أو شبكي)
            if (radioButton1.Checked)
            {
                int xOffSet = 50;
                int yOffSet = 50;
                int ColumnCount = 0;
                int MaxColumns = (int)nud_columns.Value;

                for (int i = imageIndex; i < ReceivedOrders.Count; i++)
                {
                    var order = ReceivedOrders[i];
                    imageIndex = i;

                    // تحديد المقاس الذكي لكل صورة (عشان ما تنضغط)
                    int currentPrintWidth, currentPrintHeight;
                    if (order.Photo.Width > order.Photo.Height)
                    {
                        // صورة أفقية
                        currentPrintWidth = Math.Max(val1, val2);
                        currentPrintHeight = Math.Min(val1, val2);
                    }
                    else
                    {
                        // صورة عمودية
                        currentPrintWidth = Math.Min(val1, val2);
                        currentPrintHeight = Math.Max(val1, val2);
                    }

                    // حلقة عدد النسخ لكل صورة
                    for (int j = 0; j < order.Copies; j++)
                    {
                        if (order.Photo != null)
                        {
                            // فحص حدود الورقة
                            if (yOffSet + currentPrintHeight > 1050)
                            {
                                e.HasMorePages = true;
                                return;
                            }

                            // رسم الصورة بالمقاس الذكي
                            e.Graphics.DrawImage(order.Photo, new Rectangle(xOffSet, yOffSet, currentPrintWidth, currentPrintHeight));

                            // التوزيع (عمودي أو شبكي)
                            if (radioButton3.Checked) // عمودي
                            {
                                yOffSet += currentPrintHeight + spaceBetween;
                            }
                            else if (radioButton4.Checked) // شبكي
                            {
                                ColumnCount++;
                                if (ColumnCount < MaxColumns && (xOffSet + (currentPrintWidth * 2) + spaceBetween) <= 800)
                                {
                                    xOffSet += currentPrintWidth + spaceBetween;
                                }
                                else
                                {
                                    xOffSet = 50;
                                    yOffSet += currentPrintHeight + spaceBetween;
                                    ColumnCount = 0;
                                }
                            }
                        }
                    }
                }
                imageIndex = 0; // تصفير عند الانتهاء من كل القائمة
            }
            // الحالة الثانية: كل صورة في ورقة منفصلة
            else if (radioButton2.Checked)
            {
                if (currentImageIndex < ReceivedOrders.Count)
                {
                    var order = ReceivedOrders[currentImageIndex];

                    // تحديد المقاس الذكي أيضاً هنا
                    int pW, pH;
                    if (order.Photo.Width > order.Photo.Height)
                    {
                        pW = Math.Max(val1, val2); pH = Math.Min(val1, val2);
                    }
                    else
                    {
                        pW = Math.Min(val1, val2); pH = Math.Max(val1, val2);
                    }

                    e.Graphics.DrawImage(order.Photo, new Rectangle(50, 50, pW, pH));

                    currentImageIndex++;
                    e.HasMorePages = (currentImageIndex < ReceivedOrders.Count);

                    if (!e.HasMorePages) { currentImageIndex = 0; }
                }
            }
        }
        private void nud_Width_ValueChanged(object sender, EventArgs e)
        {
            TargetWidth = (float)nud_Width.Value;
            printDocument1.PrintController = new StandardPrintController();
            imageIndex = 0;
            printPreviewControl1.InvalidatePreview();

        }
        private void nud_Heigth_ValueChanged(object sender, EventArgs e)
        {
            TargetHeight = (float)nud_Heigth.Value;
            printDocument1.PrintController = new StandardPrintController();
            imageIndex = 0;
            printPreviewControl1.InvalidatePreview();
        }
        void ResetOption()
        {
            nud_Width.Value = 8.5m;
            nud_Heigth.Value = 5.5m;

        }
        private void button1_Click(object sender, EventArgs e)
        {

            PrintDialog printDialog = new PrintDialog();
            printDialog.Document = printDocument1;
            if (printDialog.ShowDialog() == DialogResult.OK)
            {
                printDocument1.Print();
            }

        }
        private void Frm_PrintOptions_FormClosed(object sender, FormClosedEventArgs e)
        {
            ResetOption();
        }
        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox2.SelectedIndex == 0)
            {
                nud_Width.Value = 3.00m;
                nud_Heigth.Value = 4.00m;
            }
            else if (comboBox2.SelectedIndex == 1)
            {
                nud_Width.Value = 3.50m;
                nud_Heigth.Value = 4.50m;
            }
            else if (comboBox2.SelectedIndex == 2)
            {
                nud_Width.Value = 9.50m;
                nud_Heigth.Value = 6.20m;
            }
        }
        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            gb_PageLayout.Visible = false;
            printPreviewControl1.InvalidatePreview();
        }
        private void radioButton1_CheckedChanged_1(object sender, EventArgs e)
        {
            gb_PageLayout.Visible = radioButton1.Checked;
            printPreviewControl1.InvalidatePreview();
        }
        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            imageIndex = 0;
            printPreviewControl1.InvalidatePreview();
        }
        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            imageIndex = 0;
            printPreviewControl1.InvalidatePreview();
        }
        private void nud_columns_ValueChanged(object sender, EventArgs e)
        {
            imageIndex = 0;
            printPreviewControl1.InvalidatePreview();
        }
        private void Frm_PrintOptions_FormClosing(object sender, FormClosingEventArgs e)
        {
            imageIndex = 0;

        }
        public void EnableDragDrop()
        {
            flp_Perview.AllowDrop = true;
            flp_Perview.DragEnter += (s, e) => { e.Effect = DragDropEffects.Move; };
            flp_Perview.DragDrop += flp_Perview_DragDrop;
        }
        // 1. تصفير العدادات
        private void flp_Perview_DragDrop(object sender, DragEventArgs e)
        {
            PictureBox source = (PictureBox)e.Data.GetData(typeof(PictureBox));
            Point clientPoint = flp_Perview.PointToClient(new Point(e.X, e.Y));
            Control target = flp_Perview.GetChildAtPoint(clientPoint);

            if (source != null && target != null && source != target)
            {
                int targetIndex = flp_Perview.Controls.GetChildIndex(target);
                flp_Perview.Controls.SetChildIndex(source, targetIndex);
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {// 1. تصفير العدادات
            imageIndex = 0;
            currentImageIndex = 0;

            // 2. إعادة ترتيب القائمة بناءً على اللي قدامنا ع الشاشة
            var newList = new List<ImageOrder>();
            foreach (Control c in flp_Perview.Controls)
            {
                if (c is Panel pnl)
                {
                    var pic = pnl.Controls.OfType<PictureBox>().FirstOrDefault();
                    if (pic != null)
                    {
                        var order = ReceivedOrders.FirstOrDefault(o => o.Photo == pic.Image);
                        if (order != null) newList.Add(order);
                    }
                }
            }
            ReceivedOrders = newList;

            // 3. إجبار المعاينة على التحديث
            printPreviewControl1.Document = null;
            printPreviewControl1.Document = printDocument1;
            printPreviewControl1.InvalidatePreview();

        }
    }


}
