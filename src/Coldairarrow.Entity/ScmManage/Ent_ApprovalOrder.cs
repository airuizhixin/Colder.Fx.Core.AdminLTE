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
    /// ����������
    /// </summary>
    [Table("Ent_ApprovalOrder")]
    public class Ent_ApprovalOrder
    {

        /// <summary>
        /// ��Ȼ����
        /// </summary>
        [Key, Column(Order = 1)]
        public String Id { get; set; }

        /// <summary>
        /// ��ҵ���
        /// </summary>
        public String EntId { get; set; }

        /// <summary>
        /// ����ʱ��
        /// </summary>
        public DateTime CreateDate { get; set; }

        /// <summary>
        /// �Ƿ�ɾ��
        /// </summary>
        public Boolean IsDelete { get; set; }

        /// <summary>
        /// ��չ�ֶ�
        /// </summary>
        public String Ext { get; set; }

        /// <summary>
        /// �����������汾
        /// </summary>
        public String WorkflowPublishVersion { get; set; }

        /// <summary>
        /// �����������(������ں�̨��ʾ,��ʽ:Aʱ��-4λ�����)
        /// </summary>
        public String ApprovalOrderNo { get; set; }

        /// <summary>
        /// ������֯
        /// </summary>
        public String OrgId { get; set; }

        /// <summary>
        /// ������֯����
        /// </summary>
        public String OrgName { get; set; }

        /// <summary>
        /// ����Ա���
        /// </summary>
        public String OperatorId { get; set; }

        /// <summary>
        /// ����Ա����
        /// </summary>
        public String OperatorRealName { get; set; }

        /// <summary>
        /// Ԥ�����
        /// </summary>
        public decimal PreestimateAmount { get; set; }

        /// <summary>
        /// ʵ�����
        /// </summary>
        public decimal Amount { get; set; }

        /// <summary>
        /// Ԥ����
        /// </summary>
        public String BudgetId { get; set; }

        /// <summary>
        /// ״̬(0:������,10:��ȷ���ջ�,100:�������,-10:������ͨ��,-100:ȡ������)
        /// </summary>
        public Int32 Status { get; set; }

        /// <summary>
        /// ��ע
        /// </summary>
        public String Memo { get; set; }

        /// <summary>
        /// �����ջ���ַ���
        /// </summary>
        public String OrderAddressId { get; set; }

        /// <summary>
        /// ����Ա���
        /// </summary>
        public int OperatorUserNum { get; set; }

        /// <summary>
        /// �Ƿ��ύ��(���ύ��:true,δ�ύ��:null | false)
        /// </summary>
        public bool? Submitted { get; set; }
    }
}