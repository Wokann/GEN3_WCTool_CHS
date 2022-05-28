/*
 * Created by SharpDevelop.
 * User: suloku
 * Date: 03/05/2016
 * Time: 20:54
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace WC3Tool
{
	partial class ECT_editor
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.TextBox ect_path;
		private System.Windows.Forms.Button save_ect_but;
		private System.Windows.Forms.Button load_ect_but;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.ComboBox tower_appearance;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.ComboBox trainer_class;
		private System.Windows.Forms.Button helpclass_but;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.NumericUpDown tower_floor;
		private System.Windows.Forms.ComboBox textA1;
		private System.Windows.Forms.ComboBox textA2;
		private System.Windows.Forms.ComboBox textA3;
		private System.Windows.Forms.ComboBox textA4;
		private System.Windows.Forms.ComboBox textA5;
		private System.Windows.Forms.ComboBox textA6;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.ComboBox textB6;
		private System.Windows.Forms.ComboBox textB5;
		private System.Windows.Forms.ComboBox textB4;
		private System.Windows.Forms.ComboBox textB3;
		private System.Windows.Forms.ComboBox textB2;
		private System.Windows.Forms.ComboBox textB1;
		private System.Windows.Forms.GroupBox groupBox3;
		private System.Windows.Forms.ComboBox textC6;
		private System.Windows.Forms.ComboBox textC5;
		private System.Windows.Forms.ComboBox textC4;
		private System.Windows.Forms.ComboBox textC3;
		private System.Windows.Forms.ComboBox textC2;
		private System.Windows.Forms.ComboBox textC1;
		private System.Windows.Forms.ComboBox pkm3;
		private System.Windows.Forms.ComboBox pkm2;
		private System.Windows.Forms.ComboBox pkm1;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Button pkm3_edit_but;
		private System.Windows.Forms.Button pkm2_edit_but;
		private System.Windows.Forms.Button pkm1_edit_but;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.NumericUpDown SID;
		private System.Windows.Forms.NumericUpDown TID;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox name;
		private System.Windows.Forms.CheckBox jap_check;
		private System.Windows.Forms.RadioButton radio_rs;
		private System.Windows.Forms.RadioButton radio_e;
		private System.Windows.Forms.RadioButton radio_FRLG;
		private System.Windows.Forms.GroupBox groupBox4;
		private System.Windows.Forms.NumericUpDown tower_appearance_num;
		private System.Windows.Forms.NumericUpDown trainer_class_value;
		private System.Windows.Forms.GroupBox groupBox5;
		private System.Windows.Forms.RadioButton jap;
		private System.Windows.Forms.RadioButton esp;
		private System.Windows.Forms.RadioButton ita;
		private System.Windows.Forms.RadioButton ger;
		private System.Windows.Forms.RadioButton fre;
		private System.Windows.Forms.RadioButton eng;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
            this.ect_path = new System.Windows.Forms.TextBox();
            this.save_ect_but = new System.Windows.Forms.Button();
            this.load_ect_but = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tower_appearance = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.trainer_class = new System.Windows.Forms.ComboBox();
            this.helpclass_but = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.tower_floor = new System.Windows.Forms.NumericUpDown();
            this.textA1 = new System.Windows.Forms.ComboBox();
            this.textA2 = new System.Windows.Forms.ComboBox();
            this.textA3 = new System.Windows.Forms.ComboBox();
            this.textA4 = new System.Windows.Forms.ComboBox();
            this.textA5 = new System.Windows.Forms.ComboBox();
            this.textA6 = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.textB6 = new System.Windows.Forms.ComboBox();
            this.textB5 = new System.Windows.Forms.ComboBox();
            this.textB4 = new System.Windows.Forms.ComboBox();
            this.textB3 = new System.Windows.Forms.ComboBox();
            this.textB2 = new System.Windows.Forms.ComboBox();
            this.textB1 = new System.Windows.Forms.ComboBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.textC6 = new System.Windows.Forms.ComboBox();
            this.textC5 = new System.Windows.Forms.ComboBox();
            this.textC4 = new System.Windows.Forms.ComboBox();
            this.textC3 = new System.Windows.Forms.ComboBox();
            this.textC2 = new System.Windows.Forms.ComboBox();
            this.textC1 = new System.Windows.Forms.ComboBox();
            this.pkm3 = new System.Windows.Forms.ComboBox();
            this.pkm2 = new System.Windows.Forms.ComboBox();
            this.pkm1 = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.pkm3_edit_but = new System.Windows.Forms.Button();
            this.pkm2_edit_but = new System.Windows.Forms.Button();
            this.pkm1_edit_but = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.SID = new System.Windows.Forms.NumericUpDown();
            this.TID = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.name = new System.Windows.Forms.TextBox();
            this.jap_check = new System.Windows.Forms.CheckBox();
            this.radio_rs = new System.Windows.Forms.RadioButton();
            this.radio_e = new System.Windows.Forms.RadioButton();
            this.radio_FRLG = new System.Windows.Forms.RadioButton();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.tower_appearance_num = new System.Windows.Forms.NumericUpDown();
            this.trainer_class_value = new System.Windows.Forms.NumericUpDown();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.jap = new System.Windows.Forms.RadioButton();
            this.esp = new System.Windows.Forms.RadioButton();
            this.ita = new System.Windows.Forms.RadioButton();
            this.ger = new System.Windows.Forms.RadioButton();
            this.fre = new System.Windows.Forms.RadioButton();
            this.eng = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.tower_floor)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TID)).BeginInit();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tower_appearance_num)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trainer_class_value)).BeginInit();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // ect_path
            // 
            this.ect_path.Location = new System.Drawing.Point(180, 13);
            this.ect_path.Name = "ect_path";
            this.ect_path.ReadOnly = true;
            this.ect_path.Size = new System.Drawing.Size(641, 21);
            this.ect_path.TabIndex = 5;
            // 
            // save_ect_but
            // 
            this.save_ect_but.Enabled = false;
            this.save_ect_but.Location = new System.Drawing.Point(89, 1);
            this.save_ect_but.Name = "save_ect_but";
            this.save_ect_but.Size = new System.Drawing.Size(75, 40);
            this.save_ect_but.TabIndex = 4;
            this.save_ect_but.Text = "保存e卡训练家文件";
            this.save_ect_but.UseVisualStyleBackColor = true;
            this.save_ect_but.Click += new System.EventHandler(this.Save_ect_butClick);
            // 
            // load_ect_but
            // 
            this.load_ect_but.Location = new System.Drawing.Point(8, 1);
            this.load_ect_but.Name = "load_ect_but";
            this.load_ect_but.Size = new System.Drawing.Size(75, 40);
            this.load_ect_but.TabIndex = 3;
            this.load_ect_but.Text = "读取e卡训练家文件";
            this.load_ect_but.UseVisualStyleBackColor = true;
            this.load_ect_but.Click += new System.EventHandler(this.Load_ect_butClick);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(14, 214);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "对战塔外观：";
            // 
            // tower_appearance
            // 
            this.tower_appearance.FormattingEnabled = true;
            this.tower_appearance.Items.AddRange(new object[] {
            "绿岭市秘密民居",
            "对战塔Lv50挑战",
            "对战塔Lv100挑战"});
            this.tower_appearance.Location = new System.Drawing.Point(145, 211);
            this.tower_appearance.Name = "tower_appearance";
            this.tower_appearance.Size = new System.Drawing.Size(191, 20);
            this.tower_appearance.TabIndex = 7;
            this.tower_appearance.Visible = false;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(14, 239);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 21);
            this.label2.TabIndex = 8;
            this.label2.Text = "训练家类型：";
            // 
            // trainer_class
            // 
            this.trainer_class.FormattingEnabled = true;
            this.trainer_class.Location = new System.Drawing.Point(145, 236);
            this.trainer_class.Name = "trainer_class";
            this.trainer_class.Size = new System.Drawing.Size(191, 20);
            this.trainer_class.TabIndex = 9;
            this.trainer_class.SelectedIndexChanged += new System.EventHandler(this.Trainer_classSelectedIndexChanged);
            // 
            // helpclass_but
            // 
            this.helpclass_but.Location = new System.Drawing.Point(342, 236);
            this.helpclass_but.Name = "helpclass_but";
            this.helpclass_but.Size = new System.Drawing.Size(22, 21);
            this.helpclass_but.TabIndex = 10;
            this.helpclass_but.Text = "?";
            this.helpclass_but.UseVisualStyleBackColor = true;
            this.helpclass_but.Click += new System.EventHandler(this.Helpclass_butClick);
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(14, 263);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 17);
            this.label3.TabIndex = 11;
            this.label3.Text = "对战塔层数：";
            // 
            // tower_floor
            // 
            this.tower_floor.Location = new System.Drawing.Point(145, 261);
            this.tower_floor.Name = "tower_floor";
            this.tower_floor.Size = new System.Drawing.Size(73, 21);
            this.tower_floor.TabIndex = 12;
            // 
            // textA1
            // 
            this.textA1.FormattingEnabled = true;
            this.textA1.Location = new System.Drawing.Point(27, 21);
            this.textA1.Name = "textA1";
            this.textA1.Size = new System.Drawing.Size(121, 20);
            this.textA1.TabIndex = 19;
            // 
            // textA2
            // 
            this.textA2.FormattingEnabled = true;
            this.textA2.Location = new System.Drawing.Point(154, 21);
            this.textA2.Name = "textA2";
            this.textA2.Size = new System.Drawing.Size(121, 20);
            this.textA2.TabIndex = 20;
            // 
            // textA3
            // 
            this.textA3.FormattingEnabled = true;
            this.textA3.Location = new System.Drawing.Point(281, 21);
            this.textA3.Name = "textA3";
            this.textA3.Size = new System.Drawing.Size(121, 20);
            this.textA3.TabIndex = 21;
            // 
            // textA4
            // 
            this.textA4.FormattingEnabled = true;
            this.textA4.Location = new System.Drawing.Point(27, 46);
            this.textA4.Name = "textA4";
            this.textA4.Size = new System.Drawing.Size(121, 20);
            this.textA4.TabIndex = 22;
            // 
            // textA5
            // 
            this.textA5.FormattingEnabled = true;
            this.textA5.Location = new System.Drawing.Point(154, 46);
            this.textA5.Name = "textA5";
            this.textA5.Size = new System.Drawing.Size(121, 20);
            this.textA5.TabIndex = 23;
            // 
            // textA6
            // 
            this.textA6.FormattingEnabled = true;
            this.textA6.Location = new System.Drawing.Point(281, 46);
            this.textA6.Name = "textA6";
            this.textA6.Size = new System.Drawing.Size(121, 20);
            this.textA6.TabIndex = 24;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textA6);
            this.groupBox1.Controls.Add(this.textA5);
            this.groupBox1.Controls.Add(this.textA4);
            this.groupBox1.Controls.Add(this.textA3);
            this.groupBox1.Controls.Add(this.textA2);
            this.groupBox1.Controls.Add(this.textA1);
            this.groupBox1.Location = new System.Drawing.Point(370, 39);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(415, 77);
            this.groupBox1.TabIndex = 25;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "战前文本：";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.textB6);
            this.groupBox2.Controls.Add(this.textB5);
            this.groupBox2.Controls.Add(this.textB4);
            this.groupBox2.Controls.Add(this.textB3);
            this.groupBox2.Controls.Add(this.textB2);
            this.groupBox2.Controls.Add(this.textB1);
            this.groupBox2.Location = new System.Drawing.Point(370, 121);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(415, 77);
            this.groupBox2.TabIndex = 26;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "胜利文本：";
            // 
            // textB6
            // 
            this.textB6.FormattingEnabled = true;
            this.textB6.Location = new System.Drawing.Point(281, 46);
            this.textB6.Name = "textB6";
            this.textB6.Size = new System.Drawing.Size(121, 20);
            this.textB6.TabIndex = 24;
            // 
            // textB5
            // 
            this.textB5.FormattingEnabled = true;
            this.textB5.Location = new System.Drawing.Point(154, 46);
            this.textB5.Name = "textB5";
            this.textB5.Size = new System.Drawing.Size(121, 20);
            this.textB5.TabIndex = 23;
            // 
            // textB4
            // 
            this.textB4.FormattingEnabled = true;
            this.textB4.Location = new System.Drawing.Point(27, 46);
            this.textB4.Name = "textB4";
            this.textB4.Size = new System.Drawing.Size(121, 20);
            this.textB4.TabIndex = 22;
            // 
            // textB3
            // 
            this.textB3.FormattingEnabled = true;
            this.textB3.Location = new System.Drawing.Point(281, 21);
            this.textB3.Name = "textB3";
            this.textB3.Size = new System.Drawing.Size(121, 20);
            this.textB3.TabIndex = 21;
            // 
            // textB2
            // 
            this.textB2.FormattingEnabled = true;
            this.textB2.Location = new System.Drawing.Point(154, 21);
            this.textB2.Name = "textB2";
            this.textB2.Size = new System.Drawing.Size(121, 20);
            this.textB2.TabIndex = 20;
            // 
            // textB1
            // 
            this.textB1.FormattingEnabled = true;
            this.textB1.Location = new System.Drawing.Point(27, 21);
            this.textB1.Name = "textB1";
            this.textB1.Size = new System.Drawing.Size(121, 20);
            this.textB1.TabIndex = 19;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.textC6);
            this.groupBox3.Controls.Add(this.textC5);
            this.groupBox3.Controls.Add(this.textC4);
            this.groupBox3.Controls.Add(this.textC3);
            this.groupBox3.Controls.Add(this.textC2);
            this.groupBox3.Controls.Add(this.textC1);
            this.groupBox3.Location = new System.Drawing.Point(370, 203);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(415, 77);
            this.groupBox3.TabIndex = 27;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "战败文本：";
            // 
            // textC6
            // 
            this.textC6.FormattingEnabled = true;
            this.textC6.Location = new System.Drawing.Point(281, 46);
            this.textC6.Name = "textC6";
            this.textC6.Size = new System.Drawing.Size(121, 20);
            this.textC6.TabIndex = 24;
            // 
            // textC5
            // 
            this.textC5.FormattingEnabled = true;
            this.textC5.Location = new System.Drawing.Point(154, 46);
            this.textC5.Name = "textC5";
            this.textC5.Size = new System.Drawing.Size(121, 20);
            this.textC5.TabIndex = 23;
            // 
            // textC4
            // 
            this.textC4.FormattingEnabled = true;
            this.textC4.Location = new System.Drawing.Point(27, 46);
            this.textC4.Name = "textC4";
            this.textC4.Size = new System.Drawing.Size(121, 20);
            this.textC4.TabIndex = 22;
            // 
            // textC3
            // 
            this.textC3.FormattingEnabled = true;
            this.textC3.Location = new System.Drawing.Point(281, 21);
            this.textC3.Name = "textC3";
            this.textC3.Size = new System.Drawing.Size(121, 20);
            this.textC3.TabIndex = 21;
            // 
            // textC2
            // 
            this.textC2.FormattingEnabled = true;
            this.textC2.Location = new System.Drawing.Point(154, 21);
            this.textC2.Name = "textC2";
            this.textC2.Size = new System.Drawing.Size(121, 20);
            this.textC2.TabIndex = 20;
            // 
            // textC1
            // 
            this.textC1.FormattingEnabled = true;
            this.textC1.Location = new System.Drawing.Point(27, 21);
            this.textC1.Name = "textC1";
            this.textC1.Size = new System.Drawing.Size(121, 20);
            this.textC1.TabIndex = 19;
            // 
            // pkm3
            // 
            this.pkm3.FormattingEnabled = true;
            this.pkm3.Items.AddRange(new object[] {
            "无",
            "妙蛙种子",
            "妙蛙草",
            "妙蛙花",
            "小火龙",
            "火恐龙",
            "喷火龙",
            "杰尼龟",
            "卡咪龟",
            "水箭龟",
            "绿毛虫",
            "铁甲蛹",
            "巴大蝶",
            "独角虫",
            "铁壳蛹",
            "大针蜂",
            "波波",
            "比比鸟",
            "大比鸟",
            "小拉达",
            "拉达",
            "烈雀",
            "大嘴雀",
            "阿柏蛇",
            "阿柏怪",
            "皮卡丘",
            "雷丘",
            "穿山鼠",
            "穿山王",
            "尼多兰",
            "尼多娜",
            "尼多后",
            "尼多朗",
            "尼多力诺",
            "尼多王",
            "皮皮",
            "皮可西",
            "六尾",
            "九尾",
            "胖丁",
            "胖可丁",
            "超音蝠",
            "大嘴蝠",
            "走路草",
            "臭臭花",
            "霸王花",
            "派拉斯",
            "派拉斯特",
            "毛球",
            "摩鲁蛾",
            "地鼠",
            "三地鼠",
            "喵喵",
            "猫老大",
            "可达鸭",
            "哥达鸭",
            "猴怪",
            "火暴猴",
            "卡蒂狗",
            "风速狗",
            "蚊香蝌蚪",
            "蚊香君",
            "蚊香泳士",
            "凯西",
            "勇基拉",
            "胡地",
            "腕力",
            "豪力",
            "怪力",
            "喇叭芽",
            "口呆花",
            "大食花",
            "玛瑙水母",
            "毒刺水母",
            "小拳石",
            "隆隆石",
            "隆隆岩",
            "小火马",
            "烈焰马",
            "呆呆兽",
            "呆壳兽",
            "小磁怪",
            "三合一磁怪",
            "大葱鸭",
            "嘟嘟",
            "嘟嘟利",
            "小海狮",
            "白海狮",
            "臭泥",
            "臭臭泥",
            "大舌贝",
            "刺甲贝",
            "鬼斯",
            "鬼斯通",
            "耿鬼",
            "大岩蛇",
            "催眠貘",
            "引梦貘人",
            "大钳蟹",
            "巨钳蟹",
            "霹雳电球",
            "顽皮雷弹",
            "蛋蛋",
            "椰蛋树",
            "卡拉卡拉",
            "嘎啦嘎啦",
            "飞腿郎",
            "快拳郎",
            "大舌头",
            "瓦斯弹",
            "双弹瓦斯",
            "独角犀牛",
            "钻角犀兽",
            "吉利蛋",
            "蔓藤怪",
            "袋兽",
            "墨海马",
            "海刺龙",
            "角金鱼",
            "金鱼王",
            "海星星",
            "宝石海星",
            "魔墙人偶",
            "飞天螳螂",
            "迷唇姐",
            "电击兽",
            "鸭嘴火兽",
            "凯罗斯",
            "肯泰罗",
            "鲤鱼王",
            "暴鲤龙",
            "拉普拉斯",
            "百变怪",
            "伊布",
            "水伊布",
            "雷伊布",
            "火伊布",
            "多边兽",
            "菊石兽",
            "多刺菊石兽",
            "化石盔",
            "镰刀盔",
            "化石翼龙",
            "卡比兽",
            "急冻鸟",
            "闪电鸟",
            "火焰鸟",
            "迷你龙",
            "哈克龙",
            "快龙",
            "超梦",
            "梦幻",
            "菊草叶",
            "月桂叶",
            "大竺葵",
            "火球鼠",
            "火岩鼠",
            "火暴兽",
            "小锯鳄",
            "蓝鳄",
            "大力鳄",
            "尾立",
            "大尾立",
            "咕咕",
            "猫头夜鹰",
            "芭瓢虫",
            "安瓢虫",
            "圆丝蛛",
            "阿利多斯",
            "叉字蝠",
            "灯笼鱼",
            "电灯怪",
            "皮丘",
            "皮宝宝",
            "宝宝丁",
            "波克比",
            "波克基古",
            "天然雀",
            "天然鸟",
            "咩利羊",
            "茸茸羊",
            "电龙",
            "美丽花",
            "玛力露",
            "玛力露丽",
            "树才怪",
            "蚊香蛙皇",
            "毽子草",
            "毽子花",
            "毽子棉",
            "长尾怪手",
            "向日种子",
            "向日花怪",
            "蜻蜻蜓",
            "乌波",
            "沼王",
            "太阳伊布",
            "月亮伊布",
            "黑暗鸦",
            "呆呆王",
            "梦妖",
            "未知图腾A",
            "果然翁",
            "麒麟奇",
            "榛果球",
            "佛烈托斯",
            "土龙弟弟",
            "天蝎",
            "大钢蛇",
            "布鲁",
            "布鲁皇",
            "千针鱼",
            "巨钳螳螂",
            "壶壶",
            "赫拉克罗斯",
            "狃拉",
            "熊宝宝",
            "圈圈熊",
            "熔岩虫",
            "熔岩蜗牛",
            "小山猪",
            "长毛猪",
            "太阳珊瑚",
            "铁炮鱼",
            "章鱼桶",
            "信使鸟",
            "巨翅飞鱼",
            "盔甲鸟",
            "戴鲁比",
            "黑鲁加",
            "刺龙王",
            "小小象",
            "顿甲",
            "多边兽Ⅱ",
            "惊角鹿",
            "图图犬",
            "无畏小子",
            "战舞郎",
            "迷唇娃",
            "电击怪",
            "鸭嘴宝宝",
            "大奶罐",
            "幸福蛋",
            "雷公",
            "炎帝",
            "水君",
            "幼基拉斯",
            "沙基拉斯",
            "班基拉斯",
            "洛奇亚",
            "凤王",
            "时拉比",
            "?(空）",
            "?(空）",
            "?(空）",
            "?(空）",
            "?(空）",
            "?(空）",
            "?(空）",
            "?(空）",
            "?(空）",
            "?(空）",
            "?(空）",
            "?(空）",
            "?(空）",
            "?(空）",
            "?(空）",
            "?(空）",
            "?(空）",
            "?(空）",
            "?(空）",
            "?(空）",
            "?(空）",
            "?(空）",
            "?(空）",
            "?(空）",
            "?(空）",
            "木守宫",
            "森林蜥蜴",
            "蜥蜴王",
            "火稚鸡",
            "力壮鸡",
            "火焰鸡",
            "水跃鱼",
            "沼跃鱼",
            "巨沼怪",
            "土狼犬",
            "大狼犬",
            "蛇纹熊",
            "直冲熊",
            "刺尾虫",
            "甲壳茧",
            "狩猎凤蝶",
            "盾甲茧",
            "毒粉蛾",
            "莲叶童子",
            "莲帽小童",
            "乐天河童",
            "橡实果",
            "长鼻叶",
            "狡猾天狗",
            "土居忍士",
            "铁面忍者",
            "脱壳忍者",
            "傲骨燕",
            "大王燕",
            "蘑蘑菇",
            "斗笠菇",
            "晃晃斑",
            "长翅鸥",
            "大嘴鸥",
            "溜溜糖球",
            "雨翅蛾",
            "吼吼鲸",
            "吼鲸王",
            "向尾喵",
            "优雅猫",
            "变隐龙",
            "天秤偶",
            "念力土偶",
            "朝北鼻",
            "煤炭龟",
            "勾魂眼",
            "泥泥鳅",
            "鲶鱼王",
            "爱心鱼",
            "龙虾小兵",
            "铁螯龙虾",
            "丑丑鱼",
            "美纳斯",
            "利牙鱼",
            "巨牙鲨",
            "大颚蚁",
            "超音波幼虫",
            "沙漠蜻蜓",
            "幕下力士",
            "铁掌力士",
            "落雷兽",
            "雷电兽",
            "呆火驼",
            "喷火驼",
            "海豹球",
            "海魔狮",
            "帝牙海狮",
            "刺球仙人掌",
            "梦歌仙人掌",
            "雪童子",
            "冰鬼护",
            "月石",
            "太阳岩",
            "露力丽",
            "跳跳猪",
            "噗噗猪",
            "正电拍拍",
            "负电拍拍",
            "大嘴娃",
            "玛沙那",
            "恰雷姆",
            "青绵鸟",
            "七夕青鸟",
            "小果然",
            "夜巡灵",
            "彷徨夜灵",
            "毒蔷薇",
            "懒人獭",
            "过动猿",
            "请假王",
            "溶食兽",
            "吞食兽",
            "热带龙",
            "咕妞妞",
            "吼爆弹",
            "爆音怪",
            "珍珠贝",
            "猎斑鱼",
            "樱花鱼",
            "阿勃梭鲁",
            "怨影娃娃",
            "诅咒娃娃",
            "饭匙蛇",
            "猫鼬斩",
            "古空棘鱼",
            "可可多拉",
            "可多拉",
            "波士可多拉",
            "飘浮泡泡",
            "电萤虫",
            "甜甜萤",
            "触手百合",
            "摇篮百合",
            "太古羽虫",
            "太古盔甲",
            "拉鲁拉丝",
            "奇鲁莉安",
            "沙奈朵",
            "宝贝龙",
            "甲壳龙",
            "暴飞龙",
            "铁哑铃",
            "金属怪",
            "巨金怪",
            "雷吉洛克",
            "雷吉艾斯",
            "雷吉斯奇鲁",
            "盖欧卡",
            "固拉多",
            "烈空坐",
            "拉帝亚斯",
            "拉帝欧斯",
            "基拉祈",
            "代欧奇希斯",
            "风铃铃",
            "蛋",
            "未知图腾B",
            "未知图腾C",
            "未知图腾D",
            "未知图腾E",
            "未知图腾F",
            "未知图腾G",
            "未知图腾H",
            "未知图腾I",
            "未知图腾J",
            "未知图腾K",
            "未知图腾L",
            "未知图腾M",
            "未知图腾N",
            "未知图腾O",
            "未知图腾P",
            "未知图腾Q",
            "未知图腾R",
            "未知图腾S",
            "未知图腾T",
            "未知图腾U",
            "未知图腾V",
            "未知图腾W",
            "未知图腾X",
            "未知图腾Y",
            "未知图腾Z",
            "未知图腾!",
            "未知图腾?"});
            this.pkm3.Location = new System.Drawing.Point(89, 167);
            this.pkm3.Name = "pkm3";
            this.pkm3.Size = new System.Drawing.Size(161, 20);
            this.pkm3.TabIndex = 51;
            // 
            // pkm2
            // 
            this.pkm2.FormattingEnabled = true;
            this.pkm2.Items.AddRange(new object[] {
            "无",
            "妙蛙种子",
            "妙蛙草",
            "妙蛙花",
            "小火龙",
            "火恐龙",
            "喷火龙",
            "杰尼龟",
            "卡咪龟",
            "水箭龟",
            "绿毛虫",
            "铁甲蛹",
            "巴大蝶",
            "独角虫",
            "铁壳蛹",
            "大针蜂",
            "波波",
            "比比鸟",
            "大比鸟",
            "小拉达",
            "拉达",
            "烈雀",
            "大嘴雀",
            "阿柏蛇",
            "阿柏怪",
            "皮卡丘",
            "雷丘",
            "穿山鼠",
            "穿山王",
            "尼多兰",
            "尼多娜",
            "尼多后",
            "尼多朗",
            "尼多力诺",
            "尼多王",
            "皮皮",
            "皮可西",
            "六尾",
            "九尾",
            "胖丁",
            "胖可丁",
            "超音蝠",
            "大嘴蝠",
            "走路草",
            "臭臭花",
            "霸王花",
            "派拉斯",
            "派拉斯特",
            "毛球",
            "摩鲁蛾",
            "地鼠",
            "三地鼠",
            "喵喵",
            "猫老大",
            "可达鸭",
            "哥达鸭",
            "猴怪",
            "火暴猴",
            "卡蒂狗",
            "风速狗",
            "蚊香蝌蚪",
            "蚊香君",
            "蚊香泳士",
            "凯西",
            "勇基拉",
            "胡地",
            "腕力",
            "豪力",
            "怪力",
            "喇叭芽",
            "口呆花",
            "大食花",
            "玛瑙水母",
            "毒刺水母",
            "小拳石",
            "隆隆石",
            "隆隆岩",
            "小火马",
            "烈焰马",
            "呆呆兽",
            "呆壳兽",
            "小磁怪",
            "三合一磁怪",
            "大葱鸭",
            "嘟嘟",
            "嘟嘟利",
            "小海狮",
            "白海狮",
            "臭泥",
            "臭臭泥",
            "大舌贝",
            "刺甲贝",
            "鬼斯",
            "鬼斯通",
            "耿鬼",
            "大岩蛇",
            "催眠貘",
            "引梦貘人",
            "大钳蟹",
            "巨钳蟹",
            "霹雳电球",
            "顽皮雷弹",
            "蛋蛋",
            "椰蛋树",
            "卡拉卡拉",
            "嘎啦嘎啦",
            "飞腿郎",
            "快拳郎",
            "大舌头",
            "瓦斯弹",
            "双弹瓦斯",
            "独角犀牛",
            "钻角犀兽",
            "吉利蛋",
            "蔓藤怪",
            "袋兽",
            "墨海马",
            "海刺龙",
            "角金鱼",
            "金鱼王",
            "海星星",
            "宝石海星",
            "魔墙人偶",
            "飞天螳螂",
            "迷唇姐",
            "电击兽",
            "鸭嘴火兽",
            "凯罗斯",
            "肯泰罗",
            "鲤鱼王",
            "暴鲤龙",
            "拉普拉斯",
            "百变怪",
            "伊布",
            "水伊布",
            "雷伊布",
            "火伊布",
            "多边兽",
            "菊石兽",
            "多刺菊石兽",
            "化石盔",
            "镰刀盔",
            "化石翼龙",
            "卡比兽",
            "急冻鸟",
            "闪电鸟",
            "火焰鸟",
            "迷你龙",
            "哈克龙",
            "快龙",
            "超梦",
            "梦幻",
            "菊草叶",
            "月桂叶",
            "大竺葵",
            "火球鼠",
            "火岩鼠",
            "火暴兽",
            "小锯鳄",
            "蓝鳄",
            "大力鳄",
            "尾立",
            "大尾立",
            "咕咕",
            "猫头夜鹰",
            "芭瓢虫",
            "安瓢虫",
            "圆丝蛛",
            "阿利多斯",
            "叉字蝠",
            "灯笼鱼",
            "电灯怪",
            "皮丘",
            "皮宝宝",
            "宝宝丁",
            "波克比",
            "波克基古",
            "天然雀",
            "天然鸟",
            "咩利羊",
            "茸茸羊",
            "电龙",
            "美丽花",
            "玛力露",
            "玛力露丽",
            "树才怪",
            "蚊香蛙皇",
            "毽子草",
            "毽子花",
            "毽子棉",
            "长尾怪手",
            "向日种子",
            "向日花怪",
            "蜻蜻蜓",
            "乌波",
            "沼王",
            "太阳伊布",
            "月亮伊布",
            "黑暗鸦",
            "呆呆王",
            "梦妖",
            "未知图腾A",
            "果然翁",
            "麒麟奇",
            "榛果球",
            "佛烈托斯",
            "土龙弟弟",
            "天蝎",
            "大钢蛇",
            "布鲁",
            "布鲁皇",
            "千针鱼",
            "巨钳螳螂",
            "壶壶",
            "赫拉克罗斯",
            "狃拉",
            "熊宝宝",
            "圈圈熊",
            "熔岩虫",
            "熔岩蜗牛",
            "小山猪",
            "长毛猪",
            "太阳珊瑚",
            "铁炮鱼",
            "章鱼桶",
            "信使鸟",
            "巨翅飞鱼",
            "盔甲鸟",
            "戴鲁比",
            "黑鲁加",
            "刺龙王",
            "小小象",
            "顿甲",
            "多边兽Ⅱ",
            "惊角鹿",
            "图图犬",
            "无畏小子",
            "战舞郎",
            "迷唇娃",
            "电击怪",
            "鸭嘴宝宝",
            "大奶罐",
            "幸福蛋",
            "雷公",
            "炎帝",
            "水君",
            "幼基拉斯",
            "沙基拉斯",
            "班基拉斯",
            "洛奇亚",
            "凤王",
            "时拉比",
            "?(空）",
            "?(空）",
            "?(空）",
            "?(空）",
            "?(空）",
            "?(空）",
            "?(空）",
            "?(空）",
            "?(空）",
            "?(空）",
            "?(空）",
            "?(空）",
            "?(空）",
            "?(空）",
            "?(空）",
            "?(空）",
            "?(空）",
            "?(空）",
            "?(空）",
            "?(空）",
            "?(空）",
            "?(空）",
            "?(空）",
            "?(空）",
            "?(空）",
            "木守宫",
            "森林蜥蜴",
            "蜥蜴王",
            "火稚鸡",
            "力壮鸡",
            "火焰鸡",
            "水跃鱼",
            "沼跃鱼",
            "巨沼怪",
            "土狼犬",
            "大狼犬",
            "蛇纹熊",
            "直冲熊",
            "刺尾虫",
            "甲壳茧",
            "狩猎凤蝶",
            "盾甲茧",
            "毒粉蛾",
            "莲叶童子",
            "莲帽小童",
            "乐天河童",
            "橡实果",
            "长鼻叶",
            "狡猾天狗",
            "土居忍士",
            "铁面忍者",
            "脱壳忍者",
            "傲骨燕",
            "大王燕",
            "蘑蘑菇",
            "斗笠菇",
            "晃晃斑",
            "长翅鸥",
            "大嘴鸥",
            "溜溜糖球",
            "雨翅蛾",
            "吼吼鲸",
            "吼鲸王",
            "向尾喵",
            "优雅猫",
            "变隐龙",
            "天秤偶",
            "念力土偶",
            "朝北鼻",
            "煤炭龟",
            "勾魂眼",
            "泥泥鳅",
            "鲶鱼王",
            "爱心鱼",
            "龙虾小兵",
            "铁螯龙虾",
            "丑丑鱼",
            "美纳斯",
            "利牙鱼",
            "巨牙鲨",
            "大颚蚁",
            "超音波幼虫",
            "沙漠蜻蜓",
            "幕下力士",
            "铁掌力士",
            "落雷兽",
            "雷电兽",
            "呆火驼",
            "喷火驼",
            "海豹球",
            "海魔狮",
            "帝牙海狮",
            "刺球仙人掌",
            "梦歌仙人掌",
            "雪童子",
            "冰鬼护",
            "月石",
            "太阳岩",
            "露力丽",
            "跳跳猪",
            "噗噗猪",
            "正电拍拍",
            "负电拍拍",
            "大嘴娃",
            "玛沙那",
            "恰雷姆",
            "青绵鸟",
            "七夕青鸟",
            "小果然",
            "夜巡灵",
            "彷徨夜灵",
            "毒蔷薇",
            "懒人獭",
            "过动猿",
            "请假王",
            "溶食兽",
            "吞食兽",
            "热带龙",
            "咕妞妞",
            "吼爆弹",
            "爆音怪",
            "珍珠贝",
            "猎斑鱼",
            "樱花鱼",
            "阿勃梭鲁",
            "怨影娃娃",
            "诅咒娃娃",
            "饭匙蛇",
            "猫鼬斩",
            "古空棘鱼",
            "可可多拉",
            "可多拉",
            "波士可多拉",
            "飘浮泡泡",
            "电萤虫",
            "甜甜萤",
            "触手百合",
            "摇篮百合",
            "太古羽虫",
            "太古盔甲",
            "拉鲁拉丝",
            "奇鲁莉安",
            "沙奈朵",
            "宝贝龙",
            "甲壳龙",
            "暴飞龙",
            "铁哑铃",
            "金属怪",
            "巨金怪",
            "雷吉洛克",
            "雷吉艾斯",
            "雷吉斯奇鲁",
            "盖欧卡",
            "固拉多",
            "烈空坐",
            "拉帝亚斯",
            "拉帝欧斯",
            "基拉祈",
            "代欧奇希斯",
            "风铃铃",
            "蛋",
            "未知图腾B",
            "未知图腾C",
            "未知图腾D",
            "未知图腾E",
            "未知图腾F",
            "未知图腾G",
            "未知图腾H",
            "未知图腾I",
            "未知图腾J",
            "未知图腾K",
            "未知图腾L",
            "未知图腾M",
            "未知图腾N",
            "未知图腾O",
            "未知图腾P",
            "未知图腾Q",
            "未知图腾R",
            "未知图腾S",
            "未知图腾T",
            "未知图腾U",
            "未知图腾V",
            "未知图腾W",
            "未知图腾X",
            "未知图腾Y",
            "未知图腾Z",
            "未知图腾!",
            "未知图腾?"});
            this.pkm2.Location = new System.Drawing.Point(89, 145);
            this.pkm2.Name = "pkm2";
            this.pkm2.Size = new System.Drawing.Size(161, 20);
            this.pkm2.TabIndex = 50;
            // 
            // pkm1
            // 
            this.pkm1.FormattingEnabled = true;
            this.pkm1.Items.AddRange(new object[] {
            "无",
            "妙蛙种子",
            "妙蛙草",
            "妙蛙花",
            "小火龙",
            "火恐龙",
            "喷火龙",
            "杰尼龟",
            "卡咪龟",
            "水箭龟",
            "绿毛虫",
            "铁甲蛹",
            "巴大蝶",
            "独角虫",
            "铁壳蛹",
            "大针蜂",
            "波波",
            "比比鸟",
            "大比鸟",
            "小拉达",
            "拉达",
            "烈雀",
            "大嘴雀",
            "阿柏蛇",
            "阿柏怪",
            "皮卡丘",
            "雷丘",
            "穿山鼠",
            "穿山王",
            "尼多兰",
            "尼多娜",
            "尼多后",
            "尼多朗",
            "尼多力诺",
            "尼多王",
            "皮皮",
            "皮可西",
            "六尾",
            "九尾",
            "胖丁",
            "胖可丁",
            "超音蝠",
            "大嘴蝠",
            "走路草",
            "臭臭花",
            "霸王花",
            "派拉斯",
            "派拉斯特",
            "毛球",
            "摩鲁蛾",
            "地鼠",
            "三地鼠",
            "喵喵",
            "猫老大",
            "可达鸭",
            "哥达鸭",
            "猴怪",
            "火暴猴",
            "卡蒂狗",
            "风速狗",
            "蚊香蝌蚪",
            "蚊香君",
            "蚊香泳士",
            "凯西",
            "勇基拉",
            "胡地",
            "腕力",
            "豪力",
            "怪力",
            "喇叭芽",
            "口呆花",
            "大食花",
            "玛瑙水母",
            "毒刺水母",
            "小拳石",
            "隆隆石",
            "隆隆岩",
            "小火马",
            "烈焰马",
            "呆呆兽",
            "呆壳兽",
            "小磁怪",
            "三合一磁怪",
            "大葱鸭",
            "嘟嘟",
            "嘟嘟利",
            "小海狮",
            "白海狮",
            "臭泥",
            "臭臭泥",
            "大舌贝",
            "刺甲贝",
            "鬼斯",
            "鬼斯通",
            "耿鬼",
            "大岩蛇",
            "催眠貘",
            "引梦貘人",
            "大钳蟹",
            "巨钳蟹",
            "霹雳电球",
            "顽皮雷弹",
            "蛋蛋",
            "椰蛋树",
            "卡拉卡拉",
            "嘎啦嘎啦",
            "飞腿郎",
            "快拳郎",
            "大舌头",
            "瓦斯弹",
            "双弹瓦斯",
            "独角犀牛",
            "钻角犀兽",
            "吉利蛋",
            "蔓藤怪",
            "袋兽",
            "墨海马",
            "海刺龙",
            "角金鱼",
            "金鱼王",
            "海星星",
            "宝石海星",
            "魔墙人偶",
            "飞天螳螂",
            "迷唇姐",
            "电击兽",
            "鸭嘴火兽",
            "凯罗斯",
            "肯泰罗",
            "鲤鱼王",
            "暴鲤龙",
            "拉普拉斯",
            "百变怪",
            "伊布",
            "水伊布",
            "雷伊布",
            "火伊布",
            "多边兽",
            "菊石兽",
            "多刺菊石兽",
            "化石盔",
            "镰刀盔",
            "化石翼龙",
            "卡比兽",
            "急冻鸟",
            "闪电鸟",
            "火焰鸟",
            "迷你龙",
            "哈克龙",
            "快龙",
            "超梦",
            "梦幻",
            "菊草叶",
            "月桂叶",
            "大竺葵",
            "火球鼠",
            "火岩鼠",
            "火暴兽",
            "小锯鳄",
            "蓝鳄",
            "大力鳄",
            "尾立",
            "大尾立",
            "咕咕",
            "猫头夜鹰",
            "芭瓢虫",
            "安瓢虫",
            "圆丝蛛",
            "阿利多斯",
            "叉字蝠",
            "灯笼鱼",
            "电灯怪",
            "皮丘",
            "皮宝宝",
            "宝宝丁",
            "波克比",
            "波克基古",
            "天然雀",
            "天然鸟",
            "咩利羊",
            "茸茸羊",
            "电龙",
            "美丽花",
            "玛力露",
            "玛力露丽",
            "树才怪",
            "蚊香蛙皇",
            "毽子草",
            "毽子花",
            "毽子棉",
            "长尾怪手",
            "向日种子",
            "向日花怪",
            "蜻蜻蜓",
            "乌波",
            "沼王",
            "太阳伊布",
            "月亮伊布",
            "黑暗鸦",
            "呆呆王",
            "梦妖",
            "未知图腾A",
            "果然翁",
            "麒麟奇",
            "榛果球",
            "佛烈托斯",
            "土龙弟弟",
            "天蝎",
            "大钢蛇",
            "布鲁",
            "布鲁皇",
            "千针鱼",
            "巨钳螳螂",
            "壶壶",
            "赫拉克罗斯",
            "狃拉",
            "熊宝宝",
            "圈圈熊",
            "熔岩虫",
            "熔岩蜗牛",
            "小山猪",
            "长毛猪",
            "太阳珊瑚",
            "铁炮鱼",
            "章鱼桶",
            "信使鸟",
            "巨翅飞鱼",
            "盔甲鸟",
            "戴鲁比",
            "黑鲁加",
            "刺龙王",
            "小小象",
            "顿甲",
            "多边兽Ⅱ",
            "惊角鹿",
            "图图犬",
            "无畏小子",
            "战舞郎",
            "迷唇娃",
            "电击怪",
            "鸭嘴宝宝",
            "大奶罐",
            "幸福蛋",
            "雷公",
            "炎帝",
            "水君",
            "幼基拉斯",
            "沙基拉斯",
            "班基拉斯",
            "洛奇亚",
            "凤王",
            "时拉比",
            "?(空）",
            "?(空）",
            "?(空）",
            "?(空）",
            "?(空）",
            "?(空）",
            "?(空）",
            "?(空）",
            "?(空）",
            "?(空）",
            "?(空）",
            "?(空）",
            "?(空）",
            "?(空）",
            "?(空）",
            "?(空）",
            "?(空）",
            "?(空）",
            "?(空）",
            "?(空）",
            "?(空）",
            "?(空）",
            "?(空）",
            "?(空）",
            "?(空）",
            "木守宫",
            "森林蜥蜴",
            "蜥蜴王",
            "火稚鸡",
            "力壮鸡",
            "火焰鸡",
            "水跃鱼",
            "沼跃鱼",
            "巨沼怪",
            "土狼犬",
            "大狼犬",
            "蛇纹熊",
            "直冲熊",
            "刺尾虫",
            "甲壳茧",
            "狩猎凤蝶",
            "盾甲茧",
            "毒粉蛾",
            "莲叶童子",
            "莲帽小童",
            "乐天河童",
            "橡实果",
            "长鼻叶",
            "狡猾天狗",
            "土居忍士",
            "铁面忍者",
            "脱壳忍者",
            "傲骨燕",
            "大王燕",
            "蘑蘑菇",
            "斗笠菇",
            "晃晃斑",
            "长翅鸥",
            "大嘴鸥",
            "溜溜糖球",
            "雨翅蛾",
            "吼吼鲸",
            "吼鲸王",
            "向尾喵",
            "优雅猫",
            "变隐龙",
            "天秤偶",
            "念力土偶",
            "朝北鼻",
            "煤炭龟",
            "勾魂眼",
            "泥泥鳅",
            "鲶鱼王",
            "爱心鱼",
            "龙虾小兵",
            "铁螯龙虾",
            "丑丑鱼",
            "美纳斯",
            "利牙鱼",
            "巨牙鲨",
            "大颚蚁",
            "超音波幼虫",
            "沙漠蜻蜓",
            "幕下力士",
            "铁掌力士",
            "落雷兽",
            "雷电兽",
            "呆火驼",
            "喷火驼",
            "海豹球",
            "海魔狮",
            "帝牙海狮",
            "刺球仙人掌",
            "梦歌仙人掌",
            "雪童子",
            "冰鬼护",
            "月石",
            "太阳岩",
            "露力丽",
            "跳跳猪",
            "噗噗猪",
            "正电拍拍",
            "负电拍拍",
            "大嘴娃",
            "玛沙那",
            "恰雷姆",
            "青绵鸟",
            "七夕青鸟",
            "小果然",
            "夜巡灵",
            "彷徨夜灵",
            "毒蔷薇",
            "懒人獭",
            "过动猿",
            "请假王",
            "溶食兽",
            "吞食兽",
            "热带龙",
            "咕妞妞",
            "吼爆弹",
            "爆音怪",
            "珍珠贝",
            "猎斑鱼",
            "樱花鱼",
            "阿勃梭鲁",
            "怨影娃娃",
            "诅咒娃娃",
            "饭匙蛇",
            "猫鼬斩",
            "古空棘鱼",
            "可可多拉",
            "可多拉",
            "波士可多拉",
            "飘浮泡泡",
            "电萤虫",
            "甜甜萤",
            "触手百合",
            "摇篮百合",
            "太古羽虫",
            "太古盔甲",
            "拉鲁拉丝",
            "奇鲁莉安",
            "沙奈朵",
            "宝贝龙",
            "甲壳龙",
            "暴飞龙",
            "铁哑铃",
            "金属怪",
            "巨金怪",
            "雷吉洛克",
            "雷吉艾斯",
            "雷吉斯奇鲁",
            "盖欧卡",
            "固拉多",
            "烈空坐",
            "拉帝亚斯",
            "拉帝欧斯",
            "基拉祈",
            "代欧奇希斯",
            "风铃铃",
            "蛋",
            "未知图腾B",
            "未知图腾C",
            "未知图腾D",
            "未知图腾E",
            "未知图腾F",
            "未知图腾G",
            "未知图腾H",
            "未知图腾I",
            "未知图腾J",
            "未知图腾K",
            "未知图腾L",
            "未知图腾M",
            "未知图腾N",
            "未知图腾O",
            "未知图腾P",
            "未知图腾Q",
            "未知图腾R",
            "未知图腾S",
            "未知图腾T",
            "未知图腾U",
            "未知图腾V",
            "未知图腾W",
            "未知图腾X",
            "未知图腾Y",
            "未知图腾Z",
            "未知图腾!",
            "未知图腾?"});
            this.pkm1.Location = new System.Drawing.Point(89, 120);
            this.pkm1.Name = "pkm1";
            this.pkm1.Size = new System.Drawing.Size(161, 20);
            this.pkm1.TabIndex = 49;
            // 
            // label9
            // 
            this.label9.Location = new System.Drawing.Point(14, 170);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(100, 17);
            this.label9.TabIndex = 48;
            this.label9.Text = "宝可梦3：";
            // 
            // label8
            // 
            this.label8.Location = new System.Drawing.Point(14, 148);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(100, 17);
            this.label8.TabIndex = 47;
            this.label8.Text = "宝可梦2：";
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(14, 123);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(75, 17);
            this.label7.TabIndex = 46;
            this.label7.Text = "宝可梦1：";
            // 
            // pkm3_edit_but
            // 
            this.pkm3_edit_but.Enabled = false;
            this.pkm3_edit_but.Location = new System.Drawing.Point(261, 165);
            this.pkm3_edit_but.Name = "pkm3_edit_but";
            this.pkm3_edit_but.Size = new System.Drawing.Size(75, 21);
            this.pkm3_edit_but.TabIndex = 45;
            this.pkm3_edit_but.Text = "编辑";
            this.pkm3_edit_but.UseVisualStyleBackColor = true;
            this.pkm3_edit_but.Click += new System.EventHandler(this.Pkm3_edit_butClick);
            // 
            // pkm2_edit_but
            // 
            this.pkm2_edit_but.Enabled = false;
            this.pkm2_edit_but.Location = new System.Drawing.Point(261, 143);
            this.pkm2_edit_but.Name = "pkm2_edit_but";
            this.pkm2_edit_but.Size = new System.Drawing.Size(75, 21);
            this.pkm2_edit_but.TabIndex = 44;
            this.pkm2_edit_but.Text = "编辑";
            this.pkm2_edit_but.UseVisualStyleBackColor = true;
            this.pkm2_edit_but.Click += new System.EventHandler(this.Pkm2_edit_butClick);
            // 
            // pkm1_edit_but
            // 
            this.pkm1_edit_but.Enabled = false;
            this.pkm1_edit_but.Location = new System.Drawing.Point(261, 118);
            this.pkm1_edit_but.Name = "pkm1_edit_but";
            this.pkm1_edit_but.Size = new System.Drawing.Size(75, 21);
            this.pkm1_edit_but.TabIndex = 43;
            this.pkm1_edit_but.Text = "编辑";
            this.pkm1_edit_but.UseVisualStyleBackColor = true;
            this.pkm1_edit_but.Click += new System.EventHandler(this.Pkm1_edit_butClick);
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(42, 97);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 21);
            this.label6.TabIndex = 42;
            this.label6.Text = "SID：";
            // 
            // SID
            // 
            this.SID.Location = new System.Drawing.Point(89, 95);
            this.SID.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
            this.SID.Name = "SID";
            this.SID.Size = new System.Drawing.Size(161, 21);
            this.SID.TabIndex = 41;
            // 
            // TID
            // 
            this.TID.Location = new System.Drawing.Point(89, 71);
            this.TID.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
            this.TID.Name = "TID";
            this.TID.Size = new System.Drawing.Size(161, 21);
            this.TID.TabIndex = 40;
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(42, 73);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 21);
            this.label5.TabIndex = 39;
            this.label5.Text = "TID：";
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(42, 50);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 21);
            this.label4.TabIndex = 38;
            this.label4.Text = "名字：";
            // 
            // name
            // 
            this.name.Location = new System.Drawing.Point(89, 47);
            this.name.MaxLength = 7;
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(161, 21);
            this.name.TabIndex = 37;
            // 
            // jap_check
            // 
            this.jap_check.Enabled = false;
            this.jap_check.Location = new System.Drawing.Point(256, 45);
            this.jap_check.Name = "jap_check";
            this.jap_check.Size = new System.Drawing.Size(104, 22);
            this.jap_check.TabIndex = 52;
            this.jap_check.Text = "日文解码";
            this.jap_check.UseVisualStyleBackColor = true;
            this.jap_check.CheckedChanged += new System.EventHandler(this.Jap_checkCheckedChanged);
            // 
            // radio_rs
            // 
            this.radio_rs.Location = new System.Drawing.Point(6, 18);
            this.radio_rs.Name = "radio_rs";
            this.radio_rs.Size = new System.Drawing.Size(104, 16);
            this.radio_rs.TabIndex = 53;
            this.radio_rs.TabStop = true;
            this.radio_rs.Text = "红宝石/蓝宝石";
            this.radio_rs.UseVisualStyleBackColor = true;
            this.radio_rs.CheckedChanged += new System.EventHandler(this.Radio_rsCheckedChanged);
            // 
            // radio_e
            // 
            this.radio_e.Location = new System.Drawing.Point(6, 33);
            this.radio_e.Name = "radio_e";
            this.radio_e.Size = new System.Drawing.Size(88, 18);
            this.radio_e.TabIndex = 54;
            this.radio_e.TabStop = true;
            this.radio_e.Text = "绿宝石";
            this.radio_e.UseVisualStyleBackColor = true;
            this.radio_e.CheckedChanged += new System.EventHandler(this.Radio_eCheckedChanged);
            // 
            // radio_FRLG
            // 
            this.radio_FRLG.Location = new System.Drawing.Point(6, 49);
            this.radio_FRLG.Name = "radio_FRLG";
            this.radio_FRLG.Size = new System.Drawing.Size(124, 20);
            this.radio_FRLG.TabIndex = 55;
            this.radio_FRLG.TabStop = true;
            this.radio_FRLG.Text = "火红/叶绿";
            this.radio_FRLG.UseVisualStyleBackColor = true;
            this.radio_FRLG.CheckedChanged += new System.EventHandler(this.Radio_FRLGCheckedChanged);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.radio_rs);
            this.groupBox4.Controls.Add(this.radio_e);
            this.groupBox4.Controls.Add(this.radio_FRLG);
            this.groupBox4.Location = new System.Drawing.Point(224, 261);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(136, 75);
            this.groupBox4.TabIndex = 56;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "训练家类型列表";
            // 
            // tower_appearance_num
            // 
            this.tower_appearance_num.Location = new System.Drawing.Point(145, 211);
            this.tower_appearance_num.Name = "tower_appearance_num";
            this.tower_appearance_num.Size = new System.Drawing.Size(189, 21);
            this.tower_appearance_num.TabIndex = 57;
            // 
            // trainer_class_value
            // 
            this.trainer_class_value.Hexadecimal = true;
            this.trainer_class_value.Location = new System.Drawing.Point(89, 237);
            this.trainer_class_value.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.trainer_class_value.Name = "trainer_class_value";
            this.trainer_class_value.Size = new System.Drawing.Size(50, 21);
            this.trainer_class_value.TabIndex = 58;
            this.trainer_class_value.ValueChanged += new System.EventHandler(this.Trainer_class_valueValueChanged);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.jap);
            this.groupBox5.Controls.Add(this.esp);
            this.groupBox5.Controls.Add(this.ita);
            this.groupBox5.Controls.Add(this.ger);
            this.groupBox5.Controls.Add(this.fre);
            this.groupBox5.Controls.Add(this.eng);
            this.groupBox5.Location = new System.Drawing.Point(370, 288);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(414, 70);
            this.groupBox5.TabIndex = 59;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "简单会话系统语言";
            // 
            // jap
            // 
            this.jap.Location = new System.Drawing.Point(281, 40);
            this.jap.Name = "jap";
            this.jap.Size = new System.Drawing.Size(104, 22);
            this.jap.TabIndex = 3;
            this.jap.TabStop = true;
            this.jap.Text = "日语";
            this.jap.UseVisualStyleBackColor = true;
            this.jap.CheckedChanged += new System.EventHandler(this.JapCheckedChanged);
            // 
            // esp
            // 
            this.esp.Location = new System.Drawing.Point(154, 40);
            this.esp.Name = "esp";
            this.esp.Size = new System.Drawing.Size(104, 22);
            this.esp.TabIndex = 61;
            this.esp.TabStop = true;
            this.esp.Text = "西班牙语";
            this.esp.UseVisualStyleBackColor = true;
            this.esp.CheckedChanged += new System.EventHandler(this.EspCheckedChanged);
            // 
            // ita
            // 
            this.ita.Location = new System.Drawing.Point(27, 40);
            this.ita.Name = "ita";
            this.ita.Size = new System.Drawing.Size(104, 22);
            this.ita.TabIndex = 60;
            this.ita.TabStop = true;
            this.ita.Text = "意大利语";
            this.ita.UseVisualStyleBackColor = true;
            this.ita.CheckedChanged += new System.EventHandler(this.ItaCheckedChanged);
            // 
            // ger
            // 
            this.ger.Location = new System.Drawing.Point(281, 18);
            this.ger.Name = "ger";
            this.ger.Size = new System.Drawing.Size(104, 22);
            this.ger.TabIndex = 2;
            this.ger.TabStop = true;
            this.ger.Text = "德语";
            this.ger.UseVisualStyleBackColor = true;
            this.ger.CheckedChanged += new System.EventHandler(this.GerCheckedChanged);
            // 
            // fre
            // 
            this.fre.Location = new System.Drawing.Point(154, 18);
            this.fre.Name = "fre";
            this.fre.Size = new System.Drawing.Size(104, 22);
            this.fre.TabIndex = 1;
            this.fre.TabStop = true;
            this.fre.Text = "法语";
            this.fre.UseVisualStyleBackColor = true;
            this.fre.CheckedChanged += new System.EventHandler(this.FreCheckedChanged);
            // 
            // eng
            // 
            this.eng.Location = new System.Drawing.Point(27, 18);
            this.eng.Name = "eng";
            this.eng.Size = new System.Drawing.Size(104, 22);
            this.eng.TabIndex = 0;
            this.eng.TabStop = true;
            this.eng.Text = "英语";
            this.eng.UseVisualStyleBackColor = true;
            this.eng.CheckedChanged += new System.EventHandler(this.EngCheckedChanged);
            // 
            // ECT_editor
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(833, 361);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.trainer_class_value);
            this.Controls.Add(this.tower_appearance_num);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.jap_check);
            this.Controls.Add(this.pkm3);
            this.Controls.Add(this.pkm2);
            this.Controls.Add(this.pkm1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.pkm3_edit_but);
            this.Controls.Add(this.pkm2_edit_but);
            this.Controls.Add(this.pkm1_edit_but);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.SID);
            this.Controls.Add(this.TID);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.name);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.tower_floor);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.helpclass_but);
            this.Controls.Add(this.trainer_class);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tower_appearance);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ect_path);
            this.Controls.Add(this.save_ect_but);
            this.Controls.Add(this.load_ect_but);
            this.Name = "ECT_editor";
            this.Text = "e卡训练家编辑器";
            this.DragDrop += new System.Windows.Forms.DragEventHandler(this.ECT_editorDragDrop);
            this.DragEnter += new System.Windows.Forms.DragEventHandler(this.ECT_editorDragEnter);
            ((System.ComponentModel.ISupportInitialize)(this.tower_floor)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.SID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TID)).EndInit();
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tower_appearance_num)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trainer_class_value)).EndInit();
            this.groupBox5.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

		}
	}
}
