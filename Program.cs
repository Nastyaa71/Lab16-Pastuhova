// Console.Write("Сколько студентов в группе? ");
// int studentsCount = int.Parse(Console.ReadLine());
// int[] grades = new int[studentsCount];
// int sum = 0;
// for (int i = 0; i < grades.Length; i++)
// {
//     Console.Write($"Оценка студента {i + 1}: ");
//     grades[i] = int.Parse(Console.ReadLine());
// }
// foreach (int grade in grades)
// {
//     Console.WriteLine(grade);
//     sum += grade;
// }
//  double average = (double)sum/studentsCount;
//  Console.WriteLine($"Средний балл группы: {average}");


// int[] points = {4,7,2,9,5,10,85};
// for (int i = 0; i < points.Length; i++)
// {   
//     if (points[i] < 10)
//     {
//          points[i] = points[i] + 1;
//     }
// }
// foreach (int point in points)
// {
//     Console.WriteLine(point);
// }


int[] grades = {4,5,3,5,4,2};
for (int i = 0; i < grades.Length - 1; i++)
{
    for (int j = 0; j < grades.Length - 1 - i; j++)
    {
        if (grades[j] < grades[j + 1])
        {
            int temp = grades[j];
            grades[j] = grades[j + 1];
            grades[j + 1] = temp;
        }
    }
}
foreach (int grade in grades)
{
    Console.WriteLine(grade);
}


// int[] GenerateSchedulSlots(int lessonsCount)
// {
//     int[] slots = new int[lessonsCount];
//     for (int i = 0; i < lessonsCount; i++)
//     {
//         slots[i] = i + 1;
//     }
//     return slots;
// }
// int[] slots = GenerateSchedulSlots(6);
// foreach (int slot in slots)
// {
//     Console.WriteLine(slot);
// }

// int[] GenerateEvenSlots(int lessonsCount)
// {
//     int[] slots = new int[lessonsCount];
//     for (int i = 0; i < lessonsCount; i++)
//     {
//         slots[i] = (i + 1) * 2;
//     }
//     return slots;
// }
// int[] slots = GenerateEvenSlots(6);
// foreach (int slot in slots)
// {
//     Console.WriteLine(slot);
// }


// int[] grades = {4,5,3,5,4,2};
// Array.Sort(grades);
// foreach(int grade in grades)
// {
//     Console.WriteLine(grade);
// }


// int[] num = {3,9,4,-4,6,-9};
// for (int i = 0; i < num.Length; i++)
// {
//     if (num[i] < 0)
//     {
//         num[i] = 0;
//     }
// }
// foreach (int n in num)
// {
//     Console.WriteLine(n);
// }


// Console.Write("Введите N: ");
// int N = int.Parse(Console.ReadLine());
// int[] num = new int[N];
// for (int i = 0; i < N; i++)
// {
//     num[i] = (i + 1) * (i + 1);
// }
// foreach (int n in num)
// {
//     Console.Write(n);
// } 


// Console.WriteLine("Введите свою фамилию");
// string surname = Console.ReadLine()!.Trim();

// if (string.IsNullOrEmpty(surname))
// {
//     Console.WriteLine("Фамилия не введена. Завершение работы.");
//     return;
// }

// Random rnd = new(surname.GetHashCode() + DateTime.Now.DayOfYear);

// var assigned = Enumerable.Range(1,10)
//     .OrderBy(_ => rnd.Next())
//     .Take(2)
//     .OrderBy(x => x)
//     .ToList();

// Console.WriteLine($"Задачи: №{assigned[0]} и №{assigned[1]}");


// int[] num = {3,9,4,-4,6,-9};
// for (int i = 0; i < num.Length; i++)
// {
//     if (num[i]%3==0)
//     { 
//         num[i] = -1;
//     }
// }
// foreach (int n in num)
// {
//     Console.WriteLine(n);
// }


// int count = int.Parse(Console.ReadLine());
// int[] numbers = new int[count];
// int sum = 0;
// for (int i = 0; i < count; i++)
// {
//     numbers[i] = int.Parse(Console.ReadLine());
//     sum += numbers[i];
// }
// Console.WriteLine(sum);