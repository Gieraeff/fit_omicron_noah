namespace FormsIntroduction
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txb_name = new System.Windows.Forms.TextBox();
            this.txb_city = new System.Windows.Forms.TextBox();
            this.btt_cancel = new System.Windows.Forms.Button();
            this.btt_ok = new System.Windows.Forms.Button();
            this.lbl_header = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 110);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 147);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(24, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "City";
            // 
            // txb_name
            // 
            this.txb_name.BackColor = System.Drawing.SystemColors.Window;
            this.txb_name.Location = new System.Drawing.Point(61, 102);
            this.txb_name.Name = "txb_name";
            this.txb_name.Size = new System.Drawing.Size(383, 20);
            this.txb_name.TabIndex = 2;
            // 
            // txb_city
            // 
            this.txb_city.BackColor = System.Drawing.SystemColors.Window;
            this.txb_city.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txb_city.Location = new System.Drawing.Point(61, 140);
            this.txb_city.Name = "txb_city";
            this.txb_city.Size = new System.Drawing.Size(383, 20);
            this.txb_city.TabIndex = 3;
            // 
            // btt_cancel
            // 
            this.btt_cancel.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btt_cancel.BackColor = System.Drawing.Color.Green;
            this.btt_cancel.ForeColor = System.Drawing.Color.Black;
            this.btt_cancel.Location = new System.Drawing.Point(61, 327);
            this.btt_cancel.Name = "btt_cancel";
            this.btt_cancel.Size = new System.Drawing.Size(75, 23);
            this.btt_cancel.TabIndex = 4;
            this.btt_cancel.Text = "Cancel";
            this.btt_cancel.UseVisualStyleBackColor = false;
            this.btt_cancel.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // btt_ok
            // 
            this.btt_ok.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btt_ok.BackColor = System.Drawing.Color.Firebrick;
            this.btt_ok.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btt_ok.ForeColor = System.Drawing.Color.Black;
            this.btt_ok.Location = new System.Drawing.Point(369, 327);
            this.btt_ok.Name = "btt_ok";
            this.btt_ok.Size = new System.Drawing.Size(75, 23);
            this.btt_ok.TabIndex = 5;
            this.btt_ok.Text = "OK";
            this.btt_ok.UseVisualStyleBackColor = false;
            this.btt_ok.Click += new System.EventHandler(this.btt_ok_Click);
            // 
            // lbl_header
            // 
            this.lbl_header.AutoSize = true;
            this.lbl_header.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_header.Location = new System.Drawing.Point(56, 26);
            this.lbl_header.Name = "lbl_header";
            this.lbl_header.Size = new System.Drawing.Size(181, 30);
            this.lbl_header.TabIndex = 6;
            this.lbl_header.Text = "Hello Test User!";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ClientSize = new System.Drawing.Size(489, 375);
            this.Controls.Add(this.lbl_header);
            this.Controls.Add(this.btt_ok);
            this.Controls.Add(this.btt_cancel);
            this.Controls.Add(this.txb_city);
            this.Controls.Add(this.txb_name);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Cursor = System.Windows.Forms.Cursors.AppStarting;
            this.HelpButton = true;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(505, 800);
            this.Name = "Form1";
            this.Text = "Basic Form Application";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txb_name;
        private System.Windows.Forms.TextBox txb_city;
        private System.Windows.Forms.Button btt_cancel;
        private System.Windows.Forms.Button btt_ok;
        private System.Windows.Forms.Label lbl_header;
    }
}

