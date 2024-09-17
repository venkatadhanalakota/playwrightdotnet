using System.Text.RegularExpressions;
using Microsoft.Playwright;
using Microsoft.Playwright.NUnit;

namespace playwrighttest;

public class Tests : PageTest
{
    [SetUp]
    public async Task Setup()
    {
        await Page.GotoAsync("https://app-planningregister-planningportal.pp.tqinfra.co.uk/simple-search");
    }

    [Test]
    public async Task AdvancedSearch() 
    {
        await Expect(Page).ToHaveTitleAsync(new Regex("Northern Ireland Public Register"));
        await Page.ClickAsync(selector:"text=Advanced search");
    }
}