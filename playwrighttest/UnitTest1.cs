using Microsoft.Playwright;

namespace playwrighttest;

public class Tests
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public async Task Test1()
    {
        //Playwright
        using var playwright = await Playwright.CreateAsync();
        //Choose Browser
        await using var browser = await playwright.Chromium.LaunchAsync(new BrowserTypeLaunchOptions
        {
            Headless = false
        });

        //Now website
        var page = await browser.NewPageAsync();
        //await page.GotoAsync("www.bbc.co.uk");
        await page.GotoAsync("https://app-planningregister-planningportal.pp.tqinfra.co.uk/simple-search");
        //await Expect(page).
        
    }
}