﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimerDesafio
{
    internal class ProductoVendido
    {

        private int _id;
        private int _idProducto;
        private int _stock;
        private int _idVenta;


        //POSIBLES GETTERS Y SETTERS:

        //protected int Id { get; set; }
        //protected int IdProducto { get; set; }
        //protected int Stock { get; set; }
        //protected int IdVenta { get; set; }

        public ProductoVendido(int id, int idProducto, int stock, int idVenta)
        {
            this._id = id;
            this._idProducto = idProducto;
            this._stock = stock;
            this._idVenta = idVenta;
        }
    }
}
