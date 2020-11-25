using System;
using System.Collections.Generic;
using System.Web;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.Internal;
using Newtonsoft.Json;

namespace Infrastructure1.Models
{
    public class Response
    {
        public string Title { get; set; }
        [JsonIgnore]
        public FormFile VideoPath { get; set; }
        private string _videoPath1;
        public string VideoPath1
        {
            get
            {
                _videoPath1 = VideoPath.FileName;
                return _videoPath1;
            }
            set
            {
                _videoPath1 = value;
            }
        }
        public string Description { get; set; }
    }
}
