using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace SIGA_ITEA.Controllers
{
    [AllowAnonymous]
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            if (Session["Usuario"] == null)
            {
                return RedirectToAction("Login");
            }
            return View();
        }

        public ActionResult Alumnos()
        {
            if (Session["Usuario"] == null)
            {
                return RedirectToAction("Login");
            }
            return View();
        }

        public ActionResult AlumnosPorRegion(int id)
        {
            if (Session["Usuario"] == null)
            {
                return RedirectToAction("Login");
            }
            ViewBag.RegionId = id;

            var alumnos = new List<SIGA_ITEA.Models.AlumnoMock>();

            if (id == 7)
            {
                // Muestreo dinámico de MR 7 basado en el Avance Académico proporcionado
                string unidad = "385 ESC. SAN VALENTIN";
                string ce1 = "20090235";
                string ce2 = "20090236";
                string ce3 = "20090237";

                alumnos.Add(new SIGA_ITEA.Models.AlumnoMock { RFE = "AARG-000105-BQ5", Nombre = "ALVAREZ REYES GABRIELA LIZETH", FechaRegistro = "24/04/2026", Promedio = "8.5", UnidadOperativa = unidad, CirculoEstudio = ce1, Estatus = "Completo" });
                alumnos.Add(new SIGA_ITEA.Models.AlumnoMock { RFE = "AASL-951214-7K0", Nombre = "AMADOR SAENZ JOSE LUIS", FechaRegistro = "20/11/2025", Promedio = "8.2", UnidadOperativa = unidad, CirculoEstudio = ce1, Estatus = "Completo" });
                alumnos.Add(new SIGA_ITEA.Models.AlumnoMock { RFE = "BAAL-100817-7Q0", Nombre = "BALDERAS ANTONIO LUZDARY NICOLE", FechaRegistro = "06/02/2026", Promedio = "6.8", UnidadOperativa = unidad, CirculoEstudio = ce1, Estatus = "Faltan Doc." });
                alumnos.Add(new SIGA_ITEA.Models.AlumnoMock { RFE = "CARO-100228-DE1", Nombre = "CASTELLANOS RAMOS OSCAR EDUARD", FechaRegistro = "04/10/2022", Promedio = "8.2", UnidadOperativa = unidad, CirculoEstudio = ce1, Estatus = "Completo" });
                alumnos.Add(new SIGA_ITEA.Models.AlumnoMock { RFE = "CERA-090909-MLA", Nombre = "CERDA RAMIREZ JOSE ANGEL", FechaRegistro = "03/10/2024", Promedio = "8.3", UnidadOperativa = unidad, CirculoEstudio = ce1, Estatus = "Completo" });
                alumnos.Add(new SIGA_ITEA.Models.AlumnoMock { RFE = "CUDD-080328-UT8", Nombre = "CRUZ DOMINGUEZ DEISY JOSELYN", FechaRegistro = "25/02/2026", Promedio = "7.0", UnidadOperativa = unidad, CirculoEstudio = ce1, Estatus = "Faltan Doc." });
                alumnos.Add(new SIGA_ITEA.Models.AlumnoMock { RFE = "CUGE-091220-SB2", Nombre = "CRUZ GONZALEZ EDSON DANIEL", FechaRegistro = "15/08/2025", Promedio = "0.0", UnidadOperativa = unidad, CirculoEstudio = ce1, Estatus = "Faltan Doc." });
                alumnos.Add(new SIGA_ITEA.Models.AlumnoMock { RFE = "CUMO-110124-LV3", Nombre = "CRUZ MARCIAL OSMAR ARTURO", FechaRegistro = "19/10/2022", Promedio = "9.3", UnidadOperativa = unidad, CirculoEstudio = ce1, Estatus = "Completo" });
                alumnos.Add(new SIGA_ITEA.Models.AlumnoMock { RFE = "GAGB-091102-AB0", Nombre = "GALICIA GARCIA BRAYAN ALEXANDER", FechaRegistro = "17/04/2026", Promedio = "8.0", UnidadOperativa = unidad, CirculoEstudio = ce1, Estatus = "Completo" });
                alumnos.Add(new SIGA_ITEA.Models.AlumnoMock { RFE = "HESC-080305-3A9", Nombre = "HERNANDEZ SANTIAGO CARLOS DANIE", FechaRegistro = "16/08/2021", Promedio = "8.0", UnidadOperativa = unidad, CirculoEstudio = ce1, Estatus = "Completo" });
                alumnos.Add(new SIGA_ITEA.Models.AlumnoMock { RFE = "HESR-090214-7Q9", Nombre = "HERNANDEZ SANTIAGO RICARDO DAVI", FechaRegistro = "16/08/2021", Promedio = "8.5", UnidadOperativa = unidad, CirculoEstudio = ce1, Estatus = "Completo" });
                
                alumnos.Add(new SIGA_ITEA.Models.AlumnoMock { RFE = "JUAD-080813-T6A", Nombre = "JUAREZ AVELINO DINA YELITZA", FechaRegistro = "26/10/2023", Promedio = "7.5", UnidadOperativa = unidad, CirculoEstudio = ce1, Estatus = "Faltan Doc." });
                alumnos.Add(new SIGA_ITEA.Models.AlumnoMock { RFE = "JUAO-100927-467", Nombre = "JUAREZ AVELINO OSCAR ODIN", FechaRegistro = "24/04/2026", Promedio = "6.8", UnidadOperativa = unidad, CirculoEstudio = ce1, Estatus = "Completo" });
                alumnos.Add(new SIGA_ITEA.Models.AlumnoMock { RFE = "LOOA-041203-TN8", Nombre = "LOPEZ OLVERA ALAN ULISES", FechaRegistro = "17/03/2021", Promedio = "7.1", UnidadOperativa = unidad, CirculoEstudio = ce1, Estatus = "Completo" });
                alumnos.Add(new SIGA_ITEA.Models.AlumnoMock { RFE = "LOSK-060804-T20", Nombre = "LOPEZ SANTIAGO KATHIA YAEL", FechaRegistro = "24/04/2026", Promedio = "6.7", UnidadOperativa = unidad, CirculoEstudio = ce1, Estatus = "Faltan Doc." });
                alumnos.Add(new SIGA_ITEA.Models.AlumnoMock { RFE = "LUMV-081002-UT2", Nombre = "LUNA MARTINEZ VANESSA YAMILETH", FechaRegistro = "08/02/2024", Promedio = "7.2", UnidadOperativa = unidad, CirculoEstudio = ce1, Estatus = "Completo" });
                alumnos.Add(new SIGA_ITEA.Models.AlumnoMock { RFE = "MABA-101003-P63", Nombre = "MALDONADO BARRON ANA KARINA", FechaRegistro = "03/10/2025", Promedio = "7.7", UnidadOperativa = unidad, CirculoEstudio = ce1, Estatus = "Completo" });
                alumnos.Add(new SIGA_ITEA.Models.AlumnoMock { RFE = "MACN-870621-T25", Nombre = "MATEO CORRO NANCY", FechaRegistro = "17/08/2005", Promedio = "8.8", UnidadOperativa = unidad, CirculoEstudio = ce1, Estatus = "Completo" });
                alumnos.Add(new SIGA_ITEA.Models.AlumnoMock { RFE = "MEPL-900829-DF5", Nombre = "MEJIA PEREZ JOSE LUIS", FechaRegistro = "27/03/2026", Promedio = "7.5", UnidadOperativa = unidad, CirculoEstudio = ce1, Estatus = "Completo" });
                alumnos.Add(new SIGA_ITEA.Models.AlumnoMock { RFE = "MESE-080713-254", Nombre = "MEJIA SANTIAGO ENRIQUE MARTIN", FechaRegistro = "04/03/2020", Promedio = "8.6", UnidadOperativa = unidad, CirculoEstudio = ce1, Estatus = "Completo" });
                alumnos.Add(new SIGA_ITEA.Models.AlumnoMock { RFE = "MOCM-081007-K2A", Nombre = "MORALES CASTILLO MARCO ANTONIO", FechaRegistro = "16/10/2024", Promedio = "7.3", UnidadOperativa = unidad, CirculoEstudio = ce1, Estatus = "Faltan Doc." });
                alumnos.Add(new SIGA_ITEA.Models.AlumnoMock { RFE = "OEDP-081223-KI3", Nombre = "ORTEGON DOMINGUEZ PEDRO ARTURO", FechaRegistro = "22/11/2024", Promedio = "8.0", UnidadOperativa = unidad, CirculoEstudio = ce1, Estatus = "Completo" });

                alumnos.Add(new SIGA_ITEA.Models.AlumnoMock { RFE = "OIVS-811215-IT9", Nombre = "ORTIZ VALDEZ SOLEDAD", FechaRegistro = "20/11/2007", Promedio = "8.8", UnidadOperativa = unidad, CirculoEstudio = ce1, Estatus = "Completo" });
                alumnos.Add(new SIGA_ITEA.Models.AlumnoMock { RFE = "PEGM-740719-PW8", Nombre = "PEREZ GUERRERO MACRINA", FechaRegistro = "16/11/2004", Promedio = "7.8", UnidadOperativa = unidad, CirculoEstudio = ce1, Estatus = "Completo" });
                alumnos.Add(new SIGA_ITEA.Models.AlumnoMock { RFE = "PEPZ-780518-CTA", Nombre = "PEREZ PEREZ ZERAFIN", FechaRegistro = "06/03/2025", Promedio = "8.4", UnidadOperativa = unidad, CirculoEstudio = ce1, Estatus = "Completo" });
                alumnos.Add(new SIGA_ITEA.Models.AlumnoMock { RFE = "RELR-811221-EH0", Nombre = "RESENDEZ LOPEZ RAMIRO", FechaRegistro = "30/06/2003", Promedio = "8.4", UnidadOperativa = unidad, CirculoEstudio = ce1, Estatus = "Faltan Doc." });
                alumnos.Add(new SIGA_ITEA.Models.AlumnoMock { RFE = "ROCB-090806-AX7", Nombre = "DE LA ROSA DE LA CRUZ BRAYAN ARTU", FechaRegistro = "08/08/2024", Promedio = "9.0", UnidadOperativa = unidad, CirculoEstudio = ce1, Estatus = "Completo" });
                alumnos.Add(new SIGA_ITEA.Models.AlumnoMock { RFE = "SACE-890317-U34", Nombre = "SANTA ROSA CERVANTES ELIZABETH", FechaRegistro = "25/03/2025", Promedio = "8.1", UnidadOperativa = unidad, CirculoEstudio = ce1, Estatus = "Completo" });
                alumnos.Add(new SIGA_ITEA.Models.AlumnoMock { RFE = "TEMJ-790322-GP4", Nombre = "TREVIÑO MARTINEZ JORGE ALBERTO", FechaRegistro = "10/10/2003", Promedio = "7.7", UnidadOperativa = unidad, CirculoEstudio = ce1, Estatus = "Completo" });
                alumnos.Add(new SIGA_ITEA.Models.AlumnoMock { RFE = "TIVB-071029-EC0", Nombre = "TRINIDAD VILLANUEVA BRAULIO USIEL", FechaRegistro = "28/09/2023", Promedio = "0.0", UnidadOperativa = unidad, CirculoEstudio = ce1, Estatus = "Faltan Doc." });
                alumnos.Add(new SIGA_ITEA.Models.AlumnoMock { RFE = "TORG-080804-SU6", Nombre = "TOLENTINO RUBIO GEILY JAQUELINE", FechaRegistro = "06/02/2026", Promedio = "7.0", UnidadOperativa = unidad, CirculoEstudio = ce1, Estatus = "Completo" });
                alumnos.Add(new SIGA_ITEA.Models.AlumnoMock { RFE = "VEMN-800719-V61", Nombre = "VEGA MENDEZ NESTOR", FechaRegistro = "21/11/2024", Promedio = "7.0", UnidadOperativa = unidad, CirculoEstudio = ce1, Estatus = "Completo" });
            }
            else if (id == 15)
            {
                // Muestreo dinámico de MR 15 basado en el Avance Académico proporcionado
                string unidad = "571 I-28-004-05 ESCUELA PRIMARIA LIC. BENITO JU";
                
                string ce1 = "20090246";
                string ce2 = "20090254";
                string ce3 = "20110026";

                // Círculo 1
                alumnos.Add(new SIGA_ITEA.Models.AlumnoMock { RFE = "NOTK-090205-9W5", Nombre = "NOLASCO TOVAR KIMBERLI JANETH", FechaRegistro = "18/02/2025", Promedio = "8.0", UnidadOperativa = unidad, CirculoEstudio = ce1, Estatus = "Completo" });
                
                // Círculo 2
                alumnos.Add(new SIGA_ITEA.Models.AlumnoMock { RFE = "CARM-100704-M84", Nombre = "CASTILLO RODRIGUEZ MARCOS", FechaRegistro = "06/10/2025", Promedio = "8.3", UnidadOperativa = unidad, CirculoEstudio = ce2, Estatus = "Completo" });
                alumnos.Add(new SIGA_ITEA.Models.AlumnoMock { RFE = "CASB-050815-279", Nombre = "CHAVARRIA SOTO BRANDOL GAEL", FechaRegistro = "24/04/2026", Promedio = "6.6", UnidadOperativa = unidad, CirculoEstudio = ce2, Estatus = "Faltan Doc." });
                alumnos.Add(new SIGA_ITEA.Models.AlumnoMock { RFE = "EUDL-730617-UV1", Nombre = "ESTUDILLO DON JUAN JOSE LUIS", FechaRegistro = "20/11/2025", Promedio = "7.7", UnidadOperativa = unidad, CirculoEstudio = ce2, Estatus = "Completo" });
                alumnos.Add(new SIGA_ITEA.Models.AlumnoMock { RFE = "HEMA-080915-7W7", Nombre = "HERNANDEZ MARTINEZ ALEXANDER DE", FechaRegistro = "07/11/2025", Promedio = "7.3", UnidadOperativa = unidad, CirculoEstudio = ce2, Estatus = "Completo" });
                alumnos.Add(new SIGA_ITEA.Models.AlumnoMock { RFE = "MAGG-060515-R9A", Nombre = "MARQUEZ GARCIA GRECIA DEL ANGEL", FechaRegistro = "09/01/2026", Promedio = "6.8", UnidadOperativa = unidad, CirculoEstudio = ce2, Estatus = "Faltan Doc." });
                alumnos.Add(new SIGA_ITEA.Models.AlumnoMock { RFE = "NICL-780209-223", Nombre = "NICOLAS CRUZ LIDIA", FechaRegistro = "24/04/2026", Promedio = "6.3", UnidadOperativa = unidad, CirculoEstudio = ce2, Estatus = "Completo" });
                alumnos.Add(new SIGA_ITEA.Models.AlumnoMock { RFE = "OIMA-081229-HR3", Nombre = "OLIVEROS MARTINEZ AXEL MANUEL", FechaRegistro = "13/01/2026", Promedio = "0.0", UnidadOperativa = unidad, CirculoEstudio = ce2, Estatus = "Faltan Doc." });
                alumnos.Add(new SIGA_ITEA.Models.AlumnoMock { RFE = "ZAEC-071209-M73", Nombre = "ZAMORA ESCALERA CRISTOPHER ADRI", FechaRegistro = "13/03/2024", Promedio = "9.0", UnidadOperativa = unidad, CirculoEstudio = ce2, Estatus = "Completo" });
                
                // Círculo 3
                alumnos.Add(new SIGA_ITEA.Models.AlumnoMock { RFE = "CUHF-080828-QC9", Nombre = "CRUZ HERNANDEZ FRANCISCO", FechaRegistro = "15/07/2025", Promedio = "7.4", UnidadOperativa = unidad, CirculoEstudio = ce3, Estatus = "Completo" });
                alumnos.Add(new SIGA_ITEA.Models.AlumnoMock { RFE = "CUHH-100512-890", Nombre = "CRUZ HERNANDEZ HIROMI MADAI", FechaRegistro = "15/07/2025", Promedio = "8.8", UnidadOperativa = unidad, CirculoEstudio = ce3, Estatus = "Completo" });
            }

            return View(alumnos);
        }

        public ActionResult AlumnosInformatica()
        {
            if (Session["Usuario"] == null) return RedirectToAction("Login");
            
            var alumnos = new List<SIGA_ITEA.Models.AlumnoMock>();
            string unidad7 = "385 ESC. SAN VALENTIN";
            string ce1_7 = "20090235";
            
            alumnos.Add(new SIGA_ITEA.Models.AlumnoMock { RFE = "AARG-000105-BQ5", Nombre = "ALVAREZ REYES GABRIELA LIZETH", FechaRegistro = "24/04/2026", Promedio = "8.5", UnidadOperativa = unidad7, CirculoEstudio = ce1_7, Estatus = "Completo" });
            alumnos.Add(new SIGA_ITEA.Models.AlumnoMock { RFE = "AASL-951214-7K0", Nombre = "AMADOR SAENZ JOSE LUIS", FechaRegistro = "20/11/2025", Promedio = "8.2", UnidadOperativa = unidad7, CirculoEstudio = ce1_7, Estatus = "Completo" });
            alumnos.Add(new SIGA_ITEA.Models.AlumnoMock { RFE = "BAAL-100817-7Q0", Nombre = "BALDERAS ANTONIO LUZDARY NICOLE", FechaRegistro = "06/02/2026", Promedio = "6.8", UnidadOperativa = unidad7, CirculoEstudio = ce1_7, Estatus = "Faltan Doc." });
            alumnos.Add(new SIGA_ITEA.Models.AlumnoMock { RFE = "CARO-100228-DE1", Nombre = "CASTELLANOS RAMOS OSCAR EDUARD", FechaRegistro = "04/10/2022", Promedio = "8.2", UnidadOperativa = unidad7, CirculoEstudio = ce1_7, Estatus = "Completo" });
            alumnos.Add(new SIGA_ITEA.Models.AlumnoMock { RFE = "CERA-090909-MLA", Nombre = "CERDA RAMIREZ JOSE ANGEL", FechaRegistro = "03/10/2024", Promedio = "8.3", UnidadOperativa = unidad7, CirculoEstudio = ce1_7, Estatus = "Completo" });
            alumnos.Add(new SIGA_ITEA.Models.AlumnoMock { RFE = "CUDD-080328-UT8", Nombre = "CRUZ DOMINGUEZ DEISY JOSELYN", FechaRegistro = "25/02/2026", Promedio = "7.0", UnidadOperativa = unidad7, CirculoEstudio = ce1_7, Estatus = "Faltan Doc." });
            alumnos.Add(new SIGA_ITEA.Models.AlumnoMock { RFE = "CUGE-091220-SB2", Nombre = "CRUZ GONZALEZ EDSON DANIEL", FechaRegistro = "15/08/2025", Promedio = "0.0", UnidadOperativa = unidad7, CirculoEstudio = ce1_7, Estatus = "Faltan Doc." });
            alumnos.Add(new SIGA_ITEA.Models.AlumnoMock { RFE = "CUMO-110124-LV3", Nombre = "CRUZ MARCIAL OSMAR ARTURO", FechaRegistro = "19/10/2022", Promedio = "9.3", UnidadOperativa = unidad7, CirculoEstudio = ce1_7, Estatus = "Completo" });
            alumnos.Add(new SIGA_ITEA.Models.AlumnoMock { RFE = "GAGB-091102-AB0", Nombre = "GALICIA GARCIA BRAYAN ALEXANDER", FechaRegistro = "17/04/2026", Promedio = "8.0", UnidadOperativa = unidad7, CirculoEstudio = ce1_7, Estatus = "Completo" });
            alumnos.Add(new SIGA_ITEA.Models.AlumnoMock { RFE = "HESC-080305-3A9", Nombre = "HERNANDEZ SANTIAGO CARLOS DANIE", FechaRegistro = "16/08/2021", Promedio = "8.0", UnidadOperativa = unidad7, CirculoEstudio = ce1_7, Estatus = "Completo" });
            alumnos.Add(new SIGA_ITEA.Models.AlumnoMock { RFE = "HESR-090214-7Q9", Nombre = "HERNANDEZ SANTIAGO RICARDO DAVI", FechaRegistro = "16/08/2021", Promedio = "8.5", UnidadOperativa = unidad7, CirculoEstudio = ce1_7, Estatus = "Completo" });
            alumnos.Add(new SIGA_ITEA.Models.AlumnoMock { RFE = "JUAD-080813-T6A", Nombre = "JUAREZ AVELINO DINA YELITZA", FechaRegistro = "26/10/2023", Promedio = "7.5", UnidadOperativa = unidad7, CirculoEstudio = ce1_7, Estatus = "Faltan Doc." });
            alumnos.Add(new SIGA_ITEA.Models.AlumnoMock { RFE = "JUAO-100927-467", Nombre = "JUAREZ AVELINO OSCAR ODIN", FechaRegistro = "24/04/2026", Promedio = "6.8", UnidadOperativa = unidad7, CirculoEstudio = ce1_7, Estatus = "Completo" });
            alumnos.Add(new SIGA_ITEA.Models.AlumnoMock { RFE = "LOOA-041203-TN8", Nombre = "LOPEZ OLVERA ALAN ULISES", FechaRegistro = "17/03/2021", Promedio = "7.1", UnidadOperativa = unidad7, CirculoEstudio = ce1_7, Estatus = "Completo" });
            alumnos.Add(new SIGA_ITEA.Models.AlumnoMock { RFE = "LOSK-060804-T20", Nombre = "LOPEZ SANTIAGO KATHIA YAEL", FechaRegistro = "24/04/2026", Promedio = "6.7", UnidadOperativa = unidad7, CirculoEstudio = ce1_7, Estatus = "Faltan Doc." });
            alumnos.Add(new SIGA_ITEA.Models.AlumnoMock { RFE = "LUMV-081002-UT2", Nombre = "LUNA MARTINEZ VANESSA YAMILETH", FechaRegistro = "08/02/2024", Promedio = "7.2", UnidadOperativa = unidad7, CirculoEstudio = ce1_7, Estatus = "Completo" });
            alumnos.Add(new SIGA_ITEA.Models.AlumnoMock { RFE = "MABA-101003-P63", Nombre = "MALDONADO BARRON ANA KARINA", FechaRegistro = "03/10/2025", Promedio = "7.7", UnidadOperativa = unidad7, CirculoEstudio = ce1_7, Estatus = "Completo" });
            alumnos.Add(new SIGA_ITEA.Models.AlumnoMock { RFE = "MACN-870621-T25", Nombre = "MATEO CORRO NANCY", FechaRegistro = "17/08/2005", Promedio = "8.8", UnidadOperativa = unidad7, CirculoEstudio = ce1_7, Estatus = "Completo" });
            alumnos.Add(new SIGA_ITEA.Models.AlumnoMock { RFE = "MEPL-900829-DF5", Nombre = "MEJIA PEREZ JOSE LUIS", FechaRegistro = "27/03/2026", Promedio = "7.5", UnidadOperativa = unidad7, CirculoEstudio = ce1_7, Estatus = "Completo" });
            alumnos.Add(new SIGA_ITEA.Models.AlumnoMock { RFE = "MESE-080713-254", Nombre = "MEJIA SANTIAGO ENRIQUE MARTIN", FechaRegistro = "04/03/2020", Promedio = "8.6", UnidadOperativa = unidad7, CirculoEstudio = ce1_7, Estatus = "Completo" });
            alumnos.Add(new SIGA_ITEA.Models.AlumnoMock { RFE = "MOCM-081007-K2A", Nombre = "MORALES CASTILLO MARCO ANTONIO", FechaRegistro = "16/10/2024", Promedio = "7.3", UnidadOperativa = unidad7, CirculoEstudio = ce1_7, Estatus = "Faltan Doc." });
            alumnos.Add(new SIGA_ITEA.Models.AlumnoMock { RFE = "OEDP-081223-KI3", Nombre = "ORTEGON DOMINGUEZ PEDRO ARTURO", FechaRegistro = "22/11/2024", Promedio = "8.0", UnidadOperativa = unidad7, CirculoEstudio = ce1_7, Estatus = "Completo" });
            alumnos.Add(new SIGA_ITEA.Models.AlumnoMock { RFE = "OIVS-811215-IT9", Nombre = "ORTIZ VALDEZ SOLEDAD", FechaRegistro = "20/11/2007", Promedio = "8.8", UnidadOperativa = unidad7, CirculoEstudio = ce1_7, Estatus = "Completo" });
            alumnos.Add(new SIGA_ITEA.Models.AlumnoMock { RFE = "PEGM-740719-PW8", Nombre = "PEREZ GUERRERO MACRINA", FechaRegistro = "16/11/2004", Promedio = "7.8", UnidadOperativa = unidad7, CirculoEstudio = ce1_7, Estatus = "Completo" });
            alumnos.Add(new SIGA_ITEA.Models.AlumnoMock { RFE = "PEPZ-780518-CTA", Nombre = "PEREZ PEREZ ZERAFIN", FechaRegistro = "06/03/2025", Promedio = "8.4", UnidadOperativa = unidad7, CirculoEstudio = ce1_7, Estatus = "Completo" });
            alumnos.Add(new SIGA_ITEA.Models.AlumnoMock { RFE = "RELR-811221-EH0", Nombre = "RESENDEZ LOPEZ RAMIRO", FechaRegistro = "30/06/2003", Promedio = "8.4", UnidadOperativa = unidad7, CirculoEstudio = ce1_7, Estatus = "Faltan Doc." });
            alumnos.Add(new SIGA_ITEA.Models.AlumnoMock { RFE = "ROCB-090806-AX7", Nombre = "DE LA ROSA DE LA CRUZ BRAYAN ARTU", FechaRegistro = "08/08/2024", Promedio = "9.0", UnidadOperativa = unidad7, CirculoEstudio = ce1_7, Estatus = "Completo" });
            alumnos.Add(new SIGA_ITEA.Models.AlumnoMock { RFE = "SACE-890317-U34", Nombre = "SANTA ROSA CERVANTES ELIZABETH", FechaRegistro = "25/03/2025", Promedio = "8.1", UnidadOperativa = unidad7, CirculoEstudio = ce1_7, Estatus = "Completo" });
            alumnos.Add(new SIGA_ITEA.Models.AlumnoMock { RFE = "TEMJ-790322-GP4", Nombre = "TREVIÑO MARTINEZ JORGE ALBERTO", FechaRegistro = "10/10/2003", Promedio = "7.7", UnidadOperativa = unidad7, CirculoEstudio = ce1_7, Estatus = "Completo" });
            alumnos.Add(new SIGA_ITEA.Models.AlumnoMock { RFE = "TIVB-071029-EC0", Nombre = "TRINIDAD VILLANUEVA BRAULIO USIEL", FechaRegistro = "28/09/2023", Promedio = "0.0", UnidadOperativa = unidad7, CirculoEstudio = ce1_7, Estatus = "Faltan Doc." });
            alumnos.Add(new SIGA_ITEA.Models.AlumnoMock { RFE = "TORG-080804-SU6", Nombre = "TOLENTINO RUBIO GEILY JAQUELINE", FechaRegistro = "06/02/2026", Promedio = "7.0", UnidadOperativa = unidad7, CirculoEstudio = ce1_7, Estatus = "Completo" });
            alumnos.Add(new SIGA_ITEA.Models.AlumnoMock { RFE = "VEMN-800719-V61", Nombre = "VEGA MENDEZ NESTOR", FechaRegistro = "21/11/2024", Promedio = "7.0", UnidadOperativa = unidad7, CirculoEstudio = ce1_7, Estatus = "Completo" });
            
            string unidad15 = "571 I-28-004-05 ESCUELA PRIMARIA LIC. BENITO JU";
            string ce1_15 = "20090246";
            string ce2_15 = "20090254";
            string ce3_15 = "20110026";

            alumnos.Add(new SIGA_ITEA.Models.AlumnoMock { RFE = "NOTK-090205-9W5", Nombre = "NOLASCO TOVAR KIMBERLI JANETH", FechaRegistro = "18/02/2025", Promedio = "8.0", UnidadOperativa = unidad15, CirculoEstudio = ce1_15, Estatus = "Completo" });
            alumnos.Add(new SIGA_ITEA.Models.AlumnoMock { RFE = "CARM-100704-M84", Nombre = "CASTILLO RODRIGUEZ MARCOS", FechaRegistro = "06/10/2025", Promedio = "8.3", UnidadOperativa = unidad15, CirculoEstudio = ce2_15, Estatus = "Completo" });
            alumnos.Add(new SIGA_ITEA.Models.AlumnoMock { RFE = "CASB-050815-279", Nombre = "CHAVARRIA SOTO BRANDOL GAEL", FechaRegistro = "24/04/2026", Promedio = "6.6", UnidadOperativa = unidad15, CirculoEstudio = ce2_15, Estatus = "Faltan Doc." });
            alumnos.Add(new SIGA_ITEA.Models.AlumnoMock { RFE = "EUDL-730617-UV1", Nombre = "ESTUDILLO DON JUAN JOSE LUIS", FechaRegistro = "20/11/2025", Promedio = "7.7", UnidadOperativa = unidad15, CirculoEstudio = ce2_15, Estatus = "Completo" });
            alumnos.Add(new SIGA_ITEA.Models.AlumnoMock { RFE = "HEMA-080915-7W7", Nombre = "HERNANDEZ MARTINEZ ALEXANDER DE", FechaRegistro = "07/11/2025", Promedio = "7.3", UnidadOperativa = unidad15, CirculoEstudio = ce2_15, Estatus = "Completo" });
            alumnos.Add(new SIGA_ITEA.Models.AlumnoMock { RFE = "MAGG-060515-R9A", Nombre = "MARQUEZ GARCIA GRECIA DEL ANGEL", FechaRegistro = "09/01/2026", Promedio = "6.8", UnidadOperativa = unidad15, CirculoEstudio = ce2_15, Estatus = "Faltan Doc." });
            alumnos.Add(new SIGA_ITEA.Models.AlumnoMock { RFE = "NICL-780209-223", Nombre = "NICOLAS CRUZ LIDIA", FechaRegistro = "24/04/2026", Promedio = "6.3", UnidadOperativa = unidad15, CirculoEstudio = ce2_15, Estatus = "Completo" });
            alumnos.Add(new SIGA_ITEA.Models.AlumnoMock { RFE = "OIMA-081229-HR3", Nombre = "OLIVEROS MARTINEZ AXEL MANUEL", FechaRegistro = "13/01/2026", Promedio = "0.0", UnidadOperativa = unidad15, CirculoEstudio = ce2_15, Estatus = "Faltan Doc." });
            alumnos.Add(new SIGA_ITEA.Models.AlumnoMock { RFE = "ZAEC-071209-M73", Nombre = "ZAMORA ESCALERA CRISTOPHER ADRI", FechaRegistro = "13/03/2024", Promedio = "9.0", UnidadOperativa = unidad15, CirculoEstudio = ce2_15, Estatus = "Completo" });
            alumnos.Add(new SIGA_ITEA.Models.AlumnoMock { RFE = "CUHF-080828-QC9", Nombre = "CRUZ HERNANDEZ FRANCISCO", FechaRegistro = "15/07/2025", Promedio = "7.4", UnidadOperativa = unidad15, CirculoEstudio = ce3_15, Estatus = "Completo" });
            alumnos.Add(new SIGA_ITEA.Models.AlumnoMock { RFE = "CUHH-100512-890", Nombre = "CRUZ HERNANDEZ HIROMI MADAI", FechaRegistro = "15/07/2025", Promedio = "8.8", UnidadOperativa = unidad15, CirculoEstudio = ce3_15, Estatus = "Completo" });

            return View(alumnos);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Página de información del Sistema Integral de Gestión de Adultos (SIGA).";
            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Contacto del Instituto Tamaulipeco para la Educación de los Adultos.";
            return View();
        }

        // GET: Account/Login
        public ActionResult Login()
        {
            // Clear session upon going to Login page
            Session.Clear();
            return View();
        }

        [HttpPost]
        public ActionResult Login(string usuario, string password)
        {
            if (!string.IsNullOrEmpty(usuario))
            {
                FormsAuthentication.SetAuthCookie(usuario, false);
                Session["Usuario"] = usuario;
                
                // Mapeo solicitado:
                // Si entra con "admin", el rol será "Asesor Educativo" (solo ve ese Header)
                // Si entra con "admin-rol" o escribe directamente otro rol, se asigna diferente para ver los otros Headers
                string userLower = usuario.ToLower();
                if (userLower == "admin")
                {
                    Session["Rol"] = "Asesor Educativo";
                }
                else if (userLower == "admin2")
                {
                    Session["Rol"] = "Área de Informática";
                }
                else if (userLower == "admin-rol" || userLower == "administrador")
                {
                    Session["Rol"] = "admin";
                }
                else if (userLower == "tecnico")
                {
                    Session["Rol"] = "Técnico Docente";
                }
                else if (userLower == "aplicador")
                {
                    Session["Rol"] = "Aplicador de Plaza";
                }
                else if (userLower == "acreditacion")
                {
                    Session["Rol"] = "Área de Acreditación";
                }
                else if (userLower == "planeacion")
                {
                    Session["Rol"] = "Área de Planeación";
                }
                else if (userLower == "coordinador")
                {
                    Session["Rol"] = "Coordinador de Zona";
                }
                else if (userLower == "finanzas")
                {
                    Session["Rol"] = "Área Financiera";
                }
                else
                {
                    Session["Rol"] = usuario; // Mapea el texto del input directo
                }
                
                if (userLower == "admin2")
                {
                    return RedirectToAction("AlumnosInformatica", "Home");
                }

                return RedirectToAction("Index", "Home");
            }
            ModelState.AddModelError("", "Usuario inválido");
            return View();
        }
    }
}