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
    /// 供应商公司表
    /// </summary>
    [Table("Scm_SupplierCompany")]
    public class Scm_SupplierCompany
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
        /// 供应商Id
        /// </summary>
        /// 
        [Required]
        public String SupplierId { get; set; }

        /// <summary>
        /// 供应链企业名
        /// </summary>
        public String CompanyName { get; set; }

        /// <summary>
        /// 简称
        /// </summary>
        public string ShortCompanyName { get; set; }

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

    }
}