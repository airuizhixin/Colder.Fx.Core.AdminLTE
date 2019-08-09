using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using NpgsqlTypes;
using System.Collections;
using System.Collections.Generic;
using System.Net;
using System.Net.NetworkInformation;

namespace Coldairarrow.Entity.ScmManage
{
    /// <summary>
    /// 供应链总商品池
    /// </summary>
    [Table("Scm_ScmProduct")]
    public class Scm_ScmProduct
    {

        /// <summary>
        /// 自然主键
        /// </summary>
        [Key, Column(Order = 1)]
        public String Id { get; set; }

        /// <summary>
        /// 供应链主键Id
        /// </summary>
        public String ScmId { get; set; }

        /// <summary>
        /// 商品Id
        /// </summary>
        public String ProductId { get; set; }

        /// <summary>
        /// 商品类别Id
        /// </summary>
        [Required]
        public String CategoryId { get; set; }

        /// <summary>
        /// 商品来源，枚举类型，0：自营，1：电商（即平台），2：供应商
        /// </summary>
        public Int32? ProductSource { get; set; }

        /// <summary>
        /// 平台商品来源（1：京东，其它暂定）
        /// </summary>
        public int? PlatformSource { get; set; }

        /// <summary>
        /// 平台商品Id
        /// </summary>
        public String PlatformProductId { get; set; }

        /// <summary>
        /// 商品sku(指商品在京东、苏宁等的sku) 
        /// </summary>
        public String PlatformProductSKU { get; set; }

        /// <summary>
        /// 平台商品类别Id
        /// </summary>
        public String PlateformCategoryId { get; set; }

        /// <summary>
        /// 所属供应商Id
        /// </summary>
        /// 
        [Required]
        public String SupplierId { get; set; }

        /// <summary>
        /// 品牌Id(预留)
        /// </summary>
        public String BrandId { get; set; }

        /// <summary>
        /// 品牌名
        /// </summary>
        public String BrandName { get; set; }

        /// <summary>
        /// 商品名
        /// </summary>
        public String ProductName { get; set; }

        /// <summary>
        /// 市场价（指在京东等商城页面上显示的价格）
        /// </summary>
        public decimal MarketPrice { get; set; }

        /// <summary>
        /// 原价（京东合约价、自营商品原价或子供应商原价） 
        /// </summary>
        public decimal OriginalPrice { get; set; }

        /// <summary>
        /// 供应链价（供应链商品池中价格）
        /// </summary>
        public decimal ScmPrice { get; set; }

        /// <summary>
        /// 产品主图地址
        /// </summary>
        public String ProductMainImg { get; set; }

        /// <summary>
        /// 产品图片地址，多张逗号相隔
        /// </summary>
        public String ProductImgs { get; set; }

        /// <summary>
        /// 销售单位（如 盒）
        /// </summary>
        public String Unit { get; set; }

        /// <summary>
        /// 重量
        /// </summary>
        public String Weight { get; set; }

        /// <summary>
        /// 产地
        /// </summary>
        public String ProductArea { get; set; }

        /// <summary>
        /// 包装清单（如 茶叶与手提袋一比一寄出 ）
        /// </summary>
        public String Pack { get; set; }

        /// <summary>
        /// 条形码
        /// </summary>
        public String UPC { get; set; }

        /// <summary>
        /// 详情介绍（一段html）
        /// </summary>
        public String Details { get; set; }

        /// <summary>
        /// 规格参数描述（一段html）
        /// </summary>
        public String Param { get; set; }

        /// <summary>
        /// 商品库存（此字段待定，因为京东接口中的库存是分地域的，并且只给出是否有货）
        /// </summary>
        public Int32? StockQuantity { get; set; }

        /// <summary>
        /// 商品状态（0：未入库，1：已入库，入库指进入供应链总商品池）
        /// </summary>
        public Int32 ProductSate { get; set; }

        /// <summary>
        /// 创建人
        /// </summary>
        public String Creater { get; set; }

        /// <summary>
        /// 创建时间
        /// </summary>
        public DateTime? CreateTime { get; set; }

        /// <summary>
        /// 修改人
        /// </summary>
        public String Modifier { get; set; }

        /// <summary>
        /// 修改时间
        /// </summary>
        public DateTime? ModifyTime { get; set; }

        /// <summary>
        /// 商品来源，枚举类型，0：自营，1：供应商，2：京东（暂定这些）
        /// </summary>
        public Int32 ProductSourceType { get; set; }

        /// <summary>
        /// 商品来源名称
        /// </summary>
        public String ProductSourceName { get; set; }

        /// <summary>
        /// 是否已删除
        /// </summary>
        public bool IsDelete { get; set; }
    }
}