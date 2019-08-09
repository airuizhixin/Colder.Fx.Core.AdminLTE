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
    /// 供应链公司表
    /// </summary>
    [Table("Scm_ScmCompany")]
    public class Scm_ScmCompany
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
        /// 供应链企业名
        /// </summary>
        public String CompanyName { get; set; }

        /// <summary>
        /// 公司简称
        /// </summary>
        public string CompanyShortName { get; set; }

        /// <summary>
        /// 纳税人识别号
        /// </summary>
        public String TIN { get; set; }

        /// <summary>
        /// 电话
        /// </summary>
        public String TEL { get; set; }

        /// <summary>
        /// 开户行名
        /// </summary>
        public String BankName { get; set; }

        /// <summary>
        /// 银行账号
        /// </summary>
        public String BankAccount { get; set; }

        /// <summary>
        /// 平台供应链Id
        /// </summary>
        public String PlatformScmId { get; set; }

        /// <summary>
        /// 地域
        /// </summary>
        public String CompanyArea { get; set; }

        /// <summary>
        /// 等级描述
        /// </summary>
        public String GradeLevel { get; set; }

        /// <summary>
        /// 到期时间
        /// </summary>
        public DateTime? ExpireTime { get; set; }

        /// <summary>
        /// 最大商城数量
        /// </summary>
        public Int32? MaxShopQty { get; set; }

        /// <summary>
        /// 最大供应商数量
        /// </summary>
        public Int32? SubSupplierMaxQty { get; set; }

        /// <summary>
        /// 1:按订单开票，2：按商品开票(此处的“开票模式”指商城向供应链的开票)
        /// </summary>
        public Int32 InvoiceMode { get; set; }

        /// <summary>
        /// 地址
        /// </summary>
        public string Address { get; set; }
    }
}