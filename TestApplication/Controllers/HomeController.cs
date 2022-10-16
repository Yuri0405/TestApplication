using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using TestApplication.Models;
using TestApplication.Models.Data;

namespace TestApplication.Controllers
{
    public class HomeController : Controller
    {
        private readonly FolderDBContext _db;

        public HomeController(ILogger<HomeController> logger, FolderDBContext db)
        {
            _db = db;
        }

        [Route("{*catchall}")]
        public IActionResult Index()
        {
            string path = HttpContext.Request.Path;
            string str = path.Split("/").Last();
            str = str.Replace("%20", " ");
            ViewBag.Path = str;
            List<string> subfolderURLs = new List<string>();
        
            Folder folder = _db.Folders.FirstOrDefault(f=>f.Name == str);
            if(folder != null)
            {
                List<Folder> subfolders = _db.Folders.Where(f => f.RootFolderId == folder.Id).ToList();
                if(subfolders.Count > 0)
                {
                    foreach(Folder subfolder in subfolders)
                    {
                        subfolderURLs.Add(HttpContext.Request.Path + "/" + subfolder.Name.Replace(" ","%20"));
                    }
                }
                ViewBag.Folders = subfolders;
            }

            ViewBag.SubFolderURLs = subfolderURLs;

            return View();
        }

    }
}
