namespace TumbleGD.Scenes.Pools;

public abstract class PoolEnvelope : IScenePool
{
	protected PoolEnvelope(IScenePool pool)
	{
		this.pool = pool;
	}
	
	public IList<IScene> Graphicals
	{
		get => pool.Graphicals;
	}
	
	public IList<IScene> Physicals
	{
		get => pool.Physicals;
	}
	
	public IList<IScene> Inputtings
	{
		get => pool.Inputtings;
	}
	
	private readonly IScenePool pool;
}