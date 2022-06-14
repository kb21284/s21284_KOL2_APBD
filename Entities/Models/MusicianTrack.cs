namespace s21284_KOL2_APBD.Entities.Models
{
    public class MusicianTrack
    {
        public int IdTrack { get; set; }
        public int IdMusician { get; set; }
        public virtual Musician Musician { get; set; }
        public virtual Track Track { get; set; }
    }
}
