using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using Amazon.Lambda.Core;

// Assembly attribute to enable the Lambda function's JSON input to be converted into a .NET class.
[assembly: LambdaSerializer(typeof(Amazon.Lambda.Serialization.SystemTextJson.DefaultLambdaJsonSerializer))]

namespace Assignment10Test
{
    public enum Condition { EXCELLENT, GOOD, FAIR, BAD };
    public class Car
    {
        public Condition Condition;
        public string Make;
        public int Speed = 0;

        public Car(string make, Condition condition)
        {
            this.Make = make;
            this.Condition = condition;
        }
    }
}
