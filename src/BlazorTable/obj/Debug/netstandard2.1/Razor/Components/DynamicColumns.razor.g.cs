#pragma checksum "C:\Users\dawid\Desktop\Great GitHub Cleanup\TaxDashboard\BlazorTable\src\BlazorTable\Components\DynamicColumns.razor" "{8829d00f-11b8-4213-878b-770e8597ac16}" "fe9ff8a201ae26798f76165b81b0e8576210f34b24e78b23fe3d06d1edef5a19"
// <auto-generated/>
#pragma warning disable 1591
namespace 
#nullable restore
#line 1 "C:\Users\dawid\Desktop\Great GitHub Cleanup\TaxDashboard\BlazorTable\src\BlazorTable\Components\DynamicColumns.razor"
           BlazorTable

#line default
#line hidden
#nullable disable
{
    #line default
    using global::System;
    using global::System.Collections.Generic;
    using global::System.Linq;
    using global::System.Threading.Tasks;
#nullable restore
#line 2 "C:\Users\dawid\Desktop\Great GitHub Cleanup\TaxDashboard\BlazorTable\src\BlazorTable\_Imports.razor"
using System.Net.Http

#nullable disable
    ;
#nullable restore
#line 3 "C:\Users\dawid\Desktop\Great GitHub Cleanup\TaxDashboard\BlazorTable\src\BlazorTable\_Imports.razor"
using Microsoft.AspNetCore.Components

#nullable disable
    ;
#nullable restore
#line 4 "C:\Users\dawid\Desktop\Great GitHub Cleanup\TaxDashboard\BlazorTable\src\BlazorTable\_Imports.razor"
using Microsoft.AspNetCore.Components.Web

#line default
#line hidden
#nullable disable
    ;
    #nullable restore
    public partial class DynamicColumns<
#nullable restore
#line 2 "C:\Users\dawid\Desktop\Great GitHub Cleanup\TaxDashboard\BlazorTable\src\BlazorTable\Components\DynamicColumns.razor"
           TableItem

#line default
#line hidden
#nullable disable
    > : global::Microsoft.AspNetCore.Components.ComponentBase
    #nullable disable
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
#nullable restore
#line 4 "C:\Users\dawid\Desktop\Great GitHub Cleanup\TaxDashboard\BlazorTable\src\BlazorTable\Components\DynamicColumns.razor"
 foreach (var propertyInfo in (Type == null ? typeof(TableItem).GetProperties() : Type.GetProperties() ))
{
    if(propertyInfo.PropertyType.MemberType == System.Reflection.MemberTypes.NestedType)
    {

#line default
#line hidden
#nullable disable

            __builder.AddContent(0, "        ");
            __builder.OpenComponent<global::BlazorTable.DynamicColumns<TableItem>>(1);
            __builder.AddAttribute(2, "Type", (object)(global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::System.Type>(
#nullable restore
#line 8 "C:\Users\dawid\Desktop\Great GitHub Cleanup\TaxDashboard\BlazorTable\src\BlazorTable\Components\DynamicColumns.razor"
                                                     propertyInfo.PropertyType

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(3, "Sortable", (object)(global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::System.Boolean>(
#nullable restore
#line 8 "C:\Users\dawid\Desktop\Great GitHub Cleanup\TaxDashboard\BlazorTable\src\BlazorTable\Components\DynamicColumns.razor"
                                                                                          Sortable

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(4, "Filterable", (object)(global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::System.Boolean>(
#nullable restore
#line 8 "C:\Users\dawid\Desktop\Great GitHub Cleanup\TaxDashboard\BlazorTable\src\BlazorTable\Components\DynamicColumns.razor"
                                                                                                                Sortable

#line default
#line hidden
#nullable disable
            )));
            __builder.CloseComponent();
            __builder.AddMarkupContent(5, "\n");
#nullable restore
#line 9 "C:\Users\dawid\Desktop\Great GitHub Cleanup\TaxDashboard\BlazorTable\src\BlazorTable\Components\DynamicColumns.razor"
    } else {

        var member = GenerateMemberExpression<TableItem, object>(propertyInfo);
        

#line default
#line hidden
#nullable disable

            __builder.AddContent(6, "        ");
            __builder.OpenComponent<global::BlazorTable.Column<TableItem>>(7);
            __builder.AddAttribute(8, "Title", (object)(global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::System.String>(
#nullable restore
#line 13 "C:\Users\dawid\Desktop\Great GitHub Cleanup\TaxDashboard\BlazorTable\src\BlazorTable\Components\DynamicColumns.razor"
                                              propertyInfo.Name

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(9, "Type", (object)(global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::System.Type>(
#nullable restore
#line 13 "C:\Users\dawid\Desktop\Great GitHub Cleanup\TaxDashboard\BlazorTable\src\BlazorTable\Components\DynamicColumns.razor"
                                                                       Utilities.GetNonNullableType(propertyInfo.PropertyType)

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(10, "Field", (object)(global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::System.Linq.Expressions.Expression<global::System.Func<TableItem, global::System.Object>>>(
#nullable restore
#line 13 "C:\Users\dawid\Desktop\Great GitHub Cleanup\TaxDashboard\BlazorTable\src\BlazorTable\Components\DynamicColumns.razor"
                                                                                                                                       member

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(11, "Sortable", (object)(global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::System.Boolean>(
#nullable restore
#line 13 "C:\Users\dawid\Desktop\Great GitHub Cleanup\TaxDashboard\BlazorTable\src\BlazorTable\Components\DynamicColumns.razor"
                                                                                                                                                         Sortable

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(12, "Filterable", (object)(global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::System.Boolean>(
#nullable restore
#line 13 "C:\Users\dawid\Desktop\Great GitHub Cleanup\TaxDashboard\BlazorTable\src\BlazorTable\Components\DynamicColumns.razor"
                                                                                                                                                                               Filterable

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(13, "Class", (object)("Class"));
            __builder.AddAttribute(14, "Template", (global::Microsoft.AspNetCore.Components.RenderFragment<TableItem>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(15, "\n                ");
                __builder2.AddContent(16, 
#nullable restore
#line 15 "C:\Users\dawid\Desktop\Great GitHub Cleanup\TaxDashboard\BlazorTable\src\BlazorTable\Components\DynamicColumns.razor"
                 RenderProperty(context, propertyInfo, member.Compile())

#line default
#line hidden
#nullable disable
                );
                __builder2.AddMarkupContent(17, "\n            ");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(18, "\n");
#nullable restore
#line 18 "C:\Users\dawid\Desktop\Great GitHub Cleanup\TaxDashboard\BlazorTable\src\BlazorTable\Components\DynamicColumns.razor"
    }
}

#line default
#line hidden
#nullable disable

        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
