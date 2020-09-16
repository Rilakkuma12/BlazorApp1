using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MSScriptControl;

namespace BlazorApp1.Service
{
    public class JsHelper
    {
        public object ExecuteScript(string funcName, string argument, string jsPath= "./wwwroot/MyTest.js")
        {
            string js = System.IO.File.ReadAllText(jsPath);
            object o = ExecuteScript(string.Format("{0}('{1}')", funcName, argument), js);
            return o;
        }
        private object ExecuteScript(string sExpression, string sCode)
        {
            MSScriptControl.ScriptControl scriptControl = new MSScriptControl.ScriptControl();
            scriptControl.UseSafeSubset = true;
            scriptControl.Language = "JScript";
            scriptControl.AddCode(sCode);
            try
            {
                return scriptControl.Eval(sExpression);
            }
            catch (Exception ex)
            {

            }
            return null;
        }
    }
}
 