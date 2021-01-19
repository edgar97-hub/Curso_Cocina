using DAC;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    public class Bl_gestion_cusos
    {
        gestion_curso dac_cusos = new gestion_curso();

        public DataSet search_curso(string name_curso, string curso_id)
        {
            var _DataSet = dac_cusos.search_cursos(name_curso, curso_id);
            if (_DataSet != null)
            {
                return _DataSet;
            }
            return null;
        }
        public DataSet search_receta(string name_receta, string id_receta)
        {
            var _DataSet = dac_cusos.search_receta(name_receta, id_receta);
            if (_DataSet != null)
            {
                return _DataSet;
            }
            return null;
        }
        public void insert_tema_receta(int id_receta, int id_tema)
        {
            dac_cusos.insert_tema_receta(id_receta, id_tema);

        }
        public void delete_tema_receta(int id_receta)
        {
            dac_cusos.delete_tema_receta(id_receta);

        }
        public void insert_cuso_tema(string name_tema, int id_curso)
        {
            dac_cusos.insert_curso_tema(name_tema, id_curso);

        }
        public void delete_curso_tema(int id_tema, int id_curso)
        {
            dac_cusos.delete_curso_tema(id_tema, id_curso);

        }
        public DataTable cursos()
        {
            var data = dac_cusos.Cursos();
            return data;

        }
        public void insert_curso(string data)
        {
            dac_cusos.insert_curso(data);
        }
        public void delete_curso(int data)
        {
            dac_cusos.delete_curso(data);
        }
        public int insert_receta(string name_receta, string preparacion)
        {
            var data = dac_cusos.insert_receta(name_receta, preparacion);
            return data;
        }
        public void insert_ingrediente_receta(string name_ingrediente, int id_receta)
        {

            dac_cusos.insert_ingrediente_receta(name_ingrediente, id_receta);
        }
    } 
}
