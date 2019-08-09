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
    /// ��Ӧ��������Ʊ,��Ӧ������ķ�Ʊ
    /// </summary>
    [Table("Scm_OrderInvoice")]
    public class Scm_OrderInvoice
    {

        /// <summary>
        /// ����
        /// </summary>
        [Key, Column(Order = 1)]
        public String Id { get; set; }

        /// <summary>
        /// ��Ӧ��Id
        /// </summary>
        public String ScmId { get; set; }

        /// <summary>
        /// ����Id
        /// </summary>
        public String OrderId { get; set; }

        /// <summary>
        /// ��ǩ
        /// </summary>
        public String InvoiceInfoTag { get; set; }

        /// <summary>
        /// ��Ʊ����(1:��ֵ˰��ͨ��Ʊ,2:��ֵ˰ר�÷�Ʊ)
        /// </summary>
        public Int32 InvoiceType { get; set; }

        /// <summary>
        /// ��Ʊ̧ͷ
        /// </summary>
        public String InvoiceTitle { get; set; }

        /// <summary>
        /// ˰��Ǽ�֤��
        /// </summary>
        public String TaxRegistryNumber { get; set; }

        /// <summary>
        /// ����������������
        /// </summary>
        public String BankName { get; set; }

        /// <summary>
        /// ���������˺�
        /// </summary>
        public String BankNumber { get; set; }

        /// <summary>
        /// ע�᳡����ַ
        /// </summary>
        public String RegistryAddress { get; set; }

        /// <summary>
        /// �̶��绰
        /// </summary>
        public String Tel { get; set; }

        /// <summary>
        /// ��Ʊ��Դ����
        /// </summary>
        public Int32 InvoiceSourceType { get; set; }

        /// <summary>
        /// ��Ʊ��Դ����
        /// </summary>
        public String InvoiceSourceName { get; set; }

        /// <summary>
        /// ��Ʊ���(������ں�̨��ʾ,��ʽ:Iʱ��-4λ�����)
        /// </summary>
        public String InvoiceNo { get; set; }

        /// <summary>
        /// ���
        /// </summary>
        public Decimal Amount { get; set; }

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
        public DateTime OpenInvoiceTime { get; set; }

        /// <summary>
        /// ״̬(1:����Ʊ,2:������[��״̬��������],3:��ȷ���տ�,4:��Ʊ���,5�������,6:���ʧ��,7:�Ѽĳ�,8:����˴���Ʊ,9:�ѿ�Ʊ���ĳ�)
        /// </summary>
        public Int32 Status { get; set; }

        /// <summary>
        /// ���ͷ�ʽ��0�����ӷ�Ʊ��1��ʵ�巢Ʊ
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
        /// ���̷�ƱId�����ڲ���
        /// </summary>
        public string MarkID { get; set; }

        /// <summary>
        /// ��Ӧ��Id
        /// </summary>
        public string SupId { get; set; }

        /// <summary>
        /// ����ʱ��
        /// </summary>
        public DateTime CreateDate { get; set; }
    }
}