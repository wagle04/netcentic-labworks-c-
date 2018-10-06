namespace GUI_for_Csharp
{
    partial class Form1
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
            this.lblFirstNumber = new System.Windows.Forms.Label();
            this.lblSecondNumber = new System.Windows.Forms.Label();
            this.lblResult = new System.Windows.Forms.Label();
            this.txtFirstNumber = new System.Windows.Forms.TextBox();
            this.txtSecondNumber = new System.Windows.Forms.TextBox();
            this.txtResult = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnclear = new System.Windows.Forms.Button();
            this.lblTime = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblFirstNumber
            // 
            this.lblFirstNumber.AutoSize = true;
            this.lblFirstNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.lblFirstNumber.Location = new System.Drawing.Point(49, 38);
            this.lblFirstNumber.Name = "lblFirstNumber";
            this.lblFirstNumber.Size = new System.Drawing.Size(171, 31);
            this.lblFirstNumber.TabIndex = 0;
            this.lblFirstNumber.Text = "First Number";
            this.lblFirstNumber.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblSecondNumber
            // 
            this.lblSecondNumber.AutoSize = true;
            this.lblSecondNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.lblSecondNumber.Location = new System.Drawing.Point(49, 100);
            this.lblSecondNumber.Name = "lblSecondNumber";
            this.lblSecondNumber.Size = new System.Drawing.Size(209, 31);
            this.lblSecondNumber.TabIndex = 1;
            this.lblSecondNumber.Text = "Second Number";
            this.lblSecondNumber.Click += new System.EventHandler(this.label2_Click);
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.lblResult.Location = new System.Drawing.Point(52, 168);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(92, 31);
            this.lblResult.TabIndex = 2;
            this.lblResult.Text = "Result";
            this.lblResult.Click += new System.EventHandler(this.label3_Click);
            // 
            // txtFirstNumber
            // 
            this.txtFirstNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.txtFirstNumber.Location = new System.Drawing.Point(306, 49);
            this.txtFirstNumber.Name = "txtFirstNumber";
            this.txtFirstNumber.Size = new System.Drawing.Size(252, 30);
            this.txtFirstNumber.TabIndex = 3;
            this.txtFirstNumber.TextChanged += new System.EventHandler(this.txtFirstNumber_TextChanged);
            // 
            // txtSecondNumber
            // 
            this.txtSecondNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.txtSecondNumber.Location = new System.Drawing.Point(306, 112);
            this.txtSecondNumber.Name = "txtSecondNumber";
            this.txtSecondNumber.Size = new System.Drawing.Size(252, 30);
            this.txtSecondNumber.TabIndex = 4;
            this.txtSecondNumber.TextChanged += new System.EventHandler(this.txtSecondNumber_TextChanged);
            // 
            // txtResult
            // 
            this.txtResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.txtResult.Location = new System.Drawing.Point(306, 180);
            this.txtResult.Name = "txtResult";
            this.txtResult.ReadOnly = true;
            this.txtResult.Size = new System.Drawing.Size(252, 30);
            this.txtResult.TabIndex = 5;
            this.txtResult.TextChanged += new System.EventHandler(this.txtResult_TextChanged);
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.btnAdd.Location = new System.Drawing.Point(306, 271);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(94, 34);
            this.btnAdd.TabIndex = 6;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnclear
            // 
            this.btnclear.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.btnclear.Location = new System.Drawing.Point(473, 271);
            this.btnclear.Name = "btnclear";
            this.btnclear.Size = new System.Drawing.Size(85, 34);
            this.btnclear.TabIndex = 7;
            this.btnclear.Text = "Clear";
            this.btnclear.UseVisualStyleBackColor = true;
            this.btnclear.Click += new System.EventHandler(this.btnclear_Click);
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.lblTime.Location = new System.Drawing.Point(694, 66);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(0, 25);
            this.lblTime.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblTime);
            this.Controls.Add(this.btnclear);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtResult);
            this.Controls.Add(this.txtSecondNumber);
            this.Controls.Add(this.txtFirstNumber);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.lblSecondNumber);
            this.Controls.Add(this.lblFirstNumber);
            this.Name = "Form1";
            this.Text = "Addition Form";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblFirstNumber;
        private System.Windows.Forms.Label lblSecondNumber;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.TextBox txtFirstNumber;
        private System.Windows.Forms.TextBox txtSecondNumber;
        private System.Windows.Forms.TextBox txtResult;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnclear;
        private System.Windows.Forms.Label lblTime;
    }
}

