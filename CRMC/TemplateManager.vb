Imports System.IO

Public Class TemplateManager

    

    Public Shared Function templateToByte(template As DPFP.Template) As Byte()

        
        'pucha pano mag convert from Template to blob
        Dim str As New MemoryStream

        template.Serialize(str)
        Dim serializedTemplate As Byte() = str.ToArray()

        Return serializedTemplate
    End Function
End Class
