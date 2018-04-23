Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.Windows.Forms

Namespace HowToUseBarSkinHelper
	Friend NotInheritable Class Program
		''' <summary>
		''' The main entry point for the application.
		''' </summary>
		Private Sub New()
		End Sub
		<STAThread> _
		Shared Sub Main()
			DevExpress.UserSkins.BonusSkins.Register()
			DevExpress.UserSkins.OfficeSkins.Register()
			DevExpress.LookAndFeel.UserLookAndFeel.Default.SetSkinStyle("Office 2010 Silver")
			Application.EnableVisualStyles()
			Application.SetCompatibleTextRenderingDefault(False)
			Application.Run(New Form1())
		End Sub
	End Class
End Namespace