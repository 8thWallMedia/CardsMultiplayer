namespace CardsMultiplayer
{
    partial class Game
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.registerPanel = new System.Windows.Forms.Panel();
            this.pictureBox11 = new System.Windows.Forms.PictureBox();
            this.REGISTER_Email = new System.Windows.Forms.RichTextBox();
            this.pictureBox10 = new System.Windows.Forms.PictureBox();
            this.label8 = new System.Windows.Forms.Label();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.label7 = new System.Windows.Forms.Label();
            this.REGISTER_MessagePanel = new System.Windows.Forms.Panel();
            this.REGISTER_Label = new System.Windows.Forms.Label();
            this.Register_USERNAME = new System.Windows.Forms.RichTextBox();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.pictureBox8 = new System.Windows.Forms.PictureBox();
            this.pictureBox9 = new System.Windows.Forms.PictureBox();
            this.label6 = new System.Windows.Forms.Label();
            this.developerOutput = new System.Windows.Forms.RichTextBox();
            this.authenticationPanel = new System.Windows.Forms.Panel();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.errorPanel = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.RichTextBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.LoginThreadTimer = new System.Windows.Forms.Timer(this.components);
            this.REGISTER_Password2 = new CardsMultiplayer.RichPassword();
            this.REGISTER_Password = new CardsMultiplayer.RichPassword();
            this.textBox2 = new CardsMultiplayer.RichPassword();
            this.panel1.SuspendLayout();
            this.registerPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            this.REGISTER_MessagePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).BeginInit();
            this.authenticationPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            this.errorPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.registerPanel);
            this.panel1.Controls.Add(this.developerOutput);
            this.panel1.Controls.Add(this.authenticationPanel);
            this.panel1.Controls.Add(this.pictureBox4);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1623, 915);
            this.panel1.TabIndex = 0;
            // 
            // registerPanel
            // 
            this.registerPanel.Controls.Add(this.pictureBox11);
            this.registerPanel.Controls.Add(this.REGISTER_Email);
            this.registerPanel.Controls.Add(this.pictureBox10);
            this.registerPanel.Controls.Add(this.label8);
            this.registerPanel.Controls.Add(this.REGISTER_Password2);
            this.registerPanel.Controls.Add(this.pictureBox6);
            this.registerPanel.Controls.Add(this.label7);
            this.registerPanel.Controls.Add(this.REGISTER_Password);
            this.registerPanel.Controls.Add(this.REGISTER_MessagePanel);
            this.registerPanel.Controls.Add(this.Register_USERNAME);
            this.registerPanel.Controls.Add(this.pictureBox7);
            this.registerPanel.Controls.Add(this.label5);
            this.registerPanel.Controls.Add(this.pictureBox8);
            this.registerPanel.Controls.Add(this.pictureBox9);
            this.registerPanel.Controls.Add(this.label6);
            this.registerPanel.Location = new System.Drawing.Point(3, 125);
            this.registerPanel.Name = "registerPanel";
            this.registerPanel.Size = new System.Drawing.Size(750, 485);
            this.registerPanel.TabIndex = 15;
            this.registerPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // pictureBox11
            // 
            this.pictureBox11.Cursor = System.Windows.Forms.Cursors.Default;
            this.pictureBox11.Image = global::CardsMultiplayer.Properties.Resources.BackButton;
            this.pictureBox11.Location = new System.Drawing.Point(10, 419);
            this.pictureBox11.Name = "pictureBox11";
            this.pictureBox11.Size = new System.Drawing.Size(179, 55);
            this.pictureBox11.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox11.TabIndex = 20;
            this.pictureBox11.TabStop = false;
            this.pictureBox11.Click += new System.EventHandler(this.pictureBox11_Click);
            this.pictureBox11.MouseEnter += new System.EventHandler(this.pictureBox11_MouseEnter);
            this.pictureBox11.MouseLeave += new System.EventHandler(this.pictureBox11_MouseLeave);
            // 
            // REGISTER_Email
            // 
            this.REGISTER_Email.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.REGISTER_Email.Cursor = System.Windows.Forms.Cursors.Default;
            this.REGISTER_Email.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.REGISTER_Email.ForeColor = System.Drawing.SystemColors.WindowText;
            this.REGISTER_Email.Location = new System.Drawing.Point(18, 371);
            this.REGISTER_Email.MaxLength = 25;
            this.REGISTER_Email.Multiline = false;
            this.REGISTER_Email.Name = "REGISTER_Email";
            this.REGISTER_Email.Size = new System.Drawing.Size(716, 23);
            this.REGISTER_Email.TabIndex = 19;
            this.REGISTER_Email.Text = "";
            // 
            // pictureBox10
            // 
            this.pictureBox10.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox10.Image = global::CardsMultiplayer.Properties.Resources.RoundedRec;
            this.pictureBox10.Location = new System.Drawing.Point(10, 359);
            this.pictureBox10.Name = "pictureBox10";
            this.pictureBox10.Size = new System.Drawing.Size(737, 47);
            this.pictureBox10.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox10.TabIndex = 17;
            this.pictureBox10.TabStop = false;
            this.pictureBox10.Click += new System.EventHandler(this.pictureBox10_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Monotype Corsiva", 21.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(4, 322);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(164, 36);
            this.label8.TabIndex = 18;
            this.label8.Text = "Email Address";
            // 
            // pictureBox6
            // 
            this.pictureBox6.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox6.Image = global::CardsMultiplayer.Properties.Resources.RoundedRec;
            this.pictureBox6.Location = new System.Drawing.Point(9, 272);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(738, 47);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox6.TabIndex = 14;
            this.pictureBox6.TabStop = false;
            this.pictureBox6.Click += new System.EventHandler(this.pictureBox6_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Monotype Corsiva", 21.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(4, 233);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(203, 36);
            this.label7.TabIndex = 15;
            this.label7.Text = "Confirm Password";
            // 
            // REGISTER_MessagePanel
            // 
            this.REGISTER_MessagePanel.Controls.Add(this.REGISTER_Label);
            this.REGISTER_MessagePanel.Location = new System.Drawing.Point(9, 4);
            this.REGISTER_MessagePanel.Name = "REGISTER_MessagePanel";
            this.REGISTER_MessagePanel.Size = new System.Drawing.Size(738, 41);
            this.REGISTER_MessagePanel.TabIndex = 11;
            // 
            // REGISTER_Label
            // 
            this.REGISTER_Label.AutoSize = true;
            this.REGISTER_Label.BackColor = System.Drawing.Color.Transparent;
            this.REGISTER_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.REGISTER_Label.ForeColor = System.Drawing.Color.White;
            this.REGISTER_Label.Location = new System.Drawing.Point(4, 11);
            this.REGISTER_Label.Name = "REGISTER_Label";
            this.REGISTER_Label.Size = new System.Drawing.Size(248, 20);
            this.REGISTER_Label.TabIndex = 12;
            this.REGISTER_Label.Text = "Please complete the details below";
            this.REGISTER_Label.Visible = false;
            // 
            // Register_USERNAME
            // 
            this.Register_USERNAME.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Register_USERNAME.Cursor = System.Windows.Forms.Cursors.Default;
            this.Register_USERNAME.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Register_USERNAME.ForeColor = System.Drawing.SystemColors.WindowText;
            this.Register_USERNAME.Location = new System.Drawing.Point(17, 106);
            this.Register_USERNAME.MaxLength = 25;
            this.Register_USERNAME.Multiline = false;
            this.Register_USERNAME.Name = "Register_USERNAME";
            this.Register_USERNAME.Size = new System.Drawing.Size(717, 23);
            this.Register_USERNAME.TabIndex = 9;
            this.Register_USERNAME.Text = "";
            // 
            // pictureBox7
            // 
            this.pictureBox7.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox7.Image = global::CardsMultiplayer.Properties.Resources.RoundedRec;
            this.pictureBox7.Location = new System.Drawing.Point(9, 94);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(738, 47);
            this.pictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox7.TabIndex = 2;
            this.pictureBox7.TabStop = false;
            this.pictureBox7.Click += new System.EventHandler(this.pictureBox7_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Monotype Corsiva", 21.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(3, 57);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(116, 36);
            this.label5.TabIndex = 3;
            this.label5.Text = "Username";
            // 
            // pictureBox8
            // 
            this.pictureBox8.Cursor = System.Windows.Forms.Cursors.Default;
            this.pictureBox8.Image = global::CardsMultiplayer.Properties.Resources.RegisterButton;
            this.pictureBox8.Location = new System.Drawing.Point(555, 419);
            this.pictureBox8.Name = "pictureBox8";
            this.pictureBox8.Size = new System.Drawing.Size(179, 55);
            this.pictureBox8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox8.TabIndex = 8;
            this.pictureBox8.TabStop = false;
            this.pictureBox8.Click += new System.EventHandler(this.pictureBox8_Click);
            this.pictureBox8.MouseEnter += new System.EventHandler(this.pictureBox8_MouseEnter);
            this.pictureBox8.MouseLeave += new System.EventHandler(this.pictureBox8_MouseLeave);
            // 
            // pictureBox9
            // 
            this.pictureBox9.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox9.Image = global::CardsMultiplayer.Properties.Resources.RoundedRec;
            this.pictureBox9.Location = new System.Drawing.Point(9, 183);
            this.pictureBox9.Name = "pictureBox9";
            this.pictureBox9.Size = new System.Drawing.Size(738, 47);
            this.pictureBox9.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox9.TabIndex = 5;
            this.pictureBox9.TabStop = false;
            this.pictureBox9.Click += new System.EventHandler(this.pictureBox9_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Monotype Corsiva", 21.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(4, 144);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(115, 36);
            this.label6.TabIndex = 6;
            this.label6.Text = "Password";
            // 
            // developerOutput
            // 
            this.developerOutput.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.developerOutput.BackColor = System.Drawing.Color.Black;
            this.developerOutput.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.developerOutput.Location = new System.Drawing.Point(1044, 731);
            this.developerOutput.Name = "developerOutput";
            this.developerOutput.ReadOnly = true;
            this.developerOutput.Size = new System.Drawing.Size(576, 181);
            this.developerOutput.TabIndex = 12;
            this.developerOutput.Text = "Developer Console\n_____________________________________________________\n";
            // 
            // authenticationPanel
            // 
            this.authenticationPanel.Controls.Add(this.pictureBox5);
            this.authenticationPanel.Controls.Add(this.textBox2);
            this.authenticationPanel.Controls.Add(this.errorPanel);
            this.authenticationPanel.Controls.Add(this.textBox1);
            this.authenticationPanel.Controls.Add(this.pictureBox2);
            this.authenticationPanel.Controls.Add(this.label1);
            this.authenticationPanel.Controls.Add(this.pictureBox1);
            this.authenticationPanel.Controls.Add(this.pictureBox3);
            this.authenticationPanel.Controls.Add(this.label2);
            this.authenticationPanel.Location = new System.Drawing.Point(759, 182);
            this.authenticationPanel.Name = "authenticationPanel";
            this.authenticationPanel.Size = new System.Drawing.Size(511, 372);
            this.authenticationPanel.TabIndex = 11;
            this.authenticationPanel.VisibleChanged += new System.EventHandler(this.authenticationPanel_VisibleChanged);
            this.authenticationPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.authenticationPanel_Paint);
            // 
            // pictureBox5
            // 
            this.pictureBox5.Cursor = System.Windows.Forms.Cursors.Default;
            this.pictureBox5.Image = global::CardsMultiplayer.Properties.Resources.LoginButton;
            this.pictureBox5.Location = new System.Drawing.Point(9, 304);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(179, 55);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox5.TabIndex = 14;
            this.pictureBox5.TabStop = false;
            this.pictureBox5.Click += new System.EventHandler(this.pictureBox5_Click);
            this.pictureBox5.MouseEnter += new System.EventHandler(this.pictureBox5_MouseEnter);
            this.pictureBox5.MouseLeave += new System.EventHandler(this.pictureBox5_MouseLeave);
            // 
            // errorPanel
            // 
            this.errorPanel.Controls.Add(this.label3);
            this.errorPanel.Location = new System.Drawing.Point(9, 4);
            this.errorPanel.Name = "errorPanel";
            this.errorPanel.Size = new System.Drawing.Size(492, 41);
            this.errorPanel.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(4, 11);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(223, 20);
            this.label3.TabIndex = 12;
            this.label3.Text = "Invalid Username or Password";
            this.label3.Visible = false;
            // 
            // textBox1
            // 
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Cursor = System.Windows.Forms.Cursors.Default;
            this.textBox1.Font = new System.Drawing.Font("Lucida Sans Unicode", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.ForeColor = System.Drawing.SystemColors.WindowText;
            this.textBox1.Location = new System.Drawing.Point(17, 106);
            this.textBox1.MaxLength = 25;
            this.textBox1.Multiline = false;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(469, 35);
            this.textBox1.TabIndex = 9;
            this.textBox1.Text = "";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = global::CardsMultiplayer.Properties.Resources.RoundedRec;
            this.pictureBox2.Location = new System.Drawing.Point(9, 94);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(492, 58);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Monotype Corsiva", 21.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(3, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 36);
            this.label1.TabIndex = 3;
            this.label1.Text = "Username";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Default;
            this.pictureBox1.Image = global::CardsMultiplayer.Properties.Resources.RegisterButton;
            this.pictureBox1.Location = new System.Drawing.Point(322, 304);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(179, 55);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            this.pictureBox1.MouseEnter += new System.EventHandler(this.pictureBox1_MouseEnter);
            this.pictureBox1.MouseLeave += new System.EventHandler(this.pictureBox1_MouseLeave);
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.Image = global::CardsMultiplayer.Properties.Resources.RoundedRec;
            this.pictureBox3.Location = new System.Drawing.Point(9, 240);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(492, 58);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 5;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Monotype Corsiva", 21.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(3, 202);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 36);
            this.label2.TabIndex = 6;
            this.label2.Text = "Password";
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox4.Location = new System.Drawing.Point(3, 3);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(692, 116);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 7;
            this.pictureBox4.TabStop = false;
            // 
            // LoginThreadTimer
            // 
            this.LoginThreadTimer.Tick += new System.EventHandler(this.LoginThreadTimer_Tick);
            // 
            // REGISTER_Password2
            // 
            this.REGISTER_Password2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.REGISTER_Password2.Cursor = System.Windows.Forms.Cursors.Default;
            this.REGISTER_Password2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.REGISTER_Password2.Location = new System.Drawing.Point(17, 284);
            this.REGISTER_Password2.MaxLength = 40;
            this.REGISTER_Password2.Multiline = false;
            this.REGISTER_Password2.Name = "REGISTER_Password2";
            this.REGISTER_Password2.ShortcutsEnabled = false;
            this.REGISTER_Password2.Size = new System.Drawing.Size(717, 24);
            this.REGISTER_Password2.TabIndex = 16;
            this.REGISTER_Password2.Text = "";
            // 
            // REGISTER_Password
            // 
            this.REGISTER_Password.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.REGISTER_Password.Cursor = System.Windows.Forms.Cursors.Default;
            this.REGISTER_Password.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.REGISTER_Password.Location = new System.Drawing.Point(17, 195);
            this.REGISTER_Password.MaxLength = 40;
            this.REGISTER_Password.Multiline = false;
            this.REGISTER_Password.Name = "REGISTER_Password";
            this.REGISTER_Password.ShortcutsEnabled = false;
            this.REGISTER_Password.Size = new System.Drawing.Size(717, 24);
            this.REGISTER_Password.TabIndex = 13;
            this.REGISTER_Password.Text = "";
            // 
            // textBox2
            // 
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox2.Cursor = System.Windows.Forms.Cursors.Default;
            this.textBox2.Font = new System.Drawing.Font("Lucida Sans Unicode", 20F, System.Drawing.FontStyle.Italic);
            this.textBox2.Location = new System.Drawing.Point(17, 252);
            this.textBox2.MaxLength = 40;
            this.textBox2.Multiline = false;
            this.textBox2.Name = "textBox2";
            this.textBox2.ShortcutsEnabled = false;
            this.textBox2.Size = new System.Drawing.Size(469, 35);
            this.textBox2.TabIndex = 13;
            this.textBox2.Text = "";
            // 
            // Game
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1647, 939);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Game";
            this.ShowIcon = false;
            this.Text = "MagicOnline Game Window";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Game_FormClosing);
            this.Load += new System.EventHandler(this.Game_Load);
            this.panel1.ResumeLayout(false);
            this.registerPanel.ResumeLayout(false);
            this.registerPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            this.REGISTER_MessagePanel.ResumeLayout(false);
            this.REGISTER_MessagePanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).EndInit();
            this.authenticationPanel.ResumeLayout(false);
            this.authenticationPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            this.errorPanel.ResumeLayout(false);
            this.errorPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.RichTextBox textBox1;
        private System.Windows.Forms.Panel authenticationPanel;
        private System.Windows.Forms.Panel errorPanel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RichTextBox developerOutput;
        private RichPassword textBox2;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.Panel registerPanel;
        private System.Windows.Forms.RichTextBox REGISTER_Email;
        private System.Windows.Forms.PictureBox pictureBox10;
        private System.Windows.Forms.Label label8;
        private RichPassword REGISTER_Password2;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.Label label7;
        private RichPassword REGISTER_Password;
        private System.Windows.Forms.Panel REGISTER_MessagePanel;
        private System.Windows.Forms.Label REGISTER_Label;
        private System.Windows.Forms.RichTextBox Register_USERNAME;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pictureBox8;
        private System.Windows.Forms.PictureBox pictureBox9;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox pictureBox11;
        private System.Windows.Forms.Timer LoginThreadTimer;
    }
}