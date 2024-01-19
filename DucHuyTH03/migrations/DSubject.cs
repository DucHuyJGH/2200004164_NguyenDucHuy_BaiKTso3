using System;
using System.Collections.Generic;

namespace DucHuyTH03.migrations;

public partial class DSubject
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public string Description { get; set; } = null!;

    public int Status { get; set; }

    public DateTime? CreatedAt { get; set; }

    public string CreatedBy { get; set; } = null!;

    public DateTime? UpdatedAt { get; set; }

    public string UpdatedBy { get; set; } = null!;

    public virtual ICollection<DStudentMark> DStudentMarks { get; set; } = new List<DStudentMark>();
}
