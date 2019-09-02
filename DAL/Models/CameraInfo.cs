using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class CameraInfo
    {
        public int Id { get; set; }
        public string ImageUnicId { get; set; }
        public string ImageName { get; set; }
        public string ImageDatatype { get; set; }
        public byte[] ImageDataArray { get; set; }
        public string ImageUrl { get; set; }
        public DateTime? ImageDateTime { get; set; }
        public string Description { get; set; }
        public string MetaData { get; set; }
        public int? CameraId { get; set; }
    }
}
