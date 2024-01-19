using System;
using System.Collections.Generic;

namespace DucHuyTH03.migrations;

public partial class DStudentMark
{
    public int Id { get; set; }

    public string StudentId { get; set; } = null!;

    public int Studentid1 { get; set; }

    public string SubjectId { get; set; } = null!;

    public int? Subjectid1 { get; set; }

    public decimal Mark { get; set; }

    public int Status { get; set; }

    public DateTime? CreatedAt { get; set; }

    public string CreatedBy { get; set; } = null!;

    public DateTime? UpdatedAt { get; set; }

    public string UpdatedBy { get; set; } = null!;

    public virtual DStudent Studentid1Navigation { get; set; } = null!;

    public virtual DSubject? Subjectid1Navigation { get; set; }
}
