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
    /// Ent_OrderProduct
    /// </summary>
    [Table("Ent_OrderProduct")]
    public class Ent_OrderProduct
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
        /// 商品来源类型
        /// </summary>
        public Int32? ProductSourceType { get; set; }

        /// <summary>
        /// 商品来源名称
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
        /// 商品类型
        /// </summary>
        public String Category { get; set; }

        /// <summary>
        /// 产品比价组
        /// </summary>
        public String PCCR_Group { get; set; }

        /// <summary>
        /// 审批订单编号_主键
        /// </summary>
        public String ApprovalOrderId { get; set; }

        /// <summary>
        /// 审批订单编号
        /// </summary>
        public String ApprovalOrderIdNo { get; set; }

        /// <summary>
        /// 订单编号_主键
        /// </summary>
        public String OrderId { get; set; }

        /// <summary>
        /// 订单编号
        /// </summary>
        public String OrderNo { get; set; }

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
        public decimal Amount { get; set; }

        /// <summary>
        /// 发票编号
        /// </summary>
        public String InvoiceId { get; set; }

        /// <summary>
        /// 开票用户编号
        /// </summary>
        public String OpenInvoiceUserId { get; set; }

        /// <summary>
        /// 开票用户姓名
        /// </summary>
        public String OpenInvoiceUserRealName { get; set; }

        /// <summary>
        /// 开票时间
        /// </summary>
        public DateTime? OpenInvoiceTime { get; set; }

        /// <summary>
        /// 是否对账
        /// </summary>
        public Boolean IsReconciliation { get; set; }

        /// <summary>
        /// 对账用户编号
        /// </summary>
        public String ReconciliationUserId { get; set; }

        /// <summary>
        /// 对账用户姓名
        /// </summary>
        public String ReconciliationUserRealName { get; set; }

        /// <summary>
        /// 对账时间
        /// </summary>
        public DateTime? ReconciliationTime { get; set; }

        /// <summary>
        /// 是否开过票
        /// </summary>
        public Boolean IsOpenedInvoice { get; set; }

        /// <summary>
        /// 商城商品Id
        /// </summary>
        public String MallProductId { get; set; }

        /// <summary>
        /// 原价（京东合约价、自营商品原价或子供应商原价）
        /// </summary>
        public decimal OriginalPrice { get; set; }

        /// <summary>
        /// 所属供应商Id
        /// </summary>
        public String SupplierId { get; set; }

        /// <summary>
        /// 运费(商品所属订单的运费)
        /// </summary>
        public decimal Carriage { get; set; }

        /// <summary>
        /// 商品运费(订单商品按金额占比摊的部分订单运费)
        /// </summary>
        public decimal ProductCarriage { get; set; }

        /// <summary>
        /// 开票模式(1.根据商品开票,2.根据订单开票)
        /// </summary>
        public Int32 OpenInvoiceMode { get; set; }

        /// <summary>
        /// 开票运费(同一[发票&订单]一下的商品运费总额)
        /// </summary>
        public decimal OpenInvoiceCarriage { get; set; }

    }
}