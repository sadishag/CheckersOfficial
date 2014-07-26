namespace WindowsFormsApplication1
{
    //using
    partial class boardForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(boardForm));
            this.lblMessage = new System.Windows.Forms.Label();
            this.lblWhite = new System.Windows.Forms.Label();
            this.lblBlack = new System.Windows.Forms.Label();
            this.grpBox = new System.Windows.Forms.GroupBox();
            this.chkKing = new System.Windows.Forms.CheckBox();
            this.btnRemove = new System.Windows.Forms.RadioButton();
            this.btnBlack = new System.Windows.Forms.RadioButton();
            this.btnWhite = new System.Windows.Forms.RadioButton();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.startToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.restartToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.customToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.resignButton = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.button2 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.button13 = new System.Windows.Forms.Button();
            this.button15 = new System.Windows.Forms.Button();
            this.button18 = new System.Windows.Forms.Button();
            this.button20 = new System.Windows.Forms.Button();
            this.button22 = new System.Windows.Forms.Button();
            this.button24 = new System.Windows.Forms.Button();
            this.button25 = new System.Windows.Forms.Button();
            this.button27 = new System.Windows.Forms.Button();
            this.button29 = new System.Windows.Forms.Button();
            this.button31 = new System.Windows.Forms.Button();
            this.button41 = new System.Windows.Forms.Button();
            this.button57 = new System.Windows.Forms.Button();
            this.button34 = new System.Windows.Forms.Button();
            this.button50 = new System.Windows.Forms.Button();
            this.button43 = new System.Windows.Forms.Button();
            this.button59 = new System.Windows.Forms.Button();
            this.button36 = new System.Windows.Forms.Button();
            this.button52 = new System.Windows.Forms.Button();
            this.button45 = new System.Windows.Forms.Button();
            this.button61 = new System.Windows.Forms.Button();
            this.button38 = new System.Windows.Forms.Button();
            this.button54 = new System.Windows.Forms.Button();
            this.button47 = new System.Windows.Forms.Button();
            this.button63 = new System.Windows.Forms.Button();
            this.button40 = new System.Windows.Forms.Button();
            this.button56 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.computerBox = new System.Windows.Forms.PictureBox();
            this.speechBox = new System.Windows.Forms.Label();
            this.lblComputerMessage = new System.Windows.Forms.Label();
            this.grpBox.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.computerBox)).BeginInit();
            this.SuspendLayout();
            // 
            // lblMessage
            // 
            this.lblMessage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblMessage.BackColor = System.Drawing.Color.Transparent;
            this.lblMessage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblMessage.Font = new System.Drawing.Font("Courier New", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMessage.Location = new System.Drawing.Point(561, 47);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(431, 196);
            this.lblMessage.TabIndex = 8;
            this.lblMessage.Text = "Message";
            this.lblMessage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblWhite
            // 
            this.lblWhite.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblWhite.AutoSize = true;
            this.lblWhite.BackColor = System.Drawing.Color.Transparent;
            this.lblWhite.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWhite.Location = new System.Drawing.Point(573, 318);
            this.lblWhite.Name = "lblWhite";
            this.lblWhite.Size = new System.Drawing.Size(55, 20);
            this.lblWhite.TabIndex = 9;
            this.lblWhite.Text = "White";
            // 
            // lblBlack
            // 
            this.lblBlack.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblBlack.AutoSize = true;
            this.lblBlack.BackColor = System.Drawing.Color.Transparent;
            this.lblBlack.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lblBlack.Location = new System.Drawing.Point(573, 262);
            this.lblBlack.Name = "lblBlack";
            this.lblBlack.Size = new System.Drawing.Size(53, 20);
            this.lblBlack.TabIndex = 10;
            this.lblBlack.Text = "Black";
            // 
            // grpBox
            // 
            this.grpBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.grpBox.BackColor = System.Drawing.Color.Transparent;
            this.grpBox.Controls.Add(this.chkKing);
            this.grpBox.Controls.Add(this.btnRemove);
            this.grpBox.Controls.Add(this.btnBlack);
            this.grpBox.Controls.Add(this.btnWhite);
            this.grpBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpBox.Location = new System.Drawing.Point(561, 386);
            this.grpBox.Name = "grpBox";
            this.grpBox.Size = new System.Drawing.Size(152, 150);
            this.grpBox.TabIndex = 11;
            this.grpBox.TabStop = false;
            this.grpBox.Text = "Choose Piece";
            // 
            // chkKing
            // 
            this.chkKing.AutoSize = true;
            this.chkKing.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkKing.Location = new System.Drawing.Point(83, 77);
            this.chkKing.Name = "chkKing";
            this.chkKing.Size = new System.Drawing.Size(63, 24);
            this.chkKing.TabIndex = 3;
            this.chkKing.Text = "King";
            this.chkKing.UseVisualStyleBackColor = true;
            // 
            // btnRemove
            // 
            this.btnRemove.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRemove.AutoSize = true;
            this.btnRemove.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemove.Location = new System.Drawing.Point(6, 117);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(92, 24);
            this.btnRemove.TabIndex = 2;
            this.btnRemove.TabStop = true;
            this.btnRemove.Text = "Remove";
            this.btnRemove.UseVisualStyleBackColor = true;
            // 
            // btnBlack
            // 
            this.btnBlack.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBlack.AutoSize = true;
            this.btnBlack.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBlack.Location = new System.Drawing.Point(6, 76);
            this.btnBlack.Name = "btnBlack";
            this.btnBlack.Size = new System.Drawing.Size(71, 24);
            this.btnBlack.TabIndex = 1;
            this.btnBlack.TabStop = true;
            this.btnBlack.Text = "Black";
            this.btnBlack.UseVisualStyleBackColor = true;
            // 
            // btnWhite
            // 
            this.btnWhite.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnWhite.AutoSize = true;
            this.btnWhite.Checked = true;
            this.btnWhite.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnWhite.Location = new System.Drawing.Point(6, 37);
            this.btnWhite.Name = "btnWhite";
            this.btnWhite.Size = new System.Drawing.Size(73, 24);
            this.btnWhite.TabIndex = 0;
            this.btnWhite.TabStop = true;
            this.btnWhite.Text = "White";
            this.btnWhite.UseVisualStyleBackColor = true;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Transparent;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.gameToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1015, 24);
            this.menuStrip1.TabIndex = 12;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveToolStripMenuItem,
            this.loadToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // loadToolStripMenuItem
            // 
            this.loadToolStripMenuItem.Name = "loadToolStripMenuItem";
            this.loadToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
            this.loadToolStripMenuItem.Text = "Load";
            this.loadToolStripMenuItem.Click += new System.EventHandler(this.loadToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // gameToolStripMenuItem
            // 
            this.gameToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.startToolStripMenuItem,
            this.restartToolStripMenuItem,
            this.customToolStripMenuItem});
            this.gameToolStripMenuItem.Name = "gameToolStripMenuItem";
            this.gameToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.gameToolStripMenuItem.Text = "Game";
            // 
            // startToolStripMenuItem
            // 
            this.startToolStripMenuItem.Name = "startToolStripMenuItem";
            this.startToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.startToolStripMenuItem.Text = "Start";
            this.startToolStripMenuItem.Click += new System.EventHandler(this.startToolStripMenuItem_Click);
            // 
            // restartToolStripMenuItem
            // 
            this.restartToolStripMenuItem.Name = "restartToolStripMenuItem";
            this.restartToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.restartToolStripMenuItem.Text = "Restart";
            this.restartToolStripMenuItem.Click += new System.EventHandler(this.restartToolStripMenuItem_Click);
            // 
            // customToolStripMenuItem
            // 
            this.customToolStripMenuItem.Name = "customToolStripMenuItem";
            this.customToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.customToolStripMenuItem.Text = "Custom";
            this.customToolStripMenuItem.Click += new System.EventHandler(this.customToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // resignButton
            // 
            this.resignButton.Location = new System.Drawing.Point(561, 549);
            this.resignButton.Name = "resignButton";
            this.resignButton.Size = new System.Drawing.Size(128, 34);
            this.resignButton.TabIndex = 14;
            this.resignButton.Text = "Resign";
            this.resignButton.UseVisualStyleBackColor = true;
            this.resignButton.Click += new System.EventHandler(this.resignButton_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoSize = true;
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel1.BackgroundImage = global::WindowsFormsApplication1.Properties.Resources.Checker_Board1;
            this.tableLayoutPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tableLayoutPanel1.ColumnCount = 8;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tableLayoutPanel1.Controls.Add(this.button2, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.button4, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.button6, 5, 0);
            this.tableLayoutPanel1.Controls.Add(this.button8, 7, 0);
            this.tableLayoutPanel1.Controls.Add(this.button9, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.button11, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.button13, 4, 1);
            this.tableLayoutPanel1.Controls.Add(this.button15, 6, 1);
            this.tableLayoutPanel1.Controls.Add(this.button18, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.button20, 3, 2);
            this.tableLayoutPanel1.Controls.Add(this.button22, 5, 2);
            this.tableLayoutPanel1.Controls.Add(this.button24, 7, 2);
            this.tableLayoutPanel1.Controls.Add(this.button25, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.button27, 2, 3);
            this.tableLayoutPanel1.Controls.Add(this.button29, 4, 3);
            this.tableLayoutPanel1.Controls.Add(this.button31, 6, 3);
            this.tableLayoutPanel1.Controls.Add(this.button41, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.button57, 0, 7);
            this.tableLayoutPanel1.Controls.Add(this.button34, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.button50, 1, 6);
            this.tableLayoutPanel1.Controls.Add(this.button43, 2, 5);
            this.tableLayoutPanel1.Controls.Add(this.button59, 2, 7);
            this.tableLayoutPanel1.Controls.Add(this.button36, 3, 4);
            this.tableLayoutPanel1.Controls.Add(this.button52, 3, 6);
            this.tableLayoutPanel1.Controls.Add(this.button45, 4, 5);
            this.tableLayoutPanel1.Controls.Add(this.button61, 4, 7);
            this.tableLayoutPanel1.Controls.Add(this.button38, 5, 4);
            this.tableLayoutPanel1.Controls.Add(this.button54, 5, 6);
            this.tableLayoutPanel1.Controls.Add(this.button47, 6, 5);
            this.tableLayoutPanel1.Controls.Add(this.button63, 6, 7);
            this.tableLayoutPanel1.Controls.Add(this.button40, 7, 4);
            this.tableLayoutPanel1.Controls.Add(this.button56, 7, 6);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(59, 72);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 8;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(450, 464);
            this.tableLayoutPanel1.TabIndex = 0;
            this.tableLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel1_Paint);
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.button2.BackColor = System.Drawing.Color.Transparent;
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(59, 3);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(50, 52);
            this.button2.TabIndex = 1;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.squareClick);
            // 
            // button4
            // 
            this.button4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.button4.BackColor = System.Drawing.Color.Transparent;
            this.button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Location = new System.Drawing.Point(171, 3);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(50, 52);
            this.button4.TabIndex = 3;
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.squareClick);
            // 
            // button6
            // 
            this.button6.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.button6.BackColor = System.Drawing.Color.Transparent;
            this.button6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button6.FlatAppearance.BorderSize = 0;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.Location = new System.Drawing.Point(283, 3);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(50, 52);
            this.button6.TabIndex = 5;
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.squareClick);
            // 
            // button8
            // 
            this.button8.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.button8.BackColor = System.Drawing.Color.Transparent;
            this.button8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button8.FlatAppearance.BorderSize = 0;
            this.button8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button8.Location = new System.Drawing.Point(395, 3);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(50, 52);
            this.button8.TabIndex = 7;
            this.button8.UseVisualStyleBackColor = false;
            this.button8.Click += new System.EventHandler(this.squareClick);
            // 
            // button9
            // 
            this.button9.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.button9.BackColor = System.Drawing.Color.Transparent;
            this.button9.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button9.FlatAppearance.BorderSize = 0;
            this.button9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button9.Location = new System.Drawing.Point(3, 61);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(50, 52);
            this.button9.TabIndex = 8;
            this.button9.UseVisualStyleBackColor = false;
            this.button9.Click += new System.EventHandler(this.squareClick);
            // 
            // button11
            // 
            this.button11.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.button11.BackColor = System.Drawing.Color.Transparent;
            this.button11.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button11.FlatAppearance.BorderSize = 0;
            this.button11.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button11.Location = new System.Drawing.Point(115, 61);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(50, 52);
            this.button11.TabIndex = 10;
            this.button11.UseVisualStyleBackColor = false;
            this.button11.Click += new System.EventHandler(this.squareClick);
            // 
            // button13
            // 
            this.button13.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.button13.BackColor = System.Drawing.Color.Transparent;
            this.button13.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button13.FlatAppearance.BorderSize = 0;
            this.button13.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button13.Location = new System.Drawing.Point(227, 61);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(50, 52);
            this.button13.TabIndex = 12;
            this.button13.UseVisualStyleBackColor = false;
            this.button13.Click += new System.EventHandler(this.squareClick);
            // 
            // button15
            // 
            this.button15.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.button15.BackColor = System.Drawing.Color.Transparent;
            this.button15.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button15.FlatAppearance.BorderSize = 0;
            this.button15.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button15.Location = new System.Drawing.Point(339, 61);
            this.button15.Name = "button15";
            this.button15.Size = new System.Drawing.Size(50, 52);
            this.button15.TabIndex = 14;
            this.button15.UseVisualStyleBackColor = false;
            this.button15.Click += new System.EventHandler(this.squareClick);
            // 
            // button18
            // 
            this.button18.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.button18.BackColor = System.Drawing.Color.Transparent;
            this.button18.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button18.FlatAppearance.BorderSize = 0;
            this.button18.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button18.Location = new System.Drawing.Point(59, 119);
            this.button18.Name = "button18";
            this.button18.Size = new System.Drawing.Size(50, 52);
            this.button18.TabIndex = 17;
            this.button18.UseVisualStyleBackColor = false;
            this.button18.Click += new System.EventHandler(this.squareClick);
            // 
            // button20
            // 
            this.button20.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.button20.BackColor = System.Drawing.Color.Transparent;
            this.button20.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button20.FlatAppearance.BorderSize = 0;
            this.button20.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button20.Location = new System.Drawing.Point(171, 119);
            this.button20.Name = "button20";
            this.button20.Size = new System.Drawing.Size(50, 52);
            this.button20.TabIndex = 19;
            this.button20.UseVisualStyleBackColor = false;
            this.button20.Click += new System.EventHandler(this.squareClick);
            // 
            // button22
            // 
            this.button22.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.button22.BackColor = System.Drawing.Color.Transparent;
            this.button22.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button22.FlatAppearance.BorderSize = 0;
            this.button22.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button22.Location = new System.Drawing.Point(283, 119);
            this.button22.Name = "button22";
            this.button22.Size = new System.Drawing.Size(50, 52);
            this.button22.TabIndex = 21;
            this.button22.UseVisualStyleBackColor = false;
            this.button22.Click += new System.EventHandler(this.squareClick);
            // 
            // button24
            // 
            this.button24.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.button24.BackColor = System.Drawing.Color.Transparent;
            this.button24.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button24.FlatAppearance.BorderSize = 0;
            this.button24.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button24.Location = new System.Drawing.Point(395, 119);
            this.button24.Name = "button24";
            this.button24.Size = new System.Drawing.Size(50, 52);
            this.button24.TabIndex = 23;
            this.button24.UseVisualStyleBackColor = false;
            this.button24.Click += new System.EventHandler(this.squareClick);
            // 
            // button25
            // 
            this.button25.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.button25.BackColor = System.Drawing.Color.Transparent;
            this.button25.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button25.FlatAppearance.BorderSize = 0;
            this.button25.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button25.Location = new System.Drawing.Point(3, 177);
            this.button25.Name = "button25";
            this.button25.Size = new System.Drawing.Size(50, 52);
            this.button25.TabIndex = 24;
            this.button25.UseVisualStyleBackColor = false;
            this.button25.Click += new System.EventHandler(this.squareClick);
            // 
            // button27
            // 
            this.button27.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.button27.BackColor = System.Drawing.Color.Transparent;
            this.button27.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button27.FlatAppearance.BorderSize = 0;
            this.button27.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button27.Location = new System.Drawing.Point(115, 177);
            this.button27.Name = "button27";
            this.button27.Size = new System.Drawing.Size(50, 52);
            this.button27.TabIndex = 26;
            this.button27.UseVisualStyleBackColor = false;
            this.button27.Click += new System.EventHandler(this.squareClick);
            // 
            // button29
            // 
            this.button29.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.button29.BackColor = System.Drawing.Color.Transparent;
            this.button29.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button29.FlatAppearance.BorderSize = 0;
            this.button29.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button29.Location = new System.Drawing.Point(227, 177);
            this.button29.Name = "button29";
            this.button29.Size = new System.Drawing.Size(50, 52);
            this.button29.TabIndex = 28;
            this.button29.UseVisualStyleBackColor = false;
            this.button29.Click += new System.EventHandler(this.squareClick);
            // 
            // button31
            // 
            this.button31.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.button31.BackColor = System.Drawing.Color.Transparent;
            this.button31.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button31.FlatAppearance.BorderSize = 0;
            this.button31.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button31.Location = new System.Drawing.Point(339, 177);
            this.button31.Name = "button31";
            this.button31.Size = new System.Drawing.Size(50, 52);
            this.button31.TabIndex = 30;
            this.button31.UseVisualStyleBackColor = false;
            this.button31.Click += new System.EventHandler(this.squareClick);
            // 
            // button41
            // 
            this.button41.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.button41.BackColor = System.Drawing.Color.Transparent;
            this.button41.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button41.FlatAppearance.BorderSize = 0;
            this.button41.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button41.Location = new System.Drawing.Point(3, 293);
            this.button41.Name = "button41";
            this.button41.Size = new System.Drawing.Size(50, 52);
            this.button41.TabIndex = 40;
            this.button41.UseVisualStyleBackColor = false;
            this.button41.Click += new System.EventHandler(this.squareClick);
            // 
            // button57
            // 
            this.button57.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button57.BackColor = System.Drawing.Color.Transparent;
            this.button57.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button57.FlatAppearance.BorderSize = 0;
            this.button57.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button57.Location = new System.Drawing.Point(3, 409);
            this.button57.Name = "button57";
            this.button57.Size = new System.Drawing.Size(50, 52);
            this.button57.TabIndex = 56;
            this.button57.UseVisualStyleBackColor = false;
            this.button57.Click += new System.EventHandler(this.squareClick);
            // 
            // button34
            // 
            this.button34.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.button34.BackColor = System.Drawing.Color.Transparent;
            this.button34.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button34.FlatAppearance.BorderSize = 0;
            this.button34.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button34.Location = new System.Drawing.Point(59, 235);
            this.button34.Name = "button34";
            this.button34.Size = new System.Drawing.Size(50, 52);
            this.button34.TabIndex = 33;
            this.button34.UseVisualStyleBackColor = false;
            this.button34.Click += new System.EventHandler(this.squareClick);
            // 
            // button50
            // 
            this.button50.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.button50.BackColor = System.Drawing.Color.Transparent;
            this.button50.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button50.FlatAppearance.BorderSize = 0;
            this.button50.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button50.Location = new System.Drawing.Point(59, 351);
            this.button50.Name = "button50";
            this.button50.Size = new System.Drawing.Size(50, 52);
            this.button50.TabIndex = 49;
            this.button50.UseVisualStyleBackColor = false;
            this.button50.Click += new System.EventHandler(this.squareClick);
            // 
            // button43
            // 
            this.button43.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.button43.BackColor = System.Drawing.Color.Transparent;
            this.button43.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button43.FlatAppearance.BorderSize = 0;
            this.button43.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button43.Location = new System.Drawing.Point(115, 293);
            this.button43.Name = "button43";
            this.button43.Size = new System.Drawing.Size(50, 52);
            this.button43.TabIndex = 42;
            this.button43.UseVisualStyleBackColor = false;
            this.button43.Click += new System.EventHandler(this.squareClick);
            // 
            // button59
            // 
            this.button59.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button59.BackColor = System.Drawing.Color.Transparent;
            this.button59.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button59.FlatAppearance.BorderSize = 0;
            this.button59.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button59.Location = new System.Drawing.Point(115, 409);
            this.button59.Name = "button59";
            this.button59.Size = new System.Drawing.Size(50, 52);
            this.button59.TabIndex = 58;
            this.button59.UseVisualStyleBackColor = false;
            this.button59.Click += new System.EventHandler(this.squareClick);
            // 
            // button36
            // 
            this.button36.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.button36.BackColor = System.Drawing.Color.Transparent;
            this.button36.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button36.FlatAppearance.BorderSize = 0;
            this.button36.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button36.Location = new System.Drawing.Point(171, 235);
            this.button36.Name = "button36";
            this.button36.Size = new System.Drawing.Size(50, 52);
            this.button36.TabIndex = 35;
            this.button36.UseVisualStyleBackColor = false;
            this.button36.Click += new System.EventHandler(this.squareClick);
            // 
            // button52
            // 
            this.button52.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.button52.BackColor = System.Drawing.Color.Transparent;
            this.button52.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button52.FlatAppearance.BorderSize = 0;
            this.button52.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button52.Location = new System.Drawing.Point(171, 351);
            this.button52.Name = "button52";
            this.button52.Size = new System.Drawing.Size(50, 52);
            this.button52.TabIndex = 51;
            this.button52.UseVisualStyleBackColor = false;
            this.button52.Click += new System.EventHandler(this.squareClick);
            // 
            // button45
            // 
            this.button45.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.button45.BackColor = System.Drawing.Color.Transparent;
            this.button45.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button45.FlatAppearance.BorderSize = 0;
            this.button45.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button45.Location = new System.Drawing.Point(227, 293);
            this.button45.Name = "button45";
            this.button45.Size = new System.Drawing.Size(50, 52);
            this.button45.TabIndex = 44;
            this.button45.UseVisualStyleBackColor = false;
            this.button45.Click += new System.EventHandler(this.squareClick);
            // 
            // button61
            // 
            this.button61.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button61.BackColor = System.Drawing.Color.Transparent;
            this.button61.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button61.FlatAppearance.BorderSize = 0;
            this.button61.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button61.Location = new System.Drawing.Point(227, 409);
            this.button61.Name = "button61";
            this.button61.Size = new System.Drawing.Size(50, 52);
            this.button61.TabIndex = 60;
            this.button61.UseVisualStyleBackColor = false;
            this.button61.Click += new System.EventHandler(this.squareClick);
            // 
            // button38
            // 
            this.button38.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.button38.BackColor = System.Drawing.Color.Transparent;
            this.button38.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button38.FlatAppearance.BorderSize = 0;
            this.button38.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button38.Location = new System.Drawing.Point(283, 235);
            this.button38.Name = "button38";
            this.button38.Size = new System.Drawing.Size(50, 52);
            this.button38.TabIndex = 37;
            this.button38.UseVisualStyleBackColor = false;
            this.button38.Click += new System.EventHandler(this.squareClick);
            // 
            // button54
            // 
            this.button54.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.button54.BackColor = System.Drawing.Color.Transparent;
            this.button54.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button54.FlatAppearance.BorderSize = 0;
            this.button54.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button54.Location = new System.Drawing.Point(283, 351);
            this.button54.Name = "button54";
            this.button54.Size = new System.Drawing.Size(50, 52);
            this.button54.TabIndex = 53;
            this.button54.UseVisualStyleBackColor = false;
            this.button54.Click += new System.EventHandler(this.squareClick);
            // 
            // button47
            // 
            this.button47.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.button47.BackColor = System.Drawing.Color.Transparent;
            this.button47.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button47.FlatAppearance.BorderSize = 0;
            this.button47.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button47.Location = new System.Drawing.Point(339, 293);
            this.button47.Name = "button47";
            this.button47.Size = new System.Drawing.Size(50, 52);
            this.button47.TabIndex = 46;
            this.button47.UseVisualStyleBackColor = false;
            this.button47.Click += new System.EventHandler(this.squareClick);
            // 
            // button63
            // 
            this.button63.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button63.BackColor = System.Drawing.Color.Transparent;
            this.button63.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button63.FlatAppearance.BorderSize = 0;
            this.button63.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button63.Location = new System.Drawing.Point(339, 409);
            this.button63.Name = "button63";
            this.button63.Size = new System.Drawing.Size(50, 52);
            this.button63.TabIndex = 62;
            this.button63.UseVisualStyleBackColor = false;
            this.button63.Click += new System.EventHandler(this.squareClick);
            // 
            // button40
            // 
            this.button40.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.button40.BackColor = System.Drawing.Color.Transparent;
            this.button40.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button40.FlatAppearance.BorderSize = 0;
            this.button40.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button40.Location = new System.Drawing.Point(395, 235);
            this.button40.Name = "button40";
            this.button40.Size = new System.Drawing.Size(50, 52);
            this.button40.TabIndex = 39;
            this.button40.UseVisualStyleBackColor = false;
            this.button40.Click += new System.EventHandler(this.squareClick);
            // 
            // button56
            // 
            this.button56.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.button56.BackColor = System.Drawing.Color.Transparent;
            this.button56.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button56.FlatAppearance.BorderSize = 0;
            this.button56.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button56.Location = new System.Drawing.Point(395, 351);
            this.button56.Name = "button56";
            this.button56.Size = new System.Drawing.Size(50, 52);
            this.button56.TabIndex = 55;
            this.button56.UseVisualStyleBackColor = false;
            this.button56.Click += new System.EventHandler(this.squareClick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::WindowsFormsApplication1.Properties.Resources.Chess_Board_Indexes3;
            this.pictureBox1.Location = new System.Drawing.Point(24, 36);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(521, 537);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // computerBox
            // 
            this.computerBox.BackColor = System.Drawing.Color.Transparent;
            this.computerBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.computerBox.Location = new System.Drawing.Point(791, 249);
            this.computerBox.Name = "computerBox";
            this.computerBox.Size = new System.Drawing.Size(190, 237);
            this.computerBox.TabIndex = 15;
            this.computerBox.TabStop = false;
            this.computerBox.Visible = false;
            // 
            // speechBox
            // 
            this.speechBox.AutoSize = true;
            this.speechBox.Location = new System.Drawing.Point(731, 494);
            this.speechBox.Name = "speechBox";
            this.speechBox.Size = new System.Drawing.Size(0, 13);
            this.speechBox.TabIndex = 16;
            // 
            // lblComputerMessage
            // 
            this.lblComputerMessage.AutoSize = true;
            this.lblComputerMessage.Location = new System.Drawing.Point(788, 502);
            this.lblComputerMessage.Name = "lblComputerMessage";
            this.lblComputerMessage.Size = new System.Drawing.Size(35, 13);
            this.lblComputerMessage.TabIndex = 17;
            this.lblComputerMessage.Text = "label1";
            // 
            // boardForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.BackgroundImage = global::WindowsFormsApplication1.Properties.Resources.chess_2_wallpaper_1024x768;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1015, 595);
            this.Controls.Add(this.lblComputerMessage);
            this.Controls.Add(this.speechBox);
            this.Controls.Add(this.computerBox);
            this.Controls.Add(this.resignButton);
            this.Controls.Add(this.grpBox);
            this.Controls.Add(this.lblBlack);
            this.Controls.Add(this.lblWhite);
            this.Controls.Add(this.lblMessage);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.pictureBox1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "boardForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Koala-T-Shaquers";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.grpBox.ResumeLayout(false);
            this.grpBox.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.computerBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void tableLayoutPanel1_Paint(object sender, System.Windows.Forms.PaintEventArgs e)
        {
            
        }

        private void label5_Click(object sender, System.EventArgs e)
        {
            throw new System.NotImplementedException();
        }

        private void label15_Click(object sender, System.EventArgs e)
        {
            throw new System.NotImplementedException();
        }

        private void label13_Click(object sender, System.EventArgs e)
        {
            throw new System.NotImplementedException();
        }

        private void label11_Click(object sender, System.EventArgs e)
        {
            throw new System.NotImplementedException();
        }

        private void label7_Click(object sender, System.EventArgs e)
        {
            throw new System.NotImplementedException();
        }

        private void label10_Click(object sender, System.EventArgs e)
        {
            throw new System.NotImplementedException();
        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label lblMessage;
        private System.Windows.Forms.Label lblWhite;
        private System.Windows.Forms.Label lblBlack;
        private System.Windows.Forms.GroupBox grpBox;
        private System.Windows.Forms.RadioButton btnRemove;
        private System.Windows.Forms.RadioButton btnBlack;
        private System.Windows.Forms.RadioButton btnWhite;
        private System.Windows.Forms.CheckBox chkKing;
        private System.Windows.Forms.Button button63;
        private System.Windows.Forms.Button button61;
        private System.Windows.Forms.Button button59;
        private System.Windows.Forms.Button button57;
        private System.Windows.Forms.Button button56;
        private System.Windows.Forms.Button button54;
        private System.Windows.Forms.Button button52;
        private System.Windows.Forms.Button button50;
        private System.Windows.Forms.Button button47;
        private System.Windows.Forms.Button button45;
        private System.Windows.Forms.Button button43;
        private System.Windows.Forms.Button button41;
        private System.Windows.Forms.Button button40;
        private System.Windows.Forms.Button button38;
        private System.Windows.Forms.Button button36;
        private System.Windows.Forms.Button button34;
        private System.Windows.Forms.Button button31;
        private System.Windows.Forms.Button button29;
        private System.Windows.Forms.Button button27;
        private System.Windows.Forms.Button button25;
        private System.Windows.Forms.Button button24;
        private System.Windows.Forms.Button button22;
        private System.Windows.Forms.Button button20;
        private System.Windows.Forms.Button button18;
        private System.Windows.Forms.Button button15;
        private System.Windows.Forms.Button button13;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem startToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem restartToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem customToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.Button resignButton;
        private System.Windows.Forms.PictureBox computerBox;
        private System.Windows.Forms.Label speechBox;
        private System.Windows.Forms.Label lblComputerMessage;
    }
}

