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
    /// ��Ӧ����Ʒ����
    /// </summary>
    [Table("Scm_ScmProductCategory")]
    public class Scm_ScmProductCategory
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
        /// ���Id
        /// </summary>
        /// 
        [Required]
        public String CategoryId { get; set; }

        /// <summary>
        /// �����
        /// </summary>
        public String CategoryName { get; set; }

        /// <summary>
        /// ����Id����Ϊ�����ʾ���ڵ㣩
        /// </summary>
        public String ParentCategoryId { get; set; }

        /// <summary>
        /// ����0Ϊ����
        /// </summary>
        public int? Level { get; set; }

        /// <summary>
        /// ����
        /// </summary>
        public int Sort { get; set; }
    }
}