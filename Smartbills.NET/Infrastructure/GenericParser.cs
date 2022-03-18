using System;
using System.ComponentModel;
using System.Text.Json;

namespace Smartbills.Infrastructure
{
    public class GenericParser
    {

        public static T Parse<T>(string body)
        {
            try
            {
                T obj = JsonSerializer.Deserialize<T>(body);
                return obj;
            }
            catch (Exception exception) when (exception is JsonException || exception is NotSupportedException)
            {

                try
                {
                    TypeConverter conv = TypeDescriptor.GetConverter(typeof(T));
                    return (T)conv.ConvertFromString(body);
                }

                catch
                {
                    return default;
                }
            }
        }
    }
}
