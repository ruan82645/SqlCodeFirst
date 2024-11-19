using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Remoting.Contexts;
using System.Data.Entity;
using Controladores.Mapeamento;

namespace Controladores.Context
{
    internal class Sistema_Contexto : DbContext
    {
        public Sistema_Contexto() : base("Server=.;DataBase=SistemaOdonto;User ID=ruan;Password=82645")
        {

        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            Database.SetInitializer<Sistema_Contexto>(null);
            modelBuilder.Configurations.Add(new DentistaMap);
            modelBuilder.Configurations.Add(new PacienteMap);
            modelBuilder.Configurations.Add(new ConsultaMap);
            base.OnModelCreating(modelBuilder);
        }
    }
}
