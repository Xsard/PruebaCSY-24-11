using Libreria;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace UnitTestLibreria
{
    [TestClass]
    public class UnitTestAuxProducto
    {
        #region Agregar Categoría
        [TestMethod]
        public void TestMethodAgregarProductoObjeto()
        {
            //Arrange
            int ResultadoEsperado = 1;
            int ResultadoObtenido;

            Categoria categoria = new Categoria
            {
                Idcategoria = 1,
                Nombre = "Comida de Perros",
                Descripcion = "Comida para perros"
            };

            Producto producto = new Producto
            {
                IdProducto = 1,
                Nombre = "Master Can",
                Cat = categoria,
                Precio = 25000,
                Stock = 200
            };

            AuxProducto auxProducto = new AuxProducto();

            //ACT
            ResultadoObtenido = auxProducto.AgregarProducto(producto);

            //Assert
            Assert.AreEqual(ResultadoObtenido, ResultadoEsperado);
        }

        [TestMethod]
        public void TestMethodAgregarProductoPropiedad()
        {
            //Arrange
            int ResultadoEsperado = 1;
            int ResultadoObtenido;

            Categoria categoria = new Categoria
            {
                Idcategoria = 1,
                Nombre = "Comida de Perros",
                Descripcion = "Comida para perros"
            };

            int idProducto = 1;
            string Nombre = "Master Can";
            int Precio = 25000;
            int Stock = 200;

            AuxProducto auxProducto = new AuxProducto();

            //ACT
            ResultadoObtenido = auxProducto.AgregarProducto(idProducto, Nombre, categoria, Precio, Stock);

            //Assert
            Assert.AreEqual(ResultadoObtenido, ResultadoEsperado);
        }

        [TestMethod]
        public void TestMethodAgregarProductoObjetoExistente()
        {
            //Arrange
            int ResultadoEsperado = 0;
            int ResultadoObtenido;

            Categoria categoria = new Categoria
            {
                Idcategoria = 1,
                Nombre = "Comida de Perros",
                Descripcion = "Comida para perros"
            };

            Producto producto = new Producto
            {
                IdProducto = 1,
                Nombre = "Master Can",
                Cat = categoria,
                Precio = 25000,
                Stock = 200
            };

            AuxProducto auxProducto = new AuxProducto();

            //ACT
            auxProducto.AgregarProducto(producto);
            ResultadoObtenido = auxProducto.AgregarProducto(producto);

            //Assert
            Assert.AreEqual(ResultadoObtenido, ResultadoEsperado);
        }

        [TestMethod]
        public void TestMethodAgregarProductoPropiedadExistente()
        {
            //Arrange
            int ResultadoEsperado = 0;
            int ResultadoObtenido;

            Categoria categoria = new Categoria
            {
                Idcategoria = 1,
                Nombre = "Comida de Perros",
                Descripcion = "Comida para perros"
            };

            int idProducto = 1;
            string Nombre = "Master Can";
            int Precio = 25000;
            int Stock = 200;

            AuxProducto auxProducto = new AuxProducto();

            //ACT
            auxProducto.AgregarProducto(idProducto, Nombre, categoria, Precio, Stock);
            ResultadoObtenido = auxProducto.AgregarProducto(idProducto, Nombre, categoria, Precio, Stock);

            //Assert
            Assert.AreEqual(ResultadoObtenido, ResultadoEsperado);
        }

        [TestMethod]
        public void TestMethodAgregarProductoObjetoSinNombre()
        {
            //Arrange
            int ResultadoEsperado = 1;
            int ResultadoObtenido;

            Categoria categoria = new Categoria
            {
                Idcategoria = 1,
                Nombre = "Comida de Perros",
                Descripcion = "Comida para perros"
            };

            Producto producto = new Producto
            {
                IdProducto = 1,
                Cat = categoria,
                Precio = 25000,
                Stock = 200
            };

            AuxProducto auxProducto = new AuxProducto();

            //ACT
            ResultadoObtenido = auxProducto.AgregarProducto(producto);

            //Assert
            Assert.AreEqual(ResultadoObtenido, ResultadoEsperado);
        }

        [TestMethod]
        public void TestMethodAgregarProductoObjetoSinCategoria()
        {
            //Arrange
            int ResultadoEsperado = 1;
            int ResultadoObtenido;

            Producto producto = new Producto
            {
                IdProducto = 1,
                Nombre = "Master Can",
                Precio = 25000,
                Stock = 200
            };

            AuxProducto auxProducto = new AuxProducto();

            //ACT
            ResultadoObtenido = auxProducto.AgregarProducto(producto);

            //Assert
            Assert.AreEqual(ResultadoObtenido, ResultadoEsperado);
        }
        
        [TestMethod]
        public void TestMethodAgregarProductoObjetoSinPrecio()
        {
            //Arrange
            int ResultadoEsperado = 1;
            int ResultadoObtenido;

            Categoria categoria = new Categoria
            {
                Idcategoria = 1,
                Nombre = "Comida de Perros",
                Descripcion = "Comida para perros"
            };

            Producto producto = new Producto
            {
                IdProducto = 1,
                Nombre = "Master Can",
                Cat = categoria,
                Stock = 200
            };

            AuxProducto auxProducto = new AuxProducto();

            //ACT
            ResultadoObtenido = auxProducto.AgregarProducto(producto);

            //Assert
            Assert.AreEqual(ResultadoObtenido, ResultadoEsperado);
        }

        [TestMethod]
        public void TestMethodAgregarProductoObjetoSinStock()
        {
            //Arrange
            int ResultadoEsperado = 1;
            int ResultadoObtenido;

            Categoria categoria = new Categoria
            {
                Idcategoria = 1,
                Nombre = "Comida de Perros",
                Descripcion = "Comida para perros"
            };

            Producto producto = new Producto
            {
                IdProducto = 1,
                Nombre = "Master Can",
                Cat = categoria,
                Precio = 25000
            };

            AuxProducto auxProducto = new AuxProducto();

            //ACT
            ResultadoObtenido = auxProducto.AgregarProducto(producto);

            //Assert
            Assert.AreEqual(ResultadoObtenido, ResultadoEsperado);
        }

        [TestMethod]
        public void TestMethodAgregarProductoObjetoSinId()
        {
            //Arrange
            int ResultadoEsperado = 1;
            int ResultadoObtenido;

            Categoria categoria = new Categoria
            {
                Idcategoria = 1,
                Nombre = "Comida de Perros",
                Descripcion = "Comida para perros"
            };

            Producto producto = new Producto
            {
                Nombre = "Master Can",
                Cat = categoria,
                Precio = 25000,
                Stock = 200
            };

            AuxProducto auxProducto = new AuxProducto();

            //ACT
            ResultadoObtenido = auxProducto.AgregarProducto(producto);

            //Assert
            Assert.AreEqual(ResultadoObtenido, ResultadoEsperado);
        }
        #endregion

        #region Actualizar Stock
        
        [TestMethod]
        public void TestMethodActualizarStock()
        {
            //Arrange 
            int ResultadoEsperado = 210;
            int ResultadoObtenido;

            Categoria categoria = new Categoria
            {
                Idcategoria = 1,
                Nombre = "Comida de Perros",
                Descripcion = "Comida para perros"
            };

            Producto producto = new Producto
            {
                IdProducto = 1,
                Nombre = "Master Can",
                Cat = categoria,
                Precio = 25000,
                Stock = 200
            };

            AuxProducto auxProducto = new AuxProducto();
            
            auxProducto.AgregarProducto(producto);

            //ACT
            ResultadoObtenido = auxProducto.ActualizarStock(1, 10);

            //Assert
            Assert.AreEqual(ResultadoEsperado, ResultadoObtenido);
        }

        [TestMethod]
        public void TestMethodActualizarStockNegativo()
        {
            //Arrange 
            int ResultadoEsperado = -1;
            int ResultadoObtenido;

            Categoria categoria = new Categoria
            {
                Idcategoria = 1,
                Nombre = "Comida de Perros",
                Descripcion = "Comida para perros"
            };

            Producto producto = new Producto
            {
                IdProducto = 1,
                Nombre = "Master Can",
                Cat = categoria,
                Precio = 25000,
                Stock = 200
            };

            AuxProducto auxProducto = new AuxProducto();

            auxProducto.AgregarProducto(producto);

            //ACT
            ResultadoObtenido = auxProducto.ActualizarStock(1, -201);

            //Assert
            Assert.AreEqual(ResultadoEsperado, ResultadoObtenido);
        }

        [TestMethod]
        public void TestMethodActualizarStockIdInexistente()
        {
            //Arrange 
            int ResultadoEsperado = -1;
            int ResultadoObtenido;

            Categoria categoria = new Categoria
            {
                Idcategoria = 1,
                Nombre = "Comida de Perros",
                Descripcion = "Comida para perros"
            };

            Producto producto = new Producto
            {
                IdProducto = 1,
                Nombre = "Master Can",
                Cat = categoria,
                Precio = 25000,
                Stock = 200
            };

            AuxProducto auxProducto = new AuxProducto();

            auxProducto.AgregarProducto(producto);

            //ACT
            ResultadoObtenido = auxProducto.ActualizarStock(10, 10);

            //Assert
            Assert.AreEqual(ResultadoEsperado, ResultadoObtenido);
        }

        #endregion

        #region Modificar Producto
        [TestMethod]
        public void TestMethodModificarProducto()
        {
            //Arrange 
            int ResultadoEsperado = 1;
            int ResultadoObtenido;

            Categoria categoria = new Categoria
            {
                Idcategoria = 1,
                Nombre = "Comida de Perros",
                Descripcion = "Comida para perros"
            };

            Producto producto = new Producto
            {
                IdProducto = 1,
                Nombre = "Master Can",
                Cat = categoria,
                Precio = 25000,
                Stock = 200
            };

            AuxProducto auxProducto = new AuxProducto();

            auxProducto.AgregarProducto(producto);

            int IdProducto = 1;
            string Nombre = "Dog Show";
            int Precio = 30000;
            int Stock = 20;

            //ACT
            ResultadoObtenido = auxProducto.Modificar(IdProducto, Nombre, categoria, Precio, Stock);

            //Assert
            Assert.AreEqual(ResultadoEsperado, ResultadoObtenido);

        }

        [TestMethod]
        public void TestMethodModificarProductoInexistente()
        {
            //Arrange 
            int ResultadoEsperado = 0;
            int ResultadoObtenido;

            Categoria categoria = new Categoria
            {
                Idcategoria = 1,
                Nombre = "Comida de Perros",
                Descripcion = "Comida para perros"
            };

            AuxProducto auxProducto = new AuxProducto();

            int IdProducto = 1;
            string Nombre = "Dog Show";
            int Precio = 30000;
            int Stock = 20;

            //ACT
            ResultadoObtenido = auxProducto.Modificar(IdProducto, Nombre, categoria, Precio, Stock);

            //Assert
            Assert.AreEqual(ResultadoEsperado, ResultadoObtenido);

        }

        [TestMethod]
        public void TestMethodModificarProductoSinNombre()
        {
            //Arrange 
            int ResultadoEsperado = 1;
            int ResultadoObtenido;

            Categoria categoria = new Categoria
            {
                Idcategoria = 1,
                Nombre = "Comida de Perros",
                Descripcion = "Comida para perros"
            };

            Producto producto = new Producto
            {
                IdProducto = 1,
                Nombre = "Master Can",
                Cat = categoria,
                Precio = 25000,
                Stock = 200
            };

            AuxProducto auxProducto = new AuxProducto();

            auxProducto.AgregarProducto(producto);

            int IdProducto = 1;
            string Nombre = "";
            int Precio = 30000;
            int Stock = 20;

            //ACT
            ResultadoObtenido = auxProducto.Modificar(IdProducto, Nombre, categoria, Precio, Stock);

            //Assert
            Assert.AreEqual(ResultadoEsperado, ResultadoObtenido);

        }

        [TestMethod]
        public void TestMethodModificarProductoPrecioNegativo()
        {
            //Arrange 
            int ResultadoEsperado = 1;
            int ResultadoObtenido;

            Categoria categoria = new Categoria
            {
                Idcategoria = 1,
                Nombre = "Comida de Perros",
                Descripcion = "Comida para perros"
            };

            Producto producto = new Producto
            {
                IdProducto = 1,
                Nombre = "Master Can",
                Cat = categoria,
                Precio = 25000,
                Stock = 200
            };

            AuxProducto auxProducto = new AuxProducto();

            auxProducto.AgregarProducto(producto);

            int IdProducto = 1;
            string Nombre = "Dog Show";
            int Precio = -30000;
            int Stock = 20;

            //ACT
            ResultadoObtenido = auxProducto.Modificar(IdProducto, Nombre, categoria, Precio, Stock);

            //Assert
            Assert.AreEqual(ResultadoEsperado, ResultadoObtenido);

        }

        [TestMethod]
        public void TestMethodModificarProductoStockNegativo()
        {
            //Arrange 
            int ResultadoEsperado = 1;
            int ResultadoObtenido;

            Categoria categoria = new Categoria
            {
                Idcategoria = 1,
                Nombre = "Comida de Perros",
                Descripcion = "Comida para perros"
            };

            Producto producto = new Producto
            {
                IdProducto = 1,
                Nombre = "Master Can",
                Cat = categoria,
                Precio = 25000,
                Stock = 200
            };

            AuxProducto auxProducto = new AuxProducto();

            auxProducto.AgregarProducto(producto);

            int IdProducto = 1;
            string Nombre = "Dog Show";
            int Precio = 30000;
            int Stock = -20;

            //ACT
            ResultadoObtenido = auxProducto.Modificar(IdProducto, Nombre, categoria, Precio, Stock);

            //Assert
            Assert.AreEqual(ResultadoEsperado, ResultadoObtenido);

        }

        #endregion

        #region Generar Instancias

        [TestMethod]
        public void GenerarInstanciaProductoConstructorSinParametros()
        {
            //Arrange
            Producto producto;

            //ACT
            producto = new Producto();

            //Assert
            Assert.IsNotNull(producto);
        }

        [TestMethod]
        public void GenerarInstanciaProductoConstructorConParametros()
        {
            //Arrange
            Producto producto;
            int idProducto = 10;
            string nombre = "Whiskas";
            Categoria cat = new Categoria();
            int precio = 10000;
            int stock = 200;
            bool estado = false;

            //ACT
            producto = new Producto(idProducto, nombre, cat, precio, stock, estado);

            //Assert
            Assert.IsNotNull(producto);
        }

        #endregion

        #region Obtener

        [TestMethod]
        public void ObtenerIdProducto()
        {
            //Arrange 
            int ResultadoEsperado = 10;
            int ResultadoObtenido;
            Producto producto;
            int idProducto = 10;
            string nombre = "Whiskas";
            Categoria cat = new Categoria();
            int precio = 10000;
            int stock = 200;
            bool estado = false;

            //ACT
            producto = new Producto(idProducto, nombre, cat, precio, stock, estado);

            ResultadoObtenido = producto.IdProducto;

            //Assert
            Assert.AreEqual(ResultadoObtenido, ResultadoEsperado);
        }

        [TestMethod]
        public void ObtenerNombreProducto()
        {
            //Arrange 
            string ResultadoEsperado = "Whiskas";
            string ResultadoObtenido;
            Producto producto;
            int idProducto = 10;
            string nombre = "Whiskas";
            Categoria cat = new Categoria();
            int precio = 10000;
            int stock = 200;
            bool estado = false;

            //ACT
            producto = new Producto(idProducto, nombre, cat, precio, stock, estado);

            ResultadoObtenido = producto.Nombre;

            //Assert
            Assert.AreEqual(ResultadoObtenido, ResultadoEsperado);
        }

        [TestMethod]
        public void ObtenerCategoriaProducto()
        {
            //Arrange 
            Categoria cat = new Categoria();
            Categoria ResultadoEsperado = cat;
            Categoria ResultadoObtenido;
            Producto producto;
            int idProducto = 10;
            string nombre = "Whiskas";
            int precio = 10000;
            int stock = 200;
            bool estado = false;

            //ACT
            producto = new Producto(idProducto, nombre, cat, precio, stock, estado);

            ResultadoObtenido = producto.Cat;

            //Assert
            Assert.AreEqual(ResultadoObtenido, ResultadoEsperado);
        }

        [TestMethod]
        public void ObtenerPrecioProducto()
        {
            //Arrange 
            int ResultadoEsperado = 10000;
            int ResultadoObtenido;
            Producto producto;
            int idProducto = 10;
            string nombre = "Whiskas";
            Categoria cat = new Categoria();
            int precio = 10000;
            int stock = 200;
            bool estado = false;

            //ACT
            producto = new Producto(idProducto, nombre, cat, precio, stock, estado);

            ResultadoObtenido = producto.Precio;

            //Assert
            Assert.AreEqual(ResultadoObtenido, ResultadoEsperado);
        }

        [TestMethod]
        public void ObtenerStockProducto()
        {
            //Arrange 
            int ResultadoEsperado = 200;
            int ResultadoObtenido;
            Producto producto;
            int idProducto = 10;
            string nombre = "Whiskas";
            Categoria cat = new Categoria();
            int precio = 10000;
            int stock = 200;
            bool estado = false;

            //ACT
            producto = new Producto(idProducto, nombre, cat, precio, stock, estado);

            ResultadoObtenido = producto.Stock;

            //Assert
            Assert.AreEqual(ResultadoObtenido, ResultadoEsperado);
        }

        [TestMethod]
        public void ObtenerEstadoProducto()
        {
            //Arrange 
            bool ResultadoEsperado = false;
            bool ResultadoObtenido;
            Producto producto;
            int idProducto = 10;
            string nombre = "Whiskas";
            Categoria cat = new Categoria();
            int precio = 10000;
            int stock = 200;
            bool estado = false;

            //ACT
            producto = new Producto(idProducto, nombre, cat, precio, stock, estado);

            ResultadoObtenido = producto.Estado;

            //Assert
            Assert.AreEqual(ResultadoObtenido, ResultadoEsperado);
        }
        #endregion

        #region Dar de baja

        [TestMethod]
        public void TestMethodDardeBaja()
        {
            //Arrange
            int ResultadoEsperado = 1;
            int ResultadoObtenido;

            Categoria categoria = new Categoria
            {
                Idcategoria = 1,
                Nombre = "Comida de Perros",
                Descripcion = "Comida para perros"
            };

            Producto producto = new Producto
            {
                IdProducto = 1,
                Nombre = "Master Can",
                Cat = categoria,
                Precio = 25000,
                Stock = 200
            };

            AuxProducto auxProducto = new AuxProducto();
            auxProducto.AgregarProducto(producto);


            //ACT
            ResultadoObtenido = auxProducto.DardeBaja(1);

            //Assert
            Assert.AreEqual(ResultadoObtenido, ResultadoEsperado);
        }

        [TestMethod]
        public void TestMethodDardeBajaIdInexistente()
        {
            //Arrange
            int ResultadoEsperado = 0;
            int ResultadoObtenido;

            Categoria categoria = new Categoria
            {
                Idcategoria = 1,
                Nombre = "Comida de Perros",
                Descripcion = "Comida para perros"
            };

            Producto producto = new Producto
            {
                IdProducto = 1,
                Nombre = "Master Can",
                Cat = categoria,
                Precio = 25000,
                Stock = 200
            };

            AuxProducto auxProducto = new AuxProducto();
            auxProducto.AgregarProducto(producto);


            //ACT
            ResultadoObtenido = auxProducto.DardeBaja(12);

            //Assert
            Assert.AreEqual(ResultadoObtenido, ResultadoEsperado);
        }

        #endregion
    }
}
