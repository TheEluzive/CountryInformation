namespace CountryInformation
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBoxSearchCountry = new System.Windows.Forms.TextBox();
            this.tabControlSearchCountry = new System.Windows.Forms.TabControl();
            this.tabPageSearch = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBoxCapital = new System.Windows.Forms.TextBox();
            this.textBoxAlpha3Code = new System.Windows.Forms.TextBox();
            this.labelRegion = new System.Windows.Forms.Label();
            this.labelPopulation = new System.Windows.Forms.Label();
            this.textBoxRegion = new System.Windows.Forms.TextBox();
            this.labelArea = new System.Windows.Forms.Label();
            this.labelAlpha3Code = new System.Windows.Forms.Label();
            this.labelCapital = new System.Windows.Forms.Label();
            this.textBoxPopulation = new System.Windows.Forms.TextBox();
            this.labelCountryNameInResult = new System.Windows.Forms.Label();
            this.textBoxCountryNameResult = new System.Windows.Forms.TextBox();
            this.textBoxArea = new System.Windows.Forms.TextBox();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.labelCountryName = new System.Windows.Forms.Label();
            this.tabPageDatabase = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Name1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Alpha3Code = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Capital = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Area = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Population = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Region1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabControlSearchCountry.SuspendLayout();
            this.tabPageSearch.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabPageDatabase.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxSearchCountry
            // 
            this.textBoxSearchCountry.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxSearchCountry.Location = new System.Drawing.Point(15, 50);
            this.textBoxSearchCountry.Name = "textBoxSearchCountry";
            this.textBoxSearchCountry.Size = new System.Drawing.Size(224, 27);
            this.textBoxSearchCountry.TabIndex = 0;
            // 
            // tabControlSearchCountry
            // 
            this.tabControlSearchCountry.Controls.Add(this.tabPageSearch);
            this.tabControlSearchCountry.Controls.Add(this.tabPageDatabase);
            this.tabControlSearchCountry.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlSearchCountry.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tabControlSearchCountry.Location = new System.Drawing.Point(0, 0);
            this.tabControlSearchCountry.Name = "tabControlSearchCountry";
            this.tabControlSearchCountry.SelectedIndex = 0;
            this.tabControlSearchCountry.Size = new System.Drawing.Size(1018, 539);
            this.tabControlSearchCountry.TabIndex = 1;
            // 
            // tabPageSearch
            // 
            this.tabPageSearch.Controls.Add(this.groupBox1);
            this.tabPageSearch.Controls.Add(this.buttonSearch);
            this.tabPageSearch.Controls.Add(this.labelCountryName);
            this.tabPageSearch.Controls.Add(this.textBoxSearchCountry);
            this.tabPageSearch.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tabPageSearch.Location = new System.Drawing.Point(4, 29);
            this.tabPageSearch.Name = "tabPageSearch";
            this.tabPageSearch.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageSearch.Size = new System.Drawing.Size(1010, 506);
            this.tabPageSearch.TabIndex = 0;
            this.tabPageSearch.Text = "Search";
            this.tabPageSearch.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.AutoSize = true;
            this.groupBox1.Controls.Add(this.textBoxCapital);
            this.groupBox1.Controls.Add(this.textBoxAlpha3Code);
            this.groupBox1.Controls.Add(this.labelRegion);
            this.groupBox1.Controls.Add(this.labelPopulation);
            this.groupBox1.Controls.Add(this.textBoxRegion);
            this.groupBox1.Controls.Add(this.labelArea);
            this.groupBox1.Controls.Add(this.labelAlpha3Code);
            this.groupBox1.Controls.Add(this.labelCapital);
            this.groupBox1.Controls.Add(this.textBoxPopulation);
            this.groupBox1.Controls.Add(this.labelCountryNameInResult);
            this.groupBox1.Controls.Add(this.textBoxCountryNameResult);
            this.groupBox1.Controls.Add(this.textBoxArea);
            this.groupBox1.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox1.Location = new System.Drawing.Point(9, 102);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(390, 374);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Результаты поиска";
            // 
            // textBoxCapital
            // 
            this.textBoxCapital.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxCapital.Location = new System.Drawing.Point(6, 157);
            this.textBoxCapital.Name = "textBoxCapital";
            this.textBoxCapital.ReadOnly = true;
            this.textBoxCapital.Size = new System.Drawing.Size(352, 27);
            this.textBoxCapital.TabIndex = 0;
            // 
            // textBoxAlpha3Code
            // 
            this.textBoxAlpha3Code.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxAlpha3Code.Location = new System.Drawing.Point(6, 105);
            this.textBoxAlpha3Code.Name = "textBoxAlpha3Code";
            this.textBoxAlpha3Code.ReadOnly = true;
            this.textBoxAlpha3Code.Size = new System.Drawing.Size(352, 27);
            this.textBoxAlpha3Code.TabIndex = 0;
            // 
            // labelRegion
            // 
            this.labelRegion.AutoSize = true;
            this.labelRegion.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelRegion.Location = new System.Drawing.Point(8, 291);
            this.labelRegion.Name = "labelRegion";
            this.labelRegion.Size = new System.Drawing.Size(66, 19);
            this.labelRegion.TabIndex = 1;
            this.labelRegion.Text = "Регион:";
            // 
            // labelPopulation
            // 
            this.labelPopulation.AutoSize = true;
            this.labelPopulation.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelPopulation.Location = new System.Drawing.Point(8, 239);
            this.labelPopulation.Name = "labelPopulation";
            this.labelPopulation.Size = new System.Drawing.Size(97, 19);
            this.labelPopulation.TabIndex = 1;
            this.labelPopulation.Text = "Население:";
            // 
            // textBoxRegion
            // 
            this.textBoxRegion.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxRegion.Location = new System.Drawing.Point(6, 313);
            this.textBoxRegion.Name = "textBoxRegion";
            this.textBoxRegion.ReadOnly = true;
            this.textBoxRegion.Size = new System.Drawing.Size(352, 27);
            this.textBoxRegion.TabIndex = 0;
            // 
            // labelArea
            // 
            this.labelArea.AutoSize = true;
            this.labelArea.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelArea.Location = new System.Drawing.Point(8, 187);
            this.labelArea.Name = "labelArea";
            this.labelArea.Size = new System.Drawing.Size(114, 19);
            this.labelArea.TabIndex = 1;
            this.labelArea.Text = "Площадь, км:";
            // 
            // labelAlpha3Code
            // 
            this.labelAlpha3Code.AutoSize = true;
            this.labelAlpha3Code.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelAlpha3Code.Location = new System.Drawing.Point(8, 83);
            this.labelAlpha3Code.Name = "labelAlpha3Code";
            this.labelAlpha3Code.Size = new System.Drawing.Size(43, 19);
            this.labelAlpha3Code.TabIndex = 1;
            this.labelAlpha3Code.Text = "Код:";
            // 
            // labelCapital
            // 
            this.labelCapital.AutoSize = true;
            this.labelCapital.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelCapital.Location = new System.Drawing.Point(6, 135);
            this.labelCapital.Name = "labelCapital";
            this.labelCapital.Size = new System.Drawing.Size(81, 19);
            this.labelCapital.TabIndex = 1;
            this.labelCapital.Text = "Столица:";
            // 
            // textBoxPopulation
            // 
            this.textBoxPopulation.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxPopulation.Location = new System.Drawing.Point(6, 261);
            this.textBoxPopulation.Name = "textBoxPopulation";
            this.textBoxPopulation.ReadOnly = true;
            this.textBoxPopulation.Size = new System.Drawing.Size(352, 27);
            this.textBoxPopulation.TabIndex = 0;
            // 
            // labelCountryNameInResult
            // 
            this.labelCountryNameInResult.AutoSize = true;
            this.labelCountryNameInResult.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelCountryNameInResult.Location = new System.Drawing.Point(8, 31);
            this.labelCountryNameInResult.Name = "labelCountryNameInResult";
            this.labelCountryNameInResult.Size = new System.Drawing.Size(87, 19);
            this.labelCountryNameInResult.TabIndex = 1;
            this.labelCountryNameInResult.Text = "Название:";
            // 
            // textBoxCountryNameResult
            // 
            this.textBoxCountryNameResult.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxCountryNameResult.Location = new System.Drawing.Point(6, 53);
            this.textBoxCountryNameResult.Name = "textBoxCountryNameResult";
            this.textBoxCountryNameResult.ReadOnly = true;
            this.textBoxCountryNameResult.Size = new System.Drawing.Size(352, 27);
            this.textBoxCountryNameResult.TabIndex = 0;
            // 
            // textBoxArea
            // 
            this.textBoxArea.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxArea.Location = new System.Drawing.Point(6, 209);
            this.textBoxArea.Name = "textBoxArea";
            this.textBoxArea.ReadOnly = true;
            this.textBoxArea.Size = new System.Drawing.Size(352, 27);
            this.textBoxArea.TabIndex = 0;
            // 
            // buttonSearch
            // 
            this.buttonSearch.Font = new System.Drawing.Font("Arial Black", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonSearch.Location = new System.Drawing.Point(284, 45);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(115, 33);
            this.buttonSearch.TabIndex = 2;
            this.buttonSearch.Text = "🔎";
            this.buttonSearch.UseVisualStyleBackColor = true;
            this.buttonSearch.Click += new System.EventHandler(this.ButtonSearch_Click);
            // 
            // labelCountryName
            // 
            this.labelCountryName.AutoSize = true;
            this.labelCountryName.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelCountryName.Location = new System.Drawing.Point(11, 28);
            this.labelCountryName.Name = "labelCountryName";
            this.labelCountryName.Size = new System.Drawing.Size(148, 19);
            this.labelCountryName.TabIndex = 1;
            this.labelCountryName.Text = "Название страны:";
            // 
            // tabPageDatabase
            // 
            this.tabPageDatabase.Controls.Add(this.dataGridView1);
            this.tabPageDatabase.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tabPageDatabase.Location = new System.Drawing.Point(4, 29);
            this.tabPageDatabase.Name = "tabPageDatabase";
            this.tabPageDatabase.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageDatabase.Size = new System.Drawing.Size(1010, 506);
            this.tabPageDatabase.TabIndex = 1;
            this.tabPageDatabase.Text = "Database";
            this.tabPageDatabase.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Name1,
            this.Alpha3Code,
            this.Capital,
            this.Area,
            this.Population,
            this.Region1});
            this.dataGridView1.Location = new System.Drawing.Point(6, 20);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(984, 445);
            this.dataGridView1.TabIndex = 1;
            // 
            // Name1
            // 
            this.Name1.HeaderText = "Название";
            this.Name1.MinimumWidth = 6;
            this.Name1.Name = "Name1";
            this.Name1.ReadOnly = true;
            this.Name1.Width = 125;
            // 
            // Alpha3Code
            // 
            this.Alpha3Code.HeaderText = "Код страны";
            this.Alpha3Code.MinimumWidth = 6;
            this.Alpha3Code.Name = "Alpha3Code";
            this.Alpha3Code.ReadOnly = true;
            this.Alpha3Code.Width = 70;
            // 
            // Capital
            // 
            this.Capital.HeaderText = "Столица";
            this.Capital.MinimumWidth = 6;
            this.Capital.Name = "Capital";
            this.Capital.ReadOnly = true;
            this.Capital.Width = 125;
            // 
            // Area
            // 
            this.Area.HeaderText = "Площадь, км";
            this.Area.MinimumWidth = 6;
            this.Area.Name = "Area";
            this.Area.ReadOnly = true;
            this.Area.Width = 125;
            // 
            // Population
            // 
            this.Population.HeaderText = "Население";
            this.Population.MinimumWidth = 6;
            this.Population.Name = "Population";
            this.Population.ReadOnly = true;
            this.Population.Width = 125;
            // 
            // Region1
            // 
            this.Region1.HeaderText = "Регион";
            this.Region1.MinimumWidth = 6;
            this.Region1.Name = "Region1";
            this.Region1.ReadOnly = true;
            this.Region1.Width = 125;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1018, 539);
            this.Controls.Add(this.tabControlSearchCountry);
            this.Name = "Form1";
            this.Text = "CountryInformation";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControlSearchCountry.ResumeLayout(false);
            this.tabPageSearch.ResumeLayout(false);
            this.tabPageSearch.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabPageDatabase.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxSearchCountry;
        private System.Windows.Forms.TabControl tabControlSearchCountry;
        private System.Windows.Forms.TabPage tabPageSearch;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBoxCapital;
        private System.Windows.Forms.TextBox textBoxAlpha3Code;
        private System.Windows.Forms.Label labelRegion;
        private System.Windows.Forms.Label labelPopulation;
        private System.Windows.Forms.TextBox textBoxRegion;
        private System.Windows.Forms.Label labelArea;
        private System.Windows.Forms.Label labelAlpha3Code;
        private System.Windows.Forms.Label labelCapital;
        private System.Windows.Forms.TextBox textBoxPopulation;
        private System.Windows.Forms.Label labelCountryNameInResult;
        private System.Windows.Forms.TextBox textBoxCountryNameResult;
        private System.Windows.Forms.TextBox textBoxArea;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.Label labelCountryName;
        private System.Windows.Forms.TabPage tabPageDatabase;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Name1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Alpha3Code;
        private System.Windows.Forms.DataGridViewTextBoxColumn Capital;
        private System.Windows.Forms.DataGridViewTextBoxColumn Area;
        private System.Windows.Forms.DataGridViewTextBoxColumn Population;
        private System.Windows.Forms.DataGridViewTextBoxColumn Region1;
    }
}

