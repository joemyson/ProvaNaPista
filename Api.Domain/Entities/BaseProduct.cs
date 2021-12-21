using System;
using System.ComponentModel.DataAnnotations;

namespace Api.Domain.Entities
{
    public abstract class BaseProduct
    {
        [Key]
        public Guid Id { get; set; }

        private DateTime? _createAt;

        private DateTime? CreateAt
        {
            get { return _createAt; }
    set { _createAt = (value == null ? DateTime.UtcNow : value); }
        }

        public DateTime UpDateAt { get; set; }


    }
}
