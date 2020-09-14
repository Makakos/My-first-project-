using asp.net.Domain.Entitys;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace asp.net.Domain.Repositories.Abstract
{
    public interface ITextFieldsRepository
    {
         IQueryable<TextField> GetTextFields();
         TextField GetTextFieldById(Guid id);
         TextField GetTextFieldByCodeWord(string CodeWord);
         void SaveTextField(TextField entity);
         void DeleteTextField(Guid id);
    }
}
