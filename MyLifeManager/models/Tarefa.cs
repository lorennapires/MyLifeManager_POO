using System;
using System.Collections.Generic;
using System.Drawing;

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
        public string CorDaCategoria { get; set; }
        public List<Categoria> Categorias { get; set; }
        public string CategoriasNomes { get; set; }

        public Tarefa()
        {
            Categorias = new List<Categoria>();
        }
    }
}