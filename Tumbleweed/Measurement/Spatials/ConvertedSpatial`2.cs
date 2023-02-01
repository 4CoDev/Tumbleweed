namespace Tumbleweed.Measurement.Spatials;

public sealed class ConvertedSpatial<TFrom, TTo> : SpatialEnvelope<TTo>
	where TFrom : struct
	where TTo : struct
{
	public ConvertedSpatial(ISpatial<TFrom> spatial) : base
	(
		new SpatialFromScalar<TTo>(
			new Scalar.ConvertedSpatial<TFrom, TTo>(spatial))
	)
	{
	}
}