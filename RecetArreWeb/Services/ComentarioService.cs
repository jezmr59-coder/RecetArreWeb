using RecetArreWeb.DTOs;
using System.Net.Http.Json;

namespace RecetArreWeb.Services
{
    public interface IComentarioService
    {
        Task<List<ComentarioDto>> ObtenerPorReceta(int recetaId);
        Task<ComentarioDto?> Crear(ComentarioCreacionDto dto);
        Task<bool> Actualizar(int id, ComentarioModificacionDto dto);
        Task<bool> Eliminar(int id);
    }

    public class ComentarioService : IComentarioService
    {
        private readonly HttpClient httpClient;
        private const string endpoint = "api/Comentarios";

        public ComentarioService(HttpClient httpClient)
        {
            this.httpClient = httpClient;
        }

        public async Task<List<ComentarioDto>> ObtenerPorReceta(int recetaId)
        {
            try
            {
                var lista = await httpClient.GetFromJsonAsync<List<ComentarioDto>>($"{endpoint}/receta/{recetaId}");
                return lista ?? new();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error al obtener comentarios: {ex.Message}");
                return new();
            }
        }

        public async Task<ComentarioDto?> Crear(ComentarioCreacionDto dto)
        {
            try
            {
                var response = await httpClient.PostAsJsonAsync(endpoint, dto);
                if (response.IsSuccessStatusCode)
                    return await response.Content.ReadFromJsonAsync<ComentarioDto>();

                Console.WriteLine($"Error al crear comentario: {await response.Content.ReadAsStringAsync()}");
                return null;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error al crear comentario: {ex.Message}");
                return null;
            }
        }

        public async Task<bool> Actualizar(int id, ComentarioModificacionDto dto)
        {
            try
            {
                var response = await httpClient.PutAsJsonAsync($"{endpoint}/{id}", dto);
                return response.IsSuccessStatusCode;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error al actualizar comentario: {ex.Message}");
                return false;
            }
        }

        public async Task<bool> Eliminar(int id)
        {
            try
            {
                var response = await httpClient.DeleteAsync($"{endpoint}/{id}");
                return response.IsSuccessStatusCode;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error al eliminar comentario: {ex.Message}");
                return false;
            }
        }
    }
}