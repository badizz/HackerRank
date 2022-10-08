using System;

public class gradingStudent
{
    // solution 1
    public static List<int> gradingStudents(List<int> grades)
    {
        for (int i = 0; i < grades.Count; i++){
            int tmpGrade = grades[i];
            if (tmpGrade % 5 != 0 && tmpGrade > 37){
                do
                {
                    tmpGrade++;
                } while (tmpGrade % 5 != 0);

                if ((tmpGrade - grades[i]) < 3){
                    grades[i] = tmpGrade;
                }
            }
        }
        return grades;
    }

    // other way
    public static List<int> gradingStudents2(List<int> grades)
    {
        for (int i = 0; i < grades.Count; i++){
            int tmpGrade = grades[i];
            if (tmpGrade > 37){
                int diff = 5 - (tmpGrade % 5);
                if (diff < 3) {
                    grades[i] = tmpGrade + diff;
                }
            }
        }
        return grades;
    }

    // Solution includes Ternary Operator
    public static List<int> gradingStudents3(List<int> grades)
    {
        for (int i = 0; i < grades.Count; i++)
        {
            grades[i] = (grades[i] < 38 || (grades[i] % 5 < 3)) ? grades[i] : (grades[i] + (5 - grades[i] % 5));
        }
        return grades;
    }

}
