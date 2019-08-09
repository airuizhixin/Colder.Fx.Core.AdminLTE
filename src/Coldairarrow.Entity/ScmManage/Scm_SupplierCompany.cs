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
    /// ��Ӧ�̹�˾��
    /// </summary>
    [Table("Scm_SupplierCompany")]
    public class Scm_SupplierCompany
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
        /// ��Ӧ��Id
        /// </summary>
        /// 
        [Required]
        public String SupplierId { get; set; }

        /// <summary>
        /// ��Ӧ����ҵ��
        /// </summary>
        public String CompanyName { get; set; }

        /// <summary>
        /// ���
        /// </summary>
        public string ShortCompanyName { get; set; }

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

    }
}