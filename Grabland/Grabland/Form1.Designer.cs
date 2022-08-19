namespace Grabland
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
            this.btstart = new System.Windows.Forms.Button();
            this.btreset = new System.Windows.Forms.Button();
            this.tbrow = new System.Windows.Forms.TextBox();
            this.tbcol = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbred = new System.Windows.Forms.Label();
            this.bt_count = new System.Windows.Forms.Button();
            this.rb_red = new System.Windows.Forms.RadioButton();
            this.rb_green = new System.Windows.Forms.RadioButton();
            this.lb_green = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btstart
            // 
            this.btstart.Location = new System.Drawing.Point(375, 19);
            this.btstart.Name = "btstart";
            this.btstart.Size = new System.Drawing.Size(75, 23);
            this.btstart.TabIndex = 1;
            this.btstart.Text = "Start";
            this.btstart.UseVisualStyleBackColor = true;
            this.btstart.Click += new System.EventHandler(this.btstart_Click);
            // 
            // btreset
            // 
            this.btreset.Location = new System.Drawing.Point(456, 20);
            this.btreset.Name = "btreset";
            this.btreset.Size = new System.Drawing.Size(75, 23);
            this.btreset.TabIndex = 2;
            this.btreset.Text = "Reset";
            this.btreset.UseVisualStyleBackColor = true;
            this.btreset.Click += new System.EventHandler(this.btreset_Click);
            // 
            // tbrow
            // 
            this.tbrow.Location = new System.Drawing.Point(53, 20);
            this.tbrow.Name = "tbrow";
            this.tbrow.ReadOnly = true;
            this.tbrow.Size = new System.Drawing.Size(100, 23);
            this.tbrow.TabIndex = 3;
            this.tbrow.Tag = "Max 30";
            this.tbrow.Text = "10";
            // 
            // tbcol
            // 
            this.tbcol.Location = new System.Drawing.Point(241, 20);
            this.tbcol.Name = "tbcol";
            this.tbcol.ReadOnly = true;
            this.tbcol.Size = new System.Drawing.Size(100, 23);
            this.tbcol.TabIndex = 4;
            this.tbcol.Tag = "Max 30";
            this.tbcol.Text = "10";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 15);
            this.label1.TabIndex = 5;
            this.label1.Text = "Rows";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(172, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 15);
            this.label2.TabIndex = 6;
            this.label2.Text = "Colums";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(537, 20);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "Exit";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.groupBox1.Location = new System.Drawing.Point(12, 97);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(604, 560);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            // 
            // lbred
            // 
            this.lbred.AutoSize = true;
            this.lbred.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbred.Location = new System.Drawing.Point(27, 676);
            this.lbred.Name = "lbred";
            this.lbred.Size = new System.Drawing.Size(43, 21);
            this.lbred.TabIndex = 12;
            this.lbred.Text = "Red:";
            // 
            // bt_count
            // 
            this.bt_count.Location = new System.Drawing.Point(512, 676);
            this.bt_count.Name = "bt_count";
            this.bt_count.Size = new System.Drawing.Size(104, 23);
            this.bt_count.TabIndex = 13;
            this.bt_count.Text = "Count Result";
            this.bt_count.UseVisualStyleBackColor = true;
            this.bt_count.Click += new System.EventHandler(this.bt_count_Click);
            // 
            // rb_red
            // 
            this.rb_red.AutoSize = true;
            this.rb_red.BackColor = System.Drawing.Color.Red;
            this.rb_red.Checked = true;
            this.rb_red.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.rb_red.ForeColor = System.Drawing.Color.White;
            this.rb_red.Location = new System.Drawing.Point(53, 61);
            this.rb_red.Name = "rb_red";
            this.rb_red.Size = new System.Drawing.Size(53, 25);
            this.rb_red.TabIndex = 14;
            this.rb_red.TabStop = true;
            this.rb_red.Text = "red";
            this.rb_red.UseVisualStyleBackColor = false;
            // 
            // rb_green
            // 
            this.rb_green.AutoSize = true;
            this.rb_green.BackColor = System.Drawing.Color.Green;
            this.rb_green.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.rb_green.ForeColor = System.Drawing.Color.White;
            this.rb_green.Location = new System.Drawing.Point(152, 61);
            this.rb_green.Name = "rb_green";
            this.rb_green.Size = new System.Drawing.Size(72, 25);
            this.rb_green.TabIndex = 15;
            this.rb_green.Text = "green";
            this.rb_green.UseVisualStyleBackColor = false;
            // 
            // lb_green
            // 
            this.lb_green.AutoSize = true;
            this.lb_green.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lb_green.Location = new System.Drawing.Point(172, 676);
            this.lb_green.Name = "lb_green";
            this.lb_green.Size = new System.Drawing.Size(59, 21);
            this.lb_green.TabIndex = 16;
            this.lb_green.Text = "Green:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(628, 711);
            this.Controls.Add(this.lb_green);
            this.Controls.Add(this.rb_green);
            this.Controls.Add(this.rb_red);
            this.Controls.Add(this.bt_count);
            this.Controls.Add(this.lbred);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbcol);
            this.Controls.Add(this.tbrow);
            this.Controls.Add(this.btreset);
            this.Controls.Add(this.btstart);
            this.Name = "Form1";
            this.Text = "抢地盘";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Button btstart;
        private Button btreset;
        private TextBox tbrow;
        private TextBox tbcol;
        private Label label1;
        private Label label2;
        private Button button1;
        private GroupBox groupBox1;
        private Label lbred;
        private Button bt_count;
        private RadioButton rb_red;
        private RadioButton rb_green;
        private Label lb_green;
    }
}