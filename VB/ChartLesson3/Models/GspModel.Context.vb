﻿Imports System.Data.Entity.Infrastructure
Imports System.Data.Entity
Imports System

'------------------------------------------------------------------------------
' <auto-generated>
'    This code was generated from a template.
'
'    Manual changes to this file may cause unexpected behavior in your application.
'    Manual changes to this file will be overwritten if the code is regenerated.
' </auto-generated>
'------------------------------------------------------------------------------

Namespace ChartLesson3.Models

    Partial Public Class GspDbContext
        Inherits DbContext

        Public Sub New()
            MyBase.New("name=GspDbContext")
        End Sub

        Protected Overrides Sub OnModelCreating(ByVal modelBuilder As DbModelBuilder)
            Throw New UnintentionalCodeFirstException()
        End Sub

        Public Property GSPs() As DbSet(Of GSP)
    End Class
End Namespace
