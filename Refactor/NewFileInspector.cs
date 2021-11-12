using System.IO;
using System.Net;
using System.Threading;

namespace Refactor
{
    /*
      Gegeben ist dieser NewFileInspector. Wenn eine neue Datei in einem bestimmten Verzeichnis angelegt wird, soll er 
      den User informieren. Dafür gibt es eine Liste von Verhalten "Behaviours". 
      
      Die Benutzung ist so gedacht:
      
      var ic = new NewFileInspector(new[]{InspectBehaviour.SendEMail, InspectBehaviour.CallWebservice}, "c:\temp")
      ic.Start();
       
      Welche Probleme ergeben sich hinsichtlich, der Wiederverwandbarkeit, Wartung und Erweiterbarkeit?
      Wie könnte ein Refactoring aussehen?
    */
    
    public class NewFileInspector
    {
        public enum InspectBehaviour
        {
            SendEMail,
            ShowMessageBox,
            CallWebservice
        }
        
        private readonly InspectBehaviour[] _behaviours;
        private readonly string _listenToDirectory;
        private bool _looping;

        public NewFileInspector(InspectBehaviour [] behaviours, string listenToDirectory)
        {
            _behaviours = behaviours;
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
            foreach (var behaviour in _behaviours)
            {
                switch (behaviour)
                {
                    case InspectBehaviour.CallWebservice:
                        FancyWebClient.Request("http://newfileallert.com");
                        break;
                    case InspectBehaviour.SendEMail:
                        FancyMailSender.SendMail("me@recom.eu", "New File " + newFileName + " detected!");
                        break;
                    case InspectBehaviour.ShowMessageBox:
                        MessageBox.ShowMessage("New File " + newFileName + " detected!");
                        break;
                }
            }
        }
    }
}