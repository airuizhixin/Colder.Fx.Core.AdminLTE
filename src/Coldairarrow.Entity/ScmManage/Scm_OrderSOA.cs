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
    /// 供应链订单对账表
    /// </summary>
    [Table("Scm_OrderSOA")]
    public class Scm_OrderSOA
    {

        /// <summary>
        /// 自然主键
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
        /// 是否已对账（供应链作为卖方）
        /// </summary>
        public Boolean ScmSale_IsSOA { get; set; }

        /// <summary>
        /// 对账用户编号（供应链作为卖方）
        /// </summary>
        public String ScmSale_SOAUserId { get; set; }

        /// <summary>
        /// 对账用户姓名（供应链作为卖方）
        /// </summary>
        public String ScmSale_SOAUserRealName { get; set; }

        /// <summary>
        /// 对账时间（供应链作为卖方）
        /// </summary>
        public DateTime? ScmSale_SOATime { get; set; }

        /// <summary>
        /// 是否已对账（供应链作为买方）
        /// </summary>
        public Boolean ScmBuy_IsSOA { get; set; }

        /// <summary>
        /// 是否已对账（供应链作为买方）
        /// </summary>
        public String ScmBuy_SOAUserId { get; set; }

        /// <summary>
        /// 对账用户姓名（供应链作为买方）
        /// </summary>
        public String ScmBuy_SOAUserRealName { get; set; }

        /// <summary>
        /// 对账时间（供应链作为买方）
        /// </summary>
        public DateTime? ScmBuy_SOATime { get; set; }

        /// <summary>
        /// 是否已对账（供应商作为卖方）
        /// </summary>
        public Boolean SupplierSale_IsSOA { get; set; }

        /// <summary>
        /// 对账用户编号（供应商作为卖方）
        /// </summary>
        public String SupplierSale_SOAUserId { get; set; }

        /// <summary>
        /// 对账用户姓名（供应商作为卖方）
        /// </summary>
        public String SupplierSale_SOAUserRealName { get; set; }

        /// <summary>
        /// 对账时间（供应商作为卖方）
        /// </summary>
        public DateTime? SupplierSale_SOATime { get; set; }

    }
}