
namespace Lesson1
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
            this.Anket = new System.Windows.Forms.GroupBox();
            this.txt_email = new System.Windows.Forms.TextBox();
            this.txt_number = new System.Windows.Forms.TextBox();
            this.txt_born = new System.Windows.Forms.TextBox();
            this.txt_surname = new System.Windows.Forms.TextBox();
            this.txt_name = new System.Windows.Forms.TextBox();
            this.lbl_born = new System.Windows.Forms.Label();
            this.lbl_phone = new System.Windows.Forms.Label();
            this.lbl_email = new System.Windows.Forms.Label();
            this.lbl_surname = new System.Windows.Forms.Label();
            this.lbl_name = new System.Windows.Forms.Label();
            this.btn_add = new System.Windows.Forms.Button();
            this.btn_change = new System.Windows.Forms.Button();
            this.listBox = new System.Windows.Forms.ListBox();
            this.btn_save = new System.Windows.Forms.Button();
            this.btn_load = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.Anket.SuspendLayout();
            this.SuspendLayout();
            // 
            // Anket
            // 
            this.Anket.Controls.Add(this.txt_email);
            this.Anket.Controls.Add(this.txt_number);
            this.Anket.Controls.Add(this.txt_born);
            this.Anket.Controls.Add(this.txt_surname);
            this.Anket.Controls.Add(this.txt_name);
            this.Anket.Controls.Add(this.lbl_born);
            this.Anket.Controls.Add(this.lbl_phone);
            this.Anket.Controls.Add(this.lbl_email);
            this.Anket.Controls.Add(this.lbl_surname);
            this.Anket.Controls.Add(this.lbl_name);
            this.Anket.Controls.Add(this.btn_add);
            this.Anket.Controls.Add(this.btn_change);
            this.Anket.Location = new System.Drawing.Point(12, 22);
            this.Anket.Name = "Anket";
            this.Anket.Size = new System.Drawing.Size(570, 608);
            this.Anket.TabIndex = 0;
            this.Anket.TabStop = false;
            this.Anket.Text = "Anket";
            // 
            // txt_email
            // 
            this.txt_email.Location = new System.Drawing.Point(115, 171);
            this.txt_email.Name = "txt_email";
            this.txt_email.Size = new System.Drawing.Size(284, 31);
            this.txt_email.TabIndex = 11;
            // 
            // txt_number
            // 
            this.txt_number.Location = new System.Drawing.Point(115, 237);
            this.txt_number.Name = "txt_number";
            this.txt_number.Size = new System.Drawing.Size(284, 31);
            this.txt_number.TabIndex = 10;
            // 
            // txt_born
            // 
            this.txt_born.Location = new System.Drawing.Point(115, 297);
            this.txt_born.Name = "txt_born";
            this.txt_born.Size = new System.Drawing.Size(284, 31);
            this.txt_born.TabIndex = 9;
            // 
            // txt_surname
            // 
            this.txt_surname.Location = new System.Drawing.Point(115, 120);
            this.txt_surname.Name = "txt_surname";
            this.txt_surname.Size = new System.Drawing.Size(284, 31);
            this.txt_surname.TabIndex = 8;
            // 
            // txt_name
            // 
            this.txt_name.Location = new System.Drawing.Point(115, 57);
            this.txt_name.Name = "txt_name";
            this.txt_name.Size = new System.Drawing.Size(284, 31);
            this.txt_name.TabIndex = 7;
            // 
            // lbl_born
            // 
            this.lbl_born.AutoSize = true;
            this.lbl_born.Location = new System.Drawing.Point(21, 297);
            this.lbl_born.Name = "lbl_born";
            this.lbl_born.Size = new System.Drawing.Size(73, 25);
            this.lbl_born.TabIndex = 6;
            this.lbl_born.Text = "Doğum";
            // 
            // lbl_phone
            // 
            this.lbl_phone.AllowDrop = true;
            this.lbl_phone.AutoSize = true;
            this.lbl_phone.Location = new System.Drawing.Point(21, 237);
            this.lbl_phone.Name = "lbl_phone";
            this.lbl_phone.Size = new System.Drawing.Size(32, 25);
            this.lbl_phone.TabIndex = 5;
            this.lbl_phone.Text = "Tel";
            // 
            // lbl_email
            // 
            this.lbl_email.AutoSize = true;
            this.lbl_email.Location = new System.Drawing.Point(21, 177);
            this.lbl_email.Name = "lbl_email";
            this.lbl_email.Size = new System.Drawing.Size(54, 25);
            this.lbl_email.TabIndex = 4;
            this.lbl_email.Text = "Email";
            // 
            // lbl_surname
            // 
            this.lbl_surname.AutoSize = true;
            this.lbl_surname.Location = new System.Drawing.Point(21, 120);
            this.lbl_surname.Name = "lbl_surname";
            this.lbl_surname.Size = new System.Drawing.Size(62, 25);
            this.lbl_surname.TabIndex = 3;
            this.lbl_surname.Text = "Soyad";
            // 
            // lbl_name
            // 
            this.lbl_name.AutoSize = true;
            this.lbl_name.Location = new System.Drawing.Point(21, 63);
            this.lbl_name.Name = "lbl_name";
            this.lbl_name.Size = new System.Drawing.Size(35, 25);
            this.lbl_name.TabIndex = 2;
            this.lbl_name.Text = "Ad";
            // 
            // btn_add
            // 
            this.btn_add.Location = new System.Drawing.Point(419, 537);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(112, 34);
            this.btn_add.TabIndex = 1;
            this.btn_add.Text = "Əlavə et";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // btn_change
            // 
            this.btn_change.Location = new System.Drawing.Point(419, 482);
            this.btn_change.Name = "btn_change";
            this.btn_change.Size = new System.Drawing.Size(112, 34);
            this.btn_change.TabIndex = 0;
            this.btn_change.Text = "Dəyiş";
            this.btn_change.UseVisualStyleBackColor = true;
            // 
            // listBox
            // 
            this.listBox.FormattingEnabled = true;
            this.listBox.ItemHeight = 25;
            this.listBox.Items.AddRange(new object[] {
            "Mirza",
            "Elvin",
            "Alakbar",
            "Bünyamin"});
            this.listBox.Location = new System.Drawing.Point(612, 33);
            this.listBox.Name = "listBox";
            this.listBox.Size = new System.Drawing.Size(326, 454);
            this.listBox.TabIndex = 1;
            // 
            // btn_save
            // 
            this.btn_save.Location = new System.Drawing.Point(774, 559);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(139, 34);
            this.btn_save.TabIndex = 2;
            this.btn_save.Text = "Save";
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // btn_load
            // 
            this.btn_load.Location = new System.Drawing.Point(631, 559);
            this.btn_load.Name = "btn_load";
            this.btn_load.Size = new System.Drawing.Size(137, 34);
            this.btn_load.TabIndex = 3;
            this.btn_load.Text = "Load";
            this.btn_load.UseVisualStyleBackColor = true;
            this.btn_load.Click += new System.EventHandler(this.btn_load_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(631, 504);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(282, 31);
            this.textBox1.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(950, 654);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btn_load);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.listBox);
            this.Controls.Add(this.Anket);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Anket.ResumeLayout(false);
            this.Anket.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox Anket;
        private System.Windows.Forms.Label lbl_born;
        private System.Windows.Forms.Label lbl_phone;
        private System.Windows.Forms.Label lbl_email;
        private System.Windows.Forms.Label lbl_surname;
        private System.Windows.Forms.Label lbl_name;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Button btn_change;
        private System.Windows.Forms.ListBox listBox;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.Button btn_load;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox txt_email;
        private System.Windows.Forms.TextBox txt_number;
        private System.Windows.Forms.TextBox txt_born;
        private System.Windows.Forms.TextBox txt_surname;
        private System.Windows.Forms.TextBox txt_name;
    }
}

