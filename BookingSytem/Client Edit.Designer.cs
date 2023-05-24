
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
            this.CSurename = new System.Windows.Forms.TextBox();
            this.CName = new System.Windows.Forms.TextBox();
            this.Client_PH = new System.Windows.Forms.Label();
            this.Client_Surename = new System.Windows.Forms.Label();
            this.ClientName = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Client_id = new System.Windows.Forms.TextBox();
            this.Back = new System.Windows.Forms.Button();
            this.Submite = new System.Windows.Forms.Button();
            this.CPH = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // CSurename
            // 
            this.CSurename.Location = new System.Drawing.Point(546, 97);
            this.CSurename.Name = "CSurename";
            this.CSurename.Size = new System.Drawing.Size(115, 20);
            this.CSurename.TabIndex = 22;
            // 
            // CName
            // 
            this.CName.Location = new System.Drawing.Point(545, 71);
            this.CName.Name = "CName";
            this.CName.Size = new System.Drawing.Size(115, 20);
            this.CName.TabIndex = 21;
            // 
            // Client_PH
            // 
            this.Client_PH.AutoSize = true;
            this.Client_PH.Location = new System.Drawing.Point(444, 123);
            this.Client_PH.Name = "Client_PH";
            this.Client_PH.Size = new System.Drawing.Size(78, 13);
            this.Client_PH.TabIndex = 17;
            this.Client_PH.Text = "Phone Number";
            // 
            // Client_Surename
            // 
            this.Client_Surename.AutoSize = true;
            this.Client_Surename.Location = new System.Drawing.Point(444, 97);
            this.Client_Surename.Name = "Client_Surename";
            this.Client_Surename.Size = new System.Drawing.Size(84, 13);
            this.Client_Surename.TabIndex = 16;
            this.Client_Surename.Text = "Client Surename";
            // 
            // ClientName
            // 
            this.ClientName.AutoSize = true;
            this.ClientName.Location = new System.Drawing.Point(444, 71);
            this.ClientName.Name = "ClientName";
            this.ClientName.Size = new System.Drawing.Size(64, 13);
            this.ClientName.TabIndex = 15;
            this.ClientName.Text = "Client Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 22);
            this.label1.TabIndex = 29;
            this.label1.Text = "Client Editing ";
            // 
            // Client_id
            // 
            this.Client_id.Location = new System.Drawing.Point(545, 46);
            this.Client_id.Name = "Client_id";
            this.Client_id.Size = new System.Drawing.Size(115, 20);
            this.Client_id.TabIndex = 46;
            // 
            // Back
            // 
            this.Back.BackColor = System.Drawing.SystemColors.Control;
            this.Back.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.Back.Font = new System.Drawing.Font("Kristen ITC", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Back.Location = new System.Drawing.Point(562, 163);
            this.Back.Name = "Back";
            this.Back.Size = new System.Drawing.Size(103, 23);
            this.Back.TabIndex = 27;
            this.Back.Text = "Back";
            this.Back.UseVisualStyleBackColor = false;
            this.Back.Click += new System.EventHandler(this.Back_Click);
            // 
            // Submite
            // 
            this.Submite.BackColor = System.Drawing.SystemColors.Control;
            this.Submite.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.Submite.Font = new System.Drawing.Font("Kristen ITC", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Submite.Location = new System.Drawing.Point(453, 163);
            this.Submite.Name = "Submite";
            this.Submite.Size = new System.Drawing.Size(103, 23);
            this.Submite.TabIndex = 52;
            this.Submite.Text = "Submited";
            this.Submite.UseVisualStyleBackColor = false;
            this.Submite.Click += new System.EventHandler(this.Submite_Click);
            // 
            // CPH
            // 
            this.CPH.Location = new System.Drawing.Point(545, 123);
            this.CPH.Name = "CPH";
            this.CPH.Size = new System.Drawing.Size(115, 20);
            this.CPH.TabIndex = 23;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(444, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 53;
            this.label2.Text = "Client ID";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(16, 34);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(404, 157);
            this.dataGridView1.TabIndex = 54;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Client_Edit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(677, 191);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Submite);
            this.Controls.Add(this.Client_id);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Back);
            this.Controls.Add(this.CPH);
            this.Controls.Add(this.CSurename);
            this.Controls.Add(this.CName);
            this.Controls.Add(this.Client_PH);
            this.Controls.Add(this.Client_Surename);
            this.Controls.Add(this.ClientName);
            this.Name = "Client_Edit";
            this.Text = "Client_Edit";
            this.Load += new System.EventHandler(this.Client_Edit_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox CSurename;
        private System.Windows.Forms.TextBox CName;
        private System.Windows.Forms.Label Client_PH;
        private System.Windows.Forms.Label Client_Surename;
        private System.Windows.Forms.Label ClientName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Client_id;
        private System.Windows.Forms.Button Back;
        private System.Windows.Forms.Button Submite;
        private System.Windows.Forms.TextBox CPH;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}