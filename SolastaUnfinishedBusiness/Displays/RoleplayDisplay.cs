using SolastaUnfinishedBusiness.Api.ModKit;
using SolastaUnfinishedBusiness.Models;

namespace SolastaUnfinishedBusiness.Displays;
/// <summary>
/// TODO: Make this its own tab for rules. I have a dayjob :(
/// </summary>
internal static partial class RulesDisplay
{
    internal static void ExtendedDisplay()
    {
        bool toggle = false;

        toggle = Main.Settings.EnableCriticalHitsMissesAt10;
        if (UI.Toggle(Gui.Localize("ModUI/&EnableCriticalHitsMissesAt10"), ref toggle,
                UI.AutoWidth()))
        {
            Main.Settings.EnableCriticalHitsMissesAt10 = toggle;
        }

        toggle = Main.Settings.ModifyJumpRulesForArmorAndEncumberance;
        if (UI.Toggle(Gui.Localize("ModUI/&ModifyJumpRulesForArmorAndEncumberance"), ref toggle,
                UI.AutoWidth()))
        {
            Main.Settings.ModifyJumpRulesForArmorAndEncumberance = toggle;
        }

        toggle = Main.Settings.ModifyThrowingRulesForStrength;
        if (UI.Toggle(Gui.Localize("ModUI/&ModifyThrowingRulesForStrength"), ref toggle,
                UI.AutoWidth()))
        {
            Main.Settings.ModifyThrowingRulesForStrength = toggle;
        }
    }
}
