Imports System.Configuration
Imports System.Data
Imports System.Data.SqlClient
Public Class admin_login
    Inherits System.Web.UI.Page
    Dim conn As String
    Dim myConn As SqlConnection
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        conn = ConfigurationManager.ConnectionStrings("conn").ConnectionString
        myConn = New SqlConnection(conn)
        Response.Write(myConn.State)
    End Sub

End Class