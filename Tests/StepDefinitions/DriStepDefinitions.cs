using Backend.DTOs;
using Backend.Services;

namespace Tests.StepDefinitions;

[Binding]
internal class DriStepDefinitions
{
    private List<DriResponseDto>? result;
    private readonly DriService driService = new();

    [When(@"I request the DRI data")]
    public void WhenIRequestTheDRIData()
    {
        result = driService.GetAll();
    }

    [Then(@"the response should contain (.*) nutrients")]
    public void ThenTheResponseShouldContainNutrients(int expectedCount)
    {
        Assert.NotNull(result);
        Assert.Equal(expectedCount, result.Count);
    }
}
