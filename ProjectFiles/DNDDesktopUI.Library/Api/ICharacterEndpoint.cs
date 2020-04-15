using DNDDesktopUI.Library.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DNDDesktopUI.Library.Api
{
    public interface ICharacterEndpoint
    {
        Task<List<CharacterModel>> GetAll();
    }
}