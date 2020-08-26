using System;
using System.Collections.Generic;

// ReSharper disable once CheckNamespace
namespace Tracker.Core.Domain.Models
{
    /// <summary>
    /// View Model class
    /// </summary>
    public partial class TaskReadModel
        : EntityReadModel
    {
        #region Generated Properties
        /// <summary>
        /// Gets or sets the property value for 'StatusId'.
        /// </summary>
        /// <value>
        /// The property value for 'StatusId'.
        /// </value>
        public Guid StatusId { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'PriorityId'.
        /// </summary>
        /// <value>
        /// The property value for 'PriorityId'.
        /// </value>
        public Guid? PriorityId { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'Title'.
        /// </summary>
        /// <value>
        /// The property value for 'Title'.
        /// </value>
        public string Title { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'Description'.
        /// </summary>
        /// <value>
        /// The property value for 'Description'.
        /// </value>
        public string Description { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'StartDate'.
        /// </summary>
        /// <value>
        /// The property value for 'StartDate'.
        /// </value>
        public DateTimeOffset? StartDate { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'DueDate'.
        /// </summary>
        /// <value>
        /// The property value for 'DueDate'.
        /// </value>
        public DateTimeOffset? DueDate { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'CompleteDate'.
        /// </summary>
        /// <value>
        /// The property value for 'CompleteDate'.
        /// </value>
        public DateTimeOffset? CompleteDate { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'AssignedId'.
        /// </summary>
        /// <value>
        /// The property value for 'AssignedId'.
        /// </value>
        public Guid? AssignedId { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'TenantId'.
        /// </summary>
        /// <value>
        /// The property value for 'TenantId'.
        /// </value>
        public Guid TenantId { get; set; }

        #endregion

        public string StatusName { get; set; }

        public string PriorityName { get; set; }

        public string AssignedEmail { get; set; }

    }
}
