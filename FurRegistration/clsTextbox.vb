Public Class clsTextbox
    Inherits System.Windows.Forms.TextBox

    Private m_FieldName As String = ""
    Private m_DefaultValue As Object = Nothing
    Private m_FieldType As ESRI.ArcGIS.Geodatabase.esriFieldType

#Region "PROPERTIES"
    Public Property npc_DefaultValue() As String
        Get
            Return m_DefaultValue
        End Get
        Set(ByVal value As String)
            m_DefaultValue = value
        End Set
    End Property
    Public Property npc_FieldName() As String
        Get
            Return m_FieldName
        End Get
        Set(ByVal value As String)
            m_FieldName = value
        End Set
    End Property

    Public Property npc_FieldType() As ESRI.ArcGIS.Geodatabase.esriFieldType
        Get
            Return m_FieldType
        End Get
        Set(ByVal value As ESRI.ArcGIS.Geodatabase.esriFieldType)
            m_FieldType = value
        End Set
    End Property
#End Region

    Public Function Get_Value() As Object
        Try
            Dim aVal As Object = Me.Text
            If aVal = "" Then Return Nothing

            If m_FieldType = ESRI.ArcGIS.Geodatabase.esriFieldType.esriFieldTypeDouble Then
                aVal = CDbl(aVal)
            ElseIf m_FieldType = ESRI.ArcGIS.Geodatabase.esriFieldType.esriFieldTypeInteger Or
                m_FieldType = ESRI.ArcGIS.Geodatabase.esriFieldType.esriFieldTypeSingle Or
                m_FieldType = ESRI.ArcGIS.Geodatabase.esriFieldType.esriFieldTypeSmallInteger Then
                aVal = CInt(aVal)
            End If
            Return aVal
        Catch ex As Exception
            Return Nothing
        End Try
    End Function
End Class
