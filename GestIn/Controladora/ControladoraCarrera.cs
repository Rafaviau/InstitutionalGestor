using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GestIn.Modelo.Clases;

namespace GestIn.Controladora
{
    internal class ControladoraCarrera
    {
		private List<Carrera> ListCarreras;

		private static ControladoraCarrera? Instance;

		private ControladoraCarrera()
		{
			ListCarreras = new List<Carrera>();
		}

		public static ControladoraCarrera GetInstance()
		{
			if (Instance == null)
			{
				Instance = new ControladoraCarrera();
			}
			return Instance;
		}

		public List<Carrera> ReturnListCarreras()
		{
			return ListCarreras;
		}

		public List<Materia> ReturnListMaterias(Carrera carreraExistente)
		{
            Carrera aux = ReadCarrera(carreraExistente.NRORESOLUCION);
			return aux.LIST_MATERIAS;
			
		}

		/*********************************************************************************************************************/

		/*CARRERAS*/

		/*********************************************************************************************************************/

		public void CreateCarrera(int nroResolucion, string nombre, string nombreCorto, string turno, List<Materia> materiasEnCarrera)
        {
			Carrera nuevacarrera = new Carrera(nroResolucion, nombre, nombreCorto, turno, materiasEnCarrera);
			ListCarreras.Add(nuevacarrera);
        }

		public void CreateCarrera(int nroResolucion, string nombre, string nombreCorto, string turno)
		{
			Carrera nuevacarrera = new Carrera(nroResolucion, nombre, nombreCorto, turno);
			ListCarreras.Add(nuevacarrera);
		}

		public Carrera ReadCarrera(int nroResolucion)
		{
			Carrera carrera = null;

			foreach (Carrera aux in ListCarreras)
			{
				if (aux.NRORESOLUCION == nroResolucion)
				{
					carrera = aux;
				}
			}
			return carrera;
		}


		public void UpdateCarrera(Carrera nuevacarrera)
		{
			foreach (Carrera carreraExistente in ListCarreras)
			{
				if (carreraExistente.NRORESOLUCION == nuevacarrera.NRORESOLUCION) //ID
				{
					ListCarreras.Remove(carreraExistente);
					ListCarreras.Add(nuevacarrera);
				}
			}
		}

		public void DeleteCarrera(int nroResolucion)
		{
			ListCarreras.Remove(ReadCarrera(nroResolucion));
		}

		public void TestCarrera()
        {
			Carrera nuevacarrera = new Carrera(1, "Analisis Gastronomico", "AnaCom", "Tarde");
			ListCarreras.Add(nuevacarrera);
			Carrera nuevacarrera1 = new Carrera(2, "Programacion Terapeutica", "ProTera", "Vespertino");
			ListCarreras.Add(nuevacarrera1);
		}

		public string TOSTRINGCARRERA(Carrera c) //Prueba
		{
			return ("ID = " + c.NRORESOLUCION + " " + "Nombre" + " " + c.NOMBRE);
		}


		/*********************************************************************************************************************/

		/*MATERIAS*/

		/*********************************************************************************************************************/


		public void CreateMateria(int id, string nombre, List<Materia> correlativas, List<Docente> docentes, Dictionary<string, TimeSpan> cronograma, int anioEnCarrera, int cargaHorariaTotal, Carrera carrera)
		{
			Materia nuevaMateria = new Materia(id, nombre, correlativas, docentes, cronograma, anioEnCarrera, CalcularHorasSemanales(cargaHorariaTotal), cargaHorariaTotal);
			carrera.LIST_MATERIAS.Add(nuevaMateria);
			MessageBox.Show(TOSTRINGMATERIA(nuevaMateria));
		}

		public void CreateMateria(int id, string nombre, List<Materia> correlativas, int anioEnCarrera, int cargaHorariaTotal, Carrera carrera)
		{
			Materia nuevaMateria = new Materia(id, nombre, correlativas, anioEnCarrera, CalcularHorasSemanales(cargaHorariaTotal), cargaHorariaTotal);
			carrera.LIST_MATERIAS.Add(nuevaMateria);
			MessageBox.Show(TOSTRINGMATERIA(nuevaMateria));
		}

		public void CreateMateria(int id, string nombre, int anioEnCarrera, int cargaHorariaTotal, Carrera carrera)
		{
			Materia nuevaMateria = new Materia(id, nombre, anioEnCarrera, CalcularHorasSemanales(cargaHorariaTotal), cargaHorariaTotal);
			carrera.LIST_MATERIAS.Add(nuevaMateria);
			MessageBox.Show(TOSTRINGMATERIA(nuevaMateria));
		}


		public Materia ReadMateria(Materia materia, Carrera carrera) //Original
		{
			Materia _materia = null;

			foreach (Materia aux in carrera.LIST_MATERIAS)
			{
				if (aux.ANIOENCARRERA == materia.ANIOENCARRERA)
				{
					_materia = aux;
				}
			}
			return _materia;
		}


		public void UpdateMateria(Materia nuevaMateria, Carrera carreraExistente)
		{
			foreach (Carrera carrera in ListCarreras)
            {
				if(carreraExistente.NRORESOLUCION==carrera.NRORESOLUCION) //ID CARRERA
                {
					foreach (Materia materia in carrera.LIST_MATERIAS)
					{
						if (materia.ID == nuevaMateria.ID) //ID MATERIA
						{
							carrera.LIST_MATERIAS.Remove(materia);
							carrera.LIST_MATERIAS.Add(nuevaMateria);
							MessageBox.Show(TOSTRINGMATERIA(materia) + " "  +  "<" + TOSTRINGMATERIA(nuevaMateria));
						}
					}
				}
			}
		}

		public void DeleteMateria(Materia materiaBorrar, Carrera carreraExistente)
		{
			foreach (Carrera carrera in ListCarreras)
			{
				if (carrera.NRORESOLUCION == carreraExistente.NRORESOLUCION)
				{
					foreach (Materia materia in carreraExistente.LIST_MATERIAS)
					{
						if (materiaBorrar.ID == materia.ID) //ID
						{
							carrera.LIST_MATERIAS.Remove(materiaBorrar);
						}
					}
				}
			}
		}

		public void TestMateria()
		{
			List<Materia> testCorrelativasA = new List<Materia>();
			List<Materia> testCorrelativasB = new List<Materia>();

			foreach (Carrera carrera in ListCarreras)
			{
				if (carrera.NRORESOLUCION == 1)
				{
					Materia nuevamateria = new Materia(1, "Cocina Orientada a Objetos", 1, CalcularHorasSemanales(72), 24);
					carrera.LIST_MATERIAS.Add(nuevamateria);
					Materia nuevamateria1 = new Materia(2, "Gestion de Reposteria", 1, CalcularHorasSemanales(72), 24);
					carrera.LIST_MATERIAS.Add(nuevamateria1);

						testCorrelativasA.Add(nuevamateria);
						testCorrelativasA.Add(nuevamateria1);

					Materia nuevamateria2 = new Materia(3, "Investigacion Culinaria", testCorrelativasA, 2, CalcularHorasSemanales(72), 24);
					carrera.LIST_MATERIAS.Add(nuevamateria2);

						testCorrelativasB.Add(nuevamateria2);

					Materia nuevamateria3 = new Materia(4, "Practica Profesionalizante", testCorrelativasB, 3, CalcularHorasSemanales(72), 24);
					carrera.LIST_MATERIAS.Add(nuevamateria3);
				}
				else if (carrera.NRORESOLUCION == 2)
                {
					Materia nuevamateria = new Materia(1, "Terapia Intensiva por sobreutilización de GIT", 1, CalcularHorasSemanales(72), 24);
					carrera.LIST_MATERIAS.Add(nuevamateria);
					Materia nuevamateria1 = new Materia(2, "Psicologia de Programadores", 2, CalcularHorasSemanales(72), 24);
					carrera.LIST_MATERIAS.Add(nuevamateria1);
				}
			}
		}

		public int CalcularHorasSemanales(int horasTotales) 
        {
			return horasTotales / 32;
        }

		public string TOSTRINGMATERIA(Materia m) //Prueba
		{
			if(m.CORRELATIVAS.Count>0)
            {
				return ("ID = " + m.ID + " " + "Nombre" + " " + m.NOMBRE + " " + "Tiene Correlativas");
			}else
			{ 
				return ("ID = " + m.ID + " " + "Nombre" + " " + m.NOMBRE);
			}
		}
	}
}
