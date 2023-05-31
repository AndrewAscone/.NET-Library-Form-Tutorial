namespace BookApp
{
    partial class EditBookForm
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
            btnCancel = new Button();
            btnOK = new Button();
            labelCategory = new Label();
            labelAuthor = new Label();
            labelPublisher = new Label();
            labelISBN = new Label();
            labelTitle = new Label();
            textCategory = new TextBox();
            textAuthor = new TextBox();
            textPublisher = new TextBox();
            textISBN = new TextBox();
            textTitle = new TextBox();
            SuspendLayout();
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(285, 341);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(75, 23);
            btnCancel.TabIndex = 7;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnOK
            // 
            btnOK.Location = new Point(192, 341);
            btnOK.Name = "btnOK";
            btnOK.Size = new Size(75, 23);
            btnOK.TabIndex = 6;
            btnOK.Text = "OK";
            btnOK.UseVisualStyleBackColor = true;
            btnOK.Click += btnOK_Click;
            // 
            // labelCategory
            // 
            labelCategory.AutoSize = true;
            labelCategory.Location = new Point(34, 276);
            labelCategory.Name = "labelCategory";
            labelCategory.Size = new Size(58, 15);
            labelCategory.TabIndex = 21;
            labelCategory.Text = "Category:";
            // 
            // labelAuthor
            // 
            labelAuthor.AutoSize = true;
            labelAuthor.Location = new Point(34, 212);
            labelAuthor.Name = "labelAuthor";
            labelAuthor.Size = new Size(47, 15);
            labelAuthor.TabIndex = 20;
            labelAuthor.Text = "Author:";
            // 
            // labelPublisher
            // 
            labelPublisher.AutoSize = true;
            labelPublisher.Location = new Point(34, 151);
            labelPublisher.Name = "labelPublisher";
            labelPublisher.Size = new Size(59, 15);
            labelPublisher.TabIndex = 19;
            labelPublisher.Text = "Publisher:";
            // 
            // labelISBN
            // 
            labelISBN.AutoSize = true;
            labelISBN.Location = new Point(34, 90);
            labelISBN.Name = "labelISBN";
            labelISBN.Size = new Size(35, 15);
            labelISBN.TabIndex = 18;
            labelISBN.Text = "ISBN:";
            // 
            // labelTitle
            // 
            labelTitle.AutoSize = true;
            labelTitle.Location = new Point(34, 24);
            labelTitle.Name = "labelTitle";
            labelTitle.Size = new Size(32, 15);
            labelTitle.TabIndex = 17;
            labelTitle.Text = "Title:";
            // 
            // textCategory
            // 
            textCategory.Location = new Point(34, 294);
            textCategory.Name = "textCategory";
            textCategory.Size = new Size(326, 23);
            textCategory.TabIndex = 5;
            // 
            // textAuthor
            // 
            textAuthor.Location = new Point(34, 230);
            textAuthor.Name = "textAuthor";
            textAuthor.Size = new Size(326, 23);
            textAuthor.TabIndex = 4;
            // 
            // textPublisher
            // 
            textPublisher.Location = new Point(34, 169);
            textPublisher.Name = "textPublisher";
            textPublisher.Size = new Size(326, 23);
            textPublisher.TabIndex = 3;
            // 
            // textISBN
            // 
            textISBN.Location = new Point(34, 108);
            textISBN.Name = "textISBN";
            textISBN.Size = new Size(326, 23);
            textISBN.TabIndex = 2;
            // 
            // textTitle
            // 
            textTitle.Location = new Point(34, 42);
            textTitle.Name = "textTitle";
            textTitle.Size = new Size(326, 23);
            textTitle.TabIndex = 1;
            // 
            // EditBookForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btnCancel;
            ClientSize = new Size(400, 389);
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
            Name = "EditBookForm";
            Text = "Edit Book";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnCancel;
        private Button btnOK;
        private Label labelCategory;
        private Label labelAuthor;
        private Label labelPublisher;
        private Label labelISBN;
        private Label labelTitle;
        private TextBox textCategory;
        private TextBox textAuthor;
        private TextBox textPublisher;
        private TextBox textISBN;
        private TextBox textTitle;
    }
}