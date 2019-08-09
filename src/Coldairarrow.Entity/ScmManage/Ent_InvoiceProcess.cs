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
    /// ��Ʊ���̱�
    /// </summary>
    [Table("Ent_InvoiceProcess")]
    public class Ent_InvoiceProcess
    {

        /// <summary>
        /// ��Ȼ����
        /// </summary>
        [Key, Column(Order = 1)]
        public String Id { get; set; }

        /// <summary>
        /// ��Ʊ���
        /// </summary>
        public String InvoiceId { get; set; }

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
        /// ����ʱ��
        /// </summary>
        public DateTime ActionTime { get; set; }

        /// <summary>
        /// ��ʽ:
        /// ����Ա:�û���ʵ����
        /// ����:[���뿪Ʊ, ��Ʊ, ���ȷ��, �տ�ȷ��]
        /// </summary>
        public String ActionSummary { get; set; }

        /// <summary>
        /// ����ͼƬJSON�ַ���
        /// </summary>
        public String Images { get; set; }

        /// <summary>
        /// ��������JSON�ַ���
        /// </summary>
        public String Atts { get; set; }

        /// <summary>
        /// ��ע
        /// </summary>
        public String Memo { get; set; }

    }
}