<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RuneManagerV2
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(RuneManagerV2))
        Me.RuneLbl = New System.Windows.Forms.Label()
        Me.RunesCmbBx = New System.Windows.Forms.ComboBox()
        Me.ViewBtn = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'RuneLbl
        '
        Me.RuneLbl.AutoSize = True
        Me.RuneLbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 25.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RuneLbl.Location = New System.Drawing.Point(72, 9)
        Me.RuneLbl.Name = "RuneLbl"
        Me.RuneLbl.Size = New System.Drawing.Size(273, 39)
        Me.RuneLbl.TabIndex = 0
        Me.RuneLbl.Text = "Rune Selection:"
        '
        'RunesCmbBx
        '
        Me.RunesCmbBx.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.RunesCmbBx.FormattingEnabled = True
        Me.RunesCmbBx.Items.AddRange(New Object() {"Accuracy", "Blade", "Despair", "Destroy", "Determination", "Endure", "Energy", "Enhance", "Fatal", "Fight", "Focus", "Guard", "Nemesis", "Rage", "Revenge", "Shield", "Swift", "Tolerance", "Vampire", "Violent", "Will", "TRASH"})
        Me.RunesCmbBx.Location = New System.Drawing.Point(131, 77)
        Me.RunesCmbBx.Name = "RunesCmbBx"
        Me.RunesCmbBx.Size = New System.Drawing.Size(149, 21)
        Me.RunesCmbBx.TabIndex = 1
        '
        'ViewBtn
        '
        Me.ViewBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ViewBtn.Location = New System.Drawing.Point(167, 124)
        Me.ViewBtn.Name = "ViewBtn"
        Me.ViewBtn.Size = New System.Drawing.Size(83, 30)
        Me.ViewBtn.TabIndex = 2
        Me.ViewBtn.Text = "View"
        Me.ViewBtn.UseVisualStyleBackColor = True
        '
        'RuneManagerV2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(416, 192)
        Me.Controls.Add(Me.ViewBtn)
        Me.Controls.Add(Me.RunesCmbBx)
        Me.Controls.Add(Me.RuneLbl)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "RuneManagerV2"
        Me.Text = "RuneManagerV2"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents RuneLbl As Label
    Friend WithEvents RunesCmbBx As ComboBox
    Friend WithEvents ViewBtn As Button
End Class
