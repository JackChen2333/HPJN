using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HPJN
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                WifeCateBusiness wb2 = new WifeCateBusiness();
                List<WifeCate> list2 = wb2.GetAllType();
                DropWife.DataSource = list2;
                DropWife.ValueMember = "Type";
                DropWife.DisplayMember = "Name";
                DropWife.Refresh();

                WifeCateBusiness wb = new WifeCateBusiness();
                List<WifeCate> list = wb.GetAllType();
                WifeChooseBox.DataSource = list;
                WifeChooseBox.ValueMember = "Type";
                WifeChooseBox.DisplayMember = "Name";
                WifeChooseBox.Refresh();

                List<Notice> listNotice = wb.GetNotice();
                this.noticelabel1.Text=listNotice[0].Notice1.ToString();
                this.noticelabel2.Text=listNotice[0].Notice2.ToString();
                this.noticeText3.Text=listNotice[0].Notice3.ToString();
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
                int id = 0;
                int.TryParse(WifeChooseBox.SelectedValue.ToString(), out id);
                WifeCateBusiness wr = new WifeCateBusiness();
                List<WifeInfo> list = wr.GetInfoByType(id);
                dg1.DataSource = list;
                dg1.Columns[0].HeaderText = "编号";
                dg1.Columns[1].HeaderText = "名字";
                dg1.Columns[2].HeaderText = "星级";
                dg1.Columns[3].HeaderText = "护盾";
                dg1.Columns[4].HeaderText = "耐久";
                dg1.Columns[5].HeaderText = "火力";
                dg1.Columns[6].HeaderText = "装甲";
                dg1.Columns[7].HeaderText = "抵抗";
                dg1.Columns[8].HeaderText = "侦查";
                dg1.Columns[9].HeaderText = "机动";
                dg1.Columns[10].HeaderText = "装备位";
                dg1.Columns[11].HeaderText = "耗油";
                dg1.Columns[12].HeaderText = "耗弹";
                dg1.Columns[13].HeaderText = "所属国";

                foreach (DataGridViewColumn c in dg1.Columns)
                {
                    c.SortMode = DataGridViewColumnSortMode.Automatic;
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

    }
}
