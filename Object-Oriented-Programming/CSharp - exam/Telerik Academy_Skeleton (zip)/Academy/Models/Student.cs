namespace Academy.Models
{
    using Contracts;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using Utils.Contracts;

    public class Student : Human, IStudent
    {
        private Track track;
        private IList<ICourseResult> courseResults = new List<ICourseResult>();

        public Student(string userName, Track tr) : base(userName)
        {
            this.Track = tr;
        }

        public IList<ICourseResult> CourseResults
        {
            get
            {
                return this.courseResults;
            }

            set
            {
                this.courseResults = (value);
            }
        }

        public Track Track
        {
            get
            {
                return this.track;
            }

            set
            {
                if (value == 0)
                {
                    throw new ArgumentNullException("The provided track is not valid!");
                }
                this.track = value;
            }
        }

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();
            result.Append("* Student: \n");
            result.AppendFormat(" - Username: {0}\n", this.Username);
            result.AppendFormat(" - Track: {0}\n", this.Track);
            result.AppendFormat(" - Course results: {0}\n", this.CourseResults.Count > 0 ? String.Join(",", this.CourseResults) : "\n  * User has no course results!");
            //result.Append(" * User has no course results!");
            return result.ToString();
        }
    }
}
