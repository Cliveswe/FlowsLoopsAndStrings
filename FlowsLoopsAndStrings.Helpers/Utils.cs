using System.ComponentModel;
using System.Reflection;

namespace FlowsLoopsAndStrings.Helpers;
public static class Utils
{
    /// <summary>
    /// Get the decryption from a Enum class.
    /// </summary>
    /// <param name="value">An enum member.</param>
    /// <returns>The enum decryption as a string.</returns>
    public static string GetEnumDecryption(Enum value)
    {
        string res = value.ToString();

        FieldInfo? field = value.GetType().GetField(value.ToString());
        string name = value.ToString();

        if (field != null)
        {
            res = Attribute.GetCustomAttribute(field, typeof(DescriptionAttribute)) is not DescriptionAttribute attribute ? name : attribute.Description;
        }
        else
        {
            res = name;
        }
        //return Attribute.GetCustomAttribute(field, typeof(DescriptionAttribute)) is not DescriptionAttribute attribute ? name : attribute.Description;
        return res;

    }
}//end of class

