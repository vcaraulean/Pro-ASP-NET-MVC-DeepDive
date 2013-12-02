using System.Web.Mvc;
using MvcModels.Models;

namespace MvcModels.Infrastructure
{
    public class AddressSummaryBinder : IModelBinder
    {
        public object BindModel(ControllerContext controllerContext, ModelBindingContext bindingContext)
        {
            var model = (AddressSummary)bindingContext.Model ?? new AddressSummary();

            model.City = GetValue(bindingContext, "City");
            model.Country = GetValue(bindingContext, "Country");
            return model;
        }

        private string GetValue(ModelBindingContext context, string key)
        {
            key = (context.ModelName == "" ? "" : context.ModelName + "." + key);

            var result = context.ValueProvider.GetValue(key);
            if (result == null || result.AttemptedValue == "")
                return "<not specified>";
            
            return result.AttemptedValue;
        }
    }
}