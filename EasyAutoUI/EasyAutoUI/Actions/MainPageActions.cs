using EasyAutoUI.Elements;
using EasyAutoUI.Pages;

namespace EasyAutoUI.Actions
{
    public static class MainPageActions
    {
        public static bool SwapLanguagesAction(this MainPage mainPage)
        {
            var enabled = mainPage.LanguageSwapButton.Enabled;
            if (!enabled) return false;
            mainPage.LanguageSwapButton.Click();
            return true;
        }
    }
}
