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
Public Class AboutDSB
    Private Sub AboutDSB_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label1.Text = My.Application.Info.ProductName
        Label2.Text = My.Application.Info.Version.ToString
        Label3.Text = My.Application.Info.Description
    End Sub
End Class