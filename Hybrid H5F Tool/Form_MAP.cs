using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace Hybrid_H5F_Tool
{
    public partial class Form_MAP : Form
    {
        private static Int32[] address = { 0x3A25DA0 };

        public Form_MAP()
        {
            InitializeComponent();
        }

        private void Form_MAP_Load(object sender, EventArgs e)
        {

            IDictionary maps = new Dictionary<string, string> {
                {"Alpine", @"levels\multi\fo01_terrain_alpine\fo01_terrain_alpine"},
                {"Breakout Arena", @"levels\multi\fo_arena_breakout\fo_arena_breakout"},
                {"Coliseum", @"levels\multi\ng50_ss_coliseum\ng50_ss_coliseum"},
                //{"Eden", @"levels\multi\fo01_terrain_alpine\fo01_terrain_alpine"},
                //{"Empire", @"levels\multi\fo01_terrain_alpine\fo01_terrain_alpine"},
                //{"Fathom", @"levels\multi\ng23_ss_skew\ng23_ss_skew"},
                {"Glacier", @"levels\multi\fo02_glacier\fo02_glacier"},
                //{"Mercy", @"levels\multi\fo01_terrain_alpine\fo01_terrain_alpine"},
                //{"Molten", @"levels\multi\fo01_terrain_alpine\fo01_terrain_alpine"},
                //{"Overgrowth", @"levels\multi\fo01_terrain_alpine\fo01_terrain_alpine"},
                //{"Plaza", @"levels\multi\fo01_terrain_alpine\fo01_terrain_alpine"},
                {"Regret", @"levels\multi\ng43r_midship_remix\ng43r_midship_remix"},
                //{"Riptide", @"levels\multi\fo01_terrain_alpine\fo01_terrain_alpine"},
                {"Stasis", @"levels\multi\ng25_ss_pistons_remix\ng25_ss_pistons_remix"},
                //{"The Rig", @"levels\multi\fo01_terrain_alpine\fo01_terrain_alpine"},
                {"Tidal", @"levels\multi\fo04_ocean\fo04_ocean"},
                {"Torque", @"levels\multi\ng25_ss_pistons\ng25_ss_pistons"},
                {"Truth", @"levels\multi\ng43_midship\ng43_midship"},
                //{"Tyrant", @"levels\multi\fo01_terrain_alpine\fo01_terrain_alpine"},
                {"Parallax", @"levels\multi\fo03_space\fo03_space"},
                // ng11_la_courtyard
                // ng20_sa_towers\ng20_sa_towers crash
                // ng23_ss_skew = fathom
                //ng50r_ss_coliseum_remix
                //levels\multi\ng50r_ss_coliseum_remix\ng50r_ss_coliseum_remix
            };

            TutorialMapChangerMaps.DataSource = new BindingSource(maps, null);
            TutorialMapChangerMaps.DisplayMember = "Key";
            TutorialMapChangerMaps.ValueMember = "Value";
        }

        private void TutorialMapChangerChange_Click(object sender, EventArgs e)
        {
            string mapval = TutorialMapChangerMaps.SelectedValue.ToString();

            byte[] map = Encoding.ASCII.GetBytes(mapval);
            byte[] terminatedMap = new byte[map.Length + 1];

            map.CopyTo(terminatedMap, 0);
            terminatedMap[terminatedMap.Length - 1] = 0x00;

            Memory.AddressWrite(address[0], terminatedMap);
        }
    }
}
