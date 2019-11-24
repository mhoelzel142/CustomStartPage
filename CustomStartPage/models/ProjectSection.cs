using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomStartPage.models
{
    public class ProjectSection
    {
        public string Timeframe { get; set; }
        public List<ProjectDetails> ProjectsList { get; set; }
    }
}
