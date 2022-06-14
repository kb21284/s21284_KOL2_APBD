namespace s21284_KOL2_APBD.Entities.Models
{
    public class Musician
    {
        public int IdMusician { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string NickName { get; set; }
        public virtual ICollection<MusicianTrack> MusicianTracks { get; set; }
    }
}
