namespace Task_1
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
            this.components = new System.ComponentModel.Container();
            this.DGVResult = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Age = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ConnectToBD = new System.Windows.Forms.Button();
            this.myDatabaseContextBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.DGVResult)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.myDatabaseContextBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // DGVResult
            // 
            this.DGVResult.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVResult.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Name,
            this.Age});
            this.DGVResult.Location = new System.Drawing.Point(12, 12);
            this.DGVResult.Name = "DGVResult";
            this.DGVResult.RowHeadersWidth = 51;
            this.DGVResult.RowTemplate.Height = 29;
            this.DGVResult.Size = new System.Drawing.Size(434, 221);
            this.DGVResult.TabIndex = 0;
            // 
            // ID
            // 
            this.ID.HeaderText = "ID";
            this.ID.MinimumWidth = 6;
            this.ID.Name = "ID";
            this.ID.Width = 125;
            // 
            // Name
            // 
            this.Name.HeaderText = "Name";
            this.Name.MinimumWidth = 6;
            this.Name.Name = "Name";
            this.Name.Width = 125;
            // 
            // Age
            // 
            this.Age.HeaderText = "Age";
            this.Age.MinimumWidth = 6;
            this.Age.Name = "Age";
            this.Age.Width = 125;
            // 
            // ConnectToBD
            // 
            this.ConnectToBD.Font = new System.Drawing.Font("Segoe UI", 26F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ConnectToBD.Location = new System.Drawing.Point(12, 271);
            this.ConnectToBD.Name = "ConnectToBD";
            this.ConnectToBD.Size = new System.Drawing.Size(434, 157);
            this.ConnectToBD.TabIndex = 1;
            this.ConnectToBD.Text = "Load Info";
            this.ConnectToBD.UseVisualStyleBackColor = true;
            this.ConnectToBD.Click += new System.EventHandler(this.ConnectToBD_Click);
            // 
            // myDatabaseContextBindingSource
            // 
            this.myDatabaseContextBindingSource.DataSource = typeof(Task_1.Entity.MyDatabaseContext);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(469, 450);
            this.Controls.Add(this.ConnectToBD);
            this.Controls.Add(this.DGVResult);
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.DGVResult)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.myDatabaseContextBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DataGridView DGVResult;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn Name;
        private DataGridViewTextBoxColumn Age;
        private Button ConnectToBD;
        private BindingSource myDatabaseContextBindingSource;
    }
}