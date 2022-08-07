using EmployeeManager.Common.DTO;
using EmployeeManager.Core.Entities;
using EmployeeManager.Infrastructure;
using EmployeeManager.Services.Interfaces;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeManager.Services.Services
{
    public class ContactUsMessageService:IContactUsMessageService
    {
        private EmployeeContext _context;
        public ContactUsMessageService(EmployeeContext context)
        {
            _context = context;
        }
        public async Task<ContactUsMessageDTO> Delete(int id)
        {
            var entity = await _context.ContactUsMessage.FirstOrDefaultAsync(x => x.ContactUsMessageID==id);
            _context.ContactUsMessage.Remove(entity);
            await _context.SaveChangesAsync();
            return MapperDTO(entity);
        }

        public async Task<List<ContactUsMessageDTO>> Get()
        {
            var list = await _context.ContactUsMessage.ToListAsync();
            var listMap = list.Select(x => MapperDTO(x)).ToList();
            return listMap;
        }

        public async Task<ContactUsMessageDTO> Insert(ContactUsMessageDTO request)
        {
            var entity = Mapper(request);
            _context.ContactUsMessage.Add(entity);
            await _context.SaveChangesAsync();
            return MapperDTO(entity);
        }

        public async Task<ContactUsMessageDTO> Update(ContactUsMessageDTO request, int id)
        {
            var entity = _context.ContactUsMessage.Find(id);
            entity = Mapper(request);
            await _context.SaveChangesAsync();
            return MapperDTO(entity);
        }
        private ContactUsMessageDTO MapperDTO(ContactUsMessage contactusmessage)
        {
            if (contactusmessage == null)
                return null;

            var entity = new ContactUsMessageDTO();
            entity.ContactUsMessageID = contactusmessage.ContactUsMessageID;
            entity.YourName = contactusmessage.YourName;
            entity.YourEmail = contactusmessage.YourEmail;
            entity.YourPhone = contactusmessage.YourPhone;
            entity.YourMessage = contactusmessage.YourMessage;
            return entity;
        }
        private ContactUsMessage Mapper(ContactUsMessageDTO contactusmessage)
        {
            if (contactusmessage == null)
                return null;

            var entity = new ContactUsMessage();
            entity.ContactUsMessageID = contactusmessage.ContactUsMessageID;
            entity.YourName = contactusmessage.YourName;
            entity.YourEmail = contactusmessage.YourEmail;
            entity.YourPhone = contactusmessage.YourPhone;
            entity.YourMessage = contactusmessage.YourMessage;
            return entity;
        }
    }
}