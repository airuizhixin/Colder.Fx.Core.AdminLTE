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
    /// 供应链商品类别表
    /// </summary>
    [Table("Scm_ScmProductCategory")]
    public class Scm_ScmProductCategory
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
        /// 类别Id
        /// </summary>
        /// 
        [Required]
        public String CategoryId { get; set; }

        /// <summary>
        /// 类别名
        /// </summary>
        public String CategoryName { get; set; }

        /// <summary>
        /// 父类Id（若为空则表示根节点）
        /// </summary>
        public String ParentCategoryId { get; set; }

        /// <summary>
        /// 级别（0为跟）
        /// </summary>
        public int? Level { get; set; }

        /// <summary>
        /// 排序
        /// </summary>
        public int Sort { get; set; }
    }
}