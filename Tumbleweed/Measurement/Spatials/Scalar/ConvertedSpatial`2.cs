using Tumbleweed.Scalars;

namespace Tumbleweed.Measurement.Spatials.Scalar;

public sealed class ConvertedSpatial<TFrom, TTo> : IScalar<ISpatial<TTo>>
	where TFrom : struct
	where TTo : struct
{
	public ConvertedSpatial(ISpatial<TFrom> spatial)
	{
		this.spatial = spatial;
	}

	public ISpatial<TTo> Value()
	{
		return new Spatial<TTo>(
			(TTo)(dynamic) spatial.X,
			(TTo)(dynamic) spatial.Y,
			(TTo)(dynamic) spatial.Z);
	}

	private readonly ISpatial<TFrom> spatial;
}