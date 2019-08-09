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
    /// �ɹ���ҵ��
    /// </summary>
    [Table("Scm_EnterpriseCompany")]
    public class Scm_EnterpriseCompany
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
        /// �ɹ���ҵId
        /// </summary>
        public String EnterpriseId { get; set; }

        /// <summary>
        /// �ɹ���ҵ��
        /// </summary>
        public String CompanyName { get; set; }

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
        /// ���Ŷ��
        /// </summary>
        public decimal DepositVal { get; set; }

        /// <summary>
        /// ���ö��
        /// </summary>
        public decimal DepositValUsed { get; set; }
    }
}