using EmployeeManager.Common.DTO;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace EmployeeManager.Services.Interfaces
{
    public interface IContactUsMessageService
    {
        Task<ContactUsMessageDTO> Delete(int id);
        Task<List<ContactUsMessageDTO>> Get();
        Task<ContactUsMessageDTO> Insert(ContactUsMessageDTO request);
        Task<ContactUsMessageDTO> Update(ContactUsMessageDTO request, int id);
    }
}
