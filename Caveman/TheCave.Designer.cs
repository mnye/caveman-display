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
      this.splitContainer1 = new System.Windows.Forms.SplitContainer();
      this.comboScreen = new System.Windows.Forms.ComboBox();
      this.comboOutput = new System.Windows.Forms.ComboBox();
      this.txtWidth = new System.Windows.Forms.TextBox();
      this.panel1 = new System.Windows.Forms.Panel();
      this.lblX = new System.Windows.Forms.Label();
      this.txtHeight = new System.Windows.Forms.TextBox();
      this.label1 = new System.Windows.Forms.Label();
      this.listView1 = new System.Windows.Forms.ListView();
      this.panel2 = new System.Windows.Forms.Panel();
      this.label2 = new System.Windows.Forms.Label();
      this.textBox1 = new System.Windows.Forms.TextBox();
      this.comboBox1 = new System.Windows.Forms.ComboBox();
      this.label3 = new System.Windows.Forms.Label();
      this.checkBox1 = new System.Windows.Forms.CheckBox();
      this.checkBox2 = new System.Windows.Forms.CheckBox();
      this.button1 = new System.Windows.Forms.Button();
      this.button2 = new System.Windows.Forms.Button();
      this.textBox2 = new System.Windows.Forms.TextBox();
      this.statusStrip1 = new System.Windows.Forms.StatusStrip();
      this.lblCurrXY = new System.Windows.Forms.ToolStripStatusLabel();
      ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
      this.splitContainer1.Panel1.SuspendLayout();
      this.splitContainer1.Panel2.SuspendLayout();
      this.splitContainer1.SuspendLayout();
      this.panel1.SuspendLayout();
      this.panel2.SuspendLayout();
      this.statusStrip1.SuspendLayout();
      this.SuspendLayout();
      // 
      // splitContainer1
      // 
      this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
      this.splitContainer1.Location = new System.Drawing.Point(0, 0);
      this.splitContainer1.Name = "splitContainer1";
      // 
      // splitContainer1.Panel1
      // 
      this.splitContainer1.Panel1.Controls.Add(this.button2);
      this.splitContainer1.Panel1.Controls.Add(this.button1);
      this.splitContainer1.Panel1.Controls.Add(this.panel2);
      this.splitContainer1.Panel1.Controls.Add(this.listView1);
      this.splitContainer1.Panel1.Controls.Add(this.label1);
      this.splitContainer1.Panel1.Controls.Add(this.panel1);
      this.splitContainer1.Panel1.Controls.Add(this.comboOutput);
      this.splitContainer1.Panel1.Controls.Add(this.comboScreen);
      // 
      // splitContainer1.Panel2
      // 
      this.splitContainer1.Panel2.Controls.Add(this.statusStrip1);
      this.splitContainer1.Size = new System.Drawing.Size(1501, 917);
      this.splitContainer1.SplitterDistance = 247;
      this.splitContainer1.TabIndex = 0;
      // 
      // comboScreen
      // 
      this.comboScreen.Dock = System.Windows.Forms.DockStyle.Top;
      this.comboScreen.FormattingEnabled = true;
      this.comboScreen.Location = new System.Drawing.Point(0, 0);
      this.comboScreen.Name = "comboScreen";
      this.comboScreen.Size = new System.Drawing.Size(247, 33);
      this.comboScreen.TabIndex = 0;
      this.comboScreen.Text = "Sharp MemoryLCD 2.7\"";
      // 
      // comboOutput
      // 
      this.comboOutput.Dock = System.Windows.Forms.DockStyle.Top;
      this.comboOutput.FormattingEnabled = true;
      this.comboOutput.Location = new System.Drawing.Point(0, 33);
      this.comboOutput.Name = "comboOutput";
      this.comboOutput.Size = new System.Drawing.Size(247, 33);
      this.comboOutput.TabIndex = 1;
      this.comboOutput.Text = "Adafruit GFX Library";
      // 
      // txtWidth
      // 
      this.txtWidth.Dock = System.Windows.Forms.DockStyle.Left;
      this.txtWidth.Location = new System.Drawing.Point(0, 0);
      this.txtWidth.Multiline = true;
      this.txtWidth.Name = "txtWidth";
      this.txtWidth.ReadOnly = true;
      this.txtWidth.Size = new System.Drawing.Size(62, 33);
      this.txtWidth.TabIndex = 0;
      this.txtWidth.Text = "400";
      // 
      // panel1
      // 
      this.panel1.Controls.Add(this.txtHeight);
      this.panel1.Controls.Add(this.lblX);
      this.panel1.Controls.Add(this.txtWidth);
      this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
      this.panel1.Location = new System.Drawing.Point(0, 66);
      this.panel1.Name = "panel1";
      this.panel1.Size = new System.Drawing.Size(247, 33);
      this.panel1.TabIndex = 3;
      // 
      // lblX
      // 
      this.lblX.Dock = System.Windows.Forms.DockStyle.Left;
      this.lblX.Location = new System.Drawing.Point(62, 0);
      this.lblX.Name = "lblX";
      this.lblX.Size = new System.Drawing.Size(29, 33);
      this.lblX.TabIndex = 3;
      this.lblX.Text = "x";
      this.lblX.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      // 
      // txtHeight
      // 
      this.txtHeight.Dock = System.Windows.Forms.DockStyle.Left;
      this.txtHeight.Location = new System.Drawing.Point(91, 0);
      this.txtHeight.Name = "txtHeight";
      this.txtHeight.ReadOnly = true;
      this.txtHeight.Size = new System.Drawing.Size(64, 31);
      this.txtHeight.TabIndex = 5;
      this.txtHeight.Text = "240";
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(12, 125);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(119, 25);
      this.label1.TabIndex = 4;
      this.label1.Text = "Components:";
      // 
      // listView1
      // 
      this.listView1.Location = new System.Drawing.Point(12, 153);
      this.listView1.Name = "listView1";
      this.listView1.Size = new System.Drawing.Size(173, 151);
      this.listView1.TabIndex = 5;
      this.listView1.UseCompatibleStateImageBehavior = false;
      // 
      // panel2
      // 
      this.panel2.Controls.Add(this.textBox2);
      this.panel2.Controls.Add(this.checkBox2);
      this.panel2.Controls.Add(this.checkBox1);
      this.panel2.Controls.Add(this.label3);
      this.panel2.Controls.Add(this.comboBox1);
      this.panel2.Controls.Add(this.textBox1);
      this.panel2.Controls.Add(this.label2);
      this.panel2.Location = new System.Drawing.Point(12, 522);
      this.panel2.Name = "panel2";
      this.panel2.Size = new System.Drawing.Size(217, 383);
      this.panel2.TabIndex = 6;
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Location = new System.Drawing.Point(27, 17);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(82, 25);
      this.label2.TabIndex = 0;
      this.label2.Text = "Selected:";
      // 
      // textBox1
      // 
      this.textBox1.Location = new System.Drawing.Point(27, 45);
      this.textBox1.Name = "textBox1";
      this.textBox1.Size = new System.Drawing.Size(136, 31);
      this.textBox1.TabIndex = 1;
      this.textBox1.Text = "comp name";
      // 
      // comboBox1
      // 
      this.comboBox1.FormattingEnabled = true;
      this.comboBox1.Items.AddRange(new object[] {
            "Static",
            "Text",
            "On/Off"});
      this.comboBox1.Location = new System.Drawing.Point(27, 168);
      this.comboBox1.Name = "comboBox1";
      this.comboBox1.Size = new System.Drawing.Size(141, 33);
      this.comboBox1.TabIndex = 3;
      this.comboBox1.Text = "Static";
      // 
      // label3
      // 
      this.label3.AutoSize = true;
      this.label3.Location = new System.Drawing.Point(27, 140);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(120, 25);
      this.label3.TabIndex = 4;
      this.label3.Text = "Variable Type:";
      // 
      // checkBox1
      // 
      this.checkBox1.AutoSize = true;
      this.checkBox1.Location = new System.Drawing.Point(27, 225);
      this.checkBox1.Name = "checkBox1";
      this.checkBox1.Size = new System.Drawing.Size(135, 29);
      this.checkBox1.TabIndex = 5;
      this.checkBox1.Text = "Is Selectable";
      this.checkBox1.UseVisualStyleBackColor = true;
      // 
      // checkBox2
      // 
      this.checkBox2.AutoSize = true;
      this.checkBox2.Location = new System.Drawing.Point(27, 269);
      this.checkBox2.Name = "checkBox2";
      this.checkBox2.Size = new System.Drawing.Size(131, 29);
      this.checkBox2.TabIndex = 6;
      this.checkBox2.Text = "Invert Color";
      this.checkBox2.UseVisualStyleBackColor = true;
      // 
      // button1
      // 
      this.button1.Location = new System.Drawing.Point(39, 342);
      this.button1.Name = "button1";
      this.button1.Size = new System.Drawing.Size(165, 31);
      this.button1.TabIndex = 7;
      this.button1.Text = "Add";
      this.button1.UseVisualStyleBackColor = true;
      // 
      // button2
      // 
      this.button2.Location = new System.Drawing.Point(39, 379);
      this.button2.Name = "button2";
      this.button2.Size = new System.Drawing.Size(165, 31);
      this.button2.TabIndex = 8;
      this.button2.Text = "Delete";
      this.button2.UseVisualStyleBackColor = true;
      // 
      // textBox2
      // 
      this.textBox2.Location = new System.Drawing.Point(27, 82);
      this.textBox2.Name = "textBox2";
      this.textBox2.Size = new System.Drawing.Size(136, 31);
      this.textBox2.TabIndex = 7;
      this.textBox2.Text = "type (e.g., line)";
      // 
      // statusStrip1
      // 
      this.statusStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
      this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblCurrXY});
      this.statusStrip1.Location = new System.Drawing.Point(0, 885);
      this.statusStrip1.Name = "statusStrip1";
      this.statusStrip1.Size = new System.Drawing.Size(1250, 32);
      this.statusStrip1.TabIndex = 0;
      this.statusStrip1.Text = "statusStrip1";
      // 
      // lblCurrXY
      // 
      this.lblCurrXY.Name = "lblCurrXY";
      this.lblCurrXY.Size = new System.Drawing.Size(37, 25);
      this.lblCurrXY.Text = "X,Y";
      // 
      // TheCave
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(1501, 917);
      this.Controls.Add(this.splitContainer1);
      this.Name = "TheCave";
      this.Text = "TheCave";
      this.splitContainer1.Panel1.ResumeLayout(false);
      this.splitContainer1.Panel1.PerformLayout();
      this.splitContainer1.Panel2.ResumeLayout(false);
      this.splitContainer1.Panel2.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
      this.splitContainer1.ResumeLayout(false);
      this.panel1.ResumeLayout(false);
      this.panel1.PerformLayout();
      this.panel2.ResumeLayout(false);
      this.panel2.PerformLayout();
      this.statusStrip1.ResumeLayout(false);
      this.statusStrip1.PerformLayout();
      this.ResumeLayout(false);

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
    private ListView listView1;
    private Label label1;
    private Button button1;
    private CheckBox checkBox2;
    private Button button2;
    private TextBox textBox2;
    private StatusStrip statusStrip1;
    private ToolStripStatusLabel lblCurrXY;
  }
}