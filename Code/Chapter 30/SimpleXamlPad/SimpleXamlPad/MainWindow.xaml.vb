Imports System.IO
Imports System.Windows.Markup

Class MainWindow
    Private Sub btnViewXaml_Click(ByVal sender As System.Object, ByVal e As System.Windows.RoutedEventArgs)
        ' Write out the data in the text block to a local *.xaml file.
        File.WriteAllText("YourXaml.xaml", txtXamlData.Text)

        ' This is the window that will be dynamically XAML-ed.
        Dim myWindow As Window = Nothing

        ' Open local *.xaml file.
        Try
            Using sr As Stream = File.Open("YourXaml.xaml", FileMode.Open)
                ' Connect the XAML to the Window object. 
                myWindow = DirectCast(XamlReader.Load(sr), Window)
                myWindow.ShowDialog()
            End Using
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub Window_Closed(ByVal sender As System.Object, ByVal e As System.EventArgs)
        ' Write out the data in the text block to a local *.xaml file.
        File.WriteAllText("YourXaml.xaml", txtXamlData.Text)
    End Sub

  Private Sub Window_Loaded(ByVal sender As System.Object, _
    ByVal e As System.Windows.RoutedEventArgs)
    ' When the main window of the app loads,
    ' place some basic XAML text into the text block.
    If File.Exists(System.Environment.CurrentDirectory & "\YourXaml.xaml") Then
      txtXamlData.Text = File.ReadAllText("YourXaml.xaml")
    Else
      txtXamlData.Text = _
    <Window
      xmlns="http://schemas.microsoft.com/winfx/2006/xaml/presentation"
      xmlns:x="http://schemas.microsoft.com/winfx/2006/xaml">
      <StackPanel>

      </StackPanel>
    </Window>.ToString()
    End If
  End Sub


    Public Property Test() As Integer
        Get

        End Get
        Set(ByVal value As Integer)

        End Set
    End Property
End Class
