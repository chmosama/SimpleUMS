namespace OOP_Project
{
    partial class Library_New
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Library_New));
            this.btnsubmit = new System.Windows.Forms.Button();
            this.txtLlastid = new System.Windows.Forms.TextBox();
            this.txtLpublisher = new System.Windows.Forms.TextBox();
            this.txtLname = new System.Windows.Forms.TextBox();
            this.txtLid = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtLclass = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // btnsubmit
            // 
            this.btnsubmit.Font = new System.Drawing.Font("Calibri Light", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsubmit.Location = new System.Drawing.Point(343, 320);
            this.btnsubmit.Name = "btnsubmit";
            this.btnsubmit.Size = new System.Drawing.Size(122, 41);
            this.btnsubmit.TabIndex = 21;
            this.btnsubmit.Text = "Submit";
            this.btnsubmit.UseVisualStyleBackColor = true;
            this.btnsubmit.Click += new System.EventHandler(this.btnsubmit_Click);
            // 
            // txtLlastid
            // 
            this.txtLlastid.Font = new System.Drawing.Font("Calibri Light", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLlastid.Location = new System.Drawing.Point(239, 260);
            this.txtLlastid.Name = "txtLlastid";
            this.txtLlastid.Size = new System.Drawing.Size(226, 34);
            this.txtLlastid.TabIndex = 20;
            // 
            // txtLpublisher
            // 
            this.txtLpublisher.Font = new System.Drawing.Font("Calibri Light", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLpublisher.Location = new System.Drawing.Point(239, 159);
            this.txtLpublisher.Name = "txtLpublisher";
            this.txtLpublisher.Size = new System.Drawing.Size(226, 34);
            this.txtLpublisher.TabIndex = 18;
            // 
            // txtLname
            // 
            this.txtLname.Font = new System.Drawing.Font("Calibri Light", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLname.Location = new System.Drawing.Point(239, 106);
            this.txtLname.Name = "txtLname";
            this.txtLname.Size = new System.Drawing.Size(226, 34);
            this.txtLname.TabIndex = 17;
            // 
            // txtLid
            // 
            this.txtLid.Font = new System.Drawing.Font("Calibri Light", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLid.Location = new System.Drawing.Point(239, 52);
            this.txtLid.Name = "txtLid";
            this.txtLid.Size = new System.Drawing.Size(226, 34);
            this.txtLid.TabIndex = 16;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri Light", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(60, 260);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(170, 27);
            this.label5.TabIndex = 15;
            this.label5.Text = "Last Borrower ID :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri Light", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(60, 209);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(117, 27);
            this.label4.TabIndex = 14;
            this.label4.Text = "Book Class :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri Light", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(60, 159);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(162, 27);
            this.label3.TabIndex = 13;
            this.label3.Text = "Publisher Name :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri Light", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(60, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 27);
            this.label2.TabIndex = 12;
            this.label2.Text = "Book Name :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri Light", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(60, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 27);
            this.label1.TabIndex = 11;
            this.label1.Text = "Book ID :";
            // 
            // txtLclass
            // 
            this.txtLclass.Font = new System.Drawing.Font("Calibri Light", 13F);
            this.txtLclass.FormattingEnabled = true;
            this.txtLclass.Items.AddRange(new object[] {
            "Computer",
            "Math",
            "Urdu",
            "English"});
            this.txtLclass.Location = new System.Drawing.Point(239, 209);
            this.txtLclass.Name = "txtLclass";
            this.txtLclass.Size = new System.Drawing.Size(226, 35);
            this.txtLclass.TabIndex = 23;
            // 
            // Library_New
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(525, 457);
            this.Controls.Add(this.txtLclass);
            this.Controls.Add(this.btnsubmit);
            this.Controls.Add(this.txtLlastid);
            this.Controls.Add(this.txtLpublisher);
            this.Controls.Add(this.txtLname);
            this.Controls.Add(this.txtLid);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Library_New";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add New Library Record";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnsubmit;
        private System.Windows.Forms.TextBox txtLlastid;
        private System.Windows.Forms.TextBox txtLpublisher;
        private System.Windows.Forms.TextBox txtLname;
        private System.Windows.Forms.TextBox txtLid;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox txtLclass;
    }
}