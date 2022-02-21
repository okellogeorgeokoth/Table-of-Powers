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
        Me.txtA = New System.Windows.Forms.TextBox()
        Me.btnDisplay = New System.Windows.Forms.Button()
        Me.powerListBox = New System.Windows.Forms.ListBox()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(58, 42)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(150, 15)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Enter Upper limit as Integer"
        '
        'txtA
        '
        Me.txtA.Location = New System.Drawing.Point(61, 71)
        Me.txtA.Name = "txtA"
        Me.txtA.Size = New System.Drawing.Size(203, 23)
        Me.txtA.TabIndex = 1
        '
        'btnDisplay
        '
        Me.btnDisplay.Location = New System.Drawing.Point(299, 71)
        Me.btnDisplay.Name = "btnDisplay"
        Me.btnDisplay.Size = New System.Drawing.Size(172, 23)
        Me.btnDisplay.TabIndex = 2
        Me.btnDisplay.Text = "Display Table of Powers"
        Me.btnDisplay.UseVisualStyleBackColor = True
        '
        'powerListBox
        '
        Me.powerListBox.FormattingEnabled = True
        Me.powerListBox.ItemHeight = 15
        Me.powerListBox.Location = New System.Drawing.Point(61, 124)
        Me.powerListBox.Name = "powerListBox"
        Me.powerListBox.Size = New System.Drawing.Size(410, 169)
        Me.powerListBox.TabIndex = 3
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(509, 333)
        Me.Controls.Add(Me.powerListBox)
        Me.Controls.Add(Me.btnDisplay)
        Me.Controls.Add(Me.txtA)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "Form1"
        Me.Text = "Table of Powers"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents txtA As TextBox
    Friend WithEvents btnDisplay As Button
    Friend WithEvents powerListBox As ListBox
End Class
