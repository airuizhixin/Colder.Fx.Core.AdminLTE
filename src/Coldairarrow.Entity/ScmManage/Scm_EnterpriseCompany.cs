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
    /// 采购企业表
    /// </summary>
    [Table("Scm_EnterpriseCompany")]
    public class Scm_EnterpriseCompany
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
        /// 采购企业Id
        /// </summary>
        public String EnterpriseId { get; set; }

        /// <summary>
        /// 采购企业名
        /// </summary>
        public String CompanyName { get; set; }

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
        /// 授信额度
        /// </summary>
        public decimal DepositVal { get; set; }

        /// <summary>
        /// 已用额度
        /// </summary>
        public decimal DepositValUsed { get; set; }
    }
}