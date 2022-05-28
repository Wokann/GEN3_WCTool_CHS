/*
 * Created by SharpDevelop.
 * User: suloku
 * Date: 02/05/2016
 * Time: 23:40
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Windows.Forms;

namespace WC3Tool
{
	/// <summary>
	/// Description of ME3_editor.
	/// </summary>
	public partial class ME3_editor : Form
	{
		public ME3_editor()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		public string me3filter = "神秘事件文件|*.me3|所有文件(*.*)|*.*";
		public string scriptfilter = "脚本文件|*.script|所有文件(*.*)|*.*";
		public string xsescriptfilter = "填充XSE脚本文件|*.gba";
		public byte[] me3buffer;
		public byte[] me3script_new;
		public static ME3 me3file;
		
		//private int me3size;
		
		void get_me3data()
		{
			amountbox.Value = me3file.get_item_amount();
			counterbox.Value = me3file.get_item_counter();
			itembox.SelectedIndex = me3file.get_item();
			
			if(me3file.isemerald == 0)//These items aren't in emerald
			{
				if (itembox.SelectedIndex > 348)
					itembox.SelectedIndex = 348;
			}else{
				if (itembox.SelectedIndex > 376)
					itembox.SelectedIndex = 376;
			}
			
			map_bank.Value =  me3file.MAP_BANK;
			map_num.Value = me3file.MAP_MAP;
			map_npc.Value = me3file.MAP_PERSON;
			
		}
		
		void set_me3data()
		{
			me3file.set_item( (UInt16)itembox.SelectedIndex);
			me3file.set_item_amount( (byte) amountbox.Value);
			me3file.set_item_counter( (byte) counterbox.Value);
			
			me3file.MAP_BANK = (byte)map_bank.Value;
			me3file.MAP_MAP = (byte)map_num.Value;
			me3file.MAP_PERSON = (byte)map_npc.Value;
			
			if (radio_E.Checked)
				me3file.isemerald = 1;
			else if (radio_RS.Checked)
				me3file.isemerald = 0;
		}
		
		void Load_me3(string path)
		{
			int filesize = FileIO.load_file(ref me3buffer, ref path, me3filter);
			if( filesize == SAV3.ME3_SIZE_E || filesize == SAV3.ME3_SIZE_RS )
			{	
				
				radio_RS.Checked = false;
				radio_E.Checked = false;
				
				me3_path.Text = path;
				me3file = new ME3(me3buffer, filesize);
				
				switch (me3file.isemerald)
				{
					case 0:
						radio_RS.Checked = true;
						break;
					case 1:
						radio_E.Checked = true;
						break;
				}
						
				get_me3data();
				
				save_me3_but.Enabled = true;
				removescript_but.Enabled = true;
				export_script_but.Enabled = true;
				import_script_but.Enabled = true;
				custom_script.Checked = false;
				script_check.Checked = true;
				
			}else{
				MessageBox.Show("无效文件大小。");
			}
		}
		
		void Load_me3_butClick(object sender, EventArgs e)
		{
			Load_me3(null);

		}
		void ItemboxSelectedIndexChanged(object sender, EventArgs e)
		{
			if(me3file.isemerald == 0)//These items aren't in RS
			{
				if (itembox.SelectedIndex > 348){
					itembox.SelectedIndex = 348;
					MessageBox.Show("选择的道具在红宝石/蓝宝石里无效。");
				}
			}else{
				if (itembox.SelectedIndex > 376)
					itembox.SelectedIndex = 376;
			}
		}
		void Save_me3_butClick(object sender, EventArgs e)
		{
			set_me3data();
			me3file.fix_me_script_checksum();
			me3file.fix_me_item_checksum();

			if (me3file.Edited)
				FileIO.save_data(me3file.Data, me3filter);
			else MessageBox.Show("文件未被编辑。");
		}
		void Export_script_butClick(object sender, EventArgs e)
		{
			FileIO.save_data(me3file.get_script(), scriptfilter);
		}
		void Import_script_butClick(object sender, EventArgs e)
		{
			string path = null;
			int filesize = FileIO.load_file(ref me3script_new, ref path, scriptfilter);
			if( filesize <= 996 )
			{				
				me3file.set_script(me3script_new);
				custom_script.Checked = true;
				script_check.Checked = me3file.has_script();
				MessageBox.Show("自制脚本已注入。");
				
			}else{
				MessageBox.Show("无效文件大小。");
			}
		}
		void CounterboxValueChanged(object sender, EventArgs e)
		{
			//Not sure about this anymore
			/*if (counterbox.Value > amountbox.Value)
			{
				MessageBox.Show("计数器不能大于总数。");
				counterbox.Value = amountbox.Value;
			}*/
		}
		void Removescript_butClick(object sender, EventArgs e)
		{
			me3file.removeScript();
			script_check.Checked = me3file.has_script();
		}
		void Help_npcClick(object sender, EventArgs e)
		{
			MessageBox.Show("这些数值用于关联游戏中NPC的脚本。\n\n你可以使用Advance Map去确定游戏里所有NPC的对应数值。\n\n在绿宝石，橙华道馆父亲的数值为 Bank 08, Map 01, NPC 01.");
		}
		void Counter_helpClick(object sender, EventArgs e)
		{
			MessageBox.Show("每次混合记录时，此数字都会减1，即使因其他人已经拥有该道具而没有转移道具也是如此。");
		}
		void Amount_helpClick(object sender, EventArgs e)
		{
			MessageBox.Show("是否始终为1？ 改变它没有明显的效果。");
		}
		void Item_helpClick(object sender, EventArgs e)
		{
			MessageBox.Show("道具仅在接收方未拥有此道具时才可通过混合记录传输。");
		}
		void Xse_exportClick(object sender, EventArgs e)
		{
			FileIO.save_data(me3file.get_script_XSE(), xsescriptfilter);
		}
		void Xse_importClick(object sender, EventArgs e)
		{
			string path = null;
			int filesize = FileIO.load_file(ref me3script_new, ref path, xsescriptfilter);
			if( filesize <= 1000 )
			{				
				me3file.set_script_XSE(me3script_new);
				custom_script.Checked = true;
				MessageBox.Show("自制脚本已注入。");
				
			}else{
				MessageBox.Show("无效文件大小");
			}
		}
		void Xse_helpClick(object sender, EventArgs e)
		{
			MessageBox.Show("XSE导出：使用与脚本的基地址和*.gba 扩展名相对应的填充导出脚本。 您可以在 XSE 中直接加载（和编辑）脚本，使用导出按钮时将显示脚本偏移量。\nXSE 导入：使用 XSE 编辑（或未编辑）后导入此工具生成的 *.gba 脚本（导入其他任何内容将无法正常工作）\n\n这些选项只是为了方便，这些脚本绝不是 gba rom，它只是为了能在 XSE 中更方便地进行编辑。");
		}
		
		void ME3_editorDragEnter(object sender, DragEventArgs e)
		{
			e.Effect = DragDropEffects.All;
		}
		void ME3_editorDragDrop(object sender, DragEventArgs e)
		{
			string[] files = (string[])e.Data.GetData(DataFormats.FileDrop, false);
			Load_me3(files[0]);
		}
	}
}
