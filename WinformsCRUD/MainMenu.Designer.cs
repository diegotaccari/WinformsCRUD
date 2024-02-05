namespace WinformsCRUD
{
    partial class MainMenu
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
            this.btnProdyucts = new System.Windows.Forms.Button();
            this.btnContacts = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnProdyucts
            // 
            this.btnProdyucts.Location = new System.Drawing.Point(80, 35);
            this.btnProdyucts.Name = "btnProdyucts";
            this.btnProdyucts.Size = new System.Drawing.Size(124, 34);
            this.btnProdyucts.TabIndex = 0;
            this.btnProdyucts.Text = "Products";
            this.btnProdyucts.UseVisualStyleBackColor = true;
            this.btnProdyucts.Click += new System.EventHandler(this.btnProdyucts_Click);
            // 
            // btnContacts
            // 
            this.btnContacts.Location = new System.Drawing.Point(299, 35);
            this.btnContacts.Name = "btnContacts";
            this.btnContacts.Size = new System.Drawing.Size(124, 34);
            this.btnContacts.TabIndex = 1;
            this.btnContacts.Text = "Contacts";
            this.btnContacts.UseVisualStyleBackColor = true;
            this.btnContacts.Click += new System.EventHandler(this.btnContacts_Click);
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnContacts);
            this.Controls.Add(this.btnProdyucts);
            this.Name = "MainMenu";
            this.Text = "MainMenu";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnProdyucts;
        private System.Windows.Forms.Button btnContacts;
    }
}