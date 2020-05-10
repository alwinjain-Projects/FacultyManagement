using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FacultyManagement.Models
{
    interface ICourseRepository
    {
        IQueryable<FacultyResponse> Faculty { get; }
    }
}
