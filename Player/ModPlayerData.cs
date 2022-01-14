using Terraria;
using Terraria.DataStructures;
using Terraria.ModLoader;

namespace TerrariaTestMod.Player
{
  public class ModPlayerData : ModPlayer
  {
    public ModPlayerData()
    {
    }

    public override void Kill(double damage, int hitDirection, bool pvp, PlayerDeathReason damageSource)
    {
      Main.PlaySound(SoundLoader.customSoundType, -1, -1, mod.GetSoundSlot(SoundType.Custom, Sounds.Oof));

      base.Kill(damage, hitDirection, pvp, damageSource);
    }
  }
}