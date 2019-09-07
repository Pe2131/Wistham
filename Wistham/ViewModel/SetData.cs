using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Wistham.ViewModel
{
    public class SetData
    {
        [Required]
        public string ImageUnicId { get; set; }
        [Required]
        public string ImageName { get; set; }
        [Required]
        public string ImageDatatype { get; set; }
        [Required]
        public byte[] ImageDataArray { get; set; }
        [Required]
        public string ImageUrl { get; set; }
        [Required]
        public DateTime? ImageDateTime { get; set; }
        [Required]
        public string Description { get; set; }
        [Required]
        public string MetaData { get; set; }
        public int? CameraId { get; set; }
    }
}
