﻿//------------------------------------------------------------------------------
// <auto-generated>
//    此代码是根据模板生成的。
//
//    手动更改此文件可能会导致应用程序中发生异常行为。
//    如果重新生成代码，则将覆盖对此文件的手动更改。
// </auto-generated>
//------------------------------------------------------------------------------

namespace Model
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class erpEntities : DbContext
    {
        public erpEntities()
            : base("name=erpEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public DbSet<BuMenWeihu> BuMenWeihus { get; set; }
        public DbSet<bz> bzs { get; set; }
        public DbSet<cgdd> cgdds { get; set; }
        public DbSet<cgddnr> cgddnrs { get; set; }
        public DbSet<cgqgd> cgqgds { get; set; }
        public DbSet<cgqgdnr> cgqgdnrs { get; set; }
        public DbSet<cgxjd> cgxjds { get; set; }
        public DbSet<ck> cks { get; set; }
        public DbSet<DiaoBodan> DiaoBodans { get; set; }
        public DbSet<DiaoBodanXB> DiaoBodanXBs { get; set; }
        public DbSet<KeHuZB> KeHuZBs { get; set; }
        public DbSet<KuCunDaizhi> KuCunDaizhis { get; set; }
        public DbSet<KuCunTaiZhang> KuCunTaiZhangs { get; set; }
        public DbSet<Pandiandan> Pandiandans { get; set; }
        public DbSet<PandiandanXB> PandiandanXBs { get; set; }
        public DbSet<Qitaruku> Qitarukus { get; set; }
        public DbSet<Qitarukuxiang> Qitarukuxiangs { get; set; }
        public DbSet<Quotation> Quotations { get; set; }
        public DbSet<Quotaxiang> Quotaxiangs { get; set; }
        public DbSet<RenyuanWeihu> RenyuanWeihus { get; set; }
        public DbSet<t_store> t_store { get; set; }
        public DbSet<tb_bei> tb_bei { get; set; }
        public DbSet<tb_CaiGouFengTan> tb_CaiGouFengTan { get; set; }
        public DbSet<tb_CaiGouFengTanJG> tb_CaiGouFengTanJG { get; set; }
        public DbSet<tb_CaiGouFengTanMX> tb_CaiGouFengTanMX { get; set; }
        public DbSet<tb_CaiGouRuKuD> tb_CaiGouRuKuD { get; set; }
        public DbSet<tb_CaiGouRuKuDNeiR> tb_CaiGouRuKuDNeiR { get; set; }
        public DbSet<tb_CaiGouTuiHuo> tb_CaiGouTuiHuo { get; set; }
        public DbSet<tb_CaiGouTuiHuotwo> tb_CaiGouTuiHuotwo { get; set; }
        public DbSet<Tb_fapiao> Tb_fapiao { get; set; }
        public DbSet<tb_nrong> tb_nrong { get; set; }
        public DbSet<tb_qingdan> tb_qingdan { get; set; }
        public DbSet<tb_WuLiaoWeiHu> tb_WuLiaoWeiHu { get; set; }
        public DbSet<tb_WuLiaoWeiHuCunLiangXX> tb_WuLiaoWeiHuCunLiangXX { get; set; }
        public DbSet<tb_WuLiaoWeiHuJBziliao> tb_WuLiaoWeiHuJBziliao { get; set; }
        public DbSet<tb_WuLiaoWeiHuJYziliao> tb_WuLiaoWeiHuJYziliao { get; set; }
        public DbSet<TH> THs { get; set; }
        public DbSet<thnr> thnrs { get; set; }
        public DbSet<Tiaojiadan> Tiaojiadans { get; set; }
        public DbSet<TiaojiadanXB> TiaojiadanXBs { get; set; }
        public DbSet<XiaoShouChuKan> XiaoShouChuKans { get; set; }
        public DbSet<Xiaoshoudingd> Xiaoshoudingds { get; set; }
        public DbSet<xiaoshoufabiao> xiaoshoufabiaos { get; set; }
        public DbSet<xiaoshoufabiaoneirong> xiaoshoufabiaoneirongs { get; set; }
        public DbSet<xiaoshoufabiaoqingdan> xiaoshoufabiaoqingdans { get; set; }
        public DbSet<Xiaoshouzhi> Xiaoshouzhis { get; set; }
        public DbSet<yingshouchongkuan> yingshouchongkuans { get; set; }
        public DbSet<yingshouchongkuanneirong> yingshouchongkuanneirongs { get; set; }
        public DbSet<yingshouchongkuanqyy> yingshouchongkuanqyys { get; set; }
        public DbSet<ysk> ysks { get; set; }
        public DbSet<yskxb> yskxbs { get; set; }
    }
}