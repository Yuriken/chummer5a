using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace ChummerHub.Models.V1
{
    //[DebuggerDisplay("SINnerExtended {Id}")]
    //public class SINnerExtended
    //{
    //    [Key]
    //    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    //    public Guid? Id { get; set; }

    //    public Guid? SINnerId { get; set; }

    //    public String JsonSummary { get; set; }

    //    public SINnerExtended()
    //    {
    //        JsonSummary = "";
    //        Id = Guid.Empty;
    //        SINnerId = Guid.Empty;
    //    }

    //    public SINnerExtended(SINner sinner)
    //    {
    //        JsonSummary = "";
    //        //MySINner = null;
    //        Id = Guid.NewGuid();
    //        SINnerId = sinner.Id;
    //    }

    //}
}
