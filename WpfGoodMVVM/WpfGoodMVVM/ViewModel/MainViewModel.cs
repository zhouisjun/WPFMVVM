using GalaSoft.MvvmLight;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using WpfGoodMVVM.Model;
using WpfGoodMVVM.DAL;
using GalaSoft.MvvmLight.Command;
using WpfGoodMVVM.View;
using System.Windows;
using System.Linq;

namespace WpfGoodMVVM.ViewModel
{
    class MainViewModel : ViewModelBase
    {
        #region
        private GoodsDAL goodsDAL;

        private ObservableCollection<Goods> goodsList;

        public ObservableCollection<Goods> GoodsList
        {
            get {
                return goodsList;
            }
            set {
                goodsList = value;
                RaisePropertyChanged();
            }
        }

        private string search;
        public string Search
        {
            get { return search; }
            set
            {
                search = value;
                RaisePropertyChanged();
            }
        }

        public MainViewModel()
        {
            goodsDAL = new GoodsDAL();
            GetCommand = new RelayCommand(this.Query);
            Editcommand = new RelayCommand<int>(this.Edit);
            Delectcommand = new RelayCommand<int>(this.Delete);
            AddCommand = new RelayCommand(this.Add);
        }

        #endregion
        #region
        public RelayCommand GetCommand { get; set; }
        public RelayCommand<int> Editcommand { get; set; }
        public RelayCommand<int> Delectcommand { get; set; }
        public RelayCommand AddCommand { get; set; }
        #endregion
        #region
        
        public void Query()
        {
            List<Goods> goods;
            if (string.IsNullOrEmpty(search))
            {
                goods = goodsDAL.GetGoods();
            }
            else {
                goods = goodsDAL.GetGoods(search);
            }
            GoodsList = new ObservableCollection<Goods>();
            if (goods != null)
            {
                goods.ForEach(g =>
                {
                    GoodsList.Add(g);
                });
            }
        }

        public void Edit(int id) {
            var item = goodsDAL.GetGoodsID(id);
            if (item!=null)
            {
                GoodsWindow goodsWindow = new GoodsWindow(item);
                var r = goodsWindow.ShowDialog();
                if (r.Value)
                {
                    var noModel = GoodsList.FirstOrDefault(g => g.GoodsID == id);
                    if (noModel!=null)
                    {
                        noModel.GoodsName = item.GoodsName;
                        noModel.Address = item.Address;
                        noModel.Producers = item.Producers;
                    }
                    this.Query();
                }
            }
        }

        public void Delete(int id) {
            var itmp = goodsDAL.GetGoodsID(id);
            if (itmp!=null)
            {
                var b = MessageBox.Show("你确定要删除" + itmp.GoodsName + "嘛？", "提示", MessageBoxButton.YesNo);
                if (b==MessageBoxResult.Yes)
                {
                    goodsDAL.DelectGoods(id);
                    this.Query();
                }
            }
        }
        public void Add() {
            Goods goods = new Goods();
            GoodsWindow goodsWindow = new GoodsWindow(goods);
            var r = goodsWindow.ShowDialog();
            if (r.Value)
            {
                goods.GoodsID = goodsList.Max(g => g.GoodsID)+1;
                goodsDAL.AddGoods(goods);
                this.Query();
            }
        }
        #endregion
    }
}