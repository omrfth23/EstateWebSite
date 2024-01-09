<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Register.aspx.cs" Inherits="AspWebProject.Register" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head>
    <title>Bootstrap Example</title>
    <meta charset="utf-8" />
    <meta name="viewport" content="width=device-width, initial-scale=1" />
    <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/3.4.1/css/bootstrap.min.css" />
    <script src="https://ajax.googleapis.com/ajax/libs/jquery/3.6.4/jquery.min.js"></script>
    <script src="https://maxcdn.bootstrapcdn.com/bootstrap/3.4.1/js/bootstrap.min.js"></script>
    <style>
        body {
            background-image: url('https://wallpaperaccess.com/full/3966884.jpg');
            background-size: cover;
            background-position: center;
            background-repeat: no-repeat;
        }

        .container {
            display: flex;
            flex-direction: column;
            align-items: center;
            justify-content: center;
            height: 100vh;
        }

        .form-control {
            width: 250px;
            height: 40px;
            margin-top: 20px;
            background-color: rgba(255, 255, 255, 0.7); /* Opaklık ayarlamak için rgba() kullanılır */
            border: none;
            border-radius: 5px;
            padding: 10px;
            box-shadow: 0 2px 5px rgba(0, 0, 0, 0.2); /* Gölgelendirme efekti */
        }

        .mybutton {
            width: 250px;
            height: 40px;
            margin-top: 20px;
            background-color: royalblue; 
            color: #000; /* Butonun metin rengi */
            border: none;
            border-radius: 5px;
            box-shadow: 0 2px 5px rgba(0, 0, 0, 0.2); 
            transition: background-color 0.3s ease;
        }
        .mybutton:hover {
            background-color: dodgerblue;
        }
    </style>



</head>
<body>

    <div class="container">
        <div style="position: fixed; bottom: 10px; right: 10px; font-size: 12px; color: rgba(255, 255, 255, 0.7);">
            Designed by Ömer Fatih
        </div>
        <div class="background-image"></div>
        <form id="form1" runat="server">
            <h1 style="text-align: center; color: black;">Kayıt Ol</h1>
            <asp:TextBox CssClass="form-control" ID="tboxMail" placeholder="Mailinizi Giriniz" runat="server"></asp:TextBox>
            <asp:TextBox CssClass="form-control" ID="tboxName" placeholder="İsminizi Giriniz" runat="server"></asp:TextBox>
            <asp:TextBox CssClass="form-control" ID="tboxSurname" placeholder="Soyisminizi Giriniz" runat="server"></asp:TextBox>
            <asp:TextBox CssClass="form-control" ID="tboxPassword" placeholder="Şifrenizi Giriniz" runat="server" TextMode="Password"></asp:TextBox>
            <asp:Button CssClass="btn mybutton" ID="Button1" runat="server" Text="Kayıt Ol" OnClick="Button1_Click" />
        </form>
    </div>
</body>
</html>
