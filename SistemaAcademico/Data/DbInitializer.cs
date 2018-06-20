namespace SistemaAcademico.Data
{
    using SistemaAcademico.Models;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    public class DbInitializer
    {
        public static void Initialize(SistemaAcademicoContext context)
        {
            context.Database.EnsureCreated();

            //Buscar si existen registros en la tabla categoria:
            if (context.Categoria.Any())
            {
                return;
            }

            var categoria = new Categoria[]
            {
                new Categoria{
                    Nombre ="Programación",
                    Descripcion ="Curso de Programación",
                    Estado =true },

                new Categoria{
                    Nombre ="Diseño gráfico",
                    Descripcion ="Curso de de Diseño Gráfico",
                    Estado =true }
            };

            foreach (Categoria cate in categoria)
            {
                context.Categoria.Add(cate);
            }

            context.SaveChanges();

        }

       
    }
}
