using Minecraft_Launcher.Components.TabControls.Instances_subTC;

namespace Minecraft_Launcher.Components.TabControls.Instances_subTC.IconsComponent
{
    public abstract class Icons_Read_Component
    {
        public static DialogResult Show()
        {
            DialogResult result;

            using (var box = new Icons_Read())
                result = box.ShowDialog();

            return result;

            
        }
    }
}
