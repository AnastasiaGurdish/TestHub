using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testing
{
    class FillingForm1
    {
        FillingMediumTest fillingMediumTest = new FillingMediumTest(7);

        public FillingForm1()
        {
            fillingMediumTest.Search1();
            fillingMediumTest.FillConformity(3);
            fillingMediumTest.Search2();
        }

        public string AddQuest(int i)
        {
            return fillingMediumTest.Quest[i];
        }

        public string GetTrueAns(int i)
        {
            return fillingMediumTest.TrueAnswers[i];
        }
    
        public string AddErrorAns(int i)
        {
            return fillingMediumTest.FalseAnswers[i];
        }

        public string AddQuestForСonformity(int i)
        {
            return fillingMediumTest.QuestForСonformity[i];
        }

        public string AddConformity(int i)
        {
            return fillingMediumTest.Сonformity[i];
        }

        public string AddCouple(int i)
        {
            return fillingMediumTest.Сouple[i];
        }
    }
}
