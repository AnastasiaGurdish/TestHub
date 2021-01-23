using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testing
{
    class FillingForm
    {
        FillingEasyTest fillingEasyTest = new FillingEasyTest(10);

        public FillingForm()
        {
            fillingEasyTest.Search();
        }

        public string AddQuest(int i)
        {
            return fillingEasyTest.Quest[i];
        }

        public string GetTrueAns(int i)
        {
            return fillingEasyTest.TrueAnswers[i];
        }

        public string AddErrorAns(int i)
        {
            return fillingEasyTest.FalseAnswers[i];
        }

    }
}
