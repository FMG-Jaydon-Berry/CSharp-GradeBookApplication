using System;
using System.Collections.Generic;
using System.Text;
using GradeBook.GradeBooks;
using GradeBook.Enums;

namespace GradeBook.GradeBooks
{
    class StandardGradeBook : BaseGradeBook
    {
        public StandardGradeBook(string name, bool string) : base(name, isWeighted)
        {
            Name = name;
            IsWeighted = isWeighted;
            Students = new List<Student>();
            Type = GradeBookType.Standard;
        }
    }
}
