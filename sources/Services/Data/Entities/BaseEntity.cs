﻿using System;

namespace SetMeta.Web.Data.Entities
{
    public class BaseEntity
    {
        public BaseEntity()
        {
            CreatedAt = UpdatedAt = DateTime.Now;
            IsDeleted = false;
        }

        public long Id { get; set; }
        public string PublicId { get; set; }

        public bool IsActive { get; set; }
        public string Name { get; set; }


        public long UpdatedBy { get; set; }
        public DateTime UpdatedAt { get; set; }

        public long CreatedBy { get; set; }
        public DateTime CreatedAt { get; set; }

        public long DeletedBy { get; set; }
        public DateTime? DeletedAt { get; set; }
        public bool IsDeleted { get; set; }
    }
}