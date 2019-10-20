namespace CountryInformation
{
    partial class startForm
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
            this.textBoxPath = new System.Windows.Forms.TextBox();
            this.buttonSetPathToDB = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBoxPath
            // 
            this.textBoxPath.Location = new System.Drawing.Point(33, 59);
            this.textBoxPath.MinimumSize = new System.Drawing.Size(0, 40);
            this.textBoxPath.Name = "textBoxPath";
            this.textBoxPath.Size = new System.Drawing.Size(694, 22);
            this.textBoxPath.TabIndex = 0;
            this.textBoxPath.Text = "C:\\Users\\1eluz\\source\\repos\\CountryInformation\\CountryInformation\\Database1.mdf";
            // 
            // buttonSetPathToDB
            // 
            this.buttonSetPathToDB.Location = new System.Drawing.Point(733, 59);
            this.buttonSetPathToDB.Name = "buttonSetPathToDB";
            this.buttonSetPathToDB.Size = new System.Drawing.Size(78, 25);
            this.buttonSetPathToDB.TabIndex = 1;
            this.buttonSetPathToDB.Text = "OK";
            this.buttonSetPathToDB.UseVisualStyleBackColor = true;
            this.buttonSetPathToDB.Click += new System.EventHandler(this.ButtonSetPathToDB_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(29, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(290, 24);
            this.label1.TabIndex = 2;
            this.label1.Text = "Укажите полный путь к базе данных";
            // 
            // startForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(839, 132);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonSetPathToDB);
            this.Controls.Add(this.textBoxPath);
            this.Name = "startForm";
            this.Text = "startForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxPath;
        private System.Windows.Forms.Button buttonSetPathToDB;
        private System.Windows.Forms.Label label1;
    }
}