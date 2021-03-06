﻿


/*Generated by the BSD Licensed LucidMVC ViewGenerator T4 file*/
using System.Text;
using System.Collections.Generic;
using System.Web;
using System.IO;
using System;
using Earlz.LucidMVC.ViewEngine;
using Earlz.LucidMVC;

        //custom using statements for your views go here:
        
    
/*File: HomeView */
namespace LucidMVCTemplate.Views{
        ///<summary>
        ///
        ///</summary>
    public class HomeView: Earlz.LucidMVC.ViewEngine.LucidViewBase
    {
                ///<summary>
        ///
        ///</summary>
            public string ControllerName{
        get;
        set;
        }

                ///<summary>
        ///This is the layout of the given view (master page)
        ///</summary>
            public LayoutView Layout{
        get;
        set;
        }

                ///<summary>
        ///The "Flash" notification text(passes through to the layout
        ///</summary>
            public override string Flash{
        get{return Layout.Flash;}
        set{Layout.Flash=value;}
        }

         void BuildOutput()
        {
__Write(@"");
__Write(@"");
__Write(@"
");
__Write(@"
");
__Write(@"
<div>
<h1>Welcome to LucidMVC!</h1>
<p>
You're viewing the controller """);
{
                object __v;
                

                    __v=ControllerName;
                
__OutputVariable(__v);
}
__Write(@""". You can find this view in views/HomeView.html
</p>


</div>");

        }
         void __Init()
        {
Layout=new LayoutView(); Layout.Content=this;
        }
        public  HomeView()
        {
__Init();
        }
        protected virtual void __Write(string s)
        {
if(__Writer!=null){ __Writer.Write(s); }
        }
        protected virtual void __Write(ILucidView v)
        {
v.RenderView(__Writer);
        }
        public override void RenderView(System.IO.TextWriter outputStream)
        {
Layout.Title="LucidMVC Home View"; 
	__Writer=outputStream;
	if(Layout==null){
        BuildOutput();
		return;
	}
	if(__InLayout){
        //If we get here, then the layout is currently trying to render itself(and we are being rendered as a partial/sub view)
        __InLayout=false;
        BuildOutput();
	}else{
        //otherwise, we are here and someone called RenderView on us(and we have a layout to render first)
        __InLayout=true;
        Layout.RenderView(__Writer); 
	}
//This should recurse no more than 2 times
//Basically, this will go to hell if there is ever more than 1 partial view with a Layout set.
        }
        protected void __OutputVariable(object v)
        {

            {
                if(v!=null)
                {
                    var e=v as System.Collections.IEnumerable;
                    if (e!=null)
                    {
                        foreach(var item in e){ 
                            var view=item as Earlz.LucidMVC.ViewEngine.ILucidView;
                            if(view!=null){
                                __Write(view);
                            }else{
                                __Write(item.ToString());
                            }
                        }
                    }else{
                        var view=v as Earlz.LucidMVC.ViewEngine.ILucidView;
                        if(view!=null){
                            __Write(view);
                        }else{
                            __Write(v.ToString());
                        }
                    }
                }        
            }
        }
                ///<summary>
        ///For internal use only!
        ///</summary>
         bool __InLayout=false;
                ///<summary>
        ///For internal use only!
        ///</summary>
         TextWriter __Writer;
                ///<summary>
        ///For internal use only!
        ///</summary>
         bool __RenderDirectly=true;

    }
}

/*File: LayoutView */
namespace LucidMVCTemplate.Views{
        ///<summary>
        ///
        ///</summary>
    public class LayoutView: Earlz.LucidMVC.ViewEngine.LucidViewBase
    {
                ///<summary>
        ///
        ///</summary>
            public string Title{
        get;
        set;
        }

                ///<summary>
        ///
        ///</summary>
            public ILucidView Content{
        get;
        set;
        }

                ///<summary>
        ///This is the layout of the given view (master page)
        ///</summary>
            public ILucidView Layout{
        get;
        set;
        }

                ///<summary>
        ///The "Flash" notification text(passes through to the layout
        ///</summary>
            public override string Flash{
        get{return Layout.Flash;}
        set{Layout.Flash=value;}
        }

         void BuildOutput()
        {
__Write(@"<!DOCTYPE HTML5>
");
__Write(@"
<html>
	<head>
		<title>");
{
                object __v;
                

                    __v=Title;
                
__OutputVariable(__v);
}
__Write(@"</title>
		<link rel=""stylesheet"" type=""text/css"" media=""all"" href=""/static/style.css"" />
		</head>
	<body>
	<div id=""content"">
		");
{
                object __v;
                

                    __v=Content;
                
__OutputVariable(__v);
}
__Write(@"
	</div>
	</body>
</html>");

        }
         void __Init()
        {

        }
        public  LayoutView()
        {
__Init();
        }
        protected virtual void __Write(string s)
        {
if(__Writer!=null){ __Writer.Write(s); }
        }
        protected virtual void __Write(ILucidView v)
        {
v.RenderView(__Writer);
        }
        public override void RenderView(System.IO.TextWriter outputStream)
        {

	__Writer=outputStream;
	if(Layout==null){
        BuildOutput();
		return;
	}
	if(__InLayout){
        //If we get here, then the layout is currently trying to render itself(and we are being rendered as a partial/sub view)
        __InLayout=false;
        BuildOutput();
	}else{
        //otherwise, we are here and someone called RenderView on us(and we have a layout to render first)
        __InLayout=true;
        Layout.RenderView(__Writer); 
	}
//This should recurse no more than 2 times
//Basically, this will go to hell if there is ever more than 1 partial view with a Layout set.
        }
        protected void __OutputVariable(object v)
        {

            {
                if(v!=null)
                {
                    var e=v as System.Collections.IEnumerable;
                    if (e!=null)
                    {
                        foreach(var item in e){ 
                            var view=item as Earlz.LucidMVC.ViewEngine.ILucidView;
                            if(view!=null){
                                __Write(view);
                            }else{
                                __Write(item.ToString());
                            }
                        }
                    }else{
                        var view=v as Earlz.LucidMVC.ViewEngine.ILucidView;
                        if(view!=null){
                            __Write(view);
                        }else{
                            __Write(v.ToString());
                        }
                    }
                }        
            }
        }
                ///<summary>
        ///For internal use only!
        ///</summary>
         bool __InLayout=false;
                ///<summary>
        ///For internal use only!
        ///</summary>
         TextWriter __Writer;
                ///<summary>
        ///For internal use only!
        ///</summary>
         bool __RenderDirectly=true;

    }
}


//