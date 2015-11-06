using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using UniScheduler.Data;
using System.Data;
using System.Data.SqlClient;

namespace UniScheduler.Controllers
{
  public class LecturesController : Controller
  {

    public ActionResult Index()
    {
        var dataRepository = new LectureRepository();

            var lecture = dataRepository.GetLecture();
      return View(lecture);
    }

  }
}
