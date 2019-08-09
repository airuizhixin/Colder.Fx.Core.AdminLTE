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
    /// ƽ̨�ӿڲ�����
    /// </summary>
    [Table("Scm_PlateformApiParam")]
    public class Scm_PlateformApiParam
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
        /// ����client_id
        /// </summary>
        public String JD_client_id { get; set; }

        /// <summary>
        /// ����client_secret
        /// </summary>
        public String JD_client_secret { get; set; }

        /// <summary>
        /// ����username
        /// </summary>
        public String JD_username { get; set; }

        /// <summary>
        /// ����password
        /// </summary>
        public String JD_password { get; set; }

    }
}