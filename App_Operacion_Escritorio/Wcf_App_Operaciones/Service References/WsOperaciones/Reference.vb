﻿'------------------------------------------------------------------------------
' <auto-generated>
'     Este código fue generado por una herramienta.
'     Versión de runtime:4.0.30319.42000
'
'     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
'     se vuelve a generar el código.
' </auto-generated>
'------------------------------------------------------------------------------

Option Strict On
Option Explicit On


Namespace WsOperaciones
    
    <System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0"),  _
     System.ServiceModel.ServiceContractAttribute(ConfigurationName:="WsOperaciones.IService")>  _
    Public Interface IService
        
        <System.ServiceModel.OperationContractAttribute(Action:="http://tempuri.org/IService/Opsuma", ReplyAction:="http://tempuri.org/IService/OpsumaResponse")>  _
        Function Opsuma(ByVal Valor1 As Integer, ByVal Valor2 As Integer) As Integer
        
        <System.ServiceModel.OperationContractAttribute(Action:="http://tempuri.org/IService/OpResta", ReplyAction:="http://tempuri.org/IService/OpRestaResponse")>  _
        Function OpResta(ByVal Valor1 As Integer, ByVal Valor2 As Integer) As Integer
        
        <System.ServiceModel.OperationContractAttribute(Action:="http://tempuri.org/IService/OpMultiplica", ReplyAction:="http://tempuri.org/IService/OpMultiplicaResponse")>  _
        Function OpMultiplica(ByVal Valor1 As Integer, ByVal Valor2 As Integer) As Integer
        
        <System.ServiceModel.OperationContractAttribute(Action:="http://tempuri.org/IService/OpDivide", ReplyAction:="http://tempuri.org/IService/OpDivideResponse")>  _
        Function OpDivide(ByVal Valor1 As Integer, ByVal Valor2 As Integer) As Integer
    End Interface
    
    <System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")>  _
    Public Interface IServiceChannel
        Inherits WsOperaciones.IService, System.ServiceModel.IClientChannel
    End Interface
    
    <System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")>  _
    Partial Public Class ServiceClient
        Inherits System.ServiceModel.ClientBase(Of WsOperaciones.IService)
        Implements WsOperaciones.IService
        
        Public Sub New()
            MyBase.New
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
        
        Public Function Opsuma(ByVal Valor1 As Integer, ByVal Valor2 As Integer) As Integer Implements WsOperaciones.IService.Opsuma
            Return MyBase.Channel.Opsuma(Valor1, Valor2)
        End Function
        
        Public Function OpResta(ByVal Valor1 As Integer, ByVal Valor2 As Integer) As Integer Implements WsOperaciones.IService.OpResta
            Return MyBase.Channel.OpResta(Valor1, Valor2)
        End Function
        
        Public Function OpMultiplica(ByVal Valor1 As Integer, ByVal Valor2 As Integer) As Integer Implements WsOperaciones.IService.OpMultiplica
            Return MyBase.Channel.OpMultiplica(Valor1, Valor2)
        End Function
        
        Public Function OpDivide(ByVal Valor1 As Integer, ByVal Valor2 As Integer) As Integer Implements WsOperaciones.IService.OpDivide
            Return MyBase.Channel.OpDivide(Valor1, Valor2)
        End Function
    End Class
End Namespace
