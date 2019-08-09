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
    /// 订单表
    /// </summary>
    [Table("Ent_Order")]
    public class Ent_Order
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
        /// 审批订单编号_主键
        /// </summary>
        public String ApprovalOrderId { get; set; }

        /// <summary>
        /// 审批订单编号
        /// </summary>
        public String ApprovalOrderIdNo { get; set; }

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
        /// 操作员编号
        /// </summary>
        public String OperatorId { get; set; }

        /// <summary>
        /// 操作员姓名
        /// </summary>
        public String OperatorRealName { get; set; }

        /// <summary>
        /// 金额
        /// </summary>
        public decimal Amount { get; set; }

        /// <summary>
        /// 商品来源，枚举类型，0：自营，1：供应商，2：京东（暂定这些）
        /// </summary>
        public Int32 ProductSourceType { get; set; }

        /// <summary>
        /// 商品来源名称
        /// </summary>
        public String ProductSourceName { get; set; }

        /// <summary>
        /// 订单收货地址编号
        /// </summary>
        public String OrderAddressId { get; set; }

        /// <summary>
        /// 电商父订单
        /// </summary>
        public String E_Supplier_ParentOrder { get; set; }

        /// <summary>
        /// 电商子订单
        /// </summary>
        public String E_Supplier_ChildrenOrder { get; set; }

        /// <summary>
        /// 状态(1:待发货,2:已发货,3.已收货,-10下单失败)
        /// </summary>
        public Int32 Status { get; set; }

        /// <summary>
        /// *供应链Id
        /// </summary>
        public String ScmId { get; set; }

        /// <summary>
        /// 递送方式(0:未递送,1:主动递送,2:快递递送)
        /// </summary>
        public Int32 DeliveryMethod { get; set; }

        /// <summary>
        /// 物流公司
        /// </summary>
        public String LogisticsCompanies { get; set; }

        /// <summary>
        /// 快递编号
        /// </summary>
        public String ExpressNo { get; set; }

        /// <summary>
        /// 操作员序号
        /// </summary>
        public int OperatorUserNum { get; set; }

        /// <summary>
        /// 所属供应商Id
        /// </summary>
        public String SupplierId { get; set; }

        /// <summary>
        /// 运费
        /// </summary>
        public decimal Carriage { get; set; }

        /// <summary>
        /// 下单失败备注
        /// </summary>
        public string FailMemo { get; set; }

        /// <summary>
        /// 成本金额（包括运费）
        /// </summary>
        public decimal OriginalAmount { get; set; }
    }
}