namespace School_classes
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    public class Disciplines : IComment
    {
        private DisciplineList disciplineName;
        private int numberOfLectures;
        private int numberOfExercises;
        private List<string> textBlock = new List<string>(); //For IComment

        public Disciplines(DisciplineList discipline, int numLectures, int numExercises)    //Constructor
        {
            this.DisciplineName = discipline;
            this.NumberOfLectures = numLectures;
            this.NumberOfExercises = numExercises;
        }

        public DisciplineList DisciplineName        //Property
        {
            get { return this.disciplineName; }
            set { this.disciplineName = value; }
        }

        public int NumberOfLectures             //Property
        {
            get { return this.numberOfLectures; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("Number Of Lectures cannot be negative");
                }
                this.numberOfLectures = value;
            }
        }
        public int NumberOfExercises
        {
            get { return this.numberOfExercises; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("Number Of Exercises cannot be negative");
                }
                this.numberOfExercises = value;
            }
        }


        public void AddComent(string comment) //For IComment
        {
            textBlock.Add(comment);
        }

        public override string ToString()  //Override method ToString()
        {
            //return String.Format("{0},{1},{2}", this.disciplineName, this.NumberOfLectures,this.NumberOfExercises, string.Join("\n", textBlock));
            return String.Format("{0}", this.disciplineName);
        }
    }
}
