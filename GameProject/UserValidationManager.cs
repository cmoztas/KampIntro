using MernisGamerValidationService;
using System;
using System.Threading.Tasks;

namespace GameProject
{
    internal class UserValidationManager : IUserValidationService
    {
        private readonly MernisGamerValidationService.KPSPublicSoapClient _service;

        public UserValidationManager(KPSPublicSoapClient service)
        {
            _service = service;
        }

        public bool Validate(Gamer gamer)
        {
            Task<TCKimlikNoDogrulaResponse> isValidated = _service.TCKimlikNoDogrulaAsync(Convert.ToInt64(gamer.IdentityNumber), gamer.FirstName.ToUpper(), gamer.Lastname.ToUpper(), gamer.BirthDate.Year);

            return isValidated.Result.Body.TCKimlikNoDogrulaResult;
        }
    }
}