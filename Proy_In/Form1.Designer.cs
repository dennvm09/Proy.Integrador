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
            this.label5 = new System.Windows.Forms.Label();
            this.btSimulacionCompleta = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.lblHora = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.checkBParadas = new System.Windows.Forms.CheckBox();
            this.label7 = new System.Windows.Forms.Label();
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
            this.map.Size = new System.Drawing.Size(701, 727);
            this.map.TabIndex = 0;
            this.map.Zoom = 1D;
            this.map.Load += new System.EventHandler(this.Map_Load);
            // 
            // zoomIn
            // 
            this.zoomIn.Location = new System.Drawing.Point(113, 22);
            this.zoomIn.Margin = new System.Windows.Forms.Padding(2);
            this.zoomIn.Name = "zoomIn";
            this.zoomIn.Size = new System.Drawing.Size(37, 32);
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
            this.actualZoom.BackColor = System.Drawing.Color.Transparent;
            this.actualZoom.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.actualZoom.Location = new System.Drawing.Point(65, 30);
            this.actualZoom.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.actualZoom.Name = "actualZoom";
            this.actualZoom.Size = new System.Drawing.Size(13, 16);
            this.actualZoom.TabIndex = 3;
            this.actualZoom.Text = "-";
            this.actualZoom.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.actualZoom.Click += new System.EventHandler(this.ActualZoom_Click);
            // 
            // zoomOut
            // 
            this.zoomOut.Location = new System.Drawing.Point(23, 22);
            this.zoomOut.Margin = new System.Windows.Forms.Padding(2);
            this.zoomOut.Name = "zoomOut";
            this.zoomOut.Size = new System.Drawing.Size(37, 32);
            this.zoomOut.TabIndex = 4;
            this.zoomOut.Text = "-";
            this.zoomOut.UseVisualStyleBackColor = true;
            this.zoomOut.Click += new System.EventHandler(this.ZoomOut_Click);
            // 
            // testMotion
            // 
            this.testMotion.Location = new System.Drawing.Point(1134, 902);
            this.testMotion.Margin = new System.Windows.Forms.Padding(4);
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
            this.label1.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(5, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 19);
            this.label1.TabIndex = 8;
            this.label1.Text = "Filtrar por...";
            this.label1.Click += new System.EventHandler(this.Label1_Click);
            // 
            // paneZonas
            // 
            this.paneZonas.Controls.Add(this.checkBParadas);
            this.paneZonas.Controls.Add(this.checkBZ8);
            this.paneZonas.Controls.Add(this.label7);
            this.paneZonas.Controls.Add(this.checkBZ7);
            this.paneZonas.Controls.Add(this.checkBZ6);
            this.paneZonas.Controls.Add(this.checkBZ5);
            this.paneZonas.Controls.Add(this.checkBZ4);
            this.paneZonas.Controls.Add(this.checkBZ3);
            this.paneZonas.Controls.Add(this.checkBZ2);
            this.paneZonas.Controls.Add(this.checkBZ1);
            this.paneZonas.Controls.Add(this.checkBZ0);
            this.paneZonas.Location = new System.Drawing.Point(22, 195);
            this.paneZonas.Name = "paneZonas";
            this.paneZonas.Size = new System.Drawing.Size(242, 239);
            this.paneZonas.TabIndex = 13;
            // 
            // checkBZ8
            // 
            this.checkBZ8.AutoSize = true;
            this.checkBZ8.Location = new System.Drawing.Point(13, 136);
            this.checkBZ8.Name = "checkBZ8";
            this.checkBZ8.Size = new System.Drawing.Size(103, 17);
            this.checkBZ8.TabIndex = 24;
            this.checkBZ8.Text = "Zona 8 (Calipso)";
            this.checkBZ8.UseVisualStyleBackColor = true;
            this.checkBZ8.CheckedChanged += new System.EventHandler(this.CheckBZ8_CheckedChanged);
            // 
            // checkBZ7
            // 
            this.checkBZ7.AutoSize = true;
            this.checkBZ7.Location = new System.Drawing.Point(13, 120);
            this.checkBZ7.Name = "checkBZ7";
            this.checkBZ7.Size = new System.Drawing.Size(131, 17);
            this.checkBZ7.TabIndex = 23;
            this.checkBZ7.Text = "Zona 7 (Cañaveralejo)";
            this.checkBZ7.UseVisualStyleBackColor = true;
            this.checkBZ7.CheckedChanged += new System.EventHandler(this.CheckBZ7_CheckedChanged);
            // 
            // checkBZ6
            // 
            this.checkBZ6.AutoSize = true;
            this.checkBZ6.Location = new System.Drawing.Point(13, 104);
            this.checkBZ6.Name = "checkBZ6";
            this.checkBZ6.Size = new System.Drawing.Size(121, 17);
            this.checkBZ6.TabIndex = 22;
            this.checkBZ6.Text = "Zona 6 (Guadalupe)";
            this.checkBZ6.UseVisualStyleBackColor = true;
            this.checkBZ6.CheckedChanged += new System.EventHandler(this.CheckBZ6_CheckedChanged);
            // 
            // checkBZ5
            // 
            this.checkBZ5.AutoSize = true;
            this.checkBZ5.Location = new System.Drawing.Point(13, 88);
            this.checkBZ5.Name = "checkBZ5";
            this.checkBZ5.Size = new System.Drawing.Size(124, 17);
            this.checkBZ5.TabIndex = 21;
            this.checkBZ5.Text = "Zona 5 (Nuevo Latir)";
            this.checkBZ5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.checkBZ5.UseVisualStyleBackColor = true;
            this.checkBZ5.CheckedChanged += new System.EventHandler(this.CheckBZ5_CheckedChanged);
            // 
            // checkBZ4
            // 
            this.checkBZ4.AutoSize = true;
            this.checkBZ4.Location = new System.Drawing.Point(13, 72);
            this.checkBZ4.Name = "checkBZ4";
            this.checkBZ4.Size = new System.Drawing.Size(134, 17);
            this.checkBZ4.TabIndex = 20;
            this.checkBZ4.Text = "Zona 4 (Andrés Sanín)";
            this.checkBZ4.UseVisualStyleBackColor = true;
            this.checkBZ4.CheckedChanged += new System.EventHandler(this.CheckBox6_CheckedChanged);
            // 
            // checkBZ3
            // 
            this.checkBZ3.AutoSize = true;
            this.checkBZ3.Location = new System.Drawing.Point(13, 55);
            this.checkBZ3.Name = "checkBZ3";
            this.checkBZ3.Size = new System.Drawing.Size(157, 17);
            this.checkBZ3.TabIndex = 19;
            this.checkBZ3.Text = "Zona 3 (Paso del Comercio)";
            this.checkBZ3.UseVisualStyleBackColor = true;
            this.checkBZ3.CheckedChanged += new System.EventHandler(this.CheckBZ3_CheckedChanged);
            // 
            // checkBZ2
            // 
            this.checkBZ2.AutoSize = true;
            this.checkBZ2.Location = new System.Drawing.Point(13, 39);
            this.checkBZ2.Name = "checkBZ2";
            this.checkBZ2.Size = new System.Drawing.Size(102, 17);
            this.checkBZ2.TabIndex = 18;
            this.checkBZ2.Text = "Zona 2 (Menga)";
            this.checkBZ2.UseVisualStyleBackColor = true;
            this.checkBZ2.CheckedChanged += new System.EventHandler(this.CheckBZ2_CheckedChanged);
            // 
            // checkBZ1
            // 
            this.checkBZ1.AutoSize = true;
            this.checkBZ1.Location = new System.Drawing.Point(13, 23);
            this.checkBZ1.Name = "checkBZ1";
            this.checkBZ1.Size = new System.Drawing.Size(136, 17);
            this.checkBZ1.TabIndex = 17;
            this.checkBZ1.Text = "Zona 1 (Universidades)";
            this.checkBZ1.UseVisualStyleBackColor = true;
            this.checkBZ1.CheckedChanged += new System.EventHandler(this.CheckBZ1_CheckedChanged);
            // 
            // checkBZ0
            // 
            this.checkBZ0.AutoSize = true;
            this.checkBZ0.Location = new System.Drawing.Point(13, 7);
            this.checkBZ0.Name = "checkBZ0";
            this.checkBZ0.Size = new System.Drawing.Size(100, 17);
            this.checkBZ0.TabIndex = 16;
            this.checkBZ0.Text = "Zona 0 (Centro)";
            this.checkBZ0.UseVisualStyleBackColor = true;
            this.checkBZ0.CheckedChanged += new System.EventHandler(this.CheckBZ0_CheckedChanged);
            // 
            // checkBEstaciones
            // 
            this.checkBEstaciones.AutoSize = true;
            this.checkBEstaciones.Location = new System.Drawing.Point(22, 103);
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
            this.checkBCalle.Location = new System.Drawing.Point(22, 126);
            this.checkBCalle.Name = "checkBCalle";
            this.checkBCalle.Size = new System.Drawing.Size(116, 17);
            this.checkBCalle.TabIndex = 15;
            this.checkBCalle.Text = "Paradas en la calle";
            this.checkBCalle.UseVisualStyleBackColor = true;
            this.checkBCalle.CheckedChanged += new System.EventHandler(this.CheckBCalle_CheckedChanged);
            // 
            // checkBZonas
            // 
            this.checkBZonas.AutoSize = true;
            this.checkBZonas.Location = new System.Drawing.Point(22, 172);
            this.checkBZonas.Name = "checkBZonas";
            this.checkBZonas.Size = new System.Drawing.Size(56, 17);
            this.checkBZonas.TabIndex = 16;
            this.checkBZonas.Text = "Zonas";
            this.checkBZonas.UseVisualStyleBackColor = true;
            this.checkBZonas.CheckedChanged += new System.EventHandler(this.CheckBZonas_CheckedChanged);
            // 
            // btFiltrar
            // 
            this.btFiltrar.Location = new System.Drawing.Point(209, 103);
            this.btFiltrar.Name = "btFiltrar";
            this.btFiltrar.Size = new System.Drawing.Size(75, 23);
            this.btFiltrar.TabIndex = 17;
            this.btFiltrar.Text = "Ubicar";
            this.btFiltrar.UseVisualStyleBackColor = true;
            this.btFiltrar.Click += new System.EventHandler(this.BtFiltrar_Click);
            // 
            // rbtOpcion1
            // 
            this.rbtOpcion1.AutoSize = true;
            this.rbtOpcion1.Location = new System.Drawing.Point(746, 166);
            this.rbtOpcion1.Name = "rbtOpcion1";
            this.rbtOpcion1.Size = new System.Drawing.Size(122, 17);
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
            this.label2.Location = new System.Drawing.Point(731, 142);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 21);
            this.label2.TabIndex = 19;
            this.label2.Text = "Desea...";
            // 
            // rbtOpcion2
            // 
            this.rbtOpcion2.AutoSize = true;
            this.rbtOpcion2.Location = new System.Drawing.Point(746, 189);
            this.rbtOpcion2.Name = "rbtOpcion2";
            this.rbtOpcion2.Size = new System.Drawing.Size(117, 17);
            this.rbtOpcion2.TabIndex = 20;
            this.rbtOpcion2.TabStop = true;
            this.rbtOpcion2.Text = "Ver rutas en acción";
            this.rbtOpcion2.UseVisualStyleBackColor = true;
            this.rbtOpcion2.CheckedChanged += new System.EventHandler(this.RbtOpcion2_CheckedChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Proy_In.Properties.Resources.logo_mio1;
            this.pictureBox1.Location = new System.Drawing.Point(869, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(213, 67);
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
            this.paneOp1.Location = new System.Drawing.Point(735, 224);
            this.paneOp1.Name = "paneOp1";
            this.paneOp1.Size = new System.Drawing.Size(285, 437);
            this.paneOp1.TabIndex = 22;
            // 
            // checkBReservas
            // 
            this.checkBReservas.AutoSize = true;
            this.checkBReservas.Location = new System.Drawing.Point(22, 149);
            this.checkBReservas.Name = "checkBReservas";
            this.checkBReservas.Size = new System.Drawing.Size(71, 17);
            this.checkBReservas.TabIndex = 21;
            this.checkBReservas.Text = "Reservas";
            this.checkBReservas.UseVisualStyleBackColor = true;
            this.checkBReservas.CheckedChanged += new System.EventHandler(this.CheckBReservas_CheckedChanged);
            // 
            // btLimpiar
            // 
            this.btLimpiar.Location = new System.Drawing.Point(209, 133);
            this.btLimpiar.Name = "btLimpiar";
            this.btLimpiar.Size = new System.Drawing.Size(75, 23);
            this.btLimpiar.TabIndex = 20;
            this.btLimpiar.Text = "Limpiar";
            this.btLimpiar.UseVisualStyleBackColor = true;
            this.btLimpiar.Click += new System.EventHandler(this.BtLimpiar_Click);
            // 
            // checkBTodas
            // 
            this.checkBTodas.AutoSize = true;
            this.checkBTodas.Location = new System.Drawing.Point(22, 44);
            this.checkBTodas.Name = "checkBTodas";
            this.checkBTodas.Size = new System.Drawing.Size(113, 17);
            this.checkBTodas.TabIndex = 19;
            this.checkBTodas.Text = "Todas las paradas";
            this.checkBTodas.UseVisualStyleBackColor = true;
            this.checkBTodas.CheckedChanged += new System.EventHandler(this.CheckBTodas_CheckedChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(101, 3);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 23);
            this.label4.TabIndex = 18;
            this.label4.Text = "PARADAS";
            // 
            // paneOp2
            // 
            this.paneOp2.Controls.Add(this.cbCustom);
            this.paneOp2.Controls.Add(this.label3);
            this.paneOp2.Controls.Add(this.panelCustomSimulation);
            this.paneOp2.Controls.Add(this.label5);
            this.paneOp2.Controls.Add(this.btSimulacionCompleta);
            this.paneOp2.Location = new System.Drawing.Point(735, 224);
            this.paneOp2.Name = "paneOp2";
            this.paneOp2.Size = new System.Drawing.Size(316, 277);
            this.paneOp2.TabIndex = 23;
            // 
            // cbCustom
            // 
            this.cbCustom.AutoSize = true;
            this.cbCustom.Location = new System.Drawing.Point(9, 81);
            this.cbCustom.Margin = new System.Windows.Forms.Padding(2);
            this.cbCustom.Name = "cbCustom";
            this.cbCustom.Size = new System.Drawing.Size(92, 17);
            this.cbCustom.TabIndex = 25;
            this.cbCustom.Text = "Personalizado";
            this.cbCustom.UseVisualStyleBackColor = true;
            this.cbCustom.CheckedChanged += new System.EventHandler(this.CbCustom_CheckedChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 43);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(293, 26);
            this.label3.TabIndex = 22;
            this.label3.Text = "Esta opción iniciará una simulación de todos los datos desde\r\nel menor tiempo enc" +
    "ontrado:";
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
            this.panelCustomSimulation.Location = new System.Drawing.Point(2, 147);
            this.panelCustomSimulation.Margin = new System.Windows.Forms.Padding(2);
            this.panelCustomSimulation.Name = "panelCustomSimulation";
            this.panelCustomSimulation.Size = new System.Drawing.Size(283, 69);
            this.panelCustomSimulation.TabIndex = 21;
            this.panelCustomSimulation.Visible = false;
            // 
            // btCustomSimulationt
            // 
            this.btCustomSimulationt.Location = new System.Drawing.Point(209, 32);
            this.btCustomSimulationt.Margin = new System.Windows.Forms.Padding(2);
            this.btCustomSimulationt.Name = "btCustomSimulationt";
            this.btCustomSimulationt.Size = new System.Drawing.Size(67, 32);
            this.btCustomSimulationt.TabIndex = 7;
            this.btCustomSimulationt.Text = "Iniciar";
            this.btCustomSimulationt.UseVisualStyleBackColor = true;
            this.btCustomSimulationt.Visible = false;
            this.btCustomSimulationt.Click += new System.EventHandler(this.BtCustomSimulationt_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(143, 9);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(36, 13);
            this.label11.TabIndex = 6;
            this.label11.Text = "desde";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(125, 9);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(21, 13);
            this.label10.TabIndex = 5;
            this.label10.Text = "hrs";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(2, 9);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(80, 13);
            this.label9.TabIndex = 4;
            this.label9.Text = "Simular durante";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(247, 6);
            this.textBox4.Margin = new System.Windows.Forms.Padding(2);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(30, 20);
            this.textBox4.TabIndex = 3;
            this.textBox4.Visible = false;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(212, 6);
            this.textBox3.Margin = new System.Windows.Forms.Padding(2);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(31, 20);
            this.textBox3.TabIndex = 2;
            this.textBox3.Visible = false;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(180, 6);
            this.textBox2.Margin = new System.Windows.Forms.Padding(2);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(29, 20);
            this.textBox2.TabIndex = 1;
            this.textBox2.Visible = false;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(83, 6);
            this.textBox1.Margin = new System.Windows.Forms.Padding(2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(38, 20);
            this.textBox1.TabIndex = 0;
            this.textBox1.Visible = false;
            this.textBox1.TextChanged += new System.EventHandler(this.TextBox1_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(58, 4);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(178, 23);
            this.label5.TabIndex = 19;
            this.label5.Text = "RUTAS EN ACCIÓN";
            // 
            // btSimulacionCompleta
            // 
            this.btSimulacionCompleta.Location = new System.Drawing.Point(156, 81);
            this.btSimulacionCompleta.Name = "btSimulacionCompleta";
            this.btSimulacionCompleta.Size = new System.Drawing.Size(116, 23);
            this.btSimulacionCompleta.TabIndex = 20;
            this.btSimulacionCompleta.Text = "Simulacion completa";
            this.btSimulacionCompleta.UseVisualStyleBackColor = true;
            this.btSimulacionCompleta.Visible = false;
            this.btSimulacionCompleta.Click += new System.EventHandler(this.BtSimulacionCompleta_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(826, 100);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 13);
            this.label6.TabIndex = 24;
            this.label6.Text = "Hora actual:";
            // 
            // lblHora
            // 
            this.lblHora.AutoSize = true;
            this.lblHora.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHora.Location = new System.Drawing.Point(909, 96);
            this.lblHora.Name = "lblHora";
            this.lblHora.Size = new System.Drawing.Size(90, 21);
            this.lblHora.TabIndex = 25;
            this.lblHora.Text = "HH:MM:SS";
            this.lblHora.Click += new System.EventHandler(this.Label7_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // checkBParadas
            // 
            this.checkBParadas.AutoSize = true;
            this.checkBParadas.Location = new System.Drawing.Point(11, 190);
            this.checkBParadas.Name = "checkBParadas";
            this.checkBParadas.Size = new System.Drawing.Size(65, 17);
            this.checkBParadas.TabIndex = 28;
            this.checkBParadas.Text = "Paradas";
            this.checkBParadas.UseVisualStyleBackColor = true;
            this.checkBParadas.CheckedChanged += new System.EventHandler(this.CheckBParadas_CheckedChanged_1);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(8, 156);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(169, 26);
            this.label7.TabIndex = 27;
            this.label7.Text = "¿Desea conocer las paradas\r\ndel mio en dicha zona?";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1067, 673);
            this.Controls.Add(this.lblHora);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.paneOp2);
            this.Controls.Add(this.paneOp1);
            this.Controls.Add(this.pictureBox1);
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
            this.Margin = new System.Windows.Forms.Padding(2);
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
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btCustomSimulation;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.CheckBox checkBParadas;
        private System.Windows.Forms.Label label7;
    }
}

