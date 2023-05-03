using System;
namespace Cours_work.Sorting
{
    public class QuickSorting
    {
        //алгоритм быстрой сортировки
        public void QuickSort(int[] array, int first, int last)
        {
            var compareElement = array[last]; //элемент массива, с которым будет сравниваться текущий элемент
            var firstElement = first; //начальный элемент сортировка
            var lastElement = last; //конечный элемент сортировка

            //заменяем элементы до тех пор, пока начальный элемент меньше иили равен конечному
            do
            {
                //увеличиваем начальный элемент сортировки, пока текущий элемент меньше того, с которого нужно начинать сортировку  
                while (array[firstElement] < compareElement)
                    ++firstElement;

                //если текущий элемент сортировки больше, чем элемент сортировки, которым она должна закончиться, то мы уменьшаем конечный элемент
                while (array[lastElement] > compareElement)
                    --lastElement;

                //если начальный элемент сортировки, меньше конечного элемента сортировки, то меням их местами
                if (firstElement <= lastElement)
                {
                    //замена мест
                    int temp = array[firstElement];
                    array[firstElement] = array[lastElement];
                    array[lastElement] = temp;

                    //обновляем начальный и конечный указатели сортировки
                    ++firstElement;
                    --lastElement;
                }
            }
            while (firstElement <= lastElement);

            //разделение массива на две части
            if (lastElement > first)
                QuickSort(array, first, lastElement);

            if (firstElement < last)
                QuickSort(array, firstElement, last);
        }
    }
}
