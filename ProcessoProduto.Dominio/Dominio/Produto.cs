using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace ProcessoProduto.Dominio.Dominio
{
    [Table("tb_Produto")]
    public class Produto
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        public string UserName { get; set; }

        public string FullName { get; set; }

        public DateTime Date { get; set; }

        public string Active { get; set; }

        public string Country { get; set; }

        public string Role { get; set; }
    }
}
