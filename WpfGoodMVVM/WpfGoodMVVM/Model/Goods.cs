using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfGoodMVVM.Model
{
    public class Goods
    {
        public int GoodsID { get; set; }//商品编号
        public string GoodsName { get; set; }//商品名称
        public string Producers { get; set; }//生产商
        public string Address { get; set; }//生产地址
    }
}
