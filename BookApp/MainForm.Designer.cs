namespace BookApp
{
    partial class MainForm
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
            dataGridView1 = new DataGridView();
            btnNewForm = new Button();
            btnOpenEditForm = new Button();
            btnBookDelete = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(32, 28);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(728, 324);
            dataGridView1.TabIndex = 0;
            // 
            // btnNewForm
            // 
            btnNewForm.Location = new Point(503, 378);
            btnNewForm.Name = "btnNewForm";
            btnNewForm.Size = new Size(75, 23);
            btnNewForm.TabIndex = 1;
            btnNewForm.Text = "New";
            btnNewForm.UseVisualStyleBackColor = true;
            btnNewForm.Click += btnNewForm_Click_1;
            // 
            // btnOpenEditForm
            // 
            btnOpenEditForm.Location = new Point(595, 378);
            btnOpenEditForm.Name = "btnOpenEditForm";
            btnOpenEditForm.Size = new Size(75, 23);
            btnOpenEditForm.TabIndex = 2;
            btnOpenEditForm.Text = "Edit";
            btnOpenEditForm.UseVisualStyleBackColor = true;
            btnOpenEditForm.Click += btnOpenEditForm_Click;
            // 
            // btnBookDelete
            // 
            btnBookDelete.Location = new Point(685, 378);
            btnBookDelete.Name = "btnBookDelete";
            btnBookDelete.Size = new Size(75, 23);
            btnBookDelete.TabIndex = 3;
            btnBookDelete.Text = "Delete";
            btnBookDelete.UseVisualStyleBackColor = true;
            btnBookDelete.Click += btnBookDelete_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnBookDelete);
            Controls.Add(btnOpenEditForm);
            Controls.Add(btnNewForm);
            Controls.Add(dataGridView1);
            MaximizeBox = false;
            Name = "MainForm";
            Text = "Library System";
            Activated += MainForm_Activated;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView1;
        private Button btnNewForm;
        private Button btnOpenEditForm;
        private Button btnBookDelete;
    }
}