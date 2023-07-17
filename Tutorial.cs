namespace CsPractice
{
    public class Tutorial
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

        //-----------------------------------------------------------------------------------------------------
        //Inheritance:
        protected int TutorialID1;
        protected string TutorialName1;

        public void SetTutorial1(int pID, string pName)
        {
            TutorialID = pID;
            TutorialName = pName;
        }

        public String GetTutorial1()
        {
            return TutorialName;
        }

        internal void RenameTutorial2(string v)
        {
            throw new NotImplementedException();
        }
    }

    public class VaibTutorial : Tutorial
    {
        public void RenameTutorial(String pNewName)
        {
            TutorialName1 = pNewName;
        }
    }


    //-----------------------------------------------------------------------------------------------------
    //Abstarct Class:
    abstract class Tutorial2
    {
        public virtual void Set()
        {

        }
    }
    class VaibTutorial2 : Tutorial
    {
        protected int TutorialID2;
        protected string TutorialName2;

        public void SetTutorial2(int pID, string pName)
        {
            TutorialID2 = pID;
            TutorialName2 = pName;
        }

        public String GetTutorial2()
        {
            return TutorialName2;
        }
    }

    //-----------------------------------------------------------------------------------------------------
    //Interface in C#:

    interface VaibInterface
    {
        void SetTutorial(int pID, string pName);
        String GetTutorial();
    }

    class VaibTutorial4 : VaibInterface
    {
        protected int TutorialID;
        protected string TutorialName;

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


