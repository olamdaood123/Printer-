using OpenCvSharp;
using OpenCvSharp.Extensions;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Threading;
using System.Windows.Forms;
using Tesseract;

namespace Image
{
    public partial class Form1 : Form
    {
        List<ImageOrder> allOrders = new List<ImageOrder>();
        ImageOrder selectedOrder;

        public Form1()
        {
            InitializeComponent();
        }

        public Bitmap MakeGrayscale(Bitmap original)
        {
            Bitmap newBitmap = new Bitmap(original.Width, original.Height);
            for (int i = 0; i < original.Width; i++)
            {
                for (int j = 0; j < original.Height; j++)
                {
                    Color c = original.GetPixel(i, j);
                    int gray = (int)(c.R * 0.3 + c.G * 0.59 + c.B * 0.11);
                    newBitmap.SetPixel(i, j, Color.FromArgb(gray, gray, gray));
                }
            }
            return newBitmap;
        }


        public Bitmap AutoCropIdentity(Bitmap source)
        {
            Bitmap gray = MakeGrayscale(source);
            Color edgeColor = gray.GetPixel(0, 0);

            int left = 0, top = 0, right = source.Width - 1, bottom = source.Height - 1;

            int threshold = 80;

            // «·„”Õ „‰ «·√⁄·Ï ·≈ÌÃ«œ (Top)
            for (int y = 0; y < gray.Height; y++)
            {
                for (int x = 0; x < gray.Width; x++)
                {
                    if (Math.Abs(gray.GetPixel(x, y).R - edgeColor.R) > threshold)
                    {
                        top = y;
                        goto FoundTop;
                    }
                }
            }
        FoundTop:;

            // «·„”Õ „‰ «·√”›· ·≈ÌÃ«œ (Bottom)
            for (int y = gray.Height - 1; y >= 0; y--)
            {
                for (int x = 0; x < gray.Width; x++)
                {
                    if (Math.Abs(gray.GetPixel(x, y).R - edgeColor.R) > threshold)
                    {
                        bottom = y;
                        goto FoundBottom;
                    }
                }
            }
        FoundBottom:;
            // «·„”Õ „‰ «·Ì”«— ·≈ÌÃ«œ (Left)
            for (int x = 0; x < gray.Width; x++)
            {
                for (int y = 0; y < gray.Height; y++)
                {
                    if (Math.Abs(gray.GetPixel(x, y).R - edgeColor.R) > threshold)
                    {
                        left = x;
                        goto FoundLeft;
                    }
                }
            }
        FoundLeft:;

            // «·„”Õ „‰ «·Ì„Ì‰ ·≈ÌÃ«œ (Right)
            for (int x = gray.Width - 1; x >= 0; x--)
            {
                for (int y = 0; y < gray.Height; y++)
                {
                    if (Math.Abs(gray.GetPixel(x, y).R - edgeColor.R) > threshold)
                    {
                        right = x;
                        goto FoundRight;
                    }
                }
            }
        FoundRight:;
            // ≈‰‘«¡ „‰ÿﬁ… «·ﬁ’
            // ---  ⁄œÌ· ÌœÊÌ œﬁÌﬁ Ãœ« ---
            int leftTrim = 10;   // “ÌœÌ Â–« «·—ﬁ„ ≈–« ·”« ›Ì ·Ê‰ “Â—Ì ⁄ «·Ì”«—
            int topTrim = 6;   // Ã⁄·‰«Â (”«·») ·ﬂÌ Ì» ⁄œ ⁄‰ «·ÂÊÌ… „‰ «·√⁄·Ï Ê·« Ìﬁ’Â«
            int rightTrim = 3; // Ã⁄·‰«Â (”«·») ·ﬂÌ Ì Ê”⁄ ··Ì„Ì‰ Ê·« Ìﬁ’ «·ﬂ «»…
            int bottomTrim = 5;  // ·÷»ÿ «·„”«›… „‰ «·√”›·

            int finalX = left + leftTrim;
            int finalY = top + topTrim;
            int finalWidth = (right - left) - (leftTrim + rightTrim);
            int finalHeight = (bottom - top) - (topTrim + bottomTrim);

            // «· √ﬂœ „‰ √‰ «·„” ÿÌ· ·« ÌŒ—Ã Œ«—Ã √»⁄«œ «·’Ê—… «·√’·Ì…
            if (finalX < 0) finalX = 0;
            if (finalY < 0) finalY = 0;
            if (finalX + finalWidth > source.Width) finalWidth = source.Width - finalX;
            if (finalY + finalHeight > source.Height) finalHeight = source.Height - finalY;

            Rectangle cropArea = new Rectangle(finalX, finalY, finalWidth, finalHeight);
            return source.Clone(cropArea, source.PixelFormat);
        }


        private OpenCvSharp.Point2f[] OrderPoints(OpenCvSharp.Point2f[] pts)
        {
            var ordered = new OpenCvSharp.Point2f[4];

            var sums = pts.Select(p => p.X + p.Y).ToArray();
            var diffs = pts.Select(p => p.X - p.Y).ToArray();

            ordered[0] = pts[Array.IndexOf(sums, sums.Min())];
            ordered[2] = pts[Array.IndexOf(sums, sums.Max())];
            ordered[1] = pts[Array.IndexOf(diffs, diffs.Min())];
            ordered[3] = pts[Array.IndexOf(diffs, diffs.Max())];

            return ordered;
        }

        private double Distance(OpenCvSharp.Point2f a, OpenCvSharp.Point2f b)
        {
            double dx = a.X - b.X;
            double dy = a.Y - b.Y;
            return Math.Sqrt(dx * dx + dy * dy);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (pictureBox1.Visible)
            {
                using (OpenFileDialog ofd = new OpenFileDialog())
                {
                    ofd.Filter = "Images|*.jpg;*.jpeg;*.png;*.bmp";
                    ofd.Multiselect = true;

                    if (ofd.ShowDialog() == DialogResult.OK)
                    {
                        foreach (string fileName in ofd.FileNames)
                        {
                            Bitmap original = new Bitmap(fileName);
                            System.Drawing.Image croppedImg = AutoCropIdentity(original);

                            pictureBox1.Image = croppedImg;

                            int count = (int)nud_Copies.Value;
                            ImageOrder selectedOrder = new ImageOrder { Photo = croppedImg, Copies = count };
                            allOrders.Add(selectedOrder);

                            original.Dispose();
                        }
                    }
                }
            }
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            if (pictureBox1.Image != null)
            {
                e.Graphics.DrawImage(pictureBox1.Image, 0, 0);
            }
        }

        private void btn_Print_Click(object sender, EventArgs e)
        {
            if (allOrders.Count == 0)
            {
                MessageBox.Show("Ì—ÃÏ «Œ Ì«— «·’Ê—Â «Ê·«", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Frm_PrintOptions frm = new Frm_PrintOptions();
            frm.ReceivedOrders = allOrders;
            frm.ShowDialog();
            pictureBox1.Image = null;
        }

        private void LoadImageFromPath(string path)
        {
            try
            {
                if (Directory.Exists(path))
                {
                    string[] files = Directory.GetFiles(path)
                        .Where(s => s.EndsWith(".jpg") || s.EndsWith(".png") || s.EndsWith(".jpeg")).ToArray();

                    if (files.Length > 0)
                        pictureBox1.Image = System.Drawing.Image.FromFile(files[0]);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Œÿ√ ›Ì  Õ„Ì· «·’Ê—…: " + ex.Message);
            }
        }

        private void bt_Blutooth_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("fsquirt.exe");

            Thread.Sleep(10000);
            Application.DoEvents();

            string docsPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);

            var directoryInfo = new DirectoryInfo(docsPath);
            var targetDir = directoryInfo.GetDirectories("*bluetooth*").FirstOrDefault();

            if (targetDir != null)
                LoadImageFromPath(targetDir.FullName);
            else
                LoadImageFromPath(docsPath);
        }

        private void bt_WhatsApp_Click_1(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo
            {
                FileName = "https://web.whatsapp.com",
                UseShellExecute = true
            });

            Thread.Sleep(5000);
            Application.DoEvents();

            string path = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile) + @"\Downloads";
            LoadImageFromPath(path);
        }

        private void nud_Copies_ValueChanged(object sender, EventArgs e)
        {
            if (selectedOrder != null)
            {
                selectedOrder.Copies = (int)nud_Copies.Value;
            }

            Application.DoEvents();
        }

        public class ImageOrder
        {
            public System.Drawing.Image Photo { get; set; }
            public int Copies { get; set; }
        }
    }
}