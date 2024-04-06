namespace Without.Systems.Slugify.Test;

[TestFixture]
public class Tests
{
    private static readonly ISlugify _actions = new Slugify();

    [SetUp]
    public void Setup()
    {
    }
    
    [Test]
    [TestCase(
        "simple",
        true,true,true,true,
        ExpectedResult = "simple",
        Description = "Simple slugify")]
    [TestCase(
        "Digital Transformations: Don't solve Problems - Build up Capabilities",
        true,true,true,true,
        ExpectedResult = "digital-transformations-dont-solve-problems-build-up-capabilities")]
    [TestCase(
        "Digital Transformations: Don't solve Problems - Build up Capabilities",
        true,true,false,true,
        ExpectedResult = "Digital-Transformations-Dont-solve-Problems-Build-up-Capabilities")]
    [TestCase(
        "Digital Transformations: Don't solve Problems ---- Build up Capabilities",
        true,true,true,true,
        ExpectedResult = "digital-transformations-dont-solve-problems-build-up-capabilities")]
    public string Slugify_Multiple_Tests(
        string sourceText,
        bool collapseWhiteSpace,
        bool trimWhiteSpace,
        bool forceLowerCase,
        bool collapseDashes)
    {
        string result = _actions.GenerateSlug(sourceText, forceLowerCase, collapseWhiteSpace, trimWhiteSpace, collapseDashes);
        return result;

    }
}