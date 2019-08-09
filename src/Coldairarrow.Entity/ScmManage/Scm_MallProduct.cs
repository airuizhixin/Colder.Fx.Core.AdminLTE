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
    /// �̳���Ʒ��
    /// </summary>
    [Table("Scm_MallProduct")]
    public class Scm_MallProduct
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
        /// �̳�Id
        /// </summary>
        public String MallId { get; set; }

        /// <summary>
        /// �̳���ƷId
        /// </summary>
        public String MallProductId { get; set; }

        /// <summary>
        /// �̳���Ʒ����
        /// </summary>
        public String MallCategoryId { get; set; }

        /// <summary>
        /// ��Ӧ����ƷId
        /// </summary>
        public String ScmProductId { get; set; }

        /// <summary>
        /// �̳���Ʒ�۸�
        /// </summary>
        public decimal MallPrice { get; set; }

        /// <summary>
        /// ��Ʒ״̬��0���¼ܣ�1���ϼܣ�ָ�Ƿ��ϼ�չʾ���̳ǣ�
        /// </summary>
        public Int32 ProductSate { get; set; }

        /// <summary>
        /// ����ʱ��
        /// </summary>
        public DateTime? CreateTime { get; set; }

        /// <summary>
        /// ������
        /// </summary>
        public String Creator { get; set; }

        /// <summary>
        /// �Ƿ���ɾ��
        /// </summary>
        public bool IsDelete { get; set; }

        /// <summary>
        /// ����
        /// </summary>
        public int SaleCount { get; set; }

        /// <summary>
        /// ��ǩId,����������
        /// </summary>
        public string TagIds { get; set; }
    }
}