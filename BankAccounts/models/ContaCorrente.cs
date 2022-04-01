using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace BankAccounts.models
{
    [Table("conta_corrente")]
    [Index("IdAccount", Name = "id_account")]
    public partial class ContaCorrente
    {
        [Key]
        [Column("id_conta_Corrente")]
        public int IdContaCorrente { get; set; }
        [Column("tipo")]
        [StringLength(25)]
        public string? Tipo { get; set; }
        [Column("id_account")]
        public int? IdAccount { get; set; }

        [ForeignKey("IdAccount")]
        [InverseProperty("ContaCorrentes")]
        public virtual Account? IdAccountNavigation { get; set; }
    }
}
