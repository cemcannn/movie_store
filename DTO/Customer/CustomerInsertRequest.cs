using Models.Common;
using Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO.Customer
{
    public class CustomerInsertRequest
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string ConfirmPassword { get; set; }
        public PermissionEnum Permission { get; set; }
        public ICollection<GenreEnum> FavoriteGenres { get; set; }
    }
}
