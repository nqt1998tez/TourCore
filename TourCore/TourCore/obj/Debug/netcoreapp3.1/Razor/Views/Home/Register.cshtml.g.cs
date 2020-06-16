#pragma checksum "C:\Users\Tan\source\repos\TourCore\TourCore\TourCore\Views\Home\Register.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e85cb0673be5ab4b176fb705d05591a46af723b6"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Register), @"mvc.1.0.view", @"/Views/Home/Register.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e85cb0673be5ab4b176fb705d05591a46af723b6", @"/Views/Home/Register.cshtml")]
    public class Views_Home_Register : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<!DOCTYPE html>\r\n<html lang=\"en\">\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e85cb0673be5ab4b176fb705d05591a46af723b62735", async() => {
                WriteLiteral(@"
    <title>Login V16</title>
    <meta charset=""UTF-8"">
    <meta name=""viewport"" content=""width=device-width, initial-scale=1"">
    <!--===============================================================================================-->
    <link rel=""icon"" type=""image/png"" href=""/form_login/images/icons/favicon.ico"" />
    <!--===============================================================================================-->
    <link rel=""stylesheet"" type=""text/css"" href=""/form_login/vendor/bootstrap/css/bootstrap.min.css"">
    <!--===============================================================================================-->
    <link rel=""stylesheet"" type=""text/css"" href=""/form_login/fonts/font-awesome-4.7.0/css/font-awesome.min.css"">
    <!--===============================================================================================-->
    <link rel=""stylesheet"" type=""text/css"" href=""/form_login/fonts/Linearicons-Free-v1.0.0/icon-font.min.css"">
    <!--===================================");
                WriteLiteral(@"============================================================-->
    <link rel=""stylesheet"" type=""text/css"" href=""/form_login/vendor/animate/animate.css"">
    <!--===============================================================================================-->
    <link rel=""stylesheet"" type=""text/css"" href=""/form_login/vendor/css-hamburgers/hamburgers.min.css"">
    <!--===============================================================================================-->
    <link rel=""stylesheet"" type=""text/css"" href=""/form_login/vendor/animsition/css/animsition.min.css"">
    <!--===============================================================================================-->
    <link rel=""stylesheet"" type=""text/css"" href=""/form_login/vendor/select2/select2.min.css"">
    <!--===============================================================================================-->
    <link rel=""stylesheet"" type=""text/css"" href=""/form_login/vendor/daterangepicker/daterangepicker.css"">
    <!--================");
                WriteLiteral(@"===============================================================================-->
    <link rel=""stylesheet"" type=""text/css"" href=""/form_login/css/util.css"">
    <link rel=""stylesheet"" type=""text/css"" href=""/form_login/css/main.css"">
    <!--===============================================================================================-->
");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e85cb0673be5ab4b176fb705d05591a46af723b66236", async() => {
                WriteLiteral(@"
    <div class=""limiter"">
        <div class=""container-login100"" style=""background-image: url('/form_login/images/bg-01.jpg')"">
            <div class=""wrap-login100 p-t-30 p-b-50"">
                <span class=""login100-form-title p-b-41"">
                    Đăng kí
                </span>
");
#nullable restore
#line 38 "C:\Users\Tan\source\repos\TourCore\TourCore\TourCore\Views\Home\Register.cshtml"
                 using (Html.BeginForm("Register", "Home", FormMethod.Post, new { @class = "login100-form validate-form p-b-33 p-t-5" }))
                {


#line default
#line hidden
#nullable disable
                WriteLiteral(@"                        <div class=""wrap-input100 validate-input"" data-validate=""Enter username"">
                            <input class=""input100"" type=""text"" name=""Username"" placeholder=""Tài khoản"" id=""txtUsername"">
                            <span class=""focus-input100"" data-placeholder=""&#xe82a;""></span>
                        </div>
                        <div class=""wrap-input100 validate-input"" data-validate=""Enter password"">
                            <input class=""input100"" type=""password"" name=""Password"" placeholder=""Mật khẩu"">
                            <span class=""focus-input100"" data-placeholder=""&#xe80f;""></span>
                        </div>
                        <div class=""wrap-input100 validate-input"" data-validate=""Enter password"">
                            <input class=""input100"" type=""text"" name=""Email"" placeholder=""Email"">
                            <span class=""focus-input100"" data-placeholder=""&#xe80f;""></span>
                        </div>
");
                WriteLiteral(@"                        <div class=""container-login100-form-btn m-t-32"">
                            <button class=""login100-form-btn"" type=""submit"" id=""btnRegister"">
                                Đăng kí
                            </button>
                        </div>
");
#nullable restore
#line 59 "C:\Users\Tan\source\repos\TourCore\TourCore\TourCore\Views\Home\Register.cshtml"
                }

#line default
#line hidden
#nullable disable
                WriteLiteral(@"            </div>
        </div>
    </div>


    <div id=""dropDownSelect1""></div>

    <!--===============================================================================================-->
    <script src=""/form_login/vendor/jquery/jquery-3.2.1.min.js""></script>
    <!--===============================================================================================-->
    <script src=""/form_login/vendor/animsition/js/animsition.min.js""></script>
    <!--===============================================================================================-->
    <script src=""/form_login/vendor/bootstrap/js/popper.js""></script>
    <script src=""/form_login/vendor/bootstrap/js/bootstrap.min.js""></script>
    <!--===============================================================================================-->
    <script src=""/form_login/vendor/select2/select2.min.js""></script>
    <!--===============================================================================================-->
    <script src=""");
                WriteLiteral(@"/form_login/vendor/daterangepicker/moment.min.js""></script>
    <script src=""/form_login/vendor/daterangepicker/daterangepicker.js""></script>
    <!--===============================================================================================-->
    <script src=""/form_login/vendor/countdowntime/countdowntime.js""></script>
    <!--===============================================================================================-->
    <script src=""/form_login/js/main.js""></script>
    <script>
        $(""#btnRegister"").click(function ()
        {
            var check = $(""#txtUsername"").val();
            if (check < 0) {
                alert(""Vui long nhap tai khoan"");
                return false;
            }
        });
    </script>

");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</html>");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
