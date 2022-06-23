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


		/*********************************************************************************************************************/

		/*MATERIAS*/

		/*********************************************************************************************************************/


		public void CreateMateria(int id, string nombre, List<Materia> correlativas, List<Docente> docentes, Dictionary<string, TimeSpan> cronograma, int anioEnCarrera, int cargaHorariaSemanal, int cargaHorariaTotal, Carrera carrera)
		{
			Materia nuevaMateria = new Materia(id, nombre, correlativas, docentes, cronograma, anioEnCarrera, cargaHorariaSemanal, cargaHorariaTotal);

			foreach (Carrera aux in ListCarreras)
			{
				if (carrera.NRORESOLUCION == aux.NRORESOLUCION)
				{
					carrera.LIST_MATERIAS.Add(nuevaMateria);
					MessageBox.Show(TOSTRINGMATERIA(nuevaMateria));
				}
			}
		}

		public void CreateMateria(int id, string nombre, int anioEnCarrera, int CargaHorariaSemanal, int CargaHorariaTotal, Carrera carrera)
		{
			Materia nuevaMateria = new Materia(id, nombre, anioEnCarrera, CargaHorariaSemanal, CargaHorariaTotal);
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

		public String TOSTRINGMATERIA(Materia m) //Prueba
		{
			return ("ID = " + m.ID + " " + "Nombre" + " " + m.NOMBRE);
		}
	}
}
