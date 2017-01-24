namespace Academy.Models
{
    using Contracts;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    public class Course : ICourse
    {
        private string name;
        private int lecturesPerWeek;
        private DateTime startingDate;
        private DateTime endingDate;
        private IList<ILecture> lectures;
        private IList<IStudent> onlineStudents;
        private IList<IStudent> onsiteStudents;

        public Course(string name, int lecturesPW, DateTime startDate)
        {
            //this.Season = season;
            this.Name = name;
            this.LecturesPerWeek = lecturesPW;
            this.StartingDate = startDate;
            this.EndingDate = startingDate.AddDays(30);
        }

        public DateTime EndingDate
        {
            get
            {
                return this.endingDate;
            }

            set
            {
                this.endingDate = value;
            }
        }

        public IList<ILecture> Lectures
        {
            get
            {
                return this.lectures;
            }
        }

        public int LecturesPerWeek
        {
            get
            {
                return this.lecturesPerWeek;
            }

            set
            {
                if (value < 1 || value > 7)
                {
                    throw new ArgumentOutOfRangeException("The number of lectures per week must be between 1 and 7!");
                }
                this.lecturesPerWeek = value;
            }
        }

        public string Name
        {
            get
            {
                return this.name;
            }

            set
            {
                if (value.Length < 3 || value.Length > 45)
                {
                    throw new ArgumentOutOfRangeException("The name of the course must be between 3 and 45 symbols!");
                }
                this.name = value;
            }
        }

        public IList<IStudent> OnlineStudents
        {
            get
            {
                return this.onlineStudents;
            }
            set
            {
                this.onlineStudents = value;
            }
        }

        public IList<IStudent> OnsiteStudents
        {
            get
            {
                return this.onsiteStudents;
            }
            set
            {
                this.onsiteStudents = value;
            }
        }

        public DateTime StartingDate
        {
            get
            {
                return this.startingDate;
            }

            set
            {
                this.startingDate = value;
            }
        }

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();
            result.Append("* Course\n");
            result.AppendFormat(" - Name: {0}\n", this.Name);
            result.AppendFormat(" - Lectures per week: {0}\n", this.LecturesPerWeek);
            result.AppendFormat(" - Ending date: {0:dd-MM-yyyy}\n", this.EndingDate);
            result.AppendFormat(" - Onsite students: {0}\n", this.OnsiteStudents.Count);
            result.AppendFormat(" - Online students: {0}\n", this.OnlineStudents.Count);
            result.AppendFormat(" - Lectures: {0}\n", this.Lectures.Count == 0 ? " \n  * There are no lectures in this course!" : String.Join(",", this.Lectures));
            
            return result.ToString();
        }


    }
}
