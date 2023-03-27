using Microsoft.EntityFrameworkCore;
using OfficeDeskDAL.Data;
using OfficeDeskEntity.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OfficeDeskDAL.Repository
{
    public class ChoicesRepository : IChoicesRepository
    {
        DeskDbContext _db;
        public ChoicesRepository(DeskDbContext db)
        {
            _db = db;
        }
        public void AddChoice(Choices choice)
        {
            _db.choices.Add(choice);
            _db.SaveChanges();
        }

        public void DeleteChoice(int choiceId)
        {
            var choice = _db.choices.Find(choiceId);
            _db.choices.Remove(choice);
            _db.SaveChanges();
        }

        public IEnumerable<Choices> GetAllChoices()
        {
            return _db.choices.ToList();
        }

        public Choices GetChoiceById(int choiceId)
        {
            return _db.choices.Find(choiceId);
        }

        public void UpdateChoice(Choices choice)
        {
            _db.Entry(choice).State = EntityState.Modified;
            _db.SaveChanges();
        }
    }
}
