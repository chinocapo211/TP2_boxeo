class boxeador
{
    public string nombre{get; set;}
    public string pais{get; set;}
    public int peso{get; set;}
    public int potenciaGolpes{get; set;}
    public int velocidadPiernas{get; set;}
    public boxeador()
    {
    }
    public boxeador(string nom, string pa, int pe, int pg, int vp)
    {
        nombre = nom;
        pais = pa;
        peso = pe;
        potenciaGolpes = pg;
        velocidadPiernas = vp;
    }
    public double obtenerSkills()
    {
        double devolver = 0;
        Random r= new Random ();
        devolver += potenciaGolpes * 0.8;
        devolver += velocidadPiernas * 0.6;
        devolver += r.Next(11);
        return devolver;
    }
}