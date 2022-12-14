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
            this.EngineCheck = new System.Windows.Forms.CheckBox();
            this.key = new System.Windows.Forms.PictureBox();
            this.horn = new System.Windows.Forms.PictureBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.GearLabel = new System.Windows.Forms.Label();
            this.SpeedLabel = new System.Windows.Forms.Label();
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
            this.choicebox.SelectedIndexChanged += new System.EventHandler(this.choicebox_SelectedIndexChanged);
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
            this.groupBox1.Controls.Add(this.EngineCheck);
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
            // EngineCheck
            // 
            this.EngineCheck.AutoCheck = false;
            this.EngineCheck.AutoSize = true;
            this.EngineCheck.ForeColor = System.Drawing.SystemColors.ControlText;
            this.EngineCheck.Location = new System.Drawing.Point(77, 41);
            this.EngineCheck.Name = "EngineCheck";
            this.EngineCheck.Size = new System.Drawing.Size(15, 14);
            this.EngineCheck.TabIndex = 5;
            this.EngineCheck.UseVisualStyleBackColor = true;
            // 
            // key
            // 
            this.key.Image = global::AutoSim.Properties.Resources.key;
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
            this.horn.Image = ((System.Drawing.Image)(resources.GetObject("horn.Image")));
            this.horn.Location = new System.Drawing.Point(16, 83);
            this.horn.Name = "horn";
            this.horn.Size = new System.Drawing.Size(63, 39);
            this.horn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.horn.TabIndex = 3;
            this.horn.TabStop = false;
            this.horn.Click += new System.EventHandler(this.horn_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.groupBox2.Controls.Add(this.GearLabel);
            this.groupBox2.Controls.Add(this.SpeedLabel);
            this.groupBox2.Location = new System.Drawing.Point(99, 22);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(269, 100);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            // 
            // GearLabel
            // 
            this.GearLabel.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.GearLabel.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.GearLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.GearLabel.Location = new System.Drawing.Point(177, 19);
            this.GearLabel.Name = "GearLabel";
            this.GearLabel.Size = new System.Drawing.Size(73, 65);
            this.GearLabel.TabIndex = 1;
            this.GearLabel.Text = "0";
            this.GearLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // SpeedLabel
            // 
            this.SpeedLabel.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.SpeedLabel.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.SpeedLabel.ForeColor = System.Drawing.Color.ForestGreen;
            this.SpeedLabel.Location = new System.Drawing.Point(16, 19);
            this.SpeedLabel.Name = "SpeedLabel";
            this.SpeedLabel.Size = new System.Drawing.Size(155, 65);
            this.SpeedLabel.TabIndex = 0;
            this.SpeedLabel.Text = "0";
            this.SpeedLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // breakbutton
            // 
            this.breakbutton.Location = new System.Drawing.Point(143, 138);
            this.breakbutton.Name = "breakbutton";
            this.breakbutton.Size = new System.Drawing.Size(127, 186);
            this.breakbutton.TabIndex = 1;
            this.breakbutton.Text = "Bremse";
            this.breakbutton.UseVisualStyleBackColor = true;
            this.breakbutton.MouseHover += new System.EventHandler(this.breakbutton_MouseHover);
            // 
            // acceleratorbutton
            // 
            this.acceleratorbutton.Location = new System.Drawing.Point(287, 138);
            this.acceleratorbutton.Name = "acceleratorbutton";
            this.acceleratorbutton.Size = new System.Drawing.Size(81, 186);
            this.acceleratorbutton.TabIndex = 0;
            this.acceleratorbutton.Text = "Gas";
            this.acceleratorbutton.UseVisualStyleBackColor = true;
            this.acceleratorbutton.MouseHover += new System.EventHandler(this.acceleratorbutton_MouseHover);
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
        private Label hplabel;
        private GroupBox groupBox1;
        private Button acceleratorbutton;
        private Button breakbutton;
        private GroupBox groupBox2;
        private Label SpeedLabel;
        private PictureBox horn;
        private Label GearLabel;
        private PictureBox key;
        public ComboBox choicebox;
        public CheckBox EngineCheck;
    }
}