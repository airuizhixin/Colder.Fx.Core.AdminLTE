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
    /// 平台接口参数表
    /// </summary>
    [Table("Scm_PlateformApiParam")]
    public class Scm_PlateformApiParam
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
        /// 京东client_id
        /// </summary>
        public String JD_client_id { get; set; }

        /// <summary>
        /// 京东client_secret
        /// </summary>
        public String JD_client_secret { get; set; }

        /// <summary>
        /// 京东username
        /// </summary>
        public String JD_username { get; set; }

        /// <summary>
        /// 京东password
        /// </summary>
        public String JD_password { get; set; }

    }
}