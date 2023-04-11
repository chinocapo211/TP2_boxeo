class boxeador
{
    Random r= new Random ();
    public string nombre{get; set;}
    public string pais{get; set;}
    public int peso{get; set;}
    public int potenciaGolpes{get; set;}
    public int velocidadPiernas{get; set;}
    public int inteligencia {get; set;}
    public boxeador()
    {
    }
    public boxeador(string nom, string pa, int pe, int pg, int vp, int intel)
    {
        nombre = nom;
        pais = pa;
        peso = pe;
        potenciaGolpes = pg;
        velocidadPiernas = vp;
        inteligencia = intel;
    }
    public double obtenerSkills()
    {
        double devolver = 0;
        
        devolver += potenciaGolpes * 0.8;
        devolver += velocidadPiernas * 0.6;
        devolver += r.Next(11);
        devolver += inteligencia * 0.25;
        return devolver;
    }
    public void randomSkill()
    {
        potenciaGolpes = r.Next(101);
        velocidadPiernas = r.Next(101);
    }
}