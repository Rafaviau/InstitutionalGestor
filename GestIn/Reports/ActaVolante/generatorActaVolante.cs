﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


namespace GestIn.Reports.ActaVolante
{
    internal class generatorActaVolante
    {
        string _html = @"
            <!DOCTYPE html>
              <html>
              <head>
                <style>
                    .info{
	                    width: 49%;
	                    display: inline-block;
	                    text-align: left;
                    }

                    .info h5{
	                    margin: 1px;
                    }

                    tr{
	                    border: 1px solid;
                    }
                    td{
	                    border: 1px solid;
                    }
                    h4{
	                    display: inline-block;
                    }
                </style>
              </head>
              <body>
                <header>
                  <h3>Instituto Superior de Formación Técnica N° 194</h3>
                  <h4 style='text-align:right; margin: 2px;'>Código: 675433</h4>
                  <h1 style='text-align: center; margin: 2px;'>Acta volante de examen</h1>
                  <h5 style='display: inline-block;margin: 2px;'>Libro: ____</h5><h5 style='display: inline-block;margin: 2px;'>Folio: ____</h5>
                </header>
                <br>
                <hr>
                <section class='info'>
                  <h5>CARRERA: Tecnicatura Superior en análisis desarrollo y programación de aplicaciones</h5>
                  <h5>MATERIA: Análisis de sistemas</h5>      
                  <h5>DOCENTE: Gómez Mauro</h5>
                  <h5>VOCALES: Santini Esteban</h5>
                </section>
                <section class='info'>
                  <h5>AÑO: 2do</h5>
                  <h5>FECHA: 19/12/22</h5>
                  <h5>LUGAR: Aula 8</h5>
                  <h5>MODALIDAD: Examen final</h5>
                </section>
                <table style='border: 1px solid;'>
                  <tr>
                    <td>N°</td>
                    <td>Apellido y nombre</td>
                    <td>Dni</td>
                    <td>Condición</td>
                    <td>Escrito</td>
                    <td>Oral</td>
                    <td>Nota final</td>
                  </tr>
                  <hr>
                  <tr>
                    <td>1</td>
                    <td>Gonzalez, Juan</td>
                    <td>43566781</td>
                    <td>Presencial</td>
                    <td>8</td>
                    <td>8</td>
                    <td>8</td>
                  </tr>
                  <hr>
                  <tr>
                    <td>2</td>
                    <td>Ramirez, Ezequiel</td>
                    <td>39345718</td>
                    <td>Presencial</td>
                    <td>6</td>
                    <td>7</td>
                    <td>7</td>
                  </tr>
                  <tr>
                    <td>3</td>
                    <td>Luarte, Candela</td>
                    <td>45678231</td>
                    <td>Presencial</td>
                    <td>10</td>
                    <td>9</td>
                    <td>10</td>
                  </tr>         
                </table>
                <h4>Presidente _________</h4>
                <h4>Vocal _________</h4>
                <h4>Vocal _________</h4>
                <br>
                <h4>Total de alumnos: _______</h4>
                <h4>Aprobados: _______</h4>
                <h4>Desaprobados: _______</h4>
                <h4>Ausentes: _______</h4>
              </body>
              </html>
            ";
        #region Singletone
        private static generatorActaVolante? Instance;
        private generatorActaVolante() { }

        public static generatorActaVolante GetInstance()
        {
            if (Instance == null)
            {
                Instance = new generatorActaVolante();
            }
            return Instance;
        }
        #endregion

    }
}
