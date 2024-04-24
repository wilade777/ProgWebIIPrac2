﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mvcInventarioWeb.AccesoDatos.Data.Repository.IRepository
{
    public interface IContenedorTrabajo : IDisposable
    {
        IAlmacenRepository Almacen { get; }
        IUsuarioRepository Usuario { get; }
        void Save();
    }
}
