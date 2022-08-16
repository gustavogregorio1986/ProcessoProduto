using System;

namespace ProcessoProduto.Models
{
    public class ProdutoView
    {
        public int Id { get; set; }

        public string UserName { get; set; }

        public string FullName { get; set; }

        public DateTime Date { get; set; }

        public string Active { get; set; }

        public string Country { get; set; }

        public string Role { get; set; }
    }
}
