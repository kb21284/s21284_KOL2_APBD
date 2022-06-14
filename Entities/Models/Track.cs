namespace s21284_KOL2_APBD.Entities.Models
{
    public class Track
    {
        public int IdTrack { get; set; }
        public string TrackName { get; set; }
        public float Duration { get; set; }
        public int IdAlbum { get; set; }
        public virtual ICollection<MusicianTrack> MusicianTracks { get; set; }
    }
}