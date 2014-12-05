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


Imports System.Management
Imports System
Imports System.Collections
Imports System.Collections.Specialized

Public Module wmi


    Public Function QueryHD() As StringCollection
        Dim strAux As String = ""
        Dim strSerial As String
        Dim strColl As New StringCollection

        Try
            Dim searcher As New ManagementObjectSearcher("root\CIMV2", "SELECT * FROM Win32_DiskDrive")

            For Each queryObj As ManagementObject In searcher.Get()
                strAux = "HD " & roundSize(queryObj("Size"), True) & " - "
                strSerial = queryObj("SerialNumber")
                If strSerial.Length <> 1 Then
                    strAux = strAux & queryObj("Model") & " - Serial: "
                    strAux = strAux & strSerial
                    If strAux.Contains("USB") = False Then strColl.Add(strAux)
                End If

            Next
            QueryHD = strColl
        Catch err As ManagementException
            MessageBox.Show("An error occurred while querying for WMI data: " & err.Message)
        End Try
    End Function

    Private Function roundSize(ByVal lngSize As Long, ByVal blnHD As Boolean) As String
        Dim aux As Integer
        If lngSize >= 1073741824 Then
            If blnHD = True Then
                aux = lngSize \ 1000000000
                aux = aux - (aux Mod 10)
            Else
                aux = lngSize / 1073741824
            End If
            If aux >= 1000 Then
                aux = aux / 1000
                roundSize = aux & "TB"
            Else
                roundSize = aux & "GB"
            End If
        Else
            If blnHD = True Then
                aux = lngSize \ 1000000
                aux = aux - (aux Mod 10)
            Else
                aux = lngSize / 1048576
            End If
            roundSize = aux & "MB"
        End If
    End Function

    Public Function QueryMemory() As StringCollection
        Dim strAux As String = ""
        Dim strSerial As String
        Dim strColl As New StringCollection

        Try
            Dim searcher As New ManagementObjectSearcher("root\CIMV2", "SELECT * FROM Win32_PhysicalMemory")

            For Each queryObj As ManagementObject In searcher.Get()
                strAux = "RAM " & roundSize(queryObj("Capacity"), False)
 
                strSerial = queryObj("SerialNumber")
                If strSerial.Length <> 1 Then
                    strAux = strAux & queryObj("Model") & " - Serial: "
                    strAux = strAux & strSerial
                    strColl.Add(strAux)
                End If

            Next
            QueryMemory = strColl
        Catch err As ManagementException
            MessageBox.Show("An error occurred while querying for WMI data: " & err.Message)
        End Try
    End Function


    Public Function QueryVideo() As StringCollection
        Dim strAux As String = ""
        Dim strColl As New StringCollection

        Try
            Dim searcher As New ManagementObjectSearcher("root\CIMV2", "SELECT * FROM Win32_VideoController")

            For Each queryObj As ManagementObject In searcher.Get()
                strAux = "VIDEO " & roundSize(queryObj("AdapterRAM"), False)
                strAux = strAux & " - " & queryObj("Caption")
                strColl.Add(strAux)
            Next
            QueryVideo = strColl
        Catch err As ManagementException
            MessageBox.Show("An error occurred while querying for WMI data: " & err.Message)
        End Try
    End Function


    Public Function QueryMotherboard() As StringCollection
        Dim strAux As String = ""
        Dim strColl As New StringCollection

        Try
            Dim searcher As New ManagementObjectSearcher("root\CIMV2", "SELECT * FROM Win32_BaseBoard")

            For Each queryObj As ManagementObject In searcher.Get()
                strAux = "MOTHERBOARD " & queryObj("Manufacturer") & " " & queryObj("Product") & " - Serial: " & queryObj("SerialNumber")

                strColl.Add(strAux)
            Next
            QueryMotherboard = strColl
        Catch err As ManagementException
            MessageBox.Show("An error occurred while querying for WMI data: " & err.Message)
        End Try
    End Function


    Public Function QueryCPU() As StringCollection
        Dim strAux As String = ""
        Dim strColl As New StringCollection

        Try
            Dim searcher As New ManagementObjectSearcher("root\CIMV2", "SELECT * FROM Win32_Processor")

            For Each queryObj As ManagementObject In searcher.Get()
                strAux = "CPU " & queryObj("Name") & " - Serial: " & queryObj("ProcessorId")

                strColl.Add(strAux)
            Next
            QueryCPU = strColl
        Catch err As ManagementException
            MessageBox.Show("An error occurred while querying for WMI data: " & err.Message)
        End Try
    End Function
End Module
