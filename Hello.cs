using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace DemoApplication
{
    class Tutorial
    {
        int TutorialID;
        string TutorialName;

        public void SetTutorial(int pID, string pName)
        {
            TutorialID = pID;
            TutorialName = pName;
        }
        public String GetTutorial()
        {
            return TutorialName;
        }

        
    }
}