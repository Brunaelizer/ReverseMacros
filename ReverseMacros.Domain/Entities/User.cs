using System;
using System.Collections.Generic;
using System.Text;

namespace ReverseMacros.Domain.Entities
{
    public class User(string name, string email, string passwordHash)
    {
        public Guid Id { get; private set; } = Guid.NewGuid();
        public string Name { get; private set; } = string.IsNullOrWhiteSpace(name) ? throw new ArgumentException("Nome obrigatório") : name;
        public string Email { get; private set; } = email.ToLower().Trim();
        public string PasswordHash { get; private set; } = passwordHash;
        public DateTime CreatedAt { get; private set; } = DateTime.UtcNow;
        public bool IsDeleted { get; private set; }
        public DateTime? DeletedAt { get; private set; }

        public void MarkAsDeleted()
        {
            IsDeleted = true;
            DeletedAt = DateTime.UtcNow;
        }

        protected User() : this(string.Empty, string.Empty, string.Empty) { }
    }
}
