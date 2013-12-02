using System.Globalization;
using System.Web.Mvc;

namespace MvcModels.Infrastructure
{
    public class CountryValueProvider : IValueProvider
    {
        public bool ContainsPrefix(string prefix)
        {
            return prefix.ToLower().Contains("country");
        }

        public ValueProviderResult GetValue(string key)
        {
            if (ContainsPrefix(key))
                return new ValueProviderResult("USA", "USA", CultureInfo.InvariantCulture);
            
            return null;
        }
    }

    public class CustomValueProviderFactory : ValueProviderFactory
    {
        public override IValueProvider GetValueProvider(ControllerContext controllerContext)
        {
            return new CountryValueProvider();
        }
    }
}