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
    /// 采购商账号表
    /// </summary>
    [Table("Scm_EnterpriseUser")]
    public class Scm_EnterpriseUser
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
        /// 采购商Id
        /// </summary>
        public String EnterpriseId { get; set; }

        /// <summary>
        /// 手机号
        /// </summary>
        public String PhoneNum { get; set; }

        /// <summary>
        /// 密码
        /// </summary>
        public String Password { get; set; }

        /// <summary>
        /// 被禁用
        /// </summary>
        public Boolean Disabled { get; set; }

        /// <summary>
        /// 用户名
        /// </summary>
        public String UserName { get; set; }

        /// <summary>
        /// 姓名
        /// </summary>
        public String RealName { get; set; }

        /// <summary>
        /// 用户主键Id
        /// </summary>
        public string UserId { get; set; }

    }
}