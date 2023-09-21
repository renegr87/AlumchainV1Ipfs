using Alumbrado.Abstracts;
using Alumbrado.Models;
using System.Text.Json;

namespace Alumbrado.Services
{
    internal class PublishService: IPublishService
    {
        public Reading[] LoadReadings(string source)
        {
            if (string.IsNullOrEmpty(source)) 
            {
                throw new ArgumentNullException("Fuente de datos vacía");
            }

            Reading[] readings;
            try
            {
                readings = JsonSerializer.Deserialize<Reading[]>(source);
            } catch (Exception)
            {
                throw new Exception("Error al parsear JSON invalido");
            }

            if(readings is null)
            {
                throw new ArgumentNullException("JSON invalido");
            }

            return readings;
        }

        public bool ValidateReadings(Reading[] readings) {
            // RENE: Aqui va la validación
            if (readings == null || readings.Length == 0)
            {
                return false;
            }
            // Ejemplo si cualquier (Any) lectura tiene un consumo igual a cero retorna error
            // Descartar las lecturas con consumo igual a 0
            var validReadings = readings.Where(reading => reading.Consumo > 0).ToArray();

            // Si no quedan lecturas después de descartar las que tienen consumo cero, retorna false
            if (validReadings.Length == 0)
            {
                return false;
            }

            // Ahora todas las lecturas restantes tienen consumo mayor a 0, por lo que son válidas
            return true;
        }
    }
}