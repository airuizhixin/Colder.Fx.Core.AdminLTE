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
    /// �����ջ���ַ��
    /// </summary>
    [Table("Ent_OrderAddress")]
    public class Ent_OrderAddress
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
        /// �ջ���ַ���
        /// </summary>
        public String AddressId { get; set; }

        /// <summary>
        /// �û����
        /// </summary>
        public String UserId { get; set; }

        /// <summary>
        /// ��ǩ
        /// </summary>
        public String Tag { get; set; }

        /// <summary>
        /// ����λ��������Դ
        /// </summary>
        public String GeolocationSource { get; set; }

        /// <summary>
        /// ����λ��������Դ����
        /// </summary>
        public String GeolocationSourceName { get; set; }

        /// <summary>
        /// ��ַ����(1:������ַ,2:��Ʊ��ַ)
        /// </summary>
        public Int32? AddressType { get; set; }

        /// <summary>
        /// ʡ��ֱϽ�У���������
        /// </summary>
        public String Province { get; set; }

        /// <summary>
        /// ʡ��ţ�ֱϽ�У���������
        /// </summary>
        public Int32 ProvinceId { get; set; }

        /// <summary>
        /// ��
        /// </summary>
        public String City { get; set; }

        /// <summary>
        /// �б��
        /// </summary>
        public Int32 CityId { get; set; }

        /// <summary>
        /// �����أ�
        /// </summary>
        public String County { get; set; }

        /// <summary>
        /// ����ţ��أ�
        /// </summary>
        public Int32 CountyId { get; set; }

        /// <summary>
        /// �ֵ����壩
        /// </summary>
        public String Town { get; set; }

        /// <summary>
        /// �ֵ���ţ��壩
        /// </summary>
        public Int32? TownId { get; set; }

        /// <summary>
        /// ��ַ
        /// </summary>
        public String Address { get; set; }

        /// <summary>
        /// �ռ���
        /// </summary>
        public String UserName { get; set; }

        /// <summary>
        /// ��ϵ��ʽ
        /// </summary>
        public String Tel { get; set; }

    }
}