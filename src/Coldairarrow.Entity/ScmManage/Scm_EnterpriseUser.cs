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
    /// �ɹ����˺ű�
    /// </summary>
    [Table("Scm_EnterpriseUser")]
    public class Scm_EnterpriseUser
    {

        /// <summary>
        /// ��Ȼ����
        /// </summary>
        [Key, Column(Order = 1)]
        public String Id { get; set; }

        /// <summary>
        /// ��Ӧ������Id
        /// </summary>
        public String ScmId { get; set; }

        /// <summary>
        /// �ɹ���Id
        /// </summary>
        public String EnterpriseId { get; set; }

        /// <summary>
        /// �ֻ���
        /// </summary>
        public String PhoneNum { get; set; }

        /// <summary>
        /// ����
        /// </summary>
        public String Password { get; set; }

        /// <summary>
        /// ������
        /// </summary>
        public Boolean Disabled { get; set; }

        /// <summary>
        /// �û���
        /// </summary>
        public String UserName { get; set; }

        /// <summary>
        /// ����
        /// </summary>
        public String RealName { get; set; }

        /// <summary>
        /// �û�����Id
        /// </summary>
        public string UserId { get; set; }

    }
}