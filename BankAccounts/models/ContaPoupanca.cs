using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace BankAccounts.models
{
    [Table("conta_poupanca")]
    [Index("IdAccount", Name = "id_account")]
    public partial class ContaPoupanca
    {
        [Key]
        [Column("id_conta_poupanca")]
        public int IdContaPoupanca { get; set; }
        [Column("tipo")]
        [StringLength(25)]
        public string? Tipo { get; set; }
        [Column("tax")]
        [Precision(10, 2)]
        public decimal? Tax { get; set; }
        [Column("id_account")]
        public int? IdAccount { get; set; }

        [ForeignKey("IdAccount")]
        [InverseProperty("ContaPoupancas")]
        public virtual Account? IdAccountNavigation { get; set; }
    }
}
