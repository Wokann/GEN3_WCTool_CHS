﻿/*
 * Created by SharpDevelop.
 * User: suloku
 * Date: 28/04/2016
 * Time: 21:22
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace WC3Tool
{
	partial class WCN_editor
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
		private System.Windows.Forms.TextBox body5;
		private System.Windows.Forms.TextBox body1;
		private System.Windows.Forms.TextBox body2;
		private System.Windows.Forms.TextBox body3;
		private System.Windows.Forms.TextBox body4;
		private System.Windows.Forms.TextBox body6;
		private System.Windows.Forms.TextBox body7;
		private System.Windows.Forms.CheckBox distrocheck;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.ComboBox colorbox;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.Label label12;
		private System.Windows.Forms.TextBox body8;
		private System.Windows.Forms.TextBox body9;
		private System.Windows.Forms.TextBox body10;
		private System.Windows.Forms.Label regionlab;
		
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
            this.body5 = new System.Windows.Forms.TextBox();
            this.body1 = new System.Windows.Forms.TextBox();
            this.body2 = new System.Windows.Forms.TextBox();
            this.body3 = new System.Windows.Forms.TextBox();
            this.body4 = new System.Windows.Forms.TextBox();
            this.body6 = new System.Windows.Forms.TextBox();
            this.body7 = new System.Windows.Forms.TextBox();
            this.distrocheck = new System.Windows.Forms.CheckBox();
            this.colorbox = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.body8 = new System.Windows.Forms.TextBox();
            this.body9 = new System.Windows.Forms.TextBox();
            this.body10 = new System.Windows.Forms.TextBox();
            this.regionlab = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // load_wc3_but
            // 
            this.load_wc3_but.Location = new System.Drawing.Point(51, 4);
            this.load_wc3_but.Name = "load_wc3_but";
            this.load_wc3_but.Size = new System.Drawing.Size(75, 42);
            this.load_wc3_but.TabIndex = 0;
            this.load_wc3_but.Text = "读取神秘\r新闻文件";
            this.load_wc3_but.UseVisualStyleBackColor = true;
            this.load_wc3_but.Click += new System.EventHandler(this.Load_wc3_butClick);
            // 
            // save_wc3_but
            // 
            this.save_wc3_but.Enabled = false;
            this.save_wc3_but.Location = new System.Drawing.Point(130, 4);
            this.save_wc3_but.Name = "save_wc3_but";
            this.save_wc3_but.Size = new System.Drawing.Size(75, 42);
            this.save_wc3_but.TabIndex = 1;
            this.save_wc3_but.Text = "保存神秘\r新闻文件";
            this.save_wc3_but.UseVisualStyleBackColor = true;
            this.save_wc3_but.Click += new System.EventHandler(this.Save_wc3_butClick);
            // 
            // wc3_path
            // 
            this.wc3_path.Location = new System.Drawing.Point(221, 12);
            this.wc3_path.Name = "wc3_path";
            this.wc3_path.ReadOnly = true;
            this.wc3_path.Size = new System.Drawing.Size(560, 21);
            this.wc3_path.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(49, 94);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 21);
            this.label1.TabIndex = 3;
            this.label1.Text = "标题";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(49, 200);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 21);
            this.label2.TabIndex = 4;
            this.label2.Text = "正文5";
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(49, 115);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 21);
            this.label3.TabIndex = 5;
            this.label3.Text = "正文1";
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(49, 137);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 21);
            this.label4.TabIndex = 6;
            this.label4.Text = "正文2";
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(49, 158);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 21);
            this.label5.TabIndex = 7;
            this.label5.Text = "正文3";
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(49, 179);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 21);
            this.label6.TabIndex = 8;
            this.label6.Text = "正文4";
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(49, 222);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(100, 21);
            this.label7.TabIndex = 9;
            this.label7.Text = "正文6";
            // 
            // label8
            // 
            this.label8.Location = new System.Drawing.Point(49, 243);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(100, 21);
            this.label8.TabIndex = 10;
            this.label8.Text = "正文7";
            // 
            // header1
            // 
            this.header1.Location = new System.Drawing.Point(114, 91);
            this.header1.MaxLength = 40;
            this.header1.Name = "header1";
            this.header1.Size = new System.Drawing.Size(379, 21);
            this.header1.TabIndex = 11;
            this.header1.TextChanged += new System.EventHandler(this.Header1TextChanged);
            // 
            // body5
            // 
            this.body5.Location = new System.Drawing.Point(114, 198);
            this.body5.MaxLength = 40;
            this.body5.Name = "body5";
            this.body5.Size = new System.Drawing.Size(379, 21);
            this.body5.TabIndex = 16;
            this.body5.TextChanged += new System.EventHandler(this.Body5TextChanged);
            // 
            // body1
            // 
            this.body1.Location = new System.Drawing.Point(114, 113);
            this.body1.MaxLength = 40;
            this.body1.Name = "body1";
            this.body1.Size = new System.Drawing.Size(379, 21);
            this.body1.TabIndex = 12;
            this.body1.TextChanged += new System.EventHandler(this.Body1TextChanged);
            // 
            // body2
            // 
            this.body2.Location = new System.Drawing.Point(114, 134);
            this.body2.MaxLength = 40;
            this.body2.Name = "body2";
            this.body2.Size = new System.Drawing.Size(379, 21);
            this.body2.TabIndex = 13;
            this.body2.TextChanged += new System.EventHandler(this.Body2TextChanged);
            // 
            // body3
            // 
            this.body3.Location = new System.Drawing.Point(114, 155);
            this.body3.MaxLength = 40;
            this.body3.Name = "body3";
            this.body3.Size = new System.Drawing.Size(379, 21);
            this.body3.TabIndex = 14;
            this.body3.TextChanged += new System.EventHandler(this.Body3TextChanged);
            // 
            // body4
            // 
            this.body4.Location = new System.Drawing.Point(114, 176);
            this.body4.MaxLength = 40;
            this.body4.Name = "body4";
            this.body4.Size = new System.Drawing.Size(379, 21);
            this.body4.TabIndex = 15;
            this.body4.TextChanged += new System.EventHandler(this.Body4TextChanged);
            // 
            // body6
            // 
            this.body6.Location = new System.Drawing.Point(114, 219);
            this.body6.MaxLength = 40;
            this.body6.Name = "body6";
            this.body6.Size = new System.Drawing.Size(379, 21);
            this.body6.TabIndex = 17;
            this.body6.TextChanged += new System.EventHandler(this.Body6TextChanged);
            // 
            // body7
            // 
            this.body7.Location = new System.Drawing.Point(114, 240);
            this.body7.MaxLength = 40;
            this.body7.Name = "body7";
            this.body7.Size = new System.Drawing.Size(379, 21);
            this.body7.TabIndex = 18;
            this.body7.TextChanged += new System.EventHandler(this.Body7TextChanged);
            // 
            // distrocheck
            // 
            this.distrocheck.Location = new System.Drawing.Point(364, 64);
            this.distrocheck.Name = "distrocheck";
            this.distrocheck.Size = new System.Drawing.Size(118, 22);
            this.distrocheck.TabIndex = 22;
            this.distrocheck.Text = "是否可再分享";
            this.distrocheck.UseVisualStyleBackColor = true;
            // 
            // colorbox
            // 
            this.colorbox.FormattingEnabled = true;
            this.colorbox.Items.AddRange(new object[] {
            "黄色 (0x00)",
            "水晶 (0x01)",
            "红色 (0x02)",
            "绿色 (0x03)",
            "蓝色 (0x04)",
            "棕色 (0x05)",
            "金色 (0x06)",
            "银色 (0x07)"});
            this.colorbox.Location = new System.Drawing.Point(115, 54);
            this.colorbox.Name = "colorbox";
            this.colorbox.Size = new System.Drawing.Size(243, 20);
            this.colorbox.TabIndex = 25;
            this.colorbox.SelectedIndexChanged += new System.EventHandler(this.ColorboxSelectedIndexChanged);
            // 
            // label10
            // 
            this.label10.Location = new System.Drawing.Point(49, 56);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(63, 18);
            this.label10.TabIndex = 26;
            this.label10.Text = "颜色";
            // 
            // label9
            // 
            this.label9.Location = new System.Drawing.Point(49, 264);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(100, 21);
            this.label9.TabIndex = 27;
            this.label9.Text = "正文8";
            // 
            // label11
            // 
            this.label11.Location = new System.Drawing.Point(49, 285);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(100, 21);
            this.label11.TabIndex = 28;
            this.label11.Text = "正文9";
            // 
            // label12
            // 
            this.label12.Location = new System.Drawing.Point(49, 306);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(100, 21);
            this.label12.TabIndex = 29;
            this.label12.Text = "正文10";
            // 
            // body8
            // 
            this.body8.Location = new System.Drawing.Point(114, 261);
            this.body8.MaxLength = 40;
            this.body8.Name = "body8";
            this.body8.Size = new System.Drawing.Size(379, 21);
            this.body8.TabIndex = 19;
            this.body8.TextChanged += new System.EventHandler(this.Body8TextChanged);
            // 
            // body9
            // 
            this.body9.Location = new System.Drawing.Point(114, 282);
            this.body9.MaxLength = 40;
            this.body9.Name = "body9";
            this.body9.Size = new System.Drawing.Size(379, 21);
            this.body9.TabIndex = 20;
            this.body9.TextChanged += new System.EventHandler(this.Body9TextChanged);
            // 
            // body10
            // 
            this.body10.Location = new System.Drawing.Point(114, 304);
            this.body10.MaxLength = 40;
            this.body10.Name = "body10";
            this.body10.Size = new System.Drawing.Size(379, 21);
            this.body10.TabIndex = 21;
            this.body10.TextChanged += new System.EventHandler(this.Body10TextChanged);
            // 
            // regionlab
            // 
            this.regionlab.Location = new System.Drawing.Point(364, 46);
            this.regionlab.Name = "regionlab";
            this.regionlab.Size = new System.Drawing.Size(100, 15);
            this.regionlab.TabIndex = 30;
            this.regionlab.Text = "美/欧版";
            // 
            // WCN_editor
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(820, 344);
            this.Controls.Add(this.regionlab);
            this.Controls.Add(this.body10);
            this.Controls.Add(this.body9);
            this.Controls.Add(this.body8);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.colorbox);
            this.Controls.Add(this.distrocheck);
            this.Controls.Add(this.body7);
            this.Controls.Add(this.body6);
            this.Controls.Add(this.body4);
            this.Controls.Add(this.body3);
            this.Controls.Add(this.body2);
            this.Controls.Add(this.body1);
            this.Controls.Add(this.body5);
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
            this.Name = "WCN_editor";
            this.Text = "神秘新闻编辑器";
            this.Load += new System.EventHandler(this.WCN_editorLoad);
            this.DragDrop += new System.Windows.Forms.DragEventHandler(this.WCN_editorDragDrop);
            this.DragEnter += new System.Windows.Forms.DragEventHandler(this.WCN_editorDragEnter);
            this.ResumeLayout(false);
            this.PerformLayout();

		}
	}
}
