using UnityEngine;
using Zenject;

public class UntitledInstaller : MonoInstaller
{
    [SerializeField] GameObject hogeObj;
    IOnButton onButton;
    private void Awake()
    {
        
    }
    public override void InstallBindings()
    {
        Container
           .Bind<IOnButton>()
           .To<Hoge>()
           .FromComponentOn(hogeObj)
           .AsCached();
    }
}