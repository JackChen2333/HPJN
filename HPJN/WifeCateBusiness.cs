using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
//using System.Threading.Tasks;

namespace HPJN
{
    class WifeCateBusiness
    {
        WifeRepo wifeRepo = new WifeRepo();

        public List<Notice> GetNotice()
        {
            return wifeRepo.GetNotice();
        }

        public List<WifeCate> GetAllType()
        {
            return wifeRepo.GetAllType();
        }

        public List<EquipCate> GetEquipAllType()
        {
            return wifeRepo.GetEquipAllType();
        }

        public List<WifeInfo> GetInfoByType(int i)
        {
            return wifeRepo.GetInfoByType(i);
        }

        public List<WifeInfoUp> GetUpInfoByType(int i)
        {
            return wifeRepo.GetUpInfoByType(i);
        }

        public List<EquipInfo> GetEquipInfoByType(int i)
        {
            return wifeRepo.GetEquipInfoByType(i);
        }

        public List<WifeDrop> GetDropByType(int i)
        {
            return wifeRepo.GetDropByType(i);
        }

        public List<MapDrop> GetDropByMap()
        {
            return wifeRepo.GetDropByMap();
        }

        public List<ShipBuildingTime> GetBuildingTime()
        {
            return wifeRepo.GetBuildingTime();
        }

        public List<ShipBuildingFormula> GetBuildingFormula()
        {
            return wifeRepo.GetBuildingFormula();
        }

        public List<Expedition> GetExpe()
        {
            return wifeRepo.GetExpe();
        }

        public List<MapPath> GetPath()
        {
            return wifeRepo.GetPath();
        }
    }
}
