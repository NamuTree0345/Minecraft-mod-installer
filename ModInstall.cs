using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace MCInstaller
{
    public partial class ModInstall : Form
    {

        string ModDirectory = "C:\\users\\" + Environment.UserName + "\\AppData\\Roaming\\.minecraft\\mods\\";
        string TempDirectory = Path.GetTempPath();


        public ModInstall()
        {
            InitializeComponent();
        }

        private void ModInstall_Load(object sender, EventArgs e)
        {
            if (MessageBox.Show("1.8.9 버전의 마크를 실행해주세요. 안그려면 에러납니다.") == DialogResult.OK)
            {
                try
                {
                    File.WriteAllBytes(TempDirectory + @"\forge-1.8.9.exe", Properties.Resources.forge_1_8_9_11_15_1_2318_1_8_9_installer_win);
                    System.Diagnostics.Process.Start(TempDirectory + @"\forge-1.8.9.exe");
                    System.Diagnostics.Process.Start("https://www.youtube.com/watch?v=Sa69u4bASFk");
                    if (MessageBox.Show("설치 다됬으면 확인 누르세요") == DialogResult.OK)
                    {
                        if (MessageBox.Show("1.8.9 버전의 마크를 한번 더 실행해주세요. 안그려면 에러납니다.") == DialogResult.OK)
                        {
                            progressBar1.Value = 60;
                            if (mods.CustomNPC)
                            {
                                File.WriteAllBytes(ModDirectory + "CustomNPC.jar", Properties.Resources.CustomNpcs_1_8_9_29oct16_);
                                progressBar1.Value = 70;
                            }
                            if (mods.KoreanChat)
                            {
                                File.WriteAllBytes(ModDirectory + "KoreanChat.jar", Properties.Resources.b79_189f);
                                progressBar1.Value = 80;
                            }
                            if (mods.MiniMap)
                            {
                                File.WriteAllBytes(ModDirectory + "MiniMap.jar", Properties.Resources.journeymap_1_8_8_5_1_3_unlimited);
                                progressBar1.Value = 90;
                            }
                            if (mods.Optifine)
                            {
                                System.Diagnostics.Process.Start("https://optifine.net/adloadx?f=OptiFine_1.8.9_HD_U_I7.jar&x=7ca2");
                                progressBar1.Value = 99;
                            }
                            FinishPage fp = new FinishPage();
                            fp.Show();

                        }
                    }
                }
                catch
                {
                    if (MessageBox.Show("설치를 하는 도중에 오류가났습니다. 죄송합니다.", "예외", MessageBoxButtons.OK, MessageBoxIcon.Error) == DialogResult.OK)
                    {
                        Application.Exit();
                    }
                }
            }
            

        }
    }
}
