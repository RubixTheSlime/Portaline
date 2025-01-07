using Microsoft.Xna.Framework.Input;

namespace Celeste.Mod.Portaline;

[SettingName("PORTALINE_SETTINGS_TITLE")]
public class PortalineModuleSettings : EverestModuleSettings {
  [SettingName("PORTALINE_SETTINGS_OVERRIDE")]
  [SettingSubText("PORTALINE_SETTINGS_OVERRIDE_HINT")]
  public bool PortalGunOverrideEnable { get; set; } = false;

  [SettingName("PORTALINE_SETTINGS_MOUSE_BUTTONS")]
  [SettingSubText("PORTALINE_SETTINGS_MOUSE_BUTTONS_HINT")]
  public bool PortalUseMouseButtons { get; set; } = true;

  [DefaultButtonBinding(Buttons.LeftShoulder, Keys.O)]
  public ButtonBinding ShootBluePortal { get; set; }

  [DefaultButtonBinding(Buttons.RightShoulder, Keys.P)]
  public ButtonBinding ShootOrangePortal { get; set; }

  [DefaultButtonBinding(Buttons.RightStick, Keys.Q)]
  public ButtonBinding RemovePortals { get; set; }
}
