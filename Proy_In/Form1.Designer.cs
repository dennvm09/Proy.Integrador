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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.map = new GMap.NET.WindowsForms.GMapControl();
            this.zoomIn = new System.Windows.Forms.Button();
            this.zoomInfo = new System.Windows.Forms.Label();
            this.actualZoom = new System.Windows.Forms.Label();
            this.zoomOut = new System.Windows.Forms.Button();
            this.testMotion = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.paneZonas = new System.Windows.Forms.Panel();
            this.checkBZ8 = new System.Windows.Forms.CheckBox();
            this.checkBZ7 = new System.Windows.Forms.CheckBox();
            this.checkBZ6 = new System.Windows.Forms.CheckBox();
            this.checkBZ5 = new System.Windows.Forms.CheckBox();
            this.checkBZ4 = new System.Windows.Forms.CheckBox();
            this.checkBZ3 = new System.Windows.Forms.CheckBox();
            this.checkBZ2 = new System.Windows.Forms.CheckBox();
            this.checkBZ1 = new System.Windows.Forms.CheckBox();
            this.checkBZ0 = new System.Windows.Forms.CheckBox();
            this.checkBEstaciones = new System.Windows.Forms.CheckBox();
            this.checkBCalle = new System.Windows.Forms.CheckBox();
            this.checkBZonas = new System.Windows.Forms.CheckBox();
            this.btFiltrar = new System.Windows.Forms.Button();
            this.rbtOpcion1 = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.rbtOpcion2 = new System.Windows.Forms.RadioButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.paneOp1 = new System.Windows.Forms.Panel();
            this.checkBReservas = new System.Windows.Forms.CheckBox();
            this.btLimpiar = new System.Windows.Forms.Button();
            this.checkBTodas = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.paneOp2 = new System.Windows.Forms.Panel();
            this.cbCustom = new System.Windows.Forms.CheckBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panelCustomSimulation = new System.Windows.Forms.Panel();
            this.btCustomSimulationt = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btSimulacionCompleta = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblHora = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.paneZonas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.paneOp1.SuspendLayout();
            this.paneOp2.SuspendLayout();
            this.panelCustomSimulation.SuspendLayout();
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
            this.map.Location = new System.Drawing.Point(15, 14);
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
            this.map.Size = new System.Drawing.Size(935, 895);
            this.map.TabIndex = 0;
            this.map.Zoom = 1D;
            this.map.Load += new System.EventHandler(this.Map_Load);
            // 
            // zoomIn
            // 
            this.zoomIn.Location = new System.Drawing.Point(151, 27);
            this.zoomIn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.zoomIn.Name = "zoomIn";
            this.zoomIn.Size = new System.Drawing.Size(49, 39);
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
            this.actualZoom.BackColor = System.Drawing.Color.Transparent;
            this.actualZoom.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.actualZoom.Location = new System.Drawing.Point(87, 37);
            this.actualZoom.Name = "actualZoom";
            this.actualZoom.Size = new System.Drawing.Size(16, 20);
            this.actualZoom.TabIndex = 3;
            this.actualZoom.Text = "-";
            this.actualZoom.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.actualZoom.Click += new System.EventHandler(this.ActualZoom_Click);
            // 
            // zoomOut
            // 
            this.zoomOut.Location = new System.Drawing.Point(31, 27);
            this.zoomOut.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.zoomOut.Name = "zoomOut";
            this.zoomOut.Size = new System.Drawing.Size(49, 39);
            this.zoomOut.TabIndex = 4;
            this.zoomOut.Text = "-";
            this.zoomOut.UseVisualStyleBackColor = true;
            this.zoomOut.Click += new System.EventHandler(this.ZoomOut_Click);
            // 
            // testMotion
            // 
            this.testMotion.Location = new System.Drawing.Point(1512, 1110);
            this.testMotion.Margin = new System.Windows.Forms.Padding(5);
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
            this.label1.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(7, 90);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 23);
            this.label1.TabIndex = 8;
            this.label1.Text = "Filtrar por...";
            this.label1.Click += new System.EventHandler(this.Label1_Click);
            // 
            // paneZonas
            // 
            this.paneZonas.Controls.Add(this.checkBZ8);
            this.paneZonas.Controls.Add(this.checkBZ7);
            this.paneZonas.Controls.Add(this.checkBZ6);
            this.paneZonas.Controls.Add(this.checkBZ5);
            this.paneZonas.Controls.Add(this.checkBZ4);
            this.paneZonas.Controls.Add(this.checkBZ3);
            this.paneZonas.Controls.Add(this.checkBZ2);
            this.paneZonas.Controls.Add(this.checkBZ1);
            this.paneZonas.Controls.Add(this.checkBZ0);
            this.paneZonas.Location = new System.Drawing.Point(29, 240);
            this.paneZonas.Margin = new System.Windows.Forms.Padding(4);
            this.paneZonas.Name = "paneZonas";
            this.paneZonas.Size = new System.Drawing.Size(323, 198);
            this.paneZonas.TabIndex = 13;
            // 
            // checkBZ8
            // 
            this.checkBZ8.AutoSize = true;
            this.checkBZ8.Location = new System.Drawing.Point(17, 167);
            this.checkBZ8.Margin = new System.Windows.Forms.Padding(4);
            this.checkBZ8.Name = "checkBZ8";
            this.checkBZ8.Size = new System.Drawing.Size(135, 21);
            this.checkBZ8.TabIndex = 24;
            this.checkBZ8.Text = "Zona 8 (Calipso)";
            this.checkBZ8.UseVisualStyleBackColor = true;
            this.checkBZ8.CheckedChanged += new System.EventHandler(this.CheckBZ8_CheckedChanged);
            // 
            // checkBZ7
            // 
            this.checkBZ7.AutoSize = true;
            this.checkBZ7.Location = new System.Drawing.Point(17, 148);
            this.checkBZ7.Margin = new System.Windows.Forms.Padding(4);
            this.checkBZ7.Name = "checkBZ7";
            this.checkBZ7.Size = new System.Drawing.Size(172, 21);
            this.checkBZ7.TabIndex = 23;
            this.checkBZ7.Text = "Zona 7 (Cañaveralejo)";
            this.checkBZ7.UseVisualStyleBackColor = true;
            this.checkBZ7.CheckedChanged += new System.EventHandler(this.CheckBZ7_CheckedChanged);
            // 
            // checkBZ6
            // 
            this.checkBZ6.AutoSize = true;
            this.checkBZ6.Location = new System.Drawing.Point(17, 128);
            this.checkBZ6.Margin = new System.Windows.Forms.Padding(4);
            this.checkBZ6.Name = "checkBZ6";
            this.checkBZ6.Size = new System.Drawing.Size(159, 21);
            this.checkBZ6.TabIndex = 22;
            this.checkBZ6.Text = "Zona 6 (Guadalupe)";
            this.checkBZ6.UseVisualStyleBackColor = true;
            this.checkBZ6.CheckedChanged += new System.EventHandler(this.CheckBZ6_CheckedChanged);
            // 
            // checkBZ5
            // 
            this.checkBZ5.AutoSize = true;
            this.checkBZ5.Location = new System.Drawing.Point(17, 108);
            this.checkBZ5.Margin = new System.Windows.Forms.Padding(4);
            this.checkBZ5.Name = "checkBZ5";
            this.checkBZ5.Size = new System.Drawing.Size(162, 21);
            this.checkBZ5.TabIndex = 21;
            this.checkBZ5.Text = "Zona 5 (Nuevo Latir)";
            this.checkBZ5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.checkBZ5.UseVisualStyleBackColor = true;
            this.checkBZ5.CheckedChanged += new System.EventHandler(this.CheckBZ5_CheckedChanged);
            // 
            // checkBZ4
            // 
            this.checkBZ4.AutoSize = true;
            this.checkBZ4.Location = new System.Drawing.Point(17, 89);
            this.checkBZ4.Margin = new System.Windows.Forms.Padding(4);
            this.checkBZ4.Name = "checkBZ4";
            this.checkBZ4.Size = new System.Drawing.Size(174, 21);
            this.checkBZ4.TabIndex = 20;
            this.checkBZ4.Text = "Zona 4 (Andrés Sanín)";
            this.checkBZ4.UseVisualStyleBackColor = true;
            this.checkBZ4.CheckedChanged += new System.EventHandler(this.CheckBox6_CheckedChanged);
            // 
            // checkBZ3
            // 
            this.checkBZ3.AutoSize = true;
            this.checkBZ3.Location = new System.Drawing.Point(17, 68);
            this.checkBZ3.Margin = new System.Windows.Forms.Padding(4);
            this.checkBZ3.Name = "checkBZ3";
            this.checkBZ3.Size = new System.Drawing.Size(207, 21);
            this.checkBZ3.TabIndex = 19;
            this.checkBZ3.Text = "Zona 3 (Paso del Comercio)";
            this.checkBZ3.UseVisualStyleBackColor = true;
            this.checkBZ3.CheckedChanged += new System.EventHandler(this.CheckBZ3_CheckedChanged);
            // 
            // checkBZ2
            // 
            this.checkBZ2.AutoSize = true;
            this.checkBZ2.Location = new System.Drawing.Point(17, 48);
            this.checkBZ2.Margin = new System.Windows.Forms.Padding(4);
            this.checkBZ2.Name = "checkBZ2";
            this.checkBZ2.Size = new System.Drawing.Size(132, 21);
            this.checkBZ2.TabIndex = 18;
            this.checkBZ2.Text = "Zona 2 (Menga)";
            this.checkBZ2.UseVisualStyleBackColor = true;
            this.checkBZ2.CheckedChanged += new System.EventHandler(this.CheckBZ2_CheckedChanged);
            // 
            // checkBZ1
            // 
            this.checkBZ1.AutoSize = true;
            this.checkBZ1.Location = new System.Drawing.Point(17, 28);
            this.checkBZ1.Margin = new System.Windows.Forms.Padding(4);
            this.checkBZ1.Name = "checkBZ1";
            this.checkBZ1.Size = new System.Drawing.Size(179, 21);
            this.checkBZ1.TabIndex = 17;
            this.checkBZ1.Text = "Zona 1 (Universidades)";
            this.checkBZ1.UseVisualStyleBackColor = true;
            this.checkBZ1.CheckedChanged += new System.EventHandler(this.CheckBZ1_CheckedChanged);
            // 
            // checkBZ0
            // 
            this.checkBZ0.AutoSize = true;
            this.checkBZ0.Location = new System.Drawing.Point(17, 9);
            this.checkBZ0.Margin = new System.Windows.Forms.Padding(4);
            this.checkBZ0.Name = "checkBZ0";
            this.checkBZ0.Size = new System.Drawing.Size(131, 21);
            this.checkBZ0.TabIndex = 16;
            this.checkBZ0.Text = "Zona 0 (Centro)";
            this.checkBZ0.UseVisualStyleBackColor = true;
            this.checkBZ0.CheckedChanged += new System.EventHandler(this.CheckBZ0_CheckedChanged);
            // 
            // checkBEstaciones
            // 
            this.checkBEstaciones.AutoSize = true;
            this.checkBEstaciones.Location = new System.Drawing.Point(29, 127);
            this.checkBEstaciones.Margin = new System.Windows.Forms.Padding(4);
            this.checkBEstaciones.Name = "checkBEstaciones";
            this.checkBEstaciones.Size = new System.Drawing.Size(99, 21);
            this.checkBEstaciones.TabIndex = 14;
            this.checkBEstaciones.Text = "Estaciones";
            this.checkBEstaciones.UseVisualStyleBackColor = true;
            this.checkBEstaciones.CheckedChanged += new System.EventHandler(this.CheckBox1_CheckedChanged);
            // 
            // checkBCalle
            // 
            this.checkBCalle.AutoSize = true;
            this.checkBCalle.Location = new System.Drawing.Point(29, 155);
            this.checkBCalle.Margin = new System.Windows.Forms.Padding(4);
            this.checkBCalle.Name = "checkBCalle";
            this.checkBCalle.Size = new System.Drawing.Size(151, 21);
            this.checkBCalle.TabIndex = 15;
            this.checkBCalle.Text = "Paradas en la calle";
            this.checkBCalle.UseVisualStyleBackColor = true;
            this.checkBCalle.CheckedChanged += new System.EventHandler(this.CheckBCalle_CheckedChanged);
            // 
            // checkBZonas
            // 
            this.checkBZonas.AutoSize = true;
            this.checkBZonas.Location = new System.Drawing.Point(29, 212);
            this.checkBZonas.Margin = new System.Windows.Forms.Padding(4);
            this.checkBZonas.Name = "checkBZonas";
            this.checkBZonas.Size = new System.Drawing.Size(70, 21);
            this.checkBZonas.TabIndex = 16;
            this.checkBZonas.Text = "Zonas";
            this.checkBZonas.UseVisualStyleBackColor = true;
            this.checkBZonas.CheckedChanged += new System.EventHandler(this.CheckBZonas_CheckedChanged);
            // 
            // btFiltrar
            // 
            this.btFiltrar.Location = new System.Drawing.Point(279, 127);
            this.btFiltrar.Margin = new System.Windows.Forms.Padding(4);
            this.btFiltrar.Name = "btFiltrar";
            this.btFiltrar.Size = new System.Drawing.Size(100, 28);
            this.btFiltrar.TabIndex = 17;
            this.btFiltrar.Text = "Ubicar";
            this.btFiltrar.UseVisualStyleBackColor = true;
            this.btFiltrar.Click += new System.EventHandler(this.BtFiltrar_Click);
            // 
            // rbtOpcion1
            // 
            this.rbtOpcion1.AutoSize = true;
            this.rbtOpcion1.Location = new System.Drawing.Point(995, 204);
            this.rbtOpcion1.Margin = new System.Windows.Forms.Padding(4);
            this.rbtOpcion1.Name = "rbtOpcion1";
            this.rbtOpcion1.Size = new System.Drawing.Size(160, 21);
            this.rbtOpcion1.TabIndex = 18;
            this.rbtOpcion1.TabStop = true;
            this.rbtOpcion1.Text = "Conocer las paradas";
            this.rbtOpcion1.UseVisualStyleBackColor = true;
            this.rbtOpcion1.CheckedChanged += new System.EventHandler(this.RadioButton1_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(975, 175);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 26);
            this.label2.TabIndex = 19;
            this.label2.Text = "Desea...";
            // 
            // rbtOpcion2
            // 
            this.rbtOpcion2.AutoSize = true;
            this.rbtOpcion2.Location = new System.Drawing.Point(995, 233);
            this.rbtOpcion2.Margin = new System.Windows.Forms.Padding(4);
            this.rbtOpcion2.Name = "rbtOpcion2";
            this.rbtOpcion2.Size = new System.Drawing.Size(152, 21);
            this.rbtOpcion2.TabIndex = 20;
            this.rbtOpcion2.TabStop = true;
            this.rbtOpcion2.Text = "Ver rutas en acción";
            this.rbtOpcion2.UseVisualStyleBackColor = true;
            this.rbtOpcion2.CheckedChanged += new System.EventHandler(this.RbtOpcion2_CheckedChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Proy_In.Properties.Resources.logo_mio1;
            this.pictureBox1.Location = new System.Drawing.Point(1160, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(239, 82);
            this.pictureBox1.TabIndex = 21;
            this.pictureBox1.TabStop = false;
            // 
            // paneOp1
            // 
            this.paneOp1.Controls.Add(this.checkBReservas);
            this.paneOp1.Controls.Add(this.btLimpiar);
            this.paneOp1.Controls.Add(this.checkBTodas);
            this.paneOp1.Controls.Add(this.label4);
            this.paneOp1.Controls.Add(this.btFiltrar);
            this.paneOp1.Controls.Add(this.label1);
            this.paneOp1.Controls.Add(this.paneZonas);
            this.paneOp1.Controls.Add(this.checkBEstaciones);
            this.paneOp1.Controls.Add(this.checkBCalle);
            this.paneOp1.Controls.Add(this.checkBZonas);
            this.paneOp1.Location = new System.Drawing.Point(980, 276);
            this.paneOp1.Margin = new System.Windows.Forms.Padding(4);
            this.paneOp1.Name = "paneOp1";
            this.paneOp1.Size = new System.Drawing.Size(380, 511);
            this.paneOp1.TabIndex = 22;
            // 
            // checkBReservas
            // 
            this.checkBReservas.AutoSize = true;
            this.checkBReservas.Location = new System.Drawing.Point(29, 183);
            this.checkBReservas.Margin = new System.Windows.Forms.Padding(4);
            this.checkBReservas.Name = "checkBReservas";
            this.checkBReservas.Size = new System.Drawing.Size(90, 21);
            this.checkBReservas.TabIndex = 21;
            this.checkBReservas.Text = "Reservas";
            this.checkBReservas.UseVisualStyleBackColor = true;
            this.checkBReservas.CheckedChanged += new System.EventHandler(this.CheckBReservas_CheckedChanged);
            // 
            // btLimpiar
            // 
            this.btLimpiar.Location = new System.Drawing.Point(279, 164);
            this.btLimpiar.Margin = new System.Windows.Forms.Padding(4);
            this.btLimpiar.Name = "btLimpiar";
            this.btLimpiar.Size = new System.Drawing.Size(100, 28);
            this.btLimpiar.TabIndex = 20;
            this.btLimpiar.Text = "Limpiar";
            this.btLimpiar.UseVisualStyleBackColor = true;
            this.btLimpiar.Click += new System.EventHandler(this.BtLimpiar_Click);
            // 
            // checkBTodas
            // 
            this.checkBTodas.AutoSize = true;
            this.checkBTodas.Location = new System.Drawing.Point(29, 54);
            this.checkBTodas.Margin = new System.Windows.Forms.Padding(4);
            this.checkBTodas.Name = "checkBTodas";
            this.checkBTodas.Size = new System.Drawing.Size(148, 21);
            this.checkBTodas.TabIndex = 19;
            this.checkBTodas.Text = "Todas las paradas";
            this.checkBTodas.UseVisualStyleBackColor = true;
            this.checkBTodas.CheckedChanged += new System.EventHandler(this.CheckBTodas_CheckedChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(135, 4);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(127, 31);
            this.label4.TabIndex = 18;
            this.label4.Text = "PARADAS";
            // 
            // paneOp2
            // 
            this.paneOp2.Controls.Add(this.cbCustom);
            this.paneOp2.Controls.Add(this.label8);
            this.paneOp2.Controls.Add(this.label7);
            this.paneOp2.Controls.Add(this.label3);
            this.paneOp2.Controls.Add(this.panelCustomSimulation);
            this.paneOp2.Controls.Add(this.label5);
            this.paneOp2.Location = new System.Drawing.Point(980, 276);
            this.paneOp2.Margin = new System.Windows.Forms.Padding(4);
            this.paneOp2.Name = "paneOp2";
            this.paneOp2.Size = new System.Drawing.Size(422, 213);
            this.paneOp2.TabIndex = 23;
            // 
            // cbCustom
            // 
            this.cbCustom.AutoSize = true;
            this.cbCustom.Location = new System.Drawing.Point(15, 118);
            this.cbCustom.Name = "cbCustom";
            this.cbCustom.Size = new System.Drawing.Size(120, 21);
            this.cbCustom.TabIndex = 25;
            this.cbCustom.Text = "Personalizado";
            this.cbCustom.UseVisualStyleBackColor = true;
            this.cbCustom.CheckedChanged += new System.EventHandler(this.CbCustom_CheckedChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 98);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(118, 17);
            this.label8.TabIndex = 24;
            this.label8.Text = "tiempo encotrado";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(4, 81);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(216, 17);
            this.label7.TabIndex = 23;
            this.label7.Text = " todos los datos desde el menorx";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(249, 17);
            this.label3.TabIndex = 22;
            this.label3.Text = "Esta opción iniciará una simulación de";
            this.label3.Click += new System.EventHandler(this.Label3_Click_1);
            // 
            // panelCustomSimulation
            // 
            this.panelCustomSimulation.Controls.Add(this.btCustomSimulationt);
            this.panelCustomSimulation.Controls.Add(this.label11);
            this.panelCustomSimulation.Controls.Add(this.label10);
            this.panelCustomSimulation.Controls.Add(this.label9);
            this.panelCustomSimulation.Controls.Add(this.textBox4);
            this.panelCustomSimulation.Controls.Add(this.textBox3);
            this.panelCustomSimulation.Controls.Add(this.textBox2);
            this.panelCustomSimulation.Controls.Add(this.textBox1);
            this.panelCustomSimulation.Location = new System.Drawing.Point(3, 141);
            this.panelCustomSimulation.Name = "panelCustomSimulation";
            this.panelCustomSimulation.Size = new System.Drawing.Size(416, 69);
            this.panelCustomSimulation.TabIndex = 21;
            // 
            // btCustomSimulationt
            // 
            this.btCustomSimulationt.Location = new System.Drawing.Point(333, 40);
            this.btCustomSimulationt.Name = "btCustomSimulationt";
            this.btCustomSimulationt.Size = new System.Drawing.Size(75, 23);
            this.btCustomSimulationt.TabIndex = 7;
            this.btCustomSimulationt.Text = "Iniciar";
            this.btCustomSimulationt.UseVisualStyleBackColor = true;
            this.btCustomSimulationt.Visible = false;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(222, 11);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(47, 17);
            this.label11.TabIndex = 6;
            this.label11.Text = "desde";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(161, 11);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(28, 17);
            this.label10.TabIndex = 5;
            this.label10.Text = "hrs";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(-3, 11);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(108, 17);
            this.label9.TabIndex = 4;
            this.label9.Text = "Simular durante";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(365, 8);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(39, 22);
            this.textBox4.TabIndex = 3;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(319, 8);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(40, 22);
            this.textBox3.TabIndex = 2;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(276, 8);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(37, 22);
            this.textBox2.TabIndex = 1;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(106, 8);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(49, 22);
            this.textBox1.TabIndex = 0;
            // 
            // btSimulacionCompleta
            // 
            this.btSimulacionCompleta.Location = new System.Drawing.Point(1245, 233);
            this.btSimulacionCompleta.Margin = new System.Windows.Forms.Padding(4);
            this.btSimulacionCompleta.Name = "btSimulacionCompleta";
            this.btSimulacionCompleta.Size = new System.Drawing.Size(154, 28);
            this.btSimulacionCompleta.TabIndex = 20;
            this.btSimulacionCompleta.Text = "Simulacion completa";
            this.btSimulacionCompleta.UseVisualStyleBackColor = true;
            this.btSimulacionCompleta.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(77, 5);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(229, 31);
            this.label5.TabIndex = 19;
            this.label5.Text = "RUTAS EN ACCIÓN";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(1101, 123);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(85, 17);
            this.label6.TabIndex = 24;
            this.label6.Text = "Hora actual:";
            // 
            // lblHora
            // 
            this.lblHora.AutoSize = true;
            this.lblHora.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHora.Location = new System.Drawing.Point(1212, 118);
            this.lblHora.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblHora.Name = "lblHora";
            this.lblHora.Size = new System.Drawing.Size(112, 26);
            this.lblHora.TabIndex = 25;
            this.lblHora.Text = "HH:MM:SS";
            this.lblHora.Click += new System.EventHandler(this.Label7_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1403, 922);
            this.Controls.Add(this.lblHora);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.paneOp2);
            this.Controls.Add(this.paneOp1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btSimulacionCompleta);
            this.Controls.Add(this.rbtOpcion2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.rbtOpcion1);
            this.Controls.Add(this.testMotion);
            this.Controls.Add(this.zoomOut);
            this.Controls.Add(this.actualZoom);
            this.Controls.Add(this.zoomInfo);
            this.Controls.Add(this.zoomIn);
            this.Controls.Add(this.map);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "MIO SITM";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.paneZonas.ResumeLayout(false);
            this.paneZonas.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.paneOp1.ResumeLayout(false);
            this.paneOp1.PerformLayout();
            this.paneOp2.ResumeLayout(false);
            this.paneOp2.PerformLayout();
            this.panelCustomSimulation.ResumeLayout(false);
            this.panelCustomSimulation.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private GMap.NET.WindowsForms.GMapControl map;
        private System.Windows.Forms.Button zoomIn;
        private System.Windows.Forms.Label zoomInfo;
        private System.Windows.Forms.Label actualZoom;
        private System.Windows.Forms.Button zoomOut;

        private System.Windows.Forms.Button testMotion;

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel paneZonas;
        private System.Windows.Forms.CheckBox checkBEstaciones;
        private System.Windows.Forms.CheckBox checkBCalle;
        private System.Windows.Forms.CheckBox checkBZonas;
        private System.Windows.Forms.CheckBox checkBZ8;
        private System.Windows.Forms.CheckBox checkBZ7;
        private System.Windows.Forms.CheckBox checkBZ6;
        private System.Windows.Forms.CheckBox checkBZ5;
        private System.Windows.Forms.CheckBox checkBZ4;
        private System.Windows.Forms.CheckBox checkBZ3;
        private System.Windows.Forms.CheckBox checkBZ2;
        private System.Windows.Forms.CheckBox checkBZ1;
        private System.Windows.Forms.CheckBox checkBZ0;
        private System.Windows.Forms.Button btFiltrar;
        private System.Windows.Forms.RadioButton rbtOpcion1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton rbtOpcion2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel paneOp1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel paneOp2;
        private System.Windows.Forms.Button btSimulacionCompleta;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox checkBTodas;
        private System.Windows.Forms.Button btLimpiar;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblHora;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.CheckBox checkBReservas;
        private System.Windows.Forms.Panel panelCustomSimulation;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox cbCustom;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btCustomSimulation;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
    }
}

