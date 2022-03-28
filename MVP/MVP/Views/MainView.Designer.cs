namespace MVP.Views
{
    partial class MainView
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
            this.label_model = new System.Windows.Forms.Label();
            this.label_year = new System.Windows.Forms.Label();
            this.label_vendor = new System.Windows.Forms.Label();
            this.label_engine = new System.Windows.Forms.Label();
            this.textBox_Model = new System.Windows.Forms.TextBox();
            this.textBox_Year = new System.Windows.Forms.TextBox();
            this.textBox_Vendor = new System.Windows.Forms.TextBox();
            this.textBox_Volume = new System.Windows.Forms.TextBox();
            this.Cars = new System.Windows.Forms.ListBox();
            this.button_Load = new System.Windows.Forms.Button();
            this.button_Add = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label_model
            // 
            this.label_model.AutoSize = true;
            this.label_model.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_model.Location = new System.Drawing.Point(64, 46);
            this.label_model.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_model.Name = "label_model";
            this.label_model.Size = new System.Drawing.Size(74, 27);
            this.label_model.TabIndex = 0;
            this.label_model.Text = "Model";
            // 
            // label_year
            // 
            this.label_year.AutoSize = true;
            this.label_year.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_year.Location = new System.Drawing.Point(64, 123);
            this.label_year.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_year.Name = "label_year";
            this.label_year.Size = new System.Drawing.Size(57, 27);
            this.label_year.TabIndex = 0;
            this.label_year.Text = "Year";
            // 
            // label_vendor
            // 
            this.label_vendor.AutoSize = true;
            this.label_vendor.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_vendor.Location = new System.Drawing.Point(64, 198);
            this.label_vendor.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_vendor.Name = "label_vendor";
            this.label_vendor.Size = new System.Drawing.Size(80, 27);
            this.label_vendor.TabIndex = 0;
            this.label_vendor.Text = "Vendor";
            // 
            // label_engine
            // 
            this.label_engine.AutoSize = true;
            this.label_engine.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_engine.Location = new System.Drawing.Point(64, 279);
            this.label_engine.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_engine.Name = "label_engine";
            this.label_engine.Size = new System.Drawing.Size(157, 27);
            this.label_engine.TabIndex = 0;
            this.label_engine.Text = "Engine Volume";
            // 
            // textBox_Model
            // 
            this.textBox_Model.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_Model.Location = new System.Drawing.Point(345, 46);
            this.textBox_Model.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_Model.Name = "textBox_Model";
            this.textBox_Model.Size = new System.Drawing.Size(250, 35);
            this.textBox_Model.TabIndex = 1;
            // 
            // textBox_Year
            // 
            this.textBox_Year.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_Year.Location = new System.Drawing.Point(345, 123);
            this.textBox_Year.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_Year.Name = "textBox_Year";
            this.textBox_Year.Size = new System.Drawing.Size(250, 35);
            this.textBox_Year.TabIndex = 1;
            // 
            // textBox_Vendor
            // 
            this.textBox_Vendor.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_Vendor.Location = new System.Drawing.Point(345, 198);
            this.textBox_Vendor.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_Vendor.Name = "textBox_Vendor";
            this.textBox_Vendor.Size = new System.Drawing.Size(250, 35);
            this.textBox_Vendor.TabIndex = 1;
            // 
            // textBox_Volume
            // 
            this.textBox_Volume.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_Volume.Location = new System.Drawing.Point(345, 279);
            this.textBox_Volume.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_Volume.Name = "textBox_Volume";
            this.textBox_Volume.Size = new System.Drawing.Size(250, 35);
            this.textBox_Volume.TabIndex = 1;
            // 
            // Cars
            // 
            this.Cars.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Cars.FormattingEnabled = true;
            this.Cars.ItemHeight = 27;
            this.Cars.Location = new System.Drawing.Point(810, 46);
            this.Cars.Margin = new System.Windows.Forms.Padding(4);
            this.Cars.Name = "Cars";
            this.Cars.Size = new System.Drawing.Size(423, 274);
            this.Cars.TabIndex = 2;
            // 
            // button_Load
            // 
            this.button_Load.AutoSize = true;
            this.button_Load.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_Load.Location = new System.Drawing.Point(1081, 362);
            this.button_Load.Margin = new System.Windows.Forms.Padding(4);
            this.button_Load.Name = "button_Load";
            this.button_Load.Size = new System.Drawing.Size(152, 45);
            this.button_Load.TabIndex = 3;
            this.button_Load.Text = "Load";
            this.button_Load.UseVisualStyleBackColor = true;
            // 
            // button_Add
            // 
            this.button_Add.AutoSize = true;
            this.button_Add.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_Add.Location = new System.Drawing.Point(445, 362);
            this.button_Add.Margin = new System.Windows.Forms.Padding(4);
            this.button_Add.Name = "button_Add";
            this.button_Add.Size = new System.Drawing.Size(150, 45);
            this.button_Add.TabIndex = 3;
            this.button_Add.Text = "Add";
            this.button_Add.UseVisualStyleBackColor = true;
            // 
            // MainView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 27F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1312, 788);
            this.Controls.Add(this.button_Add);
            this.Controls.Add(this.button_Load);
            this.Controls.Add(this.Cars);
            this.Controls.Add(this.textBox_Volume);
            this.Controls.Add(this.textBox_Vendor);
            this.Controls.Add(this.textBox_Year);
            this.Controls.Add(this.textBox_Model);
            this.Controls.Add(this.label_engine);
            this.Controls.Add(this.label_vendor);
            this.Controls.Add(this.label_year);
            this.Controls.Add(this.label_model);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MainView";
            this.Text = "MainView";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_model;
        private System.Windows.Forms.Label label_year;
        private System.Windows.Forms.Label label_vendor;
        private System.Windows.Forms.Label label_engine;
        private System.Windows.Forms.TextBox textBox_Model;
        private System.Windows.Forms.TextBox textBox_Year;
        private System.Windows.Forms.TextBox textBox_Vendor;
        private System.Windows.Forms.TextBox textBox_Volume;
        private System.Windows.Forms.ListBox Cars;
        private System.Windows.Forms.Button button_Load;
        private System.Windows.Forms.Button button_Add;
    }
}