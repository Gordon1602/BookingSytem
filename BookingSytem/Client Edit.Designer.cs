
namespace BookingSytem
{
    partial class Client_Edit
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
            this.button1 = new System.Windows.Forms.Button();
            this.CPH = new System.Windows.Forms.TextBox();
            this.CSurename = new System.Windows.Forms.TextBox();
            this.CName = new System.Windows.Forms.TextBox();
            this.Client_PH = new System.Windows.Forms.Label();
            this.Client_Surename = new System.Windows.Forms.Label();
            this.ClientName = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.CarModel = new System.Windows.Forms.TextBox();
            this.button6 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.Control;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button1.Font = new System.Drawing.Font("Kristen ITC", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(12, 78);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(112, 23);
            this.button1.TabIndex = 27;
            this.button1.Text = "Submited";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // CPH
            // 
            this.CPH.Location = new System.Drawing.Point(240, 114);
            this.CPH.Name = "CPH";
            this.CPH.Size = new System.Drawing.Size(115, 20);
            this.CPH.TabIndex = 23;
            // 
            // CSurename
            // 
            this.CSurename.Location = new System.Drawing.Point(241, 88);
            this.CSurename.Name = "CSurename";
            this.CSurename.Size = new System.Drawing.Size(115, 20);
            this.CSurename.TabIndex = 22;
            // 
            // CName
            // 
            this.CName.Location = new System.Drawing.Point(240, 62);
            this.CName.Name = "CName";
            this.CName.Size = new System.Drawing.Size(115, 20);
            this.CName.TabIndex = 21;
            // 
            // Client_PH
            // 
            this.Client_PH.AutoSize = true;
            this.Client_PH.Location = new System.Drawing.Point(139, 114);
            this.Client_PH.Name = "Client_PH";
            this.Client_PH.Size = new System.Drawing.Size(78, 13);
            this.Client_PH.TabIndex = 17;
            this.Client_PH.Text = "Phone Number";
            // 
            // Client_Surename
            // 
            this.Client_Surename.AutoSize = true;
            this.Client_Surename.Location = new System.Drawing.Point(139, 88);
            this.Client_Surename.Name = "Client_Surename";
            this.Client_Surename.Size = new System.Drawing.Size(84, 13);
            this.Client_Surename.TabIndex = 16;
            this.Client_Surename.Text = "Client Surename";
            // 
            // ClientName
            // 
            this.ClientName.AutoSize = true;
            this.ClientName.Location = new System.Drawing.Point(139, 62);
            this.ClientName.Name = "ClientName";
            this.ClientName.Size = new System.Drawing.Size(64, 13);
            this.ClientName.TabIndex = 15;
            this.ClientName.Text = "Client Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(8, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 22);
            this.label1.TabIndex = 29;
            this.label1.Text = "Client Editing ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(139, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 47;
            this.label2.Text = "Car Id";
            // 
            // CarModel
            // 
            this.CarModel.Location = new System.Drawing.Point(240, 37);
            this.CarModel.Name = "CarModel";
            this.CarModel.Size = new System.Drawing.Size(115, 20);
            this.CarModel.TabIndex = 46;
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.SystemColors.Control;
            this.button6.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.Font = new System.Drawing.Font("Kristen ITC", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.Location = new System.Drawing.Point(12, 107);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(112, 26);
            this.button6.TabIndex = 49;
            this.button6.Text = "Back";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.Control;
            this.button3.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button3.Font = new System.Drawing.Font("Kristen ITC", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(12, 46);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(112, 23);
            this.button3.TabIndex = 50;
            this.button3.Text = "View Vehicle";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // Client_Edit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(370, 136);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.CarModel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.CPH);
            this.Controls.Add(this.CSurename);
            this.Controls.Add(this.CName);
            this.Controls.Add(this.Client_PH);
            this.Controls.Add(this.Client_Surename);
            this.Controls.Add(this.ClientName);
            this.Name = "Client_Edit";
            this.Text = "Client_Edit";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox CPH;
        private System.Windows.Forms.TextBox CSurename;
        private System.Windows.Forms.TextBox CName;
        private System.Windows.Forms.Label Client_PH;
        private System.Windows.Forms.Label Client_Surename;
        private System.Windows.Forms.Label ClientName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox CarModel;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button3;
    }
}