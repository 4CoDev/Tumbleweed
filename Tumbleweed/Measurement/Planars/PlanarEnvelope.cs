namespace Tumbleweed.Measurement.Planars;

public abstract class PlanarEnvelope<T> : IPlanar<T> where T : struct
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