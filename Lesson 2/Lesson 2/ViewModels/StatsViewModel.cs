using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Lesson_2.ViewModels
{
    public class StatsViewModel
    {
        public int EmployeesCount { get; set; }
        public int DepartmentsCount { get; set; }
        public int ProjectsCount { get; set; }

        public IQueryable<IGrouping<string,string>> EmployeesPerProject { get; set; }

    }
}