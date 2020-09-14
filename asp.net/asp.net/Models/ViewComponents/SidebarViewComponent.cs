using asp.net.Domain;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace asp.net.Models.ViewComponents
{
    public class SidebarViewComponent:ViewComponent
    {
        private readonly DataManager manager;

        public SidebarViewComponent(DataManager dataManager) => manager = dataManager;

        public Task<IViewComponentResult> InvokeAsync()
        {
            return Task.FromResult((IViewComponentResult) View("Default",manager.ServiceItems.GetServiceItems()));
        }
    }
}
