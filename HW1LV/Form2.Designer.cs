using HW1LV.Shapes;

namespace HW1LV
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
            InfoModeButton = new Button();
            DrawModeButton = new Button();
            refresh = new Button();
            textBox1 = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            label1.Location = new Point(51, 90);
            label1.Name = "label1";
            label1.Size = new Size(98, 35);
            label1.TabIndex = 1;
            label1.Text = "Shapes";
            // 
            // InfoModeButton
            // 
            InfoModeButton.Anchor = AnchorStyles.None;
            InfoModeButton.Location = new Point(192, 21);
            InfoModeButton.Name = "InfoModeButton";
            InfoModeButton.Size = new Size(135, 41);
            InfoModeButton.TabIndex = 6;
            InfoModeButton.Text = "Info Mode";
            InfoModeButton.UseVisualStyleBackColor = true;
            // 
            // DrawModeButton
            // 
            DrawModeButton.Anchor = AnchorStyles.None;
            DrawModeButton.Location = new Point(51, 21);
            DrawModeButton.Name = "DrawModeButton";
            DrawModeButton.Size = new Size(135, 41);
            DrawModeButton.TabIndex = 5;
            DrawModeButton.Text = "Draw Mode";
            DrawModeButton.UseVisualStyleBackColor = true;
            DrawModeButton.Click += DrawModeButton_Click;
            // 
            // refresh
            // 
            refresh.Anchor = AnchorStyles.None;
            refresh.Location = new Point(897, 81);
            refresh.Name = "refresh";
            refresh.Size = new Size(135, 41);
            refresh.TabIndex = 8;
            refresh.Text = "Refresh";
            refresh.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            textBox1.Anchor = AnchorStyles.None;
            textBox1.Location = new Point(40, 128);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.ScrollBars = ScrollBars.Vertical;
            textBox1.Size = new Size(1280, 558);
            textBox1.TabIndex = 9;
            
            
            
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            ClientSize = new Size(1355, 710);
            Controls.Add(textBox1);
            Controls.Add(refresh);
            Controls.Add(InfoModeButton);
            Controls.Add(DrawModeButton);
            Controls.Add(label1);
            Name = "Form2";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Draw App";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button InfoModeButton;
        private Button DrawModeButton;
        private Button refresh;
        private TextBox textBox1;
    }
}