using AspNetViewsCodeReuseExamples.Models;
using IdmbAccess;

namespace AspNetViewsCodeReuseExamples.ViewModels
{
    public class DisplayEditorTemplatesViewModel
    {
        public DisplayEditorTemplatesViewModel()
        {
            User = new User();
        }

        public bool AreYouOk { get; set; }
        public User User { get; set; }
        public Movie Movie { get; set; }
        public Movie SpecialMovie { get; set; }
    }
}