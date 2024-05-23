using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Repositories.MenuItems;


namespace Services
{
    public class ClientService
    {
        private readonly IMenuItemsRepository _menuItemsRepository;
        public ClientService(IMenuItemsRepository menuItemsRepository)
        {
            _menuItemsRepository = menuItemsRepository;
        }

        public IEnumerable<MenuItem> GetMenuItems()
        {
            return _menuItemsRepository.GetAll();
        }
    }
}
