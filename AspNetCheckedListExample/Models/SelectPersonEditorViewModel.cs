using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AspNetCheckedListExample.Models
{
    public class SelectPersonEditorViewModel
    {
        public bool Selected { get; set; }
        public int Id { get; set; }
        public string Name { get; set; }
    }
}