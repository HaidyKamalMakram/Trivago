namespace ODP2
{
    partial class Rental_Form
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
            this.txt_title = new System.Windows.Forms.TextBox();
            this.cmb_copies = new System.Windows.Forms.ComboBox();
            this.txt_memID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_DateRented = new System.Windows.Forms.TextBox();
            this.txt_DateBack = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_cost = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btn_rent = new System.Windows.Forms.Button();
            this.btn_showCopies = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txt_title
            // 
            this.txt_title.Location = new System.Drawing.Point(120, 34);
            this.txt_title.Name = "txt_title";
            this.txt_title.Size = new System.Drawing.Size(197, 20);
            this.txt_title.TabIndex = 0;
            // 
            // cmb_copies
            // 
            this.cmb_copies.FormattingEnabled = true;
            this.cmb_copies.Location = new System.Drawing.Point(120, 75);
            this.cmb_copies.Name = "cmb_copies";
            this.cmb_copies.Size = new System.Drawing.Size(86, 21);
            this.cmb_copies.TabIndex = 1;
            // 
            // txt_memID
            // 
            this.txt_memID.Location = new System.Drawing.Point(120, 114);
            this.txt_memID.Name = "txt_memID";
            this.txt_memID.Size = new System.Drawing.Size(86, 20);
            this.txt_memID.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Film Title";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Available copy IDs";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 121);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Member ID";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(27, 154);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Date Rented";
            // 
            // txt_DateRented
            // 
            this.txt_DateRented.Location = new System.Drawing.Point(120, 154);
            this.txt_DateRented.Name = "txt_DateRented";
            this.txt_DateRented.Size = new System.Drawing.Size(130, 20);
            this.txt_DateRented.TabIndex = 8;
            // 
            // txt_DateBack
            // 
            this.txt_DateBack.Location = new System.Drawing.Point(120, 191);
            this.txt_DateBack.Name = "txt_DateBack";
            this.txt_DateBack.Size = new System.Drawing.Size(130, 20);
            this.txt_DateBack.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(27, 198);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Date Due Back";
            // 
            // txt_cost
            // 
            this.txt_cost.Location = new System.Drawing.Point(120, 229);
            this.txt_cost.Name = "txt_cost";
            this.txt_cost.Size = new System.Drawing.Size(86, 20);
            this.txt_cost.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(27, 236);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Rental Cost";
            // 
            // btn_rent
            // 
            this.btn_rent.Location = new System.Drawing.Point(160, 288);
            this.btn_rent.Name = "btn_rent";
            this.btn_rent.Size = new System.Drawing.Size(75, 28);
            this.btn_rent.TabIndex = 13;
            this.btn_rent.Text = "Rent";
            this.btn_rent.UseVisualStyleBackColor = true;
            this.btn_rent.Click += new System.EventHandler(this.btn_rent_Click);
            // 
            // btn_showCopies
            // 
            this.btn_showCopies.Location = new System.Drawing.Point(223, 75);
            this.btn_showCopies.Name = "btn_showCopies";
            this.btn_showCopies.Size = new System.Drawing.Size(130, 23);
            this.btn_showCopies.TabIndex = 14;
            this.btn_showCopies.Text = "Show Available Copies";
            this.btn_showCopies.UseVisualStyleBackColor = true;
            this.btn_showCopies.Click += new System.EventHandler(this.btn_showCopies_Click);
            // 
            // Rental_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(379, 337);
            this.Controls.Add(this.btn_showCopies);
            this.Controls.Add(this.btn_rent);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txt_cost);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txt_DateBack);
            this.Controls.Add(this.txt_DateRented);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_memID);
            this.Controls.Add(this.cmb_copies);
            this.Controls.Add(this.txt_title);
            this.Name = "Rental_Form";
            this.Text = "Rental Form";
            this.Load += new System.EventHandler(this.Rental_Form_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_title;
        private System.Windows.Forms.ComboBox cmb_copies;
        private System.Windows.Forms.TextBox txt_memID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_DateRented;
        private System.Windows.Forms.TextBox txt_DateBack;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_cost;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btn_rent;
        private System.Windows.Forms.Button btn_showCopies;
    }
}

