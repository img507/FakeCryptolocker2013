using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cryptolocker_clone
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            InitializeListView();
            LoadFilesFromDesktop();
        }

        private void InitializeListView()
        {
            listView1.View = View.Details;
            listView1.Columns.Add("Name", 450);
            listView1.Columns.Add("Location", 485);
            listView1.FullRowSelect = true;

            listView1.SmallImageList = imageList1;
            imageList1.ImageSize = new Size(16, 16);
        }
        private void LoadFilesFromDesktop()
        {
            string desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            string[] files = Directory.GetFiles(desktopPath);

            imageList1.Images.Clear();

            foreach (var file in files)
            {
                FileInfo fileInfo = new FileInfo(file);
                string fileName = fileInfo.Name;
                string fileLocation = fileInfo.FullName;

                Icon fileIcon = GetFileIcon(file);
                imageList1.Images.Add(fileIcon);

                ListViewItem item = new ListViewItem(fileName, imageList1.Images.Count - 1);
                item.SubItems.Add(fileLocation);
                listView1.Items.Add(item);
            }
        }

        private Icon GetFileIcon(string filePath)
        {
            SHFileInfo shinfo = new SHFileInfo();
            const int SHGFI_ICON = 0x100;
            const int SHGFI_SMALLICON = 0x000000000;
            uint flags = SHGFI_ICON | SHGFI_SMALLICON;
            SHGetFileInfo(filePath, 0, out shinfo, (uint)Marshal.SizeOf(typeof(SHFileInfo)), flags);
            Icon icon = Icon.FromHandle(shinfo.hIcon);
            return icon;
        }

        [StructLayout(LayoutKind.Sequential)]
        private struct SHFileInfo
        {
            public IntPtr hIcon;
            public int iIcon;
            public uint dwAttributes;
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 260)]
            public string szDisplayName;
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 80)]
            public string szTypeName;
        }

        [DllImport("shell32.dll", CharSet = CharSet.Auto)]
        private static extern uint SHGetFileInfo(string pszPath, uint dwFileAttributes, out SHFileInfo pSHFileInfo, uint cbFileInfo, uint uFlags);
    }
}
