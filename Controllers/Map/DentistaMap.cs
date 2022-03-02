using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;

namespace Controllers.Map
{
    class DentistaMap : EntityTypeConfiguration<Dentista> 

                        //Esta Herando do Framework Entity Apontando(Mapeando)
                        //para a entidade dentista (Em entidades)
    {
        public DentistaMap()
        {
            //Esse contrutor vai pegar a Entidade e vai gerar a tabela com os dados q 
            //lá estão 
            this.ToTable("Dentista");
            
            //Abaixo estamos definido os campos da tabela
            this.HasKey(d => d.Id);
            this.Property(d => d.Id).HasColumnName("ID_DENTISTA");
            this.Property(d => d.Nome).HasColumnName("NOME_DENTISTA");
            this.Property(d => d.Email).HasColumnName("EMAIL_DENTISTA");
            this.Property(d => d.Email).HasColumnName("TELEFONE_DENTISTA");
            this.Property(d => d.Celular).HasColumnName("CELULAR_DENTISTA");
            this.Property(d => d.CRO).HasColumnName("CRO");


        }
    }
}
