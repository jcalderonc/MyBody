using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace MyBody
{
    public class Suscripciones : BaseDatos
    {
        public DateTime FInicio { get; set; }
        public DateTime FFin { get; set; }
        public decimal Costo { get; set; }
        public decimal Dias { get; set; }
        public int ID { get; set; }

        public void PaserBuffer(Suscripciones _ObjSuscripcion)
        {
            _ObjSuscripcion.ID = int.Parse(Buffer.Rows[0]["ID"].ToString());
            _ObjSuscripcion.Costo = int.Parse(Buffer.Rows[0]["costo"].ToString());
            _ObjSuscripcion.Dias = int.Parse(Buffer.Rows[0]["dias"].ToString());
        }

  
       



        public bool CambiarCosto()
        {
            if (Conectar())
            {
                Instruccion = Suscripciones.Query.CambiarCosto(this.ID, this.Costo);
                if (Ejecutar())
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }
        


        public bool Abrir(int _ID)
        {
            if (Conectar())
            {
                Instruccion = Suscripciones.Query.GetPrecioByID(_ID);
                if (Consultar())
                {
                    PaserBuffer(this);
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }

        public bool Lista()
        {
            if (Conectar())
            {
                Instruccion = Suscripciones.Query.GetSuscripciones();
                if (Consultar())
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }


    

       

        public bool Pagos()
        {
            if (Conectar())
            {
                Instruccion = Suscripciones.Query.GetPagos(FInicio, FFin, ID);
                if (Consultar())
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }



        public static class Query
        {
            public static string CambiarCosto(int _ID, decimal _Costo)
            {
                return @"UPDATE suscripciones SET costo='"+_Costo+"' WHERE ID='"+_ID+"'";
            }
            public static string GetSuscripciones()
            {
                return @"SELECT * FROM suscripciones";
            }
            public static string GetPagos(DateTime _Fini, DateTime _FFin, int _ID)
            {
                string ByID=" AND pagos.ID_suscripciones='"+_ID+"'";
                return @"SELECT 
                    pagos.id, 
                    socios.nombre AS socio, 
                    suscripciones.nombre AS suscripcion,
                    pagos.total,
                    pagos.cobrado,
                    pagos.pendiente,
                    pagos.fecha,
                    socios.ultimopago

                    FROM pagos 
                    INNER JOIN socios ON
                    (socios.ID=pagos.ID_socios)
                    INNER JOIN suscripciones ON
                    (suscripciones.ID=pagos.ID_suscripciones)

                    WHERE pagos.fecha
                    BETWEEN '" + _Fini.ToString("yyyy-MM-dd") + " 00:00:00' AND '" + _FFin.ToString("yyyy-MM-dd")+ @" 23:59:59'"+
                    (_ID == 0 ? string.Empty : ByID);
            }
            public static string GetPrecioByID(int _ID)
            {
                return @" SELECT * FROM suscripciones WHERE ID='"+_ID+"'";
            }
        }

    }
    public class Ventas : BaseDatos
    {
        public int ID;
        public int ID_usuario;
        public int ID_socio; 
        public int ID_producto;
        public int cantidad;
        public float punitario;
        public float total;
        public float cobrado;
        public bool pendiente;
        public DateTime fecha;

        public bool Guardar()
        {
            if (Conectar())
            {
                Instruccion = Ventas.Query.InsertReplace(this);
                if (Ejecutar())
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }


        public bool Descontar()
        {
            if (Conectar())
            {
                Instruccion = Ventas.Query.DescontarInventario(this.cantidad,this.ID_producto);
                if (Ejecutar())
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }

        }
        public class Cortes: BaseDatos
        {

            public static class Query
            {
                public static string ProductosXCorte(int ID_Corte)
                {
                    return "SELECT ID_producto FROM corte_producto WHERE ID_corte='"+ ID_Corte + "'";
                }

                public static string Cortes()
                {
                    return "SELECT ID, nombre FROM cortes ORDER BY nombre";
                }

                public static string Agregar(string _Nombre)
                {
                    return "INSERT INTO cortes (nombre) VALUES ('"+_Nombre+"')";
                }

                public static string Desasociar(int _IDCorte, int _IDProducto)
                {
                    return "DELETE FROM corte_producto WHERE ID_corte='"+_IDCorte+"' AND ID_producto='"+_IDProducto+"'";
                }
                
                public static string Asociar(int _IDCorte, int _IDProducto)
                {
                    return "INSERT INTO corte_producto (ID_corte, ID_producto) VALUES ('"+_IDCorte+"','"+_IDProducto+"')";
                }
                public static string Eliminar(int _ID)
                {
                    return "DELETE FROM cortes WHERE ID='"+_ID+ "'; DELETE FROM corte_producto WHERE ID_corte='"+_ID+"';";
                }
            }

            public bool Lista()
            {
                if (Conectar())
                {
                    Instruccion = Query.Cortes();
                    if (Consultar())
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
                else
                {
                    return false;
                }
            }
            public bool Desasociar(int ID_Corte, int ID_Producto)
            {
                if (Conectar())
                {
                    Instruccion = Query.Desasociar(ID_Corte, ID_Producto);
                    if (Ejecutar())
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
                else
                {
                    return false;
                }
            }
            
            public bool Asociar(int ID_Corte, int ID_Producto)
            {
                if (Conectar())
                {
                    Instruccion = Query.Asociar(ID_Corte, ID_Producto);
                    if (Ejecutar())
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
                else
                {
                    return false;
                }
            }
            public bool Agregar(string _Nombre)
            {
                if(Conectar())
                {
                    Instruccion = Query.Agregar(_Nombre);
                    if (Ejecutar())
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
                else
                {
                    return false;
                }
            }

            public bool ProductosXCorte(int _IDCorte)
            {
                if (Conectar())
                {
                    Instruccion = Query.ProductosXCorte(_IDCorte);
                    if (Consultar())
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
                else
                {
                    return false;
                }
            }

            public bool Eliminar(int _ID)
            {
                if (Conectar())
                {
                    Instruccion = Query.Eliminar(_ID);
                    if (Ejecutar())
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
                else
                {
                    return false;
                }

            }

        }


        public bool Socios()
        {
            if (Conectar())
            {
                Instruccion = Ventas.Query.SociosSugerencia();
                if (Consultar())
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }
        public bool Productos()
        {
            if (Conectar())
            {
                Instruccion = Ventas.Query.ProductosSugerencia();
                if (Consultar())
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }


        public bool Vendido(DateTime FIni, DateTime FFin, int _IDCorte)
        {
            if (Conectar())
            {
                Instruccion = Ventas.Query.Vendido(FIni, FFin, _IDCorte);
                if (Consultar())
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }


        public static class Query
        {
           
            public static string SociosSugerencia()
            {
                return "SELECT UPPER(replace(replace(replace(replace(replace(nombre,'á','a'),'é','e'),'í','i'),'ó','o'),'ú','u')||' '||replace(replace(replace(replace(replace(apellido,'á','a'),'é','e'),'í','i'),'ó','o'),'ú','u')||' | '||ID) AS sugerencia FROM socios WHERE activo=1 ORDER BY nombre";
            }
            public static string ProductosSugerencia()
            {
                return "SELECT UPPER(nombre||' | '||ID) AS sugerencia FROM productos WHERE activo=1 ORDER BY nombre";
            }

            public static string DescontarInventario(int _cantidad, int _idproducto)
            {
                return @"UPDATE productos SET circulacion=(circulacion-"+_cantidad+") WHERE ID="+_idproducto;
            }

            public static string Vendido(DateTime FechaIni, DateTime FechaFin, int _IDCorte)
            {
                return @"SELECT UPPER(productos.nombre) AS producto, UPPER(socios.nombre||' '||socios.apellido)  AS socio, UPPER(usuarios.nombre) AS usuario, 
CAST(ventas.cantidad AS INTEGER) AS cantidad, 
CAST(ventas.punitario AS REAL) AS punitario, 
CAST(ventas.total AS REAL) AS total, 
CAST(ventas.cobrado AS REAL) AS cobrado,

ROUND
(
    CAST(ventas.total AS REAL)
    -
    (
        CAST(productos.compra AS REAL) 
        *
        CAST(ventas.cantidad AS INTEGER)
    )
,2)
AS ganancia,

CAST(ventas.total-ventas.cobrado AS REAL) AS saldo, 
ventas.fecha
                    FROM ventas 
INNER JOIN productos ON (productos.ID=ventas.ID_productos)
INNER JOIN socios ON (socios.ID=ventas.ID_socios)
INNER JOIN usuarios ON (usuarios.ID=ventas.ID_usuarios)
                    WHERE  ventas.fecha 
                    BETWEEN '" + FechaIni.ToString("yyyy-MM-dd") + @" 00:00:00' 
                    AND '" + FechaFin.ToString("yyyy-MM-dd") + @" 23:59:59'"+ ((_IDCorte==0) ? string.Empty: "AND ventas.ID_productos IN (SELECT ID_producto FROM corte_producto WHERE ID_corte='"+_IDCorte+"')");
            }
            public static string InsertReplace(Ventas ObjVenta)
            {
                return @"INSERT OR REPLACE INTO ventas (
                ID_productos,
                ID_socios,
                ID_usuarios,
                cantidad,
                punitario,
                total,
                cobrado,
                pendiente,
                fecha
                ) VALUES (" +

                    ObjVenta.ID_producto + "," +
                    ObjVenta.ID_socio + "," +
                    ObjVenta.ID_usuario + "," +
                    "'" + ObjVenta.cantidad + "'," +
                    "'" + ObjVenta.punitario + "'," +
                    "'" + ObjVenta.total + "'," +
                    "'" + ObjVenta.cobrado + "'," +
                    "'" + (ObjVenta.pendiente?1:0) + "'," +
                    "'" + ObjVenta.fecha.ToString("yyyy-MM-dd HH:mm:ss") + "'" +
                    ");";
            }

        }

    }
    public class Socios : BaseDatos
    {
        public enum Estatus { Vencido, Pendiente, Pagado };
        public enum TipoPago { Producto, Servicio };
    

        public int ID;
        public int ID_usuarios;
        public int ID_suscripciones;
        public int ID_rutinas;

        public string nombre;
        public string apellido;
        public string telefono;
        public string facebook;
        public string direccion;
        public DateTime nacimiento;
        public DateTime inscripcion;
        public DateTime ultimopago;
        public DateTime limitepago;
        public DateTime fecharegistro;
        public int peso;
        public bool activo;

        public string Filtro { get; set; }

        public bool EliminarServicios(int _ID)
        {
            if (Conectar())
            {
                Instruccion = Socios.Query.EliminarServicio(_ID);
                if (Ejecutar())
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }


        public bool ActualizarFechaLimite(int _ID, DateTime _Fecha)
        {
            if (Conectar())
            {
                Instruccion = Socios.Query.ActualizarFechaLimite(_ID, _Fecha);
                if (Ejecutar())
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }


        public bool CobrarSuscripcion(DateTime _Fecha, int _IDSocio, int _IDUsuario)
        {
            if (Conectar())
            {
                Instruccion = Socios.Query.CobrarSuscripcion(_Fecha, _IDSocio, _IDUsuario);
                if (Ejecutar())
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }
        public bool SuscripcionesCobradas(DateTime _FechaIni, DateTime _FechaFin, int _IDSuscripcion, int _IDSocio)
        {
            if (Conectar())
            {
                Instruccion = Socios.Query.SuscripcionesCobradas(_FechaIni, _FechaFin, _IDSuscripcion, _IDSocio);
                if (Consultar())
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }
        public bool Lista(bool _Todos)
        {
            if (Conectar())
            {
                Instruccion = Socios.Query.GetSocio(Filtro, _Todos);
                if (Consultar())
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }


        public bool Huellas()
        {
            if (Conectar())
            {
                Instruccion = Socios.Query.Huellas();
                if (Consultar())
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }


        public void PaserBuffer(Socios _ObjSocio)
        {
            _ObjSocio.ID = int.Parse(Buffer.Rows[0]["ID"].ToString());
            _ObjSocio.ID_usuarios = int.Parse(Buffer.Rows[0]["ID_usuarios"].ToString());
            _ObjSocio.ID_suscripciones = int.Parse(Buffer.Rows[0]["ID_suscripciones"].ToString());
            _ObjSocio.ID_rutinas= int.Parse(Buffer.Rows[0]["ID_rutinas"].ToString());
            _ObjSocio.nombre = Buffer.Rows[0]["nombre"].ToString();
            _ObjSocio.apellido = Buffer.Rows[0]["apellido"].ToString();
            _ObjSocio.telefono = Buffer.Rows[0]["telefono"].ToString();
            _ObjSocio.facebook = Buffer.Rows[0]["facebook"].ToString();
            _ObjSocio.direccion = Buffer.Rows[0]["direccion"].ToString();
            _ObjSocio.inscripcion = DateTime.Parse(Buffer.Rows[0]["inscripcion"].ToString());
            _ObjSocio.ultimopago = DateTime.Parse(Buffer.Rows[0]["ultimopago"].ToString());
            _ObjSocio.limitepago = DateTime.Parse(Buffer.Rows[0]["limitepago"].ToString());
            _ObjSocio.fecharegistro = DateTime.Parse(Buffer.Rows[0]["fecha"].ToString());
            _ObjSocio.activo = bool.Parse(Buffer.Rows[0]["activo"].ToString());
            _ObjSocio.peso=int.Parse(Buffer.Rows[0]["peso"].ToString());
            _ObjSocio.nacimiento = DateTime.Parse(Buffer.Rows[0]["nacimiento"].ToString());
        }

        public bool Activar(int _ID, bool _Active)
        {
            if (Conectar())
            {
                Instruccion = Socios.Query.ActiveSocioByID(_ID, _Active);
                if (Ejecutar())
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }

        public bool Asistencias(DateTime Fecha)
        {
            if (Conectar())
            {
                Instruccion = Socios.Query.Asistencias(Fecha);
                if (Consultar())
                {
                    return true;
                }
                else
                {
                    return false;
                }

            }
            else
            {
                return false;
            }
        }

        public bool Interacciones(int _ID)
        {
            if (Conectar())
            {
                Instruccion = Socios.Query.Interacciones(_ID);
                if (Consultar())
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }

        public bool Asistencias(int _ID, int _Mes, int _Año)
        {
            if (Conectar())
            {
                Instruccion = Socios.Query.Asistencias(_ID, _Mes, _Año);
                if (Consultar())
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }

        public bool Pagos(int _ID, bool _Pendientes)
        {
            if (Conectar())
            {
                Instruccion = Socios.Query.VentasBySocio(_ID, _Pendientes);
                if (Consultar())
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }

        public bool Cambiar(TipoPago _Productos, int _ID, decimal _Pago)
        {
            if (Conectar())
            {
                Instruccion = Socios.Query.MontoCambiar(_Productos,_ID, _Pago);
                if (Ejecutar())
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }

        public bool Pagar(TipoPago _Productos, int _ID, decimal _Pago)
        {
            if (Conectar())
            {
                Instruccion = Socios.Query.PagosByVentas(_Productos,_ID, _Pago);
                if (Ejecutar())
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }

        

        public bool Abrir(int _ID)
        {
            if (Conectar())
            {
                Instruccion = Socios.Query.GetSocioByID(_ID);
                if (Consultar())
                {
                    PaserBuffer(this);
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }

        public int LlavePrimaria()
        {
            if (Conectar())
            {
                Instruccion = Socios.Query.GetMaxID();
                if (Consultar())
                {
                    return int.Parse(Buffer.Rows[0]["ID"].ToString());
                }
                else
                {
                    return 0;
                }
            }
            else
            {
                return 0;
            }
        }
        

   
        public bool GuardarHuella(string _Filename)
        {
            if (Conectar())
            {
                Instruccion = Socios.Query.InsertReplaceHuella(this.ID, _Filename);
                if (Ejecutar())
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }

        public bool Guardar()
        {
            if (Conectar())
            {
                Instruccion = Socios.Query.InsertReplace(this);
                if (Ejecutar())
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }

        public bool GuardarInteraccion()
        {
            if (Conectar())
            {
                Instruccion = Socios.Query.InsertReplaceInteraccion(this.ID, DateTime.Now);
                if (Ejecutar())
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }

        public static class Query
        {
            public static string GetMaxID()
            {
                return "SELECT (seq+1) AS ID FROM SQLITE_SEQUENCE WHERE name='socios'";
            }
            public static string MontoCambiar(Socios.TipoPago _Tipo, int _ID, decimal _Importe)
            {
                if (_Tipo == TipoPago.Producto)
                {
                    return "UPDATE ventas SET total="+ _Importe + " WHERE ID=" + _ID;
                }
                else
                {
                    return "UPDATE pagos SET total=" + _Importe + " WHERE ID=" + _ID;
                }
            }

            public static string PagosByVentas(Socios.TipoPago _Tipo, int _ID, decimal _Importe)
            {
                if (_Tipo== TipoPago.Producto)
                {
                    return "UPDATE ventas SET cobrado=(cobrado+" + _Importe + "), pendiente=CASE WHEN (total<=(cobrado+" + _Importe + ")) THEN 0 ELSE 1 END WHERE ID=" + _ID;
                }
                else
                {
                    return
                    @" UPDATE pagos SET cobrado=(cobrado+" + _Importe + "), pendiente=CASE WHEN (total<=(cobrado+" + _Importe + ")) THEN 0 ELSE 1 END WHERE ID='" + _ID + "';" +
                    @" UPDATE socios SET ultimopago='" + DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") + "' WHERE ID=(SELECT ID_socios FROM pagos WHERE ID='" + _ID + "' AND total=cobrado); ";
                   
                }
            }
            public static string EliminarServicio(int _ID)
            {
                return "DELETE FROM pagos WHERE ID='" + _ID + "'";
            }
            public static string ActualizarFechaLimite(int _ID, DateTime _Fecha)
            {
                return "UPDATE socios SET limitepago='" + _Fecha.ToString("yyyy-MM-dd HH:mm:ss") + "' WHERE ID='"+_ID+"'";
            }

            public static string Asistencias(DateTime _Fecha)
            {
                return @"SELECT MIN(time(interacciones.fecha)) AS hora, UPPER(socios.nombre) AS nombre, UPPER(socios.apellido) AS apellido
                        FROM interacciones
                        INNER JOIN socios ON
                        (socios.ID=interacciones.ID_socios)
                        WHERE date(interacciones.fecha)='" +_Fecha.ToString("yyyy-MM-dd")+@"'
                        GROUP BY socios.nombre, socios.apellido";
            }
            public static string Interacciones(int _ID)
            {
                return @"SELECT * FROM interacciones WHERE ID_socios='" + _ID + "'";
            }
            public static string Asistencias(int _ID, int _Mes, int _Año)
            {
                return @"
                        SELECT DISTINCT
                        strftime('%d', DATE(fecha)) AS dia
                         FROM interacciones 
                        WHERE ID_socios=" + _ID+@" 
                        AND strftime('%Y', DATE(fecha))='"+_Año.ToString()+@"'
                        AND strftime('%m', DATE(fecha))='"+_Mes.ToString().PadLeft(2,'0')+"'";

            }
            public static string VentasBySocio(int _ID, bool _Pendiente)
            {
                return @"                
                    SELECT 1 AS producto, ventas.ID,ventas.fecha,productos.nombre,ventas.pendiente,ventas.cantidad,ventas.total,
                    (ventas.cobrado-ventas.total) AS deuda, 30 AS dias
                    
                    FROM ventas 
                    INNER JOIN productos ON
                    (productos.ID=ventas.ID_productos)" +

                    " WHERE ventas.ID_socios='" + _ID + "'" +
                    (_Pendiente ? " AND ventas.pendiente='1' " : string.Empty) +

                    @" UNION ALL
                    SELECT 0 AS producto, pagos.ID, pagos.fecha, suscripciones.nombre,pagos.pendiente,pagos.cantidad,pagos.total, 
                    (pagos.cobrado-pagos.total) AS deuda, suscripciones.dias
                    
                    FROM pagos 
                    INNER JOIN suscripciones ON
                    (suscripciones.ID=pagos.ID_suscripciones)" +

                    " WHERE pagos.ID_socios='" + _ID + "'" +
                    (_Pendiente ? " AND pagos.pendiente='1' " : string.Empty)+
                    " ORDER BY fecha DESC ";
                   
            }
            public static string GetSocioByID(int _ID)
            {
                return @"SELECT ID,
                                ID_usuarios,
                                ID_suscripciones,
                                ID_rutinas,
                                nombre,
                                apellido,
                                telefono,
                                facebook,
                                direccion,
                                inscripcion,
                                ultimopago,
                                limitepago,
                                fecha,
                                activo,
                                peso,
                                nacimiento 
                        FROM socios WHERE ID=" + _ID + "";
            }
            public static string SuscripcionesCobradas(DateTime _FechaIni, DateTime _FechaFin, int _IDSuscripcion, int _IDSocio)
            {
                return @"SELECT * FROM pagos 
                WHERE DATE(fecha) 
                BETWEEN DATE('" + _FechaIni.ToString("yyyy-MM-dd") + @"') 
                AND DATE('" + _FechaFin.ToString("yyyy-MM-dd") + @"')
                AND ID_socios='" + _IDSocio + @"'
                AND ID_suscripciones='"+ _IDSuscripcion +"'";
            }
            public static string CobrarSuscripcion(DateTime _Fecha, int _IDSocio, int _IDUsuario)
            {
                return @"INSERT INTO pagos (ID_suscripciones, ID_socios, ID_usuarios, cantidad, punitario, total, cobrado, pendiente, fecha)
                        SELECT suscripciones.ID, socios.ID, '" + _IDUsuario + "', 1, suscripciones.costo, suscripciones.costo, 0, 1, '" + _Fecha.ToString("yyyy-MM-dd") + @"'
                        FROM socios
                        INNER JOIN suscripciones ON
                        (
                        suscripciones.ID=socios.ID_suscripciones
                        )
                        WHERE socios.ID=" + _IDSocio;
            }
            public static string Huellas()
            {
                return "SELECT huellas.* FROM huellas INNER JOIN socios ON (socios.id=huellas.id_socios) WHERE socios.activo=1";
            }
            public static string GetSocio(string _Filtro, bool Todos)
            {
                string Criterio = " AND UPPER(socios.ID||'-'||replace(replace(replace(replace(replace(socios.nombre,'á','a'),'é','e'),'í','i'),'ó','o'),'ú','u')||'-'||replace(replace(replace(replace(replace(socios.apellido,'á','a'),'é','e'),'í','i'),'ó','o'),'ú','u')) LIKE '%" + _Filtro.ToUpper() + "%'";
                return @"SELECT 
                        (SELECT COUNT(*) FROM ventas WHERE ventas.pendiente=1 AND ventas.ID_socios=socios.ID)+
                        (SELECT COUNT(*) FROM pagos WHERE pagos.pendiente=1 AND pagos.ID_socios=socios.ID) AS pendientes,


                        (SELECT IFNULL(SUM(total-cobrado),0) FROM ventas WHERE ventas.pendiente=1 AND ventas.ID_socios=socios.ID)+
                        (SELECT IFNULL(SUM(total-cobrado),0) FROM pagos WHERE pagos.pendiente=1 AND pagos.ID_socios=socios.ID) AS montos,

                        socios.ID,
                        socios.ID_usuarios,
                        socios.ID_suscripciones,
                        socios.ID_rutinas,
                        suscripciones.nombre AS suscripcion,
                        suscripciones.dias,
                        socios.nombre,
                        socios.apellido,
                        socios.telefono,
                        socios.facebook,
                        socios.direccion,
                        socios.inscripcion,
                        socios.ultimopago,
                        socios.limitepago,
                        socios.fecha,
                        socios.activo,
                        socios.peso,
                        socios.nacimiento
                        FROM socios
                        INNER JOIN suscripciones ON
                        (suscripciones.ID=socios.ID_suscripciones) 
                        WHERE activo IN (" + (Todos ? "0,1" : "1") + ") " +
                        ((_Filtro.Length > 0) ? Criterio : string.Empty) +
                        " ORDER BY socios.ID DESC";
            }
            public static string ActiveSocioByID(int _ID, bool _Active)
            {
                return "UPDATE socios SET activo=" + (_Active ? 1 : 0) + " WHERE ID=" + _ID + "";
            }

            public static string InsertReplaceInteraccion(int _ID, DateTime _Fecha)
            {
                return @"INSERT OR REPLACE INTO interacciones (
                ID_socios, fecha
                ) VALUES ('" + _ID + "','" + _Fecha.ToString("yyyy-MM-dd HH:mm:ss") + "')";
 
            }
            public static string InsertReplaceHuella(int _ID, string _FPFile)
            {
                return @"INSERT OR REPLACE INTO huellas (
                ID_socios, huella
                ) VALUES ('" + _ID + "','" + _FPFile + "');";
            }

            public static string InsertReplace(Socios ObjSocio)
            {
                return @"INSERT OR REPLACE INTO socios (
                ID,
                ID_usuarios,
                ID_suscripciones,
                ID_rutinas,
                nombre,
                apellido,
                telefono,
                facebook,
                direccion,
                inscripcion,
                ultimopago,
                limitepago,
                fecha,
                activo,
                peso,
                nacimiento
                ) VALUES (" +
                    ObjSocio.ID + "," +
                    ObjSocio.ID_usuarios + "," +
                    ObjSocio.ID_suscripciones + "," +
                    ObjSocio.ID_rutinas + "," +
                    "'" + ObjSocio.nombre + "'," +
                    "'" + ObjSocio.apellido + "'," +
                    "'" + ObjSocio.telefono + "'," +
                    "'" + ObjSocio.facebook + "'," +
                    "'" + ObjSocio.direccion + "'," +
                    "'" + ObjSocio.inscripcion.ToString("yyyy-MM-dd") + "'," +
                    "'" + ObjSocio.ultimopago.ToString("yyyy-MM-dd") + "'," +
                    "'" + ObjSocio.limitepago.ToString("yyyy-MM-dd") + "'," +
                    "'" + ObjSocio.fecharegistro.ToString("yyyy-MM-dd HH:mm:ss") + "'," +
                    (ObjSocio.activo ? 1 : 0) +"," +
                    ObjSocio.peso + "," +
                    "'" + ObjSocio.nacimiento.ToString("yyyy-MM-dd") + "'" +
                    ");";
            }
        } 
    }
    public class Usuarios : BaseDatos
    {
       public int ID;
       public string username;
       public string password;
       public string nombre;
       public DateTime fecha;
       public bool activo;
       public bool socios;
       public bool ventas;
       public bool inventarios;
       public bool usuarios;
       public bool rutinas;

       public bool Lista()
       {
           if (Conectar())
           {
               Instruccion = Usuarios.Query.GetUser();
               if (Consultar())
               {
                   return true;
               }
               else
               {
                   return false;
               }
           }
           else
           {
               return false;
           }
       }


       public void PaserBuffer(Usuarios _ObjUsuario)
       {

           _ObjUsuario.ID = int.Parse(Buffer.Rows[0]["ID"].ToString());
           _ObjUsuario.username = Buffer.Rows[0]["username"].ToString();
           _ObjUsuario.password = Buffer.Rows[0]["password"].ToString();
           _ObjUsuario.nombre = Buffer.Rows[0]["nombre"].ToString();
           _ObjUsuario.fecha = DateTime.Parse(Buffer.Rows[0]["fecha"].ToString());
           _ObjUsuario.activo = bool.Parse(Buffer.Rows[0]["activo"].ToString());
           _ObjUsuario.socios = bool.Parse(Buffer.Rows[0]["socios"].ToString());
           _ObjUsuario.ventas = bool.Parse(Buffer.Rows[0]["ventas"].ToString());
           _ObjUsuario.inventarios = bool.Parse(Buffer.Rows[0]["inventarios"].ToString());
           _ObjUsuario.usuarios = bool.Parse(Buffer.Rows[0]["usuarios"].ToString());
           _ObjUsuario.rutinas = bool.Parse(Buffer.Rows[0]["rutinas"].ToString());

           
       }

       public bool Login()
       {
           if (Conectar())
           {
               Instruccion = Usuarios.Query.GetUserByUserPass(this.username, this.password);
               if (Consultar())
               {
                   PaserBuffer(this);
                   return true;
               }
               else
               {
                   MessageBox.Show("Acceso denegado");
                   return false;
               }
           }
           else
           {              
               return false;
           }
       }

       public bool Activar(int _ID, bool _Active)
       {
           if (Conectar())
           {
               Instruccion = Usuarios.Query.ActiveUserByID(_ID, _Active);
               if (Ejecutar())
               {
                   return true;
               }
               else
               {
                   return false;
               }
           }
           else
           {
               return false;
           }
       }

       public bool Abrir(int _ID)
       {
           if (Conectar())
           {
               Instruccion = Usuarios.Query.GetUserByID(_ID);
               if (Consultar())
               {
                   PaserBuffer(this);
                   return true;
               }
               else
               {
                   return false;
               }
           }
           else
           {
               return false;
           }
       }

       public int LlavePrimaria()
       {
           if (Conectar())
           {
               Instruccion = Usuarios.Query.GetMaxID();
               if (Consultar())
               {   
                   return int.Parse(Buffer.Rows[0]["ID"].ToString());
               }
               else
               {
                   return 0;
               }
           }
           else
           {
               return 0;
           }
       }

       public bool Guardar()
       {
           if (Conectar())
           {
               Instruccion = Usuarios.Query.InsertReplace(this);
               if (Ejecutar())
               {
                   return true;
               }
               else
               {
                   return false;
               }
           }
           else
           {
               return false;
           }
       }


       public static class Query
       {
           public static string GetMaxID()
           {
               return "SELECT (seq+1) AS ID FROM SQLITE_SEQUENCE WHERE name='usuarios'";
           }
           public static string GetUserByUserPass(string _User, string _Pass)
           {
               return @"SELECT ID,username, password, nombre, fecha, activo, socios, ventas, inventarios, usuarios, rutinas 
                        FROM usuarios WHERE username='" + _User + "' AND password='" + _Pass + "' AND activo=1";
           }
           public static string GetUserByID(int _ID)
           {
               return @"SELECT ID,username, password, nombre, fecha, activo, socios, ventas, inventarios, usuarios, rutinas
                        FROM usuarios WHERE ID=" + _ID + "";
           }
           public static string GetUser()
           {
               return @"
                        SELECT ID,username, password, nombre, fecha, activo, socios, ventas, inventarios, usuarios, rutinas,
                        nombre ||
                        ' (' ||
                        UPPER(CASE activo WHEN 1 THEN 'Activo' ELSE 'Inactivo' END) ||
                        ')'
                        AS nombre_estatus
                        FROM usuarios";
           }
           public static string ActiveUserByID(int _ID, bool _Active)
           {
               return "UPDATE usuarios SET activo=" + (_Active ? 1 : 0) + " WHERE ID=" + _ID + "";
           }
           public static string InsertReplace(Usuarios ObjUsuario)
           {
               return "INSERT OR REPLACE INTO usuarios (ID,username, password, nombre, fecha, activo, socios, ventas, inventarios, usuarios, rutinas) VALUES (" + 
                   ObjUsuario.ID + "," + 
                   "'" + ObjUsuario.username + "'," +
                   "'" + ObjUsuario.password + "'," +
                   "'" + ObjUsuario.nombre + "'," +
                   "'" + ObjUsuario.fecha.ToString("yyyy-MM-dd HH:mm:ss") + "'," + 
                   (ObjUsuario.activo ? 1 : 0) + "," + 
                   (ObjUsuario.socios ? 1 : 0) + "," + 
                   (ObjUsuario.ventas ? 1 : 0) + "," + 
                   (ObjUsuario.inventarios ? 1 : 0) + "," +
                   (ObjUsuario.usuarios ? 1 : 0) + "," +
                   (ObjUsuario.rutinas ? 1 : 0) + ");";
           }
       } 
    }
       
    public class Productos : BaseDatos
    {
        public class Marcas : BaseDatos
        {
            public int ID { get; set; }
            public string Nombre { get; set; }
            public Marcas(int _ID)
            {
                if (Conectar())
                {
                    Instruccion = Query.MarcaById(_ID);
                    if (Consultar())
                    {
                        ID = int.Parse(Buffer.Rows[0]["ID"].ToString());
                        Nombre = Buffer.Rows[0]["nombre"].ToString();
                    }

                }
            
            }

            public Marcas()
            {
                if (Conectar())
                {
                    Instruccion = Query.Marcas();
                    if (Consultar())
                    {
                        return;
                    }

                }
            }

            public static class Query
            {
                public static string MarcaById(int _ID)
                {
                    return "SELECT * FROM marcas WHERE ID='"+_ID+"'";
                }
                public static string Marcas()
                {
                    return "SELECT * FROM marcas";
                }
            }

        }


        public class Presentaciones : BaseDatos
        {
            public int ID { get; set; }
            public string Nombre { get; set; }
            public Presentaciones(int _ID)
            {
                Instruccion = Query.PresentacionById(_ID);
                if (Consultar())
                {
                    ID = int.Parse(Buffer.Rows[0]["ID"].ToString());
                    Nombre = Buffer.Rows[0]["nombre"].ToString();
                }
            }

            public Presentaciones()
            {
                if (Conectar())
                {
                    Instruccion = Query.Presentaciones();
                    if (Consultar())
                    {
                        return;
                    }

                }
            }

            public static class Query
            {
                public static string PresentacionById(int _ID)
                {
                    return "SELECT * FROM presentaciones  WHERE ID='" + _ID + "'";
                }
                public static string Presentaciones()
                {
                    return "SELECT * FROM presentaciones";
                }
            }
        }

        public int ID;
        public int ID_usuario;
        public string clave_alterna;
        public string codigo_barra;
        public string nombre;
        public int piezas_caja;
        public float precio_compra;
        public float precio_venta;
        public int almacenado;
        public int mostrador;
        public DateTime fecha;
        public bool activo;
        public bool retornable;

        public Marcas marca { get; set; }
        public Presentaciones presentacion { get; set; }

        public string Criterio { get; set; }


        public bool Lista()
        {
            if (Conectar())
            {
                Instruccion = Productos.Query.GetProduct(Criterio);
                if (Consultar())
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }

        public void PaserBuffer(Productos _ObjProducto)
        {
            _ObjProducto.ID = int.Parse(Buffer.Rows[0]["ID"].ToString());
            _ObjProducto.ID_usuario = int.Parse(Buffer.Rows[0]["ID_usuarios"].ToString());
            _ObjProducto.marca=new Marcas(int.Parse(Buffer.Rows[0]["ID_marcas"].ToString()));
            _ObjProducto.presentacion = new Presentaciones(int.Parse(Buffer.Rows[0]["ID_presentaciones"].ToString()));
            _ObjProducto.clave_alterna= Buffer.Rows[0]["clave"].ToString();
            _ObjProducto.codigo_barra = Buffer.Rows[0]["codigobarras"].ToString();
            _ObjProducto.nombre = Buffer.Rows[0]["nombre"].ToString();

            _ObjProducto.piezas_caja= int.Parse(Buffer.Rows[0]["piezacaja"].ToString());
            _ObjProducto.precio_compra = float.Parse(Buffer.Rows[0]["compra"].ToString());
            _ObjProducto.precio_venta = float.Parse(Buffer.Rows[0]["venta"].ToString());
            _ObjProducto.almacenado = int.Parse(Buffer.Rows[0]["almacenado"].ToString());
            _ObjProducto.mostrador = int.Parse(Buffer.Rows[0]["mostrador"].ToString());
            _ObjProducto.fecha = DateTime.Parse(Buffer.Rows[0]["fecha"].ToString());

            _ObjProducto.retornable = bool.Parse(Buffer.Rows[0]["retornable"].ToString());
            _ObjProducto.activo = bool.Parse(Buffer.Rows[0]["activo"].ToString());

        }

        public bool Activar(int _ID, bool _Active)
        {
            if (Conectar())
            {
                Instruccion = Productos.Query.ActiveProductByID(_ID, _Active);
                if (Ejecutar())
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }

        
        public bool Abrir(Productos.Query.KeyType _Key, string _Value)
        {
            if (Conectar())
            {
                Instruccion = Productos.Query.GetProductByKey(_Key, _Value);
                if (Consultar())
                {
                    PaserBuffer(this);
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }

        public int LlavePrimaria()
        {
            if (Conectar())
            {
                Instruccion = Productos.Query.GetMaxID();
                if (Consultar())
                {
                    return int.Parse(Buffer.Rows[0]["ID"].ToString());
                }
                else
                {
                    return 0;
                }
            }
            else
            {
                return 0;
            }
        }
        public bool MoverProductos()
        {
            if (Conectar())
            {
                Instruccion = Productos.Query.MovimientosProductoByID(ID, mostrador, almacenado);
                if (Ejecutar())
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }

        

        public bool Guardar()
        {
            if (Conectar())
            {
                Instruccion = Productos.Query.InsertReplace(this);
                if (Ejecutar())
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }

        public static class Query
        {
            public static string GetMaxID()
            {
                return "SELECT (seq+1) AS ID FROM SQLITE_SEQUENCE WHERE name='productos'";
            }
            public enum KeyType { Identifier, BarCode};
            public static string GetProductByKey(KeyType _Key, string _Value)
            {
                string KeyColumn = string.Empty;
                switch (_Key)
                {
                    case KeyType.Identifier: { KeyColumn = "ID"; } break;
                    case KeyType.BarCode: { KeyColumn = "codigobarras"; } break;
                }
                return @"SELECT 
                        ID, ID_usuarios, ID_marcas, ID_presentaciones, clave, codigobarras, nombre, piezacaja, compra, venta, almacenado, mostrador, fecha, activo, retornable
                        FROM productos WHERE "+ KeyColumn +"='" + _Value + "'";
            }
            public static string GetProduct(string _Filtro)
            {
                string WHERE = (_Filtro == null ? string.Empty :
                    " WHERE UPPER(clave||'-'||nombre||'-'||codigobarras) LIKE '%" + _Filtro.ToUpper() + "%'");
                return @"SELECT 
                        ID, ID_usuarios, ID_marcas, ID_presentaciones, clave, codigobarras, nombre, piezacaja, compra, venta, almacenado, mostrador, fecha, activo, retornable
                         FROM productos " + WHERE + " ORDER BY nombre DESC ";
            }
            public static string ActiveProductByID(int _ID, bool _Active)
            {
                return "UPDATE productos SET activo=" + (_Active ? 1 : 0) + " WHERE ID=" + _ID + "";
            }

            public static string MovimientosProductoByID(int _ID,int _Mostrador, int _Almacenado)
            {
                return "UPDATE productos SET mostrador=" + _Mostrador + ", almacenado="+_Almacenado+" WHERE ID=" + _ID + "";
            }
            public static string InsertReplace(Productos ObjProducto)
            {
                return "INSERT OR REPLACE INTO productos (ID, ID_usuarios, ID_marcas, ID_presentaciones, clave, codigobarras, nombre, piezacaja, compra, venta, almacenado, mostrador, fecha, activo, retornable) VALUES (" +
                    ObjProducto.ID +","+
                    ObjProducto.ID_usuario + "," +

                    ObjProducto.marca.ID+","+
                    ObjProducto.presentacion.ID + "," +

                    "'" + ObjProducto.clave_alterna + "'," +
                    "'" + ObjProducto.codigo_barra + "'," +
                    "'" + ObjProducto.nombre + "'," +

                    "'" + ObjProducto.piezas_caja + "'," +
                    "'" + ObjProducto.precio_compra + "'," +
                    "'" + ObjProducto.precio_venta + "'," +
                    
                    ObjProducto.almacenado + "," +
                    ObjProducto.mostrador + "," +

                    "'" + ObjProducto.fecha.ToString("yyyy-MM-dd HH:mm:ss") + "'," +
                    
                    (ObjProducto.activo ? 1 : 0) + ","+ (ObjProducto.retornable ? 1 : 0) + ");";
            }
        } 
    }
    public class Rutinas : BaseDatos
    {
        public int ID;
        public string Nombre;
        public DateTime Fecha;
        public int LlavePrimaria()
        {
            if (Conectar())
            {
                Instruccion = Rutinas.Query.GetMaxID();
                if (Consultar())
                {
                    return int.Parse(Buffer.Rows[0]["ID"].ToString());
                }
                else
                {
                    return 0;
                }
            }
            else
            {
                return 0;
            }
        }
        public bool Guardar()
        {
            if (Conectar())
            {
                Instruccion = Rutinas.Query.InsertReplace(this);
                if (Ejecutar())
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }

        public string EspWeek(DayOfWeek _Day)
        {
            switch (_Day)
            {
                case DayOfWeek.Monday: { return "Lunes"; };
                case DayOfWeek.Tuesday: { return "Martes"; };
                case DayOfWeek.Wednesday: { return "Miércoles"; };
                case DayOfWeek.Thursday: { return "Jueves"; };
                case DayOfWeek.Friday: { return "Viernes"; };
                case DayOfWeek.Saturday: { return "Sábado"; };
                case DayOfWeek.Sunday: { return "Domingo"; };
            }
            return "";
        }
        
        public System.Data.DataTable ListaDias()
        {
            System.Data.DataTable Respuesta = new System.Data.DataTable();
            Respuesta.Columns.Add("id", typeof(int));
            Respuesta.Columns.Add("nombre", typeof(string));
            

            System.Data.DataRow Lunes = Respuesta.NewRow();
            Lunes[0] = (int)DayOfWeek.Monday;
            Lunes[1] = EspWeek(DayOfWeek.Monday);
            Respuesta.Rows.Add(Lunes);


            System.Data.DataRow Martes = Respuesta.NewRow();
            Martes[0] = (int)DayOfWeek.Tuesday;
            Martes[1] = EspWeek(DayOfWeek.Tuesday);
            Respuesta.Rows.Add(Martes);


            System.Data.DataRow Miercoles = Respuesta.NewRow();
            Miercoles[0] = (int)DayOfWeek.Wednesday;
            Miercoles[1] = EspWeek(DayOfWeek.Wednesday);
            Respuesta.Rows.Add(Miercoles);



            System.Data.DataRow Jueves = Respuesta.NewRow();
            Jueves[0] = (int)DayOfWeek.Thursday;
            Jueves[1] = EspWeek(DayOfWeek.Thursday);
            Respuesta.Rows.Add(Jueves);


            System.Data.DataRow Viernes = Respuesta.NewRow();
            Viernes[0] = (int)DayOfWeek.Friday;
            Viernes[1] = EspWeek(DayOfWeek.Friday);
            Respuesta.Rows.Add(Viernes);



            System.Data.DataRow Sabado = Respuesta.NewRow();
            Sabado[0] = (int)DayOfWeek.Saturday;
            Sabado[1] = EspWeek(DayOfWeek.Saturday);
            Respuesta.Rows.Add(Sabado);



            System.Data.DataRow Domingo = Respuesta.NewRow();
            Domingo[0] = (int)DayOfWeek.Sunday;
            Domingo[1] = EspWeek(DayOfWeek.Sunday);
            Respuesta.Rows.Add(Domingo);
            
            return Respuesta;
        }

        public bool Lista()
        {

            if (Conectar())
            {
                Instruccion = Rutinas.Query.GetRutinas();
                if (Consultar())
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }

        public bool Eliminar(int _ID)
        {
            if (Conectar())
            {
                Instruccion = Rutinas.Query.Eliminar(_ID);
                if (Ejecutar())
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }


        public static class Query
        {
            public static string Eliminar(int _ID)
            {
                return @"DELETE FROM rutinas WHERE ID='"+_ID+@"'; 
                DELETE FROM ejercicios WHERE ID_rutinas='"+_ID+@"'; 
                UPDATE socios SET ID_rutinas=0 WHERE ID_rutinas='"+_ID+@"'"; 
            }
            public static string GetMaxID()
            {
                return "SELECT (seq+1) AS ID FROM SQLITE_SEQUENCE WHERE name='rutinas'";
            }
            public static string InsertReplace(Rutinas ObjRutina)
            {
                return "INSERT OR REPLACE INTO rutinas (ID, nombre, fecha) VALUES ('" + ObjRutina.ID + "','" + ObjRutina.Nombre + "','" + ObjRutina.Fecha.ToString("yyyy-MM-dd HH:mm:ss") + "')";
            }
            public static string GetRutinas()
            {
                return "SELECT * FROM rutinas";
            }
        }     
    }

    public class Ejercicios : BaseDatos
    {
        public int ID;
        public int ID_Rutina;
        public int Dia;
        public string Nombre;
        public string Series;
        public string Repeticiones;

        public int LlavePrimaria()
        {
            if (Conectar())
            {
                Instruccion = Ejercicios.Query.GetMaxID();
                if (Consultar())
                {
                    return int.Parse(Buffer.Rows[0]["ID"].ToString());
                }
                else
                {
                    return 0;
                }
            }
            else
            {
                return 0;
            }
        }
        public bool Guardar()
        {
            if (Conectar())
            {
                Instruccion = Ejercicios.Query.InsertReplace(this);
                if (Ejecutar())
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }

        public bool Lista(int _ID)
        {
            if (Conectar())
            {
                Instruccion = Ejercicios.Query.GetEjerciciosByRutina(_ID);
                if (Consultar())
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }

        public bool Lista()
        {
            if (Conectar())
            {
                Instruccion = Ejercicios.Query.GetEjercicios();
                if (Consultar())
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }


        public bool Eliminar(int _ID)
        {
            if (Conectar())
            {
                Instruccion = Ejercicios.Query.Eliminar(_ID);
                if (Ejecutar())
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }


        public static class Query
        {
            public static string Eliminar(int _ID)
            {
                return @"DELETE FROM ejercicios WHERE ID='" + _ID + @"'";
            }
            public static string GetMaxID()
            {
                return "SELECT (seq+1) AS ID FROM SQLITE_SEQUENCE WHERE name='ejercicios'";
            }
            public static string InsertReplace(Ejercicios ObjEjercicio)
            {
                return "INSERT OR REPLACE INTO ejercicios (ID, ID_rutinas, dia, nombre, series, repeticiones) VALUES ("+
                    "'" + ObjEjercicio.ID + "',"+
                    "'" + ObjEjercicio.ID_Rutina+ "',"+
                    "'" + ObjEjercicio.Dia + "'," +
                    "'" + ObjEjercicio.Nombre.ToUpper() + "',"+
                    "'" + ObjEjercicio.Series.ToUpper() + "'," +
                    "'" + ObjEjercicio.Repeticiones.ToUpper() + "'" +
                    ")";
            }
            public static string GetEjerciciosByRutina(int _ID)
            {
                return "SELECT * FROM ejercicios WHERE ID_rutinas='"+_ID+"'";
            }
            public static string GetEjercicios()
            {
                return "SELECT DISTINCT(nombre) AS sugerencia FROM ejercicios";
            }
        }     

    }

}
