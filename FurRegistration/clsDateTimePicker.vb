Public Class clsDateTimePicker
    Inherits System.Windows.Forms.DateTimePicker

    Private m_FieldName As String = ""
    Private m_DefaultValue As Object = Nothing

#Region "PROPERTIES"
    Public Property DefaultValue() As String
        Get
            Return m_DefaultValue
        End Get
        Set(ByVal value As String)
            m_DefaultValue = value
        End Set
    End Property
    Public Property FieldName() As String
        Get
            Return m_FieldName
        End Get
        Set(ByVal value As String)
            m_FieldName = value
        End Set
    End Property
    Public Function Get_Value() As Object
        Try
            Return Me.Value

        Catch ex As Exception
            Return Nothing
        End Try
    End Function

#End Region

End Class
