namespace WindowsFormsApplication1
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
            this.btntrans = new System.Windows.Forms.Button();
            this.txtcard = new System.Windows.Forms.TextBox();
            this.txtccv = new System.Windows.Forms.TextBox();
            this.txtamt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btntrans
            // 
            this.btntrans.Location = new System.Drawing.Point(115, 197);
            this.btntrans.Name = "btntrans";
            this.btntrans.Size = new System.Drawing.Size(75, 23);
            this.btntrans.TabIndex = 0;
            this.btntrans.Text = "transaction";
            this.btntrans.UseVisualStyleBackColor = true;
            this.btntrans.Click += new System.EventHandler(this.btntrans_Click);
            // 
            // txtcard
            // 
            this.txtcard.Location = new System.Drawing.Point(157, 52);
            this.txtcard.Name = "txtcard";
            this.txtcard.Size = new System.Drawing.Size(100, 20);
            this.txtcard.TabIndex = 1;
            // 
            // txtccv
            // 
            this.txtccv.Location = new System.Drawing.Point(157, 92);
            this.txtccv.Name = "txtccv";
            this.txtccv.Size = new System.Drawing.Size(100, 20);
            this.txtccv.TabIndex = 2;
            // 
            // txtamt
            // 
            this.txtamt.Location = new System.Drawing.Point(157, 150);
            this.txtamt.Name = "txtamt";
            this.txtamt.Size = new System.Drawing.Size(100, 20);
            this.txtamt.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(41, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "card no";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(41, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "ccv no";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(44, 156);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "amount";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtamt);
            this.Controls.Add(this.txtccv);
            this.Controls.Add(this.txtcard);
            this.Controls.Add(this.btntrans);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btntrans;
        private System.Windows.Forms.TextBox txtcard;
        private System.Windows.Forms.TextBox txtccv;
        private System.Windows.Forms.TextBox txtamt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

