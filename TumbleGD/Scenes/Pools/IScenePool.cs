namespace TumbleGD.Scenes.Pools;

public interface IScenePool
{
	IList<IScene> Graphicals { get; }
	
	IList<IScene> Physicals { get; }
	
	IList<IScene> Inputtings { get; }
}