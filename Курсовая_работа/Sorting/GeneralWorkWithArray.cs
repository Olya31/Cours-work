namespace Cours_work.Sorting
{
    public class GeneralWorkWithArray
    {
        private void ArrayOutput(int[] array, string infoMessage)
        {
            Console.WriteLine(infoMessage);
            for (int i = 0; i < array.Length; ++i)
            {
                Console.WriteLine($"{array[i]} ");
            }
        }

        private void ArrayFilling(int[] array)
        {
            var canDoNextStep = false;
            int? choose = null;

            while (!canDoNextStep)
            {
                if (choose == 1) //заполнение массива рандомными числами
                {
                    canDoNextStep = true;
                    Random rand = new Random();
                    for (int i = 0; i < array.Length; i++)
                        array[i] = rand.Next();
                }
                else if (choose == 2) //заполнение массива с клавиатуры
                {
                    canDoNextStep = true;

                    for (int i = 0; i < array.Length; i++)
                    {
                        Console.Write("Введите число:");
                        array[i] = Convert.ToInt32(Console.ReadLine());
                    }
                }
                else
                {
                    Console.WriteLine("Как заполнить массив: 1. Рандомным способом, 2. Ручным (С клавиатуры)");
                    choose = Convert.ToInt32(Console.ReadLine());
                }
            }
        }

        public void StartWork()
        {
            try
            {
                Console.WriteLine("Введите размерность массива: ");
                var size = Convert.ToInt32(Console.ReadLine());

                int[] array = new int[size]; //создаём массив

                ArrayFilling(array);

                if (size != 1)
                {
                    var quickSorting = new QuickSorting();
                    ArrayOutput(array, "Массив для сортировки:");
                    //сортируем массив -> первый параметр отвечает за массив,
                    //который нужно отсортировать, второй за начальный элемент сортировки, третий - за конечный элемент сортировки 
                    quickSorting.QuickSort(array, 0, array.Length - 1);         
                }

                ArrayOutput(array, "Отсортированный массив:");

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }
    }
}
