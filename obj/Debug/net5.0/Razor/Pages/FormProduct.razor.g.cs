#pragma checksum "D:\Ref Directive Manipulating\RefDirectXManipulating\Pages\FormProduct.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "51af0b316ea4842db39ccb595b71f61fc5926f2e"
// <auto-generated/>
#pragma warning disable 1591
namespace RefDirecXManipulate.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "D:\Ref Directive Manipulating\RefDirectXManipulating\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Ref Directive Manipulating\RefDirectXManipulating\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\Ref Directive Manipulating\RefDirectXManipulating\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\Ref Directive Manipulating\RefDirectXManipulating\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\Ref Directive Manipulating\RefDirectXManipulating\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\Ref Directive Manipulating\RefDirectXManipulating\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\Ref Directive Manipulating\RefDirectXManipulating\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "D:\Ref Directive Manipulating\RefDirectXManipulating\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "D:\Ref Directive Manipulating\RefDirectXManipulating\_Imports.razor"
using RefDirecXManipulate;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "D:\Ref Directive Manipulating\RefDirectXManipulating\_Imports.razor"
using RefDirecXManipulate.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\Ref Directive Manipulating\RefDirectXManipulating\Pages\FormProduct.razor"
using Entities;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\Ref Directive Manipulating\RefDirectXManipulating\Pages\FormProduct.razor"
using Data;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/productForm")]
    [Microsoft.AspNetCore.Components.RouteAttribute("/productForm/{id}")]
    public partial class FormProduct : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>FormProduct</h3>\r\n");
            __builder.OpenElement(1, "table");
            __builder.OpenElement(2, "tbody");
            __builder.OpenElement(3, "tr");
            __builder.AddMarkupContent(4, "<th>Name</th>\r\n            ");
            __builder.OpenElement(5, "td");
            __builder.OpenElement(6, "input");
            __builder.AddAttribute(7, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 27 "D:\Ref Directive Manipulating\RefDirectXManipulating\Pages\FormProduct.razor"
                                     Name

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(8, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => Name = __value, Name));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(9, "\r\n        ");
            __builder.OpenElement(10, "tr");
            __builder.AddMarkupContent(11, "<th>Price</th>\r\n            ");
            __builder.OpenElement(12, "td");
            __builder.OpenElement(13, "input");
            __builder.AddAttribute(14, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 31 "D:\Ref Directive Manipulating\RefDirectXManipulating\Pages\FormProduct.razor"
                                     Price

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(15, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => Price = __value, Price));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(16, "\r\n        ");
            __builder.OpenElement(17, "tr");
            __builder.AddMarkupContent(18, "<th>Discount</th>\r\n            ");
            __builder.OpenElement(19, "td");
            __builder.OpenElement(20, "input");
            __builder.AddAttribute(21, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 35 "D:\Ref Directive Manipulating\RefDirectXManipulating\Pages\FormProduct.razor"
                                     Discount

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(22, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => Discount = __value, Discount));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(23, "\r\n        ");
            __builder.OpenElement(24, "tr");
            __builder.OpenElement(25, "td");
#nullable restore
#line 39 "D:\Ref Directive Manipulating\RefDirectXManipulating\Pages\FormProduct.razor"
                 if (string.IsNullOrEmpty(Id))
                {

#line default
#line hidden
#nullable disable
            __builder.AddContent(26, 
#nullable restore
#line 40 "D:\Ref Directive Manipulating\RefDirectXManipulating\Pages\FormProduct.razor"
                  Id

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(27, "  ");
            __builder.OpenElement(28, "button");
            __builder.AddAttribute(29, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 40 "D:\Ref Directive Manipulating\RefDirectXManipulating\Pages\FormProduct.razor"
                                        Create

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(30, "Create");
            __builder.CloseElement();
#nullable restore
#line 40 "D:\Ref Directive Manipulating\RefDirectXManipulating\Pages\FormProduct.razor"
                                                               }
                else
                {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(31, "button");
            __builder.AddAttribute(32, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 42 "D:\Ref Directive Manipulating\RefDirectXManipulating\Pages\FormProduct.razor"
                                    Update

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(33, "Modify");
            __builder.CloseElement();
#nullable restore
#line 42 "D:\Ref Directive Manipulating\RefDirectXManipulating\Pages\FormProduct.razor"
                                                           }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(34, "\r\n            ");
            __builder.OpenElement(35, "td");
            __builder.OpenElement(36, "button");
            __builder.AddAttribute(37, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 45 "D:\Ref Directive Manipulating\RefDirectXManipulating\Pages\FormProduct.razor"
                                  Cancel

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(38, "Cancel");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 53 "D:\Ref Directive Manipulating\RefDirectXManipulating\Pages\FormProduct.razor"
                                                                      
[Parameter]
public Product product { get; set; }

[Parameter]
public string Id { get; set; }

private string Name { get; set; }
private decimal Price { get; set; }
private decimal Discount { get; set; }

protected override void OnInitialized()
{
    base.OnInitialized();




#line default
#line hidden
#nullable disable
#nullable restore
#line 72 "D:\Ref Directive Manipulating\RefDirectXManipulating\Pages\FormProduct.razor"
                                                                                          
    if (product != null)
    {
        Name = product.Name;
        Price = product.Price;
        Discount = product.Discount;
    }
    if (Id != null)
    {
        Product product = productService.findById(int.Parse(Id));
        Name = product.Name;
        Price = product.Price;
        Discount = product.Discount;
    }

}

private void Create()
{
    //get the lastest id in server
    List<Product>productList=productService.getAllproducts();
    var Pid = productList.Max(p=>p.Pid)+1;

    Product product = new Product() {
        Pid = Pid,
        Name= Name,
        Price=Price,
        Discount=Discount
    };

    productService.addProduct(product);

    navigationManager.NavigateTo("/");

}

private void Update()
{
    Product product = new Product()
    {
        Pid = int.Parse(Id),
        Name = Name,
        Price = Price,
        Discount = Discount
    };

    productService.updateProduct(product);
}

private void Cancel()
{
    navigationManager.NavigateTo("/");
}

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IProductService productService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager navigationManager { get; set; }
    }
}
#pragma warning restore 1591
