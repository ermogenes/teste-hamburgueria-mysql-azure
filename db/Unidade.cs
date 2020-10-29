using System;
using System.Collections.Generic;

namespace teste_hamburgueria_mysql_azure.db
{
    public partial class Unidade
    {
        public Unidade()
        {
            BurguerIngrediente = new HashSet<BurguerIngrediente>();
        }

        public string Id { get; set; }
        public string Descricao { get; set; }

        public virtual ICollection<BurguerIngrediente> BurguerIngrediente { get; set; }
    }
}
