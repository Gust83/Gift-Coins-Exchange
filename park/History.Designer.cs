namespace park
{
    partial class History
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.C1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.C2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.C3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.C4 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.C5 = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.C1,
            this.C2,
            this.C3,
            this.C4,
            this.C5});
            this.dataGridView1.Location = new System.Drawing.Point(5, 6);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(817, 574);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // C1
            // 
            this.C1.HeaderText = "Code ";
            this.C1.MinimumWidth = 8;
            this.C1.Name = "C1";
            this.C1.Width = 150;
            // 
            // C2
            // 
            this.C2.HeaderText = "Item";
            this.C2.MinimumWidth = 8;
            this.C2.Name = "C2";
            this.C2.Width = 150;
            // 
            // C3
            // 
            this.C3.HeaderText = "Harga";
            this.C3.MinimumWidth = 8;
            this.C3.Name = "C3";
            this.C3.Width = 150;
            // 
            // C4
            // 
            this.C4.HeaderText = " ";
            this.C4.MinimumWidth = 8;
            this.C4.Name = "C4";
            this.C4.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.C4.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.C4.Text = "Edit";
            this.C4.Width = 150;
            // 
            // C5
            // 
            this.C5.HeaderText = "";
            this.C5.MinimumWidth = 8;
            this.C5.Name = "C5";
            this.C5.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.C5.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.C5.Text = "Delete";
            this.C5.Width = 150;
            // 
            // History
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(834, 592);
            this.Controls.Add(this.dataGridView1);
            this.Name = "History";
            this.Text = "History";
            this.Load += new System.EventHandler(this.History_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn C1;
        private System.Windows.Forms.DataGridViewTextBoxColumn C2;
        private System.Windows.Forms.DataGridViewTextBoxColumn C3;
        private System.Windows.Forms.DataGridViewButtonColumn C4;
        private System.Windows.Forms.DataGridViewButtonColumn C5;
    }
}