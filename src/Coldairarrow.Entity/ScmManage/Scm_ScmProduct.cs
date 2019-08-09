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
    /// ��Ӧ������Ʒ��
    /// </summary>
    [Table("Scm_ScmProduct")]
    public class Scm_ScmProduct
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
        /// ��ƷId
        /// </summary>
        public String ProductId { get; set; }

        /// <summary>
        /// ��Ʒ���Id
        /// </summary>
        [Required]
        public String CategoryId { get; set; }

        /// <summary>
        /// ��Ʒ��Դ��ö�����ͣ�0����Ӫ��1�����̣���ƽ̨����2����Ӧ��
        /// </summary>
        public Int32? ProductSource { get; set; }

        /// <summary>
        /// ƽ̨��Ʒ��Դ��1�������������ݶ���
        /// </summary>
        public int? PlatformSource { get; set; }

        /// <summary>
        /// ƽ̨��ƷId
        /// </summary>
        public String PlatformProductId { get; set; }

        /// <summary>
        /// ��Ʒsku(ָ��Ʒ�ھ����������ȵ�sku) 
        /// </summary>
        public String PlatformProductSKU { get; set; }

        /// <summary>
        /// ƽ̨��Ʒ���Id
        /// </summary>
        public String PlateformCategoryId { get; set; }

        /// <summary>
        /// ������Ӧ��Id
        /// </summary>
        /// 
        [Required]
        public String SupplierId { get; set; }

        /// <summary>
        /// Ʒ��Id(Ԥ��)
        /// </summary>
        public String BrandId { get; set; }

        /// <summary>
        /// Ʒ����
        /// </summary>
        public String BrandName { get; set; }

        /// <summary>
        /// ��Ʒ��
        /// </summary>
        public String ProductName { get; set; }

        /// <summary>
        /// �г��ۣ�ָ�ھ������̳�ҳ������ʾ�ļ۸�
        /// </summary>
        public decimal MarketPrice { get; set; }

        /// <summary>
        /// ԭ�ۣ�������Լ�ۡ���Ӫ��Ʒԭ�ۻ��ӹ�Ӧ��ԭ�ۣ� 
        /// </summary>
        public decimal OriginalPrice { get; set; }

        /// <summary>
        /// ��Ӧ���ۣ���Ӧ����Ʒ���м۸�
        /// </summary>
        public decimal ScmPrice { get; set; }

        /// <summary>
        /// ��Ʒ��ͼ��ַ
        /// </summary>
        public String ProductMainImg { get; set; }

        /// <summary>
        /// ��ƷͼƬ��ַ�����Ŷ������
        /// </summary>
        public String ProductImgs { get; set; }

        /// <summary>
        /// ���۵�λ���� �У�
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
        /// ��װ�嵥���� ��Ҷ�������һ��һ�ĳ� ��
        /// </summary>
        public String Pack { get; set; }

        /// <summary>
        /// ������
        /// </summary>
        public String UPC { get; set; }

        /// <summary>
        /// ������ܣ�һ��html��
        /// </summary>
        public String Details { get; set; }

        /// <summary>
        /// ������������һ��html��
        /// </summary>
        public String Param { get; set; }

        /// <summary>
        /// ��Ʒ��棨���ֶδ�������Ϊ�����ӿ��еĿ���Ƿֵ���ģ�����ֻ�����Ƿ��л���
        /// </summary>
        public Int32? StockQuantity { get; set; }

        /// <summary>
        /// ��Ʒ״̬��0��δ��⣬1������⣬���ָ���빩Ӧ������Ʒ�أ�
        /// </summary>
        public Int32 ProductSate { get; set; }

        /// <summary>
        /// ������
        /// </summary>
        public String Creater { get; set; }

        /// <summary>
        /// ����ʱ��
        /// </summary>
        public DateTime? CreateTime { get; set; }

        /// <summary>
        /// �޸���
        /// </summary>
        public String Modifier { get; set; }

        /// <summary>
        /// �޸�ʱ��
        /// </summary>
        public DateTime? ModifyTime { get; set; }

        /// <summary>
        /// ��Ʒ��Դ��ö�����ͣ�0����Ӫ��1����Ӧ�̣�2���������ݶ���Щ��
        /// </summary>
        public Int32 ProductSourceType { get; set; }

        /// <summary>
        /// ��Ʒ��Դ����
        /// </summary>
        public String ProductSourceName { get; set; }

        /// <summary>
        /// �Ƿ���ɾ��
        /// </summary>
        public bool IsDelete { get; set; }
    }
}