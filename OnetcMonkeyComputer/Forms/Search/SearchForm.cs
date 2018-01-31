using OnetcMonkeyComputer.Config;
using OnetcMonkeyComputer.Services;
using OnetcMonkeyComputer.Services.Dtos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OnetcMonkeyComputer
{
    public partial class Search : Form
    {
        private IConfigService _configService;
        private IMonkeyService _monkeyService;

        private List<MonkeyInfoDto> list = new List<MonkeyInfoDto>();
        public Search()
        {
            InitializeComponent();
            _configService = new ConfigService();
            var config = _configService.ReadConfig();
            _monkeyService = new MonkeyService(config.BaseApiUrl, config.BaseUrl);

            this.dataGridView_monkeys.AutoGenerateColumns = false;
        }

        private void button_search_Click(object sender, EventArgs e)
        {
            var token = _configService.ReadConfig().Token;
            var pages = comboBox_pages.SelectedIndex > 0 ? comboBox_pages.SelectedIndex + 1 : 1;
            var orderby = comboBox_orderby.SelectedIndex+1;
            var sort = checkBox_sort.Checked?1:0;

            var input = new FilterMonkeysFromMarketInput()
            {
                token = token,
                sort = sort,
                orderBy = orderby,
                startBear = (double)numericUpDown_bearStart.Value,
                endBear= (double)numericUpDown_bearEnd.Value,

                startBearNum = (int)numericUpDown_bearNumStart.Value,
                endBearNum = (int)numericUpDown_bearNumEnd.Value,

                startGen = (int)numericUpDown_genStart.Value,
                endGen = (int)numericUpDown_genEnd.Value,

                startGrow = (double)numericUpDown_growStart.Value,
                endGrow = (double)numericUpDown_growEnd.Value,

                startMakeMoney = (double)numericUpDown_makeMoneyStart.Value,
                endMakeMoney = (double)numericUpDown_makeMoneyEnd.Value,

                startWeight = (double)numericUpDown_weightStart.Value,
                endWeight = (double)numericUpDown_weightEnd.Value
                
            };

            list = new List<MonkeyInfoDto>();
            for (int i=1;i<= pages; i++)
            {
                input.current = i;
                list.AddRange(_monkeyService.FilterMonkeysFromMarket(input));
            }            

            list.ForEach(f => f.SetJueJinFenShu());

            dataGridView_monkeys.DataSource = list;
        }

        private SortOrder so = SortOrder.Ascending;
        private void dataGridView_monkeys_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                this.Cursor = Cursors.WaitCursor;
                System.Threading.Thread.Sleep(50);
                if (e.Button == MouseButtons.Left && e.ColumnIndex > 0)
                {
                    String columnName = dataGridView_monkeys.Columns[e.ColumnIndex].DataPropertyName;
                    
                    so = so == SortOrder.Ascending ? SortOrder.Descending : SortOrder.Ascending;
                    list = list.OrderBy(o => o.JueJinFenShu).ToList();
                    switch (columnName)
                    {
                        case "generation":
                            if (so == SortOrder.Ascending)
                                list = list.OrderBy(o => o.generation).ToList();
                            else
                                list = list.OrderByDescending(o => o.generation).ToList();
                            break;
                        case "price":
                            if (so == SortOrder.Ascending)
                                list = list.OrderBy(o => o.price).ToList();
                            else
                                list = list.OrderByDescending(o => o.price).ToList();
                            break;
                        case "JueJinFenShu":
                            if (so == SortOrder.Ascending)
                                list = list.OrderBy(o => o.JueJinFenShu).ToList();
                            else
                                list = list.OrderByDescending(o => o.JueJinFenShu).ToList();
                            break;
                        case "weight":
                            if (so == SortOrder.Ascending)
                                list = list.OrderBy(o => o.weight).ToList();
                            else
                                list = list.OrderByDescending(o => o.weight).ToList();
                            break;
                        case "grow":
                            if (so == SortOrder.Ascending)
                                list = list.OrderBy(o => o.grow).ToList();
                            else
                                list = list.OrderByDescending(o => o.grow).ToList();
                            break;
                        case "bear":
                            if (so == SortOrder.Ascending)
                                list = list.OrderBy(o => o.bear).ToList();
                            else
                                list = list.OrderByDescending(o => o.bear).ToList();
                            break;
                        case "bearNum":
                            if (so == SortOrder.Ascending)
                                list = list.OrderBy(o => o.bearNum).ToList();
                            else
                                list = list.OrderByDescending(o => o.bearNum).ToList();
                            break;
                        case "makeMoney":
                            if (so == SortOrder.Ascending)
                                list = list.OrderBy(o => o.makeMoney).ToList();
                            else
                                list = list.OrderByDescending(o => o.makeMoney).ToList();
                            break;
                    }
                    dataGridView_monkeys.DataSource = list;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                this.Cursor = Cursors.Default;
            }
        }
    }
}
