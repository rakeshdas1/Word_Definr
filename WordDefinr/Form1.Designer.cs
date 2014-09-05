namespace WordDefinr
{
    partial class WordDefinr
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
            this.txtWords = new System.Windows.Forms.RichTextBox();
            this.btnDefine = new System.Windows.Forms.Button();
            this.lblCopied = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtWords
            // 
            this.txtWords.Location = new System.Drawing.Point(1, 36);
            this.txtWords.Name = "txtWords";
            this.txtWords.Size = new System.Drawing.Size(282, 138);
            this.txtWords.TabIndex = 0;
            this.txtWords.Text = "";
            // 
            // btnDefine
            // 
            this.btnDefine.Location = new System.Drawing.Point(105, 179);
            this.btnDefine.Name = "btnDefine";
            this.btnDefine.Size = new System.Drawing.Size(75, 23);
            this.btnDefine.TabIndex = 1;
            this.btnDefine.Text = "Define";
            this.btnDefine.UseVisualStyleBackColor = true;
            this.btnDefine.Click += new System.EventHandler(this.btnDefine_Click);
            // 
            // lblCopied
            // 
            this.lblCopied.AutoSize = true;
            this.lblCopied.Location = new System.Drawing.Point(83, 236);
            this.lblCopied.Name = "lblCopied";
            this.lblCopied.Size = new System.Drawing.Size(0, 13);
            this.lblCopied.TabIndex = 2;
            // 
            // WordDefinr
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.lblCopied);
            this.Controls.Add(this.btnDefine);
            this.Controls.Add(this.txtWords);
            this.Name = "WordDefinr";
            this.Text = "Word Definr";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox txtWords;
        private System.Windows.Forms.Button btnDefine;
        private System.Windows.Forms.Label lblCopied;
    }
}

