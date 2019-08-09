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
    /// ��Ӧ���������˱�
    /// </summary>
    [Table("Scm_OrderSOA")]
    public class Scm_OrderSOA
    {

        /// <summary>
        /// ��Ȼ����
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
        /// �Ƿ��Ѷ��ˣ���Ӧ����Ϊ������
        /// </summary>
        public Boolean ScmSale_IsSOA { get; set; }

        /// <summary>
        /// �����û���ţ���Ӧ����Ϊ������
        /// </summary>
        public String ScmSale_SOAUserId { get; set; }

        /// <summary>
        /// �����û���������Ӧ����Ϊ������
        /// </summary>
        public String ScmSale_SOAUserRealName { get; set; }

        /// <summary>
        /// ����ʱ�䣨��Ӧ����Ϊ������
        /// </summary>
        public DateTime? ScmSale_SOATime { get; set; }

        /// <summary>
        /// �Ƿ��Ѷ��ˣ���Ӧ����Ϊ�򷽣�
        /// </summary>
        public Boolean ScmBuy_IsSOA { get; set; }

        /// <summary>
        /// �Ƿ��Ѷ��ˣ���Ӧ����Ϊ�򷽣�
        /// </summary>
        public String ScmBuy_SOAUserId { get; set; }

        /// <summary>
        /// �����û���������Ӧ����Ϊ�򷽣�
        /// </summary>
        public String ScmBuy_SOAUserRealName { get; set; }

        /// <summary>
        /// ����ʱ�䣨��Ӧ����Ϊ�򷽣�
        /// </summary>
        public DateTime? ScmBuy_SOATime { get; set; }

        /// <summary>
        /// �Ƿ��Ѷ��ˣ���Ӧ����Ϊ������
        /// </summary>
        public Boolean SupplierSale_IsSOA { get; set; }

        /// <summary>
        /// �����û���ţ���Ӧ����Ϊ������
        /// </summary>
        public String SupplierSale_SOAUserId { get; set; }

        /// <summary>
        /// �����û���������Ӧ����Ϊ������
        /// </summary>
        public String SupplierSale_SOAUserRealName { get; set; }

        /// <summary>
        /// ����ʱ�䣨��Ӧ����Ϊ������
        /// </summary>
        public DateTime? SupplierSale_SOATime { get; set; }

    }
}