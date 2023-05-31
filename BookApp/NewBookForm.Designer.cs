namespace BookApp
{
    partial class NewBookForm
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
            textTitle = new TextBox();
            textISBN = new TextBox();
            textPublisher = new TextBox();
            textAuthor = new TextBox();
            textCategory = new TextBox();
            labelTitle = new Label();
            labelISBN = new Label();
            labelPublisher = new Label();
            labelAuthor = new Label();
            labelCategory = new Label();
            btnOK = new Button();
            btnCancel = new Button();
            SuspendLayout();
            // 
            // textTitle
            // 
            textTitle.Location = new Point(33, 42);
            textTitle.Name = "textTitle";
            textTitle.Size = new Size(326, 23);
            textTitle.TabIndex = 1;
            // 
            // textISBN
            // 
            textISBN.Location = new Point(33, 108);
            textISBN.Name = "textISBN";
            textISBN.Size = new Size(326, 23);
            textISBN.TabIndex = 2;
            // 
            // textPublisher
            // 
            textPublisher.Location = new Point(33, 169);
            textPublisher.Name = "textPublisher";
            textPublisher.Size = new Size(326, 23);
            textPublisher.TabIndex = 3;
            // 
            // textAuthor
            // 
            textAuthor.Location = new Point(33, 230);
            textAuthor.Name = "textAuthor";
            textAuthor.Size = new Size(326, 23);
            textAuthor.TabIndex = 4;
            // 
            // textCategory
            // 
            textCategory.Location = new Point(33, 294);
            textCategory.Name = "textCategory";
            textCategory.Size = new Size(326, 23);
            textCategory.TabIndex = 5;
            // 
            // labelTitle
            // 
            labelTitle.AutoSize = true;
            labelTitle.Location = new Point(33, 24);
            labelTitle.Name = "labelTitle";
            labelTitle.Size = new Size(32, 15);
            labelTitle.TabIndex = 5;
            labelTitle.Text = "Title:";
            // 
            // labelISBN
            // 
            labelISBN.AutoSize = true;
            labelISBN.Location = new Point(33, 90);
            labelISBN.Name = "labelISBN";
            labelISBN.Size = new Size(35, 15);
            labelISBN.TabIndex = 6;
            labelISBN.Text = "ISBN:";
            // 
            // labelPublisher
            // 
            labelPublisher.AutoSize = true;
            labelPublisher.Location = new Point(33, 151);
            labelPublisher.Name = "labelPublisher";
            labelPublisher.Size = new Size(59, 15);
            labelPublisher.TabIndex = 7;
            labelPublisher.Text = "Publisher:";
            // 
            // labelAuthor
            // 
            labelAuthor.AutoSize = true;
            labelAuthor.Location = new Point(33, 212);
            labelAuthor.Name = "labelAuthor";
            labelAuthor.Size = new Size(47, 15);
            labelAuthor.TabIndex = 8;
            labelAuthor.Text = "Author:";
            // 
            // labelCategory
            // 
            labelCategory.AutoSize = true;
            labelCategory.Location = new Point(33, 276);
            labelCategory.Name = "labelCategory";
            labelCategory.Size = new Size(58, 15);
            labelCategory.TabIndex = 9;
            labelCategory.Text = "Category:";
            // 
            // btnOK
            // 
            btnOK.Location = new Point(191, 341);
            btnOK.Name = "btnOK";
            btnOK.Size = new Size(75, 23);
            btnOK.TabIndex = 6;
            btnOK.Text = "OK";
            btnOK.UseVisualStyleBackColor = true;
            btnOK.Click += btnOK_Click;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(284, 341);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(75, 23);
            btnCancel.TabIndex = 7;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            // 
            // NewBookForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btnCancel;
            ClientSize = new Size(401, 388);
            Controls.Add(btnCancel);
            Controls.Add(btnOK);
            Controls.Add(labelCategory);
            Controls.Add(labelAuthor);
            Controls.Add(labelPublisher);
            Controls.Add(labelISBN);
            Controls.Add(labelTitle);
            Controls.Add(textCategory);
            Controls.Add(textAuthor);
            Controls.Add(textPublisher);
            Controls.Add(textISBN);
            Controls.Add(textTitle);
            MaximizeBox = false;
            Name = "NewBookForm";
            Text = "New Book";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textTitle;
        private TextBox textISBN;
        private TextBox textPublisher;
        private TextBox textAuthor;
        private TextBox textCategory;
        private Label labelTitle;
        private Label labelISBN;
        private Label labelPublisher;
        private Label labelAuthor;
        private Label labelCategory;
        private Button btnOK;
        private Button btnCancel;
    }
}