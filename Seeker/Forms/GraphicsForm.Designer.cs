
namespace Seeker
{
    partial class GraphicsForm
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GraphicsForm));
            this.menuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.cancelBtn = new System.Windows.Forms.ToolStripMenuItem();
            this.closeBoundary = new System.Windows.Forms.ToolStripMenuItem();
            this.ribbon = new System.Windows.Forms.Ribbon();
            this.drawTab = new System.Windows.Forms.RibbonTab();
            this.drawPanel = new System.Windows.Forms.RibbonPanel();
            this.arcBtn = new System.Windows.Forms.RibbonButton();
            this.arcBtn11 = new System.Windows.Forms.RibbonButton();
            this.circleBtn = new System.Windows.Forms.RibbonButton();
            this.circleBtn21 = new System.Windows.Forms.RibbonButton();
            this.circleBtn22 = new System.Windows.Forms.RibbonButton();
            this.ellipseBtn = new System.Windows.Forms.RibbonButton();
            this.ellipseBtn31 = new System.Windows.Forms.RibbonButton();
            this.lineBtn = new System.Windows.Forms.RibbonButton();
            this.polylineBtn = new System.Windows.Forms.RibbonButton();
            this.polygonBtn = new System.Windows.Forms.RibbonButton();
            this.pointBtn = new System.Windows.Forms.RibbonButton();
            this.rectangleBtn = new System.Windows.Forms.RibbonButton();
            this.ribbonButton1 = new System.Windows.Forms.RibbonButton();
            this.ribbonButton2 = new System.Windows.Forms.RibbonButton();
            this.drawing = new System.Windows.Forms.PictureBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.coordinate = new System.Windows.Forms.ToolStripStatusLabel();
            this.hS = new System.Windows.Forms.HScrollBar();
            this.vS = new System.Windows.Forms.VScrollBar();
            this.arcBtn12 = new System.Windows.Forms.RibbonButton();
            this.arcBtn13 = new System.Windows.Forms.RibbonButton();
            this.menuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.drawing)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cancelBtn,
            this.closeBoundary});
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(123, 52);
            // 
            // cancelBtn
            // 
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(122, 24);
            this.cancelBtn.Text = "Cancel";
            this.cancelBtn.Click += new System.EventHandler(this.cancelBtn_Click);
            // 
            // closeBoundary
            // 
            this.closeBoundary.Name = "closeBoundary";
            this.closeBoundary.Size = new System.Drawing.Size(122, 24);
            this.closeBoundary.Text = "Close";
            this.closeBoundary.Click += new System.EventHandler(this.closeBoundary_Click);
            // 
            // ribbon
            // 
            this.ribbon.CaptionBarVisible = false;
            this.ribbon.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ribbon.Location = new System.Drawing.Point(0, 0);
            this.ribbon.Minimized = false;
            this.ribbon.Name = "ribbon";
            // 
            // 
            // 
            this.ribbon.OrbDropDown.BorderRoundness = 8;
            this.ribbon.OrbDropDown.Location = new System.Drawing.Point(0, 0);
            this.ribbon.OrbDropDown.Name = "";
            this.ribbon.OrbDropDown.TabIndex = 0;
            this.ribbon.RibbonTabFont = new System.Drawing.Font("Trebuchet MS", 9F);
            this.ribbon.Size = new System.Drawing.Size(1222, 130);
            this.ribbon.TabIndex = 9;
            this.ribbon.Tabs.Add(this.drawTab);
            this.ribbon.Text = "ribbon1";
            // 
            // drawTab
            // 
            this.drawTab.Name = "drawTab";
            this.drawTab.Panels.Add(this.drawPanel);
            this.drawTab.Text = "Drawing";
            // 
            // drawPanel
            // 
            this.drawPanel.ButtonMoreEnabled = false;
            this.drawPanel.ButtonMoreVisible = false;
            this.drawPanel.Items.Add(this.arcBtn);
            this.drawPanel.Items.Add(this.circleBtn);
            this.drawPanel.Items.Add(this.ellipseBtn);
            this.drawPanel.Items.Add(this.lineBtn);
            this.drawPanel.Items.Add(this.polylineBtn);
            this.drawPanel.Items.Add(this.polygonBtn);
            this.drawPanel.Items.Add(this.pointBtn);
            this.drawPanel.Items.Add(this.rectangleBtn);
            this.drawPanel.Name = "drawPanel";
            this.drawPanel.Text = "";
            // 
            // arcBtn
            // 
            this.arcBtn.DropDownItems.Add(this.arcBtn11);
            this.arcBtn.DropDownItems.Add(this.arcBtn12);
            this.arcBtn.DropDownItems.Add(this.arcBtn13);
            this.arcBtn.Image = global::Seeker.Properties.Resources.arc__1_;
            this.arcBtn.LargeImage = global::Seeker.Properties.Resources.arc__1_;
            this.arcBtn.Name = "arcBtn";
            this.arcBtn.SmallImage = ((System.Drawing.Image)(resources.GetObject("arcBtn.SmallImage")));
            this.arcBtn.Style = System.Windows.Forms.RibbonButtonStyle.DropDown;
            this.arcBtn.Text = "Arc";
            // 
            // arcBtn11
            // 
            this.arcBtn11.DropDownArrowDirection = System.Windows.Forms.RibbonArrowDirection.Left;
            this.arcBtn11.Image = ((System.Drawing.Image)(resources.GetObject("arcBtn11.Image")));
            this.arcBtn11.LargeImage = ((System.Drawing.Image)(resources.GetObject("arcBtn11.LargeImage")));
            this.arcBtn11.Name = "arcBtn11";
            this.arcBtn11.SmallImage = ((System.Drawing.Image)(resources.GetObject("arcBtn11.SmallImage")));
            this.arcBtn11.Text = "3-Point";
            this.arcBtn11.Click += new System.EventHandler(this.ArcBtn_Click);
            // 
            // circleBtn
            // 
            this.circleBtn.DropDownItems.Add(this.circleBtn21);
            this.circleBtn.DropDownItems.Add(this.circleBtn22);
            this.circleBtn.Image = global::Seeker.Properties.Resources.dry_clean;
            this.circleBtn.LargeImage = global::Seeker.Properties.Resources.dry_clean;
            this.circleBtn.Name = "circleBtn";
            this.circleBtn.SmallImage = ((System.Drawing.Image)(resources.GetObject("circleBtn.SmallImage")));
            this.circleBtn.Style = System.Windows.Forms.RibbonButtonStyle.DropDown;
            this.circleBtn.Text = "Circle";
            // 
            // circleBtn21
            // 
            this.circleBtn21.DropDownArrowDirection = System.Windows.Forms.RibbonArrowDirection.Left;
            this.circleBtn21.Image = ((System.Drawing.Image)(resources.GetObject("circleBtn21.Image")));
            this.circleBtn21.LargeImage = ((System.Drawing.Image)(resources.GetObject("circleBtn21.LargeImage")));
            this.circleBtn21.Name = "circleBtn21";
            this.circleBtn21.SmallImage = ((System.Drawing.Image)(resources.GetObject("circleBtn21.SmallImage")));
            this.circleBtn21.Text = "Center, Radius";
            this.circleBtn21.Click += new System.EventHandler(this.CircleBtn_Click);
            // 
            // circleBtn22
            // 
            this.circleBtn22.DropDownArrowDirection = System.Windows.Forms.RibbonArrowDirection.Left;
            this.circleBtn22.Image = ((System.Drawing.Image)(resources.GetObject("circleBtn22.Image")));
            this.circleBtn22.LargeImage = ((System.Drawing.Image)(resources.GetObject("circleBtn22.LargeImage")));
            this.circleBtn22.Name = "circleBtn22";
            this.circleBtn22.SmallImage = ((System.Drawing.Image)(resources.GetObject("circleBtn22.SmallImage")));
            this.circleBtn22.Text = "3-Points";
            this.circleBtn22.Click += new System.EventHandler(this.CircleBtn_Click);
            // 
            // ellipseBtn
            // 
            this.ellipseBtn.DropDownItems.Add(this.ellipseBtn31);
            this.ellipseBtn.Image = global::Seeker.Properties.Resources.ellipse__1_;
            this.ellipseBtn.LargeImage = global::Seeker.Properties.Resources.ellipse__1_;
            this.ellipseBtn.Name = "ellipseBtn";
            this.ellipseBtn.SmallImage = ((System.Drawing.Image)(resources.GetObject("ellipseBtn.SmallImage")));
            this.ellipseBtn.Style = System.Windows.Forms.RibbonButtonStyle.DropDown;
            this.ellipseBtn.Text = "Ellipse";
            this.ellipseBtn.Click += new System.EventHandler(this.EllipseBtn_Click);
            // 
            // ellipseBtn31
            // 
            this.ellipseBtn31.DropDownArrowDirection = System.Windows.Forms.RibbonArrowDirection.Left;
            this.ellipseBtn31.Image = ((System.Drawing.Image)(resources.GetObject("ellipseBtn31.Image")));
            this.ellipseBtn31.LargeImage = ((System.Drawing.Image)(resources.GetObject("ellipseBtn31.LargeImage")));
            this.ellipseBtn31.Name = "ellipseBtn31";
            this.ellipseBtn31.SmallImage = ((System.Drawing.Image)(resources.GetObject("ellipseBtn31.SmallImage")));
            this.ellipseBtn31.Text = "Full Ellipse";
            this.ellipseBtn31.Click += new System.EventHandler(this.EllipseBtn_Click);
            // 
            // lineBtn
            // 
            this.lineBtn.Image = global::Seeker.Properties.Resources.diagonal_line;
            this.lineBtn.LargeImage = global::Seeker.Properties.Resources.diagonal_line;
            this.lineBtn.Name = "lineBtn";
            this.lineBtn.SmallImage = ((System.Drawing.Image)(resources.GetObject("lineBtn.SmallImage")));
            this.lineBtn.Text = "Line";
            this.lineBtn.Click += new System.EventHandler(this.DrawBtn_Click);
            // 
            // polylineBtn
            // 
            this.polylineBtn.Image = global::Seeker.Properties.Resources.polygonal_chain;
            this.polylineBtn.LargeImage = global::Seeker.Properties.Resources.polygonal_chain;
            this.polylineBtn.Name = "polylineBtn";
            this.polylineBtn.SmallImage = ((System.Drawing.Image)(resources.GetObject("polylineBtn.SmallImage")));
            this.polylineBtn.Text = "Polyline";
            this.polylineBtn.Click += new System.EventHandler(this.DrawBtn_Click);
            // 
            // polygonBtn
            // 
            this.polygonBtn.Image = global::Seeker.Properties.Resources.hexagon;
            this.polygonBtn.LargeImage = global::Seeker.Properties.Resources.hexagon;
            this.polygonBtn.Name = "polygonBtn";
            this.polygonBtn.SmallImage = ((System.Drawing.Image)(resources.GetObject("polygonBtn.SmallImage")));
            this.polygonBtn.Text = "Polygon";
            this.polygonBtn.Click += new System.EventHandler(this.DrawBtn_Click);
            // 
            // pointBtn
            // 
            this.pointBtn.Image = global::Seeker.Properties.Resources.points;
            this.pointBtn.LargeImage = global::Seeker.Properties.Resources.points;
            this.pointBtn.Name = "pointBtn";
            this.pointBtn.SmallImage = ((System.Drawing.Image)(resources.GetObject("pointBtn.SmallImage")));
            this.pointBtn.Text = "Point";
            this.pointBtn.Click += new System.EventHandler(this.DrawBtn_Click);
            // 
            // rectangleBtn
            // 
            this.rectangleBtn.Image = global::Seeker.Properties.Resources.rectangular_shape_outline;
            this.rectangleBtn.LargeImage = global::Seeker.Properties.Resources.rectangular_shape_outline;
            this.rectangleBtn.Name = "rectangleBtn";
            this.rectangleBtn.SmallImage = ((System.Drawing.Image)(resources.GetObject("rectangleBtn.SmallImage")));
            this.rectangleBtn.Text = "Rectangle";
            this.rectangleBtn.Click += new System.EventHandler(this.DrawBtn_Click);
            // 
            // ribbonButton1
            // 
            this.ribbonButton1.Image = ((System.Drawing.Image)(resources.GetObject("ribbonButton1.Image")));
            this.ribbonButton1.LargeImage = ((System.Drawing.Image)(resources.GetObject("ribbonButton1.LargeImage")));
            this.ribbonButton1.MaxSizeMode = System.Windows.Forms.RibbonElementSizeMode.Compact;
            this.ribbonButton1.Name = "ribbonButton1";
            this.ribbonButton1.SmallImage = ((System.Drawing.Image)(resources.GetObject("ribbonButton1.SmallImage")));
            this.ribbonButton1.Text = "ribbonButton1";
            // 
            // ribbonButton2
            // 
            this.ribbonButton2.Image = ((System.Drawing.Image)(resources.GetObject("ribbonButton2.Image")));
            this.ribbonButton2.LargeImage = ((System.Drawing.Image)(resources.GetObject("ribbonButton2.LargeImage")));
            this.ribbonButton2.MaxSizeMode = System.Windows.Forms.RibbonElementSizeMode.Compact;
            this.ribbonButton2.Name = "ribbonButton2";
            this.ribbonButton2.SmallImage = ((System.Drawing.Image)(resources.GetObject("ribbonButton2.SmallImage")));
            this.ribbonButton2.Text = "ribbonButton2";
            // 
            // drawing
            // 
            this.drawing.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.drawing.BackColor = System.Drawing.SystemColors.Window;
            this.drawing.ContextMenuStrip = this.menuStrip;
            this.drawing.Location = new System.Drawing.Point(0, 136);
            this.drawing.Name = "drawing";
            this.drawing.Size = new System.Drawing.Size(1199, 490);
            this.drawing.TabIndex = 0;
            this.drawing.TabStop = false;
            this.drawing.Paint += new System.Windows.Forms.PaintEventHandler(this.drawing_Paint);
            this.drawing.MouseDown += new System.Windows.Forms.MouseEventHandler(this.drawing_MouseDown);
            this.drawing.MouseMove += new System.Windows.Forms.MouseEventHandler(this.drawing_MouseMove);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(40, 40);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.coordinate});
            this.statusStrip1.Location = new System.Drawing.Point(0, 650);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1222, 35);
            this.statusStrip1.TabIndex = 10;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // coordinate
            // 
            this.coordinate.AutoSize = false;
            this.coordinate.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
            this.coordinate.BorderStyle = System.Windows.Forms.Border3DStyle.SunkenOuter;
            this.coordinate.Name = "coordinate";
            this.coordinate.Size = new System.Drawing.Size(250, 29);
            this.coordinate.Text = "0.000,0.000,0.000";
            // 
            // hS
            // 
            this.hS.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.hS.Location = new System.Drawing.Point(0, 629);
            this.hS.Name = "hS";
            this.hS.Size = new System.Drawing.Size(1199, 21);
            this.hS.TabIndex = 11;
            this.hS.Scroll += new System.Windows.Forms.ScrollEventHandler(this.hS_Scroll);
            // 
            // vS
            // 
            this.vS.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.vS.Location = new System.Drawing.Point(1203, 130);
            this.vS.Name = "vS";
            this.vS.Size = new System.Drawing.Size(21, 496);
            this.vS.TabIndex = 12;
            this.vS.Scroll += new System.Windows.Forms.ScrollEventHandler(this.vS_Scroll);
            // 
            // arcBtn12
            // 
            this.arcBtn12.DropDownArrowDirection = System.Windows.Forms.RibbonArrowDirection.Left;
            this.arcBtn12.Image = ((System.Drawing.Image)(resources.GetObject("arcBtn12.Image")));
            this.arcBtn12.LargeImage = ((System.Drawing.Image)(resources.GetObject("arcBtn12.LargeImage")));
            this.arcBtn12.Name = "arcBtn12";
            this.arcBtn12.SmallImage = ((System.Drawing.Image)(resources.GetObject("arcBtn12.SmallImage")));
            this.arcBtn12.Text = "Start, Center, End";
            this.arcBtn12.Click += new System.EventHandler(this.ArcBtn_Click);
            // 
            // arcBtn13
            // 
            this.arcBtn13.DropDownArrowDirection = System.Windows.Forms.RibbonArrowDirection.Left;
            this.arcBtn13.Image = ((System.Drawing.Image)(resources.GetObject("arcBtn13.Image")));
            this.arcBtn13.LargeImage = ((System.Drawing.Image)(resources.GetObject("arcBtn13.LargeImage")));
            this.arcBtn13.Name = "arcBtn13";
            this.arcBtn13.SmallImage = ((System.Drawing.Image)(resources.GetObject("arcBtn13.SmallImage")));
            this.arcBtn13.Text = "Center, Start, End";
            this.arcBtn13.Click += new System.EventHandler(this.ArcBtn_Click);
            // 
            // GraphicsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1222, 685);
            this.Controls.Add(this.vS);
            this.Controls.Add(this.hS);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.ribbon);
            this.Controls.Add(this.drawing);
            this.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "GraphicsForm";
            this.Text = "Form1";
            this.menuStrip.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.drawing)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox drawing;
        private System.Windows.Forms.ContextMenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem cancelBtn;
        private System.Windows.Forms.Ribbon ribbon;
        private System.Windows.Forms.RibbonButton ribbonButton1;
        private System.Windows.Forms.RibbonButton ribbonButton2;
        private System.Windows.Forms.RibbonTab drawTab;
        private System.Windows.Forms.RibbonPanel drawPanel;
        private System.Windows.Forms.RibbonButton arcBtn;
        private System.Windows.Forms.RibbonButton arcBtn11;
        private System.Windows.Forms.RibbonButton circleBtn;
        private System.Windows.Forms.RibbonButton circleBtn21;
        private System.Windows.Forms.RibbonButton circleBtn22;
        private System.Windows.Forms.RibbonButton ellipseBtn;
        private System.Windows.Forms.RibbonButton lineBtn;
        private System.Windows.Forms.RibbonButton polylineBtn;
        private System.Windows.Forms.RibbonButton polygonBtn;
        private System.Windows.Forms.RibbonButton pointBtn;
        private System.Windows.Forms.RibbonButton rectangleBtn;
        private System.Windows.Forms.RibbonButton ellipseBtn31;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel coordinate;
        private System.Windows.Forms.HScrollBar hS;
        private System.Windows.Forms.VScrollBar vS;
        private System.Windows.Forms.ToolStripMenuItem closeBoundary;
        private System.Windows.Forms.RibbonButton arcBtn12;
        private System.Windows.Forms.RibbonButton arcBtn13;
    }
}

