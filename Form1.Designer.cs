
namespace sistemas_operativos
{
    partial class frmSO
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.informacionDelSistemaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hardwareToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.softwareToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.procesosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.monitoreoDeRecursosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.redesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.concurrenciaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.interbloqueoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.grpwindows = new System.Windows.Forms.GroupBox();
            this.btnAceptarVersion = new System.Windows.Forms.Button();
            this.lblVWindows = new System.Windows.Forms.Label();
            this.lblWindows = new System.Windows.Forms.Label();
            this.grpHardware = new System.Windows.Forms.GroupBox();
            this.lvHardware = new System.Windows.Forms.ListView();
            this.btnAceptHardware = new System.Windows.Forms.Button();
            this.grpSoftware = new System.Windows.Forms.GroupBox();
            this.btnAceptarSoftwares = new System.Windows.Forms.Button();
            this.lvSoftware = new System.Windows.Forms.ListView();
            this.grpProcesos = new System.Windows.Forms.GroupBox();
            this.BtnAceptarProcesos = new System.Windows.Forms.Button();
            this.btnMaatarTodos = new System.Windows.Forms.Button();
            this.btnMatar = new System.Windows.Forms.Button();
            this.btnPausar = new System.Windows.Forms.Button();
            this.lbxProcesos = new System.Windows.Forms.ListBox();
            this.lblProcesos = new System.Windows.Forms.Label();
            this.grpMonitoreo = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lvMonitoreo = new System.Windows.Forms.ListView();
            this.btnAceptarMonitoreo = new System.Windows.Forms.Button();
            this.btnAceptarRedes = new System.Windows.Forms.Button();
            this.grpConcurrencia = new System.Windows.Forms.GroupBox();
            this.btnAceptarConcurrencia = new System.Windows.Forms.Button();
            this.lvOrdenes = new System.Windows.Forms.ListView();
            this.ORDENES = new System.Windows.Forms.ColumnHeader();
            this.TIEMPO = new System.Windows.Forms.ColumnHeader();
            this.label4 = new System.Windows.Forms.Label();
            this.txtCantidadPlatillo = new System.Windows.Forms.TextBox();
            this.cbxMenu = new System.Windows.Forms.ComboBox();
            this.txtCantidadBebida = new System.Windows.Forms.TextBox();
            this.cbxBebida = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnNuevaOrden = new System.Windows.Forms.Button();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.lblNotificationOrden = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.grpwindows.SuspendLayout();
            this.grpHardware.SuspendLayout();
            this.grpSoftware.SuspendLayout();
            this.grpProcesos.SuspendLayout();
            this.grpMonitoreo.SuspendLayout();
            this.grpConcurrencia.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoEllipsis = true;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(355, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(485, 62);
            this.label1.TabIndex = 0;
            this.label1.Tag = "ot";
            this.label1.Text = "Sistemas  Operativos";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.salirToolStripMenuItem,
            this.informacionDelSistemaToolStripMenuItem,
            this.hardwareToolStripMenuItem,
            this.softwareToolStripMenuItem,
            this.procesosToolStripMenuItem,
            this.monitoreoDeRecursosToolStripMenuItem,
            this.redesToolStripMenuItem,
            this.concurrenciaToolStripMenuItem,
            this.interbloqueoToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1129, 28);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(50, 24);
            this.salirToolStripMenuItem.Text = "salir";
            // 
            // informacionDelSistemaToolStripMenuItem
            // 
            this.informacionDelSistemaToolStripMenuItem.Name = "informacionDelSistemaToolStripMenuItem";
            this.informacionDelSistemaToolStripMenuItem.Size = new System.Drawing.Size(157, 24);
            this.informacionDelSistemaToolStripMenuItem.Text = "Version de Windows";
            this.informacionDelSistemaToolStripMenuItem.Click += new System.EventHandler(this.informacionDelSistemaToolStripMenuItem_Click);
            // 
            // hardwareToolStripMenuItem
            // 
            this.hardwareToolStripMenuItem.Name = "hardwareToolStripMenuItem";
            this.hardwareToolStripMenuItem.Size = new System.Drawing.Size(88, 24);
            this.hardwareToolStripMenuItem.Text = "Hardware";
            this.hardwareToolStripMenuItem.Click += new System.EventHandler(this.hardwareToolStripMenuItem_Click);
            // 
            // softwareToolStripMenuItem
            // 
            this.softwareToolStripMenuItem.Name = "softwareToolStripMenuItem";
            this.softwareToolStripMenuItem.Size = new System.Drawing.Size(80, 24);
            this.softwareToolStripMenuItem.Text = "software";
            this.softwareToolStripMenuItem.Click += new System.EventHandler(this.softwareToolStripMenuItem_Click);
            // 
            // procesosToolStripMenuItem
            // 
            this.procesosToolStripMenuItem.Name = "procesosToolStripMenuItem";
            this.procesosToolStripMenuItem.Size = new System.Drawing.Size(85, 24);
            this.procesosToolStripMenuItem.Text = "Procesos ";
            this.procesosToolStripMenuItem.Click += new System.EventHandler(this.procesosToolStripMenuItem_Click);
            // 
            // monitoreoDeRecursosToolStripMenuItem
            // 
            this.monitoreoDeRecursosToolStripMenuItem.Name = "monitoreoDeRecursosToolStripMenuItem";
            this.monitoreoDeRecursosToolStripMenuItem.Size = new System.Drawing.Size(176, 24);
            this.monitoreoDeRecursosToolStripMenuItem.Text = "Monitoreo de Recursos";
            this.monitoreoDeRecursosToolStripMenuItem.Click += new System.EventHandler(this.monitoreoDeRecursosToolStripMenuItem_Click);
            // 
            // redesToolStripMenuItem
            // 
            this.redesToolStripMenuItem.Name = "redesToolStripMenuItem";
            this.redesToolStripMenuItem.Size = new System.Drawing.Size(63, 24);
            this.redesToolStripMenuItem.Text = "Redes";
            this.redesToolStripMenuItem.Click += new System.EventHandler(this.redesToolStripMenuItem_Click);
            // 
            // concurrenciaToolStripMenuItem
            // 
            this.concurrenciaToolStripMenuItem.Name = "concurrenciaToolStripMenuItem";
            this.concurrenciaToolStripMenuItem.Size = new System.Drawing.Size(109, 24);
            this.concurrenciaToolStripMenuItem.Text = "Concurrencia";
            this.concurrenciaToolStripMenuItem.Click += new System.EventHandler(this.concurrenciaToolStripMenuItem_Click);
            // 
            // interbloqueoToolStripMenuItem
            // 
            this.interbloqueoToolStripMenuItem.Name = "interbloqueoToolStripMenuItem";
            this.interbloqueoToolStripMenuItem.Size = new System.Drawing.Size(109, 24);
            this.interbloqueoToolStripMenuItem.Text = "Interbloqueo";
            // 
            // colorDialog1
            // 
            this.colorDialog1.Color = System.Drawing.Color.DimGray;
            // 
            // grpwindows
            // 
            this.grpwindows.Controls.Add(this.btnAceptarVersion);
            this.grpwindows.Controls.Add(this.lblVWindows);
            this.grpwindows.Controls.Add(this.lblWindows);
            this.grpwindows.Location = new System.Drawing.Point(111, 106);
            this.grpwindows.Name = "grpwindows";
            this.grpwindows.Size = new System.Drawing.Size(900, 353);
            this.grpwindows.TabIndex = 2;
            this.grpwindows.TabStop = false;
            this.grpwindows.Visible = false;
            // 
            // btnAceptarVersion
            // 
            this.btnAceptarVersion.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.btnAceptarVersion.ForeColor = System.Drawing.Color.White;
            this.btnAceptarVersion.Location = new System.Drawing.Point(787, 311);
            this.btnAceptarVersion.Name = "btnAceptarVersion";
            this.btnAceptarVersion.Size = new System.Drawing.Size(113, 36);
            this.btnAceptarVersion.TabIndex = 2;
            this.btnAceptarVersion.Text = "Aceptar";
            this.btnAceptarVersion.UseVisualStyleBackColor = false;
            this.btnAceptarVersion.Click += new System.EventHandler(this.btnAceptarVersion_Click);
            // 
            // lblVWindows
            // 
            this.lblVWindows.AutoSize = true;
            this.lblVWindows.Location = new System.Drawing.Point(244, 224);
            this.lblVWindows.Name = "lblVWindows";
            this.lblVWindows.Size = new System.Drawing.Size(0, 20);
            this.lblVWindows.TabIndex = 1;
            // 
            // lblWindows
            // 
            this.lblWindows.AutoSize = true;
            this.lblWindows.Location = new System.Drawing.Point(244, 103);
            this.lblWindows.Name = "lblWindows";
            this.lblWindows.Size = new System.Drawing.Size(0, 20);
            this.lblWindows.TabIndex = 0;
            // 
            // grpHardware
            // 
            this.grpHardware.Controls.Add(this.lvHardware);
            this.grpHardware.Controls.Add(this.btnAceptHardware);
            this.grpHardware.Location = new System.Drawing.Point(111, 106);
            this.grpHardware.Name = "grpHardware";
            this.grpHardware.Size = new System.Drawing.Size(900, 353);
            this.grpHardware.TabIndex = 3;
            this.grpHardware.TabStop = false;
            this.grpHardware.Visible = false;
            // 
            // lvHardware
            // 
            this.lvHardware.HideSelection = false;
            this.lvHardware.Location = new System.Drawing.Point(93, 41);
            this.lvHardware.Name = "lvHardware";
            this.lvHardware.Size = new System.Drawing.Size(645, 276);
            this.lvHardware.TabIndex = 2;
            this.lvHardware.UseCompatibleStateImageBehavior = false;
            this.lvHardware.View = System.Windows.Forms.View.List;
            // 
            // btnAceptHardware
            // 
            this.btnAceptHardware.BackColor = System.Drawing.Color.White;
            this.btnAceptHardware.Location = new System.Drawing.Point(737, 311);
            this.btnAceptHardware.Name = "btnAceptHardware";
            this.btnAceptHardware.Size = new System.Drawing.Size(163, 42);
            this.btnAceptHardware.TabIndex = 1;
            this.btnAceptHardware.Text = "Aceptar";
            this.btnAceptHardware.UseVisualStyleBackColor = false;
            this.btnAceptHardware.Click += new System.EventHandler(this.btnAceptHardware_Click);
            // 
            // grpSoftware
            // 
            this.grpSoftware.Controls.Add(this.btnAceptarSoftwares);
            this.grpSoftware.Controls.Add(this.lvSoftware);
            this.grpSoftware.Location = new System.Drawing.Point(47, 93);
            this.grpSoftware.Name = "grpSoftware";
            this.grpSoftware.Size = new System.Drawing.Size(822, 403);
            this.grpSoftware.TabIndex = 4;
            this.grpSoftware.TabStop = false;
            this.grpSoftware.Visible = false;
            // 
            // btnAceptarSoftwares
            // 
            this.btnAceptarSoftwares.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnAceptarSoftwares.ForeColor = System.Drawing.Color.White;
            this.btnAceptarSoftwares.Location = new System.Drawing.Point(667, 360);
            this.btnAceptarSoftwares.Name = "btnAceptarSoftwares";
            this.btnAceptarSoftwares.Size = new System.Drawing.Size(151, 42);
            this.btnAceptarSoftwares.TabIndex = 1;
            this.btnAceptarSoftwares.Text = "Aceptar";
            this.btnAceptarSoftwares.UseVisualStyleBackColor = false;
            this.btnAceptarSoftwares.Click += new System.EventHandler(this.btnAceptarSoftwares_Click);
            // 
            // lvSoftware
            // 
            this.lvSoftware.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.lvSoftware.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lvSoftware.ForeColor = System.Drawing.Color.White;
            this.lvSoftware.HideSelection = false;
            this.lvSoftware.Location = new System.Drawing.Point(75, 17);
            this.lvSoftware.Name = "lvSoftware";
            this.lvSoftware.Size = new System.Drawing.Size(693, 321);
            this.lvSoftware.TabIndex = 0;
            this.lvSoftware.UseCompatibleStateImageBehavior = false;
            this.lvSoftware.View = System.Windows.Forms.View.List;
            // 
            // grpProcesos
            // 
            this.grpProcesos.Controls.Add(this.BtnAceptarProcesos);
            this.grpProcesos.Controls.Add(this.btnMaatarTodos);
            this.grpProcesos.Controls.Add(this.btnMatar);
            this.grpProcesos.Controls.Add(this.btnPausar);
            this.grpProcesos.Controls.Add(this.lbxProcesos);
            this.grpProcesos.Controls.Add(this.lblProcesos);
            this.grpProcesos.Location = new System.Drawing.Point(178, 93);
            this.grpProcesos.Name = "grpProcesos";
            this.grpProcesos.Size = new System.Drawing.Size(765, 449);
            this.grpProcesos.TabIndex = 5;
            this.grpProcesos.TabStop = false;
            this.grpProcesos.Visible = false;
            // 
            // BtnAceptarProcesos
            // 
            this.BtnAceptarProcesos.Location = new System.Drawing.Point(595, 390);
            this.BtnAceptarProcesos.Name = "BtnAceptarProcesos";
            this.BtnAceptarProcesos.Size = new System.Drawing.Size(139, 29);
            this.BtnAceptarProcesos.TabIndex = 6;
            this.BtnAceptarProcesos.Text = "Aceptar";
            this.BtnAceptarProcesos.UseVisualStyleBackColor = true;
            this.BtnAceptarProcesos.Click += new System.EventHandler(this.BtnAceptarProcesos_Click);
            // 
            // btnMaatarTodos
            // 
            this.btnMaatarTodos.Location = new System.Drawing.Point(595, 287);
            this.btnMaatarTodos.Name = "btnMaatarTodos";
            this.btnMaatarTodos.Size = new System.Drawing.Size(139, 29);
            this.btnMaatarTodos.TabIndex = 5;
            this.btnMaatarTodos.Text = "MatarTodos";
            this.btnMaatarTodos.UseVisualStyleBackColor = true;
            // 
            // btnMatar
            // 
            this.btnMatar.Location = new System.Drawing.Point(595, 224);
            this.btnMatar.Name = "btnMatar";
            this.btnMatar.Size = new System.Drawing.Size(139, 29);
            this.btnMatar.TabIndex = 4;
            this.btnMatar.Text = "Matar";
            this.btnMatar.UseVisualStyleBackColor = true;
            // 
            // btnPausar
            // 
            this.btnPausar.Location = new System.Drawing.Point(595, 160);
            this.btnPausar.Name = "btnPausar";
            this.btnPausar.Size = new System.Drawing.Size(139, 31);
            this.btnPausar.TabIndex = 3;
            this.btnPausar.Text = "Pausar";
            this.btnPausar.UseVisualStyleBackColor = true;
            // 
            // lbxProcesos
            // 
            this.lbxProcesos.FormattingEnabled = true;
            this.lbxProcesos.ItemHeight = 20;
            this.lbxProcesos.Location = new System.Drawing.Point(50, 116);
            this.lbxProcesos.Name = "lbxProcesos";
            this.lbxProcesos.Size = new System.Drawing.Size(501, 304);
            this.lbxProcesos.TabIndex = 2;
            // 
            // lblProcesos
            // 
            this.lblProcesos.AutoSize = true;
            this.lblProcesos.Location = new System.Drawing.Point(214, 93);
            this.lblProcesos.Name = "lblProcesos";
            this.lblProcesos.Size = new System.Drawing.Size(146, 20);
            this.lblProcesos.TabIndex = 1;
            this.lblProcesos.Text = "Procesos del sistema";
            this.lblProcesos.Click += new System.EventHandler(this.lblProcesos_Click);
            // 
            // grpMonitoreo
            // 
            this.grpMonitoreo.Controls.Add(this.label2);
            this.grpMonitoreo.Controls.Add(this.lvMonitoreo);
            this.grpMonitoreo.Controls.Add(this.btnAceptarMonitoreo);
            this.grpMonitoreo.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.grpMonitoreo.Location = new System.Drawing.Point(97, 93);
            this.grpMonitoreo.Name = "grpMonitoreo";
            this.grpMonitoreo.Size = new System.Drawing.Size(860, 430);
            this.grpMonitoreo.TabIndex = 6;
            this.grpMonitoreo.TabStop = false;
            this.grpMonitoreo.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label2.Location = new System.Drawing.Point(339, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(261, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Uso del CPU  durante los 10 Segundos";
            // 
            // lvMonitoreo
            // 
            this.lvMonitoreo.BackColor = System.Drawing.SystemColors.MenuBar;
            this.lvMonitoreo.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.lvMonitoreo.HideSelection = false;
            this.lvMonitoreo.Location = new System.Drawing.Point(168, 107);
            this.lvMonitoreo.Name = "lvMonitoreo";
            this.lvMonitoreo.Size = new System.Drawing.Size(600, 323);
            this.lvMonitoreo.TabIndex = 1;
            this.lvMonitoreo.UseCompatibleStateImageBehavior = false;
            this.lvMonitoreo.View = System.Windows.Forms.View.List;
            // 
            // btnAceptarMonitoreo
            // 
            this.btnAceptarMonitoreo.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnAceptarMonitoreo.Location = new System.Drawing.Point(766, 401);
            this.btnAceptarMonitoreo.Name = "btnAceptarMonitoreo";
            this.btnAceptarMonitoreo.Size = new System.Drawing.Size(94, 29);
            this.btnAceptarMonitoreo.TabIndex = 0;
            this.btnAceptarMonitoreo.Text = "Aceptar";
            this.btnAceptarMonitoreo.UseVisualStyleBackColor = true;
            this.btnAceptarMonitoreo.Click += new System.EventHandler(this.btnAceptarMonitoreo_Click);
            // 
            // btnAceptarRedes
            // 
            this.btnAceptarRedes.Location = new System.Drawing.Point(1030, 533);
            this.btnAceptarRedes.Name = "btnAceptarRedes";
            this.btnAceptarRedes.Size = new System.Drawing.Size(94, 29);
            this.btnAceptarRedes.TabIndex = 7;
            this.btnAceptarRedes.Text = "Aceptar";
            this.btnAceptarRedes.UseVisualStyleBackColor = true;
            this.btnAceptarRedes.Visible = false;
            // 
            // grpConcurrencia
            // 
            this.grpConcurrencia.Controls.Add(this.lblNotificationOrden);
            this.grpConcurrencia.Controls.Add(this.btnAceptarConcurrencia);
            this.grpConcurrencia.Controls.Add(this.lvOrdenes);
            this.grpConcurrencia.Controls.Add(this.label4);
            this.grpConcurrencia.Controls.Add(this.txtCantidadPlatillo);
            this.grpConcurrencia.Controls.Add(this.cbxMenu);
            this.grpConcurrencia.Controls.Add(this.txtCantidadBebida);
            this.grpConcurrencia.Controls.Add(this.cbxBebida);
            this.grpConcurrencia.Controls.Add(this.label3);
            this.grpConcurrencia.Controls.Add(this.btnNuevaOrden);
            this.grpConcurrencia.Location = new System.Drawing.Point(0, 31);
            this.grpConcurrencia.Name = "grpConcurrencia";
            this.grpConcurrencia.Size = new System.Drawing.Size(1124, 562);
            this.grpConcurrencia.TabIndex = 8;
            this.grpConcurrencia.TabStop = false;
            this.grpConcurrencia.Visible = false;
            // 
            // btnAceptarConcurrencia
            // 
            this.btnAceptarConcurrencia.Location = new System.Drawing.Point(1012, 482);
            this.btnAceptarConcurrencia.Name = "btnAceptarConcurrencia";
            this.btnAceptarConcurrencia.Size = new System.Drawing.Size(94, 29);
            this.btnAceptarConcurrencia.TabIndex = 8;
            this.btnAceptarConcurrencia.Text = "Aceptar";
            this.btnAceptarConcurrencia.UseVisualStyleBackColor = true;
            this.btnAceptarConcurrencia.Click += new System.EventHandler(this.btnAceptarConcurrencia_Click);
            // 
            // lvOrdenes
            // 
            this.lvOrdenes.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ORDENES,
            this.TIEMPO});
            this.lvOrdenes.HideSelection = false;
            this.lvOrdenes.Location = new System.Drawing.Point(592, 188);
            this.lvOrdenes.Name = "lvOrdenes";
            this.lvOrdenes.Size = new System.Drawing.Size(514, 241);
            this.lvOrdenes.TabIndex = 7;
            this.lvOrdenes.UseCompatibleStateImageBehavior = false;
            this.lvOrdenes.View = System.Windows.Forms.View.List;
            // 
            // ORDENES
            // 
            this.ORDENES.Text = "ORDENES LISTOS";
            this.ORDENES.Width = 300;
            // 
            // TIEMPO
            // 
            this.TIEMPO.Text = "TIEMPO";
            this.TIEMPO.Width = 200;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(228, 146);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(174, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "M E N U      D E L     D I A";
            // 
            // txtCantidadPlatillo
            // 
            this.txtCantidadPlatillo.Location = new System.Drawing.Point(323, 188);
            this.txtCantidadPlatillo.Name = "txtCantidadPlatillo";
            this.txtCantidadPlatillo.PlaceholderText = "Cantidad";
            this.txtCantidadPlatillo.Size = new System.Drawing.Size(125, 27);
            this.txtCantidadPlatillo.TabIndex = 5;
            // 
            // cbxMenu
            // 
            this.cbxMenu.FormattingEnabled = true;
            this.cbxMenu.Items.AddRange(new object[] {
            "HAMBURGUESA",
            "TORTA MEXICANA",
            "PIZZA"});
            this.cbxMenu.Location = new System.Drawing.Point(138, 187);
            this.cbxMenu.Name = "cbxMenu";
            this.cbxMenu.Size = new System.Drawing.Size(179, 28);
            this.cbxMenu.TabIndex = 4;
            this.cbxMenu.Text = "Selecione su platillo";
            // 
            // txtCantidadBebida
            // 
            this.txtCantidadBebida.Location = new System.Drawing.Point(323, 287);
            this.txtCantidadBebida.Name = "txtCantidadBebida";
            this.txtCantidadBebida.PlaceholderText = "Cantidad";
            this.txtCantidadBebida.Size = new System.Drawing.Size(125, 27);
            this.txtCantidadBebida.TabIndex = 3;
            // 
            // cbxBebida
            // 
            this.cbxBebida.FormattingEnabled = true;
            this.cbxBebida.Items.AddRange(new object[] {
            "Coca-cola12onz",
            "Pepsi_cola12onz"});
            this.cbxBebida.Location = new System.Drawing.Point(138, 286);
            this.cbxBebida.Name = "cbxBebida";
            this.cbxBebida.Size = new System.Drawing.Size(179, 28);
            this.cbxBebida.TabIndex = 2;
            this.cbxBebida.Text = "Seleccione la  Bebida";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(436, 52);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(131, 20);
            this.label3.TabIndex = 1;
            this.label3.Text = "C A F E  T E R R I A";
            // 
            // btnNuevaOrden
            // 
            this.btnNuevaOrden.Location = new System.Drawing.Point(138, 393);
            this.btnNuevaOrden.Name = "btnNuevaOrden";
            this.btnNuevaOrden.Size = new System.Drawing.Size(382, 29);
            this.btnNuevaOrden.TabIndex = 0;
            this.btnNuevaOrden.Text = "O R D E N A R ";
            this.btnNuevaOrden.UseVisualStyleBackColor = true;
            this.btnNuevaOrden.Click += new System.EventHandler(this.btnNuevaOrden_Click);
            // 
            // lblNotificationOrden
            // 
            this.lblNotificationOrden.AutoSize = true;
            this.lblNotificationOrden.ForeColor = System.Drawing.Color.Blue;
            this.lblNotificationOrden.Location = new System.Drawing.Point(280, 442);
            this.lblNotificationOrden.Name = "lblNotificationOrden";
            this.lblNotificationOrden.Size = new System.Drawing.Size(0, 20);
            this.lblNotificationOrden.TabIndex = 9;
            // 
            // frmSO
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1129, 561);
            this.Controls.Add(this.grpConcurrencia);
            this.Controls.Add(this.btnAceptarRedes);
            this.Controls.Add(this.grpMonitoreo);
            this.Controls.Add(this.grpProcesos);
            this.Controls.Add(this.grpSoftware);
            this.Controls.Add(this.grpHardware);
            this.Controls.Add(this.grpwindows);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmSO";
            this.Text = "Sistemas Operativos";
            this.Load += new System.EventHandler(this.frmSO_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.grpwindows.ResumeLayout(false);
            this.grpwindows.PerformLayout();
            this.grpHardware.ResumeLayout(false);
            this.grpSoftware.ResumeLayout(false);
            this.grpProcesos.ResumeLayout(false);
            this.grpProcesos.PerformLayout();
            this.grpMonitoreo.ResumeLayout(false);
            this.grpMonitoreo.PerformLayout();
            this.grpConcurrencia.ResumeLayout(false);
            this.grpConcurrencia.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem informacionDelSistemaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hardwareToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem softwareToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem procesosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem monitoreoDeRecursosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem redesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem concurrenciaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem interbloqueoToolStripMenuItem;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.GroupBox grpwindows;
        private System.Windows.Forms.Label lblWindows;
        private System.Windows.Forms.Label lblVWindows;
        private System.Windows.Forms.Button btnAceptarVersion;
        private System.Windows.Forms.GroupBox grpHardware;
        private System.Windows.Forms.Button btnAceptHardware;
        private System.Windows.Forms.ListView lvHardware;
        private System.Windows.Forms.GroupBox grpSoftware;
        private System.Windows.Forms.ListView lvSoftware;
        private System.Windows.Forms.Button btnAceptarSoftwares;
        private System.Windows.Forms.GroupBox grpProcesos;
        private System.Windows.Forms.ListBox lbxProcesos;
        private System.Windows.Forms.Label lblProcesos;
        private System.Windows.Forms.Button BtnAceptarProcesos;
        private System.Windows.Forms.Button btnMaatarTodos;
        private System.Windows.Forms.Button btnMatar;
        private System.Windows.Forms.Button btnPausar;
        private System.Windows.Forms.GroupBox grpMonitoreo;
        private System.Windows.Forms.Button btnAceptarMonitoreo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListView lvMonitoreo;
        private System.Windows.Forms.Button btnAceptarRedes;
        private System.Windows.Forms.GroupBox grpConcurrencia;
        private System.Windows.Forms.Button btnAceptarConcurrencia;
        private System.Windows.Forms.ListView lvOrdenes;
        private System.Windows.Forms.ColumnHeader ORDENES;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtCantidadPlatillo;
        private System.Windows.Forms.ComboBox cbxMenu;
        private System.Windows.Forms.TextBox txtCantidadBebida;
        private System.Windows.Forms.ComboBox cbxBebida;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnNuevaOrden;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.ColumnHeader TIEMPO;
        private System.Windows.Forms.Label lblNotificationOrden;
    }
}

