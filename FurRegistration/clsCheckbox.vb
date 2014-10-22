Public Class clsCheckbox
    Inherits System.Windows.Forms.CheckBox

    Private m_FieldName As String = ""

    Public Property npc_FieldName() As String
        Get
            Return m_FieldName
        End Get
        Set(ByVal value As String)
            m_FieldName = value
        End Set
    End Property
End Class
