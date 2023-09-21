namespace Alumbrado.Models
{
    public class Reading
    {
        public string Id { get; set; }
        public float Consumo { get; set; }
        public DateTime Fecha { get; set; }
        public TipoMedidor TipoMedidor { get; set; }
        public string? Notas { get; set; }

    }
}
