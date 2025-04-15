using Avalonia;
using Avalonia.Markup.Xaml;
using Blazonia;

namespace BlazoniaDemo;

public class App : AppBase
{
    public override void Initialize()
    {
        AvaloniaXamlLoader.Load(this);
    }

    public override void OnFrameworkInitializationCompleted()
    {
        base.OnFrameworkInitializationCompleted();
#if DEBUG
        this.AttachDevTools();
#endif
    }
}
public class AppBase : BlazoniaApplication<MainPage>
{
}
