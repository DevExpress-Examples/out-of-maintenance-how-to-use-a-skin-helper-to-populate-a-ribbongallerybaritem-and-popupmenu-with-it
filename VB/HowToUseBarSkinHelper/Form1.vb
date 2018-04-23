Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Text
Imports System.Windows.Forms
Imports DevExpress.XtraBars.Ribbon
Imports DevExpress.XtraBars.Helpers

Namespace HowToUseBarSkinHelper
	Partial Public Class Form1
		Inherits RibbonForm
		Public Sub New()
			InitializeComponent()
		End Sub

		Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
			SkinHelper.InitSkinGallery(ribbonGalleryBarItem1, True)
			SkinHelper.InitSkinPopupMenu(popupMenu1)
		End Sub
	End Class
End Namespace