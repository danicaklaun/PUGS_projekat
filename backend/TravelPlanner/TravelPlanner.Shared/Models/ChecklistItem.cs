using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class ChecklistItem
{
    public Guid Id { get; set; }

    public Guid TripId { get; set; }

    public string Title { get; set; } = string.Empty;

    public bool IsCompleted { get; set; }
}