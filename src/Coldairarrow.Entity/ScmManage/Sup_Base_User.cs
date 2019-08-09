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
    /// ��Ӧ���˺ű�
    /// </summary>
    [Table("Sup_Base_User")]
    public class Sup_Base_User
    {

        /// <summary>
        /// ��������
        /// </summary>
        [Key, Column(Order = 1)]
        public String Id { get; set; }

        /// <summary>
        /// �û�Id,�߼�����
        /// </summary>
        /// 
        public String UserId { get; set; }

        /// <summary>
        /// �û���
        /// </summary>
        public String UserName { get; set; }

        /// <summary>
        /// ����
        /// </summary>
        public String Password { get; set; }

        /// <summary>
        /// ��ʵ����
        /// </summary>
        public String RealName { get; set; }

        /// <summary>
        /// �Ա�(1Ϊ�У�0ΪŮ)
        /// </summary>
        public Int32? Sex { get; set; }

        /// <summary>
        /// ��������
        /// </summary>
        public DateTime? Birthday { get; set; }

        /// <summary>
        /// ��Ӧ��Id
        /// </summary>
        public string ScmId { get; set; }

        /// <summary>
        /// ��Ӧ��Id
        /// </summary>
        public string SupId { get; set; }

        /// <summary>
        /// �ֻ���
        /// </summary>
        public string PhoneNum { get; set; }

        /// <summary>
        /// ������
        /// </summary>
        public Boolean Disabled { get; set; }
    }
}