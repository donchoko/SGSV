﻿'------------------------------------------------------------------------------
' <auto-generated>
'     This code was generated by a tool.
'     Runtime Version:4.0.30319.33440
'
'     Changes to this file may cause incorrect behavior and will be lost if
'     the code is regenerated.
' </auto-generated>
'------------------------------------------------------------------------------

Option Strict On
Option Explicit On


Namespace PublicacionService
    
    <System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0"),  _
     System.ServiceModel.ServiceContractAttribute(ConfigurationName:="PublicacionService.IListado")>  _
    Public Interface IListado
        
        <System.ServiceModel.OperationContractAttribute(Action:="http://tempuri.org/IListado/cargarLista", ReplyAction:="http://tempuri.org/IListado/cargarListaResponse")>  _
        Function cargarLista(ByVal tipo_doc As String, ByVal seccion As String, ByVal vigencia As String) As SVSG_lib.Publicaciones
        
        <System.ServiceModel.OperationContractAttribute(Action:="http://tempuri.org/IListado/crearDocumento", ReplyAction:="http://tempuri.org/IListado/crearDocumentoResponse")>  _
        Function crearDocumento(ByVal publicacion As SVSG_lib.Publicacion) As Boolean
        
        <System.ServiceModel.OperationContractAttribute(Action:="http://tempuri.org/IListado/modificacionMenor", ReplyAction:="http://tempuri.org/IListado/modificacionMenorResponse")> _
        Function modificacionMenor(ByVal publicacion As SVSG_lib.Publicacion, ByVal cod_original As String, ByVal version_original As String) As Boolean

        <System.ServiceModel.OperationContractAttribute(Action:="http://tempuri.org/IListado/publicacionMayor", ReplyAction:="http://tempuri.org/IListado/publicacionMayorResponse")> _
        Function publicacionMayor(ByVal publicacion As SVSG_lib.Publicacion) As Boolean

        <System.ServiceModel.OperationContractAttribute(Action:="http://tempuri.org/IListado/cargarItem", ReplyAction:="http://tempuri.org/IListado/cargarItemResponse")> _
        Function cargarItem(ByVal cod As String) As SVSG_lib.Documento

        <System.ServiceModel.OperationContractAttribute(Action:="http://tempuri.org/IListado/eliminar", ReplyAction:="http://tempuri.org/IListado/eliminarResponse")> _
        Function eliminar(ByVal cod As String, ByVal ver As String) As Boolean
    End Interface

    <System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")> _
    Public Interface IListadoChannel
        Inherits PublicacionService.IListado, System.ServiceModel.IClientChannel
    End Interface

    <System.Diagnostics.DebuggerStepThroughAttribute(), _
     System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")> _
    Partial Public Class ListadoClient
        Inherits System.ServiceModel.ClientBase(Of PublicacionService.IListado)
        Implements PublicacionService.IListado

        Public Sub New()
            MyBase.New()
        End Sub

        Public Sub New(ByVal endpointConfigurationName As String)
            MyBase.New(endpointConfigurationName)
        End Sub

        Public Sub New(ByVal endpointConfigurationName As String, ByVal remoteAddress As String)
            MyBase.New(endpointConfigurationName, remoteAddress)
        End Sub

        Public Sub New(ByVal endpointConfigurationName As String, ByVal remoteAddress As System.ServiceModel.EndpointAddress)
            MyBase.New(endpointConfigurationName, remoteAddress)
        End Sub

        Public Sub New(ByVal binding As System.ServiceModel.Channels.Binding, ByVal remoteAddress As System.ServiceModel.EndpointAddress)
            MyBase.New(binding, remoteAddress)
        End Sub

        Public Function cargarLista(ByVal tipo_doc As String, ByVal seccion As String, ByVal vigencia As String) As SVSG_lib.Publicaciones Implements PublicacionService.IListado.cargarLista
            Return MyBase.Channel.cargarLista(tipo_doc, seccion, vigencia)
        End Function

        Public Function crearDocumento(ByVal publicacion As SVSG_lib.Publicacion) As Boolean Implements PublicacionService.IListado.crearDocumento
            Return MyBase.Channel.crearDocumento(publicacion)
        End Function

        Public Function modificacionMenor(ByVal publicacion As SVSG_lib.Publicacion, ByVal cod_original As String, ByVal version_original As String) As Boolean Implements PublicacionService.IListado.modificacionMenor
            Return MyBase.Channel.modificacionMenor(publicacion, cod_original, version_original)
        End Function
        
        Public Function publicacionMayor(ByVal publicacion As SVSG_lib.Publicacion) As Boolean Implements PublicacionService.IListado.publicacionMayor
            Return MyBase.Channel.publicacionMayor(publicacion)
        End Function
        
        Public Function cargarItem(ByVal cod As String) As SVSG_lib.Documento Implements PublicacionService.IListado.cargarItem
            Return MyBase.Channel.cargarItem(cod)
        End Function
        
        Public Function eliminar(ByVal cod As String, ByVal ver As String) As Boolean Implements PublicacionService.IListado.eliminar
            Return MyBase.Channel.eliminar(cod, ver)
        End Function
    End Class
End Namespace
