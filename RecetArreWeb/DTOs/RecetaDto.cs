namespace RecetArreWeb.DTOs
{
    public class RecetaDto
    {
        public int Id { get; set; }
        public string Titulo { get; set; } = default!;
        public string? Descripcion { get; set; }
        public string Instrucciones { get; set; } = default!;
        public int TiempoPreparacionMinutos { get; set; }
        public int TiempoCoccionMinutos { get; set; }
        public int Porciones { get; set; }
        public bool EstaPublicado { get; set; }
        public DateTime CreadoUtc { get; set; }
        public List<IngredienteRecetaDto> Ingredientes { get; set; } = new();
        public List<string> Categorias { get; set; } = new();
    }

    public class IngredienteRecetaDto
    {
        public int IngredienteId { get; set; }
        public string Nombre { get; set; } = default!;
    }

    public class RecetaCreacionDto
    {
        public string Titulo { get; set; } = default!;
        public string? Descripcion { get; set; }
        public string Instrucciones { get; set; } = default!;
        public int TiempoPreparacionMinutos { get; set; }
        public int TiempoCoccionMinutos { get; set; }
        public int Porciones { get; set; } = 1;
        public bool EstaPublicado { get; set; } = true;
        public List<int> CategoriaIds { get; set; } = new();
        public List<int> IngredienteIds { get; set; } = new();
    }

    public class RecetaModificacionDto
    {
        public string Titulo { get; set; } = default!;
        public string? Descripcion { get; set; }
        public string Instrucciones { get; set; } = default!;
        public int TiempoPreparacionMinutos { get; set; }
        public int TiempoCoccionMinutos { get; set; }
        public int Porciones { get; set; } = 1;
        public bool EstaPublicado { get; set; } = true;
        public List<int> CategoriaIds { get; set; } = new();
        public List<int> IngredienteIds { get; set; } = new();
    }
}