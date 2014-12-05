Imports System.Xml

Public Module xmlmod

    Public Function saveXML(ByVal strFilename As String, ByVal strArrayPopulate() As String) As Integer
        Dim xmlWriter As New XmlTextWriter(strFilename, System.Text.Encoding.UTF8)
        Dim i As Integer = 0
        Dim aux As Integer = 1

        xmlWriter.WriteStartDocument(True)
        xmlWriter.Formatting = Formatting.Indented
        xmlWriter.Indentation = 2

        xmlWriter.WriteStartElement("HARDWARE_INFO")

        While i <= strArrayPopulate.Length
            Select Case strArrayPopulate(i)
                Case "DISCOS RIGIDOS"
                    xmlWriter.WriteStartElement("HARD_DRIVE")
                    i += 1
                    While (strArrayPopulate(i).Length <> 0)
                        xmlWriter.WriteStartElement("HD_" & aux)
                        xmlWriter.WriteString(strArrayPopulate(i))
                        xmlWriter.WriteEndElement()
                        i += 1
                        aux += 1
                    End While
                    i += 1
                    aux = 1
                    xmlWriter.WriteEndElement()
                Case "MEMORIAS"
                    xmlWriter.WriteStartElement("MEMORY")
                    i += 1
                    While (strArrayPopulate(i).Length <> 0)
                        xmlWriter.WriteStartElement("RAM_" & aux)
                        xmlWriter.WriteString(strArrayPopulate(i))
                        xmlWriter.WriteEndElement()
                        aux += 1
                        i += 1
                    End While
                    i += 1
                    aux = 1
                    xmlWriter.WriteEndElement()
                Case "PLACA DE VIDEO"
                    xmlWriter.WriteStartElement("VIDEO")
                    i += 1
                    While (strArrayPopulate(i).Length <> 0)
                        xmlWriter.WriteStartElement("VIDEO_" & aux)
                        xmlWriter.WriteString(strArrayPopulate(i))
                        xmlWriter.WriteEndElement()
                        aux += 1
                        i += 1
                    End While
                    i += 1
                    aux = 1
                    xmlWriter.WriteEndElement()
                Case "PLACA MADRE"
                    xmlWriter.WriteStartElement("MOTHERBOARD")
                    i += 1
                    While (strArrayPopulate(i).Length <> 0)
                        xmlWriter.WriteStartElement("MOBO_" & aux)
                        xmlWriter.WriteString(strArrayPopulate(i))
                        xmlWriter.WriteEndElement()
                        aux += 1
                        i += 1
                    End While
                    i += 1
                    aux = 1
                    xmlWriter.WriteEndElement()
                Case "PROCESADOR"
                    xmlWriter.WriteStartElement("PROCESSOR")
                    i += 1
                    While (i <= (strArrayPopulate.Length - 2))
                        xmlWriter.WriteStartElement("CPU_" & aux)
                        xmlWriter.WriteString(strArrayPopulate(i))
                        xmlWriter.WriteEndElement()
                        aux += 1
                        i += 1
                    End While
                    i += 2
                    xmlWriter.WriteEndElement()
                Case Else
                    saveXML = 1
            End Select
        End While

        xmlWriter.WriteEndElement()
        xmlWriter.WriteEndDocument()
        xmlWriter.Close()
        saveXML = 0

    End Function

End Module
