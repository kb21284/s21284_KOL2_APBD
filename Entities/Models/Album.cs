namespace s21284_KOL2_APBD.Entities.Models
{
    public class Album
    {
        public int IdAlbum { get; set; }
        public string AlbumName { get; set; }
        public DateTime PublishDate { get; set; }
        public int IdMusicLabel { get; set; }
        public virtual ICollection<Track> Tracks { get; set; }
    }
}
