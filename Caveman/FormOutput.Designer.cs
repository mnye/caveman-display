namespace Caveman
{
    partial class FormOutput
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
            richTextBoxCode = new RichTextBox();
            SuspendLayout();
            // 
            // richTextBoxCode
            // 
            richTextBoxCode.Location = new Point(5, 2);
            richTextBoxCode.Name = "richTextBoxCode";
            richTextBoxCode.Size = new Size(793, 445);
            richTextBoxCode.TabIndex = 0;
            richTextBoxCode.Text = "";
            // 
            // FormOutput
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(richTextBoxCode);
            Name = "FormOutput";
            Text = "Generated Code";
            ResumeLayout(false);
        }

        #endregion

        private RichTextBox richTextBoxCode;
    }
}