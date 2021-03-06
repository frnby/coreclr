using System;
/// <summary>
///Property
/// </summary>

public class AttributeTargetsProperty
{
    public static int Main()
    {
        AttributeTargetsProperty AttributeTargetsProperty = new AttributeTargetsProperty();

        TestLibrary.TestFramework.BeginTestCase("AttributeTargetsProperty");
        if (AttributeTargetsProperty.RunTests())
        {
            TestLibrary.TestFramework.EndTestCase();
            TestLibrary.TestFramework.LogInformation("PASS");
            return 100;
        }
        else
        {
            TestLibrary.TestFramework.EndTestCase();
            TestLibrary.TestFramework.LogInformation("FAIL");
            return 0;
        }
    }
    public bool RunTests()
    {
        bool retVal = true;
       TestLibrary.TestFramework.LogInformation("[Positive]");
        retVal = PosTest1() && retVal;
      
        return retVal;
    }
    // Returns true if the expected result is right
    // Returns false if the expected result is wrong

    public bool PosTest1()
    {
        bool retVal = true;
        TestLibrary.TestFramework.BeginScenario("PosTest1: Verify the AttributeTargets.Property value is 0x0080. ");
        try
        {
            int expectValue = 0x0080;
            if ((int)AttributeTargets.Property != expectValue)
            {
                TestLibrary.TestFramework.LogError("001.1", " AttributeTargets.Property should return 0x0080.");
                retVal = false;
            }
           
        }
        catch (Exception e)
        {
            TestLibrary.TestFramework.LogError("001.0", "Unexpected exception: " + e);
            retVal = false;
        }
       
        return retVal;
    }
   
}

