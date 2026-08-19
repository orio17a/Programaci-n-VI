namespace WebApi2026.Models
{
    public class Computadora
    {
        public string procesador { get; set; }
        public int ram { get; set; }
        public string marca { get; set; }
        public string modelo { get; set; }
        public List <string> programasInstalados { get; set; }

    }
}
