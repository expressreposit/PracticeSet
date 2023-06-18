namespace UseAPIAnalyzersSwaggerSwashBuckle.Repository
{
    public class AuthorRepository
    {
        List<Author> authors = new List<Author>()
        {
            new Author{Id = 1,FirstName = "Joydip",LastName = "Kanjilal"},
            new Author{Id = 2,FirstName = "Steve",LastName = "Smith"}
        };
        public async Task<Author> GetAuthor(int id)
        {
            var author = authors.FirstOrDefault(a => a.Id == id);
            return await Task.FromResult<Author>(author);
        }
        public async Task<bool> SaveAuthor(Author author)
        {
            var result = authors.Where(a => a.Id == author.Id);
            if (result == null)
            {
                authors.Add(author);
                return await Task.FromResult(true);
            }
            return await Task.FromResult(false);
        }
    }
}
