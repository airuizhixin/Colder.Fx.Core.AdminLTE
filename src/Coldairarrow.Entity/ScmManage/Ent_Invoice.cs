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
    /// 发票表
    /// </summary>
    [Table("Ent_Invoice")]
    public class Ent_Invoice
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
        /// 发票来源类型(null:供应链or未知)
        /// </summary>
        public Int32? InvoiceSourceType { get; set; }

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
        public decimal Amount { get; set; }

        /// <summary>
        /// 审批备注
        /// </summary>
        public String Memo { get; set; }

        /// <summary>
        /// 发票收货地址编号
        /// </summary>
        public String InvoiceAddressId { get; set; }

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
        /// 状态(1:待开票,2:待付款[该状态可以跳过],3:待确认收款,4:开票完成)
        /// </summary>
        public Int32 Status { get; set; }

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

    }
}