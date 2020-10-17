#pragma checksum "/Users/alihaidar/Projects/Python/fantasyepl/MvcFantasy/Views/Home/Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ded7bb1992b40250c5cb6c916fd9fa4be6641c95"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
#line 1 "/Users/alihaidar/Projects/Python/fantasyepl/MvcFantasy/Views/_ViewImports.cshtml"
using MvcFantasy;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/alihaidar/Projects/Python/fantasyepl/MvcFantasy/Views/_ViewImports.cshtml"
using MvcFantasy.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ded7bb1992b40250c5cb6c916fd9fa4be6641c95", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"34b39869afa474f400044047324f3972a998ece5", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "/Users/alihaidar/Projects/Python/fantasyepl/MvcFantasy/Views/Home/Index.cshtml"
  
    ViewData["Title"] = "Display Data";
    string[] TableHeaders = new string[] {
        "Element Type", "First Name", "Last Name", "Form", "Cost", "PPG",  "% Selected", 
         "Team Id",  "Total Points", "Transfers In", "Transfers Out",  "Minutes Played", "Goals", "Assists", 
         "Clean Sheets", "Conceded", "Own Goals", "Pens Saved", "Pens Missed", "Yellow Cards", "Red Cards", 
         "Saves", "Bonus", "BPS", "Influence", "Creativity", "Threat", "ICT Index"};


        

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<style>
    #myInput {
        background-image: url('/css/searchicon.png'); /* Add a search icon to input */
        background-position: 10px 12px; /* Position the search icon */
        background-repeat: no-repeat; /* Do not repeat the icon image */
        width: 100%; /* Full-width */
        font-size: 16px; /* Increase font-size */
        padding: 12px 20px 12px 40px; /* Add some padding */
        border: 1px solid #ddd; /* Add a grey border */
        margin-bottom: 12px; /* Add some space below the input */
        }

        #myTable {
        border-collapse: collapse; /* Collapse borders */
        width: 100%; /* Full-width */
        border: 1px solid #ddd; /* Add a grey border */
        font-size: 18px; /* Increase font-size */
        }

        #myTable th, #myTable td {
        text-align: left; /* Left-align text */
        padding: 12px; /* Add padding */
        }

        #myTable tr {
        /* Add a bottom border to all table rows */
        border-bott");
            WriteLiteral(@"om: 1px solid #ddd; 
        }

        #myTable tr.header, #myTable tr:hover {
        /* Add a grey background color to the table header and on hover */
        background-color: #f1f1f1;
    }
</style>

<html>
    <p><button onclick=""sortTable()"">Sort</button></p>
    <input type=""text"" id=""myInput"" onkeyup=""myFunction()"" placeholder=""Search for names.."">
    
    <table id=""myTable"" class=""table table-bordered table-responsive table-hover"">
        <thead>
            <tr>
");
#nullable restore
#line 60 "/Users/alihaidar/Projects/Python/fantasyepl/MvcFantasy/Views/Home/Index.cshtml"
                  
                    int i = 0;
                    while (i < TableHeaders.Count()) {
                        foreach (var head in TableHeaders){

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <th");
            BeginWriteAttribute("onclick", " onclick=\'", 2953, "\'", 2976, 3);
            WriteAttributeValue("", 2963, "sortTable(", 2963, 10, true);
#nullable restore
#line 64 "/Users/alihaidar/Projects/Python/fantasyepl/MvcFantasy/Views/Home/Index.cshtml"
WriteAttributeValue("", 2973, i, 2973, 2, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2975, ")", 2975, 1, true);
            EndWriteAttribute();
            WriteLiteral("> ");
#nullable restore
#line 64 "/Users/alihaidar/Projects/Python/fantasyepl/MvcFantasy/Views/Home/Index.cshtml"
                                                Write(head);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </th>\r\n");
#nullable restore
#line 65 "/Users/alihaidar/Projects/Python/fantasyepl/MvcFantasy/Views/Home/Index.cshtml"
                        i = i + 1;
                    } 

                    }
                           
                

#line default
#line hidden
#nullable disable
            WriteLiteral("            </tr>\r\n        </thead>\r\n        <tbody>\r\n");
#nullable restore
#line 74 "/Users/alihaidar/Projects/Python/fantasyepl/MvcFantasy/Views/Home/Index.cshtml"
              
                if (Model != null) {
                    foreach (var Data in Model) {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <tr>\r\n                            <td>");
#nullable restore
#line 78 "/Users/alihaidar/Projects/Python/fantasyepl/MvcFantasy/Views/Home/Index.cshtml"
                           Write(Data.element_type);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td>");
#nullable restore
#line 79 "/Users/alihaidar/Projects/Python/fantasyepl/MvcFantasy/Views/Home/Index.cshtml"
                           Write(Data.first_name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td>");
#nullable restore
#line 80 "/Users/alihaidar/Projects/Python/fantasyepl/MvcFantasy/Views/Home/Index.cshtml"
                           Write(Data.second_name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td>");
#nullable restore
#line 81 "/Users/alihaidar/Projects/Python/fantasyepl/MvcFantasy/Views/Home/Index.cshtml"
                           Write(Data.form);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td>");
#nullable restore
#line 82 "/Users/alihaidar/Projects/Python/fantasyepl/MvcFantasy/Views/Home/Index.cshtml"
                           Write(Data.now_cost);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td>");
#nullable restore
#line 83 "/Users/alihaidar/Projects/Python/fantasyepl/MvcFantasy/Views/Home/Index.cshtml"
                           Write(Data.points_per_game);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td>");
#nullable restore
#line 84 "/Users/alihaidar/Projects/Python/fantasyepl/MvcFantasy/Views/Home/Index.cshtml"
                           Write(Data.selected_by_percent);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td>");
#nullable restore
#line 85 "/Users/alihaidar/Projects/Python/fantasyepl/MvcFantasy/Views/Home/Index.cshtml"
                           Write(Data.team);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td>");
#nullable restore
#line 86 "/Users/alihaidar/Projects/Python/fantasyepl/MvcFantasy/Views/Home/Index.cshtml"
                           Write(Data.total_points);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td>");
#nullable restore
#line 87 "/Users/alihaidar/Projects/Python/fantasyepl/MvcFantasy/Views/Home/Index.cshtml"
                           Write(Data.transfers_in);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td>");
#nullable restore
#line 88 "/Users/alihaidar/Projects/Python/fantasyepl/MvcFantasy/Views/Home/Index.cshtml"
                           Write(Data.transfers_out);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td>");
#nullable restore
#line 89 "/Users/alihaidar/Projects/Python/fantasyepl/MvcFantasy/Views/Home/Index.cshtml"
                           Write(Data.minutes);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td>");
#nullable restore
#line 90 "/Users/alihaidar/Projects/Python/fantasyepl/MvcFantasy/Views/Home/Index.cshtml"
                           Write(Data.goals_scored);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td>");
#nullable restore
#line 91 "/Users/alihaidar/Projects/Python/fantasyepl/MvcFantasy/Views/Home/Index.cshtml"
                           Write(Data.assists);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td>");
#nullable restore
#line 92 "/Users/alihaidar/Projects/Python/fantasyepl/MvcFantasy/Views/Home/Index.cshtml"
                           Write(Data.clean_sheets);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td>");
#nullable restore
#line 93 "/Users/alihaidar/Projects/Python/fantasyepl/MvcFantasy/Views/Home/Index.cshtml"
                           Write(Data.goals_conceded);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td>");
#nullable restore
#line 94 "/Users/alihaidar/Projects/Python/fantasyepl/MvcFantasy/Views/Home/Index.cshtml"
                           Write(Data.own_goals);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td>");
#nullable restore
#line 95 "/Users/alihaidar/Projects/Python/fantasyepl/MvcFantasy/Views/Home/Index.cshtml"
                           Write(Data.penalties_saved);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td>");
#nullable restore
#line 96 "/Users/alihaidar/Projects/Python/fantasyepl/MvcFantasy/Views/Home/Index.cshtml"
                           Write(Data.penalties_missed);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td>");
#nullable restore
#line 97 "/Users/alihaidar/Projects/Python/fantasyepl/MvcFantasy/Views/Home/Index.cshtml"
                           Write(Data.yellow_cards);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td>");
#nullable restore
#line 98 "/Users/alihaidar/Projects/Python/fantasyepl/MvcFantasy/Views/Home/Index.cshtml"
                           Write(Data.red_cards);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td>");
#nullable restore
#line 99 "/Users/alihaidar/Projects/Python/fantasyepl/MvcFantasy/Views/Home/Index.cshtml"
                           Write(Data.saves);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td>");
#nullable restore
#line 100 "/Users/alihaidar/Projects/Python/fantasyepl/MvcFantasy/Views/Home/Index.cshtml"
                           Write(Data.bonus);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td>");
#nullable restore
#line 101 "/Users/alihaidar/Projects/Python/fantasyepl/MvcFantasy/Views/Home/Index.cshtml"
                           Write(Data.bps);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td>");
#nullable restore
#line 102 "/Users/alihaidar/Projects/Python/fantasyepl/MvcFantasy/Views/Home/Index.cshtml"
                           Write(Data.influence);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td>");
#nullable restore
#line 103 "/Users/alihaidar/Projects/Python/fantasyepl/MvcFantasy/Views/Home/Index.cshtml"
                           Write(Data.creativity);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td>");
#nullable restore
#line 104 "/Users/alihaidar/Projects/Python/fantasyepl/MvcFantasy/Views/Home/Index.cshtml"
                           Write(Data.threat);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td>");
#nullable restore
#line 105 "/Users/alihaidar/Projects/Python/fantasyepl/MvcFantasy/Views/Home/Index.cshtml"
                           Write(Data.ict_index);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        </tr>\r\n");
#nullable restore
#line 107 "/Users/alihaidar/Projects/Python/fantasyepl/MvcFantasy/Views/Home/Index.cshtml"
                    }
                }
            

#line default
#line hidden
#nullable disable
            WriteLiteral(@"        </tbody>
    </table>

    <script>
    function sortTable() {
        var table, rows, switching, i, x, y, shouldSwitch, dir, switchcount = 0;
        var n = 2;
        table = document.getElementById(""myTable"");
        switching = true;
        //Set the sorting direction to ascending:
        dir = ""asc""; 
        /*Make a loop that will continue until
        no switching has been done:*/
        while (switching) {
            //start by saying: no switching is done:
            switching = false;
            rows = table.rows;
            /*Loop through all table rows (except the
            first, which contains table headers):*/
            for (i = 1; i < (rows.length - 1); i++) {
                //start by saying there should be no switching:
                shouldSwitch = false;
                /*Get the two elements you want to compare,
                one from current row and one from the next:*/
                x = rows[i].getElementsByTagName(""TD"")[n];
       ");
            WriteLiteral(@"         y = rows[i + 1].getElementsByTagName(""TD"")[n];
                /*check if the two rows should switch place,
                based on the direction, asc or desc:*/
                if (dir == ""asc"") {
                    if (x.innerHTML.toLowerCase() > y.innerHTML.toLowerCase()) {
                    //if so, mark as a switch and break the loop:
                    shouldSwitch= true;
                    break;
                    }
                } else if (dir == ""desc"") {
                    if (x.innerHTML.toLowerCase() < y.innerHTML.toLowerCase()) {
                    //if so, mark as a switch and break the loop:
                    shouldSwitch = true;
                    break;
                    }   
                }
            }
            if (shouldSwitch) {
                /*If a switch has been marked, make the switch
                and mark that a switch has been done:*/
                rows[i].parentNode.insertBefore(rows[i + 1], rows[i]);
                switc");
            WriteLiteral(@"hing = true;
                //Each time a switch is done, increase this count by 1:
                switchcount ++;      
            } else {
                /*If no switching has been done AND the direction is ""asc"",
                set the direction to ""desc"" and run the while loop again.*/
                if (switchcount == 0 && dir == ""asc"") {
                    dir = ""desc"";
                    switching = true;
                }   
            }
        }
    }

    function sortTable(n) {
        var table, rows, switching, i, x, y, shouldSwitch, dir, switchcount = 0;
        table = document.getElementById(""myTable"");
        switching = true;
        //Set the sorting direction to ascending:
        dir = ""asc""; 
        /*Make a loop that will continue until
        no switching has been done:*/
        while (switching) {
            //start by saying: no switching is done:
            switching = false;
            rows = table.rows;
            /*Loop through all tabl");
            WriteLiteral(@"e rows (except the
            first, which contains table headers):*/
            for (i = 1; i < (rows.length - 1); i++) {
                //start by saying there should be no switching:
                shouldSwitch = false;
                /*Get the two elements you want to compare,
                one from current row and one from the next:*/
                x = rows[i].getElementsByTagName(""TD"")[n];
                y = rows[i + 1].getElementsByTagName(""TD"")[n];
                /*check if the two rows should switch place,
                based on the direction, asc or desc:*/
                if (dir == ""asc"") {
                    if (x.innerHTML.toLowerCase() > y.innerHTML.toLowerCase()) {
                    //if so, mark as a switch and break the loop:
                    shouldSwitch= true;
                    break;
                    }
                } else if (dir == ""desc"") {
                    if (x.innerHTML.toLowerCase() < y.innerHTML.toLowerCase()) {
                    /");
            WriteLiteral(@"/if so, mark as a switch and break the loop:
                    shouldSwitch = true;
                    break;
                    }
                }
            }
            if (shouldSwitch) {
                /*If a switch has been marked, make the switch
                and mark that a switch has been done:*/
                rows[i].parentNode.insertBefore(rows[i + 1], rows[i]);
                switching = true;
                //Each time a switch is done, increase this count by 1:
                switchcount ++;      
            } else {
                /*If no switching has been done AND the direction is ""asc"",
                set the direction to ""desc"" and run the while loop again.*/
                if (switchcount == 0 && dir == ""asc"") {
                    dir = ""desc"";
                    switching = true;
                }
            }
        }
    }

    function myFunction() {
        var input, filter, table, tr, td, i, txtValue;
        input = document.getElem");
            WriteLiteral(@"entById(""myInput"");
        filter = input.value.toUpperCase();
        table = document.getElementById(""myTable"");
        tr = table.getElementsByTagName(""tr"");
        for (i = 0; i < tr.length; i++) {
            td = tr[i].getElementsByTagName(""td"")[0];
            if (td) {
                txtValue = td.textContent || td.innerText;
            }
            if (txtValue.toUpperCase().indexOf(filter) > -1) {
                tr[i].style.display = """";
            } else {
                tr[i].style.display = ""none"";
            }
        }       
    }
    </script>

</html>

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
