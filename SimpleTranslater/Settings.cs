using Mutagen.Bethesda.Fallout4;
using Mutagen.Bethesda.Plugins;
using Mutagen.Bethesda.Synthesis.Settings;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleTranslator;

public record Settings
{
    [SynthesisTooltip(@"")]
    public bool ResolveFromOrigin = false;

    [SynthesisTooltip(@"If true, all entities will be translated. If false, only entities patched by synthesis will be translated")]
    public bool PatchAllEntity = false;

    public bool WhiteListMode = false;
    [SynthesisTooltip(@"Referenced mod that translated name comes from (Only available while whitelist mode)")]
    public List<ModKey> WhiteList = new()
    {
    };
    [SynthesisTooltip(@"Referenced Mod That Will Skipped (Available while blacklist mode0")]
    public List<ModKey> BlackList = new();

    public bool IgnorePatchMods = true;
    public List<ModKey> IncludedPatchMods = new List<ModKey>()
    {
    };

    public bool Weapon = true;
    public bool Armor = true;
    public bool Npc = true;
    public bool WorldSpace = true;
    public bool Perk = true;
    public bool Quest = true;
    public bool Container = true;
    public bool Item = true;

    public bool Verbose = true;

    public Dictionary<string, string> CustomDictionary = new()
    {
        { "Horse", "马" },
        { "Skull", "头骨" },
        { "Blackreach", "黑境" }
    };
}
