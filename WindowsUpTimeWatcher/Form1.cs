using System;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;

namespace WindowsUpTimeWatcher
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            // 特殊ディレクトリ(スタートアップ)のパスを取得する
            string StartupDirPath = Environment.GetFolderPath(Environment.SpecialFolder.Startup);
            string StartupExePath = Path.Combine(StartupDirPath, Path.GetFileName(Application.ExecutablePath));
            // exeファイルへのパス
            string ExeFilePath = Application.ExecutablePath;

            // コピー
            if (ExeFilePath != StartupExePath)
            {
                File.Copy(ExeFilePath, StartupExePath, true);
            }

            Debug.WriteLine(StartupExePath);
            Debug.WriteLine(ExeFilePath);

            // アプリの起動時間
            int mSec = System.Environment.TickCount & int.MaxValue; // ミリ病
            int second = mSec / 1000;
            TimeSpan ts = new TimeSpan(0, 0, second);
            label_AppUptime.Text = ts.ToString();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            int mSec = System.Environment.TickCount & int.MaxValue; // ミリ病

            int second = mSec / 1000;

            TimeSpan ts = new TimeSpan(0, 0, second);

            label_WindowsUptime.Text = ts.ToString();

        }
    }
}
