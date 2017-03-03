Partial Public Class frmSincroDOCDir
    Inherits DevExpress.XtraEditors.XtraForm

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
        Dim SerializableAppearanceObject1 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Dim SerializableAppearanceObject2 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Dim SerializableAppearanceObject3 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Dim SerializableAppearanceObject4 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSincroDOCDir))
        Me.fswVerArquivos = New System.IO.FileSystemWatcher()
        Me.txtConEdt = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.cmdConVer = New DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit()
        Me.cmdConDow = New DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit()
        Me.RepositoryItemTextEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.RepositoryItemButtonEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit()
        Me.RepositoryItemButtonEdit2 = New DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit()
        Me.GaugeControl1 = New DevExpress.XtraGauges.Win.GaugeControl()
        Me.DigitalGauge1 = New DevExpress.XtraGauges.Win.Gauges.Digital.DigitalGauge()
        Me.dblContador = New DevExpress.XtraGauges.Win.Gauges.Digital.DigitalBackgroundLayerComponent()
        Me.DigitalEffectLayerComponent1 = New DevExpress.XtraGauges.Win.Gauges.Digital.DigitalEffectLayerComponent()
        Me.ImageIndicatorComponent1 = New DevExpress.XtraGauges.Win.Base.ImageIndicatorComponent()
        Me.LabelComponent1 = New DevExpress.XtraGauges.Win.Base.LabelComponent()
        Me.LabelComponent2 = New DevExpress.XtraGauges.Win.Base.LabelComponent()
        Me.lblLocal = New DevExpress.XtraEditors.LabelControl()
        Me.lblDepartamento = New DevExpress.XtraEditors.LabelControl()
        CType(Me.fswVerArquivos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtConEdt, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmdConVer, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmdConDow, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemTextEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemButtonEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemButtonEdit2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DigitalGauge1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dblContador, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DigitalEffectLayerComponent1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ImageIndicatorComponent1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LabelComponent1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LabelComponent2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'fswVerArquivos
        '
        Me.fswVerArquivos.EnableRaisingEvents = True
        Me.fswVerArquivos.SynchronizingObject = Me
        '
        'txtConEdt
        '
        Me.txtConEdt.AutoHeight = False
        Me.txtConEdt.Name = "txtConEdt"
        '
        'cmdConVer
        '
        Me.cmdConVer.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, True, True, False, DevExpress.XtraEditors.ImageLocation.MiddleCenter, CType(resources.GetObject("cmdConVer.Buttons"), System.Drawing.Image), New DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), SerializableAppearanceObject1, "Abrir com aplicativo de origem...", Nothing, Nothing, True)})
        Me.cmdConVer.Name = "cmdConVer"
        Me.cmdConVer.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor
        '
        'cmdConDow
        '
        Me.cmdConDow.AutoHeight = False
        Me.cmdConDow.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, True, True, False, DevExpress.XtraEditors.ImageLocation.MiddleCenter, CType(resources.GetObject("cmdConDow.Buttons"), System.Drawing.Image), New DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), SerializableAppearanceObject2, "Fazer download do arquivo...", Nothing, Nothing, True)})
        Me.cmdConDow.Name = "cmdConDow"
        Me.cmdConDow.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor
        '
        'RepositoryItemTextEdit1
        '
        Me.RepositoryItemTextEdit1.AutoHeight = False
        Me.RepositoryItemTextEdit1.Name = "RepositoryItemTextEdit1"
        '
        'RepositoryItemButtonEdit1
        '
        Me.RepositoryItemButtonEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, True, True, False, DevExpress.XtraEditors.ImageLocation.MiddleCenter, CType(resources.GetObject("RepositoryItemButtonEdit1.Buttons"), System.Drawing.Image), New DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), SerializableAppearanceObject3, "Abrir com aplicativo de origem...", Nothing, Nothing, True)})
        Me.RepositoryItemButtonEdit1.Name = "RepositoryItemButtonEdit1"
        Me.RepositoryItemButtonEdit1.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor
        '
        'RepositoryItemButtonEdit2
        '
        Me.RepositoryItemButtonEdit2.AutoHeight = False
        Me.RepositoryItemButtonEdit2.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, True, True, False, DevExpress.XtraEditors.ImageLocation.MiddleCenter, CType(resources.GetObject("RepositoryItemButtonEdit2.Buttons"), System.Drawing.Image), New DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), SerializableAppearanceObject4, "Fazer download do arquivo...", Nothing, Nothing, True)})
        Me.RepositoryItemButtonEdit2.Name = "RepositoryItemButtonEdit2"
        Me.RepositoryItemButtonEdit2.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor
        '
        'GaugeControl1
        '
        Me.GaugeControl1.AutoLayout = False
        Me.GaugeControl1.BackColor = System.Drawing.Color.Transparent
        Me.GaugeControl1.BackgroundImage = Global.SincroDOCDIR.My.Resources.Resources.P0
        Me.GaugeControl1.Gauges.AddRange(New DevExpress.XtraGauges.Base.IGauge() {Me.DigitalGauge1})
        Me.GaugeControl1.Location = New System.Drawing.Point(12, 12)
        Me.GaugeControl1.Name = "GaugeControl1"
        Me.GaugeControl1.Size = New System.Drawing.Size(621, 68)
        Me.GaugeControl1.TabIndex = 0
        '
        'DigitalGauge1
        '
        Me.DigitalGauge1.AppearanceOff.ContentBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:#0D8097")
        Me.DigitalGauge1.AppearanceOn.ContentBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:#02F0F7")
        Me.DigitalGauge1.BackgroundLayers.AddRange(New DevExpress.XtraGauges.Win.Gauges.Digital.DigitalBackgroundLayerComponent() {Me.dblContador})
        Me.DigitalGauge1.Bounds = New System.Drawing.Rectangle(6, 6, 608, 56)
        Me.DigitalGauge1.DigitCount = 6
        Me.DigitalGauge1.EffectLayers.AddRange(New DevExpress.XtraGauges.Win.Gauges.Digital.DigitalEffectLayerComponent() {Me.DigitalEffectLayerComponent1})
        Me.DigitalGauge1.Images.AddRange(New DevExpress.XtraGauges.Win.Base.ImageIndicatorComponent() {Me.ImageIndicatorComponent1})
        Me.DigitalGauge1.Labels.AddRange(New DevExpress.XtraGauges.Win.Base.LabelComponent() {Me.LabelComponent1, Me.LabelComponent2})
        Me.DigitalGauge1.Name = "DigitalGauge1"
        Me.DigitalGauge1.Padding = New DevExpress.XtraGauges.Core.Base.TextSpacing(26, 20, 26, 20)
        Me.DigitalGauge1.Text = "00,000"
        '
        'dblContador
        '
        Me.dblContador.BottomRight = New DevExpress.XtraGauges.Core.Base.PointF2D(313.775!, 99.9625!)
        Me.dblContador.Name = "digitalBackgroundLayerComponent1"
        Me.dblContador.Shader = New DevExpress.XtraGauges.Core.Drawing.OpacityShader("")
        Me.dblContador.ShapeType = DevExpress.XtraGauges.Core.Model.DigitalBackgroundShapeSetType.Style17
        Me.dblContador.TopLeft = New DevExpress.XtraGauges.Core.Base.PointF2D(26.0!, 0!)
        Me.dblContador.ZOrder = 1000
        '
        'DigitalEffectLayerComponent1
        '
        Me.DigitalEffectLayerComponent1.BottomRight = New DevExpress.XtraGauges.Core.Base.PointF2D(608.0!, 56.0!)
        Me.DigitalEffectLayerComponent1.Name = "DigitalGauge1_EffectLayer1"
        Me.DigitalEffectLayerComponent1.ShapeType = DevExpress.XtraGauges.Core.Model.DigitalEffectShapeType.Empty
        Me.DigitalEffectLayerComponent1.ZOrder = -1000
        '
        'ImageIndicatorComponent1
        '
        Me.ImageIndicatorComponent1.Name = "DigitalGauge1_ImageIndicator1"
        Me.ImageIndicatorComponent1.ZOrder = -1001
        '
        'LabelComponent1
        '
        Me.LabelComponent1.AppearanceText.TextBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:Black")
        Me.LabelComponent1.Name = "DigitalGauge1_Label1"
        Me.LabelComponent1.Position = New DevExpress.XtraGauges.Core.Base.PointF2D(125.0!, 50.0!)
        Me.LabelComponent1.Text = "DigitalGauge1_Label1"
        Me.LabelComponent1.ZOrder = -1001
        '
        'LabelComponent2
        '
        Me.LabelComponent2.AppearanceText.TextBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:Black")
        Me.LabelComponent2.Name = "DigitalGauge1_Label2"
        Me.LabelComponent2.Position = New DevExpress.XtraGauges.Core.Base.PointF2D(125.0!, 50.0!)
        Me.LabelComponent2.Text = "DigitalGauge1_Label2"
        Me.LabelComponent2.ZOrder = -1001
        '
        'lblLocal
        '
        Me.lblLocal.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.lblLocal.Appearance.Options.UseFont = True
        Me.lblLocal.Appearance.Options.UseTextOptions = True
        Me.lblLocal.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.lblLocal.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.lblLocal.Location = New System.Drawing.Point(46, 86)
        Me.lblLocal.Name = "lblLocal"
        Me.lblLocal.ShowLineShadow = False
        Me.lblLocal.Size = New System.Drawing.Size(587, 13)
        Me.lblLocal.TabIndex = 1
        Me.lblLocal.Text = "\\mcbmsmng02.magna.global\DFS\Interactivity\Scanner\Diretoria"
        '
        'lblDepartamento
        '
        Me.lblDepartamento.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.lblDepartamento.Appearance.Options.UseFont = True
        Me.lblDepartamento.Appearance.Options.UseTextOptions = True
        Me.lblDepartamento.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.lblDepartamento.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.lblDepartamento.Location = New System.Drawing.Point(12, 86)
        Me.lblDepartamento.Name = "lblDepartamento"
        Me.lblDepartamento.ShowLineShadow = False
        Me.lblDepartamento.Size = New System.Drawing.Size(28, 13)
        Me.lblDepartamento.TabIndex = 2
        Me.lblDepartamento.Text = "5"
        '
        'frmSincroDOCDir
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(645, 105)
        Me.Controls.Add(Me.lblDepartamento)
        Me.Controls.Add(Me.lblLocal)
        Me.Controls.Add(Me.GaugeControl1)
        Me.FormBorderEffect = DevExpress.XtraEditors.FormBorderEffect.None
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmSincroDOCDir"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "SincroDOC Diretorio"
        Me.TopMost = True
        CType(Me.fswVerArquivos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtConEdt, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmdConVer, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmdConDow, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemTextEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemButtonEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemButtonEdit2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DigitalGauge1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dblContador, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DigitalEffectLayerComponent1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ImageIndicatorComponent1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LabelComponent1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LabelComponent2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents fswVerArquivos As IO.FileSystemWatcher
    Friend WithEvents txtConEdt As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents cmdConVer As DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit
    Friend WithEvents cmdConDow As DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit
    Friend WithEvents RepositoryItemTextEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents RepositoryItemButtonEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit
    Friend WithEvents RepositoryItemButtonEdit2 As DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit
    Friend WithEvents lblLocal As DevExpress.XtraEditors.LabelControl
    Friend WithEvents GaugeControl1 As DevExpress.XtraGauges.Win.GaugeControl
    Friend WithEvents DigitalGauge1 As DevExpress.XtraGauges.Win.Gauges.Digital.DigitalGauge
    Private WithEvents dblContador As DevExpress.XtraGauges.Win.Gauges.Digital.DigitalBackgroundLayerComponent
    Private WithEvents DigitalEffectLayerComponent1 As DevExpress.XtraGauges.Win.Gauges.Digital.DigitalEffectLayerComponent
    Private WithEvents ImageIndicatorComponent1 As DevExpress.XtraGauges.Win.Base.ImageIndicatorComponent
    Private WithEvents LabelComponent1 As DevExpress.XtraGauges.Win.Base.LabelComponent
    Private WithEvents LabelComponent2 As DevExpress.XtraGauges.Win.Base.LabelComponent
    Friend WithEvents lblDepartamento As DevExpress.XtraEditors.LabelControl

#End Region

End Class
