/*
 * Created by SharpDevelop.
 * User: suloku
 * Date: 29/04/2016
 * Time: 13:45
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace WC3Tool
{
	partial class MainScreen
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Button wc3_editor_but;
		private System.Windows.Forms.Button load_save_but;
		private System.Windows.Forms.Button inject_wc3_but;
		private System.Windows.Forms.Button export_wc3but;
		private System.Windows.Forms.TextBox sav3_path;
		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem exportSortedSavefileToolStripMenuItem;
		private System.Windows.Forms.Button export_wcn;
		private System.Windows.Forms.Button inject_wcn;
		private System.Windows.Forms.Button wcn_edit_but;
		private System.Windows.Forms.Button export_me3_but;
		private System.Windows.Forms.Button inject_me3_but;
		private System.Windows.Forms.Button me3_editor_but;
		private System.Windows.Forms.Button eon_em_but;
		private System.Windows.Forms.ToolStripMenuItem extraToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem enableMysteryGiftMainScreenStripMenuItem;
		private System.Windows.Forms.Button region_but;
		private System.Windows.Forms.ToolStripMenuItem fixSectionChecksumsToolStripMenuItem;
		private System.Windows.Forms.Button decor_but;
		private System.Windows.Forms.Button ect_edit_but;
		private System.Windows.Forms.Button export_ect_but;
		private System.Windows.Forms.Button inject_ect_but;
		private System.Windows.Forms.ComboBox game_box;
		private System.Windows.Forms.ComboBox language_box;
		private System.Windows.Forms.Label region_lab;
		private System.Windows.Forms.ToolStripMenuItem exportOldSaveToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
		private System.Windows.Forms.ToolStripMenuItem clearEggEventFlagToolStripMenuItem;
		private System.Windows.Forms.Button export_eberry;
		private System.Windows.Forms.Button inject_eberry;
		private System.Windows.Forms.Button ecb_edit_but;
		private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem1;
		private System.Windows.Forms.Button tvswarm_but;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.GroupBox groupBox3;
		private System.Windows.Forms.GroupBox groupBox4;
		private System.Windows.Forms.Button events_distro_but;
		
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
            this.wc3_editor_but = new System.Windows.Forms.Button();
            this.load_save_but = new System.Windows.Forms.Button();
            this.inject_wc3_but = new System.Windows.Forms.Button();
            this.export_wc3but = new System.Windows.Forms.Button();
            this.sav3_path = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exportSortedSavefileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.exportOldSaveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fixSectionChecksumsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.extraToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.enableMysteryGiftMainScreenStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clearEggEventFlagToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.export_wcn = new System.Windows.Forms.Button();
            this.inject_wcn = new System.Windows.Forms.Button();
            this.wcn_edit_but = new System.Windows.Forms.Button();
            this.export_me3_but = new System.Windows.Forms.Button();
            this.inject_me3_but = new System.Windows.Forms.Button();
            this.me3_editor_but = new System.Windows.Forms.Button();
            this.eon_em_but = new System.Windows.Forms.Button();
            this.region_but = new System.Windows.Forms.Button();
            this.decor_but = new System.Windows.Forms.Button();
            this.ect_edit_but = new System.Windows.Forms.Button();
            this.export_ect_but = new System.Windows.Forms.Button();
            this.inject_ect_but = new System.Windows.Forms.Button();
            this.game_box = new System.Windows.Forms.ComboBox();
            this.language_box = new System.Windows.Forms.ComboBox();
            this.region_lab = new System.Windows.Forms.Label();
            this.export_eberry = new System.Windows.Forms.Button();
            this.inject_eberry = new System.Windows.Forms.Button();
            this.ecb_edit_but = new System.Windows.Forms.Button();
            this.tvswarm_but = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.events_distro_but = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // wc3_editor_but
            // 
            this.wc3_editor_but.Location = new System.Drawing.Point(132, 18);
            this.wc3_editor_but.Name = "wc3_editor_but";
            this.wc3_editor_but.Size = new System.Drawing.Size(75, 48);
            this.wc3_editor_but.TabIndex = 0;
            this.wc3_editor_but.Text = "神秘卡片  编辑器";
            this.wc3_editor_but.UseVisualStyleBackColor = true;
            this.wc3_editor_but.Click += new System.EventHandler(this.Button1Click);
            // 
            // load_save_but
            // 
            this.load_save_but.Location = new System.Drawing.Point(12, 34);
            this.load_save_but.Name = "load_save_but";
            this.load_save_but.Size = new System.Drawing.Size(91, 21);
            this.load_save_but.TabIndex = 1;
            this.load_save_but.Text = "读取存档";
            this.load_save_but.UseVisualStyleBackColor = true;
            this.load_save_but.Click += new System.EventHandler(this.Load_save_butClick);
            // 
            // inject_wc3_but
            // 
            this.inject_wc3_but.Enabled = false;
            this.inject_wc3_but.Location = new System.Drawing.Point(6, 45);
            this.inject_wc3_but.Name = "inject_wc3_but";
            this.inject_wc3_but.Size = new System.Drawing.Size(120, 21);
            this.inject_wc3_but.TabIndex = 2;
            this.inject_wc3_but.Text = "配信神秘卡片";
            this.inject_wc3_but.UseVisualStyleBackColor = true;
            this.inject_wc3_but.Click += new System.EventHandler(this.Inject_wc3_butClick);
            // 
            // export_wc3but
            // 
            this.export_wc3but.Enabled = false;
            this.export_wc3but.Location = new System.Drawing.Point(6, 18);
            this.export_wc3but.Name = "export_wc3but";
            this.export_wc3but.Size = new System.Drawing.Size(120, 21);
            this.export_wc3but.TabIndex = 4;
            this.export_wc3but.Text = "导出神秘卡片";
            this.export_wc3but.UseVisualStyleBackColor = true;
            this.export_wc3but.Click += new System.EventHandler(this.Export_wc3butClick);
            // 
            // sav3_path
            // 
            this.sav3_path.Location = new System.Drawing.Point(12, 61);
            this.sav3_path.Name = "sav3_path";
            this.sav3_path.ReadOnly = true;
            this.sav3_path.Size = new System.Drawing.Size(665, 21);
            this.sav3_path.TabIndex = 5;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem,
            this.extraToolStripMenuItem,
            this.aboutToolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(687, 25);
            this.menuStrip1.TabIndex = 6;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exportSortedSavefileToolStripMenuItem,
            this.fixSectionChecksumsToolStripMenuItem});
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(44, 21);
            this.menuToolStripMenuItem.Text = "菜单";
            // 
            // exportSortedSavefileToolStripMenuItem
            // 
            this.exportSortedSavefileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.exportOldSaveToolStripMenuItem});
            this.exportSortedSavefileToolStripMenuItem.Name = "exportSortedSavefileToolStripMenuItem";
            this.exportSortedSavefileToolStripMenuItem.Size = new System.Drawing.Size(220, 22);
            this.exportSortedSavefileToolStripMenuItem.Text = "导出当前整理过的存档文件";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Enabled = false;
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(148, 22);
            this.toolStripMenuItem1.Text = "导出当前存档";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.ToolStripMenuItem1Click);
            // 
            // exportOldSaveToolStripMenuItem
            // 
            this.exportOldSaveToolStripMenuItem.Enabled = false;
            this.exportOldSaveToolStripMenuItem.Name = "exportOldSaveToolStripMenuItem";
            this.exportOldSaveToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.exportOldSaveToolStripMenuItem.Text = "导出旧存档";
            this.exportOldSaveToolStripMenuItem.Click += new System.EventHandler(this.ExportOldSaveToolStripMenuItemClick);
            // 
            // fixSectionChecksumsToolStripMenuItem
            // 
            this.fixSectionChecksumsToolStripMenuItem.Enabled = false;
            this.fixSectionChecksumsToolStripMenuItem.Name = "fixSectionChecksumsToolStripMenuItem";
            this.fixSectionChecksumsToolStripMenuItem.Size = new System.Drawing.Size(220, 22);
            this.fixSectionChecksumsToolStripMenuItem.Text = "修复区块校验和";
            this.fixSectionChecksumsToolStripMenuItem.Click += new System.EventHandler(this.FixSectionChecksumsToolStripMenuItemClick);
            // 
            // extraToolStripMenuItem
            // 
            this.extraToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.enableMysteryGiftMainScreenStripMenuItem,
            this.clearEggEventFlagToolStripMenuItem});
            this.extraToolStripMenuItem.Name = "extraToolStripMenuItem";
            this.extraToolStripMenuItem.Size = new System.Drawing.Size(44, 21);
            this.extraToolStripMenuItem.Text = "其他";
            // 
            // enableMysteryGiftMainScreenStripMenuItem
            // 
            this.enableMysteryGiftMainScreenStripMenuItem.Enabled = false;
            this.enableMysteryGiftMainScreenStripMenuItem.Name = "enableMysteryGiftMainScreenStripMenuItem";
            this.enableMysteryGiftMainScreenStripMenuItem.Size = new System.Drawing.Size(225, 22);
            this.enableMysteryGiftMainScreenStripMenuItem.Text = "开启存档神秘事件/礼物功能";
            this.enableMysteryGiftMainScreenStripMenuItem.Click += new System.EventHandler(this.EnableMysteryGiftMainScreenStripMenuItemClick);
            // 
            // clearEggEventFlagToolStripMenuItem
            // 
            this.clearEggEventFlagToolStripMenuItem.Enabled = false;
            this.clearEggEventFlagToolStripMenuItem.Name = "clearEggEventFlagToolStripMenuItem";
            this.clearEggEventFlagToolStripMenuItem.Size = new System.Drawing.Size(225, 22);
            this.clearEggEventFlagToolStripMenuItem.Text = "清除事件旗标“蛋事件”";
            this.clearEggEventFlagToolStripMenuItem.Click += new System.EventHandler(this.ClearEggEventFlagToolStripMenuItemClick);
            // 
            // aboutToolStripMenuItem1
            // 
            this.aboutToolStripMenuItem1.Name = "aboutToolStripMenuItem1";
            this.aboutToolStripMenuItem1.Size = new System.Drawing.Size(44, 21);
            this.aboutToolStripMenuItem1.Text = "关于";
            this.aboutToolStripMenuItem1.Click += new System.EventHandler(this.AboutToolStripMenuItem1Click);
            // 
            // export_wcn
            // 
            this.export_wcn.Enabled = false;
            this.export_wcn.Location = new System.Drawing.Point(6, 72);
            this.export_wcn.Name = "export_wcn";
            this.export_wcn.Size = new System.Drawing.Size(120, 21);
            this.export_wcn.TabIndex = 7;
            this.export_wcn.Text = "导出神秘新闻";
            this.export_wcn.UseVisualStyleBackColor = true;
            this.export_wcn.Click += new System.EventHandler(this.Export_wcnClick);
            // 
            // inject_wcn
            // 
            this.inject_wcn.Enabled = false;
            this.inject_wcn.Location = new System.Drawing.Point(6, 99);
            this.inject_wcn.Name = "inject_wcn";
            this.inject_wcn.Size = new System.Drawing.Size(120, 21);
            this.inject_wcn.TabIndex = 8;
            this.inject_wcn.Text = "配信神秘新闻";
            this.inject_wcn.UseVisualStyleBackColor = true;
            this.inject_wcn.Click += new System.EventHandler(this.Inject_wcnClick);
            // 
            // wcn_edit_but
            // 
            this.wcn_edit_but.Location = new System.Drawing.Point(132, 72);
            this.wcn_edit_but.Name = "wcn_edit_but";
            this.wcn_edit_but.Size = new System.Drawing.Size(75, 45);
            this.wcn_edit_but.TabIndex = 9;
            this.wcn_edit_but.Text = "神秘新闻  编辑器";
            this.wcn_edit_but.UseVisualStyleBackColor = true;
            this.wcn_edit_but.Click += new System.EventHandler(this.Wcn_edit_butClick);
            // 
            // export_me3_but
            // 
            this.export_me3_but.Enabled = false;
            this.export_me3_but.Location = new System.Drawing.Point(6, 18);
            this.export_me3_but.Name = "export_me3_but";
            this.export_me3_but.Size = new System.Drawing.Size(120, 21);
            this.export_me3_but.TabIndex = 10;
            this.export_me3_but.Text = "导出神秘事件";
            this.export_me3_but.UseVisualStyleBackColor = true;
            this.export_me3_but.Click += new System.EventHandler(this.Export_me3_butClick);
            // 
            // inject_me3_but
            // 
            this.inject_me3_but.Enabled = false;
            this.inject_me3_but.Location = new System.Drawing.Point(6, 45);
            this.inject_me3_but.Name = "inject_me3_but";
            this.inject_me3_but.Size = new System.Drawing.Size(120, 21);
            this.inject_me3_but.TabIndex = 11;
            this.inject_me3_but.Text = "配信神秘事件";
            this.inject_me3_but.UseVisualStyleBackColor = true;
            this.inject_me3_but.Click += new System.EventHandler(this.Inject_me3_butClick);
            // 
            // me3_editor_but
            // 
            this.me3_editor_but.Location = new System.Drawing.Point(132, 18);
            this.me3_editor_but.Name = "me3_editor_but";
            this.me3_editor_but.Size = new System.Drawing.Size(75, 48);
            this.me3_editor_but.TabIndex = 12;
            this.me3_editor_but.Text = "神秘事件  编辑器";
            this.me3_editor_but.UseVisualStyleBackColor = true;
            this.me3_editor_but.Click += new System.EventHandler(this.Me3_editor_butClick);
            // 
            // eon_em_but
            // 
            this.eon_em_but.Enabled = false;
            this.eon_em_but.Location = new System.Drawing.Point(6, 72);
            this.eon_em_but.Name = "eon_em_but";
            this.eon_em_but.Size = new System.Drawing.Size(120, 45);
            this.eon_em_but.TabIndex = 13;
            this.eon_em_but.Text = "无限船票\n（绿宝石）";
            this.eon_em_but.UseVisualStyleBackColor = true;
            this.eon_em_but.Click += new System.EventHandler(this.Eon_em_butClick);
            // 
            // region_but
            // 
            this.region_but.Enabled = false;
            this.region_but.Location = new System.Drawing.Point(445, 34);
            this.region_but.Name = "region_but";
            this.region_but.Size = new System.Drawing.Size(92, 21);
            this.region_but.TabIndex = 15;
            this.region_but.Text = "强制更改信息";
            this.region_but.UseVisualStyleBackColor = true;
            this.region_but.Click += new System.EventHandler(this.Region_butClick);
            // 
            // decor_but
            // 
            this.decor_but.Enabled = false;
            this.decor_but.Location = new System.Drawing.Point(6, 18);
            this.decor_but.Name = "decor_but";
            this.decor_but.Size = new System.Drawing.Size(120, 21);
            this.decor_but.TabIndex = 16;
            this.decor_but.Text = "装饰物品编辑器";
            this.decor_but.UseVisualStyleBackColor = true;
            this.decor_but.Click += new System.EventHandler(this.Decor_butClick);
            // 
            // ect_edit_but
            // 
            this.ect_edit_but.Location = new System.Drawing.Point(132, 16);
            this.ect_edit_but.Name = "ect_edit_but";
            this.ect_edit_but.Size = new System.Drawing.Size(75, 47);
            this.ect_edit_but.TabIndex = 17;
            this.ect_edit_but.Text = "e卡训练家编辑器";
            this.ect_edit_but.UseVisualStyleBackColor = true;
            this.ect_edit_but.Click += new System.EventHandler(this.Ect_edit_butClick);
            // 
            // export_ect_but
            // 
            this.export_ect_but.Enabled = false;
            this.export_ect_but.Location = new System.Drawing.Point(6, 16);
            this.export_ect_but.Name = "export_ect_but";
            this.export_ect_but.Size = new System.Drawing.Size(120, 21);
            this.export_ect_but.TabIndex = 18;
            this.export_ect_but.Text = "导出e卡训练家";
            this.export_ect_but.UseVisualStyleBackColor = true;
            this.export_ect_but.Click += new System.EventHandler(this.Export_ect_butClick);
            // 
            // inject_ect_but
            // 
            this.inject_ect_but.Enabled = false;
            this.inject_ect_but.Location = new System.Drawing.Point(6, 42);
            this.inject_ect_but.Name = "inject_ect_but";
            this.inject_ect_but.Size = new System.Drawing.Size(120, 21);
            this.inject_ect_but.TabIndex = 19;
            this.inject_ect_but.Text = "配信e卡训练家";
            this.inject_ect_but.UseVisualStyleBackColor = true;
            this.inject_ect_but.Click += new System.EventHandler(this.Inject_ect_butClick);
            // 
            // game_box
            // 
            this.game_box.Enabled = false;
            this.game_box.FormattingEnabled = true;
            this.game_box.Items.AddRange(new object[] {
            "红宝石/蓝宝石",
            "绿宝石",
            "火红/叶绿"});
            this.game_box.Location = new System.Drawing.Point(109, 36);
            this.game_box.Name = "game_box";
            this.game_box.Size = new System.Drawing.Size(149, 20);
            this.game_box.TabIndex = 21;
            this.game_box.SelectedIndexChanged += new System.EventHandler(this.Game_boxSelectedIndexChanged);
            // 
            // language_box
            // 
            this.language_box.Enabled = false;
            this.language_box.FormattingEnabled = true;
            this.language_box.Items.AddRange(new object[] {
            "日语",
            "英语",
            "法语",
            "意大利语",
            "德语",
            "韩语（未使用）",
            "西班牙语"});
            this.language_box.Location = new System.Drawing.Point(263, 36);
            this.language_box.Name = "language_box";
            this.language_box.Size = new System.Drawing.Size(121, 20);
            this.language_box.TabIndex = 22;
            this.language_box.SelectedIndexChanged += new System.EventHandler(this.Language_boxSelectedIndexChanged);
            // 
            // region_lab
            // 
            this.region_lab.Location = new System.Drawing.Point(390, 39);
            this.region_lab.Name = "region_lab";
            this.region_lab.Size = new System.Drawing.Size(55, 19);
            this.region_lab.TabIndex = 23;
            this.region_lab.Text = "区域";
            // 
            // export_eberry
            // 
            this.export_eberry.Enabled = false;
            this.export_eberry.Location = new System.Drawing.Point(6, 69);
            this.export_eberry.Name = "export_eberry";
            this.export_eberry.Size = new System.Drawing.Size(120, 21);
            this.export_eberry.TabIndex = 24;
            this.export_eberry.Text = "导出e卡树果";
            this.export_eberry.UseVisualStyleBackColor = true;
            this.export_eberry.Click += new System.EventHandler(this.Export_eberryClick);
            // 
            // inject_eberry
            // 
            this.inject_eberry.Enabled = false;
            this.inject_eberry.Location = new System.Drawing.Point(6, 96);
            this.inject_eberry.Name = "inject_eberry";
            this.inject_eberry.Size = new System.Drawing.Size(120, 21);
            this.inject_eberry.TabIndex = 25;
            this.inject_eberry.Text = "配信e卡树果";
            this.inject_eberry.UseVisualStyleBackColor = true;
            this.inject_eberry.Click += new System.EventHandler(this.Inject_eberryClick);
            // 
            // ecb_edit_but
            // 
            this.ecb_edit_but.Location = new System.Drawing.Point(132, 69);
            this.ecb_edit_but.Name = "ecb_edit_but";
            this.ecb_edit_but.Size = new System.Drawing.Size(75, 48);
            this.ecb_edit_but.TabIndex = 26;
            this.ecb_edit_but.Text = "e卡树果  编辑器";
            this.ecb_edit_but.UseVisualStyleBackColor = true;
            this.ecb_edit_but.Click += new System.EventHandler(this.Ecb_edit_butClick);
            // 
            // tvswarm_but
            // 
            this.tvswarm_but.Enabled = false;
            this.tvswarm_but.Location = new System.Drawing.Point(6, 44);
            this.tvswarm_but.Name = "tvswarm_but";
            this.tvswarm_but.Size = new System.Drawing.Size(120, 20);
            this.tvswarm_but.TabIndex = 27;
            this.tvswarm_but.Text = "电视和大量出现";
            this.tvswarm_but.UseVisualStyleBackColor = true;
            this.tvswarm_but.Click += new System.EventHandler(this.Tvswarm_butClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.wcn_edit_but);
            this.groupBox1.Controls.Add(this.inject_wcn);
            this.groupBox1.Controls.Add(this.export_wcn);
            this.groupBox1.Controls.Add(this.export_wc3but);
            this.groupBox1.Controls.Add(this.inject_wc3_but);
            this.groupBox1.Controls.Add(this.wc3_editor_but);
            this.groupBox1.Location = new System.Drawing.Point(12, 85);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(219, 126);
            this.groupBox1.TabIndex = 28;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "神秘礼物";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.export_me3_but);
            this.groupBox2.Controls.Add(this.inject_me3_but);
            this.groupBox2.Controls.Add(this.me3_editor_but);
            this.groupBox2.Controls.Add(this.eon_em_but);
            this.groupBox2.Location = new System.Drawing.Point(238, 85);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(215, 126);
            this.groupBox2.TabIndex = 29;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "神秘事件";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.ecb_edit_but);
            this.groupBox3.Controls.Add(this.inject_eberry);
            this.groupBox3.Controls.Add(this.export_eberry);
            this.groupBox3.Controls.Add(this.inject_ect_but);
            this.groupBox3.Controls.Add(this.export_ect_but);
            this.groupBox3.Controls.Add(this.ect_edit_but);
            this.groupBox3.Location = new System.Drawing.Point(459, 85);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(217, 126);
            this.groupBox3.TabIndex = 30;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "e卡训练家和e卡树果";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.tvswarm_but);
            this.groupBox4.Controls.Add(this.decor_but);
            this.groupBox4.Location = new System.Drawing.Point(12, 216);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(141, 73);
            this.groupBox4.TabIndex = 31;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "其他";
            // 
            // events_distro_but
            // 
            this.events_distro_but.Location = new System.Drawing.Point(484, 234);
            this.events_distro_but.Name = "events_distro_but";
            this.events_distro_but.Size = new System.Drawing.Size(182, 47);
            this.events_distro_but.TabIndex = 32;
            this.events_distro_but.Text = "若想直接配信\r【官方合法配信船票】\r请点击此处";
            this.events_distro_but.UseVisualStyleBackColor = true;
            this.events_distro_but.Click += new System.EventHandler(this.Events_distro_butClick);
            // 
            // label1
            // 
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(541, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(153, 25);
            this.label1.TabIndex = 34;
            this.label1.Text = "注：若版本或语言识别错误，请点击按钮进行修正。";
            // 
            // MainScreen
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(687, 292);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.events_distro_but);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.region_lab);
            this.Controls.Add(this.language_box);
            this.Controls.Add(this.game_box);
            this.Controls.Add(this.region_but);
            this.Controls.Add(this.sav3_path);
            this.Controls.Add(this.load_save_but);
            this.Controls.Add(this.menuStrip1);
            this.Name = "MainScreen";
            this.Text = "Mystery Gift Tool 0.1f by Sabresite（汉化者：卧看微尘/Wokann）";
            this.DragDrop += new System.Windows.Forms.DragEventHandler(this.MainScreenDragDrop);
            this.DragEnter += new System.Windows.Forms.DragEventHandler(this.MainScreenDragEnter);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

		}
        private System.Windows.Forms.Label label1;
    }
}
