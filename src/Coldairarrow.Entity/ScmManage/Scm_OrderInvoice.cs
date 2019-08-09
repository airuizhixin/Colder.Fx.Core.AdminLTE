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
    /// 供应链订单发票,供应链发起的发票
    /// </summary>
    [Table("Scm_OrderInvoice")]
    public class Scm_OrderInvoice
    {

        /// <summary>
        /// 主键
        /// </summary>
        [Key, Column(Order = 1)]
        public String Id { get; set; }

        /// <summary>
        /// 供应链Id
        /// </summary>
        public String ScmId { get; set; }

        /// <summary>
        /// 订单Id
        /// </summary>
        public String OrderId { get; set; }

        /// <summary>
        /// 标签
        /// </summary>
        public String InvoiceInfoTag { get; set; }

        /// <summary>
        /// 发票类型(1:增值税普通发票,2:增值税专用发票)
        /// </summary>
        public Int32 InvoiceType { get; set; }

        /// <summary>
        /// 发票抬头
        /// </summary>
        public String InvoiceTitle { get; set; }

        /// <summary>
        /// 税务登记证号
        /// </summary>
        public String TaxRegistryNumber { get; set; }

        /// <summary>
        /// 基本开户银行名称
        /// </summary>
        public String BankName { get; set; }

        /// <summary>
        /// 基本开户账号
        /// </summary>
        public String BankNumber { get; set; }

        /// <summary>
        /// 注册场所地址
        /// </summary>
        public String RegistryAddress { get; set; }

        /// <summary>
        /// 固定电话
        /// </summary>
        public String Tel { get; set; }

        /// <summary>
        /// 发票来源类型
        /// </summary>
        public Int32 InvoiceSourceType { get; set; }

        /// <summary>
        /// 发票来源名称
        /// </summary>
        public String InvoiceSourceName { get; set; }

        /// <summary>
        /// 发票编号(编号用于后台显示,格式:I时间-4位随机数)
        /// </summary>
        public String InvoiceNo { get; set; }

        /// <summary>
        /// 金额
        /// </summary>
        public Decimal Amount { get; set; }

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
        public DateTime OpenInvoiceTime { get; set; }

        /// <summary>
        /// 状态(1:待开票,2:待付款[该状态可以跳过],3:待确认收款,4:开票完成,5：待审核,6:审核失败,7:已寄出,8:已审核待开票,9:已开票待寄出)
        /// </summary>
        public Int32 Status { get; set; }

        /// <summary>
        /// 递送方式，0：电子发票，1：实体发票
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
        /// 电商发票Id，用于查找
        /// </summary>
        public string MarkID { get; set; }

        /// <summary>
        /// 供应商Id
        /// </summary>
        public string SupId { get; set; }

        /// <summary>
        /// 创建时间
        /// </summary>
        public DateTime CreateDate { get; set; }
    }
}