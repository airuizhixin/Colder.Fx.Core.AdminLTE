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
    /// ��Ӧ����˾��
    /// </summary>
    [Table("Scm_ScmCompany")]
    public class Scm_ScmCompany
    {

        /// <summary>
        /// ��Ȼ����
        /// </summary>
        [Key, Column(Order = 1)]
        public String Id { get; set; }

        /// <summary>
        /// ��Ӧ������Id
        /// </summary>
        public String ScmId { get; set; }

        /// <summary>
        /// ��Ӧ����ҵ��
        /// </summary>
        public String CompanyName { get; set; }

        /// <summary>
        /// ��˾���
        /// </summary>
        public string CompanyShortName { get; set; }

        /// <summary>
        /// ��˰��ʶ���
        /// </summary>
        public String TIN { get; set; }

        /// <summary>
        /// �绰
        /// </summary>
        public String TEL { get; set; }

        /// <summary>
        /// ��������
        /// </summary>
        public String BankName { get; set; }

        /// <summary>
        /// �����˺�
        /// </summary>
        public String BankAccount { get; set; }

        /// <summary>
        /// ƽ̨��Ӧ��Id
        /// </summary>
        public String PlatformScmId { get; set; }

        /// <summary>
        /// ����
        /// </summary>
        public String CompanyArea { get; set; }

        /// <summary>
        /// �ȼ�����
        /// </summary>
        public String GradeLevel { get; set; }

        /// <summary>
        /// ����ʱ��
        /// </summary>
        public DateTime? ExpireTime { get; set; }

        /// <summary>
        /// ����̳�����
        /// </summary>
        public Int32? MaxShopQty { get; set; }

        /// <summary>
        /// ���Ӧ������
        /// </summary>
        public Int32? SubSupplierMaxQty { get; set; }

        /// <summary>
        /// 1:��������Ʊ��2������Ʒ��Ʊ(�˴��ġ���Ʊģʽ��ָ�̳���Ӧ���Ŀ�Ʊ)
        /// </summary>
        public Int32 InvoiceMode { get; set; }

        /// <summary>
        /// ��ַ
        /// </summary>
        public string Address { get; set; }
    }
}