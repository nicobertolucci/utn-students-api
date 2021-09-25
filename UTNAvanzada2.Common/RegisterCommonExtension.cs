using Microsoft.Extensions.DependencyInjection;
using UTNAvanzada2.Common.Implementations;

namespace UTNAvanzada2.Common
{
    public static class RegisterCommonExtension
    {
        public static IServiceCollection RegisterApplicationCommon(this IServiceCollection services)
        {
            return services.AddScoped(typeof(IJsonManager<>), typeof(JsonManager<>));
        }
    }
}
