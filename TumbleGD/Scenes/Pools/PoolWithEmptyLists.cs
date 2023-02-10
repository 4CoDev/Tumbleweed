namespace TumbleGD.Scenes.Pools;

public class PoolWithEmptyLists : PoolEnvelope
{
	public PoolWithEmptyLists() : base
	(
		new PoolWithValues(
			new List<IScene>(),
			new List<IScene>(),
			new List<IScene>())
	)
	{
	}
}