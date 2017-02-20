using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.IO;
using System.Web.UI;

namespace staticcss.Controllers
{
    public class ContentController : Controller
    {
        /// <summary>
        /// ~content/index/{file}
        /// content/{file}.cssのレスポンスを変換
        /// </summary>
        /// <param name="file"></param>
        /// <returns></returns>
        public ActionResult Index(string file)
        {
            var path = Server.MapPath("~/Content/" + file + ".css");

            // 空白除去
            var content = string.Join("", System.IO.File.ReadAllLines(path).Select(p => p.Trim()));

            // css形式のMINEタイプでレスポンスを返す
            return Content(content, "text/css");            
        }
    }
}