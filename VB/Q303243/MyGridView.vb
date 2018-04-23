Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.Text
Imports DevExpress.XtraGrid.Views.Grid

Namespace Q303243
	Public Class MyGridView
		Inherits GridView
		Public Overrides Function IsExistAnyRowFooterCell(ByVal rowHandle As Integer) As Boolean
			Return True
		End Function
	End Class
End Namespace
