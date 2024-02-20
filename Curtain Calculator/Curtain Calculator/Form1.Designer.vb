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
        components = New ComponentModel.Container()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        ContextMenuStrip1 = New ContextMenuStrip(components)
        Label4 = New Label()
        txtWinWidth = New TextBox()
        txtWinHeight = New TextBox()
        txtFloorDropHeight = New TextBox()
        Label5 = New Label()
        lblCurtainWidth = New Label()
        Label7 = New Label()
        lblCurtainLength = New Label()
        btnCalculate = New Button()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = SystemColors.Control
        Label1.Font = New Font("Segoe UI", 16F)
        Label1.Location = New Point(25, 39)
        Label1.Name = "Label1"
        Label1.Size = New Size(450, 59)
        Label1.TabIndex = 0
        Label1.Text = "Curtain Size Calculator"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = SystemColors.Control
        Label2.Font = New Font("Segoe UI", 9F)
        Label2.Location = New Point(43, 169)
        Label2.Name = "Label2"
        Label2.Size = New Size(172, 32)
        Label2.TabIndex = 1
        Label2.Text = "Window Width"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BackColor = SystemColors.Control
        Label3.Font = New Font("Segoe UI", 9F)
        Label3.Location = New Point(35, 233)
        Label3.Name = "Label3"
        Label3.Size = New Size(180, 32)
        Label3.TabIndex = 2
        Label3.Text = "Window Height"
        ' 
        ' ContextMenuStrip1
        ' 
        ContextMenuStrip1.ImageScalingSize = New Size(32, 32)
        ContextMenuStrip1.Name = "ContextMenuStrip1"
        ContextMenuStrip1.Size = New Size(61, 4)
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.BackColor = SystemColors.Control
        Label4.Font = New Font("Segoe UI", 9F)
        Label4.Location = New Point(8, 296)
        Label4.Name = "Label4"
        Label4.Size = New Size(207, 32)
        Label4.TabIndex = 4
        Label4.Text = "Floor Drop Height"
        ' 
        ' txtWinWidth
        ' 
        txtWinWidth.Location = New Point(244, 162)
        txtWinWidth.Name = "txtWinWidth"
        txtWinWidth.Size = New Size(200, 39)
        txtWinWidth.TabIndex = 5
        ' 
        ' txtWinHeight
        ' 
        txtWinHeight.Location = New Point(244, 226)
        txtWinHeight.Name = "txtWinHeight"
        txtWinHeight.Size = New Size(200, 39)
        txtWinHeight.TabIndex = 6
        ' 
        ' txtFloorDropHeight
        ' 
        txtFloorDropHeight.Location = New Point(244, 293)
        txtFloorDropHeight.Name = "txtFloorDropHeight"
        txtFloorDropHeight.Size = New Size(200, 39)
        txtFloorDropHeight.TabIndex = 7
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.BackColor = SystemColors.Control
        Label5.Font = New Font("Segoe UI", 9F)
        Label5.Location = New Point(470, 191)
        Label5.Name = "Label5"
        Label5.Size = New Size(269, 32)
        Label5.TabIndex = 8
        Label5.Text = "Curtain Width Required:"
        ' 
        ' lblCurtainWidth
        ' 
        lblCurtainWidth.AutoSize = True
        lblCurtainWidth.BackColor = SystemColors.Control
        lblCurtainWidth.Font = New Font("Segoe UI", 9F)
        lblCurtainWidth.Location = New Point(763, 191)
        lblCurtainWidth.Name = "lblCurtainWidth"
        lblCurtainWidth.Size = New Size(27, 32)
        lblCurtainWidth.TabIndex = 9
        lblCurtainWidth.Text = "0"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.BackColor = SystemColors.Control
        Label7.Font = New Font("Segoe UI", 9F)
        Label7.Location = New Point(460, 258)
        Label7.Name = "Label7"
        Label7.Size = New Size(279, 32)
        Label7.TabIndex = 10
        Label7.Text = "Curtain Length Required:"
        ' 
        ' lblCurtainLength
        ' 
        lblCurtainLength.AutoSize = True
        lblCurtainLength.BackColor = SystemColors.Control
        lblCurtainLength.Font = New Font("Segoe UI", 9F)
        lblCurtainLength.Location = New Point(763, 258)
        lblCurtainLength.Name = "lblCurtainLength"
        lblCurtainLength.Size = New Size(27, 32)
        lblCurtainLength.TabIndex = 11
        lblCurtainLength.Text = "0"
        ' 
        ' btnCalculate
        ' 
        btnCalculate.Location = New Point(510, 372)
        btnCalculate.Name = "btnCalculate"
        btnCalculate.Size = New Size(280, 46)
        btnCalculate.TabIndex = 12
        btnCalculate.Text = "Calculate Curtain"
        btnCalculate.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(13F, 32F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.Peru
        ClientSize = New Size(974, 529)
        Controls.Add(btnCalculate)
        Controls.Add(lblCurtainLength)
        Controls.Add(Label7)
        Controls.Add(lblCurtainWidth)
        Controls.Add(Label5)
        Controls.Add(txtFloorDropHeight)
        Controls.Add(txtWinHeight)
        Controls.Add(txtWinWidth)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Name = "Form1"
        Text = "Curtain Calculator"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents Label4 As Label
    Friend WithEvents txtWinWidth As TextBox
    Friend WithEvents txtWinHeight As TextBox
    Friend WithEvents txtFloorDropHeight As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents lblCurtainWidth As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents lblCurtainLength As Label
    Friend WithEvents btnCalculate As Button

End Class
