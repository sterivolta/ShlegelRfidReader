using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.CompilerServices;
using System.IO.Ports;

namespace ShlegelRfidReader;
public partial class Main : Form
{
  private SerialPort _COMPort;

  private SerialPort COMPort
  {
    [MethodImpl(MethodImplOptions.Synchronized)]
    get
    {
      return _COMPort;
    }

    [MethodImpl(MethodImplOptions.Synchronized)]
    set
    {
      if (_COMPort != null)
      {
        _COMPort.DataReceived -= Receiver;
      }

      _COMPort = value;
      if (_COMPort != null)
      {
        _COMPort.DataReceived += Receiver;
      }
    }
  }
  private int var_manual = 0;                       // Variable so that the manual button does not trigger the event twice

  private byte[] _snrByteArray = new byte[18];

  public string UID { get; set; }

  public Main()
  {
    COMPort = new SerialPort();
    InitializeComponent();
  }


  private void Main_Load(object sender, EventArgs e)
  {
    foreach (var comboBox in SerialPort.GetPortNames())
    {
      COMPortsComboBox.Items.Add(comboBox);
    }

    BaudRateComboBox.Items.Add("2400");
    BaudRateComboBox.Items.Add("4800");
    BaudRateComboBox.Items.Add("7200");
    BaudRateComboBox.Items.Add("9600");
    BaudRateComboBox.Items.Add("14400");
    BaudRateComboBox.Items.Add("19200");
    BaudRateComboBox.Items.Add("38400");
    BaudRateComboBox.Items.Add("57600");
    BaudRateComboBox.Items.Add("115200");

    DataBitsComboBox.Items.Add("5");
    DataBitsComboBox.Items.Add("6");
    DataBitsComboBox.Items.Add("7");
    DataBitsComboBox.Items.Add("8");

    ParityComboBox.Items.Add("None");
    ParityComboBox.Items.Add("Odd");
    ParityComboBox.Items.Add("Even");
    ParityComboBox.Items.Add("Mark");
    ParityComboBox.Items.Add("Space");

    HandshakeComboBox.Items.Add("None");
    HandshakeComboBox.Items.Add("RequestToSend");
    HandshakeComboBox.Items.Add("RequestToSendXOnXOff");
    HandshakeComboBox.Items.Add("XOnXOff");
  }

  private void Receiver(object sender, SerialDataReceivedEventArgs e)
  {
    byte RXByte;
    int count = 0;
    do
    {
      do
      {
        RXByte = (byte)COMPort.ReadByte();
        _snrByteArray[count++] = RXByte;
      }
      while (!(COMPort.BytesToRead == 0));
      Display();
    }
    while (!(COMPort.BytesToRead == 0));
  }

  private void Display()
  {
    var serialNumberText = new StringBuilder("");
    for (int i = 0; _snrByteArray != null && i < _snrByteArray.Length; i++)
    {
      serialNumberText.Append(string.Format("{0:X2}", _snrByteArray[_snrByteArray.Length - 1 - i]));
    }
    UID = serialNumberText.ToString();

    richTextBox1.Invoke(() =>
    {
      richTextBox1.AppendText(UID + "\r\n");
      richTextBox1.ScrollToCaret();
    });


    byte[] data = new byte[8];
    Array.Copy(_snrByteArray, 9, data, 0, 8);
    serialNumberText = new StringBuilder("");
    for (int i = 0; data != null && i < data.Length; i++)
    {
      serialNumberText.Append(string.Format("{0:X2}", data[data.Length - 1 - i]));
    }
    UID = serialNumberText.ToString();

    uidTextBox.Invoke(() =>
    {
      uidTextBox.AppendText("UID:   " + UID + "\r\n");
      uidTextBox.ScrollToCaret();
    });
  }

  private void PortSelection(object sender, EventArgs e)
  {
    if (COMPort.IsOpen)
    {
      COMPort.RtsEnable = false;
      COMPort.DtrEnable = false;
      ClosePort();
      Application.DoEvents();
      Thread.Sleep(200);
    }

    COMPort.PortName = COMPortsComboBox.Text;

    COMPort.BaudRate = 115200; // Default: 115200 bit/s, 8 data bits, no parity, 1 stop bit
    COMPort.WriteTimeout = 2000;
    try
    {
      COMPort.Open();
    }
    catch (Exception ex)
    {
      MessageBox.Show(ex.Message);
    }

    BaudRateComboBox.Text = COMPort.BaudRate.ToString();
    DataBitsComboBox.Text = COMPort.DataBits.ToString();
    ParityComboBox.Text = COMPort.Parity.ToString();
    HandshakeComboBox.Text = COMPort.Handshake.ToString();
    if (COMPort.IsOpen)
    {
      COMPort.RtsEnable = true;
      COMPort.DtrEnable = true;
      CycleCheckBox.Checked = true;
      LEDAutoCheckBox.Checked = true;
    }
  }

  private void ClosePort()
  {
    if (COMPort.IsOpen)
      COMPort.Close();
  }

  private void TransmitToReader(string str_text)
  {
    string TextString;
    byte[] TXArray = new byte[2048];
    int J = 0;
    bool Ascii = false;
    bool Quote = false;
    bool Temp;
    bool Second = false;
    byte TXByte = 0;
    byte CharByte;
    if (COMPort.IsOpen)
    {
      TextString = str_text;
      for (int i = 0; i <= TextString.Length - 1; i++)
      {
        CharByte = (byte)TextString[i];
        if (CharByte == 34)
        {
          Temp = Ascii;
          Ascii = Ascii | Quote;
          Quote = !(Temp & Quote);
        }
        else
        {
          Ascii = Ascii ^ Quote;
          Quote = false;
        }
        if (!Quote)
        {
          if (Ascii)
          {
            TXArray[J] = CharByte;
            J = J + 1;
          }
          else if ((CharByte != 32) & (CharByte != 10) & (CharByte != 13))
          {
            CharByte = (byte)((CharByte - 48) & 31); // And 31 makes it case insensitive
            if (CharByte > 16)
              CharByte = (byte)(CharByte - 7);
            if (Second)
            {
              TXArray[J] = (byte)(TXByte + CharByte);
              Second = false;
              J = J + 1;
            }
            else
            {
              TXByte = (byte)(CharByte << 4);
              Second = true;
            }
          }
        }
      }
      try
      {
        COMPort.Write(TXArray, 0, J);
      }
      catch (Exception ex)
      {
        MessageBox.Show(ex.Message + "  Check CTS signal or set Flow Control to None.");
      }
    }
    else
    {
    }
  }

  private void LEDAutoCheckBox_CheckedChanged(object sender, EventArgs e)
  {
    if (!LEDAutoCheckBox.Checked)
    {
      GreenButton.Visible = true;
      BlueButton.Visible = true;
      CyanButton.Visible = true;
      OffButton.Visible = true;
      LedColorLabel.Visible = true;
    }
    else
    {
      GreenButton.Visible = false;
      BlueButton.Visible = false;
      CyanButton.Visible = false;
      OffButton.Visible = false;
      LedColorLabel.Visible = false;
      LedOff();
    }
  }

  private void GreenButton_Click(object sender, EventArgs e)
  {
    LedGreen();
  }

  private void BlueButton_Click(object sender, EventArgs e)
  {
    LedBlue();
  }

  private void CyanButton_Click(object sender, EventArgs e)
  {
    LedCyan();
  }

  private void OffButton_Click(object sender, EventArgs e)
  {
    LedOff();
  }

  private void CycleCheckBox_CheckedChanged(object sender, EventArgs e)
  {
    if (LEDAutoCheckBox.Checked && CycleCheckBox.Checked)
    {
      CycleSendOn();
      SingleSendOff();
      ManualCheckBox.Enabled = false;
      ManualCheckBox.Checked = false;
      ManualCheckBox.Visible = false;
    }
    else if (LEDAutoCheckBox.Checked && CycleCheckBox.Checked is false)
    {
      CycleSendOff();
      Thread.Sleep(100);
      SingleSendOn();
      ManualCheckBox.Enabled = true;
      ManualCheckBox.Checked = true;
      ManualCheckBox.Visible = true;
      LEDAutoCheckBox.Enabled = true;
    }

    if (LEDAutoCheckBox.Checked is false && CycleCheckBox.Checked)
    {
      CycleSendOnLED();
      SingleSendOff();
      ManualCheckBox.Enabled = false;
      ManualCheckBox.Checked = false;
      ManualCheckBox.Visible = false;
      LEDAutoCheckBox.Enabled = false;
    }
    else if (LEDAutoCheckBox.Checked is false && CycleCheckBox.Checked is false)
    {
      CycleSendOff();
      SingleSendOnLED();
      ManualCheckBox.Enabled = true;
      ManualCheckBox.Checked = true;
      ManualCheckBox.Visible = true;
      LEDAutoCheckBox.Enabled = true;
    }
  }

  private void ManualCheckBox_CheckedChanged(object sender, EventArgs e)
  {
    var_manual += 1;

    if (var_manual == 1)
      ManualSend();
    else
      var_manual = 0;

    ManualCheckBox.Checked = false;
  }

  private void ClearButton_Click(object sender, EventArgs e)
  {
    richTextBox1.Clear();
    uidTextBox.Clear();
  }

  private void BaudRateComboBox_SelectedIndexChanged(object sender, EventArgs e)
  {
    COMPort.BaudRate = System.Convert.ToInt32(BaudRateComboBox.Text);
  }

  private void DataBitsComboBox_SelectedIndexChanged(object sender, EventArgs e)
  {
    COMPort.DataBits = System.Convert.ToInt32(DataBitsComboBox.Text);
  }

  private void ParityComboBox_SelectedIndexChanged(object sender, EventArgs e)
  {
    COMPort.Parity = (Parity)Enum.Parse(typeof(Parity), ParityComboBox.Text);
  }

  private void HandshakeComboBox_SelectedIndexChanged(object sender, EventArgs e)
  {
    COMPort.Handshake = (Handshake)Enum.Parse(typeof(Handshake), HandshakeComboBox.Text);
  }

  #region Send

  // Switch on cyclic sending
  public void CycleSendOn() => TransmitToReader("50 00 05 23 FF 64 00 04 05 EC");
  // Switch on cyclic sending with external control of the LEDs
  public void CycleSendOnLED() => TransmitToReader("50 00 05 23 FF 64 00 04 00 E9");
  // Switch off cyclic sending
  public void CycleSendOff() => TransmitToReader("50 00 05 23 FF 00 00 00 00 89");
  // Turn on single send
  public void SingleSendOn() => TransmitToReader("50 00 05 23 FF 01 00 01 05 8C");
  // Turn on single send with external control of the LEDs
  public void SingleSendOnLED() => TransmitToReader("50 00 05 23 FF 64 00 01 00 EC");
  // Turn off single send
  public void SingleSendOff() => TransmitToReader("50 00 05 23 FF 00 00 00 00 89");
  // Manual transmission ISO 14443 Mifare
  public void ManualSend() => TransmitToReader("50 00 02 22 10 52 32");
  // Turn on the Green LED
  public void LedGreen() => TransmitToReader("50 00 03 03 FF 07 01 A9");
  // Turn on the Blue LED
  public void LedBlue() => TransmitToReader("50 00 03 03 FF 07 04 AC");
  // Turn on the Cyan LED
  public void LedCyan() => TransmitToReader("50 00 03 03 FF 07 05 AD");
  // All LEDs Off
  public void LedOff() => TransmitToReader("50 00 03 03 FF 07 00 A8");



  #endregion

}
