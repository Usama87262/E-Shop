using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace E_Shop.Web.Controllers
{
    public class SharedController : Controller
    {
        public JsonResult UploadImage()
        {
            JsonResult result = new JsonResult();
            result.JsonRequestBehavior = JsonRequestBehavior.AllowGet;

           try {
                var file = Request.Files[0];
                var filename = Guid.NewGuid() + Path.GetExtension(file.FileName);
                var path = Path.Combine(Server.MapPath("~/Content/images"), filename);

                file.SaveAs(path);

                result.Data = new { Success = true, ImageURL = string.Format("/Content/images/{0}", filename) };
            }

            catch (Exception ex)
            {
                result.Data = new { Success = false, Message = ex.Message };
            }
            return result;
        }
    }
}