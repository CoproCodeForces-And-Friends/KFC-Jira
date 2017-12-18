using System;

namespace KFCJira.Models
{
    public class KFCIssue
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime CreationDate { get; set; }
        public string Status { get; set; }
        public int CreatorId { get; set; }
        public int DeveloperId { get; set; }
        public string[] Labels { get; set; }
        public int ProjectId { get; set; }
        public KFCIssue[] RelatedIssue { get; set; }
    }
}