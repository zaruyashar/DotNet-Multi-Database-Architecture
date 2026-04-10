using Microsoft.AspNetCore.Mvc;
using TransportationMongoDB.Services.QuestionServices;

namespace TransportationMongoDB.ViewComponents.DefaultComponents
{
    public class _DefaultFAQComponentPartial : ViewComponent
    {
        private readonly IQuestionService _questionService;

        public _DefaultFAQComponentPartial(IQuestionService QuestionService)
        {
            _questionService = QuestionService;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var values = await _questionService.GetAllQuestionsAsync();
            return View(values);
        }
    }
}
