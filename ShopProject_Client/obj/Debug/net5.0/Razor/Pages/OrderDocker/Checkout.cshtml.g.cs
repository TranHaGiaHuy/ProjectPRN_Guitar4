#pragma checksum "D:\FA24\PRN231\PRN231_Project\ShopProject\ShopProject_Client\Pages\OrderDocker\Checkout.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "9de35a47bd8d3b8b40404b29a8616527e05bd498284dcec855a93ed79dc4f675"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(ShopProject_Client.Pages.OrderDocker.Pages_OrderDocker_Checkout), @"mvc.1.0.razor-page", @"/Pages/OrderDocker/Checkout.cshtml")]
namespace ShopProject_Client.Pages.OrderDocker
{
    #line hidden
    using global::System;
    using global::System.Collections.Generic;
    using global::System.Linq;
    using global::System.Threading.Tasks;
    using global::Microsoft.AspNetCore.Mvc;
    using global::Microsoft.AspNetCore.Mvc.Rendering;
    using global::Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "D:\FA24\PRN231\PRN231_Project\ShopProject\ShopProject_Client\Pages\_ViewImports.cshtml"
using ShopProject_Client;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"9de35a47bd8d3b8b40404b29a8616527e05bd498284dcec855a93ed79dc4f675", @"/Pages/OrderDocker/Checkout.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"150ef794712bdbf703a2b4e1a92d0672a279ebc56d340f345b6f79b85065e405", @"/Pages/_ViewImports.cshtml")]
    #nullable restore
    public class Pages_OrderDocker_Checkout : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "D:\FA24\PRN231\PRN231_Project\ShopProject\ShopProject_Client\Pages\OrderDocker\Checkout.cshtml"
  
    Layout = "~/Pages/Shared/HomeLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<script>
    $(document).ready(function () {
        var token = sessionStorage.getItem('auToken');
        if (token == null) {
            window.location.href = ""/Error/Error401"";
        }
    });
</script>
<div class=""check"">
    <div class=""container"">
        <div class=""col-md-3 cart-total"">

            <div class=""price-details"">
                <h3>Delivery Address</h3>
                <hr />
                <span>Full Name</span>
                <span class=""total1"" id=""fullname"">ghi tên vào</span>
                <span>Phone</span>
                <span class=""total1"" id=""phone"">ghi tên sdt</span>
                <span>Address</span>
                <span class=""total1"" id=""address"">ghi tên địa chỉ</span>
                <div class=""clearfix""></div>
            </div>
            <hr class=""featurette-divider"">
            <ul class=""total_price"">
                <li class=""last_price""> <h4>TOTAL</h4></li>
                <li class=""last_price""><span id=""order_total"">0.00</span></li>
           ");
            WriteLiteral(@"     <div class=""clearfix""> </div>
            </ul>
            <div class=""clearfix""></div>
            <a class=""order"" href=""#"" id=""checkoutbtn"" onclick=""buy()"">Place Order</a>
        </div>
        <div class=""col-md-9 cart-items"">
            <h1 id=""count""></h1>
            <div class=""footer-table1"">
                <div class=""yl931K"">Product Image</div>
                <div class=""+4E7yJ"">Product Name</div>
                <div class=""pZMZa7"">Quantity</div>
                <div class=""lKFOxX"">Price</div>
            </div>
            
           
            <div class=""cart-header1"" id=""order_list"">
 
                </div>
                <div class=""clearfix""> </div>
        </div>
    </div>
    </div>
<script>

    $(document).ready(function (c) {
        $('.close1').on('click', function (c) {
            $('.cart-header').fadeOut('slow', function (c) {
                $('.cart-header').remove();
            });
        });
    });
</script>
<script>
    $(document).ready(function (c) {
    ");
            WriteLiteral("    $(\'.close2\').on(\'click\', function (c) {\n            $(\'.cart-header2\').fadeOut(\'slow\', function (c) {\n                $(\'.cart-header2\').remove();\n            });\n        });\n    });\n</script>\n<script>\n    const baseUrl = \'");
#nullable restore
#line 76 "D:\FA24\PRN231\PRN231_Project\ShopProject\ShopProject_Client\Pages\OrderDocker\Checkout.cshtml"
                Write(AppUrl.BaseUrl);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"';
    $(document).ready(function () {
        function decodeToken(token) {
            const base64Url = token.split('.')[1];
            const base64 = base64Url.replace(/-/g, '+').replace(/_/g, '/');
            return JSON.parse(atob(base64));
        }
        // Lấy dữ liệu từ biểu mẫu
        var accessToken = sessionStorage.getItem(""auToken"");
        if (accessToken != null) {
            const decodedPayload = decodeToken(accessToken);
            var tokendecode = decodedPayload;
        }
        else {
            tokendecode = null;
        }
        // Truy vấn danh sách mặt hàng trong giỏ hàng
        $.ajax({
            type: ""GET"",
            url: baseUrl + ""Carts/Cart?id="" + tokendecode.UserID, // Thay thế bằng URL thích hợp
            dataType: ""json"",
            headers: {
                'Authorization': 'Bearer ' + accessToken
            },
            success: function (responseData) {
                var x = JSON.stringify(responseData);
                if (x === ""[]"") {
       ");
            WriteLiteral(@"             $(""#checkoutbtn"").hide();
                    var cartItemHtml = `<p style=""font-size: 24px;text-align: center;"">There are no items in your cart.</p>`;
                    $(""#order_list"").append(cartItemHtml);
                }
                else {
                    $.each(responseData, function (index, cartItem) {
                        var cartItemHtml = `
                                                    <div class=""cart-sec simpleCart_shelfItem"">
                                    <div class=""cart-item1 cyc"">
                                            <img src=""/assets/images/${cartItem.productImage}"" class=""img-responsive1"" alt="""" />
                                    </div>
                                    <div class=""cart-item-info1"">
                                        <ul class=""qty1"">
                                            <li>
                                                <p style=""font-weight:700;"">${cartItem.productName}</p>
                                  ");
            WriteLiteral(@"          </li>
                                            <li>
                                                   <p>${cartItem.cartQuantity}</p>
                                            </li>
                                            <li>
                                                <p>${cartItem.price}</p>
                                            </li>
                                        </ul>
                                    </div>
                                    <div class=""clearfix""></div>
                                </div>


                                                                `;
                        $(""#order_list"").append(cartItemHtml);

                    });
                    console.log(""Data loaded successfully!"");
                }
            },
            error: function (error) {
                console.log(error);
                console.error(""AJAX request failed: "" + error);
            }
        });
    });
</script>
<script>
    $(document).re");
            WriteLiteral(@"ady(function () {
        // Lấy giá trị data-id từ nút
        function decodeToken(token) {
            const base64Url = token.split('.')[1];
            const base64 = base64Url.replace(/-/g, '+').replace(/_/g, '/');
            return JSON.parse(atob(base64));
        }
        // Lấy dữ liệu từ biểu mẫu
        var accessToken = sessionStorage.getItem(""auToken"");
        if (accessToken != null) {
            const decodedPayload = decodeToken(accessToken);
            var tokendecode = decodedPayload;
        }
        else {
            tokendecode = null;
        }
        // Đảm bảo rằng URL được định dạng chính xác và trỏ đúng vào điểm cuối API của bạn
        $.ajax({
            url: baseUrl + 'User/' + tokendecode.UserID,
            method: 'GET',
            headers: {
                'Authorization': 'Bearer ' + accessToken
            },
            success: function (data) {
                console.log(data);
                // Cập nhật các trường của biểu mẫu với dữ liệu nhận được
        ");
            WriteLiteral(@"        $('#fullname').text(data.fullName);
                $('#phone').text(data.phone);
                $('#address').text(data.address);
            },
            error: function (error) {
                console.error('Lỗi khi tải dữ liệu: ' + error);
            }
        });
    });
</script>
<script>
    $(document).ready(function () {
        function decodeToken(token) {
            const base64Url = token.split('.')[1];
            const base64 = base64Url.replace(/-/g, '+').replace(/_/g, '/');
            return JSON.parse(atob(base64));
        }
        // Lấy dữ liệu từ biểu mẫu
        var accessToken = sessionStorage.getItem(""auToken"");
        if (accessToken != null) {
            const decodedPayload = decodeToken(accessToken);
            var tokendecode = decodedPayload;
        }
        else {
            tokendecode = null;
        }
        $.ajax({
            url: baseUrl + 'Carts/TotalPrice?id=' + tokendecode.UserID,
            method: 'GET',
            headers: {
              ");
            WriteLiteral(@"  'Authorization': 'Bearer ' + accessToken
            },
            success: function (data) {
                console.log(data);
                var h2Element = document.getElementById(""order_total"");
                h2Element.textContent = data.totalPrice + ""$"";
            },
            error: function (error) {
                console.error('Lỗi khi tải dữ liệu: ' + error);
            }
        });
    });

</script>
<script>
    $(document).ready(function () {
        function decodeToken(token) {
            const base64Url = token.split('.')[1];
            const base64 = base64Url.replace(/-/g, '+').replace(/_/g, '/');
            return JSON.parse(atob(base64));
        }
        // Lấy dữ liệu từ biểu mẫu
        var accessToken = sessionStorage.getItem(""auToken"");
        if (accessToken != null) {
            const decodedPayload = decodeToken(accessToken);
            var tokendecode = decodedPayload;
        }
        else {
            tokendecode = null;
        }
        $.ajax({
        ");
            WriteLiteral(@"    url: baseUrl + 'Carts/CountCart?id=' + tokendecode.UserID,
            method: 'GET',
            headers: {
                'Authorization': 'Bearer ' + accessToken
            },
            success: function (data) {
                console.log(data);
                var h2Element = document.getElementById(""count"");
                h2Element.textContent = ""My Shopping Bag("" + data.count + "")"";
            },
            error: function (jqXHR) {
                if (jqXHR.status === 0) {
                    window.location.href = ""/Error/Error500"";
                } else {
                    // Handle other types of errors
                    console.error(""Other error occurred: "" + jqXHR.status);
                }
            }
        });
    });
</script>
<script src=""assets\libs\sweetalert2\sweetalert2.min.js""></script>

<script src=""https://cdn.jsdelivr.net/npm/sweetalert2@11""></script>
<script src=""assets\js\pages\sweet-alerts.init.js""></script>

<script>
    function buy() {
        // Lấy giá t");
            WriteLiteral(@"rị data-id từ nút
        function decodeToken(token) {
            const base64Url = token.split('.')[1];
            const base64 = base64Url.replace(/-/g, '+').replace(/_/g, '/');
            return JSON.parse(atob(base64));
        }
        // Lấy dữ liệu từ biểu mẫu
        var accessToken = sessionStorage.getItem(""auToken"");
        if (accessToken != null) {
            const decodedPayload = decodeToken(accessToken);
            var tokendecode = decodedPayload;
            $.ajax({
                url: baseUrl + 'Order?id=' + tokendecode.UserID,
                method: 'POST',
                headers: {
                    'Authorization': 'Bearer ' + accessToken
                },
                success: function (data) {
                    swal.fire({
                        icon: 'success',
                        title: 'Purcharse Successfully!',
                        text: 'Do you want to shopping more??',
                    }).then(function () {
                        // Sau khi người dù");
            WriteLiteral(@"ng bấm OK, chuyển trang
                        window.location.href = '/Home/Home';
                    });
                },
                error: function (error) {
                    console.error('Lỗi khi tải dữ liệu: ' + error);
                }
            });
        }
        else {
            tokendecode = null;
        }
        // Đảm bảo rằng URL được định dạng chính xác và trỏ đúng vào điểm cuối API của bạn

    };
</script>");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ShopProject_Client.Pages.OrderDocker.CheckoutModel> Html { get; private set; } = default!;
        #nullable disable
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<ShopProject_Client.Pages.OrderDocker.CheckoutModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<ShopProject_Client.Pages.OrderDocker.CheckoutModel>)PageContext?.ViewData;
        public ShopProject_Client.Pages.OrderDocker.CheckoutModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
