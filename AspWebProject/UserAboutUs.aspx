<%@ Page Title="" Language="C#" MasterPageFile="~/User.Master" AutoEventWireup="true" CodeBehind="UserAboutUs.aspx.cs" Inherits="AspWebProject.UserAboutUs" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <style>
        .section-title {
            font-size: 24px;
            color: #333;
            margin-bottom: 20px;
            text-align: center;
        }

        p {
            font-size: 16px;
            color: #555;
            line-height: 1.5;
        }
    </style>

    <h2 class="section-title">Hakkımızda</h2>
    <br />
    <h3 runat="server" id="aboutus"></h3>
    <br />
    <p>
        Emlak Firması olarak, müşterilerimize en iyi hizmeti sunmayı amaçlıyoruz. Profesyonel ekibimiz ve geniş portföyümüzle, sizlere hayalinizdeki evi bulmanızda yardımcı oluyoruz.
    </p>
    <p>
        Firmamız, yılların verdiği deneyimle müşteri memnuniyetini ön planda tutmaktadır. Sizin ihtiyaçlarınızı anlamak, beklentilerinizi karşılamak ve güvenilir bir emlak deneyimi sağlamak için çalışıyoruz.
    </p>
    <p>
        Uzman ekibimiz, emlak sektöründeki güncel gelişmeleri takip ederek size en doğru bilgileri sunar. Satış, kiralama veya yatırım amaçlı emlak konularında sizleri doğru yönlendirmek için sürekli olarak eğitimlerimize devam ediyoruz.
    </p>
    <p>
        Sizin için en uygun olanı bulmak için taleplerinizi dikkate alıyoruz. Bütçenize, tercihlerinize ve beklentilerinize uygun seçenekler sunarak size en iyi emlak deneyimini yaşatmak için çalışıyoruz.
    </p>
    <p>
        Emlak Firması olarak, sizlere güvenilir, dürüst ve profesyonel hizmet sunmayı taahhüt ediyoruz. Sizleri de ailemize katılmaya ve hayallerinizdeki evi bulmak için bize ulaşmaya davet ediyoruz.
    </p>
</asp:Content>
