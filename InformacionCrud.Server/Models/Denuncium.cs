﻿using System;
using System.Collections.Generic;

namespace InformacionCrud.Server.Models;

public partial class Denuncium
{
    public int Iddenuncia { get; set; }

    public string? Denuncia { get; set; }

    public string? Tipodenuncia { get; set; }

    public string? Denunciante { get; set; }

    public string? Denunciado { get; set; }

    public ulong? Estado { get; set; }

    public virtual ICollection<Arrestopolicial> Arrestopolicials { get; set; } = new List<Arrestopolicial>();
}
