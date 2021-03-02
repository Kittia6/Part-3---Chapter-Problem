namespace Part_3___Chapter_Problem
{
    partial class BasicInput
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
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtAge = new System.Windows.Forms.TextBox();
            this.txtHeight = new System.Windows.Forms.TextBox();
            this.lblname = new System.Windows.Forms.Label();
            this.lblAge = new System.Windows.Forms.Label();
            this.lblHeight = new System.Windows.Forms.Label();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.lblResultName = new System.Windows.Forms.Label();
            this.lblResultAge = new System.Windows.Forms.Label();
            this.lblResultHeight = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(274, 59);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(277, 20);
            this.txtName.TabIndex = 0;
            // 
            // txtAge
            // 
            this.txtAge.Location = new System.Drawing.Point(274, 168);
            this.txtAge.Name = "txtAge";
            this.txtAge.Size = new System.Drawing.Size(277, 20);
            this.txtAge.TabIndex = 1;
            // 
            // txtHeight
            // 
            this.txtHeight.Location = new System.Drawing.Point(274, 277);
            this.txtHeight.Name = "txtHeight";
            this.txtHeight.Size = new System.Drawing.Size(277, 20);
            this.txtHeight.TabIndex = 2;
            // 
            // lblname
            // 
            this.lblname.AutoSize = true;
            this.lblname.Font = new System.Drawing.Font("Harrington", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblname.Location = new System.Drawing.Point(98, 61);
            this.lblname.Name = "lblname";
            this.lblname.Size = new System.Drawing.Size(141, 15);
            this.lblname.TabIndex = 3;
            this.lblname.Text = "Please enter your name:";
            // 
            // lblAge
            // 
            this.lblAge.AutoSize = true;
            this.lblAge.Font = new System.Drawing.Font("Harrington", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAge.Location = new System.Drawing.Point(108, 170);
            this.lblAge.Name = "lblAge";
            this.lblAge.Size = new System.Drawing.Size(131, 15);
            this.lblAge.TabIndex = 4;
            this.lblAge.Text = "Please enter your age:";
            // 
            // lblHeight
            // 
            this.lblHeight.AutoSize = true;
            this.lblHeight.Font = new System.Drawing.Font("Harrington", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeight.Location = new System.Drawing.Point(69, 277);
            this.lblHeight.Name = "lblHeight";
            this.lblHeight.Size = new System.Drawing.Size(170, 15);
            this.lblHeight.TabIndex = 5;
            this.lblHeight.Text = "Please enter your height (m): ";
            // 
            // btnSubmit
            // 
            this.btnSubmit.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnSubmit.Font = new System.Drawing.Font("Old English Text MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmit.Location = new System.Drawing.Point(312, 383);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(134, 40);
            this.btnSubmit.TabIndex = 6;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = false;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // lblResultName
            // 
            this.lblResultName.AutoSize = true;
            this.lblResultName.Font = new System.Drawing.Font("Centaur", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResultName.Location = new System.Drawing.Point(271, 103);
            this.lblResultName.Name = "lblResultName";
            this.lblResultName.Size = new System.Drawing.Size(48, 17);
            this.lblResultName.TabIndex = 7;
            this.lblResultName.Text = "Result";
            // 
            // lblResultAge
            // 
            this.lblResultAge.AutoSize = true;
            this.lblResultAge.Font = new System.Drawing.Font("Centaur", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResultAge.Location = new System.Drawing.Point(271, 228);
            this.lblResultAge.Name = "lblResultAge";
            this.lblResultAge.Size = new System.Drawing.Size(48, 17);
            this.lblResultAge.TabIndex = 8;
            this.lblResultAge.Text = "Result";
            // 
            // lblResultHeight
            // 
            this.lblResultHeight.AutoSize = true;
            this.lblResultHeight.Font = new System.Drawing.Font("Centaur", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResultHeight.Location = new System.Drawing.Point(271, 330);
            this.lblResultHeight.Name = "lblResultHeight";
            this.lblResultHeight.Size = new System.Drawing.Size(48, 17);
            this.lblResultHeight.TabIndex = 9;
            this.lblResultHeight.Text = "Result";
            // 
            // BasicInput
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(712, 450);
            this.Controls.Add(this.lblResultHeight);
            this.Controls.Add(this.lblResultAge);
            this.Controls.Add(this.lblResultName);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.lblHeight);
            this.Controls.Add(this.lblAge);
            this.Controls.Add(this.lblname);
            this.Controls.Add(this.txtHeight);
            this.Controls.Add(this.txtAge);
            this.Controls.Add(this.txtName);
            this.Name = "BasicInput";
            this.Text = "Chapter Problem";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtAge;
        private System.Windows.Forms.TextBox txtHeight;
        private System.Windows.Forms.Label lblname;
        private System.Windows.Forms.Label lblAge;
        private System.Windows.Forms.Label lblHeight;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Label lblResultName;
        private System.Windows.Forms.Label lblResultAge;
        private System.Windows.Forms.Label lblResultHeight;
    }
}

