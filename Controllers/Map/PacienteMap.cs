using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;

namespace Controllers.Map
{
    
        class PacienteMap : EntityTypeConfiguration<Paciente>

        //Esta Herando do Framework Entity Apontando(Mapeando)
        //para a entidade dentista (Em entidades)
        {
            public PacienteMap()
            {
                //Esse contrutor vai pegar a Entidade e vai gerar a tabela com os dados q 
                //lá estão 
                this.ToTable("Paciente");

                //Abaixo estamos definido os campos da tabela
                this.HasKey(p => p.Id);
                this.Property(p => p.Id).HasColumnName("ID_PACIENTE");
                this.Property(p => p.Nome).HasColumnName("NOME_PACIENTE");
                this.Property(p => p.Email).HasColumnName("EMAIL_PACIENTE");
                this.Property(p => p.Email).HasColumnName("TELEFONE_PACIENTE");
                this.Property(p => p.Celular).HasColumnName("CELULAR_PACIENTE");
                this.Property(p => p.CEP).HasColumnName("CEP_PACIENTE");
                this.Property(p => p.Endereco).HasColumnName("ENDERECO_PACIENTE");
                this.Property(p => p.Nascimento).HasColumnName("NASCIMENTO_PACIENTE");
                this.Property(p => p.Sexo).HasColumnName("SEXO_PACIENTE");



        }
        }
    
}
