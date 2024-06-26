﻿using Sukuna.Common.Models;
using System.ComponentModel.DataAnnotations;

namespace Sukuna.Common.Resources.Client;

public class ClientResource
{
    [Key]
    public int ID { get; set; }
    public string Nom { get; set; }
    public string Prénom { get; set; }
    public string Adresse { get; set; }
    public string Email { get; set; }
    public ICollection<ClientOrder> Orders { get; set; } // Relation un client a plusieurs commandes

    public ClientResource()
    {
        Orders = new List<ClientOrder>();
    }
}
