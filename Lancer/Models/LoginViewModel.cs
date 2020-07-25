using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Security.Policy;
using System.Text.RegularExpressions;
using Microsoft.AspNetCore.Mvc;
namespace Lancer.Models
    {
    [BindProperties]
    public class LoginViewModel: Attribute
    {

        public long Id { get; set; }

        public string _key;

        public string ShowRequestId
        {
            get
            {
                if (_key == null)
                {
                    _key = Regex.Replace(Password.ToLower(), "[^a-z0-9]", "-");
                }
                return _key;
            }
            set { _key = value; }
        }
        [Required]
        [Display(Name = "Email Address")]
        [DataType(DataType.EmailAddress)]
        public string EmailAddress { get; set; }

        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Display(Name = "Remember Me")]
        public bool RememberMe { get; set; }
    }

}