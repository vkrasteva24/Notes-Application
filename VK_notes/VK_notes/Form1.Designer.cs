namespace VK_notes
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
            label1 = new Label();
            label2 = new Label();
            create = new Button();
            view = new Button();
            delete = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("MV Boli", 24F, FontStyle.Bold | FontStyle.Italic | FontStyle.Underline, GraphicsUnit.Point);
            label1.ForeColor = Color.MediumVioletRed;
            label1.Location = new Point(88, 47);
            label1.Name = "label1";
            label1.Size = new Size(504, 41);
            label1.TabIndex = 0;
            label1.Text = "Welcome to the NOTES APP!";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.MediumVioletRed;
            label2.Location = new Point(262, 97);
            label2.Name = "label2";
            label2.Size = new Size(156, 21);
            label2.TabIndex = 1;
            label2.Text = "Choose your action!";
            // 
            // create
            // 
            create.BackColor = Color.Pink;
            create.FlatAppearance.BorderColor = Color.Purple;
            create.FlatAppearance.BorderSize = 0;
            create.FlatStyle = FlatStyle.Flat;
            create.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            create.ForeColor = Color.MediumVioletRed;
            create.Location = new Point(104, 174);
            create.Name = "create";
            create.Size = new Size(181, 42);
            create.TabIndex = 2;
            create.Text = "Create New Note";
            create.UseVisualStyleBackColor = false;
            create.Click += create_Click;
            // 
            // view
            // 
            view.BackColor = Color.Pink;
            view.FlatAppearance.BorderColor = Color.Purple;
            view.FlatAppearance.BorderSize = 0;
            view.FlatStyle = FlatStyle.Flat;
            view.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            view.ForeColor = Color.MediumVioletRed;
            view.Location = new Point(249, 250);
            view.Name = "view";
            view.Size = new Size(181, 42);
            view.TabIndex = 3;
            view.Text = "View Notes";
            view.UseVisualStyleBackColor = false;
            view.Click += button2_Click;
            // 
            // delete
            // 
            delete.BackColor = Color.Pink;
            delete.FlatAppearance.BorderColor = Color.Purple;
            delete.FlatAppearance.BorderSize = 0;
            delete.FlatStyle = FlatStyle.Flat;
            delete.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            delete.ForeColor = Color.MediumVioletRed;
            delete.Location = new Point(389, 174);
            delete.Name = "delete";
            delete.Size = new Size(181, 42);
            delete.TabIndex = 4;
            delete.Text = "Delete Note";
            delete.UseVisualStyleBackColor = false;
            delete.Click += delete_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.ca4fff4f6f5e635c03ab60f4467b47bc;
            ClientSize = new Size(683, 373);
            Controls.Add(delete);
            Controls.Add(view);
            Controls.Add(create);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Button create;
        private Button view;
        private Button delete;
    }
}