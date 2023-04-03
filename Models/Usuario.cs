using System;
using System.Collections.Generic;

namespace Primera_aplicacion_1.Models;

public partial class Usuario
{
    public int Id { get; set; }

    public string? Nombre { get; set; }

    public string? Apellido { get; set; }

    public string? Correo { get; set; }

    public string? Rut { get; set; }

    public string? Password { get; set; }
}
