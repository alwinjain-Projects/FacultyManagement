using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FacultyManagement.Models
{
    public class Repository : IFacultyRepository
    {
        private ApplicationDbContext context;
        private static List<FacultyResponse> fResponses = new List<FacultyResponse>();
        public static List<CourseResponse> cResponses = new List<CourseResponse>();
        private static List<CourseAndFaculty> cAfResponses = new List<CourseAndFaculty>();
        private static readonly List<FeedbackResponse> fedd = new List<FeedbackResponse>();

      

        public Repository(ApplicationDbContext ctx)
        {
            context = ctx;
           

           

          
        }
        public IQueryable<FacultyResponse> Faculty => context.Faculty;
        public IQueryable<FeedbackResponse> Feedback => context.FacultyFeedback;


        public void SaveFaculty(FacultyResponse faculty)
        {
            if (faculty.fId == 0)
            {
                context.Faculty.Add(faculty);
            }
            else
            {
                FacultyResponse facultyEntry = context.Faculty
                    .FirstOrDefault(p => p.fId == faculty.fId);

                if (facultyEntry != null)
                {
                    facultyEntry.fName = faculty.fName;
                    facultyEntry.fLastName = faculty.fLastName;

                }
            }
            context.SaveChanges();
        }

        public void SaveFeedback(FeedbackResponse Feeds)
        {

            context.FacultyFeedback.Add(Feeds);


            //fedd.Add(Feeds);
            context.SaveChanges();

        }

        public FacultyResponse DeleteFaculty(int fid)
        {
            FacultyResponse facultyDelete = context.Faculty.FirstOrDefault(p => p.fId == fid);
            if (facultyDelete != null)
            {
                context.Faculty.Remove(facultyDelete);
                context.SaveChanges();
            }
            return facultyDelete;
        }












        public static IEnumerable<FeedbackResponse> Fedd
        {
            get
            {
                return fedd;
            }
        }

        public static IEnumerable<FacultyResponse> FResponses
        {
            get
            {
                return fResponses;
            }
        }

        public static void AddFResponse(FacultyResponse FacultyResponses)
        {
            fResponses.Add(FacultyResponses);

        }

        public static IEnumerable<CourseResponse> CResponses
        {
            get
            {
                return cResponses;
            }
        }

        public static void AddCResponse(CourseResponse courseResponses)
        {
            cResponses.Add(courseResponses);

        }

        public static IEnumerable<CourseAndFaculty> CAFResponses
        {
            get
            {
                return cAfResponses;
            }
        }
        public static void AddCAFResponse(CourseAndFaculty cAFResponses)
        {
            cAfResponses.Add(cAFResponses);

        }
        public static List<CourseResponse> GetCourse()
        {
            return cResponses;
        }
        public static List<FacultyResponse> GetFaculty()
        {
            return fResponses;
        }






    }
}
