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
    public static bool GetEnumDecryption(Enum value, out string decryptionAsString)
    {

        Type Type = value.GetType();
        FieldInfo field = Type.GetField(value.ToString());
        string name = value.ToString();

        if ((field != null) && (name != null))
        {

            decryptionAsString = Attribute.GetCustomAttribute(field, typeof(DescriptionAttribute)) is not DescriptionAttribute attribute ? name : attribute.Description;
            return true;
        }
        else
        {

            decryptionAsString = name;
        }

        return false;

    }//end of GetEnumDecryption

}//end of class

