namespace QLCHBanHoaQuaWF.Attributes;

[AttributeUsage(AttributeTargets.Property)]
public class PermissionGroupAttribute : Attribute
{
    public string GroupName { get; set; }

    public PermissionGroupAttribute()
    {
        
    }

    public PermissionGroupAttribute(string groupName)
    {
        GroupName = groupName;
    }
}