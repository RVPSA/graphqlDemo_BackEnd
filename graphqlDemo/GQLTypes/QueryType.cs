using BusinessObjects.BusinessObjects.TestObject;

namespace graphqlDemo.GQLTypes
{
    public class QueryType
    {
        public TestObject testmethod() {
            TestObject _test = new TestObject();
            _test.index = 0;
            _test.description = "test";
            _test.name = "testClass";

            return _test;
        }

    }
}
