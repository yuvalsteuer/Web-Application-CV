﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using cvWebApplication.Models;
namespace cvWebApplication.Controllers
{
	public class ProjectsController : Controller
	{
		// GET: Projects
		public ActionResult Random()
		{
			var project = new Project("hello", "");
			return View(project);
		}
	}
}