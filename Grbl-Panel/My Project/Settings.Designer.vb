﻿'------------------------------------------------------------------------------
' <auto-generated>
'     This code was generated by a tool.
'     Runtime Version:4.0.30319.42000
'
'     Changes to this file may cause incorrect behavior and will be lost if
'     the code is regenerated.
' </auto-generated>
'------------------------------------------------------------------------------

Option Strict On
Option Explicit On


Namespace My
    
    <Global.System.Runtime.CompilerServices.CompilerGeneratedAttribute(),  _
     Global.System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "14.0.0.0"),  _
     Global.System.ComponentModel.EditorBrowsableAttribute(Global.System.ComponentModel.EditorBrowsableState.Advanced)>  _
    Partial Friend NotInheritable Class MySettings
        Inherits Global.System.Configuration.ApplicationSettingsBase
        
        Private Shared defaultInstance As MySettings = CType(Global.System.Configuration.ApplicationSettingsBase.Synchronized(New MySettings()),MySettings)
        
#Region "My.Settings Auto-Save Functionality"
#If _MyType = "WindowsForms" Then
    Private Shared addedHandler As Boolean

    Private Shared addedHandlerLockObject As New Object

    <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(), Global.System.ComponentModel.EditorBrowsableAttribute(Global.System.ComponentModel.EditorBrowsableState.Advanced)> _
    Private Shared Sub AutoSaveSettings(ByVal sender As Global.System.Object, ByVal e As Global.System.EventArgs)
        If My.Application.SaveMySettingsOnExit Then
            My.Settings.Save()
        End If
    End Sub
#End If
#End Region
        
        Public Shared ReadOnly Property [Default]() As MySettings
            Get
                
#If _MyType = "WindowsForms" Then
               If Not addedHandler Then
                    SyncLock addedHandlerLockObject
                        If Not addedHandler Then
                            AddHandler My.Application.Shutdown, AddressOf AutoSaveSettings
                            addedHandler = True
                        End If
                    End SyncLock
                End If
#End If
                Return defaultInstance
            End Get
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("")>  _
        Public Property Port() As String
            Get
                Return CType(Me("Port"),String)
            End Get
            Set
                Me("Port") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("115200")>  _
        Public Property Baud() As String
            Get
                Return CType(Me("Baud"),String)
            End Get
            Set
                Me("Baud") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("False")>  _
        Public Property JoggingUnitsMetric() As Boolean
            Get
                Return CType(Me("JoggingUnitsMetric"),Boolean)
            End Get
            Set
                Me("JoggingUnitsMetric") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("G90 G10 L20 P0 X0 Y0 Z0")>  _
        Public Property Work0Cmd() As String
            Get
                Return CType(Me("Work0Cmd"),String)
            End Get
            Set
                Me("Work0Cmd") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("True")>  _
        Public Property StatusPollEnabled() As Boolean
            Get
                Return CType(Me("StatusPollEnabled"),Boolean)
            End Get
            Set
                Me("StatusPollEnabled") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("False")>  _
        Public Property StatusVerbose() As Boolean
            Get
                Return CType(Me("StatusVerbose"),Boolean)
            End Get
            Set
                Me("StatusVerbose") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("200")>  _
        Public Property StatusPollInterval() As String
            Get
                Return CType(Me("StatusPollInterval"),String)
            End Get
            Set
                Me("StatusPollInterval") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("G90 G10 L20 P0 X0")>  _
        Public Property WorkX0Cmd() As String
            Get
                Return CType(Me("WorkX0Cmd"),String)
            End Get
            Set
                Me("WorkX0Cmd") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("G90 G10 L20 P0 Y0")>  _
        Public Property WorkY0Cmd() As String
            Get
                Return CType(Me("WorkY0Cmd"),String)
            End Get
            Set
                Me("WorkY0Cmd") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("G90 G10 L20 P0 Z0")>  _
        Public Property WorkZ0Cmd() As String
            Get
                Return CType(Me("WorkZ0Cmd"),String)
            End Get
            Set
                Me("WorkZ0Cmd") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("100,50,10,5")>  _
        Public Property JoggingFRImperial() As String
            Get
                Return CType(Me("JoggingFRImperial"),String)
            End Get
            Set
                Me("JoggingFRImperial") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("1,0.1,0.01,0.001")>  _
        Public Property JoggingFIImperial() As String
            Get
                Return CType(Me("JoggingFIImperial"),String)
            End Get
            Set
                Me("JoggingFIImperial") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("10,1,0.1,0.01 ")>  _
        Public Property JoggingFIMEtric() As String
            Get
                Return CType(Me("JoggingFIMEtric"),String)
            End Get
            Set
                Me("JoggingFIMEtric") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("1000,500,100,5")>  _
        Public Property JoggingFRMetric() As String
            Get
                Return CType(Me("JoggingFRMetric"),String)
            End Get
            Set
                Me("JoggingFRMetric") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("17")>  _
        Public Property QBuffMaxSize() As String
            Get
                Return CType(Me("QBuffMaxSize"),String)
            End Get
            Set
                Me("QBuffMaxSize") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("127")>  _
        Public Property RBuffMaxSize() As String
            Get
                Return CType(Me("RBuffMaxSize"),String)
            End Get
            Set
                Me("RBuffMaxSize") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("2.5")>  _
        Public Property JoggingXRepeat() As String
            Get
                Return CType(Me("JoggingXRepeat"),String)
            End Get
            Set
                Me("JoggingXRepeat") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("2.5")>  _
        Public Property JoggingZRepeat() As String
            Get
                Return CType(Me("JoggingZRepeat"),String)
            End Get
            Set
                Me("JoggingZRepeat") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("2.5")>  _
        Public Property JoggingYRepeat() As String
            Get
                Return CType(Me("JoggingYRepeat"),String)
            End Get
            Set
                Me("JoggingYRepeat") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("True")>  _
        Public Property GCodePauseOnError() As Boolean
            Get
                Return CType(Me("GCodePauseOnError"),Boolean)
            End Get
            Set
                Me("GCodePauseOnError") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("False")>  _
        Public Property GrblConnectOnLoad() As Boolean
            Get
                Return CType(Me("GrblConnectOnLoad"),Boolean)
            End Get
            Set
                Me("GrblConnectOnLoad") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("False")>  _
        Public Property JoggingUseKeyboard() As Boolean
            Get
                Return CType(Me("JoggingUseKeyboard"),Boolean)
            End Get
            Set
                Me("JoggingUseKeyboard") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("False")>  _
        Public Property LeftHandedGUI() As Boolean
            Get
                Return CType(Me("LeftHandedGUI"),Boolean)
            End Get
            Set
                Me("LeftHandedGUI") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("G28")>  _
        Public Property MachineSpclPosition1() As String
            Get
                Return CType(Me("MachineSpclPosition1"),String)
            End Get
            Set
                Me("MachineSpclPosition1") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("G30")>  _
        Public Property MachineSpclPosition2() As String
            Get
                Return CType(Me("MachineSpclPosition2"),String)
            End Get
            Set
                Me("MachineSpclPosition2") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("$132")>  _
        Public Property GrblLastParamID() As String
            Get
                Return CType(Me("GrblLastParamID"),String)
            End Get
            Set
                Me("GrblLastParamID") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("I2")>  _
        Public Property JoggingFIDefault() As String
            Get
                Return CType(Me("JoggingFIDefault"),String)
            End Get
            Set
                Me("JoggingFIDefault") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("F2")>  _
        Public Property JoggingFRDefault() As String
            Get
                Return CType(Me("JoggingFRDefault"),String)
            End Get
            Set
                Me("JoggingFRDefault") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("1.5")>  _
        Public Property StartupDelay() As String
            Get
                Return CType(Me("StartupDelay"),String)
            End Get
            Set
                Me("StartupDelay") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("")>  _
        Public Property DefaultFileExt() As String
            Get
                Return CType(Me("DefaultFileExt"),String)
            End Get
            Set
                Me("DefaultFileExt") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("")>  _
        Public Property IPAddress() As String
            Get
                Return CType(Me("IPAddress"),String)
            End Get
            Set
                Me("IPAddress") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("0")>  _
        Public Property ConnectionType() As String
            Get
                Return CType(Me("ConnectionType"),String)
            End Get
            Set
                Me("ConnectionType") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("")>  _
        Public Property Macro1() As String
            Get
                Return CType(Me("Macro1"),String)
            End Get
            Set
                Me("Macro1") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("")>  _
        Public Property Macro2() As String
            Get
                Return CType(Me("Macro2"),String)
            End Get
            Set
                Me("Macro2") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("")>  _
        Public Property Macro3() As String
            Get
                Return CType(Me("Macro3"),String)
            End Get
            Set
                Me("Macro3") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("")>  _
        Public Property Macro4() As String
            Get
                Return CType(Me("Macro4"),String)
            End Get
            Set
                Me("Macro4") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("")>  _
        Public Property Macro5() As String
            Get
                Return CType(Me("Macro5"),String)
            End Get
            Set
                Me("Macro5") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("True")>  _
        Public Property UpgradeSettings() As Boolean
            Get
                Return CType(Me("UpgradeSettings"),Boolean)
            End Get
            Set
                Me("UpgradeSettings") = value
            End Set
        End Property
    End Class
End Namespace

Namespace My
    
    <Global.Microsoft.VisualBasic.HideModuleNameAttribute(),  _
     Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
     Global.System.Runtime.CompilerServices.CompilerGeneratedAttribute()>  _
    Friend Module MySettingsProperty
        
        <Global.System.ComponentModel.Design.HelpKeywordAttribute("My.Settings")>  _
        Friend ReadOnly Property Settings() As Global.GrblPanel.My.MySettings
            Get
                Return Global.GrblPanel.My.MySettings.Default
            End Get
        End Property
    End Module
End Namespace
