using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Runtime.CompilerServices;

namespace JSViewerCodeReports
{
	/// <summary>
	/// DeliveryNote の概要の説明です。
	/// </summary>
	public partial class DeliveryNote : GrapeCity.ActiveReports.SectionReport
	{
		DataTable table;
		int counter = 0;

		public DeliveryNote()
		{
			//
			// デザイナー サポートに必要なメソッドです。このメソッドの内容を
			//
			InitializeComponent();
		}

		private void ActiveReport_DataInitialize(object sender, EventArgs e)
		{
			table = new DataTable("Results");
			counter = 0;

			table.Columns.Add("ID", typeof(int));
			this.Fields.Add("ID");

			table.Columns.Add("CustomerID", typeof(int));
			this.Fields.Add("CustomerID");

			table.Columns.Add("CustomerName", typeof(string));
			this.Fields.Add("CustomerName");

			table.Columns.Add("Products", typeof(string));
			this.Fields.Add("Products");

			table.Columns.Add("Number", typeof(int));
			this.Fields.Add("Number");

			table.Columns.Add("UnitPrice", typeof(decimal));
			this.Fields.Add("UnitPrice");

			table.Columns.Add("Price", typeof(decimal));
			this.Fields.Add("Price");

			table.Columns.Add("BillNo", typeof(string));
			this.Fields.Add("BillNo");

			table.Columns.Add("SlipNo", typeof(string));
			this.Fields.Add("SlipNo");

			table.Columns.Add("Category", typeof(int));
			this.Fields.Add("Category");

			table.Rows.Add(new object[] { 1, 1, "長崎カントリーフーズ", "コーヒー 250 ml", 100, 100m, 10000m, "WS-DF502", "GB465", 10 });
			table.Rows.Add(new object[] { 2, 1, "長崎カントリーフーズ", "紅茶 350 ml", 300, 120m, 36000m, "WS-DF502", "GB465", 10 });
			table.Rows.Add(new object[] { 3, 1, "長崎カントリーフーズ", "炭酸飲料 (オレンジ） 350 ml", 200, 120m, 24000m, "WS-DF502", "DK055", 11 });
			table.Rows.Add(new object[] { 4, 1, "長崎カントリーフーズ", "ミルクココア 350 ml", 200, 120m, 24000m, "WS-DF502", "HB224", 14 });
			table.Rows.Add(new object[] { 5, 1, "長崎カントリーフーズ", "レモンティー 350 ml", 200, 120m, 24000m, "WS-DF502", "GB465", 11 });
			table.Rows.Add(new object[] { 6, 1, "長崎カントリーフーズ", "スポーツドリンク 350 ml", 100, 120m, 12000m, "WS-DF502", "HJ120", 11 });
			table.Rows.Add(new object[] { 7, 1, "長崎カントリーフーズ", "天然水 1.5 ﾘｯﾄﾙ", 500, 330m, 165000m, "WS-DF502", "HJ120", 11 });
			table.Rows.Add(new object[] { 8, 1, "長崎カントリーフーズ", "炭酸飲料 (グレープ） 1.5 ﾘｯﾄﾙ", 200, 330m, 66000m, "WS-DF502", "CF003", 11 });
			table.Rows.Add(new object[] { 9, 1, "長崎カントリーフーズ", "ウーロン茶 2.0 ﾘｯﾄﾙ", 150, 298m, 44700m, "WS-DF502", "BE460", 11 });
			table.Rows.Add(new object[] { 10, 1, "長崎カントリーフーズ", "緑茶 1.5 ﾘｯﾄﾙ", 100, 330m, 33000m, "WS-DF502", "OP122", 11 });
			table.Rows.Add(new object[] { 11, 1, "長崎カントリーフーズ", "炭酸飲料（レモン） 1.5 ﾘｯﾄﾙ", 350, 330m, 115500m, "WS-DF502", "OP122", 11 });
			table.Rows.Add(new object[] { 12, 1, "長崎カントリーフーズ", "スポーツドリンク 1.5 ﾘｯﾄﾙ", 100, 330m, 33000m, "WS-DF502", "LP310", 11 });
			table.Rows.Add(new object[] { 13, 1, "長崎カントリーフーズ", "100％ オレンジジュース", 350, 280m, 98000m, "WS-DF502", "ME220", 30 });
			table.Rows.Add(new object[] { 14, 1, "長崎カントリーフーズ", "100％ アップルジュース", 250, 280m, 70000m, "WS-DF502", "MG224", 30 });
			table.Rows.Add(new object[] { 15, 1, "長崎カントリーフーズ", "100％ グレープジュース", 350, 280m, 98000m, "WS-DF502", "MG224", 30 });
			table.Rows.Add(new object[] { 16, 2, "（有）デジタルノロシネット", "ボールペン (赤)", 50, 100m, 5000m, "WA-GJ419", "PI198", 11 });
			table.Rows.Add(new object[] { 17, 2, "（有）デジタルノロシネット", "ボールペン (青)", 100, 100m, 10000m, "WA-GJ419", "TA471", 11 });
			table.Rows.Add(new object[] { 18, 2, "（有）デジタルノロシネット", "付箋紙（小）", 20, 120m, 2400m, "WA-GJ419", "TA471", 11 });
			table.Rows.Add(new object[] { 19, 2, "（有）デジタルノロシネット", "A4コピー用紙", 50, 300m, 15000m, "WA-GJ419", "GB145", 11 });
			table.Rows.Add(new object[] { 20, 2, "（有）デジタルノロシネット", "B4コピー用紙", 20, 500m, 10000m, "WA-GJ419", "GB145", 11 });
			table.Rows.Add(new object[] { 21, 2, "（有）デジタルノロシネット", "ファイルA4", 5, 150m, 750m, "WA-GJ419", "HJ346", 11 });
			table.Rows.Add(new object[] { 22, 2, "（有）デジタルノロシネット", "クリアケース", 10, 200m, 2000m, "WA-GJ419", "HJ346", 11 });
			table.Rows.Add(new object[] { 23, 2, "（有）デジタルノロシネット", "クリップ", 30, 50m, 1500m, "WA-GJ419", "NB002", 14 });
			table.Rows.Add(new object[] { 24, 2, "（有）デジタルノロシネット", "インク (黒)", 1, 800m, 800m, "WA-GJ419", "IK131", 11 });
			table.Rows.Add(new object[] { 25, 2, "（有）デジタルノロシネット", "インク (赤)", 1, 800m, 800m, "WA-GJ419", "IK131", 11 });
			table.Rows.Add(new object[] { 26, 3, "昭和チクタク堂", "カーボン用紙", 1, 500m, 500m, "WQ-LM172", "CB981", 11 });
			table.Rows.Add(new object[] { 27, 3, "昭和チクタク堂", "給与封筒", 1500, 450m, 675000m, "WQ-LM172", "OP252", 11 });
			table.Rows.Add(new object[] { 28, 3, "昭和チクタク堂", "表示用シール（赤）", 10, 250m, 2500m, "WQ-LM172", "SH064", 11 });
			table.Rows.Add(new object[] { 29, 3, "昭和チクタク堂", "表示用シール（青）", 5, 250m, 1250m, "WQ-LM172", "SH064", 11 });
			table.Rows.Add(new object[] { 30, 3, "昭和チクタク堂", "表示用シール（黄）", 5, 250m, 1250m, "WQ-LM172", "SH064", 11 });
			table.Rows.Add(new object[] { 31, 3, "昭和チクタク堂", "ビデオラベル（背見出し）", 2, 500m, 1000m, "WQ-LM172", "VL661", 11 });
			table.Rows.Add(new object[] { 32, 3, "昭和チクタク堂", "ビデオラベル（正面用）", 2, 500m, 1000m, "WQ-LM172", "VL661", 11 });
			table.Rows.Add(new object[] { 33, 3, "昭和チクタク堂", "プリンタ用トナー", 10, 9000m, 90000m, "WQ-LM172", "FF103", 14 });
			table.Rows.Add(new object[] { 34, 3, "昭和チクタク堂", "住所ラベル", 15000, 500m, 7500000m, "WQ-LM172", "FF103", 14 });
			table.Rows.Add(new object[] { 35, 3, "昭和チクタク堂", "ワープロリボン（黒）", 10, 1000m, 10000m, "WQ-LM172", "LK023", 11 });
			table.Rows.Add(new object[] { 36, 3, "昭和チクタク堂", "ワープロリボン（赤）", 10, 1000m, 10000m, "WQ-LM172", "LK023", 11 });
			table.Rows.Add(new object[] { 37, 3, "昭和チクタク堂", "A4ファイル", 50, 90m, 4500m, "WQ-LM172", "HJ511", 11 });
			table.Rows.Add(new object[] { 38, 3, "昭和チクタク堂", "B4ファイル", 30, 90m, 2700m, "WQ-LM172", "HJ511", 11 });
			table.Rows.Add(new object[] { 39, 3, "昭和チクタク堂", "消しゴム", 20, 50m, 1000m, "WQ-LM172", "HJ511", 11 });
		}

		public void ActiveReport_FetchData(object sender, FetchEventArgs eArgs)
		{
			if (counter == table.Rows.Count)
			{
				eArgs.EOF = true;
				return;
			}
			else
			{
				this.Fields["ID"].Value = table.Rows[counter]["ID"];
				this.Fields["CustomerID"].Value = table.Rows[counter]["CustomerID"];
				this.Fields["CustomerName"].Value = table.Rows[counter]["CustomerName"];
				this.Fields["Products"].Value = table.Rows[counter]["Products"];
				this.Fields["Number"].Value = table.Rows[counter]["Number"];
				this.Fields["UnitPrice"].Value = table.Rows[counter]["UnitPrice"];
				this.Fields["Price"].Value = table.Rows[counter]["Price"];
				this.Fields["BillNo"].Value = table.Rows[counter]["BillNo"];
				this.Fields["SlipNo"].Value = table.Rows[counter]["SlipNo"];
				this.Fields["Category"].Value = table.Rows[counter]["Category"];
				counter++;

				eArgs.EOF = false;
			}
		}
	}
}
