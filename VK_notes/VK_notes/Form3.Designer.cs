namespace VK_notes
{
    partial class Form3
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
            button1 = new Button();
            delete = new Button();
            content = new TextBox();
            label2 = new Label();
            label1 = new Label();
            titleB = new ComboBox();
            timestamp = new Label();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = Color.Pink;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = Color.MediumVioletRed;
            button1.Location = new Point(472, 387);
            button1.Name = "button1";
            button1.Size = new Size(155, 32);
            button1.TabIndex = 12;
            button1.Text = "Return to Main Menu";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // delete
            // 
            delete.BackColor = Color.Pink;
            delete.FlatStyle = FlatStyle.Flat;
            delete.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            delete.ForeColor = Color.MediumVioletRed;
            delete.Location = new Point(166, 385);
            delete.Name = "delete";
            delete.Size = new Size(93, 32);
            delete.TabIndex = 11;
            delete.Text = "Delete Note";
            delete.UseVisualStyleBackColor = false;
            delete.Click += delete_Click;
            // 
            // content
            // 
            content.BackColor = Color.Pink;
            content.BorderStyle = BorderStyle.None;
            content.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            content.Location = new Point(166, 151);
            content.Multiline = true;
            content.Name = "content";
            content.Size = new Size(461, 223);
            content.TabIndex = 10;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.MediumVioletRed;
            label2.Location = new Point(161, 81);
            label2.Name = "label2";
            label2.Size = new Size(46, 21);
            label2.TabIndex = 9;
            label2.Text = "Title:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("MV Boli", 24F, FontStyle.Bold | FontStyle.Italic | FontStyle.Underline, GraphicsUnit.Point);
            label1.ForeColor = Color.MediumVioletRed;
            label1.Location = new Point(157, 31);
            label1.Name = "label1";
            label1.Size = new Size(487, 41);
            label1.TabIndex = 7;
            label1.Text = "New Note                  ";
            // 
            // titleB
            // 
            titleB.BackColor = Color.Pink;
            titleB.FormattingEnabled = true;
            titleB.Location = new Point(166, 108);
            titleB.Name = "titleB";
            titleB.Size = new Size(134, 23);
            titleB.TabIndex = 13;
            titleB.SelectedIndexChanged += titleB_SelectedIndexChanged;
            // 
            // timestamp
            // 
            timestamp.AutoSize = true;
            timestamp.BackColor = Color.Transparent;
            timestamp.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            timestamp.ForeColor = Color.MediumVioletRed;
            timestamp.Location = new Point(368, 108);
            timestamp.Name = "timestamp";
            timestamp.Size = new Size(0, 21);
            timestamp.TabIndex = 21;
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.ca4fff4f6f5e635c03ab60f4467b47bc;
            ClientSize = new Size(800, 450);
            Controls.Add(timestamp);
            Controls.Add(titleB);
            Controls.Add(button1);
            Controls.Add(delete);
            Controls.Add(content);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form3";
            Text = "Form3";
            Load += Form3_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button delete;
        private TextBox content;
        private Label label2;
        private Label label1;
        private ComboBox titleB;
        private Label timestamp;
    }
}