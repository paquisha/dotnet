namespace webApiAutores.Entidades
{
    public class Autor
    {
        public int Id { get; set; }
        public string name { get; set; }
        public List<Libro> Libros { get; set; }
    }
}
