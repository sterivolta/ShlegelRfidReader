namespace ShlegelRfidReader;

partial class Main
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
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.COMPortsComboBox = new System.Windows.Forms.ComboBox();
			this.BaudRateComboBox = new System.Windows.Forms.ComboBox();
			this.label3 = new System.Windows.Forms.Label();
			this.DataBitsComboBox = new System.Windows.Forms.ComboBox();
			this.label4 = new System.Windows.Forms.Label();
			this.ParityComboBox = new System.Windows.Forms.ComboBox();
			this.label5 = new System.Windows.Forms.Label();
			this.HandshakeComboBox = new System.Windows.Forms.ComboBox();
			this.label6 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.LEDAutoCheckBox = new System.Windows.Forms.CheckBox();
			this.CycleCheckBox = new System.Windows.Forms.CheckBox();
			this.ManualCheckBox = new System.Windows.Forms.CheckBox();
			this.label8 = new System.Windows.Forms.Label();
			this.ClearButton = new System.Windows.Forms.Button();
			this.richTextBox1 = new System.Windows.Forms.RichTextBox();
			this.LedColorLabel = new System.Windows.Forms.Label();
			this.GreenButton = new System.Windows.Forms.Button();
			this.BlueButton = new System.Windows.Forms.Button();
			this.CyanButton = new System.Windows.Forms.Button();
			this.OffButton = new System.Windows.Forms.Button();
			this.uidTextBox = new System.Windows.Forms.RichTextBox();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.label1.ForeColor = System.Drawing.Color.White;
			this.label1.Location = new System.Drawing.Point(12, 83);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(93, 25);
			this.label1.TabIndex = 0;
			this.label1.Text = "COM Port";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.label2.ForeColor = System.Drawing.Color.White;
			this.label2.Location = new System.Drawing.Point(12, 22);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(93, 37);
			this.label2.TabIndex = 1;
			this.label2.Text = "SETUP";
			// 
			// COMPortsComboBox
			// 
			this.COMPortsComboBox.BackColor = System.Drawing.Color.DimGray;
			this.COMPortsComboBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.COMPortsComboBox.ForeColor = System.Drawing.Color.White;
			this.COMPortsComboBox.FormattingEnabled = true;
			this.COMPortsComboBox.ItemHeight = 21;
			this.COMPortsComboBox.Location = new System.Drawing.Point(111, 82);
			this.COMPortsComboBox.Name = "COMPortsComboBox";
			this.COMPortsComboBox.Size = new System.Drawing.Size(111, 29);
			this.COMPortsComboBox.TabIndex = 2;
			this.COMPortsComboBox.SelectedIndexChanged += new System.EventHandler(this.PortSelection);
			// 
			// BaudRateComboBox
			// 
			this.BaudRateComboBox.BackColor = System.Drawing.Color.DimGray;
			this.BaudRateComboBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.BaudRateComboBox.ForeColor = System.Drawing.Color.White;
			this.BaudRateComboBox.FormattingEnabled = true;
			this.BaudRateComboBox.ItemHeight = 21;
			this.BaudRateComboBox.Location = new System.Drawing.Point(376, 82);
			this.BaudRateComboBox.Name = "BaudRateComboBox";
			this.BaudRateComboBox.Size = new System.Drawing.Size(111, 29);
			this.BaudRateComboBox.TabIndex = 4;
			this.BaudRateComboBox.SelectedIndexChanged += new System.EventHandler(this.BaudRateComboBox_SelectedIndexChanged);
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.label3.ForeColor = System.Drawing.Color.White;
			this.label3.Location = new System.Drawing.Point(240, 83);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(130, 25);
			this.label3.TabIndex = 3;
			this.label3.Text = "Bit Rate (bit/s)";
			// 
			// DataBitsComboBox
			// 
			this.DataBitsComboBox.BackColor = System.Drawing.Color.DimGray;
			this.DataBitsComboBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.DataBitsComboBox.ForeColor = System.Drawing.Color.White;
			this.DataBitsComboBox.FormattingEnabled = true;
			this.DataBitsComboBox.ItemHeight = 21;
			this.DataBitsComboBox.Location = new System.Drawing.Point(624, 82);
			this.DataBitsComboBox.Name = "DataBitsComboBox";
			this.DataBitsComboBox.Size = new System.Drawing.Size(65, 29);
			this.DataBitsComboBox.TabIndex = 6;
			this.DataBitsComboBox.SelectedIndexChanged += new System.EventHandler(this.DataBitsComboBox_SelectedIndexChanged);
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.label4.ForeColor = System.Drawing.Color.White;
			this.label4.Location = new System.Drawing.Point(525, 83);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(86, 25);
			this.label4.TabIndex = 5;
			this.label4.Text = "Data Bits";
			// 
			// ParityComboBox
			// 
			this.ParityComboBox.BackColor = System.Drawing.Color.DimGray;
			this.ParityComboBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.ParityComboBox.ForeColor = System.Drawing.Color.White;
			this.ParityComboBox.FormattingEnabled = true;
			this.ParityComboBox.ItemHeight = 21;
			this.ParityComboBox.Location = new System.Drawing.Point(783, 82);
			this.ParityComboBox.Name = "ParityComboBox";
			this.ParityComboBox.Size = new System.Drawing.Size(65, 29);
			this.ParityComboBox.TabIndex = 8;
			this.ParityComboBox.SelectedIndexChanged += new System.EventHandler(this.ParityComboBox_SelectedIndexChanged);
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.label5.ForeColor = System.Drawing.Color.White;
			this.label5.Location = new System.Drawing.Point(718, 82);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(59, 25);
			this.label5.TabIndex = 7;
			this.label5.Text = "Parity";
			// 
			// HandshakeComboBox
			// 
			this.HandshakeComboBox.BackColor = System.Drawing.Color.DimGray;
			this.HandshakeComboBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.HandshakeComboBox.ForeColor = System.Drawing.Color.White;
			this.HandshakeComboBox.FormattingEnabled = true;
			this.HandshakeComboBox.ItemHeight = 21;
			this.HandshakeComboBox.Location = new System.Drawing.Point(987, 83);
			this.HandshakeComboBox.Name = "HandshakeComboBox";
			this.HandshakeComboBox.Size = new System.Drawing.Size(205, 29);
			this.HandshakeComboBox.TabIndex = 10;
			this.HandshakeComboBox.SelectedIndexChanged += new System.EventHandler(this.HandshakeComboBox_SelectedIndexChanged);
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.label6.ForeColor = System.Drawing.Color.White;
			this.label6.Location = new System.Drawing.Point(876, 83);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(105, 25);
			this.label6.TabIndex = 9;
			this.label6.Text = "Handshake";
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.label7.ForeColor = System.Drawing.Color.White;
			this.label7.Location = new System.Drawing.Point(12, 139);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(288, 37);
			this.label7.TabIndex = 11;
			this.label7.Text = "TRANSMISSION MODE";
			// 
			// LEDAutoCheckBox
			// 
			this.LEDAutoCheckBox.AutoSize = true;
			this.LEDAutoCheckBox.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.LEDAutoCheckBox.ForeColor = System.Drawing.Color.White;
			this.LEDAutoCheckBox.Location = new System.Drawing.Point(34, 202);
			this.LEDAutoCheckBox.Name = "LEDAutoCheckBox";
			this.LEDAutoCheckBox.Size = new System.Drawing.Size(179, 34);
			this.LEDAutoCheckBox.TabIndex = 12;
			this.LEDAutoCheckBox.Text = "LED Auto Mode";
			this.LEDAutoCheckBox.UseVisualStyleBackColor = true;
			this.LEDAutoCheckBox.CheckedChanged += new System.EventHandler(this.LEDAutoCheckBox_CheckedChanged);
			// 
			// CycleCheckBox
			// 
			this.CycleCheckBox.AutoSize = true;
			this.CycleCheckBox.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.CycleCheckBox.ForeColor = System.Drawing.Color.White;
			this.CycleCheckBox.Location = new System.Drawing.Point(289, 202);
			this.CycleCheckBox.Name = "CycleCheckBox";
			this.CycleCheckBox.Size = new System.Drawing.Size(81, 34);
			this.CycleCheckBox.TabIndex = 13;
			this.CycleCheckBox.Text = "Cycle";
			this.CycleCheckBox.UseVisualStyleBackColor = true;
			this.CycleCheckBox.CheckedChanged += new System.EventHandler(this.CycleCheckBox_CheckedChanged);
			// 
			// ManualCheckBox
			// 
			this.ManualCheckBox.AutoSize = true;
			this.ManualCheckBox.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.ManualCheckBox.ForeColor = System.Drawing.Color.White;
			this.ManualCheckBox.Location = new System.Drawing.Point(402, 202);
			this.ManualCheckBox.Name = "ManualCheckBox";
			this.ManualCheckBox.Size = new System.Drawing.Size(102, 34);
			this.ManualCheckBox.TabIndex = 15;
			this.ManualCheckBox.Text = "Manual";
			this.ManualCheckBox.UseVisualStyleBackColor = true;
			this.ManualCheckBox.Visible = false;
			this.ManualCheckBox.CheckedChanged += new System.EventHandler(this.ManualCheckBox_CheckedChanged);
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.label8.ForeColor = System.Drawing.Color.White;
			this.label8.Location = new System.Drawing.Point(12, 267);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(141, 37);
			this.label8.TabIndex = 16;
			this.label8.Text = "TRANSFER";
			// 
			// ClearButton
			// 
			this.ClearButton.ForeColor = System.Drawing.Color.Black;
			this.ClearButton.Location = new System.Drawing.Point(160, 273);
			this.ClearButton.Name = "ClearButton";
			this.ClearButton.Size = new System.Drawing.Size(62, 31);
			this.ClearButton.TabIndex = 17;
			this.ClearButton.Text = "CLEAR";
			this.ClearButton.UseVisualStyleBackColor = true;
			this.ClearButton.Click += new System.EventHandler(this.ClearButton_Click);
			// 
			// richTextBox1
			// 
			this.richTextBox1.BackColor = System.Drawing.Color.Gray;
			this.richTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.richTextBox1.ForeColor = System.Drawing.Color.White;
			this.richTextBox1.Location = new System.Drawing.Point(376, 310);
			this.richTextBox1.Name = "richTextBox1";
			this.richTextBox1.Size = new System.Drawing.Size(816, 173);
			this.richTextBox1.TabIndex = 18;
			this.richTextBox1.Text = "";
			// 
			// LedColorLabel
			// 
			this.LedColorLabel.AutoSize = true;
			this.LedColorLabel.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.LedColorLabel.ForeColor = System.Drawing.Color.White;
			this.LedColorLabel.Location = new System.Drawing.Point(22, 499);
			this.LedColorLabel.Name = "LedColorLabel";
			this.LedColorLabel.Size = new System.Drawing.Size(154, 37);
			this.LedColorLabel.TabIndex = 19;
			this.LedColorLabel.Text = "LED COLOR";
			this.LedColorLabel.Visible = false;
			// 
			// GreenButton
			// 
			this.GreenButton.BackColor = System.Drawing.Color.Green;
			this.GreenButton.FlatAppearance.BorderColor = System.Drawing.Color.Red;
			this.GreenButton.FlatAppearance.BorderSize = 0;
			this.GreenButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.GreenButton.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.GreenButton.Location = new System.Drawing.Point(22, 567);
			this.GreenButton.Name = "GreenButton";
			this.GreenButton.Size = new System.Drawing.Size(111, 59);
			this.GreenButton.TabIndex = 20;
			this.GreenButton.Text = "GREEN";
			this.GreenButton.UseVisualStyleBackColor = false;
			this.GreenButton.Visible = false;
			this.GreenButton.Click += new System.EventHandler(this.GreenButton_Click);
			// 
			// BlueButton
			// 
			this.BlueButton.BackColor = System.Drawing.Color.Blue;
			this.BlueButton.FlatAppearance.BorderColor = System.Drawing.Color.Red;
			this.BlueButton.FlatAppearance.BorderSize = 0;
			this.BlueButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.BlueButton.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.BlueButton.ForeColor = System.Drawing.Color.White;
			this.BlueButton.Location = new System.Drawing.Point(205, 567);
			this.BlueButton.Name = "BlueButton";
			this.BlueButton.Size = new System.Drawing.Size(111, 59);
			this.BlueButton.TabIndex = 21;
			this.BlueButton.Text = "BLUE";
			this.BlueButton.UseVisualStyleBackColor = false;
			this.BlueButton.Visible = false;
			this.BlueButton.Click += new System.EventHandler(this.BlueButton_Click);
			// 
			// CyanButton
			// 
			this.CyanButton.BackColor = System.Drawing.Color.Cyan;
			this.CyanButton.FlatAppearance.BorderColor = System.Drawing.Color.Red;
			this.CyanButton.FlatAppearance.BorderSize = 0;
			this.CyanButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.CyanButton.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.CyanButton.ForeColor = System.Drawing.Color.Black;
			this.CyanButton.Location = new System.Drawing.Point(402, 567);
			this.CyanButton.Name = "CyanButton";
			this.CyanButton.Size = new System.Drawing.Size(111, 59);
			this.CyanButton.TabIndex = 22;
			this.CyanButton.Text = "CYAN";
			this.CyanButton.UseVisualStyleBackColor = false;
			this.CyanButton.Visible = false;
			this.CyanButton.Click += new System.EventHandler(this.CyanButton_Click);
			// 
			// OffButton
			// 
			this.OffButton.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.OffButton.ForeColor = System.Drawing.Color.Black;
			this.OffButton.Location = new System.Drawing.Point(590, 567);
			this.OffButton.Name = "OffButton";
			this.OffButton.Size = new System.Drawing.Size(111, 59);
			this.OffButton.TabIndex = 23;
			this.OffButton.Text = "OFF";
			this.OffButton.UseVisualStyleBackColor = true;
			this.OffButton.Visible = false;
			this.OffButton.Click += new System.EventHandler(this.OffButton_Click);
			// 
			// uidTextBox
			// 
			this.uidTextBox.BackColor = System.Drawing.Color.Gray;
			this.uidTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.uidTextBox.ForeColor = System.Drawing.Color.White;
			this.uidTextBox.Location = new System.Drawing.Point(22, 310);
			this.uidTextBox.Name = "uidTextBox";
			this.uidTextBox.Size = new System.Drawing.Size(329, 173);
			this.uidTextBox.TabIndex = 24;
			this.uidTextBox.Text = "";
			// 
			// Main
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.DimGray;
			this.ClientSize = new System.Drawing.Size(1216, 663);
			this.Controls.Add(this.uidTextBox);
			this.Controls.Add(this.ClearButton);
			this.Controls.Add(this.OffButton);
			this.Controls.Add(this.CyanButton);
			this.Controls.Add(this.BlueButton);
			this.Controls.Add(this.GreenButton);
			this.Controls.Add(this.LedColorLabel);
			this.Controls.Add(this.richTextBox1);
			this.Controls.Add(this.label8);
			this.Controls.Add(this.ManualCheckBox);
			this.Controls.Add(this.CycleCheckBox);
			this.Controls.Add(this.LEDAutoCheckBox);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.HandshakeComboBox);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.ParityComboBox);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.DataBitsComboBox);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.BaudRateComboBox);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.COMPortsComboBox);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.ForeColor = System.Drawing.Color.White;
			this.Name = "Main";
			this.Text = "Shlegel RFID Reader";
			this.Load += new System.EventHandler(this.Main_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

  }

  #endregion

  private Label label1;
  private Label label2;
  private ComboBox COMPortsComboBox;
  private ComboBox BaudRateComboBox;
  private Label label3;
  private ComboBox DataBitsComboBox;
  private Label label4;
  private ComboBox ParityComboBox;
  private Label label5;
  private ComboBox HandshakeComboBox;
  private Label label6;
  private Label label7;
  private CheckBox LEDAutoCheckBox;
  private CheckBox CycleCheckBox;
  private CheckBox ManualCheckBox;
  private Label label8;
  private Button ClearButton;
  private RichTextBox richTextBox1;
  private Label LedColorLabel;
  private Button GreenButton;
  private Button BlueButton;
  private Button CyanButton;
  private Button OffButton;
  private RichTextBox uidTextBox;
}