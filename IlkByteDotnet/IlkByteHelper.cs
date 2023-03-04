using System;
using System.ComponentModel;
using Newtonsoft.Json;

namespace IlkByteDotnet;

public static class IlkByteHelper
{
    public static string GetEnumDescription(this System.Enum enumValue)
    {
        var field = enumValue.GetType().GetField(enumValue.ToString());
        if (Attribute.GetCustomAttribute(field, typeof(DescriptionAttribute)) is DescriptionAttribute attribute)
        {
            return attribute.Description;
        }
        throw new ArgumentException("Item not found.", nameof(enumValue));
    }

    public static async Task<T?> GetService<T>(string url)
    {
        using var httpClient = new HttpClient();
        using var response = await httpClient.GetAsync(url);

        string result = await response.Content.ReadAsStringAsync();

        if (string.IsNullOrWhiteSpace(result) || !response.IsSuccessStatusCode)
        {
            response.EnsureSuccessStatusCode();
            return default(T);
        }

        return JsonConvert.DeserializeObject<T>(result);
    }
}