using System;
using System.Windows.Forms;

namespace Hybrid_H5F_Tool
{
    public partial class Form_FOV : Form
    {
        FormRunner Form = new FormRunner();

        private static Int32[] address = { 0x58ECF90 };
        private Single Default = 78;
        private Int32 Min = 65;
        private Int32 Max = 150;

        public Form_FOV()
        {
            InitializeComponent();
        }

        private void Form_FOV_Load(object sender, EventArgs e)
        {
            FovInput.Minimum = Min;
            FovTrackBar.Minimum = Min;

            FovInput.Maximum = Max;
            FovTrackBar.Maximum = Max;

            if (Form.isGameRunning())
            {
                FovInput.Value = (Decimal)get_fov();
                FovTrackBar.Value = (Int32)get_fov();
            }
            else
            {
                FovInput.Value = (Decimal)Default;
                FovTrackBar.Value = (Int32)Default;
            }
        }

        private Single get_fov()
        {
            Single Result;
            Result = BitConverter.ToSingle(Memory.AddressRead(address[0]), 0);
            return Result;
        }

        private void set_fov(Single Value)
        {
            Memory.AddressWrite(address[0], BitConverter.GetBytes(Value));
        }

        private void FovDefault_Click(object sender, EventArgs e)
        {
            FovInput.Value = (Decimal)Default;
            FovTrackBar.Value = (Int32)Default;

            set_fov(Default);
        }

        private void FovInput_ValueChanged(object sender, EventArgs e)
        {
            FovTrackBar.Value = (Int32)FovInput.Value;

            set_fov((Single)FovInput.Value);
        }

        private void FovTrackBar_Scroll(object sender, EventArgs e)
        {
            FovInput.Value = FovTrackBar.Value;

            set_fov(FovTrackBar.Value);
        }
    }
}
