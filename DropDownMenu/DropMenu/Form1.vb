Public Class Form1
    Dim isCollapsed As Boolean = True
    Dim isCollapsed2 As Boolean = True
    Dim isCollapsed3 As Boolean = True
    Dim isCollapsed4 As Boolean = True
    Dim isCollapsed5 As Boolean = True
    Dim isCollapsed6 As Boolean = True
    Dim isCollapsed7 As Boolean = True
    Dim isCollapsed8 As Boolean = True
    Dim isCollapsed9 As Boolean = True
    Dim isCollapsed10 As Boolean = True
    Dim isCollapsed11 As Boolean = True
    Dim isCollapsed12 As Boolean = True



    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DropPanel1.Size = DropPanel1.MinimumSize
        DropPanel2.Size = DropPanel2.MinimumSize
        DropPanel3.Size = DropPanel3.MinimumSize
        CompanyDropPanel.Size = CompanyDropPanel.MinimumSize
        SecurityDropPanel.Size = SecurityDropPanel.MinimumSize
        ImportExportDropPanel.Size = ImportExportDropPanel.MinimumSize
        FinancialCenterDropPanel.Size = ImportExportDropPanel.MinimumSize
        SalesPanel.Size = SalesPanel.MinimumSize
        CustomerReportPanel.Size = CustomerReportPanel.MinimumSize
        InventoryPanel.Size = InventoryPanel.MinimumSize
        VendorReportPanel.Size = VendorReportPanel.MinimumSize
        OthersPanel.Size = OthersPanel.MinimumSize


        PreferencesPanel.Visible = False
        SetupPanel.Visible = False
        ReportPanel.Visible = False


    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If isCollapsed Then
            DropButton1.Image = My.Resources.Arrow_Down
            DropPanel1.Height += 10
            If DropPanel1.Size = DropPanel1.MaximumSize Then
                Timer1.Stop()
                isCollapsed = False
            End If
        Else
            DropButton1.Image = My.Resources.Arrow_Left
            DropPanel1.Height -= 10
            If DropPanel1.Size = DropPanel1.MinimumSize Then
                Timer1.Stop()
                isCollapsed = True
            End If
        End If
    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        If isCollapsed2 Then
            DropButton2.Image = My.Resources.Arrow_Down
            DropPanel2.Height += 10
            If DropPanel2.Size = DropPanel2.MaximumSize Then
                Timer2.Stop()
                isCollapsed2 = False
            End If
        Else
            DropButton2.Image = My.Resources.Arrow_Left
            DropPanel2.Height -= 10
            If DropPanel2.Size = DropPanel2.MinimumSize Then
                Timer2.Stop()
                isCollapsed2 = True
            End If
        End If
    End Sub

    Private Sub Timer3_Tick(sender As Object, e As EventArgs) Handles Timer3.Tick
        If isCollapsed3 Then
            DropButton3.Image = My.Resources.Arrow_Down
            DropPanel3.Height += 10
            If DropPanel3.Size = DropPanel2.MaximumSize Then
                Timer3.Stop()
                isCollapsed3 = False
            End If
        Else
            DropButton3.Image = My.Resources.Arrow_Left
            DropPanel3.Height -= 10
            If DropPanel3.Size = DropPanel2.MinimumSize Then
                Timer3.Stop()
                isCollapsed3 = True
            End If
        End If
    End Sub


    Private Sub Timer4_Tick(sender As Object, e As EventArgs) Handles Timer4.Tick
        If isCollapsed4 Then
            DropButton4.Image = My.Resources.Arrow_Down
            CompanyDropPanel.Height += 10
            If CompanyDropPanel.Size = CompanyDropPanel.MaximumSize Then
                Timer4.Stop()
                isCollapsed4 = False
            End If
        Else
            DropButton4.Image = My.Resources.Arrow_Left
            CompanyDropPanel.Height -= 10
            If CompanyDropPanel.Size = CompanyDropPanel.MinimumSize Then
                Timer4.Stop()
                isCollapsed4 = True
            End If
        End If
    End Sub

    Private Sub Timer5_Tick(sender As Object, e As EventArgs) Handles Timer5.Tick
        If isCollapsed5 Then
            DropButton5.Image = My.Resources.Arrow_Down
            SecurityDropPanel.Height += 10
            If SecurityDropPanel.Size = SecurityDropPanel.MaximumSize Then
                Timer5.Stop()
                isCollapsed5 = False
            End If
        Else
            DropButton5.Image = My.Resources.Arrow_Left
            SecurityDropPanel.Height -= 10
            If SecurityDropPanel.Size = SecurityDropPanel.MinimumSize Then
                Timer5.Stop()
                isCollapsed5 = True
            End If
        End If
    End Sub


    Private Sub Timer6_Tick(sender As Object, e As EventArgs) Handles Timer6.Tick
        If isCollapsed6 Then
            DropButton6.Image = My.Resources.Arrow_Down
            ImportExportDropPanel.Height += 10
            If ImportExportDropPanel.Size = ImportExportDropPanel.MaximumSize Then
                Timer6.Stop()
                isCollapsed6 = False
            End If
        Else
            DropButton6.Image = My.Resources.Arrow_Left
            ImportExportDropPanel.Height -= 10
            If ImportExportDropPanel.Size = ImportExportDropPanel.MinimumSize Then
                Timer6.Stop()
                isCollapsed6 = True
            End If
        End If
    End Sub



    Private Sub Timer7_Tick(sender As Object, e As EventArgs) Handles Timer7.Tick
        If isCollapsed7 Then
            DropButton7.Image = My.Resources.Arrow_Down
            FinancialCenterDropPanel.Height += 10
            If FinancialCenterDropPanel.Size = FinancialCenterDropPanel.MaximumSize Then
                Timer7.Stop()
                isCollapsed7 = False
            End If
        Else
            DropButton7.Image = My.Resources.Arrow_Left
            FinancialCenterDropPanel.Height -= 10
            If FinancialCenterDropPanel.Size = FinancialCenterDropPanel.MinimumSize Then
                Timer7.Stop()
                isCollapsed7 = True
            End If
        End If
    End Sub


    Private Sub Timer8_Tick(sender As Object, e As EventArgs) Handles Timer8.Tick
        If isCollapsed8 Then
            DropButton8.Image = My.Resources.Arrow_Down
            SalesPanel.Height += 10
            If SalesPanel.Size = SalesPanel.MaximumSize Then
                Timer8.Stop()
                isCollapsed8 = False
            End If
        Else
            DropButton8.Image = My.Resources.Arrow_Left
            SalesPanel.Height -= 10
            If SalesPanel.Size = SalesPanel.MinimumSize Then
                Timer8.Stop()
                isCollapsed8 = True
            End If
        End If
    End Sub


    Private Sub Timer9_Tick(sender As Object, e As EventArgs) Handles Timer9.Tick
        If isCollapsed9 Then
            DropButton9.Image = My.Resources.Arrow_Down
            CustomerReportPanel.Height += 10
            If CustomerReportPanel.Size = CustomerReportPanel.MaximumSize Then
                Timer9.Stop()
                isCollapsed9 = False
            End If
        Else
            DropButton9.Image = My.Resources.Arrow_Left
            CustomerReportPanel.Height -= 10
            If CustomerReportPanel.Size = CustomerReportPanel.MinimumSize Then
                Timer9.Stop()
                isCollapsed9 = True
            End If
        End If
    End Sub



    Private Sub Timer10_Tick(sender As Object, e As EventArgs) Handles Timer10.Tick
        If isCollapsed10 Then
            DropButton10.Image = My.Resources.Arrow_Down
            InventoryPanel.Height += 10
            If InventoryPanel.Size = InventoryPanel.MaximumSize Then
                Timer10.Stop()
                isCollapsed10 = False
            End If
        Else
            DropButton10.Image = My.Resources.Arrow_Left
            InventoryPanel.Height -= 10
            If InventoryPanel.Size = InventoryPanel.MinimumSize Then
                Timer10.Stop()
                isCollapsed10 = True
            End If
        End If
    End Sub


    Private Sub Timer11_Tick(sender As Object, e As EventArgs) Handles Timer11.Tick
        If isCollapsed11 Then
            DropButton11.Image = My.Resources.Arrow_Down
            VendorReportPanel.Height += 10
            If VendorReportPanel.Size = VendorReportPanel.MaximumSize Then
                Timer11.Stop()
                isCollapsed11 = False
            End If
        Else
            DropButton11.Image = My.Resources.Arrow_Left
            VendorReportPanel.Height -= 10
            If VendorReportPanel.Size = VendorReportPanel.MinimumSize Then
                Timer11.Stop()
                isCollapsed11 = True
            End If
        End If
    End Sub



    Private Sub Timer12_Tick(sender As Object, e As EventArgs) Handles Timer12.Tick
        If isCollapsed12 Then
            DropButton12.Image = My.Resources.Arrow_Down
            OthersPanel.Height += 10
            If OthersPanel.Size = OthersPanel.MaximumSize Then
                Timer12.Stop()
                isCollapsed12 = False
            End If
        Else
            DropButton12.Image = My.Resources.Arrow_Left
            OthersPanel.Height -= 10
            If OthersPanel.Size = OthersPanel.MinimumSize Then
                Timer12.Stop()
                isCollapsed12 = True
            End If
        End If
    End Sub


    Private Sub DropButton1_Click(sender As Object, e As EventArgs) Handles DropButton1.Click
        isCollapsed2 = False
        isCollapsed3 = False

        Timer1.Start()
        Timer2.Start()
        Timer3.Start()

    End Sub

    Private Sub DropButton2_Click(sender As Object, e As EventArgs) Handles DropButton2.Click
        isCollapsed = False
        isCollapsed3 = False

        Timer1.Start()
        Timer2.Start()
        Timer3.Start()

    End Sub

    Private Sub Button13_Click(sender As Object, e As EventArgs) Handles DropButton3.Click
        isCollapsed = False
        isCollapsed2 = False

        Timer1.Start()
        Timer2.Start()
        Timer3.Start()
    End Sub

    Private Sub DropButton4_Click(sender As Object, e As EventArgs) Handles DropButton4.Click
        isCollapsed5 = False
        isCollapsed6 = False
        isCollapsed7 = False


        Timer4.Start()
        Timer5.Start()
        Timer6.Start()
        Timer7.Start()


    End Sub

    Private Sub DropButton5_Click(sender As Object, e As EventArgs) Handles DropButton5.Click
        isCollapsed4 = False
        isCollapsed6 = False
        isCollapsed7 = False


        Timer4.Start()
        Timer5.Start()
        Timer6.Start()
        Timer7.Start()


    End Sub


    Private Sub DropButton6_Click(sender As Object, e As EventArgs) Handles DropButton6.Click
        isCollapsed4 = False
        isCollapsed5 = False
        isCollapsed7 = False


        Timer4.Start()
        Timer5.Start()
        Timer6.Start()
        Timer7.Start()


    End Sub

    Private Sub DropButton7_Click(sender As Object, e As EventArgs) Handles DropButton7.Click
        isCollapsed4 = False
        isCollapsed5 = False
        isCollapsed6 = False


        Timer4.Start()
        Timer5.Start()
        Timer6.Start()
        Timer7.Start()


    End Sub

    Private Sub DropButton8_Click(sender As Object, e As EventArgs) Handles DropButton8.Click
        isCollapsed9 = False
        isCollapsed10 = False
        isCollapsed11 = False
        isCollapsed12 = False


        Timer8.Start()
        Timer9.Start()
        Timer10.Start()
        Timer11.Start()
        Timer12.Start()


    End Sub

    Private Sub DropButton9_Click(sender As Object, e As EventArgs) Handles DropButton9.Click
        isCollapsed8 = False
        isCollapsed10 = False
        isCollapsed11 = False
        isCollapsed12 = False


        Timer8.Start()
        Timer9.Start()
        Timer10.Start()
        Timer11.Start()
        Timer12.Start()


    End Sub

    Private Sub DropButton10_Click(sender As Object, e As EventArgs) Handles DropButton10.Click
        isCollapsed9 = False
        isCollapsed8 = False
        isCollapsed11 = False
        isCollapsed12 = False


        Timer8.Start()
        Timer9.Start()
        Timer10.Start()
        Timer11.Start()
        Timer12.Start()


    End Sub

    Private Sub DropButton11_Click(sender As Object, e As EventArgs) Handles DropButton11.Click
        isCollapsed9 = False
        isCollapsed10 = False
        isCollapsed8 = False
        isCollapsed12 = False


        Timer8.Start()
        Timer9.Start()
        Timer10.Start()
        Timer11.Start()
        Timer12.Start()


    End Sub


    Private Sub DropButton12_Click(sender As Object, e As EventArgs) Handles DropButton12.Click
        isCollapsed9 = False
        isCollapsed10 = False
        isCollapsed8 = False
        isCollapsed11 = False


        Timer8.Start()
        Timer9.Start()
        Timer10.Start()
        Timer11.Start()
        Timer12.Start()


    End Sub

    Private Sub HeaderMenu_Paint(sender As Object, e As PaintEventArgs) Handles HeaderMenu.Paint

    End Sub

    Private Sub Button18_Click(sender As Object, e As EventArgs) Handles PreferencesBtn.Click

        MainMenu.Visible = False
        SetupPanel.Visible = False
        PreferencesPanel.Visible = True
        ReportPanel.Visible = False


    End Sub

    Private Sub ActivitiesBtn_Click(sender As Object, e As EventArgs) Handles ActivitiesBtn.Click
        MainMenu.Visible = True
        PreferencesPanel.Visible = False
        ReportPanel.Visible = False
        SetupPanel.Visible = False

    End Sub

    Private Sub PrefencesPanel_Paint(sender As Object, e As PaintEventArgs) Handles PreferencesPanel.Paint

    End Sub

    Private Sub Button37_Click(sender As Object, e As EventArgs)
    End Sub

    Private Sub Button20_Click(sender As Object, e As EventArgs) Handles Button20.Click

    End Sub

    Private Sub SetupBtn_Click(sender As Object, e As EventArgs) Handles SetupBtn.Click
        MainMenu.Visible = False
        PreferencesPanel.Visible = False
        SetupPanel.Visible = True
        ReportPanel.Visible = False
    End Sub

    Private Sub InventoryPanel_Paint(sender As Object, e As PaintEventArgs) Handles InventoryPanel.Paint

    End Sub

    Private Sub ReportBtn_Click(sender As Object, e As EventArgs) Handles ReportBtn.Click
        MainMenu.Visible = False
        PreferencesPanel.Visible = False
        ReportPanel.Visible = True
        SetupPanel.Visible = False

    End Sub

    Private Sub Button66_Click(sender As Object, e As EventArgs) Handles Button66.Click

    End Sub

    Private Sub ShortcutPanel_Paint(sender As Object, e As PaintEventArgs) Handles ShortcutPanel.Paint

    End Sub
End Class
