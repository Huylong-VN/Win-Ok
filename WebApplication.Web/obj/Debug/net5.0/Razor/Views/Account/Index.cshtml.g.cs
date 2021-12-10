#pragma checksum "C:\Users\admin\OneDrive\Tài liệu\Máy tính\Win-Ok\WebApplication.Web\Views\Account\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6ab42cfb5e68774adc5947ad257bc08cf5b929d2"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Account_Index), @"mvc.1.0.view", @"/Views/Account/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6ab42cfb5e68774adc5947ad257bc08cf5b929d2", @"/Views/Account/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"55dcb12be480a17ed0836b14daa9689fbfa158f6", @"/Views/_ViewImports.cshtml")]
    public class Views_Account_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 4 "C:\Users\admin\OneDrive\Tài liệu\Máy tính\Win-Ok\WebApplication.Web\Views\Account\Index.cshtml"
  
    ViewData["Title"] = "Users";
    Layout = "~/Views/Shared/_Layout_admin.cshtml";
    ViewData["head-title"] = "Management User";

#line default
#line hidden
#nullable disable
            DefineSection("Scripts", async() => {
                WriteLiteral(@"
    <script>
        let curruntUserPage = 1;
        function getAllUser(filter, page) {
            curruntUserPage = page;
            $.ajax({
                url: ""https://localhost:5001/api/Users?SkipCount="" + page + ""&MaxResultCount=10&Filter=n"",
                beforeSend: function (xhr) {
                    xhr.setRequestHeader(""Authorization"", ""Bearer "" + user.accessToken);
                },
                type: ""GET"",
                success: response => {
                    renderPagination(response.totalCount, page);
                    let html = """";
                    for (let data of response.items) {
                        html += `<tr>
                                                                            <th scope=""row"">`+ data.userName + `</th>
                                                                                                           <td>`+ data.fullName + `</td>
                                                                                  ");
                WriteLiteral(@"                         <td>`+ data.email + `</td>
                                                                                                           <td>`+ data.phoneNumber + `</td>
                                                                                                            <td class='action-center' scope=""col"">
                                                                                                            <div class=""btn-group"">
                                                                                                                <button type=""button"" class=""btn btn-danger dropdown-toggle"" data-toggle=""dropdown"" aria-expanded=""false"">
                                                                                                                    Action
                                                                                                                </button>
                                                                                  ");
                WriteLiteral(@"                              <div class=""dropdown-menu"">
                                                                                                                    <a class=""dropdown-item"" onclick='showModalUpdate(${JSON.stringify(data)})'>Update</a>
                                                                                                                    <a class=""dropdown-item"" onclick='deleteTopic(${JSON.stringify(data.id)})'>Delete</a>
                                                                                                                    <a class=""dropdown-item"" onclick='roleAssignModal(${JSON.stringify(data.id)})'>Roles Assign</a>
                                                                                                                    <a class=""dropdown-item"" onclick='classAssign(${JSON.stringify(data.id)})' href=""#"">Class Assign</a>
                                                                                                                    <a class=""d");
                WriteLiteral(@"ropdown-item"" onclick=''>Course Assign</a>
                                                                                                                </div>
                                                                                                            </div>
                                                                                                           </td>
                                                                                                           </tr>`;

                    }
                    $(""#body-user"").html(html);
                    $(""#spinLoaded"").hide();
                    $(""#tableuser"").removeClass(""d-none"");
                }
            })
        }
        let maxClass = 10;
        let userClassAssignId;
        function classAssign(id) {
            userClassAssignId = id;
            $(""#classAssign"").modal(""show"");
            getListClass(maxClass);
        }
        function getMore() {
            maxClass += 5;
   ");
                WriteLiteral(@"         getListClass(maxClass);
        }
        let roleAssignUserId;
        function getListClass(max) {
            maxClass = max;
            $.ajax({
                url: ""https://localhost:5001/api/Classes?MaxResultCount="" + maxClass,
                type: ""GET"",
                success: datas => {
                    let htm = ""<option selected value='1'>Choice one Class</option>"";
                    for (let i of datas.items) {
                        if (i.user.length > 0) {
                            for (let j = 0; j < i.user.length; j++) {
                                if (i.user[j].id == userClassAssignId) {
                                    htm += `<option style=""background:red"" disabled value='` + i.id + `'>Class ->> ` + i.name + ` on this user did join </option>`;
                                    break;
                                }
                                else {
                                    if (j == i.user.length - 1) {
                      ");
                WriteLiteral(@"                  htm += `<option value='` + i.id + `'>Join Now -> ` + i.name + `</option>`;
                                        break;
                                    }
                                }
                            }
                        }
                        else {
                            htm += `<option value='` + i.id + `'>Join Now -> ` + i.name + `</option>`;
                        }

                    }
                    $(""#selectClass"").html(htm);
                }
            })
        }
        function assignUser() {
            if (userClassAssignId != null && $(""#selectClass"").val() != 1) {
                $.ajax({
                    url: ""https://localhost:5001/api/Users/ClassAssign"",
                    type: ""POST"",
                    contentType: 'application/json; charset=UTF-8',
                    data: JSON.stringify({ ""userId"": userClassAssignId, ""classId"": $(""#selectClass"").val() }),
                    success: datas => {");
                WriteLiteral(@"
                        swal({
                            title: ""Assign Success"",
                            text: ""Hihi!"",
                            icon: ""success"",
                            type: ""OK""
                        });
                        getListClass(maxClass);
                    }
                })
            }
            else {
                swal({
                    title: ""Plss check again !!"",
                    text: ""Hihi!"",
                    icon: ""success"",
                    type: ""OK""
                })
            }

        }
        function roleAssignModal(data) {
            roleAssignUserId = data;
            $(""#roleAssign"").modal(""show"");
            $.ajax({
                url: ""https://localhost:5001/api/Users/GetListRole"",
                type: ""GET"",
                success: datas => {
                    let html = """";
                    for (let i of datas) {
                        if (i.users.length > 0) {
      ");
                WriteLiteral(@"                      for (let j = 0; j < i.users.length; j++) {
                                if (i.users[j].id == roleAssignUserId) {
                                    html += `<div class=""form-check form-check-inline"">
                                                      <input class=""form-check-input listRole-input"" id=""${i.name}"" type=""checkbox"" value=""${i.id}"" checked>
                                                      <label class=""form-check-label"" for=""inlineCheckbox1"">${i.name}</label>
                                                    </div>`;
                                    break;
                                }
                                else {
                                    if (j == i.users.length - 1) {
                                        html += `<div class=""form-check form-check-inline"">
                                                      <input class=""form-check-input listRole-input"" id=""${i.name}"" type=""checkbox"" value=""${i.id}"">
                  ");
                WriteLiteral(@"                                    <label class=""form-check-label"" for=""inlineCheckbox1"">${i.name}</label>
                                                    </div>`;
                                        break;
                                    }
                                }
                            }
                        }
                        else {
                            html += `<div class=""form-check form-check-inline"">
                                                      <input class=""form-check-input listRole-input"" id=""${i.name}"" type=""checkbox"" value=""${i.id}"">
                                                      <label class=""form-check-label"" for=""inlineCheckbox1"">${i.name}</label>
                                                    </div>`;
                        }
                    }
                    $(""#listrole"").html(html);
                }
            })
        }

        function getListCourse(max) {
            maxClass = max;
       ");
                WriteLiteral(@"     $.ajax({
                url: ""https://localhost:5001/api/Courses?MaxResultCount="" + maxClass,
                type: ""GET"",
                success: datas => {
                    let htm = ""<option selected value='1'>Choice one Course</option>"";
                    for (let i of datas.items) {
                        if (i.user.length > 0) {
                            for (let j = 0; j < i.user.length; j++) {
                                if (i.user[j].id == userClassAssignId) {
                                    htm += `<option style=""background:red"" disabled value='` + i.id + `'>Join Now ->> ` + i.name + ` (Did join) </option>`;
                                    break;
                                }
                                else {
                                    if (j == i.user.length - 1) {
                                        htm += `<option value='` + i.id + `'>Join Now ->> ` + i.name + `</option>`;
                                        break;
              ");
                WriteLiteral(@"                      }
                                }
                            }
                        }
                        else {
                            htm += `<option value='` + i.id + `'>Join Now ->> ` + i.name + `</option>`;
                        }

                    }
                    $(""#selectClass"").html(htm);
                }
            })
        }
        getAllUser('', curruntUserPage);
        function AssignUserApi() {
            const listRoleInput = $("".listRole-input"");
            let roles = { id: roleAssignUserId, Roles: [] };
            for (var i = 0; i < listRoleInput.length; i++) {
                roles.Roles.push({
                    ""id"": listRoleInput.eq(i).attr(""value""),
                    ""name"": listRoleInput.eq(i).attr(""id""),
                    ""selected"": listRoleInput.eq(i).is("":checked"")
                })
            }
            if (roles.Roles != null && roles.id!=null) {
                $.ajax({
                ");
                WriteLiteral(@"    url: ""https://localhost:5001/api/users/roles"",
                    type: ""PUT"",
                    contentType: 'application/json; charset=UTF-8',
                    data: JSON.stringify(roles),
                    success: () => {
                        swal({
                            title: ""Assign Success"",
                            text: ""Hihi!"",
                            icon: ""success"",
                            type: ""OK""
                        });
                    }
                })
            }
        }
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
<table id=""tableuser"" class=""d-none table table-striped table-hover"">
    <thead style="" background: rebeccapurple;"">
        <tr>
            <th scope=""col"">User Name</th>
            <th scope=""col"">Full Name</th>
            <th scope=""col"">Email</th>
            <th scope=""col"">Phone</th>
            <th scope=""col"" class=""text-center"">Action</th>
        </tr>
    </thead>
    <tbody id=""body-user"">
    </tbody>
</table>
<nav aria-label=""Page navigation example"">
    <ul class=""pagination"" id=""paginationTopic"">
    </ul>
</nav>

<div class=""modal fade"" id=""classAssign"" tabindex=""-1"" role=""dialog"" aria-labelledby=""exampleModalLabel""
     aria-hidden=""true"">
    <div class=""modal-dialog"" rol");
            WriteLiteral(@"e=""document"">
        <div class=""modal-content"">
            <div class=""modal-header"">
                <h5 class=""modal-title"" id=""modallabelTopic"">Class Assign</h5>
                <button class=""close"" type=""button"" data-dismiss=""modal"" aria-label=""Close"">
                    <span aria-hidden=""true"">×</span>
                </button>
            </div>
            <div class=""modal-body"">
                <select id=""selectClass"" class=""form-control form-control-sm"">
                </select>
            </div>
            <div class=""modal-footer"">
                <button class=""btn btn-secondary"" type=""button"" data-dismiss=""modal"">Cancel</button>
                <button class=""btn btn-primary"" id=""classAssign"" onclick=""assignUser()"" type=""button"">Assign</button>
            </div>
        </div>
    </div>
</div>

<div class=""modal fade"" id=""roleAssign"" tabindex=""-1"" role=""dialog"" aria-labelledby=""exampleModalLabel""
     aria-hidden=""true"">
    <div class=""modal-dialog"" role=""docum");
            WriteLiteral(@"ent"">
        <div class=""modal-content"">
            <div class=""modal-header"">
                <h5 class=""modal-title"" id=""modallabelTopic"">Role Assign</h5>
                <button class=""close"" type=""button"" data-dismiss=""modal"" aria-label=""Close"">
                    <span aria-hidden=""true"">×</span>
                </button>
            </div>
            <div class=""modal-body"" id=""listrole"">
            </div>
            <div class=""modal-footer"">
                <button class=""btn btn-secondary"" type=""button"" data-dismiss=""modal"">Cancel</button>
                <button class=""btn btn-primary"" id=""classAssign"" onclick=""AssignUserApi()"" type=""button"">Assign</button>
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
