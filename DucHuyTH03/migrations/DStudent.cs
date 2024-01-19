using System;
using System.Collections.Generic;

namespace DucHuyTH03.migrations;

public partial class DStudent
{
    public int Id { get; set; }

    public string StudentCode { get; set; } = null!;

    public string Name { get; set; } = null!;

    public DateTime? Birthday { get; set; }

    public string Cccd { get; set; } = null!;

    public int Status { get; set; }

    public DateTime? CreatedAt { get; set; }

    public string CreatedBy { get; set; } = null!;

    public DateTime? UpdatedAt { get; set; }

    public string UpdatedBy { get; set; } = null!;

    public int AddressId { get; set; }

    public int? Addressid1 { get; set; }

    public virtual DAddress? Addressid1Navigation { get; set; }

    public virtual ICollection<DStudentMark> DStudentMarks { get; set; } = new List<DStudentMark>();
}
