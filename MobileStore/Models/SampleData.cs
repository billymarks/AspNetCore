using System;
using System.Linq;
using Microsoft.Extensions.DependencyInjection;

namespace MobileStore.Models
{
    // роль инициализатора базы данных
    public static class SampleData
    {
        /// <summary>
        /// статический метод Initialize(), в котором происходит добавление трех начальных элементов - объектов Phone
        /// </summary>
        /// <param name="servicePovider">получаем контекст данных</param>
        public static void Initialize(IServiceProvider servicePovider)
        {
            var context = servicePovider.GetService<MobileContext>();

            if (!context.Phones.Any())
            {
                context.Phones.AddRange(
                    new Phone
                    {
                        Name = "Iphone 7s",
                        Company = "Apple",
                        Price = 600
                    },
                    new Phone
                    {
                        Name = "Meizu m5s",
                        Company = "Meizu",
                        Price = 130,
                    },
                    new Phone
                    {
                        Name = "Meizu m3 note",
                        Company = "Meizu",
                        Price = 130
                    }
                );
                context.SaveChanges();
            }
        }
    }
}
