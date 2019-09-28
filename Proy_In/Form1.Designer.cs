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
            this.paneZonas = new System.Windows.Forms.Panel();
            this.checkBEstaciones = new System.Windows.Forms.CheckBox();
            this.checkBCalle = new System.Windows.Forms.CheckBox();
            this.checkBZonas = new System.Windows.Forms.CheckBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.checkBox4 = new System.Windows.Forms.CheckBox();
            this.checkBox5 = new System.Windows.Forms.CheckBox();
            this.checkBox6 = new System.Windows.Forms.CheckBox();
            this.checkBox7 = new System.Windows.Forms.CheckBox();
            this.checkBox8 = new System.Windows.Forms.CheckBox();
            this.checkBox9 = new System.Windows.Forms.CheckBox();
            this.paneZonas.SuspendLayout();
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
            this.map.Location = new System.Drawing.Point(11, 11);
            this.map.Margin = new System.Windows.Forms.Padding(2);
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
            this.map.Size = new System.Drawing.Size(703, 692);
            this.map.TabIndex = 0;
            this.map.Zoom = 1D;
            this.map.Load += new System.EventHandler(this.Map_Load);
            // 
            // zoomIn
            // 
            this.zoomIn.Location = new System.Drawing.Point(938, 559);
            this.zoomIn.Margin = new System.Windows.Forms.Padding(2);
            this.zoomIn.Name = "zoomIn";
            this.zoomIn.Size = new System.Drawing.Size(58, 32);
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
            this.actualZoom.Location = new System.Drawing.Point(899, 569);
            this.actualZoom.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.actualZoom.Name = "actualZoom";
            this.actualZoom.Size = new System.Drawing.Size(35, 13);
            this.actualZoom.TabIndex = 3;
            this.actualZoom.Text = "label1";
            this.actualZoom.Click += new System.EventHandler(this.ActualZoom_Click);
            // 
            // zoomOut
            // 
            this.zoomOut.Location = new System.Drawing.Point(833, 559);
            this.zoomOut.Margin = new System.Windows.Forms.Padding(2);
            this.zoomOut.Name = "zoomOut";
            this.zoomOut.Size = new System.Drawing.Size(62, 32);
            this.zoomOut.TabIndex = 4;
            this.zoomOut.Text = "-";
            this.zoomOut.UseVisualStyleBackColor = true;
            this.zoomOut.Click += new System.EventHandler(this.ZoomOut_Click);
            // 
            // loadDataBt
            // 
            this.loadDataBt.Location = new System.Drawing.Point(857, 623);
            this.loadDataBt.Margin = new System.Windows.Forms.Padding(2);
            this.loadDataBt.Name = "loadDataBt";
            this.loadDataBt.Size = new System.Drawing.Size(188, 27);
            this.loadDataBt.TabIndex = 5;
            this.loadDataBt.Text = "Cargar archivo";
            this.loadDataBt.UseVisualStyleBackColor = true;
            this.loadDataBt.Click += new System.EventHandler(this.LoadDataBt_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(899, 503);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(56, 19);
            this.button1.TabIndex = 6;
            this.button1.Text = "test";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // locateBt
            // 
            this.locateBt.Location = new System.Drawing.Point(857, 666);
            this.locateBt.Margin = new System.Windows.Forms.Padding(2);
            this.locateBt.Name = "locateBt";
            this.locateBt.Size = new System.Drawing.Size(188, 27);
            this.locateBt.TabIndex = 7;
            this.locateBt.Text = "Ubicar";
            this.locateBt.UseVisualStyleBackColor = true;
            this.locateBt.Click += new System.EventHandler(this.LocateBt_Click);
            // 
            // testMotion
            // 
            this.testMotion.Location = new System.Drawing.Point(723, 607);
            this.testMotion.Name = "testMotion";
            this.testMotion.Size = new System.Drawing.Size(119, 23);
            this.testMotion.TabIndex = 8;
            this.testMotion.Text = "test animation";
            this.testMotion.UseVisualStyleBackColor = true;
            this.testMotion.Click += new System.EventHandler(this.TestMotion_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(719, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 21);
            this.label1.TabIndex = 8;
            this.label1.Text = "Filtrar por...";
            this.label1.Click += new System.EventHandler(this.Label1_Click);
            // 
            // paneZonas
            // 
            this.paneZonas.Controls.Add(this.checkBox9);
            this.paneZonas.Controls.Add(this.checkBox7);
            this.paneZonas.Controls.Add(this.checkBox8);
            this.paneZonas.Controls.Add(this.checkBox5);
            this.paneZonas.Controls.Add(this.checkBox6);
            this.paneZonas.Controls.Add(this.checkBox3);
            this.paneZonas.Controls.Add(this.checkBox4);
            this.paneZonas.Controls.Add(this.checkBox2);
            this.paneZonas.Controls.Add(this.checkBox1);
            this.paneZonas.Location = new System.Drawing.Point(736, 170);
            this.paneZonas.Name = "paneZonas";
            this.paneZonas.Size = new System.Drawing.Size(304, 168);
            this.paneZonas.TabIndex = 13;
            // 
            // checkBEstaciones
            // 
            this.checkBEstaciones.AutoSize = true;
            this.checkBEstaciones.Location = new System.Drawing.Point(736, 101);
            this.checkBEstaciones.Name = "checkBEstaciones";
            this.checkBEstaciones.Size = new System.Drawing.Size(78, 17);
            this.checkBEstaciones.TabIndex = 14;
            this.checkBEstaciones.Text = "Estaciones";
            this.checkBEstaciones.UseVisualStyleBackColor = true;
            this.checkBEstaciones.CheckedChanged += new System.EventHandler(this.CheckBox1_CheckedChanged);
            // 
            // checkBCalle
            // 
            this.checkBCalle.AutoSize = true;
            this.checkBCalle.Location = new System.Drawing.Point(736, 124);
            this.checkBCalle.Name = "checkBCalle";
            this.checkBCalle.Size = new System.Drawing.Size(116, 17);
            this.checkBCalle.TabIndex = 15;
            this.checkBCalle.Text = "Paradas en la calle";
            this.checkBCalle.UseVisualStyleBackColor = true;
            // 
            // checkBZonas
            // 
            this.checkBZonas.AutoSize = true;
            this.checkBZonas.Location = new System.Drawing.Point(736, 147);
            this.checkBZonas.Name = "checkBZonas";
            this.checkBZonas.Size = new System.Drawing.Size(56, 17);
            this.checkBZonas.TabIndex = 16;
            this.checkBZonas.Text = "Zonas";
            this.checkBZonas.UseVisualStyleBackColor = true;
            this.checkBZonas.CheckedChanged += new System.EventHandler(this.CheckBZonas_CheckedChanged);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(13, 7);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(100, 17);
            this.checkBox1.TabIndex = 16;
            this.checkBox1.Text = "Zona 0 (Centro)";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(13, 23);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(136, 17);
            this.checkBox2.TabIndex = 17;
            this.checkBox2.Text = "Zona 1 (Universidades)";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Location = new System.Drawing.Point(13, 55);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(157, 17);
            this.checkBox3.TabIndex = 19;
            this.checkBox3.Text = "Zona 3 (Paso del Comercio)";
            this.checkBox3.UseVisualStyleBackColor = true;
            // 
            // checkBox4
            // 
            this.checkBox4.AutoSize = true;
            this.checkBox4.Location = new System.Drawing.Point(13, 39);
            this.checkBox4.Name = "checkBox4";
            this.checkBox4.Size = new System.Drawing.Size(102, 17);
            this.checkBox4.TabIndex = 18;
            this.checkBox4.Text = "Zona 2 (Menga)";
            this.checkBox4.UseVisualStyleBackColor = true;
            // 
            // checkBox5
            // 
            this.checkBox5.AutoSize = true;
            this.checkBox5.Location = new System.Drawing.Point(13, 88);
            this.checkBox5.Name = "checkBox5";
            this.checkBox5.Size = new System.Drawing.Size(124, 17);
            this.checkBox5.TabIndex = 21;
            this.checkBox5.Text = "Zona 5 (Nuevo Latir)";
            this.checkBox5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.checkBox5.UseVisualStyleBackColor = true;
            // 
            // checkBox6
            // 
            this.checkBox6.AutoSize = true;
            this.checkBox6.Location = new System.Drawing.Point(13, 72);
            this.checkBox6.Name = "checkBox6";
            this.checkBox6.Size = new System.Drawing.Size(134, 17);
            this.checkBox6.TabIndex = 20;
            this.checkBox6.Text = "Zona 4 (Andrés Sanín)";
            this.checkBox6.UseVisualStyleBackColor = true;
            // 
            // checkBox7
            // 
            this.checkBox7.AutoSize = true;
            this.checkBox7.Location = new System.Drawing.Point(13, 120);
            this.checkBox7.Name = "checkBox7";
            this.checkBox7.Size = new System.Drawing.Size(131, 17);
            this.checkBox7.TabIndex = 23;
            this.checkBox7.Text = "Zona 7 (Cañaveralejo)";
            this.checkBox7.UseVisualStyleBackColor = true;
            // 
            // checkBox8
            // 
            this.checkBox8.AutoSize = true;
            this.checkBox8.Location = new System.Drawing.Point(13, 104);
            this.checkBox8.Name = "checkBox8";
            this.checkBox8.Size = new System.Drawing.Size(121, 17);
            this.checkBox8.TabIndex = 22;
            this.checkBox8.Text = "Zona 6 (Guadalupe)";
            this.checkBox8.UseVisualStyleBackColor = true;
            // 
            // checkBox9
            // 
            this.checkBox9.AutoSize = true;
            this.checkBox9.Location = new System.Drawing.Point(13, 136);
            this.checkBox9.Name = "checkBox9";
            this.checkBox9.Size = new System.Drawing.Size(103, 17);
            this.checkBox9.TabIndex = 24;
            this.checkBox9.Text = "Zona 8 (Calipso)";
            this.checkBox9.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1052, 749);
            this.Controls.Add(this.checkBZonas);
            this.Controls.Add(this.checkBCalle);
            this.Controls.Add(this.checkBEstaciones);
            this.Controls.Add(this.testMotion);
            this.Controls.Add(this.paneZonas);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.locateBt);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.loadDataBt);
            this.Controls.Add(this.zoomOut);
            this.Controls.Add(this.actualZoom);
            this.Controls.Add(this.zoomInfo);
            this.Controls.Add(this.zoomIn);
            this.Controls.Add(this.map);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "MIO SITM";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.paneZonas.ResumeLayout(false);
            this.paneZonas.PerformLayout();
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
        private System.Windows.Forms.Panel paneZonas;
        private System.Windows.Forms.CheckBox checkBEstaciones;
        private System.Windows.Forms.CheckBox checkBCalle;
        private System.Windows.Forms.CheckBox checkBZonas;
        private System.Windows.Forms.CheckBox checkBox9;
        private System.Windows.Forms.CheckBox checkBox7;
        private System.Windows.Forms.CheckBox checkBox8;
        private System.Windows.Forms.CheckBox checkBox5;
        private System.Windows.Forms.CheckBox checkBox6;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.CheckBox checkBox4;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox1;
    }
}

