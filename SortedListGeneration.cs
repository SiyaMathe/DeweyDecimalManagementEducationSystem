using System.Collections.Generic;

namespace DeweyDecimalManagmentSystem
{
    class SortedListGeneration

    {
        //not needed anymore
        private List<double> SortedListFinal;
        //generating a sorted list using a recursive bubble sort
        public List<double> GenerateSortedList(List<double> UnsortedList)
        {
            var n = UnsortedList.Count;
            for (int i = 0; i < n - 1; i++)
                for (int j = 0; j < n - i - 1; j++)
                    if (SortedListFinal[j] > SortedListFinal[j + 1])
                    {
                        var tempVar = UnsortedList[j];
                        UnsortedList[j] = UnsortedList[j + 1];
                        UnsortedList[j + 1] = tempVar;
                    }



            SortedListFinal = UnsortedList;

            return SortedListFinal;
        }
    }
}
