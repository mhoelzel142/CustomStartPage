using CustomStartPage.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomStartPage.viewmodels
{
    public class MainWindowViewModel
    {
        public List<ProjectSection> Projects { get; set; }
        public ProjectSection ProjectsToday { get; set; }
        public ProjectSection ProjectsThisWeek { get; set; }
        public ProjectSection ProjectsLastWeek { get; set; }
        public ProjectSection ProjectsThisMonth { get; set; }
        public ProjectSection ProjectsLastMonth { get; set; }
        public ProjectSection ProjectsOlder { get; set; }

        // Instantiate the viewmodel with some test data for layout purposes.  
        // Will build a service to get this from the PrivateRegistry hive at a later date. 
        public MainWindowViewModel()
        {
            Projects = new List<ProjectSection>();

            ProjectsToday = new models.ProjectSection()
            {
                Timeframe = "Today",
                ProjectsList = new List<ProjectDetails>(){
                    new ProjectDetails(){ProjectDirectory = "C:\\Test", ProjectName = "TestProject"}
                }
            };
            ProjectsThisWeek = new ProjectSection()
            {
                Timeframe = "This Week",
                ProjectsList = new List<ProjectDetails>()
                {
                    new ProjectDetails(){ProjectDirectory="C:\\Users\\Me\\Source\\Repos\\Project.sln", ProjectName = "AnotherProject.sln"}, 
                    new ProjectDetails(){ProjectDirectory="C:\\Users\\Me\\Source\\Repos\\YetAnotherProject.sln", ProjectName = "YetAnotherProject.sln"}, 
                    new ProjectDetails(){ProjectDirectory="C:\\Users\\Me\\Source\\Repos\\SomeOtherProject.sln", ProjectName = "SomeOtherProject.sln"}
                }
            };
            ProjectsLastWeek = new ProjectSection()
            {
                Timeframe = "Last Week",
                ProjectsList = new List<ProjectDetails>()
                {
                    new ProjectDetails(){ProjectDirectory="C:\\Users\\Me\\Source\\Repos\\Project.sln", ProjectName = "ProjectNumber2.sln"},
                    new ProjectDetails(){ProjectDirectory="C:\\Users\\Me\\Source\\Repos\\MoreProjects.sln", ProjectName = "MoreProjects.sln"},
                    new ProjectDetails(){ProjectDirectory="C:\\Users\\Me\\Source\\Repos\\EvenMoreProjects.sln", ProjectName = "EvenMoreProjects.sln"},
                    new ProjectDetails(){ProjectDirectory="C:\\Users\\Me\\Source\\Repos\\Jeebus.sln", ProjectName = "JeezThatsALotOfProjects.sln"},
                    new ProjectDetails(){ProjectDirectory="C:\\Users\\Me\\Source\\Repos\\ForeverAlone.sln", ProjectName = "YouWillDieAloneWithYourProjects.sln"}
                }
            };
            ProjectsThisMonth = new ProjectSection()
            {
                Timeframe = "This Month",
                ProjectsList = new List<ProjectDetails>()
                {
                    new ProjectDetails(){ProjectDirectory="C:\\Users\\Me\\Source\\Repos\\MyBestProject.sln", ProjectName = "ThatUnfinishedThing.sln"},
                    new ProjectDetails(){ProjectDirectory="C:\\Users\\Me\\Source\\Repos\\ThisOneIsEpic.sln", ProjectName = "ThisOneWillBeGreat.sln"},
                    new ProjectDetails(){ProjectDirectory="C:\\Users\\Me\\Source\\Repos\\MillionDollarIdea.sln", ProjectName = "MillionDollarIdea.sln"}
                }
            };
            Projects.Add(ProjectsToday);
            Projects.Add(ProjectsThisWeek);
            Projects.Add(ProjectsLastWeek);
            Projects.Add(ProjectsThisMonth);
        }
    }
}
