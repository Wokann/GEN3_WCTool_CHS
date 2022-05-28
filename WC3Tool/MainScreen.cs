/*
 * Created by SharpDevelop.
 * User: suloku
 * Date: 29/04/2016
 * Time: 13:45
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Windows.Forms;
using System.Reflection;

namespace WC3Tool
{
	/// <summary>
	/// Description of MainScreen.
	/// </summary>
	public partial class MainScreen : Form
	{
		public string version()
		{
			Version version = Assembly.GetExecutingAssembly().GetName().Version;
			DateTime buildDate = new DateTime(2000, 1, 1).AddDays(version.Build).AddSeconds(version.Revision*2);
			return $"BUILD {buildDate.Year}{buildDate.Month}{buildDate.Day}_{buildDate.Hour}{buildDate.Minute}{buildDate.Second}";
		}
		
		public MainScreen()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			region_lab.Text = "";
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		public static string savfilter = "原始存档文件|*.sav;*sa1;*sa2|所有文件(*.*)|*.*";
		public string wc3filter = "神秘卡片文件|*.wc3|所有文件(*.*)|*.*";
		public string wcnfilter = "神秘新闻文件|*.wn3|所有文件(*.*)|*.*";
		public string me3filter = "神秘事件文件|*.me3|所有文件(*.*)|*.*";
		public string ectfilter = "e卡训练家文件|*.ect|所有文件(*.*)|*.*";
		public string berryfilter = "e卡树果文件|*.ecb|所有文件(*.*)|*.*";
		public byte[] savbuffer;
		public byte[] wc3new;
		public byte[] wcnnew;
		public byte[] me3file;
		public byte[] ectfile;
		public byte[] berryfile;
		public static SAV3 sav3file;
		void Button1Click(object sender, EventArgs e)
		{
			Form wc3edit = new WC3_editor();
			wc3edit.ShowDialog();
		}
		
		void update_button_state()
		{
				export_wc3but.Enabled = false;
				inject_wc3_but.Enabled = false;
				export_wcn.Enabled = false;
				inject_wcn.Enabled = false;
				export_me3_but.Enabled = false;
				inject_me3_but.Enabled = false;
				eon_em_but.Enabled = false;
				decor_but.Enabled = false;
				export_ect_but.Enabled = false;
				inject_ect_but.Enabled = false;
				export_eberry.Enabled = false;
				inject_eberry.Enabled = false;
				tvswarm_but.Enabled = false;
				
				region_but.Enabled = false;
				
				toolStripMenuItem1.Enabled = false;
				exportOldSaveToolStripMenuItem.Enabled = false;
				enableMysteryGiftMainScreenStripMenuItem.Enabled = false;
				fixSectionChecksumsToolStripMenuItem.Enabled = false;
				
				switch(sav3file.game)
				{
					case 0:
						//Gamelabel.Text = "红宝石/蓝宝石";
						export_me3_but.Enabled = true;
						inject_me3_but.Enabled = true;
						decor_but.Enabled = true;
						export_eberry.Enabled = true;
						inject_eberry.Enabled = true;
						tvswarm_but.Enabled = true;
						break;
					case 1:
						//Gamelabel.Text = "绿宝石";
						export_wc3but.Enabled = true;
						inject_wc3_but.Enabled = true;
						export_wcn.Enabled = true;
						inject_wcn.Enabled = true;
						export_me3_but.Enabled = true;
						inject_me3_but.Enabled = true;
						eon_em_but.Enabled = true;
						decor_but.Enabled = true;
						tvswarm_but.Enabled = true;
						break;
					case 2:
						//Gamelabel.Text = "火红/叶绿";
						export_wc3but.Enabled = true;
						inject_wc3_but.Enabled = true;
						export_wcn.Enabled = true;
						inject_wcn.Enabled = true;
						tvswarm_but.Enabled = false;
						break;
					default:
						//Gamelabel.Text = "无法识别存档对应游戏。";
						break;
				}
				toolStripMenuItem1.Enabled = true;
				exportOldSaveToolStripMenuItem.Enabled = true;
				enableMysteryGiftMainScreenStripMenuItem.Enabled = true;
				fixSectionChecksumsToolStripMenuItem.Enabled = true;
				clearEggEventFlagToolStripMenuItem.Enabled = sav3file.has_EggEvent_Flag();
				
				export_ect_but.Enabled = true;
				inject_ect_but.Enabled = true;
				
				region_lab.Text = sav3file.isjap ? "日版" : "美/欧版";

				region_but.Enabled = true;
		}
		
		void Load_save(string path)
		{
			int filesize = FileIO.load_file(ref savbuffer, ref path, savfilter);
			if( filesize == SAV3.SAVE_SIZE)
			{				
				sav3_path.Text = path;
				sav3file = new SAV3(savbuffer);
				
				update_button_state();
				
				language_box.SelectedIndex = sav3file.language-1;
				game_box.SelectedIndex = sav3file.game;

				if (sav3file.isjap && sav3file.language != 1)
				{
					DialogResult dialogResult = MessageBox.Show("区域/语言检测不一致。\n\n这是日版的游戏存档吗？", "输入区域", MessageBoxButtons.YesNo);
					if(dialogResult == DialogResult.Yes)
					{
						sav3file.isjap = true;
						region_lab.Text = "日版";
						language_box.SelectedIndex = 0;
					}
					else if (dialogResult == DialogResult.No)
					{
						sav3file.isjap = false;
						region_lab.Text = "美/欧版";
					}
				}
				sav3file.updateOffsets();
	
			}else if (filesize == -1){
			}else{
				MessageBox.Show("无效文件。");
			}
		}
		void Load_save_butClick(object sender, EventArgs e)
		{
			Load_save(null);
		}
		void Export_wc3butClick(object sender, EventArgs e)
		{
			if(sav3file.has_WC == false)
				MessageBox.Show("存档未包含神秘卡片数据。");
			else
				FileIO.save_data(sav3file.get_WC3(), wc3filter);
		}
		void Inject_wc3_butClick(object sender, EventArgs e)
		{
			if(sav3file.has_WC)
			{
				DialogResult dialogResult = MessageBox.Show("存档已经有一张神秘卡片了，是否覆盖？", "神秘卡片配信中", MessageBoxButtons.YesNo);
				if(dialogResult == DialogResult.No)
				{
					return;
				}
			}
					if (sav3file.has_mystery_gift)
					{
						string path = null;
						int filesize = FileIO.load_file(ref wc3new, ref path, wc3filter);
						if( filesize == wc3.SIZE_WC3 && sav3file.isjap == false || filesize == wc3.SIZE_WC3_jap  && sav3file.isjap )
						{				
							sav3file.set_WC3(wc3new);
							//custom_script.Checked = true;
							//Add fix sav3 checksum func3
							sav3file.update_section_chk(4);
							MessageBox.Show("神秘卡片配信完成。");
							FileIO.save_data(sav3file.Data, savfilter);
							
						}else if (filesize == -1){
							;
						}else{
							MessageBox.Show("无效文件大小。");
						}
					}else
					{
						MessageBox.Show("存档未开启神秘礼物功能。");
					}
		}
		void Export_wcnClick(object sender, EventArgs e)
		{
			if(sav3file.has_WCN == false)
				MessageBox.Show("存档未包含神秘新闻数据。");
			else
			FileIO.save_data(sav3file.get_WCN(), wcnfilter);
		}
		void Inject_wcnClick(object sender, EventArgs e)
		{
			if (sav3file.has_mystery_gift)
			{
				string path = null;
				int filesize = FileIO.load_file(ref wcnnew, ref path, wcnfilter);
				if( filesize == SAV3.WCN_SIZE && sav3file.isjap == false || filesize == SAV3.WCN_SIZE_jap  && sav3file.isjap )
				{				
					sav3file.set_WCN(wcnnew);
					//custom_script.Checked = true;
					//Add fix sav3 checksum func3
					sav3file.update_section_chk(4);
					MessageBox.Show("神秘新闻配信完成。");
					FileIO.save_data(sav3file.Data, savfilter);
					
				}else if (filesize == -1){
					;
				}else{
					MessageBox.Show("无效文件大小。");
				}
			}else
			{
				MessageBox.Show("存档未开启神秘礼物功能。");
			}
		}
		void Wcn_edit_butClick(object sender, EventArgs e)
		{
			Form wcnedit = new WCN_editor();
			wcnedit.ShowDialog();
		}
		void Export_me3_butClick(object sender, EventArgs e)
		{
			int check = sav3file.has_ME3();
			if(check == 0)
				MessageBox.Show("存档未包含神秘事件数据。");
			else if(check == 2)
				MessageBox.Show("存档包含神秘事件数据，但脚本已从存档数据中被删除。");
			
			if (check != 0)
				FileIO.save_data(sav3file.get_ME3(), me3filter);
		}
		void Inject_me3_butClick(object sender, EventArgs e)
		{
			if (sav3file.has_mystery_event || sav3file.game == 1)
			{
				if (sav3file.game == 1)
					MessageBox.Show("非日版绿宝石里已移除神秘事件。\n\t您仍可以自行承担风险继续配信数据。");
				string path = null;
				int filesize = FileIO.load_file(ref me3file, ref path, me3filter);
				if( filesize == sav3file.me3_size )
				{	
					ME3 me3_struct = new ME3(me3file, filesize);
					if (sav3file.game != me3_struct.isemerald)
					{
						MessageBox.Show("神秘事件文件不适用于此游戏！");
					}else
					{
						sav3file.set_ME3(me3file);
						//custom_script.Checked = true;
						//Add fix sav3 checksum func3
						sav3file.update_section_chk(4);
						MessageBox.Show("神秘事件配信完成。");
						FileIO.save_data(sav3file.Data, savfilter);
					}
					
				}else if (filesize == -1){
				}else{
					MessageBox.Show("无效文件大小。");
				}
			}else
			{
				MessageBox.Show("存档未开启神秘事件功能。");
			}
		}
		void Me3_editor_butClick(object sender, EventArgs e)
		{
			Form me3edit = new ME3_editor();
			me3edit.ShowDialog();
		}
		void Eon_em_butClick(object sender, EventArgs e)
		{
			MessageBox.Show("无限船票将作为日版活动配信。\n请注意此活动从未在日本以外地区配信过。\n如您想在非日版绿宝石获得合法无限船票，请与配信了无限船票的红宝石/蓝宝石进行混合记录。");
			sav3file.enable_eon_emerald();
			MessageBox.Show("神秘事件无限船票配信完成。\n\n注：如存档在宝可梦中心二楼保存, 您需离开二楼再返回以使蓝色邮递员出现。");
			FileIO.save_data(sav3file.Data, savfilter);
		}
		void EnableMysteryGiftMainScreenStripMenuItemClick(object sender, EventArgs e)
		{
			sav3file.enable_Mystery();
			FileIO.save_data(sav3file.Data, savfilter);
		}
		void Region_butClick(object sender, EventArgs e)
		{
			/*
			sav3file.prompt_region("这是日版的游戏存档吗？");
				if (sav3file.isjap)
					region_text.Text = "日版";
				else
					region_text.Text = "美/欧版";
			*/
			game_box.Enabled = true;
			language_box.Enabled = true;
		}
		void FixSectionChecksumsToolStripMenuItemClick(object sender, EventArgs e)
		{
			sav3file.fix_section_checksums();
			FileIO.save_data(sav3file.Data, savfilter);
		}
		void Decor_butClick(object sender, EventArgs e)
		{
			Form decoredit = new Decor_editor(sav3file);
			decoredit.ShowDialog();
		}
		void Ect_edit_butClick(object sender, EventArgs e)
		{
			Form ectedit = new ECT_editor();
			ectedit.ShowDialog();
		}
		void Export_ect_butClick(object sender, EventArgs e)
		{
			/*int check = sav3file.has_ME3();
			if(check == 0)
				MessageBox.Show("Save file does not contain Mystery Event Data.");
			else if(check == 2)
				MessageBox.Show("Save file does contain Mystery Event Data, but the script has already been erased from savedata.");
			
			if (check != 0)*/
				FileIO.save_data(sav3file.get_ECT(), ectfilter);
		}
		void Inject_ect_butClick(object sender, EventArgs e)
		{
			//if (sav3file.has_mystery_event == true || sav3file.game == 1)
			//{
				if (sav3file.game == 1)
					MessageBox.Show("非日版绿宝石里已移除神秘事件。\n\t您仍可以自行承担风险继续配信数据。");
				string path = null;
				int filesize = FileIO.load_file(ref ectfile, ref path, ectfilter);
				if( filesize == ECT.SIZE_ECT )
				{				
					sav3file.set_ECT(ectfile);
					sav3file.update_section_chk(0);
					MessageBox.Show("e卡训练家配信完成。");
					FileIO.save_data(sav3file.Data, savfilter);
					
				}else if (filesize == -1){
					;
				}else{
					MessageBox.Show("无效文件大小。");
				}
			//}else
			//{
			//	MessageBox.Show("Save file does not have Mystery Event enabled.");
			//}
		}
		void MainScreenDragEnter(object sender, DragEventArgs e)
		{
			e.Effect = DragDropEffects.All;
		}
		void MainScreenDragDrop(object sender, DragEventArgs e)
		{
			string[] files = (string[])e.Data.GetData(DataFormats.FileDrop, false);
			Load_save(files[0]);
		}
		void Game_boxSelectedIndexChanged(object sender, EventArgs e)
		{
			sav3file.game = game_box.SelectedIndex;
			update_button_state();
			sav3file.updateOffsets();
		}
		void Language_boxSelectedIndexChanged(object sender, EventArgs e)
		{
			sav3file.language = language_box.SelectedIndex+1;
			
			if(sav3file.language == 1)
				sav3file.isjap = true;
			else
				sav3file.isjap = false;
			
			if(sav3file.isjap)
				region_lab.Text = "日版";
			else
				region_lab.Text = "美/欧版";
			
			update_button_state();			
			sav3file.updateOffsets();
		}
		void ExportOldSaveToolStripMenuItemClick(object sender, EventArgs e)
		{
			FileIO.save_data(sav3file.getSortedSave(1), savfilter);
		}
		void ToolStripMenuItem1Click(object sender, EventArgs e)
		{
			FileIO.save_data(sav3file.getSortedSave(0), savfilter);
		}
		void ClearEggEventFlagToolStripMenuItemClick(object sender, EventArgs e)
		{
			sav3file.clear_EggEvent_Flag();
			MessageBox.Show("事件旗标“蛋事件”已移除。");
			FileIO.save_data(sav3file.Data, savfilter);
			clearEggEventFlagToolStripMenuItem.Enabled = sav3file.has_EggEvent_Flag();
		}
		void EnableEnigmaBerryFlagToolStripMenuItemClick(object sender, EventArgs e)
		{

		}
		void Export_eberryClick(object sender, EventArgs e)
		{
			if(sav3file.has_berry())
			{
				FileIO.save_data(sav3file.get_ECB(), berryfilter);
			}else
			{
				MessageBox.Show("此存档文件没有树果。");
			}

		}
		void Inject_eberryClick(object sender, EventArgs e)
		{
			if (sav3file.game == 0)
			{
				string path = null;
				int filesize = FileIO.load_file(ref berryfile, ref path, berryfilter);
				if( filesize == SAV3.BERRY_SIZE)
				{				
					sav3file.set_ECB(berryfile);
					sav3file.set_Enigma_Flag();
					sav3file.update_section_chk(4);
					MessageBox.Show("谜芝果配信完成。");
					FileIO.save_data(sav3file.Data, savfilter);
					
				}else if (filesize == -1){
					;
				}else{
					MessageBox.Show("无效文件大小。");
				}
			}

		}
		void Ecb_edit_butClick(object sender, EventArgs e)
		{
			Form ecbedit = new ECB_editor();
			ecbedit.ShowDialog();
		}
		void AboutToolStripMenuItem1Click(object sender, EventArgs e)
		{
			MessageBox.Show("Mystery Gift Tool 0.1f by Sabresite（汉化者：卧看微尘/Wokann） \n(" + version()+ ")\n\n非常感谢suloku、ajxpkm、Real.96、BlackShark、lostaddict、Háčky、每一位贡献者以及更多参与神秘事件研究的人！\n\n您可能会对projectpokemon.org 上的研究线程感兴趣。\n\n如果您想贡献任何缺失的官方配信活动，请在 projectpokemon 的论坛或 sabresite@projectpokemon.org 联系 Sabresite、suloku 或 ajxpkm。");
		}
		void Tvswarm_butClick(object sender, EventArgs e)
		{
			Form tvswarm = new TV_editor(sav3file);
			tvswarm.ShowDialog();
		}
		void Events_distro_butClick(object sender, EventArgs e)
		{
			Form distro = new EventTool();
			distro.ShowDialog();
		}
	}
}
