'***********************************************************************
'Copyright 2022 Vijay Sridhara

'Licensed under the Apache License, Version 2.0 (the "License");
'you may not use this file except in compliance with the License.
'You may obtain a copy of the License at

'   http://www.apache.org/licenses/LICENSE-2.0

'Unless required by applicable law or agreed to in writing, software
'distributed under the License is distributed on an "AS IS" BASIS,
'WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
'See the License for the specific language governing permissions and
'limitations under the License.
'***********************************************************************
Module ComFun
    Public SceneBackBrushes As New List(Of Brush)
    Public SceneWidthSmall As Integer = 100
    Public SceneHeightSmall As Integer = 60
    Public SceneWidthMedium As Integer = 160
    Public SceneHeightMedium As Integer = 165
    Public SceneWidthLarge As Integer = 360
    Public SceneHeightLarge As Integer = 340
    Public Const MAX_PAGES = 999
    Public Const MAX_PAGES_LENGTH = 3 'number of characters in a page number
    Public blankimage As Image = New Bitmap(350, 262)
    Enum DisplayType

        Medium = 0
        Small = 1
        Large = 2
    End Enum

    Public titleFont As New Font("Lucida Console", 8, FontStyle.Bold)
    Public textFont2 As New Font("Arial", 8, FontStyle.Regular)
    Public Enum Importance
        None
        Mild
        Moderate
        Important
        VeryMuch
        Final
        Invalid
        Backup
    End Enum
    Public Sub DE(ex As Exception)
        MsgBox(ex.Message, MsgBoxStyle.Critical)
    End Sub
End Module
