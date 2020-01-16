namespace Game_Rock_Paper_Scissors
{
    partial class frmMain
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
            this.grpBoxConfiguracion = new System.Windows.Forms.GroupBox();
            this.ckbComputer = new System.Windows.Forms.CheckBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.ListQntGames = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnSalve = new System.Windows.Forms.Button();
            this.txtPlayer02 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPlayer01 = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtNumberMatched = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtScoreEven = new System.Windows.Forms.TextBox();
            this.lblEven = new System.Windows.Forms.Label();
            this.txtQntMatch = new System.Windows.Forms.TextBox();
            this.txtScorePlayer02 = new System.Windows.Forms.TextBox();
            this.lblPlayer02 = new System.Windows.Forms.Label();
            this.txtScorePlayer01 = new System.Windows.Forms.TextBox();
            this.lblPlayer01 = new System.Windows.Forms.Label();
            this.btnScissors = new System.Windows.Forms.Button();
            this.btnPaper = new System.Windows.Forms.Button();
            this.btnRock = new System.Windows.Forms.Button();
            this.txtStatus = new System.Windows.Forms.TextBox();
            this.lblTurn = new System.Windows.Forms.Label();
            this.grpBoxConfiguracion.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpBoxConfiguracion
            // 
            this.grpBoxConfiguracion.Controls.Add(this.ckbComputer);
            this.grpBoxConfiguracion.Controls.Add(this.btnExit);
            this.grpBoxConfiguracion.Controls.Add(this.ListQntGames);
            this.grpBoxConfiguracion.Controls.Add(this.label3);
            this.grpBoxConfiguracion.Controls.Add(this.btnSalve);
            this.grpBoxConfiguracion.Controls.Add(this.txtPlayer02);
            this.grpBoxConfiguracion.Controls.Add(this.label2);
            this.grpBoxConfiguracion.Controls.Add(this.label1);
            this.grpBoxConfiguracion.Controls.Add(this.txtPlayer01);
            this.grpBoxConfiguracion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpBoxConfiguracion.Location = new System.Drawing.Point(12, 12);
            this.grpBoxConfiguracion.Name = "grpBoxConfiguracion";
            this.grpBoxConfiguracion.Size = new System.Drawing.Size(233, 286);
            this.grpBoxConfiguracion.TabIndex = 3;
            this.grpBoxConfiguracion.TabStop = false;
            this.grpBoxConfiguracion.Text = "Configuration";
            // 
            // ckbComputer
            // 
            this.ckbComputer.AutoSize = true;
            this.ckbComputer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckbComputer.Location = new System.Drawing.Point(9, 118);
            this.ckbComputer.Name = "ckbComputer";
            this.ckbComputer.Size = new System.Drawing.Size(142, 19);
            this.ckbComputer.TabIndex = 2;
            this.ckbComputer.Text = "Player with Computer";
            this.ckbComputer.UseVisualStyleBackColor = true;
            this.ckbComputer.CheckedChanged += new System.EventHandler(this.CkbComputer_CheckedChanged);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(9, 232);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(214, 43);
            this.btnExit.TabIndex = 5;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.BtbExit_Click);
            // 
            // ListQntGames
            // 
            this.ListQntGames.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ListQntGames.FormattingEnabled = true;
            this.ListQntGames.Items.AddRange(new object[] {
            "1",
            "3",
            "5"});
            this.ListQntGames.Location = new System.Drawing.Point(9, 158);
            this.ListQntGames.Name = "ListQntGames";
            this.ListQntGames.Size = new System.Drawing.Size(214, 24);
            this.ListQntGames.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 140);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "How many match?";
            // 
            // btnSalve
            // 
            this.btnSalve.Location = new System.Drawing.Point(9, 185);
            this.btnSalve.Name = "btnSalve";
            this.btnSalve.Size = new System.Drawing.Size(214, 43);
            this.btnSalve.TabIndex = 4;
            this.btnSalve.Text = "Salve";
            this.btnSalve.UseVisualStyleBackColor = true;
            this.btnSalve.Click += new System.EventHandler(this.BtnSalvePlayer_Click);
            // 
            // txtPlayer02
            // 
            this.txtPlayer02.ForeColor = System.Drawing.Color.Indigo;
            this.txtPlayer02.Location = new System.Drawing.Point(9, 90);
            this.txtPlayer02.MaxLength = 15;
            this.txtPlayer02.Name = "txtPlayer02";
            this.txtPlayer02.Size = new System.Drawing.Size(214, 22);
            this.txtPlayer02.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Indigo;
            this.label2.Location = new System.Drawing.Point(6, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Player 02";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(6, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Player 01";
            // 
            // txtPlayer01
            // 
            this.txtPlayer01.ForeColor = System.Drawing.Color.Blue;
            this.txtPlayer01.Location = new System.Drawing.Point(9, 45);
            this.txtPlayer01.MaxLength = 15;
            this.txtPlayer01.Name = "txtPlayer01";
            this.txtPlayer01.Size = new System.Drawing.Size(214, 22);
            this.txtPlayer01.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtNumberMatched);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtScoreEven);
            this.groupBox1.Controls.Add(this.lblEven);
            this.groupBox1.Controls.Add(this.txtQntMatch);
            this.groupBox1.Controls.Add(this.txtScorePlayer02);
            this.groupBox1.Controls.Add(this.lblPlayer02);
            this.groupBox1.Controls.Add(this.txtScorePlayer01);
            this.groupBox1.Controls.Add(this.lblPlayer01);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(251, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(336, 80);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Score";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(46, 48);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(17, 15);
            this.label6.TabIndex = 12;
            this.label6.Text = "of";
            // 
            // txtNumberMatched
            // 
            this.txtNumberMatched.Enabled = false;
            this.txtNumberMatched.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold);
            this.txtNumberMatched.Location = new System.Drawing.Point(6, 33);
            this.txtNumberMatched.Multiline = true;
            this.txtNumberMatched.Name = "txtNumberMatched";
            this.txtNumberMatched.ReadOnly = true;
            this.txtNumberMatched.Size = new System.Drawing.Size(38, 41);
            this.txtNumberMatched.TabIndex = 10;
            this.txtNumberMatched.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(1, 14);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 15);
            this.label4.TabIndex = 9;
            this.label4.Text = "Match";
            // 
            // txtScoreEven
            // 
            this.txtScoreEven.Enabled = false;
            this.txtScoreEven.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtScoreEven.Location = new System.Drawing.Point(254, 33);
            this.txtScoreEven.Multiline = true;
            this.txtScoreEven.Name = "txtScoreEven";
            this.txtScoreEven.ReadOnly = true;
            this.txtScoreEven.Size = new System.Drawing.Size(65, 41);
            this.txtScoreEven.TabIndex = 8;
            this.txtScoreEven.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblEven
            // 
            this.lblEven.AutoSize = true;
            this.lblEven.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEven.Location = new System.Drawing.Point(252, 15);
            this.lblEven.Name = "lblEven";
            this.lblEven.Size = new System.Drawing.Size(34, 15);
            this.lblEven.TabIndex = 7;
            this.lblEven.Text = "Even";
            // 
            // txtQntMatch
            // 
            this.txtQntMatch.Enabled = false;
            this.txtQntMatch.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold);
            this.txtQntMatch.Location = new System.Drawing.Point(66, 33);
            this.txtQntMatch.Multiline = true;
            this.txtQntMatch.Name = "txtQntMatch";
            this.txtQntMatch.ReadOnly = true;
            this.txtQntMatch.Size = new System.Drawing.Size(38, 41);
            this.txtQntMatch.TabIndex = 6;
            this.txtQntMatch.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtScorePlayer02
            // 
            this.txtScorePlayer02.Enabled = false;
            this.txtScorePlayer02.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtScorePlayer02.Location = new System.Drawing.Point(183, 33);
            this.txtScorePlayer02.Multiline = true;
            this.txtScorePlayer02.Name = "txtScorePlayer02";
            this.txtScorePlayer02.ReadOnly = true;
            this.txtScorePlayer02.Size = new System.Drawing.Size(65, 41);
            this.txtScorePlayer02.TabIndex = 5;
            this.txtScorePlayer02.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblPlayer02
            // 
            this.lblPlayer02.AutoSize = true;
            this.lblPlayer02.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayer02.Location = new System.Drawing.Point(180, 15);
            this.lblPlayer02.Name = "lblPlayer02";
            this.lblPlayer02.Size = new System.Drawing.Size(58, 15);
            this.lblPlayer02.TabIndex = 4;
            this.lblPlayer02.Text = "Player 02";
            // 
            // txtScorePlayer01
            // 
            this.txtScorePlayer01.Enabled = false;
            this.txtScorePlayer01.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtScorePlayer01.Location = new System.Drawing.Point(112, 33);
            this.txtScorePlayer01.Multiline = true;
            this.txtScorePlayer01.Name = "txtScorePlayer01";
            this.txtScorePlayer01.ReadOnly = true;
            this.txtScorePlayer01.Size = new System.Drawing.Size(65, 41);
            this.txtScorePlayer01.TabIndex = 3;
            this.txtScorePlayer01.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblPlayer01
            // 
            this.lblPlayer01.AutoSize = true;
            this.lblPlayer01.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayer01.Location = new System.Drawing.Point(109, 15);
            this.lblPlayer01.Name = "lblPlayer01";
            this.lblPlayer01.Size = new System.Drawing.Size(58, 15);
            this.lblPlayer01.TabIndex = 2;
            this.lblPlayer01.Text = "Player 01";
            // 
            // btnScissors
            // 
            this.btnScissors.Enabled = false;
            this.btnScissors.Image = global::Game_Rock_Paper_Scissors.Properties.Resources.Scissor;
            this.btnScissors.Location = new System.Drawing.Point(272, 216);
            this.btnScissors.Name = "btnScissors";
            this.btnScissors.Size = new System.Drawing.Size(80, 71);
            this.btnScissors.TabIndex = 8;
            this.btnScissors.UseVisualStyleBackColor = true;
            this.btnScissors.Click += new System.EventHandler(this.BtnScissors_Click);
            // 
            // btnPaper
            // 
            this.btnPaper.Enabled = false;
            this.btnPaper.Image = global::Game_Rock_Paper_Scissors.Properties.Resources.Paper;
            this.btnPaper.Location = new System.Drawing.Point(480, 216);
            this.btnPaper.Name = "btnPaper";
            this.btnPaper.Size = new System.Drawing.Size(80, 71);
            this.btnPaper.TabIndex = 7;
            this.btnPaper.UseVisualStyleBackColor = true;
            this.btnPaper.Click += new System.EventHandler(this.BtnPaper_Click);
            // 
            // btnRock
            // 
            this.btnRock.Enabled = false;
            this.btnRock.Image = global::Game_Rock_Paper_Scissors.Properties.Resources.Rock;
            this.btnRock.Location = new System.Drawing.Point(378, 216);
            this.btnRock.Name = "btnRock";
            this.btnRock.Size = new System.Drawing.Size(80, 71);
            this.btnRock.TabIndex = 6;
            this.btnRock.UseVisualStyleBackColor = true;
            this.btnRock.Click += new System.EventHandler(this.BtnRock_Click);
            // 
            // txtStatus
            // 
            this.txtStatus.Enabled = false;
            this.txtStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStatus.Location = new System.Drawing.Point(257, 126);
            this.txtStatus.Multiline = true;
            this.txtStatus.Name = "txtStatus";
            this.txtStatus.ReadOnly = true;
            this.txtStatus.Size = new System.Drawing.Size(329, 73);
            this.txtStatus.TabIndex = 7;
            this.txtStatus.Text = "Waiting Configurations";
            // 
            // lblTurn
            // 
            this.lblTurn.AutoSize = true;
            this.lblTurn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTurn.Location = new System.Drawing.Point(257, 102);
            this.lblTurn.Name = "lblTurn";
            this.lblTurn.Size = new System.Drawing.Size(0, 15);
            this.lblTurn.TabIndex = 11;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(590, 302);
            this.ControlBox = false;
            this.Controls.Add(this.btnPaper);
            this.Controls.Add(this.btnRock);
            this.Controls.Add(this.lblTurn);
            this.Controls.Add(this.btnScissors);
            this.Controls.Add(this.txtStatus);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.grpBoxConfiguracion);
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GAME - Rock x Paper x Scissors";
            this.grpBoxConfiguracion.ResumeLayout(false);
            this.grpBoxConfiguracion.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRock;
        private System.Windows.Forms.Button btnPaper;
        private System.Windows.Forms.Button btnScissors;
        private System.Windows.Forms.GroupBox grpBoxConfiguracion;
        private System.Windows.Forms.ComboBox ListQntGames;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnSalve;
        private System.Windows.Forms.TextBox txtPlayer02;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPlayer01;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.CheckBox ckbComputer;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblPlayer01;
        private System.Windows.Forms.TextBox txtScorePlayer02;
        private System.Windows.Forms.Label lblPlayer02;
        private System.Windows.Forms.TextBox txtScorePlayer01;
        private System.Windows.Forms.TextBox txtQntMatch;
        private System.Windows.Forms.TextBox txtStatus;
        private System.Windows.Forms.TextBox txtScoreEven;
        private System.Windows.Forms.Label lblEven;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtNumberMatched;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblTurn;
    }
}

