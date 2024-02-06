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
            this.btnClose = new System.Windows.Forms.Button();
            this.pMainMenu = new System.Windows.Forms.Panel();
            this.btnMinimized = new System.Windows.Forms.Button();
            this.pMainMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnProdyucts
            // 
            this.btnProdyucts.FlatAppearance.BorderSize = 0;
            this.btnProdyucts.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProdyucts.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProdyucts.Location = new System.Drawing.Point(28, 27);
            this.btnProdyucts.Name = "btnProdyucts";
            this.btnProdyucts.Size = new System.Drawing.Size(124, 34);
            this.btnProdyucts.TabIndex = 0;
            this.btnProdyucts.Text = "Products";
            this.btnProdyucts.UseVisualStyleBackColor = true;
            this.btnProdyucts.Click += new System.EventHandler(this.btnProdyucts_Click);
            // 
            // btnContacts
            // 
            this.btnContacts.FlatAppearance.BorderSize = 0;
            this.btnContacts.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnContacts.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F);
            this.btnContacts.Location = new System.Drawing.Point(180, 27);
            this.btnContacts.Name = "btnContacts";
            this.btnContacts.Size = new System.Drawing.Size(124, 34);
            this.btnContacts.TabIndex = 1;
            this.btnContacts.Text = "Contacts";
            this.btnContacts.UseVisualStyleBackColor = true;
            this.btnContacts.Click += new System.EventHandler(this.btnContacts_Click);
            // 
            // btnClose
            // 
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Location = new System.Drawing.Point(749, 3);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(48, 37);
            this.btnClose.TabIndex = 2;
            this.btnClose.Text = "X";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // pMainMenu
            // 
            this.pMainMenu.BackColor = System.Drawing.Color.OrangeRed;
            this.pMainMenu.Controls.Add(this.btnMinimized);
            this.pMainMenu.Controls.Add(this.btnClose);
            this.pMainMenu.Controls.Add(this.btnContacts);
            this.pMainMenu.Controls.Add(this.btnProdyucts);
            this.pMainMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.pMainMenu.Location = new System.Drawing.Point(0, 0);
            this.pMainMenu.Name = "pMainMenu";
            this.pMainMenu.Size = new System.Drawing.Size(800, 89);
            this.pMainMenu.TabIndex = 2;
            // 
            // btnMinimized
            // 
            this.btnMinimized.FlatAppearance.BorderSize = 0;
            this.btnMinimized.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimized.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMinimized.Location = new System.Drawing.Point(706, 3);
            this.btnMinimized.Name = "btnMinimized";
            this.btnMinimized.Size = new System.Drawing.Size(48, 37);
            this.btnMinimized.TabIndex = 3;
            this.btnMinimized.Text = "-";
            this.btnMinimized.UseVisualStyleBackColor = true;
            this.btnMinimized.Click += new System.EventHandler(this.btnMinimized_Click);
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pMainMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainMenu";
            this.Text = "MainMenu";
            this.pMainMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnProdyucts;
        private System.Windows.Forms.Button btnContacts;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Panel pMainMenu;
        private System.Windows.Forms.Button btnMinimized;
    }
}