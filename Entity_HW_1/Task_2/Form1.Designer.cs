namespace Task_2
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.DGBResult = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Curse = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Count = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DGBResult)).BeginInit();
            this.SuspendLayout();
            // 
            // DGBResult
            // 
            this.DGBResult.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGBResult.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Curse,
            this.Count});
            this.DGBResult.Location = new System.Drawing.Point(12, 12);
            this.DGBResult.Name = "DGBResult";
            this.DGBResult.RowHeadersWidth = 51;
            this.DGBResult.RowTemplate.Height = 29;
            this.DGBResult.Size = new System.Drawing.Size(430, 284);
            this.DGBResult.TabIndex = 0;
            // 
            // ID
            // 
            this.ID.HeaderText = "ID";
            this.ID.MinimumWidth = 6;
            this.ID.Name = "ID";
            this.ID.Width = 125;
            // 
            // Curse
            // 
            this.Curse.HeaderText = "Curse";
            this.Curse.MinimumWidth = 6;
            this.Curse.Name = "Curse";
            this.Curse.Width = 125;
            // 
            // Count
            // 
            this.Count.HeaderText = "Count of lessons";
            this.Count.MinimumWidth = 6;
            this.Count.Name = "Count";
            this.Count.Width = 125;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Segoe UI", 26F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button1.Location = new System.Drawing.Point(12, 326);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(430, 99);
            this.button1.TabIndex = 1;
            this.button1.Text = "Load data";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(456, 437);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.DGBResult);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.DGBResult)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DataGridView DGBResult;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn Curse;
        private DataGridViewTextBoxColumn Count;
        private Button button1;
    }
}