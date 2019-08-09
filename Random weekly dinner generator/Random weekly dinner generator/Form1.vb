Public Class Form1
    Dim recipeNametxt As String = ""
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Label1.Visible = False

        lstRecipes.Items.Add("Terriakyi Chicken wcaliflower rice and vegetables")
        lstRecipes.Items.Add("Burgers")
        lstRecipes.Items.Add("Spagetti")
        lstRecipes.Items.Add("Cranberry Chicken")
        lstRecipes.Items.Add("Tacos")

    End Sub

    Private Sub LstRecipes_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstRecipes.SelectedIndexChanged

        Select Case lstRecipes.SelectedIndex
            Case 0
                recipeNametxt = "Terriakyi Chicken wcaliflower rice and vegetables"
            Case 1
                recipeNametxt = "Burgers"
            Case 2
                recipeNametxt = "Spagetti"
            Case 3
                recipeNametxt = "Cranberry Chicken"
            Case 4
                recipeNametxt = "Tacos"
        End Select

        Label1.Visible = True
        Label1.Text = My.Computer.FileSystem.ReadAllText("C:\Recipes\" & recipeNametxt & ".txt")

    End Sub

    Private Sub BtnCreate_Click(sender As Object, e As EventArgs) Handles btnCreate.Click



    End Sub

    Private Sub BtnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click



    End Sub
End Class
