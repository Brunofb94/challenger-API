using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace BankAccounts.models
{
    [Table("account")]
    public partial class Account
    {
        public Account()
        {
            ContaCorrentes = new HashSet<ContaCorrente>();
            ContaPoupancas = new HashSet<ContaPoupanca>();
        }

        [Key]
        [Column("id")]
        public int Id { get; set; }
        [Column("agency")]
        public int? Agency { get; set; }
        [Column("start_account")]
        public DateTime StartAccount { get; set; }
        
        [Column("number_account")]
        public int NumberAccount { get; set; }
        
        [Column("balance", TypeName = "double(10,2)")]
        public double Balance { get; set; }

        [InverseProperty("IdAccountNavigation")]
        public virtual ICollection<ContaCorrente> ContaCorrentes { get; set; }
        [InverseProperty("IdAccountNavigation")]
        public virtual ICollection<ContaPoupanca> ContaPoupancas { get; set; }
    }
}
