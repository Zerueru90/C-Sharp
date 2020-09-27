using Klasser;

namespace ArvOchAbstraktion
{
    public interface IVerkstad
    {
        void LäggtillFordon(Fordon fordon);
        void TabortFordon(Fordon fordon, string regnr);
    }
}
