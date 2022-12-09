namespace AutoSim
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.choicelabel = new System.Windows.Forms.Label();
            this.choicebox = new System.Windows.Forms.ComboBox();
            this.hplabel = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.enginecheck = new System.Windows.Forms.CheckBox();
            this.key = new System.Windows.Forms.PictureBox();
            this.horn = new System.Windows.Forms.PictureBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.speedlabel = new System.Windows.Forms.Label();
            this.breakbutton = new System.Windows.Forms.Button();
            this.acceleratorbutton = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.key)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.horn)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // choicelabel
            // 
            this.choicelabel.AutoSize = true;
            this.choicelabel.Location = new System.Drawing.Point(28, 15);
            this.choicelabel.Name = "choicelabel";
            this.choicelabel.Size = new System.Drawing.Size(77, 15);
            this.choicelabel.TabIndex = 0;
            this.choicelabel.Text = "Auto wählen:";
            // 
            // choicebox
            // 
            this.choicebox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.choicebox.FormattingEnabled = true;
            this.choicebox.Location = new System.Drawing.Point(111, 12);
            this.choicebox.Name = "choicebox";
            this.choicebox.Size = new System.Drawing.Size(196, 23);
            this.choicebox.TabIndex = 1;
            // 
            // hplabel
            // 
            this.hplabel.AutoSize = true;
            this.hplabel.Location = new System.Drawing.Point(332, 15);
            this.hplabel.Name = "hplabel";
            this.hplabel.Size = new System.Drawing.Size(29, 15);
            this.hplabel.TabIndex = 2;
            this.hplabel.Text = "0 PS";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.enginecheck);
            this.groupBox1.Controls.Add(this.key);
            this.groupBox1.Controls.Add(this.horn);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.breakbutton);
            this.groupBox1.Controls.Add(this.acceleratorbutton);
            this.groupBox1.Location = new System.Drawing.Point(12, 41);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(391, 397);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(29, 175);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 23);
            this.textBox1.TabIndex = 6;
            // 
            // enginecheck
            // 
            this.enginecheck.AutoSize = true;
            this.enginecheck.ForeColor = System.Drawing.SystemColors.ControlText;
            this.enginecheck.Location = new System.Drawing.Point(77, 41);
            this.enginecheck.Name = "enginecheck";
            this.enginecheck.Size = new System.Drawing.Size(15, 14);
            this.enginecheck.TabIndex = 5;
            this.enginecheck.UseVisualStyleBackColor = true;
            // 
            // key
            // 
            this.key.Image = ((System.Drawing.Image)(resources.GetObject("key.Image")));
            this.key.Location = new System.Drawing.Point(16, 12);
            this.key.Name = "key";
            this.key.Size = new System.Drawing.Size(55, 65);
            this.key.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.key.TabIndex = 4;
            this.key.TabStop = false;
            this.key.Click += new System.EventHandler(this.key_Click);
            // 
            // horn
            // 
            this.horn.Image = global::AutoSim.Properties.Resources.horn;
            this.horn.Location = new System.Drawing.Point(16, 83);
            this.horn.Name = "horn";
            this.horn.Size = new System.Drawing.Size(63, 39);
            this.horn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.horn.TabIndex = 3;
            this.horn.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.speedlabel);
            this.groupBox2.Location = new System.Drawing.Point(99, 22);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(269, 100);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.label1.Location = new System.Drawing.Point(177, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 65);
            this.label1.TabIndex = 1;
            this.label1.Text = "0";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // speedlabel
            // 
            this.speedlabel.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.speedlabel.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.speedlabel.ForeColor = System.Drawing.Color.ForestGreen;
            this.speedlabel.Location = new System.Drawing.Point(16, 19);
            this.speedlabel.Name = "speedlabel";
            this.speedlabel.Size = new System.Drawing.Size(155, 65);
            this.speedlabel.TabIndex = 0;
            this.speedlabel.Text = "0";
            this.speedlabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // breakbutton
            // 
            this.breakbutton.Location = new System.Drawing.Point(143, 138);
            this.breakbutton.Name = "breakbutton";
            this.breakbutton.Size = new System.Drawing.Size(127, 186);
            this.breakbutton.TabIndex = 1;
            this.breakbutton.Text = "Bremse";
            this.breakbutton.UseVisualStyleBackColor = true;
            // 
            // acceleratorbutton
            // 
            this.acceleratorbutton.Location = new System.Drawing.Point(287, 138);
            this.acceleratorbutton.Name = "acceleratorbutton";
            this.acceleratorbutton.Size = new System.Drawing.Size(81, 186);
            this.acceleratorbutton.TabIndex = 0;
            this.acceleratorbutton.Text = "Gas";
            this.acceleratorbutton.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(415, 450);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.hplabel);
            this.Controls.Add(this.choicebox);
            this.Controls.Add(this.choicelabel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.key)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.horn)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label choicelabel;
        private ComboBox choicebox;
        private Label hplabel;
        private GroupBox groupBox1;
        private Button acceleratorbutton;
        private Button breakbutton;
        private GroupBox groupBox2;
        private Label speedlabel;
        private PictureBox horn;
        private Label label1;
        private PictureBox key;
        private CheckBox enginecheck;
        private TextBox textBox1;
    }
}