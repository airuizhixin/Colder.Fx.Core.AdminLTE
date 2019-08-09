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
    /// 商城商品表
    /// </summary>
    [Table("Scm_MallProduct")]
    public class Scm_MallProduct
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
        /// 商城商品Id
        /// </summary>
        public String MallProductId { get; set; }

        /// <summary>
        /// 商城商品类型
        /// </summary>
        public String MallCategoryId { get; set; }

        /// <summary>
        /// 供应链商品Id
        /// </summary>
        public String ScmProductId { get; set; }

        /// <summary>
        /// 商城商品价格
        /// </summary>
        public decimal MallPrice { get; set; }

        /// <summary>
        /// 商品状态（0：下架，1：上架，指是否上架展示到商城）
        /// </summary>
        public Int32 ProductSate { get; set; }

        /// <summary>
        /// 创建时间
        /// </summary>
        public DateTime? CreateTime { get; set; }

        /// <summary>
        /// 创建人
        /// </summary>
        public String Creator { get; set; }

        /// <summary>
        /// 是否已删除
        /// </summary>
        public bool IsDelete { get; set; }

        /// <summary>
        /// 销量
        /// </summary>
        public int SaleCount { get; set; }

        /// <summary>
        /// 标签Id,多个逗号相隔
        /// </summary>
        public string TagIds { get; set; }
    }
}