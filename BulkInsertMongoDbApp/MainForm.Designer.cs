namespace BulkInsertMongoDbApp
{
    partial class MainForm
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
            this.btnInsertGeneratedData = new System.Windows.Forms.Button();
            this.btnDeleteDataBase = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.numNumOfRestaurants = new System.Windows.Forms.NumericUpDown();
            this.numMaxNumOfMealsPerRestaurants = new System.Windows.Forms.NumericUpDown();
            this.numNumOfUsers = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.numNumOfSearchAnalyticsData = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.richTextBox = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.numNumOfRestaurants)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMaxNumOfMealsPerRestaurants)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numNumOfUsers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numNumOfSearchAnalyticsData)).BeginInit();
            this.SuspendLayout();
            // 
            // btnInsertGeneratedData
            // 
            this.btnInsertGeneratedData.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnInsertGeneratedData.Location = new System.Drawing.Point(170, 225);
            this.btnInsertGeneratedData.Name = "btnInsertGeneratedData";
            this.btnInsertGeneratedData.Size = new System.Drawing.Size(151, 23);
            this.btnInsertGeneratedData.TabIndex = 2;
            this.btnInsertGeneratedData.Text = "Insert generated data";
            this.btnInsertGeneratedData.UseVisualStyleBackColor = true;
            this.btnInsertGeneratedData.Click += new System.EventHandler(this.btnInsertGeneratedData_Click);
            // 
            // btnDeleteDataBase
            // 
            this.btnDeleteDataBase.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnDeleteDataBase.Location = new System.Drawing.Point(12, 225);
            this.btnDeleteDataBase.Name = "btnDeleteDataBase";
            this.btnDeleteDataBase.Size = new System.Drawing.Size(151, 23);
            this.btnDeleteDataBase.TabIndex = 5;
            this.btnDeleteDataBase.Text = "Delete existing data";
            this.btnDeleteDataBase.UseVisualStyleBackColor = true;
            this.btnDeleteDataBase.Click += new System.EventHandler(this.btnDeleteDataBase_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(167, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Num of restaurants";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(324, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(135, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Max Num of meals per rest.";
            // 
            // numNumOfRestaurants
            // 
            this.numNumOfRestaurants.Location = new System.Drawing.Point(170, 26);
            this.numNumOfRestaurants.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numNumOfRestaurants.Name = "numNumOfRestaurants";
            this.numNumOfRestaurants.Size = new System.Drawing.Size(151, 20);
            this.numNumOfRestaurants.TabIndex = 8;
            this.numNumOfRestaurants.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // numMaxNumOfMealsPerRestaurants
            // 
            this.numMaxNumOfMealsPerRestaurants.Location = new System.Drawing.Point(327, 26);
            this.numMaxNumOfMealsPerRestaurants.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.numMaxNumOfMealsPerRestaurants.Name = "numMaxNumOfMealsPerRestaurants";
            this.numMaxNumOfMealsPerRestaurants.Size = new System.Drawing.Size(148, 20);
            this.numMaxNumOfMealsPerRestaurants.TabIndex = 9;
            this.numMaxNumOfMealsPerRestaurants.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // numNumOfUsers
            // 
            this.numNumOfUsers.Location = new System.Drawing.Point(12, 26);
            this.numNumOfUsers.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numNumOfUsers.Name = "numNumOfUsers";
            this.numNumOfUsers.Size = new System.Drawing.Size(151, 20);
            this.numNumOfUsers.TabIndex = 11;
            this.numNumOfUsers.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Num of users";
            // 
            // numNumOfSearchAnalyticsData
            // 
            this.numNumOfSearchAnalyticsData.Location = new System.Drawing.Point(481, 26);
            this.numNumOfSearchAnalyticsData.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numNumOfSearchAnalyticsData.Name = "numNumOfSearchAnalyticsData";
            this.numNumOfSearchAnalyticsData.Size = new System.Drawing.Size(148, 20);
            this.numNumOfSearchAnalyticsData.TabIndex = 13;
            this.numNumOfSearchAnalyticsData.Value = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(478, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(144, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Num of search analytics data";
            // 
            // richTextBox
            // 
            this.richTextBox.Location = new System.Drawing.Point(12, 52);
            this.richTextBox.Name = "richTextBox";
            this.richTextBox.Size = new System.Drawing.Size(617, 167);
            this.richTextBox.TabIndex = 14;
            this.richTextBox.Text = "";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(641, 260);
            this.Controls.Add(this.richTextBox);
            this.Controls.Add(this.numNumOfSearchAnalyticsData);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.numNumOfUsers);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.numMaxNumOfMealsPerRestaurants);
            this.Controls.Add(this.numNumOfRestaurants);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnDeleteDataBase);
            this.Controls.Add(this.btnInsertGeneratedData);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "MainForm";
            this.Text = "Healthy Hunting Data Generator";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numNumOfRestaurants)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMaxNumOfMealsPerRestaurants)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numNumOfUsers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numNumOfSearchAnalyticsData)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnInsertGeneratedData;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnDeleteDataBase;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numNumOfRestaurants;
        private System.Windows.Forms.NumericUpDown numMaxNumOfMealsPerRestaurants;
        private System.Windows.Forms.NumericUpDown numNumOfUsers;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown numNumOfSearchAnalyticsData;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RichTextBox richTextBox;
    }
}

