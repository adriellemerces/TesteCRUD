using System.ComponentModel.DataAnnotations;
using System.Xml;

namespace FloressenciaCrud.Model
{
   
        public class Todo
        {
              [Key]
            public int UsuarioId { get; set; }
            public string nome_usuario { get; set; }
            public string email { get; set; }
            public string senha_usuario_hash { get; set; } 
            //public bool data_nascimento { get; set; }
            //public bool foto_perfil { get; set; }
            //public bool data_criacao { get; set; }
            //public bool data_ultimo_acesso { get; set; }
    }
    
}
