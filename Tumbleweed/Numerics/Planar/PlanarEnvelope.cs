namespace Tumbleweed.Numerics.Planar;

public abstract class PlanarEnvelope<T> : IPlanar<T>
{
	protected PlanarEnvelope(IPlanar<T> planar)
	{
		this.planar = planar;
	}

	public T X
	{
		get => planar.X;
	}
	
	public T Y
	{
		get => planar.Y;
	}
	
	private readonly IPlanar<T> planar;
}