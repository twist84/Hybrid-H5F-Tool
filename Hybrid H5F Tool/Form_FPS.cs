using System;
using System.Windows.Forms;

namespace Hybrid_H5F_Tool
{
    public partial class Form_FPS : Form
    {
        FormRunner Form = new FormRunner();

        private static Int32[] address = { 0x34B8C50, 0x34B8C60, 0x34B8C70 };
        private Single Default = 60;
        private Int32 Min = 30;
        private Int32 Max = 300;

        public Form_FPS()
        {
            InitializeComponent();
        }

        private void Form_FPS_Load(object sender, EventArgs e)
        {
            FpsInput.Minimum = Min;
            FpsTrackBar.Minimum = Min;

            FpsInput.Maximum = Max;
            FpsTrackBar.Maximum = Max;

            if (Form.isGameRunning())
            {
                FpsInput.Value = (Decimal)get_fps();
                FpsTrackBar.Value = (Int32)get_fps();
            }
            else
            {
                FpsInput.Value = (Decimal)Default;
                FpsTrackBar.Value = (Int32)Default;
            }
        }

        private Single get_fps()
        {
            Single Result;
            Result = BitConverter.ToInt16(Memory.AddressRead(address[0]), 0);
            return 1000000 / Result;
        }

        private void set_fps(Single Value)
        {
            for (Int32 i = 0; i < address.Length; i++)
                Memory.AddressWrite(address[i], BitConverter.GetBytes(1000000 / Convert.ToInt16(Value)));
        }

        private void FpsDefault_Click(object sender, EventArgs e)
        {
            FpsInput.Value = (Decimal)Default;
            FpsTrackBar.Value = (Int32)Default;

            set_fps(Default);
        }

        private void FpsInput_ValueChanged(object sender, EventArgs e)
        {
            FpsTrackBar.Value = (Int32)FpsInput.Value;

            set_fps((Single)FpsInput.Value);
        }

        private void FpsTrackBar_Scroll(object sender, EventArgs e)
        {
            FpsInput.Value = FpsTrackBar.Value;

            set_fps(FpsTrackBar.Value);
        }
    }
}
