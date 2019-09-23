namespace Proy_In
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.map = new GMap.NET.WindowsForms.GMapControl();
            this.zoomIn = new System.Windows.Forms.Button();
            this.zoomInfo = new System.Windows.Forms.Label();
            this.actualZoom = new System.Windows.Forms.Label();
            this.zoomOut = new System.Windows.Forms.Button();
            this.loadDataBt = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.locateBt = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // map
            // 
            this.map.Bearing = 0F;
            this.map.CanDragMap = true;
            this.map.EmptyTileColor = System.Drawing.Color.Navy;
            this.map.GrayScaleMode = false;
            this.map.HelperLineOption = GMap.NET.WindowsForms.HelperLineOptions.DontShow;
            this.map.LevelsKeepInMemmory = 5;
            this.map.Location = new System.Drawing.Point(-1, 1);
            this.map.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.map.MarkersEnabled = true;
            this.map.MaxZoom = 100;
            this.map.MinZoom = 1;
            this.map.MouseWheelZoomEnabled = true;
            this.map.MouseWheelZoomType = GMap.NET.MouseWheelZoomType.MousePositionAndCenter;
            this.map.Name = "map";
            this.map.NegativeMode = false;
            this.map.PolygonsEnabled = true;
            this.map.RetryLoadTile = 0;
            this.map.RoutesEnabled = true;
            this.map.ScaleMode = GMap.NET.WindowsForms.ScaleModes.Integer;
            this.map.SelectedAreaFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(65)))), ((int)(((byte)(105)))), ((int)(((byte)(225)))));
            this.map.ShowTileGridLines = false;
            this.map.Size = new System.Drawing.Size(806, 763);
            this.map.TabIndex = 0;
            this.map.Zoom = 7D;
            this.map.Load += new System.EventHandler(this.Map_Load);
            // 
            // zoomIn
            // 
            this.zoomIn.Location = new System.Drawing.Point(914, 26);
            this.zoomIn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.zoomIn.Name = "zoomIn";
            this.zoomIn.Size = new System.Drawing.Size(33, 32);
            this.zoomIn.TabIndex = 1;
            this.zoomIn.Text = "+";
            this.zoomIn.UseVisualStyleBackColor = true;
            this.zoomIn.Click += new System.EventHandler(this.ZoomIn_Click);
            // 
            // zoomInfo
            // 
            this.zoomInfo.AutoSize = true;
            this.zoomInfo.Location = new System.Drawing.Point(602, 41);
            this.zoomInfo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.zoomInfo.Name = "zoomInfo";
            this.zoomInfo.Size = new System.Drawing.Size(0, 13);
            this.zoomInfo.TabIndex = 2;
            // 
            // actualZoom
            // 
            this.actualZoom.AutoSize = true;
            this.actualZoom.Location = new System.Drawing.Point(875, 35);
            this.actualZoom.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.actualZoom.Name = "actualZoom";
            this.actualZoom.Size = new System.Drawing.Size(35, 13);
            this.actualZoom.TabIndex = 3;
            this.actualZoom.Text = "label1";
            this.actualZoom.Click += new System.EventHandler(this.ActualZoom_Click);
            // 
            // zoomOut
            // 
            this.zoomOut.Location = new System.Drawing.Point(833, 26);
            this.zoomOut.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.zoomOut.Name = "zoomOut";
            this.zoomOut.Size = new System.Drawing.Size(37, 32);
            this.zoomOut.TabIndex = 4;
            this.zoomOut.Text = "-";
            this.zoomOut.UseVisualStyleBackColor = true;
            this.zoomOut.Click += new System.EventHandler(this.ZoomOut_Click);
            // 
            // loadDataBt
            // 
            this.loadDataBt.Location = new System.Drawing.Point(841, 100);
            this.loadDataBt.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.loadDataBt.Name = "loadDataBt";
            this.loadDataBt.Size = new System.Drawing.Size(106, 37);
            this.loadDataBt.TabIndex = 5;
            this.loadDataBt.Text = "load Data";
            this.loadDataBt.UseVisualStyleBackColor = true;
            this.loadDataBt.Click += new System.EventHandler(this.LoadDataBt_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(841, 141);
            this.button1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(56, 19);
            this.button1.TabIndex = 6;
            this.button1.Text = "test";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // locateBt
            // 
            this.locateBt.Location = new System.Drawing.Point(841, 191);
            this.locateBt.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.locateBt.Name = "locateBt";
            this.locateBt.Size = new System.Drawing.Size(106, 41);
            this.locateBt.TabIndex = 7;
            this.locateBt.Text = "Locate";
            this.locateBt.UseVisualStyleBackColor = true;
            this.locateBt.Click += new System.EventHandler(this.LocateBt_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(990, 766);
            this.Controls.Add(this.locateBt);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.loadDataBt);
            this.Controls.Add(this.zoomOut);
            this.Controls.Add(this.actualZoom);
            this.Controls.Add(this.zoomInfo);
            this.Controls.Add(this.zoomIn);
            this.Controls.Add(this.map);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private GMap.NET.WindowsForms.GMapControl map;
        private System.Windows.Forms.Button zoomIn;
        private System.Windows.Forms.Label zoomInfo;
        private System.Windows.Forms.Label actualZoom;
        private System.Windows.Forms.Button zoomOut;
        private System.Windows.Forms.Button loadDataBt;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button locateBt;
    }
}

