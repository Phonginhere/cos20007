using SwinAdventure;

namespace TestProjectIdentifiableObject
{
	public class Tests
	{
		private IdentifiableObject _testObject;
		private IdentifiableObject _testObject_null;

		private string[] _testStringArray;
		private string[] _testStringArray_null;

		private string _testStringtext;
		private string _testStringText_null;

		private string _testCondition;
		


		[SetUp]
		public void Setup()
		{
			//value
			_testStringArray = new string[] { "minh", "kien" };
			_testObject = new IdentifiableObject(_testStringArray);
			_testStringtext = "mark";
			_testCondition = "bharat";
			_testObject.AddIdentifier(_testStringtext);

			//null
			_testStringArray_null = new string[] { };
			_testObject_null = new IdentifiableObject(_testStringArray_null);
			_testStringText_null = "";
			_testObject.AddIdentifier(_testStringText_null);
			
		}

		[Test]
		public void TestAreYou()
		{			
			Assert.IsTrue(_testObject.AreYou("minh"));
		}

		[Test]
		public void TestNotAreYou()
		{
			Assert.IsFalse(_testObject.AreYou(_testCondition));
		}

		[Test]
		public void TestCaseSensitive()
		{
			Assert.IsTrue(_testObject.AreYou("kIeN"));
		}


		[Test]
		public void TestFirstID()
		{
			Assert.That("minh".Equals(_testObject.FirstId));
			Assert.That(_testStringtext, Is.Not.EqualTo(_testObject.FirstId));
		}

		[Test]
		public void TestFirstIdWithNoIDs()
		{
			Assert.That(_testStringText_null, Is.EqualTo(_testObject_null.FirstId));
		}

		[Test]
		public void TestAddID()
		{
			_testObject.AddIdentifier(_testStringtext);
			_testObject.AddIdentifier("ali");
			Assert.IsTrue(_testObject.AreYou(_testStringtext));
			Assert.IsTrue(_testObject.AreYou("ali"));
		}
	}
}