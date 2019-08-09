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
    /// 商城表
    /// </summary>
    [Table("Scm_Mall")]
    public class Scm_Mall
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
        /// 所属采购企业Id
        /// </summary>
        public String EnterpriseId { get; set; }

        /// <summary>
        /// 商城Id
        /// </summary>
        public String MallId { get; set; }

        /// <summary>
        /// 商城名
        /// </summary>
        public String MallName { get; set; }

    }
}