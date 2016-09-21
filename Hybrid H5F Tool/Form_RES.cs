using System;
using System.Windows.Forms;

namespace Hybrid_H5F_Tool
{
    public partial class Form_RES : Form
    {
        FormRunner Form = new FormRunner();

        private static Int32[] address = { 0x4E97F60, 0x4E97F64, 0x332FC18 };
        private Single DefaultWidth = 1920;
        private Single DefaultHeight = 1080;
        private Int32 MinWidth = 840;
        private Int32 MinHeight = 480;
        private Int32 MaxWidth = 7680;
        private Int32 MaxHeight = 4320;

        /*
         * private static Single AR1920x1080 = 1.777777791F;    // 16:9
         * private static Single AR1680x1050 = 1.6F;            // 16:10
         * private static Single AR2560x1080 = 2.37037037037F;  // 21:9
         * private static Single AR3440x1440 = 2.38888888889F;  // 21:9
         */

        public Form_RES()
        {
            InitializeComponent();
        }

        private void Form_RES_Load(object sender, EventArgs e)
        {
            ResInputWidth.Minimum = MinWidth;
            ResInputHeight.Minimum = MinHeight;
            ResTrackBarWidth.Minimum = MinWidth;
            ResTrackBarHeight.Minimum = MinHeight;

            ResInputWidth.Maximum = MaxWidth;
            ResInputHeight.Maximum = MaxHeight;
            ResTrackBarWidth.Maximum = MaxWidth;
            ResTrackBarHeight.Maximum = MaxHeight;

            if (Form.isGameRunning())
            {
                ResInputWidth.Value = (Decimal)get_res()[0];
                ResInputHeight.Value = (Decimal)get_res()[1];

                ResTrackBarWidth.Value = (Int32)get_res()[0];
                ResTrackBarHeight.Value = (Int32)get_res()[1];
            }
            else
            {
                ResInputWidth.Value = (Decimal)DefaultWidth;
                ResInputHeight.Value = (Decimal)DefaultHeight;

                ResTrackBarWidth.Value = (Int32)DefaultWidth;
                ResTrackBarHeight.Value = (Int32)DefaultHeight;
            }
        }

        private Single[] get_res()
        {
            Single[] Result = {
                BitConverter.ToInt32(Memory.AddressRead(address[0]), 0),
                BitConverter.ToInt32(Memory.AddressRead(address[1]), 0)
            };
            return Result;
        }

        private void set_res(Int32 Width, Int32 Height)
        {
            Memory.AddressWrite(address[0], BitConverter.GetBytes(Width));
            Memory.AddressWrite(address[1], BitConverter.GetBytes(Height));
            //set_asra(Width, Height);
        }

        private void set_asra(Int32 Width, Int32 Height)
        {
            Memory.AddressWrite(address[2], BitConverter.GetBytes(Width / Height));
        }

        private void ResDefault_Click(object sender, EventArgs e)
        {
            ResInputWidth.Value = (Decimal)DefaultWidth;
            ResTrackBarWidth.Value = (Int32)DefaultWidth;

            ResInputHeight.Value = (Decimal)DefaultHeight;
            ResTrackBarHeight.Value = (Int32)DefaultHeight;

            set_res((Int32)DefaultWidth, (Int32)DefaultHeight);
        }

        private void ResInputWidth_ValueChanged(object sender, EventArgs e)
        {
            ResTrackBarWidth.Value = (Int32)ResInputWidth.Value;

            set_res((Int32)ResInputWidth.Value, (Int32)ResInputHeight.Value);
        }

        private void ResInputHeight_ValueChanged(object sender, EventArgs e)
        {
            ResTrackBarHeight.Value = (Int32)ResInputHeight.Value;

            set_res((Int32)ResInputWidth.Value, (Int32)ResInputHeight.Value);
        }

        private void ResTrackBarWidth_Scroll(object sender, EventArgs e)
        {
            ResInputWidth.Value = ResTrackBarWidth.Value;

            set_res((Int32)ResInputWidth.Value, (Int32)ResInputHeight.Value);
        }

        private void ResTrackBarHeight_Scroll(object sender, EventArgs e)
        {
            ResInputHeight.Value = ResTrackBarHeight.Value;

            set_res(ResTrackBarWidth.Value, ResTrackBarHeight.Value);
        }
    }
}
