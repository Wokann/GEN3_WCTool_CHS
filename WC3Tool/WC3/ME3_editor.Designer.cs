/*
 * Created by SharpDevelop.
 * User: suloku
 * Date: 02/05/2016
 * Time: 23:40
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace WC3Tool
{
	partial class ME3_editor
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Button load_me3_but;
		private System.Windows.Forms.Button save_me3_but;
		private System.Windows.Forms.TextBox me3_path;
		private System.Windows.Forms.Button export_script_but;
		private System.Windows.Forms.Button import_script_but;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.ComboBox itembox;
		private System.Windows.Forms.NumericUpDown amountbox;
		private System.Windows.Forms.NumericUpDown counterbox;
		private System.Windows.Forms.CheckBox custom_script;
		private System.Windows.Forms.Button removescript_but;
		private System.Windows.Forms.CheckBox script_check;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.RadioButton radio_E;
		private System.Windows.Forms.RadioButton radio_RS;
		private System.Windows.Forms.NumericUpDown map_bank;
		private System.Windows.Forms.NumericUpDown map_num;
		private System.Windows.Forms.NumericUpDown map_npc;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.Button help_npc;
		private System.Windows.Forms.Button counter_help;
		private System.Windows.Forms.Button amount_help;
		private System.Windows.Forms.Button item_help;
		private System.Windows.Forms.Button xse_help;
		private System.Windows.Forms.Button xse_import;
		private System.Windows.Forms.Button xse_export;
		
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
            this.load_me3_but = new System.Windows.Forms.Button();
            this.save_me3_but = new System.Windows.Forms.Button();
            this.me3_path = new System.Windows.Forms.TextBox();
            this.export_script_but = new System.Windows.Forms.Button();
            this.import_script_but = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.itembox = new System.Windows.Forms.ComboBox();
            this.amountbox = new System.Windows.Forms.NumericUpDown();
            this.counterbox = new System.Windows.Forms.NumericUpDown();
            this.custom_script = new System.Windows.Forms.CheckBox();
            this.script_check = new System.Windows.Forms.CheckBox();
            this.removescript_but = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radio_E = new System.Windows.Forms.RadioButton();
            this.radio_RS = new System.Windows.Forms.RadioButton();
            this.map_bank = new System.Windows.Forms.NumericUpDown();
            this.map_num = new System.Windows.Forms.NumericUpDown();
            this.map_npc = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.help_npc = new System.Windows.Forms.Button();
            this.counter_help = new System.Windows.Forms.Button();
            this.amount_help = new System.Windows.Forms.Button();
            this.item_help = new System.Windows.Forms.Button();
            this.xse_help = new System.Windows.Forms.Button();
            this.xse_import = new System.Windows.Forms.Button();
            this.xse_export = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.amountbox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.counterbox)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.map_bank)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.map_num)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.map_npc)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // load_me3_but
            // 
            this.load_me3_but.Location = new System.Drawing.Point(12, 2);
            this.load_me3_but.Name = "load_me3_but";
            this.load_me3_but.Size = new System.Drawing.Size(75, 40);
            this.load_me3_but.TabIndex = 0;
            this.load_me3_but.Text = "读取神秘事件文件";
            this.load_me3_but.UseVisualStyleBackColor = true;
            this.load_me3_but.Click += new System.EventHandler(this.Load_me3_butClick);
            // 
            // save_me3_but
            // 
            this.save_me3_but.Enabled = false;
            this.save_me3_but.Location = new System.Drawing.Point(93, 2);
            this.save_me3_but.Name = "save_me3_but";
            this.save_me3_but.Size = new System.Drawing.Size(75, 40);
            this.save_me3_but.TabIndex = 1;
            this.save_me3_but.Text = "保存神秘事件文件";
            this.save_me3_but.UseVisualStyleBackColor = true;
            this.save_me3_but.Click += new System.EventHandler(this.Save_me3_butClick);
            // 
            // me3_path
            // 
            this.me3_path.Location = new System.Drawing.Point(12, 48);
            this.me3_path.Name = "me3_path";
            this.me3_path.ReadOnly = true;
            this.me3_path.Size = new System.Drawing.Size(309, 21);
            this.me3_path.TabIndex = 2;
            // 
            // export_script_but
            // 
            this.export_script_but.Enabled = false;
            this.export_script_but.Location = new System.Drawing.Point(12, 197);
            this.export_script_but.Name = "export_script_but";
            this.export_script_but.Size = new System.Drawing.Size(75, 21);
            this.export_script_but.TabIndex = 3;
            this.export_script_but.Text = "导出脚本";
            this.export_script_but.UseVisualStyleBackColor = true;
            this.export_script_but.Click += new System.EventHandler(this.Export_script_butClick);
            // 
            // import_script_but
            // 
            this.import_script_but.Enabled = false;
            this.import_script_but.Location = new System.Drawing.Point(93, 197);
            this.import_script_but.Name = "import_script_but";
            this.import_script_but.Size = new System.Drawing.Size(75, 21);
            this.import_script_but.TabIndex = 4;
            this.import_script_but.Text = "导入脚本";
            this.import_script_but.UseVisualStyleBackColor = true;
            this.import_script_but.Click += new System.EventHandler(this.Import_script_butClick);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(26, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 21);
            this.label1.TabIndex = 5;
            this.label1.Text = "道具";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(26, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 21);
            this.label2.TabIndex = 6;
            this.label2.Text = "总数量";
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(26, 129);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 21);
            this.label3.TabIndex = 7;
            this.label3.Text = "可分享次数";
            // 
            // itembox
            // 
            this.itembox.FormattingEnabled = true;
            this.itembox.Items.AddRange(new object[] {
            "无",
            "大师球",
            "高级球",
            "超级球",
            "精灵球",
            "狩猎球",
            "捕网球",
            "潜水球",
            "巢穴球",
            "重复球",
            "计时球",
            "豪华球",
            "纪念球",
            "伤药",
            "解毒药",
            "灼伤药",
            "解冻药",
            "解眠药",
            "解麻药",
            "全复药",
            "全满药",
            "厉害伤药",
            "好伤药",
            "万灵药",
            "活力碎片",
            "活力块",
            "美味之水",
            "劲爽汽水",
            "果汁牛奶",
            "哞哞鲜奶",
            "元气粉",
            "元气根",
            "万能粉",
            "复活草",
            "ＰＰ单项小补剂",
            "ＰＰ单项全补剂",
            "ＰＰ多项小补剂",
            "ＰＰ多项全补剂",
            "釜炎仙贝",
            "蓝色玻璃哨",
            "黄色玻璃哨",
            "红色玻璃哨",
            "黑色玻璃哨",
            "白色玻璃哨",
            "树果汁",
            "圣灰",
            "浅滩海盐",
            "浅滩贝壳",
            "红色碎片",
            "蓝色碎片",
            "黄色碎片",
            "绿色碎片",
            "未知",
            "未知",
            "未知",
            "未知",
            "未知",
            "未知",
            "未知",
            "未知",
            "未知",
            "未知",
            "未知",
            "ＨＰ增强剂",
            "攻击增强剂",
            "防御增强剂",
            "速度增强剂",
            "特攻增强剂",
            "神奇糖果",
            "ＰＰ提升剂",
            "特防增强剂",
            "ＰＰ极限提升剂",
            "未知",
            "能力防守",
            "要害攻击",
            "力量强化",
            "防御强化",
            "速度强化",
            "命中强化",
            "特攻强化",
            "皮皮玩偶",
            "向尾喵的尾巴",
            "未知",
            "白银喷雾",
            "黄金喷雾",
            "离洞绳",
            "除虫喷雾",
            "未知",
            "未知",
            "未知",
            "未知",
            "未知",
            "未知",
            "日之石",
            "月之石",
            "火之石",
            "雷之石",
            "水之石",
            "叶之石",
            "未知",
            "未知",
            "未知",
            "未知",
            "小蘑菇",
            "大蘑菇",
            "未知",
            "珍珠",
            "大珍珠",
            "星星沙子",
            "星星碎片",
            "金珠",
            "心之鳞片",
            "未知",
            "未知",
            "未知",
            "未知",
            "未知",
            "未知",
            "未知",
            "未知",
            "未知",
            "橙色邮件",
            "港口邮件",
            "闪亮邮件",
            "机械邮件",
            "木纹邮件",
            "波涛邮件",
            "珠宝邮件",
            "影子邮件",
            "热带邮件",
            "梦境邮件",
            "奇迹邮件",
            "复古邮件",
            "樱子果",
            "零余果",
            "桃桃果",
            "莓莓果",
            "利木果",
            "苹野果",
            "橙橙果",
            "柿仔果",
            "木子果",
            "文柚果",
            "勿花果",
            "异奇果",
            "芒芒果",
            "乐芭果",
            "芭亚果",
            "蔓莓果",
            "墨莓果",
            "蕉香果",
            "西梨果",
            "凰梨果",
            "榴石果",
            "藻根果",
            "比巴果",
            "哈密果",
            "萄葡果",
            "茄番果",
            "玉黍果",
            "岳竹果",
            "茸丹果",
            "檬柠果",
            "刺角果",
            "椰木果",
            "瓜西果",
            "金枕果",
            "靛莓果",
            "枝荔果",
            "龙睛果",
            "沙鳞果",
            "龙火果",
            "杏仔果",
            "兰萨果",
            "星桃果",
            "谜芝果",
            "未知",
            "未知",
            "未知",
            "光粉",
            "白色香草",
            "强制锻炼器",
            "学习装置",
            "先制之爪",
            "安抚之铃",
            "心灵香草",
            "讲究头带",
            "王者之证",
            "银粉",
            "护符金币",
            "洁净之符",
            "心之水滴",
            "深海之牙",
            "深海鳞片",
            "烟雾球",
            "不变之石",
            "气势头带",
            "幸运蛋",
            "焦点镜",
            "金属膜",
            "吃剩的东西",
            "龙之鳞片",
            "电气球",
            "柔软沙子",
            "硬石头",
            "奇迹种子",
            "黑色眼镜",
            "黑带",
            "磁铁",
            "神秘水滴",
            "锐利鸟嘴",
            "毒针",
            "不融冰",
            "诅咒之符",
            "弯曲的汤匙",
            "木炭",
            "龙之牙",
            "丝绸围巾",
            "升级数据",
            "贝壳之铃",
            "海潮薰香",
            "悠闲薰香",
            "吉利拳",
            "金属粉",
            "粗骨头",
            "大葱",
            "未知",
            "未知",
            "未知",
            "未知",
            "未知",
            "未知",
            "未知",
            "未知",
            "未知",
            "未知",
            "未知",
            "未知",
            "未知",
            "未知",
            "未知",
            "未知",
            "未知",
            "未知",
            "未知",
            "未知",
            "未知",
            "未知",
            "未知",
            "未知",
            "未知",
            "未知",
            "未知",
            "未知",
            "红色头巾",
            "蓝色头巾",
            "粉红头巾",
            "绿色头巾",
            "黄色头巾",
            "音速自行车",
            "代币盒",
            "探宝器",
            "破旧钓竿",
            "好钓竿",
            "厉害钓竿",
            "船票",
            "华丽大赛参加证",
            "未知",
            "吼吼鲸喷壶",
            "得文的物品",
            "集灰袋",
            "地下钥匙",
            "越野自行车",
            "宝可方块盒",
            "给大吾的信",
            "无限船票",
            "朱红色宝珠",
            "靛蓝色宝珠",
            "探测器",
            "ＧＯＧＯ护目镜",
            "陨石",
            "１号客房的钥匙",
            "２号客房的钥匙",
            "４号客房的钥匙",
            "６号客房的钥匙",
            "仓库钥匙",
            "根状化石",
            "爪子化石",
            "得文侦测镜",
            "TM01",
            "TM02",
            "TM03",
            "TM04",
            "TM05",
            "TM06",
            "TM07",
            "TM08",
            "TM09",
            "TM10",
            "TM11",
            "TM12",
            "TM13",
            "TM14",
            "TM15",
            "TM16",
            "TM17",
            "TM18",
            "TM19",
            "TM20",
            "TM21",
            "TM22",
            "TM23",
            "TM24",
            "TM25",
            "TM26",
            "TM27",
            "TM28",
            "TM29",
            "TM30",
            "TM31",
            "TM32",
            "TM33",
            "TM34",
            "TM35",
            "TM36",
            "TM37",
            "TM38",
            "TM39",
            "TM40",
            "TM41",
            "TM42",
            "TM43",
            "TM44",
            "TM45",
            "TM46",
            "TM47",
            "TM48",
            "TM49",
            "TM50",
            "HM01",
            "HM02",
            "HM03",
            "HM04",
            "HM05",
            "HM06",
            "HM07",
            "HM08",
            "未知",
            "未知",
            "包裹* (仅绿宝石)",
            "宝可梦之笛* (仅绿宝石)",
            "秘密钥匙* (仅绿宝石)",
            "兑换券* (仅绿宝石)",
            "金假牙* (仅绿宝石)",
            "秘密琥珀* (仅绿宝石)",
            "钥匙卡* (仅绿宝石)",
            "电梯钥匙* (仅绿宝石)",
            "贝壳化石* (仅绿宝石)",
            "甲壳化石* (仅绿宝石)",
            "西尔佛检视镜* (仅绿宝石)",
            "自行车* (仅绿宝石)",
            "城镇地图* (仅绿宝石)",
            "对战搜寻器* (仅绿宝石)",
            "声音记录器* (仅绿宝石)",
            "招式学习器盒* (仅绿宝石)",
            "树果袋* (仅绿宝石)",
            "教学电视* (仅绿宝石)",
            "三岛通行证* (仅绿宝石)",
            "七岛通行证* (仅绿宝石)",
            "茶* (仅绿宝石)",
            "神秘船票* (仅绿宝石)",
            "极光船票* (仅绿宝石)",
            "粉末收集瓶* (仅绿宝石)",
            "红宝石* (仅绿宝石)",
            "蓝宝石* (仅绿宝石)",
            "熔岩标志* (仅绿宝石)",
            "古航海图* (仅绿宝石)"});
            this.itembox.Location = new System.Drawing.Point(132, 78);
            this.itembox.Name = "itembox";
            this.itembox.Size = new System.Drawing.Size(189, 20);
            this.itembox.TabIndex = 8;
            this.itembox.SelectedIndexChanged += new System.EventHandler(this.ItemboxSelectedIndexChanged);
            // 
            // amountbox
            // 
            this.amountbox.Location = new System.Drawing.Point(132, 103);
            this.amountbox.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.amountbox.Name = "amountbox";
            this.amountbox.Size = new System.Drawing.Size(189, 21);
            this.amountbox.TabIndex = 9;
            // 
            // counterbox
            // 
            this.counterbox.Location = new System.Drawing.Point(132, 127);
            this.counterbox.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.counterbox.Name = "counterbox";
            this.counterbox.Size = new System.Drawing.Size(189, 21);
            this.counterbox.TabIndex = 10;
            this.counterbox.ValueChanged += new System.EventHandler(this.CounterboxValueChanged);
            // 
            // custom_script
            // 
            this.custom_script.AutoCheck = false;
            this.custom_script.Location = new System.Drawing.Point(204, 197);
            this.custom_script.Name = "custom_script";
            this.custom_script.Size = new System.Drawing.Size(104, 22);
            this.custom_script.TabIndex = 11;
            this.custom_script.Text = "自制脚本";
            this.custom_script.UseVisualStyleBackColor = true;
            // 
            // script_check
            // 
            this.script_check.AutoCheck = false;
            this.script_check.Location = new System.Drawing.Point(204, 169);
            this.script_check.Name = "script_check";
            this.script_check.Size = new System.Drawing.Size(104, 22);
            this.script_check.TabIndex = 12;
            this.script_check.Text = "脚本展示";
            this.script_check.UseVisualStyleBackColor = true;
            // 
            // removescript_but
            // 
            this.removescript_but.Enabled = false;
            this.removescript_but.Location = new System.Drawing.Point(12, 170);
            this.removescript_but.Name = "removescript_but";
            this.removescript_but.Size = new System.Drawing.Size(156, 21);
            this.removescript_but.TabIndex = 13;
            this.removescript_but.Text = "移除脚本";
            this.removescript_but.UseVisualStyleBackColor = true;
            this.removescript_but.Click += new System.EventHandler(this.Removescript_butClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radio_E);
            this.groupBox1.Controls.Add(this.radio_RS);
            this.groupBox1.Location = new System.Drawing.Point(20, 250);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(127, 86);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "游戏版本";
            // 
            // radio_E
            // 
            this.radio_E.Location = new System.Drawing.Point(6, 50);
            this.radio_E.Name = "radio_E";
            this.radio_E.Size = new System.Drawing.Size(121, 22);
            this.radio_E.TabIndex = 1;
            this.radio_E.TabStop = true;
            this.radio_E.Text = "绿宝石（仅日版）";
            this.radio_E.UseVisualStyleBackColor = true;
            // 
            // radio_RS
            // 
            this.radio_RS.Location = new System.Drawing.Point(6, 22);
            this.radio_RS.Name = "radio_RS";
            this.radio_RS.Size = new System.Drawing.Size(115, 22);
            this.radio_RS.TabIndex = 0;
            this.radio_RS.TabStop = true;
            this.radio_RS.Text = "红宝石/蓝宝石";
            this.radio_RS.UseVisualStyleBackColor = true;
            // 
            // map_bank
            // 
            this.map_bank.Location = new System.Drawing.Point(82, 13);
            this.map_bank.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.map_bank.Name = "map_bank";
            this.map_bank.Size = new System.Drawing.Size(71, 21);
            this.map_bank.TabIndex = 15;
            // 
            // map_num
            // 
            this.map_num.Location = new System.Drawing.Point(82, 37);
            this.map_num.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.map_num.Name = "map_num";
            this.map_num.Size = new System.Drawing.Size(71, 21);
            this.map_num.TabIndex = 16;
            // 
            // map_npc
            // 
            this.map_npc.Location = new System.Drawing.Point(82, 61);
            this.map_npc.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.map_npc.Name = "map_npc";
            this.map_npc.Size = new System.Drawing.Size(71, 21);
            this.map_npc.TabIndex = 17;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(6, 15);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 17);
            this.label4.TabIndex = 18;
            this.label4.Text = "Map Bank";
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(6, 39);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 21);
            this.label5.TabIndex = 19;
            this.label5.Text = "Map #";
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(6, 63);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 21);
            this.label6.TabIndex = 20;
            this.label6.Text = "Map NPC";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.map_bank);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.map_num);
            this.groupBox2.Controls.Add(this.map_npc);
            this.groupBox2.Location = new System.Drawing.Point(155, 250);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(166, 86);
            this.groupBox2.TabIndex = 21;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "脚本NPC";
            // 
            // help_npc
            // 
            this.help_npc.Location = new System.Drawing.Point(327, 261);
            this.help_npc.Name = "help_npc";
            this.help_npc.Size = new System.Drawing.Size(17, 19);
            this.help_npc.TabIndex = 22;
            this.help_npc.Text = "?";
            this.help_npc.UseVisualStyleBackColor = true;
            this.help_npc.Click += new System.EventHandler(this.Help_npcClick);
            // 
            // counter_help
            // 
            this.counter_help.Location = new System.Drawing.Point(327, 126);
            this.counter_help.Name = "counter_help";
            this.counter_help.Size = new System.Drawing.Size(17, 19);
            this.counter_help.TabIndex = 23;
            this.counter_help.Text = "?";
            this.counter_help.UseVisualStyleBackColor = true;
            this.counter_help.Click += new System.EventHandler(this.Counter_helpClick);
            // 
            // amount_help
            // 
            this.amount_help.Location = new System.Drawing.Point(327, 102);
            this.amount_help.Name = "amount_help";
            this.amount_help.Size = new System.Drawing.Size(17, 19);
            this.amount_help.TabIndex = 24;
            this.amount_help.Text = "?";
            this.amount_help.UseVisualStyleBackColor = true;
            this.amount_help.Click += new System.EventHandler(this.Amount_helpClick);
            // 
            // item_help
            // 
            this.item_help.Location = new System.Drawing.Point(327, 78);
            this.item_help.Name = "item_help";
            this.item_help.Size = new System.Drawing.Size(17, 19);
            this.item_help.TabIndex = 25;
            this.item_help.Text = "?";
            this.item_help.UseVisualStyleBackColor = true;
            this.item_help.Click += new System.EventHandler(this.Item_helpClick);
            // 
            // xse_help
            // 
            this.xse_help.Location = new System.Drawing.Point(174, 225);
            this.xse_help.Name = "xse_help";
            this.xse_help.Size = new System.Drawing.Size(21, 20);
            this.xse_help.TabIndex = 35;
            this.xse_help.Text = "?";
            this.xse_help.UseVisualStyleBackColor = true;
            this.xse_help.Click += new System.EventHandler(this.Xse_helpClick);
            // 
            // xse_import
            // 
            this.xse_import.Location = new System.Drawing.Point(93, 223);
            this.xse_import.Name = "xse_import";
            this.xse_import.Size = new System.Drawing.Size(75, 21);
            this.xse_import.TabIndex = 37;
            this.xse_import.Text = "XSE导入";
            this.xse_import.UseVisualStyleBackColor = true;
            this.xse_import.Click += new System.EventHandler(this.Xse_importClick);
            // 
            // xse_export
            // 
            this.xse_export.Location = new System.Drawing.Point(12, 223);
            this.xse_export.Name = "xse_export";
            this.xse_export.Size = new System.Drawing.Size(75, 21);
            this.xse_export.TabIndex = 36;
            this.xse_export.Text = "XSE导出";
            this.xse_export.UseVisualStyleBackColor = true;
            this.xse_export.Click += new System.EventHandler(this.Xse_exportClick);
            // 
            // ME3_editor
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(354, 342);
            this.Controls.Add(this.xse_help);
            this.Controls.Add(this.xse_import);
            this.Controls.Add(this.xse_export);
            this.Controls.Add(this.item_help);
            this.Controls.Add(this.amount_help);
            this.Controls.Add(this.counter_help);
            this.Controls.Add(this.help_npc);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.removescript_but);
            this.Controls.Add(this.script_check);
            this.Controls.Add(this.custom_script);
            this.Controls.Add(this.counterbox);
            this.Controls.Add(this.amountbox);
            this.Controls.Add(this.itembox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.import_script_but);
            this.Controls.Add(this.export_script_but);
            this.Controls.Add(this.me3_path);
            this.Controls.Add(this.save_me3_but);
            this.Controls.Add(this.load_me3_but);
            this.Name = "ME3_editor";
            this.Text = "神秘事件编辑器";
            this.DragDrop += new System.Windows.Forms.DragEventHandler(this.ME3_editorDragDrop);
            this.DragEnter += new System.Windows.Forms.DragEventHandler(this.ME3_editorDragEnter);
            ((System.ComponentModel.ISupportInitialize)(this.amountbox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.counterbox)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.map_bank)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.map_num)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.map_npc)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

		}
	}
}
