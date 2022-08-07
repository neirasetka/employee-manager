using EmployeeManager.API.Entities;
using EmployeeManager.Common.DTO;
using EmployeeManager.Infrastructure;
using EmployeeManager.Services.Interfaces;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeManager.Services.Services
{
    public class ClientService : IClientService
    {
        private EmployeeContext _context;
        public ClientService(EmployeeContext context)
        {
            _context = context;
        }
        public async Task<ClientDTO> DeleteById(int id)
        {
            var entity = await _context.Client.FirstOrDefaultAsync(x => x.ClientID == id);
            _context.Client.Remove(entity);
            await _context.SaveChangesAsync();
            return MapperDTO(entity);
        }

        public async Task<List<ClientDTO>> Get()
        {
            var list = await _context.Client.ToListAsync();
            var listMap = list.Select(x => MapperDTO(x)).ToList();
            return listMap;
        }

        public async Task<ClientDTO> Insert(ClientDTO request)
        {
            var entity = Mapper(request);
            _context.Client.Add(entity);
            await _context.SaveChangesAsync();
            return MapperDTO(entity);
        }

        public async Task<ClientDTO> GetClientById(int id)
        {
            //Client client = _context.Client.Find(id);
            var client = _context.Client.Where(a => a.ClientID == id).Select(c => new ClientDTO()
            {
                ClientID = c.ClientID,
                BusinessName = c.BusinessName,
                ContactName = c.ContactName,
                HomeAddress=c.HomeAddress,
                Email = c.Email,
                Status = c.Status,
                ProjectID = c.ProjectID,
                IsDeleted = c.IsDeleted,
                Project=c.Project,
                PhoneNumber = c.PhoneNumber,
                ZipCity = c.ZipCity,
            }).FirstOrDefault();

            return client;
        }
        public async Task<ClientDTO> Update(ClientDTO request, int id)
        {
            var entity = _context.Client.Find(id);
            entity = Mapper(request);
            await _context.SaveChangesAsync();
            return MapperDTO(entity);
        }
        private ClientDTO MapperDTO(Client client)
        {
            if (client == null)
                return null;

            var entity = new ClientDTO();
            entity.ClientID = client.ClientID;
            entity.BusinessName = client.BusinessName;
            entity.ContactName = client.ContactName;
            entity.HomeAddress = client.HomeAddress;
            entity.Email = client.Email;
            entity.Status = client.Status;
            entity.ProjectID = client.ProjectID;
            entity.IsDeleted = client.IsDeleted;
            entity.Project = client.Project;
            entity.PhoneNumber = client.PhoneNumber;
            entity.ZipCity = client.ZipCity;
            return entity;
        }

        private Client Mapper(ClientDTO client)
        {
            if (client == null)
                return null;

            var entity = new Client();
            entity.ClientID = client.ClientID;
            entity.BusinessName = client.BusinessName;
            entity.ContactName = client.ContactName;
            entity.HomeAddress = client.HomeAddress;
            entity.Email = client.Email;
            entity.Status = client.Status;
            entity.ProjectID = client.ProjectID;
            entity.IsDeleted = client.IsDeleted;
            entity.Project = client.Project;
            entity.PhoneNumber = client.PhoneNumber;
            entity.ZipCity = client.ZipCity;
            return entity;
        }
    }
}