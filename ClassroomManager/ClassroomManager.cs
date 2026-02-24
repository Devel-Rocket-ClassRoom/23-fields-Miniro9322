using System;

class ClassroomManager
{
    private const int MaxStudent = 5;
    private readonly string _className;
    private string[] _studentName;
    private int _currentStudent = 0;
    private static int s_totalClass = 0;

    public ClassroomManager(string className)
    {
        this._className = className;
        this._studentName = new string[MaxStudent];
        s_totalClass++;
    }

    public void AddStudent(string name)
    {
        for(int i = 0; i < MaxStudent; i++)
        {
            if(_studentName[i] == null)
            {
                _studentName[i] = name;
                _currentStudent++;
                break;
            }
        }
    }

    public void ShowStudents()
    {
        Console.WriteLine($"=== {_className} 학생 목록 ({_currentStudent}/{MaxStudent}) ===");
        for(int i = 0;i < MaxStudent; i++)
        {
            if(_studentName[i] == null)
            {
                break;
            }
            Console.WriteLine($"{i + 1}. {_studentName[i]}");
        }
    }

    public static void ShowTotalClassrooms()
    {
        Console.WriteLine($"전체 교실 수: {s_totalClass}");
    }


}