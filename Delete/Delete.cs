using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Delete
{

    public partial class Delete : Form
    {
        public Delete()
        {
            InitializeComponent();
        }

        // 按钮
        private void btnDelete_Click(object sender, EventArgs e)
        {
            // 获取路径
            string str = txtPath.Text;
            str.Replace("\\", "/");
            if (str.Equals(""))
            {
                MessageBox.Show("路径不能为空！", "提示");
            }
            else if (str.Equals("Q:\\") || str.Equals("W:\\") || str.Equals("E:\\") || str.Equals("R:\\") || str.Equals("T:\\") || str.Equals("Y:\\") || str.Equals("U:\\") || str.Equals("I:\\") || str.Equals("O:\\") || str.Equals("P:\\")|| str.Equals("A:\\") || str.Equals("S:\\") || str.Equals("D:\\") || str.Equals("G:\\") || str.Equals("H:\\")|| str.Equals("J:\\") || str.Equals("K:\\") || str.Equals("L:\\") || str.Equals("Z:\\") || str.Equals("X:\\")|| str.Equals("C:\\") || str.Equals("C:\\") || str.Equals("V:\\") || str.Equals("B:\\") || str.Equals("N:\\")|| str.Equals("M:\\"))
            {
                MessageBox.Show("路径不能为盘符！", "提示");
            }
            else
            {
                getPath(str);
            }
        }

        // 窗体加载事件
        private void Main_Load(object sender, EventArgs e)
        {

        }
        // 浏览
        private void btnLL_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog f = new FolderBrowserDialog();
            if (f.ShowDialog() == DialogResult.OK)
            {
                String DirPath = f.SelectedPath;
                this.txtPath.Text = DirPath;//G:\新建文件夹
            }
        }

        static List<string> list = new List<string>();//定义list变量
        public List<string> getPath(string path)
        {
            // 获取子目录
            DirectoryInfo dir = new DirectoryInfo(path);
            FileInfo[] fil = dir.GetFiles();
            DirectoryInfo[] dii = dir.GetDirectories();
            foreach (FileInfo f in fil)
            {
                list.Add(f.FullName);//添加文件的路径到列表
            }
            //获取子文件夹内的文件列表，递归遍历
            foreach (DirectoryInfo d in dii)
            {
                getPath(d.FullName);
                list.Add(d.FullName);//添加文件夹的路径到列表
            }

            // 删除空目录
            /// 删除掉空文件夹
            /// 所有没有子“文件系统”的都将被删除
            DirectoryInfo[] subdirs = dir.GetDirectories("*.*", SearchOption.AllDirectories);
            foreach (DirectoryInfo subdir in subdirs)
            {
                FileSystemInfo[] subFiles = subdir.GetFileSystemInfos();
                if (subFiles.Count() == 0)
                {
                    subdir.Delete();
                }
            }
            
            return list;
        }
    }
}
