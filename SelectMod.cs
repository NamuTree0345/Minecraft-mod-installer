using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MCInstaller
{
    public partial class SelectMod : Form
    {
        public SelectMod()
        {
            InitializeComponent();
        }

        // 설치 버튼
        private void button1_Click(object sender, EventArgs e)
        {
            ModInstall mi = new ModInstall();
            mi.Show();
        }

        private void SelectMod_Load(object sender, EventArgs e)
        {
            Loop.Start();
        }

        private void Loop_Tick(object sender, EventArgs e)
        {
            if (CustomNPC.Checked)
            {
                mods.CustomNPC = true;
            }
            else
            {
                mods.CustomNPC = false;
            }

            if (KoreanChat.Checked)
            {
                mods.KoreanChat = true;
            }
            else
            {
                mods.KoreanChat = false;
            }

            if (MiniMap.Checked)
            {
                mods.MiniMap = true;
            }
            else
            {
                mods.MiniMap = false;
            }

            if (Optifine.Checked)
            {
                mods.Optifine = true;
            }
            else
            {
                mods.Optifine = false;
            }
        }
    }
}
