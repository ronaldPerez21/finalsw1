
namespace vehicle_speed_project
{
    partial class MyProject
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.MenuStrip menuStrip1;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MyProject));
            this.archivosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.abrirVideoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.abrirCámaraToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.analizarImagenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tamañoDeEntradaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.normalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.estiramientoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.automáticoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.centradoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zoomToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.trackBarVideo = new System.Windows.Forms.TrackBar();
            this.labelInfoCapture = new System.Windows.Forms.Label();
            this.labelTitlePlate = new System.Windows.Forms.Label();
            this.panelPlateText = new System.Windows.Forms.Panel();
            this.labelSpeedResult = new System.Windows.Forms.Label();
            this.labelResult = new System.Windows.Forms.Label();
            this.labelColor = new System.Windows.Forms.Label();
            this.labelColorTitle = new System.Windows.Forms.Label();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.panelCapture = new System.Windows.Forms.Panel();
            this.pictureBoxPlate = new System.Windows.Forms.PictureBox();
            this.pictureBoxCapture = new System.Windows.Forms.PictureBox();
            this.pictureBoxInput = new System.Windows.Forms.PictureBox();
            this.btnCapture = new System.Windows.Forms.Button();
            this.btnPause = new System.Windows.Forms.Button();
            this.btnPlay = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            menuStrip1 = new System.Windows.Forms.MenuStrip();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarVideo)).BeginInit();
            this.panelPlateText.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.panelCapture.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPlate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCapture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxInput)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible;
            menuStrip1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivosToolStripMenuItem,
            this.tamañoDeEntradaToolStripMenuItem});
            menuStrip1.Location = new System.Drawing.Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            menuStrip1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            menuStrip1.ShowItemToolTips = true;
            menuStrip1.Size = new System.Drawing.Size(1252, 29);
            menuStrip1.Stretch = false;
            menuStrip1.TabIndex = 1;
            menuStrip1.TabStop = true;
            menuStrip1.Text = "menuStrip1";
            // 
            // archivosToolStripMenuItem
            // 
            this.archivosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.abrirVideoToolStripMenuItem,
            this.abrirCámaraToolStripMenuItem,
            this.analizarImagenToolStripMenuItem});
            this.archivosToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.archivosToolStripMenuItem.Name = "archivosToolStripMenuItem";
            this.archivosToolStripMenuItem.Size = new System.Drawing.Size(82, 25);
            this.archivosToolStripMenuItem.Text = "Archivos";
            // 
            // abrirVideoToolStripMenuItem
            // 
            this.abrirVideoToolStripMenuItem.Name = "abrirVideoToolStripMenuItem";
            this.abrirVideoToolStripMenuItem.Size = new System.Drawing.Size(192, 26);
            this.abrirVideoToolStripMenuItem.Text = "Abrir video";
            this.abrirVideoToolStripMenuItem.Click += new System.EventHandler(this.abrirVideoToolStripMenuItem_Click);
            // 
            // abrirCámaraToolStripMenuItem
            // 
            this.abrirCámaraToolStripMenuItem.Name = "abrirCámaraToolStripMenuItem";
            this.abrirCámaraToolStripMenuItem.Size = new System.Drawing.Size(192, 26);
            this.abrirCámaraToolStripMenuItem.Text = "Abrir cámara";
            this.abrirCámaraToolStripMenuItem.Click += new System.EventHandler(this.abrirCámaraToolStripMenuItem_Click);
            // 
            // analizarImagenToolStripMenuItem
            // 
            this.analizarImagenToolStripMenuItem.Name = "analizarImagenToolStripMenuItem";
            this.analizarImagenToolStripMenuItem.Size = new System.Drawing.Size(192, 26);
            this.analizarImagenToolStripMenuItem.Text = "Analizar Imagen";
            this.analizarImagenToolStripMenuItem.Click += new System.EventHandler(this.analizarImagenToolStripMenuItem_Click);
            // 
            // tamañoDeEntradaToolStripMenuItem
            // 
            this.tamañoDeEntradaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.normalToolStripMenuItem,
            this.estiramientoToolStripMenuItem,
            this.automáticoToolStripMenuItem,
            this.centradoToolStripMenuItem,
            this.zoomToolStripMenuItem});
            this.tamañoDeEntradaToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tamañoDeEntradaToolStripMenuItem.Name = "tamañoDeEntradaToolStripMenuItem";
            this.tamañoDeEntradaToolStripMenuItem.Size = new System.Drawing.Size(154, 25);
            this.tamañoDeEntradaToolStripMenuItem.Text = "Tamaño de entrada";
            // 
            // normalToolStripMenuItem
            // 
            this.normalToolStripMenuItem.Name = "normalToolStripMenuItem";
            this.normalToolStripMenuItem.Size = new System.Drawing.Size(167, 26);
            this.normalToolStripMenuItem.Text = "Normal";
            this.normalToolStripMenuItem.Click += new System.EventHandler(this.normalToolStripMenuItem_Click);
            // 
            // estiramientoToolStripMenuItem
            // 
            this.estiramientoToolStripMenuItem.Name = "estiramientoToolStripMenuItem";
            this.estiramientoToolStripMenuItem.Size = new System.Drawing.Size(167, 26);
            this.estiramientoToolStripMenuItem.Text = "Estiramiento";
            this.estiramientoToolStripMenuItem.Click += new System.EventHandler(this.estiramientoToolStripMenuItem_Click);
            // 
            // automáticoToolStripMenuItem
            // 
            this.automáticoToolStripMenuItem.Name = "automáticoToolStripMenuItem";
            this.automáticoToolStripMenuItem.Size = new System.Drawing.Size(167, 26);
            this.automáticoToolStripMenuItem.Text = "Automático";
            this.automáticoToolStripMenuItem.Click += new System.EventHandler(this.automáticoToolStripMenuItem_Click);
            // 
            // centradoToolStripMenuItem
            // 
            this.centradoToolStripMenuItem.Name = "centradoToolStripMenuItem";
            this.centradoToolStripMenuItem.Size = new System.Drawing.Size(167, 26);
            this.centradoToolStripMenuItem.Text = "Centrado";
            this.centradoToolStripMenuItem.Click += new System.EventHandler(this.centradoToolStripMenuItem_Click);
            // 
            // zoomToolStripMenuItem
            // 
            this.zoomToolStripMenuItem.Name = "zoomToolStripMenuItem";
            this.zoomToolStripMenuItem.Size = new System.Drawing.Size(167, 26);
            this.zoomToolStripMenuItem.Text = "Zoom";
            this.zoomToolStripMenuItem.Click += new System.EventHandler(this.zoomToolStripMenuItem_Click);
            // 
            // trackBarVideo
            // 
            this.trackBarVideo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.trackBarVideo.AutoSize = false;
            this.trackBarVideo.Location = new System.Drawing.Point(12, 6);
            this.trackBarVideo.Name = "trackBarVideo";
            this.trackBarVideo.Size = new System.Drawing.Size(1224, 38);
            this.trackBarVideo.TabIndex = 6;
            this.trackBarVideo.TickStyle = System.Windows.Forms.TickStyle.Both;
            // 
            // labelInfoCapture
            // 
            this.labelInfoCapture.AutoSize = true;
            this.labelInfoCapture.BackColor = System.Drawing.SystemColors.Control;
            this.labelInfoCapture.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelInfoCapture.Location = new System.Drawing.Point(92, 262);
            this.labelInfoCapture.Name = "labelInfoCapture";
            this.labelInfoCapture.Size = new System.Drawing.Size(104, 20);
            this.labelInfoCapture.TabIndex = 19;
            this.labelInfoCapture.Text = "info message";
            // 
            // labelTitlePlate
            // 
            this.labelTitlePlate.AutoSize = true;
            this.labelTitlePlate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitlePlate.Location = new System.Drawing.Point(3, 294);
            this.labelTitlePlate.Name = "labelTitlePlate";
            this.labelTitlePlate.Size = new System.Drawing.Size(53, 20);
            this.labelTitlePlate.TabIndex = 20;
            this.labelTitlePlate.Text = "Placa";
            // 
            // panelPlateText
            // 
            this.panelPlateText.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelPlateText.Controls.Add(this.labelSpeedResult);
            this.panelPlateText.Controls.Add(this.labelResult);
            this.panelPlateText.Location = new System.Drawing.Point(7, 378);
            this.panelPlateText.Name = "panelPlateText";
            this.panelPlateText.Size = new System.Drawing.Size(444, 156);
            this.panelPlateText.TabIndex = 21;
            // 
            // labelSpeedResult
            // 
            this.labelSpeedResult.AutoSize = true;
            this.labelSpeedResult.BackColor = System.Drawing.Color.Transparent;
            this.labelSpeedResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSpeedResult.Location = new System.Drawing.Point(250, 11);
            this.labelSpeedResult.Name = "labelSpeedResult";
            this.labelSpeedResult.Size = new System.Drawing.Size(91, 20);
            this.labelSpeedResult.TabIndex = 17;
            this.labelSpeedResult.Text = "Velocidad:  ";
            // 
            // labelResult
            // 
            this.labelResult.AutoSize = true;
            this.labelResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelResult.Location = new System.Drawing.Point(4, 11);
            this.labelResult.Name = "labelResult";
            this.labelResult.Size = new System.Drawing.Size(90, 140);
            this.labelResult.TabIndex = 13;
            this.labelResult.Text = "Placa: \r\nModelo:\r\nMarca: \r\nCategoría:  \r\nDueño: \r\nCI: \r\nMensaje: ";
            // 
            // labelColor
            // 
            this.labelColor.BackColor = System.Drawing.SystemColors.Control;
            this.labelColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelColor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelColor.Location = new System.Drawing.Point(189, 317);
            this.labelColor.Name = "labelColor";
            this.labelColor.Size = new System.Drawing.Size(135, 55);
            this.labelColor.TabIndex = 16;
            this.labelColor.Text = "Sin color";
            this.labelColor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelColorTitle
            // 
            this.labelColorTitle.AutoSize = true;
            this.labelColorTitle.BackColor = System.Drawing.Color.Transparent;
            this.labelColorTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelColorTitle.Location = new System.Drawing.Point(185, 294);
            this.labelColorTitle.Name = "labelColorTitle";
            this.labelColorTitle.Size = new System.Drawing.Size(51, 20);
            this.labelColorTitle.TabIndex = 15;
            this.labelColorTitle.Text = "Color";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.toolStrip1);
            this.splitContainer1.Panel1.Controls.Add(menuStrip1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.AutoScroll = true;
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer2);
            this.splitContainer1.Size = new System.Drawing.Size(1252, 749);
            this.splitContainer1.SplitterDistance = 70;
            this.splitContainer1.TabIndex = 19;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1,
            this.toolStripSeparator1,
            this.toolStripButton2,
            this.toolStripSeparator2});
            this.toolStrip1.Location = new System.Drawing.Point(0, 29);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1252, 25);
            this.toolStrip1.TabIndex = 2;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(53, 22);
            this.toolStripButton1.Text = "Captura";
            this.toolStripButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.Overlay;
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton2.Image")));
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(55, 22);
            this.toolStripButton2.Text = "Historial";
            this.toolStripButton2.TextImageRelation = System.Windows.Forms.TextImageRelation.Overlay;
            this.toolStripButton2.Click += new System.EventHandler(this.toolStripButton2_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // splitContainer2
            // 
            this.splitContainer2.AllowDrop = true;
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.AutoScroll = true;
            this.splitContainer2.Panel1.Controls.Add(this.panelCapture);
            this.splitContainer2.Panel1.Controls.Add(this.pictureBoxInput);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.trackBarVideo);
            this.splitContainer2.Panel2.Controls.Add(this.btnCapture);
            this.splitContainer2.Panel2.Controls.Add(this.btnPause);
            this.splitContainer2.Panel2.Controls.Add(this.btnPlay);
            this.splitContainer2.Panel2.Controls.Add(this.btnStop);
            this.splitContainer2.Size = new System.Drawing.Size(1252, 675);
            this.splitContainer2.SplitterDistance = 565;
            this.splitContainer2.TabIndex = 20;
            // 
            // panelCapture
            // 
            this.panelCapture.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelCapture.Controls.Add(this.panelPlateText);
            this.panelCapture.Controls.Add(this.pictureBoxPlate);
            this.panelCapture.Controls.Add(this.labelColor);
            this.panelCapture.Controls.Add(this.labelInfoCapture);
            this.panelCapture.Controls.Add(this.labelColorTitle);
            this.panelCapture.Controls.Add(this.labelTitlePlate);
            this.panelCapture.Controls.Add(this.pictureBoxCapture);
            this.panelCapture.Location = new System.Drawing.Point(780, 8);
            this.panelCapture.Name = "panelCapture";
            this.panelCapture.Size = new System.Drawing.Size(456, 540);
            this.panelCapture.TabIndex = 19;
            this.panelCapture.MouseHover += new System.EventHandler(this.panelCapture_MouseHover);
            // 
            // pictureBoxPlate
            // 
            this.pictureBoxPlate.BackColor = System.Drawing.SystemColors.ControlDark;
            this.pictureBoxPlate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBoxPlate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxPlate.Location = new System.Drawing.Point(7, 317);
            this.pictureBoxPlate.Name = "pictureBoxPlate";
            this.pictureBoxPlate.Size = new System.Drawing.Size(136, 55);
            this.pictureBoxPlate.TabIndex = 19;
            this.pictureBoxPlate.TabStop = false;
            // 
            // pictureBoxCapture
            // 
            this.pictureBoxCapture.BackColor = System.Drawing.SystemColors.ControlDark;
            this.pictureBoxCapture.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBoxCapture.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxCapture.Location = new System.Drawing.Point(7, 10);
            this.pictureBoxCapture.Name = "pictureBoxCapture";
            this.pictureBoxCapture.Size = new System.Drawing.Size(317, 249);
            this.pictureBoxCapture.TabIndex = 11;
            this.pictureBoxCapture.TabStop = false;
            // 
            // pictureBoxInput
            // 
            this.pictureBoxInput.BackColor = System.Drawing.SystemColors.ControlDark;
            this.pictureBoxInput.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBoxInput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxInput.Location = new System.Drawing.Point(12, 19);
            this.pictureBoxInput.Name = "pictureBoxInput";
            this.pictureBoxInput.Size = new System.Drawing.Size(731, 480);
            this.pictureBoxInput.TabIndex = 0;
            this.pictureBoxInput.TabStop = false;
            // 
            // btnCapture
            // 
            this.btnCapture.BackgroundImage = global::vehicle_speed_project.Properties.Resources.capture_icon;
            this.btnCapture.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCapture.Cursor = System.Windows.Forms.Cursors.No;
            this.btnCapture.Enabled = false;
            this.btnCapture.Location = new System.Drawing.Point(22, 50);
            this.btnCapture.Name = "btnCapture";
            this.btnCapture.Size = new System.Drawing.Size(39, 36);
            this.btnCapture.TabIndex = 5;
            this.btnCapture.UseVisualStyleBackColor = true;
            this.btnCapture.Click += new System.EventHandler(this.btnCapture_Click);
            // 
            // btnPause
            // 
            this.btnPause.Cursor = System.Windows.Forms.Cursors.No;
            this.btnPause.Enabled = false;
            this.btnPause.Image = global::vehicle_speed_project.Properties.Resources.pause_icon;
            this.btnPause.Location = new System.Drawing.Point(455, 50);
            this.btnPause.Name = "btnPause";
            this.btnPause.Size = new System.Drawing.Size(36, 36);
            this.btnPause.TabIndex = 3;
            this.btnPause.UseVisualStyleBackColor = true;
            this.btnPause.Click += new System.EventHandler(this.btnPause_Click);
            // 
            // btnPlay
            // 
            this.btnPlay.Cursor = System.Windows.Forms.Cursors.No;
            this.btnPlay.Enabled = false;
            this.btnPlay.Image = global::vehicle_speed_project.Properties.Resources.play_icon;
            this.btnPlay.Location = new System.Drawing.Point(510, 50);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(36, 36);
            this.btnPlay.TabIndex = 2;
            this.btnPlay.UseVisualStyleBackColor = true;
            this.btnPlay.Click += new System.EventHandler(this.btnPlay_Click);
            // 
            // btnStop
            // 
            this.btnStop.Cursor = System.Windows.Forms.Cursors.No;
            this.btnStop.Enabled = false;
            this.btnStop.Image = global::vehicle_speed_project.Properties.Resources.stop_icon;
            this.btnStop.Location = new System.Drawing.Point(567, 50);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(36, 36);
            this.btnStop.TabIndex = 4;
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // MyProject
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1252, 749);
            this.Controls.Add(this.splitContainer1);
            this.MainMenuStrip = menuStrip1;
            this.Name = "MyProject";
            this.Text = "MyProject";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MyProject_FormClosed);
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarVideo)).EndInit();
            this.panelPlateText.ResumeLayout(false);
            this.panelPlateText.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.panelCapture.ResumeLayout(false);
            this.panelCapture.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPlate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCapture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxInput)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxInput;
        private System.Windows.Forms.ToolStripMenuItem archivosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem abrirVideoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem abrirCámaraToolStripMenuItem;
        private System.Windows.Forms.Button btnPlay;
        private System.Windows.Forms.Button btnPause;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Button btnCapture;
        private System.Windows.Forms.TrackBar trackBarVideo;
        private System.Windows.Forms.ToolStripMenuItem analizarImagenToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBoxCapture;
        private System.Windows.Forms.PictureBox pictureBoxPlate;
        private System.Windows.Forms.Label labelTitlePlate;
        private System.Windows.Forms.Panel panelPlateText;
        private System.Windows.Forms.Label labelColor;
        private System.Windows.Forms.Label labelColorTitle;
        private System.Windows.Forms.Label labelResult;
        private System.Windows.Forms.Label labelInfoCapture;
        private System.Windows.Forms.ToolStripMenuItem tamañoDeEntradaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem normalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem estiramientoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem automáticoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem centradoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zoomToolStripMenuItem;
        private System.Windows.Forms.Label labelSpeedResult;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.Panel panelCapture;
        private System.Windows.Forms.SplitContainer splitContainer2;
    }
}

