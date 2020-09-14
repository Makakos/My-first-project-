using asp.net.Domain.Entitys;
using asp.net.Domain.Repositories.Abstract;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace asp.net.Domain.Repositories.EntityFramework
{
    public class EFTextFieldsRepotitory: ITextFieldsRepository
    {
        private readonly SiteContext context;
        public EFTextFieldsRepotitory(SiteContext context)
        {
            this.context = context;
        }

        public IQueryable<TextField> GetTextFields()
        {
            return context.TextFields;
        }

        public TextField GetTextFieldById(Guid id)
        {
            return context.TextFields.FirstOrDefault(x => x.Id == id);
        }

        public TextField GetTextFieldByCodeWord(string CodeWord)
        {
            return context.TextFields.FirstOrDefault(x => x.CodeWord == CodeWord);
        }

        public void SaveTextField(TextField entity)
        {
            if (entity.Id == default)
                context.Entry(entity).State = EntityState.Added;
            else
                context.Entry(entity).State = EntityState.Modified;
            context.SaveChanges();
        }

        public void DeleteTextField(Guid id)
        {
            context.TextFields.Remove(new TextField() { Id = id });
        }

      
    }
}
