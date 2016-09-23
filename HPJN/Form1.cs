using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
//using System.Threading.Tasks;
using System.Windows.Forms;

namespace HPJN
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            //CreateDesktopShortCut();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                WifeCateBusiness equip = new WifeCateBusiness();
                List<EquipCate> liste = equip.GetEquipAllType();
                comboBox2.DataSource = liste;
                comboBox2.ValueMember = "Type";
                comboBox2.DisplayMember = "Name";
                comboBox2.Refresh();

                WifeCateBusiness wb2 = new WifeCateBusiness();
                List<WifeCate> list2 = wb2.GetAllType();
                DropWife.DataSource = list2;
                DropWife.ValueMember = "Type";
                DropWife.DisplayMember = "Name";
                DropWife.Refresh();

                WifeCateBusiness wbup = new WifeCateBusiness();
                List<WifeCate> listUp = wbup.GetAllType();
                wifeUpBox.DataSource = listUp;
                wifeUpBox.ValueMember = "Type";
                wifeUpBox.DisplayMember = "Name";
                wifeUpBox.Refresh();

                WifeCateBusiness wb = new WifeCateBusiness();
                List<WifeCate> list = wb.GetAllType();
                WifeChooseBox.DataSource = list;
                WifeChooseBox.ValueMember = "Type";
                WifeChooseBox.DisplayMember = "Name";
                WifeChooseBox.Refresh();

                List<Notice> listNotice = wb.GetNotice();
                this.noticelabel1.Text=listNotice[0].Notice1.ToString();
                this.noticelabel2.Text=listNotice[0].Notice2.ToString();
                this.noticelabel3.Text=listNotice[0].Notice3.ToString();
                this.noticeText4.Text=listNotice[0].Notice4.ToString();
                this.noticelabel5.Text=listNotice[0].Notice5.ToString();
                this.noticelabel6.Text=listNotice[0].Notice6.ToString();
                this.noticelabel7.Text=listNotice[0].Notice7.ToString();
                this.noticelabel8.Text=listNotice[0].Notice8.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void WifeChooseBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (WifeChooseBox.SelectedValue != null)
            {
                int curVersion = 0;
                try
                {
                    string curVersionSql = "select UpdateVersion from UpdateVer";
                    curVersion = int.Parse(DataAccess.GetSingleAnswer(curVersionSql).ToString());
                }
                catch (Exception)
                {
                    throw;
                }

                int id = 0;
                int.TryParse(WifeChooseBox.SelectedValue.ToString(), out id);
                WifeCateBusiness wr = new WifeCateBusiness();
                List<WifeInfo> list = wr.GetInfoByType(id);
                dg1.DataSource = list;
                dg1.Columns[0].HeaderText = "编号";
                dg1.Columns[1].HeaderText = "名字";
                dg1.Columns[2].HeaderText = "星级";
                dg1.Columns[3].HeaderText = "总属性";
                dg1.Columns[4].HeaderText = "护盾";
                dg1.Columns[5].HeaderText = "耐久";
                dg1.Columns[6].HeaderText = "火力";
                dg1.Columns[7].HeaderText = "装甲";
                dg1.Columns[8].HeaderText = "抵抗";
                dg1.Columns[9].HeaderText = "侦查";
                dg1.Columns[10].HeaderText = "机动";
                dg1.Columns[11].HeaderText = "技能1";
                dg1.Columns[12].HeaderText = "技能2";
                dg1.Columns[13].HeaderText = "耗油";
                dg1.Columns[14].HeaderText = "耗弹";
                dg1.Columns[15].HeaderText = "装备位";
                dg1.Columns[16].HeaderText = "装备1";
                dg1.Columns[17].HeaderText = "装备2";
                dg1.Columns[18].HeaderText = "装备3";
                dg1.Columns[19].HeaderText = "装备4";
                dg1.Columns[20].HeaderText = "所属国";

                if (curVersion == 2)
                {
                    dg1.Columns[3].Visible = true;
                    dg1.Columns[16].Visible = true;
                    dg1.Columns[17].Visible = true;
                    dg1.Columns[18].Visible = true;
                    dg1.Columns[19].Visible = true;
                }
                else
                {
                    dg1.Columns[3].Visible = false;
                    dg1.Columns[16].Visible = false;
                    dg1.Columns[17].Visible = false;
                    dg1.Columns[18].Visible = false;
                    dg1.Columns[19].Visible = false;
                }
                foreach (DataGridViewColumn c in dg1.Columns)
                {
                    c.SortMode = DataGridViewColumnSortMode.NotSortable;
                }
                

                dg1.Refresh();
            }
        }

        private void DropWife_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (DropWife.SelectedValue != null)
            {
                int id = 0;
                int.TryParse(DropWife.SelectedValue.ToString(), out id);
                WifeCateBusiness wr = new WifeCateBusiness();
                List<WifeDrop> list = wr.GetDropByType(id);
                dg1.DataSource = list;
                dg1.Columns[0].HeaderText = "编号";
                dg1.Columns[1].HeaderText = "名字";
                dg1.Columns[2].HeaderText = "掉落地图";
                dg1.Refresh();
            }
        }

        private void MapDropBtn_Click(object sender, EventArgs e)
        {
            WifeCateBusiness wr = new WifeCateBusiness();
            List<MapDrop> list = wr.GetDropByMap();
            dg1.DataSource = list;
            dg1.Columns[0].HeaderText = "地图";
            dg1.Columns[1].HeaderText = "机娘掉落";
            dg1.Refresh();
        }




        private void dg1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void ShipBTBtn_Click(object sender, EventArgs e)
        {
            WifeCateBusiness wr = new WifeCateBusiness();
            List<ShipBuildingTime> list = wr.GetBuildingTime();
            dg1.DataSource = list;
            dg1.Columns[0].HeaderText = "建造时间";
            dg1.Columns[1].HeaderText = "对应机娘";
            dg1.Columns[2].HeaderText = "类型";
            dg1.Columns[3].HeaderText = "星级";
            dg1.Refresh();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            WifeCateBusiness wr = new WifeCateBusiness();
            List<Expedition> list = wr.GetExpe();
            dg1.DataSource = list;
            dg1.Columns[0].HeaderText = "任务名";
            dg1.Columns[1].HeaderText = "时间(分钟)";
            dg1.Columns[2].HeaderText = "燃油收益";
            dg1.Columns[3].HeaderText = "弹药收益";
            dg1.Columns[4].HeaderText = "合金收益";
            dg1.Columns[5].HeaderText = "总收益";
            dg1.Columns[6].HeaderText = "总收益(按小时计算)";
            dg1.Columns[7].HeaderText = "获取物品";
            dg1.Refresh();

        }

        private void pathBtn_Click(object sender, EventArgs e)
        {
            WifeCateBusiness wr = new WifeCateBusiness();
            List<MapPath> list = wr.GetPath();
            dg1.DataSource = list;
            dg1.Columns[0].HeaderText = "地图";
            dg1.Columns[1].HeaderText = "过图条件";
            dg1.Refresh();
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox2.SelectedValue != null)
            {
                int id = 0;
                int.TryParse(comboBox2.SelectedValue.ToString(), out id);
                WifeCateBusiness wr = new WifeCateBusiness();
                List<EquipInfo> list = wr.GetEquipInfoByType(id);
                dg1.DataSource = list;
                dg1.Columns[0].HeaderText = "分类";
                dg1.Columns[1].HeaderText = "装备名称";
                dg1.Columns[2].HeaderText = "初始火力";
                dg1.Columns[3].HeaderText = "满级火力";
                dg1.Columns[4].HeaderText = "出处";
                dg1.Columns[5].HeaderText = "建造公式";
            }

                foreach (DataGridViewColumn c in dg1.Columns)
                {
                    c.SortMode = DataGridViewColumnSortMode.NotSortable;
                }

                dg1.Refresh();
        }

        private void wifeUpBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (wifeUpBox.SelectedValue != null)
            {
                int curVersion = 0;
                try
                {
                    string curVersionSql = "select UpdateVersion from UpdateVer";
                    curVersion = int.Parse(DataAccess.GetSingleAnswer(curVersionSql).ToString());
                }
                catch (Exception)
                {
                    throw;
                }

                int id = 0;
                int.TryParse(wifeUpBox.SelectedValue.ToString(), out id);
                WifeCateBusiness wr = new WifeCateBusiness();
                List<WifeInfoUp> list = wr.GetUpInfoByType(id);
                dg1.DataSource = list;
                dg1.Columns[0].HeaderText = "编号";
                dg1.Columns[1].HeaderText = "名字";
                dg1.Columns[2].HeaderText = "星级";
                dg1.Columns[3].HeaderText = "总属性";
                dg1.Columns[4].HeaderText = "护盾";
                dg1.Columns[5].HeaderText = "耐久";
                dg1.Columns[6].HeaderText = "火力";
                dg1.Columns[7].HeaderText = "装甲";
                dg1.Columns[8].HeaderText = "抵抗";
                dg1.Columns[9].HeaderText = "侦查";
                dg1.Columns[10].HeaderText = "机动";
                dg1.Columns[11].HeaderText = "技能1";
                dg1.Columns[12].HeaderText = "技能2";
                dg1.Columns[13].HeaderText = "耗油";
                dg1.Columns[14].HeaderText = "耗弹";
                dg1.Columns[15].HeaderText = "装备位";
                dg1.Columns[16].HeaderText = "装备1";
                dg1.Columns[17].HeaderText = "装备2";
                dg1.Columns[18].HeaderText = "装备3";
                dg1.Columns[19].HeaderText = "装备4";
                dg1.Columns[20].HeaderText = "所属国";

                if (curVersion == 2)
                {
                    dg1.Columns[3].Visible = true;
                    dg1.Columns[16].Visible = true;
                    dg1.Columns[17].Visible = true;
                    dg1.Columns[18].Visible = true;
                    dg1.Columns[19].Visible = true;
                }
                else
                {
                    dg1.Columns[3].Visible = false;
                    dg1.Columns[16].Visible = false;
                    dg1.Columns[17].Visible = false;
                    dg1.Columns[18].Visible = false;
                    dg1.Columns[19].Visible = false;
                }
                foreach (DataGridViewColumn c in dg1.Columns)
                {
                    c.SortMode = DataGridViewColumnSortMode.NotSortable;
                }
                
                dg1.Refresh();
            }

        }

        private void buildFormBtn_Click(object sender, EventArgs e)
        {
            WifeCateBusiness wr = new WifeCateBusiness();
            List<ShipBuildingFormula> list = wr.GetBuildingFormula();
            dg1.DataSource = list;
            dg1.Columns[0].HeaderText = "公式";
            dg1.Columns[1].HeaderText = "可出机型";
            dg1.Refresh();
        }


        private static void CreateDesktopShortCut()
        {
            string path = System.Environment.GetFolderPath(Environment.SpecialFolder.StartMenu);
            if (!path.EndsWith("\\"))
            {
                path += "\\";
            }
            path += @"Programs\皇牌机娘数据查询\JackChen";
            if (System.IO.Directory.Exists(path))
            {
                string desktop = System.Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory);
                if (!desktop.EndsWith("\\"))
                {
                    desktop += "\\";
                }
                foreach (String file in System.IO.Directory.GetFiles(path))
                {
                    System.IO.FileInfo fi = new System.IO.FileInfo(file);
                    if (!System.IO.File.Exists(desktop + fi.Name))
                    {
                        fi.CopyTo(desktop + fi.Name);
                    }
                }
            }
        }
    }
}
