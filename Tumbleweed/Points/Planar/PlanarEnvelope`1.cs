namespace Tumbleweed.Points.Planar;

public abstract class PlanarEnvelope<T> : IPlanar<T>
{
	protected PlanarEnvelope(IPlanar<T> planar)
	{
		this.planar = planar;
	}

	public T X => planar.X;

	public T Y => planar.Y;

	private readonly IPlanar<T> planar;
}