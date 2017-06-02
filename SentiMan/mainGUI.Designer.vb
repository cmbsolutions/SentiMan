<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class mainGUI
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(mainGUI))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Bar0ToolStripMenuItem = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.cboEnv = New System.Windows.Forms.ComboBox()
        Me.txtSshAccountname = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cmdGenerate = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.cmdAdd = New System.Windows.Forms.Button()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtPrivateKey = New System.Windows.Forms.TextBox()
        Me.txtDbPassword = New System.Windows.Forms.TextBox()
        Me.txtDbAccountname = New System.Windows.Forms.TextBox()
        Me.txtSshPassword = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.dgvAccounts = New System.Windows.Forms.DataGridView()
        Me.cSshUser = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cSshPass = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cSshUser2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cSshPass2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cDbUser = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cDbPass = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cDomainname = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cPrivKey = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cEncPass = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.rtbLog = New System.Windows.Forms.RichTextBox()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.NewToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ManageConnectionsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ManageAuthorizedKeysToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExportConnectionsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CloseToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ImportConnectionsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.dgvAccounts, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1503, 24)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NewToolStripMenuItem, Me.Bar0ToolStripMenuItem, Me.ManageConnectionsToolStripMenuItem, Me.ManageAuthorizedKeysToolStripMenuItem, Me.ToolStripSeparator1, Me.ExportConnectionsToolStripMenuItem, Me.ImportConnectionsToolStripMenuItem, Me.ToolStripSeparator2, Me.CloseToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'Bar0ToolStripMenuItem
        '
        Me.Bar0ToolStripMenuItem.Name = "Bar0ToolStripMenuItem"
        Me.Bar0ToolStripMenuItem.Size = New System.Drawing.Size(238, 6)
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(238, 6)
        '
        'cboEnv
        '
        Me.cboEnv.FormattingEnabled = True
        Me.cboEnv.Location = New System.Drawing.Point(101, 22)
        Me.cboEnv.Name = "cboEnv"
        Me.cboEnv.Size = New System.Drawing.Size(255, 23)
        Me.cboEnv.TabIndex = 2
        '
        'txtSshAccountname
        '
        Me.txtSshAccountname.Location = New System.Drawing.Point(101, 92)
        Me.txtSshAccountname.Name = "txtSshAccountname"
        Me.txtSshAccountname.Size = New System.Drawing.Size(255, 23)
        Me.txtSshAccountname.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 25)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(75, 15)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Environment"
        '
        'cmdGenerate
        '
        Me.cmdGenerate.Location = New System.Drawing.Point(293, 50)
        Me.cmdGenerate.Name = "cmdGenerate"
        Me.cmdGenerate.Size = New System.Drawing.Size(63, 23)
        Me.cmdGenerate.TabIndex = 5
        Me.cmdGenerate.Text = "Generate"
        Me.cmdGenerate.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.cmdAdd)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.txtPrivateKey)
        Me.GroupBox1.Controls.Add(Me.cmdGenerate)
        Me.GroupBox1.Controls.Add(Me.txtDbPassword)
        Me.GroupBox1.Controls.Add(Me.txtDbAccountname)
        Me.GroupBox1.Controls.Add(Me.txtSshPassword)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.cboEnv)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.txtSshAccountname)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox1.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(363, 248)
        Me.GroupBox1.TabIndex = 6
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Add account"
        '
        'cmdAdd
        '
        Me.cmdAdd.Location = New System.Drawing.Point(281, 221)
        Me.cmdAdd.Name = "cmdAdd"
        Me.cmdAdd.Size = New System.Drawing.Size(75, 23)
        Me.cmdAdd.TabIndex = 16
        Me.cmdAdd.Text = "Add"
        Me.cmdAdd.UseVisualStyleBackColor = True
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(6, 147)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(40, 15)
        Me.Label8.TabIndex = 15
        Me.Label8.Text = "MySql"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(6, 80)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(28, 15)
        Me.Label7.TabIndex = 14
        Me.Label7.Text = "SSH"
        '
        'txtPrivateKey
        '
        Me.txtPrivateKey.Location = New System.Drawing.Point(101, 51)
        Me.txtPrivateKey.Name = "txtPrivateKey"
        Me.txtPrivateKey.Size = New System.Drawing.Size(186, 23)
        Me.txtPrivateKey.TabIndex = 13
        '
        'txtDbPassword
        '
        Me.txtDbPassword.Location = New System.Drawing.Point(101, 188)
        Me.txtDbPassword.Name = "txtDbPassword"
        Me.txtDbPassword.Size = New System.Drawing.Size(255, 23)
        Me.txtDbPassword.TabIndex = 12
        '
        'txtDbAccountname
        '
        Me.txtDbAccountname.Location = New System.Drawing.Point(101, 159)
        Me.txtDbAccountname.Name = "txtDbAccountname"
        Me.txtDbAccountname.Size = New System.Drawing.Size(255, 23)
        Me.txtDbAccountname.TabIndex = 11
        '
        'txtSshPassword
        '
        Me.txtSshPassword.Location = New System.Drawing.Point(101, 121)
        Me.txtSshPassword.Name = "txtSshPassword"
        Me.txtSshPassword.Size = New System.Drawing.Size(255, 23)
        Me.txtSshPassword.TabIndex = 10
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(6, 54)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(64, 15)
        Me.Label6.TabIndex = 9
        Me.Label6.Text = "Private key"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(6, 191)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(57, 15)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Password"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(6, 162)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(82, 15)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "Accountname"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 124)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(57, 15)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Password"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 95)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(82, 15)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Accountname"
        '
        'dgvAccounts
        '
        Me.dgvAccounts.AllowUserToAddRows = False
        Me.dgvAccounts.AllowUserToDeleteRows = False
        Me.dgvAccounts.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvAccounts.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableWithoutHeaderText
        Me.dgvAccounts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvAccounts.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.cSshUser, Me.cSshPass, Me.cSshUser2, Me.cSshPass2, Me.cDbUser, Me.cDbPass, Me.cDomainname, Me.cPrivKey, Me.cEncPass})
        Me.dgvAccounts.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvAccounts.Location = New System.Drawing.Point(3, 19)
        Me.dgvAccounts.Name = "dgvAccounts"
        Me.dgvAccounts.ReadOnly = True
        Me.dgvAccounts.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvAccounts.Size = New System.Drawing.Size(1116, 226)
        Me.dgvAccounts.TabIndex = 7
        '
        'cSshUser
        '
        Me.cSshUser.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.cSshUser.FillWeight = 10.0!
        Me.cSshUser.HeaderText = "Ssh User"
        Me.cSshUser.Name = "cSshUser"
        Me.cSshUser.ReadOnly = True
        '
        'cSshPass
        '
        Me.cSshPass.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.cSshPass.FillWeight = 10.0!
        Me.cSshPass.HeaderText = "Ssh Password"
        Me.cSshPass.Name = "cSshPass"
        Me.cSshPass.ReadOnly = True
        '
        'cSshUser2
        '
        Me.cSshUser2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.cSshUser2.FillWeight = 10.0!
        Me.cSshUser2.HeaderText = "Ssh User2"
        Me.cSshUser2.Name = "cSshUser2"
        Me.cSshUser2.ReadOnly = True
        '
        'cSshPass2
        '
        Me.cSshPass2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.cSshPass2.FillWeight = 10.0!
        Me.cSshPass2.HeaderText = "Ssh Pass 2"
        Me.cSshPass2.Name = "cSshPass2"
        Me.cSshPass2.ReadOnly = True
        '
        'cDbUser
        '
        Me.cDbUser.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.cDbUser.FillWeight = 10.0!
        Me.cDbUser.HeaderText = "DB User"
        Me.cDbUser.Name = "cDbUser"
        Me.cDbUser.ReadOnly = True
        '
        'cDbPass
        '
        Me.cDbPass.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.cDbPass.FillWeight = 10.0!
        Me.cDbPass.HeaderText = "DB Password"
        Me.cDbPass.Name = "cDbPass"
        Me.cDbPass.ReadOnly = True
        '
        'cDomainname
        '
        Me.cDomainname.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.cDomainname.FillWeight = 10.0!
        Me.cDomainname.HeaderText = "Domainname"
        Me.cDomainname.Name = "cDomainname"
        Me.cDomainname.ReadOnly = True
        '
        'cPrivKey
        '
        Me.cPrivKey.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.cPrivKey.FillWeight = 10.0!
        Me.cPrivKey.HeaderText = "Private key"
        Me.cPrivKey.Name = "cPrivKey"
        Me.cPrivKey.ReadOnly = True
        '
        'cEncPass
        '
        Me.cEncPass.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.cEncPass.FillWeight = 10.0!
        Me.cEncPass.HeaderText = "Encoded pass"
        Me.cEncPass.Name = "cEncPass"
        Me.cEncPass.ReadOnly = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.dgvAccounts)
        Me.GroupBox2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox2.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(1122, 248)
        Me.GroupBox2.TabIndex = 8
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Created account"
        '
        'GroupBox3
        '
        Me.GroupBox3.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox3.Controls.Add(Me.rtbLog)
        Me.GroupBox3.Location = New System.Drawing.Point(0, 318)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(1503, 238)
        Me.GroupBox3.TabIndex = 0
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Ssh log"
        '
        'rtbLog
        '
        Me.rtbLog.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.rtbLog.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.rtbLog.Dock = System.Windows.Forms.DockStyle.Fill
        Me.rtbLog.Font = New System.Drawing.Font("Consolas", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rtbLog.ForeColor = System.Drawing.Color.Lime
        Me.rtbLog.Location = New System.Drawing.Point(3, 19)
        Me.rtbLog.Name = "rtbLog"
        Me.rtbLog.ReadOnly = True
        Me.rtbLog.Size = New System.Drawing.Size(1497, 216)
        Me.rtbLog.TabIndex = 0
        Me.rtbLog.Text = ""
        '
        'TabControl1
        '
        Me.TabControl1.Appearance = System.Windows.Forms.TabAppearance.FlatButtons
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.ImageList = Me.ImageList1
        Me.TabControl1.Location = New System.Drawing.Point(0, 27)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(1503, 285)
        Me.TabControl1.TabIndex = 9
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.SplitContainer1)
        Me.TabPage1.ImageIndex = 0
        Me.TabPage1.Location = New System.Drawing.Point(4, 27)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(1495, 254)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "New accounts"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.Location = New System.Drawing.Point(3, 3)
        Me.SplitContainer1.Margin = New System.Windows.Forms.Padding(0)
        Me.SplitContainer1.Name = "SplitContainer1"
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.GroupBox1)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.GroupBox2)
        Me.SplitContainer1.Size = New System.Drawing.Size(1489, 248)
        Me.SplitContainer1.SplitterDistance = 363
        Me.SplitContainer1.TabIndex = 9
        '
        'TabPage2
        '
        Me.TabPage2.ImageIndex = 1
        Me.TabPage2.Location = New System.Drawing.Point(4, 27)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(1495, 254)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Shell stuff"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'ImageList1
        '
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageList1.Images.SetKeyName(0, "client_account_template.png")
        Me.ImageList1.Images.SetKeyName(1, "ssh_shell_access.png")
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(238, 6)
        '
        'NewToolStripMenuItem
        '
        Me.NewToolStripMenuItem.Image = Global.SentiMan.My.Resources.Resources.document_black
        Me.NewToolStripMenuItem.Name = "NewToolStripMenuItem"
        Me.NewToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.N), System.Windows.Forms.Keys)
        Me.NewToolStripMenuItem.Size = New System.Drawing.Size(241, 22)
        Me.NewToolStripMenuItem.Text = "New..."
        '
        'ManageConnectionsToolStripMenuItem
        '
        Me.ManageConnectionsToolStripMenuItem.Image = Global.SentiMan.My.Resources.Resources.bios
        Me.ManageConnectionsToolStripMenuItem.Name = "ManageConnectionsToolStripMenuItem"
        Me.ManageConnectionsToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.M), System.Windows.Forms.Keys)
        Me.ManageConnectionsToolStripMenuItem.Size = New System.Drawing.Size(241, 22)
        Me.ManageConnectionsToolStripMenuItem.Text = "Manage connections"
        '
        'ManageAuthorizedKeysToolStripMenuItem
        '
        Me.ManageAuthorizedKeysToolStripMenuItem.Image = Global.SentiMan.My.Resources.Resources.ssh_shell_access
        Me.ManageAuthorizedKeysToolStripMenuItem.Name = "ManageAuthorizedKeysToolStripMenuItem"
        Me.ManageAuthorizedKeysToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.K), System.Windows.Forms.Keys)
        Me.ManageAuthorizedKeysToolStripMenuItem.Size = New System.Drawing.Size(241, 22)
        Me.ManageAuthorizedKeysToolStripMenuItem.Text = "Manage authorizedKeys"
        '
        'ExportConnectionsToolStripMenuItem
        '
        Me.ExportConnectionsToolStripMenuItem.Image = Global.SentiMan.My.Resources.Resources.more_exports
        Me.ExportConnectionsToolStripMenuItem.Name = "ExportConnectionsToolStripMenuItem"
        Me.ExportConnectionsToolStripMenuItem.Size = New System.Drawing.Size(241, 22)
        Me.ExportConnectionsToolStripMenuItem.Text = "Export connections"
        '
        'CloseToolStripMenuItem
        '
        Me.CloseToolStripMenuItem.Image = Global.SentiMan.My.Resources.Resources.door_in
        Me.CloseToolStripMenuItem.Name = "CloseToolStripMenuItem"
        Me.CloseToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.X), System.Windows.Forms.Keys)
        Me.CloseToolStripMenuItem.Size = New System.Drawing.Size(241, 22)
        Me.CloseToolStripMenuItem.Text = "Close"
        '
        'ImportConnectionsToolStripMenuItem
        '
        Me.ImportConnectionsToolStripMenuItem.Image = Global.SentiMan.My.Resources.Resources.more_imports
        Me.ImportConnectionsToolStripMenuItem.Name = "ImportConnectionsToolStripMenuItem"
        Me.ImportConnectionsToolStripMenuItem.Size = New System.Drawing.Size(241, 22)
        Me.ImportConnectionsToolStripMenuItem.Text = "Import connections"
        '
        'mainGUI
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(1503, 555)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.MenuStrip1)
        Me.DoubleBuffered = True
        Me.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.MinimumSize = New System.Drawing.Size(815, 420)
        Me.Name = "mainGUI"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "mainGUI"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.dgvAccounts, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents NewToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Bar0ToolStripMenuItem As ToolStripSeparator
    Friend WithEvents ManageConnectionsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents CloseToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents cboEnv As ComboBox
    Friend WithEvents txtSshAccountname As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents cmdGenerate As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents cmdAdd As Button
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents txtPrivateKey As TextBox
    Friend WithEvents txtDbPassword As TextBox
    Friend WithEvents txtDbAccountname As TextBox
    Friend WithEvents txtSshPassword As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents dgvAccounts As DataGridView
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents rtbLog As RichTextBox
    Friend WithEvents cSshUser As DataGridViewTextBoxColumn
    Friend WithEvents cSshPass As DataGridViewTextBoxColumn
    Friend WithEvents cSshUser2 As DataGridViewTextBoxColumn
    Friend WithEvents cSshPass2 As DataGridViewTextBoxColumn
    Friend WithEvents cDbUser As DataGridViewTextBoxColumn
    Friend WithEvents cDbPass As DataGridViewTextBoxColumn
    Friend WithEvents cDomainname As DataGridViewTextBoxColumn
    Friend WithEvents cPrivKey As DataGridViewTextBoxColumn
    Friend WithEvents cEncPass As DataGridViewTextBoxColumn
    Friend WithEvents ManageAuthorizedKeysToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents SplitContainer1 As SplitContainer
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents ImageList1 As ImageList
    Friend WithEvents ErrorProvider1 As ErrorProvider
    Friend WithEvents ExportConnectionsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator2 As ToolStripSeparator
    Friend WithEvents ImportConnectionsToolStripMenuItem As ToolStripMenuItem
End Class
