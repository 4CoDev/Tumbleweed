namespace Tumbleweed.Measurement.Spatials;

public sealed class Positive<T> : SpatialEnvelope<T> where T : struct
{
	public Positive(ISpatial<T> spatial) : base
	(
		new Spatial<T>(
			new Linears.Positive<T>(spatial.X),
			new Linears.Positive<T>(spatial.Y),
			new Linears.Positive<T>(spatial.Z))
	)
	{
	}
}