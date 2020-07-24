﻿namespace Syncfusion.Dashboard.Server.Api.Helper.V4.Models
{
    using System;
    using System.Net;
    using System.Runtime.Serialization;

    /// <summary>
    /// Item Details.
    /// </summary>
    public class ApiSpecifiedItemDetailV4
    {
        /// <summary>
        /// Item ID.
        /// </summary>
        [DataMember]
        public Guid Id
        {
            get;
            set;
        }

        /// <summary>
        /// Item type.
        /// </summary>
        [DataMember]
        public string ItemType
        {
            get;
            set;
        }

        /// <summary>
        /// Item name.
        /// </summary>
        [DataMember]
        public string Name
        {
            get;
            set;
        }

        /// <summary>
        /// Item description.
        /// </summary>
        [DataMember]
        public string Description
        {
            get;
            set;
        }

        /// <summary>
        /// Specifies the user ID of the item creator.
        /// </summary>
        [DataMember]
        public int CreatedById
        {
            get;
            set;
        }

        /// <summary>
        /// Item ID from where the item was cloned.
        /// </summary>
        [DataMember]
        public Guid? CloneOf
        {
            get;
            set;
        }

        /// <summary>
        /// Category ID.
        /// </summary>
        [DataMember]
        public Guid? CategoryId
        {
            get;
            set;
        }

        /// <summary>
        /// Category name.
        /// </summary>
        [DataMember]
        public string CategoryName
        {
            get;
            set;
        }

        /// <summary>
        /// Date created of item in date format.
        /// </summary>
        [DataMember]
        public DateTime ItemCreatedDate
        {
            get;
            set;
        }

        /// <summary>
        /// Date modified of item in date format.
        /// </summary>
        [DataMember]
        public DateTime ItemModifiedDate
        {
            get;
            set;
        }

        /// <summary>
        /// Date created of item in string format.
        /// </summary>
        [DataMember]
        public string CreatedDate
        {
            get;
            set;
        }

        /// <summary>
        /// Date modified of item in string format.
        /// </summary>
        [DataMember]
        public string ModifiedDate
        {
            get;
            set;
        }

        /// <summary>
        /// Specifies the user ID of the item modifier.
        /// </summary>
        [DataMember]
        public int ModifiedById
        {
            get;
            set;
        }

        /// <summary>
        /// Item extension.
        /// </summary>
        [DataMember]
        public string Extension
        {
            get;
            set;
        }

        /// <summary>
        /// Returns true if the item is public.
        /// </summary>
        [DataMember]
        public bool IsPublic
        {
            get;
            set;
        }

        /// <summary>
        /// Returns true if the item is active.
        /// </summary>
        [DataMember]
        public bool IsActive
        {
            get;
            set;
        }

        /// <summary>
        /// Returns true if the item is Unlisted.
        /// </summary>
        [DataMember]
        public bool IsUnlisted
        {
            get;
            set;
        }

        /// <summary>
        /// Returns true if the item is Web Designer Compatible
        /// </summary>
        [DataMember]
        public bool IsWebDesignerCompatible
        {
            get;
            set;
        }

        /// <summary>
        /// Specifies the read permission of the item.
        /// </summary>
        [DataMember]
        public bool CanRead
        {
            get;
            set;
        }

        /// <summary>
        /// Specifies the write permission of the item.
        /// </summary>
        [DataMember]
        public bool CanWrite
        {
            get;
            set;
        }

        /// <summary>
        /// Specifies the delete permission of the item.
        /// </summary>
        [DataMember]
        public bool CanDelete
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
