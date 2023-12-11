using Sukuna.Common.Models;
using Sukuna.Common.Resources.Core;

namespace Sukuna.Common.Resources.Role;

public class RoleResource : EntityResource
{
    public string Title { get; set; }
    public string Type { get; set; }
}
