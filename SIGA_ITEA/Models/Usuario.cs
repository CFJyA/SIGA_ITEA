using System;
using System.ComponentModel.DataAnnotations;

namespace SIGA_ITEA.Models
{
    public class Usuario
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [Display(Name = "Nombre")]
        public string Nombre { get; set; }

        [Required]
        [Display(Name = "Apellido Paterno")]
        public string ApellidoPaterno { get; set; }

        [Required]
        [Display(Name = "Apellido Materno")]
        public string ApellidoMaterno { get; set; }

        [DataType(DataType.Date)]
        [Display(Name = "Fecha de Nacimiento")]
        public DateTime FechaNacimiento { get; set; }

        // Domicilio (Opcionales)
        [Display(Name = "Calle")]
        public string Calle { get; set; }

        [Display(Name = "No. Exterior")]
        public string NumeroExterior { get; set; }

        [Display(Name = "No. Interior")]
        public string NumeroInterior { get; set; }

        [Display(Name = "Colonia")]
        public string Colonia { get; set; }

        [Display(Name = "Código Postal")]
        public string CodigoPostal { get; set; }

        // Datos de contacto y acceso
        [Display(Name = "Número")]
        public string Numero { get; set; }

        [Display(Name = "Correo Electrónico")]
        [EmailAddress]
        public string Correo { get; set; }

        [Required]
        [Display(Name = "Usuario (RFC)")]
        public string RFC { get; set; }

        [Required]
        [DataType(DataType.Password)]
        [Display(Name = "Contraseña")]
        public string Contrasena { get; set; }

        // Papelería (Indicadores si los documentos fueron entregados)
        [Display(Name = "CURP")]
        public bool PapeleriaCURP { get; set; }

        [Display(Name = "Acta de Nacimiento")]
        public bool PapeleriaActa { get; set; }

        [Display(Name = "Comprobante de estudio")]
        public bool PapeleriaComprobanteEstudio { get; set; }

        [Display(Name = "Identificación Oficial")]
        public bool PapeleriaIdentificacionOficial { get; set; }

        [Display(Name = "Comprobante de domicilio")]
        public bool PapeleriaComprobanteDomicilio { get; set; }

        [Display(Name = "Estado de cuenta")]
        public bool PapeleriaEstadoCuenta { get; set; }

        // Rol de usuario
        [Required]
        [Display(Name = "Rol")]
        public RolUsuario Rol { get; set; }
    }

    public enum RolUsuario
    {
        [Display(Name = "Técnico Docente")]
        TecnicoDocente,
        
        [Display(Name = "PVS que apoya como aplicador")]
        PVS_Aplicador,
        
        [Display(Name = "PVS que apoya como Territorial")]
        PVS_Territorial,
        
        [Display(Name = "PVS que apoya como Asesor Educativo")]
        PVS_AsesorEducativo,
        
        [Display(Name = "Informática")]
        Informatica,
        
        [Display(Name = "Acreditación")]
        Acreditacion
    }
}
