using Klasser;

namespace ArvOchAbstraktion
{
    public interface IVerkstad
    {
        void läggtillFordon(Fordon fordon);
        void tabortFordon(Fordon fordon, string regnr);
    }
}
