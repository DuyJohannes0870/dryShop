#pragma checksum "D:\.Net\2034\dryShop\eShopSolution.WebApp\Views\Delivery\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5935b421ab6eea9bafa7389047dd12d2b776615b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Delivery_Index), @"mvc.1.0.view", @"/Views/Delivery/Index.cshtml")]
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
#nullable restore
#line 1 "D:\.Net\2034\dryShop\eShopSolution.WebApp\Views\_ViewImports.cshtml"
using eShopSolution.WebApp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\.Net\2034\dryShop\eShopSolution.WebApp\Views\_ViewImports.cshtml"
using eShopSolution.WebApp.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\.Net\2034\dryShop\eShopSolution.WebApp\Views\_ViewImports.cshtml"
using System.Globalization;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5935b421ab6eea9bafa7389047dd12d2b776615b", @"/Views/Delivery/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fbe4547a8cacf5364b9360f7575f19b5b210142f", @"/Views/_ViewImports.cshtml")]
    public class Views_Delivery_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "D:\.Net\2034\dryShop\eShopSolution.WebApp\Views\Delivery\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""span9"" id=""mainCol"">
    <ul class=""breadcrumb"">
        <li><a href=""index.html"">Home</a> <span class=""divider"">/</span></li>
        <li class=""active"">Giao Hàng</li>
    </ul>
    <h3>Thông tin giao hàng</h3>
    <hr class=""soft"" />
    <h4>Chính sách vận chuyển</h4>
    <p>
        <b>Sau khi quý khách đã đặt hàng thành công</b>, đội ngũ Chăm sóc khách hàng của chúng tôi sẽ tiến hành liên hệ theo số điện thoại Bạn cung cấp để xác minh đơn hàng, đồng thời thông báo về thời gian bạn nhận được hàng, kèm theo các thông tin cần thiết khác.
        <br />
        <b>Sau khi quá trình xác minh thành công</b>, đơn hàng sẽ được giao đến quý khách trong khoảng thời gian sau đây: (Các đơn đặt hàng ngoài giờ hành chính sẽ tính thời gian bắt đầu từ sáng ngày hôm sau):
        <br />
        <b>Địa chỉ giao hàng</b> &emsp;&emsp;&emsp;&emsp;&emsp;&emsp; <b>Thời gian giao hàng</b><br />
        Nội thành TP. Hồ Chí Minh &emsp;&emsp;&ensp; 1h-36h sau khi đặt hàng (Nếu quý khách cần giao nhanh v");
            WriteLiteral(@"ui lòng liên hệ hotline: 1900 636 900)<br />
        Ngoại thành TP Hồ Chí Minh &emsp;&nbsp;&ensp; 12h-48h sau khi đặt hàng<br />
        Nội thành các thành phố &emsp;&emsp;&emsp;;&ensp; 1 – 3 ngày làm việc<br />
        Ngoại thành các tỉnh &emsp;&emsp;&emsp;&emsp;&emsp;&nbsp; 3 – 5 ngày sau khi đặt hàng<br />
        Các nước ngoài Việt Nam &emsp;&emsp;&emsp; Vui lòng liên hệ hotline: 1900 636 900 để biết thêm chi tiết<br />
    </p>
    <h4>Tiêu chuẩn Vận Chuyển hàng</h4>
    <p>
        DryShop.vn cung cấp dịch vụ vận chuyển toàn quốc với đồng mức phí 29,000đ. Đối tác vận chuyển hiện là DHL. Lệ phí vận chuyển hoàn toàn do khách hàng chi trả. Lệ phí bao gồm thuế GTGT và phụ cấp xăng dầu tại thời điểm vận chuyển. Thời gian giao hàng trong ngày làm việc (thứ 2 - thứ 7), nhân viên giao nhận sẽ liên hệ qua số điện thoại trước khi giao hàng.
        <br><br>
        - Đối với đơn hàng giao đến thành phố Hồ Chí Minh: đơn hàng sẽ được giao trong ngày nếu được đặt trước 8 giờ sáng cùng ngày. Đơn hàng đặ");
            WriteLiteral(@"t sau 8 giờ sáng sẽ được giao vào ngày hôm sau.
        <br><br>
        - Đối với đơn hàng giao đến trung tâm tỉnh và thành phố khác, thời gian vận chuyển có thể kéo dài ba (3) ngày làm việc.
        <br><br>
        - Đối với đơn hàng giao đến các khu vực ngoại thành và vùng sau vùng xa khác, thời gian vận chuyển tối đa bốn (4) ngày làm việc.
        <br><br>
        Công ty vận chuyển sẽ cố gắng chuyển hàng đến tay người nhận trong ba (3) lần trước khi thông báo việc giao hàng bị thất bại, và khách hàng sẽ phải chịu thanh toán khoản chi phí vận chuyển mới cho lần giao hàng sau. Việc chuyển hàng đến các khu vực xa xôi hẻo lánh (như miền núi cao hay hải đảo), hoặc trong các dịp sale lớn, ngày lễ tết, và thời tiết xấu thì việc vận chuyển sẽ có thể kéo dài thêm ba (3) ngày làm việc.
    </p>
    <h4>Vận chuyển đến nhiều địa chỉ</h4>
                                         <p>
                                             Chúng tôi hiện nay chỉ nhận giao hàng đến một địa chỉ cụ thể cho một đơn hàng xá");
            WriteLiteral(@"c định. Nếu bạn muốn chuyển hàng đến nhiều địa chỉ khác nhau, xin vui lòng tách riêng một cách cụ thể đơn đặt hàng nào được chuyển đến địa chỉ nào.
                                         </p>
    <h4>Hình thức thanh toán </h4>
                                  <p>
                                      <b>COD:</b>&nbsp;Khách hàng trả tiền khi nhận được hàng<br />
                                      <b>CHUYỂN KHOẢN:</b>&nbsp; Khách hàng chuyển khoản đơn hàng qua tài khoản Sacombank <br />
                                      Số tài khoản: 14030209895010<br />
                                      Tên tài khoản: Hoàng Phạm Khương Duy<br />
                                      Ngân hàng thương mại cổ phần Sài Gòn Thương Tín (Sacombank) – CN SÀI GÒN<br />
                                      <b>MOMO:</b>&nbsp;Tài khoản momo: 0337622894
                                  </p>
    
</div>

");
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
