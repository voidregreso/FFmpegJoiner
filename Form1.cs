using System;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace FFmpeg_Joiner {

    public partial class Form1 : Form
    {

        public const int WM_SYSCOMMAND = 274;
        public const int SC_MOVE = 61456;
        public const int HTCAPTION = 2;
        private const int DIR_HTLEFT = 10;
        private const int DIR_HTRIGHT = 11;
        private const int DIR_HTTOP = 12;
        private const int DIR_HTTOPLEFT = 13;
        private const int DIR_HTTOPRIGHT = 14;
        private const int DIR_HTBOTTOM = 15;
        private const int DIR_HTBOTTOMLEFT = 16;
        private const int DIR_HTBOTTOMRIGHT = 17;


        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();


        [DllImport("user32.dll")]
        public static extern bool SendMessage(IntPtr hwnd, int wMsg, int wParam, int lParam);


        protected override CreateParams CreateParams {
            get {
                CreateParams createParams = base.CreateParams;
                createParams.Style |= 131072;
                return createParams;
            }
        }

        protected override void WndProc(ref Message m) {
            if (m.Msg == 132) {
                base.WndProc(ref m);
                Point point = new Point((int)m.LParam & 65535, ((int)m.LParam >> 16) & 65535);
                point = base.PointToClient(point);
                if (point.X <= 5) {
                    if (point.Y <= 5) {
                        m.Result = (IntPtr)DIR_HTTOPLEFT;
                    } else if (point.Y >= base.ClientSize.Height - 5) {
                        m.Result = (IntPtr)DIR_HTBOTTOMLEFT;
                    } else {
                        m.Result = (IntPtr)DIR_HTLEFT;
                    }
                } else if (point.X >= base.ClientSize.Width - 5) {
                    if (point.Y <= 5) {
                        m.Result = (IntPtr)DIR_HTTOPRIGHT;
                    } else if (point.Y >= base.ClientSize.Height - 5) {
                        m.Result = (IntPtr)DIR_HTBOTTOMRIGHT;
                    } else {
                        m.Result = (IntPtr)DIR_HTRIGHT;
                    }
                } else if (point.Y <= 5) {
                    m.Result = (IntPtr)DIR_HTTOP;
                } else if (point.Y >= base.ClientSize.Height - 5) {
                    m.Result = (IntPtr)DIR_HTBOTTOM;
                }
            } else if (m.Msg == 513) {
                m.Msg = 161;
                m.LParam = IntPtr.Zero;
                m.WParam = new IntPtr(2);
                base.WndProc(ref m);
            } else {
                base.WndProc(ref m);
            }
        }

        public Form1() {
            InitializeComponent();
            Init();
        }

        private void SaveLstToTxt() {
            StreamWriter streamWriter = new StreamWriter("filelist.txt", false);
            for (int i = 0; i < filelist.Items.Count; i++) {
                streamWriter.Write("file '" + filelist.Items[i].ToString() + "'\r\n");
            }
            streamWriter.Close();
        }


        private void Clear_Click(object sender, EventArgs e) {
            filelist.Items.Clear();
        }

        private void AddFile_Click(object sender, EventArgs e) {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Multiselect = true;
            openFileDialog.Title = "Seleccione el archivo ahora";
            openFileDialog.Filter = "Videos|*.avi;*.wmv;*.wmp;*.wm;*.asf;*.mpg;*.mpeg;*.mpe;*.m1v;*.m2v;*.mpv2;*.mp2v;*.ts;*.tp;*.tpr;*.trp;*.vob;*.ifo;*.ogm;*.ogv;*.mp4;*.m4v;*.m4p;*.m4b;*.3gp;*.3gpp;*.3g2;*.3gp2;*.mkv;*.rm;*.ram;*.rmvb;*.rpm;*.flv;*.swf;*.mov;*.qt;*.amr;*.nsv;*.dpg;*.m2ts;*.m2t;*.mts;*.dvr-ms;*.k3g;*.skm;*.evo;*.nsr;*.amv;*.divx;*.webm;*.wtv;*.f4v";
            openFileDialog.FilterIndex = 1;
            openFileDialog.RestoreDirectory = true;
            if (openFileDialog.ShowDialog() == DialogResult.OK) {
                OpenPath.Text = openFileDialog.FileName.Substring(0, openFileDialog.FileName.LastIndexOf("\\"));
                foreach (string text in openFileDialog.FileNames) {
                    filelist.Items.Add(text);
                }
            }
        }


        private void FFmpeg_Join_Click(object sender, EventArgs e) {
            if (filelist.Items.Count == 0) {
                MessageBox.Show("No videos added!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                return;
            }
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Title = "Guardar en";
            saveFileDialog.InitialDirectory = OpenPath.Text;
            saveFileDialog.FileName = "Joined";
            saveFileDialog.Filter = "Matroska Video|*.mkv|MPEG-4 Video|*.mp4|MPEG-TS|*.ts|Flash video|*.flv|Quicktime Video|*.mov";
            saveFileDialog.FilterIndex = 1;
            saveFileDialog.RestoreDirectory = true;
            if (saveFileDialog.ShowDialog() == DialogResult.OK) {
                SaveLstToTxt();
                OutPath.Text = saveFileDialog.FileName;
                OutExtendName.Text = saveFileDialog.FileName.Substring(saveFileDialog.FileName.LastIndexOf(".") + 1);
                Information.Text = "";
                if (OutExtendName.Text == "mkv" || OutExtendName.Text == "mp4" || OutExtendName.Text == "mov") {
                    Command.Text = "-f concat -safe 0 -i filelist.txt -c copy -bsf:a aac_adtstoasc -threads 0 \"" + OutPath.Text + "\"";
                    RealAction("ffmpeg.exe", Command.Text);
                }
                if (OutExtendName.Text == "ts") {
                    Command.Text = "-f concat -safe 0 -i filelist.txt -c copy -f mpegts -threads 0 \"" + OutPath.Text + "\"";
                    RealAction("ffmpeg.exe", Command.Text);
                }
            }
        }


        private void Form1_Load(object sender, EventArgs e) {
            if (!File.Exists("ffmpeg.exe")) {
                MessageBox.Show("No se encontró ffmpeg.exe", "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                base.Dispose();
                Application.Exit();
            }
            if (Process.GetProcessesByName(Process.GetCurrentProcess().ProcessName).Length > 1) {
                MessageBox.Show("Ya se está ejecutando otra instancia", "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                base.Dispose();
                Application.Exit();
            }
        }

        private void Form1_ResizeEnd_1(object sender, EventArgs e) {
            if (base.Width < 945) {
                base.Width = 945;
            }
            if (base.Height < 630) {
                base.Height = 630;
            }
        }


        private void filelist_DragEnter(object sender, DragEventArgs e) {
            e.Effect = DragDropEffects.All;
        }


        private void filelist_DragOver(object sender, DragEventArgs e) {
            e.Effect = DragDropEffects.All;
        }


        private void filelist_DragDrop(object sender, DragEventArgs e) {
            if (e.Data.GetDataPresent(DataFormats.FileDrop, false)) {
                string[] array = (string[])e.Data.GetData(DataFormats.FileDrop);
                int num = array[0].LastIndexOf('.') + 1;
                string text = array[0].Substring(num);
                if (text == "m3u8" || text == "mkv" || text == "avi" || text == "mp4" || text == "ts" || text == "flv" || text == "f4v" 
                    || text == "wmv" || text == "wm" || text == "mpeg" || text == "mpg" || text == "m4v" || text == "3gp" || text == "rm" 
                    || text == "rmvb" || text == "mov" || text == "qt" || text == "m2ts" || text == "m3u" || text == "mts" || text == "txt") {
                    foreach (string text2 in (string[])e.Data.GetData(DataFormats.FileDrop)) {
                        (sender as ListBox).Items.Add(text2);
                    }
                }
            }
        }


        private void Sort_Click(object sender, EventArgs e) {
            filelist.Sorted = true;
        }


        private void button4_Click(object sender, EventArgs e) {
            base.WindowState = FormWindowState.Minimized;
        }


        private void button_MAX_Click(object sender, EventArgs e) {
            if (button_MAX.Text == "FULL") {
                base.WindowState = FormWindowState.Maximized;
                button_MAX.Text = "NORM";
                return;
            }
            if (button_MAX.Text == "NORM") {
                base.WindowState = FormWindowState.Normal;
                button_MAX.Text = "FULL";
            }
        }


        private void button_EXIT_Click(object sender, EventArgs e) {
            base.Dispose();
            Application.Exit();
        }


        private void Form1_MouseDown(object sender, MouseEventArgs e) {
            Form1.ReleaseCapture();
            Form1.SendMessage(base.Handle, 274, 61458, 0);
        }


        private void Notice1_MouseDown(object sender, MouseEventArgs e) {
            Form1.ReleaseCapture();
            Form1.SendMessage(base.Handle, 274, 61458, 0);
        }


        private void Information_TextChanged(object sender, EventArgs e) {
            if (Information.GetLineFromCharIndex(Information.TextLength) + 1 > 10) {
                Information.ScrollBars = ScrollBars.Vertical;
            }
            if (Information.GetLineFromCharIndex(Information.TextLength) + 1 <= 10) {
                Information.ScrollBars = ScrollBars.None;
            }
        }


        private void label2_MouseDown(object sender, MouseEventArgs e) {
            Form1.ReleaseCapture();
            Form1.SendMessage(base.Handle, 274, 61458, 0);
        }


        public event DelReadStdOutput ReadStdOutput;

        public event DelReadErrOutput ReadErrOutput;


        private void Init() {
            ReadStdOutput += ReadStdOutputAction;
            ReadErrOutput += ReadErrOutputAction;
        }


        private void RealAction(string StartFileName, string StartFileArg) {
            Process process = new Process();
            process.StartInfo.FileName = StartFileName;
            process.StartInfo.Arguments = StartFileArg;
            process.StartInfo.CreateNoWindow = true;
            process.StartInfo.UseShellExecute = false;
            process.StartInfo.RedirectStandardInput = true;
            process.StartInfo.RedirectStandardOutput = true;
            process.StartInfo.RedirectStandardError = true;
            process.OutputDataReceived += p_OutputDataReceived;
            process.ErrorDataReceived += p_ErrorDataReceived;
            process.EnableRaisingEvents = true;
            process.Exited += CmdProcess_Exited;
            process.Start();
            process.BeginOutputReadLine();
            process.BeginErrorReadLine();
        }


        private void p_OutputDataReceived(object sender, DataReceivedEventArgs e) {
            if (e.Data != null) {
                base.Invoke(ReadStdOutput, new object[] { e.Data });
            }
        }


        private void p_ErrorDataReceived(object sender, DataReceivedEventArgs e) {
            if (e.Data != null) {
                base.Invoke(ReadErrOutput, new object[] { e.Data });
            }
        }


        private void ReadStdOutputAction(string result) {
            Information.AppendText(result + "\r\n");
        }


        private void ReadErrOutputAction(string result) {
            Information.AppendText(result + "\r\n");
        }


        private void CmdProcess_Exited(object sender, EventArgs e) {
            MessageBox.Show("Se acabó la fusión!", "FFmpeg Joiner", MessageBoxButtons.OK, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly);
        }

        private void btnVaciar_Click(object sender, EventArgs e)
        {
            Information.Text = "Información de las salidas de FFmpeg...";
        }
    }
}
