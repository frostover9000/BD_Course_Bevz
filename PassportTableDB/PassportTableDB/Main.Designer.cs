namespace PassportTableDB
{
    partial class Main
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
            this.CivizenButton = new System.Windows.Forms.Button();
            this.PassportButton = new System.Windows.Forms.Button();
            this.ServiceButton = new System.Windows.Forms.Button();
            this.TypeDocsButton = new System.Windows.Forms.Button();
            this.TypeServiceButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // CivizenButton
            // 
            this.CivizenButton.Location = new System.Drawing.Point(111, 38);
            this.CivizenButton.Name = "CivizenButton";
            this.CivizenButton.Size = new System.Drawing.Size(160, 55);
            this.CivizenButton.TabIndex = 0;
            this.CivizenButton.Text = "Таблиця Civizen";
            this.CivizenButton.UseVisualStyleBackColor = true;
            this.CivizenButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // PassportButton
            // 
            this.PassportButton.Location = new System.Drawing.Point(111, 110);
            this.PassportButton.Name = "PassportButton";
            this.PassportButton.Size = new System.Drawing.Size(160, 55);
            this.PassportButton.TabIndex = 1;
            this.PassportButton.Text = "Таблиця Passport";
            this.PassportButton.UseVisualStyleBackColor = true;
            // 
            // ServiceButton
            // 
            this.ServiceButton.Location = new System.Drawing.Point(111, 182);
            this.ServiceButton.Name = "ServiceButton";
            this.ServiceButton.Size = new System.Drawing.Size(160, 55);
            this.ServiceButton.TabIndex = 2;
            this.ServiceButton.Text = "Таблиця Service";
            this.ServiceButton.UseVisualStyleBackColor = true;
            // 
            // TypeDocsButton
            // 
            this.TypeDocsButton.Location = new System.Drawing.Point(111, 255);
            this.TypeDocsButton.Name = "TypeDocsButton";
            this.TypeDocsButton.Size = new System.Drawing.Size(160, 55);
            this.TypeDocsButton.TabIndex = 3;
            this.TypeDocsButton.Text = "Таблиця TypeDocs";
            this.TypeDocsButton.UseVisualStyleBackColor = true;
            // 
            // TypeServiceButton
            // 
            this.TypeServiceButton.Location = new System.Drawing.Point(111, 329);
            this.TypeServiceButton.Name = "TypeServiceButton";
            this.TypeServiceButton.Size = new System.Drawing.Size(160, 55);
            this.TypeServiceButton.TabIndex = 4;
            this.TypeServiceButton.Text = "Таблиця TypeService";
            this.TypeServiceButton.UseVisualStyleBackColor = true;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(396, 433);
            this.Controls.Add(this.TypeServiceButton);
            this.Controls.Add(this.TypeDocsButton);
            this.Controls.Add(this.ServiceButton);
            this.Controls.Add(this.PassportButton);
            this.Controls.Add(this.CivizenButton);
            this.Name = "Main";
            this.Text = "Main";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button CivizenButton;
        private System.Windows.Forms.Button PassportButton;
        private System.Windows.Forms.Button ServiceButton;
        private System.Windows.Forms.Button TypeDocsButton;
        private System.Windows.Forms.Button TypeServiceButton;
    }
}