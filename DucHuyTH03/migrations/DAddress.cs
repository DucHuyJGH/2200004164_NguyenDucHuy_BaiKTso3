using System;
using System.Collections.Generic;

namespace DucHuyTH03.migrations;

public partial class DAddress
{
    public int Id { get; set; }

    public int ProvinceId { get; set; }

    public string ProvinceName { get; set; } = null!;

    public int DistrictId { get; set; }

    public string DistrictName { get; set; } = null!;

    public int WardId { get; set; }

    public string WardName { get; set; } = null!;

    public string Number { get; set; } = null!;

    public int Status { get; set; }

    public DateTime? CreatedAt { get; set; }

    public string CreatedBy { get; set; } = null!;

    public DateTime? UpdatedAt { get; set; }

    public virtual ICollection<DStudent> DStudents { get; set; } = new List<DStudent>();
}
