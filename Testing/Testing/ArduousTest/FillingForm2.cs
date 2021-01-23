using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testing
{
    class FillingForm2
    {
        FillingArduousTest fillingArduousTest = new FillingArduousTest(5);

        public FillingForm2()
        {
            fillingArduousTest.Search2();
        }

        public string AddQuestForСonformity(int i)
        {
            return fillingArduousTest.QuestForСonformity[i];
        }

        public string AddConformity(int i)
        {
            return fillingArduousTest.Сonformity[i];
        }

        public string AddCouple(int i)
        {
            return fillingArduousTest.Сouple[i];
        }
    }
}
