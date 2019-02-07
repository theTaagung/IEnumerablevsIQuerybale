using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IEnumerableVsIQueryable
{
    class Program
    {
        static void Main(string[] args)
        {
            StudyEntities studyEntities = new StudyEntities();
            QueryWithIEnumerable(studyEntities);
            QueryWithIQueryable(studyEntities);

            Console.ReadLine();
        }

        static void QueryWithIEnumerable(StudyEntities studyEntities)
        {
            IEnumerable<PROJECT_TEAM> projects =
                studyEntities.PROJECT_TEAM.Where(e => e.PRJ_ID.Equals("TAAGUNG"));
            Console.WriteLine(projects.ToString());
            projects = projects.Take(1);
            Console.WriteLine(projects.ToString());
            foreach (var project in projects)
            {
                Console.WriteLine(project.FRST_NM + " " + project.LAST_NM);
            }
        }
        static void QueryWithIQueryable(StudyEntities studyEntities)
        {

            IQueryable<PROJECT_TEAM> projects =
                studyEntities.PROJECT_TEAM.Where(e => e.PRJ_ID.Equals("TAAGUNG"));
           projects = projects.Take(1);
            Console.WriteLine(projects.ToString());

            foreach (var project in projects)
            {
                Console.WriteLine(project.FRST_NM + " " + project.LAST_NM);
            }
        }
    }
}
