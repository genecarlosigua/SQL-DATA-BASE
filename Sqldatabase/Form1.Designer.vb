<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.MI = New System.Windows.Forms.Label()
        Me.address = New System.Windows.Forms.Label()
        Me.gender = New System.Windows.Forms.Label()
        Me.txtlastname = New System.Windows.Forms.TextBox()
        Me.contactno = New System.Windows.Forms.Label()
        Me.txtfirstname = New System.Windows.Forms.TextBox()
        Me.txtMI = New System.Windows.Forms.TextBox()
        Me.txtaddress = New System.Windows.Forms.TextBox()
        Me.txtcontact = New System.Windows.Forms.TextBox()
        Me.position = New System.Windows.Forms.Label()
        Me.lblempno = New System.Windows.Forms.Label()
        Me.ListView1 = New System.Windows.Forms.ListView()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.txtempno = New System.Windows.Forms.TextBox()
        Me.cmbgender = New System.Windows.Forms.ComboBox()
        Me.cmbposition = New System.Windows.Forms.ComboBox()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(73, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Employee No:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 82)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(58, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Last Name"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(157, 82)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(57, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "First Name"
        '
        'MI
        '
        Me.MI.AutoSize = True
        Me.MI.Location = New System.Drawing.Point(291, 82)
        Me.MI.Name = "MI"
        Me.MI.Size = New System.Drawing.Size(19, 13)
        Me.MI.TabIndex = 3
        Me.MI.Text = "MI"
        '
        'address
        '
        Me.address.AutoSize = True
        Me.address.Location = New System.Drawing.Point(12, 139)
        Me.address.Name = "address"
        Me.address.Size = New System.Drawing.Size(45, 13)
        Me.address.TabIndex = 4
        Me.address.Text = "Address"
        '
        'gender
        '
        Me.gender.AutoSize = True
        Me.gender.Location = New System.Drawing.Point(12, 204)
        Me.gender.Name = "gender"
        Me.gender.Size = New System.Drawing.Size(42, 13)
        Me.gender.TabIndex = 5
        Me.gender.Text = "Gender"
        '
        'txtlastname
        '
        Me.txtlastname.Location = New System.Drawing.Point(12, 98)
        Me.txtlastname.Name = "txtlastname"
        Me.txtlastname.Size = New System.Drawing.Size(135, 20)
        Me.txtlastname.TabIndex = 6
        '
        'contactno
        '
        Me.contactno.AutoSize = True
        Me.contactno.Location = New System.Drawing.Point(157, 204)
        Me.contactno.Name = "contactno"
        Me.contactno.Size = New System.Drawing.Size(64, 13)
        Me.contactno.TabIndex = 10
        Me.contactno.Text = "Contact No:"
        '
        'txtfirstname
        '
        Me.txtfirstname.Location = New System.Drawing.Point(153, 98)
        Me.txtfirstname.Name = "txtfirstname"
        Me.txtfirstname.Size = New System.Drawing.Size(135, 20)
        Me.txtfirstname.TabIndex = 11
        '
        'txtMI
        '
        Me.txtMI.Location = New System.Drawing.Point(294, 98)
        Me.txtMI.Name = "txtMI"
        Me.txtMI.Size = New System.Drawing.Size(135, 20)
        Me.txtMI.TabIndex = 12
        '
        'txtaddress
        '
        Me.txtaddress.Location = New System.Drawing.Point(12, 155)
        Me.txtaddress.Name = "txtaddress"
        Me.txtaddress.Size = New System.Drawing.Size(416, 20)
        Me.txtaddress.TabIndex = 13
        '
        'txtcontact
        '
        Me.txtcontact.Location = New System.Drawing.Point(153, 220)
        Me.txtcontact.Name = "txtcontact"
        Me.txtcontact.Size = New System.Drawing.Size(135, 20)
        Me.txtcontact.TabIndex = 16
        '
        'position
        '
        Me.position.AutoSize = True
        Me.position.Location = New System.Drawing.Point(291, 204)
        Me.position.Name = "position"
        Me.position.Size = New System.Drawing.Size(44, 13)
        Me.position.TabIndex = 17
        Me.position.Text = "Position"
        '
        'lblempno
        '
        Me.lblempno.AutoSize = True
        Me.lblempno.Location = New System.Drawing.Point(105, 27)
        Me.lblempno.Name = "lblempno"
        Me.lblempno.Size = New System.Drawing.Size(0, 13)
        Me.lblempno.TabIndex = 19
        '
        'ListView1
        '
        Me.ListView1.Activation = System.Windows.Forms.ItemActivation.OneClick
        Me.ListView1.FullRowSelect = True
        Me.ListView1.HideSelection = False
        Me.ListView1.Location = New System.Drawing.Point(15, 262)
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(413, 162)
        Me.ListView1.TabIndex = 20
        Me.ListView1.UseCompatibleStateImageBehavior = False
        Me.ListView1.UseWaitCursor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(160, 430)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(77, 23)
        Me.Button1.TabIndex = 21
        Me.Button1.Text = "ADD NEW"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(243, 430)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(77, 23)
        Me.Button2.TabIndex = 22
        Me.Button2.Text = "UPDATE"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(351, 430)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(77, 23)
        Me.Button3.TabIndex = 23
        Me.Button3.Text = "DELETE"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'txtempno
        '
        Me.txtempno.Location = New System.Drawing.Point(86, 21)
        Me.txtempno.Name = "txtempno"
        Me.txtempno.Size = New System.Drawing.Size(48, 20)
        Me.txtempno.TabIndex = 24
        '
        'cmbgender
        '
        Me.cmbgender.FormattingEnabled = True
        Me.cmbgender.Items.AddRange(New Object() {"Male", "Female"})
        Me.cmbgender.Location = New System.Drawing.Point(12, 219)
        Me.cmbgender.Name = "cmbgender"
        Me.cmbgender.Size = New System.Drawing.Size(121, 21)
        Me.cmbgender.TabIndex = 25
        '
        'cmbposition
        '
        Me.cmbposition.FormattingEnabled = True
        Me.cmbposition.Items.AddRange(New Object() {"Manager", "cashier"})
        Me.cmbposition.Location = New System.Drawing.Point(294, 219)
        Me.cmbposition.Name = "cmbposition"
        Me.cmbposition.Size = New System.Drawing.Size(121, 21)
        Me.cmbposition.TabIndex = 26
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(440, 466)
        Me.Controls.Add(Me.cmbposition)
        Me.Controls.Add(Me.cmbgender)
        Me.Controls.Add(Me.txtempno)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.ListView1)
        Me.Controls.Add(Me.lblempno)
        Me.Controls.Add(Me.position)
        Me.Controls.Add(Me.txtcontact)
        Me.Controls.Add(Me.txtaddress)
        Me.Controls.Add(Me.txtMI)
        Me.Controls.Add(Me.txtfirstname)
        Me.Controls.Add(Me.contactno)
        Me.Controls.Add(Me.txtlastname)
        Me.Controls.Add(Me.gender)
        Me.Controls.Add(Me.address)
        Me.Controls.Add(Me.MI)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Employee information"
        Me.UseWaitCursor = True
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents MI As Label
    Friend WithEvents address As Label
    Friend WithEvents gender As Label
    Friend WithEvents txtlastname As TextBox
    Friend WithEvents contactno As Label
    Friend WithEvents txtfirstname As TextBox
    Friend WithEvents txtMI As TextBox
    Friend WithEvents txtaddress As TextBox
    Friend WithEvents txtcontact As TextBox
    Friend WithEvents position As Label
    Friend WithEvents lblempno As Label
    Friend WithEvents ListView1 As ListView
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents txtempno As TextBox
    Friend WithEvents cmbgender As ComboBox
    Friend WithEvents cmbposition As ComboBox
End Class
