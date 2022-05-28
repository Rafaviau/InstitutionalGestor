namespace GestIn.Modelo.Clases
{
    public class Docente
    {
        String? rol;
        int cuil;

        public Docente(string? rol, int cuil)
        {
            ROL = rol;
            CUIL = cuil;
        }

        public string? ROL { get => rol; set => rol = value; }
        public int CUIL { get => cuil; set => cuil = value; }

    }
}