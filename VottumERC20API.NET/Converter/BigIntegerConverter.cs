using System;
using System.Numerics;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Globalization;
using System.Text;

public class BigIntegerConverter : JsonConverter<BigInteger>
{
    public override BigInteger Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        // Check if the input is a numeric value
        if (reader.TokenType == JsonTokenType.Number)
        {
            return reader.GetUInt64();
        }
        // Check if the input is a string value
        else if (reader.TokenType == JsonTokenType.String)
        {
            // Try to parse the input as a BigInteger using BigInteger.TryParse
            if (BigInteger.TryParse(reader.GetString(), out BigInteger result))
            {
                return result;
            }
        }

        // If parsing fails, throw a JsonException
        throw new JsonException($"Could not convert \"{reader.GetString()}\" to BigInteger.");
    }


    public override void Write(Utf8JsonWriter writer, BigInteger value, JsonSerializerOptions options)
    {
        // Convertir el valor BigInteger a ulong (si es posible)
        if (value >= ulong.MinValue && value <= ulong.MaxValue)
        {
            writer.WriteNumberValue((ulong)value);
        }
        else
        {
            // Si el valor es demasiado grande para un ulong, escribirlo como cadena
            writer.WriteStringValue(value.ToString(NumberFormatInfo.InvariantInfo));
        }
    }
}