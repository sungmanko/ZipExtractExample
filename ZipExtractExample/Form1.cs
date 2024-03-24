using System;
using System.IO;
using System.IO.Compression;
using System.Windows.Forms;

namespace ZipExtractExample
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 圧縮解凍
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnTarget2_Click(object sender, EventArgs e)
        {
            string zipPath = txtTarget1.Text;
            string extractPath = txtTarget2.Text;

            ExtractZipFile(zipPath, extractPath);
        }

        /// <summary>
        /// 解凍処理
        /// </summary>
        /// <param name="zipPath"></param>
        /// <param name="extractPath"></param>
        public static void ExtractZipFile(string zipPath, string extractPath)
        {
            // ファイル存在確認
            if (!File.Exists(zipPath))
            {
                return;
            }

            try
            {
                // 指定されたところに解凍
                ZipFile.ExtractToDirectory(zipPath, extractPath);
            }
            catch (Exception ex)
            {
                // 例外
            }
        }
    }
}
