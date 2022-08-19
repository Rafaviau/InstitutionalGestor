using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestIn.Controladora
{
    internal class ControladoraCursada
    {
		private List<Cursada> ListCursadas;

		private static ControladoraCursada? Instance;

		private ControladoraCursada()
		{
			ListCursadas = new List<Cursada>();
		}

		public static ControladoraCursada GetInstance()
		{
			if (Instance == null)
			{
				Instance = new ControladoraCursada();
			}
			return Instance;
		}

		public List<Cursada> ReturnListCursadas()
        {
			return ListCursadas;
        }

		public void CreateCursada(int cicloLectivo,Alumno alumno, Materia materia, bool aprobada)
        {
			//Cursada cur = new Cursada(cicloLectivo, alumno, materia, aprobada);
			//ListCursadas.Add(cur);
        }

		public List<Cursada> ReadCursada(int cicloLectivo)
		{
			List<Cursada> listAux = new List<Cursada>();

			foreach (Cursada aux in ListCursadas)
			{
				//if (aux.CICLOLECTIVO == cicloLectivo)
				{
					listAux.Add(aux);
				}
			}
			return listAux;
		}


		public void UpdateCursada(Cursada nuevacursada)
		{
			foreach (Cursada c in ListCursadas)
			{
				//if (c.CICLOLECTIVO == nuevacursada.CICLOLECTIVO) //ID
				{
					ListCursadas.Remove(c);
					ListCursadas.Add(nuevacursada);
				}
			}
		}

		public void DeleteCursada(Cursada cursada)
		{
			foreach (Cursada c in ListCursadas)
			{
				//if (c.CICLOLECTIVO == cursada.CICLOLECTIVO) //ID
				{
					ListCursadas.Remove(c);
				}
			}
		}





	}
}
