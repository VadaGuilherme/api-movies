using System;

namespace MyMovies.Domain.Core.Entities
{
    public class Movies
    {
        public Guid Id { get; private set; }
        public string Title { get; private set; }
        public string Text { get; private set; }
        public int Release { get; private set; }
        public string Img { get; private set; }
    }
}