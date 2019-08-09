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
    /// Ent_OrderProduct
    /// </summary>
    [Table("Ent_OrderProduct")]
    public class Ent_OrderProduct
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
        /// ��ƷSKU
        /// </summary>
        public String SKU { get; set; }

        /// <summary>
        /// ��Ʒ��Դ����
        /// </summary>
        public Int32? ProductSourceType { get; set; }

        /// <summary>
        /// ��Ʒ��Դ����
        /// </summary>
        public String ProductSourceName { get; set; }

        /// <summary>
        /// ����
        /// </summary>
        public String Name { get; set; }

        /// <summary>
        /// Ʒ��
        /// </summary>
        public String Brand { get; set; }

        /// <summary>
        /// ��ͼ��ַ
        /// </summary>
        public String ImagePath { get; set; }

        /// <summary>
        /// ��ƷͼƬ
        /// </summary>
        public String Images { get; set; }

        /// <summary>
        /// ���۵�λ
        /// </summary>
        public String Unit { get; set; }

        /// <summary>
        /// ����
        /// </summary>
        public String Weight { get; set; }

        /// <summary>
        /// ����
        /// </summary>
        public String ProductArea { get; set; }

        /// <summary>
        /// ��װ�嵥
        /// </summary>
        public String Pack { get; set; }

        /// <summary>
        /// ������ܣ�һ��html��
        /// </summary>
        public String Details { get; set; }

        /// <summary>
        /// ������������һ��html��
        /// </summary>
        public String Param { get; set; }

        /// <summary>
        /// �̳Ǽ۸�
        /// </summary>
        public decimal MallPrice { get; set; }

        /// <summary>
        /// ��Ʒ����
        /// </summary>
        public String Category { get; set; }

        /// <summary>
        /// ��Ʒ�ȼ���
        /// </summary>
        public String PCCR_Group { get; set; }

        /// <summary>
        /// �����������_����
        /// </summary>
        public String ApprovalOrderId { get; set; }

        /// <summary>
        /// �����������
        /// </summary>
        public String ApprovalOrderIdNo { get; set; }

        /// <summary>
        /// �������_����
        /// </summary>
        public String OrderId { get; set; }

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
        /// ����
        /// </summary>
        public Int32 Quantity { get; set; }

        /// <summary>
        /// ���
        /// </summary>
        public decimal Amount { get; set; }

        /// <summary>
        /// ��Ʊ���
        /// </summary>
        public String InvoiceId { get; set; }

        /// <summary>
        /// ��Ʊ�û����
        /// </summary>
        public String OpenInvoiceUserId { get; set; }

        /// <summary>
        /// ��Ʊ�û�����
        /// </summary>
        public String OpenInvoiceUserRealName { get; set; }

        /// <summary>
        /// ��Ʊʱ��
        /// </summary>
        public DateTime? OpenInvoiceTime { get; set; }

        /// <summary>
        /// �Ƿ����
        /// </summary>
        public Boolean IsReconciliation { get; set; }

        /// <summary>
        /// �����û����
        /// </summary>
        public String ReconciliationUserId { get; set; }

        /// <summary>
        /// �����û�����
        /// </summary>
        public String ReconciliationUserRealName { get; set; }

        /// <summary>
        /// ����ʱ��
        /// </summary>
        public DateTime? ReconciliationTime { get; set; }

        /// <summary>
        /// �Ƿ񿪹�Ʊ
        /// </summary>
        public Boolean IsOpenedInvoice { get; set; }

        /// <summary>
        /// �̳���ƷId
        /// </summary>
        public String MallProductId { get; set; }

        /// <summary>
        /// ԭ�ۣ�������Լ�ۡ���Ӫ��Ʒԭ�ۻ��ӹ�Ӧ��ԭ�ۣ�
        /// </summary>
        public decimal OriginalPrice { get; set; }

        /// <summary>
        /// ������Ӧ��Id
        /// </summary>
        public String SupplierId { get; set; }

        /// <summary>
        /// �˷�(��Ʒ�����������˷�)
        /// </summary>
        public decimal Carriage { get; set; }

        /// <summary>
        /// ��Ʒ�˷�(������Ʒ�����ռ��̯�Ĳ��ֶ����˷�)
        /// </summary>
        public decimal ProductCarriage { get; set; }

        /// <summary>
        /// ��Ʊģʽ(1.������Ʒ��Ʊ,2.���ݶ�����Ʊ)
        /// </summary>
        public Int32 OpenInvoiceMode { get; set; }

        /// <summary>
        /// ��Ʊ�˷�(ͬһ[��Ʊ&����]һ�µ���Ʒ�˷��ܶ�)
        /// </summary>
        public decimal OpenInvoiceCarriage { get; set; }

    }
}