using System;

namespace HeroUp.Models.Generic
{
    public class Entity : IEntity
    {
        public int Id { get; set; }
        public DateTime CreatedAt { get; set; }
    }
}
