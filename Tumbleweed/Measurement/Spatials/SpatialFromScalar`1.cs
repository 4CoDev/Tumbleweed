using Tumbleweed.Scalars;

namespace Tumbleweed.Measurement.Spatials;

public sealed class SpatialFromScalar<T> : ISpatial<T>
	where T : struct
{
	public SpatialFromScalar(IScalar<ISpatial<T>> scalarSpatial)
	{
		this.scalarSpatial = scalarSpatial;
	}
	
	public T X
	{
		get => scalarSpatial.Value().X;
	}

	public T Y
	{
		get => scalarSpatial.Value().Y;
	}

	public T Z
	{
		get => scalarSpatial.Value().Z;
	}
	
	private readonly IScalar<ISpatial<T>> scalarSpatial;
}