using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TravelPlanner.Shared.Enums;

public class ShareLink
{
    public Guid Id { get; set; }

    public Guid TripId { get; set; }

    public string Token { get; set; } = string.Empty;

    public SharePermission Permission { get; set; }

    public DateTime CreatedAt { get; set; }

    public DateTime? ExpiresAt { get; set; }
}