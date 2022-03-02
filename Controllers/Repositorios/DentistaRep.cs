﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Controllers.Context;
using Entidades;

namespace Controllers.Repositorios
{
    //Esse Repositorio/Classe que vai conter/implementar os metodos do grud
    public class DentistaRep
    {
        public void Cadastrar(Dentista obj) //Objeto de referencia a tabela
        {
            using (var ctx = new SistemaContext()) //Instancia do SistemaContext
                                                   //(Referencia a conexão com o banco)
            {
                ctx.Dentistas.Add(obj);
                ctx.SaveChanges();


            }

        }
        public Dentista Buscar(int id)
                //Verificar dentro da tabela Dentista Pelo Id 
                //E retorna o mesmo
        {
            Dentista obj = new Dentista(); 
            using (var ctx = new SistemaContext())
            {
                obj = ctx.Dentistas.Find(id); 
            }
            return obj; 

        }
        public List<Dentista> Listar() //Para Receber uma consulta tipo lit o metodo deve conter esse list
        //traz a tabela de dentistas
        {
            
            using (var ctx = new SistemaContext())
            {
                var Dentistas = (from obj in ctx.Dentistas select obj).OrderBy(x => x.Nome).ToList();
                return Dentistas;
            }
            
        }

        public void Deletar(int id)
            //Metodo para deletar procura por Id
        {
            using (var ctx = new SistemaContext())
            {
                Dentista obj = ctx.Dentistas.Find(id);
                ctx.Dentistas.Remove(obj);
                ctx.SaveChanges();

            }
        }

        public void Editar(Dentista objNovo)
        {
           using (var ctx = new SistemaContext())
            {
                Dentista objAntigo = ctx.Dentistas.Find(objNovo.Id);
                objAntigo.Nome = objNovo.Nome;
                objAntigo.Telefone = objNovo.Telefone;
                objAntigo.Celular = objNovo.Celular;
                objAntigo.CRO = objNovo.CRO;
                objAntigo.Email = objNovo.Email;

                ctx.SaveChanges();
             

            }
        }

    }
}
