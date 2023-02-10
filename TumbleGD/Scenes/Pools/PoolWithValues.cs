namespace TumbleGD.Scenes.Pools;

public sealed class PoolWithValues : IScenePool
{
	public PoolWithValues
	(
		IEnumerable<IScene> graphicals,
		IEnumerable<IScene> physicals,
		IEnumerable<IScene> inputtings
	)
	{
		Graphicals = new List<IScene>(graphicals);
		Physicals = new List<IScene>(physicals);
		Inputtings = new List<IScene>(inputtings);
	}
	
	public IList<IScene> Graphicals { get; }

	public IList<IScene> Physicals { get; }

	public IList<IScene> Inputtings { get; }
}