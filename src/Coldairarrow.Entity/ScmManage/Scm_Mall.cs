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
    /// �̳Ǳ�
    /// </summary>
    [Table("Scm_Mall")]
    public class Scm_Mall
    {

        /// <summary>
        /// ��Ȼ����
        /// </summary>
        [Key, Column(Order = 1)]
        public String Id { get; set; }

        /// <summary>
        /// ��Ӧ��Id
        /// </summary>
        public String ScmId { get; set; }

        /// <summary>
        /// �����ɹ���ҵId
        /// </summary>
        public String EnterpriseId { get; set; }

        /// <summary>
        /// �̳�Id
        /// </summary>
        public String MallId { get; set; }

        /// <summary>
        /// �̳���
        /// </summary>
        public String MallName { get; set; }

    }
}