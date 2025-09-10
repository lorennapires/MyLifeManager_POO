using System;
using System.Collections.Generic;

namespace MyLifeManager.Models
{
    public class Tarefa
    {
        public int Id { get; set; }
        public string Titulo { get; set; }
        public string Descricao { get; set; }
        public DateTime? Data_inicio { get; set; } 
        public DateTime? Data_fim { get; set; }
        public bool Concluida { get; set; }

        public List<Categoria> Categorias { get; set; }

        public Tarefa()
        {
            Categorias = new List<Categoria>();
        }
    }
}