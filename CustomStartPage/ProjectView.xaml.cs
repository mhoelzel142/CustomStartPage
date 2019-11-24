using CustomStartPage.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace CustomStartPage
{
    /// <summary>
    /// Interaction logic for ProjectView.xaml
    /// </summary>
    public partial class ProjectView : UserControl
    {
        public string Timeframe { get; set; }
        public List<ProjectDetails> Projects { get; set; }

        public static readonly DependencyProperty TimeframeProperty =
            DependencyProperty.Register("Timeframe", typeof(string), typeof(ProjectView));
        public static readonly DependencyProperty ItemsSourceProperty =
            DependencyProperty.Register("Projects", typeof(List<ProjectDetails>), typeof(ProjectView));

        public ProjectView()
        {
            InitializeComponent();
        }
    }
}
