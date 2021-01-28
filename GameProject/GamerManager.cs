using System;

namespace GameProject
{
    // Bir class içerisinde başka bir sınıf, manager kullanılacaksa onu asla new'leme.
    // Onun yerine constructor'da oluştur. Bu şekilde yapıldığında bağımlılığı var anlamına gelir.
    internal class GamerManager : IGamerService
    {
        private readonly IUserValidationService _userValidationService;

        public GamerManager(IUserValidationService userValidationService)
        {
            _userValidationService = userValidationService;
        }

        public void Add(Gamer gamer)
        {
            Console.WriteLine(_userValidationService.Validate(gamer)
                ? "Kayıt oldu."
                : "Doğrulama başarısız. Kayıt başarısız.");
        }

        public void Update(Gamer gamer)
        {
            Console.WriteLine("Kayıt güncellendi.");
        }

        public void Delete(Gamer gamer)
        {
            Console.WriteLine("Kayıt silindi.");
        }
    }
}