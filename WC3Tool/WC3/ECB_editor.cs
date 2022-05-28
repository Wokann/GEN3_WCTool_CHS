/*
 * Created by SharpDevelop.
 * User: suloku
 * Date: 09/05/2016
 * Time: 0:59
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Windows.Forms;

namespace WC3Tool
{
	/// <summary>
	/// Description of ECB_editor.
	/// </summary>
	public partial class ECB_editor : Form
	{
		public ECB_editor()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			hap200.Minimum = -127;
			hap100.Minimum = -127;
			happ0.Minimum = -127;
			tr6_val.Minimum = 0;
			tr6_val.Maximum = 255;
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		public string berryfilter = "e卡树果文件|*.ecb|所有文件(*.*)|*.*";
		public string berry_sp_filter = "All Files (*.*)|*.*";
		public byte[] ecbbuffer;
		public byte[] spritebuf;
		public byte[] paletebuf;
		public static ECB ecbfile;
		
		void Load_ECB(string path)
		{
			int filesize = FileIO.load_file(ref ecbbuffer, ref path, berryfilter);
			if( filesize == ECB.SIZE_ECB )
			{				
				ecb_path.Text = path;
				ecbfile = new ECB(ecbbuffer);
				
				update_ecbData();
				
				save_ecb_but.Enabled = true;
				palette_export_but.Enabled = true;
				palette_import_but.Enabled = true;
				sprite_export_but.Enabled = true;
				sprite_import_but.Enabled = true;
				
			}else{
				MessageBox.Show("无效文件大小。");
			}
		}
		
		void Load_ecb_butClick(object sender, EventArgs e)
		{
			Load_ECB(null);
		}
		void Save_ecb_butClick(object sender, EventArgs e)
		{
			set_ecbData();
			ecbfile.fix_berry_checksum();
			//if (ecbfile.Edited)
				FileIO.save_data(ecbfile.Data, berryfilter);
			//else MessageBox.Show("存档未被编辑。");
		}
		void update_ecbData()
		{
			name.Text = ecbfile.NAME;
			firm_box.SelectedIndex = ecbfile.FIRMNESS-1;
			size.Value = ecbfile.SIZE;
			yield_max.Value = ecbfile.YIELD_MAX;
			yield_min.Value = ecbfile.YIELD_MIN;
			growth.Value = ecbfile.GROWTH;
			spicy.Value = ecbfile.SPICY;
			dry.Value = ecbfile.DRY;
			sweet.Value = ecbfile.SWEET;
			bitter.Value = ecbfile.BITTER;
			sour.Value = ecbfile.SOUR;
			smooth.Value = ecbfile.SMOOTH;
			
			desc1.Text = ecbfile.DESC_1;
			desc2.Text = ecbfile.DESC_2;
			
			held.Value = ecbfile.HITEM;
			
			heal_burn.Checked = ecbfile.TR_3_clearBurn;
			heal_confu.Checked = ecbfile.TR_3_clearConf;
			heal_ice.Checked = ecbfile.TR_3_clearIce;
			heal_inf.Checked = ecbfile.TR_0_healinfatuation;
			heal_para.Checked = ecbfile.TR_3_clearPar;
			heal_poison.Checked = ecbfile.TR_3_clearPoison;
			heal_sleep.Checked = ecbfile.TR_3_clearSleep;
			
			guard.Checked = ecbfile.TR_3_guardspec;
			lvlup.Checked = ecbfile.TR_3_lvlUP;
			
			firstpoke.Checked = ecbfile.TR_0_firstpkm;
			
			direhit.Value = ecbfile.TR_0_direhit;
			atkup.Value = ecbfile.TR_0_attackUP;
			defup.Value = ecbfile.TR_1_defUP;
			speedup.Value = ecbfile.TR_1_speedUP;
			spatkup.Value = ecbfile.TR_2_espUP;
			accurup.Value = ecbfile.TR_2_accUP;
			
			ev_hp.Checked = ecbfile.TR_4_hpEVUP;
			ev_atk.Checked = ecbfile.TR_4_atkEVUP;
			ev_def.Checked = ecbfile.TR_5_defEVUP;
			ev_speed.Checked = ecbfile.TR_5_spEVUP;
			ev_speatk.Checked = ecbfile.TR_5_spatkEVUP;
			ev_spedef.Checked = ecbfile.TR_5_spdefEVUP;
			
			if (ecbfile.HPRecovery != 0)
				tr6_val.Value = ecbfile.HPRecovery;
			else if (ecbfile.PPRecovery != 0)
				tr6_val.Value = ecbfile.PPRecovery;
			else if (ecbfile.EVchange != 0)
				tr6_val.Value = ecbfile.EVchange;
			//else if (ecbfile.HPRecovery == 0 && ecbfile.EVchange == 0 && ecbfile.PPRecovery == 0)
			//	tr6_val.Enabled = false;
			
			heal_hp.Checked = ecbfile.TR_4_healHP;
			heal_pp.Checked = ecbfile.TR_4_healPP;
			selectedatk.Checked = ecbfile.TR_4_onlyatack;
			maxppUP.Checked = ecbfile.TR_4_maxPPUP;
			revive.Checked = ecbfile.TR_4_revive;
			stone.Checked = ecbfile.TR_4_stone;
			ppup.Checked = ecbfile.TR_5_ppMax;
			
			happy200.Checked = ecbfile.TR_5_happy200;
			happy100.Checked = ecbfile.TR_5_happy100;
			happy0.Checked = ecbfile.TR_5_happy0;
			
			if (happy200.Checked)
				hap200.Value = ecbfile.Happy200;
			else
				hap200.Value = 0;
			if (happy100.Checked)
				hap100.Value = ecbfile.Happy100;
			else
				hap100.Value = 0;
			if (happy0.Checked)
				happ0.Value = ecbfile.Happy0;
			else
				happ0.Value = 0;			
			
		}
		
		void set_ecbData()
		{
			ecbfile.NAME = name.Text;
			ecbfile.FIRMNESS = (byte)(firm_box.SelectedIndex+1);
			ecbfile.SIZE = (UInt16) size.Value;
			ecbfile.YIELD_MAX = (byte)yield_max.Value;
			ecbfile.YIELD_MIN = (byte)yield_min.Value;
			ecbfile.GROWTH = (byte)growth.Value;
			ecbfile.SPICY = (byte)spicy.Value;
			ecbfile.DRY = (byte)dry.Value;
			ecbfile.SWEET = (byte)sweet.Value;
			ecbfile.BITTER = (byte)bitter.Value;
			ecbfile.SOUR = (byte)sour.Value;
			ecbfile.SMOOTH = (byte)smooth.Value;
			
			ecbfile.DESC_1 = desc1.Text;
			ecbfile.DESC_2 = desc2.Text;
			
			ecbfile.HITEM = (byte) held.Value;
			
			ecbfile.TR_3_clearBurn = heal_burn.Checked;
			ecbfile.TR_3_clearConf = heal_confu.Checked ;
			ecbfile.TR_3_clearIce = heal_ice.Checked;
			ecbfile.TR_0_healinfatuation = heal_inf.Checked;
			ecbfile.TR_3_clearPar = heal_para.Checked;
			ecbfile.TR_3_clearPoison = heal_poison.Checked;
			ecbfile.TR_3_clearSleep = heal_sleep.Checked;
			
			ecbfile.TR_3_guardspec = guard.Checked;
			ecbfile.TR_3_lvlUP = lvlup.Checked;
			
			ecbfile.TR_0_firstpkm = firstpoke.Checked;
			
			ecbfile.TR_0_direhit = (int)direhit.Value;
			ecbfile.TR_0_attackUP = (int)atkup.Value;
			ecbfile.TR_1_defUP = (int)defup.Value;
			ecbfile.TR_1_speedUP = (int)speedup.Value;
			ecbfile.TR_2_espUP = (int)spatkup.Value;
			ecbfile.TR_2_accUP = (int)accurup.Value;
			
			ecbfile.TR_4_hpEVUP = ev_hp.Checked;
			ecbfile.TR_4_atkEVUP = ev_atk.Checked;
			ecbfile.TR_5_defEVUP = ev_def.Checked;
			ecbfile.TR_5_spEVUP = ev_speed.Checked;
			ecbfile.TR_5_spatkEVUP = ev_speatk.Checked;
			ecbfile.TR_5_spdefEVUP = ev_spedef.Checked;
			
			ecbfile.TR_4_healHP = heal_hp.Checked;
			ecbfile.TR_4_healPP = heal_pp.Checked;
			ecbfile.TR_4_onlyatack = selectedatk.Checked;
			ecbfile.TR_4_maxPPUP = maxppUP.Checked;
			ecbfile.TR_4_revive = revive.Checked;
			ecbfile.TR_4_stone = stone.Checked;
			ecbfile.TR_5_ppMax = ppup.Checked;
			
			//Only put the first value found
			if (heal_hp.Checked)
				ecbfile.HPRecovery = (byte)tr6_val.Value;
			else if (heal_pp.Checked)
				ecbfile.PPRecovery = (byte)tr6_val.Value;
			else if (ev_hp.Checked || ev_atk.Checked || ev_def.Checked || ev_speed.Checked || ev_speatk.Checked || ev_spedef.Checked)
				ecbfile.EVchange = (sbyte)tr6_val.Value;			
			
			ecbfile.TR_5_happy200 = happy200.Checked;
			ecbfile.TR_5_happy100 = happy100.Checked;
			ecbfile.TR_5_happy0 = happy0.Checked;
			
			ecbfile.Happy200 = (sbyte)hap200.Value;
			ecbfile.Happy100 = (sbyte)hap100.Value;
			ecbfile.Happy0 = (sbyte)happ0.Value;	
		}
		void Held_helpClick(object sender, EventArgs e)
		{
			MessageBox.Show("已知值：\n00：无效果\n04：治愈中毒（无青果）\n05：治愈灼伤（日版菩达果）\n06：治愈冰冻（瓜南果）\n08：治愈混乱（日版辛子果）\n23：被下降的能力变化归零（日版葱首果）\n28：治愈着迷状态（子茄果）");
		}
		void Sprite_export_butClick(object sender, EventArgs e)
		{
			FileIO.save_data(ecbfile.get_full_sprite(), berry_sp_filter);
		}
		void Sprite_import_butClick(object sender, EventArgs e)
		{
				string path = null;
				int filesize = FileIO.load_file(ref spritebuf, ref path, berry_sp_filter);
				if( filesize == ECB.SIZE_SPRITE+ECB.SIZE_PALETTE)
				{				
					ecbfile.set_full_sprite(spritebuf);
					MessageBox.Show("树果sprite注入完成。");
					
				}else if (filesize == -1){
					;
				}else{
					MessageBox.Show("无效文件大小。");
				}
		}
		void Palette_import_butClick(object sender, EventArgs e)
		{
				string path = null;
				int filesize = FileIO.load_file(ref paletebuf, ref path, berry_sp_filter);
				if( filesize == ECB.SIZE_PALETTE)
				{				
					ecbfile.set_palette(paletebuf);
					MessageBox.Show("树果调色板注入完成。");
					
				}else if (filesize == -1){
					;
				}else{
					MessageBox.Show("无效文件大小。");
				}
		}
		void Palette_export_butClick(object sender, EventArgs e)
		{
			FileIO.save_data(ecbfile.get_palette(), berry_sp_filter);
		}
		void Sprite_helpClick(object sender, EventArgs e)
		{
			MessageBox.Show("编辑树果sprite你可以用\"Nameless Sprite Editor (NSE) 2.1 beta\".\n将树果sprite保存为\".gba\"文件并再NSE中用\"加载ROM\"选项打开：然后点击导航并输入这个值：\n\t图像偏移：20\n\t调色盘偏移：0\n\t宽度：6\n\t高度：6\n\n再点击打开并编辑sprite。保存则使用 file->save 或 control+S (调色盘也可被编辑，使用调色盘编辑器的保存按钮保存）。 \n\n若想导入树果sprite，你可以选择导入修改后的树果\".gba\"文件。");
		}
		void Jap_encodingCheckedChanged(object sender, EventArgs e)
		{
			ecbfile.isjap = jap_encoding.Checked;
			name.Text = ecbfile.NAME;
			desc1.Text = ecbfile.DESC_1;
			desc2.Text = ecbfile.DESC_2;
		}
		void PphelpClick(object sender, EventArgs e)
		{
			MessageBox.Show("治愈HP与回复PP为互斥选项，你不能同时回复PP和HP。若两者同时选中，则HP优先度更高。");
		}
		void Modifier_helpClick(object sender, EventArgs e)
		{
			MessageBox.Show("PP恢复类道具最大为127。\n体力恢复类，255表示最大生命值，254表示最大生命值一般，253为神奇糖果使用（仅在升级时提升）.\n对于基础点数类，0-127增加基础点数, 128-255减少基础点数（128为-1, 255为-127）。");
		}
		void NoteClick(object sender, EventArgs e)
		{
			MessageBox.Show("请记住，旗标之间不存在兼容。例如你不能制作一个能回复HP的树果，同时它还能提升宝可梦等级，并可以在对战中使用，因为升级类道具只能从包包里使用。");
		}
		
		void ECB_editorDragEnter(object sender, DragEventArgs e)
		{
			e.Effect = DragDropEffects.All;
		}
		void ECB_editorDragDrop(object sender, DragEventArgs e)
		{
			string[] files = (string[])e.Data.GetData(DataFormats.FileDrop, false);
			Load_ECB(files[0]);
		}	
	}
}
