﻿
namespace BookingSytem
{
    partial class Vehicle_Edit
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
            this.label1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.Carmake = new System.Windows.Forms.TextBox();
            this.CarModel = new System.Windows.Forms.TextBox();
            this.CarID = new System.Windows.Forms.TextBox();
            this.labe = new System.Windows.Forms.Label();
            this.Car_Make = new System.Windows.Forms.Label();
            this.Car_Mobel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.CarReg = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(320, 22);
            this.label1.TabIndex = 44;
            this.label1.Text = "Please Selcet a Vehicle to Editing ";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.Control;
            this.button2.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button2.Font = new System.Drawing.Font("Kristen ITC", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(422, 142);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(112, 23);
            this.button2.TabIndex = 43;
            this.button2.Text = "Back";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.Control;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button1.Font = new System.Drawing.Font("Kristen ITC", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(541, 142);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(112, 23);
            this.button1.TabIndex = 42;
            this.button1.Text = "Submit";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Carmake
            // 
            this.Carmake.Location = new System.Drawing.Point(538, 80);
            this.Carmake.Name = "Carmake";
            this.Carmake.Size = new System.Drawing.Size(115, 20);
            this.Carmake.TabIndex = 41;
            // 
            // CarModel
            // 
            this.CarModel.Location = new System.Drawing.Point(538, 54);
            this.CarModel.Name = "CarModel";
            this.CarModel.Size = new System.Drawing.Size(115, 20);
            this.CarModel.TabIndex = 40;
            // 
            // CarID
            // 
            this.CarID.Location = new System.Drawing.Point(538, 27);
            this.CarID.Name = "CarID";
            this.CarID.Size = new System.Drawing.Size(115, 20);
            this.CarID.TabIndex = 39;
            // 
            // labe
            // 
            this.labe.AutoSize = true;
            this.labe.Location = new System.Drawing.Point(430, 106);
            this.labe.Name = "labe";
            this.labe.Size = new System.Drawing.Size(82, 13);
            this.labe.TabIndex = 35;
            this.labe.Text = "Car Registration";
            // 
            // Car_Make
            // 
            this.Car_Make.AutoSize = true;
            this.Car_Make.Location = new System.Drawing.Point(431, 80);
            this.Car_Make.Name = "Car_Make";
            this.Car_Make.Size = new System.Drawing.Size(53, 13);
            this.Car_Make.TabIndex = 34;
            this.Car_Make.Text = "Car Make";
            // 
            // Car_Mobel
            // 
            this.Car_Mobel.AutoSize = true;
            this.Car_Mobel.Location = new System.Drawing.Point(431, 54);
            this.Car_Mobel.Name = "Car_Mobel";
            this.Car_Mobel.Size = new System.Drawing.Size(55, 13);
            this.Car_Mobel.TabIndex = 33;
            this.Car_Mobel.Text = "Car Model";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(431, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 45;
            this.label2.Text = "Car Id";
            // 
            // CarReg
            // 
            this.CarReg.Location = new System.Drawing.Point(538, 106);
            this.CarReg.Name = "CarReg";
            this.CarReg.Size = new System.Drawing.Size(115, 20);
            this.CarReg.TabIndex = 46;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 34);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(404, 131);
            this.dataGridView1.TabIndex = 55;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Vehicle_Edit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(675, 177);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.CarReg);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Carmake);
            this.Controls.Add(this.CarModel);
            this.Controls.Add(this.CarID);
            this.Controls.Add(this.labe);
            this.Controls.Add(this.Car_Make);
            this.Controls.Add(this.Car_Mobel);
            this.Name = "Vehicle_Edit";
            this.Text = "Vehicle_Edit";
            this.Load += new System.EventHandler(this.Vehicle_Edit_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox Carmake;
        private System.Windows.Forms.TextBox CarModel;
        private System.Windows.Forms.TextBox CarID;
        private System.Windows.Forms.Label labe;
        private System.Windows.Forms.Label Car_Make;
        private System.Windows.Forms.Label Car_Mobel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox CarReg;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}