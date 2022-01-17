
namespace API_Cracker
{
    partial class Main
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.guna2AnimateWindow1 = new Guna.UI2.WinForms.Guna2AnimateWindow(this.components);
            this.guna2BorderlessForm1 = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
            this.guna2ControlBox2 = new Guna.UI2.WinForms.Guna2ControlBox();
            this.guna2ControlBox1 = new Guna.UI2.WinForms.Guna2ControlBox();
            this.targetTB = new Guna.UI2.WinForms.Guna2TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.unameTB = new Guna.UI2.WinForms.Guna2TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.passTB = new Guna.UI2.WinForms.Guna2TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.jsonTB = new Guna.UI2.WinForms.Guna2TextBox();
            this.unameBtn = new Guna.UI2.WinForms.Guna2Button();
            this.passBtn = new Guna.UI2.WinForms.Guna2Button();
            this.startBtn = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Separator1 = new Guna.UI2.WinForms.Guna2Separator();
            this.label5 = new System.Windows.Forms.Label();
            this.guna2Separator2 = new Guna.UI2.WinForms.Guna2Separator();
            this.pUname = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.pHits = new System.Windows.Forms.Label();
            this.pElapsed = new System.Windows.Forms.Label();
            this.pTotalProgress = new System.Windows.Forms.Label();
            this.pThisProgress = new System.Windows.Forms.Label();
            this.pPass = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // guna2AnimateWindow1
            // 
            this.guna2AnimateWindow1.AnimationType = Guna.UI2.WinForms.Guna2AnimateWindow.AnimateWindowType.AW_SLIDE;
            this.guna2AnimateWindow1.TargetForm = this;
            // 
            // guna2BorderlessForm1
            // 
            this.guna2BorderlessForm1.AnimateWindow = true;
            this.guna2BorderlessForm1.AnimationInterval = 250;
            this.guna2BorderlessForm1.BorderRadius = 5;
            this.guna2BorderlessForm1.ContainerControl = this;
            this.guna2BorderlessForm1.DockIndicatorTransparencyValue = 0.6D;
            this.guna2BorderlessForm1.ResizeForm = false;
            this.guna2BorderlessForm1.TransparentWhileDrag = true;
            // 
            // guna2ControlBox2
            // 
            this.guna2ControlBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2ControlBox2.BackColor = System.Drawing.Color.Transparent;
            this.guna2ControlBox2.ControlBoxType = Guna.UI2.WinForms.Enums.ControlBoxType.MinimizeBox;
            this.guna2ControlBox2.FillColor = System.Drawing.Color.Transparent;
            this.guna2ControlBox2.HoverState.Parent = this.guna2ControlBox2;
            this.guna2ControlBox2.IconColor = System.Drawing.Color.DarkOrange;
            this.guna2ControlBox2.Location = new System.Drawing.Point(397, 0);
            this.guna2ControlBox2.Name = "guna2ControlBox2";
            this.guna2ControlBox2.ShadowDecoration.Parent = this.guna2ControlBox2;
            this.guna2ControlBox2.Size = new System.Drawing.Size(45, 29);
            this.guna2ControlBox2.TabIndex = 1;
            // 
            // guna2ControlBox1
            // 
            this.guna2ControlBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2ControlBox1.BackColor = System.Drawing.Color.Transparent;
            this.guna2ControlBox1.FillColor = System.Drawing.Color.Transparent;
            this.guna2ControlBox1.HoverState.Parent = this.guna2ControlBox1;
            this.guna2ControlBox1.IconColor = System.Drawing.Color.DarkOrange;
            this.guna2ControlBox1.Location = new System.Drawing.Point(442, 0);
            this.guna2ControlBox1.Name = "guna2ControlBox1";
            this.guna2ControlBox1.ShadowDecoration.Parent = this.guna2ControlBox1;
            this.guna2ControlBox1.Size = new System.Drawing.Size(45, 29);
            this.guna2ControlBox1.TabIndex = 0;
            // 
            // targetTB
            // 
            this.targetTB.BorderColor = System.Drawing.Color.DarkOrange;
            this.targetTB.BorderRadius = 2;
            this.targetTB.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.targetTB.DefaultText = "https://api.connectedcity.pl/account/sign-in";
            this.targetTB.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.targetTB.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.targetTB.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.targetTB.DisabledState.Parent = this.targetTB;
            this.targetTB.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.targetTB.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.targetTB.FocusedState.BorderColor = System.Drawing.Color.Orange;
            this.targetTB.FocusedState.Parent = this.targetTB;
            this.targetTB.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.targetTB.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.targetTB.HoverState.BorderColor = System.Drawing.Color.Orange;
            this.targetTB.HoverState.Parent = this.targetTB;
            this.targetTB.Location = new System.Drawing.Point(24, 65);
            this.targetTB.Name = "targetTB";
            this.targetTB.Padding = new System.Windows.Forms.Padding(5);
            this.targetTB.PasswordChar = '\0';
            this.targetTB.PlaceholderText = "";
            this.targetTB.SelectedText = "";
            this.targetTB.ShadowDecoration.Parent = this.targetTB;
            this.targetTB.Size = new System.Drawing.Size(433, 36);
            this.targetTB.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.Color.BurlyWood;
            this.label1.Location = new System.Drawing.Point(25, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 18);
            this.label1.TabIndex = 2;
            this.label1.Text = "Target login url:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.ForeColor = System.Drawing.Color.BurlyWood;
            this.label2.Location = new System.Drawing.Point(25, 116);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 18);
            this.label2.TabIndex = 4;
            this.label2.Text = "Username or wordlist:";
            // 
            // unameTB
            // 
            this.unameTB.BorderColor = System.Drawing.Color.DarkOrange;
            this.unameTB.BorderRadius = 2;
            this.unameTB.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.unameTB.DefaultText = "crackhead@pipe.com";
            this.unameTB.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.unameTB.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.unameTB.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.unameTB.DisabledState.Parent = this.unameTB;
            this.unameTB.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.unameTB.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.unameTB.FocusedState.BorderColor = System.Drawing.Color.Orange;
            this.unameTB.FocusedState.Parent = this.unameTB;
            this.unameTB.Font = new System.Drawing.Font("Segoe UI Semibold", 8.75F, System.Drawing.FontStyle.Bold);
            this.unameTB.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.unameTB.HoverState.BorderColor = System.Drawing.Color.Orange;
            this.unameTB.HoverState.Parent = this.unameTB;
            this.unameTB.Location = new System.Drawing.Point(24, 137);
            this.unameTB.Name = "unameTB";
            this.unameTB.Padding = new System.Windows.Forms.Padding(4);
            this.unameTB.PasswordChar = '\0';
            this.unameTB.PlaceholderText = "";
            this.unameTB.SelectedText = "";
            this.unameTB.ShadowDecoration.Parent = this.unameTB;
            this.unameTB.Size = new System.Drawing.Size(353, 32);
            this.unameTB.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.ForeColor = System.Drawing.Color.BurlyWood;
            this.label3.Location = new System.Drawing.Point(25, 182);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(126, 18);
            this.label3.TabIndex = 7;
            this.label3.Text = "Password or wordlist:";
            // 
            // passTB
            // 
            this.passTB.BorderColor = System.Drawing.Color.DarkOrange;
            this.passTB.BorderRadius = 2;
            this.passTB.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.passTB.DefaultText = "E:\\Wordlists\\test.txt";
            this.passTB.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.passTB.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.passTB.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.passTB.DisabledState.Parent = this.passTB;
            this.passTB.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.passTB.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.passTB.FocusedState.BorderColor = System.Drawing.Color.Orange;
            this.passTB.FocusedState.Parent = this.passTB;
            this.passTB.Font = new System.Drawing.Font("Segoe UI Semibold", 8.75F, System.Drawing.FontStyle.Bold);
            this.passTB.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.passTB.HoverState.BorderColor = System.Drawing.Color.Orange;
            this.passTB.HoverState.Parent = this.passTB;
            this.passTB.Location = new System.Drawing.Point(24, 203);
            this.passTB.Name = "passTB";
            this.passTB.Padding = new System.Windows.Forms.Padding(4);
            this.passTB.PasswordChar = '\0';
            this.passTB.PlaceholderText = "";
            this.passTB.SelectedText = "";
            this.passTB.ShadowDecoration.Parent = this.passTB;
            this.passTB.Size = new System.Drawing.Size(353, 32);
            this.passTB.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.ForeColor = System.Drawing.Color.BurlyWood;
            this.label4.Location = new System.Drawing.Point(25, 248);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(300, 18);
            this.label4.TabIndex = 10;
            this.label4.Text = "JSON Body (Username = {UNAME}, Password = {PASS})";
            // 
            // jsonTB
            // 
            this.jsonTB.BorderColor = System.Drawing.Color.DarkOrange;
            this.jsonTB.BorderRadius = 2;
            this.jsonTB.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.jsonTB.DefaultText = "{\r\n  \"email\": \"{UNAME}\",\r\n  \"password\": \"{PASS}\"\r\n}";
            this.jsonTB.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.jsonTB.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.jsonTB.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.jsonTB.DisabledState.Parent = this.jsonTB;
            this.jsonTB.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.jsonTB.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.jsonTB.FocusedState.BorderColor = System.Drawing.Color.Orange;
            this.jsonTB.FocusedState.Parent = this.jsonTB;
            this.jsonTB.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.jsonTB.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.jsonTB.HoverState.BorderColor = System.Drawing.Color.Orange;
            this.jsonTB.HoverState.Parent = this.jsonTB;
            this.jsonTB.Location = new System.Drawing.Point(28, 269);
            this.jsonTB.Multiline = true;
            this.jsonTB.Name = "jsonTB";
            this.jsonTB.Padding = new System.Windows.Forms.Padding(4);
            this.jsonTB.PasswordChar = '\0';
            this.jsonTB.PlaceholderText = "";
            this.jsonTB.SelectedText = "";
            this.jsonTB.ShadowDecoration.Parent = this.jsonTB;
            this.jsonTB.Size = new System.Drawing.Size(429, 146);
            this.jsonTB.TabIndex = 9;
            // 
            // unameBtn
            // 
            this.unameBtn.Animated = true;
            this.unameBtn.AnimatedGIF = true;
            this.unameBtn.BorderRadius = 2;
            this.unameBtn.CheckedState.Parent = this.unameBtn;
            this.unameBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.unameBtn.CustomImages.Parent = this.unameBtn;
            this.unameBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.unameBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.unameBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.unameBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.unameBtn.DisabledState.Parent = this.unameBtn;
            this.unameBtn.FillColor = System.Drawing.Color.OrangeRed;
            this.unameBtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.unameBtn.ForeColor = System.Drawing.Color.White;
            this.unameBtn.HoverState.Parent = this.unameBtn;
            this.unameBtn.Location = new System.Drawing.Point(383, 137);
            this.unameBtn.Name = "unameBtn";
            this.unameBtn.ShadowDecoration.Parent = this.unameBtn;
            this.unameBtn.Size = new System.Drawing.Size(74, 32);
            this.unameBtn.TabIndex = 11;
            this.unameBtn.Text = "Browse...";
            this.unameBtn.Click += new System.EventHandler(this.unameBtn_Click);
            // 
            // passBtn
            // 
            this.passBtn.Animated = true;
            this.passBtn.AnimatedGIF = true;
            this.passBtn.BorderRadius = 2;
            this.passBtn.CheckedState.Parent = this.passBtn;
            this.passBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.passBtn.CustomImages.Parent = this.passBtn;
            this.passBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.passBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.passBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.passBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.passBtn.DisabledState.Parent = this.passBtn;
            this.passBtn.FillColor = System.Drawing.Color.OrangeRed;
            this.passBtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.passBtn.ForeColor = System.Drawing.Color.White;
            this.passBtn.HoverState.Parent = this.passBtn;
            this.passBtn.Location = new System.Drawing.Point(383, 203);
            this.passBtn.Name = "passBtn";
            this.passBtn.ShadowDecoration.Parent = this.passBtn;
            this.passBtn.Size = new System.Drawing.Size(74, 32);
            this.passBtn.TabIndex = 12;
            this.passBtn.Text = "Browse...";
            this.passBtn.Click += new System.EventHandler(this.passBtn_Click);
            // 
            // startBtn
            // 
            this.startBtn.Animated = true;
            this.startBtn.AnimatedGIF = true;
            this.startBtn.BorderRadius = 2;
            this.startBtn.CheckedState.Parent = this.startBtn;
            this.startBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.startBtn.CustomImages.Parent = this.startBtn;
            this.startBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.startBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.startBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.startBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.startBtn.DisabledState.Parent = this.startBtn;
            this.startBtn.FillColor = System.Drawing.Color.OrangeRed;
            this.startBtn.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.startBtn.ForeColor = System.Drawing.Color.White;
            this.startBtn.HoverState.Parent = this.startBtn;
            this.startBtn.Location = new System.Drawing.Point(28, 436);
            this.startBtn.Name = "startBtn";
            this.startBtn.ShadowDecoration.Parent = this.startBtn;
            this.startBtn.Size = new System.Drawing.Size(429, 47);
            this.startBtn.TabIndex = 13;
            this.startBtn.Text = "START";
            this.startBtn.Click += new System.EventHandler(this.startBtn_Click);
            // 
            // guna2Separator1
            // 
            this.guna2Separator1.FillColor = System.Drawing.Color.DarkOrange;
            this.guna2Separator1.Location = new System.Drawing.Point(24, 515);
            this.guna2Separator1.Name = "guna2Separator1";
            this.guna2Separator1.Size = new System.Drawing.Size(173, 10);
            this.guna2Separator1.TabIndex = 14;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.DarkOrange;
            this.label5.Location = new System.Drawing.Point(208, 512);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "PROGRESS";
            // 
            // guna2Separator2
            // 
            this.guna2Separator2.FillColor = System.Drawing.Color.DarkOrange;
            this.guna2Separator2.Location = new System.Drawing.Point(284, 515);
            this.guna2Separator2.Name = "guna2Separator2";
            this.guna2Separator2.Size = new System.Drawing.Size(173, 10);
            this.guna2Separator2.TabIndex = 16;
            // 
            // pUname
            // 
            this.pUname.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.pUname.AutoSize = true;
            this.pUname.Font = new System.Drawing.Font("Trebuchet MS", 11F);
            this.pUname.ForeColor = System.Drawing.Color.BurlyWood;
            this.pUname.Location = new System.Drawing.Point(3, 10);
            this.pUname.Name = "pUname";
            this.pUname.Size = new System.Drawing.Size(123, 20);
            this.pUname.TabIndex = 17;
            this.pUname.Text = "Username: (0/0)";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.pHits, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.pElapsed, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.pTotalProgress, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.pThisProgress, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.pPass, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.pUname, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(24, 543);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 37F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(433, 119);
            this.tableLayoutPanel1.TabIndex = 18;
            // 
            // pHits
            // 
            this.pHits.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.pHits.AutoSize = true;
            this.pHits.Font = new System.Drawing.Font("Trebuchet MS", 11F);
            this.pHits.ForeColor = System.Drawing.Color.BurlyWood;
            this.pHits.Location = new System.Drawing.Point(3, 90);
            this.pHits.Name = "pHits";
            this.pHits.Size = new System.Drawing.Size(54, 20);
            this.pHits.TabIndex = 22;
            this.pHits.Text = "Hits: 0";
            // 
            // pElapsed
            // 
            this.pElapsed.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.pElapsed.AutoSize = true;
            this.pElapsed.Font = new System.Drawing.Font("Trebuchet MS", 11F);
            this.pElapsed.ForeColor = System.Drawing.Color.BurlyWood;
            this.pElapsed.Location = new System.Drawing.Point(301, 90);
            this.pElapsed.Name = "pElapsed";
            this.pElapsed.Size = new System.Drawing.Size(129, 20);
            this.pElapsed.TabIndex = 21;
            this.pElapsed.Text = "Elapsed: 00:00:00";
            // 
            // pTotalProgress
            // 
            this.pTotalProgress.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.pTotalProgress.AutoSize = true;
            this.pTotalProgress.Font = new System.Drawing.Font("Trebuchet MS", 11F);
            this.pTotalProgress.ForeColor = System.Drawing.Color.BurlyWood;
            this.pTotalProgress.Location = new System.Drawing.Point(300, 51);
            this.pTotalProgress.Name = "pTotalProgress";
            this.pTotalProgress.Size = new System.Drawing.Size(130, 20);
            this.pTotalProgress.TabIndex = 20;
            this.pTotalProgress.Text = "Total progress: 0%";
            // 
            // pThisProgress
            // 
            this.pThisProgress.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.pThisProgress.AutoSize = true;
            this.pThisProgress.Font = new System.Drawing.Font("Trebuchet MS", 11F);
            this.pThisProgress.ForeColor = System.Drawing.Color.BurlyWood;
            this.pThisProgress.Location = new System.Drawing.Point(3, 51);
            this.pThisProgress.Name = "pThisProgress";
            this.pThisProgress.Size = new System.Drawing.Size(125, 20);
            this.pThisProgress.TabIndex = 19;
            this.pThisProgress.Text = "This progress: 0%";
            // 
            // pPass
            // 
            this.pPass.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.pPass.AutoSize = true;
            this.pPass.Font = new System.Drawing.Font("Trebuchet MS", 11F);
            this.pPass.ForeColor = System.Drawing.Color.BurlyWood;
            this.pPass.Location = new System.Drawing.Point(314, 10);
            this.pPass.Name = "pPass";
            this.pPass.Size = new System.Drawing.Size(116, 20);
            this.pPass.TabIndex = 18;
            this.pPass.Text = "Password: (0/0)";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.ClientSize = new System.Drawing.Size(487, 674);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.guna2Separator2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.guna2Separator1);
            this.Controls.Add(this.startBtn);
            this.Controls.Add(this.passBtn);
            this.Controls.Add(this.unameBtn);
            this.Controls.Add(this.guna2ControlBox2);
            this.Controls.Add(this.guna2ControlBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.jsonTB);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.passTB);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.unameTB);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.targetTB);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Location = new System.Drawing.Point(800, 100);
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "API Cracker by HERME$";
            this.Load += new System.EventHandler(this.Main_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2AnimateWindow guna2AnimateWindow1;
        private Guna.UI2.WinForms.Guna2BorderlessForm guna2BorderlessForm1;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox2;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox1;
        private Guna.UI2.WinForms.Guna2TextBox targetTB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2TextBox passTB;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2TextBox unameTB;
        private System.Windows.Forms.Label label4;
        private Guna.UI2.WinForms.Guna2TextBox jsonTB;
        private Guna.UI2.WinForms.Guna2Button unameBtn;
        private Guna.UI2.WinForms.Guna2Button passBtn;
        private Guna.UI2.WinForms.Guna2Button startBtn;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label pTotalProgress;
        private System.Windows.Forms.Label pThisProgress;
        private System.Windows.Forms.Label pPass;
        private System.Windows.Forms.Label pUname;
        private Guna.UI2.WinForms.Guna2Separator guna2Separator2;
        private System.Windows.Forms.Label label5;
        private Guna.UI2.WinForms.Guna2Separator guna2Separator1;
        private System.Windows.Forms.Label pElapsed;
        private System.Windows.Forms.Label pHits;
    }
}

