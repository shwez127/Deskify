using OfficeDeskEntity.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OfficeDeskDAL.Repository
{
    public interface IFloorRepository
    {
        //Method Definition's for FloorEntity

        void AddFloor(Floor floor);
        void UpdateFloor(Floor floor);
        void DeleteFloor(int floorId);
        Floor GetFloorById(int floorId);
        IEnumerable<Floor> GetFloor();
    }
}
