using Pechkin;
using Pechkin.Synchronized;
using System;
using System.Collections.Generic;
using System.Drawing.Printing;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SotosWoodwork.Utils
{
    public class HtmlToPdf : Controller
    {
        public FileContentResult Execute(HttpRequestBase request, string page, string name)
        {
            byte[] byteArray = new SynchronizedPechkin(new GlobalConfig().SetPaperSize(PaperKind.A4))
                .Convert(new ObjectConfig().SetLoadImages(true)
                        .SetZoomFactor(1.5)
                        .SetPrintBackground(true)
                        .SetScreenMediaType(true)
                        .SetCreateExternalLinks(true)
                        .SetPageUri(request.Url.Scheme + "//" + request.Url.Authority + "/" + page));
            return File(byteArray, "application/pdf", name + ".pdf");
        }
    }
}