﻿Namespace CustomFunctionReturningArrayExample
    Partial Public Class Form1
        ''' <summary>
        ''' Required designer variable.
        ''' </summary>
        Private components As System.ComponentModel.IContainer = Nothing

        ''' <summary>
        ''' Clean up any resources being used.
        ''' </summary>
        ''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If disposing AndAlso (components IsNot Nothing) Then
                components.Dispose()
            End If
            MyBase.Dispose(disposing)
        End Sub

        #Region "Windows Form Designer generated code"

        ''' <summary>
        ''' Required method for Designer support - do not modify
        ''' the contents of this method with the code editor.
        ''' </summary>
        Private Sub InitializeComponent()
            Me.components = New System.ComponentModel.Container()
            Dim spreadsheetCommandGalleryItemGroup8 As New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup()
            Dim spreadsheetCommandGalleryItem56 As New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
            Dim spreadsheetCommandGalleryItem57 As New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
            Dim spreadsheetCommandGalleryItem58 As New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
            Dim spreadsheetCommandGalleryItem59 As New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
            Dim spreadsheetCommandGalleryItem60 As New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
            Dim spreadsheetCommandGalleryItem61 As New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
            Dim spreadsheetCommandGalleryItemGroup9 As New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup()
            Dim spreadsheetCommandGalleryItem62 As New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
            Dim spreadsheetCommandGalleryItem63 As New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
            Dim spreadsheetCommandGalleryItem64 As New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
            Dim spreadsheetCommandGalleryItem65 As New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
            Dim spreadsheetCommandGalleryItem66 As New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
            Dim spreadsheetCommandGalleryItem67 As New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
            Dim galleryItemGroup2 As New DevExpress.XtraBars.Ribbon.GalleryItemGroup()
            Dim spreadsheetCommandGalleryItem68 As New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
            Dim spreadsheetCommandGalleryItem69 As New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
            Dim spreadsheetCommandGalleryItem70 As New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
            Dim spreadsheetCommandGalleryItem71 As New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
            Dim spreadsheetCommandGalleryItem72 As New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
            Dim spreadsheetCommandGalleryItem73 As New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
            Dim spreadsheetCommandGalleryItem74 As New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
            Dim spreadsheetCommandGalleryItem75 As New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
            Dim spreadsheetCommandGalleryItem76 As New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
            Dim spreadsheetCommandGalleryItem77 As New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
            Dim spreadsheetCommandGalleryItem78 As New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
            Dim spreadsheetCommandGalleryItemGroup10 As New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup()
            Dim spreadsheetCommandGalleryItem79 As New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
            Dim spreadsheetCommandGalleryItem80 As New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
            Dim spreadsheetCommandGalleryItem81 As New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
            Dim spreadsheetCommandGalleryItem82 As New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
            Dim spreadsheetCommandGalleryItem83 As New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
            Dim spreadsheetCommandGalleryItem84 As New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
            Dim spreadsheetCommandGalleryItem85 As New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
            Dim spreadsheetCommandGalleryItem86 As New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
            Dim spreadsheetCommandGalleryItem87 As New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
            Dim spreadsheetCommandGalleryItem88 As New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
            Dim spreadsheetCommandGalleryItem89 As New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
            Dim spreadsheetCommandGalleryItem90 As New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
            Dim spreadsheetCommandGalleryItemGroup11 As New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup()
            Dim spreadsheetCommandGalleryItem91 As New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
            Dim spreadsheetCommandGalleryItem92 As New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
            Dim spreadsheetCommandGalleryItem93 As New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
            Dim spreadsheetCommandGalleryItem94 As New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
            Dim spreadsheetCommandGalleryItem95 As New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
            Dim spreadsheetCommandGalleryItem96 As New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
            Dim spreadsheetCommandGalleryItem97 As New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
            Dim spreadsheetCommandGalleryItemGroup12 As New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup()
            Dim spreadsheetCommandGalleryItem98 As New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
            Dim spreadsheetCommandGalleryItem99 As New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
            Dim spreadsheetCommandGalleryItem100 As New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
            Dim spreadsheetCommandGalleryItem101 As New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
            Dim spreadsheetCommandGalleryItem102 As New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
            Dim spreadsheetCommandGalleryItemGroup13 As New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup()
            Dim spreadsheetCommandGalleryItem103 As New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
            Dim spreadsheetCommandGalleryItem104 As New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
            Dim spreadsheetCommandGalleryItem105 As New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
            Dim spreadsheetCommandGalleryItemGroup14 As New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup()
            Dim spreadsheetCommandGalleryItem106 As New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
            Dim spreadsheetCommandGalleryItem107 As New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
            Dim spreadsheetCommandGalleryItem108 As New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
            Dim spreadsheetCommandGalleryItem109 As New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
            Dim spreadsheetCommandGalleryItem110 As New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
            Dim reduceOperation2 As New DevExpress.XtraBars.Ribbon.ReduceOperation()
            Me.stylesRibbonPageGroup1 = New DevExpress.XtraSpreadsheet.UI.StylesRibbonPageGroup()
            Me.spreadsheetCommandBarSubItem4 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarSubItem()
            Me.spreadsheetCommandBarSubItem5 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarSubItem()
            Me.spreadsheetCommandBarButtonItem45 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem()
            Me.spreadsheetCommandBarButtonItem46 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem()
            Me.spreadsheetCommandBarButtonItem47 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem()
            Me.spreadsheetCommandBarButtonItem48 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem()
            Me.spreadsheetCommandBarButtonItem49 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem()
            Me.spreadsheetCommandBarButtonItem50 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem()
            Me.spreadsheetCommandBarButtonItem51 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem()
            Me.spreadsheetCommandBarSubItem6 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarSubItem()
            Me.spreadsheetCommandBarButtonItem52 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem()
            Me.spreadsheetCommandBarButtonItem53 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem()
            Me.spreadsheetCommandBarButtonItem54 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem()
            Me.spreadsheetCommandBarButtonItem55 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem()
            Me.spreadsheetCommandBarButtonItem56 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem()
            Me.spreadsheetCommandBarButtonItem57 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem()
            Me.spreadsheetCommandBarButtonGalleryDropDownItem1 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonGalleryDropDownItem()
            Me.commandBarGalleryDropDown2 = New DevExpress.XtraBars.Commands.CommandBarGalleryDropDown(Me.components)
            Me.ribbonControl1 = New DevExpress.XtraBars.Ribbon.RibbonControl()
            Me.spreadsheetCommandBarButtonItem1 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem()
            Me.spreadsheetCommandBarButtonItem2 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem()
            Me.spreadsheetCommandBarButtonItem3 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem()
            Me.spreadsheetCommandBarButtonItem4 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem()
            Me.spreadsheetCommandBarButtonItem5 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem()
            Me.spreadsheetCommandBarButtonItem6 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem()
            Me.spreadsheetCommandBarButtonItem7 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem()
            Me.spreadsheetCommandBarButtonItem8 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem()
            Me.spreadsheetCommandBarButtonItem9 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem()
            Me.spreadsheetCommandBarButtonItem10 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem()
            Me.spreadsheetCommandBarButtonItem11 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem()
            Me.spreadsheetCommandBarButtonItem12 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem()
            Me.spreadsheetCommandBarButtonItem13 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem()
            Me.spreadsheetCommandBarButtonItem14 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem()
            Me.spreadsheetCommandBarButtonItem15 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem()
            Me.barButtonGroup1 = New DevExpress.XtraBars.BarButtonGroup()
            Me.changeFontNameItem1 = New DevExpress.XtraSpreadsheet.UI.ChangeFontNameItem()
            Me.repositoryItemFontEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemFontEdit()
            Me.changeFontSizeItem1 = New DevExpress.XtraSpreadsheet.UI.ChangeFontSizeItem()
            Me.repositoryItemSpreadsheetFontSizeEdit1 = New DevExpress.XtraSpreadsheet.Design.RepositoryItemSpreadsheetFontSizeEdit()
            Me.spreadsheetControl1 = New DevExpress.XtraSpreadsheet.SpreadsheetControl()
            Me.spreadsheetCommandBarButtonItem16 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem()
            Me.spreadsheetCommandBarButtonItem17 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem()
            Me.barButtonGroup2 = New DevExpress.XtraBars.BarButtonGroup()
            Me.spreadsheetCommandBarCheckItem1 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarCheckItem()
            Me.spreadsheetCommandBarCheckItem2 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarCheckItem()
            Me.spreadsheetCommandBarCheckItem3 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarCheckItem()
            Me.spreadsheetCommandBarCheckItem4 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarCheckItem()
            Me.barButtonGroup3 = New DevExpress.XtraBars.BarButtonGroup()
            Me.spreadsheetCommandBarSubItem1 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarSubItem()
            Me.spreadsheetCommandBarButtonItem18 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem()
            Me.spreadsheetCommandBarButtonItem19 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem()
            Me.spreadsheetCommandBarButtonItem20 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem()
            Me.spreadsheetCommandBarButtonItem21 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem()
            Me.spreadsheetCommandBarButtonItem22 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem()
            Me.spreadsheetCommandBarButtonItem23 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem()
            Me.spreadsheetCommandBarButtonItem24 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem()
            Me.spreadsheetCommandBarButtonItem25 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem()
            Me.spreadsheetCommandBarButtonItem26 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem()
            Me.spreadsheetCommandBarButtonItem27 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem()
            Me.spreadsheetCommandBarButtonItem28 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem()
            Me.spreadsheetCommandBarButtonItem29 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem()
            Me.spreadsheetCommandBarButtonItem30 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem()
            Me.changeBorderLineColorItem1 = New DevExpress.XtraSpreadsheet.UI.ChangeBorderLineColorItem()
            Me.changeBorderLineStyleItem1 = New DevExpress.XtraSpreadsheet.UI.ChangeBorderLineStyleItem()
            Me.commandBarGalleryDropDown1 = New DevExpress.XtraBars.Commands.CommandBarGalleryDropDown(Me.components)
            Me.barButtonGroup4 = New DevExpress.XtraBars.BarButtonGroup()
            Me.changeCellFillColorItem1 = New DevExpress.XtraSpreadsheet.UI.ChangeCellFillColorItem()
            Me.changeFontColorItem1 = New DevExpress.XtraSpreadsheet.UI.ChangeFontColorItem()
            Me.barButtonGroup5 = New DevExpress.XtraBars.BarButtonGroup()
            Me.spreadsheetCommandBarCheckItem5 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarCheckItem()
            Me.spreadsheetCommandBarCheckItem6 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarCheckItem()
            Me.spreadsheetCommandBarCheckItem7 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarCheckItem()
            Me.barButtonGroup6 = New DevExpress.XtraBars.BarButtonGroup()
            Me.spreadsheetCommandBarCheckItem8 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarCheckItem()
            Me.spreadsheetCommandBarCheckItem9 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarCheckItem()
            Me.spreadsheetCommandBarCheckItem10 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarCheckItem()
            Me.barButtonGroup7 = New DevExpress.XtraBars.BarButtonGroup()
            Me.spreadsheetCommandBarButtonItem31 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem()
            Me.spreadsheetCommandBarButtonItem32 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem()
            Me.spreadsheetCommandBarCheckItem11 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarCheckItem()
            Me.spreadsheetCommandBarSubItem2 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarSubItem()
            Me.spreadsheetCommandBarCheckItem12 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarCheckItem()
            Me.spreadsheetCommandBarButtonItem33 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem()
            Me.spreadsheetCommandBarButtonItem34 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem()
            Me.spreadsheetCommandBarButtonItem35 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem()
            Me.barButtonGroup8 = New DevExpress.XtraBars.BarButtonGroup()
            Me.changeNumberFormatItem1 = New DevExpress.XtraSpreadsheet.UI.ChangeNumberFormatItem()
            Me.repositoryItemPopupGalleryEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemPopupGalleryEdit()
            Me.barButtonGroup9 = New DevExpress.XtraBars.BarButtonGroup()
            Me.spreadsheetCommandBarSubItem3 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarSubItem()
            Me.spreadsheetCommandBarButtonItem36 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem()
            Me.spreadsheetCommandBarButtonItem37 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem()
            Me.spreadsheetCommandBarButtonItem38 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem()
            Me.spreadsheetCommandBarButtonItem39 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem()
            Me.spreadsheetCommandBarButtonItem40 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem()
            Me.spreadsheetCommandBarButtonItem41 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem()
            Me.spreadsheetCommandBarButtonItem42 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem()
            Me.barButtonGroup10 = New DevExpress.XtraBars.BarButtonGroup()
            Me.spreadsheetCommandBarButtonItem43 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem()
            Me.spreadsheetCommandBarButtonItem44 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem()
            Me.spreadsheetCommandBarButtonGalleryDropDownItem2 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonGalleryDropDownItem()
            Me.commandBarGalleryDropDown3 = New DevExpress.XtraBars.Commands.CommandBarGalleryDropDown(Me.components)
            Me.spreadsheetCommandBarButtonGalleryDropDownItem3 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonGalleryDropDownItem()
            Me.commandBarGalleryDropDown4 = New DevExpress.XtraBars.Commands.CommandBarGalleryDropDown(Me.components)
            Me.spreadsheetCommandBarButtonItem58 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem()
            Me.spreadsheetCommandBarButtonItem59 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem()
            Me.spreadsheetCommandBarButtonItem60 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem()
            Me.spreadsheetCommandBarSubItem7 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarSubItem()
            Me.galleryFormatAsTableItem1 = New DevExpress.XtraSpreadsheet.UI.GalleryFormatAsTableItem()
            Me.commandBarGalleryDropDown5 = New DevExpress.XtraBars.Commands.CommandBarGalleryDropDown(Me.components)
            Me.galleryChangeStyleItem1 = New DevExpress.XtraSpreadsheet.UI.GalleryChangeStyleItem()
            Me.spreadsheetCommandBarSubItem8 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarSubItem()
            Me.spreadsheetCommandBarButtonItem61 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem()
            Me.spreadsheetCommandBarButtonItem62 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem()
            Me.spreadsheetCommandBarButtonItem63 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem()
            Me.spreadsheetCommandBarSubItem9 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarSubItem()
            Me.spreadsheetCommandBarButtonItem64 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem()
            Me.spreadsheetCommandBarButtonItem65 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem()
            Me.spreadsheetCommandBarButtonItem66 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem()
            Me.spreadsheetCommandBarSubItem10 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarSubItem()
            Me.spreadsheetCommandBarButtonItem67 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem()
            Me.spreadsheetCommandBarButtonItem68 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem()
            Me.spreadsheetCommandBarButtonItem69 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem()
            Me.spreadsheetCommandBarButtonItem70 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem()
            Me.spreadsheetCommandBarButtonItem71 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem()
            Me.spreadsheetCommandBarSubItem11 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarSubItem()
            Me.spreadsheetCommandBarButtonItem72 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem()
            Me.spreadsheetCommandBarButtonItem73 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem()
            Me.spreadsheetCommandBarButtonItem74 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem()
            Me.spreadsheetCommandBarButtonItem75 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem()
            Me.spreadsheetCommandBarButtonItem76 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem()
            Me.spreadsheetCommandBarButtonItem77 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem()
            Me.spreadsheetCommandBarButtonItem78 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem()
            Me.spreadsheetCommandBarButtonItem79 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem()
            Me.changeSheetTabColorItem1 = New DevExpress.XtraSpreadsheet.UI.ChangeSheetTabColorItem()
            Me.spreadsheetCommandBarButtonItem80 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem()
            Me.spreadsheetCommandBarCheckItem13 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarCheckItem()
            Me.spreadsheetCommandBarButtonItem81 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem()
            Me.spreadsheetCommandBarSubItem12 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarSubItem()
            Me.spreadsheetCommandBarButtonItem82 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem()
            Me.spreadsheetCommandBarButtonItem83 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem()
            Me.spreadsheetCommandBarButtonItem84 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem()
            Me.spreadsheetCommandBarButtonItem85 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem()
            Me.spreadsheetCommandBarButtonItem86 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem()
            Me.spreadsheetCommandBarSubItem13 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarSubItem()
            Me.spreadsheetCommandBarButtonItem87 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem()
            Me.spreadsheetCommandBarButtonItem88 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem()
            Me.spreadsheetCommandBarButtonItem89 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem()
            Me.spreadsheetCommandBarButtonItem90 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem()
            Me.spreadsheetCommandBarSubItem14 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarSubItem()
            Me.spreadsheetCommandBarButtonItem91 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem()
            Me.spreadsheetCommandBarButtonItem92 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem()
            Me.spreadsheetCommandBarButtonItem93 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem()
            Me.spreadsheetCommandBarButtonItem94 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem()
            Me.spreadsheetCommandBarButtonItem95 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem()
            Me.spreadsheetCommandBarButtonItem96 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem()
            Me.spreadsheetCommandBarSubItem15 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarSubItem()
            Me.spreadsheetCommandBarButtonItem97 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem()
            Me.spreadsheetCommandBarButtonItem98 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem()
            Me.spreadsheetCommandBarCheckItem14 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarCheckItem()
            Me.spreadsheetCommandBarButtonItem99 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem()
            Me.spreadsheetCommandBarButtonItem100 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem()
            Me.spreadsheetCommandBarSubItem16 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarSubItem()
            Me.spreadsheetCommandBarButtonItem101 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem()
            Me.spreadsheetCommandBarButtonItem102 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem()
            Me.spreadsheetCommandBarButtonItem103 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem()
            Me.spreadsheetCommandBarButtonItem104 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem()
            Me.spreadsheetCommandBarButtonItem105 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem()
            Me.spreadsheetCommandBarButtonItem106 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem()
            Me.spreadsheetCommandBarButtonItem107 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem()
            Me.spreadsheetCommandBarSubItem17 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarSubItem()
            Me.functionsFinancialItem1 = New DevExpress.XtraSpreadsheet.UI.FunctionsFinancialItem()
            Me.functionsLogicalItem1 = New DevExpress.XtraSpreadsheet.UI.FunctionsLogicalItem()
            Me.functionsTextItem1 = New DevExpress.XtraSpreadsheet.UI.FunctionsTextItem()
            Me.functionsDateAndTimeItem1 = New DevExpress.XtraSpreadsheet.UI.FunctionsDateAndTimeItem()
            Me.functionsLookupAndReferenceItem1 = New DevExpress.XtraSpreadsheet.UI.FunctionsLookupAndReferenceItem()
            Me.functionsMathAndTrigonometryItem1 = New DevExpress.XtraSpreadsheet.UI.FunctionsMathAndTrigonometryItem()
            Me.spreadsheetCommandBarSubItem18 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarSubItem()
            Me.functionsStatisticalItem1 = New DevExpress.XtraSpreadsheet.UI.FunctionsStatisticalItem()
            Me.functionsEngineeringItem1 = New DevExpress.XtraSpreadsheet.UI.FunctionsEngineeringItem()
            Me.functionsInformationItem1 = New DevExpress.XtraSpreadsheet.UI.FunctionsInformationItem()
            Me.functionsCompatibilityItem1 = New DevExpress.XtraSpreadsheet.UI.FunctionsCompatibilityItem()
            Me.functionsWebItem1 = New DevExpress.XtraSpreadsheet.UI.FunctionsWebItem()
            Me.spreadsheetCommandBarButtonItem113 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem()
            Me.spreadsheetCommandBarButtonItem114 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem()
            Me.definedNameListItem1 = New DevExpress.XtraSpreadsheet.UI.DefinedNameListItem()
            Me.spreadsheetCommandBarButtonItem115 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem()
            Me.spreadsheetCommandBarCheckItem15 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarCheckItem()
            Me.spreadsheetCommandBarSubItem19 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarSubItem()
            Me.spreadsheetCommandBarCheckItem16 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarCheckItem()
            Me.spreadsheetCommandBarCheckItem17 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarCheckItem()
            Me.spreadsheetCommandBarButtonItem116 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem()
            Me.spreadsheetCommandBarButtonItem117 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem()
            Me.fileRibbonPage1 = New DevExpress.XtraSpreadsheet.UI.FileRibbonPage()
            Me.commonRibbonPageGroup1 = New DevExpress.XtraSpreadsheet.UI.CommonRibbonPageGroup()
            Me.infoRibbonPageGroup1 = New DevExpress.XtraSpreadsheet.UI.InfoRibbonPageGroup()
            Me.homeRibbonPage1 = New DevExpress.XtraSpreadsheet.UI.HomeRibbonPage()
            Me.clipboardRibbonPageGroup1 = New DevExpress.XtraSpreadsheet.UI.ClipboardRibbonPageGroup()
            Me.fontRibbonPageGroup1 = New DevExpress.XtraSpreadsheet.UI.FontRibbonPageGroup()
            Me.alignmentRibbonPageGroup1 = New DevExpress.XtraSpreadsheet.UI.AlignmentRibbonPageGroup()
            Me.numberRibbonPageGroup1 = New DevExpress.XtraSpreadsheet.UI.NumberRibbonPageGroup()
            Me.cellsRibbonPageGroup1 = New DevExpress.XtraSpreadsheet.UI.CellsRibbonPageGroup()
            Me.editingRibbonPageGroup1 = New DevExpress.XtraSpreadsheet.UI.EditingRibbonPageGroup()
            Me.formulasRibbonPage1 = New DevExpress.XtraSpreadsheet.UI.FormulasRibbonPage()
            Me.functionLibraryRibbonPageGroup1 = New DevExpress.XtraSpreadsheet.UI.FunctionLibraryRibbonPageGroup()
            Me.formulaDefinedNamesRibbonPageGroup1 = New DevExpress.XtraSpreadsheet.UI.FormulaDefinedNamesRibbonPageGroup()
            Me.formulaAuditingRibbonPageGroup1 = New DevExpress.XtraSpreadsheet.UI.FormulaAuditingRibbonPageGroup()
            Me.formulaCalculationRibbonPageGroup1 = New DevExpress.XtraSpreadsheet.UI.FormulaCalculationRibbonPageGroup()
            Me.spreadsheetFormulaBarControl1 = New DevExpress.XtraSpreadsheet.SpreadsheetFormulaBarControl()
            Me.spreadsheetNameBoxControl1 = New DevExpress.XtraSpreadsheet.SpreadsheetNameBoxControl()
            Me.splitContainerControl1 = New DevExpress.XtraEditors.SplitContainerControl()
            Me.splitterControl1 = New DevExpress.XtraEditors.SplitterControl()
            Me.spreadsheetBarController1 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetBarController()
            Me.spreadsheetCommandBarButtonItem108 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem()
            Me.spreadsheetCommandBarButtonItem109 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem()
            Me.spreadsheetCommandBarButtonItem110 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem()
            Me.spreadsheetCommandBarButtonItem111 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem()
            Me.spreadsheetCommandBarButtonItem112 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem()
            Me.defaultLookAndFeel1 = New DevExpress.LookAndFeel.DefaultLookAndFeel(Me.components)
            CType(Me.commandBarGalleryDropDown2, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.ribbonControl1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.repositoryItemFontEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.repositoryItemSpreadsheetFontSizeEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.commandBarGalleryDropDown1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.repositoryItemPopupGalleryEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.commandBarGalleryDropDown3, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.commandBarGalleryDropDown4, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.commandBarGalleryDropDown5, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.spreadsheetNameBoxControl1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.splitContainerControl1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.splitContainerControl1.SuspendLayout()
            CType(Me.spreadsheetBarController1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            ' 
            ' stylesRibbonPageGroup1
            ' 
            Me.stylesRibbonPageGroup1.ItemLinks.Add(Me.spreadsheetCommandBarSubItem4)
            Me.stylesRibbonPageGroup1.ItemLinks.Add(Me.galleryFormatAsTableItem1)
            Me.stylesRibbonPageGroup1.ItemLinks.Add(Me.galleryChangeStyleItem1)
            Me.stylesRibbonPageGroup1.Name = "stylesRibbonPageGroup1"
            ' 
            ' spreadsheetCommandBarSubItem4
            ' 
            Me.spreadsheetCommandBarSubItem4.CommandName = "ConditionalFormattingCommandGroup"
            Me.spreadsheetCommandBarSubItem4.Id = 77
            Me.spreadsheetCommandBarSubItem4.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() { _
                New DevExpress.XtraBars.LinkPersistInfo(Me.spreadsheetCommandBarSubItem5), _
                New DevExpress.XtraBars.LinkPersistInfo(Me.spreadsheetCommandBarSubItem6), _
                New DevExpress.XtraBars.LinkPersistInfo(Me.spreadsheetCommandBarButtonGalleryDropDownItem1), _
                New DevExpress.XtraBars.LinkPersistInfo(Me.spreadsheetCommandBarButtonGalleryDropDownItem2), _
                New DevExpress.XtraBars.LinkPersistInfo(Me.spreadsheetCommandBarButtonGalleryDropDownItem3), _
                New DevExpress.XtraBars.LinkPersistInfo(Me.spreadsheetCommandBarButtonItem58), _
                New DevExpress.XtraBars.LinkPersistInfo(Me.spreadsheetCommandBarSubItem7) _
            })
            Me.spreadsheetCommandBarSubItem4.Name = "spreadsheetCommandBarSubItem4"
            ' 
            ' spreadsheetCommandBarSubItem5
            ' 
            Me.spreadsheetCommandBarSubItem5.CommandName = "ConditionalFormattingHighlightCellsRuleCommandGroup"
            Me.spreadsheetCommandBarSubItem5.Id = 85
            Me.spreadsheetCommandBarSubItem5.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() { _
                New DevExpress.XtraBars.LinkPersistInfo(Me.spreadsheetCommandBarButtonItem45), _
                New DevExpress.XtraBars.LinkPersistInfo(Me.spreadsheetCommandBarButtonItem46), _
                New DevExpress.XtraBars.LinkPersistInfo(Me.spreadsheetCommandBarButtonItem47), _
                New DevExpress.XtraBars.LinkPersistInfo(Me.spreadsheetCommandBarButtonItem48), _
                New DevExpress.XtraBars.LinkPersistInfo(Me.spreadsheetCommandBarButtonItem49), _
                New DevExpress.XtraBars.LinkPersistInfo(Me.spreadsheetCommandBarButtonItem50), _
                New DevExpress.XtraBars.LinkPersistInfo(Me.spreadsheetCommandBarButtonItem51) _
            })
            Me.spreadsheetCommandBarSubItem5.Name = "spreadsheetCommandBarSubItem5"
            ' 
            ' spreadsheetCommandBarButtonItem45
            ' 
            Me.spreadsheetCommandBarButtonItem45.CommandName = "ConditionalFormattingGreaterThanRuleCommand"
            Me.spreadsheetCommandBarButtonItem45.Id = 78
            Me.spreadsheetCommandBarButtonItem45.Name = "spreadsheetCommandBarButtonItem45"
            Me.spreadsheetCommandBarButtonItem45.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large
            ' 
            ' spreadsheetCommandBarButtonItem46
            ' 
            Me.spreadsheetCommandBarButtonItem46.CommandName = "ConditionalFormattingLessThanRuleCommand"
            Me.spreadsheetCommandBarButtonItem46.Id = 79
            Me.spreadsheetCommandBarButtonItem46.Name = "spreadsheetCommandBarButtonItem46"
            Me.spreadsheetCommandBarButtonItem46.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large
            ' 
            ' spreadsheetCommandBarButtonItem47
            ' 
            Me.spreadsheetCommandBarButtonItem47.CommandName = "ConditionalFormattingBetweenRuleCommand"
            Me.spreadsheetCommandBarButtonItem47.Id = 80
            Me.spreadsheetCommandBarButtonItem47.Name = "spreadsheetCommandBarButtonItem47"
            Me.spreadsheetCommandBarButtonItem47.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large
            ' 
            ' spreadsheetCommandBarButtonItem48
            ' 
            Me.spreadsheetCommandBarButtonItem48.CommandName = "ConditionalFormattingEqualToRuleCommand"
            Me.spreadsheetCommandBarButtonItem48.Id = 81
            Me.spreadsheetCommandBarButtonItem48.Name = "spreadsheetCommandBarButtonItem48"
            Me.spreadsheetCommandBarButtonItem48.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large
            ' 
            ' spreadsheetCommandBarButtonItem49
            ' 
            Me.spreadsheetCommandBarButtonItem49.CommandName = "ConditionalFormattingTextContainsRuleCommand"
            Me.spreadsheetCommandBarButtonItem49.Id = 82
            Me.spreadsheetCommandBarButtonItem49.Name = "spreadsheetCommandBarButtonItem49"
            Me.spreadsheetCommandBarButtonItem49.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large
            ' 
            ' spreadsheetCommandBarButtonItem50
            ' 
            Me.spreadsheetCommandBarButtonItem50.CommandName = "ConditionalFormattingDateOccurringRuleCommand"
            Me.spreadsheetCommandBarButtonItem50.Id = 83
            Me.spreadsheetCommandBarButtonItem50.Name = "spreadsheetCommandBarButtonItem50"
            Me.spreadsheetCommandBarButtonItem50.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large
            ' 
            ' spreadsheetCommandBarButtonItem51
            ' 
            Me.spreadsheetCommandBarButtonItem51.CommandName = "ConditionalFormattingDuplicateValuesRuleCommand"
            Me.spreadsheetCommandBarButtonItem51.Id = 84
            Me.spreadsheetCommandBarButtonItem51.Name = "spreadsheetCommandBarButtonItem51"
            Me.spreadsheetCommandBarButtonItem51.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large
            ' 
            ' spreadsheetCommandBarSubItem6
            ' 
            Me.spreadsheetCommandBarSubItem6.CommandName = "ConditionalFormattingTopBottomRuleCommandGroup"
            Me.spreadsheetCommandBarSubItem6.Id = 92
            Me.spreadsheetCommandBarSubItem6.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() { _
                New DevExpress.XtraBars.LinkPersistInfo(Me.spreadsheetCommandBarButtonItem52), _
                New DevExpress.XtraBars.LinkPersistInfo(Me.spreadsheetCommandBarButtonItem53), _
                New DevExpress.XtraBars.LinkPersistInfo(Me.spreadsheetCommandBarButtonItem54), _
                New DevExpress.XtraBars.LinkPersistInfo(Me.spreadsheetCommandBarButtonItem55), _
                New DevExpress.XtraBars.LinkPersistInfo(Me.spreadsheetCommandBarButtonItem56), _
                New DevExpress.XtraBars.LinkPersistInfo(Me.spreadsheetCommandBarButtonItem57) _
            })
            Me.spreadsheetCommandBarSubItem6.Name = "spreadsheetCommandBarSubItem6"
            ' 
            ' spreadsheetCommandBarButtonItem52
            ' 
            Me.spreadsheetCommandBarButtonItem52.CommandName = "ConditionalFormattingTop10RuleCommand"
            Me.spreadsheetCommandBarButtonItem52.Id = 86
            Me.spreadsheetCommandBarButtonItem52.Name = "spreadsheetCommandBarButtonItem52"
            Me.spreadsheetCommandBarButtonItem52.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large
            ' 
            ' spreadsheetCommandBarButtonItem53
            ' 
            Me.spreadsheetCommandBarButtonItem53.CommandName = "ConditionalFormattingTop10PercentRuleCommand"
            Me.spreadsheetCommandBarButtonItem53.Id = 87
            Me.spreadsheetCommandBarButtonItem53.Name = "spreadsheetCommandBarButtonItem53"
            Me.spreadsheetCommandBarButtonItem53.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large
            ' 
            ' spreadsheetCommandBarButtonItem54
            ' 
            Me.spreadsheetCommandBarButtonItem54.CommandName = "ConditionalFormattingBottom10RuleCommand"
            Me.spreadsheetCommandBarButtonItem54.Id = 88
            Me.spreadsheetCommandBarButtonItem54.Name = "spreadsheetCommandBarButtonItem54"
            Me.spreadsheetCommandBarButtonItem54.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large
            ' 
            ' spreadsheetCommandBarButtonItem55
            ' 
            Me.spreadsheetCommandBarButtonItem55.CommandName = "ConditionalFormattingBottom10PercentRuleCommand"
            Me.spreadsheetCommandBarButtonItem55.Id = 89
            Me.spreadsheetCommandBarButtonItem55.Name = "spreadsheetCommandBarButtonItem55"
            Me.spreadsheetCommandBarButtonItem55.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large
            ' 
            ' spreadsheetCommandBarButtonItem56
            ' 
            Me.spreadsheetCommandBarButtonItem56.CommandName = "ConditionalFormattingAboveAverageRuleCommand"
            Me.spreadsheetCommandBarButtonItem56.Id = 90
            Me.spreadsheetCommandBarButtonItem56.Name = "spreadsheetCommandBarButtonItem56"
            Me.spreadsheetCommandBarButtonItem56.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large
            ' 
            ' spreadsheetCommandBarButtonItem57
            ' 
            Me.spreadsheetCommandBarButtonItem57.CommandName = "ConditionalFormattingBelowAverageRuleCommand"
            Me.spreadsheetCommandBarButtonItem57.Id = 91
            Me.spreadsheetCommandBarButtonItem57.Name = "spreadsheetCommandBarButtonItem57"
            Me.spreadsheetCommandBarButtonItem57.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large
            ' 
            ' spreadsheetCommandBarButtonGalleryDropDownItem1
            ' 
            Me.spreadsheetCommandBarButtonGalleryDropDownItem1.CommandName = "ConditionalFormattingDataBarsCommandGroup"
            Me.spreadsheetCommandBarButtonGalleryDropDownItem1.DropDownControl = Me.commandBarGalleryDropDown2
            Me.spreadsheetCommandBarButtonGalleryDropDownItem1.Id = 93
            Me.spreadsheetCommandBarButtonGalleryDropDownItem1.Name = "spreadsheetCommandBarButtonGalleryDropDownItem1"
            Me.spreadsheetCommandBarButtonGalleryDropDownItem1.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large
            ' 
            ' commandBarGalleryDropDown2
            ' 
            ' 
            ' 
            ' 
            Me.commandBarGalleryDropDown2.Gallery.AllowFilter = False
            spreadsheetCommandGalleryItemGroup8.CommandName = "ConditionalFormattingDataBarsGradientFillCommandGroup"
            spreadsheetCommandGalleryItem56.CommandName = "ConditionalFormattingDataBarGradientBlue"
            spreadsheetCommandGalleryItem57.CommandName = "ConditionalFormattingDataBarGradientGreen"
            spreadsheetCommandGalleryItem58.CommandName = "ConditionalFormattingDataBarGradientRed"
            spreadsheetCommandGalleryItem59.CommandName = "ConditionalFormattingDataBarGradientOrange"
            spreadsheetCommandGalleryItem60.CommandName = "ConditionalFormattingDataBarGradientLightBlue"
            spreadsheetCommandGalleryItem61.CommandName = "ConditionalFormattingDataBarGradientPurple"
            spreadsheetCommandGalleryItemGroup8.Items.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItem() { spreadsheetCommandGalleryItem56, spreadsheetCommandGalleryItem57, spreadsheetCommandGalleryItem58, spreadsheetCommandGalleryItem59, spreadsheetCommandGalleryItem60, spreadsheetCommandGalleryItem61})
            spreadsheetCommandGalleryItemGroup9.CommandName = "ConditionalFormattingDataBarsSolidFillCommandGroup"
            spreadsheetCommandGalleryItem62.CommandName = "ConditionalFormattingDataBarSolidBlue"
            spreadsheetCommandGalleryItem63.CommandName = "ConditionalFormattingDataBarSolidGreen"
            spreadsheetCommandGalleryItem64.CommandName = "ConditionalFormattingDataBarSolidRed"
            spreadsheetCommandGalleryItem65.CommandName = "ConditionalFormattingDataBarSolidOrange"
            spreadsheetCommandGalleryItem66.CommandName = "ConditionalFormattingDataBarSolidLightBlue"
            spreadsheetCommandGalleryItem67.CommandName = "ConditionalFormattingDataBarSolidPurple"
            spreadsheetCommandGalleryItemGroup9.Items.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItem() { spreadsheetCommandGalleryItem62, spreadsheetCommandGalleryItem63, spreadsheetCommandGalleryItem64, spreadsheetCommandGalleryItem65, spreadsheetCommandGalleryItem66, spreadsheetCommandGalleryItem67})
            Me.commandBarGalleryDropDown2.Gallery.Groups.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItemGroup() { spreadsheetCommandGalleryItemGroup8, spreadsheetCommandGalleryItemGroup9})
            Me.commandBarGalleryDropDown2.Gallery.ImageSize = New System.Drawing.Size(32, 32)
            Me.commandBarGalleryDropDown2.Gallery.ShowScrollBar = DevExpress.XtraBars.Ribbon.Gallery.ShowScrollBar.Auto
            Me.commandBarGalleryDropDown2.Name = "commandBarGalleryDropDown2"
            Me.commandBarGalleryDropDown2.Ribbon = Me.ribbonControl1
            ' 
            ' ribbonControl1
            ' 
            Me.ribbonControl1.ExpandCollapseItem.Id = 0
            Me.ribbonControl1.Items.AddRange(New DevExpress.XtraBars.BarItem() { Me.ribbonControl1.ExpandCollapseItem, Me.spreadsheetCommandBarButtonItem1, Me.spreadsheetCommandBarButtonItem2, Me.spreadsheetCommandBarButtonItem3, Me.spreadsheetCommandBarButtonItem4, Me.spreadsheetCommandBarButtonItem5, Me.spreadsheetCommandBarButtonItem6, Me.spreadsheetCommandBarButtonItem7, Me.spreadsheetCommandBarButtonItem8, Me.spreadsheetCommandBarButtonItem9, Me.spreadsheetCommandBarButtonItem10, Me.spreadsheetCommandBarButtonItem11, Me.spreadsheetCommandBarButtonItem12, Me.spreadsheetCommandBarButtonItem13, Me.spreadsheetCommandBarButtonItem14, Me.spreadsheetCommandBarButtonItem15, Me.barButtonGroup1, Me.changeFontNameItem1, Me.changeFontSizeItem1, Me.spreadsheetCommandBarButtonItem16, Me.spreadsheetCommandBarButtonItem17, Me.barButtonGroup2, Me.spreadsheetCommandBarCheckItem1, Me.spreadsheetCommandBarCheckItem2, Me.spreadsheetCommandBarCheckItem3, Me.spreadsheetCommandBarCheckItem4, Me.barButtonGroup3, Me.spreadsheetCommandBarSubItem1, Me.spreadsheetCommandBarButtonItem18, Me.spreadsheetCommandBarButtonItem19, Me.spreadsheetCommandBarButtonItem20, Me.spreadsheetCommandBarButtonItem21, Me.spreadsheetCommandBarButtonItem22, Me.spreadsheetCommandBarButtonItem23, Me.spreadsheetCommandBarButtonItem24, Me.spreadsheetCommandBarButtonItem25, Me.spreadsheetCommandBarButtonItem26, Me.spreadsheetCommandBarButtonItem27, Me.spreadsheetCommandBarButtonItem28, Me.spreadsheetCommandBarButtonItem29, Me.spreadsheetCommandBarButtonItem30, Me.changeBorderLineColorItem1, Me.changeBorderLineStyleItem1, Me.barButtonGroup4, Me.changeCellFillColorItem1, Me.changeFontColorItem1, Me.barButtonGroup5, Me.spreadsheetCommandBarCheckItem5, Me.spreadsheetCommandBarCheckItem6, Me.spreadsheetCommandBarCheckItem7, Me.barButtonGroup6, Me.spreadsheetCommandBarCheckItem8, Me.spreadsheetCommandBarCheckItem9, Me.spreadsheetCommandBarCheckItem10, Me.barButtonGroup7, Me.spreadsheetCommandBarButtonItem31, Me.spreadsheetCommandBarButtonItem32, Me.spreadsheetCommandBarCheckItem11, Me.spreadsheetCommandBarSubItem2, Me.spreadsheetCommandBarCheckItem12, Me.spreadsheetCommandBarButtonItem33, Me.spreadsheetCommandBarButtonItem34, Me.spreadsheetCommandBarButtonItem35, Me.barButtonGroup8, Me.changeNumberFormatItem1, Me.barButtonGroup9, Me.spreadsheetCommandBarSubItem3, Me.spreadsheetCommandBarButtonItem36, Me.spreadsheetCommandBarButtonItem37, Me.spreadsheetCommandBarButtonItem38, Me.spreadsheetCommandBarButtonItem39, Me.spreadsheetCommandBarButtonItem40, Me.spreadsheetCommandBarButtonItem41, Me.spreadsheetCommandBarButtonItem42, Me.barButtonGroup10, Me.spreadsheetCommandBarButtonItem43, Me.spreadsheetCommandBarButtonItem44, Me.spreadsheetCommandBarSubItem4, Me.spreadsheetCommandBarButtonItem45, Me.spreadsheetCommandBarButtonItem46, Me.spreadsheetCommandBarButtonItem47, Me.spreadsheetCommandBarButtonItem48, Me.spreadsheetCommandBarButtonItem49, Me.spreadsheetCommandBarButtonItem50, Me.spreadsheetCommandBarButtonItem51, Me.spreadsheetCommandBarSubItem5, Me.spreadsheetCommandBarButtonItem52, Me.spreadsheetCommandBarButtonItem53, Me.spreadsheetCommandBarButtonItem54, Me.spreadsheetCommandBarButtonItem55, Me.spreadsheetCommandBarButtonItem56, Me.spreadsheetCommandBarButtonItem57, Me.spreadsheetCommandBarSubItem6, Me.spreadsheetCommandBarButtonGalleryDropDownItem1, Me.spreadsheetCommandBarButtonGalleryDropDownItem2, Me.spreadsheetCommandBarButtonGalleryDropDownItem3, Me.spreadsheetCommandBarButtonItem58, Me.spreadsheetCommandBarButtonItem59, Me.spreadsheetCommandBarButtonItem60, Me.spreadsheetCommandBarSubItem7, Me.galleryFormatAsTableItem1, Me.galleryChangeStyleItem1, Me.spreadsheetCommandBarSubItem8, Me.spreadsheetCommandBarButtonItem61, Me.spreadsheetCommandBarButtonItem62, Me.spreadsheetCommandBarButtonItem63, Me.spreadsheetCommandBarSubItem9, Me.spreadsheetCommandBarButtonItem64, Me.spreadsheetCommandBarButtonItem65, Me.spreadsheetCommandBarButtonItem66, Me.spreadsheetCommandBarSubItem10, Me.spreadsheetCommandBarButtonItem67, Me.spreadsheetCommandBarButtonItem68, Me.spreadsheetCommandBarButtonItem69, Me.spreadsheetCommandBarButtonItem70, Me.spreadsheetCommandBarButtonItem71, Me.spreadsheetCommandBarButtonItem72, Me.spreadsheetCommandBarButtonItem73, Me.spreadsheetCommandBarButtonItem74, Me.spreadsheetCommandBarButtonItem75, Me.spreadsheetCommandBarButtonItem76, Me.spreadsheetCommandBarButtonItem77, Me.spreadsheetCommandBarSubItem11, Me.spreadsheetCommandBarButtonItem78, Me.spreadsheetCommandBarButtonItem79, Me.changeSheetTabColorItem1, Me.spreadsheetCommandBarButtonItem80, Me.spreadsheetCommandBarCheckItem13, Me.spreadsheetCommandBarButtonItem81, Me.spreadsheetCommandBarSubItem12, Me.spreadsheetCommandBarButtonItem82, Me.spreadsheetCommandBarButtonItem83, Me.spreadsheetCommandBarButtonItem84, Me.spreadsheetCommandBarButtonItem85, Me.spreadsheetCommandBarButtonItem86, Me.spreadsheetCommandBarSubItem13, Me.spreadsheetCommandBarButtonItem87, Me.spreadsheetCommandBarButtonItem88, Me.spreadsheetCommandBarButtonItem89, Me.spreadsheetCommandBarButtonItem90, Me.spreadsheetCommandBarSubItem14, Me.spreadsheetCommandBarButtonItem91, Me.spreadsheetCommandBarButtonItem92, Me.spreadsheetCommandBarButtonItem93, Me.spreadsheetCommandBarButtonItem94, Me.spreadsheetCommandBarButtonItem95, Me.spreadsheetCommandBarButtonItem96, Me.spreadsheetCommandBarSubItem15, Me.spreadsheetCommandBarButtonItem97, Me.spreadsheetCommandBarButtonItem98, Me.spreadsheetCommandBarCheckItem14, Me.spreadsheetCommandBarButtonItem99, Me.spreadsheetCommandBarButtonItem100, Me.spreadsheetCommandBarSubItem16, Me.spreadsheetCommandBarButtonItem101, Me.spreadsheetCommandBarButtonItem102, Me.spreadsheetCommandBarButtonItem103, Me.spreadsheetCommandBarButtonItem104, Me.spreadsheetCommandBarButtonItem105, Me.spreadsheetCommandBarButtonItem106, Me.spreadsheetCommandBarButtonItem107, Me.spreadsheetCommandBarSubItem17, Me.functionsFinancialItem1, Me.functionsLogicalItem1, Me.functionsTextItem1, Me.functionsDateAndTimeItem1, Me.functionsLookupAndReferenceItem1, Me.functionsMathAndTrigonometryItem1, Me.spreadsheetCommandBarSubItem18, Me.functionsStatisticalItem1, Me.functionsEngineeringItem1, Me.functionsInformationItem1, Me.functionsCompatibilityItem1, Me.functionsWebItem1, Me.spreadsheetCommandBarButtonItem113, Me.spreadsheetCommandBarButtonItem114, Me.definedNameListItem1, Me.spreadsheetCommandBarButtonItem115, Me.spreadsheetCommandBarCheckItem15, Me.spreadsheetCommandBarSubItem19, Me.spreadsheetCommandBarCheckItem16, Me.spreadsheetCommandBarCheckItem17, Me.spreadsheetCommandBarButtonItem116, Me.spreadsheetCommandBarButtonItem117})
            Me.ribbonControl1.Location = New System.Drawing.Point(0, 0)
            Me.ribbonControl1.MaxItemId = 186
            Me.ribbonControl1.Name = "ribbonControl1"
            Me.ribbonControl1.Pages.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPage() { Me.fileRibbonPage1, Me.homeRibbonPage1, Me.formulasRibbonPage1})
            Me.ribbonControl1.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() { Me.repositoryItemFontEdit1, Me.repositoryItemSpreadsheetFontSizeEdit1, Me.repositoryItemPopupGalleryEdit1})
            Me.ribbonControl1.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonControlStyle.Office2013
            Me.ribbonControl1.Size = New System.Drawing.Size(784, 146)
            ' 
            ' spreadsheetCommandBarButtonItem1
            ' 
            Me.spreadsheetCommandBarButtonItem1.CommandName = "FileNew"
            Me.spreadsheetCommandBarButtonItem1.Id = 1
            Me.spreadsheetCommandBarButtonItem1.Name = "spreadsheetCommandBarButtonItem1"
            ' 
            ' spreadsheetCommandBarButtonItem2
            ' 
            Me.spreadsheetCommandBarButtonItem2.CommandName = "FileOpen"
            Me.spreadsheetCommandBarButtonItem2.Id = 2
            Me.spreadsheetCommandBarButtonItem2.Name = "spreadsheetCommandBarButtonItem2"
            ' 
            ' spreadsheetCommandBarButtonItem3
            ' 
            Me.spreadsheetCommandBarButtonItem3.CommandName = "FileSave"
            Me.spreadsheetCommandBarButtonItem3.Id = 3
            Me.spreadsheetCommandBarButtonItem3.Name = "spreadsheetCommandBarButtonItem3"
            ' 
            ' spreadsheetCommandBarButtonItem4
            ' 
            Me.spreadsheetCommandBarButtonItem4.CommandName = "FileSaveAs"
            Me.spreadsheetCommandBarButtonItem4.Id = 4
            Me.spreadsheetCommandBarButtonItem4.Name = "spreadsheetCommandBarButtonItem4"
            ' 
            ' spreadsheetCommandBarButtonItem5
            ' 
            Me.spreadsheetCommandBarButtonItem5.CommandName = "FileQuickPrint"
            Me.spreadsheetCommandBarButtonItem5.Id = 5
            Me.spreadsheetCommandBarButtonItem5.Name = "spreadsheetCommandBarButtonItem5"
            ' 
            ' spreadsheetCommandBarButtonItem6
            ' 
            Me.spreadsheetCommandBarButtonItem6.CommandName = "FilePrint"
            Me.spreadsheetCommandBarButtonItem6.Id = 6
            Me.spreadsheetCommandBarButtonItem6.Name = "spreadsheetCommandBarButtonItem6"
            ' 
            ' spreadsheetCommandBarButtonItem7
            ' 
            Me.spreadsheetCommandBarButtonItem7.CommandName = "FilePrintPreview"
            Me.spreadsheetCommandBarButtonItem7.Id = 7
            Me.spreadsheetCommandBarButtonItem7.Name = "spreadsheetCommandBarButtonItem7"
            ' 
            ' spreadsheetCommandBarButtonItem8
            ' 
            Me.spreadsheetCommandBarButtonItem8.CommandName = "FileUndo"
            Me.spreadsheetCommandBarButtonItem8.Id = 8
            Me.spreadsheetCommandBarButtonItem8.Name = "spreadsheetCommandBarButtonItem8"
            ' 
            ' spreadsheetCommandBarButtonItem9
            ' 
            Me.spreadsheetCommandBarButtonItem9.CommandName = "FileRedo"
            Me.spreadsheetCommandBarButtonItem9.Id = 9
            Me.spreadsheetCommandBarButtonItem9.Name = "spreadsheetCommandBarButtonItem9"
            ' 
            ' spreadsheetCommandBarButtonItem10
            ' 
            Me.spreadsheetCommandBarButtonItem10.CommandName = "FileEncrypt"
            Me.spreadsheetCommandBarButtonItem10.Id = 10
            Me.spreadsheetCommandBarButtonItem10.Name = "spreadsheetCommandBarButtonItem10"
            ' 
            ' spreadsheetCommandBarButtonItem11
            ' 
            Me.spreadsheetCommandBarButtonItem11.CommandName = "FileShowDocumentProperties"
            Me.spreadsheetCommandBarButtonItem11.Id = 11
            Me.spreadsheetCommandBarButtonItem11.Name = "spreadsheetCommandBarButtonItem11"
            ' 
            ' spreadsheetCommandBarButtonItem12
            ' 
            Me.spreadsheetCommandBarButtonItem12.CommandName = "PasteSelection"
            Me.spreadsheetCommandBarButtonItem12.Id = 22
            Me.spreadsheetCommandBarButtonItem12.Name = "spreadsheetCommandBarButtonItem12"
            Me.spreadsheetCommandBarButtonItem12.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large
            ' 
            ' spreadsheetCommandBarButtonItem13
            ' 
            Me.spreadsheetCommandBarButtonItem13.CommandName = "CutSelection"
            Me.spreadsheetCommandBarButtonItem13.Id = 23
            Me.spreadsheetCommandBarButtonItem13.Name = "spreadsheetCommandBarButtonItem13"
            Me.spreadsheetCommandBarButtonItem13.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText
            ' 
            ' spreadsheetCommandBarButtonItem14
            ' 
            Me.spreadsheetCommandBarButtonItem14.CommandName = "CopySelection"
            Me.spreadsheetCommandBarButtonItem14.Id = 24
            Me.spreadsheetCommandBarButtonItem14.Name = "spreadsheetCommandBarButtonItem14"
            Me.spreadsheetCommandBarButtonItem14.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText
            ' 
            ' spreadsheetCommandBarButtonItem15
            ' 
            Me.spreadsheetCommandBarButtonItem15.CommandName = "ShowPasteSpecialForm"
            Me.spreadsheetCommandBarButtonItem15.Id = 25
            Me.spreadsheetCommandBarButtonItem15.Name = "spreadsheetCommandBarButtonItem15"
            Me.spreadsheetCommandBarButtonItem15.RibbonStyle = (CType((DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText Or DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText), DevExpress.XtraBars.Ribbon.RibbonItemStyles))
            ' 
            ' barButtonGroup1
            ' 
            Me.barButtonGroup1.Id = 12
            Me.barButtonGroup1.ItemLinks.Add(Me.changeFontNameItem1)
            Me.barButtonGroup1.ItemLinks.Add(Me.changeFontSizeItem1)
            Me.barButtonGroup1.ItemLinks.Add(Me.spreadsheetCommandBarButtonItem16)
            Me.barButtonGroup1.ItemLinks.Add(Me.spreadsheetCommandBarButtonItem17)
            Me.barButtonGroup1.Name = "barButtonGroup1"
            Me.barButtonGroup1.Tag = "{B0CA3FA8-82D6-4BC4-BD31-D9AE56C1D033}"
            ' 
            ' changeFontNameItem1
            ' 
            Me.changeFontNameItem1.Edit = Me.repositoryItemFontEdit1
            Me.changeFontNameItem1.Id = 26
            Me.changeFontNameItem1.Name = "changeFontNameItem1"
            ' 
            ' repositoryItemFontEdit1
            ' 
            Me.repositoryItemFontEdit1.AutoHeight = False
            Me.repositoryItemFontEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.repositoryItemFontEdit1.Name = "repositoryItemFontEdit1"
            ' 
            ' changeFontSizeItem1
            ' 
            Me.changeFontSizeItem1.Edit = Me.repositoryItemSpreadsheetFontSizeEdit1
            Me.changeFontSizeItem1.Id = 27
            Me.changeFontSizeItem1.Name = "changeFontSizeItem1"
            ' 
            ' repositoryItemSpreadsheetFontSizeEdit1
            ' 
            Me.repositoryItemSpreadsheetFontSizeEdit1.AutoHeight = False
            Me.repositoryItemSpreadsheetFontSizeEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.repositoryItemSpreadsheetFontSizeEdit1.Control = Me.spreadsheetControl1
            Me.repositoryItemSpreadsheetFontSizeEdit1.Name = "repositoryItemSpreadsheetFontSizeEdit1"
            ' 
            ' spreadsheetControl1
            ' 
            Me.spreadsheetControl1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.spreadsheetControl1.Location = New System.Drawing.Point(0, 178)
            Me.spreadsheetControl1.MenuManager = Me.ribbonControl1
            Me.spreadsheetControl1.Name = "spreadsheetControl1"
            Me.spreadsheetControl1.Size = New System.Drawing.Size(784, 383)
            Me.spreadsheetControl1.TabIndex = 0
            Me.spreadsheetControl1.Text = "spreadsheetControl1"
            ' 
            ' spreadsheetCommandBarButtonItem16
            ' 
            Me.spreadsheetCommandBarButtonItem16.ButtonGroupTag = "{B0CA3FA8-82D6-4BC4-BD31-D9AE56C1D033}"
            Me.spreadsheetCommandBarButtonItem16.CommandName = "FormatIncreaseFontSize"
            Me.spreadsheetCommandBarButtonItem16.Id = 28
            Me.spreadsheetCommandBarButtonItem16.Name = "spreadsheetCommandBarButtonItem16"
            Me.spreadsheetCommandBarButtonItem16.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText
            ' 
            ' spreadsheetCommandBarButtonItem17
            ' 
            Me.spreadsheetCommandBarButtonItem17.ButtonGroupTag = "{B0CA3FA8-82D6-4BC4-BD31-D9AE56C1D033}"
            Me.spreadsheetCommandBarButtonItem17.CommandName = "FormatDecreaseFontSize"
            Me.spreadsheetCommandBarButtonItem17.Id = 29
            Me.spreadsheetCommandBarButtonItem17.Name = "spreadsheetCommandBarButtonItem17"
            Me.spreadsheetCommandBarButtonItem17.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText
            ' 
            ' barButtonGroup2
            ' 
            Me.barButtonGroup2.Id = 13
            Me.barButtonGroup2.ItemLinks.Add(Me.spreadsheetCommandBarCheckItem1)
            Me.barButtonGroup2.ItemLinks.Add(Me.spreadsheetCommandBarCheckItem2)
            Me.barButtonGroup2.ItemLinks.Add(Me.spreadsheetCommandBarCheckItem3)
            Me.barButtonGroup2.ItemLinks.Add(Me.spreadsheetCommandBarCheckItem4)
            Me.barButtonGroup2.Name = "barButtonGroup2"
            Me.barButtonGroup2.Tag = "{56C139FB-52E5-405B-A03F-FA7DCABD1D17}"
            ' 
            ' spreadsheetCommandBarCheckItem1
            ' 
            Me.spreadsheetCommandBarCheckItem1.ButtonGroupTag = "{56C139FB-52E5-405B-A03F-FA7DCABD1D17}"
            Me.spreadsheetCommandBarCheckItem1.CommandName = "FormatFontBold"
            Me.spreadsheetCommandBarCheckItem1.Id = 30
            Me.spreadsheetCommandBarCheckItem1.Name = "spreadsheetCommandBarCheckItem1"
            Me.spreadsheetCommandBarCheckItem1.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText
            ' 
            ' spreadsheetCommandBarCheckItem2
            ' 
            Me.spreadsheetCommandBarCheckItem2.ButtonGroupTag = "{56C139FB-52E5-405B-A03F-FA7DCABD1D17}"
            Me.spreadsheetCommandBarCheckItem2.CommandName = "FormatFontItalic"
            Me.spreadsheetCommandBarCheckItem2.Id = 31
            Me.spreadsheetCommandBarCheckItem2.Name = "spreadsheetCommandBarCheckItem2"
            Me.spreadsheetCommandBarCheckItem2.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText
            ' 
            ' spreadsheetCommandBarCheckItem3
            ' 
            Me.spreadsheetCommandBarCheckItem3.ButtonGroupTag = "{56C139FB-52E5-405B-A03F-FA7DCABD1D17}"
            Me.spreadsheetCommandBarCheckItem3.CommandName = "FormatFontUnderline"
            Me.spreadsheetCommandBarCheckItem3.Id = 32
            Me.spreadsheetCommandBarCheckItem3.Name = "spreadsheetCommandBarCheckItem3"
            Me.spreadsheetCommandBarCheckItem3.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText
            ' 
            ' spreadsheetCommandBarCheckItem4
            ' 
            Me.spreadsheetCommandBarCheckItem4.ButtonGroupTag = "{56C139FB-52E5-405B-A03F-FA7DCABD1D17}"
            Me.spreadsheetCommandBarCheckItem4.CommandName = "FormatFontStrikeout"
            Me.spreadsheetCommandBarCheckItem4.Id = 33
            Me.spreadsheetCommandBarCheckItem4.Name = "spreadsheetCommandBarCheckItem4"
            Me.spreadsheetCommandBarCheckItem4.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText
            ' 
            ' barButtonGroup3
            ' 
            Me.barButtonGroup3.Id = 14
            Me.barButtonGroup3.ItemLinks.Add(Me.spreadsheetCommandBarSubItem1)
            Me.barButtonGroup3.Name = "barButtonGroup3"
            Me.barButtonGroup3.Tag = "{DDB05A32-9207-4556-85CB-FE3403A197C7}"
            ' 
            ' spreadsheetCommandBarSubItem1
            ' 
            Me.spreadsheetCommandBarSubItem1.ButtonGroupTag = "{DDB05A32-9207-4556-85CB-FE3403A197C7}"
            Me.spreadsheetCommandBarSubItem1.CommandName = "FormatBordersCommandGroup"
            Me.spreadsheetCommandBarSubItem1.Id = 34
            Me.spreadsheetCommandBarSubItem1.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() { _
                New DevExpress.XtraBars.LinkPersistInfo(Me.spreadsheetCommandBarButtonItem18), _
                New DevExpress.XtraBars.LinkPersistInfo(Me.spreadsheetCommandBarButtonItem19), _
                New DevExpress.XtraBars.LinkPersistInfo(Me.spreadsheetCommandBarButtonItem20), _
                New DevExpress.XtraBars.LinkPersistInfo(Me.spreadsheetCommandBarButtonItem21), _
                New DevExpress.XtraBars.LinkPersistInfo(Me.spreadsheetCommandBarButtonItem22), _
                New DevExpress.XtraBars.LinkPersistInfo(Me.spreadsheetCommandBarButtonItem23), _
                New DevExpress.XtraBars.LinkPersistInfo(Me.spreadsheetCommandBarButtonItem24), _
                New DevExpress.XtraBars.LinkPersistInfo(Me.spreadsheetCommandBarButtonItem25), _
                New DevExpress.XtraBars.LinkPersistInfo(Me.spreadsheetCommandBarButtonItem26), _
                New DevExpress.XtraBars.LinkPersistInfo(Me.spreadsheetCommandBarButtonItem27), _
                New DevExpress.XtraBars.LinkPersistInfo(Me.spreadsheetCommandBarButtonItem28), _
                New DevExpress.XtraBars.LinkPersistInfo(Me.spreadsheetCommandBarButtonItem29), _
                New DevExpress.XtraBars.LinkPersistInfo(Me.spreadsheetCommandBarButtonItem30), _
                New DevExpress.XtraBars.LinkPersistInfo(Me.changeBorderLineColorItem1), _
                New DevExpress.XtraBars.LinkPersistInfo(Me.changeBorderLineStyleItem1) _
            })
            Me.spreadsheetCommandBarSubItem1.Name = "spreadsheetCommandBarSubItem1"
            Me.spreadsheetCommandBarSubItem1.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText
            ' 
            ' spreadsheetCommandBarButtonItem18
            ' 
            Me.spreadsheetCommandBarButtonItem18.CommandName = "FormatBottomBorder"
            Me.spreadsheetCommandBarButtonItem18.Id = 35
            Me.spreadsheetCommandBarButtonItem18.Name = "spreadsheetCommandBarButtonItem18"
            ' 
            ' spreadsheetCommandBarButtonItem19
            ' 
            Me.spreadsheetCommandBarButtonItem19.CommandName = "FormatTopBorder"
            Me.spreadsheetCommandBarButtonItem19.Id = 36
            Me.spreadsheetCommandBarButtonItem19.Name = "spreadsheetCommandBarButtonItem19"
            ' 
            ' spreadsheetCommandBarButtonItem20
            ' 
            Me.spreadsheetCommandBarButtonItem20.CommandName = "FormatLeftBorder"
            Me.spreadsheetCommandBarButtonItem20.Id = 37
            Me.spreadsheetCommandBarButtonItem20.Name = "spreadsheetCommandBarButtonItem20"
            ' 
            ' spreadsheetCommandBarButtonItem21
            ' 
            Me.spreadsheetCommandBarButtonItem21.CommandName = "FormatRightBorder"
            Me.spreadsheetCommandBarButtonItem21.Id = 38
            Me.spreadsheetCommandBarButtonItem21.Name = "spreadsheetCommandBarButtonItem21"
            ' 
            ' spreadsheetCommandBarButtonItem22
            ' 
            Me.spreadsheetCommandBarButtonItem22.CommandName = "FormatNoBorders"
            Me.spreadsheetCommandBarButtonItem22.Id = 39
            Me.spreadsheetCommandBarButtonItem22.Name = "spreadsheetCommandBarButtonItem22"
            ' 
            ' spreadsheetCommandBarButtonItem23
            ' 
            Me.spreadsheetCommandBarButtonItem23.CommandName = "FormatAllBorders"
            Me.spreadsheetCommandBarButtonItem23.Id = 40
            Me.spreadsheetCommandBarButtonItem23.Name = "spreadsheetCommandBarButtonItem23"
            ' 
            ' spreadsheetCommandBarButtonItem24
            ' 
            Me.spreadsheetCommandBarButtonItem24.CommandName = "FormatOutsideBorders"
            Me.spreadsheetCommandBarButtonItem24.Id = 41
            Me.spreadsheetCommandBarButtonItem24.Name = "spreadsheetCommandBarButtonItem24"
            ' 
            ' spreadsheetCommandBarButtonItem25
            ' 
            Me.spreadsheetCommandBarButtonItem25.CommandName = "FormatThickBorder"
            Me.spreadsheetCommandBarButtonItem25.Id = 42
            Me.spreadsheetCommandBarButtonItem25.Name = "spreadsheetCommandBarButtonItem25"
            ' 
            ' spreadsheetCommandBarButtonItem26
            ' 
            Me.spreadsheetCommandBarButtonItem26.CommandName = "FormatBottomDoubleBorder"
            Me.spreadsheetCommandBarButtonItem26.Id = 43
            Me.spreadsheetCommandBarButtonItem26.Name = "spreadsheetCommandBarButtonItem26"
            ' 
            ' spreadsheetCommandBarButtonItem27
            ' 
            Me.spreadsheetCommandBarButtonItem27.CommandName = "FormatBottomThickBorder"
            Me.spreadsheetCommandBarButtonItem27.Id = 44
            Me.spreadsheetCommandBarButtonItem27.Name = "spreadsheetCommandBarButtonItem27"
            ' 
            ' spreadsheetCommandBarButtonItem28
            ' 
            Me.spreadsheetCommandBarButtonItem28.CommandName = "FormatTopAndBottomBorder"
            Me.spreadsheetCommandBarButtonItem28.Id = 45
            Me.spreadsheetCommandBarButtonItem28.Name = "spreadsheetCommandBarButtonItem28"
            ' 
            ' spreadsheetCommandBarButtonItem29
            ' 
            Me.spreadsheetCommandBarButtonItem29.CommandName = "FormatTopAndThickBottomBorder"
            Me.spreadsheetCommandBarButtonItem29.Id = 46
            Me.spreadsheetCommandBarButtonItem29.Name = "spreadsheetCommandBarButtonItem29"
            ' 
            ' spreadsheetCommandBarButtonItem30
            ' 
            Me.spreadsheetCommandBarButtonItem30.CommandName = "FormatTopAndDoubleBottomBorder"
            Me.spreadsheetCommandBarButtonItem30.Id = 47
            Me.spreadsheetCommandBarButtonItem30.Name = "spreadsheetCommandBarButtonItem30"
            ' 
            ' changeBorderLineColorItem1
            ' 
            Me.changeBorderLineColorItem1.ActAsDropDown = True
            Me.changeBorderLineColorItem1.Id = 48
            Me.changeBorderLineColorItem1.Name = "changeBorderLineColorItem1"
            ' 
            ' changeBorderLineStyleItem1
            ' 
            Me.changeBorderLineStyleItem1.DropDownControl = Me.commandBarGalleryDropDown1
            Me.changeBorderLineStyleItem1.Id = 49
            Me.changeBorderLineStyleItem1.Name = "changeBorderLineStyleItem1"
            ' 
            ' commandBarGalleryDropDown1
            ' 
            ' 
            ' 
            ' 
            Me.commandBarGalleryDropDown1.Gallery.AllowFilter = False
            Me.commandBarGalleryDropDown1.Gallery.ColumnCount = 1
            Me.commandBarGalleryDropDown1.Gallery.DrawImageBackground = False
            Me.commandBarGalleryDropDown1.Gallery.ImageSize = New System.Drawing.Size(65, 46)
            Me.commandBarGalleryDropDown1.Gallery.ItemAutoSizeMode = DevExpress.XtraBars.Ribbon.Gallery.GalleryItemAutoSizeMode.None
            Me.commandBarGalleryDropDown1.Gallery.ItemSize = New System.Drawing.Size(136, 26)
            Me.commandBarGalleryDropDown1.Gallery.RowCount = 14
            Me.commandBarGalleryDropDown1.Gallery.ShowGroupCaption = False
            Me.commandBarGalleryDropDown1.Gallery.ShowItemText = True
            Me.commandBarGalleryDropDown1.Gallery.ShowScrollBar = DevExpress.XtraBars.Ribbon.Gallery.ShowScrollBar.Auto
            Me.commandBarGalleryDropDown1.Name = "commandBarGalleryDropDown1"
            Me.commandBarGalleryDropDown1.Ribbon = Me.ribbonControl1
            ' 
            ' barButtonGroup4
            ' 
            Me.barButtonGroup4.Id = 15
            Me.barButtonGroup4.ItemLinks.Add(Me.changeCellFillColorItem1)
            Me.barButtonGroup4.ItemLinks.Add(Me.changeFontColorItem1)
            Me.barButtonGroup4.Name = "barButtonGroup4"
            Me.barButtonGroup4.Tag = "{C2275623-04A3-41E8-8D6A-EB5C7F8541D1}"
            ' 
            ' changeCellFillColorItem1
            ' 
            Me.changeCellFillColorItem1.Id = 50
            Me.changeCellFillColorItem1.Name = "changeCellFillColorItem1"
            ' 
            ' changeFontColorItem1
            ' 
            Me.changeFontColorItem1.Id = 51
            Me.changeFontColorItem1.Name = "changeFontColorItem1"
            ' 
            ' barButtonGroup5
            ' 
            Me.barButtonGroup5.Id = 16
            Me.barButtonGroup5.ItemLinks.Add(Me.spreadsheetCommandBarCheckItem5)
            Me.barButtonGroup5.ItemLinks.Add(Me.spreadsheetCommandBarCheckItem6)
            Me.barButtonGroup5.ItemLinks.Add(Me.spreadsheetCommandBarCheckItem7)
            Me.barButtonGroup5.Name = "barButtonGroup5"
            Me.barButtonGroup5.Tag = "{03A0322B-12A2-4434-A487-8B5AAF64CCFC}"
            ' 
            ' spreadsheetCommandBarCheckItem5
            ' 
            Me.spreadsheetCommandBarCheckItem5.ButtonGroupTag = "{03A0322B-12A2-4434-A487-8B5AAF64CCFC}"
            Me.spreadsheetCommandBarCheckItem5.CommandName = "FormatAlignmentTop"
            Me.spreadsheetCommandBarCheckItem5.Id = 52
            Me.spreadsheetCommandBarCheckItem5.Name = "spreadsheetCommandBarCheckItem5"
            Me.spreadsheetCommandBarCheckItem5.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText
            ' 
            ' spreadsheetCommandBarCheckItem6
            ' 
            Me.spreadsheetCommandBarCheckItem6.ButtonGroupTag = "{03A0322B-12A2-4434-A487-8B5AAF64CCFC}"
            Me.spreadsheetCommandBarCheckItem6.CommandName = "FormatAlignmentMiddle"
            Me.spreadsheetCommandBarCheckItem6.Id = 53
            Me.spreadsheetCommandBarCheckItem6.Name = "spreadsheetCommandBarCheckItem6"
            Me.spreadsheetCommandBarCheckItem6.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText
            ' 
            ' spreadsheetCommandBarCheckItem7
            ' 
            Me.spreadsheetCommandBarCheckItem7.ButtonGroupTag = "{03A0322B-12A2-4434-A487-8B5AAF64CCFC}"
            Me.spreadsheetCommandBarCheckItem7.CommandName = "FormatAlignmentBottom"
            Me.spreadsheetCommandBarCheckItem7.Id = 54
            Me.spreadsheetCommandBarCheckItem7.Name = "spreadsheetCommandBarCheckItem7"
            Me.spreadsheetCommandBarCheckItem7.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText
            ' 
            ' barButtonGroup6
            ' 
            Me.barButtonGroup6.Id = 17
            Me.barButtonGroup6.ItemLinks.Add(Me.spreadsheetCommandBarCheckItem8)
            Me.barButtonGroup6.ItemLinks.Add(Me.spreadsheetCommandBarCheckItem9)
            Me.barButtonGroup6.ItemLinks.Add(Me.spreadsheetCommandBarCheckItem10)
            Me.barButtonGroup6.Name = "barButtonGroup6"
            Me.barButtonGroup6.Tag = "{ECC693B7-EF59-4007-A0DB-A9550214A0F2}"
            ' 
            ' spreadsheetCommandBarCheckItem8
            ' 
            Me.spreadsheetCommandBarCheckItem8.ButtonGroupTag = "{ECC693B7-EF59-4007-A0DB-A9550214A0F2}"
            Me.spreadsheetCommandBarCheckItem8.CommandName = "FormatAlignmentLeft"
            Me.spreadsheetCommandBarCheckItem8.Id = 55
            Me.spreadsheetCommandBarCheckItem8.Name = "spreadsheetCommandBarCheckItem8"
            Me.spreadsheetCommandBarCheckItem8.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText
            ' 
            ' spreadsheetCommandBarCheckItem9
            ' 
            Me.spreadsheetCommandBarCheckItem9.ButtonGroupTag = "{ECC693B7-EF59-4007-A0DB-A9550214A0F2}"
            Me.spreadsheetCommandBarCheckItem9.CommandName = "FormatAlignmentCenter"
            Me.spreadsheetCommandBarCheckItem9.Id = 56
            Me.spreadsheetCommandBarCheckItem9.Name = "spreadsheetCommandBarCheckItem9"
            Me.spreadsheetCommandBarCheckItem9.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText
            ' 
            ' spreadsheetCommandBarCheckItem10
            ' 
            Me.spreadsheetCommandBarCheckItem10.ButtonGroupTag = "{ECC693B7-EF59-4007-A0DB-A9550214A0F2}"
            Me.spreadsheetCommandBarCheckItem10.CommandName = "FormatAlignmentRight"
            Me.spreadsheetCommandBarCheckItem10.Id = 57
            Me.spreadsheetCommandBarCheckItem10.Name = "spreadsheetCommandBarCheckItem10"
            Me.spreadsheetCommandBarCheckItem10.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText
            ' 
            ' barButtonGroup7
            ' 
            Me.barButtonGroup7.Id = 18
            Me.barButtonGroup7.ItemLinks.Add(Me.spreadsheetCommandBarButtonItem31)
            Me.barButtonGroup7.ItemLinks.Add(Me.spreadsheetCommandBarButtonItem32)
            Me.barButtonGroup7.Name = "barButtonGroup7"
            Me.barButtonGroup7.Tag = "{A5E37DED-106E-44FC-8044-CE3824C08225}"
            ' 
            ' spreadsheetCommandBarButtonItem31
            ' 
            Me.spreadsheetCommandBarButtonItem31.ButtonGroupTag = "{A5E37DED-106E-44FC-8044-CE3824C08225}"
            Me.spreadsheetCommandBarButtonItem31.CommandName = "FormatDecreaseIndent"
            Me.spreadsheetCommandBarButtonItem31.Id = 58
            Me.spreadsheetCommandBarButtonItem31.Name = "spreadsheetCommandBarButtonItem31"
            Me.spreadsheetCommandBarButtonItem31.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText
            ' 
            ' spreadsheetCommandBarButtonItem32
            ' 
            Me.spreadsheetCommandBarButtonItem32.ButtonGroupTag = "{A5E37DED-106E-44FC-8044-CE3824C08225}"
            Me.spreadsheetCommandBarButtonItem32.CommandName = "FormatIncreaseIndent"
            Me.spreadsheetCommandBarButtonItem32.Id = 59
            Me.spreadsheetCommandBarButtonItem32.Name = "spreadsheetCommandBarButtonItem32"
            Me.spreadsheetCommandBarButtonItem32.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText
            ' 
            ' spreadsheetCommandBarCheckItem11
            ' 
            Me.spreadsheetCommandBarCheckItem11.CommandName = "FormatWrapText"
            Me.spreadsheetCommandBarCheckItem11.Id = 60
            Me.spreadsheetCommandBarCheckItem11.Name = "spreadsheetCommandBarCheckItem11"
            Me.spreadsheetCommandBarCheckItem11.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText
            ' 
            ' spreadsheetCommandBarSubItem2
            ' 
            Me.spreadsheetCommandBarSubItem2.CommandName = "EditingMergeCellsCommandGroup"
            Me.spreadsheetCommandBarSubItem2.Id = 61
            Me.spreadsheetCommandBarSubItem2.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() { _
                New DevExpress.XtraBars.LinkPersistInfo(Me.spreadsheetCommandBarCheckItem12), _
                New DevExpress.XtraBars.LinkPersistInfo(Me.spreadsheetCommandBarButtonItem33), _
                New DevExpress.XtraBars.LinkPersistInfo(Me.spreadsheetCommandBarButtonItem34), _
                New DevExpress.XtraBars.LinkPersistInfo(Me.spreadsheetCommandBarButtonItem35) _
            })
            Me.spreadsheetCommandBarSubItem2.Name = "spreadsheetCommandBarSubItem2"
            Me.spreadsheetCommandBarSubItem2.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText
            ' 
            ' spreadsheetCommandBarCheckItem12
            ' 
            Me.spreadsheetCommandBarCheckItem12.CommandName = "EditingMergeAndCenterCells"
            Me.spreadsheetCommandBarCheckItem12.Id = 62
            Me.spreadsheetCommandBarCheckItem12.Name = "spreadsheetCommandBarCheckItem12"
            ' 
            ' spreadsheetCommandBarButtonItem33
            ' 
            Me.spreadsheetCommandBarButtonItem33.CommandName = "EditingMergeCellsAcross"
            Me.spreadsheetCommandBarButtonItem33.Id = 63
            Me.spreadsheetCommandBarButtonItem33.Name = "spreadsheetCommandBarButtonItem33"
            ' 
            ' spreadsheetCommandBarButtonItem34
            ' 
            Me.spreadsheetCommandBarButtonItem34.CommandName = "EditingMergeCells"
            Me.spreadsheetCommandBarButtonItem34.Id = 64
            Me.spreadsheetCommandBarButtonItem34.Name = "spreadsheetCommandBarButtonItem34"
            ' 
            ' spreadsheetCommandBarButtonItem35
            ' 
            Me.spreadsheetCommandBarButtonItem35.CommandName = "EditingUnmergeCells"
            Me.spreadsheetCommandBarButtonItem35.Id = 65
            Me.spreadsheetCommandBarButtonItem35.Name = "spreadsheetCommandBarButtonItem35"
            ' 
            ' barButtonGroup8
            ' 
            Me.barButtonGroup8.Id = 19
            Me.barButtonGroup8.ItemLinks.Add(Me.changeNumberFormatItem1)
            Me.barButtonGroup8.Name = "barButtonGroup8"
            Me.barButtonGroup8.Tag = "{0B3A7A43-3079-4ce0-83A8-3789F5F6DC9F}"
            ' 
            ' changeNumberFormatItem1
            ' 
            Me.changeNumberFormatItem1.Edit = Me.repositoryItemPopupGalleryEdit1
            Me.changeNumberFormatItem1.Id = 66
            Me.changeNumberFormatItem1.Name = "changeNumberFormatItem1"
            ' 
            ' repositoryItemPopupGalleryEdit1
            ' 
            Me.repositoryItemPopupGalleryEdit1.AutoHeight = False
            Me.repositoryItemPopupGalleryEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            ' 
            ' 
            ' 
            Me.repositoryItemPopupGalleryEdit1.Gallery.AllowFilter = False
            Me.repositoryItemPopupGalleryEdit1.Gallery.AutoFitColumns = False
            Me.repositoryItemPopupGalleryEdit1.Gallery.ColumnCount = 1
            Me.repositoryItemPopupGalleryEdit1.Gallery.FixedImageSize = False
            spreadsheetCommandGalleryItem68.AlwaysUpdateDescription = True
            spreadsheetCommandGalleryItem68.CaptionAsValue = True
            spreadsheetCommandGalleryItem68.CommandName = "FormatNumberGeneral"
            spreadsheetCommandGalleryItem68.IsEmptyHint = True
            spreadsheetCommandGalleryItem69.AlwaysUpdateDescription = True
            spreadsheetCommandGalleryItem69.CaptionAsValue = True
            spreadsheetCommandGalleryItem69.CommandName = "FormatNumberDecimal"
            spreadsheetCommandGalleryItem69.IsEmptyHint = True
            spreadsheetCommandGalleryItem70.AlwaysUpdateDescription = True
            spreadsheetCommandGalleryItem70.CaptionAsValue = True
            spreadsheetCommandGalleryItem70.CommandName = "FormatNumberAccountingCurrency"
            spreadsheetCommandGalleryItem70.IsEmptyHint = True
            spreadsheetCommandGalleryItem71.AlwaysUpdateDescription = True
            spreadsheetCommandGalleryItem71.CaptionAsValue = True
            spreadsheetCommandGalleryItem71.CommandName = "FormatNumberAccountingRegular"
            spreadsheetCommandGalleryItem71.IsEmptyHint = True
            spreadsheetCommandGalleryItem72.AlwaysUpdateDescription = True
            spreadsheetCommandGalleryItem72.CaptionAsValue = True
            spreadsheetCommandGalleryItem72.CommandName = "FormatNumberShortDate"
            spreadsheetCommandGalleryItem72.IsEmptyHint = True
            spreadsheetCommandGalleryItem73.AlwaysUpdateDescription = True
            spreadsheetCommandGalleryItem73.CaptionAsValue = True
            spreadsheetCommandGalleryItem73.CommandName = "FormatNumberLongDate"
            spreadsheetCommandGalleryItem73.IsEmptyHint = True
            spreadsheetCommandGalleryItem74.AlwaysUpdateDescription = True
            spreadsheetCommandGalleryItem74.CaptionAsValue = True
            spreadsheetCommandGalleryItem74.CommandName = "FormatNumberTime"
            spreadsheetCommandGalleryItem74.IsEmptyHint = True
            spreadsheetCommandGalleryItem75.AlwaysUpdateDescription = True
            spreadsheetCommandGalleryItem75.CaptionAsValue = True
            spreadsheetCommandGalleryItem75.CommandName = "FormatNumberPercentage"
            spreadsheetCommandGalleryItem75.IsEmptyHint = True
            spreadsheetCommandGalleryItem76.AlwaysUpdateDescription = True
            spreadsheetCommandGalleryItem76.CaptionAsValue = True
            spreadsheetCommandGalleryItem76.CommandName = "FormatNumberFraction"
            spreadsheetCommandGalleryItem76.IsEmptyHint = True
            spreadsheetCommandGalleryItem77.AlwaysUpdateDescription = True
            spreadsheetCommandGalleryItem77.CaptionAsValue = True
            spreadsheetCommandGalleryItem77.CommandName = "FormatNumberScientific"
            spreadsheetCommandGalleryItem77.IsEmptyHint = True
            spreadsheetCommandGalleryItem78.AlwaysUpdateDescription = True
            spreadsheetCommandGalleryItem78.CaptionAsValue = True
            spreadsheetCommandGalleryItem78.CommandName = "FormatNumberText"
            spreadsheetCommandGalleryItem78.IsEmptyHint = True
            galleryItemGroup2.Items.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItem() { spreadsheetCommandGalleryItem68, spreadsheetCommandGalleryItem69, spreadsheetCommandGalleryItem70, spreadsheetCommandGalleryItem71, spreadsheetCommandGalleryItem72, spreadsheetCommandGalleryItem73, spreadsheetCommandGalleryItem74, spreadsheetCommandGalleryItem75, spreadsheetCommandGalleryItem76, spreadsheetCommandGalleryItem77, spreadsheetCommandGalleryItem78})
            Me.repositoryItemPopupGalleryEdit1.Gallery.Groups.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItemGroup() { galleryItemGroup2})
            Me.repositoryItemPopupGalleryEdit1.Gallery.ItemImageLayout = DevExpress.Utils.Drawing.ImageLayoutMode.MiddleLeft
            Me.repositoryItemPopupGalleryEdit1.Gallery.ItemImageLocation = DevExpress.Utils.Locations.Left
            Me.repositoryItemPopupGalleryEdit1.Gallery.RowCount = 11
            Me.repositoryItemPopupGalleryEdit1.Gallery.ShowGroupCaption = False
            Me.repositoryItemPopupGalleryEdit1.Gallery.ShowItemText = True
            Me.repositoryItemPopupGalleryEdit1.Gallery.ShowScrollBar = DevExpress.XtraBars.Ribbon.Gallery.ShowScrollBar.Hide
            Me.repositoryItemPopupGalleryEdit1.Gallery.StretchItems = True
            Me.repositoryItemPopupGalleryEdit1.Name = "repositoryItemPopupGalleryEdit1"
            Me.repositoryItemPopupGalleryEdit1.ShowButtons = False
            Me.repositoryItemPopupGalleryEdit1.ShowPopupCloseButton = False
            Me.repositoryItemPopupGalleryEdit1.ShowSizeGrip = False
            ' 
            ' barButtonGroup9
            ' 
            Me.barButtonGroup9.Id = 20
            Me.barButtonGroup9.ItemLinks.Add(Me.spreadsheetCommandBarSubItem3)
            Me.barButtonGroup9.ItemLinks.Add(Me.spreadsheetCommandBarButtonItem41)
            Me.barButtonGroup9.ItemLinks.Add(Me.spreadsheetCommandBarButtonItem42)
            Me.barButtonGroup9.Name = "barButtonGroup9"
            Me.barButtonGroup9.Tag = "{508C2CE6-E1C8-4DD1-BA50-6C210FDB31B0}"
            ' 
            ' spreadsheetCommandBarSubItem3
            ' 
            Me.spreadsheetCommandBarSubItem3.ButtonGroupTag = "{508C2CE6-E1C8-4DD1-BA50-6C210FDB31B0}"
            Me.spreadsheetCommandBarSubItem3.CommandName = "FormatNumberAccountingCommandGroup"
            Me.spreadsheetCommandBarSubItem3.Id = 67
            Me.spreadsheetCommandBarSubItem3.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() { _
                New DevExpress.XtraBars.LinkPersistInfo(Me.spreadsheetCommandBarButtonItem36), _
                New DevExpress.XtraBars.LinkPersistInfo(Me.spreadsheetCommandBarButtonItem37), _
                New DevExpress.XtraBars.LinkPersistInfo(Me.spreadsheetCommandBarButtonItem38), _
                New DevExpress.XtraBars.LinkPersistInfo(Me.spreadsheetCommandBarButtonItem39), _
                New DevExpress.XtraBars.LinkPersistInfo(Me.spreadsheetCommandBarButtonItem40) _
            })
            Me.spreadsheetCommandBarSubItem3.Name = "spreadsheetCommandBarSubItem3"
            Me.spreadsheetCommandBarSubItem3.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText
            ' 
            ' spreadsheetCommandBarButtonItem36
            ' 
            Me.spreadsheetCommandBarButtonItem36.CommandName = "FormatNumberAccountingUS"
            Me.spreadsheetCommandBarButtonItem36.Id = 68
            Me.spreadsheetCommandBarButtonItem36.Name = "spreadsheetCommandBarButtonItem36"
            ' 
            ' spreadsheetCommandBarButtonItem37
            ' 
            Me.spreadsheetCommandBarButtonItem37.CommandName = "FormatNumberAccountingUK"
            Me.spreadsheetCommandBarButtonItem37.Id = 69
            Me.spreadsheetCommandBarButtonItem37.Name = "spreadsheetCommandBarButtonItem37"
            ' 
            ' spreadsheetCommandBarButtonItem38
            ' 
            Me.spreadsheetCommandBarButtonItem38.CommandName = "FormatNumberAccountingEuro"
            Me.spreadsheetCommandBarButtonItem38.Id = 70
            Me.spreadsheetCommandBarButtonItem38.Name = "spreadsheetCommandBarButtonItem38"
            ' 
            ' spreadsheetCommandBarButtonItem39
            ' 
            Me.spreadsheetCommandBarButtonItem39.CommandName = "FormatNumberAccountingPRC"
            Me.spreadsheetCommandBarButtonItem39.Id = 71
            Me.spreadsheetCommandBarButtonItem39.Name = "spreadsheetCommandBarButtonItem39"
            ' 
            ' spreadsheetCommandBarButtonItem40
            ' 
            Me.spreadsheetCommandBarButtonItem40.CommandName = "FormatNumberAccountingSwiss"
            Me.spreadsheetCommandBarButtonItem40.Id = 72
            Me.spreadsheetCommandBarButtonItem40.Name = "spreadsheetCommandBarButtonItem40"
            ' 
            ' spreadsheetCommandBarButtonItem41
            ' 
            Me.spreadsheetCommandBarButtonItem41.ButtonGroupTag = "{508C2CE6-E1C8-4DD1-BA50-6C210FDB31B0}"
            Me.spreadsheetCommandBarButtonItem41.CommandName = "FormatNumberPercent"
            Me.spreadsheetCommandBarButtonItem41.Id = 73
            Me.spreadsheetCommandBarButtonItem41.Name = "spreadsheetCommandBarButtonItem41"
            Me.spreadsheetCommandBarButtonItem41.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText
            ' 
            ' spreadsheetCommandBarButtonItem42
            ' 
            Me.spreadsheetCommandBarButtonItem42.ButtonGroupTag = "{508C2CE6-E1C8-4DD1-BA50-6C210FDB31B0}"
            Me.spreadsheetCommandBarButtonItem42.CommandName = "FormatNumberAccounting"
            Me.spreadsheetCommandBarButtonItem42.Id = 74
            Me.spreadsheetCommandBarButtonItem42.Name = "spreadsheetCommandBarButtonItem42"
            Me.spreadsheetCommandBarButtonItem42.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText
            ' 
            ' barButtonGroup10
            ' 
            Me.barButtonGroup10.Id = 21
            Me.barButtonGroup10.ItemLinks.Add(Me.spreadsheetCommandBarButtonItem43)
            Me.barButtonGroup10.ItemLinks.Add(Me.spreadsheetCommandBarButtonItem44)
            Me.barButtonGroup10.Name = "barButtonGroup10"
            Me.barButtonGroup10.Tag = "{BBAB348B-BDB2-487A-A883-EFB9982DC698}"
            ' 
            ' spreadsheetCommandBarButtonItem43
            ' 
            Me.spreadsheetCommandBarButtonItem43.ButtonGroupTag = "{BBAB348B-BDB2-487A-A883-EFB9982DC698}"
            Me.spreadsheetCommandBarButtonItem43.CommandName = "FormatNumberIncreaseDecimal"
            Me.spreadsheetCommandBarButtonItem43.Id = 75
            Me.spreadsheetCommandBarButtonItem43.Name = "spreadsheetCommandBarButtonItem43"
            Me.spreadsheetCommandBarButtonItem43.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText
            ' 
            ' spreadsheetCommandBarButtonItem44
            ' 
            Me.spreadsheetCommandBarButtonItem44.ButtonGroupTag = "{BBAB348B-BDB2-487A-A883-EFB9982DC698}"
            Me.spreadsheetCommandBarButtonItem44.CommandName = "FormatNumberDecreaseDecimal"
            Me.spreadsheetCommandBarButtonItem44.Id = 76
            Me.spreadsheetCommandBarButtonItem44.Name = "spreadsheetCommandBarButtonItem44"
            Me.spreadsheetCommandBarButtonItem44.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText
            ' 
            ' spreadsheetCommandBarButtonGalleryDropDownItem2
            ' 
            Me.spreadsheetCommandBarButtonGalleryDropDownItem2.CommandName = "ConditionalFormattingColorScalesCommandGroup"
            Me.spreadsheetCommandBarButtonGalleryDropDownItem2.DropDownControl = Me.commandBarGalleryDropDown3
            Me.spreadsheetCommandBarButtonGalleryDropDownItem2.Id = 94
            Me.spreadsheetCommandBarButtonGalleryDropDownItem2.Name = "spreadsheetCommandBarButtonGalleryDropDownItem2"
            Me.spreadsheetCommandBarButtonGalleryDropDownItem2.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large
            ' 
            ' commandBarGalleryDropDown3
            ' 
            ' 
            ' 
            ' 
            Me.commandBarGalleryDropDown3.Gallery.AllowFilter = False
            spreadsheetCommandGalleryItemGroup10.CommandName = "ConditionalFormattingColorScalesCommandGroup"
            spreadsheetCommandGalleryItem79.CommandName = "ConditionalFormattingColorScaleGreenYellowRed"
            spreadsheetCommandGalleryItem80.CommandName = "ConditionalFormattingColorScaleRedYellowGreen"
            spreadsheetCommandGalleryItem81.CommandName = "ConditionalFormattingColorScaleGreenWhiteRed"
            spreadsheetCommandGalleryItem82.CommandName = "ConditionalFormattingColorScaleRedWhiteGreen"
            spreadsheetCommandGalleryItem83.CommandName = "ConditionalFormattingColorScaleBlueWhiteRed"
            spreadsheetCommandGalleryItem84.CommandName = "ConditionalFormattingColorScaleRedWhiteBlue"
            spreadsheetCommandGalleryItem85.CommandName = "ConditionalFormattingColorScaleWhiteRed"
            spreadsheetCommandGalleryItem86.CommandName = "ConditionalFormattingColorScaleRedWhite"
            spreadsheetCommandGalleryItem87.CommandName = "ConditionalFormattingColorScaleGreenWhite"
            spreadsheetCommandGalleryItem88.CommandName = "ConditionalFormattingColorScaleWhiteGreen"
            spreadsheetCommandGalleryItem89.CommandName = "ConditionalFormattingColorScaleGreenYellow"
            spreadsheetCommandGalleryItem90.CommandName = "ConditionalFormattingColorScaleYellowGreen"
            spreadsheetCommandGalleryItemGroup10.Items.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItem() { spreadsheetCommandGalleryItem79, spreadsheetCommandGalleryItem80, spreadsheetCommandGalleryItem81, spreadsheetCommandGalleryItem82, spreadsheetCommandGalleryItem83, spreadsheetCommandGalleryItem84, spreadsheetCommandGalleryItem85, spreadsheetCommandGalleryItem86, spreadsheetCommandGalleryItem87, spreadsheetCommandGalleryItem88, spreadsheetCommandGalleryItem89, spreadsheetCommandGalleryItem90})
            Me.commandBarGalleryDropDown3.Gallery.Groups.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItemGroup() { spreadsheetCommandGalleryItemGroup10})
            Me.commandBarGalleryDropDown3.Gallery.ImageSize = New System.Drawing.Size(32, 32)
            Me.commandBarGalleryDropDown3.Gallery.ShowScrollBar = DevExpress.XtraBars.Ribbon.Gallery.ShowScrollBar.Auto
            Me.commandBarGalleryDropDown3.Name = "commandBarGalleryDropDown3"
            Me.commandBarGalleryDropDown3.Ribbon = Me.ribbonControl1
            ' 
            ' spreadsheetCommandBarButtonGalleryDropDownItem3
            ' 
            Me.spreadsheetCommandBarButtonGalleryDropDownItem3.CommandName = "ConditionalFormattingIconSetsCommandGroup"
            Me.spreadsheetCommandBarButtonGalleryDropDownItem3.DropDownControl = Me.commandBarGalleryDropDown4
            Me.spreadsheetCommandBarButtonGalleryDropDownItem3.Id = 95
            Me.spreadsheetCommandBarButtonGalleryDropDownItem3.Name = "spreadsheetCommandBarButtonGalleryDropDownItem3"
            Me.spreadsheetCommandBarButtonGalleryDropDownItem3.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large
            ' 
            ' commandBarGalleryDropDown4
            ' 
            ' 
            ' 
            ' 
            Me.commandBarGalleryDropDown4.Gallery.AllowFilter = False
            spreadsheetCommandGalleryItemGroup11.CommandName = "ConditionalFormattingIconSetsDirectionalCommandGroup"
            spreadsheetCommandGalleryItem91.CommandName = "ConditionalFormattingIconSetArrows3Colored"
            spreadsheetCommandGalleryItem92.CommandName = "ConditionalFormattingIconSetArrows3Grayed"
            spreadsheetCommandGalleryItem93.CommandName = "ConditionalFormattingIconSetArrows4Colored"
            spreadsheetCommandGalleryItem94.CommandName = "ConditionalFormattingIconSetArrows4Grayed"
            spreadsheetCommandGalleryItem95.CommandName = "ConditionalFormattingIconSetArrows5Colored"
            spreadsheetCommandGalleryItem96.CommandName = "ConditionalFormattingIconSetArrows5Grayed"
            spreadsheetCommandGalleryItem97.CommandName = "ConditionalFormattingIconSetTriangles3"
            spreadsheetCommandGalleryItemGroup11.Items.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItem() { spreadsheetCommandGalleryItem91, spreadsheetCommandGalleryItem92, spreadsheetCommandGalleryItem93, spreadsheetCommandGalleryItem94, spreadsheetCommandGalleryItem95, spreadsheetCommandGalleryItem96, spreadsheetCommandGalleryItem97})
            spreadsheetCommandGalleryItemGroup12.CommandName = "ConditionalFormattingIconSetsShapesCommandGroup"
            spreadsheetCommandGalleryItem98.CommandName = "ConditionalFormattingIconSetTrafficLights3"
            spreadsheetCommandGalleryItem99.CommandName = "ConditionalFormattingIconSetTrafficLights3Rimmed"
            spreadsheetCommandGalleryItem100.CommandName = "ConditionalFormattingIconSetTrafficLights4"
            spreadsheetCommandGalleryItem101.CommandName = "ConditionalFormattingIconSetSigns3"
            spreadsheetCommandGalleryItem102.CommandName = "ConditionalFormattingIconSetRedToBlack"
            spreadsheetCommandGalleryItemGroup12.Items.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItem() { spreadsheetCommandGalleryItem98, spreadsheetCommandGalleryItem99, spreadsheetCommandGalleryItem100, spreadsheetCommandGalleryItem101, spreadsheetCommandGalleryItem102})
            spreadsheetCommandGalleryItemGroup13.CommandName = "ConditionalFormattingIconSetsIndicatorsCommandGroup"
            spreadsheetCommandGalleryItem103.CommandName = "ConditionalFormattingIconSetSymbols3Circled"
            spreadsheetCommandGalleryItem104.CommandName = "ConditionalFormattingIconSetSymbols3"
            spreadsheetCommandGalleryItem105.CommandName = "ConditionalFormattingIconSetFlags3"
            spreadsheetCommandGalleryItemGroup13.Items.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItem() { spreadsheetCommandGalleryItem103, spreadsheetCommandGalleryItem104, spreadsheetCommandGalleryItem105})
            spreadsheetCommandGalleryItemGroup14.CommandName = "ConditionalFormattingIconSetsRatingsCommandGroup"
            spreadsheetCommandGalleryItem106.CommandName = "ConditionalFormattingIconSetStars3"
            spreadsheetCommandGalleryItem107.CommandName = "ConditionalFormattingIconSetRatings4"
            spreadsheetCommandGalleryItem108.CommandName = "ConditionalFormattingIconSetRatings5"
            spreadsheetCommandGalleryItem109.CommandName = "ConditionalFormattingIconSetQuarters5"
            spreadsheetCommandGalleryItem110.CommandName = "ConditionalFormattingIconSetBoxes5"
            spreadsheetCommandGalleryItemGroup14.Items.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItem() { spreadsheetCommandGalleryItem106, spreadsheetCommandGalleryItem107, spreadsheetCommandGalleryItem108, spreadsheetCommandGalleryItem109, spreadsheetCommandGalleryItem110})
            Me.commandBarGalleryDropDown4.Gallery.Groups.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItemGroup() { spreadsheetCommandGalleryItemGroup11, spreadsheetCommandGalleryItemGroup12, spreadsheetCommandGalleryItemGroup13, spreadsheetCommandGalleryItemGroup14})
            Me.commandBarGalleryDropDown4.Gallery.ImageSize = New System.Drawing.Size(32, 32)
            Me.commandBarGalleryDropDown4.Gallery.ShowScrollBar = DevExpress.XtraBars.Ribbon.Gallery.ShowScrollBar.Auto
            Me.commandBarGalleryDropDown4.Name = "commandBarGalleryDropDown4"
            Me.commandBarGalleryDropDown4.Ribbon = Me.ribbonControl1
            ' 
            ' spreadsheetCommandBarButtonItem58
            ' 
            Me.spreadsheetCommandBarButtonItem58.CommandName = "NewConditionalFormattingRule"
            Me.spreadsheetCommandBarButtonItem58.Id = 96
            Me.spreadsheetCommandBarButtonItem58.Name = "spreadsheetCommandBarButtonItem58"
            ' 
            ' spreadsheetCommandBarButtonItem59
            ' 
            Me.spreadsheetCommandBarButtonItem59.CommandName = "ConditionalFormattingRemoveFromSheet"
            Me.spreadsheetCommandBarButtonItem59.Id = 97
            Me.spreadsheetCommandBarButtonItem59.Name = "spreadsheetCommandBarButtonItem59"
            ' 
            ' spreadsheetCommandBarButtonItem60
            ' 
            Me.spreadsheetCommandBarButtonItem60.CommandName = "ConditionalFormattingRemove"
            Me.spreadsheetCommandBarButtonItem60.Id = 98
            Me.spreadsheetCommandBarButtonItem60.Name = "spreadsheetCommandBarButtonItem60"
            ' 
            ' spreadsheetCommandBarSubItem7
            ' 
            Me.spreadsheetCommandBarSubItem7.CommandName = "ConditionalFormattingRemoveCommandGroup"
            Me.spreadsheetCommandBarSubItem7.Id = 99
            Me.spreadsheetCommandBarSubItem7.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() { _
                New DevExpress.XtraBars.LinkPersistInfo(Me.spreadsheetCommandBarButtonItem59), _
                New DevExpress.XtraBars.LinkPersistInfo(Me.spreadsheetCommandBarButtonItem60) _
            })
            Me.spreadsheetCommandBarSubItem7.Name = "spreadsheetCommandBarSubItem7"
            ' 
            ' galleryFormatAsTableItem1
            ' 
            Me.galleryFormatAsTableItem1.DropDownControl = Me.commandBarGalleryDropDown5
            Me.galleryFormatAsTableItem1.Id = 100
            Me.galleryFormatAsTableItem1.Name = "galleryFormatAsTableItem1"
            ' 
            ' commandBarGalleryDropDown5
            ' 
            ' 
            ' 
            ' 
            Me.commandBarGalleryDropDown5.Gallery.AllowFilter = False
            Me.commandBarGalleryDropDown5.Gallery.ColumnCount = 7
            Me.commandBarGalleryDropDown5.Gallery.DrawImageBackground = False
            Me.commandBarGalleryDropDown5.Gallery.ItemAutoSizeMode = DevExpress.XtraBars.Ribbon.Gallery.GalleryItemAutoSizeMode.None
            Me.commandBarGalleryDropDown5.Gallery.ItemSize = New System.Drawing.Size(73, 58)
            Me.commandBarGalleryDropDown5.Gallery.RowCount = 10
            Me.commandBarGalleryDropDown5.Name = "commandBarGalleryDropDown5"
            Me.commandBarGalleryDropDown5.Ribbon = Me.ribbonControl1
            ' 
            ' galleryChangeStyleItem1
            ' 
            ' 
            ' 
            ' 
            Me.galleryChangeStyleItem1.Gallery.DrawImageBackground = False
            Me.galleryChangeStyleItem1.Gallery.ImageSize = New System.Drawing.Size(65, 46)
            Me.galleryChangeStyleItem1.Gallery.ItemAutoSizeMode = DevExpress.XtraBars.Ribbon.Gallery.GalleryItemAutoSizeMode.None
            Me.galleryChangeStyleItem1.Gallery.ItemSize = New System.Drawing.Size(106, 28)
            Me.galleryChangeStyleItem1.Gallery.RowCount = 9
            Me.galleryChangeStyleItem1.Gallery.ShowItemText = True
            Me.galleryChangeStyleItem1.Id = 101
            Me.galleryChangeStyleItem1.Name = "galleryChangeStyleItem1"
            ' 
            ' spreadsheetCommandBarSubItem8
            ' 
            Me.spreadsheetCommandBarSubItem8.CommandName = "InsertCellsCommandGroup"
            Me.spreadsheetCommandBarSubItem8.Id = 102
            Me.spreadsheetCommandBarSubItem8.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() { _
                New DevExpress.XtraBars.LinkPersistInfo(Me.spreadsheetCommandBarButtonItem61), _
                New DevExpress.XtraBars.LinkPersistInfo(Me.spreadsheetCommandBarButtonItem62), _
                New DevExpress.XtraBars.LinkPersistInfo(Me.spreadsheetCommandBarButtonItem63) _
            })
            Me.spreadsheetCommandBarSubItem8.Name = "spreadsheetCommandBarSubItem8"
            ' 
            ' spreadsheetCommandBarButtonItem61
            ' 
            Me.spreadsheetCommandBarButtonItem61.CommandName = "InsertSheetRows"
            Me.spreadsheetCommandBarButtonItem61.Id = 103
            Me.spreadsheetCommandBarButtonItem61.Name = "spreadsheetCommandBarButtonItem61"
            ' 
            ' spreadsheetCommandBarButtonItem62
            ' 
            Me.spreadsheetCommandBarButtonItem62.CommandName = "InsertSheetColumns"
            Me.spreadsheetCommandBarButtonItem62.Id = 104
            Me.spreadsheetCommandBarButtonItem62.Name = "spreadsheetCommandBarButtonItem62"
            ' 
            ' spreadsheetCommandBarButtonItem63
            ' 
            Me.spreadsheetCommandBarButtonItem63.CommandName = "InsertSheet"
            Me.spreadsheetCommandBarButtonItem63.Id = 105
            Me.spreadsheetCommandBarButtonItem63.Name = "spreadsheetCommandBarButtonItem63"
            ' 
            ' spreadsheetCommandBarSubItem9
            ' 
            Me.spreadsheetCommandBarSubItem9.CommandName = "RemoveCellsCommandGroup"
            Me.spreadsheetCommandBarSubItem9.Id = 106
            Me.spreadsheetCommandBarSubItem9.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() { _
                New DevExpress.XtraBars.LinkPersistInfo(Me.spreadsheetCommandBarButtonItem64), _
                New DevExpress.XtraBars.LinkPersistInfo(Me.spreadsheetCommandBarButtonItem65), _
                New DevExpress.XtraBars.LinkPersistInfo(Me.spreadsheetCommandBarButtonItem66) _
            })
            Me.spreadsheetCommandBarSubItem9.Name = "spreadsheetCommandBarSubItem9"
            ' 
            ' spreadsheetCommandBarButtonItem64
            ' 
            Me.spreadsheetCommandBarButtonItem64.CommandName = "RemoveSheetRows"
            Me.spreadsheetCommandBarButtonItem64.Id = 107
            Me.spreadsheetCommandBarButtonItem64.Name = "spreadsheetCommandBarButtonItem64"
            ' 
            ' spreadsheetCommandBarButtonItem65
            ' 
            Me.spreadsheetCommandBarButtonItem65.CommandName = "RemoveSheetColumns"
            Me.spreadsheetCommandBarButtonItem65.Id = 108
            Me.spreadsheetCommandBarButtonItem65.Name = "spreadsheetCommandBarButtonItem65"
            ' 
            ' spreadsheetCommandBarButtonItem66
            ' 
            Me.spreadsheetCommandBarButtonItem66.CommandName = "RemoveSheet"
            Me.spreadsheetCommandBarButtonItem66.Id = 109
            Me.spreadsheetCommandBarButtonItem66.Name = "spreadsheetCommandBarButtonItem66"
            ' 
            ' spreadsheetCommandBarSubItem10
            ' 
            Me.spreadsheetCommandBarSubItem10.CommandName = "FormatCommandGroup"
            Me.spreadsheetCommandBarSubItem10.Id = 110
            Me.spreadsheetCommandBarSubItem10.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() { _
                New DevExpress.XtraBars.LinkPersistInfo(Me.spreadsheetCommandBarButtonItem67), _
                New DevExpress.XtraBars.LinkPersistInfo(Me.spreadsheetCommandBarButtonItem68), _
                New DevExpress.XtraBars.LinkPersistInfo(Me.spreadsheetCommandBarButtonItem69), _
                New DevExpress.XtraBars.LinkPersistInfo(Me.spreadsheetCommandBarButtonItem70), _
                New DevExpress.XtraBars.LinkPersistInfo(Me.spreadsheetCommandBarButtonItem71), _
                New DevExpress.XtraBars.LinkPersistInfo(Me.spreadsheetCommandBarSubItem11), _
                New DevExpress.XtraBars.LinkPersistInfo(Me.spreadsheetCommandBarButtonItem78), _
                New DevExpress.XtraBars.LinkPersistInfo(Me.spreadsheetCommandBarButtonItem79), _
                New DevExpress.XtraBars.LinkPersistInfo(Me.changeSheetTabColorItem1), _
                New DevExpress.XtraBars.LinkPersistInfo(Me.spreadsheetCommandBarButtonItem80), _
                New DevExpress.XtraBars.LinkPersistInfo(Me.spreadsheetCommandBarCheckItem13), _
                New DevExpress.XtraBars.LinkPersistInfo(Me.spreadsheetCommandBarButtonItem81) _
            })
            Me.spreadsheetCommandBarSubItem10.Name = "spreadsheetCommandBarSubItem10"
            ' 
            ' spreadsheetCommandBarButtonItem67
            ' 
            Me.spreadsheetCommandBarButtonItem67.CommandName = "FormatRowHeight"
            Me.spreadsheetCommandBarButtonItem67.Id = 111
            Me.spreadsheetCommandBarButtonItem67.Name = "spreadsheetCommandBarButtonItem67"
            ' 
            ' spreadsheetCommandBarButtonItem68
            ' 
            Me.spreadsheetCommandBarButtonItem68.CommandName = "FormatAutoFitRowHeight"
            Me.spreadsheetCommandBarButtonItem68.Id = 112
            Me.spreadsheetCommandBarButtonItem68.Name = "spreadsheetCommandBarButtonItem68"
            ' 
            ' spreadsheetCommandBarButtonItem69
            ' 
            Me.spreadsheetCommandBarButtonItem69.CommandName = "FormatColumnWidth"
            Me.spreadsheetCommandBarButtonItem69.Id = 113
            Me.spreadsheetCommandBarButtonItem69.Name = "spreadsheetCommandBarButtonItem69"
            ' 
            ' spreadsheetCommandBarButtonItem70
            ' 
            Me.spreadsheetCommandBarButtonItem70.CommandName = "FormatAutoFitColumnWidth"
            Me.spreadsheetCommandBarButtonItem70.Id = 114
            Me.spreadsheetCommandBarButtonItem70.Name = "spreadsheetCommandBarButtonItem70"
            ' 
            ' spreadsheetCommandBarButtonItem71
            ' 
            Me.spreadsheetCommandBarButtonItem71.CommandName = "FormatDefaultColumnWidth"
            Me.spreadsheetCommandBarButtonItem71.Id = 115
            Me.spreadsheetCommandBarButtonItem71.Name = "spreadsheetCommandBarButtonItem71"
            ' 
            ' spreadsheetCommandBarSubItem11
            ' 
            Me.spreadsheetCommandBarSubItem11.CommandName = "HideAndUnhideCommandGroup"
            Me.spreadsheetCommandBarSubItem11.Id = 122
            Me.spreadsheetCommandBarSubItem11.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() { _
                New DevExpress.XtraBars.LinkPersistInfo(Me.spreadsheetCommandBarButtonItem72), _
                New DevExpress.XtraBars.LinkPersistInfo(Me.spreadsheetCommandBarButtonItem73), _
                New DevExpress.XtraBars.LinkPersistInfo(Me.spreadsheetCommandBarButtonItem74), _
                New DevExpress.XtraBars.LinkPersistInfo(Me.spreadsheetCommandBarButtonItem75), _
                New DevExpress.XtraBars.LinkPersistInfo(Me.spreadsheetCommandBarButtonItem76), _
                New DevExpress.XtraBars.LinkPersistInfo(Me.spreadsheetCommandBarButtonItem77) _
            })
            Me.spreadsheetCommandBarSubItem11.Name = "spreadsheetCommandBarSubItem11"
            ' 
            ' spreadsheetCommandBarButtonItem72
            ' 
            Me.spreadsheetCommandBarButtonItem72.CommandName = "HideRows"
            Me.spreadsheetCommandBarButtonItem72.Id = 116
            Me.spreadsheetCommandBarButtonItem72.Name = "spreadsheetCommandBarButtonItem72"
            ' 
            ' spreadsheetCommandBarButtonItem73
            ' 
            Me.spreadsheetCommandBarButtonItem73.CommandName = "HideColumns"
            Me.spreadsheetCommandBarButtonItem73.Id = 117
            Me.spreadsheetCommandBarButtonItem73.Name = "spreadsheetCommandBarButtonItem73"
            ' 
            ' spreadsheetCommandBarButtonItem74
            ' 
            Me.spreadsheetCommandBarButtonItem74.CommandName = "HideSheet"
            Me.spreadsheetCommandBarButtonItem74.Id = 118
            Me.spreadsheetCommandBarButtonItem74.Name = "spreadsheetCommandBarButtonItem74"
            ' 
            ' spreadsheetCommandBarButtonItem75
            ' 
            Me.spreadsheetCommandBarButtonItem75.CommandName = "UnhideRows"
            Me.spreadsheetCommandBarButtonItem75.Id = 119
            Me.spreadsheetCommandBarButtonItem75.Name = "spreadsheetCommandBarButtonItem75"
            ' 
            ' spreadsheetCommandBarButtonItem76
            ' 
            Me.spreadsheetCommandBarButtonItem76.CommandName = "UnhideColumns"
            Me.spreadsheetCommandBarButtonItem76.Id = 120
            Me.spreadsheetCommandBarButtonItem76.Name = "spreadsheetCommandBarButtonItem76"
            ' 
            ' spreadsheetCommandBarButtonItem77
            ' 
            Me.spreadsheetCommandBarButtonItem77.CommandName = "UnhideSheet"
            Me.spreadsheetCommandBarButtonItem77.Id = 121
            Me.spreadsheetCommandBarButtonItem77.Name = "spreadsheetCommandBarButtonItem77"
            ' 
            ' spreadsheetCommandBarButtonItem78
            ' 
            Me.spreadsheetCommandBarButtonItem78.CommandName = "RenameSheet"
            Me.spreadsheetCommandBarButtonItem78.Id = 123
            Me.spreadsheetCommandBarButtonItem78.Name = "spreadsheetCommandBarButtonItem78"
            ' 
            ' spreadsheetCommandBarButtonItem79
            ' 
            Me.spreadsheetCommandBarButtonItem79.CommandName = "MoveOrCopySheet"
            Me.spreadsheetCommandBarButtonItem79.Id = 124
            Me.spreadsheetCommandBarButtonItem79.Name = "spreadsheetCommandBarButtonItem79"
            ' 
            ' changeSheetTabColorItem1
            ' 
            Me.changeSheetTabColorItem1.ActAsDropDown = True
            Me.changeSheetTabColorItem1.Id = 125
            Me.changeSheetTabColorItem1.Name = "changeSheetTabColorItem1"
            ' 
            ' spreadsheetCommandBarButtonItem80
            ' 
            Me.spreadsheetCommandBarButtonItem80.CommandName = "ReviewProtectSheet"
            Me.spreadsheetCommandBarButtonItem80.Id = 126
            Me.spreadsheetCommandBarButtonItem80.Name = "spreadsheetCommandBarButtonItem80"
            ' 
            ' spreadsheetCommandBarCheckItem13
            ' 
            Me.spreadsheetCommandBarCheckItem13.CommandName = "FormatCellLocked"
            Me.spreadsheetCommandBarCheckItem13.Id = 127
            Me.spreadsheetCommandBarCheckItem13.Name = "spreadsheetCommandBarCheckItem13"
            ' 
            ' spreadsheetCommandBarButtonItem81
            ' 
            Me.spreadsheetCommandBarButtonItem81.CommandName = "FormatCellsContextMenuItem"
            Me.spreadsheetCommandBarButtonItem81.Id = 128
            Me.spreadsheetCommandBarButtonItem81.Name = "spreadsheetCommandBarButtonItem81"
            ' 
            ' spreadsheetCommandBarSubItem12
            ' 
            Me.spreadsheetCommandBarSubItem12.CommandName = "EditingAutoSumCommandGroup"
            Me.spreadsheetCommandBarSubItem12.Id = 129
            Me.spreadsheetCommandBarSubItem12.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() { _
                New DevExpress.XtraBars.LinkPersistInfo(Me.spreadsheetCommandBarButtonItem82), _
                New DevExpress.XtraBars.LinkPersistInfo(Me.spreadsheetCommandBarButtonItem83), _
                New DevExpress.XtraBars.LinkPersistInfo(Me.spreadsheetCommandBarButtonItem84), _
                New DevExpress.XtraBars.LinkPersistInfo(Me.spreadsheetCommandBarButtonItem85), _
                New DevExpress.XtraBars.LinkPersistInfo(Me.spreadsheetCommandBarButtonItem86) _
            })
            Me.spreadsheetCommandBarSubItem12.Name = "spreadsheetCommandBarSubItem12"
            Me.spreadsheetCommandBarSubItem12.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText
            ' 
            ' spreadsheetCommandBarButtonItem82
            ' 
            Me.spreadsheetCommandBarButtonItem82.CommandName = "FunctionsInsertSum"
            Me.spreadsheetCommandBarButtonItem82.Id = 130
            Me.spreadsheetCommandBarButtonItem82.Name = "spreadsheetCommandBarButtonItem82"
            ' 
            ' spreadsheetCommandBarButtonItem83
            ' 
            Me.spreadsheetCommandBarButtonItem83.CommandName = "FunctionsInsertAverage"
            Me.spreadsheetCommandBarButtonItem83.Id = 131
            Me.spreadsheetCommandBarButtonItem83.Name = "spreadsheetCommandBarButtonItem83"
            ' 
            ' spreadsheetCommandBarButtonItem84
            ' 
            Me.spreadsheetCommandBarButtonItem84.CommandName = "FunctionsInsertCountNumbers"
            Me.spreadsheetCommandBarButtonItem84.Id = 132
            Me.spreadsheetCommandBarButtonItem84.Name = "spreadsheetCommandBarButtonItem84"
            ' 
            ' spreadsheetCommandBarButtonItem85
            ' 
            Me.spreadsheetCommandBarButtonItem85.CommandName = "FunctionsInsertMax"
            Me.spreadsheetCommandBarButtonItem85.Id = 133
            Me.spreadsheetCommandBarButtonItem85.Name = "spreadsheetCommandBarButtonItem85"
            ' 
            ' spreadsheetCommandBarButtonItem86
            ' 
            Me.spreadsheetCommandBarButtonItem86.CommandName = "FunctionsInsertMin"
            Me.spreadsheetCommandBarButtonItem86.Id = 134
            Me.spreadsheetCommandBarButtonItem86.Name = "spreadsheetCommandBarButtonItem86"
            ' 
            ' spreadsheetCommandBarSubItem13
            ' 
            Me.spreadsheetCommandBarSubItem13.CommandName = "EditingFillCommandGroup"
            Me.spreadsheetCommandBarSubItem13.Id = 135
            Me.spreadsheetCommandBarSubItem13.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() { _
                New DevExpress.XtraBars.LinkPersistInfo(Me.spreadsheetCommandBarButtonItem87), _
                New DevExpress.XtraBars.LinkPersistInfo(Me.spreadsheetCommandBarButtonItem88), _
                New DevExpress.XtraBars.LinkPersistInfo(Me.spreadsheetCommandBarButtonItem89), _
                New DevExpress.XtraBars.LinkPersistInfo(Me.spreadsheetCommandBarButtonItem90) _
            })
            Me.spreadsheetCommandBarSubItem13.Name = "spreadsheetCommandBarSubItem13"
            Me.spreadsheetCommandBarSubItem13.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText
            ' 
            ' spreadsheetCommandBarButtonItem87
            ' 
            Me.spreadsheetCommandBarButtonItem87.CommandName = "EditingFillDown"
            Me.spreadsheetCommandBarButtonItem87.Id = 136
            Me.spreadsheetCommandBarButtonItem87.Name = "spreadsheetCommandBarButtonItem87"
            ' 
            ' spreadsheetCommandBarButtonItem88
            ' 
            Me.spreadsheetCommandBarButtonItem88.CommandName = "EditingFillRight"
            Me.spreadsheetCommandBarButtonItem88.Id = 137
            Me.spreadsheetCommandBarButtonItem88.Name = "spreadsheetCommandBarButtonItem88"
            ' 
            ' spreadsheetCommandBarButtonItem89
            ' 
            Me.spreadsheetCommandBarButtonItem89.CommandName = "EditingFillUp"
            Me.spreadsheetCommandBarButtonItem89.Id = 138
            Me.spreadsheetCommandBarButtonItem89.Name = "spreadsheetCommandBarButtonItem89"
            ' 
            ' spreadsheetCommandBarButtonItem90
            ' 
            Me.spreadsheetCommandBarButtonItem90.CommandName = "EditingFillLeft"
            Me.spreadsheetCommandBarButtonItem90.Id = 139
            Me.spreadsheetCommandBarButtonItem90.Name = "spreadsheetCommandBarButtonItem90"
            ' 
            ' spreadsheetCommandBarSubItem14
            ' 
            Me.spreadsheetCommandBarSubItem14.CommandName = "FormatClearCommandGroup"
            Me.spreadsheetCommandBarSubItem14.Id = 140
            Me.spreadsheetCommandBarSubItem14.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() { _
                New DevExpress.XtraBars.LinkPersistInfo(Me.spreadsheetCommandBarButtonItem91), _
                New DevExpress.XtraBars.LinkPersistInfo(Me.spreadsheetCommandBarButtonItem92), _
                New DevExpress.XtraBars.LinkPersistInfo(Me.spreadsheetCommandBarButtonItem93), _
                New DevExpress.XtraBars.LinkPersistInfo(Me.spreadsheetCommandBarButtonItem94), _
                New DevExpress.XtraBars.LinkPersistInfo(Me.spreadsheetCommandBarButtonItem95), _
                New DevExpress.XtraBars.LinkPersistInfo(Me.spreadsheetCommandBarButtonItem96) _
            })
            Me.spreadsheetCommandBarSubItem14.Name = "spreadsheetCommandBarSubItem14"
            Me.spreadsheetCommandBarSubItem14.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText
            ' 
            ' spreadsheetCommandBarButtonItem91
            ' 
            Me.spreadsheetCommandBarButtonItem91.CommandName = "FormatClearAll"
            Me.spreadsheetCommandBarButtonItem91.Id = 141
            Me.spreadsheetCommandBarButtonItem91.Name = "spreadsheetCommandBarButtonItem91"
            ' 
            ' spreadsheetCommandBarButtonItem92
            ' 
            Me.spreadsheetCommandBarButtonItem92.CommandName = "FormatClearFormats"
            Me.spreadsheetCommandBarButtonItem92.Id = 142
            Me.spreadsheetCommandBarButtonItem92.Name = "spreadsheetCommandBarButtonItem92"
            ' 
            ' spreadsheetCommandBarButtonItem93
            ' 
            Me.spreadsheetCommandBarButtonItem93.CommandName = "FormatClearContents"
            Me.spreadsheetCommandBarButtonItem93.Id = 143
            Me.spreadsheetCommandBarButtonItem93.Name = "spreadsheetCommandBarButtonItem93"
            ' 
            ' spreadsheetCommandBarButtonItem94
            ' 
            Me.spreadsheetCommandBarButtonItem94.CommandName = "FormatClearComments"
            Me.spreadsheetCommandBarButtonItem94.Id = 144
            Me.spreadsheetCommandBarButtonItem94.Name = "spreadsheetCommandBarButtonItem94"
            ' 
            ' spreadsheetCommandBarButtonItem95
            ' 
            Me.spreadsheetCommandBarButtonItem95.CommandName = "FormatClearHyperlinks"
            Me.spreadsheetCommandBarButtonItem95.Id = 145
            Me.spreadsheetCommandBarButtonItem95.Name = "spreadsheetCommandBarButtonItem95"
            ' 
            ' spreadsheetCommandBarButtonItem96
            ' 
            Me.spreadsheetCommandBarButtonItem96.CommandName = "FormatRemoveHyperlinks"
            Me.spreadsheetCommandBarButtonItem96.Id = 146
            Me.spreadsheetCommandBarButtonItem96.Name = "spreadsheetCommandBarButtonItem96"
            ' 
            ' spreadsheetCommandBarSubItem15
            ' 
            Me.spreadsheetCommandBarSubItem15.CommandName = "EditingSortAndFilterCommandGroup"
            Me.spreadsheetCommandBarSubItem15.Id = 147
            Me.spreadsheetCommandBarSubItem15.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() { _
                New DevExpress.XtraBars.LinkPersistInfo(Me.spreadsheetCommandBarButtonItem97), _
                New DevExpress.XtraBars.LinkPersistInfo(Me.spreadsheetCommandBarButtonItem98), _
                New DevExpress.XtraBars.LinkPersistInfo(Me.spreadsheetCommandBarCheckItem14), _
                New DevExpress.XtraBars.LinkPersistInfo(Me.spreadsheetCommandBarButtonItem99), _
                New DevExpress.XtraBars.LinkPersistInfo(Me.spreadsheetCommandBarButtonItem100) _
            })
            Me.spreadsheetCommandBarSubItem15.Name = "spreadsheetCommandBarSubItem15"
            ' 
            ' spreadsheetCommandBarButtonItem97
            ' 
            Me.spreadsheetCommandBarButtonItem97.CommandName = "DataSortAscending"
            Me.spreadsheetCommandBarButtonItem97.Id = 148
            Me.spreadsheetCommandBarButtonItem97.Name = "spreadsheetCommandBarButtonItem97"
            ' 
            ' spreadsheetCommandBarButtonItem98
            ' 
            Me.spreadsheetCommandBarButtonItem98.CommandName = "DataSortDescending"
            Me.spreadsheetCommandBarButtonItem98.Id = 149
            Me.spreadsheetCommandBarButtonItem98.Name = "spreadsheetCommandBarButtonItem98"
            ' 
            ' spreadsheetCommandBarCheckItem14
            ' 
            Me.spreadsheetCommandBarCheckItem14.CommandName = "DataFilterToggle"
            Me.spreadsheetCommandBarCheckItem14.Id = 150
            Me.spreadsheetCommandBarCheckItem14.Name = "spreadsheetCommandBarCheckItem14"
            ' 
            ' spreadsheetCommandBarButtonItem99
            ' 
            Me.spreadsheetCommandBarButtonItem99.CommandName = "DataFilterClear"
            Me.spreadsheetCommandBarButtonItem99.Id = 151
            Me.spreadsheetCommandBarButtonItem99.Name = "spreadsheetCommandBarButtonItem99"
            ' 
            ' spreadsheetCommandBarButtonItem100
            ' 
            Me.spreadsheetCommandBarButtonItem100.CommandName = "DataFilterReApply"
            Me.spreadsheetCommandBarButtonItem100.Id = 152
            Me.spreadsheetCommandBarButtonItem100.Name = "spreadsheetCommandBarButtonItem100"
            ' 
            ' spreadsheetCommandBarSubItem16
            ' 
            Me.spreadsheetCommandBarSubItem16.CommandName = "EditingFindAndSelectCommandGroup"
            Me.spreadsheetCommandBarSubItem16.Id = 153
            Me.spreadsheetCommandBarSubItem16.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() { _
                New DevExpress.XtraBars.LinkPersistInfo(Me.spreadsheetCommandBarButtonItem101), _
                New DevExpress.XtraBars.LinkPersistInfo(Me.spreadsheetCommandBarButtonItem102), _
                New DevExpress.XtraBars.LinkPersistInfo(Me.spreadsheetCommandBarButtonItem103), _
                New DevExpress.XtraBars.LinkPersistInfo(Me.spreadsheetCommandBarButtonItem104), _
                New DevExpress.XtraBars.LinkPersistInfo(Me.spreadsheetCommandBarButtonItem105), _
                New DevExpress.XtraBars.LinkPersistInfo(Me.spreadsheetCommandBarButtonItem106), _
                New DevExpress.XtraBars.LinkPersistInfo(Me.spreadsheetCommandBarButtonItem107) _
            })
            Me.spreadsheetCommandBarSubItem16.Name = "spreadsheetCommandBarSubItem16"
            ' 
            ' spreadsheetCommandBarButtonItem101
            ' 
            Me.spreadsheetCommandBarButtonItem101.CommandName = "EditingFind"
            Me.spreadsheetCommandBarButtonItem101.Id = 154
            Me.spreadsheetCommandBarButtonItem101.Name = "spreadsheetCommandBarButtonItem101"
            ' 
            ' spreadsheetCommandBarButtonItem102
            ' 
            Me.spreadsheetCommandBarButtonItem102.CommandName = "EditingReplace"
            Me.spreadsheetCommandBarButtonItem102.Id = 155
            Me.spreadsheetCommandBarButtonItem102.Name = "spreadsheetCommandBarButtonItem102"
            ' 
            ' spreadsheetCommandBarButtonItem103
            ' 
            Me.spreadsheetCommandBarButtonItem103.CommandName = "EditingSelectFormulas"
            Me.spreadsheetCommandBarButtonItem103.Id = 156
            Me.spreadsheetCommandBarButtonItem103.Name = "spreadsheetCommandBarButtonItem103"
            ' 
            ' spreadsheetCommandBarButtonItem104
            ' 
            Me.spreadsheetCommandBarButtonItem104.CommandName = "EditingSelectComments"
            Me.spreadsheetCommandBarButtonItem104.Id = 157
            Me.spreadsheetCommandBarButtonItem104.Name = "spreadsheetCommandBarButtonItem104"
            ' 
            ' spreadsheetCommandBarButtonItem105
            ' 
            Me.spreadsheetCommandBarButtonItem105.CommandName = "EditingSelectConditionalFormatting"
            Me.spreadsheetCommandBarButtonItem105.Id = 158
            Me.spreadsheetCommandBarButtonItem105.Name = "spreadsheetCommandBarButtonItem105"
            ' 
            ' spreadsheetCommandBarButtonItem106
            ' 
            Me.spreadsheetCommandBarButtonItem106.CommandName = "EditingSelectConstants"
            Me.spreadsheetCommandBarButtonItem106.Id = 159
            Me.spreadsheetCommandBarButtonItem106.Name = "spreadsheetCommandBarButtonItem106"
            ' 
            ' spreadsheetCommandBarButtonItem107
            ' 
            Me.spreadsheetCommandBarButtonItem107.CommandName = "EditingSelectDataValidation"
            Me.spreadsheetCommandBarButtonItem107.Id = 160
            Me.spreadsheetCommandBarButtonItem107.Name = "spreadsheetCommandBarButtonItem107"
            ' 
            ' spreadsheetCommandBarSubItem17
            ' 
            Me.spreadsheetCommandBarSubItem17.CommandName = "FunctionsAutoSumCommandGroup"
            Me.spreadsheetCommandBarSubItem17.Id = 161
            Me.spreadsheetCommandBarSubItem17.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() { _
                New DevExpress.XtraBars.LinkPersistInfo(Me.spreadsheetCommandBarButtonItem82), _
                New DevExpress.XtraBars.LinkPersistInfo(Me.spreadsheetCommandBarButtonItem83), _
                New DevExpress.XtraBars.LinkPersistInfo(Me.spreadsheetCommandBarButtonItem84), _
                New DevExpress.XtraBars.LinkPersistInfo(Me.spreadsheetCommandBarButtonItem85), _
                New DevExpress.XtraBars.LinkPersistInfo(Me.spreadsheetCommandBarButtonItem86) _
            })
            Me.spreadsheetCommandBarSubItem17.Name = "spreadsheetCommandBarSubItem17"
            ' 
            ' functionsFinancialItem1
            ' 
            Me.functionsFinancialItem1.Id = 162
            Me.functionsFinancialItem1.Name = "functionsFinancialItem1"
            ' 
            ' functionsLogicalItem1
            ' 
            Me.functionsLogicalItem1.Id = 163
            Me.functionsLogicalItem1.Name = "functionsLogicalItem1"
            ' 
            ' functionsTextItem1
            ' 
            Me.functionsTextItem1.Id = 164
            Me.functionsTextItem1.Name = "functionsTextItem1"
            ' 
            ' functionsDateAndTimeItem1
            ' 
            Me.functionsDateAndTimeItem1.Id = 165
            Me.functionsDateAndTimeItem1.Name = "functionsDateAndTimeItem1"
            ' 
            ' functionsLookupAndReferenceItem1
            ' 
            Me.functionsLookupAndReferenceItem1.Id = 166
            Me.functionsLookupAndReferenceItem1.Name = "functionsLookupAndReferenceItem1"
            ' 
            ' functionsMathAndTrigonometryItem1
            ' 
            Me.functionsMathAndTrigonometryItem1.Id = 167
            Me.functionsMathAndTrigonometryItem1.Name = "functionsMathAndTrigonometryItem1"
            ' 
            ' spreadsheetCommandBarSubItem18
            ' 
            Me.spreadsheetCommandBarSubItem18.CommandName = "FunctionsMoreCommandGroup"
            Me.spreadsheetCommandBarSubItem18.Id = 168
            Me.spreadsheetCommandBarSubItem18.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() { _
                New DevExpress.XtraBars.LinkPersistInfo(Me.functionsStatisticalItem1), _
                New DevExpress.XtraBars.LinkPersistInfo(Me.functionsEngineeringItem1), _
                New DevExpress.XtraBars.LinkPersistInfo(Me.functionsInformationItem1), _
                New DevExpress.XtraBars.LinkPersistInfo(Me.functionsCompatibilityItem1), _
                New DevExpress.XtraBars.LinkPersistInfo(Me.functionsWebItem1) _
            })
            Me.spreadsheetCommandBarSubItem18.Name = "spreadsheetCommandBarSubItem18"
            ' 
            ' functionsStatisticalItem1
            ' 
            Me.functionsStatisticalItem1.Id = 169
            Me.functionsStatisticalItem1.Name = "functionsStatisticalItem1"
            ' 
            ' functionsEngineeringItem1
            ' 
            Me.functionsEngineeringItem1.Id = 170
            Me.functionsEngineeringItem1.Name = "functionsEngineeringItem1"
            ' 
            ' functionsInformationItem1
            ' 
            Me.functionsInformationItem1.Id = 171
            Me.functionsInformationItem1.Name = "functionsInformationItem1"
            ' 
            ' functionsCompatibilityItem1
            ' 
            Me.functionsCompatibilityItem1.Id = 172
            Me.functionsCompatibilityItem1.Name = "functionsCompatibilityItem1"
            ' 
            ' functionsWebItem1
            ' 
            Me.functionsWebItem1.Id = 173
            Me.functionsWebItem1.Name = "functionsWebItem1"
            ' 
            ' spreadsheetCommandBarButtonItem113
            ' 
            Me.spreadsheetCommandBarButtonItem113.CommandName = "FormulasShowNameManager"
            Me.spreadsheetCommandBarButtonItem113.Id = 174
            Me.spreadsheetCommandBarButtonItem113.Name = "spreadsheetCommandBarButtonItem113"
            ' 
            ' spreadsheetCommandBarButtonItem114
            ' 
            Me.spreadsheetCommandBarButtonItem114.CommandName = "FormulasDefineNameCommand"
            Me.spreadsheetCommandBarButtonItem114.Id = 175
            Me.spreadsheetCommandBarButtonItem114.Name = "spreadsheetCommandBarButtonItem114"
            Me.spreadsheetCommandBarButtonItem114.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText
            ' 
            ' definedNameListItem1
            ' 
            Me.definedNameListItem1.Id = 176
            Me.definedNameListItem1.Name = "definedNameListItem1"
            Me.definedNameListItem1.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText
            ' 
            ' spreadsheetCommandBarButtonItem115
            ' 
            Me.spreadsheetCommandBarButtonItem115.CommandName = "FormulasCreateDefinedNamesFromSelection"
            Me.spreadsheetCommandBarButtonItem115.Id = 177
            Me.spreadsheetCommandBarButtonItem115.Name = "spreadsheetCommandBarButtonItem115"
            Me.spreadsheetCommandBarButtonItem115.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText
            ' 
            ' spreadsheetCommandBarCheckItem15
            ' 
            Me.spreadsheetCommandBarCheckItem15.CommandName = "ViewShowFormulas"
            Me.spreadsheetCommandBarCheckItem15.Id = 178
            Me.spreadsheetCommandBarCheckItem15.Name = "spreadsheetCommandBarCheckItem15"
            ' 
            ' spreadsheetCommandBarSubItem19
            ' 
            Me.spreadsheetCommandBarSubItem19.CommandName = "FormulasCalculationOptionsCommandGroup"
            Me.spreadsheetCommandBarSubItem19.Id = 179
            Me.spreadsheetCommandBarSubItem19.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() { _
                New DevExpress.XtraBars.LinkPersistInfo(Me.spreadsheetCommandBarCheckItem16), _
                New DevExpress.XtraBars.LinkPersistInfo(Me.spreadsheetCommandBarCheckItem17) _
            })
            Me.spreadsheetCommandBarSubItem19.Name = "spreadsheetCommandBarSubItem19"
            ' 
            ' spreadsheetCommandBarCheckItem16
            ' 
            Me.spreadsheetCommandBarCheckItem16.CommandName = "FormulasCalculationModeAutomatic"
            Me.spreadsheetCommandBarCheckItem16.Id = 180
            Me.spreadsheetCommandBarCheckItem16.Name = "spreadsheetCommandBarCheckItem16"
            ' 
            ' spreadsheetCommandBarCheckItem17
            ' 
            Me.spreadsheetCommandBarCheckItem17.CommandName = "FormulasCalculationModeManual"
            Me.spreadsheetCommandBarCheckItem17.Id = 181
            Me.spreadsheetCommandBarCheckItem17.Name = "spreadsheetCommandBarCheckItem17"
            ' 
            ' spreadsheetCommandBarButtonItem116
            ' 
            Me.spreadsheetCommandBarButtonItem116.CommandName = "FormulasCalculateNow"
            Me.spreadsheetCommandBarButtonItem116.Id = 182
            Me.spreadsheetCommandBarButtonItem116.Name = "spreadsheetCommandBarButtonItem116"
            Me.spreadsheetCommandBarButtonItem116.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText
            ' 
            ' spreadsheetCommandBarButtonItem117
            ' 
            Me.spreadsheetCommandBarButtonItem117.CommandName = "FormulasCalculateSheet"
            Me.spreadsheetCommandBarButtonItem117.Id = 183
            Me.spreadsheetCommandBarButtonItem117.Name = "spreadsheetCommandBarButtonItem117"
            Me.spreadsheetCommandBarButtonItem117.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText
            ' 
            ' fileRibbonPage1
            ' 
            Me.fileRibbonPage1.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() { Me.commonRibbonPageGroup1, Me.infoRibbonPageGroup1})
            Me.fileRibbonPage1.Name = "fileRibbonPage1"
            ' 
            ' commonRibbonPageGroup1
            ' 
            Me.commonRibbonPageGroup1.ItemLinks.Add(Me.spreadsheetCommandBarButtonItem1)
            Me.commonRibbonPageGroup1.ItemLinks.Add(Me.spreadsheetCommandBarButtonItem2)
            Me.commonRibbonPageGroup1.ItemLinks.Add(Me.spreadsheetCommandBarButtonItem3)
            Me.commonRibbonPageGroup1.ItemLinks.Add(Me.spreadsheetCommandBarButtonItem4)
            Me.commonRibbonPageGroup1.ItemLinks.Add(Me.spreadsheetCommandBarButtonItem5)
            Me.commonRibbonPageGroup1.ItemLinks.Add(Me.spreadsheetCommandBarButtonItem6)
            Me.commonRibbonPageGroup1.ItemLinks.Add(Me.spreadsheetCommandBarButtonItem7)
            Me.commonRibbonPageGroup1.ItemLinks.Add(Me.spreadsheetCommandBarButtonItem8)
            Me.commonRibbonPageGroup1.ItemLinks.Add(Me.spreadsheetCommandBarButtonItem9)
            Me.commonRibbonPageGroup1.Name = "commonRibbonPageGroup1"
            ' 
            ' infoRibbonPageGroup1
            ' 
            Me.infoRibbonPageGroup1.ItemLinks.Add(Me.spreadsheetCommandBarButtonItem10)
            Me.infoRibbonPageGroup1.ItemLinks.Add(Me.spreadsheetCommandBarButtonItem11)
            Me.infoRibbonPageGroup1.Name = "infoRibbonPageGroup1"
            ' 
            ' homeRibbonPage1
            ' 
            Me.homeRibbonPage1.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() { Me.clipboardRibbonPageGroup1, Me.fontRibbonPageGroup1, Me.alignmentRibbonPageGroup1, Me.numberRibbonPageGroup1, Me.stylesRibbonPageGroup1, Me.cellsRibbonPageGroup1, Me.editingRibbonPageGroup1})
            Me.homeRibbonPage1.Name = "homeRibbonPage1"
            reduceOperation2.Behavior = DevExpress.XtraBars.Ribbon.ReduceOperationBehavior.UntilAvailable
            reduceOperation2.Group = Me.stylesRibbonPageGroup1
            reduceOperation2.ItemLinkIndex = 2
            reduceOperation2.ItemLinksCount = 0
            reduceOperation2.Operation = DevExpress.XtraBars.Ribbon.ReduceOperationType.Gallery
            Me.homeRibbonPage1.ReduceOperations.Add(reduceOperation2)
            ' 
            ' clipboardRibbonPageGroup1
            ' 
            Me.clipboardRibbonPageGroup1.ItemLinks.Add(Me.spreadsheetCommandBarButtonItem12)
            Me.clipboardRibbonPageGroup1.ItemLinks.Add(Me.spreadsheetCommandBarButtonItem13)
            Me.clipboardRibbonPageGroup1.ItemLinks.Add(Me.spreadsheetCommandBarButtonItem14)
            Me.clipboardRibbonPageGroup1.ItemLinks.Add(Me.spreadsheetCommandBarButtonItem15)
            Me.clipboardRibbonPageGroup1.Name = "clipboardRibbonPageGroup1"
            ' 
            ' fontRibbonPageGroup1
            ' 
            Me.fontRibbonPageGroup1.ItemLinks.Add(Me.barButtonGroup1)
            Me.fontRibbonPageGroup1.ItemLinks.Add(Me.barButtonGroup2)
            Me.fontRibbonPageGroup1.ItemLinks.Add(Me.barButtonGroup3)
            Me.fontRibbonPageGroup1.ItemLinks.Add(Me.barButtonGroup4)
            Me.fontRibbonPageGroup1.Name = "fontRibbonPageGroup1"
            ' 
            ' alignmentRibbonPageGroup1
            ' 
            Me.alignmentRibbonPageGroup1.ItemLinks.Add(Me.barButtonGroup5)
            Me.alignmentRibbonPageGroup1.ItemLinks.Add(Me.barButtonGroup6)
            Me.alignmentRibbonPageGroup1.ItemLinks.Add(Me.barButtonGroup7)
            Me.alignmentRibbonPageGroup1.ItemLinks.Add(Me.spreadsheetCommandBarCheckItem11)
            Me.alignmentRibbonPageGroup1.ItemLinks.Add(Me.spreadsheetCommandBarSubItem2)
            Me.alignmentRibbonPageGroup1.Name = "alignmentRibbonPageGroup1"
            ' 
            ' numberRibbonPageGroup1
            ' 
            Me.numberRibbonPageGroup1.ItemLinks.Add(Me.barButtonGroup8)
            Me.numberRibbonPageGroup1.ItemLinks.Add(Me.barButtonGroup9)
            Me.numberRibbonPageGroup1.ItemLinks.Add(Me.barButtonGroup10)
            Me.numberRibbonPageGroup1.Name = "numberRibbonPageGroup1"
            ' 
            ' cellsRibbonPageGroup1
            ' 
            Me.cellsRibbonPageGroup1.ItemLinks.Add(Me.spreadsheetCommandBarSubItem8)
            Me.cellsRibbonPageGroup1.ItemLinks.Add(Me.spreadsheetCommandBarSubItem9)
            Me.cellsRibbonPageGroup1.ItemLinks.Add(Me.spreadsheetCommandBarSubItem10)
            Me.cellsRibbonPageGroup1.Name = "cellsRibbonPageGroup1"
            ' 
            ' editingRibbonPageGroup1
            ' 
            Me.editingRibbonPageGroup1.ItemLinks.Add(Me.spreadsheetCommandBarSubItem12)
            Me.editingRibbonPageGroup1.ItemLinks.Add(Me.spreadsheetCommandBarSubItem13)
            Me.editingRibbonPageGroup1.ItemLinks.Add(Me.spreadsheetCommandBarSubItem14)
            Me.editingRibbonPageGroup1.ItemLinks.Add(Me.spreadsheetCommandBarSubItem15)
            Me.editingRibbonPageGroup1.ItemLinks.Add(Me.spreadsheetCommandBarSubItem16)
            Me.editingRibbonPageGroup1.Name = "editingRibbonPageGroup1"
            ' 
            ' formulasRibbonPage1
            ' 
            Me.formulasRibbonPage1.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() { Me.functionLibraryRibbonPageGroup1, Me.formulaDefinedNamesRibbonPageGroup1, Me.formulaAuditingRibbonPageGroup1, Me.formulaCalculationRibbonPageGroup1})
            Me.formulasRibbonPage1.Name = "formulasRibbonPage1"
            ' 
            ' functionLibraryRibbonPageGroup1
            ' 
            Me.functionLibraryRibbonPageGroup1.ItemLinks.Add(Me.spreadsheetCommandBarSubItem17)
            Me.functionLibraryRibbonPageGroup1.ItemLinks.Add(Me.functionsFinancialItem1)
            Me.functionLibraryRibbonPageGroup1.ItemLinks.Add(Me.functionsLogicalItem1)
            Me.functionLibraryRibbonPageGroup1.ItemLinks.Add(Me.functionsTextItem1)
            Me.functionLibraryRibbonPageGroup1.ItemLinks.Add(Me.functionsDateAndTimeItem1)
            Me.functionLibraryRibbonPageGroup1.ItemLinks.Add(Me.functionsLookupAndReferenceItem1)
            Me.functionLibraryRibbonPageGroup1.ItemLinks.Add(Me.functionsMathAndTrigonometryItem1)
            Me.functionLibraryRibbonPageGroup1.ItemLinks.Add(Me.spreadsheetCommandBarSubItem18)
            Me.functionLibraryRibbonPageGroup1.Name = "functionLibraryRibbonPageGroup1"
            ' 
            ' formulaDefinedNamesRibbonPageGroup1
            ' 
            Me.formulaDefinedNamesRibbonPageGroup1.ItemLinks.Add(Me.spreadsheetCommandBarButtonItem113)
            Me.formulaDefinedNamesRibbonPageGroup1.ItemLinks.Add(Me.spreadsheetCommandBarButtonItem114)
            Me.formulaDefinedNamesRibbonPageGroup1.ItemLinks.Add(Me.definedNameListItem1)
            Me.formulaDefinedNamesRibbonPageGroup1.ItemLinks.Add(Me.spreadsheetCommandBarButtonItem115)
            Me.formulaDefinedNamesRibbonPageGroup1.Name = "formulaDefinedNamesRibbonPageGroup1"
            ' 
            ' formulaAuditingRibbonPageGroup1
            ' 
            Me.formulaAuditingRibbonPageGroup1.ItemLinks.Add(Me.spreadsheetCommandBarCheckItem15)
            Me.formulaAuditingRibbonPageGroup1.Name = "formulaAuditingRibbonPageGroup1"
            ' 
            ' formulaCalculationRibbonPageGroup1
            ' 
            Me.formulaCalculationRibbonPageGroup1.ItemLinks.Add(Me.spreadsheetCommandBarSubItem19)
            Me.formulaCalculationRibbonPageGroup1.ItemLinks.Add(Me.spreadsheetCommandBarButtonItem116)
            Me.formulaCalculationRibbonPageGroup1.ItemLinks.Add(Me.spreadsheetCommandBarButtonItem117)
            Me.formulaCalculationRibbonPageGroup1.Name = "formulaCalculationRibbonPageGroup1"
            ' 
            ' spreadsheetFormulaBarControl1
            ' 
            Me.spreadsheetFormulaBarControl1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.spreadsheetFormulaBarControl1.Location = New System.Drawing.Point(0, 0)
            Me.spreadsheetFormulaBarControl1.MinimumSize = New System.Drawing.Size(0, 20)
            Me.spreadsheetFormulaBarControl1.Name = "spreadsheetFormulaBarControl1"
            Me.spreadsheetFormulaBarControl1.Size = New System.Drawing.Size(627, 20)
            Me.spreadsheetFormulaBarControl1.SpreadsheetControl = Me.spreadsheetControl1
            Me.spreadsheetFormulaBarControl1.TabIndex = 0
            ' 
            ' spreadsheetNameBoxControl1
            ' 
            Me.spreadsheetNameBoxControl1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.spreadsheetNameBoxControl1.EditValue = "A1"
            Me.spreadsheetNameBoxControl1.Location = New System.Drawing.Point(0, 0)
            Me.spreadsheetNameBoxControl1.MinimumSize = New System.Drawing.Size(0, 20)
            Me.spreadsheetNameBoxControl1.Name = "spreadsheetNameBoxControl1"
            Me.spreadsheetNameBoxControl1.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.spreadsheetNameBoxControl1.Size = New System.Drawing.Size(145, 20)
            Me.spreadsheetNameBoxControl1.SpreadsheetControl = Me.spreadsheetControl1
            Me.spreadsheetNameBoxControl1.TabIndex = 0
            ' 
            ' splitContainerControl1
            ' 
            Me.splitContainerControl1.Dock = System.Windows.Forms.DockStyle.Top
            Me.splitContainerControl1.Location = New System.Drawing.Point(0, 146)
            Me.splitContainerControl1.MinimumSize = New System.Drawing.Size(0, 20)
            Me.splitContainerControl1.Name = "splitContainerControl1"
            Me.splitContainerControl1.Panel1.Controls.Add(Me.spreadsheetNameBoxControl1)
            Me.splitContainerControl1.Panel2.Controls.Add(Me.spreadsheetFormulaBarControl1)
            Me.splitContainerControl1.Size = New System.Drawing.Size(784, 20)
            Me.splitContainerControl1.SplitterPosition = 145
            Me.splitContainerControl1.TabIndex = 2
            ' 
            ' splitterControl1
            ' 
            Me.splitterControl1.Dock = System.Windows.Forms.DockStyle.Top
            Me.splitterControl1.Location = New System.Drawing.Point(0, 166)
            Me.splitterControl1.MinSize = 20
            Me.splitterControl1.Name = "splitterControl1"
            Me.splitterControl1.Size = New System.Drawing.Size(784, 12)
            Me.splitterControl1.TabIndex = 1
            Me.splitterControl1.TabStop = False
            ' 
            ' spreadsheetBarController1
            ' 
            Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarButtonItem1)
            Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarButtonItem2)
            Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarButtonItem3)
            Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarButtonItem4)
            Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarButtonItem5)
            Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarButtonItem6)
            Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarButtonItem7)
            Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarButtonItem8)
            Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarButtonItem9)
            Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarButtonItem10)
            Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarButtonItem11)
            Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarButtonItem12)
            Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarButtonItem13)
            Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarButtonItem14)
            Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarButtonItem15)
            Me.spreadsheetBarController1.BarItems.Add(Me.changeFontNameItem1)
            Me.spreadsheetBarController1.BarItems.Add(Me.changeFontSizeItem1)
            Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarButtonItem16)
            Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarButtonItem17)
            Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarCheckItem1)
            Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarCheckItem2)
            Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarCheckItem3)
            Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarCheckItem4)
            Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarSubItem1)
            Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarButtonItem18)
            Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarButtonItem19)
            Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarButtonItem20)
            Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarButtonItem21)
            Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarButtonItem22)
            Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarButtonItem23)
            Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarButtonItem24)
            Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarButtonItem25)
            Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarButtonItem26)
            Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarButtonItem27)
            Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarButtonItem28)
            Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarButtonItem29)
            Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarButtonItem30)
            Me.spreadsheetBarController1.BarItems.Add(Me.changeBorderLineColorItem1)
            Me.spreadsheetBarController1.BarItems.Add(Me.changeBorderLineStyleItem1)
            Me.spreadsheetBarController1.BarItems.Add(Me.changeCellFillColorItem1)
            Me.spreadsheetBarController1.BarItems.Add(Me.changeFontColorItem1)
            Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarCheckItem5)
            Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarCheckItem6)
            Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarCheckItem7)
            Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarCheckItem8)
            Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarCheckItem9)
            Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarCheckItem10)
            Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarButtonItem31)
            Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarButtonItem32)
            Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarCheckItem11)
            Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarSubItem2)
            Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarCheckItem12)
            Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarButtonItem33)
            Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarButtonItem34)
            Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarButtonItem35)
            Me.spreadsheetBarController1.BarItems.Add(Me.changeNumberFormatItem1)
            Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarSubItem3)
            Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarButtonItem36)
            Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarButtonItem37)
            Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarButtonItem38)
            Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarButtonItem39)
            Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarButtonItem40)
            Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarButtonItem41)
            Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarButtonItem42)
            Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarButtonItem43)
            Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarButtonItem44)
            Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarSubItem4)
            Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarSubItem5)
            Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarButtonItem45)
            Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarButtonItem46)
            Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarButtonItem47)
            Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarButtonItem48)
            Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarButtonItem49)
            Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarButtonItem50)
            Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarButtonItem51)
            Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarSubItem6)
            Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarButtonItem52)
            Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarButtonItem53)
            Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarButtonItem54)
            Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarButtonItem55)
            Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarButtonItem56)
            Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarButtonItem57)
            Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarButtonGalleryDropDownItem1)
            Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarButtonGalleryDropDownItem2)
            Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarButtonGalleryDropDownItem3)
            Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarButtonItem58)
            Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarSubItem7)
            Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarButtonItem59)
            Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarButtonItem60)
            Me.spreadsheetBarController1.BarItems.Add(Me.galleryFormatAsTableItem1)
            Me.spreadsheetBarController1.BarItems.Add(Me.galleryChangeStyleItem1)
            Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarSubItem8)
            Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarButtonItem61)
            Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarButtonItem62)
            Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarButtonItem63)
            Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarSubItem9)
            Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarButtonItem64)
            Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarButtonItem65)
            Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarButtonItem66)
            Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarSubItem10)
            Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarButtonItem67)
            Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarButtonItem68)
            Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarButtonItem69)
            Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarButtonItem70)
            Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarButtonItem71)
            Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarSubItem11)
            Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarButtonItem72)
            Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarButtonItem73)
            Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarButtonItem74)
            Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarButtonItem75)
            Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarButtonItem76)
            Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarButtonItem77)
            Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarButtonItem78)
            Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarButtonItem79)
            Me.spreadsheetBarController1.BarItems.Add(Me.changeSheetTabColorItem1)
            Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarButtonItem80)
            Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarCheckItem13)
            Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarButtonItem81)
            Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarSubItem12)
            Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarButtonItem82)
            Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarButtonItem83)
            Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarButtonItem84)
            Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarButtonItem85)
            Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarButtonItem86)
            Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarSubItem13)
            Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarButtonItem87)
            Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarButtonItem88)
            Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarButtonItem89)
            Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarButtonItem90)
            Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarSubItem14)
            Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarButtonItem91)
            Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarButtonItem92)
            Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarButtonItem93)
            Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarButtonItem94)
            Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarButtonItem95)
            Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarButtonItem96)
            Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarSubItem15)
            Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarButtonItem97)
            Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarButtonItem98)
            Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarCheckItem14)
            Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarButtonItem99)
            Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarButtonItem100)
            Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarSubItem16)
            Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarButtonItem101)
            Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarButtonItem102)
            Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarButtonItem103)
            Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarButtonItem104)
            Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarButtonItem105)
            Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarButtonItem106)
            Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarButtonItem107)
            Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarSubItem17)
            Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarButtonItem108)
            Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarButtonItem109)
            Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarButtonItem110)
            Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarButtonItem111)
            Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarButtonItem112)
            Me.spreadsheetBarController1.BarItems.Add(Me.functionsFinancialItem1)
            Me.spreadsheetBarController1.BarItems.Add(Me.functionsLogicalItem1)
            Me.spreadsheetBarController1.BarItems.Add(Me.functionsTextItem1)
            Me.spreadsheetBarController1.BarItems.Add(Me.functionsDateAndTimeItem1)
            Me.spreadsheetBarController1.BarItems.Add(Me.functionsLookupAndReferenceItem1)
            Me.spreadsheetBarController1.BarItems.Add(Me.functionsMathAndTrigonometryItem1)
            Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarSubItem18)
            Me.spreadsheetBarController1.BarItems.Add(Me.functionsStatisticalItem1)
            Me.spreadsheetBarController1.BarItems.Add(Me.functionsEngineeringItem1)
            Me.spreadsheetBarController1.BarItems.Add(Me.functionsInformationItem1)
            Me.spreadsheetBarController1.BarItems.Add(Me.functionsCompatibilityItem1)
            Me.spreadsheetBarController1.BarItems.Add(Me.functionsWebItem1)
            Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarButtonItem113)
            Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarButtonItem114)
            Me.spreadsheetBarController1.BarItems.Add(Me.definedNameListItem1)
            Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarButtonItem115)
            Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarCheckItem15)
            Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarSubItem19)
            Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarCheckItem16)
            Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarCheckItem17)
            Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarButtonItem116)
            Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarButtonItem117)
            Me.spreadsheetBarController1.Control = Me.spreadsheetControl1
            ' 
            ' spreadsheetCommandBarButtonItem108
            ' 
            Me.spreadsheetCommandBarButtonItem108.CommandName = "FunctionsInsertSum"
            Me.spreadsheetCommandBarButtonItem108.Id = -1
            Me.spreadsheetCommandBarButtonItem108.Name = "spreadsheetCommandBarButtonItem108"
            ' 
            ' spreadsheetCommandBarButtonItem109
            ' 
            Me.spreadsheetCommandBarButtonItem109.CommandName = "FunctionsInsertAverage"
            Me.spreadsheetCommandBarButtonItem109.Id = -1
            Me.spreadsheetCommandBarButtonItem109.Name = "spreadsheetCommandBarButtonItem109"
            ' 
            ' spreadsheetCommandBarButtonItem110
            ' 
            Me.spreadsheetCommandBarButtonItem110.CommandName = "FunctionsInsertCountNumbers"
            Me.spreadsheetCommandBarButtonItem110.Id = -1
            Me.spreadsheetCommandBarButtonItem110.Name = "spreadsheetCommandBarButtonItem110"
            ' 
            ' spreadsheetCommandBarButtonItem111
            ' 
            Me.spreadsheetCommandBarButtonItem111.CommandName = "FunctionsInsertMax"
            Me.spreadsheetCommandBarButtonItem111.Id = -1
            Me.spreadsheetCommandBarButtonItem111.Name = "spreadsheetCommandBarButtonItem111"
            ' 
            ' spreadsheetCommandBarButtonItem112
            ' 
            Me.spreadsheetCommandBarButtonItem112.CommandName = "FunctionsInsertMin"
            Me.spreadsheetCommandBarButtonItem112.Id = -1
            Me.spreadsheetCommandBarButtonItem112.Name = "spreadsheetCommandBarButtonItem112"
            ' 
            ' defaultLookAndFeel1
            ' 
            Me.defaultLookAndFeel1.LookAndFeel.SkinName = "Office 2016 Colorful"
            ' 
            ' Form1
            ' 
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(784, 561)
            Me.Controls.Add(Me.spreadsheetControl1)
            Me.Controls.Add(Me.splitterControl1)
            Me.Controls.Add(Me.splitContainerControl1)
            Me.Controls.Add(Me.ribbonControl1)
            Me.Name = "Form1"
            Me.Ribbon = Me.ribbonControl1
            Me.Text = "Form1"
            CType(Me.commandBarGalleryDropDown2, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.ribbonControl1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.repositoryItemFontEdit1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.repositoryItemSpreadsheetFontSizeEdit1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.commandBarGalleryDropDown1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.repositoryItemPopupGalleryEdit1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.commandBarGalleryDropDown3, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.commandBarGalleryDropDown4, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.commandBarGalleryDropDown5, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.spreadsheetNameBoxControl1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.splitContainerControl1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.splitContainerControl1.ResumeLayout(False)
            CType(Me.spreadsheetBarController1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub

        #End Region

        Private spreadsheetControl1 As DevExpress.XtraSpreadsheet.SpreadsheetControl
        Private ribbonControl1 As DevExpress.XtraBars.Ribbon.RibbonControl
        Private spreadsheetCommandBarButtonItem1 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem
        Private spreadsheetCommandBarButtonItem2 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem
        Private spreadsheetCommandBarButtonItem3 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem
        Private spreadsheetCommandBarButtonItem4 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem
        Private spreadsheetCommandBarButtonItem5 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem
        Private spreadsheetCommandBarButtonItem6 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem
        Private spreadsheetCommandBarButtonItem7 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem
        Private spreadsheetCommandBarButtonItem8 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem
        Private spreadsheetCommandBarButtonItem9 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem
        Private spreadsheetCommandBarButtonItem10 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem
        Private spreadsheetCommandBarButtonItem11 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem
        Private spreadsheetCommandBarButtonItem12 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem
        Private spreadsheetCommandBarButtonItem13 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem
        Private spreadsheetCommandBarButtonItem14 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem
        Private spreadsheetCommandBarButtonItem15 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem
        Private barButtonGroup1 As DevExpress.XtraBars.BarButtonGroup
        Private changeFontNameItem1 As DevExpress.XtraSpreadsheet.UI.ChangeFontNameItem
        Private repositoryItemFontEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemFontEdit
        Private changeFontSizeItem1 As DevExpress.XtraSpreadsheet.UI.ChangeFontSizeItem
        Private repositoryItemSpreadsheetFontSizeEdit1 As DevExpress.XtraSpreadsheet.Design.RepositoryItemSpreadsheetFontSizeEdit
        Private spreadsheetCommandBarButtonItem16 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem
        Private spreadsheetCommandBarButtonItem17 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem
        Private barButtonGroup2 As DevExpress.XtraBars.BarButtonGroup
        Private spreadsheetCommandBarCheckItem1 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarCheckItem
        Private spreadsheetCommandBarCheckItem2 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarCheckItem
        Private spreadsheetCommandBarCheckItem3 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarCheckItem
        Private spreadsheetCommandBarCheckItem4 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarCheckItem
        Private barButtonGroup3 As DevExpress.XtraBars.BarButtonGroup
        Private spreadsheetCommandBarSubItem1 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarSubItem
        Private spreadsheetCommandBarButtonItem18 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem
        Private spreadsheetCommandBarButtonItem19 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem
        Private spreadsheetCommandBarButtonItem20 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem
        Private spreadsheetCommandBarButtonItem21 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem
        Private spreadsheetCommandBarButtonItem22 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem
        Private spreadsheetCommandBarButtonItem23 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem
        Private spreadsheetCommandBarButtonItem24 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem
        Private spreadsheetCommandBarButtonItem25 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem
        Private spreadsheetCommandBarButtonItem26 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem
        Private spreadsheetCommandBarButtonItem27 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem
        Private spreadsheetCommandBarButtonItem28 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem
        Private spreadsheetCommandBarButtonItem29 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem
        Private spreadsheetCommandBarButtonItem30 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem
        Private changeBorderLineColorItem1 As DevExpress.XtraSpreadsheet.UI.ChangeBorderLineColorItem
        Private changeBorderLineStyleItem1 As DevExpress.XtraSpreadsheet.UI.ChangeBorderLineStyleItem
        Private commandBarGalleryDropDown1 As DevExpress.XtraBars.Commands.CommandBarGalleryDropDown
        Private barButtonGroup4 As DevExpress.XtraBars.BarButtonGroup
        Private changeCellFillColorItem1 As DevExpress.XtraSpreadsheet.UI.ChangeCellFillColorItem
        Private changeFontColorItem1 As DevExpress.XtraSpreadsheet.UI.ChangeFontColorItem
        Private barButtonGroup5 As DevExpress.XtraBars.BarButtonGroup
        Private spreadsheetCommandBarCheckItem5 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarCheckItem
        Private spreadsheetCommandBarCheckItem6 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarCheckItem
        Private spreadsheetCommandBarCheckItem7 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarCheckItem
        Private barButtonGroup6 As DevExpress.XtraBars.BarButtonGroup
        Private spreadsheetCommandBarCheckItem8 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarCheckItem
        Private spreadsheetCommandBarCheckItem9 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarCheckItem
        Private spreadsheetCommandBarCheckItem10 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarCheckItem
        Private barButtonGroup7 As DevExpress.XtraBars.BarButtonGroup
        Private spreadsheetCommandBarButtonItem31 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem
        Private spreadsheetCommandBarButtonItem32 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem
        Private spreadsheetCommandBarCheckItem11 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarCheckItem
        Private spreadsheetCommandBarSubItem2 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarSubItem
        Private spreadsheetCommandBarCheckItem12 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarCheckItem
        Private spreadsheetCommandBarButtonItem33 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem
        Private spreadsheetCommandBarButtonItem34 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem
        Private spreadsheetCommandBarButtonItem35 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem
        Private barButtonGroup8 As DevExpress.XtraBars.BarButtonGroup
        Private changeNumberFormatItem1 As DevExpress.XtraSpreadsheet.UI.ChangeNumberFormatItem
        Private repositoryItemPopupGalleryEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemPopupGalleryEdit
        Private barButtonGroup9 As DevExpress.XtraBars.BarButtonGroup
        Private spreadsheetCommandBarSubItem3 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarSubItem
        Private spreadsheetCommandBarButtonItem36 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem
        Private spreadsheetCommandBarButtonItem37 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem
        Private spreadsheetCommandBarButtonItem38 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem
        Private spreadsheetCommandBarButtonItem39 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem
        Private spreadsheetCommandBarButtonItem40 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem
        Private spreadsheetCommandBarButtonItem41 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem
        Private spreadsheetCommandBarButtonItem42 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem
        Private barButtonGroup10 As DevExpress.XtraBars.BarButtonGroup
        Private spreadsheetCommandBarButtonItem43 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem
        Private spreadsheetCommandBarButtonItem44 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem
        Private spreadsheetCommandBarSubItem4 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarSubItem
        Private spreadsheetCommandBarSubItem5 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarSubItem
        Private spreadsheetCommandBarButtonItem45 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem
        Private spreadsheetCommandBarButtonItem46 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem
        Private spreadsheetCommandBarButtonItem47 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem
        Private spreadsheetCommandBarButtonItem48 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem
        Private spreadsheetCommandBarButtonItem49 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem
        Private spreadsheetCommandBarButtonItem50 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem
        Private spreadsheetCommandBarButtonItem51 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem
        Private spreadsheetCommandBarSubItem6 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarSubItem
        Private spreadsheetCommandBarButtonItem52 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem
        Private spreadsheetCommandBarButtonItem53 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem
        Private spreadsheetCommandBarButtonItem54 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem
        Private spreadsheetCommandBarButtonItem55 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem
        Private spreadsheetCommandBarButtonItem56 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem
        Private spreadsheetCommandBarButtonItem57 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem
        Private spreadsheetCommandBarButtonGalleryDropDownItem1 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonGalleryDropDownItem
        Private commandBarGalleryDropDown2 As DevExpress.XtraBars.Commands.CommandBarGalleryDropDown
        Private spreadsheetCommandBarButtonGalleryDropDownItem2 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonGalleryDropDownItem
        Private commandBarGalleryDropDown3 As DevExpress.XtraBars.Commands.CommandBarGalleryDropDown
        Private spreadsheetCommandBarButtonGalleryDropDownItem3 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonGalleryDropDownItem
        Private commandBarGalleryDropDown4 As DevExpress.XtraBars.Commands.CommandBarGalleryDropDown
        Private spreadsheetCommandBarButtonItem58 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem
        Private spreadsheetCommandBarSubItem7 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarSubItem
        Private spreadsheetCommandBarButtonItem59 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem
        Private spreadsheetCommandBarButtonItem60 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem
        Private galleryFormatAsTableItem1 As DevExpress.XtraSpreadsheet.UI.GalleryFormatAsTableItem
        Private commandBarGalleryDropDown5 As DevExpress.XtraBars.Commands.CommandBarGalleryDropDown
        Private galleryChangeStyleItem1 As DevExpress.XtraSpreadsheet.UI.GalleryChangeStyleItem
        Private spreadsheetCommandBarSubItem8 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarSubItem
        Private spreadsheetCommandBarButtonItem61 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem
        Private spreadsheetCommandBarButtonItem62 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem
        Private spreadsheetCommandBarButtonItem63 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem
        Private spreadsheetCommandBarSubItem9 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarSubItem
        Private spreadsheetCommandBarButtonItem64 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem
        Private spreadsheetCommandBarButtonItem65 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem
        Private spreadsheetCommandBarButtonItem66 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem
        Private spreadsheetCommandBarSubItem10 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarSubItem
        Private spreadsheetCommandBarButtonItem67 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem
        Private spreadsheetCommandBarButtonItem68 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem
        Private spreadsheetCommandBarButtonItem69 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem
        Private spreadsheetCommandBarButtonItem70 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem
        Private spreadsheetCommandBarButtonItem71 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem
        Private spreadsheetCommandBarSubItem11 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarSubItem
        Private spreadsheetCommandBarButtonItem72 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem
        Private spreadsheetCommandBarButtonItem73 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem
        Private spreadsheetCommandBarButtonItem74 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem
        Private spreadsheetCommandBarButtonItem75 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem
        Private spreadsheetCommandBarButtonItem76 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem
        Private spreadsheetCommandBarButtonItem77 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem
        Private spreadsheetCommandBarButtonItem78 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem
        Private spreadsheetCommandBarButtonItem79 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem
        Private changeSheetTabColorItem1 As DevExpress.XtraSpreadsheet.UI.ChangeSheetTabColorItem
        Private spreadsheetCommandBarButtonItem80 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem
        Private spreadsheetCommandBarCheckItem13 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarCheckItem
        Private spreadsheetCommandBarButtonItem81 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem
        Private spreadsheetCommandBarSubItem12 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarSubItem
        Private spreadsheetCommandBarButtonItem82 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem
        Private spreadsheetCommandBarButtonItem83 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem
        Private spreadsheetCommandBarButtonItem84 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem
        Private spreadsheetCommandBarButtonItem85 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem
        Private spreadsheetCommandBarButtonItem86 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem
        Private spreadsheetCommandBarSubItem13 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarSubItem
        Private spreadsheetCommandBarButtonItem87 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem
        Private spreadsheetCommandBarButtonItem88 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem
        Private spreadsheetCommandBarButtonItem89 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem
        Private spreadsheetCommandBarButtonItem90 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem
        Private spreadsheetCommandBarSubItem14 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarSubItem
        Private spreadsheetCommandBarButtonItem91 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem
        Private spreadsheetCommandBarButtonItem92 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem
        Private spreadsheetCommandBarButtonItem93 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem
        Private spreadsheetCommandBarButtonItem94 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem
        Private spreadsheetCommandBarButtonItem95 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem
        Private spreadsheetCommandBarButtonItem96 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem
        Private spreadsheetCommandBarSubItem15 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarSubItem
        Private spreadsheetCommandBarButtonItem97 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem
        Private spreadsheetCommandBarButtonItem98 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem
        Private spreadsheetCommandBarCheckItem14 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarCheckItem
        Private spreadsheetCommandBarButtonItem99 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem
        Private spreadsheetCommandBarButtonItem100 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem
        Private spreadsheetCommandBarSubItem16 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarSubItem
        Private spreadsheetCommandBarButtonItem101 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem
        Private spreadsheetCommandBarButtonItem102 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem
        Private spreadsheetCommandBarButtonItem103 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem
        Private spreadsheetCommandBarButtonItem104 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem
        Private spreadsheetCommandBarButtonItem105 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem
        Private spreadsheetCommandBarButtonItem106 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem
        Private spreadsheetCommandBarButtonItem107 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem
        Private spreadsheetCommandBarSubItem17 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarSubItem
        Private functionsFinancialItem1 As DevExpress.XtraSpreadsheet.UI.FunctionsFinancialItem
        Private functionsLogicalItem1 As DevExpress.XtraSpreadsheet.UI.FunctionsLogicalItem
        Private functionsTextItem1 As DevExpress.XtraSpreadsheet.UI.FunctionsTextItem
        Private functionsDateAndTimeItem1 As DevExpress.XtraSpreadsheet.UI.FunctionsDateAndTimeItem
        Private functionsLookupAndReferenceItem1 As DevExpress.XtraSpreadsheet.UI.FunctionsLookupAndReferenceItem
        Private functionsMathAndTrigonometryItem1 As DevExpress.XtraSpreadsheet.UI.FunctionsMathAndTrigonometryItem
        Private spreadsheetCommandBarSubItem18 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarSubItem
        Private functionsStatisticalItem1 As DevExpress.XtraSpreadsheet.UI.FunctionsStatisticalItem
        Private functionsEngineeringItem1 As DevExpress.XtraSpreadsheet.UI.FunctionsEngineeringItem
        Private functionsInformationItem1 As DevExpress.XtraSpreadsheet.UI.FunctionsInformationItem
        Private functionsCompatibilityItem1 As DevExpress.XtraSpreadsheet.UI.FunctionsCompatibilityItem
        Private functionsWebItem1 As DevExpress.XtraSpreadsheet.UI.FunctionsWebItem
        Private spreadsheetCommandBarButtonItem113 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem
        Private spreadsheetCommandBarButtonItem114 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem
        Private definedNameListItem1 As DevExpress.XtraSpreadsheet.UI.DefinedNameListItem
        Private spreadsheetCommandBarButtonItem115 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem
        Private spreadsheetCommandBarCheckItem15 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarCheckItem
        Private spreadsheetCommandBarSubItem19 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarSubItem
        Private spreadsheetCommandBarCheckItem16 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarCheckItem
        Private spreadsheetCommandBarCheckItem17 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarCheckItem
        Private spreadsheetCommandBarButtonItem116 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem
        Private spreadsheetCommandBarButtonItem117 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem
        Private fileRibbonPage1 As DevExpress.XtraSpreadsheet.UI.FileRibbonPage
        Private commonRibbonPageGroup1 As DevExpress.XtraSpreadsheet.UI.CommonRibbonPageGroup
        Private infoRibbonPageGroup1 As DevExpress.XtraSpreadsheet.UI.InfoRibbonPageGroup
        Private homeRibbonPage1 As DevExpress.XtraSpreadsheet.UI.HomeRibbonPage
        Private clipboardRibbonPageGroup1 As DevExpress.XtraSpreadsheet.UI.ClipboardRibbonPageGroup
        Private fontRibbonPageGroup1 As DevExpress.XtraSpreadsheet.UI.FontRibbonPageGroup
        Private alignmentRibbonPageGroup1 As DevExpress.XtraSpreadsheet.UI.AlignmentRibbonPageGroup
        Private numberRibbonPageGroup1 As DevExpress.XtraSpreadsheet.UI.NumberRibbonPageGroup
        Private stylesRibbonPageGroup1 As DevExpress.XtraSpreadsheet.UI.StylesRibbonPageGroup
        Private cellsRibbonPageGroup1 As DevExpress.XtraSpreadsheet.UI.CellsRibbonPageGroup
        Private editingRibbonPageGroup1 As DevExpress.XtraSpreadsheet.UI.EditingRibbonPageGroup
        Private formulasRibbonPage1 As DevExpress.XtraSpreadsheet.UI.FormulasRibbonPage
        Private functionLibraryRibbonPageGroup1 As DevExpress.XtraSpreadsheet.UI.FunctionLibraryRibbonPageGroup
        Private formulaDefinedNamesRibbonPageGroup1 As DevExpress.XtraSpreadsheet.UI.FormulaDefinedNamesRibbonPageGroup
        Private formulaAuditingRibbonPageGroup1 As DevExpress.XtraSpreadsheet.UI.FormulaAuditingRibbonPageGroup
        Private formulaCalculationRibbonPageGroup1 As DevExpress.XtraSpreadsheet.UI.FormulaCalculationRibbonPageGroup
        Private spreadsheetFormulaBarControl1 As DevExpress.XtraSpreadsheet.SpreadsheetFormulaBarControl
        Private spreadsheetNameBoxControl1 As DevExpress.XtraSpreadsheet.SpreadsheetNameBoxControl
        Private splitContainerControl1 As DevExpress.XtraEditors.SplitContainerControl
        Private splitterControl1 As DevExpress.XtraEditors.SplitterControl
        Private spreadsheetBarController1 As DevExpress.XtraSpreadsheet.UI.SpreadsheetBarController
        Private spreadsheetCommandBarButtonItem108 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem
        Private spreadsheetCommandBarButtonItem109 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem
        Private spreadsheetCommandBarButtonItem110 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem
        Private spreadsheetCommandBarButtonItem111 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem
        Private spreadsheetCommandBarButtonItem112 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem
        Private defaultLookAndFeel1 As DevExpress.LookAndFeel.DefaultLookAndFeel
    End Class
End Namespace

