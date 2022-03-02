using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using Controllers.Map;
using Entidades;

namespace Controllers.Context
{
    /*Essa Classe Vai Enserir as informações para que as tabelas do banco serjam 
     *Geradas de forma automatizada. 
     *Foi inserido o Sistem.Data.Entity nas referencias e o SistemasContext esta herdando 
     *
     *Também Foi implementado o console do gerenciador de pacotes Ref.:View/OtherWindows/MenagementNuget
     *     No log foi realizado o comando: Install-Package EntityFramework  (Para instalar o Framework)
     *
     */
    public class SistemaContext : DbContext //A Responsavel por criar e Jogar no banco
                                            //(POR ONDE COMEÇAMOS A MODELAGEM). 
    {
        //O Contrutor Abaixo tem como referencia base que aponta para o servidor sql
        public SistemaContext() : base("Server=LAPTOP-DNO3086A\\SQLEXPRESS; Database=Odonto; Integrated Security=True; ")
        {
             
        }

            //DbSet Serve para definir algumas propriedades relacionadas as tabelas
            //(Feito Apenas depois que as entidades estão prontas)
        public DbSet<Consulta>Consultas{ get; set; } //Gera a tabela consultas atravez desse metodo no banco (Feito Apenas depois que as entidades estão prontas)
        public DbSet<Paciente> Pacientes{ get; set; } //Gera a tabela Paciente atravez desse metodo no banco (Feito Apenas depois que as entidades estão prontas)
        public DbSet<Dentista> Dentistas{ get; set; } //Gera a tabela consultas atravez desse metodo no banco (Feito Apenas depois que as entidades estão prontas)
        //Comando: PM> Enable-Migrations no management log para executar

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            //Seta a classe e faz a inicialização do banco por isso se aponta para o nome da mesma
            Database.SetInitializer<SistemaContext>(null);

            //Mapeamento das janelas (o que precisa ser alimentado nas tebelas
            modelBuilder.Configurations.Add(new DentistaMap());
            modelBuilder.Configurations.Add(new PacienteMap());
            modelBuilder.Configurations.Add(new ConsultaMap());

            //O DbModelBuilder Vai Acessar os dados para regar as tabelas
            base.OnModelCreating(modelBuilder); 
             
        }
    }
}
