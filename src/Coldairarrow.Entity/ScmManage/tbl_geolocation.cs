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
    /// tbl_geolocation
    /// </summary>
    [Table("tbl_geolocation")]
    public class tbl_geolocation
    {

        /// <summary>
        /// id
        /// </summary>
        [Key, Column(Order = 1)]
        public Int32 id { get; set; }

        /// <summary>
        /// parentid
        /// </summary>
        public Int32 parentid { get; set; }

        /// <summary>
        /// name
        /// </summary>
        public String name { get; set; }

        /// <summary>
        /// sort
        /// </summary>
        public Int32? sort { get; set; }

        /// <summary>
        /// remark
        /// </summary>
        public String remark { get; set; }

        /// <summary>
        /// zip
        /// </summary>
        public String zip { get; set; }

        /// <summary>
        /// phoneareacode
        /// </summary>
        public String phoneareacode { get; set; }

        /// <summary>
        /// type
        /// </summary>
        public Int32? type { get; set; }

        /// <summary>
        /// jindongid
        /// </summary>
        public String jindongid { get; set; }

        /// <summary>
        /// jindongname
        /// </summary>
        public String jindongname { get; set; }

        /// <summary>
        /// jindonglevel
        /// </summary>
        public Int32? jindonglevel { get; set; }

        /// <summary>
        /// suningid
        /// </summary>
        public String suningid { get; set; }

        /// <summary>
        /// suningname
        /// </summary>
        public String suningname { get; set; }

        /// <summary>
        /// suninglevel
        /// </summary>
        public Int32? suninglevel { get; set; }

        /// <summary>
        /// deliid
        /// </summary>
        public String deliid { get; set; }

        /// <summary>
        /// deliname
        /// </summary>
        public String deliname { get; set; }

        /// <summary>
        /// delilevel
        /// </summary>
        public Int32? delilevel { get; set; }

        /// <summary>
        /// mgid
        /// </summary>
        public String mgid { get; set; }

        /// <summary>
        /// mgname
        /// </summary>
        public String mgname { get; set; }

        /// <summary>
        /// mglevel
        /// </summary>
        public Int32? mglevel { get; set; }

        /// <summary>
        /// you163id
        /// </summary>
        public String you163id { get; set; }

        /// <summary>
        /// you163name
        /// </summary>
        public String you163name { get; set; }

        /// <summary>
        /// you163level
        /// </summary>
        public Int32? you163level { get; set; }

    }
}