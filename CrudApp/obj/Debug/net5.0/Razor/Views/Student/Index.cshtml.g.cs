#pragma checksum "C:\Users\TE\Downloads\Sanjay\CrudApp\CrudApp\Views\Student\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5804d057cd1a51d555101ded1d558c81c3a61cc3"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Student_Index), @"mvc.1.0.view", @"/Views/Student/Index.cshtml")]
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
#line 1 "C:\Users\TE\Downloads\Sanjay\CrudApp\CrudApp\Views\_ViewImports.cshtml"
using CrudApp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\TE\Downloads\Sanjay\CrudApp\CrudApp\Views\_ViewImports.cshtml"
using CrudApp.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5804d057cd1a51d555101ded1d558c81c3a61cc3", @"/Views/Student/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"679f7a082400a522713084afbc4e02258cbbcd25", @"/Views/_ViewImports.cshtml")]
    public class Views_Student_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<CrudApp.Models.Student>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\TE\Downloads\Sanjay\CrudApp\CrudApp\Views\Student\Index.cshtml"
  
    ViewBag.Title = "Student CRUD";
    Layout = "_Layout";

#line default
#line hidden
#nullable disable
            WriteLiteral(@" 
<script src=""https://cdn.jsdelivr.net/npm/sweetalert2@11""></script>

<link rel=""stylesheet"" href=""https://maxcdn.bootstrapcdn.com/bootstrap/3.4.1/css/bootstrap.min.css"">
<link rel=""stylesheet"" href=""https://cdn.datatables.net/1.13.4/css/jquery.dataTables.css"" />

<script src=""https://ajax.googleapis.com/ajax/libs/jquery/3.6.3/jquery.min.js""></script>
<script src=""https://maxcdn.bootstrapcdn.com/bootstrap/3.4.1/js/bootstrap.min.js""></script>
<script src=""https://cdn.datatables.net/1.13.4/js/jquery.dataTables.js""></script>
<link rel=""stylesheet"" type=""text/css"" href=""https://cdnjs.cloudflare.com/ajax/libs/bootbox.js/5.5.2/bootbox.min.css"">
<script src=""https://cdnjs.cloudflare.com/ajax/libs/bootbox.js/5.5.2/bootbox.min.js""></script>

<link rel=""stylesheet"" href=""https://cdnjs.cloudflare.com/ajax/libs/font-awesome/6.4.0/css/all.min.css"" integrity=""sha512-iecdLmaskl7CVkqkXNQ/ZH/XLlvWZOJyj7Yy7tcenmpD1ypASozpmT/E0iPtmFIB46ZmdtAc9eNBvH0H/ZpiBw=="" crossorigin=""anonymous"" referrerpolicy=""no-referrer"" />");
            WriteLiteral(@"
<div class=""container"">
    <button type=""button"" class=""btn btn-success"" style=""margin-bottom: 10px""  data-toggle=""modal"" data-target=""#myModal""><i class=""fa fa-plus""></i>Add Student</button>
    <br />
    <div>
        <table id=""dataTable"" class=""table table-striped dt-responsive nowrap"" width=""100%"" cellspacing=""0"">
            <thead>
                <tr>
                    <th>StudentID</th>
                    <th>Name</th>
                    <th>Email</th>
                    <th>City</th>
                    <th colspan=""2"" class=""text-center"">Action</th>
                </tr>
            </thead>
        </table>
    </div>
</div>

 
");
            WriteLiteral(@"<div class=""modal fade"" id=""myModal"" role=""dialog"">
    <div class=""modal-dialog"">

        <div class=""modal-content"">
            <div class=""modal-header"">
                <button type=""button"" class=""close"" data-dismiss=""modal"">&times;</button>
                <h4 class=""modal-title"">Add Student</h4>
            </div>
            <div class=""modal-body"">
                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5804d057cd1a51d555101ded1d558c81c3a61cc36598", async() => {
                WriteLiteral(@"
                    <input type=""hidden"" id=""StudentID"" />
                    <div class=""mb-3"">
                        <label for=""Name"" class=""col-form-label""> Name :</label>
                        <input type=""text"" name=""Name"" class=""form-control"" id=""Name"" required />
                    </div>
                    <div class=""mb-3"">
                        <label for=""Email"" class=""col-form-label"">Email:</label>
                        <input type=""text"" class=""form-control"" name=""Email"" id=""Email"" required />
                    </div>
                    <div class=""mb-3"">
                        <label for=""City"" class=""col-form-label"">City:</label>
                        <input type=""text"" class=""form-control"" name=""City"" id=""City"" required />
                    </div> <br />
                    <div class=""text-center"">
                        <button type=""button"" onclick=""Add()"" class=""btn btn-primary btn-block"">Save</button>
                    </div>
                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n");
            WriteLiteral("\r\n");
            WriteLiteral(@"<div class=""modal fade"" id=""myModal"" role=""dialog"">
    <div class=""modal-dialog"">

        <div class=""modal-content"">
            <div class=""modal-header"">
                <button type=""button"" class=""close"" data-dismiss=""modal"">&times;</button>
                <h4 class=""modal-title"">Edit Student</h4>
            </div>
            <div class=""modal-body"">
                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5804d057cd1a51d555101ded1d558c81c3a61cc39839", async() => {
                WriteLiteral(@"
                    <input type=""hidden"" id=""txtStudentID"" />
                    <div class=""mb-3"">
                        <label for=""Name"" class=""col-form-label""> Name :</label>
                        <input type=""text"" name=""Name"" class=""form-control"" id=""txtName"" required />
                    </div>
                    <div class=""mb-3"">
                        <label for=""Email"" class=""col-form-label"">Email:</label>
                        <input type=""text"" class=""form-control"" name=""Email"" id=""txtEmail"" required />
                    </div>
                    <div class=""mb-3"">
                        <label for=""City"" class=""col-form-label"">City:</label>
                        <input type=""text"" class=""form-control"" name=""City"" id=""txtCity"" required />
                    </div> <br />
                    <div class=""text-center"">
                        <button type=""button"" onclick=""Edit()"" class=""btn btn-primary btn-block"">Update & Save</button>
                    </div>
");
                WriteLiteral("                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n");
            WriteLiteral(@"
<div class=""modal fade"" id=""exampleModal""  role=""dialog"">
    <div class=""modal-dialog"" role=""document"">
        <div class=""modal-content"">
            <div class=""modal-header"">
                <button type=""button"" class=""close"" data-dismiss=""modal"">&times;</button>
                <h4 class=""modal-title"">Edit Student</h4>
            </div>
            <div class=""modal-body"">
                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5804d057cd1a51d555101ded1d558c81c3a61cc313126", async() => {
                WriteLiteral(@"
                    <input type=""hidden"" id=""txtStudentID"" />
                    <div class=""mb-3"">
                        <label for=""Name"" class=""col-form-label""> Name :</label>
                        <input type=""text"" name=""Name"" class=""form-control"" id=""txtNameEdit"" required />
                    </div>
                    <div class=""mb-3"">
                        <label for=""Email"" class=""col-form-label"">Email:</label>
                        <input type=""text"" class=""form-control"" name=""Email"" id=""txtEmailEdit"" required />
                    </div>
                    <div class=""mb-3"">
                        <label for=""City"" class=""col-form-label"">City:</label>
                        <input type=""text"" class=""form-control"" name=""City"" id=""txtCityEdit"" required />
                    </div> <br />
                    <div class=""text-center"">
                        <button type=""button"" onclick=""Edit()"" class=""btn btn-primary btn-block"">Update & Save</button>
                ");
                WriteLiteral("    </div>\r\n                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
            </div>
        </div>
    </div>
</div>

<script>
    $(document).ready(function () {

        $('#dataTable').DataTable({
            ""ajax"": {
                ""url"": ""/Student/LoadData"",
                ""type"": ""GET"",
                ""datatype"": ""json"",
                ""processing"": true,
                ""serverSide"": true,
                ""filter"": true,
            },
            ""columns"": [
                { ""data"": ""studentID"" },
                { ""data"": ""name"" },
                { ""data"": ""email"" },
                { ""data"": ""city"" },
                {
                    ""data"": ""studentID"",
                    ""render"": function (data, i, ev) {

                        var html = `<a href='#' class='btn btn-primary' id=""btnUpdate"" onclick='getbyID(` + data + `)'><i class='fa fa-pencil'></i></a> |
                                   <a type=""button"" class='btn btn-danger ml-5' onclick='DeleteData(`+ data + `)'><i class='fa fa-trash'></i></a> |`
              ");
            WriteLiteral(@"          return html;
                    }
                },

            ]
        }); 
    });

    function DeleteData(Id) {

        Swal.fire({
            title: 'Are you sure?',
            text: ""You won't be able to revert this!"",
            icon: 'warning',
            showCancelButton: true,
            confirmButtonColor: '#3085d6',
            cancelButtonColor: '#d33',
            confirmButtonText: 'Yes, delete it!'
        }).then((result) => {
            if (result.isConfirmed) {
                $.ajax({
                    url: '");
#nullable restore
#line 182 "C:\Users\TE\Downloads\Sanjay\CrudApp\CrudApp\Views\Student\Index.cshtml"
                     Write(Url.Action("Delete", "Student"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"',
                    type: 'POST',
                    dataType: 'json',
                    data: { studentID: Id },
                    success: function (data) {
                        if (data.success) {
                            var oTable = $('#dataTable').DataTable();
                            oTable.ajax.reload();
                            Swal.fire(
                                'Deleted!',
                                'Student has been deleted.',
                                'success'
                            );
                        } else {
                            Swal.fire(
                                'Error!',
                                data.error,
                                'error'
                            );
                        }
                    },
                    error: function () {
                        Swal.fire(
                            'Error!',
                            'An error occurred while trying ");
            WriteLiteral(@"to delete the student.',
                            'error'
                        );
                    }
                });
            }
        });


    }
 
    function Add() {
        var studentID = '0';
        if ($('#StudentID').val() !== '') {
            studentID = $('#StudentID').val();
        }
        var stdObj = {
            StudentID: studentID,
            Name: $('#Name').val(),
            Email: $('#Email').val(),
            City: $('#City').val(),
        };
        $.ajax({
            url: ""/Student/Create"",
            data: { student: stdObj },
            type: ""POST"",
            success: function (result) {
                 
                if (result.status == true) {
                    $('#myModal').modal('hide');
                    var oTable = $('#dataTable').DataTable();
                    oTable.ajax.reload();
                    Swal.fire(
                        'New Student Added ',
                        'Student saved in D");
            WriteLiteral(@"B',
                        'success'
                    )
                }
                clearTextboxes();
            },
            error: function (errormessage) {
                alert(errormessage.responseText);
            }
        });
    }
 
    function clearTextboxes() {
        var inputs = document.querySelectorAll('input');
        for (var i = 0; i < inputs.length; i++) {
            inputs[i].value = """";
        }
    }
 
    function getbyID(ID) {
       debugger
        $.ajax({
            url: ""/Student/getbyID/"" + ID,
            typr: ""GET"",
            contentType: ""application/json;charset=UTF-8"",
            dataType: ""json"",
            success: function (result) {
                debugger
                $('#txtStudentID').val(result.studentID);
                $('#txtNameEdit').val(result.name);
                $('#txtEmailEdit').val(result.email);
                $('#txtCityEdit').val(result.city);
                debugger
                $('#");
            WriteLiteral(@"exampleModal').modal('show');
                $('#btnUpdate').show();
             
            },
            error: function (errormessage) {
                alert(errormessage.responseText);
            }
        });
        
    }

    function Edit() {
        var Student = {
            StudentID: parseInt($('#txtStudentID').val()),
            Name: $('#txtNameEdit').val(),
            Email: $('#txtEmailEdit').val(),
            City: $('#txtCityEdit').val()
        };
        $.ajax({
            url: ""/Student/Edit"",
            data: {Student:Student},
            type: ""POST"",
            dataType: ""json"",
            success: function (result) {
                Swal.fire(
                    'Student Updated ',
                    'updated record saved in db',
                    'success'
                )
                var oTable = $('#dataTable').DataTable();
                oTable.ajax.reload();
                $('#exampleModal').modal('hide');
              ");
            WriteLiteral(@"  loadData();
                $('#StudentID').val("""");
                $('#Name').val("""");
                $('#Email').val("""");
                $('#City').val("""");
                
            },
            error: function (errormessage) {
                alert(errormessage.responseText);
            }
        });
    }


</script>


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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<CrudApp.Models.Student>> Html { get; private set; }
    }
}
#pragma warning restore 1591
