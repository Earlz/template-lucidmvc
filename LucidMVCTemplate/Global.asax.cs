using Earlz.LucidMVC;


namespace LucidMVCTemplate
{
	using System;
	using System.Collections;
	using System.ComponentModel;
	using System.Web;
	using System.Web.SessionState;

	public class Global : System.Web.HttpApplication
	{
		Router router;
		protected void Application_Start(Object sender, EventArgs e)
		{
			if(router==null)
			{
				InitRouter();
			}
		}
		object routerinit=new object();
		void InitRouter()
		{
			lock(routerinit)
			{
				router=new Router();

				var landing=router.Controller((c) => new HomeController(c));
				landing.Handles("/").With(x=>x.HomePage());
			}
		}
		protected void Session_Start(Object sender, EventArgs e)
		{
		}

		protected void Application_BeginRequest(Object sender, EventArgs e)
		{
			if(router==null)
			{
				InitRouter();
			}
			if(router.Execute(new AspNetServerContext()))
			{
				CompleteRequest();
			}
		}

		protected void Application_EndRequest(Object sender, EventArgs e)
		{
		}

		protected void Application_AuthenticateRequest(Object sender, EventArgs e)
		{
		}

		protected void Application_Error(Object sender, EventArgs e)
		{
		}

		protected void Session_End(Object sender, EventArgs e)
		{
		}

		protected void Application_End(Object sender, EventArgs e)
		{
		}
	}
}

