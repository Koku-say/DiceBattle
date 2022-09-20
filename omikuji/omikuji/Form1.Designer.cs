namespace omikuji
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dicebutton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Resetbutton = new System.Windows.Forms.Button();
            this.exitbutton = new System.Windows.Forms.Button();
            this.Join = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // dicebutton
            // 
            this.dicebutton.Font = new System.Drawing.Font("Yu Gothic UI", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dicebutton.Location = new System.Drawing.Point(98, 240);
            this.dicebutton.Name = "dicebutton";
            this.dicebutton.Size = new System.Drawing.Size(308, 119);
            this.dicebutton.TabIndex = 0;
            this.dicebutton.Text = "Aがダイスを投げる";
            this.dicebutton.UseVisualStyleBackColor = true;
            this.dicebutton.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.label1.Font = new System.Drawing.Font("Yu Gothic UI", 50.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label1.Location = new System.Drawing.Point(178, 124);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(160, 98);
            this.label1.TabIndex = 3;
            this.label1.Text = "100";
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Yu Gothic UI", 50.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(426, 122);
            this.label2.Margin = new System.Windows.Forms.Padding(0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 103);
            this.label2.TabIndex = 5;
            this.label2.Text = "０";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label3.Font = new System.Drawing.Font("Yu Gothic UI", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(12, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(326, 198);
            this.label3.TabIndex = 6;
            this.label3.Text = "ゴールまであと...";
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.label4.Font = new System.Drawing.Font("Yu Gothic UI", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(78, 228);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(328, 137);
            this.label4.TabIndex = 7;
            this.label4.Text = "Player   A\r\n  win!";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Resetbutton
            // 
            this.Resetbutton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.Resetbutton.Font = new System.Drawing.Font("Yu Gothic UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Resetbutton.Location = new System.Drawing.Point(432, 228);
            this.Resetbutton.Name = "Resetbutton";
            this.Resetbutton.Size = new System.Drawing.Size(111, 62);
            this.Resetbutton.TabIndex = 8;
            this.Resetbutton.Text = "Reset";
            this.Resetbutton.UseVisualStyleBackColor = false;
            this.Resetbutton.Click += new System.EventHandler(this.Resetbutton_Click);
            // 
            // exitbutton
            // 
            this.exitbutton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.exitbutton.Font = new System.Drawing.Font("Yu Gothic UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.exitbutton.Location = new System.Drawing.Point(432, 296);
            this.exitbutton.Name = "exitbutton";
            this.exitbutton.Size = new System.Drawing.Size(111, 66);
            this.exitbutton.TabIndex = 9;
            this.exitbutton.Text = "Exit";
            this.exitbutton.UseVisualStyleBackColor = false;
            this.exitbutton.Click += new System.EventHandler(this.exitbutton_Click);
            // 
            // Join
            // 
            this.Join.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.Join.Font = new System.Drawing.Font("Yu Gothic UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Join.Location = new System.Drawing.Point(-1, 0);
            this.Join.Name = "Join";
            this.Join.Size = new System.Drawing.Size(555, 387);
            this.Join.TabIndex = 10;
            this.Join.Text = "・このゲームは2人で遊ぶゲームです。\r\n・1～10の数字が出るダイスを交互に振って、100マス先のゴールにピッタリ到着した方の勝利です\r\n\r\n\r\n例)　Aが5を出" +
    "す→ゴールまであと95→Bが10を出す→ゴールまであと85→Aが１を出す→.....→ゴールまであと2→Bが10を出す→(ゴールを通り過ぎて)あとー8→Aが8を" +
    "出す→Aゴール(Aの勝ち)\r\n         \r\n";
            this.Join.Click += new System.EventHandler(this.Join_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Yu Gothic UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button1.Location = new System.Drawing.Point(191, 272);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(174, 69);
            this.button1.TabIndex = 11;
            this.button1.Text = "Start";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(549, 371);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Join);
            this.Controls.Add(this.exitbutton);
            this.Controls.Add(this.Resetbutton);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dicebutton);
            this.Name = "Form1";
            this.Text = "DiceBattle";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Button dicebutton;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button Resetbutton;
        private Button exitbutton;
        private Label Join;
        private Button button1;
    }
}