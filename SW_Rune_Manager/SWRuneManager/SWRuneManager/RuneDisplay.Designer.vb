<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RuneDisplay
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(RuneDisplay))
        Me.RuneCheckLst = New System.Windows.Forms.CheckedListBox()
        Me.FormNameLbl = New System.Windows.Forms.Label()
        Me.TrashBtn = New System.Windows.Forms.Button()
        Me.RuneMngBtn = New System.Windows.Forms.Button()
        Me.ListView1 = New System.Windows.Forms.ListView()
        Me.SuspendLayout()
        '
        'RuneCheckLst
        '
        Me.RuneCheckLst.FormattingEnabled = True
        Me.RuneCheckLst.HorizontalScrollbar = True
        Me.RuneCheckLst.Location = New System.Drawing.Point(297, 196)
        Me.RuneCheckLst.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.RuneCheckLst.Name = "RuneCheckLst"
        Me.RuneCheckLst.Size = New System.Drawing.Size(141, 79)
        Me.RuneCheckLst.TabIndex = 0
        '
        'FormNameLbl
        '
        Me.FormNameLbl.AutoSize = True
        Me.FormNameLbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 30.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormNameLbl.Location = New System.Drawing.Point(56, 6)
        Me.FormNameLbl.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.FormNameLbl.Name = "FormNameLbl"
        Me.FormNameLbl.Size = New System.Drawing.Size(386, 46)
        Me.FormNameLbl.TabIndex = 1
        Me.FormNameLbl.Text = "<Rune Set> Runes:"
        '
        'TrashBtn
        '
        Me.TrashBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TrashBtn.Location = New System.Drawing.Point(297, 337)
        Me.TrashBtn.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.TrashBtn.Name = "TrashBtn"
        Me.TrashBtn.Size = New System.Drawing.Size(139, 62)
        Me.TrashBtn.TabIndex = 2
        Me.TrashBtn.Text = "Move Selected To Trash"
        Me.TrashBtn.UseVisualStyleBackColor = True
        '
        'RuneMngBtn
        '
        Me.RuneMngBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RuneMngBtn.Location = New System.Drawing.Point(53, 337)
        Me.RuneMngBtn.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.RuneMngBtn.Name = "RuneMngBtn"
        Me.RuneMngBtn.Size = New System.Drawing.Size(139, 62)
        Me.RuneMngBtn.TabIndex = 3
        Me.RuneMngBtn.Text = "Rune Management"
        Me.RuneMngBtn.UseVisualStyleBackColor = True
        '
        'ListView1
        '
        Me.ListView1.CheckBoxes = True
        Me.ListView1.Location = New System.Drawing.Point(40, 65)
        Me.ListView1.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(422, 244)
        Me.ListView1.TabIndex = 4
        Me.ListView1.UseCompatibleStateImageBehavior = False
        '
        'RuneDisplay
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(511, 430)
        Me.Controls.Add(Me.ListView1)
        Me.Controls.Add(Me.RuneMngBtn)
        Me.Controls.Add(Me.TrashBtn)
        Me.Controls.Add(Me.FormNameLbl)
        Me.Controls.Add(Me.RuneCheckLst)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Name = "RuneDisplay"
        Me.Text = "RuneDisplay"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents RuneCheckLst As CheckedListBox
    Friend WithEvents FormNameLbl As Label
    Friend WithEvents TrashBtn As Button
    Friend WithEvents RuneMngBtn As Button
    Friend WithEvents ListView1 As ListView
End Class
