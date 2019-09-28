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
            this.testMotion = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.label6 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
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
            this.map.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
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
            this.map.Size = new System.Drawing.Size(1075, 939);
            this.map.TabIndex = 0;
            this.map.Zoom = 1D;
            this.map.Load += new System.EventHandler(this.Map_Load);
            // 
            // zoomIn
            // 
            this.zoomIn.Location = new System.Drawing.Point(1299, 711);
            this.zoomIn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.zoomIn.Name = "zoomIn";
            this.zoomIn.Size = new System.Drawing.Size(77, 39);
            this.zoomIn.TabIndex = 1;
            this.zoomIn.Text = "+";
            this.zoomIn.UseVisualStyleBackColor = true;
            this.zoomIn.Click += new System.EventHandler(this.ZoomIn_Click);
            // 
            // zoomInfo
            // 
            this.zoomInfo.AutoSize = true;
            this.zoomInfo.Location = new System.Drawing.Point(803, 50);
            this.zoomInfo.Name = "zoomInfo";
            this.zoomInfo.Size = new System.Drawing.Size(0, 17);
            this.zoomInfo.TabIndex = 2;
            // 
            // actualZoom
            // 
            this.actualZoom.AutoSize = true;
            this.actualZoom.Location = new System.Drawing.Point(1247, 724);
            this.actualZoom.Name = "actualZoom";
            this.actualZoom.Size = new System.Drawing.Size(46, 17);
            this.actualZoom.TabIndex = 3;
            this.actualZoom.Text = "label1";
            this.actualZoom.Click += new System.EventHandler(this.ActualZoom_Click);
            // 
            // zoomOut
            // 
            this.zoomOut.Location = new System.Drawing.Point(1159, 711);
            this.zoomOut.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.zoomOut.Name = "zoomOut";
            this.zoomOut.Size = new System.Drawing.Size(83, 39);
            this.zoomOut.TabIndex = 4;
            this.zoomOut.Text = "-";
            this.zoomOut.UseVisualStyleBackColor = true;
            this.zoomOut.Click += new System.EventHandler(this.ZoomOut_Click);
            // 
            // loadDataBt
            // 
            this.loadDataBt.Location = new System.Drawing.Point(1143, 767);
            this.loadDataBt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.loadDataBt.Name = "loadDataBt";
            this.loadDataBt.Size = new System.Drawing.Size(251, 33);
            this.loadDataBt.TabIndex = 5;
            this.loadDataBt.Text = "Cargar archivo";
            this.loadDataBt.UseVisualStyleBackColor = true;
            this.loadDataBt.Click += new System.EventHandler(this.LoadDataBt_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1247, 642);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "test";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // locateBt
            // 
            this.locateBt.Location = new System.Drawing.Point(1143, 820);
            this.locateBt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.locateBt.Name = "locateBt";
            this.locateBt.Size = new System.Drawing.Size(251, 33);
            this.locateBt.TabIndex = 7;
            this.locateBt.Text = "Ubicar";
            this.locateBt.UseVisualStyleBackColor = true;
            this.locateBt.Click += new System.EventHandler(this.LocateBt_Click);
            // 
            // testMotion
            // 
            this.testMotion.Location = new System.Drawing.Point(1134, 902);
            this.testMotion.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.testMotion.Name = "testMotion";
            this.testMotion.Size = new System.Drawing.Size(159, 28);
            this.testMotion.TabIndex = 8;
            this.testMotion.Text = "test animation";
            this.testMotion.UseVisualStyleBackColor = true;
            this.testMotion.Click += new System.EventHandler(this.TestMotion_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(1171, 95);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 26);
            this.label1.TabIndex = 8;
            this.label1.Text = "Filtrar por...";
            this.label1.Click += new System.EventHandler(this.Label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1383, 452);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 17);
            this.label2.TabIndex = 9;
            this.label2.Text = "Zonas:";
            this.label2.Click += new System.EventHandler(this.Label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(1160, 149);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(133, 17);
            this.label3.TabIndex = 10;
            this.label3.Text = "Paradas en la calle:";
            this.label3.Click += new System.EventHandler(this.Label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(1189, 560);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 17);
            this.label4.TabIndex = 11;
            this.label4.Text = "Estaciones:";
            this.label4.Click += new System.EventHandler(this.Label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(1189, 476);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 17);
            this.label5.TabIndex = 12;
            this.label5.Text = "Buses:";
            this.label5.Click += new System.EventHandler(this.Label5_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.checkedListBox1);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Location = new System.Drawing.Point(1237, 208);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(252, 240);
            this.panel1.TabIndex = 13;
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Items.AddRange(new object[] {
            "Zona 0 (Centro)",
            "Zona 1 (Universidades)",
            "Zona 2 (Menga)",
            "Zona 3 (Paso del Comercio)",
            "Zona 4 (Andrés Sanín)",
            "Zona 5 (Nuevo Latir)",
            "Zona 6 (Guadalupe)",
            "Zona 7 (Cañaveralejo)",
            "Zona 8 (Calipso)"});
            this.checkedListBox1.Location = new System.Drawing.Point(4, 47);
            this.checkedListBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(241, 157);
            this.checkedListBox1.TabIndex = 15;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(19, 14);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(84, 29);
            this.label6.TabIndex = 14;
            this.label6.Text = "Zonas";
            this.label6.Click += new System.EventHandler(this.Label6_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1541, 943);
            this.Controls.Add(this.testMotion);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.locateBt);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.loadDataBt);
            this.Controls.Add(this.zoomOut);
            this.Controls.Add(this.actualZoom);
            this.Controls.Add(this.zoomInfo);
            this.Controls.Add(this.zoomIn);
            this.Controls.Add(this.map);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
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

        private System.Windows.Forms.Button testMotion;

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.CheckedListBox checkedListBox1;

    }
}

