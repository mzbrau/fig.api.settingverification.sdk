using System.ComponentModel;

namespace Fig.Api.SettingVerification.Sdk;

public static class ObjectArrayExtensionMethods
{
    public static T IndexAs<T>(this object[] parameters, int index)
    {
        if (parameters.Length <= index)
            throw new IndexOutOfRangeException($"Less than {index} parameters supplied");

        var value = parameters[index];

        if (value is T valueAsT)
            return valueAsT;
        
        return (T)TypeDescriptor.GetConverter(typeof(T)).ConvertFrom(value);
    }
}