
'============================================================================
' Name        : Form1.vb
' Author      : Abdurrahman Nurhakim
' Version     : 1.0
' Copyright   : Your copyright notice
' Description : Decimal Error Code to Binary 16-bit
'============================================================================
Imports System.Runtime.InteropServices.JavaScript.JSType

Public Class Form1

    Dim InputDecimal
    Dim Ouput_LSB_String

    Public Function SelectStatus(Input_String As Char, Tag_name As String) As String
        Dim Output As String
        If Input_String = "1" Then
            Output = "ERROR !!!, Please Check " + Tag_name
        Else
            Output = "STATUS OKE"
        End If
        Return Output
    End Function

    Public Function DecimalToBinaryLSB(ByVal decimalValue As Integer) As String
        Dim binaryValue As String = ""
        Dim bitValue As Integer

        While decimalValue > 0
            bitValue = decimalValue Mod 2
            binaryValue = bitValue.ToString() & binaryValue
            decimalValue = decimalValue \ 2
        End While

        ' Pad the binary value with zeros to make it 16 bits long
        Do While Len(binaryValue) < 16
            binaryValue = "0" & binaryValue
        Loop

        ' Reverse the binary value to get the LSB format
        binaryValue = StrReverse(binaryValue)

        ' Return the binary value as a string
        DecimalToBinaryLSB = binaryValue
        Return DecimalToBinaryLSB
    End Function

    Private Sub TextBox10_TextChanged(sender As Object, e As EventArgs) Handles BIT_15.TextChanged

    End Sub

    Private Sub START_CONVERTER_Click(sender As Object, e As EventArgs) Handles START_CONVERTER.Click
        InputDecimal = CInt(INPUT.Text) 'convert String to Decimal (Integer)
        Ouput_LSB_String = DecimalToBinaryLSB(InputDecimal)
        OUTPUT.Text = Ouput_LSB_String
        OUTPUT.Text = StrReverse(OUTPUT.Text)
        Dim myCharArray() As Char = Ouput_LSB_String.ToCharArray()

        BIT_1.Text = SelectStatus(myCharArray(0), Label1.Text)
        BIT_2.Text = SelectStatus(myCharArray(1), Label2.Text)
        BIT_3.Text = SelectStatus(myCharArray(2), Label3.Text)
        BIT_4.Text = SelectStatus(myCharArray(3), Label4.Text)
        BIT_5.Text = SelectStatus(myCharArray(4), Label5.Text)
        BIT_6.Text = SelectStatus(myCharArray(5), Label6.Text)
        BIT_7.Text = SelectStatus(myCharArray(6), Label7.Text)
        BIT_8.Text = SelectStatus(myCharArray(7), Label8.Text)
        BIT_9.Text = SelectStatus(myCharArray(8), Label9.Text)
        BIT_10.Text = SelectStatus(myCharArray(9), Label10.Text)
        BIT_11.Text = SelectStatus(myCharArray(10), Label11.Text)
        BIT_12.Text = SelectStatus(myCharArray(11), Label12.Text)
        BIT_13.Text = SelectStatus(myCharArray(12), Label13.Text)
        BIT_14.Text = SelectStatus(myCharArray(13), Label14.Text)
        BIT_15.Text = SelectStatus(myCharArray(14), Label15.Text)
        BIT_16.Text = SelectStatus(myCharArray(15), Label18.Text)
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub
End Class
