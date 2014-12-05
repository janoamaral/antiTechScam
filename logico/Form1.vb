'Copyright (c) 2010-2014 "Lógico [software + hosting]"
'Programa para detectar  fraude informático

'This file is part of Lógico: Programa para detectar fraude informático.

'Lógico is free software: you can redistribute it and/or modify
'it under the terms of the GNU General Public License as published by
'the Free Software Foundation, either version 3 of the License, or
'(at your option) any later version.

'This program is distributed in the hope that it will be useful,
'but WITHOUT ANY WARRANTY; without even the implied warranty of
'MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
'GNU General Public License for more details.

'You should have received a copy of the GNU General Public License
'along with this program.  If not, see <http://www.gnu.org/licenses/>.

Imports System.Xml
Imports System.Collections
Imports System.Collections.Specialized

Public Class Form1

    Private Sub lst_ItemSelectionChanged(sender As Object, e As System.Windows.Forms.ListViewItemSelectionChangedEventArgs) Handles lst.ItemSelectionChanged
        Dim auxStr As String
        Dim strDesc(2) As String

        If lst.Items(e.ItemIndex).SubItems.Count = 2 Then
            auxStr = lst.Items.Item(e.ItemIndex).SubItems.Item(1).Text
            If auxStr = "" Then
                lblComponente.Text = "Componentes"
                txtDescripcion.Text = "Seleccione un componente para conocer más"
            Else
                strDesc = auxStr.Split("/")
                lblComponente.Text = strDesc(0)
                txtDescripcion.Text = strDesc(1)
            End If
        End If

    End Sub


    Private Sub Form1_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

        lst.Items.Add("DISCOS RIGIDOS").SubItems.Add("Disco Rígido/Click sobre los componentes para conocer más")
        For Each Str As String In QueryHD()
            lst.Items.Add(Str).SubItems.Add("Disco Rígido/El disco rígido es el componente utilizado para almacenar los datos de manera permanente, a diferencia de la memoria RAM, que se borra cada vez que se reinicia la PC, motivo por el cual a veces se denomina dispositivo de almacenamiento masivo a los discos rígidos.La información se escribe/lee en discos que rotan (rpm) y que están recubiertos por una película magnética. Poseen diversas capacidades de almacenamiento que cada vez es más elevada y que actualmente llega a más de 10 petabytes")
        Next

        lst.Items.Add("").SubItems.Add("")
        lst.Items.Add("MEMORIAS").SubItems.Add("Memorias RAM/Click sobre los componentes para conocer más")
        For Each Str As String In QueryMemory()
            lst.Items.Add(Str).SubItems.Add("Memorias RAM/Esta es utilizada por la computadora para almacenar los programas que estés ejecutando en un determinado momento y los datos con los que trabajas. En un equipo con más memoria RAM podrás ejecutar más programas al mismo tiempo o trabajar con mayor cantidad de datos. Los sistemas operativos cuando se quedan sin memoria RAM utilizan el disco duro para simular tener más memoria de este tipo. Cuando ocurre esto el sistema se ralentiza debido a que el disco duro es miles de veces más lento que la memoria.")
        Next

        lst.Items.Add("").SubItems.Add("")
        lst.Items.Add("PLACA DE VIDEO").SubItems.Add("Placa de video/Click sobre los componentes para conocer más")
        For Each Str As String In QueryVideo()
            lst.Items.Add(Str).SubItems.Add("Placa de vídeo/Una tarjeta gráfica, tarjeta de vídeo, placa de vídeo, tarjeta aceleradora de gráficos o adaptador de pantalla, es una tarjeta de expansión para una computadora u ordenador, encargada de procesar los datos provenientes de la CPU y transformarlos en información comprensible y representable en un dispositivo de salida, como un monitor o televisor. Las tarjetas gráficas más comunes son las disponibles para las computadoras compatibles con la IBM PC, debido a la enorme popularidad de éstas, pero otras arquitecturas también hacen uso de este tipo de dispositivos.")
        Next

        lst.Items.Add("").SubItems.Add("")
        lst.Items.Add("PLACA MADRE").SubItems.Add("Motherboard/Click sobre los componentes para conocer más")
        For Each Str As String In QueryMotherboard()
            lst.Items.Add(Str).SubItems.Add("Motherboard/La placa madre o tarjeta madre es una tarjeta de circuito impreso a la que se conectan los componentes que constituyen la computadora u ordenador. Tiene instalados una serie de circuitos integrados, entre los que se encuentra el chipset, que sirve como centro de conexión entre el microprocesador, la memoria de acceso aleatorio (RAM), las ranuras de expansión y otros dispositivos. Va instalada dentro de una caja o gabinete que por lo general está hecha de chapa y tiene un panel para conectar dispositivos externos y muchos conectores internos y zócalos para instalar componentes dentro de la caja.")
        Next

        lst.Items.Add("").SubItems.Add("")
        lst.Items.Add("PROCESADOR").SubItems.Add("Procesador (CPU)/Click sobre los componentes para conocer más")
        For Each Str As String In QueryCPU()
            lst.Items.Add(Str).SubItems.Add("Procesador (CPU)/El procesador es el cerebro del sistema, encargado de procesar toda la información. Es el componente donde es usada la tecnología más reciente. Existen en el mundo sólo cuatro grandes empresas con tecnología para fabricar procesadores competitivos para computadoras: Intel, AMD, Vía e IBM, que fabrica procesadores para otras empresas, como Transmeta. Algunos de los modelos más modernos, y los cuales cuentan con la tecnoogía más avanzada de la actualidad son el Intel Core Sandy Bridge en sus variantes i3, i5 e i7, el AMD Fusion y FX, los cuales pueden incorporar hasta 8 núcleos.")
        Next

    End Sub


    Private Sub PictureBox7_Click(sender As System.Object, e As System.EventArgs) Handles PictureBox7.Click
        Dim strAux As String
        Dim blnCheckPass As Boolean = True
        Dim strFailArray As New StringCollection

        If odiag.ShowDialog = Windows.Forms.DialogResult.OK Then
            Dim reader As XmlTextReader = New XmlTextReader(odiag.FileName)
            Do While (reader.Read())
                strAux = reader.Value
                If (strAux.Length >= 10) And (strAux.StartsWith("version") = False) Then
                    Dim foundItem As ListViewItem = lst.FindItemWithText(strAux)
                    If (foundItem Is Nothing) Then
                        strFailArray.Add(strAux)
                        blnCheckPass = False
                    End If
                End If
            Loop
            If blnCheckPass = True Then
                result.picbox.Image = result.imglst.Images.Item(0)
                result.lblTitulo.Text = "Pasó el examen!"
                result.lblDesc.Text = "El análisis demostró que no se han cambiado componentes. Igualmente recomendamos que revise la fuente de poder, compactera y otros dispositivos para una mayor seguridad."
                result.ShowDialog(Me)
            Else
                result.picbox.Image = result.imglst.Images.Item(1)
                result.lblTitulo.Text = "Se cambiaron componentes!"
                result.lblDesc.Text = "No se han encontrado los siguientes dispositivos:" & vbCrLf

                For Each strng As String In strFailArray
                    result.lblDesc.Text = result.lblDesc.Text & strng & vbCrLf
                Next
                result.lblDesc.Text = result.lblDesc.Text & "Si no se notificaron los cambios de componentes por favor dirijase a un servicio técnico de confianza"
                result.ShowDialog(Me)
            End If
        End If

    End Sub

    Private Sub PictureBox6_Click(sender As System.Object, e As System.EventArgs) Handles PictureBox6.Click
        If sdiag.ShowDialog = Windows.Forms.DialogResult.OK Then
            Dim strArray(lst.Items.Count) As String
            Dim i As Integer = 0

            For Each lstitem As ListViewItem In lst.Items
                strArray(i) = lstitem.Text
                i += 1
            Next
            saveXML(sdiag.FileName, strArray)
            infovb.lblTitulo.Text = "¡Guardado!"
            infovb.lblDesc.Text = "La configuración se ha guardado correctamente. Recomendamos que almacene el archivo en un pendrive, mail u otro almacenamiento externo para que no pueda ser modificado."
            infovb.ShowDialog()
        End If
    End Sub

    Private Sub PictureBox5_Click(sender As System.Object, e As System.EventArgs) Handles PictureBox5.Click
        infovb.lblTitulo.Text = "Lógico [software + hosting]"
        infovb.lblDesc.Text = "Ideamos este programa para brindarle información básica sobre los componentes de su PC y así evitar que técnicos y empresas sin ética profesional puedan cambiar o robar sus piezas. Ante cualquier duda siempre pida una segunda opinión con otro técnico. Esperamos que este programa le sea de utilidad"
        infovb.ShowDialog()

    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As System.Object, e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        System.Diagnostics.Process.Start("http://logico.com.ar")
    End Sub
End Class
