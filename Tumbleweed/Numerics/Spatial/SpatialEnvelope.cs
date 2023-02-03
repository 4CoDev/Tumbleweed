namespace Tumbleweed.Numerics.Spatial;

public abstract class SpatialEnvelope<T> : ISpatial<T>
{
	protected SpatialEnvelope(ISpatial<T> spatial)
	{
		this.spatial = spatial;
	}

	public T X
	{
		get => spatial.X;
	}
	
	public T Y
	{
		get => spatial.Y;
	}
	
	public T Z
	{
		get => spatial.Z;
	}
	
	private readonly ISpatial<T> spatial;
}