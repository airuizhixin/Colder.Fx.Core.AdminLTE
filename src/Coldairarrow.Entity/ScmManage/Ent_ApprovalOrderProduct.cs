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
    /// 审批订单商品表
    /// </summary>
    [Table("Ent_ApprovalOrderProduct")]
    public class Ent_ApprovalOrderProduct
    {

        /// <summary>
        /// 自然主键
        /// </summary>
        [Key, Column(Order = 1)]
        public String Id { get; set; }

        /// <summary>
        /// 企业编号
        /// </summary>
        public String EntId { get; set; }

        /// <summary>
        /// 创建时间
        /// </summary>
        public DateTime CreateDate { get; set; }

        /// <summary>
        /// 是否删除
        /// </summary>
        public Boolean IsDelete { get; set; }

        /// <summary>
        /// 拓展字段
        /// </summary>
        public String Ext { get; set; }

        /// <summary>
        /// 商品SKU
        /// </summary>
        public String SKU { get; set; }

        /// <summary>
        /// 商品来源，枚举类型，0：自营，1：供应商，2：京东（暂定这些）
        /// </summary>
        public Int32? ProductSourceType { get; set; }

        /// <summary>
        /// 商品来源名称（具体的名字，例如XXX供应商）
        /// </summary>
        public String ProductSourceName { get; set; }

        /// <summary>
        /// 名称
        /// </summary>
        public String Name { get; set; }

        /// <summary>
        /// 品牌
        /// </summary>
        public String Brand { get; set; }

        /// <summary>
        /// 主图地址
        /// </summary>
        public String ImagePath { get; set; }

        /// <summary>
        /// 产品图片
        /// </summary>
        public String Images { get; set; }

        /// <summary>
        /// 销售单位
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
        /// 包装清单
        /// </summary>
        public String Pack { get; set; }

        /// <summary>
        /// 详情介绍（一段html）
        /// </summary>
        public String Details { get; set; }

        /// <summary>
        /// 规格参数描述（一段html）
        /// </summary>
        public String Param { get; set; }

        /// <summary>
        /// 商城价格
        /// </summary>
        public decimal MallPrice { get; set; }

        /// <summary>
        /// 产品比价组
        /// </summary>
        public String PCCR_Group { get; set; }

        /// <summary>
        /// 商品类型
        /// </summary>
        public String Category { get; set; }

        /// <summary>
        /// 审批订单编号_主键
        /// </summary>
        public String ApprovalOrderId { get; set; }

        /// <summary>
        /// 审批订单编号
        /// </summary>
        public String ApprovalOrderIdNo { get; set; }

        /// <summary>
        /// 所属组织
        /// </summary>
        public String OrgId { get; set; }

        /// <summary>
        /// 所属组织名称
        /// </summary>
        public String OrgName { get; set; }

        /// <summary>
        /// 数量
        /// </summary>
        public Int32 Quantity { get; set; }

        /// <summary>
        /// 金额
        /// </summary>
        public Double Amount { get; set; }

        /// <summary>
        /// 商城商品Id
        /// </summary>
        public String MallProductId { get; set; }

        /// <summary>
        /// 所属供应商Id
        /// </summary>
        public String SupplierId { get; set; }

        /// <summary>
        /// 原价（京东合约价、自营商品原价或子供应商原价） 
        /// </summary>
        public decimal OriginalPrice { get; set; }
    }
}