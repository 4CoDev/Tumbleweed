namespace Tumbleweed.Numerics.Spatial;

public abstract class SpatialEnvelope<T> : ISpatial<T>
{
	protected SpatialEnvelope(ISpatial<T> spatial) =>
		this.spatial = spatial;

	public T X => spatial.X;

	public T Y => spatial.Y;

	public T Z => spatial.Z;

	private readonly ISpatial<T> spatial;
}