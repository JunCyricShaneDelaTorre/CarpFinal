﻿namespace _2CARPENELLI
{
    partial class ViewTraceResult
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
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnTraceResults = new _2CARPENELLI.RJButton();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox2
            // 
            this.textBox2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox2.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(29)))), ((int)(((byte)(45)))));
            this.textBox2.Location = new System.Drawing.Point(50, 99);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(836, 444);
            this.textBox2.TabIndex = 224;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnTraceResults);
            this.panel1.Location = new System.Drawing.Point(0, 583);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(938, 113);
            this.panel1.TabIndex = 226;
            // 
            // btnTraceResults
            // 
            this.btnTraceResults.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(29)))), ((int)(((byte)(45)))));
            this.btnTraceResults.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(29)))), ((int)(((byte)(45)))));
            this.btnTraceResults.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnTraceResults.BorderRadius = 20;
            this.btnTraceResults.BorderSize = 0;
            this.btnTraceResults.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTraceResults.FlatAppearance.BorderSize = 0;
            this.btnTraceResults.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTraceResults.Font = new System.Drawing.Font("Google Sans", 7.8F, System.Drawing.FontStyle.Bold);
            this.btnTraceResults.ForeColor = System.Drawing.Color.White;
            this.btnTraceResults.Location = new System.Drawing.Point(364, 3);
            this.btnTraceResults.Name = "btnTraceResults";
            this.btnTraceResults.Size = new System.Drawing.Size(206, 53);
            this.btnTraceResults.TabIndex = 227;
            this.btnTraceResults.Text = "TRACE RESULT";
            this.btnTraceResults.TextColor = System.Drawing.Color.White;
            this.btnTraceResults.UseVisualStyleBackColor = false;
            this.btnTraceResults.Click += new System.EventHandler(this.btnTraceResults_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 22.2F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(42, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(373, 44);
            this.label2.TabIndex = 227;
            this.label2.Text = "VIEW TRACE RESULTS";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // ViewTraceResult
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(37)))), ((int)(((byte)(69)))));
            this.ClientSize = new System.Drawing.Size(938, 696);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.textBox2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ViewTraceResult";
            this.Text = "956, 743";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Panel panel1;
        private RJButton btnTraceResults;
        private System.Windows.Forms.Label label2;
    }
}