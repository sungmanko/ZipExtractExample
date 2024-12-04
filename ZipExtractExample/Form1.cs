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
            // ファイルパス取得
            string zipPath = txtTarget1.Text;
            // 解凍先パス取得
            string extractPath = txtTarget2.Text;

            // 解凍処理
            ExtractZipFile(zipPath, extractPath);
        }

        /// <summary>
        /// 解凍処理
        /// </summary>
        /// <param name="zipPath">ZIPファイルのパス</param>
        /// <param name="extractPath">解凍先のパス</param>
        public static void ExtractZipFile(string zipPath, string extractPath)
        {
            // ファイル存在確認
            if (!File.Exists(zipPath))
            {
                MessageBox.Show("指定されたZIPファイルが存在しません。", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                // 解凍先ディレクトリが存在しない場合は作成
                if (!Directory.Exists(extractPath))
                {
                    Directory.CreateDirectory(extractPath);
                }

                // 指定されたところに解凍
                ZipFile.ExtractToDirectory(zipPath, extractPath);
                MessageBox.Show("解凍が完了しました。", "成功", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                // 例外発生時にエラーメッセージを表示
                MessageBox.Show($"解凍中にエラーが発生しました: {ex.Message}", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
