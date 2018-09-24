using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Задание2
{
    public partial class Form1 : Form
    {
        Graphics g;
        Bitmap curBmp, origBmp;
        int dH, dS, dV;
        Rectangle rect;
        byte[] rgbValues;

        delegate void Funcdelegate(byte R, byte G, byte B, out byte R2, out byte G2, out byte B2);

            
        public Form1()
        {
            InitializeComponent();
            curBmp = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            pictureBox1.Image = curBmp;
            g = Graphics.FromImage(curBmp);
            g.FillRectangle(new SolidBrush(Color.White), 0, 0, pictureBox1.Width, pictureBox1.Height);
            rect = new Rectangle(0, 0, curBmp.Width, curBmp.Height);
            textBox1.Text = "30";
            textBox2.Text = "0";
            textBox3.Text = "0";
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                pictureBox1.Image.Save(saveFileDialog1.FileName, System.Drawing.Imaging.ImageFormat.Bmp);
        }
        private void openBtn_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                curBmp = new Bitmap(Image.FromFile(openFileDialog1.FileName, true), new Size(pictureBox1.Width, pictureBox1.Height));
                pictureBox1.Image = curBmp;
                origBmp = curBmp.Clone(rect, System.Drawing.Imaging.PixelFormat.Format24bppRgb);
                pictureBox1.Invalidate();
            }
        }

        private void restoreBtn_Click(object sender, EventArgs e)
        {
            curBmp = origBmp.Clone(rect, System.Drawing.Imaging.PixelFormat.Format24bppRgb);
            pictureBox1.Image = curBmp;
            pictureBox1.Invalidate();
        }

        private void ChangePic(Funcdelegate function, bool restore = true)
        {
            if (pictureBox1.Image == null)
            {
                MessageBox.Show("Необходимо открыть изображение!");
                return;
            }
            if (restore)
            {
                curBmp = origBmp.Clone(rect, System.Drawing.Imaging.PixelFormat.Format24bppRgb);
                pictureBox1.Image = curBmp;
            }
            rect = new Rectangle(0, 0, curBmp.Width, curBmp.Height);
            System.Drawing.Imaging.BitmapData bmpData = curBmp.LockBits(rect, System.Drawing.Imaging.ImageLockMode.ReadWrite, curBmp.PixelFormat);
            IntPtr ptr = bmpData.Scan0;
            int bytes = Math.Abs(bmpData.Stride) * curBmp.Height;
            rgbValues = new byte[bytes];
            System.Runtime.InteropServices.Marshal.Copy(ptr, rgbValues, 0, bytes);
            for (int i = 0; i < rgbValues.Length - 3; i += 3)
            {
                byte R, G, B;
                function(rgbValues[i + 2], rgbValues[i + 1], rgbValues[i], out R, out G, out B);
                rgbValues[i + 2] = R;
                rgbValues[i + 1] = G;
                rgbValues[i] = B;
            }
            System.Runtime.InteropServices.Marshal.Copy(rgbValues, 0, ptr, bytes);
            curBmp.UnlockBits(bmpData);

            pictureBox1.Invalidate();
        }

        private void getEqGrey(byte R, byte G, byte B, out byte R2, out byte G2, out byte B2)
        {
            byte eqVal = Convert.ToByte((B + G + R) / 3);
            R2 = G2 = B2 = eqVal; 
        }
        private void getDifGrey(byte R, byte G, byte B, out byte R2, out byte G2, out byte B2)
        {
            byte difVal = Convert.ToByte(B * 0.2126 + G * 0.7152 + R * 0.0722);
            R2 = G2 = B2 = difVal;
        }
        private void getEqDifGrey(byte R, byte G, byte B, out byte R2, out byte G2, out byte B2)
        {
            byte eqVal = Convert.ToByte((B + G + R) / 3);
            byte difVal = Convert.ToByte(B * 0.2126 + G * 0.7152 + R * 0.0722);
            R2 = G2 = B2 = Convert.ToByte(Math.Abs(difVal - eqVal));
        }
        private void eqGreyBtn_Click(object sender, EventArgs e)
        {
            ChangePic(getEqGrey);
        }
        private void difGreyBtn_Click(object sender, EventArgs e)
        {
            ChangePic(getDifGrey);
        }

        private void eqDifGreyBtn_Click(object sender, EventArgs e)
        {
            ChangePic(getEqDifGrey);
        }
              
        private void redBtn_Click(object sender, EventArgs e)
        {
            ChangePic(getRChannel);
        }

        private void greenBtn_Click(object sender, EventArgs e)
        {
            ChangePic(getGChannel);
        }

        private void blueBtn_Click(object sender, EventArgs e)
        {
            ChangePic(getBChannel);
        }

        private void getRChannel(byte R, byte G, byte B, out byte R2, out byte G2, out byte B2)
        {
            R2 = R;
            G2 = 0;
            B2 = 0;
        }

        private void getGChannel(byte R, byte G, byte B, out byte R2, out byte G2, out byte B2)
        {
            R2 = 0;
            G2 = G;
            B2 = 0;
        }

        private void getBChannel(byte R, byte G, byte B, out byte R2, out byte G2, out byte B2)
        {
            R2 = 0;
            G2 = 0;
            B2 = B;
        }

     
        private void RGBToHSV(byte R, byte G, byte B, out double hue, out double saturation, out double value)
        {
            int max = Math.Max(R, Math.Max(G, B));
            int min = Math.Min(R, Math.Min(G, B));
            if (max == min)
                hue = 0;
            else if (max == R && G >= B)
                hue = 60 * (G - B) / (max - min);
            else if (max == R && G < B)
                hue = 60 * (G - B) / (max - min) + 360;
            else if (max == G)
                hue = 60 * (B - R) / (max - min) + 120;
            else
                hue = 60 * (R - G) / (max - min) + 240;

            saturation = (max == 0) ? 0 : (1 - (min / (double)max)) * 100;
            value = max / (double)255 * 100;
        }

        private void HSVToRGB(double h, double s, double v, out byte R, out byte G, out byte B)
        {
            double vMin, a, vInc, vDec;
            int hi;
            hi = Convert.ToInt32(Math.Floor(h / 60)) % 6;
            vMin = (100 - s) * v / 100;
            a = (v - vMin) * (h % 60) / 60;
            vInc = (vMin + a) * 2.55;
            vDec = (v - a) * 2.55;
            v *= 2.55;
            vMin *= 2.55;

            vMin = (int)Math.Floor(vMin);
            vInc = (int)Math.Floor(vInc);
            vDec = (int)Math.Floor(vDec);
            v = (int)Math.Floor(v);
            switch (hi)
            {
                case 0:
                    R = Convert.ToByte(v);
                    G = Convert.ToByte(vInc);
                    B = Convert.ToByte(vMin);
                    break;
                case 1:
                    R = Convert.ToByte(vDec);
                    G = Convert.ToByte(v);
                    B = Convert.ToByte(vMin);
                    break;
                case 2:
                    R = Convert.ToByte(vMin);
                    G = Convert.ToByte(v);
                    B = Convert.ToByte(vInc);
                    break;
                case 3:
                    R = Convert.ToByte(vMin);
                    G = Convert.ToByte(vDec);
                    B = Convert.ToByte(v);
                    break;
                case 4:
                    R = Convert.ToByte(vInc);
                    G = Convert.ToByte(vMin);
                    B = Convert.ToByte(v);
                    break;
                case 5:
                    R = Convert.ToByte(v);
                    G = Convert.ToByte(vMin);
                    B = Convert.ToByte(vDec);
                    break;
                default:
                    throw new Exception("wrong hi");
            }
        }

        private void hsvBtn_Click(object sender, EventArgs e)
        {
            bool f = (Int32.TryParse(textBox1.Text, out dH) & Int32.TryParse(textBox2.Text, out dS) & Int32.TryParse(textBox3.Text, out dV));
            if (f & (dH >= 0 & dH <= 360) & (dS >= 0 & dS <= 100) & (dV >= 0 & dV <= 100))
                ChangePic(HSV, false);
            else
                MessageBox.Show("Некорректные параметры для HSV");
        }
            
        private void HSV(byte R, byte G, byte B, out byte R2, out byte G2, out byte B2)
        {

            double H, S, V;
            H = S = V = 0;
            RGBToHSV(R, G, B, out H, out S, out V);

            double H2, S2, V2;
            H2 = H + dH;
            S2 = S + dV;
            V2 = V + dS;
            H2 = (H2 > 360) ? H2 - 360 : H2;
            S2 = (S2 > 100) ? S2 - 100 : S2;
            V2 = (V2 > 100) ? V2 - 100 : V2;

            HSVToRGB(H2, S2, V2, out R2, out G2, out B2);
        }

       
    }
}
