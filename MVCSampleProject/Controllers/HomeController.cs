using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCSampleProject.Controllers
{
    public class HomeController : Controller
    {
        log4net.ILog logger = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public ActionResult Index()
        {
            logger.Debug("Debug: 開発用のデバッグメッセージ");
            logger.Info("Info: 操作ログなどの情報");
            logger.Warn("Warn: 障害ではない注意警告");
            logger.Error("Error: システム停止はしないが、問題となる障害");
            logger.Fatal("Fatal: システム停止するような致命的な障害");

            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}