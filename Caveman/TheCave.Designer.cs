namespace Caveman
{
    partial class TheCave
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
            splitContainer1 = new SplitContainer();
            buttonClear = new Button();
            button2 = new Button();
            buttonAdd = new Button();
            panel2 = new Panel();
            textBox2 = new TextBox();
            checkBox2 = new CheckBox();
            checkBox1 = new CheckBox();
            label3 = new Label();
            comboBox1 = new ComboBox();
            textBox1 = new TextBox();
            label2 = new Label();
            listViewComponents = new ListView();
            label1 = new Label();
            panel1 = new Panel();
            txtHeight = new TextBox();
            lblX = new Label();
            txtWidth = new TextBox();
            comboOutput = new ComboBox();
            comboScreen = new ComboBox();
            pnlScreen = new Panel();
            pbPixels = new PictureBox();
            statusStrip1 = new StatusStrip();
            lblCurrXY = new ToolStripStatusLabel();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            pnlScreen.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbPixels).BeginInit();
            statusStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.Location = new Point(0, 0);
            splitContainer1.Margin = new Padding(2, 3, 2, 3);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(buttonClear);
            splitContainer1.Panel1.Controls.Add(button2);
            splitContainer1.Panel1.Controls.Add(buttonAdd);
            splitContainer1.Panel1.Controls.Add(panel2);
            splitContainer1.Panel1.Controls.Add(listViewComponents);
            splitContainer1.Panel1.Controls.Add(label1);
            splitContainer1.Panel1.Controls.Add(panel1);
            splitContainer1.Panel1.Controls.Add(comboOutput);
            splitContainer1.Panel1.Controls.Add(comboScreen);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(pnlScreen);
            splitContainer1.Panel2.Controls.Add(statusStrip1);
            splitContainer1.Size = new Size(2398, 1231);
            splitContainer1.SplitterDistance = 390;
            splitContainer1.SplitterWidth = 3;
            splitContainer1.TabIndex = 0;
            // 
            // buttonClear
            // 
            buttonClear.Location = new Point(31, 623);
            buttonClear.Margin = new Padding(2, 3, 2, 3);
            buttonClear.Name = "buttonClear";
            buttonClear.Size = new Size(133, 29);
            buttonClear.TabIndex = 9;
            buttonClear.Text = "Clear Image";
            buttonClear.UseVisualStyleBackColor = true;
            buttonClear.Click += buttonClear_Click;
            // 
            // button2
            // 
            button2.Location = new Point(31, 303);
            button2.Margin = new Padding(2, 3, 2, 3);
            button2.Name = "button2";
            button2.Size = new Size(133, 27);
            button2.TabIndex = 8;
            button2.Text = "Delete";
            button2.UseVisualStyleBackColor = true;
            // 
            // buttonAdd
            // 
            buttonAdd.Location = new Point(31, 270);
            buttonAdd.Margin = new Padding(2, 3, 2, 3);
            buttonAdd.Name = "buttonAdd";
            buttonAdd.Size = new Size(133, 28);
            buttonAdd.TabIndex = 7;
            buttonAdd.Text = "Add";
            buttonAdd.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel2.Controls.Add(textBox2);
            panel2.Controls.Add(checkBox2);
            panel2.Controls.Add(checkBox1);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(comboBox1);
            panel2.Controls.Add(textBox1);
            panel2.Controls.Add(label2);
            panel2.Location = new Point(9, 916);
            panel2.Margin = new Padding(2, 3, 2, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(368, 307);
            panel2.TabIndex = 6;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(22, 65);
            textBox2.Margin = new Padding(2, 3, 2, 3);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(109, 27);
            textBox2.TabIndex = 7;
            textBox2.Text = "type (e.g., line)";
            // 
            // checkBox2
            // 
            checkBox2.AutoSize = true;
            checkBox2.Location = new Point(22, 215);
            checkBox2.Margin = new Padding(2, 3, 2, 3);
            checkBox2.Name = "checkBox2";
            checkBox2.Size = new Size(108, 24);
            checkBox2.TabIndex = 6;
            checkBox2.Text = "Invert Color";
            checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(22, 180);
            checkBox1.Margin = new Padding(2, 3, 2, 3);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(114, 24);
            checkBox1.TabIndex = 5;
            checkBox1.Text = "Is Selectable";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(22, 112);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(101, 20);
            label3.TabIndex = 4;
            label3.Text = "Variable Type:";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Static", "Text", "On/Off" });
            comboBox1.Location = new Point(22, 135);
            comboBox1.Margin = new Padding(2, 3, 2, 3);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(114, 28);
            comboBox1.TabIndex = 3;
            comboBox1.Text = "Static";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(22, 36);
            textBox1.Margin = new Padding(2, 3, 2, 3);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(109, 27);
            textBox1.TabIndex = 1;
            textBox1.Text = "comp name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(22, 13);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(69, 20);
            label2.TabIndex = 0;
            label2.Text = "Selected:";
            // 
            // listViewComponents
            // 
            listViewComponents.Location = new Point(9, 123);
            listViewComponents.Margin = new Padding(2, 3, 2, 3);
            listViewComponents.MultiSelect = false;
            listViewComponents.Name = "listViewComponents";
            listViewComponents.Size = new Size(139, 121);
            listViewComponents.TabIndex = 5;
            listViewComponents.UseCompatibleStateImageBehavior = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(9, 100);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(96, 20);
            label1.TabIndex = 4;
            label1.Text = "Components:";
            // 
            // panel1
            // 
            panel1.Controls.Add(txtHeight);
            panel1.Controls.Add(lblX);
            panel1.Controls.Add(txtWidth);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 56);
            panel1.Margin = new Padding(2, 3, 2, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(390, 27);
            panel1.TabIndex = 3;
            // 
            // txtHeight
            // 
            txtHeight.Dock = DockStyle.Left;
            txtHeight.Location = new Point(74, 0);
            txtHeight.Margin = new Padding(2, 3, 2, 3);
            txtHeight.Name = "txtHeight";
            txtHeight.ReadOnly = true;
            txtHeight.Size = new Size(52, 27);
            txtHeight.TabIndex = 5;
            txtHeight.Text = "240";
            // 
            // lblX
            // 
            lblX.Dock = DockStyle.Left;
            lblX.Location = new Point(51, 0);
            lblX.Margin = new Padding(2, 0, 2, 0);
            lblX.Name = "lblX";
            lblX.Size = new Size(23, 27);
            lblX.TabIndex = 3;
            lblX.Text = "x";
            lblX.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtWidth
            // 
            txtWidth.Dock = DockStyle.Left;
            txtWidth.Location = new Point(0, 0);
            txtWidth.Margin = new Padding(2, 3, 2, 3);
            txtWidth.Multiline = true;
            txtWidth.Name = "txtWidth";
            txtWidth.ReadOnly = true;
            txtWidth.Size = new Size(51, 27);
            txtWidth.TabIndex = 0;
            txtWidth.Text = "400";
            // 
            // comboOutput
            // 
            comboOutput.Dock = DockStyle.Top;
            comboOutput.FormattingEnabled = true;
            comboOutput.Location = new Point(0, 28);
            comboOutput.Margin = new Padding(2, 3, 2, 3);
            comboOutput.Name = "comboOutput";
            comboOutput.Size = new Size(390, 28);
            comboOutput.TabIndex = 1;
            comboOutput.Text = "Adafruit GFX Library";
            // 
            // comboScreen
            // 
            comboScreen.Dock = DockStyle.Top;
            comboScreen.FormattingEnabled = true;
            comboScreen.Location = new Point(0, 0);
            comboScreen.Margin = new Padding(2, 3, 2, 3);
            comboScreen.Name = "comboScreen";
            comboScreen.Size = new Size(390, 28);
            comboScreen.TabIndex = 0;
            comboScreen.Text = "Sharp MemoryLCD 2.7\"";
            // 
            // pnlScreen
            // 
            pnlScreen.AutoScroll = true;
            pnlScreen.AutoSize = true;
            pnlScreen.BackColor = SystemColors.WindowFrame;
            pnlScreen.Controls.Add(pbPixels);
            pnlScreen.Dock = DockStyle.Fill;
            pnlScreen.Location = new Point(0, 0);
            pnlScreen.Margin = new Padding(2, 3, 2, 3);
            pnlScreen.Name = "pnlScreen";
            pnlScreen.Size = new Size(2005, 1205);
            pnlScreen.TabIndex = 1;
            // 
            // pbPixels
            // 
            pbPixels.BackColor = Color.DarkGray;
            pbPixels.Location = new Point(3, 3);
            pbPixels.Name = "pbPixels";
            pbPixels.Size = new Size(2000, 1200);
            pbPixels.TabIndex = 0;
            pbPixels.TabStop = false;
            pbPixels.MouseDown += pbPixels_MouseDown;
            pbPixels.MouseMove += pbPixels_MouseMove;
            pbPixels.MouseUp += pbPixels_MouseUp;
            // 
            // statusStrip1
            // 
            statusStrip1.ImageScalingSize = new Size(24, 24);
            statusStrip1.Items.AddRange(new ToolStripItem[] { lblCurrXY });
            statusStrip1.Location = new Point(0, 1205);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Padding = new Padding(1, 0, 11, 0);
            statusStrip1.Size = new Size(2005, 26);
            statusStrip1.TabIndex = 0;
            statusStrip1.Text = "statusStrip1";
            // 
            // lblCurrXY
            // 
            lblCurrXY.Name = "lblCurrXY";
            lblCurrXY.Size = new Size(29, 20);
            lblCurrXY.Text = "X,Y";
            // 
            // TheCave
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(2398, 1231);
            Controls.Add(splitContainer1);
            Margin = new Padding(2, 3, 2, 3);
            Name = "TheCave";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "TheCave";
            Load += TheCave_Load;
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel1.PerformLayout();
            splitContainer1.Panel2.ResumeLayout(false);
            splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            pnlScreen.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pbPixels).EndInit();
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private SplitContainer splitContainer1;
        private Panel panel1;
        private TextBox txtHeight;
        private Label lblX;
        private TextBox txtWidth;
        private ComboBox comboOutput;
        private ComboBox comboScreen;
        private Panel panel2;
        private CheckBox checkBox1;
        private Label label3;
        private ComboBox comboBox1;
        private TextBox textBox1;
        private Label label2;
        private ListView listViewComponents;
        private Label label1;
        private Button buttonAdd;
        private CheckBox checkBox2;
        private Button button2;
        private TextBox textBox2;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel lblCurrXY;
        private Panel pnlScreen;
        private PictureBox pbPixels;
        private Button buttonClear;
    }
}