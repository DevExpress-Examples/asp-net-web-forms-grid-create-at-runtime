Imports System
Imports System.Data
Imports System.Web.UI
Imports System.Web.UI.WebControls
Imports System.Web.UI.WebControls.WebParts
Imports System.Web.UI.HtmlControls
Imports DevExpress.Web

Namespace GridRuntime

    Public Partial Class _Default
        Inherits Page

        Protected Sub Page_Init(ByVal sender As Object, ByVal e As EventArgs)
            Dim grid As ASPxGridView = New ASPxGridView()
            grid.ID = "grid"
            grid.KeyFieldName = "ID"
            grid.DataSource = GetData()
            form1.Controls.Add(grid)
            grid.DataBind()
        End Sub

        Public Function GetData() As DataTable
            Dim Table As DataTable = New DataTable()
            Table.Columns.Add("ID", GetType(Integer))
            Table.Columns.Add("ItemName", GetType(String))
            Table.Rows.Add(1, "A")
            Table.Rows.Add(2, "B")
            Return Table
        End Function
    End Class
End Namespace
