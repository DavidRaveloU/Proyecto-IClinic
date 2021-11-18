﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos;
namespace Logica
{
    public class TratamientoService
    {
        ConnectionManager connectionManager;
        TratamientoRepository tratamientoRepository;
        public TratamientoService(string conexion)
        {
            connectionManager = new ConnectionManager(conexion);
            tratamientoRepository = new TratamientoRepository(connectionManager.conn);
        }
    }
}
