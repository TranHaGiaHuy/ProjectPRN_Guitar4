#pragma checksum "D:\FA24\PRN231\PRN231_Project\ShopProject\ShopProject_Client\Pages\CartDocker\Cart.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "3addc56d0d185d594f6e40651832912026127ad083dd9f86bc5a59f251a0c279"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(ShopProject_Client.Pages.CartDocker.Pages_CartDocker_Cart), @"mvc.1.0.razor-page", @"/Pages/CartDocker/Cart.cshtml")]
namespace ShopProject_Client.Pages.CartDocker
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"3addc56d0d185d594f6e40651832912026127ad083dd9f86bc5a59f251a0c279", @"/Pages/CartDocker/Cart.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"150ef794712bdbf703a2b4e1a92d0672a279ebc56d340f345b6f79b85065e405", @"/Pages/_ViewImports.cshtml")]
    #nullable restore
    public class Pages_CartDocker_Cart : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "D:\FA24\PRN231\PRN231_Project\ShopProject\ShopProject_Client\Pages\CartDocker\Cart.cshtml"
  
    Layout = "~/Pages/Shared/HomeLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("<script>\n    $(document).ready(function () {\n        var token = sessionStorage.getItem(\'auToken\');\n        if (token == null) {\n            window.location.href = \"/Error/Error401\";\n        }\n    });\n</script>\n<script>\n    const baseUrl = \'");
#nullable restore
#line 15 "D:\FA24\PRN231\PRN231_Project\ShopProject\ShopProject_Client\Pages\CartDocker\Cart.cshtml"
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
            $.ajax({
                type: ""GET"",
                url: baseUrl + ""Carts/Cart?id="" + tokendecode.UserID, // Thay thế bằng URL thích hợp
                dataType: ""json"",
                headers: {
                    'Authorization': 'Bearer ' + accessToken
                },
                success: function (responseData) {
                    var x = JSON.stringify(responseData);
                    console.log(x);
                    if (x === ""[]"") {
                        $(""#checkoutbtn"").hide();
  ");
            WriteLiteral(@"                      $(""#toal"").hide();
                        var cartItemHtml = `<p style=""    font-size: 28px;text-align: center;"">There are no items in your cart.</p>`;
                        $(""#cartList"").append(cartItemHtml);
                    }
                    else {
                        $.each(responseData, function (index, cartItem) {
                            console.log(""jdsfjkhbsdkf"" + cartItem);
                            var cartItemHtml = `

                                                   <div class=""cart-sec simpleCart_shelfItem"" >
                                                      <div class=""cart-item cyc"">
                                                             <img src=""/assets/images/${cartItem.productImage}"" class=""img-responsive"" alt="""" />
                                                      </div>
                                                      <div class=""cart-item-info"">
                                                         <ul class=""qty"">
      ");
            WriteLiteral(@"                                                      <li>
                                                               <p style=""font-weight:700;"">${cartItem.productName}</p>
                                                            </li>
                                                            <li>
                                                               <div class=""btn-qty"">
                                                                  <div class=""_8Xhu5+ shopee-input-quantity"">
                                                                         <button class=""EOdsa-"" aria-label=""Decrease"" onclick=""subcart(this)"" data-id=""${cartItem.cartId}"">
                                                                        <svg enable-background=""new 0 0 10 10"" viewBox=""0 0 10 10"" x=""0"" y=""0"" class=""shopee-svg-icon"">
                                                                           <polygon points=""4.5 4.5 3.5 4.5 0 4.5 0 5.5 3.5 5.5 4.5 5.5 10 5.5 10 4.5""></polygon>
                  ");
            WriteLiteral(@"                                                      </svg>
                                                                     </button>
                                                                         <input class=""EOdsa- v3H4Zf"" type=""text"" role=""spinbutton"" aria-valuenow=""1"" value=""${cartItem.cartQuantity}"" readonly>
                                                                         <button class=""EOdsa-"" aria-label=""Increase"" onclick=""pluscart(this)"" data-id=""${cartItem.cartId}"">
                                                                        <svg enable-background=""new 0 0 10 10"" viewBox=""0 0 10 10"" x=""0"" y=""0"" class=""shopee-svg-icon icon-plus-sign"">
                                                                           <polygon points=""10 4.5 5.5 4.5 5.5 0 4.5 0 4.5 4.5 0 4.5 0 5.5 4.5 5.5 4.5 10 5.5 10 5.5 5.5 10 5.5""></polygon>
                                                                        </svg>
                                                                    ");
            WriteLiteral(@" </button>
                                                                  </div>
                                                               </div>
                                                            </li>
                                                            <li>
                                                               <p>${cartItem.price}</p>
                                                            </li>
                                                            <li>
                                                                   <div class=""close1""><a href=""#"" onclick=""deletecart(this)"" data-id=""${cartItem.cartId}""><span class=""glyphicon glyphicon-trash iconglyphicon"" aria-hidden=""true""></span></a></div>
                                                            </li>
                                                         </ul>
                                                      </div>
                                                      <div class=""clearfix""></div>
 ");
            WriteLiteral(@"                                                  </div>



                                                            `;
                            $(""#cartList"").append(cartItemHtml);
                        });
                        console.log(""Data loaded successfully!"");
                    }
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
        }
        else {
            tokendecode = null;
        }

        
    });
</script>
<script>
    function deletecart(link) {
        var accessToken = sessionStorage.getItem(""auToken"");
        var dataId = link.getAttribute('data-id');
        $.ajax({
            url: baseUrl+'Carts/' + dataId,
            metho");
            WriteLiteral(@"d: 'DELETE',
            headers: {
                'Authorization': 'Bearer ' + accessToken
            },// Điều này phụ thuộc vào việc bạn muốn thực hiện một thao tác POST hoặc PUT
            success: function (response) {
                console.log(""success"");
                location.reload();
            },
            error: function (error) {
                console.error('Lỗi r: ' + error);
            }
        });
    }
    function pluscart(link) {
        var accessToken = sessionStorage.getItem(""auToken"");
        var dataId = link.getAttribute('data-id');
        $.ajax({
            url: baseUrl + 'Carts/Pluss?id=' + dataId,
            method: 'GET',
            headers: {
                'Authorization': 'Bearer ' + accessToken
            },// Điều này phụ thuộc vào việc bạn muốn thực hiện một thao tác POST hoặc PUT
            success: function (response) {
                console.log(""success"");
                location.reload();
            },
            error: function (error) {
    ");
            WriteLiteral(@"            console.error('Lỗi r: ' + error);
            }
        });
    }
    function subcart(link) {
        var accessToken = sessionStorage.getItem(""auToken"");
        var dataId = link.getAttribute('data-id');
        $.ajax({
            url: baseUrl + 'Carts/Sub?id=' + dataId,
            method: 'GET',
            headers: {
                'Authorization': 'Bearer ' + accessToken
            },// Điều này phụ thuộc vào việc bạn muốn thực hiện một thao tác POST hoặc PUT
            success: function (response) {
                console.log(""success"");
                location.reload();
            },
            error: function (error) {
                console.error('Lỗi r: ' + error);
            }
        });
    }
</script>

<script>
    $(document).ready(function () {
        function decodeToken(token) {
            const base64Url = token.split('.')[1];
            const base64 = base64Url.replace(/-/g, '+').replace(/_/g, '/');
            return JSON.parse(atob(base64));
        }
        ");
            WriteLiteral(@"// Lấy dữ liệu từ biểu mẫu
        var accessToken = sessionStorage.getItem(""auToken"");
        if (accessToken != null) {
            const decodedPayload = decodeToken(accessToken);
            var tokendecode = decodedPayload;
            $.ajax({
                url: baseUrl + 'Carts/TotalPrice?id=' + tokendecode.UserID,
                method: 'GET',
                headers: {
                    'Authorization': 'Bearer ' + accessToken
                },
                success: function (data) {
                    console.log(data);
                    var h2Element = document.getElementById(""cart_total"");
                    h2Element.textContent = data.totalPrice + ""$"";
                },
                error: function (error) {
                    console.error('Lỗi khi tải dữ liệu: ' + error);
                }
            });
        }
        else {
            tokendecode = null;
        }

    });

</script>
<!-- check-out -->
<div class=""check"">
    <div class=""container"">
        <h1 class=");
            WriteLiteral(@"""name-cart"">Shopping Cart</h1>
        <div class=""footer-table"">
            <div class=""yl931K"">Product Image</div>
            <div class=""+4E7yJ"">Product Name</div>
            <div class=""pZMZa7"">Quantity</div>
            <div class=""lKFOxX"">Price</div>
        </div>
        <div class=""cart-header"" id=""cartList"">
        </div>
        <div class=""total-prices1"" id=""toal"">
            <span>Total :</span>
            <span class=""total2"" id=""cart_total"">0</span>
        </div>
        <div class=""checkout"">
            <a class=""order2"" id=""checkoutbtn"" href=""/OrderDocker/Checkout"">Place Order</a>
        </div>

    </div>
    <div class=""clearfix""> </div>
</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ShopProject_Client.Pages.CartDocker.CartModel> Html { get; private set; } = default!;
        #nullable disable
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<ShopProject_Client.Pages.CartDocker.CartModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<ShopProject_Client.Pages.CartDocker.CartModel>)PageContext?.ViewData;
        public ShopProject_Client.Pages.CartDocker.CartModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
