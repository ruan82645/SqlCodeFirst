using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Metadata.Edm;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controladores.Mapeamento
{
    internal class DentistaMap : EntityTypeConfiguration<Dentista>
    {
        public DentistaMap() 
        {
            this.ToTable("Dentista");
            this.HasKey(t => t.Id);
            this.Property(t => t.Id).HasColumnName("IdDentista");
            this.Property(t => t.Nome).HasColumnName("NomeDentista");
            this.Property(t => t.Email).HasColumnName("EmailDentista");
            this.Property(t => t.Nome).HasColumnName("NomeDentista");


        }
    }
}
