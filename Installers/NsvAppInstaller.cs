using IPA.Logging;
using SliceVisualizer.Configuration;
using SliceVisualizer.UI;
using Zenject;

namespace SliceVisualizer.Installers
{
    internal class NsvAppInstaller : Installer<PluginConfig, NsvAppInstaller>
    {
        private readonly PluginConfig _config;

        public NsvAppInstaller()
        {
            _config = PluginConfig.Instance;
            SettingsUI.CreateMenu();
        }

        public override void InstallBindings()
        {
            Container.BindInstance(_config).AsSingle();

            Container.BindInterfacesAndSelfTo<NsvAssetLoader>().AsSingle().Lazy();
        }
    }
}