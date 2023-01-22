using Godot;
using Tumbleweed.Scalars;
using Tumbleweed.WithGodot.Transforms;

namespace Tumbleweed.Measurement.Spatials.Scalar;

public sealed class Transformed : IScalar<ISpatial<float>>
{
	public Transformed(ISpatial<float> spatial, IScalar<Transform3D> transform)
	{
		this.spatial = spatial;
		this.transform = transform;
	}
	
	public ISpatial<float> Value()
	{
		return new Spatials.SpatialFromVector3(
			new TranslatedTransform3DTo(spatial, transform).Value().origin);
	}
	
	private readonly ISpatial<float> spatial;
	
	private readonly IScalar<Transform3D> transform;
}