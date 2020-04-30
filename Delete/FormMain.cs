using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Delete
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }
        [DllImport("user32.dll")]//取设备场景 
        private static extern IntPtr GetDC(IntPtr hwnd);//返回设备场景句柄 
        [DllImport("gdi32.dll")]//取指定点颜色 
        private static extern int GetPixel(IntPtr hdc, Point p);



        // 单击乐特
        private void lete_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://lete114.github.io/");
        }
        // 窗体加载事件
        private void LeteTools_Load(object sender, EventArgs e)
        {
            this.tm.Enabled = true;
            this.tm.Interval = 1;//timer控件的执行频率
        }

        //计时器
        private void tm_Tick(object sender, EventArgs e)
        {
            // 计时器
            Timer tim = new Timer();
            tim.Interval = 1;
            tim.Tick += delegate
            {
                //获取RGB鼠标当前位置颜色
                Point p = new Point(MousePosition.X, MousePosition.Y);//取置顶点坐标 
                IntPtr hdc = GetDC(new IntPtr(0));//取到设备场景(0就是全屏的设备场景) 
                int c = GetPixel(hdc, p);//取指定点颜色 
                int r = (c & 0xFF);//转换R 
                int g = (c & 0xFF00) / 256;//转换G 
                int b = (c & 0xFF0000) / 65536;//转换B 
                //RGB.BackColor = Color.FromArgb(r, g, b);
                lblR255.Text = r.ToString();
                lblG255.Text = g.ToString();
                lblB255.Text = b.ToString();


                // 用主类实例化，调用convertRGBToHex方法，传入RGB
                FormMain lt = new FormMain();
                lblVHEX.Text = lt.convertRGBToHex(r, g, b);

                // 鼠标坐标
                //方法1：
                //lblVX.Text = Cursor.Position.X.ToString();
                //lblVY.Text = Cursor.Position.Y.ToString();
                //方法2：
                lblVX.Text = Control.MousePosition.X.ToString();
                lblVY.Text = Control.MousePosition.Y.ToString();

            };
            tim.Start();

        }


        // 计算HEX值
        public String convertRGBToHex(int r, int g, int b)
        {
            String rFString, rSString, gFString, gSString, bFString, bSString, result;
            int red, green, blue;
            int rred, rgreen, rblue;
            red = r / 16;
            rred = r % 16;
            if (red == 10) rFString = "A";
            else if (red == 11) rFString = "B";
            else if (red == 12) rFString = "C";
            else if (red == 13) rFString = "D";
            else if (red == 14) rFString = "E";
            else if (red == 15) rFString = "F";
            else rFString = red.ToString();

            if (rred == 10) rSString = "A";
            else if (rred == 11) rSString = "B";
            else if (rred == 12) rSString = "C";
            else if (rred == 13) rSString = "D";
            else if (rred == 14) rSString = "E";
            else if (rred == 15) rSString = "F";
            else rSString = rred.ToString();

            rFString = rFString + rSString;

            green = g / 16;
            rgreen = g % 16;

            if (green == 10) gFString = "A";
            else if (green == 11) gFString = "B";
            else if (green == 12) gFString = "C";
            else if (green == 13) gFString = "D";
            else if (green == 14) gFString = "E";
            else if (green == 15) gFString = "F";
            else gFString = green.ToString();

            if (rgreen == 10) gSString = "A";
            else if (rgreen == 11) gSString = "B";
            else if (rgreen == 12) gSString = "C";
            else if (rgreen == 13) gSString = "D";
            else if (rgreen == 14) gSString = "E";
            else if (rgreen == 15) gSString = "F";
            else gSString = rgreen.ToString();

            gFString = gFString + gSString;

            blue = b / 16;
            rblue = b % 16;

            if (blue == 10) bFString = "A";
            else if (blue == 11) bFString = "B";
            else if (blue == 12) bFString = "C";
            else if (blue == 13) bFString = "D";
            else if (blue == 14) bFString = "E";
            else if (blue == 15) bFString = "F";
            else bFString = blue.ToString();

            if (rblue == 10) bSString = "A";
            else if (rblue == 11) bSString = "B";
            else if (rblue == 12) bSString = "C";
            else if (rblue == 13) bSString = "D";
            else if (rblue == 14) bSString = "E";
            else if (rblue == 15) bSString = "F";
            else bSString = rblue.ToString();
            bFString = bFString + bSString;
            result = "#" + rFString + gFString + bFString;
            return result;

        }

        // 进入删除窗体
        private void Zhu_Click(object sender, EventArgs e)
        {
            Delete m = new Delete();
            m.Show();
        }
    }
}
