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
    /// 商城标签表
    /// </summary>
    [Table("Scm_MallTag")]
    public class Scm_MallTag
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
        /// 商城Id
        /// </summary>
        public String MallId { get; set; }

        /// <summary>
        /// 标签主键Id
        /// </summary>
        public String TagId { get; set; }

        /// <summary>
        /// 标签名
        /// </summary>
        public String TagName { get; set; }

    }
}