﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ImportForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ImportForm))
        Me.FormNameLbl = New System.Windows.Forms.Label()
        Me.CSVFileLbl = New System.Windows.Forms.Label()
        Me.CSVFileTxt = New System.Windows.Forms.TextBox()
        Me.ImpFileBtn = New System.Windows.Forms.Button()
        Me.ManImpBtn = New System.Windows.Forms.Button()
        Me.BrowseBtn = New System.Windows.Forms.Button()
        Me.RuneManagementBtn = New System.Windows.Forms.Button()
        Me.DBTxt = New System.Windows.Forms.TextBox()
        Me.DBBrowseBtn = New System.Windows.Forms.Button()
        Me.DBLbl = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'FormNameLbl
        '
        Me.FormNameLbl.AutoSize = True
        Me.FormNameLbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormNameLbl.Location = New System.Drawing.Point(113, 23)
        Me.FormNameLbl.Name = "FormNameLbl"
        Me.FormNameLbl.Size = New System.Drawing.Size(320, 25)
        Me.FormNameLbl.TabIndex = 0
        Me.FormNameLbl.Text = "Summoners War Rune Manager"
        '
        'CSVFileLbl
        '
        Me.CSVFileLbl.AutoSize = True
        Me.CSVFileLbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CSVFileLbl.Location = New System.Drawing.Point(45, 115)
        Me.CSVFileLbl.Name = "CSVFileLbl"
        Me.CSVFileLbl.Size = New System.Drawing.Size(59, 13)
        Me.CSVFileLbl.TabIndex = 1
        Me.CSVFileLbl.Text = "CSV File:"
        '
        'CSVFileTxt
        '
        Me.CSVFileTxt.Location = New System.Drawing.Point(118, 113)
        Me.CSVFileTxt.Name = "CSVFileTxt"
        Me.CSVFileTxt.Size = New System.Drawing.Size(308, 20)
        Me.CSVFileTxt.TabIndex = 2
        '
        'ImpFileBtn
        '
        Me.ImpFileBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ImpFileBtn.Location = New System.Drawing.Point(219, 147)
        Me.ImpFileBtn.Name = "ImpFileBtn"
        Me.ImpFileBtn.Size = New System.Drawing.Size(108, 23)
        Me.ImpFileBtn.TabIndex = 3
        Me.ImpFileBtn.Text = "Import File"
        Me.ImpFileBtn.UseVisualStyleBackColor = True
        '
        'ManImpBtn
        '
        Me.ManImpBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ManImpBtn.Location = New System.Drawing.Point(72, 210)
        Me.ManImpBtn.Name = "ManImpBtn"
        Me.ManImpBtn.Size = New System.Drawing.Size(174, 55)
        Me.ManImpBtn.TabIndex = 4
        Me.ManImpBtn.Text = "Manual Import"
        Me.ManImpBtn.UseVisualStyleBackColor = True
        '
        'BrowseBtn
        '
        Me.BrowseBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BrowseBtn.Location = New System.Drawing.Point(444, 112)
        Me.BrowseBtn.Name = "BrowseBtn"
        Me.BrowseBtn.Size = New System.Drawing.Size(75, 23)
        Me.BrowseBtn.TabIndex = 5
        Me.BrowseBtn.Text = "Browse"
        Me.BrowseBtn.UseVisualStyleBackColor = True
        '
        'RuneManagementBtn
        '
        Me.RuneManagementBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RuneManagementBtn.Location = New System.Drawing.Point(326, 210)
        Me.RuneManagementBtn.Name = "RuneManagementBtn"
        Me.RuneManagementBtn.Size = New System.Drawing.Size(174, 55)
        Me.RuneManagementBtn.TabIndex = 6
        Me.RuneManagementBtn.Text = "Rune Management"
        Me.RuneManagementBtn.UseVisualStyleBackColor = True
        '
        'DBTxt
        '
        Me.DBTxt.Location = New System.Drawing.Point(118, 69)
        Me.DBTxt.Name = "DBTxt"
        Me.DBTxt.Size = New System.Drawing.Size(308, 20)
        Me.DBTxt.TabIndex = 7
        '
        'DBBrowseBtn
        '
        Me.DBBrowseBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DBBrowseBtn.Location = New System.Drawing.Point(444, 67)
        Me.DBBrowseBtn.Name = "DBBrowseBtn"
        Me.DBBrowseBtn.Size = New System.Drawing.Size(75, 23)
        Me.DBBrowseBtn.TabIndex = 8
        Me.DBBrowseBtn.Text = "Browse"
        Me.DBBrowseBtn.UseVisualStyleBackColor = True
        '
        'DBLbl
        '
        Me.DBLbl.AutoSize = True
        Me.DBLbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DBLbl.Location = New System.Drawing.Point(16, 72)
        Me.DBLbl.Name = "DBLbl"
        Me.DBLbl.Size = New System.Drawing.Size(96, 13)
        Me.DBLbl.TabIndex = 9
        Me.DBLbl.Text = ".mdb Database:"
        '
        'ImportForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.SWRuneManager.My.Resources.Resources.summonersWar
        Me.ClientSize = New System.Drawing.Size(595, 300)
        Me.Controls.Add(Me.DBLbl)
        Me.Controls.Add(Me.DBBrowseBtn)
        Me.Controls.Add(Me.DBTxt)
        Me.Controls.Add(Me.RuneManagementBtn)
        Me.Controls.Add(Me.BrowseBtn)
        Me.Controls.Add(Me.ManImpBtn)
        Me.Controls.Add(Me.ImpFileBtn)
        Me.Controls.Add(Me.CSVFileTxt)
        Me.Controls.Add(Me.CSVFileLbl)
        Me.Controls.Add(Me.FormNameLbl)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "ImportForm"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents FormNameLbl As Label
    Friend WithEvents CSVFileLbl As Label
    Friend WithEvents CSVFileTxt As TextBox
    Friend WithEvents ImpFileBtn As Button
    Friend WithEvents ManImpBtn As Button
    Friend WithEvents BrowseBtn As Button
    Friend WithEvents RuneManagementBtn As Button
    Friend WithEvents DBTxt As System.Windows.Forms.TextBox
    Friend WithEvents DBBrowseBtn As System.Windows.Forms.Button
    Friend WithEvents DBLbl As System.Windows.Forms.Label
End Class
