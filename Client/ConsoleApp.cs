using Domain;
using Repositories.MenuItems;
using Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainUI
{
    internal class ConsoleApp
    {


        public static void Main(string[] args)
        {
            MenuItemsRepository menuItemsRepository = new MenuItemsRepository();
            ClientService clientService = new ClientService(menuItemsRepository);

            // Testing
            clientService.GetMenuItems();

        }
    }
}
