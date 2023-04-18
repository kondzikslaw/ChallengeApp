namespace ChallengeApp
{
    public class Supervisor : IEmployee
    {
        private List<float> grades = new List<float>();
        public Supervisor(string name, string surname, string sex)
        {
            this.Name = name;
            this.Surname = surname;
            this.Sex = sex;
        }
        public string Name { get; private set; }

        public string Surname { get; private set; }

        public string Sex { get; private set; }

        public void AddGrade(float grade)
        {
            int valueInInt = (int)grade;
            if (grade >= 0 && grade <= 100)
            {
                this.grades.Add(grade);
            }
            else
            {
                throw new Exception("Please enter grade between 0 and 100.");
            }
        }

        public void AddGrade(string grade)
        {
            switch (grade)
            {
                case "1":
                    AddGrade(0);
                    break;
                case "+1":
                case "1+":
                    AddGrade(5);
                    break;
                case "-2":
                case "2-":
                    AddGrade(15);
                    break;
                case "2":
                    AddGrade(20);
                    break;
                case "+2":
                case "2+":
                    AddGrade(25);
                    break;
                case "-3":
                case "3-":
                    AddGrade(35);
                    break;
                case "3":
                    AddGrade(40);
                    break;
                case "-4":
                case "4-":
                    AddGrade(55);
                    break;
                case "4":
                    AddGrade(60);
                    break;
                case "+4":
                case "4+":
                    AddGrade(65);
                    break;
                case "-5":
                case "5-":
                    AddGrade(75);
                    break;
                case "5":
                    AddGrade(80);
                    break;
                case "+5":
                case "5+":
                    AddGrade(85);
                    break;
                case "-6":
                case "6-":
                    AddGrade(95);
                    break;
                case "6":
                    AddGrade(100);
                    break;
            }
        }

        public void AddGrade(int grade)
        {
            float gradeInFloat = grade;
            this.AddGrade(gradeInFloat);
        }

        public void AddGrade(char grade)
        {
            switch (grade)
            {
                case 'A':
                case 'a':
                    this.grades.Add(100);
                    break;
                case 'B':
                case 'b':
                    this.grades.Add(80);
                    break;
                case 'C':
                case 'c':
                    this.grades.Add(60);
                    break;
                case 'D':
                case 'd':
                    this.grades.Add(40);
                    break;
                case 'E':
                case 'e':
                    this.grades.Add(20);
                    break;
                default:
                    throw new Exception("Wrong Letter");
            }
        }

        public void AddGrade(double grade)
        {
            float gradeInFloat = (float)grade;
            this.AddGrade(gradeInFloat);
        }

        public void AddGrade(long grade)
        {
            float gradeInFloat = grade;
            this.AddGrade(gradeInFloat);
        }

        public Statistics GetStatistics()
        {
            var statistics = new Statistics();
            statistics.Average = 0;
            statistics.Max = float.MinValue;
            statistics.Min = float.MaxValue;

            foreach (var grade in this.grades)
            {
                statistics.Max = Math.Max(statistics.Max, grade);
                statistics.Min = Math.Min(statistics.Min, grade);
                statistics.Average += grade;
            }

            statistics.Average /= this.grades.Count;

            switch (statistics.Average)
            {
                case var average when average >= 80:
                    statistics.AverageLetter = 'A';
                    break;
                case var average when average >= 60:
                    statistics.AverageLetter = 'B';
                    break;
                case var average when average >= 40:
                    statistics.AverageLetter = 'C';
                    break;
                case var average when average >= 20:
                    statistics.AverageLetter = 'D';
                    break;
                default:
                    statistics.AverageLetter = 'E';
                    break;
            }

            return statistics;
        }
    }
}
