#pragma checksum "C:\Users\admin\OneDrive\Tài liệu\Máy tính\Win-Ok\WebApplication.Web\Views\Topic\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ada9b09ba8ed93e3f3bd979101890e07a832205f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Topic_Index), @"mvc.1.0.view", @"/Views/Topic/Index.cshtml")]
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
#line 1 "C:\Users\admin\OneDrive\Tài liệu\Máy tính\Win-Ok\WebApplication.Web\Views\_ViewImports.cshtml"
using WebApplication.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\admin\OneDrive\Tài liệu\Máy tính\Win-Ok\WebApplication.Web\Views\_ViewImports.cshtml"
using WebApplication.Web.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ada9b09ba8ed93e3f3bd979101890e07a832205f", @"/Views/Topic/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"55dcb12be480a17ed0836b14daa9689fbfa158f6", @"/Views/_ViewImports.cshtml")]
    public class Views_Topic_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("addNewTopic"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("enctype", new global::Microsoft.AspNetCore.Html.HtmlString("multipart/form-data"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n    For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860\r\n\r\n");
#nullable restore
#line 4 "C:\Users\admin\OneDrive\Tài liệu\Máy tính\Win-Ok\WebApplication.Web\Views\Topic\Index.cshtml"
  
    ViewData["Title"] = "Topics";
    Layout = "~/Views/Shared/_Layout_admin.cshtml";
    ViewData["head-title"] = "Topic Control";

#line default
#line hidden
#nullable disable
            DefineSection("Scripts", async() => {
                WriteLiteral(@"
    <script>
        let currentPage = 1;
        function getAllTopic(filter, page) {
            let html = """";
            currentPage = page;
            $.ajax({
                url: `https://localhost:5001/api/Topics?SkipCount=${currentPage}&Filter=${filter}`,
                type: ""GET"",
                beforeSend: function (xhr) {
                    xhr.setRequestHeader(""Authorization"", ""Bearer "" + user.accessToken);
                },
                success: datas => {
                    console.log(datas.totalCount)
                    renderPagination(datas.totalCount, page);
                    for (var data of datas.items) {
                        const updateTime = data.updateTime == null ? ""No Time Update"" : moment(data.updateTime).format(""DD/MM/YYYY"");
                        html += `<tr>
                                         <th scope=""row"">`+ data.name + `</th>
                                         <td>`+ data.description + `</td>
                             ");
                WriteLiteral(@"            <td>`+ moment(data.createTime).format(""DD/MM/YYYY"") + `</td>
                                         <td>`+ updateTime + `</td>
                                         <td><img class='image-topic' src=https://localhost:5001/store-image/`+ data.image + ` /></td>
                                         <td class='action-center' scope=""col"">
                                         <div class=""btn-group"">
                                         <button type=""button"" class=""btn btn-danger dropdown-toggle"" data-toggle=""dropdown"" aria-expanded=""false"">
                                         Action
                                         </button>
                                         <div class=""dropdown-menu"">
                                         <a class=""dropdown-item"" onclick='showModalUpdate(${JSON.stringify(data)})'>Update</a>
                                         <a class=""dropdown-item"" onclick='deleteTopic(${JSON.stringify(data.id)})'>Delete</a>
                     ");
                WriteLiteral(@"                    <div class=""dropdown-divider""></div>
                                         </div>
                                         </div>
                                         </td>
                                       </tr>`;
                    }
                    $(""#body-topic"").html(html);
                    $(""#tabletopic"").show();
                    $(""#spinLoaded"").hide();
                }
            })
        }
        getAllTopic('', currentPage);
        console.log(user.accessToken)
        function getListCourse(flag) {
            if (flag == true) {
                $(""#update"").hide();
                $(""#create"").show();
                $(""#modallabelTopic"").text(""Add topic"");
            }
            $.ajax({
                url: ""https://localhost:5001/api/Courses/all?MaxResultCount=100"",
                type: ""GET"",
                beforeSend: function (xhr) {
                    xhr.setRequestHeader(""Authorization"", ""Bearer "" + user.acces");
                WriteLiteral(@"sToken);
                },
                success: response => {
                    console.log(response);
                    let html = ""<option selected></option>"";
                    for (let i of response.items) {
                        html += `<option value='` + i.id + `'>` + i.name + `</option>`
                    }
                    $(""#inputState"").html(html)
                }
            })
        }
        function addNewTopic() {
            var formData = new FormData();
            formData.append('name', $(""#name"").val());
            formData.append('description', $(""#description"").val());
            formData.append('image', $(""#image"")[0].files[0]);
            formData.append('courseId', $(""#inputState"").val());
            $(""#image-cd"").show();
            $.ajax({
                url: `https://localhost:5001/api/Topics`,
                type: ""POST"",
                beforeSend: function (xhr) {
                    xhr.setRequestHeader(""Authorization"", ""Be");
                WriteLiteral(@"arer "" + user.accessToken);
                },
                data: formData,
                success: response => {
                    $(""#createModal"").modal(""hide"");
                    swal({
                        title: ""Create Success"",
                        text: ""Hihi!"",
                        icon: ""success"",
                        type: ""OK""
                    })
                    getAllTopic('', currentPage);
                    $(""#name"").val();
                    $(""#description"").val();
                    $(""#inputState"").val();
                    $(""#image"")[0].files[0];
                },
                cache: false,
                contentType: false,
                processData: false
            })
        }
        let currentValueUpdate;

        function showModalUpdate(data) {
            $(""#create"").hide();
            $(""#update"").show();
            getListCourse(false);
            console.log(""vo"");
            $(""#modallabelTopic"").text");
                WriteLiteral(@"(""Update topic"");
            $(""#createModal"").modal(""show"");
            $(""#name"").val(data.name);
            $(""#description"").val(data.description);
            $(""#image-cd"").hide();
            currentValueUpdate = data;
        }
        function updateTopic(data) {
            const newdata = {
                ""id"": data.id,
                ""name"": $(""#name"").val(),
                ""description"": $(""#description"").val(),
                ""courseId"": $(""#inputState"").val()
            }
            console.log(newdata);
            $.ajax({
                contentType: 'application/json; charset=UTF-8',
                url: `https://localhost:5001/api/Topics`,
                type: ""PUT"",
                beforeSend: function (xhr) {
                    xhr.setRequestHeader(""Authorization"", ""Bearer "" + user.accessToken);
                },
                dataType: ""json"",
                data: JSON.stringify(newdata),
                success: response => {
                    ");
                WriteLiteral(@"$(""#createModal"").modal(""hide"");
                    swal({
                        title: ""Update Success"",
                        text: ""Hihi!"",
                        icon: ""success"",
                        type: ""OK""
                    })
                    getAllTopic('', currentPage);
                    $(""#name"").val();
                    $(""#description"").val();
                    $(""#inputState"").val();
                },
                cache: false,
                processData: false
            })
        }
        function deleteTopic(id) {
            currentIdelete = id;
            $(""#deleteModal"").modal(""show"");
        }
        function confirmDelete() {
            $.ajax({
                url: ""https://localhost:5001/api/Topics/"" + currentIdelete,
                type: ""DELETE"",
                beforeSend: function (xhr) {
                    xhr.setRequestHeader(""Authorization"", ""Bearer "" + user.accessToken);
                },
                success:");
                WriteLiteral(@" response => {
                    swal({
                        title: ""Delete Success"",
                        text: ""Hihi!"",
                        icon: ""success"",
                        type: ""OK""
                    })
                    $(""#deleteModal"").modal(""hide"");
                    getAllTopic('', currentPage);
                }
            })
        }
        let currentIdelete;
       
    </script>
");
            }
            );
            WriteLiteral(@"<h2 onclick=""getListCourse(true)"" data-toggle=""modal"" data-target=""#createModal"">Create</h2>
<div class=""justify-content-center"" style=""display:flex"" id=""spinLoaded"">
    <div class=""spinner-border text-success "" role=""status"">
        <span class=""sr-only"">Loading...</span>
    </div>
</div>
<table id=""tabletopic"" style=""display:none"" class=""table table-striped table-hover"">
    <thead style="" background: rebeccapurple;"">
        <tr>
            <th scope=""col"">Topic Name</th>
            <th scope=""col"">Topic Description</th>
            <th scope=""col"">Create Time</th>
            <th scope=""col"">Update Time</th>
            <th scope=""col"">Topic Image</th>
            <th scope=""col"" class=""text-center"">Action</th>
        </tr>
    </thead>
    <tbody id=""body-topic"">
    </tbody>
</table>
<nav aria-label=""Page navigation example"">
    <ul class=""pagination"" id=""paginationTopic"">
    </ul>
</nav>
 Logout Modal
<div class=""modal fade"" id=""deleteModal"" tabindex=""-1"" role=""dialog"" ");
            WriteLiteral(@"aria-labelledby=""exampleModalLabel""
     aria-hidden=""true"">
    <div class=""modal-dialog"" role=""document"">
        <div class=""modal-content"">
            <div class=""modal-header"">
                <h5 class=""modal-title"" id=""exampleModalLabel"">Do you want delete it ??</h5>
                <button class=""close"" type=""button"" data-dismiss=""modal"" aria-label=""Close"">
                    <span aria-hidden=""true"">×</span>
                </button>
            </div>
            <div class=""modal-body"">
                <h2>Alert!!!!</h2>
            </div>
            <div class=""modal-footer"">
                <button class=""btn btn-secondary"" type=""button"" data-dismiss=""modal"">Cancel</button>
                <button class=""btn btn-danger"" id=""update"" onclick=""confirmDelete()"" type=""button"">Delete</button>
            </div>
        </div>
    </div>
</div>

 Logout Modal
<div class=""modal fade"" id=""createModal"" tabindex=""-1"" role=""dialog"" aria-labelledby=""exampleModalLabel""
     aria-hidde");
            WriteLiteral(@"n=""true"">
    <div class=""modal-dialog"" role=""document"">
        <div class=""modal-content"">
            <div class=""modal-header"">
                <h5 class=""modal-title"" id=""modallabelTopic"">New Topic</h5>
                <button class=""close"" type=""button"" data-dismiss=""modal"" aria-label=""Close"">
                    <span aria-hidden=""true"">×</span>
                </button>
            </div>
            <div class=""modal-body"">
                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ada9b09ba8ed93e3f3bd979101890e07a832205f15622", async() => {
                WriteLiteral(@"
                    <div class=""form-group"">
                        <label for=""name"">Topic Name</label>
                        <input type=""text"" class=""form-control"" id=""name"" aria-describedby=""emailHelp"" placeholder=""Enter email"">
                    </div>
                    <div class=""form-group"">
                        <label for=""description"">Topic Description</label>
                        <input type=""text"" class=""form-control"" id=""description"" placeholder=""Password"">
                    </div>
                    <div class=""form-group"" id=""image-cd"">
                        <label for=""image"">Topic Image</label>
                        <input type=""file"" class=""form-control-file"" id=""image"">
                    </div>
                    <div class=""form-group"">
                        <label for=""inputState"">Course</label>
                        <select id=""inputState"" class=""form-control form-control-sm""></select>
                    </div>
                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
            </div>
            <div class=""modal-footer"">
                <button class=""btn btn-secondary"" type=""button"" data-dismiss=""modal"">Cancel</button>
                <button class=""btn btn-primary"" id=""create"" onclick=""addNewTopic()"" type=""button"">Create</button>
                <button class=""btn btn-primary"" id=""update"" onclick=""updateTopic(currentValueUpdate)"" type=""button"">Update</button>
            </div>
        </div>
    </div>
</div>");
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
