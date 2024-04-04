using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sukuna.Common.Models
{
    public class ClientOrder : Entity
    {
        public DateOnly Date { get; set; } // Date de la commande
        public String State { get; set; } // État actuel de la command
        public int NumberArticle { get; set; } // Nombre d'articles dans la commande 
        public int TotalHT { get; set; } // Total hors taxes de la commande
        public int TotalTTC { get; set; } // Total toutes taxes comprises de la commande
        public int InvoiceNumber { get; set; } // Numéro de la facture
        public bool Send { get; set; } // Envoyer true or false
        public DateOnly SendOn { get; set; } // Date d'envoi de la commande
        public User CancelledBy { get; set; } // L'employé qui annule la commande 
        public Client Client { get; set; } // L'id du Client lié à la commande
        public ClientOrder() { }
    }
}
