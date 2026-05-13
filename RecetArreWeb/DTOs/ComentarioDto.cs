namespace RecetArreWeb.DTOs
{
    public class ComentarioDto
    {
        public int Id { get; set; }
        public string Contenido { get; set; } = default!;
        public int Puntuacion { get; set; }
        public DateTime CreadoUtc { get; set; }
        public string? UsuarioEmail { get; set; }
        public int RecetaId { get; set; }
    }

    public class ComentarioCreacionDto
    {
        public string Contenido { get; set; } = default!;
        public int Puntuacion { get; set; } = 5;
        public int RecetaId { get; set; }
    }

    public class ComentarioModificacionDto
    {
        public string Contenido { get; set; } = default!;
        public int Puntuacion { get; set; }
    }
}