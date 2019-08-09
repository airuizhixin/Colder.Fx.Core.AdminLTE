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
    /// 订单收货地址表
    /// </summary>
    [Table("Ent_OrderAddress")]
    public class Ent_OrderAddress
    {

        /// <summary>
        /// 自然主键
        /// </summary>
        [Key, Column(Order = 1)]
        public String Id { get; set; }

        /// <summary>
        /// 企业编号
        /// </summary>
        public String EntId { get; set; }

        /// <summary>
        /// 创建时间
        /// </summary>
        public DateTime CreateDate { get; set; }

        /// <summary>
        /// 是否删除
        /// </summary>
        public Boolean IsDelete { get; set; }

        /// <summary>
        /// 拓展字段
        /// </summary>
        public String Ext { get; set; }

        /// <summary>
        /// 收货地址编号
        /// </summary>
        public String AddressId { get; set; }

        /// <summary>
        /// 用户编号
        /// </summary>
        public String UserId { get; set; }

        /// <summary>
        /// 标签
        /// </summary>
        public String Tag { get; set; }

        /// <summary>
        /// 地理位置数据来源
        /// </summary>
        public String GeolocationSource { get; set; }

        /// <summary>
        /// 地理位置数据来源名称
        /// </summary>
        public String GeolocationSourceName { get; set; }

        /// <summary>
        /// 地址类型(1:订单地址,2:发票地址)
        /// </summary>
        public Int32? AddressType { get; set; }

        /// <summary>
        /// 省（直辖市，自治区）
        /// </summary>
        public String Province { get; set; }

        /// <summary>
        /// 省编号（直辖市，自治区）
        /// </summary>
        public Int32 ProvinceId { get; set; }

        /// <summary>
        /// 市
        /// </summary>
        public String City { get; set; }

        /// <summary>
        /// 市编号
        /// </summary>
        public Int32 CityId { get; set; }

        /// <summary>
        /// 区（县）
        /// </summary>
        public String County { get; set; }

        /// <summary>
        /// 区编号（县）
        /// </summary>
        public Int32 CountyId { get; set; }

        /// <summary>
        /// 街道（村）
        /// </summary>
        public String Town { get; set; }

        /// <summary>
        /// 街道编号（村）
        /// </summary>
        public Int32? TownId { get; set; }

        /// <summary>
        /// 地址
        /// </summary>
        public String Address { get; set; }

        /// <summary>
        /// 收件人
        /// </summary>
        public String UserName { get; set; }

        /// <summary>
        /// 联系方式
        /// </summary>
        public String Tel { get; set; }

    }
}