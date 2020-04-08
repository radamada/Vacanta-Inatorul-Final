namespace ProiectFinalSE
{
    partial class Form2
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
            this.labelQst = new System.Windows.Forms.Label();
            this.possAns = new System.Windows.Forms.CheckedListBox();
            this.buttNextQ = new System.Windows.Forms.Button();
            this.buttStopQ = new System.Windows.Forms.Button();
            this.dlgNoRespSelected = new System.Windows.Forms.FontDialog();
            this.SuspendLayout();
            // 
            // labelQst
            // 
            this.labelQst.AutoSize = true;
            this.labelQst.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelQst.Location = new System.Drawing.Point(32, 40);
            this.labelQst.Name = "labelQst";
            this.labelQst.Size = new System.Drawing.Size(17, 19);
            this.labelQst.TabIndex = 0;
            this.labelQst.Text = "a";
            this.labelQst.Visible = false;
            // 
            // possAns
            // 
            this.possAns.BackColor = System.Drawing.Color.SlateGray;
            this.possAns.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.possAns.FormattingEnabled = true;
            this.possAns.Location = new System.Drawing.Point(56, 122);
            this.possAns.Name = "possAns";
            this.possAns.Size = new System.Drawing.Size(370, 136);
            this.possAns.TabIndex = 1;
            this.possAns.Visible = false;
            // 
            // buttNextQ
            // 
            this.buttNextQ.Location = new System.Drawing.Point(134, 340);
            this.buttNextQ.Name = "buttNextQ";
            this.buttNextQ.Size = new System.Drawing.Size(160, 50);
            this.buttNextQ.TabIndex = 2;
            this.buttNextQ.Text = "Urmatoarea intrebare!";
            this.buttNextQ.UseVisualStyleBackColor = true;
            this.buttNextQ.Click += new System.EventHandler(this.buttNextQ_Click);
            // 
            // buttStopQ
            // 
            this.buttStopQ.Location = new System.Drawing.Point(603, 340);
            this.buttStopQ.Name = "buttStopQ";
            this.buttStopQ.Size = new System.Drawing.Size(160, 50);
            this.buttStopQ.TabIndex = 3;
            this.buttStopQ.Text = "Renunta";
            this.buttStopQ.UseVisualStyleBackColor = true;
            this.buttStopQ.Click += new System.EventHandler(this.buttStopQ_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SlateGray;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttStopQ);
            this.Controls.Add(this.buttNextQ);
            this.Controls.Add(this.possAns);
            this.Controls.Add(this.labelQst);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelQst;
        private System.Windows.Forms.CheckedListBox possAns;
        private System.Windows.Forms.Button buttNextQ;
        private System.Windows.Forms.Button buttStopQ;
        private System.Windows.Forms.FontDialog dlgNoRespSelected;
    }
}