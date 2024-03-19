namespace VK_notes
{
    partial class Form2
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
            label1 = new Label();
            title = new TextBox();
            label2 = new Label();
            content = new TextBox();
            save = new Button();
            button1 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("MV Boli", 24F, FontStyle.Bold | FontStyle.Italic | FontStyle.Underline, GraphicsUnit.Point);
            label1.ForeColor = Color.MediumVioletRed;
            label1.Location = new Point(142, 23);
            label1.Name = "label1";
            label1.Size = new Size(487, 41);
            label1.TabIndex = 1;
            label1.Text = "New Note                  ";
            label1.Click += label1_Click;
            // 
            // title
            // 
            title.BackColor = Color.Pink;
            title.BorderStyle = BorderStyle.None;
            title.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            title.Location = new Point(151, 97);
            title.Name = "title";
            title.Size = new Size(161, 26);
            title.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.MediumVioletRed;
            label2.Location = new Point(146, 73);
            label2.Name = "label2";
            label2.Size = new Size(46, 21);
            label2.TabIndex = 3;
            label2.Text = "Title:";
            // 
            // content
            // 
            content.BackColor = Color.Pink;
            content.BorderStyle = BorderStyle.None;
            content.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            content.Location = new Point(151, 143);
            content.Multiline = true;
            content.Name = "content";
            content.Size = new Size(461, 223);
            content.TabIndex = 4;
            // 
            // save
            // 
            save.BackColor = Color.Pink;
            save.FlatStyle = FlatStyle.Flat;
            save.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            save.ForeColor = Color.MediumVioletRed;
            save.Location = new Point(151, 377);
            save.Name = "save";
            save.Size = new Size(93, 32);
            save.TabIndex = 5;
            save.Text = "Save Note";
            save.UseVisualStyleBackColor = false;
            save.Click += save_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.Pink;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = Color.MediumVioletRed;
            button1.Location = new Point(457, 379);
            button1.Name = "button1";
            button1.Size = new Size(155, 32);
            button1.TabIndex = 6;
            button1.Text = "Return to Main Menu";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.ca4fff4f6f5e635c03ab60f4467b47bc;
            ClientSize = new Size(768, 450);
            Controls.Add(button1);
            Controls.Add(save);
            Controls.Add(content);
            Controls.Add(label2);
            Controls.Add(title);
            Controls.Add(label1);
            Name = "Form2";
            Text = "Form2";
            Load += Form2_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox title;
        private Label label2;
        private TextBox content;
        private Button save;
        private Button button1;
    }
}