using System;
using GestIn.Modelo.Clases;

public class ControladoraMateria
{
	private List<Materia> ListMaterias;
	private static ControladoraMateria? Instance;
	private ControladoraMateria()
	{
		ListMaterias = new List<Materia>();
	}

	public static ControladoraMateria GetInstance()
	{
		if (Instance == null)
		{
			Instance = new ControladoraMateria();
		}
		return Instance;
	}

	
	public void CreateMateria(int id, string nombre, List<Materia> correlativas, List<Docente> docentes, List<DateTime> cronograma, int anioEnCarrera, int cargaHorariaSemanal, int cargaHorariaTotal)
    {
		Materia objMateria = new Materia(id, nombre, correlativas, docentes, cronograma, anioEnCarrera, cargaHorariaSemanal, cargaHorariaTotal);
		ListMaterias.Add(objMateria);
	}

	public void CreateMateria(int id, string nombre,int anioEnCarrera,int CargaHorariaSemanal, int CargaHorariaTotal)
	{
		Materia objMateria = new Materia(id, nombre, anioEnCarrera, CargaHorariaSemanal, CargaHorariaTotal);
		ListMaterias.Add(objMateria);
		MessageBox.Show(TOSTRINGMATERIA(objMateria));
	}

	public List<Materia> ReadMaterias(int año)
	{
		List<Materia> listAux = new List<Materia>();

		foreach (Materia aux in ListMaterias)
		{
			if (aux.ANIOENCARRERA == año)
			{
				listAux.Add(aux);
			}
		}
		return listAux;
	}


	public void UpdateMateria(int id, string nombre, List<Materia> correlativas, List<Docente> docentes, List<DateTime> cronograma, int anioEnCarrera, int cargaHorariaSemanal, int cargaHorariaTotal)
	{
		Materia objMateria = new Materia(id, nombre, correlativas, docentes, cronograma, anioEnCarrera, cargaHorariaSemanal, cargaHorariaTotal);
		foreach (Materia m in ListMaterias)
		{
			if (m.ID==objMateria.ID&&m.NOMBRE==objMateria.NOMBRE) //Nombre y ID
			{
				int a = ListMaterias.IndexOf(m);
				ListMaterias.RemoveAt(a);
				ListMaterias.Insert(a, objMateria);
			}
			//ListMaterias.RemoveAt(x);
			//ListMaterias.Insert(x, objMateria);
		}
	}

	public void DeleteMateria(int id)
	{
		Materia objMateria = new Materia(id);
		foreach (Materia m in ListMaterias)
		{
			if (m.ID==objMateria.ID)
			{
				ListMaterias.Remove(m);
			}
		}
	}

	public String TOSTRINGMATERIA(Materia m) //Prueba
	{
		return ("ID = " + m.ID + " " + "Nombre" + " " + m.NOMBRE);
	}


}

