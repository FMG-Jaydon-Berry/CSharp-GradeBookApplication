using System;
using System.Collections.Generic;
using System.Text;
using GradeBook.GradeBooks;
using GradeBook.Enums;

namespace GradeBook.GradeBooks
{
    class StandardGradeBook : BaseGradeBook
    {
        public StandardGradeBook(string name, string isWeighted) : base(name, isWeighted)
        {
            Name = name;
            IsWeighted = bool.Parse(isWeighted);
            Students = new List<Student>();
            Type = GradeBookType.Standard;
        }
    }
}
