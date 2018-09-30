namespace Bank_codefFirst.Forms
{
    partial class CreditForm
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
            this.btn_credit = new System.Windows.Forms.Button();
            this.txt_amount = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_pname = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_show = new System.Windows.Forms.Button();
            this.Date_Credit = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // btn_credit
            // 
            this.btn_credit.Location = new System.Drawing.Point(16, 225);
            this.btn_credit.Name = "btn_credit";
            this.btn_credit.Size = new System.Drawing.Size(129, 60);
            this.btn_credit.TabIndex = 13;
            this.btn_credit.Text = "Add";
            this.btn_credit.UseVisualStyleBackColor = true;
            this.btn_credit.Click += new System.EventHandler(this.btn_person_Click);
            // 
            // txt_amount
            // 
            this.txt_amount.Location = new System.Drawing.Point(16, 158);
            this.txt_amount.Name = "txt_amount";
            this.txt_amount.Size = new System.Drawing.Size(377, 26);
            this.txt_amount.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 135);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 20);
            this.label3.TabIndex = 11;
            this.label3.Text = "Amount:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 20);
            this.label2.TabIndex = 9;
            this.label2.Text = "Disburs:";
            // 
            // txt_pname
            // 
            this.txt_pname.Location = new System.Drawing.Point(16, 53);
            this.txt_pname.Name = "txt_pname";
            this.txt_pname.ReadOnly = true;
            this.txt_pname.Size = new System.Drawing.Size(377, 26);
            this.txt_pname.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 20);
            this.label1.TabIndex = 7;
            this.label1.Text = "Name:";
            // 
            // btn_show
            // 
            this.btn_show.Location = new System.Drawing.Point(264, 225);
            this.btn_show.Name = "btn_show";
            this.btn_show.Size = new System.Drawing.Size(129, 60);
            this.btn_show.TabIndex = 14;
            this.btn_show.Text = "Show all";
            this.btn_show.UseVisualStyleBackColor = true;
            this.btn_show.Click += new System.EventHandler(this.btn_show_Click);
            // 
            // Date_Credit
            // 
            this.Date_Credit.Location = new System.Drawing.Point(16, 106);
            this.Date_Credit.Name = "Date_Credit";
            this.Date_Credit.Size = new System.Drawing.Size(377, 26);
            this.Date_Credit.TabIndex = 15;
            // 
            // CreditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(432, 445);
            this.Controls.Add(this.Date_Credit);
            this.Controls.Add(this.btn_show);
            this.Controls.Add(this.btn_credit);
            this.Controls.Add(this.txt_amount);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_pname);
            this.Controls.Add(this.label1);
            this.Name = "CreditForm";
            this.Load += new System.EventHandler(this.CreditForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_credit;
        private System.Windows.Forms.TextBox txt_amount;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_show;
        public System.Windows.Forms.TextBox txt_pname;
        private System.Windows.Forms.DateTimePicker Date_Credit;
    }
}