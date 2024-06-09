using Microsoft.Extensions.Options;
using System.Numerics;
using System.Text.Json;
using VottunERC20API.NET.json;

namespace VottunERC20API.NET.Tests
{
    public class Tests
    {
        static public JsonSerializerOptions NewJsonOptions()
        {
            JsonSerializerOptions options = new JsonSerializerOptions();
            options.Converters.Add(new BigIntegerConverter());
            options.TypeInfoResolver = new AppJsonSerializerContext();
            return options;
        }
        
    

        [SetUp]
        public void Setup()
        {
        }
    

        [Test]
        public void BigIntegerSerializeAndDeserialize_whenULong()
        {
            DeployRequest deployRequest = new DeployRequest();
            BigInteger[] bigIntegers = { 1,100,1000,1000000,1000000000000 };
            for (int i = 0; i < bigIntegers.Length; i++)
            {
                BigInteger bigInteger = bigIntegers[i];

                deployRequest.initialSupply = bigInteger;
                deployRequest.network = 80002;
                deployRequest.name = "TOKen test";
                deployRequest.alias = " token alias";
                deployRequest.symbol = "TOK";

                var options = NewJsonOptions();
                var json = JsonSerializer.Serialize<DeployRequest>(deployRequest, options);
                Console.WriteLine($"{bigInteger} => [{json}]");

                DeployRequest deserialized = JsonSerializer.Deserialize<DeployRequest>(json, options);

                Console.WriteLine($"{bigInteger} => [{deserialized.initialSupply}]");

                Assert.AreEqual(deployRequest.initialSupply, deserialized.initialSupply);
            }
        }

        [Test]
        public void BigIntegerSerializeAndDeserialize_whenBiggerThanULong()
        {
            DeployRequest deployRequest = new DeployRequest();
            BigInteger[] bigIntegers = { BigInteger.Parse("11111111111111111111111111111111111111111111111111111"), BigInteger.Parse("250000000000000000000000000000000000000") };
            for (int i = 0; i < bigIntegers.Length; i++)
            {
                BigInteger bigInteger = bigIntegers[i];

                deployRequest.initialSupply = bigInteger;
                deployRequest.network = 80002;
                deployRequest.name = "TOKen test";
                deployRequest.alias = " token alias";
                deployRequest.symbol = "TOK";

                var options = NewJsonOptions();
                var json = JsonSerializer.Serialize<DeployRequest>(deployRequest, options);
                Console.WriteLine($"{bigInteger} => [{json}]");

                DeployRequest deserialized = JsonSerializer.Deserialize<DeployRequest>(json, options);

                Console.WriteLine($"{bigInteger} => [{deserialized.initialSupply}]");

                Assert.AreEqual(deployRequest.initialSupply, deserialized.initialSupply);
            }
        }


    }
}