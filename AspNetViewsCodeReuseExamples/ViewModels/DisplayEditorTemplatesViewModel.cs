using AspNetViewsCodeReuseExamples.Models;

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
    }
}