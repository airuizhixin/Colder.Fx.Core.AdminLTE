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
    /// ������
    /// </summary>
    [Table("Ent_Order")]
    public class Ent_Order
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
        /// �����������_����
        /// </summary>
        public String ApprovalOrderId { get; set; }

        /// <summary>
        /// �����������
        /// </summary>
        public String ApprovalOrderIdNo { get; set; }

        /// <summary>
        /// �������
        /// </summary>
        public String OrderNo { get; set; }

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
        /// ���
        /// </summary>
        public decimal Amount { get; set; }

        /// <summary>
        /// ��Ʒ��Դ��ö�����ͣ�0����Ӫ��1����Ӧ�̣�2���������ݶ���Щ��
        /// </summary>
        public Int32 ProductSourceType { get; set; }

        /// <summary>
        /// ��Ʒ��Դ����
        /// </summary>
        public String ProductSourceName { get; set; }

        /// <summary>
        /// �����ջ���ַ���
        /// </summary>
        public String OrderAddressId { get; set; }

        /// <summary>
        /// ���̸�����
        /// </summary>
        public String E_Supplier_ParentOrder { get; set; }

        /// <summary>
        /// �����Ӷ���
        /// </summary>
        public String E_Supplier_ChildrenOrder { get; set; }

        /// <summary>
        /// ״̬(1:������,2:�ѷ���,3.���ջ�,-10�µ�ʧ��)
        /// </summary>
        public Int32 Status { get; set; }

        /// <summary>
        /// *��Ӧ��Id
        /// </summary>
        public String ScmId { get; set; }

        /// <summary>
        /// ���ͷ�ʽ(0:δ����,1:��������,2:��ݵ���)
        /// </summary>
        public Int32 DeliveryMethod { get; set; }

        /// <summary>
        /// ������˾
        /// </summary>
        public String LogisticsCompanies { get; set; }

        /// <summary>
        /// ��ݱ��
        /// </summary>
        public String ExpressNo { get; set; }

        /// <summary>
        /// ����Ա���
        /// </summary>
        public int OperatorUserNum { get; set; }

        /// <summary>
        /// ������Ӧ��Id
        /// </summary>
        public String SupplierId { get; set; }

        /// <summary>
        /// �˷�
        /// </summary>
        public decimal Carriage { get; set; }

        /// <summary>
        /// �µ�ʧ�ܱ�ע
        /// </summary>
        public string FailMemo { get; set; }

        /// <summary>
        /// �ɱ��������˷ѣ�
        /// </summary>
        public decimal OriginalAmount { get; set; }
    }
}