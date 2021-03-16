Imports Microsoft.VisualBasic
Imports System
Imports System.Data
Imports System.Configuration
Imports System.Collections
Imports System.Web
Imports System.Web.Security
Imports System.Web.UI
Imports System.Web.UI.WebControls
Imports System.Web.UI.WebControls.WebParts
Imports System.Web.UI.HtmlControls
Imports DevExpress.Web

Namespace GridRuntime
	Partial Public Class _Default
		Inherits System.Web.UI.Page
		Protected Sub Page_Init(ByVal sender As Object, ByVal e As EventArgs)
			Dim grid As New ASPxGridView()
			grid.ID = "grid"
			grid.KeyFieldName = "ID"
			grid.DataSource = GetData()

			Me.form1.Controls.Add(grid)

			grid.DataBind()
		End Sub

		Public Function GetData() As DataTable
			Dim Table As New DataTable()
			Table.Columns.Add("ID", GetType(Integer))
			Table.Columns.Add("ItemName", GetType(String))
			Table.Rows.Add(1, "A")
			Table.Rows.Add(2, "B")
			Return Table
		End Function
	End Class
End Namespace
