using Modbus.Device;
using ModBusV1.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ModBusV1
{
    public partial class FrmMain : Form
    {
        SerialPort serialPort;
        IModbusSerialMaster master;
        byte slaveAddress = Properties.Settings.Default.Address;


        public static int[] BaudRate = new int[] { 4800, 9600, 19200, 38400, 57600, 115200 };
        public static int[] DataBits = new int[] { 7, 8 };
        public static int[] StepBits = new int[] { 1, 2 };

        public FrmMain()
        {
            InitializeComponent();
            serialPort = new SerialPort();
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            UpdateStatus();
            tmr.Interval = Properties.Settings.Default.Refresh;
        }

        private void MnuFileSettings_Click(object sender, EventArgs e)
        {
            FrmSettings frmSettings = new FrmSettings();
            var result = frmSettings.ShowDialog(this);

            if (result == DialogResult.OK)
            {
                Properties.Settings.Default.ComPort = frmSettings.cmbComPort.Text;
                Properties.Settings.Default.Baudrate = int.Parse(frmSettings.cmbBaudrate.Text);
                Properties.Settings.Default.DataBits = int.Parse(frmSettings.cmbDataBits.Text);
                Properties.Settings.Default.ParityBits = frmSettings.cmbParityBits.SelectedIndex;
                Properties.Settings.Default.StopBits = frmSettings.cmbStopBits.SelectedIndex;
                Properties.Settings.Default.Refresh = int.Parse(frmSettings.NumRefresh.Value.ToString());
                Properties.Settings.Default.Address = byte.Parse(frmSettings.NumAddress.Value.ToString());
                slaveAddress = Properties.Settings.Default.Address;
                tmr.Interval = Properties.Settings.Default.Refresh;

                Properties.Settings.Default.Save();
                UpdateStatus();
            }

            frmSettings.Dispose();
        }

        private void UpdateStatus()
        {
            stsComPort.Text = "Port: " + Properties.Settings.Default.ComPort;
            stsBaudRate.Text = "Baud Rate: " + Properties.Settings.Default.Baudrate;
            stsDataBits.Text = "Data Bits: " + Properties.Settings.Default.DataBits;
            stsParity.Text = "Patity: " + (Parity)Properties.Settings.Default.ParityBits;
            stsStopBits.Text = "Stop Bits: " + (StopBits)Properties.Settings.Default.StopBits;
        }

        private void MnuFileConnect_Click(object sender, EventArgs e)
        {
            try
            {
                serialPort = new SerialPort();
                serialPort.PortName = Properties.Settings.Default.ComPort;
                serialPort.BaudRate = Properties.Settings.Default.Baudrate;
                serialPort.DataBits = Properties.Settings.Default.DataBits;
                serialPort.Parity = (Parity)Properties.Settings.Default.ParityBits;
                serialPort.StopBits = (StopBits)Properties.Settings.Default.StopBits;

                if (!serialPort.IsOpen) serialPort.Open();
                master = ModbusSerialMaster.CreateRtu(serialPort);
                master.Transport.ReadTimeout = 1000;
                master.Transport.WriteTimeout = 1000;

                stsState.Text = "Connected";
                stsState.ForeColor = Color.DarkGreen;
                mnuFileConnect.Enabled = false;
                mnuFileSettings.Enabled = false;
                mnuFileDisConnect.Enabled = true;
                LblSpeed.Visible = true;
                LblAmper.Visible = true;
                BtnStop.Visible = true;
                BtnRight.Visible = true;
                BtnLeft.Visible = true;
                LblA.Visible = true;
                LblF.Visible = true;
                BtnInc.Visible = true;
                BtnDec.Visible = true;
                BarSpeed.Visible = true;

                BackgroundImage = null;

                tmr.Start();
            }
            catch (IOException exIO)
            {
                if (exIO.HResult == -2146232800)
                    MessageBox.Show(this, "SerialPort is not available.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                else
                    MessageBox.Show(this, exIO.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void MnuFileExit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(this, "Do you want to close?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                serialPort.Close();
                serialPort.Dispose();
                master.Dispose();
                this.Dispose();
            }
        }

        private void MnuFileDisConnect_Click(object sender, EventArgs e)
        {
            tmr.Stop();
            serialPort.Close();
            serialPort.Dispose();
            master.Dispose();

            stsState.Text = "Disconnected";
            stsState.ForeColor = Color.DarkRed;
            mnuFileConnect.Enabled = true;
            mnuFileSettings.Enabled = true;
            mnuFileDisConnect.Enabled = false;
            LblSpeed.Visible = false;
            LblAmper.Visible = false;
            BtnStop.Visible = false;
            BtnRight.Visible = false;
            BtnLeft.Visible = false;
            LblA.Visible = false;
            LblF.Visible = false;
            BtnInc.Visible = false;
            BtnDec.Visible = false;
            BarSpeed.Visible = false;
        }

        private void BtnInc_Click(object sender, EventArgs e)
        {
            var val = decimal.Parse(LblSpeed.Text) * 100;
            val += 100;
            if (val > 5000) val = 5000;
            master.WriteSingleRegister(slaveAddress, 0x2001, (ushort)val);
            LblSpeed.Text = (val / 100).ToString("0.0");
        }

        private void BtnDec_Click(object sender, EventArgs e)
        {
            var val = decimal.Parse(LblSpeed.Text) * 100;
            val -= 100;
            if (val < 0) val = 0;
            master.WriteSingleRegister(slaveAddress, 0x2001, (ushort)val);
            LblSpeed.Text = (val / 100).ToString("0.0");
        }

        private void BtnStop_Click(object sender, EventArgs e)
        {
            master.WriteSingleRegister(slaveAddress, 0x2000, 1);
        }

        private void BtnRight_Click(object sender, EventArgs e)
        {
            master.WriteSingleRegister(slaveAddress, 0x2000, 18);
        }

        private void BtnLeft_Click(object sender, EventArgs e)
        {
            master.WriteSingleRegister(slaveAddress, 0x2000, 34);
        }

        private void tmr_Tick(object sender, EventArgs e)
        {
            try
            {
                var speeds = master.ReadHoldingRegisters(slaveAddress, 0x2102, 1);
                decimal speed = speeds[0];
                speed /= 100;
                LblSpeed.Text = speed.ToString("0.0");
                BarSpeed.Value = Convert.ToInt32(speed * 100);

                var ampers = master.ReadHoldingRegisters(slaveAddress, 0x2104, 1);
                decimal amper = ampers[0];
                amper /= 10;
                LblAmper.Text = amper.ToString("0.0");
            }
            catch (Exception ex)
            {
                MnuFileDisConnect_Click(this, new EventArgs());

                if (ex.HResult == -2146233083)
                    MessageBox.Show(this, "Check SlaveAddress then try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                    MessageBox.Show(this, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BarSpeed_Scroll(object sender, EventArgs e)
        {
            master.WriteSingleRegister(slaveAddress, 0x2001, (ushort)BarSpeed.Value);
        }
    }
}
