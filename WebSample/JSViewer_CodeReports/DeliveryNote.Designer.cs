using System.IO;
using System.Reflection;

namespace JSViewerCodeReports
{
    /// <summary>
    /// NewActiveReport1 の概要の説明です。
    /// </summary>
    partial class DeliveryNote
    {

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
            }
            base.Dispose(disposing);
        }

        #region ActiveReports デザイナーで生成されたコード
        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DeliveryNote));
            GrapeCity.ActiveReports.Data.OleDBDataSource oleDBDataSource1 = new GrapeCity.ActiveReports.Data.OleDBDataSource();
            this.Detail = new GrapeCity.ActiveReports.SectionReportModel.Detail();
            this.txtProductID = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
            this.txtProductName = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
            this.txtQuantity = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
            this.txtUnitPrice = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
            this.Line6 = new GrapeCity.ActiveReports.SectionReportModel.Line();
            this.txtSubTotal = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
            this.PageHeader1 = new GrapeCity.ActiveReports.SectionReportModel.PageHeader();
            this.PageFooter1 = new GrapeCity.ActiveReports.SectionReportModel.PageFooter();
            this.GroupHeader1 = new GrapeCity.ActiveReports.SectionReportModel.GroupHeader();
            this.Picture1 = new GrapeCity.ActiveReports.SectionReportModel.Picture();
            this.Picture2 = new GrapeCity.ActiveReports.SectionReportModel.Picture();
            this.TextBox5 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
            this.lblTitle = new GrapeCity.ActiveReports.SectionReportModel.Label();
            this.Label1 = new GrapeCity.ActiveReports.SectionReportModel.Label();
            this.Label2 = new GrapeCity.ActiveReports.SectionReportModel.Label();
            this.Label3 = new GrapeCity.ActiveReports.SectionReportModel.Label();
            this.Label4 = new GrapeCity.ActiveReports.SectionReportModel.Label();
            this.Label5 = new GrapeCity.ActiveReports.SectionReportModel.Label();
            this.txtName = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
            this.Label6 = new GrapeCity.ActiveReports.SectionReportModel.Label();
            this.txtCustomerID = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
            this.TextBox1 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
            this.TextBox2 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
            this.TextBox3 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
            this.TextBox4 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
            this.CrossSectionBox1 = new GrapeCity.ActiveReports.SectionReportModel.CrossSectionBox();
            this.CrossSectionLine1 = new GrapeCity.ActiveReports.SectionReportModel.CrossSectionLine();
            this.CrossSectionLine2 = new GrapeCity.ActiveReports.SectionReportModel.CrossSectionLine();
            this.CrossSectionLine3 = new GrapeCity.ActiveReports.SectionReportModel.CrossSectionLine();
            this.Line2 = new GrapeCity.ActiveReports.SectionReportModel.Line();
            this.CrossSectionLine4 = new GrapeCity.ActiveReports.SectionReportModel.CrossSectionLine();
            this.Line3 = new GrapeCity.ActiveReports.SectionReportModel.Line();
            this.Label7 = new GrapeCity.ActiveReports.SectionReportModel.Label();
            this.Line1 = new GrapeCity.ActiveReports.SectionReportModel.Line();
            this.GroupFooter1 = new GrapeCity.ActiveReports.SectionReportModel.GroupFooter();
            this.txtTax = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
            this.lblTotal = new GrapeCity.ActiveReports.SectionReportModel.Label();
            this.txtUnitPriceTotal = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
            this.TextBox7 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
            this.Field1 = new GrapeCity.ActiveReports.Data.Field();
            this.line4 = new GrapeCity.ActiveReports.SectionReportModel.Line();
            ((System.ComponentModel.ISupportInitialize)(this.txtProductID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtProductName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtQuantity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUnitPrice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSubTotal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Picture1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Picture2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TextBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblTitle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Label1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Label2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Label3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Label4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Label5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Label6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCustomerID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TextBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TextBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TextBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TextBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Label7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTax)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblTotal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUnitPriceTotal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TextBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            // 
            // Detail
            // 
            this.Detail.CanGrow = false;
            this.Detail.Controls.AddRange(new GrapeCity.ActiveReports.SectionReportModel.ARControl[] {
            this.txtProductID,
            this.txtProductName,
            this.txtQuantity,
            this.txtUnitPrice,
            this.txtSubTotal,
            this.Line6});
            this.Detail.Height = 0.3937007F;
            this.Detail.KeepTogether = true;
            this.Detail.Name = "Detail";
            this.Detail.RepeatToFill = true;
            // 
            // txtProductID
            // 
            this.txtProductID.CanGrow = false;
            this.txtProductID.DataField = "SlipNo";
            this.txtProductID.Height = 0.3937007F;
            this.txtProductID.Left = 0.07874014F;
            this.txtProductID.Name = "txtProductID";
            this.txtProductID.Style = "font-family: メイリオ; font-size: 8.25pt; text-align: center; vertical-align: middle;" +
    " ddo-char-set: 128";
            this.txtProductID.Text = "ProductID";
            this.txtProductID.Top = 0F;
            this.txtProductID.Width = 0.7874014F;
            // 
            // txtProductName
            // 
            this.txtProductName.CanGrow = false;
            this.txtProductName.DataField = "Products";
            this.txtProductName.Height = 0.3937007F;
            this.txtProductName.Left = 0.8661417F;
            this.txtProductName.Name = "txtProductName";
            this.txtProductName.Padding = new GrapeCity.ActiveReports.PaddingEx(5, 0, 0, 0);
            this.txtProductName.Style = "font-family: メイリオ; font-size: 8.25pt; vertical-align: middle; ddo-char-set: 128";
            this.txtProductName.Text = "Products";
            this.txtProductName.Top = 0F;
            this.txtProductName.Width = 2.677165F;
            // 
            // txtQuantity
            // 
            this.txtQuantity.CanGrow = false;
            this.txtQuantity.DataField = "Number";
            this.txtQuantity.Height = 0.3937007F;
            this.txtQuantity.Left = 3.543307F;
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.OutputFormat = "#,##0";
            this.txtQuantity.Style = "font-family: メイリオ; font-size: 8.25pt; text-align: center; vertical-align: middle;" +
    " ddo-char-set: 128";
            this.txtQuantity.Text = "Number";
            this.txtQuantity.Top = 0F;
            this.txtQuantity.Width = 0.7874014F;
            // 
            // txtUnitPrice
            // 
            this.txtUnitPrice.CanGrow = false;
            this.txtUnitPrice.DataField = "UnitPrice";
            this.txtUnitPrice.Height = 0.3937007F;
            this.txtUnitPrice.Left = 4.330709F;
            this.txtUnitPrice.Name = "txtUnitPrice";
            this.txtUnitPrice.OutputFormat = "¥#,##0";
            this.txtUnitPrice.Padding = new GrapeCity.ActiveReports.PaddingEx(0, 0, 5, 0);
            this.txtUnitPrice.Style = "font-family: メイリオ; font-size: 8.25pt; text-align: right; vertical-align: middle; " +
    "ddo-char-set: 128";
            this.txtUnitPrice.Text = "UnitPrice";
            this.txtUnitPrice.Top = 0F;
            this.txtUnitPrice.Width = 0.7874014F;
            // 
            // Line6
            // 
            this.Line6.Height = 0F;
            this.Line6.Left = 0.07874014F;
            this.Line6.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(179)))), ((int)(((byte)(113)))));
            this.Line6.LineWeight = 1F;
            this.Line6.Name = "Line6";
            this.Line6.Top = 0.3937007F;
            this.Line6.Width = 6.141732F;
            this.Line6.X1 = 6.220472F;
            this.Line6.X2 = 0.07874014F;
            this.Line6.Y1 = 0.3937007F;
            this.Line6.Y2 = 0.3937007F;
            // 
            // txtSubTotal
            // 
            this.txtSubTotal.CanGrow = false;
            this.txtSubTotal.DataField = "Field1";
            this.txtSubTotal.Height = 0.3937007F;
            this.txtSubTotal.Left = 5.118111F;
            this.txtSubTotal.Name = "txtSubTotal";
            this.txtSubTotal.OutputFormat = "¥#,##0";
            this.txtSubTotal.Padding = new GrapeCity.ActiveReports.PaddingEx(0, 0, 5, 0);
            this.txtSubTotal.Style = "font-family: メイリオ; font-size: 8.25pt; text-align: right; vertical-align: middle; " +
    "ddo-char-set: 128";
            this.txtSubTotal.Text = "SubTotal";
            this.txtSubTotal.Top = 0F;
            this.txtSubTotal.Width = 1.102362F;
            // 
            // PageHeader1
            // 
            this.PageHeader1.Height = 0F;
            this.PageHeader1.Name = "PageHeader1";
            // 
            // PageFooter1
            // 
            this.PageFooter1.Height = 0F;
            this.PageFooter1.Name = "PageFooter1";
            // 
            // GroupHeader1
            // 
            this.GroupHeader1.CanGrow = false;
            this.GroupHeader1.Controls.AddRange(new GrapeCity.ActiveReports.SectionReportModel.ARControl[] {
            this.Picture1,
            this.Picture2,
            this.TextBox5,
            this.lblTitle,
            this.Label1,
            this.Label2,
            this.Label3,
            this.Label4,
            this.Label5,
            this.txtName,
            this.Label6,
            this.txtCustomerID,
            this.TextBox1,
            this.TextBox2,
            this.TextBox3,
            this.TextBox4,
            this.CrossSectionBox1,
            this.CrossSectionLine1,
            this.CrossSectionLine2,
            this.CrossSectionLine3,
            this.Line2,
            this.CrossSectionLine4,
            this.Line3,
            this.Label7,
            this.Line1});
            this.GroupHeader1.DataField = "CustomerID";
            this.GroupHeader1.Height = 3.149606F;
            this.GroupHeader1.Name = "GroupHeader1";
            this.GroupHeader1.RepeatStyle = GrapeCity.ActiveReports.SectionReportModel.RepeatStyle.OnPage;
            // 
            // Picture1
            // 
            this.Picture1.Height = 0.472441F;
            this.Picture1.HyperLink = null;
            this.Picture1.Left = 0F;
            this.Picture1.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.Picture1.Name = "Picture1";
            this.Picture1.SizeMode = GrapeCity.ActiveReports.SectionReportModel.SizeModes.Zoom;
            this.Picture1.Top = 0F;
            this.Picture1.Width = 3.149606F;
            // 
            // Picture2
            // 
            this.Picture2.Height = 0.551181F;
            this.Picture2.HyperLink = null;
            this.Picture2.Left = 3.385827F;
            this.Picture2.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.Picture2.Name = "Picture2";
            this.Picture2.SizeMode = GrapeCity.ActiveReports.SectionReportModel.SizeModes.Zoom;
            this.Picture2.Top = 0.551181F;
            this.Picture2.Width = 2.755905F;
            // 
            // TextBox5
            // 
            this.TextBox5.Height = 0.3937007F;
            this.TextBox5.Left = 5.118111F;
            this.TextBox5.Name = "TextBox5";
            this.TextBox5.Padding = new GrapeCity.ActiveReports.PaddingEx(10, 0, 10, 0);
            this.TextBox5.Style = "background-color: Honeydew; color: MediumSeaGreen; font-family: メイリオ; font-size: " +
    "9.75pt; font-weight: bold; text-align: justify; text-justify: distribute-all-lin" +
    "es; vertical-align: middle";
            this.TextBox5.Text = "小計";
            this.TextBox5.Top = 2.755905F;
            this.TextBox5.Width = 1.102362F;
            // 
            // lblTitle
            // 
            this.lblTitle.Border.BottomColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(179)))), ((int)(((byte)(113)))));
            this.lblTitle.Border.BottomStyle = GrapeCity.ActiveReports.BorderLineStyle.ExtraThickSolid;
            this.lblTitle.Border.TopColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(179)))), ((int)(((byte)(113)))));
            this.lblTitle.Border.TopStyle = GrapeCity.ActiveReports.BorderLineStyle.ExtraThickSolid;
            this.lblTitle.Height = 0.3937007F;
            this.lblTitle.HyperLink = null;
            this.lblTitle.Left = 3.543307F;
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Style = "background-color: Honeydew; color: MediumSeaGreen; font-family: メイリオ; font-size: " +
    "18pt; font-weight: bold; text-align: center; vertical-align: middle";
            this.lblTitle.Text = "納品書";
            this.lblTitle.Top = 0.07874014F;
            this.lblTitle.Width = 2.677165F;
            // 
            // Label1
            // 
            this.Label1.Height = 0.1968504F;
            this.Label1.HyperLink = null;
            this.Label1.Left = 4.330709F;
            this.Label1.Name = "Label1";
            this.Label1.Style = "font-family: メイリオ; font-size: 8.25pt";
            this.Label1.Text = "仙台市 泉区 紫山3-1-4";
            this.Label1.Top = 0.9842521F;
            this.Label1.Width = 1.889764F;
            // 
            // Label2
            // 
            this.Label2.Height = 0.1968504F;
            this.Label2.HyperLink = null;
            this.Label2.Left = 4.330709F;
            this.Label2.Name = "Label2";
            this.Label2.Style = "font-family: メイリオ; font-size: 8.25pt";
            this.Label2.Text = "〒981-3205";
            this.Label2.Top = 1.181102F;
            this.Label2.Width = 1.889764F;
            // 
            // Label3
            // 
            this.Label3.Height = 0.1968504F;
            this.Label3.HyperLink = null;
            this.Label3.Left = 4.330709F;
            this.Label3.Name = "Label3";
            this.Label3.Style = "font-family: メイリオ; font-size: 8.25pt";
            this.Label3.Text = "phone: 022-777-8210";
            this.Label3.Top = 1.377953F;
            this.Label3.Width = 1.889764F;
            // 
            // Label4
            // 
            this.Label4.Height = 0.1968504F;
            this.Label4.HyperLink = null;
            this.Label4.Left = 4.330709F;
            this.Label4.Name = "Label4";
            this.Label4.Style = "font-family: メイリオ; font-size: 8.25pt";
            this.Label4.Text = "fax: 022-777-8231";
            this.Label4.Top = 1.574803F;
            this.Label4.Width = 1.889764F;
            // 
            // Label5
            // 
            this.Label5.Height = 0.1968504F;
            this.Label5.HyperLink = "https://developer.mescius.jp/";
            this.Label5.Left = 4.330709F;
            this.Label5.Name = "Label5";
            this.Label5.Style = "font-family: メイリオ; font-size: 8.25pt; font-weight: normal; ddo-char-set: 128";
            this.Label5.Text = "https://developer.mescius.jp/";
            this.Label5.Top = 1.771653F;
            this.Label5.Width = 1.889764F;
            // 
            // txtName
            // 
            this.txtName.DataField = "CustomerName";
            this.txtName.Height = 0.472441F;
            this.txtName.Left = 0.07874014F;
            this.txtName.Name = "txtName";
            this.txtName.Padding = new GrapeCity.ActiveReports.PaddingEx(8, 8, 0, 0);
            this.txtName.Style = "font-family: メイリオ; font-size: 12pt; ddo-char-set: 128";
            this.txtName.Text = "CustomerName";
            this.txtName.Top = 1.023622F;
            this.txtName.Width = 2.755905F;
            // 
            // Label6
            // 
            this.Label6.Height = 0.2362205F;
            this.Label6.HyperLink = null;
            this.Label6.Left = 0.07874014F;
            this.Label6.Name = "Label6";
            this.Label6.Style = "font-family: メイリオ; font-size: 8.25pt";
            this.Label6.Text = "お客様コード：";
            this.Label6.Top = 1.653543F;
            this.Label6.Width = 1.023622F;
            // 
            // txtCustomerID
            // 
            this.txtCustomerID.DataField = "CustomerID";
            this.txtCustomerID.Height = 0.2362205F;
            this.txtCustomerID.Left = 1.102362F;
            this.txtCustomerID.Name = "txtCustomerID";
            this.txtCustomerID.Style = "font-family: メイリオ; font-size: 8.25pt";
            this.txtCustomerID.Text = "CustomerID";
            this.txtCustomerID.Top = 1.653543F;
            this.txtCustomerID.Width = 1.181102F;
            // 
            // TextBox1
            // 
            this.TextBox1.Height = 0.3937007F;
            this.TextBox1.Left = 0.07874014F;
            this.TextBox1.Name = "TextBox1";
            this.TextBox1.Padding = new GrapeCity.ActiveReports.PaddingEx(4, 0, 4, 0);
            this.TextBox1.Style = resources.GetString("TextBox1.Style");
            this.TextBox1.Text = "伝票番号";
            this.TextBox1.Top = 2.755905F;
            this.TextBox1.Width = 0.7874014F;
            // 
            // TextBox2
            // 
            this.TextBox2.Height = 0.3937007F;
            this.TextBox2.Left = 0.8661417F;
            this.TextBox2.Name = "TextBox2";
            this.TextBox2.Padding = new GrapeCity.ActiveReports.PaddingEx(30, 0, 30, 0);
            this.TextBox2.Style = "background-color: Honeydew; color: MediumSeaGreen; font-family: メイリオ; font-size: " +
    "9.75pt; font-weight: bold; text-align: justify; text-justify: distribute-all-lin" +
    "es; vertical-align: middle";
            this.TextBox2.Text = "製品名";
            this.TextBox2.Top = 2.755905F;
            this.TextBox2.Width = 2.677165F;
            // 
            // TextBox3
            // 
            this.TextBox3.Height = 0.3937007F;
            this.TextBox3.Left = 3.543307F;
            this.TextBox3.Name = "TextBox3";
            this.TextBox3.Padding = new GrapeCity.ActiveReports.PaddingEx(10, 0, 10, 0);
            this.TextBox3.Style = "background-color: Honeydew; color: MediumSeaGreen; font-family: メイリオ; font-size: " +
    "9.75pt; font-weight: bold; text-align: justify; text-justify: distribute-all-lin" +
    "es; vertical-align: middle";
            this.TextBox3.Text = "数量";
            this.TextBox3.Top = 2.755905F;
            this.TextBox3.Width = 0.7874014F;
            // 
            // TextBox4
            // 
            this.TextBox4.Height = 0.3937007F;
            this.TextBox4.Left = 4.330709F;
            this.TextBox4.Name = "TextBox4";
            this.TextBox4.Padding = new GrapeCity.ActiveReports.PaddingEx(10, 0, 10, 0);
            this.TextBox4.Style = "background-color: Honeydew; color: MediumSeaGreen; font-family: メイリオ; font-size: " +
    "9.75pt; font-weight: bold; text-align: justify; text-justify: distribute-all-lin" +
    "es; vertical-align: middle";
            this.TextBox4.Text = "単価";
            this.TextBox4.Top = 2.755905F;
            this.TextBox4.Width = 0.7874014F;
            // 
            // CrossSectionBox1
            // 
            this.CrossSectionBox1.Bottom = 0.472441F;
            this.CrossSectionBox1.CloseBorder = true;
            this.CrossSectionBox1.Left = 0.07874014F;
            this.CrossSectionBox1.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(179)))), ((int)(((byte)(113)))));
            this.CrossSectionBox1.LineWeight = 5F;
            this.CrossSectionBox1.Name = "CrossSectionBox1";
            this.CrossSectionBox1.Radius = new GrapeCity.ActiveReports.Controls.CornersRadius(0F, null, null, null, null);
            this.CrossSectionBox1.Right = 6.220472F;
            this.CrossSectionBox1.Top = 2.755905F;
            // 
            // CrossSectionLine1
            // 
            this.CrossSectionLine1.Bottom = 0F;
            this.CrossSectionLine1.Left = 0.8661417F;
            this.CrossSectionLine1.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(179)))), ((int)(((byte)(113)))));
            this.CrossSectionLine1.LineWeight = 1F;
            this.CrossSectionLine1.Name = "CrossSectionLine1";
            this.CrossSectionLine1.Top = 2.755905F;
            // 
            // CrossSectionLine2
            // 
            this.CrossSectionLine2.Bottom = 0F;
            this.CrossSectionLine2.Left = 3.543307F;
            this.CrossSectionLine2.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(179)))), ((int)(((byte)(113)))));
            this.CrossSectionLine2.LineWeight = 1F;
            this.CrossSectionLine2.Name = "CrossSectionLine2";
            this.CrossSectionLine2.Top = 2.755905F;
            // 
            // CrossSectionLine3
            // 
            this.CrossSectionLine3.Bottom = 0.472441F;
            this.CrossSectionLine3.Left = 4.330709F;
            this.CrossSectionLine3.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(179)))), ((int)(((byte)(113)))));
            this.CrossSectionLine3.LineWeight = 1F;
            this.CrossSectionLine3.Name = "CrossSectionLine3";
            this.CrossSectionLine3.Top = 2.755905F;
            // 
            // Line2
            // 
            this.Line2.Height = 0F;
            this.Line2.Left = 0.07874014F;
            this.Line2.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(179)))), ((int)(((byte)(113)))));
            this.Line2.LineWeight = 1F;
            this.Line2.Name = "Line2";
            this.Line2.Top = 3.133858F;
            this.Line2.Width = 6.141732F;
            this.Line2.X1 = 0.07874014F;
            this.Line2.X2 = 6.220472F;
            this.Line2.Y1 = 3.133858F;
            this.Line2.Y2 = 3.133858F;
            // 
            // CrossSectionLine4
            // 
            this.CrossSectionLine4.Bottom = 0.472441F;
            this.CrossSectionLine4.Left = 5.118111F;
            this.CrossSectionLine4.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(179)))), ((int)(((byte)(113)))));
            this.CrossSectionLine4.LineWeight = 1F;
            this.CrossSectionLine4.Name = "CrossSectionLine4";
            this.CrossSectionLine4.Top = 2.755905F;
            // 
            // Line3
            // 
            this.Line3.Height = 0F;
            this.Line3.Left = 0.07874014F;
            this.Line3.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(179)))), ((int)(((byte)(113)))));
            this.Line3.LineWeight = 1F;
            this.Line3.Name = "Line3";
            this.Line3.Top = 3.110236F;
            this.Line3.Width = 6.141732F;
            this.Line3.X1 = 0.07874014F;
            this.Line3.X2 = 6.220472F;
            this.Line3.Y1 = 3.110236F;
            this.Line3.Y2 = 3.110236F;
            // 
            // Label7
            // 
            this.Label7.Height = 0.472441F;
            this.Label7.HyperLink = null;
            this.Label7.Left = 2.834646F;
            this.Label7.Name = "Label7";
            this.Label7.Style = "font-family: メイリオ; font-size: 14.25pt; text-align: center; vertical-align: middle" +
    "";
            this.Label7.Text = "様";
            this.Label7.Top = 1.023622F;
            this.Label7.Width = 0.3937007F;
            // 
            // Line1
            // 
            this.Line1.Height = 0F;
            this.Line1.Left = 0.07874014F;
            this.Line1.LineStyle = GrapeCity.ActiveReports.SectionReportModel.LineStyle.Double;
            this.Line1.LineWeight = 8F;
            this.Line1.Name = "Line1";
            this.Line1.Top = 1.496063F;
            this.Line1.Width = 3.149606F;
            this.Line1.X1 = 0.07874014F;
            this.Line1.X2 = 3.228346F;
            this.Line1.Y1 = 1.496063F;
            this.Line1.Y2 = 1.496063F;
            // 
            // GroupFooter1
            // 
            this.GroupFooter1.Controls.AddRange(new GrapeCity.ActiveReports.SectionReportModel.ARControl[] {
            this.txtTax,
            this.lblTotal,
            this.txtUnitPriceTotal,
            this.TextBox7,
            this.line4});
            this.GroupFooter1.Height = 1.181102F;
            this.GroupFooter1.Name = "GroupFooter1";
            this.GroupFooter1.NewPage = GrapeCity.ActiveReports.SectionReportModel.NewPage.After;
            // 
            // txtTax
            // 
            this.txtTax.DataField = "Number";
            this.txtTax.Height = 0.472441F;
            this.txtTax.Left = 3.543307F;
            this.txtTax.Name = "txtTax";
            this.txtTax.OutputFormat = "#,##0";
            this.txtTax.Style = "background-color: Honeydew; font-family: メイリオ; font-size: 9.75pt; text-align: cen" +
    "ter; vertical-align: middle";
            this.txtTax.SummaryGroup = "GroupHeader1";
            this.txtTax.SummaryRunning = GrapeCity.ActiveReports.SectionReportModel.SummaryRunning.Group;
            this.txtTax.SummaryType = GrapeCity.ActiveReports.SectionReportModel.SummaryType.SubTotal;
            this.txtTax.Text = "Q Total";
            this.txtTax.Top = 0F;
            this.txtTax.Width = 0.7874014F;
            // 
            // lblTotal
            // 
            this.lblTotal.Height = 0.472441F;
            this.lblTotal.HyperLink = null;
            this.lblTotal.Left = 0.07874014F;
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Style = "background-color: MediumSeaGreen; color: White; font-family: メイリオ; font-size: 14." +
    "25pt; font-weight: bold; text-align: center; text-justify: auto; vertical-align:" +
    " middle";
            this.lblTotal.Text = "合　計";
            this.lblTotal.Top = 0F;
            this.lblTotal.Width = 3.464567F;
            // 
            // txtUnitPriceTotal
            // 
            this.txtUnitPriceTotal.Height = 0.472441F;
            this.txtUnitPriceTotal.Left = 4.330709F;
            this.txtUnitPriceTotal.Name = "txtUnitPriceTotal";
            this.txtUnitPriceTotal.Padding = new GrapeCity.ActiveReports.PaddingEx(0, 0, 5, 0);
            this.txtUnitPriceTotal.Style = "background-color: Gainsboro; font-family: メイリオ; font-size: 9.75pt; text-align: ri" +
    "ght; vertical-align: middle";
            this.txtUnitPriceTotal.Text = null;
            this.txtUnitPriceTotal.Top = 0F;
            this.txtUnitPriceTotal.Width = 0.7874014F;
            // 
            // TextBox7
            // 
            this.TextBox7.DataField = "Field1";
            this.TextBox7.Height = 0.472441F;
            this.TextBox7.Left = 5.118111F;
            this.TextBox7.Name = "TextBox7";
            this.TextBox7.OutputFormat = "¥#,##0";
            this.TextBox7.Padding = new GrapeCity.ActiveReports.PaddingEx(0, 0, 5, 0);
            this.TextBox7.Style = "background-color: Honeydew; font-family: メイリオ; font-size: 9.75pt; text-align: rig" +
    "ht; vertical-align: middle";
            this.TextBox7.SummaryGroup = "GroupHeader1";
            this.TextBox7.SummaryRunning = GrapeCity.ActiveReports.SectionReportModel.SummaryRunning.Group;
            this.TextBox7.SummaryType = GrapeCity.ActiveReports.SectionReportModel.SummaryType.SubTotal;
            this.TextBox7.Text = "P Total";
            this.TextBox7.Top = 0F;
            this.TextBox7.Width = 1.102362F;
            // 
            // Field1
            // 
            this.Field1.DefaultValue = null;
            this.Field1.FieldType = GrapeCity.ActiveReports.Data.FieldTypeEnum.None;
            this.Field1.Formula = "=Number * UnitPrice";
            this.Field1.Name = "Field1";
            this.Field1.Tag = null;
            // 
            // line4
            // 
            this.line4.Height = 0F;
            this.line4.Left = 0.07874036F;
            this.line4.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(179)))), ((int)(((byte)(113)))));
            this.line4.LineWeight = 1F;
            this.line4.Name = "line4";
            this.line4.Top = 0F;
            this.line4.Width = 6.141731F;
            this.line4.X1 = 6.220471F;
            this.line4.X2 = 0.07874036F;
            this.line4.Y1 = 0F;
            this.line4.Y2 = 0F;
            // 
            // SectionReport1
            // 
            this.MasterReport = false;
            this.CalculatedFields.Add(this.Field1);
            this.CompatibilityMode = GrapeCity.ActiveReports.Document.CompatibilityModes.CrossPlatform;
            this.PageSettings.DefaultPaperSize = false;
            this.PageSettings.Margins.Bottom = 0.3937007F;
            this.PageSettings.Margins.Left = 0.984252F;
            this.PageSettings.Margins.Right = 0.3937007F;
            this.PageSettings.Margins.Top = 0.984252F;
            this.PageSettings.PaperHeight = 11.69291F;
            this.PageSettings.PaperKind = GrapeCity.ActiveReports.Printing.PaperKind.A4;
            this.PageSettings.PaperWidth = 8.267716F;
            this.PrintWidth = 6.299212F;
            this.Sections.Add(this.PageHeader1);
            this.Sections.Add(this.GroupHeader1);
            this.Sections.Add(this.Detail);
            this.Sections.Add(this.GroupFooter1);
            this.Sections.Add(this.PageFooter1);
            this.StyleSheet.Add(new DDCssLib.StyleSheetRule(resources.GetString("$this.StyleSheet"), "Normal"));
            this.StyleSheet.Add(new DDCssLib.StyleSheetRule("font-family: inherit; font-style: inherit; font-variant: inherit; font-weight: bo" +
            "ld; font-size: 16pt; font-size-adjust: inherit; font-stretch: inherit", "Heading1", "Normal"));
            this.StyleSheet.Add(new DDCssLib.StyleSheetRule("font-family: Times New Roman; font-style: italic; font-variant: inherit; font-wei" +
            "ght: bold; font-size: 14pt; font-size-adjust: inherit; font-stretch: inherit", "Heading2", "Normal"));
            this.StyleSheet.Add(new DDCssLib.StyleSheetRule("font-family: inherit; font-style: inherit; font-variant: inherit; font-weight: bo" +
            "ld; font-size: 13pt; font-size-adjust: inherit; font-stretch: inherit", "Heading3", "Normal"));
            this.StyleSheet.Add(new DDCssLib.StyleSheetRule("", "Heading4"));
            this.FetchData += new GrapeCity.ActiveReports.SectionReport.FetchEventHandler(this.ActiveReport_FetchData);
            this.DataInitialize += new System.EventHandler(this.ActiveReport_DataInitialize);
            ((System.ComponentModel.ISupportInitialize)(this.txtProductID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtProductName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtQuantity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUnitPrice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSubTotal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Picture1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Picture2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TextBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblTitle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Label1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Label2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Label3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Label4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Label5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Label6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCustomerID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TextBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TextBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TextBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TextBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Label7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTax)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblTotal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUnitPriceTotal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TextBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();

        }
        #endregion

        private GrapeCity.ActiveReports.SectionReportModel.Detail Detail;
        private GrapeCity.ActiveReports.SectionReportModel.TextBox txtProductID;
        private GrapeCity.ActiveReports.SectionReportModel.TextBox txtProductName;
        private GrapeCity.ActiveReports.SectionReportModel.TextBox txtQuantity;
        private GrapeCity.ActiveReports.SectionReportModel.TextBox txtUnitPrice;
        private GrapeCity.ActiveReports.SectionReportModel.Line Line6;
        private GrapeCity.ActiveReports.SectionReportModel.TextBox txtSubTotal;
        private GrapeCity.ActiveReports.SectionReportModel.PageHeader PageHeader1;
        private GrapeCity.ActiveReports.SectionReportModel.PageFooter PageFooter1;
        private GrapeCity.ActiveReports.SectionReportModel.GroupHeader GroupHeader1;
        private GrapeCity.ActiveReports.SectionReportModel.Picture Picture1;
        private GrapeCity.ActiveReports.SectionReportModel.Picture Picture2;
        private GrapeCity.ActiveReports.SectionReportModel.TextBox TextBox5;
        private GrapeCity.ActiveReports.SectionReportModel.Label lblTitle;
        private GrapeCity.ActiveReports.SectionReportModel.Label Label1;
        private GrapeCity.ActiveReports.SectionReportModel.Label Label2;
        private GrapeCity.ActiveReports.SectionReportModel.Label Label3;
        private GrapeCity.ActiveReports.SectionReportModel.Label Label4;
        private GrapeCity.ActiveReports.SectionReportModel.Label Label5;
        private GrapeCity.ActiveReports.SectionReportModel.TextBox txtName;
        private GrapeCity.ActiveReports.SectionReportModel.Label Label6;
        private GrapeCity.ActiveReports.SectionReportModel.TextBox txtCustomerID;
        private GrapeCity.ActiveReports.SectionReportModel.TextBox TextBox1;
        private GrapeCity.ActiveReports.SectionReportModel.TextBox TextBox2;
        private GrapeCity.ActiveReports.SectionReportModel.TextBox TextBox3;
        private GrapeCity.ActiveReports.SectionReportModel.TextBox TextBox4;
        private GrapeCity.ActiveReports.SectionReportModel.CrossSectionBox CrossSectionBox1;
        private GrapeCity.ActiveReports.SectionReportModel.CrossSectionLine CrossSectionLine1;
        private GrapeCity.ActiveReports.SectionReportModel.CrossSectionLine CrossSectionLine2;
        private GrapeCity.ActiveReports.SectionReportModel.CrossSectionLine CrossSectionLine3;
        private GrapeCity.ActiveReports.SectionReportModel.Line Line2;
        private GrapeCity.ActiveReports.SectionReportModel.CrossSectionLine CrossSectionLine4;
        private GrapeCity.ActiveReports.SectionReportModel.Line Line3;
        private GrapeCity.ActiveReports.SectionReportModel.Label Label7;
        private GrapeCity.ActiveReports.SectionReportModel.Line Line1;
        private GrapeCity.ActiveReports.SectionReportModel.GroupFooter GroupFooter1;
        private GrapeCity.ActiveReports.SectionReportModel.TextBox txtTax;
        private GrapeCity.ActiveReports.SectionReportModel.Label lblTotal;
        private GrapeCity.ActiveReports.SectionReportModel.TextBox txtUnitPriceTotal;
        private GrapeCity.ActiveReports.SectionReportModel.TextBox TextBox7;
        private GrapeCity.ActiveReports.Data.Field Field1;
        private GrapeCity.ActiveReports.SectionReportModel.Line line4;
    }
}
