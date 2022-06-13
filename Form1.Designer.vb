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
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtfirstname = New System.Windows.Forms.TextBox()
        Me.txtlastname = New System.Windows.Forms.TextBox()
        Me.txtusername = New System.Windows.Forms.TextBox()
        Me.txtIC = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.ListBox = New System.Windows.Forms.ListBox()
        Me.lblname = New System.Windows.Forms.Label()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.btnReset = New System.Windows.Forms.Button()
        Me.label = New System.Windows.Forms.Label()
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(193, 116)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(114, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "First Name :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(193, 177)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(112, 20)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Last Name :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(193, 239)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(106, 20)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Username :"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(193, 297)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(110, 20)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "IC Number :"
        '
        'txtfirstname
        '
        Me.txtfirstname.Location = New System.Drawing.Point(352, 114)
        Me.txtfirstname.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtfirstname.Name = "txtfirstname"
        Me.txtfirstname.Size = New System.Drawing.Size(275, 22)
        Me.txtfirstname.TabIndex = 4
        '
        'txtlastname
        '
        Me.txtlastname.Location = New System.Drawing.Point(352, 176)
        Me.txtlastname.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtlastname.Name = "txtlastname"
        Me.txtlastname.Size = New System.Drawing.Size(275, 22)
        Me.txtlastname.TabIndex = 5
        '
        'txtusername
        '
        Me.txtusername.Location = New System.Drawing.Point(352, 238)
        Me.txtusername.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtusername.Name = "txtusername"
        Me.txtusername.Size = New System.Drawing.Size(275, 22)
        Me.txtusername.TabIndex = 6
        '
        'txtIC
        '
        Me.txtIC.Location = New System.Drawing.Point(352, 295)
        Me.txtIC.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtIC.Name = "txtIC"
        Me.txtIC.Size = New System.Drawing.Size(275, 22)
        Me.txtIC.TabIndex = 7
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(193, 388)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(101, 20)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Name List:"
        '
        'ListBox
        '
        Me.ListBox.FormattingEnabled = True
        Me.ListBox.ItemHeight = 16
        Me.ListBox.Location = New System.Drawing.Point(197, 437)
        Me.ListBox.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.ListBox.Name = "ListBox"
        Me.ListBox.Size = New System.Drawing.Size(725, 164)
        Me.ListBox.TabIndex = 9
        '
        'lblname
        '
        Me.lblname.AutoSize = True
        Me.lblname.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblname.Location = New System.Drawing.Point(193, 646)
        Me.lblname.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblname.Name = "lblname"
        Me.lblname.Size = New System.Drawing.Size(69, 20)
        Me.lblname.TabIndex = 10
        Me.lblname.Text = "Name :"
        '
        'btnAdd
        '
        Me.btnAdd.BackColor = System.Drawing.Color.RosyBrown
        Me.btnAdd.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAdd.Location = New System.Drawing.Point(788, 106)
        Me.btnAdd.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(100, 41)
        Me.btnAdd.TabIndex = 11
        Me.btnAdd.Text = "Add"
        Me.btnAdd.UseVisualStyleBackColor = False
        '
        'btnReset
        '
        Me.btnReset.BackColor = System.Drawing.Color.RosyBrown
        Me.btnReset.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnReset.Location = New System.Drawing.Point(788, 165)
        Me.btnReset.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(100, 41)
        Me.btnReset.TabIndex = 12
        Me.btnReset.Text = "Reset"
        Me.btnReset.UseVisualStyleBackColor = False
        '
        'label
        '
        Me.label.AutoSize = True
        Me.label.ForeColor = System.Drawing.Color.Firebrick
        Me.label.Location = New System.Drawing.Point(636, 299)
        Me.label.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.label.Name = "label"
        Me.label.Size = New System.Drawing.Size(154, 16)
        Me.label.TabIndex = 13
        Me.label.Text = "Without Dash (-), 12 Digit "
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DarkGray
        Me.ClientSize = New System.Drawing.Size(1092, 677)
        Me.Controls.Add(Me.label)
        Me.Controls.Add(Me.btnReset)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.lblname)
        Me.Controls.Add(Me.ListBox)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtIC)
        Me.Controls.Add(Me.txtusername)
        Me.Controls.Add(Me.txtlastname)
        Me.Controls.Add(Me.txtfirstname)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txtfirstname As TextBox
    Friend WithEvents txtlastname As TextBox
    Friend WithEvents txtusername As TextBox
    Friend WithEvents txtIC As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents ListBox As ListBox
    Friend WithEvents lblname As Label
    Friend WithEvents btnAdd As Button
    Friend WithEvents btnReset As Button
    Friend WithEvents label As Label
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
End Class
