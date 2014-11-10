namespace ForumSystem.Data.Models
{
    using System;
    using System.ComponentModel.DataAnnotations;

    using ForumSystem.Data.Common.Models;

    public class Post : AuditInfo, IDeletableEntity
    {
        public int Id { get; set; }

        [MaxLength(100)]
        public string Title { get; set; }

        //// TODO: Author, 

        public bool IsDeleted { get; set; }

        public DateTime? DeletedOn { get; set; }
    }
}
