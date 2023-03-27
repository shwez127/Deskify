using OfficeDeskEntity.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OfficeDeskDAL.Repository
{
    public interface IChoicesRepository
    {
        void AddChoice(Choices choice);
        void DeleteChoice(int choiceId);
        void UpdateChoice(Choices choice);
        Choices GetChoiceById(int choiceId);
        IEnumerable<Choices> GetAllChoices();
    }
}
