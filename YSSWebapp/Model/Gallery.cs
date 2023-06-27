namespace YSSWebapp.Model
{
    public class Gallery
    {
        [Key]
        public int ID { get; set; }
        public string albumName { get; set; }
        public string caption { get; set; }
        public byte[] img { get; set; }
        public bool isCarousel { get; set; }    
    }
}
