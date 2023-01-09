using System;
namespace poc_maui.Models
{
    public class PreviousInspection
    {
        /// <summary>
        /// Inspection id => unique identifier
        /// </summary>
        public string InspectionId { get; set; }
        /// <summary>
        /// PreviousInspectionId 
        /// </summary>
        public string PreviousInspectionId { get; set; }
        /// <summary>
        /// Business name
        /// </summary>
        public string BusinessName { get; set; }
        /// <summary>
        /// Inspection Type
        /// </summary>
        public string InspectionType { get; set; }
        /// <summary>
        /// Scheduled start date
        /// </summary>
        public DateTime? ScheduledStartDate { get; set; }
        /// <summary>
        /// Completion Date
        /// </summary>
        public DateTime CompletionDate { get; set; }
        /// <summary>
        /// Inspector first name
        /// </summary>
        public string InspectorFirstName { get; set; }
        /// <summary>
        /// Inspector last name
        /// </summary>
        public string InspectorLastName { get; set; }
        /// <summary>
        /// IsSuccess
        /// </summary>
        public bool IsSuccess { get; set; }
        /// <summary>
        /// ChipBackgroundColor
        /// </summary>
        public Color ChipBackgroundColor { get; set; }
        /// <summary>
        /// ChipTextColor
        /// </summary>
        public Color ChipTextColor { get; set; }
        /// <summary>
        /// ChipText
        /// </summary>
        public string ChipText { get; set; }

    }
}

