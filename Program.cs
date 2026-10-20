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


int[] points = {4,7,2,9,5,10,85};
for (int i = 0; i < points.Length; i++)
{   
    if (points[i] < 10)
    {
         points[i] = points[i] + 1;
    }
}
foreach (int point in points)
{
    Console.WriteLine(point);
}