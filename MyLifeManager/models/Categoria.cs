using System.Collections.Generic;

namespace MyLifeManager.Models
{
    public class Categoria
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Cor { get; set; }

        public List<Tarefa> Tarefas { get; set; }

        public Categoria()
        {
            Tarefas = new List<Tarefa>();
        }
    }
}