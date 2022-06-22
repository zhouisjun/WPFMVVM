using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfGoodMVVM.Model;

namespace WpfGoodMVVM.DAL
{
    class GoodsDAL
    {
       private List<Goods> Listgoods;

        public GoodsDAL()
        {
            InitGoods();
        }

        private void InitGoods()
        {
            Listgoods = new List<Goods>() {
                new Goods(){GoodsID=1,GoodsName="西瓜",Producers="未知",Address="广东中山" },
                new Goods(){GoodsID=2,GoodsName="芒果",Producers="未知",Address="广东中山" },
                new Goods(){GoodsID=3,GoodsName="杨梅",Producers="未知",Address="广东中山" },
                new Goods(){GoodsID=4,GoodsName="红薯",Producers="未知",Address="广东中山" },
                new Goods(){GoodsID=5,GoodsName="龙眼",Producers="未知",Address="广东中山" },
                new Goods(){GoodsID=6,GoodsName="荔枝",Producers="未知",Address="广东中山" },
                new Goods(){GoodsID=7,GoodsName="芭乐",Producers="未知",Address="广东中山" },
                new Goods(){GoodsID=8,GoodsName="猕猴桃",Producers="未知",Address="广东中山" },
                new Goods(){GoodsID=9,GoodsName="水蜜桃",Producers="未知",Address="广东中山" },
                new Goods(){GoodsID=10,GoodsName="柠檬",Producers="未知",Address="广东中山" },
            };
        }

        //查询所有数据
        public List<Goods> GetGoods()
        {
            return Listgoods;
        }
        //根据商品名称进行模糊查询
        public List<Goods> GetGoods(string name)
        {
            List<Goods> item = Listgoods.Where(g => g.GoodsName.Contains(name)).ToList();
            return item;
        }
        //根据编号查询商品
        public Goods GetGoodsID(int GoodsID)
        {
            var item = Listgoods.FirstOrDefault(g => g.GoodsID == GoodsID);
            if (item != null)
            {
                return new Goods()
                {
                    GoodsID = item.GoodsID,
                    GoodsName = item.GoodsName,
                    Address = item.Address,
                    Producers = item.Producers
                };
            }
            return null;
        }
        //新增商品
        public void AddGoods(Goods goods)
        {
            if (goods != null)
            {
                Goods itmp = new Goods();
                itmp.GoodsID = goods.GoodsID;
                itmp.GoodsName = goods.GoodsName;
                itmp.Producers = goods.Producers;
                itmp.Address = goods.Address;
                Listgoods.Add(itmp);
            }
        }
        //删除商品
        public void DelectGoods(int id)
        {
            var item = Listgoods.FirstOrDefault(g => g.GoodsID == id);
            if (item != null)
            {
                Listgoods.Remove(item);
            }
        }
    }
}
