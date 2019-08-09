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
    /// ����������Ʒ��
    /// </summary>
    [Table("Ent_ApprovalOrderProduct")]
    public class Ent_ApprovalOrderProduct
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
        /// ��Ʒ��Դ��ö�����ͣ�0����Ӫ��1����Ӧ�̣�2���������ݶ���Щ��
        /// </summary>
        public Int32? ProductSourceType { get; set; }

        /// <summary>
        /// ��Ʒ��Դ���ƣ���������֣�����XXX��Ӧ�̣�
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
        /// ��Ʒ�ȼ���
        /// </summary>
        public String PCCR_Group { get; set; }

        /// <summary>
        /// ��Ʒ����
        /// </summary>
        public String Category { get; set; }

        /// <summary>
        /// �����������_����
        /// </summary>
        public String ApprovalOrderId { get; set; }

        /// <summary>
        /// �����������
        /// </summary>
        public String ApprovalOrderIdNo { get; set; }

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
        public Double Amount { get; set; }

        /// <summary>
        /// �̳���ƷId
        /// </summary>
        public String MallProductId { get; set; }

        /// <summary>
        /// ������Ӧ��Id
        /// </summary>
        public String SupplierId { get; set; }

        /// <summary>
        /// ԭ�ۣ�������Լ�ۡ���Ӫ��Ʒԭ�ۻ��ӹ�Ӧ��ԭ�ۣ� 
        /// </summary>
        public decimal OriginalPrice { get; set; }
    }
}