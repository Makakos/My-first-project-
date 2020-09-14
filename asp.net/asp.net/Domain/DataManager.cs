using asp.net.Domain.Repositories.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace asp.net.Domain
{
    public class DataManager
    {
        public ITextFieldsRepository TextFields { get; set; }
        public IServicesItemRepository ServiceItems { get; set; }

        public DataManager(ITextFieldsRepository textFieldsRepository,IServicesItemRepository servicesItemRepository)
        {
            TextFields = textFieldsRepository;
            ServiceItems = servicesItemRepository;
        }
    }
}
