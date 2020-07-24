﻿namespace Syncfusion.Dashboard.Server.Api.Helper.V3.Models
{
    using System;
    using System.ComponentModel.DataAnnotations;
    using System.Runtime.Serialization;
    using System.Net;

    /// <summary>
    /// File details
    /// </summary>
    public class ApiFileUpdate
    {
        /// <summary>
        /// Item ID
        /// </summary>
        [DataMember]
        [Required]
        public Guid ItemId
        {
            get;
            set;
        }

        /// <summary>
        /// File name
        /// </summary>
        [DataMember]
        public string Name
        {
            get;
            set;
        }

        /// <summary>
        /// File description
        /// </summary>
        [DataMember]
        public string Description
        {
            get;
            set;
        }

        /// <summary>
        /// Comments about update
        /// </summary>
        [DataMember]
        public string VersionComment
        {
            get;
            set;
        }

        /// <summary>
        /// Provide the file extension to save the item
        /// </summary>
        [DataMember]
        public string Extension
        {
            get;
            set;
        }

        /// <summary>
        /// Provide items in an array of bytes
        /// </summary>
        [DataMember]
        public byte[] ItemContent
        {
            get;
            set;
        }

        [DataMember]
        public string Message { get; set; }

        [DataMember]
        public HttpStatusCode StatusCode { get; set; }
    }
}
