using System;
using Newtonsoft.Json;
using NUnit.Framework;

namespace Problems.Tests
{
    public class CopyListWithRandomPointerProblemTests
    {
        [Test]
        public void CopyRandomListTest1()
        {
            var next = new CopyListWithRandomPointerProblem.Node();
            next.val = 2;
            next.random = next;
            var result = CopyListWithRandomPointerProblem
                .CopyRandomList(new CopyListWithRandomPointerProblem.Node(1, next, next));

            Console.Write(JsonConvert.SerializeObject(result, new JsonSerializerSettings{ReferenceLoopHandling = ReferenceLoopHandling.Ignore}));
        }
    }
}