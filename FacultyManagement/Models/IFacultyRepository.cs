using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FacultyManagement.Models
{
    public interface IFacultyRepository
    {
        IQueryable<FacultyResponse> Faculty { get; }
        IQueryable<FeedbackResponse> Feedback { get; }

        void SaveFaculty(FacultyResponse faculty);

        FacultyResponse DeleteFaculty(int fid);

        void SaveFeedback(FeedbackResponse feedback);
    }
}
