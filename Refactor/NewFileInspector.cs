using System.IO;
using System.Net;
using System.Threading;

namespace Refactor
{
    /*
      Gegeben ist dieser NewFileInspector. Wenn eine neue Datei in einem bestimmten Verzeichnis angelegt wird, soll er 
      den User informieren. Dafür gibt es eine Menge von Verhalten die an oder ausgeschaltet werden können. 
      
      Die Benutzung ist so gedacht:
      
      var ic = new NewFileInspector("c:\temp")
      ic.ShouldCallWebservice = true;
      ic.Start();
       
      Welche Probleme ergeben sich hinsichtlich, der Wiederverwandbarkeit, Wartung und Erweiterbarkeit?
      Wie könnte ein Refactoring aussehen?
    */
    
    public class NewFileInspector
    {
        private bool _looping;
        private string _listenToDirectory;

        public bool ShouldCallWebservice { get; set; }
        public bool ShouldSendEmail { get; set; }
        public bool ShouldShowMessageBox { get; set; }
        
        public NewFileInspector(string listenToDirectory)
        {
            _listenToDirectory = listenToDirectory;
        }

        public void Start()
        {
            _looping = true;
            while (_looping)
            {
                bool newFile = true; //Platzhalter für eine Abfrage
                string newFileName = "text1.txt"; //Platzhalter für eine Abfrage 
                
                if (newFile)
                {
                    ExecuteBehaviour(newFileName);
                }
                Thread.Sleep(1000);    
            }
        }

        public void Stop()
        {
            _looping = false;
        }


        private void ExecuteBehaviour(string newFileName)
        {
            if (ShouldCallWebservice)
            {
                FancyWebClient.Request("http://newfileallert.com");
            }

            if (ShouldSendEmail)
            {
                FancyMailSender.SendMail("me@recom.eu", "New File " + newFileName + " detected!");
            }

            if (ShouldShowMessageBox)
            {
                MessageBox.ShowMessage("New File " + newFileName + " detected!");
            }
        }
    }
}