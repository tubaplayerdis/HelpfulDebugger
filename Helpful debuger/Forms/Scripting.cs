using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.ClearScript.V8;
using Microsoft.ClearScript;


namespace Helpful_debugger.Forms
{
    public partial class Scripting : Form
    {
        V8ScriptEngine Engine = new V8ScriptEngine(V8ScriptEngineFlags.EnableDebugging);
        public Scripting()
        {
            InitializeComponent();
            Engine.AddHostType("Console", typeof(ConsoleNew));
            RefeshLog.Stop();
        }

        

        private void RunScriptButton_Click(object sender, EventArgs e)
        {
            RefeshLog.Start();
            try
            {
                Engine.Execute(EditorBox.Text);
            }
            catch (ScriptEngineException ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void RefeshLog_Tick(object sender, EventArgs e)
        {
            OutputBox.Text = ConsoleNew.Output;
        }
    }

    public static class ConsoleNew
    {
        public static string Output { get; set; }
        public static void Log(object toprint)
        {
            Output = Output + $"\r\n{toprint.ToString()}";
        }

        public static void Clear()
        {
            Output = "";
        }
    }


}
