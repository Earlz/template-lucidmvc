using System;
using Earlz.LucidMVC;
using Earlz.LucidMVC.ViewEngine;
using LucidMVCTemplate.Views;

namespace LucidMVCTemplate
{
	public class HomeController : HttpController
	{
		public HomeController(RequestContext context) : base(context)
		{
		}
		public HomeView HomePage()
		{
			return new HomeView{ControllerName="HomeController"};
		}
	}
}

