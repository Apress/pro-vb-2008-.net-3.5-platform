Option Explicit On

Imports System.Windows.Forms
Imports CommonSnappableTypes
Imports System.Reflection

Public Class MainForm
  Sub New()
    ' This call is required by the Windows Form Designer.
    InitializeComponent()

    ' Add any initialization after the InitializeComponent() call.
    CenterToScreen()
  End Sub

  Private Sub SnapInModuleToolStripMenuItem_Click(ByVal sender As System.Object, _
    ByVal e As System.EventArgs) Handles SnapInModuleToolStripMenuItem.Click
    ' Allow user to select an assembly to load.
    Dim dlg As OpenFileDialog = New OpenFileDialog()

    If dlg.ShowDialog = Windows.Forms.DialogResult.OK Then
      If dlg.FileName.Contains("CommonSnappableTypes") Then
        MessageBox.Show("CommonSnappableTypes has no snap-ins!")
      ElseIf LoadExternalModule(dlg.FileName) = False Then
        MessageBox.Show("Nothing implements IAppFunctionality!")
      End If
    End If
  End Sub

  Private Function LoadExternalModule(ByVal path As String) As Boolean
    Dim foundSnapIn As Boolean = False
    Dim itfAppFx As IAppFunctionality
    Dim theSnapInAsm As Assembly = Nothing

    ' Try to dynamically load the selected assembly.
    Try
      theSnapInAsm = Assembly.LoadFrom(path)
    Catch ex As Exception
      MessageBox.Show(ex.Message)
      Return foundSnapIn
    End Try

    ' Get all IAppFunctionality compatible classes in assembly,
    ' using a LINQ query and implicitly typed data. 
    Dim classTypes = From t In theSnapInAsm.GetTypes() Where _
                     t.IsClass And (t.GetInterface("IAppFunctionality") _
                                    IsNot Nothing) Select t

    For Each c As Object In classTypes
      foundSnapIn = True

      ' Use late binding to create the type.
      Dim o As Object = theSnapInAsm.CreateInstance(c.FullName)

      ' Call DoIt() off the interface.
      itfAppFx = CType(o, IAppFunctionality)
      itfAppFx.DoIt()
      lstLoadedSnapIns.Items.Add(c.FullName)

      ' Show company info.
      DisplayCompanyData(c)
    Next
    Return foundSnapIn
  End Function

  Private Sub DisplayCompanyData(ByVal t As Type)
    ' Get <CompanyInfo> data.
    Dim customAtts As Object() = t.GetCustomAttributes(False)
    For Each c As CompanyInfoAttribute In customAtts
      ' Show data.
      MessageBox.Show(c.Url, String.Format("More info about {0} can be found at", c.Name))
    Next
  End Sub
End Class
