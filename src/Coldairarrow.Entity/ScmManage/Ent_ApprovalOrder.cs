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
    /// 审批订单表
    /// </summary>
    [Table("Ent_ApprovalOrder")]
    public class Ent_ApprovalOrder
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
        /// 工作流发布版本
        /// </summary>
        public String WorkflowPublishVersion { get; set; }

        /// <summary>
        /// 审批订单编号(编号用于后台显示,格式:A时间-4位随机数)
        /// </summary>
        public String ApprovalOrderNo { get; set; }

        /// <summary>
        /// 所属组织
        /// </summary>
        public String OrgId { get; set; }

        /// <summary>
        /// 所属组织名称
        /// </summary>
        public String OrgName { get; set; }

        /// <summary>
        /// 操作员编号
        /// </summary>
        public String OperatorId { get; set; }

        /// <summary>
        /// 操作员姓名
        /// </summary>
        public String OperatorRealName { get; set; }

        /// <summary>
        /// 预估金额
        /// </summary>
        public decimal PreestimateAmount { get; set; }

        /// <summary>
        /// 实付金额
        /// </summary>
        public decimal Amount { get; set; }

        /// <summary>
        /// 预算编号
        /// </summary>
        public String BudgetId { get; set; }

        /// <summary>
        /// 状态(0:审批中,10:待确认收货,100:交易完成,-10:审批不通过,-100:取消订单)
        /// </summary>
        public Int32 Status { get; set; }

        /// <summary>
        /// 备注
        /// </summary>
        public String Memo { get; set; }

        /// <summary>
        /// 订单收货地址编号
        /// </summary>
        public String OrderAddressId { get; set; }

        /// <summary>
        /// 操作员序号
        /// </summary>
        public int OperatorUserNum { get; set; }

        /// <summary>
        /// 是否提交过(已提交过:true,未提交过:null | false)
        /// </summary>
        public bool? Submitted { get; set; }
    }
}