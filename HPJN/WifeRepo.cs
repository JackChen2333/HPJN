using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
//using System.Threading.Tasks;

namespace HPJN
{
    class WifeRepo
    {
        public List<Notice> GetNotice()
        {
            List<Notice> list = new List<Notice>();
            try
            {
                string sql = "select * from Notice";
                DataTable dt = DataAccess.GetDataTable(sql);
                foreach (DataRow dr in dt.Rows)
                {
                    Notice notice = new Notice();
                    notice.Notice1 = (string)dr["Notice1"];
                    notice.Notice2 = (string)dr["Notice4"];
                    notice.Notice3 = (string)dr["Notice5"];
                    notice.Notice4 = (string)dr["Notice6"];
                    notice.Notice5 = (string)dr["Notice7"];
                    notice.Notice6 = (string)dr["Notice8"];
                    notice.Notice7 = (string)dr["Notice9"];
                    notice.Notice8 = (string)dr["Notice10"];
                    list.Add(notice);
                }
            }
            catch (Exception)
            {
                throw;
            }
            return list;
        }

        public List<WifeCate> GetAllType()
        {
            List<WifeCate> list = new List<WifeCate>();
            try
            {
                string sql = "select * from Category";
                DataTable dt = DataAccess.GetDataTable(sql);
                foreach (DataRow dr in dt.Rows)
                {
                    WifeCate wifeCate = new WifeCate();
                    wifeCate.Type = (int)dr["Type"];
                    wifeCate.Name = (string)dr["Name"];
                    list.Add(wifeCate);
                }
            }
            catch (Exception)
            {
                throw;
            }
            return list;
        }

        public List<EquipCate> GetEquipAllType()
        {
            List<EquipCate> list = new List<EquipCate>();
            try
            {
                string sql = "select * from EquipCate";
                DataTable dt = DataAccess.GetDataTable(sql);
                foreach (DataRow dr in dt.Rows)
                {
                    EquipCate ec = new EquipCate();
                    ec.Type = (int)dr["Type"];
                    ec.Name = (string)dr["Name"];
                    list.Add(ec);
                }
            }
            catch (Exception)
            {
                throw;
            }
            return list;
        }

        public List<WifeInfo> GetInfoByType(int type)
        {
            List<WifeInfo> list = new List<WifeInfo>();
            try
            {
                string sql = "";

                if (type == 8)
                {
                    sql = "select * from INFO";
                }
                else
                {
                    sql = "select * from INFO where Type=" +
                        type.ToString();
                }
                DataTable dt = DataAccess.GetDataTable(sql);
                foreach (DataRow dr in dt.Rows)
                {
                    WifeInfo wife = new WifeInfo();

                    wife.Num = (string)dr["Num"];
                    wife.Name = (string)dr["Name"];
                    wife.Star = (int)dr["Star"];
                    wife.Shield = (int)dr["Shield"];
                    wife.Hp = (int)dr["Hp"];
                    wife.Fire = (int)dr["Fire"];
                    wife.Armor = (int)dr["Armor"];
                    wife.Resist = (int)dr["Resist"];
                    wife.Investigate = (int)dr["Investigate"];
                    wife.Maneuver = (int)dr["Maneuver"];
                    wife.Skill1 = (string)dr["Skill1"];
                    wife.Skill2 = (string)dr["Skill2"];
                    wife.Oil = (int)dr["ConOil"];
                    wife.Ammo = (int)dr["ConAmmo"];
                    wife.Equip = (int)dr["Equip"];
                    wife.Country = (string)dr["Country"];
                    wife.TotalAtt = (int)dr["TotalAtt"];
                    wife.EquipName1 = (string)dr["EquipName1"];
                    wife.EquipName2 = (string)dr["EquipName2"];
                    wife.EquipName3 = (string)dr["EquipName3"];
                    wife.EquipName4 = (string)dr["EquipName4"];

                    list.Add(wife);
                }
            }
            catch (Exception)
            {
                throw;
            }
            return list;
        }

        public List<WifeInfoUp> GetUpInfoByType(int type)
        {
            List<WifeInfoUp> list = new List<WifeInfoUp>();
            try
            {
                string sql = "";

                if (type == 8)
                {
                    sql = "select * from INFOLEVELUP";
                }
                else
                {
                    sql = "select * from INFOLEVELUP where Type=" +
                        type.ToString();
                }
                DataTable dt = DataAccess.GetDataTable(sql);
                foreach (DataRow dr in dt.Rows)
                {
                    WifeInfoUp wife = new WifeInfoUp();

                    wife.Num = (string)dr["Num"];
                    wife.Name = (string)dr["Name"];
                    wife.Star = (int)dr["Star"];
                    wife.Shield = (int)dr["Shield"];
                    wife.Hp = (int)dr["Hp"];
                    wife.Fire = (int)dr["Fire"];
                    wife.Armor = (int)dr["Armor"];
                    wife.Resist = (int)dr["Resist"];
                    wife.Investigate = (int)dr["Investigate"];
                    wife.Maneuver = (int)dr["Maneuver"];
                    wife.Skill1 = (string)dr["Skill1"];
                    wife.Skill2 = (string)dr["Skill2"];
                    wife.Oil = (int)dr["ConOil"];
                    wife.Ammo = (int)dr["ConAmmo"];
                    wife.Equip = (int)dr["Equip"];
                    wife.Country = (string)dr["Country"];
                    wife.TotalAtt = (int)dr["TotalAtt"];
                    wife.EquipName1 = (string)dr["EquipName1"];
                    wife.EquipName2 = (string)dr["EquipName2"];
                    wife.EquipName3 = (string)dr["EquipName3"];
                    wife.EquipName4 = (string)dr["EquipName4"];

                    list.Add(wife);
                }
            }
            catch (Exception)
            {
                throw;
            }
            return list;
        }

        public List<EquipInfo> GetEquipInfoByType(int type)
        {
            List<EquipInfo> list = new List<EquipInfo>();
            try
            {
                string sql = "";

                if (type == 8)
                {
                    sql = "select * from EquipInfo";
                }
                else
                {
                    sql = "select * from EquipInfo where Type=" +
                        type.ToString();
                }
                DataTable dt = DataAccess.GetDataTable(sql);
                foreach (DataRow dr in dt.Rows)
                {
                    EquipInfo wife = new EquipInfo();
                    wife.TypeName = (string)dr["TypeName"];
                    wife.Name = (string)dr["Name"];
                    wife.Fire = (string)dr["Fire"];
                    wife.FireUp = (string)dr["FireUp"];
                    wife.Source = (string)dr["Source"];
                    wife.Formula = (string)dr["Formula"];

                    list.Add(wife);
                }
            }
            catch (Exception)
            {
                throw;
            }
            return list;
        }

        public List<WifeDrop> GetDropByType(int type)
        {
            List<WifeDrop> list = new List<WifeDrop>();
            try
            {
                string sql = "";
                if (type == 8)
                {
                    sql = "select Num, Name, DropMap from INFO";
                }
                else
                {
                    sql = "select Num, Name, DropMap from INFO where Type=" +
    type.ToString();

                }

                DataTable dt = DataAccess.GetDataTable(sql);
                foreach (DataRow dr in dt.Rows)
                {
                    WifeDrop wife = new WifeDrop();

                    wife.Num=(string)dr["Num"];
                    wife.Name=(string)dr["Name"];
                    wife.DropMap = (string)dr["DropMap"];
                    list.Add(wife);
                }
            }
            catch (Exception)
            {
                throw;
            }
            return list;
        }

        public List<MapDrop> GetDropByMap()
        {
            List<MapDrop> list = new List<MapDrop>();
            try
            {
                string sql = "select * from MapDropInfo";
                DataTable dt = DataAccess.GetDataTable(sql);
                foreach (DataRow dr in dt.Rows)
                {
                    MapDrop mp = new MapDrop();

                    mp.MapName=(string)dr["Map"];
                    mp.WifeName=(string)dr["DropInfo"];
                    list.Add(mp);
                }
            }
            catch (Exception)
            {
                throw;
            }
            return list;
        }

        public List<ShipBuildingTime> GetBuildingTime()
        {
            List<ShipBuildingTime> list = new List<ShipBuildingTime>();
            try
            {
                string sql = "select * from ShipBuildTime";
                DataTable dt = DataAccess.GetDataTable(sql);
                foreach (DataRow dr in dt.Rows)
                {
                    ShipBuildingTime sbt = new ShipBuildingTime();

                    sbt.Time = (string)dr["Time"];
                    sbt.Name=(string)dr["Name"];
                    sbt.Type=(string)dr["Type"];
                    sbt.Star=(string)dr["Star"];
                    list.Add(sbt);

                }
            }
            catch (Exception)
            {
                throw;
            }
            return list;
        }

        public List<ShipBuildingFormula> GetBuildingFormula()
        {
            List<ShipBuildingFormula> list = new List<ShipBuildingFormula>();
            try
            {
                string sql = "select * from Build";
                DataTable dt = DataAccess.GetDataTable(sql);
                foreach (DataRow dr in dt.Rows)
                {
                    ShipBuildingFormula sbf = new ShipBuildingFormula();
                    sbf.Formula = (string)dr["Consume"];
                    sbf.Wife=(string)dr["Type"];
                    list.Add(sbf);
                }
            }
            catch (Exception)
            {
                throw;
            }
            return list;
        }

        public List<Expedition> GetExpe()
        {
            List<Expedition> list = new List<Expedition>();
            try
            {
                string sql = "select * from Expedition";
                DataTable dt = DataAccess.GetDataTable(sql);
                foreach (DataRow dr in dt.Rows)
                {
                    Expedition ex = new Expedition();
                    ex.Name = (string)dr["Name"];
                    ex.Time=(int)dr["Time"];
                    ex.Oil=(int)dr["Oil"];
                    ex.Bullet=(int)dr["Bullet"];
                    ex.Metal=(int)dr["Metal"];
                    ex.Total=(int)dr["Total"];
                    ex.TotalPerH=(int)dr["TotalPerH"];
                    ex.Items=(string)dr["Items"];
                    list.Add(ex);
                }
            }
            catch (Exception)
            {
                throw;
            }
            return list;
        }

        public List<MapPath> GetPath()
        {
            List<MapPath> list = new List<MapPath>();
            try
            {
                string sql = "select * from MapPath";
                DataTable dt = DataAccess.GetDataTable(sql);
                foreach (DataRow dr in dt.Rows)
                {
                    MapPath mp = new MapPath();

                    mp.Map=(string)dr["Map"];
                    mp.Path=(string)dr["Path"];
                    list.Add(mp);
                }
            }
            catch (Exception)
            {
                throw;
            }
            return list;
        }




        

    }
}
