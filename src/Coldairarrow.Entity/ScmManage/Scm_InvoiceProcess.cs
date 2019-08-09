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
    /// ��Ӧ����Ʊ���̱�
    /// </summary>
    [Table("Scm_InvoiceProcess")]
    public class Scm_InvoiceProcess
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
        /// ��ƱId
        /// </summary>
        public String ScmOrderInvoiceId { get; set; }

        /// <summary>
        /// �������ͣ�0�����뿪Ʊ��1����Ʊ��2�����ȷ�ϣ�3���տ�ȷ�ϣ�4����˳ɹ���5���ĳ���6�����ʧ�ܣ�7����Ʊ���
        /// </summary>
        public Int32 ProcessType { get; set; }

        /// <summary>
        /// ����������
        /// </summary>
        public String OpRealName { get; set; }

        /// <summary>
        /// ������Id
        /// </summary>
        public String OpUserId { get; set; }

        /// <summary>
        /// ����ʱ��
        /// </summary>
        public DateTime? OpTime { get; set; }

        /// <summary>
        /// ����������������
        /// </summary>
        public String Files { get; set; }

        /// <summary>
        /// ��ע
        /// </summary>
        public String Note { get; set; }

    }
}