<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        nmProduk = New TextBox()
        ktProduk = New TextBox()
        hrgProduk = New TextBox()
        jmlStok = New TextBox()
        DataGridView1 = New DataGridView()
        Column1 = New DataGridViewTextBoxColumn()
        Column2 = New DataGridViewTextBoxColumn()
        Column3 = New DataGridViewTextBoxColumn()
        Column4 = New DataGridViewTextBoxColumn()
        Column5 = New DataGridViewTextBoxColumn()
        Column6 = New DataGridViewTextBoxColumn()
        Column7 = New DataGridViewTextBoxColumn()
        btnInsert = New Button()
        btnUpdate = New Button()
        btnDelete = New Button()
        Label6 = New Label()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(18, 48)
        Label1.Name = "Label1"
        Label1.Size = New Size(85, 15)
        Label1.TabIndex = 0
        Label1.Text = "Nama Produk:"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(18, 99)
        Label2.Name = "Label2"
        Label2.Size = New Size(101, 15)
        Label2.TabIndex = 1
        Label2.Text = "Kategori Produk:"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(18, 148)
        Label3.Name = "Label3"
        Label3.Size = New Size(86, 15)
        Label3.TabIndex = 2
        Label3.Text = "Harga Produk:"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.FlatStyle = FlatStyle.System
        Label4.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label4.Location = New Point(25, 200)
        Label4.Name = "Label4"
        Label4.Size = New Size(78, 15)
        Label4.TabIndex = 3
        Label4.Text = "Jumlah Stok:"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(424, 244)
        Label5.Name = "Label5"
        Label5.Size = New Size(0, 15)
        Label5.TabIndex = 4
        ' 
        ' nmProduk
        ' 
        nmProduk.Location = New Point(134, 45)
        nmProduk.Name = "nmProduk"
        nmProduk.Size = New Size(140, 23)
        nmProduk.TabIndex = 5
        ' 
        ' ktProduk
        ' 
        ktProduk.Location = New Point(134, 99)
        ktProduk.Name = "ktProduk"
        ktProduk.Size = New Size(140, 23)
        ktProduk.TabIndex = 6
        ' 
        ' hrgProduk
        ' 
        hrgProduk.Location = New Point(134, 148)
        hrgProduk.Name = "hrgProduk"
        hrgProduk.Size = New Size(140, 23)
        hrgProduk.TabIndex = 7
        ' 
        ' jmlStok
        ' 
        jmlStok.Location = New Point(134, 197)
        jmlStok.Name = "jmlStok"
        jmlStok.Size = New Size(140, 23)
        jmlStok.TabIndex = 8
        ' 
        ' DataGridView1
        ' 
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Columns.AddRange(New DataGridViewColumn() {Column1, Column2, Column3, Column4, Column5, Column6, Column7})
        DataGridView1.Location = New Point(30, 288)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.Size = New Size(743, 150)
        DataGridView1.TabIndex = 9
        ' 
        ' Column1
        ' 
        Column1.HeaderText = "ID:"
        Column1.Name = "Column1"
        ' 
        ' Column2
        ' 
        Column2.HeaderText = "Nama Barang:"
        Column2.Name = "Column2"
        ' 
        ' Column3
        ' 
        Column3.HeaderText = "Harga Barang:"
        Column3.Name = "Column3"
        ' 
        ' Column4
        ' 
        Column4.HeaderText = "Kategori Barang:"
        Column4.Name = "Column4"
        ' 
        ' Column5
        ' 
        Column5.HeaderText = "Stok Barang"
        Column5.Name = "Column5"
        ' 
        ' Column6
        ' 
        Column6.HeaderText = "Total Harga"
        Column6.Name = "Column6"
        ' 
        ' Column7
        ' 
        Column7.HeaderText = "Status"
        Column7.Name = "Column7"
        ' 
        ' btnInsert
        ' 
        btnInsert.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnInsert.Location = New Point(266, 244)
        btnInsert.Name = "btnInsert"
        btnInsert.Size = New Size(84, 27)
        btnInsert.TabIndex = 10
        btnInsert.Text = "INSERT"
        btnInsert.UseVisualStyleBackColor = True
        ' 
        ' btnUpdate
        ' 
        btnUpdate.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnUpdate.Location = New Point(385, 244)
        btnUpdate.Name = "btnUpdate"
        btnUpdate.Size = New Size(81, 27)
        btnUpdate.TabIndex = 11
        btnUpdate.Text = "UPDATE"
        btnUpdate.UseVisualStyleBackColor = True
        ' 
        ' btnDelete
        ' 
        btnDelete.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnDelete.Location = New Point(504, 244)
        btnDelete.Name = "btnDelete"
        btnDelete.Size = New Size(79, 27)
        btnDelete.TabIndex = 12
        btnDelete.Text = "DELETE"
        btnDelete.UseVisualStyleBackColor = True
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Candara", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label6.Location = New Point(329, 9)
        Label6.Name = "Label6"
        Label6.Size = New Size(190, 23)
        Label6.TabIndex = 13
        Label6.Text = "PENDATAAN BARANG"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(Label6)
        Controls.Add(btnDelete)
        Controls.Add(btnUpdate)
        Controls.Add(btnInsert)
        Controls.Add(DataGridView1)
        Controls.Add(jmlStok)
        Controls.Add(hrgProduk)
        Controls.Add(ktProduk)
        Controls.Add(nmProduk)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Name = "Form1"
        Text = "Form1"
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents nmProduk As TextBox
    Friend WithEvents ktProduk As TextBox
    Friend WithEvents hrgProduk As TextBox
    Friend WithEvents jmlStok As TextBox
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents btnInsert As Button
    Friend WithEvents btnUpdate As Button
    Friend WithEvents btnDelete As Button
    Friend WithEvents Label6 As Label
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
    Friend WithEvents Column6 As DataGridViewTextBoxColumn
    Friend WithEvents Column7 As DataGridViewTextBoxColumn

End Class
