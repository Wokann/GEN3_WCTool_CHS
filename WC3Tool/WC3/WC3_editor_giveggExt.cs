/*
 * Created by SharpDevelop.
 * User: suloku
 * Date: 07/05/2016
 * Time: 21:27
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Linq;
using System.Windows.Forms;
using System.Reflection;
using System.Resources;

namespace WC3Tool
{
	/// <summary>
	/// Description of WC3_editor_givegg.
	/// </summary>
	public partial class WC3_editor_giveggExt : Form
	{
		public WC3_editor_giveggExt()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			game_box.SelectedIndex = 0;
			lang_box.SelectedIndex = 1;
			species_box.SelectedIndex = 172;
			move_box.SelectedIndex = 0x39;
			move2.SelectedIndex = 0x39;
			move3.SelectedIndex = 0x39;
			move4.SelectedIndex = 0x39;
/*
ResourceManager resources = new ResourceManager("Namespace.ResourceFile", Assembly.GetExecutingAssembly());
byte[] fileData = (byte[])ResourceManager.GetObject("Test.dat");
Bitmap bitmap = (Bitmap)ResourceManager.GetObject("Image");
*/
			//byte[] fileData = (byte[]) EggScripts.GetObject("ROM"+game+"GiveEgg"+lang);
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		void Save_butClick(object sender, EventArgs e)
		{
			string game;
			if (game_box.SelectedIndex == 1)
				game = "FR";
			else
				game = "E";
			
			string lang = "Eng";
			switch (lang_box.SelectedIndex)
			{
				case 0:
					lang = "Jap";
					break;
				case 1:
					lang = "Eng";
					break;
				case 2:
					lang = "Fre";
					break;
				case 3:
					lang = "Ita";
					break;
				case 4:
					lang = "Deu";
					break;
				case 5:
					lang = "Esp";
					break;
			}
			//MessageBox.Show("ROM_"+game+"_GiveEgg_"+lang);
			ResourceManager EggScripts = new ResourceManager("WC3Tool.WC3.GiveEggOrg", Assembly.GetExecutingAssembly());
			byte[] egg_script;
			
			if (killscript.Checked)
				egg_script =(byte[]) EggScripts.GetObject("ROM_"+game+"_GiveEgg_"+lang+"_4moves_kill");
			else
				egg_script = (byte[]) EggScripts.GetObject("ROM_"+game+"_GiveEgg_"+lang+"_4moves");
			
			UInt16 move;
			UInt16 move_2;
			UInt16 move_3;
			UInt16 move_4;
			
			int offset = 4;//Embedded scripts have a 4 byte padding
			if (killscript.Checked)
			{
				egg_script[0x5+offset] = 0x00; //Remove jumpram command, I should technically update the embedded script files instead of doing this...
				offset -= 0xF;//Killscript version is 0xF bytes shorter
			}
			move = (UInt16)move_box.SelectedIndex;
			BitConverter.GetBytes(move).ToArray().CopyTo(egg_script, 0xB1+offset);
			BitConverter.GetBytes(move).ToArray().CopyTo(egg_script, 0xC7+offset);
			BitConverter.GetBytes(move).ToArray().CopyTo(egg_script, 0xDD+offset);
			BitConverter.GetBytes(move).ToArray().CopyTo(egg_script, 0xF3+offset);
			BitConverter.GetBytes(move).ToArray().CopyTo(egg_script, 0x109+offset);
			
			offset+=5;
			move_2 = (UInt16)move2.SelectedIndex;
			BitConverter.GetBytes(move_2).ToArray().CopyTo(egg_script, 0xB1+offset);
			BitConverter.GetBytes(move_2).ToArray().CopyTo(egg_script, 0xC7+offset);
			BitConverter.GetBytes(move_2).ToArray().CopyTo(egg_script, 0xDD+offset);
			BitConverter.GetBytes(move_2).ToArray().CopyTo(egg_script, 0xF3+offset);
			BitConverter.GetBytes(move_2).ToArray().CopyTo(egg_script, 0x109+offset);
			
			offset+=5;
			move_3 = (UInt16)move3.SelectedIndex;
			BitConverter.GetBytes(move_3).ToArray().CopyTo(egg_script, 0xB1+offset);
			BitConverter.GetBytes(move_3).ToArray().CopyTo(egg_script, 0xC7+offset);
			BitConverter.GetBytes(move_3).ToArray().CopyTo(egg_script, 0xDD+offset);
			BitConverter.GetBytes(move_3).ToArray().CopyTo(egg_script, 0xF3+offset);
			BitConverter.GetBytes(move_3).ToArray().CopyTo(egg_script, 0x109+offset);
			
			offset+=5;
			move_4 = (UInt16)move4.SelectedIndex;
			BitConverter.GetBytes(move_4).ToArray().CopyTo(egg_script, 0xB1+offset);
			BitConverter.GetBytes(move_4).ToArray().CopyTo(egg_script, 0xC7+offset);
			BitConverter.GetBytes(move_4).ToArray().CopyTo(egg_script, 0xDD+offset);
			BitConverter.GetBytes(move_4).ToArray().CopyTo(egg_script, 0xF3+offset);
			BitConverter.GetBytes(move_4).ToArray().CopyTo(egg_script, 0x109+offset);

			UInt16 species;
			species = (UInt16)species_box.SelectedIndex;
			if (killscript.Checked)
				BitConverter.GetBytes(species).ToArray().CopyTo(egg_script, 0x5D+4);
			else
				BitConverter.GetBytes(species).ToArray().CopyTo(egg_script, 0x6C+4);
			
			//Because script files embedded have a 4 byte padding for XSE editing...and I'm lazy to strip those 4 bytes
			WC3_editor.wc3file.set_script(egg_script.Skip(4).Take(996).ToArray());
			WC3_editor.script_injected = true;
			
			Close();
		}
		void Cancel_butClick(object sender, EventArgs e)
		{
			Close();
		}
		void Script_helpClick(object sender, EventArgs e)
		{
			MessageBox.Show("使用rom事件旗标：该脚本将使用在ROM中找到的用于标记已接收礼物蛋的事件旗标。神秘卡片将被发送，接收者将能够收到一个蛋（如果存档内的事件旗标未被标记）。\n\n杀死脚本：存档内不会设置旗标，所以最终只会收到一个蛋。脚本会被从存档内删除，所以分享神秘卡片不会让接收者获得蛋。");
		}
	}
}
