/*
 * Created by SharpDevelop.
 * User: suloku
 * Date: 28/04/2016
 * Time: 21:22
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace WC3Tool
{
	partial class WC3_editor
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Button load_wc3_but;
		private System.Windows.Forms.Button save_wc3_but;
		private System.Windows.Forms.TextBox wc3_path;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.TextBox header1;
		private System.Windows.Forms.TextBox header2;
		private System.Windows.Forms.TextBox body1;
		private System.Windows.Forms.TextBox body2;
		private System.Windows.Forms.TextBox body3;
		private System.Windows.Forms.TextBox body4;
		private System.Windows.Forms.TextBox footer1;
		private System.Windows.Forms.TextBox footer2;
		private System.Windows.Forms.Button export_script_but;
		private System.Windows.Forms.Button import_script_but;
		private System.Windows.Forms.CheckBox custom_script;
		private System.Windows.Forms.ComboBox iconbox;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.ComboBox colorbox;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.NumericUpDown icon_num;
		private System.Windows.Forms.RadioButton distro_but_always;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.RadioButton distro_but_one;
		private System.Windows.Forms.RadioButton distro_but_no;
		private System.Windows.Forms.Label regionlab;
		private System.Windows.Forms.Button giveEgg_but;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.Label label13;
		private System.Windows.Forms.Label label12;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.NumericUpDown map_npc;
		private System.Windows.Forms.NumericUpDown map_map;
		private System.Windows.Forms.NumericUpDown map_bank;
		private System.Windows.Forms.Label label14;
		private System.Windows.Forms.Button map_help;
		private System.Windows.Forms.Button xse_import;
		private System.Windows.Forms.Button xse_export;
		private System.Windows.Forms.Button xse_help;
		private System.Windows.Forms.Button giveEggExt_but;
		private System.Windows.Forms.CheckBox faketoogle;
		
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
            this.load_wc3_but = new System.Windows.Forms.Button();
            this.save_wc3_but = new System.Windows.Forms.Button();
            this.wc3_path = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.header1 = new System.Windows.Forms.TextBox();
            this.header2 = new System.Windows.Forms.TextBox();
            this.body1 = new System.Windows.Forms.TextBox();
            this.body2 = new System.Windows.Forms.TextBox();
            this.body3 = new System.Windows.Forms.TextBox();
            this.body4 = new System.Windows.Forms.TextBox();
            this.footer1 = new System.Windows.Forms.TextBox();
            this.footer2 = new System.Windows.Forms.TextBox();
            this.export_script_but = new System.Windows.Forms.Button();
            this.import_script_but = new System.Windows.Forms.Button();
            this.custom_script = new System.Windows.Forms.CheckBox();
            this.iconbox = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.colorbox = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.icon_num = new System.Windows.Forms.NumericUpDown();
            this.distro_but_always = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.distro_but_no = new System.Windows.Forms.RadioButton();
            this.distro_but_one = new System.Windows.Forms.RadioButton();
            this.regionlab = new System.Windows.Forms.Label();
            this.giveEgg_but = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.map_help = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.map_npc = new System.Windows.Forms.NumericUpDown();
            this.map_map = new System.Windows.Forms.NumericUpDown();
            this.map_bank = new System.Windows.Forms.NumericUpDown();
            this.xse_import = new System.Windows.Forms.Button();
            this.xse_export = new System.Windows.Forms.Button();
            this.xse_help = new System.Windows.Forms.Button();
            this.giveEggExt_but = new System.Windows.Forms.Button();
            this.faketoogle = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.icon_num)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.map_npc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.map_map)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.map_bank)).BeginInit();
            this.SuspendLayout();
            // 
            // load_wc3_but
            // 
            this.load_wc3_but.Location = new System.Drawing.Point(49, 2);
            this.load_wc3_but.Name = "load_wc3_but";
            this.load_wc3_but.Size = new System.Drawing.Size(75, 33);
            this.load_wc3_but.TabIndex = 0;
            this.load_wc3_but.Text = "读取神秘\r卡片文件";
            this.load_wc3_but.UseVisualStyleBackColor = true;
            this.load_wc3_but.Click += new System.EventHandler(this.Load_wc3_butClick);
            // 
            // save_wc3_but
            // 
            this.save_wc3_but.Enabled = false;
            this.save_wc3_but.Location = new System.Drawing.Point(130, 2);
            this.save_wc3_but.Name = "save_wc3_but";
            this.save_wc3_but.Size = new System.Drawing.Size(75, 33);
            this.save_wc3_but.TabIndex = 1;
            this.save_wc3_but.Text = "保存神秘\r卡片文件";
            this.save_wc3_but.UseVisualStyleBackColor = true;
            this.save_wc3_but.Click += new System.EventHandler(this.Save_wc3_butClick);
            // 
            // wc3_path
            // 
            this.wc3_path.Location = new System.Drawing.Point(221, 12);
            this.wc3_path.Name = "wc3_path";
            this.wc3_path.ReadOnly = true;
            this.wc3_path.Size = new System.Drawing.Size(522, 21);
            this.wc3_path.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(46, 108);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 21);
            this.label1.TabIndex = 3;
            this.label1.Text = "标题1";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(46, 129);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 21);
            this.label2.TabIndex = 4;
            this.label2.Text = "标题2";
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(46, 150);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 21);
            this.label3.TabIndex = 5;
            this.label3.Text = "正文1";
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(46, 172);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 21);
            this.label4.TabIndex = 6;
            this.label4.Text = "正文2";
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(46, 193);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 21);
            this.label5.TabIndex = 7;
            this.label5.Text = "正文3";
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(46, 214);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 21);
            this.label6.TabIndex = 8;
            this.label6.Text = "正文4";
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(46, 235);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(100, 21);
            this.label7.TabIndex = 9;
            this.label7.Text = "页脚1";
            // 
            // label8
            // 
            this.label8.Location = new System.Drawing.Point(46, 257);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(100, 21);
            this.label8.TabIndex = 10;
            this.label8.Text = "页脚2";
            // 
            // header1
            // 
            this.header1.Location = new System.Drawing.Point(114, 105);
            this.header1.MaxLength = 40;
            this.header1.Name = "header1";
            this.header1.Size = new System.Drawing.Size(379, 21);
            this.header1.TabIndex = 11;
            this.header1.TextChanged += new System.EventHandler(this.Header1TextChanged);
            // 
            // header2
            // 
            this.header2.Location = new System.Drawing.Point(114, 126);
            this.header2.MaxLength = 40;
            this.header2.Name = "header2";
            this.header2.Size = new System.Drawing.Size(379, 21);
            this.header2.TabIndex = 12;
            this.header2.TextChanged += new System.EventHandler(this.Header2TextChanged);
            // 
            // body1
            // 
            this.body1.Location = new System.Drawing.Point(114, 148);
            this.body1.MaxLength = 40;
            this.body1.Name = "body1";
            this.body1.Size = new System.Drawing.Size(379, 21);
            this.body1.TabIndex = 13;
            this.body1.TextChanged += new System.EventHandler(this.Body1TextChanged);
            // 
            // body2
            // 
            this.body2.Location = new System.Drawing.Point(114, 169);
            this.body2.MaxLength = 40;
            this.body2.Name = "body2";
            this.body2.Size = new System.Drawing.Size(379, 21);
            this.body2.TabIndex = 14;
            this.body2.TextChanged += new System.EventHandler(this.Body2TextChanged);
            // 
            // body3
            // 
            this.body3.Location = new System.Drawing.Point(114, 190);
            this.body3.MaxLength = 40;
            this.body3.Name = "body3";
            this.body3.Size = new System.Drawing.Size(379, 21);
            this.body3.TabIndex = 15;
            this.body3.TextChanged += new System.EventHandler(this.Body3TextChanged);
            // 
            // body4
            // 
            this.body4.Location = new System.Drawing.Point(114, 211);
            this.body4.MaxLength = 40;
            this.body4.Name = "body4";
            this.body4.Size = new System.Drawing.Size(379, 21);
            this.body4.TabIndex = 16;
            this.body4.TextChanged += new System.EventHandler(this.Body4TextChanged);
            // 
            // footer1
            // 
            this.footer1.Location = new System.Drawing.Point(114, 233);
            this.footer1.MaxLength = 40;
            this.footer1.Name = "footer1";
            this.footer1.Size = new System.Drawing.Size(379, 21);
            this.footer1.TabIndex = 17;
            this.footer1.TextChanged += new System.EventHandler(this.Footer1TextChanged);
            // 
            // footer2
            // 
            this.footer2.Location = new System.Drawing.Point(114, 254);
            this.footer2.MaxLength = 40;
            this.footer2.Name = "footer2";
            this.footer2.Size = new System.Drawing.Size(379, 21);
            this.footer2.TabIndex = 18;
            this.footer2.TextChanged += new System.EventHandler(this.Footer2TextChanged);
            // 
            // export_script_but
            // 
            this.export_script_but.Enabled = false;
            this.export_script_but.Location = new System.Drawing.Point(47, 281);
            this.export_script_but.Name = "export_script_but";
            this.export_script_but.Size = new System.Drawing.Size(75, 21);
            this.export_script_but.TabIndex = 19;
            this.export_script_but.Text = "导出脚本";
            this.export_script_but.UseVisualStyleBackColor = true;
            this.export_script_but.Click += new System.EventHandler(this.Export_script_butClick);
            // 
            // import_script_but
            // 
            this.import_script_but.Enabled = false;
            this.import_script_but.Location = new System.Drawing.Point(128, 281);
            this.import_script_but.Name = "import_script_but";
            this.import_script_but.Size = new System.Drawing.Size(75, 21);
            this.import_script_but.TabIndex = 20;
            this.import_script_but.Text = "导入脚本";
            this.import_script_but.UseVisualStyleBackColor = true;
            this.import_script_but.Click += new System.EventHandler(this.Import_script_butClick);
            // 
            // custom_script
            // 
            this.custom_script.AutoCheck = false;
            this.custom_script.Location = new System.Drawing.Point(213, 281);
            this.custom_script.Name = "custom_script";
            this.custom_script.Size = new System.Drawing.Size(147, 22);
            this.custom_script.TabIndex = 21;
            this.custom_script.Text = "读取自制脚本";
            this.custom_script.UseVisualStyleBackColor = true;
            // 
            // iconbox
            // 
            this.iconbox.FormattingEnabled = true;
            this.iconbox.Items.AddRange(new object[] {
            "????????",
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
            "未知图腾?",
            "按索引设置  --->"});
            this.iconbox.Location = new System.Drawing.Point(115, 78);
            this.iconbox.Name = "iconbox";
            this.iconbox.Size = new System.Drawing.Size(243, 20);
            this.iconbox.TabIndex = 23;
            this.iconbox.SelectedIndexChanged += new System.EventHandler(this.IconboxSelectedIndexChanged);
            // 
            // label9
            // 
            this.label9.Location = new System.Drawing.Point(46, 81);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(42, 13);
            this.label9.TabIndex = 24;
            this.label9.Text = "小图标";
            // 
            // colorbox
            // 
            this.colorbox.FormattingEnabled = true;
            this.colorbox.Items.AddRange(new object[] {
            "深黄色+方块图案 (0x00)",
            "深蓝/绿色+方块图案 (0x04)",
            "红色+线条图案 (0x08)",
            "绿色+线条图案 (0x0c)",
            "蓝色+线条图案 (0x10)",
            "黄色+线条图案 (0x14)",
            "黄色+精灵球图案 (0x18)",
            "灰色+精灵球图案 (0x1c)"});
            this.colorbox.Location = new System.Drawing.Point(115, 54);
            this.colorbox.Name = "colorbox";
            this.colorbox.Size = new System.Drawing.Size(243, 20);
            this.colorbox.TabIndex = 25;
            this.colorbox.SelectedIndexChanged += new System.EventHandler(this.ColorboxSelectedIndexChanged);
            // 
            // label10
            // 
            this.label10.Location = new System.Drawing.Point(46, 55);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(63, 18);
            this.label10.TabIndex = 26;
            this.label10.Text = "颜色及图案";
            // 
            // icon_num
            // 
            this.icon_num.Location = new System.Drawing.Point(373, 78);
            this.icon_num.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
            this.icon_num.Name = "icon_num";
            this.icon_num.Size = new System.Drawing.Size(120, 21);
            this.icon_num.TabIndex = 27;
            this.icon_num.ValueChanged += new System.EventHandler(this.Icon_numValueChanged);
            // 
            // distro_but_always
            // 
            this.distro_but_always.Location = new System.Drawing.Point(6, 18);
            this.distro_but_always.Name = "distro_but_always";
            this.distro_but_always.Size = new System.Drawing.Size(141, 22);
            this.distro_but_always.TabIndex = 28;
            this.distro_but_always.TabStop = true;
            this.distro_but_always.Text = "永久";
            this.distro_but_always.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.distro_but_no);
            this.groupBox1.Controls.Add(this.distro_but_one);
            this.groupBox1.Controls.Add(this.distro_but_always);
            this.groupBox1.Location = new System.Drawing.Point(499, 36);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(154, 88);
            this.groupBox1.TabIndex = 29;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "是否可再分享配信";
            // 
            // distro_but_no
            // 
            this.distro_but_no.Location = new System.Drawing.Point(6, 60);
            this.distro_but_no.Name = "distro_but_no";
            this.distro_but_no.Size = new System.Drawing.Size(141, 22);
            this.distro_but_no.TabIndex = 30;
            this.distro_but_no.TabStop = true;
            this.distro_but_no.Text = "禁用";
            this.distro_but_no.UseVisualStyleBackColor = true;
            // 
            // distro_but_one
            // 
            this.distro_but_one.Location = new System.Drawing.Point(6, 39);
            this.distro_but_one.Name = "distro_but_one";
            this.distro_but_one.Size = new System.Drawing.Size(141, 22);
            this.distro_but_one.TabIndex = 29;
            this.distro_but_one.TabStop = true;
            this.distro_but_one.Text = "接收者不能再分享";
            this.distro_but_one.UseVisualStyleBackColor = true;
            // 
            // regionlab
            // 
            this.regionlab.Location = new System.Drawing.Point(373, 55);
            this.regionlab.Name = "regionlab";
            this.regionlab.Size = new System.Drawing.Size(100, 21);
            this.regionlab.TabIndex = 30;
            this.regionlab.Text = "美/欧版";
            // 
            // giveEgg_but
            // 
            this.giveEgg_but.Location = new System.Drawing.Point(47, 342);
            this.giveEgg_but.Name = "giveEgg_but";
            this.giveEgg_but.Size = new System.Drawing.Size(156, 21);
            this.giveEgg_but.TabIndex = 31;
            this.giveEgg_but.Text = "注入赠蛋脚本";
            this.giveEgg_but.UseVisualStyleBackColor = true;
            this.giveEgg_but.Click += new System.EventHandler(this.GiveEgg_butClick);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.map_help);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.map_npc);
            this.groupBox2.Controls.Add(this.map_map);
            this.groupBox2.Controls.Add(this.map_bank);
            this.groupBox2.Location = new System.Drawing.Point(290, 299);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(203, 103);
            this.groupBox2.TabIndex = 32;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "脚本关联";
            // 
            // map_help
            // 
            this.map_help.Location = new System.Drawing.Point(174, 10);
            this.map_help.Name = "map_help";
            this.map_help.Size = new System.Drawing.Size(21, 20);
            this.map_help.TabIndex = 7;
            this.map_help.Text = "?";
            this.map_help.UseVisualStyleBackColor = true;
            this.map_help.Click += new System.EventHandler(this.Map_helpClick);
            // 
            // label14
            // 
            this.label14.Location = new System.Drawing.Point(125, 23);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(70, 66);
            this.label14.TabIndex = 6;
            this.label14.Text = "全255时为宝可梦中心邮递员";
            this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label13
            // 
            this.label13.Location = new System.Drawing.Point(17, 71);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(36, 21);
            this.label13.TabIndex = 5;
            this.label13.Text = "NPC:";
            // 
            // label12
            // 
            this.label12.Location = new System.Drawing.Point(17, 47);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(36, 21);
            this.label12.TabIndex = 4;
            this.label12.Text = "Map:";
            // 
            // label11
            // 
            this.label11.Location = new System.Drawing.Point(17, 23);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(36, 17);
            this.label11.TabIndex = 3;
            this.label11.Text = "Bank:";
            // 
            // map_npc
            // 
            this.map_npc.Location = new System.Drawing.Point(59, 69);
            this.map_npc.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.map_npc.Name = "map_npc";
            this.map_npc.Size = new System.Drawing.Size(60, 21);
            this.map_npc.TabIndex = 2;
            // 
            // map_map
            // 
            this.map_map.Location = new System.Drawing.Point(59, 45);
            this.map_map.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.map_map.Name = "map_map";
            this.map_map.Size = new System.Drawing.Size(60, 21);
            this.map_map.TabIndex = 1;
            // 
            // map_bank
            // 
            this.map_bank.Location = new System.Drawing.Point(59, 21);
            this.map_bank.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.map_bank.Name = "map_bank";
            this.map_bank.Size = new System.Drawing.Size(60, 21);
            this.map_bank.TabIndex = 0;
            // 
            // xse_import
            // 
            this.xse_import.Enabled = false;
            this.xse_import.Location = new System.Drawing.Point(128, 307);
            this.xse_import.Name = "xse_import";
            this.xse_import.Size = new System.Drawing.Size(75, 21);
            this.xse_import.TabIndex = 34;
            this.xse_import.Text = "XSE导入";
            this.xse_import.UseVisualStyleBackColor = true;
            this.xse_import.Click += new System.EventHandler(this.Xse_importClick);
            // 
            // xse_export
            // 
            this.xse_export.Enabled = false;
            this.xse_export.Location = new System.Drawing.Point(47, 307);
            this.xse_export.Name = "xse_export";
            this.xse_export.Size = new System.Drawing.Size(75, 21);
            this.xse_export.TabIndex = 33;
            this.xse_export.Text = "XSE导出";
            this.xse_export.UseVisualStyleBackColor = true;
            this.xse_export.Click += new System.EventHandler(this.Xse_exportClick);
            // 
            // xse_help
            // 
            this.xse_help.Location = new System.Drawing.Point(209, 308);
            this.xse_help.Name = "xse_help";
            this.xse_help.Size = new System.Drawing.Size(21, 20);
            this.xse_help.TabIndex = 8;
            this.xse_help.Text = "?";
            this.xse_help.UseVisualStyleBackColor = true;
            this.xse_help.Click += new System.EventHandler(this.Xse_helpClick);
            // 
            // giveEggExt_but
            // 
            this.giveEggExt_but.Location = new System.Drawing.Point(47, 369);
            this.giveEggExt_but.Name = "giveEggExt_but";
            this.giveEggExt_but.Size = new System.Drawing.Size(156, 32);
            this.giveEggExt_but.TabIndex = 35;
            this.giveEggExt_but.Text = "注入赠蛋脚本(拓展版)";
            this.giveEggExt_but.UseVisualStyleBackColor = true;
            this.giveEggExt_but.Click += new System.EventHandler(this.GiveEggExt_butClick);
            // 
            // faketoogle
            // 
            this.faketoogle.Location = new System.Drawing.Point(130, 35);
            this.faketoogle.Name = "faketoogle";
            this.faketoogle.Size = new System.Drawing.Size(141, 18);
            this.faketoogle.TabIndex = 36;
            this.faketoogle.Text = "Fake saved WC ID";
            this.faketoogle.UseVisualStyleBackColor = true;
            this.faketoogle.Visible = false;
            // 
            // WC3_editor
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(749, 414);
            this.Controls.Add(this.faketoogle);
            this.Controls.Add(this.giveEggExt_but);
            this.Controls.Add(this.xse_help);
            this.Controls.Add(this.xse_import);
            this.Controls.Add(this.xse_export);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.giveEgg_but);
            this.Controls.Add(this.regionlab);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.icon_num);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.colorbox);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.iconbox);
            this.Controls.Add(this.custom_script);
            this.Controls.Add(this.import_script_but);
            this.Controls.Add(this.export_script_but);
            this.Controls.Add(this.footer2);
            this.Controls.Add(this.footer1);
            this.Controls.Add(this.body4);
            this.Controls.Add(this.body3);
            this.Controls.Add(this.body2);
            this.Controls.Add(this.body1);
            this.Controls.Add(this.header2);
            this.Controls.Add(this.header1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.wc3_path);
            this.Controls.Add(this.save_wc3_but);
            this.Controls.Add(this.load_wc3_but);
            this.Name = "WC3_editor";
            this.Text = "神秘卡片编辑器";
            this.Load += new System.EventHandler(this.WC3_editorLoad);
            this.DragDrop += new System.Windows.Forms.DragEventHandler(this.WC3_editorDragDrop);
            this.DragEnter += new System.Windows.Forms.DragEventHandler(this.WC3_editorDragEnter);
            ((System.ComponentModel.ISupportInitialize)(this.icon_num)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.map_npc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.map_map)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.map_bank)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}
	}
}
