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
    /// 发票过程表
    /// </summary>
    [Table("Ent_InvoiceProcess")]
    public class Ent_InvoiceProcess
    {

        /// <summary>
        /// 自然主键
        /// </summary>
        [Key, Column(Order = 1)]
        public String Id { get; set; }

        /// <summary>
        /// 发票编号
        /// </summary>
        public String InvoiceId { get; set; }

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
        /// 操作时间
        /// </summary>
        public DateTime ActionTime { get; set; }

        /// <summary>
        /// 格式:
        /// 操作员:用户真实姓名
        /// 操作:[申请开票, 开票, 打款确认, 收款确认]
        /// </summary>
        public String ActionSummary { get; set; }

        /// <summary>
        /// 关联图片JSON字符串
        /// </summary>
        public String Images { get; set; }

        /// <summary>
        /// 关联附件JSON字符串
        /// </summary>
        public String Atts { get; set; }

        /// <summary>
        /// 备注
        /// </summary>
        public String Memo { get; set; }

    }
}