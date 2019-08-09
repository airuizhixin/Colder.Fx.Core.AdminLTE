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
    /// �̳Ǳ�ǩ��
    /// </summary>
    [Table("Scm_MallTag")]
    public class Scm_MallTag
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
        /// �̳�Id
        /// </summary>
        public String MallId { get; set; }

        /// <summary>
        /// ��ǩ����Id
        /// </summary>
        public String TagId { get; set; }

        /// <summary>
        /// ��ǩ��
        /// </summary>
        public String TagName { get; set; }

    }
}