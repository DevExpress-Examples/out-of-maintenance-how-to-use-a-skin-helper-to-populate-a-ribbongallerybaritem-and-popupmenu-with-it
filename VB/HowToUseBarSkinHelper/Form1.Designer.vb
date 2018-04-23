Imports Microsoft.VisualBasic
Imports System
Namespace HowToUseBarSkinHelper
	Partial Public Class Form1
		''' <summary>
		''' Required designer variable.
		''' </summary>
		Private components As System.ComponentModel.IContainer = Nothing

		''' <summary>
		''' Clean up any resources being used.
		''' </summary>
		''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		Protected Overrides Sub Dispose(ByVal disposing As Boolean)
			If disposing AndAlso (components IsNot Nothing) Then
				components.Dispose()
			End If
			MyBase.Dispose(disposing)
		End Sub

		#Region "Windows Form Designer generated code"

		''' <summary>
		''' Required method for Designer support - do not modify
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
			Me.components = New System.ComponentModel.Container()
			Me.ribbonControl1 = New DevExpress.XtraBars.Ribbon.RibbonControl()
			Me.ribbonGalleryBarItem1 = New DevExpress.XtraBars.RibbonGalleryBarItem()
			Me.ribbonPage1 = New DevExpress.XtraBars.Ribbon.RibbonPage()
			Me.ribbonPageGroup1 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
			Me.labelControl1 = New DevExpress.XtraEditors.LabelControl()
			Me.popupMenu1 = New DevExpress.XtraBars.PopupMenu(Me.components)
			CType(Me.ribbonControl1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.popupMenu1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' ribbonControl1
			' 
			Me.ribbonControl1.ApplicationButtonText = Nothing
			' 
			' 
			' 
			Me.ribbonControl1.ExpandCollapseItem.Id = 0
			Me.ribbonControl1.ExpandCollapseItem.Name = ""
			Me.ribbonControl1.ExpandCollapseItem.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText
			Me.ribbonControl1.Items.AddRange(New DevExpress.XtraBars.BarItem() { Me.ribbonControl1.ExpandCollapseItem, Me.ribbonGalleryBarItem1})
			Me.ribbonControl1.Location = New System.Drawing.Point(0, 0)
			Me.ribbonControl1.MaxItemId = 2
			Me.ribbonControl1.Name = "ribbonControl1"
			Me.ribbonControl1.Pages.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPage() { Me.ribbonPage1})
			Me.ribbonControl1.SelectedPage = Me.ribbonPage1
			Me.ribbonControl1.Size = New System.Drawing.Size(770, 148)
			' 
			' ribbonGalleryBarItem1
			' 
			Me.ribbonGalleryBarItem1.Caption = "ribbonGalleryBarItem1"
			Me.ribbonGalleryBarItem1.Id = 1
			Me.ribbonGalleryBarItem1.Name = "ribbonGalleryBarItem1"
			' 
			' ribbonPage1
			' 
			Me.ribbonPage1.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() { Me.ribbonPageGroup1})
			Me.ribbonPage1.Name = "ribbonPage1"
			Me.ribbonPage1.Text = "ribbonPage1"
			' 
			' ribbonPageGroup1
			' 
			Me.ribbonPageGroup1.ItemLinks.Add(Me.ribbonGalleryBarItem1)
			Me.ribbonPageGroup1.Name = "ribbonPageGroup1"
			Me.ribbonPageGroup1.ShowCaptionButton = False
			Me.ribbonPageGroup1.Text = "ribbonPageGroup1"
			' 
			' labelControl1
			' 
			Me.labelControl1.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
			Me.labelControl1.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
			Me.labelControl1.Dock = System.Windows.Forms.DockStyle.Fill
			Me.labelControl1.Location = New System.Drawing.Point(0, 148)
			Me.labelControl1.Name = "labelControl1"
			Me.ribbonControl1.SetPopupContextMenu(Me.labelControl1, Me.popupMenu1)
			Me.labelControl1.Size = New System.Drawing.Size(770, 285)
			Me.labelControl1.TabIndex = 1
			Me.labelControl1.Text = "Right button click here to show popup menu..."
			' 
			' popupMenu1
			' 
			Me.popupMenu1.Name = "popupMenu1"
			Me.popupMenu1.Ribbon = Me.ribbonControl1
			' 
			' Form1
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.ClientSize = New System.Drawing.Size(770, 433)
			Me.Controls.Add(Me.labelControl1)
			Me.Controls.Add(Me.ribbonControl1)
			Me.Name = "Form1"
			Me.Ribbon = Me.ribbonControl1
			Me.Text = "Form1"
'			Me.Load += New System.EventHandler(Me.Form1_Load);
			CType(Me.ribbonControl1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.popupMenu1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private ribbonControl1 As DevExpress.XtraBars.Ribbon.RibbonControl
		Private ribbonPage1 As DevExpress.XtraBars.Ribbon.RibbonPage
		Private ribbonPageGroup1 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
		Private ribbonGalleryBarItem1 As DevExpress.XtraBars.RibbonGalleryBarItem
		Private popupMenu1 As DevExpress.XtraBars.PopupMenu
		Private labelControl1 As DevExpress.XtraEditors.LabelControl
	End Class
End Namespace

