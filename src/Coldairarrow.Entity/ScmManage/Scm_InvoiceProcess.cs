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
    /// 供应链发票过程表
    /// </summary>
    [Table("Scm_InvoiceProcess")]
    public class Scm_InvoiceProcess
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
        /// 发票Id
        /// </summary>
        public String ScmOrderInvoiceId { get; set; }

        /// <summary>
        /// 操作类型，0：申请开票，1：开票，2：打款确认，3：收款确认，4：审核成功，5：寄出，6：审核失败，7：开票完成
        /// </summary>
        public Int32 ProcessType { get; set; }

        /// <summary>
        /// 操作人姓名
        /// </summary>
        public String OpRealName { get; set; }

        /// <summary>
        /// 操作人Id
        /// </summary>
        public String OpUserId { get; set; }

        /// <summary>
        /// 操纵时间
        /// </summary>
        public DateTime? OpTime { get; set; }

        /// <summary>
        /// 附件，多个逗号相隔
        /// </summary>
        public String Files { get; set; }

        /// <summary>
        /// 备注
        /// </summary>
        public String Note { get; set; }

    }
}