﻿using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace TiendaOnline.web.Models
{
    public class Department
    {
        public int Id { get; set; }
        [MaxLength(50)]
        [Required]
        public string Name { get; set; }
        public ICollection<City> Cities { get; set; }
        [DisplayName("Cities Number")]
        public int CitiesNumber => Cities == null ? 0 : Cities.Count;
        [JsonIgnore] //lo ignora en la respuesta json
        [NotMapped] //no se crea en la base de datos
        public int IdCountry { get; set; }
    }
}
