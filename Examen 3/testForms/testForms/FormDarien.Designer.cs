namespace testForms
{
    partial class FormDarien
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
            this.btnGen = new System.Windows.Forms.Button();
            this.cbEmpresa = new System.Windows.Forms.ComboBox();
            this.textGetCliente = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbProductos = new System.Windows.Forms.ListBox();
            this.lbPrecios = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dgvProductosCliente = new System.Windows.Forms.DataGridView();
            this.Producto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.textMontoTotal = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label14 = new System.Windows.Forms.Label();
            this.dgvMostrar = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomEmpresa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.montoFinal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaGen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvMostrarProductosPrecios = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cbModifCliente = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.dgvModifProductosPrecios = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lbModifPrecios = new System.Windows.Forms.ListBox();
            this.lbModifProductos = new System.Windows.Forms.ListBox();
            this.label9 = new System.Windows.Forms.Label();
            this.cbModifID = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.textModifMontoTotal = new System.Windows.Forms.TextBox();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.lbModifEmpresa = new System.Windows.Forms.ListBox();
            this.textModifCliente = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.textFechaGenerada = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductosCliente)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMostrar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMostrarProductosPrecios)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvModifProductosPrecios)).BeginInit();
            this.SuspendLayout();
            // 
            // btnGen
            // 
            this.btnGen.Location = new System.Drawing.Point(352, 384);
            this.btnGen.Name = "btnGen";
            this.btnGen.Size = new System.Drawing.Size(75, 23);
            this.btnGen.TabIndex = 0;
            this.btnGen.Text = "Generar";
            this.btnGen.UseVisualStyleBackColor = true;
            this.btnGen.Click += new System.EventHandler(this.btnGen_Click);
            // 
            // cbEmpresa
            // 
            this.cbEmpresa.FormattingEnabled = true;
            this.cbEmpresa.Location = new System.Drawing.Point(64, 151);
            this.cbEmpresa.Name = "cbEmpresa";
            this.cbEmpresa.Size = new System.Drawing.Size(149, 21);
            this.cbEmpresa.TabIndex = 2;
            this.cbEmpresa.SelectedIndexChanged += new System.EventHandler(this.cbEmpresa_SelectedIndexChanged);
            // 
            // textGetCliente
            // 
            this.textGetCliente.Location = new System.Drawing.Point(88, 85);
            this.textGetCliente.Name = "textGetCliente";
            this.textGetCliente.Size = new System.Drawing.Size(100, 20);
            this.textGetCliente.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(88, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Nombre del Cliente";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(118, 135);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Empresa:";
            // 
            // lbProductos
            // 
            this.lbProductos.FormattingEnabled = true;
            this.lbProductos.Location = new System.Drawing.Point(25, 230);
            this.lbProductos.Name = "lbProductos";
            this.lbProductos.Size = new System.Drawing.Size(120, 134);
            this.lbProductos.TabIndex = 7;
            this.lbProductos.SelectedIndexChanged += new System.EventHandler(this.lbProductos_SelectedIndexChanged);
            this.lbProductos.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lbProductos_MouseDoubleClick);
            // 
            // lbPrecios
            // 
            this.lbPrecios.Enabled = false;
            this.lbPrecios.FormattingEnabled = true;
            this.lbPrecios.Location = new System.Drawing.Point(144, 230);
            this.lbPrecios.Name = "lbPrecios";
            this.lbPrecios.Size = new System.Drawing.Size(120, 134);
            this.lbPrecios.TabIndex = 8;
            this.lbPrecios.SelectedIndexChanged += new System.EventHandler(this.lbPrecios_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(54, 211);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Productos";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(178, 211);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Precios";
            // 
            // dgvProductosCliente
            // 
            this.dgvProductosCliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProductosCliente.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Producto,
            this.Precio});
            this.dgvProductosCliente.Location = new System.Drawing.Point(330, 66);
            this.dgvProductosCliente.Name = "dgvProductosCliente";
            this.dgvProductosCliente.ReadOnly = true;
            this.dgvProductosCliente.Size = new System.Drawing.Size(246, 284);
            this.dgvProductosCliente.TabIndex = 11;
            this.dgvProductosCliente.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProductosCliente_CellContentClick);
            // 
            // Producto
            // 
            this.Producto.HeaderText = "Nombre Producto";
            this.Producto.Name = "Producto";
            this.Producto.ReadOnly = true;
            // 
            // Precio
            // 
            this.Precio.HeaderText = "Precio Producto";
            this.Precio.Name = "Precio";
            this.Precio.ReadOnly = true;
            // 
            // textMontoTotal
            // 
            this.textMontoTotal.Location = new System.Drawing.Point(467, 398);
            this.textMontoTotal.Name = "textMontoTotal";
            this.textMontoTotal.ReadOnly = true;
            this.textMontoTotal.Size = new System.Drawing.Size(100, 20);
            this.textMontoTotal.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(485, 382);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Monto Total";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label16);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Location = new System.Drawing.Point(12, 40);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(584, 398);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Insertar";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(11, 327);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(120, 13);
            this.label14.TabIndex = 39;
            this.label14.Text = "Doble clic para agregar.";
            this.label14.Click += new System.EventHandler(this.label14_Click);
            // 
            // dgvMostrar
            // 
            this.dgvMostrar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMostrar.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.nomCliente,
            this.nomEmpresa,
            this.montoFinal,
            this.fechaGen});
            this.dgvMostrar.Location = new System.Drawing.Point(641, 166);
            this.dgvMostrar.Name = "dgvMostrar";
            this.dgvMostrar.ReadOnly = true;
            this.dgvMostrar.Size = new System.Drawing.Size(664, 234);
            this.dgvMostrar.TabIndex = 16;
            this.dgvMostrar.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMostrar_CellClick);
            this.dgvMostrar.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMostrar_CellContentClick);
            this.dgvMostrar.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvMostrar_CellMouseDoubleClick);
            // 
            // id
            // 
            this.id.HeaderText = "Nota ID";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Width = 220;
            // 
            // nomCliente
            // 
            this.nomCliente.HeaderText = "Nombre Cliente";
            this.nomCliente.Name = "nomCliente";
            this.nomCliente.ReadOnly = true;
            // 
            // nomEmpresa
            // 
            this.nomEmpresa.HeaderText = "Empresa";
            this.nomEmpresa.Name = "nomEmpresa";
            this.nomEmpresa.ReadOnly = true;
            // 
            // montoFinal
            // 
            this.montoFinal.HeaderText = "Monto Final";
            this.montoFinal.Name = "montoFinal";
            this.montoFinal.ReadOnly = true;
            // 
            // fechaGen
            // 
            this.fechaGen.HeaderText = "Generada el:";
            this.fechaGen.Name = "fechaGen";
            this.fechaGen.ReadOnly = true;
            // 
            // dgvMostrarProductosPrecios
            // 
            this.dgvMostrarProductosPrecios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMostrarProductosPrecios.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2});
            this.dgvMostrarProductosPrecios.Location = new System.Drawing.Point(844, 436);
            this.dgvMostrarProductosPrecios.Name = "dgvMostrarProductosPrecios";
            this.dgvMostrarProductosPrecios.ReadOnly = true;
            this.dgvMostrarProductosPrecios.Size = new System.Drawing.Size(246, 234);
            this.dgvMostrarProductosPrecios.TabIndex = 17;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Nombre Producto";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Precio Producto";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label17);
            this.groupBox2.Location = new System.Drawing.Point(626, 138);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(697, 569);
            this.groupBox2.TabIndex = 18;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Base de Datos";
            // 
            // cbModifCliente
            // 
            this.cbModifCliente.FormattingEnabled = true;
            this.cbModifCliente.Location = new System.Drawing.Point(384, 476);
            this.cbModifCliente.Name = "cbModifCliente";
            this.cbModifCliente.Size = new System.Drawing.Size(149, 21);
            this.cbModifCliente.TabIndex = 19;
            this.cbModifCliente.SelectedIndexChanged += new System.EventHandler(this.cbModifCliente_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(413, 460);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(96, 13);
            this.label6.TabIndex = 20;
            this.label6.Text = "Nombre del Cliente";
            // 
            // dgvModifProductosPrecios
            // 
            this.dgvModifProductosPrecios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvModifProductosPrecios.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.dgvModifProductosPrecios.Location = new System.Drawing.Point(350, 502);
            this.dgvModifProductosPrecios.Name = "dgvModifProductosPrecios";
            this.dgvModifProductosPrecios.ReadOnly = true;
            this.dgvModifProductosPrecios.Size = new System.Drawing.Size(246, 234);
            this.dgvModifProductosPrecios.TabIndex = 21;
            this.dgvModifProductosPrecios.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvModifProductosPrecios_CellContentClick);
            this.dgvModifProductosPrecios.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvModifProductosPrecios_CellContentDoubleClick);
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "Nombre Producto";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.HeaderText = "Precio Producto";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(176, 595);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(42, 13);
            this.label7.TabIndex = 27;
            this.label7.Text = "Precios";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(52, 595);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(55, 13);
            this.label8.TabIndex = 26;
            this.label8.Text = "Productos";
            // 
            // lbModifPrecios
            // 
            this.lbModifPrecios.Enabled = false;
            this.lbModifPrecios.FormattingEnabled = true;
            this.lbModifPrecios.Location = new System.Drawing.Point(142, 614);
            this.lbModifPrecios.Name = "lbModifPrecios";
            this.lbModifPrecios.Size = new System.Drawing.Size(120, 134);
            this.lbModifPrecios.TabIndex = 25;
            // 
            // lbModifProductos
            // 
            this.lbModifProductos.FormattingEnabled = true;
            this.lbModifProductos.Location = new System.Drawing.Point(23, 614);
            this.lbModifProductos.Name = "lbModifProductos";
            this.lbModifProductos.Size = new System.Drawing.Size(120, 134);
            this.lbModifProductos.TabIndex = 24;
            this.lbModifProductos.SelectedIndexChanged += new System.EventHandler(this.lbModifProductos_SelectedIndexChanged);
            this.lbModifProductos.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lbModifProductos_MouseDoubleClick);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(70, 458);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(51, 13);
            this.label9.TabIndex = 23;
            this.label9.Text = "Empresa:";
            // 
            // cbModifID
            // 
            this.cbModifID.FormattingEnabled = true;
            this.cbModifID.Location = new System.Drawing.Point(427, 476);
            this.cbModifID.Name = "cbModifID";
            this.cbModifID.Size = new System.Drawing.Size(149, 21);
            this.cbModifID.TabIndex = 28;
            this.cbModifID.Visible = false;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(532, 772);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(64, 13);
            this.label10.TabIndex = 30;
            this.label10.Text = "Monto Total";
            // 
            // textModifMontoTotal
            // 
            this.textModifMontoTotal.Location = new System.Drawing.Point(514, 788);
            this.textModifMontoTotal.Name = "textModifMontoTotal";
            this.textModifMontoTotal.ReadOnly = true;
            this.textModifMontoTotal.Size = new System.Drawing.Size(100, 20);
            this.textModifMontoTotal.TabIndex = 29;
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(35, 787);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(75, 23);
            this.btnModificar.TabIndex = 31;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(138, 787);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(75, 23);
            this.btnEliminar.TabIndex = 32;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.ForeColor = System.Drawing.Color.Red;
            this.label11.Location = new System.Drawing.Point(70, 572);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(232, 13);
            this.label11.TabIndex = 33;
            this.label11.Text = "*Cambiar la Empresa vaciará los productos ----->";
            this.label11.Click += new System.EventHandler(this.label11_Click);
            // 
            // lbModifEmpresa
            // 
            this.lbModifEmpresa.Enabled = false;
            this.lbModifEmpresa.FormattingEnabled = true;
            this.lbModifEmpresa.Location = new System.Drawing.Point(35, 474);
            this.lbModifEmpresa.Name = "lbModifEmpresa";
            this.lbModifEmpresa.Size = new System.Drawing.Size(120, 95);
            this.lbModifEmpresa.TabIndex = 34;
            this.lbModifEmpresa.MouseClick += new System.Windows.Forms.MouseEventHandler(this.lbModifEmpresa_MouseClick);
            // 
            // textModifCliente
            // 
            this.textModifCliente.Location = new System.Drawing.Point(202, 477);
            this.textModifCliente.Name = "textModifCliente";
            this.textModifCliente.Size = new System.Drawing.Size(100, 20);
            this.textModifCliente.TabIndex = 35;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(206, 457);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(93, 13);
            this.label12.TabIndex = 36;
            this.label12.Text = "Actualizar Nombre";
            // 
            // textFechaGenerada
            // 
            this.textFechaGenerada.Location = new System.Drawing.Point(318, 790);
            this.textFechaGenerada.Name = "textFechaGenerada";
            this.textFechaGenerada.ReadOnly = true;
            this.textFechaGenerada.Size = new System.Drawing.Size(100, 20);
            this.textFechaGenerada.TabIndex = 37;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(322, 771);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(92, 13);
            this.label13.TabIndex = 38;
            this.label13.Text = "Nota generada el:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(25, 751);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(120, 13);
            this.label15.TabIndex = 40;
            this.label15.Text = "Doble clic para agregar.";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.ForeColor = System.Drawing.Color.Red;
            this.label16.Location = new System.Drawing.Point(73, 135);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(232, 13);
            this.label16.TabIndex = 41;
            this.label16.Text = "*Cambiar la Empresa vaciará los productos ----->";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(265, 12);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(191, 13);
            this.label17.TabIndex = 42;
            this.label17.Text = "Doble click para enseñar los productos";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.ForeColor = System.Drawing.Color.Red;
            this.label18.Location = new System.Drawing.Point(392, 739);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(162, 13);
            this.label18.TabIndex = 41;
            this.label18.Text = "Doble clic para eliminar Producto";
            // 
            // FormDarien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1341, 838);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.textFechaGenerada);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.textModifCliente);
            this.Controls.Add(this.lbModifEmpresa);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.textModifMontoTotal);
            this.Controls.Add(this.cbModifID);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.lbModifPrecios);
            this.Controls.Add(this.lbModifProductos);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.dgvModifProductosPrecios);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cbModifCliente);
            this.Controls.Add(this.dgvMostrarProductosPrecios);
            this.Controls.Add(this.dgvMostrar);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textMontoTotal);
            this.Controls.Add(this.dgvProductosCliente);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lbPrecios);
            this.Controls.Add(this.lbProductos);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textGetCliente);
            this.Controls.Add(this.cbEmpresa);
            this.Controls.Add(this.btnGen);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Name = "FormDarien";
            this.Text = "* Cambiar de Empresa vaciará los productos del cliente";
            this.Load += new System.EventHandler(this.FormDarien_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductosCliente)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMostrar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMostrarProductosPrecios)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvModifProductosPrecios)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGen;
        private System.Windows.Forms.ComboBox cbEmpresa;
        private System.Windows.Forms.TextBox textGetCliente;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox lbProductos;
        private System.Windows.Forms.ListBox lbPrecios;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dgvProductosCliente;
        private System.Windows.Forms.TextBox textMontoTotal;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Producto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Precio;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvMostrar;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomEmpresa;
        private System.Windows.Forms.DataGridViewTextBoxColumn montoFinal;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaGen;
        private System.Windows.Forms.DataGridView dgvMostrarProductosPrecios;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox cbModifCliente;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dgvModifProductosPrecios;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ListBox lbModifPrecios;
        private System.Windows.Forms.ListBox lbModifProductos;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cbModifID;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textModifMontoTotal;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ListBox lbModifEmpresa;
        private System.Windows.Forms.TextBox textModifCliente;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox textFechaGenerada;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label18;
    }
}

