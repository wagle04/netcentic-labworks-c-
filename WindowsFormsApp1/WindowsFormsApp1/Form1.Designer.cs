namespace WindowsFormsApp1
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
            this.txtFirstNumber = new System.Windows.Forms.TextBox();
            this.txtSecondNumber = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.txtResult = new System.Windows.Forms.TextBox();
            this.lblResult = new System.Windows.Forms.Label();
            this.btnReset = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCall = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblFirstNumber
            // 
            this.lblFirstNumber.AutoSize = true;
            this.lblFirstNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFirstNumber.Location = new System.Drawing.Point(41, 31);
            this.lblFirstNumber.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFirstNumber.Name = "lblFirstNumber";
            this.lblFirstNumber.Size = new System.Drawing.Size(213, 39);
            this.lblFirstNumber.TabIndex = 0;
            this.lblFirstNumber.Text = "First Number";
            this.lblFirstNumber.Click += new System.EventHandler(this.lblFirstNumber_Click);
            // 
            // lblSecondNumber
            // 
            this.lblSecondNumber.AutoSize = true;
            this.lblSecondNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSecondNumber.Location = new System.Drawing.Point(41, 107);
            this.lblSecondNumber.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSecondNumber.Name = "lblSecondNumber";
            this.lblSecondNumber.Size = new System.Drawing.Size(263, 39);
            this.lblSecondNumber.TabIndex = 1;
            this.lblSecondNumber.Text = "Second Number";
            this.lblSecondNumber.Click += new System.EventHandler(this.label2_Click);
            // 
            // txtFirstNumber
            // 
            this.txtFirstNumber.Location = new System.Drawing.Point(328, 47);
            this.txtFirstNumber.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtFirstNumber.Name = "txtFirstNumber";
            this.txtFirstNumber.Size = new System.Drawing.Size(461, 22);
            this.txtFirstNumber.TabIndex = 2;
            // 
            // txtSecondNumber
            // 
            this.txtSecondNumber.Location = new System.Drawing.Point(328, 107);
            this.txtSecondNumber.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtSecondNumber.Name = "txtSecondNumber";
            this.txtSecondNumber.Size = new System.Drawing.Size(461, 22);
            this.txtSecondNumber.TabIndex = 3;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(395, 274);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(100, 28);
            this.btnAdd.TabIndex = 4;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // txtResult
            // 
            this.txtResult.Location = new System.Drawing.Point(331, 185);
            this.txtResult.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtResult.Name = "txtResult";
            this.txtResult.ReadOnly = true;
            this.txtResult.Size = new System.Drawing.Size(461, 22);
            this.txtResult.TabIndex = 6;
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResult.Location = new System.Drawing.Point(44, 181);
            this.lblResult.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(114, 39);
            this.lblResult.TabIndex = 5;
            this.lblResult.Text = "Result";
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(517, 274);
            this.btnReset.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(100, 28);
            this.btnReset.TabIndex = 7;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(960, 47);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 17);
            this.label1.TabIndex = 8;
            this.label1.Text = "label1";
            // 
            // btnCall
            // 
            this.btnCall.Location = new System.Drawing.Point(641, 274);
            this.btnCall.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCall.Name = "btnCall";
            this.btnCall.Size = new System.Drawing.Size(100, 28);
            this.btnCall.TabIndex = 9;
            this.btnCall.Text = "Call";
            this.btnCall.UseVisualStyleBackColor = true;
            this.btnCall.Click += new System.EventHandler(this.btnCall_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.btnCall);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.txtResult);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtSecondNumber);
            this.Controls.Add(this.txtFirstNumber);
            this.Controls.Add(this.lblSecondNumber);
            this.Controls.Add(this.lblFirstNumber);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblFirstNumber;
        private System.Windows.Forms.Label lblSecondNumber;
        private System.Windows.Forms.TextBox txtFirstNumber;
        private System.Windows.Forms.TextBox txtSecondNumber;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox txtResult;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCall;
    }
}

