Imports System.IO.Packaging
Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports Microsoft.Office.Interop
Imports OfficeOpenXml

Public Class Texto

    Private Sub BtnExportar_Click(sender As Object, e As EventArgs) Handles PbWord.Click
        Dim dialogo As New SaveFileDialog()
        If dialogo.ShowDialog() <> DialogResult.OK Then
            Return
        End If
        Dim wordDoc As Word.Document = Nothing
        Dim wordApp = New Word.Application()
        wordDoc = wordApp.Documents.Add()
        Dim txtdoc As String = TxtNota.Text
        wordDoc.Content.Text = txtdoc
        Dim savePath As String = dialogo.FileName
        wordDoc.SaveAs2(savePath)
        MessageBox.Show("Texto exportado")
        wordApp.Visible = True
        wordDoc = Nothing
        wordApp = Nothing
        If wordDoc IsNot Nothing Then
            wordDoc.Close(False)
            System.Runtime.InteropServices.Marshal.ReleaseComObject(wordDoc)
        End If
    End Sub

    Private Sub Texto_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TxtNota.Text = "Hello Word"
    End Sub

    Private Sub PbExcel_Click(sender As Object, e As EventArgs) Handles PbExcel.Click
        Dim dialogo As New SaveFileDialog()
        If dialogo.ShowDialog() <> DialogResult.OK Then
            Return
        End If
        Dim ruta As String = dialogo.FileName
        Dim dato As String = TxtNota.Text ' variable string para guardar el textbox 
        ExcelPackage.LicenseContext = OfficeOpenXml.LicenseContext.NonCommercial
        Using package = New ExcelPackage() ' paquete externo instalado epplus
            Dim workbook = package.Workbook 'libro de trabajo
            Dim worksheet = workbook.Worksheets.Add("Sheet1") 'hoja de trabajo 
            worksheet.Cells("A1").Value = dato
            Dim excelFilePath As String = ruta & ".xlsx" ' variable string para guardar la ruta 
            package.SaveAs(New System.IO.FileInfo(excelFilePath))
            MessageBox.Show("Exportado a Excel")
            Process.Start(New ProcessStartInfo(excelFilePath) With {
        .UseShellExecute = True
                          })
        End Using

    End Sub
End Class
