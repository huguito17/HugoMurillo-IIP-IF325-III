<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmproductos
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.PanelNuevoProducto = New System.Windows.Forms.Panel()
        Me.MenuStrip2 = New System.Windows.Forms.MenuStrip()
        Me.DATALISTADO_PRODUCTOS_OKA = New System.Windows.Forms.DataGridView()
        Me.ToolStripMenuItem3 = New System.Windows.Forms.ToolStripMenuItem()
        Me.txtCodigo = New System.Windows.Forms.TextBox()
        Me.Código = New System.Windows.Forms.Label()
        Me.txtCompra = New System.Windows.Forms.TextBox()
        Me.txtVenta = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.txtStock = New System.Windows.Forms.TextBox()
        Me.DataGridViewCheckBoxColumn8 = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.txtFechaVen = New System.Windows.Forms.MaskedTextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DataGridView2 = New System.Windows.Forms.DataGridView()
        Me.DataGridViewCheckBoxColumn3 = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.DataGridViewCheckBoxColumn1 = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtStockMinimo = New System.Windows.Forms.TextBox()
        Me.cmbImpto = New System.Windows.Forms.ComboBox()
        Me.TGUARDARCAMBIOS = New System.Windows.Forms.Button()
        Me.dtgBusquedaProductos = New System.Windows.Forms.DataGridView()
        Me.txtbuscarCodigo = New System.Windows.Forms.TextBox()
        Me.btnBuscar = New System.Windows.Forms.Button()
        Me.PanelNuevoProducto.SuspendLayout()
        Me.MenuStrip2.SuspendLayout()
        CType(Me.DATALISTADO_PRODUCTOS_OKA, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtgBusquedaProductos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PanelNuevoProducto
        '
        Me.PanelNuevoProducto.AutoScroll = True
        Me.PanelNuevoProducto.BackColor = System.Drawing.Color.White
        Me.PanelNuevoProducto.Controls.Add(Me.btnBuscar)
        Me.PanelNuevoProducto.Controls.Add(Me.txtbuscarCodigo)
        Me.PanelNuevoProducto.Controls.Add(Me.dtgBusquedaProductos)
        Me.PanelNuevoProducto.Controls.Add(Me.TGUARDARCAMBIOS)
        Me.PanelNuevoProducto.Controls.Add(Me.txtFechaVen)
        Me.PanelNuevoProducto.Controls.Add(Me.cmbImpto)
        Me.PanelNuevoProducto.Controls.Add(Me.txtStockMinimo)
        Me.PanelNuevoProducto.Controls.Add(Me.Label9)
        Me.PanelNuevoProducto.Controls.Add(Me.Label8)
        Me.PanelNuevoProducto.Controls.Add(Me.Label7)
        Me.PanelNuevoProducto.Controls.Add(Me.Panel2)
        Me.PanelNuevoProducto.Controls.Add(Me.DATALISTADO_PRODUCTOS_OKA)
        Me.PanelNuevoProducto.Controls.Add(Me.txtStock)
        Me.PanelNuevoProducto.Controls.Add(Me.txtNombre)
        Me.PanelNuevoProducto.Controls.Add(Me.Label3)
        Me.PanelNuevoProducto.Controls.Add(Me.Label4)
        Me.PanelNuevoProducto.Controls.Add(Me.Label5)
        Me.PanelNuevoProducto.Controls.Add(Me.Label6)
        Me.PanelNuevoProducto.Controls.Add(Me.txtVenta)
        Me.PanelNuevoProducto.Controls.Add(Me.txtCompra)
        Me.PanelNuevoProducto.Controls.Add(Me.Código)
        Me.PanelNuevoProducto.Controls.Add(Me.txtCodigo)
        Me.PanelNuevoProducto.Controls.Add(Me.MenuStrip2)
        Me.PanelNuevoProducto.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.PanelNuevoProducto.Location = New System.Drawing.Point(3, 14)
        Me.PanelNuevoProducto.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.PanelNuevoProducto.Name = "PanelNuevoProducto"
        Me.PanelNuevoProducto.Size = New System.Drawing.Size(1026, 622)
        Me.PanelNuevoProducto.TabIndex = 353
        '
        'MenuStrip2
        '
        Me.MenuStrip2.AutoSize = False
        Me.MenuStrip2.BackColor = System.Drawing.Color.Transparent
        Me.MenuStrip2.Dock = System.Windows.Forms.DockStyle.None
        Me.MenuStrip2.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip2.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem3})
        Me.MenuStrip2.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow
        Me.MenuStrip2.Location = New System.Drawing.Point(1086, 2)
        Me.MenuStrip2.Name = "MenuStrip2"
        Me.MenuStrip2.Padding = New System.Windows.Forms.Padding(7, 2, 0, 2)
        Me.MenuStrip2.ShowItemToolTips = True
        Me.MenuStrip2.Size = New System.Drawing.Size(100, 69)
        Me.MenuStrip2.TabIndex = 539
        Me.MenuStrip2.Text = "MenuStrip2"
        '
        'DATALISTADO_PRODUCTOS_OKA
        '
        Me.DATALISTADO_PRODUCTOS_OKA.AllowUserToAddRows = False
        Me.DATALISTADO_PRODUCTOS_OKA.AllowUserToDeleteRows = False
        Me.DATALISTADO_PRODUCTOS_OKA.AllowUserToResizeRows = False
        Me.DATALISTADO_PRODUCTOS_OKA.BackgroundColor = System.Drawing.Color.White
        Me.DATALISTADO_PRODUCTOS_OKA.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DATALISTADO_PRODUCTOS_OKA.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.DATALISTADO_PRODUCTOS_OKA.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DATALISTADO_PRODUCTOS_OKA.ColumnHeadersVisible = False
        Me.DATALISTADO_PRODUCTOS_OKA.EnableHeadersVisualStyles = False
        Me.DATALISTADO_PRODUCTOS_OKA.Location = New System.Drawing.Point(1041, 66)
        Me.DATALISTADO_PRODUCTOS_OKA.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.DATALISTADO_PRODUCTOS_OKA.Name = "DATALISTADO_PRODUCTOS_OKA"
        Me.DATALISTADO_PRODUCTOS_OKA.ReadOnly = True
        Me.DATALISTADO_PRODUCTOS_OKA.RowHeadersVisible = False
        Me.DATALISTADO_PRODUCTOS_OKA.RowHeadersWidth = 9
        Me.DATALISTADO_PRODUCTOS_OKA.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.DATALISTADO_PRODUCTOS_OKA.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black
        Me.DATALISTADO_PRODUCTOS_OKA.RowTemplate.Height = 40
        Me.DATALISTADO_PRODUCTOS_OKA.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DATALISTADO_PRODUCTOS_OKA.Size = New System.Drawing.Size(112, 228)
        Me.DATALISTADO_PRODUCTOS_OKA.TabIndex = 494
        Me.DATALISTADO_PRODUCTOS_OKA.Visible = False
        '
        'ToolStripMenuItem3
        '
        Me.ToolStripMenuItem3.Name = "ToolStripMenuItem3"
        Me.ToolStripMenuItem3.Size = New System.Drawing.Size(184, 65)
        Me.ToolStripMenuItem3.Text = "ToolStripMenuItem3"
        '
        'txtCodigo
        '
        Me.txtCodigo.BackColor = System.Drawing.Color.White
        Me.txtCodigo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtCodigo.ForeColor = System.Drawing.Color.Black
        Me.txtCodigo.Location = New System.Drawing.Point(263, 48)
        Me.txtCodigo.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtCodigo.Name = "txtCodigo"
        Me.txtCodigo.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtCodigo.Size = New System.Drawing.Size(224, 35)
        Me.txtCodigo.TabIndex = 2
        '
        'Código
        '
        Me.Código.AutoSize = True
        Me.Código.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Código.ForeColor = System.Drawing.Color.Black
        Me.Código.Location = New System.Drawing.Point(33, 50)
        Me.Código.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Código.Name = "Código"
        Me.Código.Size = New System.Drawing.Size(98, 29)
        Me.Código.TabIndex = 338
        Me.Código.Text = "Código"
        '
        'txtCompra
        '
        Me.txtCompra.BackColor = System.Drawing.Color.White
        Me.txtCompra.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCompra.ForeColor = System.Drawing.Color.Black
        Me.txtCompra.Location = New System.Drawing.Point(266, 205)
        Me.txtCompra.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtCompra.Name = "txtCompra"
        Me.txtCompra.Size = New System.Drawing.Size(170, 35)
        Me.txtCompra.TabIndex = 7
        Me.txtCompra.Text = "0"
        '
        'txtVenta
        '
        Me.txtVenta.BackColor = System.Drawing.Color.White
        Me.txtVenta.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtVenta.ForeColor = System.Drawing.Color.Black
        Me.txtVenta.Location = New System.Drawing.Point(266, 252)
        Me.txtVenta.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtVenta.Name = "txtVenta"
        Me.txtVenta.Size = New System.Drawing.Size(170, 35)
        Me.txtVenta.TabIndex = 8
        Me.txtVenta.Text = "0"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(33, 109)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(101, 29)
        Me.Label6.TabIndex = 1
        Me.Label6.Text = "Nombre"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(36, 208)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(175, 29)
        Me.Label5.TabIndex = 1
        Me.Label5.Text = "Precio Compra"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(36, 159)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(69, 29)
        Me.Label4.TabIndex = 1
        Me.Label4.Text = "stock"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(37, 252)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(150, 29)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Precio Venta"
        '
        'txtNombre
        '
        Me.txtNombre.BackColor = System.Drawing.Color.White
        Me.txtNombre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtNombre.ForeColor = System.Drawing.Color.Black
        Me.txtNombre.Location = New System.Drawing.Point(266, 106)
        Me.txtNombre.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(373, 35)
        Me.txtNombre.TabIndex = 5
        '
        'txtStock
        '
        Me.txtStock.Location = New System.Drawing.Point(266, 155)
        Me.txtStock.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtStock.Name = "txtStock"
        Me.txtStock.Size = New System.Drawing.Size(221, 35)
        Me.txtStock.TabIndex = 6
        Me.txtStock.Text = "0"
        '
        'DataGridViewCheckBoxColumn8
        '
        Me.DataGridViewCheckBoxColumn8.DataPropertyName = "Marcar"
        Me.DataGridViewCheckBoxColumn8.HeaderText = "Marcar"
        Me.DataGridViewCheckBoxColumn8.MinimumWidth = 6
        Me.DataGridViewCheckBoxColumn8.Name = "DataGridViewCheckBoxColumn8"
        Me.DataGridViewCheckBoxColumn8.ReadOnly = True
        Me.DataGridViewCheckBoxColumn8.Visible = False
        Me.DataGridViewCheckBoxColumn8.Width = 125
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.DataGridView1)
        Me.Panel2.Controls.Add(Me.DataGridView2)
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Location = New System.Drawing.Point(1896, 54)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(15, 20)
        Me.Panel2.TabIndex = 627
        '
        'txtFechaVen
        '
        Me.txtFechaVen.Location = New System.Drawing.Point(263, 298)
        Me.txtFechaVen.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtFechaVen.Mask = "00/00/0000"
        Me.txtFechaVen.Name = "txtFechaVen"
        Me.txtFechaVen.Size = New System.Drawing.Size(172, 35)
        Me.txtFechaVen.TabIndex = 635
        Me.txtFechaVen.ValidatingType = GetType(Date)
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(53, 38)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(92, 29)
        Me.Label1.TabIndex = 340
        Me.Label1.Text = "Label1"
        '
        'DataGridView2
        '
        Me.DataGridView2.AllowUserToAddRows = False
        Me.DataGridView2.AllowUserToDeleteRows = False
        Me.DataGridView2.AllowUserToResizeRows = False
        Me.DataGridView2.BackgroundColor = System.Drawing.Color.DarkGray
        Me.DataGridView2.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DataGridView2.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.DataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView2.ColumnHeadersVisible = False
        Me.DataGridView2.EnableHeadersVisualStyles = False
        Me.DataGridView2.Location = New System.Drawing.Point(78, 126)
        Me.DataGridView2.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.DataGridView2.Name = "DataGridView2"
        Me.DataGridView2.ReadOnly = True
        Me.DataGridView2.RowHeadersVisible = False
        Me.DataGridView2.RowHeadersWidth = 9
        Me.DataGridView2.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.DataGridView2.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black
        Me.DataGridView2.RowTemplate.Height = 40
        Me.DataGridView2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView2.Size = New System.Drawing.Size(206, 306)
        Me.DataGridView2.TabIndex = 626
        '
        'DataGridViewCheckBoxColumn3
        '
        Me.DataGridViewCheckBoxColumn3.DataPropertyName = "Marcar"
        Me.DataGridViewCheckBoxColumn3.HeaderText = "Marcar"
        Me.DataGridViewCheckBoxColumn3.MinimumWidth = 6
        Me.DataGridViewCheckBoxColumn3.Name = "DataGridViewCheckBoxColumn3"
        Me.DataGridViewCheckBoxColumn3.ReadOnly = True
        Me.DataGridViewCheckBoxColumn3.Width = 125
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AllowUserToResizeRows = False
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.Maroon
        Me.DataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.ColumnHeadersVisible = False
        Me.DataGridView1.EnableHeadersVisualStyles = False
        Me.DataGridView1.Location = New System.Drawing.Point(99, 118)
        Me.DataGridView1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.RowHeadersVisible = False
        Me.DataGridView1.RowHeadersWidth = 9
        Me.DataGridView1.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.DataGridView1.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black
        Me.DataGridView1.RowTemplate.Height = 40
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.Size = New System.Drawing.Size(219, 381)
        Me.DataGridView1.TabIndex = 625
        '
        'DataGridViewCheckBoxColumn1
        '
        Me.DataGridViewCheckBoxColumn1.DataPropertyName = "Marcar"
        Me.DataGridViewCheckBoxColumn1.HeaderText = "Marcar"
        Me.DataGridViewCheckBoxColumn1.MinimumWidth = 6
        Me.DataGridViewCheckBoxColumn1.Name = "DataGridViewCheckBoxColumn1"
        Me.DataGridViewCheckBoxColumn1.ReadOnly = True
        Me.DataGridViewCheckBoxColumn1.Width = 125
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(36, 306)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(215, 29)
        Me.Label7.TabIndex = 630
        Me.Label7.Text = "Fecha vencimiento"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(36, 349)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(158, 29)
        Me.Label8.TabIndex = 631
        Me.Label8.Text = "Stock minimo"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(37, 396)
        Me.Label9.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(112, 29)
        Me.Label9.TabIndex = 632
        Me.Label9.Text = "Impuesto"
        '
        'txtStockMinimo
        '
        Me.txtStockMinimo.BackColor = System.Drawing.Color.White
        Me.txtStockMinimo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtStockMinimo.ForeColor = System.Drawing.Color.Black
        Me.txtStockMinimo.Location = New System.Drawing.Point(266, 340)
        Me.txtStockMinimo.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtStockMinimo.Name = "txtStockMinimo"
        Me.txtStockMinimo.Size = New System.Drawing.Size(170, 35)
        Me.txtStockMinimo.TabIndex = 633
        Me.txtStockMinimo.Text = "0"
        '
        'cmbImpto
        '
        Me.cmbImpto.FormattingEnabled = True
        Me.cmbImpto.Items.AddRange(New Object() {"0.13", "0.15", "0.18"})
        Me.cmbImpto.Location = New System.Drawing.Point(266, 385)
        Me.cmbImpto.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cmbImpto.Name = "cmbImpto"
        Me.cmbImpto.Size = New System.Drawing.Size(136, 37)
        Me.cmbImpto.TabIndex = 634
        '
        'TGUARDARCAMBIOS
        '
        Me.TGUARDARCAMBIOS.Location = New System.Drawing.Point(266, 475)
        Me.TGUARDARCAMBIOS.Name = "TGUARDARCAMBIOS"
        Me.TGUARDARCAMBIOS.Size = New System.Drawing.Size(225, 78)
        Me.TGUARDARCAMBIOS.TabIndex = 636
        Me.TGUARDARCAMBIOS.Text = "GUARDAR"
        Me.TGUARDARCAMBIOS.UseVisualStyleBackColor = True
        '
        'dtgBusquedaProductos
        '
        Me.dtgBusquedaProductos.BackgroundColor = System.Drawing.SystemColors.ActiveCaption
        Me.dtgBusquedaProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtgBusquedaProductos.Location = New System.Drawing.Point(690, 92)
        Me.dtgBusquedaProductos.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.dtgBusquedaProductos.Name = "dtgBusquedaProductos"
        Me.dtgBusquedaProductos.RowHeadersWidth = 51
        Me.dtgBusquedaProductos.RowTemplate.Height = 24
        Me.dtgBusquedaProductos.Size = New System.Drawing.Size(841, 442)
        Me.dtgBusquedaProductos.TabIndex = 637
        '
        'txtbuscarCodigo
        '
        Me.txtbuscarCodigo.BackColor = System.Drawing.Color.DarkGray
        Me.txtbuscarCodigo.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtbuscarCodigo.Cursor = System.Windows.Forms.Cursors.Hand
        Me.txtbuscarCodigo.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.txtbuscarCodigo.ForeColor = System.Drawing.Color.Black
        Me.txtbuscarCodigo.Location = New System.Drawing.Point(1074, 39)
        Me.txtbuscarCodigo.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtbuscarCodigo.Name = "txtbuscarCodigo"
        Me.txtbuscarCodigo.Size = New System.Drawing.Size(408, 32)
        Me.txtbuscarCodigo.TabIndex = 639
        '
        'btnBuscar
        '
        Me.btnBuscar.Location = New System.Drawing.Point(1504, 28)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(126, 46)
        Me.btnBuscar.TabIndex = 640
        Me.btnBuscar.Text = "Buscar"
        Me.btnBuscar.UseVisualStyleBackColor = True
        '
        'frmproductos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1042, 636)
        Me.Controls.Add(Me.PanelNuevoProducto)
        Me.Name = "frmproductos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmproductos"
        Me.PanelNuevoProducto.ResumeLayout(False)
        Me.PanelNuevoProducto.PerformLayout()
        Me.MenuStrip2.ResumeLayout(False)
        Me.MenuStrip2.PerformLayout()
        CType(Me.DATALISTADO_PRODUCTOS_OKA, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtgBusquedaProductos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PanelNuevoProducto As Panel
    Friend WithEvents dtgBusquedaProductos As DataGridView
    Friend WithEvents TGUARDARCAMBIOS As Button
    Friend WithEvents txtFechaVen As MaskedTextBox
    Friend WithEvents cmbImpto As ComboBox
    Friend WithEvents txtStockMinimo As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents DataGridView2 As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents DATALISTADO_PRODUCTOS_OKA As DataGridView
    Friend WithEvents txtStock As TextBox
    Friend WithEvents txtNombre As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents txtVenta As TextBox
    Friend WithEvents txtCompra As TextBox
    Friend WithEvents Código As Label
    Friend WithEvents txtCodigo As TextBox
    Friend WithEvents MenuStrip2 As MenuStrip
    Friend WithEvents ToolStripMenuItem3 As ToolStripMenuItem
    Friend WithEvents DataGridViewCheckBoxColumn8 As DataGridViewCheckBoxColumn
    Friend WithEvents DataGridViewCheckBoxColumn3 As DataGridViewCheckBoxColumn
    Friend WithEvents DataGridViewCheckBoxColumn1 As DataGridViewCheckBoxColumn
    Friend WithEvents btnBuscar As Button
    Friend WithEvents txtbuscarCodigo As TextBox
End Class
