using Microsoft.AspNetCore.Mvc;
using TransportationMongoDB.Services.ProjectSectionServices;

namespace TransportationMongoDB.ViewComponents.DefaultComponents
{
    public class _DefaultWhatWeHaveDoneComponentPartial : ViewComponent
    {
        private readonly IProjectSectionService _projectSectionService;

        public _DefaultWhatWeHaveDoneComponentPartial(IProjectSectionService ProjectSectionService)
        {
            _projectSectionService = ProjectSectionService;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var values = await _projectSectionService.GetAllProjectSectionsAsync();
            return View(values);
        }
    }
}
